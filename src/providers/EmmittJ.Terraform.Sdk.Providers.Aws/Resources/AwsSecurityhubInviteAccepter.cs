using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_securityhub_invite_accepter Terraform resource.
/// Manages a aws_securityhub_invite_accepter resource.
/// </summary>
public partial class AwsSecurityhubInviteAccepter(string name) : TerraformResource("aws_securityhub_invite_accepter", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The master_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MasterId is required")]
    public required TerraformValue<string> MasterId
    {
        get => new TerraformReference<string>(this, "master_id");
        set => SetArgument("master_id", value);
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
    /// The invitation_id attribute.
    /// </summary>
    public TerraformValue<string> InvitationId
    {
        get => new TerraformReference<string>(this, "invitation_id");
    }

}
