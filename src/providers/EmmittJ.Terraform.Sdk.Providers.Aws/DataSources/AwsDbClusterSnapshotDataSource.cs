using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_db_cluster_snapshot.
/// </summary>
public partial class AwsDbClusterSnapshotDataSource : TerraformDataSource
{
    public AwsDbClusterSnapshotDataSource(string name) : base("aws_db_cluster_snapshot", name)
    {
    }

    /// <summary>
    /// The db_cluster_identifier attribute.
    /// </summary>
    [TerraformProperty("db_cluster_identifier")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DbClusterIdentifier { get; set; }

    /// <summary>
    /// The db_cluster_snapshot_identifier attribute.
    /// </summary>
    [TerraformProperty("db_cluster_snapshot_identifier")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DbClusterSnapshotIdentifier { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The include_public attribute.
    /// </summary>
    [TerraformProperty("include_public")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? IncludePublic { get; set; }

    /// <summary>
    /// The include_shared attribute.
    /// </summary>
    [TerraformProperty("include_shared")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? IncludeShared { get; set; }

    /// <summary>
    /// The most_recent attribute.
    /// </summary>
    [TerraformProperty("most_recent")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? MostRecent { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The snapshot_type attribute.
    /// </summary>
    [TerraformProperty("snapshot_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SnapshotType { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// The allocated_storage attribute.
    /// </summary>
    [TerraformProperty("allocated_storage")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> AllocatedStorage { get; }

    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    [TerraformProperty("availability_zones")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> AvailabilityZones { get; }

    /// <summary>
    /// The db_cluster_snapshot_arn attribute.
    /// </summary>
    [TerraformProperty("db_cluster_snapshot_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DbClusterSnapshotArn { get; }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    [TerraformProperty("engine")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Engine { get; }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    [TerraformProperty("engine_version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> EngineVersion { get; }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformProperty("kms_key_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> KmsKeyId { get; }

    /// <summary>
    /// The license_model attribute.
    /// </summary>
    [TerraformProperty("license_model")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LicenseModel { get; }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformProperty("port")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> Port { get; }

    /// <summary>
    /// The snapshot_create_time attribute.
    /// </summary>
    [TerraformProperty("snapshot_create_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SnapshotCreateTime { get; }

    /// <summary>
    /// The source_db_cluster_snapshot_arn attribute.
    /// </summary>
    [TerraformProperty("source_db_cluster_snapshot_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SourceDbClusterSnapshotArn { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Status { get; }

    /// <summary>
    /// The storage_encrypted attribute.
    /// </summary>
    [TerraformProperty("storage_encrypted")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> StorageEncrypted { get; }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformProperty("vpc_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> VpcId { get; }

}
