// Licensed under the MIT License.

using Aspire.Hosting;
using Aspire.Hosting.ApplicationModel;
using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Aspire.Hosting.Terraform;

/// <summary>
/// A reference to an output from a Terraform resource.
/// </summary>
/// <remarks>
/// <para>
/// This class follows the same pattern as <c>BicepOutputReference</c> in Aspire's Azure hosting.
/// It represents a reference to a specific output from a resource that will be deployed via Terraform.
/// </para>
/// <para>
/// Outputs can be retrieved using the <see cref="TerraformOutputReferenceExtensions.GetTerraformOutput"/> extension method:
/// <code>
/// var redis = builder.AddRedis("cache")
///     .PublishAsTerraform(infra =>
///     {
///         var cache = new AzurermRedisCache("cache") { ... };
///         infra.Add(cache);
///         infra.Add(new TerraformOutput("connection_string") { Value = cache.PrimaryConnectionString });
///     });
///
/// var connectionString = redis.GetOutput("connection_string");
///
/// // Use the output in another resource
/// api.WithEnvironment("REDIS_CONNECTION", connectionString);
/// </code>
/// </para>
/// <para>
/// Resources can also expose outputs as properties on their resource class:
/// <code>
/// public class MyTerraformResource : Resource
/// {
///     public TerraformOutputReference ConnectionString => new("connection_string", this);
///     public TerraformOutputReference Hostname => new("hostname", this);
/// }
/// </code>
/// </para>
/// </remarks>
/// <param name="name">The name of the output.</param>
/// <param name="resource">The resource that produces this output.</param>
/// <param name="sensitive">Whether this output contains sensitive data.</param>
public sealed class TerraformOutputReference(string name, IResource resource, bool sensitive = false)
    : IManifestExpressionProvider, IValueProvider, IValueWithReferences, IEquatable<TerraformOutputReference>
{
    /// <summary>
    /// Gets the name of the output.
    /// </summary>
    public string Name { get; } = name ?? throw new ArgumentNullException(nameof(name));

    /// <summary>
    /// Gets the resource that produces this output.
    /// </summary>
    public IResource Resource { get; } = resource ?? throw new ArgumentNullException(nameof(resource));

    /// <summary>
    /// Gets a value indicating whether this output contains sensitive data.
    /// </summary>
    public bool Sensitive { get; } = sensitive;

    /// <summary>
    /// Gets the references for this output, which includes the resource that produces it.
    /// </summary>
    IEnumerable<object> IValueWithReferences.References => [Resource];

    /// <summary>
    /// Gets the value of the output asynchronously.
    /// </summary>
    /// <param name="cancellationToken">A <see cref="CancellationToken"/> to observe while waiting for the task to complete.</param>
    /// <returns>The value of the output, or <c>null</c> if not available.</returns>
    /// <remarks>
    /// <para>
    /// This method waits for the Terraform provisioning to complete before returning the output value.
    /// The outputs are populated after Terraform apply completes with the actual output values.
    /// </para>
    /// <para>
    /// During local development (dotnet run), Terraform outputs may not be available and this
    /// method will throw an exception.
    /// </para>
    /// </remarks>
    public async ValueTask<string?> GetValueAsync(CancellationToken cancellationToken = default)
    {
        var outputsAnnotation = GetOutputsAnnotation();
        var provisioning = outputsAnnotation?.ProvisioningTaskCompletionSource;
        if (provisioning is not null)
        {
            await provisioning.Task.WaitAsync(cancellationToken).ConfigureAwait(false);
        }

        return Value;
    }

    /// <summary>
    /// Gets the current value of the output.
    /// </summary>
    /// <remarks>
    /// The value is retrieved from the resource's <see cref="TerraformOutputsAnnotation"/>.
    /// </remarks>
    /// <exception cref="InvalidOperationException">Thrown when no output with the specified name exists.</exception>
    public string? Value
    {
        get
        {
            var outputsAnnotation = GetOutputsAnnotation();
            if (outputsAnnotation is null)
            {
                throw new InvalidOperationException(
                    $"No Terraform outputs found for resource '{Resource.Name}'. " +
                    $"Ensure the resource has been configured with PublishAsTerraform().");
            }

            if (!outputsAnnotation.Outputs.TryGetValue(Name, out var value))
            {
                throw new InvalidOperationException($"No output for '{Name}' on resource '{Resource.Name}'.");
            }

            return value?.ToString();
        }
    }

    /// <summary>
    /// Gets the <see cref="TerraformOutputsAnnotation"/> for this resource.
    /// </summary>
    private TerraformOutputsAnnotation? GetOutputsAnnotation()
    {
        // Check for outputs annotation directly on the resource
        if (Resource.TryGetAnnotationsOfType<TerraformOutputsAnnotation>(out var annotations))
        {
            return annotations.FirstOrDefault();
        }

        return null;
    }

    /// <summary>
    /// Gets the expression used in the manifest to reference the value of the output.
    /// </summary>
    /// <remarks>
    /// The expression format is <c>{resourceName.outputs.outputName}</c>, which follows
    /// the same pattern as Bicep output references.
    /// </remarks>
    public string ValueExpression => $"{{{Resource.Name}.outputs.{Name}}}";

    /// <summary>
    /// Determines whether the specified <see cref="TerraformOutputReference"/> is equal to this instance.
    /// </summary>
    /// <param name="other">The other output reference to compare.</param>
    /// <returns><c>true</c> if the references are equal; otherwise, <c>false</c>.</returns>
    public bool Equals(TerraformOutputReference? other) =>
        other is not null &&
        other.Resource == Resource &&
        other.Name == Name;

    /// <inheritdoc/>
    public override bool Equals(object? obj) => Equals(obj as TerraformOutputReference);

    /// <inheritdoc/>
    public override int GetHashCode() => HashCode.Combine(Resource, Name);
}

