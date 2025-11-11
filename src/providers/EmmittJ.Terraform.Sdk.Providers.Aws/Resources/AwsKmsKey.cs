using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsKmsKeyTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

}

/// <summary>
/// Manages a aws_kms_key resource.
/// </summary>
public class AwsKmsKey : TerraformResource
{
    public AwsKmsKey(string name) : base("aws_kms_key", name)
    {
    }

    /// <summary>
    /// The bypass_policy_lockout_safety_check attribute.
    /// </summary>
    [TerraformPropertyName("bypass_policy_lockout_safety_check")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? BypassPolicyLockoutSafetyCheck { get; set; }

    /// <summary>
    /// The custom_key_store_id attribute.
    /// </summary>
    [TerraformPropertyName("custom_key_store_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CustomKeyStoreId { get; set; }

    /// <summary>
    /// The customer_master_key_spec attribute.
    /// </summary>
    [TerraformPropertyName("customer_master_key_spec")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CustomerMasterKeySpec { get; set; }

    /// <summary>
    /// The deletion_window_in_days attribute.
    /// </summary>
    [TerraformPropertyName("deletion_window_in_days")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? DeletionWindowInDays { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Description { get; set; } = default!;

    /// <summary>
    /// The enable_key_rotation attribute.
    /// </summary>
    [TerraformPropertyName("enable_key_rotation")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnableKeyRotation { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The is_enabled attribute.
    /// </summary>
    [TerraformPropertyName("is_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? IsEnabled { get; set; }

    /// <summary>
    /// The key_usage attribute.
    /// </summary>
    [TerraformPropertyName("key_usage")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? KeyUsage { get; set; }

    /// <summary>
    /// The multi_region attribute.
    /// </summary>
    [TerraformPropertyName("multi_region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> MultiRegion { get; set; } = default!;

    /// <summary>
    /// The policy attribute.
    /// </summary>
    [TerraformPropertyName("policy")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Policy { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The rotation_period_in_days attribute.
    /// </summary>
    [TerraformPropertyName("rotation_period_in_days")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> RotationPeriodInDays { get; set; } = default!;

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
    /// The xks_key_id attribute.
    /// </summary>
    [TerraformPropertyName("xks_key_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? XksKeyId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsKmsKeyTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The key_id attribute.
    /// </summary>
    [TerraformPropertyName("key_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> KeyId => new TerraformReference(this, "key_id");

}
