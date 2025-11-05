// Licensed under the MIT License.

using Aspire.Hosting.ApplicationModel;
using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Aspire.Hosting.Terraform;

/// <summary>
/// Represents a Terraform stack resource that is associated with a parent Aspire resource.
/// This is a separate resource instance that manages infrastructure provisioning via Terraform.
/// </summary>
public class TerraformStackResource : Resource, IResourceWithParent<IResource>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TerraformStackResource"/> class.
    /// </summary>
    /// <param name="name">The unique name of this Terraform stack resource.</param>
    /// <param name="parent">The parent Aspire resource that this stack is associated with.</param>
    /// <param name="stack">The Terraform stack definition containing providers, resources, and configuration.</param>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="name"/>, <paramref name="parent"/>, or <paramref name="stack"/> is null.</exception>
    public TerraformStackResource(string name, IResource parent, TerraformStack stack)
        : base(name)
    {
        Parent = parent ?? throw new ArgumentNullException(nameof(parent));
        Stack = stack ?? throw new ArgumentNullException(nameof(stack));
    }

    /// <summary>
    /// Gets the parent resource that this Terraform stack is associated with.
    /// </summary>
    public IResource Parent { get; }

    /// <summary>
    /// Gets the Terraform stack definition containing the infrastructure configuration.
    /// </summary>
    public TerraformStack Stack { get; }
}
