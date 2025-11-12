using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsKmsKeyTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

}

/// <summary>
/// Manages a aws_kms_key resource.
/// </summary>
public partial class AwsKmsKey : TerraformResource
{
    public AwsKmsKey(string name) : base("aws_kms_key", name)
    {
    }

    /// <summary>
    /// The bypass_policy_lockout_safety_check attribute.
    /// </summary>
    [TerraformProperty("bypass_policy_lockout_safety_check")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? BypassPolicyLockoutSafetyCheck { get; set; }

    /// <summary>
    /// The custom_key_store_id attribute.
    /// </summary>
    [TerraformProperty("custom_key_store_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CustomKeyStoreId { get; set; }

    /// <summary>
    /// The customer_master_key_spec attribute.
    /// </summary>
    [TerraformProperty("customer_master_key_spec")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CustomerMasterKeySpec { get; set; }

    /// <summary>
    /// The deletion_window_in_days attribute.
    /// </summary>
    [TerraformProperty("deletion_window_in_days")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? DeletionWindowInDays { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Description { get; set; }

    /// <summary>
    /// The enable_key_rotation attribute.
    /// </summary>
    [TerraformProperty("enable_key_rotation")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableKeyRotation { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The is_enabled attribute.
    /// </summary>
    [TerraformProperty("is_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? IsEnabled { get; set; }

    /// <summary>
    /// The key_usage attribute.
    /// </summary>
    [TerraformProperty("key_usage")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KeyUsage { get; set; }

    /// <summary>
    /// The multi_region attribute.
    /// </summary>
    [TerraformProperty("multi_region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> MultiRegion { get; set; }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    [TerraformProperty("policy")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Policy { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The rotation_period_in_days attribute.
    /// </summary>
    [TerraformProperty("rotation_period_in_days")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> RotationPeriodInDays { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The xks_key_id attribute.
    /// </summary>
    [TerraformProperty("xks_key_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? XksKeyId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsKmsKeyTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The key_id attribute.
    /// </summary>
    [TerraformProperty("key_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> KeyId { get; }

}
