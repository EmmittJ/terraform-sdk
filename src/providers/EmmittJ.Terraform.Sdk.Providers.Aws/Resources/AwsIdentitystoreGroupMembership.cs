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
        get => GetArgument<TerraformValue<string>>("group_id");
        set => SetArgument("group_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The identity_store_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityStoreId is required")]
    public required TerraformValue<string> IdentityStoreId
    {
        get => GetArgument<TerraformValue<string>>("identity_store_id");
        set => SetArgument("identity_store_id", value);
    }

    /// <summary>
    /// The member_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MemberId is required")]
    public required TerraformValue<string> MemberId
    {
        get => GetArgument<TerraformValue<string>>("member_id");
        set => SetArgument("member_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The membership_id attribute.
    /// </summary>
    public TerraformValue<string> MembershipId
        => AsReference("membership_id");

}
