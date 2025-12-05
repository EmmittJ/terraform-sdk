using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for kafka_cluster in AwsMskReplicator.
/// Nesting mode: list
/// </summary>
public class AwsMskReplicatorKafkaClusterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "kafka_cluster";

    /// <summary>
    /// AmazonMskCluster block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AmazonMskCluster is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AmazonMskCluster block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AmazonMskCluster block(s) allowed")]
    public required TerraformList<AwsMskReplicatorKafkaClusterBlockAmazonMskClusterBlock> AmazonMskCluster
    {
        get => GetRequiredArgument<TerraformList<AwsMskReplicatorKafkaClusterBlockAmazonMskClusterBlock>>("amazon_msk_cluster");
        set => SetArgument("amazon_msk_cluster", value);
    }

    /// <summary>
    /// VpcConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 VpcConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcConfig block(s) allowed")]
    public required TerraformList<AwsMskReplicatorKafkaClusterBlockVpcConfigBlock> VpcConfig
    {
        get => GetRequiredArgument<TerraformList<AwsMskReplicatorKafkaClusterBlockVpcConfigBlock>>("vpc_config");
        set => SetArgument("vpc_config", value);
    }

}

/// <summary>
/// Block type for amazon_msk_cluster in AwsMskReplicatorKafkaClusterBlock.
/// Nesting mode: list
/// </summary>
public class AwsMskReplicatorKafkaClusterBlockAmazonMskClusterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "amazon_msk_cluster";

    /// <summary>
    /// The msk_cluster_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MskClusterArn is required")]
    public required TerraformValue<string> MskClusterArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("msk_cluster_arn");
        set => SetArgument("msk_cluster_arn", value);
    }

}

/// <summary>
/// Block type for vpc_config in AwsMskReplicatorKafkaClusterBlock.
/// Nesting mode: list
/// </summary>
public class AwsMskReplicatorKafkaClusterBlockVpcConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "vpc_config";

    /// <summary>
    /// The security_groups_ids attribute.
    /// </summary>
    public TerraformSet<string>? SecurityGroupsIds
    {
        get => GetArgument<TerraformSet<string>>("security_groups_ids");
        set => SetArgument("security_groups_ids", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    public required TerraformSet<string> SubnetIds
    {
        get => GetRequiredArgument<TerraformSet<string>>("subnet_ids");
        set => SetArgument("subnet_ids", value);
    }

}


/// <summary>
/// Block type for replication_info_list in AwsMskReplicator.
/// Nesting mode: list
/// </summary>
public class AwsMskReplicatorReplicationInfoListBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "replication_info_list";

    /// <summary>
    /// The source_kafka_cluster_alias attribute.
    /// </summary>
    public TerraformValue<string> SourceKafkaClusterAlias
        => CreateReference("source_kafka_cluster_alias");

    /// <summary>
    /// The source_kafka_cluster_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceKafkaClusterArn is required")]
    public required TerraformValue<string> SourceKafkaClusterArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("source_kafka_cluster_arn");
        set => SetArgument("source_kafka_cluster_arn", value);
    }

    /// <summary>
    /// The target_compression_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetCompressionType is required")]
    public required TerraformValue<string> TargetCompressionType
    {
        get => GetRequiredArgument<TerraformValue<string>>("target_compression_type");
        set => SetArgument("target_compression_type", value);
    }

    /// <summary>
    /// The target_kafka_cluster_alias attribute.
    /// </summary>
    public TerraformValue<string> TargetKafkaClusterAlias
        => CreateReference("target_kafka_cluster_alias");

    /// <summary>
    /// The target_kafka_cluster_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetKafkaClusterArn is required")]
    public required TerraformValue<string> TargetKafkaClusterArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("target_kafka_cluster_arn");
        set => SetArgument("target_kafka_cluster_arn", value);
    }

    /// <summary>
    /// ConsumerGroupReplication block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConsumerGroupReplication is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ConsumerGroupReplication block(s) required")]
    public required TerraformList<AwsMskReplicatorReplicationInfoListBlockConsumerGroupReplicationBlock> ConsumerGroupReplication
    {
        get => GetRequiredArgument<TerraformList<AwsMskReplicatorReplicationInfoListBlockConsumerGroupReplicationBlock>>("consumer_group_replication");
        set => SetArgument("consumer_group_replication", value);
    }

    /// <summary>
    /// TopicReplication block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TopicReplication is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 TopicReplication block(s) required")]
    public required TerraformList<AwsMskReplicatorReplicationInfoListBlockTopicReplicationBlock> TopicReplication
    {
        get => GetRequiredArgument<TerraformList<AwsMskReplicatorReplicationInfoListBlockTopicReplicationBlock>>("topic_replication");
        set => SetArgument("topic_replication", value);
    }

}

