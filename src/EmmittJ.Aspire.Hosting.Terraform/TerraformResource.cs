// Licensed under the MIT License.

using Aspire.Hosting.ApplicationModel;

namespace EmmittJ.Aspire.Hosting.Terraform;

/// <summary>
/// Represents a wrapper around an Aspire resource that will be deployed via Terraform.
/// </summary>
internal sealed class TerraformResource : Resource
{
    /// <summary>
    /// Gets the target Aspire resource that this Terraform resource represents, if any.
    /// </summary>
    public IResource? TargetResource { get; }

    /// <summary>
    /// Gets the Terraform environment this resource belongs to.
    /// </summary>
    public TerraformEnvironmentResource Environment { get; }

    /// <summary>
    /// Gets the dictionary of input dependencies for this resource.
    /// Keys are input names, values are source objects (TerraformOutputReference, ParameterResource, etc.)
    /// </summary>
    internal Dictionary<string, object> Inputs { get; } = new();

    /// <summary>
    /// Gets the dictionary of Terraform outputs produced by this resource.
    /// Keys are output names (case-insensitive), values are the output values.
    /// This dictionary is populated after Terraform apply completes.
    /// </summary>
    internal Dictionary<string, object?> Outputs { get; } = new(StringComparer.OrdinalIgnoreCase);

    /// <summary>
    /// Initializes a new instance of the <see cref="TerraformResource"/> class.
    /// </summary>
    /// <param name="name">The name of the Terraform resource.</param>
    /// <param name="targetResource">The target Aspire resource, or <c>null</c> if this is a standalone Terraform resource.</param>
    /// <param name="environment">The Terraform environment.</param>
    public TerraformResource(string name, IResource? targetResource, TerraformEnvironmentResource environment)
        : base(name)
    {
        TargetResource = targetResource;
        Environment = environment ?? throw new ArgumentNullException(nameof(environment));
    }
}
