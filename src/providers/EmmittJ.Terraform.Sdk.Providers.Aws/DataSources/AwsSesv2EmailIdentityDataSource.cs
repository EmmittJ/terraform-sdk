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
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The configuration_set_name attribute.
    /// </summary>
    [TerraformPropertyName("configuration_set_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ConfigurationSetName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "configuration_set_name");

    /// <summary>
    /// The dkim_signing_attributes attribute.
    /// </summary>
    [TerraformPropertyName("dkim_signing_attributes")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> DkimSigningAttributes => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "dkim_signing_attributes");

    /// <summary>
    /// The identity_type attribute.
    /// </summary>
    [TerraformPropertyName("identity_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> IdentityType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "identity_type");

    /// <summary>
    /// The verification_status attribute.
    /// </summary>
    [TerraformPropertyName("verification_status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VerificationStatus => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "verification_status");

    /// <summary>
    /// The verified_for_sending_status attribute.
    /// </summary>
    [TerraformPropertyName("verified_for_sending_status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> VerifiedForSendingStatus => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "verified_for_sending_status");

}
