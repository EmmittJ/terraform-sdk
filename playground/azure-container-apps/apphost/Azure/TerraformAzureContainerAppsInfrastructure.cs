// Licensed under the MIT License.

#pragma warning disable ASPIREPIPELINES001

using Aspire.Hosting;
using EmmittJ.Aspire.Hosting.Terraform;
using Microsoft.Extensions.Logging;

namespace TerraformPlayground.AppHost.Azure;

/// <summary>
/// Infrastructure subscriber that automatically creates deployment targets for compute resources
/// when a <see cref="TerraformAzureContainerAppEnvironmentResource"/> is present.
/// </summary>
/// <remarks>
/// This class extends <see cref="TerraformCloudInfrastructure{TEnvironment}"/> to handle the common
/// lifecycle of compute resource deployment, providing only the Azure Container Apps-specific builder.
/// </remarks>
internal sealed class TerraformAzureContainerAppsInfrastructure(
    ILogger<TerraformAzureContainerAppsInfrastructure> logger,
    DistributedApplicationExecutionContext executionContext)
    : TerraformCloudInfrastructure<TerraformAzureContainerAppEnvironmentResource>(logger, executionContext)
{
    protected override ITerraformComputeResourceBuilder GetComputeResourceBuilder(
        TerraformAzureContainerAppEnvironmentResource environment,
        IServiceProvider services)
    {
        return new TerraformAzureContainerAppBuilder(environment);
    }
}
