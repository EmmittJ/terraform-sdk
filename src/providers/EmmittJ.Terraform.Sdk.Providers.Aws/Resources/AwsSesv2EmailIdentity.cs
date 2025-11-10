using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for dkim_signing_attributes in .
/// Nesting mode: list
/// </summary>
public class AwsSesv2EmailIdentityDkimSigningAttributesBlock : ITerraformBlock
{
    /// <summary>
    /// The current_signing_key_length attribute.
    /// </summary>
    [TerraformPropertyName("current_signing_key_length")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CurrentSigningKeyLength => new TerraformReferenceProperty<TerraformProperty<string>>("", "current_signing_key_length");

    /// <summary>
    /// The domain_signing_private_key attribute.
    /// </summary>
    [TerraformPropertyName("domain_signing_private_key")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DomainSigningPrivateKey { get; set; }

    /// <summary>
    /// The domain_signing_selector attribute.
    /// </summary>
    [TerraformPropertyName("domain_signing_selector")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DomainSigningSelector { get; set; }

    /// <summary>
    /// The last_key_generation_timestamp attribute.
    /// </summary>
    [TerraformPropertyName("last_key_generation_timestamp")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LastKeyGenerationTimestamp => new TerraformReferenceProperty<TerraformProperty<string>>("", "last_key_generation_timestamp");

    /// <summary>
    /// The next_signing_key_length attribute.
    /// </summary>
    [TerraformPropertyName("next_signing_key_length")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> NextSigningKeyLength { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "next_signing_key_length");

    /// <summary>
    /// The signing_attributes_origin attribute.
    /// </summary>
    [TerraformPropertyName("signing_attributes_origin")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SigningAttributesOrigin => new TerraformReferenceProperty<TerraformProperty<string>>("", "signing_attributes_origin");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Status => new TerraformReferenceProperty<TerraformProperty<string>>("", "status");

    /// <summary>
    /// The tokens attribute.
    /// </summary>
    [TerraformPropertyName("tokens")]
    // Computed attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> Tokens => new TerraformReferenceProperty<List<TerraformProperty<string>>>("", "tokens");

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
    public TerraformProperty<TerraformProperty<string>>? ConfigurationSetName { get; set; }

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
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// Block for dkim_signing_attributes.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DkimSigningAttributes block(s) allowed")]
    [TerraformPropertyName("dkim_signing_attributes")]
    public TerraformList<TerraformBlock<AwsSesv2EmailIdentityDkimSigningAttributesBlock>>? DkimSigningAttributes { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

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
