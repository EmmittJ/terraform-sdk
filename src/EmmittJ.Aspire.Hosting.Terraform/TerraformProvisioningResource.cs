// Licensed under the MIT License.

using Aspire.Hosting;
using Aspire.Hosting.ApplicationModel;
using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Aspire.Hosting.Terraform;

/// <summary>
/// Represents an Aspire resource that will be deployed via Terraform.
/// This resource wraps an existing Aspire resource and provides methods for configuring
/// the Terraform infrastructure, including adding blocks, outputs, and variables.
/// </summary>
/// <remarks>
/// <para>
/// This class serves as both the deployment target (similar to <c>DockerComposeServiceResource</c>)
/// and the configuration context (similar to <c>AzureResourceInfrastructure</c>). It provides
/// helper methods for building Terraform configurations and managing dependencies between resources.
/// </para>
/// <example>
/// <code>
/// resource.PublishAsTerraform(terraform =>
/// {
///     // Reference another resource's output
///     var redisHost = terraform.AddVariable(redisResource.HostnameOutput);
///
///     // Create Terraform resources using the SDK
///     var container = new AzurermContainerApp("api")
///     {
///         EnvironmentVariables = new()
///         {
///             ["REDIS_HOST"] = redisHost
///         }
///     };
///
///     terraform.Add(container);
/// });
/// </code>
/// </example>
/// </remarks>
public sealed class TerraformProvisioningResource : Resource, IResourceWithParent<TerraformEnvironmentResource>
{
    /// <summary>
    /// Gets the target Aspire resource that this Terraform resource represents, if any.
    /// </summary>
    public IResource? TargetResource { get; }

    /// <summary>
    /// Gets the Terraform environment this resource belongs to.
    /// </summary>
    public TerraformEnvironmentResource Parent { get; }

    /// <summary>
    /// Gets the Terraform stack where resources should be added.
    /// </summary>
    public TerraformStack Stack { get; }

    /// <summary>
    /// Gets the dictionary of input dependencies for this resource.
    /// Keys are input names, values are source objects (TerraformOutputReference, ParameterResource, etc.)
    /// </summary>
    internal Dictionary<string, object> Inputs { get; } = [];

    /// <summary>
    /// Gets the dictionary of Terraform outputs produced by this resource.
    /// Keys are output names (case-insensitive), values are the output values.
    /// This dictionary is populated after Terraform apply completes.
    /// </summary>
    internal Dictionary<string, object?> Outputs { get; } = new(StringComparer.OrdinalIgnoreCase);

    /// <summary>
    /// Gets the dictionary of variables created for this module's inputs.
    /// </summary>
    internal Dictionary<string, TerraformVariable> Parameters { get; } = [];

    /// <summary>
    /// Initializes a new instance of the <see cref="TerraformProvisioningResource"/> class.
    /// </summary>
    /// <param name="name">The name of the Terraform resource.</param>
    /// <param name="environment">The Terraform environment this resource belongs to.</param>
    /// <param name="targetResource">The target Aspire resource, or <c>null</c> if this is a standalone Terraform resource.</param>
    internal TerraformProvisioningResource(string name, TerraformEnvironmentResource environment, IResource? targetResource = null)
        : base(name)
    {
        Parent = environment ?? throw new ArgumentNullException(nameof(environment));
        TargetResource = targetResource;
        Stack = new TerraformStack();
    }

    /// <summary>
    /// Adds a Terraform block to the stack.
    /// </summary>
    /// <param name="block">The Terraform block to add.</param>
    public void Add(TerraformBlock block)
    {
        ArgumentNullException.ThrowIfNull(block);
        Stack.Add(block);
    }

    /// <summary>
    /// Creates a Terraform output for the specified output reference and adds it to the stack.
    /// </summary>
    /// <param name="outputReference">The output reference that defines the output name and sensitivity.</param>
    /// <param name="value">The value expression for the output.</param>
    /// <param name="description">Optional description for the output.</param>
    /// <returns>The created <see cref="TerraformOutput"/> that was added to the stack.</returns>
    /// <remarks>
    /// This method creates an output in the current module that can be consumed by other resources
    /// via <see cref="AddVariable(TerraformOutputReference, string?)"/>. The output name comes from the <see cref="TerraformOutputReference.Name"/>.
    /// </remarks>
    /// <example>
    /// <code>
    /// var connectionString = new TerraformOutputReference("connection-string", cache.Resource, sensitive: true);
    ///
    /// cache.PublishAsTerraform(terraform =>
    /// {
    ///     var redis = new AzurermRedisCache("cache") { ... };
    ///     terraform.Add(redis);
    ///     terraform.AddOutput(connectionString, redis.PrimaryConnectionString);
    /// });
    /// </code>
    /// </example>
    public TerraformOutput AddOutput(TerraformOutputReference outputReference, TerraformValue<object> value, string? description = null)
    {
        ArgumentNullException.ThrowIfNull(outputReference);
        ArgumentNullException.ThrowIfNull(value);

        var output = new TerraformOutput(outputReference.Name)
        {
            Value = value,
            Sensitive = outputReference.Sensitive ? true : null,
        };

        if (description is not null)
        {
            output.Description = description;
        }

        Stack.Add(output);
        return output;
    }

