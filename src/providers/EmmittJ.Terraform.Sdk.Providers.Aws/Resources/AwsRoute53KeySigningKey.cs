using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsRoute53KeySigningKeyTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_route53_key_signing_key resource.
/// </summary>
public partial class AwsRoute53KeySigningKey : TerraformResource
{
    public AwsRoute53KeySigningKey(string name) : base("aws_route53_key_signing_key", name)
    {
    }

    /// <summary>
    /// The hosted_zone_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostedZoneId is required")]
    [TerraformProperty("hosted_zone_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> HostedZoneId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The key_management_service_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyManagementServiceArn is required")]
    [TerraformProperty("key_management_service_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> KeyManagementServiceArn { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Status { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AwsRoute53KeySigningKeyTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The digest_algorithm_mnemonic attribute.
    /// </summary>
    [TerraformProperty("digest_algorithm_mnemonic")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DigestAlgorithmMnemonic { get; }

    /// <summary>
    /// The digest_algorithm_type attribute.
    /// </summary>
    [TerraformProperty("digest_algorithm_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> DigestAlgorithmType { get; }

    /// <summary>
    /// The digest_value attribute.
    /// </summary>
    [TerraformProperty("digest_value")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DigestValue { get; }

    /// <summary>
    /// The dnskey_record attribute.
    /// </summary>
    [TerraformProperty("dnskey_record")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DnskeyRecord { get; }

    /// <summary>
    /// The ds_record attribute.
    /// </summary>
    [TerraformProperty("ds_record")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DsRecord { get; }

    /// <summary>
    /// The flag attribute.
    /// </summary>
    [TerraformProperty("flag")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> Flag { get; }

    /// <summary>
    /// The key_tag attribute.
    /// </summary>
    [TerraformProperty("key_tag")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> KeyTag { get; }

    /// <summary>
    /// The public_key attribute.
    /// </summary>
    [TerraformProperty("public_key")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PublicKey { get; }

    /// <summary>
    /// The signing_algorithm_mnemonic attribute.
    /// </summary>
    [TerraformProperty("signing_algorithm_mnemonic")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SigningAlgorithmMnemonic { get; }

    /// <summary>
    /// The signing_algorithm_type attribute.
    /// </summary>
    [TerraformProperty("signing_algorithm_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> SigningAlgorithmType { get; }

}
