using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_sesv2_email_identity.
/// </summary>
public class AwsSesv2EmailIdentityDataSource : TerraformDataSource
{
    public AwsSesv2EmailIdentityDataSource(string name) : base("aws_sesv2_email_identity", name)
    {
    }

    /// <summary>
    /// The email_identity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EmailIdentity is required")]
    [TerraformPropertyName("email_identity")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> EmailIdentity { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Tags { get; set; } = default!;

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The configuration_set_name attribute.
    /// </summary>
    [TerraformPropertyName("configuration_set_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ConfigurationSetName => new TerraformReference(this, "configuration_set_name");

    /// <summary>
    /// The dkim_signing_attributes attribute.
    /// </summary>
    [TerraformPropertyName("dkim_signing_attributes")]
    // Output-only attribute - read-only reference
    public TerraformList<object> DkimSigningAttributes => new TerraformReference(this, "dkim_signing_attributes");

    /// <summary>
    /// The identity_type attribute.
    /// </summary>
    [TerraformPropertyName("identity_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> IdentityType => new TerraformReference(this, "identity_type");

    /// <summary>
    /// The verification_status attribute.
    /// </summary>
    [TerraformPropertyName("verification_status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> VerificationStatus => new TerraformReference(this, "verification_status");

    /// <summary>
    /// The verified_for_sending_status attribute.
    /// </summary>
    [TerraformPropertyName("verified_for_sending_status")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> VerifiedForSendingStatus => new TerraformReference(this, "verified_for_sending_status");

}