    /// <summary>
    /// Creates a Terraform variable for consuming the specified output reference and adds it to the stack.
    /// </summary>
    /// <param name="outputReference">The output reference to consume as a variable.</param>
    /// <param name="variableName">Optional custom name for the variable. If not provided, a name is generated from the output reference.</param>
    /// <returns>The created <see cref="TerraformVariable"/> that was added to the stack.</returns>
    /// <remarks>
    /// <para>
    /// This method creates an input variable in the current module that will receive its value
    /// from the output defined by <paramref name="outputReference"/>. The publishing context
    /// will wire up the module block to pass the output value to this variable.
    /// </para>
    /// <para>
    /// If the output reference was created with <c>sensitive: true</c>, the variable will also
    /// be marked as sensitive.
    /// </para>
    /// </remarks>
    /// <example>
    /// <code>
    /// var connectionString = new TerraformOutputReference("connection-string", cache.Resource, sensitive: true);
    ///
    /// api.PublishAsTerraform(terraform =>
    /// {
    ///     var connVar = terraform.AddVariable(connectionString);
    ///     var containerApp = new AzurermContainerApp("api")
    ///     {
    ///         Secret = [new() { Name = "conn", Value = connVar.AsReference() }]
    ///     };
    ///     terraform.Add(containerApp);
    /// });
    /// </code>
    /// </example>
    public TerraformVariable AddVariable(TerraformOutputReference outputReference, string? variableName = null)
    {
        ArgumentNullException.ThrowIfNull(outputReference);

        // Generate variable name from output reference if not provided
        variableName ??= $"{outputReference.Resource.Name}_{outputReference.Name}".Replace("-", "_");

        // Check if we already have this variable
        if (Parameters.TryGetValue(variableName, out var existingVariable))
        {
            return existingVariable;
        }

        // Register this output reference as an input dependency
        Inputs[variableName] = outputReference;

        // Create the variable
        var variable = new TerraformVariable(variableName)
        {
            Type = "string",
            Sensitive = outputReference.Sensitive ? true : null
        };

        Parameters[variableName] = variable;
        Stack.Add(variable);

        return variable;
    }

    /// <summary>
    /// Creates a Terraform variable for the specified Aspire parameter and adds it to the stack.
    /// </summary>
    /// <param name="parameterResource">The parameter resource to convert to a variable.</param>
    /// <param name="variableName">Optional custom name for the variable. If not provided, uses the parameter's name.</param>
    /// <returns>The created <see cref="TerraformVariable"/> that was added to the stack.</returns>
    /// <remarks>
    /// <para>
    /// This method creates a Terraform variable for an Aspire parameter, maintaining the secret
    /// flag and other metadata. The parameter value will be provided at deployment time through
    /// Terraform's standard variable mechanisms (tfvars, environment variables, etc.).
    /// </para>
    /// </remarks>
    /// <example>
    /// <code>
    /// var password = builder.AddParameter("postgres-password", secret: true);
    ///
    /// db.PublishAsTerraform(terraform =>
    /// {
    ///     var passwordVar = terraform.AddVariable(password);
    ///     var server = new AzurermPostgresqlFlexibleServer("postgres")
    ///     {
    ///         AdministratorPassword = passwordVar.AsReference()
    ///     };
    ///     terraform.Add(server);
    /// });
    /// </code>
    /// </example>
    public TerraformVariable AddVariable(ParameterResource parameterResource, string? variableName = null)
    {
        ArgumentNullException.ThrowIfNull(parameterResource);

        // Use parameter name as variable name if not provided
        variableName ??= parameterResource.Name.Replace("-", "_");

        // Check if we already have this variable
        if (Parameters.TryGetValue(variableName, out var existingVariable))
        {
            return existingVariable;
        }

        // Register this parameter as an input dependency
        Inputs[variableName] = parameterResource;

        // Create the variable
        var variable = new TerraformVariable(variableName)
        {
            Type = "string",
            Description = parameterResource.Description ?? $"Parameter '{parameterResource.Name}'",
            Sensitive = parameterResource.Secret
        };

        Parameters[variableName] = variable;
        Stack.Add(variable);

        // Register on the environment for runtime resolution during plan/apply
        Parent.ParameterVariables[parameterResource] = variable;

        return variable;
    }

    /// <summary>
    /// Creates a Terraform variable for the specified Aspire parameter builder and adds it to the stack.
    /// </summary>
    /// <param name="parameterBuilder">The parameter resource builder.</param>
    /// <param name="variableName">Optional custom name for the variable. If not provided, uses the parameter's name.</param>
    /// <returns>The created <see cref="TerraformVariable"/> that was added to the stack.</returns>
    public TerraformVariable AddVariable(IResourceBuilder<ParameterResource> parameterBuilder, string? variableName = null)
    {
        ArgumentNullException.ThrowIfNull(parameterBuilder);
        return AddVariable(parameterBuilder.Resource, variableName);
    }
}
