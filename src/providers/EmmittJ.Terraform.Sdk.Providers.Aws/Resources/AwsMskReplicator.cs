using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for kafka_cluster in .
/// Nesting mode: list
/// </summary>
public class AwsMskReplicatorKafkaClusterBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for replication_info_list in .
/// Nesting mode: list
/// </summary>
public class AwsMskReplicatorReplicationInfoListBlock : ITerraformBlock
{
    /// <summary>
    /// The source_kafka_cluster_alias attribute.
    /// </summary>
    [TerraformPropertyName("source_kafka_cluster_alias")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SourceKafkaClusterAlias => new TerraformReferenceProperty<TerraformProperty<string>>("", "source_kafka_cluster_alias");

    /// <summary>
    /// The source_kafka_cluster_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceKafkaClusterArn is required")]
    [TerraformPropertyName("source_kafka_cluster_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SourceKafkaClusterArn { get; set; }

    /// <summary>
    /// The target_compression_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetCompressionType is required")]
    [TerraformPropertyName("target_compression_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> TargetCompressionType { get; set; }

    /// <summary>
    /// The target_kafka_cluster_alias attribute.
    /// </summary>
    [TerraformPropertyName("target_kafka_cluster_alias")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TargetKafkaClusterAlias => new TerraformReferenceProperty<TerraformProperty<string>>("", "target_kafka_cluster_alias");

    /// <summary>
    /// The target_kafka_cluster_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetKafkaClusterArn is required")]
    [TerraformPropertyName("target_kafka_cluster_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> TargetKafkaClusterArn { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsMskReplicatorTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a aws_msk_replicator resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsMskReplicator : TerraformResource
{
    public AwsMskReplicator(string name) : base("aws_msk_replicator", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The replicator_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicatorName is required")]
    [TerraformPropertyName("replicator_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ReplicatorName { get; set; }

    /// <summary>
    /// The service_execution_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceExecutionRoleArn is required")]
    [TerraformPropertyName("service_execution_role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ServiceExecutionRoleArn { get; set; }

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
    /// Block for kafka_cluster.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(2, ErrorMessage = "At least 2 KafkaCluster block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(2, ErrorMessage = "Maximum 2 KafkaCluster block(s) allowed")]
    [TerraformPropertyName("kafka_cluster")]
    public TerraformList<TerraformBlock<AwsMskReplicatorKafkaClusterBlock>>? KafkaCluster { get; set; } = new();

    /// <summary>
    /// Block for replication_info_list.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationInfoList is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ReplicationInfoList block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReplicationInfoList block(s) allowed")]
    [TerraformPropertyName("replication_info_list")]
    public TerraformList<TerraformBlock<AwsMskReplicatorReplicationInfoListBlock>>? ReplicationInfoList { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsMskReplicatorTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The current_version attribute.
    /// </summary>
    [TerraformPropertyName("current_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CurrentVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "current_version");

}
