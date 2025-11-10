using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsRoute53KeySigningKeyTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a aws_route53_key_signing_key resource.
/// </summary>
public class AwsRoute53KeySigningKey : TerraformResource
{
    public AwsRoute53KeySigningKey(string name) : base("aws_route53_key_signing_key", name)
    {
    }

    /// <summary>
    /// The hosted_zone_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostedZoneId is required")]
    [TerraformPropertyName("hosted_zone_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> HostedZoneId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The key_management_service_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyManagementServiceArn is required")]
    [TerraformPropertyName("key_management_service_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> KeyManagementServiceArn { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Status { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsRoute53KeySigningKeyTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The digest_algorithm_mnemonic attribute.
    /// </summary>
    [TerraformPropertyName("digest_algorithm_mnemonic")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DigestAlgorithmMnemonic => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "digest_algorithm_mnemonic");

    /// <summary>
    /// The digest_algorithm_type attribute.
    /// </summary>
    [TerraformPropertyName("digest_algorithm_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> DigestAlgorithmType => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "digest_algorithm_type");

    /// <summary>
    /// The digest_value attribute.
    /// </summary>
    [TerraformPropertyName("digest_value")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DigestValue => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "digest_value");

    /// <summary>
    /// The dnskey_record attribute.
    /// </summary>
    [TerraformPropertyName("dnskey_record")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DnskeyRecord => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "dnskey_record");

    /// <summary>
    /// The ds_record attribute.
    /// </summary>
    [TerraformPropertyName("ds_record")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DsRecord => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ds_record");

    /// <summary>
    /// The flag attribute.
    /// </summary>
    [TerraformPropertyName("flag")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> Flag => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "flag");

    /// <summary>
    /// The key_tag attribute.
    /// </summary>
    [TerraformPropertyName("key_tag")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> KeyTag => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "key_tag");

    /// <summary>
    /// The public_key attribute.
    /// </summary>
    [TerraformPropertyName("public_key")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PublicKey => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "public_key");

    /// <summary>
    /// The signing_algorithm_mnemonic attribute.
    /// </summary>
    [TerraformPropertyName("signing_algorithm_mnemonic")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SigningAlgorithmMnemonic => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "signing_algorithm_mnemonic");

    /// <summary>
    /// The signing_algorithm_type attribute.
    /// </summary>
    [TerraformPropertyName("signing_algorithm_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> SigningAlgorithmType => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "signing_algorithm_type");

}
