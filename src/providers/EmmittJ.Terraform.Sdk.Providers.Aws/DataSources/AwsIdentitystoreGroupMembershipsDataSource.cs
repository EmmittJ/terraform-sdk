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
        SetOutput("group_memberships");
        SetOutput("group_id");
        SetOutput("identity_store_id");
        SetOutput("region");
    }

    /// <summary>
    /// The group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GroupId is required")]
    public required TerraformProperty<string> GroupId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("group_id");
        set => SetProperty("group_id", value);
    }

    /// <summary>
    /// The identity_store_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityStoreId is required")]
    public required TerraformProperty<string> IdentityStoreId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("identity_store_id");
        set => SetProperty("identity_store_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The group_memberships attribute.
    /// </summary>
    public TerraformExpression GroupMemberships => this["group_memberships"];

}
