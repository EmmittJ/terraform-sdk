using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_signer_signing_profile.
/// </summary>
public class AwsSignerSigningProfileDataSource : TerraformDataSource
{
    public AwsSignerSigningProfileDataSource(string name) : base("aws_signer_signing_profile", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

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
    /// The platform_display_name attribute.
    /// </summary>
    [TerraformPropertyName("platform_display_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PlatformDisplayName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "platform_display_name");

    /// <summary>
    /// The platform_id attribute.
    /// </summary>
    [TerraformPropertyName("platform_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PlatformId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "platform_id");

    /// <summary>
    /// The revocation_record attribute.
    /// </summary>
    [TerraformPropertyName("revocation_record")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> RevocationRecord => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "revocation_record");

    /// <summary>
    /// The signature_validity_period attribute.
    /// </summary>
    [TerraformPropertyName("signature_validity_period")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> SignatureValidityPeriod => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "signature_validity_period");

    /// <summary>
    /// The signing_material attribute.
    /// </summary>
    [TerraformPropertyName("signing_material")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> SigningMaterial => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "signing_material");

    /// <summary>
    /// The signing_parameters attribute.
    /// </summary>
    [TerraformPropertyName("signing_parameters")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> SigningParameters => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "signing_parameters");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Status => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformPropertyName("version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Version => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "version");

    /// <summary>
    /// The version_arn attribute.
    /// </summary>
    [TerraformPropertyName("version_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VersionArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "version_arn");

}
