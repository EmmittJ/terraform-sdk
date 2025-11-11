using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_sesv2_email_identity_mail_from_attributes.
/// </summary>
public partial class AwsSesv2EmailIdentityMailFromAttributesDataSource : TerraformDataSource
{
    public AwsSesv2EmailIdentityMailFromAttributesDataSource(string name) : base("aws_sesv2_email_identity_mail_from_attributes", name)
    {
    }

    /// <summary>
    /// The email_identity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EmailIdentity is required")]
    [TerraformProperty("email_identity")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> EmailIdentity { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The behavior_on_mx_failure attribute.
    /// </summary>
    [TerraformProperty("behavior_on_mx_failure")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> BehaviorOnMxFailure { get; }

    /// <summary>
    /// The mail_from_domain attribute.
    /// </summary>
    [TerraformProperty("mail_from_domain")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> MailFromDomain { get; }

}