/// <summary>
/// Block type for consumer_group_replication in AwsMskReplicatorReplicationInfoListBlock.
/// Nesting mode: list
/// </summary>
public class AwsMskReplicatorReplicationInfoListBlockConsumerGroupReplicationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "consumer_group_replication";

    /// <summary>
    /// The consumer_groups_to_exclude attribute.
    /// </summary>
    public TerraformSet<string>? ConsumerGroupsToExclude
    {
        get => GetArgument<TerraformSet<string>>("consumer_groups_to_exclude");
        set => SetArgument("consumer_groups_to_exclude", value);
    }

    /// <summary>
    /// The consumer_groups_to_replicate attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConsumerGroupsToReplicate is required")]
    public required TerraformSet<string> ConsumerGroupsToReplicate
    {
        get => GetRequiredArgument<TerraformSet<string>>("consumer_groups_to_replicate");
        set => SetArgument("consumer_groups_to_replicate", value);
    }

    /// <summary>
    /// The detect_and_copy_new_consumer_groups attribute.
    /// </summary>
    public TerraformValue<bool>? DetectAndCopyNewConsumerGroups
    {
        get => GetArgument<TerraformValue<bool>>("detect_and_copy_new_consumer_groups");
        set => SetArgument("detect_and_copy_new_consumer_groups", value);
    }

    /// <summary>
    /// The synchronise_consumer_group_offsets attribute.
    /// </summary>
    public TerraformValue<bool>? SynchroniseConsumerGroupOffsets
    {
        get => GetArgument<TerraformValue<bool>>("synchronise_consumer_group_offsets");
        set => SetArgument("synchronise_consumer_group_offsets", value);
    }

}

