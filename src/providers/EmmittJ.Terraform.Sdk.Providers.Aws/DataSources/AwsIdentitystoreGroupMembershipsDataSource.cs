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
        this.WithOutput("group_memberships");
    }

    /// <summary>
    /// The group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GroupId is required")]
    public required TerraformProperty<string> GroupId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("group_id");
        set => this.WithProperty("group_id", value);
    }

    /// <summary>
    /// The identity_store_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityStoreId is required")]
    public required TerraformProperty<string> IdentityStoreId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("identity_store_id");
        set => this.WithProperty("identity_store_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The group_memberships attribute.
    /// </summary>
    public TerraformExpression GroupMemberships => this["group_memberships"];

}
