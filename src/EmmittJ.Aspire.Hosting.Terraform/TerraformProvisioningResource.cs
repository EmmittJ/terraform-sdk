// Licensed under the MIT License.

#pragma warning disable ASPIREPIPELINES001
#pragma warning disable ASPIREPIPELINES003

using Aspire.Hosting;
using Aspire.Hosting.ApplicationModel;
using Aspire.Hosting.Pipelines;
using Aspire.Hosting.Publishing;
using EmmittJ.Terraform.Sdk;
using Microsoft.Extensions.DependencyInjection;

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
public sealed class TerraformProvisioningResource : Resource
{
    /// <summary>
    /// Gets the target Aspire resource that this Terraform resource represents, if any.
    /// </summary>
    public IResource? TargetResource { get; }

    /// <summary>
    /// Gets the Terraform environment this resource belongs to.
    /// </summary>
    public ITerraformEnvironment Environment { get; }

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
    /// Gets or sets the <see cref="TerraformOutputsAnnotation"/> for the target resource.
    /// This annotation stores outputs directly on the target resource for easy access.
    /// </summary>
    internal TerraformOutputsAnnotation? OutputsAnnotation { get; set; }

    /// <summary>
    /// Gets the dictionary of variables created for this module's inputs.
    /// </summary>
    internal Dictionary<string, TerraformVariable> Parameters { get; } = [];

    // Lazy-initialized backing fields for container properties
    private TerraformVariable? _containerImage;
    private TerraformVariable? _registryEndpoint;
    private TerraformVariable? _registryName;

    /// <summary>
    /// Gets the container image variable for this resource. Auto-creates on first access.
    /// </summary>
    /// <exception cref="InvalidOperationException">
    /// Thrown if the target resource doesn't require image build/push.
    /// </exception>
    /// <remarks>
    /// <para>
    /// This property provides lazy access to the container image variable. The variable is created
    /// on first access and reused for subsequent accesses. This is equivalent to calling
    /// <see cref="GetContainerImage()"/> but with property syntax for cleaner code.
    /// </para>
    /// </remarks>
    /// <example>
    /// <code>
    /// app.PublishAsTerraform(infra =>
    /// {
    ///     var containerApp = new AzurermContainerApp("app")
    ///     {
    ///         Template = [new()
    ///         {
    ///             Container = [new()
    ///             {
    ///                 Name = "app",
    ///                 Image = infra.ContainerImage.AsReference()  // Lazy-creates variable
    ///             }]
    ///         }]
    ///     };
    ///     infra.Add(containerApp);
    /// });
    /// </code>
    /// </example>
    public TerraformVariable ContainerImage => _containerImage ??= GetContainerImage();

    /// <summary>
    /// Gets the registry endpoint variable. Auto-creates on first access.
    /// </summary>
    /// <exception cref="InvalidOperationException">
    /// Thrown if no container registry is configured for the environment.
    /// </exception>
    /// <remarks>
    /// <para>
    /// This property provides lazy access to the container registry endpoint variable. The variable
    /// is created on first access from the parent environment's container registry configuration.
    /// </para>
    /// </remarks>
    /// <example>
    /// <code>
    /// app.PublishAsTerraform(infra =>
    /// {
    ///     var containerApp = new AzurermContainerApp("app")
    ///     {
    ///         Registry = [new()
    ///         {
    ///             Server = infra.RegistryEndpoint.AsReference()  // Lazy-creates variable
    ///         }]
    ///     };
    ///     infra.Add(containerApp);
    /// });
    /// </code>
    /// </example>
    public TerraformVariable RegistryEndpoint => _registryEndpoint ??= CreateRegistryEndpointVariable();

