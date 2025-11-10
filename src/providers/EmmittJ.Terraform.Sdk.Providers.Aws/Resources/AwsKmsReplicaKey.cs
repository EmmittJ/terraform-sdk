using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_kms_replica_key resource.
/// </summary>
public class AwsKmsReplicaKey : TerraformResource
{
    public AwsKmsReplicaKey(string name) : base("aws_kms_replica_key", name)
    {
    }

    /// <summary>
    /// The bypass_policy_lockout_safety_check attribute.
    /// </summary>
    [TerraformPropertyName("bypass_policy_lockout_safety_check")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? BypassPolicyLockoutSafetyCheck { get; set; }

    /// <summary>
    /// The deletion_window_in_days attribute.
    /// </summary>
    [TerraformPropertyName("deletion_window_in_days")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? DeletionWindowInDays { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Enabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The policy attribute.
    /// </summary>
    [TerraformPropertyName("policy")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Policy { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "policy");

    /// <summary>
    /// The primary_key_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrimaryKeyArn is required")]
    [TerraformPropertyName("primary_key_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> PrimaryKeyArn { get; set; }

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
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The key_id attribute.
    /// </summary>
    [TerraformPropertyName("key_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> KeyId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "key_id");

    /// <summary>
    /// The key_rotation_enabled attribute.
    /// </summary>
    [TerraformPropertyName("key_rotation_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> KeyRotationEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "key_rotation_enabled");

    /// <summary>
    /// The key_spec attribute.
    /// </summary>
    [TerraformPropertyName("key_spec")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> KeySpec => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "key_spec");

    /// <summary>
    /// The key_usage attribute.
    /// </summary>
    [TerraformPropertyName("key_usage")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> KeyUsage => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "key_usage");

}
