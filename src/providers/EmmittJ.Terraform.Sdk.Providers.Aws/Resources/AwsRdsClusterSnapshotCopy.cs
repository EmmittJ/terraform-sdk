using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsRdsClusterSnapshotCopyTimeoutsBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

}

/// <summary>
/// Manages a aws_rds_cluster_snapshot_copy resource.
/// </summary>
public class AwsRdsClusterSnapshotCopy : TerraformResource
{
    public AwsRdsClusterSnapshotCopy(string name) : base("aws_rds_cluster_snapshot_copy", name)
    {
    }

    /// <summary>
    /// The copy_tags attribute.
    /// </summary>
    [TerraformPropertyName("copy_tags")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? CopyTags { get; set; }

    /// <summary>
    /// The destination_region attribute.
    /// </summary>
    [TerraformPropertyName("destination_region")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DestinationRegion { get; set; }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? KmsKeyId { get; set; }

    /// <summary>
    /// The presigned_url attribute.
    /// </summary>
    [TerraformPropertyName("presigned_url")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PresignedUrl { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The shared_accounts attribute.
    /// </summary>
    [TerraformPropertyName("shared_accounts")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? SharedAccounts { get; set; }

    /// <summary>
    /// The source_db_cluster_snapshot_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceDbClusterSnapshotIdentifier is required")]
    [TerraformPropertyName("source_db_cluster_snapshot_identifier")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> SourceDbClusterSnapshotIdentifier { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The target_db_cluster_snapshot_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetDbClusterSnapshotIdentifier is required")]
    [TerraformPropertyName("target_db_cluster_snapshot_identifier")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> TargetDbClusterSnapshotIdentifier { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsRdsClusterSnapshotCopyTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The allocated_storage attribute.
    /// </summary>
    [TerraformPropertyName("allocated_storage")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> AllocatedStorage => new TerraformReference(this, "allocated_storage");

    /// <summary>
    /// The db_cluster_snapshot_arn attribute.
    /// </summary>
    [TerraformPropertyName("db_cluster_snapshot_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DbClusterSnapshotArn => new TerraformReference(this, "db_cluster_snapshot_arn");

    /// <summary>
    /// The engine attribute.
    /// </summary>
    [TerraformPropertyName("engine")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Engine => new TerraformReference(this, "engine");

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    [TerraformPropertyName("engine_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> EngineVersion => new TerraformReference(this, "engine_version");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Id => new TerraformReference(this, "id");

    /// <summary>
    /// The license_model attribute.
    /// </summary>
    [TerraformPropertyName("license_model")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LicenseModel => new TerraformReference(this, "license_model");

    /// <summary>
    /// The snapshot_type attribute.
    /// </summary>
    [TerraformPropertyName("snapshot_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SnapshotType => new TerraformReference(this, "snapshot_type");

    /// <summary>
    /// The storage_encrypted attribute.
    /// </summary>
    [TerraformPropertyName("storage_encrypted")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> StorageEncrypted => new TerraformReference(this, "storage_encrypted");

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    [TerraformPropertyName("storage_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> StorageType => new TerraformReference(this, "storage_type");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> TagsAll => new TerraformReference(this, "tags_all");

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformPropertyName("vpc_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> VpcId => new TerraformReference(this, "vpc_id");

}