    /// <summary>
    /// Gets the registry name variable. Auto-creates on first access.
    /// </summary>
    /// <exception cref="InvalidOperationException">
    /// Thrown if no container registry is configured for the environment.
    /// </exception>
    /// <remarks>
    /// <para>
    /// This property provides lazy access to the container registry name variable. The variable
    /// is created on first access from the parent environment's container registry configuration.
    /// </para>
    /// </remarks>
    /// <example>
    /// <code>
    /// app.PublishAsTerraform(infra =>
    /// {
    ///     // Use registry name for data source lookups
    ///     var acrDataSource = new TerraformDataSource("azurerm_container_registry", "acr")
    ///     {
    ///         ["name"] = infra.RegistryName.AsReference()  // Lazy-creates variable
    ///     };
    ///     infra.Add(acrDataSource);
    /// });
    /// </code>
    /// </example>
    public TerraformVariable RegistryName => _registryName ??= CreateRegistryNameVariable();

    private TerraformVariable CreateRegistryEndpointVariable()
    {
        var endpoint = Environment.ContainerRegistryEndpoint()
            ?? throw new InvalidOperationException(
                $"No container registry configured for environment '{Environment.Name}'. " +
                "Use AddTerraformEnvironment(name, registry) to configure one.");

        return AddVariable(endpoint);
    }

