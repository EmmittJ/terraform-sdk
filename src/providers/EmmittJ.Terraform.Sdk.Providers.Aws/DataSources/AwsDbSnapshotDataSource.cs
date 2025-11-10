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
    public TerraformProperty<TerraformProperty<string>>? DbInstanceIdentifier { get; set; }

    /// <summary>
    /// The db_snapshot_identifier attribute.
    /// </summary>
    [TerraformPropertyName("db_snapshot_identifier")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DbSnapshotIdentifier { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The include_public attribute.
    /// </summary>
    [TerraformPropertyName("include_public")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IncludePublic { get; set; }

    /// <summary>
    /// The include_shared attribute.
    /// </summary>
    [TerraformPropertyName("include_shared")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IncludeShared { get; set; }

    /// <summary>
    /// The most_recent attribute.
    /// </summary>
    [TerraformPropertyName("most_recent")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? MostRecent { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The snapshot_type attribute.
    /// </summary>
    [TerraformPropertyName("snapshot_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SnapshotType { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The allocated_storage attribute.
    /// </summary>
    [TerraformPropertyName("allocated_storage")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> AllocatedStorage => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "allocated_storage");

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    [TerraformPropertyName("availability_zone")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AvailabilityZone => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "availability_zone");

    /// <summary>
    /// The db_snapshot_arn attribute.
    /// </summary>
    [TerraformPropertyName("db_snapshot_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DbSnapshotArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "db_snapshot_arn");

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    [TerraformPropertyName("encrypted")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> Encrypted => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "encrypted");

    /// <summary>
    /// The engine attribute.
    /// </summary>
    [TerraformPropertyName("engine")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Engine => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "engine");

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    [TerraformPropertyName("engine_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EngineVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "engine_version");

    /// <summary>
    /// The iops attribute.
    /// </summary>
    [TerraformPropertyName("iops")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> Iops => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "iops");

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> KmsKeyId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "kms_key_id");

    /// <summary>
    /// The license_model attribute.
    /// </summary>
    [TerraformPropertyName("license_model")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LicenseModel => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "license_model");

    /// <summary>
    /// The option_group_name attribute.
    /// </summary>
    [TerraformPropertyName("option_group_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OptionGroupName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "option_group_name");

    /// <summary>
    /// The original_snapshot_create_time attribute.
    /// </summary>
    [TerraformPropertyName("original_snapshot_create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OriginalSnapshotCreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "original_snapshot_create_time");

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformPropertyName("port")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> Port => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "port");

    /// <summary>
    /// The snapshot_create_time attribute.
    /// </summary>
    [TerraformPropertyName("snapshot_create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SnapshotCreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "snapshot_create_time");

    /// <summary>
    /// The source_db_snapshot_identifier attribute.
    /// </summary>
    [TerraformPropertyName("source_db_snapshot_identifier")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SourceDbSnapshotIdentifier => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "source_db_snapshot_identifier");

    /// <summary>
    /// The source_region attribute.
    /// </summary>
    [TerraformPropertyName("source_region")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SourceRegion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "source_region");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Status => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    [TerraformPropertyName("storage_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StorageType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "storage_type");

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformPropertyName("vpc_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VpcId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "vpc_id");

}
