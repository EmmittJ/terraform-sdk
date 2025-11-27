// Licensed under the MIT License.

using Aspire.Hosting.ApplicationModel;

namespace EmmittJ.Aspire.Hosting.Terraform;

/// <summary>
/// Represents an annotation for customizing Terraform resource generation.
/// </summary>
/// <remarks>
/// Initializes a new instance of the <see cref="TerraformCustomizationAnnotation"/> class.
/// </remarks>
/// <param name="configure">The configuration action for customizing the Terraform resource.</param>
public sealed class TerraformCustomizationAnnotation(Action<TerraformResource> configure) : IResourceAnnotation
{
    /// <summary>
    /// Gets the configuration action for customizing the Terraform resource.
    /// </summary>
    public Action<TerraformResource> Configure { get; } = configure ?? throw new ArgumentNullException(nameof(configure));
}
