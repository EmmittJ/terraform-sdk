// Licensed under the MIT License.

using Aspire.Hosting;
using Aspire.Hosting.ApplicationModel;
using Microsoft.Extensions.Logging;

namespace EmmittJ.Aspire.Hosting.Terraform;

/// <summary>
/// Context for managing Terraform resource creation and configuration within an environment.
/// </summary>
internal sealed class TerraformEnvironmentContext
{
    private readonly TerraformEnvironmentResource _environment;
    private readonly ILogger _logger;
    private readonly DistributedApplicationExecutionContext _executionContext;

    public TerraformEnvironmentContext(
        TerraformEnvironmentResource environment,
        ILogger logger,
        DistributedApplicationExecutionContext executionContext)
    {
        _environment = environment;
        _logger = logger;
        _executionContext = executionContext;
    }

    /// <summary>
    /// Creates a Terraform resource wrapper for the given compute resource.
    /// </summary>
    /// <param name="resource">The compute resource to wrap.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>A <see cref="TerraformResource"/> that wraps the compute resource.</returns>
    public Task<TerraformResource> CreateTerraformResourceAsync(IResource resource, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(resource);

        _logger.LogDebug("Creating Terraform resource for {ResourceName} ({ResourceType})",
            resource.Name,
            resource.GetType().Name);

        var terraformResource = new TerraformResource(resource, _environment);

        return Task.FromResult(terraformResource);
    }
}
