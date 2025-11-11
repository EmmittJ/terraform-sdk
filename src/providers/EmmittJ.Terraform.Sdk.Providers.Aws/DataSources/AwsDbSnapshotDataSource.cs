using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_db_snapshot.
/// </summary>
public class AwsDbSnapshotDataSource : TerraformDataSource
{
    public AwsDbSnapshotDataSource(string name) : base("aws_db_snapshot", name)
    {
    }

    /// <summary>
    /// The db_instance_identifier attribute.
    /// </summary>
    [TerraformPropertyName("db_instance_identifier")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DbInstanceIdentifier { get; set; }

    /// <summary>
    /// The db_snapshot_identifier attribute.
    /// </summary>
    [TerraformPropertyName("db_snapshot_identifier")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DbSnapshotIdentifier { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The include_public attribute.
    /// </summary>
    [TerraformPropertyName("include_public")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? IncludePublic { get; set; }

    /// <summary>
    /// The include_shared attribute.
    /// </summary>
    [TerraformPropertyName("include_shared")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? IncludeShared { get; set; }

    /// <summary>
    /// The most_recent attribute.
    /// </summary>
    [TerraformPropertyName("most_recent")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? MostRecent { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The snapshot_type attribute.
    /// </summary>
    [TerraformPropertyName("snapshot_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SnapshotType { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Tags { get; set; } = default!;

    /// <summary>
    /// The allocated_storage attribute.
    /// </summary>
    [TerraformPropertyName("allocated_storage")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> AllocatedStorage => new TerraformReference(this, "allocated_storage");

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    [TerraformPropertyName("availability_zone")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AvailabilityZone => new TerraformReference(this, "availability_zone");

    /// <summary>
    /// The db_snapshot_arn attribute.
    /// </summary>
    [TerraformPropertyName("db_snapshot_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DbSnapshotArn => new TerraformReference(this, "db_snapshot_arn");

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    [TerraformPropertyName("encrypted")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> Encrypted => new TerraformReference(this, "encrypted");

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
    /// The iops attribute.
    /// </summary>
    [TerraformPropertyName("iops")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> Iops => new TerraformReference(this, "iops");

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> KmsKeyId => new TerraformReference(this, "kms_key_id");

    /// <summary>
    /// The license_model attribute.
    /// </summary>
    [TerraformPropertyName("license_model")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LicenseModel => new TerraformReference(this, "license_model");

    /// <summary>
    /// The option_group_name attribute.
    /// </summary>
    [TerraformPropertyName("option_group_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OptionGroupName => new TerraformReference(this, "option_group_name");

    /// <summary>
    /// The original_snapshot_create_time attribute.
    /// </summary>
    [TerraformPropertyName("original_snapshot_create_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OriginalSnapshotCreateTime => new TerraformReference(this, "original_snapshot_create_time");

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformPropertyName("port")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> Port => new TerraformReference(this, "port");

    /// <summary>
    /// The snapshot_create_time attribute.
    /// </summary>
    [TerraformPropertyName("snapshot_create_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SnapshotCreateTime => new TerraformReference(this, "snapshot_create_time");

    /// <summary>
    /// The source_db_snapshot_identifier attribute.
    /// </summary>
    [TerraformPropertyName("source_db_snapshot_identifier")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SourceDbSnapshotIdentifier => new TerraformReference(this, "source_db_snapshot_identifier");

    /// <summary>
    /// The source_region attribute.
    /// </summary>
    [TerraformPropertyName("source_region")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SourceRegion => new TerraformReference(this, "source_region");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Status => new TerraformReference(this, "status");

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    [TerraformPropertyName("storage_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> StorageType => new TerraformReference(this, "storage_type");

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformPropertyName("vpc_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> VpcId => new TerraformReference(this, "vpc_id");

}