/// <summary>
/// Provides extension methods for working with <see cref="TerraformOutputReference"/>.
/// </summary>
public static class TerraformOutputReferenceExtensions
{
    /// <summary>
    /// Gets a reference to an output from a Terraform resource.
    /// </summary>
    /// <typeparam name="T">The type of resource.</typeparam>
    /// <param name="builder">The resource builder.</param>
    /// <param name="name">The name of the output.</param>
    /// <param name="sensitive">Whether this output contains sensitive data.</param>
    /// <returns>A <see cref="TerraformOutputReference"/> that represents the output.</returns>
    /// <remarks>
    /// The output must be defined in the resource's <see cref="TerraformExtensions.PublishAsTerraform"/> callback
    /// by adding a <see cref="EmmittJ.Terraform.Sdk.TerraformOutput"/> to the infrastructure.
    /// </remarks>
    /// <example>
    /// <code>
    /// var redis = builder.AddRedis("cache")
    ///     .PublishAsTerraform(infra =>
    ///     {
    ///         var cache = new AzurermRedisCache("cache") { ... };
    ///         infra.Add(cache);
    ///         infra.Add(new TerraformOutput("connection_string") { Value = cache.PrimaryConnectionString });
    ///     });
    ///
    /// var connectionString = redis.GetOutput("connection_string");
    /// api.WithEnvironment("REDIS_CONNECTION", connectionString);
    /// </code>
    /// </example>
    public static TerraformOutputReference GetTerraformOutput<T>(this IResourceBuilder<T> builder, string name, bool sensitive = false)
        where T : IResource
    {
        ArgumentNullException.ThrowIfNull(builder);
        ArgumentException.ThrowIfNullOrEmpty(name);

        return new TerraformOutputReference(name, builder.Resource, sensitive);
    }

    /// <summary>
    /// Gets a reference to an output from a Terraform resource.
    /// </summary>
    /// <param name="resource">The resource that produces this output.</param>
    /// <param name="name">The name of the output.</param>
    /// <param name="sensitive">Whether this output contains sensitive data.</param>
    /// <returns>A <see cref="TerraformOutputReference"/> that represents the output.</returns>
    /// <remarks>
    /// The output must be defined in the resource's <see cref="TerraformExtensions.PublishAsTerraform"/> callback
    /// by adding a <see cref="EmmittJ.Terraform.Sdk.TerraformOutput"/> to the infrastructure.
    /// </remarks>
    /// <example>
    /// <code>
    /// var azure = builder.AddTerraformEnvironment("azure");
    ///
    /// // Get a reference to an output that will be defined in the environment's PublishAsTerraform callback
    /// var containerEnvId = azure.Resource.GetOutput("container-env-id");
    ///
    /// azure.PublishAsTerraform(infra =>
    /// {
    ///     var containerEnv = new AzurermContainerAppEnvironment("container-env") { ... };
    ///     infra.Add(containerEnv);
    ///     infra.Add(new TerraformOutput("container-env-id") { Value = containerEnv.Id });
    /// });
    /// </code>
    /// </example>
    public static TerraformOutputReference GetTerraformOutput(this IResource resource, string name, bool sensitive = false)
    {
        ArgumentNullException.ThrowIfNull(resource);
        ArgumentException.ThrowIfNullOrEmpty(name);

        return new TerraformOutputReference(name, resource, sensitive);
    }
}
