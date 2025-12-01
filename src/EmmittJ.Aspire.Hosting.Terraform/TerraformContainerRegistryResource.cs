// Licensed under the MIT License.

#pragma warning disable ASPIREPIPELINES001

using Aspire.Hosting.ApplicationModel;
using Aspire.Hosting.Pipelines;
using Aspire.Hosting.Publishing;
using EmmittJ.Terraform.Sdk;
using Microsoft.Extensions.Logging;

namespace EmmittJ.Aspire.Hosting.Terraform;

/// <summary>
/// Represents a Terraform-managed container registry resource that implements <see cref="IContainerRegistry"/>.
/// </summary>
/// <remarks>
/// <para>
/// This resource manages a container registry (like Azure Container Registry or AWS ECR) through Terraform.
/// It has its own <see cref="TerraformProvisioningResource"/> with a separate state directory from the parent environment,
/// allowing the registry to be provisioned independently before image builds and pushes.
/// </para>
/// <para>
/// The registry is provisioned as part of the deployment pipeline with the following steps:
/// <list type="number">
/// <item>publish-registry: Generates Terraform files for the registry</item>
/// <item>init-registry: Runs terraform init for the registry</item>
/// <item>plan-registry: Runs terraform plan for the registry</item>
/// <item>apply-registry: Runs terraform apply to create the registry</item>
/// <item>read-registry-outputs: Reads terraform outputs to get registry name and endpoint</item>
/// <item>login-registry: Authenticates to the registry using the configured callback</item>
/// </list>
/// </para>
/// </remarks>
public sealed class TerraformContainerRegistryResource : Resource, IContainerRegistry
{
    private TerraformProvisioningResource? _registryTerraformResource;
    private TerraformEnvironmentResource? _parentEnvironment;

    /// <summary>
    /// Gets the <see cref="TerraformProvisioningResource"/> that manages the registry's Terraform infrastructure.
    /// </summary>
    /// <remarks>
    /// This resource has its own <see cref="TerraformStack"/> and state directory, separate from the parent environment.
    /// This property is only available after the registry has been associated with an environment.
    /// </remarks>
    /// <exception cref="InvalidOperationException">Thrown if accessed before the registry is associated with an environment.</exception>
    public TerraformProvisioningResource RegistryTerraformResource =>
        _registryTerraformResource ?? throw new InvalidOperationException(
            $"Container registry '{Name}' has not been associated with a Terraform environment. " +
            $"Use builder.AddTerraformEnvironment(\"name\", {Name}) to associate it.");

    /// <summary>
    /// Gets the parent <see cref="TerraformEnvironmentResource"/> that this registry belongs to.
    /// </summary>
    /// <exception cref="InvalidOperationException">Thrown if accessed before the registry is associated with an environment.</exception>
    public TerraformEnvironmentResource ParentEnvironment =>
        _parentEnvironment ?? throw new InvalidOperationException(
            $"Container registry '{Name}' has not been associated with a Terraform environment. " +
            $"Use builder.AddTerraformEnvironment(\"name\", {Name}) to associate it.");

    /// <summary>
    /// Gets the output reference for the registry name.
    /// </summary>
    /// <remarks>
    /// This output must be defined in the registry's Terraform configuration with the name "name".
    /// The value is resolved after terraform apply completes.
    /// </remarks>
    public TerraformOutputReference NameOutput { get; }

    /// <summary>
    /// Gets the output reference for the registry endpoint.
    /// </summary>
    /// <remarks>
    /// This output must be defined in the registry's Terraform configuration with the name "endpoint".
    /// The value is resolved after terraform apply completes.
    /// </remarks>
    public TerraformOutputReference EndpointOutput { get; }

    /// <summary>
    /// Gets the container registry name as a <see cref="ReferenceExpression"/>.
    /// </summary>
    ReferenceExpression IContainerRegistry.Name => ReferenceExpression.Create($"{NameOutput}");

    /// <summary>
    /// Gets the container registry endpoint as a <see cref="ReferenceExpression"/>.
    /// </summary>
    ReferenceExpression IContainerRegistry.Endpoint => ReferenceExpression.Create($"{EndpointOutput}");

    /// <summary>
    /// Gets or sets the callback for authenticating to the container registry.
    /// </summary>
    /// <remarks>
    /// This callback is invoked during the login-registry pipeline step after the registry is provisioned.
    /// Use <see cref="TerraformContainerRegistryHelpers"/> to create common login callbacks for Azure, AWS, and Docker.
    /// </remarks>
    public Func<PipelineStepContext, TerraformContainerRegistryResource, Task>? LoginCallback { get; set; }