/// <summary>
/// Block type for topic_replication in AwsMskReplicatorReplicationInfoListBlock.
/// Nesting mode: list
/// </summary>
public class AwsMskReplicatorReplicationInfoListBlockTopicReplicationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "topic_replication";

    /// <summary>
    /// The copy_access_control_lists_for_topics attribute.
    /// </summary>
    public TerraformValue<bool>? CopyAccessControlListsForTopics
    {
        get => GetArgument<TerraformValue<bool>>("copy_access_control_lists_for_topics");
        set => SetArgument("copy_access_control_lists_for_topics", value);
    }

    /// <summary>
    /// The copy_topic_configurations attribute.
    /// </summary>
    public TerraformValue<bool>? CopyTopicConfigurations
    {
        get => GetArgument<TerraformValue<bool>>("copy_topic_configurations");
        set => SetArgument("copy_topic_configurations", value);
    }

    /// <summary>
    /// The detect_and_copy_new_topics attribute.
    /// </summary>
    public TerraformValue<bool>? DetectAndCopyNewTopics
    {
        get => GetArgument<TerraformValue<bool>>("detect_and_copy_new_topics");
        set => SetArgument("detect_and_copy_new_topics", value);
    }

    /// <summary>
    /// The topics_to_exclude attribute.
    /// </summary>
    public TerraformSet<string>? TopicsToExclude
    {
        get => GetArgument<TerraformSet<string>>("topics_to_exclude");
        set => SetArgument("topics_to_exclude", value);
    }

    /// <summary>
    /// The topics_to_replicate attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TopicsToReplicate is required")]
    public required TerraformSet<string> TopicsToReplicate
    {
        get => GetRequiredArgument<TerraformSet<string>>("topics_to_replicate");
        set => SetArgument("topics_to_replicate", value);
    }

    /// <summary>
    /// StartingPosition block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StartingPosition block(s) allowed")]
    public TerraformList<AwsMskReplicatorReplicationInfoListBlockTopicReplicationBlockStartingPositionBlock>? StartingPosition
    {
        get => GetArgument<TerraformList<AwsMskReplicatorReplicationInfoListBlockTopicReplicationBlockStartingPositionBlock>>("starting_position");
        set => SetArgument("starting_position", value);
    }

    /// <summary>
    /// TopicNameConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TopicNameConfiguration block(s) allowed")]
    public TerraformList<AwsMskReplicatorReplicationInfoListBlockTopicReplicationBlockTopicNameConfigurationBlock>? TopicNameConfiguration
    {
        get => GetArgument<TerraformList<AwsMskReplicatorReplicationInfoListBlockTopicReplicationBlockTopicNameConfigurationBlock>>("topic_name_configuration");
        set => SetArgument("topic_name_configuration", value);
    }

}

/// <summary>
/// Block type for starting_position in AwsMskReplicatorReplicationInfoListBlockTopicReplicationBlock.
/// Nesting mode: list
/// </summary>
public class AwsMskReplicatorReplicationInfoListBlockTopicReplicationBlockStartingPositionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "starting_position";

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for topic_name_configuration in AwsMskReplicatorReplicationInfoListBlockTopicReplicationBlock.
/// Nesting mode: list
/// </summary>
public class AwsMskReplicatorReplicationInfoListBlockTopicReplicationBlockTopicNameConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "topic_name_configuration";

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsMskReplicator.
/// Nesting mode: single
/// </summary>
public class AwsMskReplicatorTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_msk_replicator Terraform resource.
/// Manages a aws_msk_replicator resource.
/// </summary>
public partial class AwsMskReplicator(string name) : TerraformResource("aws_msk_replicator", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The replicator_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicatorName is required")]
    public required TerraformValue<string> ReplicatorName
    {
        get => GetRequiredArgument<TerraformValue<string>>("replicator_name");
        set => SetArgument("replicator_name", value);
    }

    /// <summary>
    /// The service_execution_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceExecutionRoleArn is required")]
    public required TerraformValue<string> ServiceExecutionRoleArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("service_execution_role_arn");
        set => SetArgument("service_execution_role_arn", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? CreateReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The current_version attribute.
    /// </summary>
    public TerraformValue<string> CurrentVersion
        => CreateReference("current_version");

    /// <summary>
    /// KafkaCluster block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(2, ErrorMessage = "At least 2 KafkaCluster block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(2, ErrorMessage = "Maximum 2 KafkaCluster block(s) allowed")]
    public TerraformList<AwsMskReplicatorKafkaClusterBlock>? KafkaCluster
    {
        get => GetArgument<TerraformList<AwsMskReplicatorKafkaClusterBlock>>("kafka_cluster");
        set => SetArgument("kafka_cluster", value);
    }

    /// <summary>
    /// ReplicationInfoList block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationInfoList is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ReplicationInfoList block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReplicationInfoList block(s) allowed")]
    public required TerraformList<AwsMskReplicatorReplicationInfoListBlock> ReplicationInfoList
    {
        get => GetRequiredArgument<TerraformList<AwsMskReplicatorReplicationInfoListBlock>>("replication_info_list");
        set => SetArgument("replication_info_list", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsMskReplicatorTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsMskReplicatorTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
