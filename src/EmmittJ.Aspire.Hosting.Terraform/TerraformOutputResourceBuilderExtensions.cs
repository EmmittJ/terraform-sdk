// Licensed under the MIT License.

using Aspire.Hosting;
using Aspire.Hosting.ApplicationModel;
using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Aspire.Hosting.Terraform;

/// <summary>
/// Provides extension methods for adding Terraform output resources to an application.
/// </summary>
public static class TerraformOutputResourceBuilderExtensions
{
    /// <summary>
    /// Adds a Terraform output resource to the application.
    /// </summary>
    /// <param name="builder">Distributed application builder.</param>
    /// <param name="name">Name of the output resource.</param>
    /// <param name="sensitive">Whether the output contains sensitive data.</param>
    /// <returns>A resource builder for the Terraform output.</returns>
    /// <remarks>
    /// <para>
    /// This method creates an output resource that can be produced by one resource and consumed
    /// by others. The output is defined at the builder level, making it easy to share between
    /// different parts of the application.
    /// </para>
    /// <example>
    /// <code>
    /// // Define outputs at the builder level
    /// var redisConnectionString = builder.AddTerraformOutput("redis-connection-string", sensitive: true);
    /// var redisHostname = builder.AddTerraformOutput("redis-hostname");
    ///
    /// // Associate with producer and define the actual value
    /// cache.PublishAsTerraform(infra =>
    /// {
    ///     var redis = new AzurermRedisCache(...);
    ///     infra.Add(redis);
    ///     infra.Add(redisConnectionString.AsOutput(infra, redis.PrimaryConnectionString));
    ///     infra.Add(redisHostname.AsOutput(infra, redis.Hostname));
    /// });
    ///
    /// // Consume in another resource
    /// api.PublishAsTerraform(infra =>
    /// {
    ///     var connStr = redisConnectionString.AsVariable(infra);
    /// });
    /// </code>
    /// </example>
    /// </remarks>
    public static IResourceBuilder<TerraformOutputResource> AddTerraformOutput(
        this IDistributedApplicationBuilder builder,
        string name,
        bool sensitive = false)
    {
        ArgumentNullException.ThrowIfNull(builder);
        ArgumentException.ThrowIfNullOrEmpty(name);

        var resource = new TerraformOutputResource(name, sensitive);
        return builder.AddResource(resource);
    }
}

/// <summary>
/// Provides extension methods for <see cref="IResourceBuilder{TerraformOutputResource}"/>.
/// </summary>
public static class TerraformOutputResourceExtensions
{
    /// <summary>
    /// Associates this output with the resource that produces its value.
    /// </summary>
    /// <typeparam name="T">The type of the producer resource.</typeparam>
    /// <param name="builder">The output resource builder.</param>
    /// <param name="producer">The resource that produces this output value.</param>
    /// <returns>The resource builder for chaining.</returns>
    /// <example>
    /// <code>
    /// var redisConnectionString = builder.AddTerraformOutput("redis-connection-string", sensitive: true)
    ///     .ProducedBy(cache);
    /// </code>
    /// </example>
    public static IResourceBuilder<TerraformOutputResource> ProducedBy<T>(
        this IResourceBuilder<TerraformOutputResource> builder,
        IResourceBuilder<T> producer)
        where T : IResource
    {
        ArgumentNullException.ThrowIfNull(builder);
        ArgumentNullException.ThrowIfNull(producer);

        builder.Resource.Producer = producer.Resource;
        return builder;
    }