    /// <summary>
    /// Gets or sets the callback to configure the registry's Terraform infrastructure.
    /// </summary>
    /// <remarks>
    /// This callback is invoked when the registry is associated with an environment.
    /// </remarks>
    internal Action<TerraformProvisioningResource>? ConfigureCallback { get; set; }

    /// <summary>
    /// Gets or sets whether to automatically run terraform init for the registry.
    /// </summary>
    public bool AutoInit { get; set; } = true;

    /// <summary>
    /// Gets or sets whether to automatically run terraform plan for the registry.
    /// </summary>
    public bool AutoPlan { get; set; } = true;

    /// <summary>
    /// Gets or sets whether to automatically run terraform apply for the registry.
    /// </summary>
    public bool AutoApply { get; set; } = true;

    /// <summary>
    /// Initializes a new instance of the <see cref="TerraformContainerRegistryResource"/> class.
    /// </summary>
    /// <param name="name">The name of the container registry resource.</param>
    /// <remarks>
    /// The registry must be associated with a Terraform environment using
    /// <see cref="TerraformEnvironmentExtensions.AddTerraformEnvironment(IDistributedApplicationBuilder, string, IResourceBuilder{TerraformContainerRegistryResource})"/>
    /// before it can be used.
    /// </remarks>
    public TerraformContainerRegistryResource(string name)
        : base(name)
    {
        // Create output references for required outputs
        NameOutput = new TerraformOutputReference("name", this);
        EndpointOutput = new TerraformOutputReference("endpoint", this);

        // Add pipeline step annotation for registry provisioning
        Annotations.Add(new PipelineStepAnnotation(CreatePipelineSteps));
    }

    /// <summary>
    /// Associates this registry with a Terraform environment.
    /// </summary>
    /// <param name="environment">The parent Terraform environment.</param>
    internal void SetEnvironment(TerraformEnvironmentResource environment)
    {
        ArgumentNullException.ThrowIfNull(environment);

        if (_parentEnvironment is not null)
        {
            throw new InvalidOperationException(
                $"Container registry '{Name}' is already associated with environment '{_parentEnvironment.Name}'.");
        }

        _parentEnvironment = environment;
        _registryTerraformResource = new TerraformProvisioningResource($"{Name}-terraform", environment, this);

        // Apply the configuration callback if one was set
        ConfigureCallback?.Invoke(_registryTerraformResource);

        // Validate that required outputs are defined
        ValidateRequiredOutputs(Name, _registryTerraformResource);
    }

    /// <summary>
    /// Validates that the registry's Terraform configuration contains the required outputs.
    /// </summary>
    /// <exception cref="InvalidOperationException">
    /// Thrown when the required 'name' or 'endpoint' outputs are not defined in the registry's Terraform stack.
    /// </exception>
    private static void ValidateRequiredOutputs(string name, TerraformProvisioningResource resource)
    {
        var stack = resource.Stack;
        var outputs = stack.Blocks.OfType<TerraformOutput>().Select(o => o.Name).ToHashSet(StringComparer.OrdinalIgnoreCase);

        var missingOutputs = new List<string>();

        if (!outputs.Contains("name"))
        {
            missingOutputs.Add("name");
        }

        if (!outputs.Contains("endpoint"))
        {
            missingOutputs.Add("endpoint");
        }

        if (missingOutputs.Count > 0)
        {
            throw new InvalidOperationException(
                $"Container registry '{name}' is missing required Terraform outputs: {string.Join(", ", missingOutputs)}. " +
                $"Add the following to your ConfigureInfrastructure callback:\n" +
                $"  registry.Add(new TerraformOutput(\"name\") {{ Value = <registry-name-expression> }});\n" +
                $"  registry.Add(new TerraformOutput(\"endpoint\") {{ Value = <registry-endpoint-expression> }});");
        }
    }

