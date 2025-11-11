using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_kms_replica_key resource.
/// </summary>
public partial class AwsKmsReplicaKey : TerraformResource
{
    public AwsKmsReplicaKey(string name) : base("aws_kms_replica_key", name)
    {
    }

    /// <summary>
    /// The bypass_policy_lockout_safety_check attribute.
    /// </summary>
    [TerraformProperty("bypass_policy_lockout_safety_check")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? BypassPolicyLockoutSafetyCheck { get; set; }

    /// <summary>
    /// The deletion_window_in_days attribute.
    /// </summary>
    [TerraformProperty("deletion_window_in_days")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? DeletionWindowInDays { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    [TerraformProperty("policy")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Policy { get; set; }

    /// <summary>
    /// The primary_key_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrimaryKeyArn is required")]
    [TerraformProperty("primary_key_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> PrimaryKeyArn { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The key_id attribute.
    /// </summary>
    [TerraformProperty("key_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> KeyId { get; }

    /// <summary>
    /// The key_rotation_enabled attribute.
    /// </summary>
    [TerraformProperty("key_rotation_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> KeyRotationEnabled { get; }

    /// <summary>
    /// The key_spec attribute.
    /// </summary>
    [TerraformProperty("key_spec")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> KeySpec { get; }

    /// <summary>
    /// The key_usage attribute.
    /// </summary>
    [TerraformProperty("key_usage")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> KeyUsage { get; }

}
