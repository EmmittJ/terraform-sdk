// Licensed under the MIT License.

using Aspire.Hosting.ApplicationModel;

namespace EmmittJ.Aspire.Hosting.Terraform;

/// <summary>
/// Defines a builder that creates Terraform infrastructure for compute resources.
/// </summary>
/// <remarks>
/// <para>
/// Implement this interface to create platform-specific compute resources (Azure Container Apps,
/// AWS ECS, GCP Cloud Run, etc.) from Aspire resources. The builder is responsible for:
/// </para>
/// <list type="bullet">
/// <item>Processing the Aspire resource (endpoints, environment variables, arguments)</item>
/// <item>Generating the appropriate Terraform resources</item>
/// <item>Handling platform-specific endpoint resolution (e.g., ingress for container apps)</item>
/// </list>
/// </remarks>
/// <example>
/// <code>
/// // Create a custom compute resource builder for AWS ECS
/// public class AwsEcsComputeResourceBuilder : ITerraformComputeResourceBuilder
/// {
///     public async Task&lt;TerraformComputeResourceContext&gt; ProcessResourceAsync(
///         IResource resource,
///         DistributedApplicationExecutionContext executionContext,
///         CancellationToken cancellationToken)
///     {
///         var context = new EcsTaskContext(resource, executionContext);
///         await context.ProcessResourceAsync(cancellationToken);
///         return context;
///     }
///
///     public void BuildComputeResource(
///         TerraformComputeResourceContext context,
///         TerraformProvisioningResource infra)
///     {
///         var ecsContext = (EcsTaskContext)context;
///         ecsContext.BuildTaskDefinition(infra);
///     }
/// }
/// </code>
/// </example>
public interface ITerraformComputeResourceBuilder
{
    /// <summary>
    /// Processes an Aspire resource and creates a context containing resolved values.
    /// </summary>
    /// <param name="resource">The Aspire resource to process.</param>
    /// <param name="executionContext">The execution context.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>A context containing resolved environment variables, arguments, and endpoints.</returns>
    Task<TerraformComputeResourceContext> ProcessResourceAsync(
        IResource resource,
        DistributedApplicationExecutionContext executionContext,
        CancellationToken cancellationToken);

    /// <summary>
    /// Builds the Terraform infrastructure for the compute resource.
    /// </summary>
    /// <param name="context">The context containing resolved resource values.</param>
    /// <param name="infra">The provisioning resource to add Terraform blocks to.</param>
    void BuildComputeResource(TerraformComputeResourceContext context, TerraformProvisioningResource infra);
}