    private IEnumerable<PipelineStep> CreatePipelineSteps(PipelineStepFactoryContext context)
    {
        var steps = new List<PipelineStep>();

        // Publish step - generates Terraform files for the registry
        var publishStep = new PipelineStep
        {
            Name = $"publish-registry-{Name}",
            Action = ctx => PublishRegistryAsync(ctx),
            Tags = ["publish-terraform", "registry"],
            RequiredBySteps = [WellKnownPipelineSteps.Publish, WellKnownPipelineSteps.Deploy]
        };
        steps.Add(publishStep);

        if (!AutoInit)
        {
            return steps;
        }

        // Init step - runs terraform init
        var initStep = new PipelineStep
        {
            Name = $"init-registry-{Name}",
            Action = ctx => TerraformCommandRunner.RunTerraformCommandAsync(
                ctx,
                "init -input=false -no-color",
                GetRegistryOutputPath(ctx)),
            Tags = ["terraform-init", "registry"],
            DependsOnSteps = [publishStep.Name],
            RequiredBySteps = [WellKnownPipelineSteps.Deploy]
        };
        steps.Add(initStep);

        if (!AutoPlan)
        {
            return steps;
        }

        // Plan step - runs terraform plan
        var planStep = new PipelineStep
        {
            Name = $"plan-registry-{Name}",
            Action = async ctx =>
            {
                var outputPath = GetRegistryOutputPath(ctx);
                var sensitiveEnvVars = await TerraformVariableResolver.ResolveParameterVariablesAsync(ctx, ParentEnvironment, outputPath).ConfigureAwait(false);
                await TerraformCommandRunner.RunTerraformCommandAsync(
                    ctx,
                    "plan -out=aspire.tfplan -input=false -no-color",
                    outputPath,
                    sensitiveEnvVars).ConfigureAwait(false);
            },
            Tags = ["terraform-plan", "registry"],
            DependsOnSteps = [initStep.Name, WellKnownPipelineSteps.DeployPrereq],
            RequiredBySteps = [WellKnownPipelineSteps.Deploy]
        };
        steps.Add(planStep);

        if (!AutoApply)
        {
            return steps;
        }

        // Apply step - runs terraform apply
        var applyStep = new PipelineStep
        {
            Name = $"apply-registry-{Name}",
            Action = async ctx =>
            {
                var outputPath = GetRegistryOutputPath(ctx);
                var sensitiveEnvVars = await TerraformVariableResolver.ResolveParameterVariablesAsync(ctx, ParentEnvironment, outputPath).ConfigureAwait(false);
                await TerraformCommandRunner.RunTerraformCommandAsync(
                    ctx,
                    "apply -auto-approve -input=false -no-color aspire.tfplan",
                    outputPath,
                    sensitiveEnvVars).ConfigureAwait(false);
            },
            Tags = ["terraform-apply", "registry"],
            DependsOnSteps = [planStep.Name, WellKnownPipelineSteps.DeployPrereq],
            RequiredBySteps = [WellKnownPipelineSteps.Deploy]
        };
        steps.Add(applyStep);

        // Read outputs step - reads terraform outputs
        var readOutputsStep = new PipelineStep
        {
            Name = $"read-registry-outputs-{Name}",
            Action = ctx => ReadRegistryOutputsAsync(ctx),
            Tags = ["terraform-outputs", "registry"],
            DependsOnSteps = [applyStep.Name],
            RequiredBySteps = [WellKnownPipelineSteps.Deploy]
        };
        steps.Add(readOutputsStep);

        // Login step - authenticates to the registry
        // Include ProvisionInfrastructure tag so that image push steps wait for this to complete
        var loginStep = new PipelineStep
        {
            Name = $"login-registry-{Name}",
            Action = ctx => LoginToRegistryAsync(ctx),
            Tags = ["registry-login", "registry", WellKnownPipelineTags.ProvisionInfrastructure],
            DependsOnSteps = [readOutputsStep.Name],
            RequiredBySteps = [WellKnownPipelineSteps.Deploy]
        };
        steps.Add(loginStep);

        return steps;
    }

    private Task PublishRegistryAsync(PipelineStepContext context)
    {
        var outputPath = GetRegistryOutputPath(context);

        var terraformContext = new TerraformPublishingContext(
            context,
            context.ExecutionContext,
            outputPath,
            context.Logger,
            ParentEnvironment,
            context.CancellationToken);

        return terraformContext.WriteRegistryAsync(this);
    }

    private async Task ReadRegistryOutputsAsync(PipelineStepContext context)
    {
        var outputPath = GetRegistryOutputPath(context);
        var outputs = await TerraformOutputReader.ReadOutputsAsync(outputPath, context.Logger, context.CancellationToken).ConfigureAwait(false);

        // Populate the outputs dictionary
        foreach (var (key, value) in outputs)
        {
            RegistryTerraformResource.Outputs[key] = value;
        }
    }

    private async Task LoginToRegistryAsync(PipelineStepContext context)
    {
        if (LoginCallback is null)
        {
            context.Logger.LogWarning("No login callback configured for registry '{RegistryName}'. Skipping authentication.", Name);
            return;
        }

        await LoginCallback(context, this).ConfigureAwait(false);
    }

    private string GetRegistryOutputPath(PipelineStepContext context)
    {
        var basePath = PublishingContextUtils.GetEnvironmentOutputPath(context, ParentEnvironment);
        return Path.Combine(basePath, "registry");
    }
}