    private TerraformVariable CreateRegistryNameVariable()
    {
        var name = Environment.ContainerRegistryName()
            ?? throw new InvalidOperationException(
                $"No container registry configured for environment '{Environment.Name}'. " +
                "Use AddTerraformEnvironment(name, registry) to configure one.");

        return AddVariable(name);
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="TerraformProvisioningResource"/> class.
    /// </summary>
    /// <param name="name">The name of the Terraform resource.</param>
    /// <param name="environment">The Terraform environment this resource belongs to.</param>
    /// <param name="targetResource">The target Aspire resource, or <c>null</c> if this is a standalone Terraform resource.</param>
    internal TerraformProvisioningResource(string name, ITerraformEnvironment environment, IResource? targetResource = null)
        : base(name)
    {
        Environment = environment ?? throw new ArgumentNullException(nameof(environment));
        TargetResource = targetResource;
        Stack = new TerraformStack();

        // Add pipeline step annotation for container image push (if this resource needs it)
        Annotations.Add(new PipelineStepAnnotation(CreatePipelineSteps));

        // Add pipeline configuration annotation to wire up dependencies
        Annotations.Add(new PipelineConfigurationAnnotation(ConfigurePipeline));
    }

    private IEnumerable<PipelineStep> CreatePipelineSteps(PipelineStepFactoryContext factoryContext)
    {
        // Only create push step if we have a target resource that needs image push
        if (TargetResource is null || !TargetResource.RequiresImageBuildAndPush())
        {
            return [];
        }

        // Get the registry from the target resource's deployment target annotation
        var deploymentTargetAnnotation = TargetResource.GetDeploymentTargetAnnotation();
        if (deploymentTargetAnnotation?.ContainerRegistry is not IContainerRegistry registry)
        {
            return [];
        }

        var steps = new List<PipelineStep>();

        // Create push step for this deployment target
        // Tagged with PushContainerImage so environments can hook into push steps
        var pushStep = new PipelineStep
        {
            Name = $"push-{TargetResource.Name}",
            Action = ctx => PushImageToRegistryAsync(registry, TargetResource, ctx),
            Tags = [WellKnownPipelineTags.PushContainerImage]
        };

        steps.Add(pushStep);

        return steps;
    }

    private static async Task PushImageToRegistryAsync(
        IContainerRegistry registry,
        IResource resource,
        PipelineStepContext context)
    {
        var containerImageBuilder = context.Services.GetRequiredService<IResourceContainerImageBuilder>();

        var registryEndpoint = await registry.Endpoint.GetValueAsync(context.CancellationToken).ConfigureAwait(false) ??
            throw new InvalidOperationException("Failed to retrieve container registry endpoint.");

        // Get the local image name (defaults to resource name)
        if (!resource.TryGetContainerImageName(out var localImageName))
        {
            localImageName = resource.Name.ToLowerInvariant();
        }

        // Get the target tag using ContainerImageReference
        IValueProvider cir = new ContainerImageReference(resource);
        var targetTag = await cir.GetValueAsync(context.CancellationToken).ConfigureAwait(false);

        var pushTask = await context.ReportingStep.CreateTaskAsync(
            $"Pushing **{resource.Name}** to **{registryEndpoint}**",
            context.CancellationToken).ConfigureAwait(false);

        await using (pushTask.ConfigureAwait(false))
        {
            try
            {
                if (targetTag is null)
                {
                    throw new InvalidOperationException($"Failed to get target tag for {resource.Name}");
                }

                await containerImageBuilder.TagImageAsync(localImageName, targetTag, context.CancellationToken).ConfigureAwait(false);
                await containerImageBuilder.PushImageAsync(targetTag, context.CancellationToken).ConfigureAwait(false);

                await pushTask.CompleteAsync(
                    $"Successfully pushed **{resource.Name}** to `{targetTag}`",
                    CompletionState.Completed,
                    context.CancellationToken).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                await pushTask.CompleteAsync(
                    $"Failed to push **{resource.Name}**: {ex.Message}",
                    CompletionState.CompletedWithError,
                    context.CancellationToken).ConfigureAwait(false);
                throw;
            }
        }
    }

    private void ConfigurePipeline(PipelineConfigurationContext context)
    {
        if (TargetResource is null)
        {
            return;
        }

        // Find the push step for this resource using tag
        var pushSteps = context.GetSteps(this, WellKnownPipelineTags.PushContainerImage);

        // Make push step depend on the Build meta-step which orchestrates all build operations
        pushSteps.DependsOn(WellKnownPipelineSteps.Build);

        // Make push step depend on the registry being provisioned
        var deploymentTargetAnnotation = TargetResource.GetDeploymentTargetAnnotation();
        if (deploymentTargetAnnotation?.ContainerRegistry is IResource registryResource)
        {
            var registryProvisionSteps = context.GetSteps(registryResource, WellKnownPipelineTags.ProvisionInfrastructure);
            pushSteps.DependsOn(registryProvisionSteps);
        }

        // Make environment terraform plan step depend on push steps
        // The plan step needs push to complete so it can reference the pushed images
        var envPlanSteps = context.GetSteps(Environment, TerraformPipelineTags.TerraformPlan);
        envPlanSteps.DependsOn(pushSteps);
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
    /// Creates a Terraform output with the specified name and value, and registers it for cross-resource reference.
    /// </summary>
    /// <param name="name">The name of the output.</param>
    /// <param name="value">The value expression for the output.</param>
    /// <param name="sensitive">Whether this output contains sensitive data.</param>
    /// <param name="description">Optional description for the output.</param>
    /// <returns>The created <see cref="TerraformOutput"/>.</returns>
    /// <remarks>
    /// This method creates both:
    /// <list type="bullet">
    /// <item>A <see cref="TerraformOutput"/> in the current stack</item>
    /// <item>A <see cref="TerraformOutputReference"/> on the parent environment for cross-resource consumption</item>
    /// </list>
    /// Other resources can consume this output via <see cref="AddVariable(string, string?)"/> or <c>Environment.GetTerraformOutput(name)</c>.
    /// </remarks>
    /// <example>
    /// <code>
    /// terraform.PublishAsTerraform(infra =>
    /// {
    ///     var containerAppEnvironment = new AzurermContainerAppEnvironment("cae") { ... };
    ///     infra.Add(containerAppEnvironment);
    ///
    ///     // Single method - creates reference and adds output internally
    ///     infra.AddOutput("container_env_id", containerAppEnvironment.Id);
    ///
    ///     // With sensitivity
    ///     infra.AddOutput("connection_string", db.ConnectionString, sensitive: true);
    /// });
    /// </code>
    /// </example>
    public TerraformOutput AddOutput(string name, TerraformValue<object> value, bool sensitive = false, string? description = null)
    {
        ArgumentException.ThrowIfNullOrEmpty(name);
        ArgumentNullException.ThrowIfNull(value);

        // Create the output reference for cross-resource consumption
        var outputRef = Environment.GetTerraformOutput(name, sensitive);

        // Delegate to existing method
        return AddOutput(outputRef, value, description);
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
    /// Creates a Terraform variable that imports an output from the parent environment.
    /// </summary>
    /// <param name="outputName">The name of the output to import from the parent environment.</param>
    /// <param name="variableName">Optional custom name for the variable. If not provided, derived from output name.</param>
    /// <returns>A <see cref="TerraformVariable"/> that receives the output value.</returns>
    /// <remarks>
    /// This is a convenience overload that combines <c>Environment.GetTerraformOutput(name)</c> with <c>AddVariable(outputRef)</c>.
    /// </remarks>
    /// <example>
    /// <code>
    /// app.PublishAsTerraform(infra =>
    /// {
    ///     // Single method - gets parent output and creates variable internally
    ///     var containerEnvIdVar = infra.AddVariable("container_env_id");
    ///     var managedIdentityIdVar = infra.AddVariable("managed_identity_id");
    ///     var resourceGroupVar = infra.AddVariable("resource_group_name");
    ///
    ///     var containerApp = new AzurermContainerApp("app")
    ///     {
    ///         ContainerAppEnvironmentId = containerEnvIdVar.AsReference()
    ///     };
    ///     infra.Add(containerApp);
    /// });
    /// </code>
    /// </example>
    public TerraformVariable AddVariable(string outputName, string? variableName = null)
    {
        ArgumentException.ThrowIfNullOrEmpty(outputName);

        var outputRef = Environment.GetTerraformOutput(outputName);

        return AddVariable(outputRef, variableName);
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
        Environment.ParameterVariables[parameterResource] = variable;

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

    /// <summary>
    /// Gets the output name for the specified endpoint reference using the standard naming convention.
    /// </summary>
    /// <param name="endpointReference">The endpoint reference to get the output name for.</param>
    /// <returns>The output name in the format <c>{endpoint_name}_endpoint</c>.</returns>
    /// <remarks>
    /// <para>
    /// This method returns the standard output name that should be used when exporting an endpoint.
    /// The naming convention matches what <see cref="IComputeEnvironmentResource.GetHostAddressExpression"/>
    /// expects when resolving endpoint references across resources.
    /// </para>
    /// </remarks>
    /// <example>
    /// <code>
    /// app.PublishAsTerraform(infra =>
    /// {
    ///     var containerApp = new AzurermContainerApp("app") { ... };
    ///     infra.Add(containerApp);
    ///
    ///     // Export the endpoint using the standard naming convention
    ///     // Use the stable ingress FQDN, not LatestRevisionFqdn which changes per deployment
    ///     var outputName = TerraformProvisioningResource.GetEndpointOutputName(app.GetEndpoint("http"));
    ///     infra.AddOutput(outputName, Tf.Interpolate($"https://{containerApp["ingress[0].fqdn"]}"));
    /// });
    /// </code>
    /// </example>
    public static string GetEndpointOutputName(EndpointReference endpointReference)
    {
        ArgumentNullException.ThrowIfNull(endpointReference);
        return $"{endpointReference.EndpointName}_endpoint";
    }

    /// <summary>
    /// Creates a Terraform output for the specified endpoint reference.
    /// </summary>
    /// <param name="endpointReference">The endpoint reference to create an output for.</param>
    /// <param name="value">The value expression for the endpoint (e.g., the URL or FQDN).</param>
    /// <param name="description">Optional description for the output.</param>
    /// <returns>The created <see cref="TerraformOutput"/> that was added to the stack.</returns>
    /// <remarks>
    /// <para>
    /// This is a convenience method that combines <see cref="GetEndpointOutputName"/> with <see cref="AddOutput(string, TerraformValue{object}, bool, string?)"/>.
    /// It creates an output using the standard naming convention (<c>{endpoint_name}_endpoint</c>) that
    /// can be consumed by other resources via <see cref="IComputeEnvironmentResource.GetHostAddressExpression"/>.
    /// </para>
    /// </remarks>
    /// <example>
    /// <code>
    /// app.PublishAsTerraform(infra =>
    /// {
    ///     var containerApp = new AzurermContainerApp("app") { ... };
    ///     infra.Add(containerApp);
    ///
    ///     // Export the HTTP endpoint for cross-resource references
    ///     // Use the stable ingress FQDN, not LatestRevisionFqdn which changes per deployment
    ///     infra.AddOutput(app.GetEndpoint("http"), Tf.Interpolate($"https://{containerApp["ingress[0].fqdn"]}"));
    /// });
    ///
    /// // Another resource can then reference this endpoint:
    /// worker.PublishAsTerraform(infra =>
    /// {
    ///     var appUrl = infra.AddVariable("http_endpoint"); // From app's output
    ///     // Use appUrl in configuration...
    /// });
    /// </code>
    /// </example>
    public TerraformOutput AddOutput(EndpointReference endpointReference, TerraformValue<object> value, string? description = null)
    {
        ArgumentNullException.ThrowIfNull(endpointReference);
        ArgumentNullException.ThrowIfNull(value);

        var outputName = GetEndpointOutputName(endpointReference);
        return AddOutput(outputName, value, sensitive: false, description);
    }

    /// <summary>
    /// Gets a reference to an endpoint output from a child module.
    /// </summary>
    /// <param name="endpointReference">The endpoint reference to get from the child module.</param>
    /// <returns>A <see cref="TerraformExpression"/> that references the child module's endpoint output.</returns>
    /// <remarks>
    /// <para>
    /// This method returns a reference to a child module's endpoint output using the pattern
    /// <c>module.{resource_name}.{endpoint_name}_endpoint</c>. Use this to read a child module's
    /// output value or to expose it in the parent module via <see cref="AddOutput(string, TerraformValue{object}, bool, string?)"/>.
    /// </para>
    /// <para>
    /// The child module must have previously exported the endpoint using <see cref="AddOutput(EndpointReference, TerraformValue{object}, string?)"/>.
    /// </para>
    /// </remarks>
    /// <example>
    /// <code>
    /// // In the child module (app resource):
    /// app.PublishAsTerraform(infra =>
    /// {
    ///     var containerApp = new AzurermContainerApp("app") { ... };
    ///     infra.Add(containerApp);
    ///     // Use the stable ingress FQDN, not LatestRevisionFqdn
    ///     infra.AddOutput(app.GetEndpoint("http"), Tf.Interpolate($"https://{containerApp["ingress[0].fqdn"]}"));
    /// });
    ///
    /// // In the parent module (environment):
    /// terraform.PublishAsTerraform(infra =>
    /// {
    ///     // Get reference to child module's output, then expose it
    ///     var appEndpoint = infra.GetOutput(app.GetEndpoint("http"));
    ///     infra.AddOutput("http_endpoint", appEndpoint);
    /// });
    /// </code>
    /// </example>
    public TerraformExpression GetOutput(EndpointReference endpointReference)
    {
        ArgumentNullException.ThrowIfNull(endpointReference);

        var resource = endpointReference.Resource;
        var outputName = GetEndpointOutputName(endpointReference);

        // Return a reference to the child module's output: module.{resource_name}.{output_name}
        return TerraformExpression.Identifier($"module.{resource.Name}.{outputName}");
    }

    /// <summary>
    /// Exposes a child module's endpoint output as an output of the current module.
    /// </summary>
    /// <param name="endpointReference">The endpoint reference from a child resource to pass through.</param>
    /// <param name="outputName">
    /// Optional custom name for the output. If <see langword="null"/>, uses the pattern
    /// <c>{resource_name}_{endpoint_name}_endpoint</c>.
    /// </param>
    /// <param name="description">Optional description for the output.</param>
    /// <returns>The created <see cref="TerraformOutput"/> that was added to the stack.</returns>
    /// <remarks>
    /// <para>
    /// This method combines <see cref="GetOutput(EndpointReference)"/> and <see cref="AddOutput(string, TerraformValue{object}, bool, string?)"/>
    /// for the common pattern of exposing a child module's endpoint at the parent level.
    /// </para>
    /// <para>
    /// Use this method in parent modules (like the environment) to pass through endpoint outputs
    /// from child modules (like container apps) to the root module or external consumers.
    /// </para>
    /// </remarks>
    /// <example>
    /// <code>
    /// // In a child module (app resource):
    /// app.PublishAsTerraform(infra =>
    /// {
    ///     var containerApp = new AzurermContainerApp("app") { ... };
    ///     infra.Add(containerApp);
    ///     infra.AddOutput(app.GetEndpoint("http"), Tf.Interpolate($"https://{containerApp["ingress[0].fqdn"]}"));
    /// });
    ///
    /// // In the parent module (environment) - pass through with default name "app_http_endpoint":
    /// terraform.PublishAsTerraform(infra =>
    /// {
    ///     infra.AddOutput(app.GetEndpoint("http"));
    /// });
    ///
    /// // Or with a custom name:
    /// terraform.PublishAsTerraform(infra =>
    /// {
    ///     infra.AddOutput(app.GetEndpoint("http"), "my_app_url");
    /// });
    /// </code>
    /// </example>
    public TerraformOutput AddOutput(EndpointReference endpointReference, string? outputName = null, string? description = null)
    {
        ArgumentNullException.ThrowIfNull(endpointReference);

        var value = GetOutput(endpointReference);
        var name = outputName ?? $"{endpointReference.Resource.Name}_{GetEndpointOutputName(endpointReference)}";
        return AddOutput(name, value, sensitive: false, description);
    }

    /// <summary>
    /// Gets the container image reference for the target resource.
    /// </summary>
    /// <returns>A <see cref="TerraformVariable"/> that will contain the fully-qualified container image reference
    /// (e.g., "myregistry.azurecr.io/myapp:latest") at deployment time.</returns>
    /// <remarks>
    /// <para>
    /// This method creates a Terraform variable that will receive the fully-qualified container image
    /// reference after the image is built and pushed. The value follows the format:
    /// <c>{registry-endpoint}/{resource-name}:{tag}</c>
    /// </para>
    /// <para>
    /// The tag is determined by the build/push process and may include timestamps, git commits, or
    /// custom values configured via <c>DeploymentImageTagCallbackAnnotation</c>.
    /// </para>
    /// </remarks>
    /// <exception cref="InvalidOperationException">
    /// Thrown if this resource doesn't have a target resource or if the target resource doesn't require image build and push.
    /// </exception>
    /// <example>
    /// <code>
    /// app.PublishAsTerraform(infra =>
    /// {
    ///     var imageVar = infra.GetContainerImage();
    ///
    ///     var containerApp = new AzurermContainerApp("app")
    ///     {
    ///         Template = [new()
    ///         {
    ///             Container = [new()
    ///             {
    ///                 Name = "app",
    ///                 Image = imageVar.AsReference()
    ///             }]
    ///         }]
    ///     };
    ///     infra.Add(containerApp);
    /// });
    /// </code>
    /// </example>
    public TerraformVariable GetContainerImage()
    {
        if (TargetResource is null)
        {
            throw new InvalidOperationException(
                "Cannot get container image for a Terraform resource without a target resource.");
        }

        if (!TargetResource.RequiresImageBuildAndPush())
        {
            throw new InvalidOperationException(
                $"Resource '{TargetResource.Name}' does not require image build and push. " +
                "This method is only available for project resources and resources with Dockerfiles.");
        }

        var variableName = $"{TargetResource.Name}_container_image".Replace("-", "_");

        // Check if we already have this variable
        if (Parameters.TryGetValue(variableName, out var existingVariable))
        {
            return existingVariable;
        }

        // Register the container image reference as an input dependency
        // The publishing context will resolve this to the actual pushed image reference
        var imageReference = new ContainerImageReference(TargetResource);
        Inputs[variableName] = imageReference;

        // Create the variable
        var variable = new TerraformVariable(variableName)
        {
            Type = "string",
            Description = $"Container image reference for '{TargetResource.Name}'"
        };

        Parameters[variableName] = variable;
        Stack.Add(variable);

        return variable;
    }
}
