using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_sesv2_email_identity_mail_from_attributes Terraform resource.
/// Manages a aws_sesv2_email_identity_mail_from_attributes resource.
/// </summary>
public partial class AwsSesv2EmailIdentityMailFromAttributes(string name) : TerraformResource("aws_sesv2_email_identity_mail_from_attributes", name)
{
    /// <summary>
    /// The behavior_on_mx_failure attribute.
    /// </summary>
    public TerraformValue<string>? BehaviorOnMxFailure
    {
        get => GetArgument<TerraformValue<string>>("behavior_on_mx_failure");
        set => SetArgument("behavior_on_mx_failure", value);
    }

    /// <summary>
    /// The email_identity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EmailIdentity is required")]
    public required TerraformValue<string> EmailIdentity
    {
        get => GetRequiredArgument<TerraformValue<string>>("email_identity");
        set => SetArgument("email_identity", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The mail_from_domain attribute.
    /// </summary>
    public TerraformValue<string>? MailFromDomain
    {
        get => GetArgument<TerraformValue<string>>("mail_from_domain");
        set => SetArgument("mail_from_domain", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

}
