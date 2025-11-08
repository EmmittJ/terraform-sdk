// Licensed under the MIT License.

using Aspire.Hosting;
using Aspire.Hosting.ApplicationModel;
using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Aspire.Hosting.Terraform;

/// <summary>
/// Provides extension methods for adding Terraform infrastructure provisioning to Aspire resources.
/// </summary>
public static class TerraformBuilderExtensions
{
    /// <summary>
    /// Configures Terraform generation settings for a resource.
    /// </summary>
    /// <typeparam name="T">The resource type.</typeparam>
    /// <param name="builder">The resource builder.</param>
    /// <param name="configure">An action to configure the Terraform settings.</param>
    /// <returns>The resource builder for chaining.</returns>
    public static IResourceBuilder<T> WithTerraformConfiguration<T>(
        this IResourceBuilder<T> builder,
        Action<TerraformConfigurationAnnotation> configure)
        where T : IResource
    {
        ArgumentNullException.ThrowIfNull(builder);
        ArgumentNullException.ThrowIfNull(configure);

        var annotation = builder.Resource.Annotations
            .OfType<TerraformConfigurationAnnotation>()
            .FirstOrDefault();

        if (annotation is null)
        {
            annotation = new TerraformConfigurationAnnotation();
            builder.WithAnnotation(annotation);
        }

        configure(annotation);

        return builder;
    }
}
