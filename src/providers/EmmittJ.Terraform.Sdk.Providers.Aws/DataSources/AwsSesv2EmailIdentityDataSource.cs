using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_sesv2_email_identity.
/// </summary>
public partial class AwsSesv2EmailIdentityDataSource : TerraformDataSource
{
    public AwsSesv2EmailIdentityDataSource(string name) : base("aws_sesv2_email_identity", name)
    {
    }

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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The configuration_set_name attribute.
    /// </summary>
    [TerraformProperty("configuration_set_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ConfigurationSetName { get; }

    /// <summary>
    /// The dkim_signing_attributes attribute.
    /// </summary>
    [TerraformProperty("dkim_signing_attributes")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> DkimSigningAttributes { get; }

    /// <summary>
    /// The identity_type attribute.
    /// </summary>
    [TerraformProperty("identity_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> IdentityType { get; }

    /// <summary>
    /// The verification_status attribute.
    /// </summary>
    [TerraformProperty("verification_status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> VerificationStatus { get; }

    /// <summary>
    /// The verified_for_sending_status attribute.
    /// </summary>
    [TerraformProperty("verified_for_sending_status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> VerifiedForSendingStatus { get; }

}
