using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_cloud_identity_group_memberships.
/// </summary>
public class GoogleCloudIdentityGroupMembershipsDataSource : TerraformDataSource
{
    public GoogleCloudIdentityGroupMembershipsDataSource(string name) : base("google_cloud_identity_group_memberships", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("memberships");
    }

    /// <summary>
    /// The name of the Group to get memberships from.
    /// </summary>
    public TerraformLiteralProperty<string>? Group
    {
        get => GetProperty<TerraformLiteralProperty<string>>("group");
        set => this.WithProperty("group", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// List of Cloud Identity group memberships.
    /// </summary>
    public TerraformExpression Memberships => this["memberships"];

}
