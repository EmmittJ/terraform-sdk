// Licensed under the MIT License.

using Aspire.Hosting.ApplicationModel;
using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Aspire.Hosting.Terraform;

/// <summary>
/// Represents the Terraform infrastructure context for a resource, providing access to the Terraform stack and resource.
/// </summary>
public sealed class TerraformResourceInfrastructure
{
    internal TerraformResourceInfrastructure(IResource resource, TerraformStack stack, TerraformEnvironmentResource environment)
    {
        Resource = resource;
        Stack = stack;
        Environment = environment;
    }

    /// <summary>
    /// Gets the Aspire resource that this Terraform infrastructure represents.
    /// </summary>
    public IResource Resource { get; }

    /// <summary>
    /// Gets the Terraform stack for this resource.
    /// </summary>
    public TerraformStack Stack { get; }

    /// <summary>
    /// Gets the Terraform environment resource.
    /// </summary>
    public TerraformEnvironmentResource Environment { get; }
}
