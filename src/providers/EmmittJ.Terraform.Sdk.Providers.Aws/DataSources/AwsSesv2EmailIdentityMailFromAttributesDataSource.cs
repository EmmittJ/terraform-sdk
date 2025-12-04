using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_sesv2_email_identity_mail_from_attributes Terraform data source.
/// Retrieves information about a aws_sesv2_email_identity_mail_from_attributes.
/// </summary>
public partial class AwsSesv2EmailIdentityMailFromAttributesDataSource(string name) : TerraformDataSource("aws_sesv2_email_identity_mail_from_attributes", name)
{
    /// <summary>
    /// The email_identity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EmailIdentity is required")]
    public required TerraformValue<string> EmailIdentity
    {
        get => GetArgument<TerraformValue<string>>("email_identity");
        set => SetArgument("email_identity", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The behavior_on_mx_failure attribute.
    /// </summary>
    public TerraformValue<string> BehaviorOnMxFailure
        => AsReference("behavior_on_mx_failure");

    /// <summary>
    /// The mail_from_domain attribute.
    /// </summary>
    public TerraformValue<string> MailFromDomain
        => AsReference("mail_from_domain");

}