    /// <summary>
    /// Creates a <see cref="TerraformOutput"/> from this output resource with the specified value.
    /// Use this method in the producer resource's PublishAsTerraform callback to define the output.
    /// </summary>
    /// <param name="builder">The output resource builder.</param>
    /// <param name="infrastructure">The infrastructure context for the current resource.</param>
    /// <param name="value">The value expression for the output.</param>
    /// <param name="description">Optional description for the output.</param>
    /// <returns>A <see cref="TerraformOutput"/> that should be added to the infrastructure.</returns>
    /// <remarks>
    /// This method also sets the producer resource to the current infrastructure's resource.
    /// </remarks>
    /// <example>
    /// <code>
    /// cache.PublishAsTerraform(infra =>
    /// {
    ///     var redis = new AzurermRedisCache(...);
    ///     infra.Add(redis);
    ///     infra.Add(redisConnectionString.AsOutput(infra, redis.PrimaryConnectionString));
    /// });
    /// </code>
    /// </example>
    public static TerraformOutput AsOutput(
        this IResourceBuilder<TerraformOutputResource> builder,
        TerraformResourceInfrastructure infrastructure,
        TerraformValue<object> value,
        string? description = null)
    {
        ArgumentNullException.ThrowIfNull(builder);
        ArgumentNullException.ThrowIfNull(infrastructure);
        ArgumentNullException.ThrowIfNull(value);

        // Set the producer to the current infrastructure's resource
        builder.Resource.Producer = infrastructure.Resource;

        var output = new TerraformOutput(builder.Resource.Name)
        {
            Value = value,
            Sensitive = builder.Resource.Sensitive ? true : null
        };

        if (description is not null)
        {
            output.Description = description;
        }

        return output;
    }

    /// <summary>
    /// Converts this Terraform output resource to a variable in the current module.
    /// This enables consuming outputs from other modules as input variables.
    /// </summary>
    /// <param name="builder">The output resource builder.</param>
    /// <param name="infrastructure">The infrastructure context for the current resource.</param>
    /// <param name="variableName">Optional custom name for the variable. If not provided, uses the output resource name.</param>
    /// <returns>A <see cref="TerraformVariable"/> that can be used in resource configurations.</returns>
    /// <remarks>
    /// This method registers the output as an input dependency and creates a variable
    /// in the module's Terraform configuration. The publishing context will later wire this variable
    /// to the module block in the root main.tf file.
    /// <para>
    /// If the output resource was created with <c>sensitive: true</c>, the generated variable
    /// will also be marked as sensitive.
    /// </para>
    /// </remarks>
    /// <example>
    /// <code>
    /// api.PublishAsTerraform(infra =>
    /// {
    ///     var connStr = redisConnectionString.AsVariable(infra);
    ///     var containerApp = new AzurermContainerApp("api")
    ///     {
    ///         Secret = [new () { Name = "redis", Value = connStr.AsReference() }]
    ///     };
    /// });
    /// </code>
    /// </example>
    public static TerraformVariable AsVariable(
        this IResourceBuilder<TerraformOutputResource> builder,
        TerraformResourceInfrastructure infrastructure,
        string? variableName = null)
    {
        ArgumentNullException.ThrowIfNull(builder);
        ArgumentNullException.ThrowIfNull(infrastructure);

        var outputResource = builder.Resource;

        // Require that a producer has been set
        if (outputResource.Producer is null)
        {
            throw new InvalidOperationException(
                $"Cannot create a variable from output '{outputResource.Name}' because no producer resource has been set. " +
                $"Call AsOutput() in the producer's PublishAsTerraform callback first, or use ProducedBy() to associate with a producer.");
        }

        // Generate variable name from output resource if not provided
        variableName ??= $"{outputResource.Producer.Name}_{outputResource.Name}";

        // Register this output resource as an input dependency
        infrastructure.Inputs[variableName] = outputResource;

        // Get or create the variable in the stack
        if (!infrastructure.Parameters.TryGetValue(variableName, out var variable))
        {
            variable = new TerraformVariable(variableName)
            {
                Type = "string",
                Sensitive = outputResource.Sensitive ? true : null
            };
            infrastructure.Parameters[variableName] = variable;
            infrastructure.Stack.Add(variable);
        }

        return variable;
    }
}
