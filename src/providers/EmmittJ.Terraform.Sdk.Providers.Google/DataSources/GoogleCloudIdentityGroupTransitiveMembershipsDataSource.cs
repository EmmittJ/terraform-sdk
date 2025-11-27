using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_cloud_identity_group_transitive_memberships Terraform data source.
/// Retrieves information about a google_cloud_identity_group_transitive_memberships.
/// </summary>
public partial class GoogleCloudIdentityGroupTransitiveMembershipsDataSource(string name) : TerraformDataSource("google_cloud_identity_group_transitive_memberships", name)
{
    /// <summary>
    /// The name of the Group to get memberships from.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Group is required")]
    public required TerraformValue<string> Group
    {
        get => new TerraformReference<string>(this, "group");
        set => SetArgument("group", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// List of Cloud Identity group memberships.
    /// </summary>
    public TerraformList<TerraformMap<object>> Memberships
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "memberships").ResolveNodes(ctx));
    }

}
