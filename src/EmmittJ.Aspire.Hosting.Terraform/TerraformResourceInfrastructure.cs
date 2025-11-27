// Licensed under the MIT License.

using Aspire.Hosting;
using Aspire.Hosting.ApplicationModel;
using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Aspire.Hosting.Terraform;

/// <summary>
/// Provides context for configuring Terraform infrastructure for a specific resource.
/// This context is passed to resource configuration callbacks and provides access to the
/// Terraform stack, the Aspire resource being configured, and infrastructure helpers.
/// </summary>
/// <remarks>
/// Similar to Aspire's AzureResourceInfrastructure for Bicep publishing, this context
/// enables resources to declare dependencies on other resources' outputs and automatically
/// handles the conversion to Terraform module variables.
/// <example>
/// <code>
/// resource.PublishAsTerraform(infra =>
/// {
///     // Reference another resource's output
///     var redisHost = infra.AddVariable(redisResource.HostnameOutput);
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
///     infra.Add(container);
/// });
/// </code>
/// </example>
/// </remarks>
public sealed class TerraformResourceInfrastructure
{
    /// <summary>
    /// Gets the Aspire resource that this infrastructure configuration represents.
    /// </summary>
    public IResource Resource { get; }

    /// <summary>
    /// Gets the Terraform stack where resources should be added.
    /// </summary>
    public TerraformStack Stack { get; }

    /// <summary>
    /// Gets the dictionary of input parameters for this module.
    /// Keys are parameter names, values are the source objects (TerraformOutputReference, ParameterResource, etc.)
    /// </summary>
    internal Dictionary<string, object> Inputs { get; } = new();

    /// <summary>
    /// Gets the dictionary of variables created for this module's inputs.
    /// </summary>
    internal Dictionary<string, TerraformVariable> Parameters { get; } = new();

    /// <summary>
    /// Gets the Terraform resource wrapper if this is a compute resource.
    /// </summary>
    internal TerraformResource? TerraformResource { get; }

    /// <summary>
    /// Initializes a new instance of TerraformResourceInfrastructure.
    /// </summary>
    /// <param name="resource">The Aspire resource being configured.</param>
    /// <param name="stack">The Terraform stack for this resource.</param>
    /// <param name="terraformResource">Optional Terraform resource wrapper.</param>
    internal TerraformResourceInfrastructure(
        IResource resource,
        TerraformStack stack,
        TerraformResource? terraformResource = null)
    {
        Resource = resource ?? throw new ArgumentNullException(nameof(resource));
        Stack = stack ?? throw new ArgumentNullException(nameof(stack));
        TerraformResource = terraformResource;
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
    /// cache.PublishAsTerraform(infra =>
    /// {
    ///     var redis = new AzurermRedisCache("cache") { ... };
    ///     infra.Add(redis);
    ///     infra.AddOutput(connectionString, redis.PrimaryConnectionString);
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
    /// api.PublishAsTerraform(infra =>
    /// {
    ///     var connVar = infra.AddVariable(connectionString);
    ///     var containerApp = new AzurermContainerApp("api")
    ///     {
    ///         Secret = [new() { Name = "conn", Value = connVar.AsReference() }]
    ///     };
    ///     infra.Add(containerApp);
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
    /// db.PublishAsTerraform(infra =>
    /// {
    ///     var passwordVar = infra.AddVariable(password);
    ///     var server = new AzurermPostgresqlFlexibleServer("postgres")
    ///     {
    ///         AdministratorPassword = passwordVar.AsReference()
    ///     };
    ///     infra.Add(server);
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
        var environment = TerraformResource?.Parent ?? (Resource as TerraformEnvironmentResource);

        if (environment is not null)
        {
            environment.ParameterVariables[parameterResource] = variable;
        }

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
