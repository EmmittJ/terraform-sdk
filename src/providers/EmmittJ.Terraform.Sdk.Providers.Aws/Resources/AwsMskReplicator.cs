using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for kafka_cluster in .
/// Nesting mode: list
/// </summary>
public class AwsMskReplicatorKafkaClusterBlock : TerraformBlock
{
}

/// <summary>
/// Block type for replication_info_list in .
/// Nesting mode: list
/// </summary>
public class AwsMskReplicatorReplicationInfoListBlock : TerraformBlock
{
    /// <summary>
    /// The source_kafka_cluster_alias attribute.
    /// </summary>
    public TerraformProperty<string>? SourceKafkaClusterAlias
    {
        get => GetProperty<TerraformProperty<string>>("source_kafka_cluster_alias");
        set => WithProperty("source_kafka_cluster_alias", value);
    }

    /// <summary>
    /// The source_kafka_cluster_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceKafkaClusterArn is required")]
    public required TerraformProperty<string> SourceKafkaClusterArn
    {
        get => GetRequiredProperty<TerraformProperty<string>>("source_kafka_cluster_arn");
        set => WithProperty("source_kafka_cluster_arn", value);
    }

    /// <summary>
    /// The target_compression_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetCompressionType is required")]
    public required TerraformProperty<string> TargetCompressionType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("target_compression_type");
        set => WithProperty("target_compression_type", value);
    }

    /// <summary>
    /// The target_kafka_cluster_alias attribute.
    /// </summary>
    public TerraformProperty<string>? TargetKafkaClusterAlias
    {
        get => GetProperty<TerraformProperty<string>>("target_kafka_cluster_alias");
        set => WithProperty("target_kafka_cluster_alias", value);
    }

    /// <summary>
    /// The target_kafka_cluster_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetKafkaClusterArn is required")]
    public required TerraformProperty<string> TargetKafkaClusterArn
    {
        get => GetRequiredProperty<TerraformProperty<string>>("target_kafka_cluster_arn");
        set => WithProperty("target_kafka_cluster_arn", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsMskReplicatorTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_msk_replicator resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsMskReplicator : TerraformResource
{
    public AwsMskReplicator(string name) : base("aws_msk_replicator", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
        this.WithOutput("current_version");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The replicator_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicatorName is required")]
    public required TerraformProperty<string> ReplicatorName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("replicator_name");
        set => this.WithProperty("replicator_name", value);
    }

    /// <summary>
    /// The service_execution_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceExecutionRoleArn is required")]
    public required TerraformProperty<string> ServiceExecutionRoleArn
    {
        get => GetRequiredProperty<TerraformProperty<string>>("service_execution_role_arn");
        set => this.WithProperty("service_execution_role_arn", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// Block for kafka_cluster.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(2, ErrorMessage = "At least 2 KafkaCluster block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(2, ErrorMessage = "Maximum 2 KafkaCluster block(s) allowed")]
    public List<AwsMskReplicatorKafkaClusterBlock>? KafkaCluster
    {
        get => GetProperty<List<AwsMskReplicatorKafkaClusterBlock>>("kafka_cluster");
        set => this.WithProperty("kafka_cluster", value);
    }

    /// <summary>
    /// Block for replication_info_list.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ReplicationInfoList block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReplicationInfoList block(s) allowed")]
    public List<AwsMskReplicatorReplicationInfoListBlock>? ReplicationInfoList
    {
        get => GetProperty<List<AwsMskReplicatorReplicationInfoListBlock>>("replication_info_list");
        set => this.WithProperty("replication_info_list", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsMskReplicatorTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsMskReplicatorTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The current_version attribute.
    /// </summary>
    public TerraformExpression CurrentVersion => this["current_version"];

}
