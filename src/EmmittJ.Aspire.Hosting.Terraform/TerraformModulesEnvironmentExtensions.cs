// Licensed under the MIT License.

using Aspire.Hosting;
using Aspire.Hosting.ApplicationModel;

namespace EmmittJ.Aspire.Hosting.Terraform;

/// <summary>Extension methods for a Terraform modules deployment environment.</summary>
public static class TerraformModulesEnvironmentExtensions
{
    /// <summary>Adds an environment that publishes Terraform modules as one root configuration.</summary>
    /// <param name="builder">The distributed application builder.</param>
    /// <param name="name">The environment resource name.</param>
    /// <returns>The Terraform environment builder.</returns>
    [AspireExport]
    public static IResourceBuilder<TerraformModulesEnvironmentResource> AddTerraformEnvironment(
        this IDistributedApplicationBuilder builder,
        [ResourceName] string name)
    {
        ArgumentNullException.ThrowIfNull(builder);
        ArgumentException.ThrowIfNullOrEmpty(name);

        var environment = new TerraformModulesEnvironmentResource(name);
        return builder.ExecutionContext.IsRunMode
            ? builder.CreateResourceBuilder(environment)
            : builder.AddResource(environment);
    }
}
