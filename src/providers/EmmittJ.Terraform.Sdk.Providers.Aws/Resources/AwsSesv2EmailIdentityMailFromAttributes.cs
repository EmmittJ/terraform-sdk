using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_sesv2_email_identity_mail_from_attributes resource.
/// </summary>
public partial class AwsSesv2EmailIdentityMailFromAttributes : TerraformResource
{
    public AwsSesv2EmailIdentityMailFromAttributes(string name) : base("aws_sesv2_email_identity_mail_from_attributes", name)
    {
    }

    /// <summary>
    /// The behavior_on_mx_failure attribute.
    /// </summary>
    [TerraformProperty("behavior_on_mx_failure")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? BehaviorOnMxFailure { get; set; }

    /// <summary>
    /// The email_identity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EmailIdentity is required")]
    [TerraformProperty("email_identity")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> EmailIdentity { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The mail_from_domain attribute.
    /// </summary>
    [TerraformProperty("mail_from_domain")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MailFromDomain { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

}
