// Licensed under the MIT License.

using Aspire.Hosting.ApplicationModel;
using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Aspire.Hosting.Terraform;

/// <summary>
/// Represents an annotation for customizing Terraform resource generation.
/// </summary>
/// <remarks>
/// Initializes a new instance of the <see cref="TerraformCustomizationAnnotation"/> class.
/// </remarks>
/// <param name="configure">The configuration action for customizing the Terraform infrastructure.</param>
public sealed class TerraformCustomizationAnnotation(Action<TerraformResourceInfrastructure> configure) : IResourceAnnotation
{
    /// <summary>
    /// Gets the configuration action for customizing the Terraform infrastructure.
    /// </summary>
    public Action<TerraformResourceInfrastructure> Configure { get; } = configure ?? throw new ArgumentNullException(nameof(configure));
}
