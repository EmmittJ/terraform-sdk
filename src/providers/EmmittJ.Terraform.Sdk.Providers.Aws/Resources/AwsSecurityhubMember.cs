using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_securityhub_member Terraform resource.
/// Manages a aws_securityhub_member resource.
/// </summary>
public partial class AwsSecurityhubMember(string name) : TerraformResource("aws_securityhub_member", name)
{
    /// <summary>
    /// The account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountId is required")]
    public required TerraformValue<string> AccountId
    {
        get => new TerraformReference<string>(this, "account_id");
        set => SetArgument("account_id", value);
    }

    /// <summary>
    /// The email attribute.
    /// </summary>
    public TerraformValue<string>? Email
    {
        get => new TerraformReference<string>(this, "email");
        set => SetArgument("email", value);
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
    /// The invite attribute.
    /// </summary>
    public TerraformValue<bool>? Invite
    {
        get => new TerraformReference<bool>(this, "invite");
        set => SetArgument("invite", value);
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
    /// The master_id attribute.
    /// </summary>
    public TerraformValue<string> MasterId
    {
        get => new TerraformReference<string>(this, "master_id");
    }

    /// <summary>
    /// The member_status attribute.
    /// </summary>
    public TerraformValue<string> MemberStatus
    {
        get => new TerraformReference<string>(this, "member_status");
    }

}
