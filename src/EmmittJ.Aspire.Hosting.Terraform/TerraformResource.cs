// Licensed under the MIT License.

using Aspire.Hosting.ApplicationModel;

namespace EmmittJ.Aspire.Hosting.Terraform;

/// <summary>
/// Represents a wrapper around an Aspire resource that will be deployed via Terraform.
/// </summary>
internal sealed class TerraformResource(string name, TerraformEnvironmentResource environment, IResource? resource = null) : Resource(name), IResourceWithParent<TerraformEnvironmentResource>
{
    /// <summary>
    /// Gets the target Aspire resource that this Terraform resource represents, if any.
    /// </summary>
    public IResource? TargetResource => resource;

    /// <summary>
    /// Gets the Terraform environment this resource belongs to.
    /// </summary>
    public TerraformEnvironmentResource Parent => environment;

    /// <summary>
    /// Gets the dictionary of input dependencies for this resource.
    /// Keys are input names, values are source objects (TerraformOutputReference, ParameterResource, etc.)
    /// </summary>
    internal Dictionary<string, object> Inputs { get; } = [];

    /// <summary>
    /// Gets the dictionary of Terraform outputs produced by this resource.
    /// Keys are output names (case-insensitive), values are the output values.
    /// This dictionary is populated after Terraform apply completes.
    /// </summary>
    internal Dictionary<string, object?> Outputs { get; } = new(StringComparer.OrdinalIgnoreCase);
}
