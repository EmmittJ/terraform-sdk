// Licensed under the MIT License.

#pragma warning disable ASPIREPIPELINES001

using Aspire.Hosting;
using Aspire.Hosting.ApplicationModel;
using EmmittJ.Aspire.Hosting.Terraform;

namespace TerraformPlayground.AppHost.Azure;

/// <summary>
/// Builder for creating Azure Container App Terraform resources from Aspire compute resources.
/// </summary>
internal sealed class TerraformAzureContainerAppBuilder : ITerraformComputeResourceBuilder
{
    private readonly TerraformAzureContainerAppEnvironmentResource _environment;
    private readonly Dictionary<IResource, TerraformAzureContainerAppContext> _contexts = new();

    public TerraformAzureContainerAppBuilder(TerraformAzureContainerAppEnvironmentResource environment)
    {
        _environment = environment;
    }

    public async Task<TerraformComputeResourceContext> ProcessResourceAsync(
        IResource resource,
        DistributedApplicationExecutionContext executionContext,
        CancellationToken cancellationToken)
    {
        var context = new TerraformAzureContainerAppContext(resource, executionContext, _environment.Name);
        _contexts[resource] = context;
        await context.ProcessResourceAsync(cancellationToken).ConfigureAwait(false);
        return context;
    }

    public void BuildComputeResource(TerraformComputeResourceContext context, TerraformProvisioningResource infra)
    {
        if (context is TerraformAzureContainerAppContext appContext)
        {
            appContext.BuildContainerApp(infra);
        }
    }
}
