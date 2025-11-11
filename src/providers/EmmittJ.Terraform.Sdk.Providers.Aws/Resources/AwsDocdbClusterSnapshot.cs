using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsDocdbClusterSnapshotTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

}

/// <summary>
/// Manages a aws_docdb_cluster_snapshot resource.
/// </summary>
public partial class AwsDocdbClusterSnapshot : TerraformResource
{
    public AwsDocdbClusterSnapshot(string name) : base("aws_docdb_cluster_snapshot", name)
    {
    }

    /// <summary>
    /// The db_cluster_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DbClusterIdentifier is required")]
    [TerraformProperty("db_cluster_identifier")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DbClusterIdentifier { get; set; }

    /// <summary>
    /// The db_cluster_snapshot_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DbClusterSnapshotIdentifier is required")]
    [TerraformProperty("db_cluster_snapshot_identifier")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DbClusterSnapshotIdentifier { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsDocdbClusterSnapshotTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    [TerraformProperty("availability_zones")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> AvailabilityZones { get; }

    /// <summary>
    /// The db_cluster_snapshot_arn attribute.
    /// </summary>
    [TerraformProperty("db_cluster_snapshot_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DbClusterSnapshotArn { get; }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    [TerraformProperty("engine")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Engine { get; }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    [TerraformProperty("engine_version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> EngineVersion { get; }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformProperty("kms_key_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> KmsKeyId { get; }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformProperty("port")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> Port { get; }

    /// <summary>
    /// The snapshot_type attribute.
    /// </summary>
    [TerraformProperty("snapshot_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SnapshotType { get; }

    /// <summary>
    /// The source_db_cluster_snapshot_arn attribute.
    /// </summary>
    [TerraformProperty("source_db_cluster_snapshot_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SourceDbClusterSnapshotArn { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Status { get; }

    /// <summary>
    /// The storage_encrypted attribute.
    /// </summary>
    [TerraformProperty("storage_encrypted")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> StorageEncrypted { get; }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformProperty("vpc_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> VpcId { get; }

}
