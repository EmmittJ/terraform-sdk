using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_sesv2_email_identity_mail_from_attributes.
/// </summary>
public class AwsSesv2EmailIdentityMailFromAttributesDataSource : TerraformDataSource
{
    public AwsSesv2EmailIdentityMailFromAttributesDataSource(string name) : base("aws_sesv2_email_identity_mail_from_attributes", name)
    {
    }

    /// <summary>
    /// The email_identity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EmailIdentity is required")]
    [TerraformPropertyName("email_identity")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> EmailIdentity { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The behavior_on_mx_failure attribute.
    /// </summary>
    [TerraformPropertyName("behavior_on_mx_failure")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> BehaviorOnMxFailure => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "behavior_on_mx_failure");

    /// <summary>
    /// The mail_from_domain attribute.
    /// </summary>
    [TerraformPropertyName("mail_from_domain")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> MailFromDomain => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "mail_from_domain");

}
