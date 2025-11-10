using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_cloud_identity_group_transitive_memberships.
/// </summary>
public class GoogleCloudIdentityGroupTransitiveMembershipsDataSource : TerraformDataSource
{
    public GoogleCloudIdentityGroupTransitiveMembershipsDataSource(string name) : base("google_cloud_identity_group_transitive_memberships", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("memberships");
    }

    /// <summary>
    /// The name of the Group to get memberships from.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Group is required")]
    public required TerraformProperty<string> Group
    {
        get => GetRequiredProperty<TerraformProperty<string>>("group");
        set => this.WithProperty("group", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// List of Cloud Identity group memberships.
    /// </summary>
    public TerraformExpression Memberships => this["memberships"];

}
