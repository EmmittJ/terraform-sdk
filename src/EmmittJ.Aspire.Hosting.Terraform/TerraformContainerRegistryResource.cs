// Licensed under the MIT License.

#pragma warning disable ASPIREPIPELINES001
#pragma warning disable ASPIREPIPELINES004

using Aspire.Hosting.ApplicationModel;
using Aspire.Hosting.Pipelines;
using Aspire.Hosting.Publishing;
using EmmittJ.Terraform.Sdk;
using Microsoft.Extensions.Logging;

namespace EmmittJ.Aspire.Hosting.Terraform;

/// <summary>
/// Represents a Terraform-managed container registry resource that implements both <see cref="IContainerRegistry"/>
/// and <see cref="ITerraformEnvironment"/>.
/// </summary>
/// <remarks>
/// <para>
/// This resource manages a container registry (like Azure Container Registry or AWS ECR) through Terraform.
/// It is a self-contained Terraform environment with its own state, configuration, and lifecycle,
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
/// <para>
/// Unlike child resources, the container registry is a first-class <see cref="ITerraformEnvironment"/>
/// with its own settings for version, backend, providers, and automatic operations.
/// </para>
/// </remarks>
public sealed class TerraformContainerRegistryResource : Resource, IContainerRegistry, ITerraformEnvironment
{
    /// <inheritdoc />
    public TerraformProvisioningResource TerraformResource { get; }

    /// <inheritdoc />
    public string? TerraformVersion { get; set; }

    /// <inheritdoc />
    public string? OutputPath { get; set; }

    /// <inheritdoc />
    public bool AutoInit { get; set; } = true;

    /// <inheritdoc />
    public bool AutoPlan { get; set; } = true;

    /// <inheritdoc />
    public bool AutoApply { get; set; } = true;

    /// <inheritdoc />
    public Dictionary<ParameterResource, TerraformVariable> ParameterVariables { get; } = new();

    /// <inheritdoc />
    /// <remarks>
    /// For a container registry resource, this returns itself since the registry IS the container registry.
    /// </remarks>
    public IContainerRegistry? ContainerRegistry => this;

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
    public Func<PipelineStepContext, IContainerRegistry, Task>? LoginCallback { get; set; }

    /// <summary>
    /// Gets the <see cref="TerraformOutputsAnnotation"/> for this registry.
    /// This annotation stores outputs directly on the resource for easy access via <see cref="TerraformOutputReference"/>.
    /// </summary>
    internal TerraformOutputsAnnotation OutputsAnnotation => TerraformResource.OutputsAnnotation;

    /// <summary>
    /// Initializes a new instance of the <see cref="TerraformContainerRegistryResource"/> class.
    /// </summary>
    /// <param name="name">The name of the container registry resource.</param>
    /// <remarks>
    /// <para>
    /// The container registry is a self-contained Terraform environment. Configure it using extension methods:
    /// </para>
    /// <list type="bullet">
    /// <item><c>WithVersion</c> - Set Terraform version</item>
    /// <item><c>WithBackend</c> - Configure state backend</item>
    /// <item><c>WithSettings</c> - Configure providers and required versions</item>
    /// <item><c>PublishAsTerraform</c> - Define Terraform resources</item>
    /// </list>
    /// </remarks>
    public TerraformContainerRegistryResource(string name)
        : base(name)
    {
        // Create the TerraformResource for this registry (it references itself as the environment)
        // The constructor adds the TerraformOutputsAnnotation to this resource's Annotations collection
        TerraformResource = new TerraformProvisioningResource($"{name}-terraform", this, this);

        // Create output references for required outputs
        NameOutput = new TerraformOutputReference("name", this);
        EndpointOutput = new TerraformOutputReference("endpoint", this);

        // Add pipeline step annotation for registry provisioning
        Annotations.Add(new PipelineStepAnnotation(CreatePipelineSteps));
    }

    /// <summary>
    /// Validates that the registry's Terraform configuration contains the required outputs.
    /// </summary>
    /// <exception cref="InvalidOperationException">
    /// Thrown when the required 'name' or 'endpoint' outputs are not defined in the registry's Terraform stack.
    /// </exception>
    internal void ValidateRequiredOutputs()
    {
        var stack = TerraformResource.Stack;
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
                $"Container registry '{Name}' is missing required Terraform outputs: {string.Join(", ", missingOutputs)}. " +
                $"Add the following to your PublishAsTerraform callback:\n" +
                $"  registry.Add(new TerraformOutput(\"name\") {{ Value = <registry-name-expression> }});\n" +
                $"  registry.Add(new TerraformOutput(\"endpoint\") {{ Value = <registry-endpoint-expression> }});");
        }
    }

    private IEnumerable<PipelineStep> CreatePipelineSteps(PipelineStepFactoryContext context)
    {
        // Use the factory for standard steps
        // Note: Factory appends environment.Name, so just use "registry" as prefix
        var steps = TerraformPipelineFactory.CreateTerraformSteps(
            this,
            "registry",
            ctx => PublishingContextUtils.GetOutputPath(ctx, this),
            PublishRegistryAsync,
            [TerraformPipelineTags.Registry]);

        // Add login step after read-outputs if we have auto-apply enabled
        if (AutoApply && LoginCallback is not null)
        {
            var readOutputsStep = steps.LastOrDefault(s => s.Tags.Contains(TerraformPipelineTags.TerraformOutputs));
            if (readOutputsStep is not null)
            {
                var loginStep = new PipelineStep
                {
                    Name = $"login-registry-{Name}",
                    Action = LoginToRegistryAsync,
                    Tags = [TerraformPipelineTags.Registry, WellKnownPipelineTags.ProvisionInfrastructure],
                    DependsOnSteps = [readOutputsStep.Name],
                    RequiredBySteps = [WellKnownPipelineSteps.Deploy]
                };
                steps.Add(loginStep);
            }
        }

        return steps;
    }

    private Task PublishRegistryAsync(PipelineStepContext context)
    {
        var outputPath = PublishingContextUtils.GetOutputPath(context, this);

        // Apply all customization annotations
        if (this.TryGetAnnotationsOfType<TerraformCustomizationAnnotation>(out var annotations))
        {
            foreach (var annotation in annotations)
            {
                annotation.Configure(TerraformResource);
            }
        }

        // Validate required outputs
        ValidateRequiredOutputs();

        // Write the registry's Terraform configuration
        return WriteRegistryConfigurationAsync(context, outputPath);
    }

    private async Task WriteRegistryConfigurationAsync(PipelineStepContext context, string outputPath)
    {
        context.Logger.LogDebug("Generating Terraform configuration for registry '{RegistryName}' at {OutputPath}", Name, outputPath);

        // Ensure the output directory exists
        Directory.CreateDirectory(outputPath);

        // Generate main.tf
        var stack = TerraformResource.Stack;
        var mainTfPath = Path.Combine(outputPath, "main.tf");
        var hcl = stack.ToHcl();
        await File.WriteAllTextAsync(mainTfPath, hcl, context.CancellationToken).ConfigureAwait(false);

        context.Logger.LogDebug("Generated registry Terraform configuration at {Path}", mainTfPath);

        // Generate .terraform-version file if specified
        if (!string.IsNullOrEmpty(TerraformVersion))
        {
            var versionFilePath = Path.Combine(outputPath, ".terraform-version");
            await File.WriteAllTextAsync(versionFilePath, TerraformVersion, context.CancellationToken).ConfigureAwait(false);
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
}
