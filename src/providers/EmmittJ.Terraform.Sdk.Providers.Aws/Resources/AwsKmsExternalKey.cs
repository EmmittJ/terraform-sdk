using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_kms_external_key resource.
/// </summary>
public partial class AwsKmsExternalKey : TerraformResource
{
    public AwsKmsExternalKey(string name) : base("aws_kms_external_key", name)
    {
    }

    /// <summary>
    /// The bypass_policy_lockout_safety_check attribute.
    /// </summary>
    [TerraformProperty("bypass_policy_lockout_safety_check")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? BypassPolicyLockoutSafetyCheck { get; set; }

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
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> Enabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The key_material_base64 attribute.
    /// </summary>
    [TerraformProperty("key_material_base64")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KeyMaterialBase64 { get; set; }

    /// <summary>
    /// The key_spec attribute.
    /// </summary>
    [TerraformProperty("key_spec")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> KeySpec { get; set; }

    /// <summary>
    /// The key_usage attribute.
    /// </summary>
    [TerraformProperty("key_usage")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> KeyUsage { get; set; }

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
    /// The valid_to attribute.
    /// </summary>
    [TerraformProperty("valid_to")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ValidTo { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The expiration_model attribute.
    /// </summary>
    [TerraformProperty("expiration_model")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ExpirationModel { get; }

    /// <summary>
    /// The key_state attribute.
    /// </summary>
    [TerraformProperty("key_state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> KeyState { get; }

}
