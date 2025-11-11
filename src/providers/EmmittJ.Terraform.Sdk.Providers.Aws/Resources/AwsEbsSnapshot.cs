using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsEbsSnapshotTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

}

/// <summary>
/// Manages a aws_ebs_snapshot resource.
/// </summary>
public class AwsEbsSnapshot : TerraformResource
{
    public AwsEbsSnapshot(string name) : base("aws_ebs_snapshot", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The outpost_arn attribute.
    /// </summary>
    [TerraformPropertyName("outpost_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? OutpostArn { get; set; }

    /// <summary>
    /// The permanent_restore attribute.
    /// </summary>
    [TerraformPropertyName("permanent_restore")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? PermanentRestore { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The storage_tier attribute.
    /// </summary>
    [TerraformPropertyName("storage_tier")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> StorageTier { get; set; } = default!;

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
    /// The temporary_restore_days attribute.
    /// </summary>
    [TerraformPropertyName("temporary_restore_days")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? TemporaryRestoreDays { get; set; }

    /// <summary>
    /// The volume_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VolumeId is required")]
    [TerraformPropertyName("volume_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> VolumeId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsEbsSnapshotTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The data_encryption_key_id attribute.
    /// </summary>
    [TerraformPropertyName("data_encryption_key_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DataEncryptionKeyId => new TerraformReference(this, "data_encryption_key_id");

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    [TerraformPropertyName("encrypted")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> Encrypted => new TerraformReference(this, "encrypted");

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> KmsKeyId => new TerraformReference(this, "kms_key_id");

    /// <summary>
    /// The owner_alias attribute.
    /// </summary>
    [TerraformPropertyName("owner_alias")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OwnerAlias => new TerraformReference(this, "owner_alias");

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformPropertyName("owner_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OwnerId => new TerraformReference(this, "owner_id");

    /// <summary>
    /// The volume_size attribute.
    /// </summary>
    [TerraformPropertyName("volume_size")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> VolumeSize => new TerraformReference(this, "volume_size");

}
