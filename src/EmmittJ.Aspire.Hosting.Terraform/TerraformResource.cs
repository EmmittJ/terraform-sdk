// Licensed under the MIT License.

using Aspire.Hosting.ApplicationModel;

namespace EmmittJ.Aspire.Hosting.Terraform;

/// <summary>
/// Represents a wrapper around an Aspire resource that will be deployed via Terraform.
/// </summary>
internal sealed class TerraformResource : Resource
{
    /// <summary>
    /// Gets the target Aspire resource that this Terraform resource represents.
    /// </summary>
    public IResource TargetResource { get; }

    /// <summary>
    /// Gets the Terraform environment this resource belongs to.
    /// </summary>
    public TerraformEnvironmentResource Environment { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="TerraformResource"/> class.
    /// </summary>
    /// <param name="targetResource">The target Aspire resource.</param>
    /// <param name="environment">The Terraform environment.</param>
    public TerraformResource(IResource targetResource, TerraformEnvironmentResource environment)
        : base($"{targetResource.Name}-terraform")
    {
        TargetResource = targetResource ?? throw new ArgumentNullException(nameof(targetResource));
        Environment = environment ?? throw new ArgumentNullException(nameof(environment));
    }
}
