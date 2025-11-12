using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for kafka_cluster in .
/// Nesting mode: list
/// </summary>
public partial class AwsMskReplicatorKafkaClusterBlock() : TerraformBlock("kafka_cluster")
{
}

/// <summary>
/// Block type for replication_info_list in .
/// Nesting mode: list
/// </summary>
public partial class AwsMskReplicatorReplicationInfoListBlock() : TerraformBlock("replication_info_list")
{

    /// <summary>
    /// The source_kafka_cluster_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceKafkaClusterArn is required")]
    [TerraformProperty("source_kafka_cluster_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SourceKafkaClusterArn { get; set; }

    /// <summary>
    /// The target_compression_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetCompressionType is required")]
    [TerraformProperty("target_compression_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TargetCompressionType { get; set; }


    /// <summary>
    /// The target_kafka_cluster_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetKafkaClusterArn is required")]
    [TerraformProperty("target_kafka_cluster_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TargetKafkaClusterArn { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsMskReplicatorTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_msk_replicator resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsMskReplicator : TerraformResource
{
    public AwsMskReplicator(string name) : base("aws_msk_replicator", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

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
    /// The replicator_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicatorName is required")]
    [TerraformProperty("replicator_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ReplicatorName { get; set; }

    /// <summary>
    /// The service_execution_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceExecutionRoleArn is required")]
    [TerraformProperty("service_execution_role_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ServiceExecutionRoleArn { get; set; }

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
    /// Block for kafka_cluster.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(2, ErrorMessage = "At least 2 KafkaCluster block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(2, ErrorMessage = "Maximum 2 KafkaCluster block(s) allowed")]
    [TerraformProperty("kafka_cluster")]
    public TerraformList<AwsMskReplicatorKafkaClusterBlock> KafkaCluster { get; set; } = new();

    /// <summary>
    /// Block for replication_info_list.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationInfoList is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ReplicationInfoList block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReplicationInfoList block(s) allowed")]
    [TerraformProperty("replication_info_list")]
    public required TerraformList<AwsMskReplicatorReplicationInfoListBlock> ReplicationInfoList { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsMskReplicatorTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The current_version attribute.
    /// </summary>
    [TerraformProperty("current_version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CurrentVersion { get; }

}
