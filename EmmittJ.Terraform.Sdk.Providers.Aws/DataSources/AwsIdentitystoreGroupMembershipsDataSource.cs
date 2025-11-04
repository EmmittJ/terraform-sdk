using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_identitystore_group_memberships.
/// </summary>
public class AwsIdentitystoreGroupMembershipsDataSource : TerraformDataSource
{
    public AwsIdentitystoreGroupMembershipsDataSource(string name) : base("aws_identitystore_group_memberships", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("group_memberships");
    }

    /// <summary>
    /// The group_id attribute.
    /// </summary>
    public string? GroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("group_id")?.Value;
        set => this.WithProperty("group_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The identity_store_id attribute.
    /// </summary>
    public string? IdentityStoreId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("identity_store_id")?.Value;
        set => this.WithProperty("identity_store_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The group_memberships attribute.
    /// </summary>
    public TerraformExpression GroupMemberships => this["group_memberships"];

}
