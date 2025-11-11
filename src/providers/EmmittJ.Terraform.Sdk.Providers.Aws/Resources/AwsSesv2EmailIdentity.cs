using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for dkim_signing_attributes in .
/// Nesting mode: list
/// </summary>
public class AwsSesv2EmailIdentityDkimSigningAttributesBlock
{

    /// <summary>
    /// The domain_signing_private_key attribute.
    /// </summary>
    [TerraformPropertyName("domain_signing_private_key")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DomainSigningPrivateKey { get; set; }

    /// <summary>
    /// The domain_signing_selector attribute.
    /// </summary>
    [TerraformPropertyName("domain_signing_selector")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DomainSigningSelector { get; set; }


    /// <summary>
    /// The next_signing_key_length attribute.
    /// </summary>
    [TerraformPropertyName("next_signing_key_length")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> NextSigningKeyLength { get; set; } = default!;




}

/// <summary>
/// Manages a aws_sesv2_email_identity resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsSesv2EmailIdentity : TerraformResource
{
    public AwsSesv2EmailIdentity(string name) : base("aws_sesv2_email_identity", name)
    {
    }

    /// <summary>
    /// The configuration_set_name attribute.
    /// </summary>
    [TerraformPropertyName("configuration_set_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ConfigurationSetName { get; set; }

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
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// Block for dkim_signing_attributes.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DkimSigningAttributes block(s) allowed")]
    [TerraformPropertyName("dkim_signing_attributes")]
    public TerraformList<TerraformBlock<AwsSesv2EmailIdentityDkimSigningAttributesBlock>>? DkimSigningAttributes { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

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
