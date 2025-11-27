using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_quicksight_user Terraform resource.
/// Manages a aws_quicksight_user resource.
/// </summary>
public partial class AwsQuicksightUser(string name) : TerraformResource("aws_quicksight_user", name)
{
    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    public TerraformValue<string> AwsAccountId
    {
        get => new TerraformReference<string>(this, "aws_account_id");
        set => SetArgument("aws_account_id", value);
    }

    /// <summary>
    /// The email attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Email is required")]
    public required TerraformValue<string> Email
    {
        get => new TerraformReference<string>(this, "email");
        set => SetArgument("email", value);
    }

    /// <summary>
    /// The iam_arn attribute.
    /// </summary>
    public TerraformValue<string>? IamArn
    {
        get => new TerraformReference<string>(this, "iam_arn");
        set => SetArgument("iam_arn", value);
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
    /// The identity_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityType is required")]
    public required TerraformValue<string> IdentityType
    {
        get => new TerraformReference<string>(this, "identity_type");
        set => SetArgument("identity_type", value);
    }

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    public TerraformValue<string>? NamespaceAttribute
    {
        get => new TerraformReference<string>(this, "namespace");
        set => SetArgument("namespace", value);
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
    /// The session_name attribute.
    /// </summary>
    public TerraformValue<string>? SessionName
    {
        get => new TerraformReference<string>(this, "session_name");
        set => SetArgument("session_name", value);
    }

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    public TerraformValue<string> UserName
    {
        get => new TerraformReference<string>(this, "user_name");
        set => SetArgument("user_name", value);
    }

    /// <summary>
    /// The user_role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserRole is required")]
    public required TerraformValue<string> UserRole
    {
        get => new TerraformReference<string>(this, "user_role");
        set => SetArgument("user_role", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The user_invitation_url attribute.
    /// </summary>
    public TerraformValue<string> UserInvitationUrl
    {
        get => new TerraformReference<string>(this, "user_invitation_url");
    }

}
