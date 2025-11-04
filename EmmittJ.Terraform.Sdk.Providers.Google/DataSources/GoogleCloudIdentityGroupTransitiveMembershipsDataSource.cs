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
        this.DeclareOutput("memberships");
    }

    /// <summary>
    /// The name of the Group to get memberships from.
    /// </summary>
    public string? Group
    {
        get => GetProperty<TerraformLiteralProperty<string>>("group")?.Value;
        set => this.WithProperty("group", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// List of Cloud Identity group memberships.
    /// </summary>
    public TerraformExpression Memberships => this["memberships"];

}
