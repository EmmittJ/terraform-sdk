using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_identitystore_group_membership Terraform resource.
/// Manages a aws_identitystore_group_membership resource.
/// </summary>
public partial class AwsIdentitystoreGroupMembership(string name) : TerraformResource("aws_identitystore_group_membership", name)
{
    /// <summary>
    /// The group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GroupId is required")]
    public required TerraformValue<string> GroupId
    {
        get => new TerraformReference<string>(this, "group_id");
        set => SetArgument("group_id", value);
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
    /// The identity_store_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityStoreId is required")]
    public required TerraformValue<string> IdentityStoreId
    {
        get => new TerraformReference<string>(this, "identity_store_id");
        set => SetArgument("identity_store_id", value);
    }

    /// <summary>
    /// The member_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MemberId is required")]
    public required TerraformValue<string> MemberId
    {
        get => new TerraformReference<string>(this, "member_id");
        set => SetArgument("member_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The membership_id attribute.
    /// </summary>
    public TerraformValue<string> MembershipId
    {
        get => new TerraformReference<string>(this, "membership_id");
    }

}
