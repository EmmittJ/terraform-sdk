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
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

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
    /// The platform_display_name attribute.
    /// </summary>
    [TerraformPropertyName("platform_display_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PlatformDisplayName => new TerraformReference(this, "platform_display_name");

    /// <summary>
    /// The platform_id attribute.
    /// </summary>
    [TerraformPropertyName("platform_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PlatformId => new TerraformReference(this, "platform_id");

    /// <summary>
    /// The revocation_record attribute.
    /// </summary>
    [TerraformPropertyName("revocation_record")]
    // Output-only attribute - read-only reference
    public TerraformList<object> RevocationRecord => new TerraformReference(this, "revocation_record");

    /// <summary>
    /// The signature_validity_period attribute.
    /// </summary>
    [TerraformPropertyName("signature_validity_period")]
    // Output-only attribute - read-only reference
    public TerraformList<object> SignatureValidityPeriod => new TerraformReference(this, "signature_validity_period");

    /// <summary>
    /// The signing_material attribute.
    /// </summary>
    [TerraformPropertyName("signing_material")]
    // Output-only attribute - read-only reference
    public TerraformList<object> SigningMaterial => new TerraformReference(this, "signing_material");

    /// <summary>
    /// The signing_parameters attribute.
    /// </summary>
    [TerraformPropertyName("signing_parameters")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> SigningParameters => new TerraformReference(this, "signing_parameters");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Status => new TerraformReference(this, "status");

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformPropertyName("version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Version => new TerraformReference(this, "version");

    /// <summary>
    /// The version_arn attribute.
    /// </summary>
    [TerraformPropertyName("version_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> VersionArn => new TerraformReference(this, "version_arn");

}
