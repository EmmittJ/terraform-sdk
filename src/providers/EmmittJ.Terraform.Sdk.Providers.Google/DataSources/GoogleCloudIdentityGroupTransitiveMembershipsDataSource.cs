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
        get => GetRequiredArgument<TerraformValue<string>>("group");
        set => SetArgument("group", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// List of Cloud Identity group memberships.
    /// </summary>
    public TerraformList<TerraformMap<object>> Memberships
        => AsReference("memberships");

}
