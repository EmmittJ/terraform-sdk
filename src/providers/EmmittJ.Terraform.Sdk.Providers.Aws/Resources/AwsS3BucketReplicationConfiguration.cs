using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for rule in AwsS3BucketReplicationConfiguration.
/// Nesting mode: list
/// </summary>
public class AwsS3BucketReplicationConfigurationRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rule";

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string>? Prefix
    {
        get => GetArgument<TerraformValue<string>>("prefix");
        set => SetArgument("prefix", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    public TerraformValue<double>? Priority
    {
        get => GetArgument<TerraformValue<double>>("priority");
        set => SetArgument("priority", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Status is required")]
    public required TerraformValue<string> Status
    {
        get => GetRequiredArgument<TerraformValue<string>>("status");
        set => SetArgument("status", value);
    }

    /// <summary>
    /// DeleteMarkerReplication block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeleteMarkerReplication block(s) allowed")]
    public TerraformList<AwsS3BucketReplicationConfigurationRuleBlockDeleteMarkerReplicationBlock>? DeleteMarkerReplication
    {
        get => GetArgument<TerraformList<AwsS3BucketReplicationConfigurationRuleBlockDeleteMarkerReplicationBlock>>("delete_marker_replication");
        set => SetArgument("delete_marker_replication", value);
    }

    /// <summary>
    /// Destination block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destination is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Destination block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Destination block(s) allowed")]
    public required TerraformList<AwsS3BucketReplicationConfigurationRuleBlockDestinationBlock> Destination
    {
        get => GetRequiredArgument<TerraformList<AwsS3BucketReplicationConfigurationRuleBlockDestinationBlock>>("destination");
        set => SetArgument("destination", value);
    }

    /// <summary>
    /// ExistingObjectReplication block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExistingObjectReplication block(s) allowed")]
    public TerraformList<AwsS3BucketReplicationConfigurationRuleBlockExistingObjectReplicationBlock>? ExistingObjectReplication
    {
        get => GetArgument<TerraformList<AwsS3BucketReplicationConfigurationRuleBlockExistingObjectReplicationBlock>>("existing_object_replication");
        set => SetArgument("existing_object_replication", value);
    }

    /// <summary>
    /// Filter block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Filter block(s) allowed")]
    public TerraformList<AwsS3BucketReplicationConfigurationRuleBlockFilterBlock>? Filter
    {
        get => GetArgument<TerraformList<AwsS3BucketReplicationConfigurationRuleBlockFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

    /// <summary>
    /// SourceSelectionCriteria block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceSelectionCriteria block(s) allowed")]
    public TerraformList<AwsS3BucketReplicationConfigurationRuleBlockSourceSelectionCriteriaBlock>? SourceSelectionCriteria
    {
        get => GetArgument<TerraformList<AwsS3BucketReplicationConfigurationRuleBlockSourceSelectionCriteriaBlock>>("source_selection_criteria");
        set => SetArgument("source_selection_criteria", value);
    }

}

/// <summary>
/// Block type for delete_marker_replication in AwsS3BucketReplicationConfigurationRuleBlock.
/// Nesting mode: list
/// </summary>
public class AwsS3BucketReplicationConfigurationRuleBlockDeleteMarkerReplicationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "delete_marker_replication";

    /// <summary>
    /// The status attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Status is required")]
    public required TerraformValue<string> Status
    {
        get => GetRequiredArgument<TerraformValue<string>>("status");
        set => SetArgument("status", value);
    }

}

/// <summary>
/// Block type for destination in AwsS3BucketReplicationConfigurationRuleBlock.
/// Nesting mode: list
/// </summary>
public class AwsS3BucketReplicationConfigurationRuleBlockDestinationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "destination";

    /// <summary>
    /// The account attribute.
    /// </summary>
    public TerraformValue<string>? Account
    {
        get => GetArgument<TerraformValue<string>>("account");
        set => SetArgument("account", value);
    }

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformValue<string> Bucket
    {
        get => GetRequiredArgument<TerraformValue<string>>("bucket");
        set => SetArgument("bucket", value);
    }

    /// <summary>
    /// The storage_class attribute.
    /// </summary>
    public TerraformValue<string>? StorageClass
    {
        get => GetArgument<TerraformValue<string>>("storage_class");
        set => SetArgument("storage_class", value);
    }

    /// <summary>
    /// AccessControlTranslation block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccessControlTranslation block(s) allowed")]
    public TerraformList<AwsS3BucketReplicationConfigurationRuleBlockDestinationBlockAccessControlTranslationBlock>? AccessControlTranslation
    {
        get => GetArgument<TerraformList<AwsS3BucketReplicationConfigurationRuleBlockDestinationBlockAccessControlTranslationBlock>>("access_control_translation");
        set => SetArgument("access_control_translation", value);
    }

    /// <summary>
    /// EncryptionConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionConfiguration block(s) allowed")]
    public TerraformList<AwsS3BucketReplicationConfigurationRuleBlockDestinationBlockEncryptionConfigurationBlock>? EncryptionConfiguration
    {
        get => GetArgument<TerraformList<AwsS3BucketReplicationConfigurationRuleBlockDestinationBlockEncryptionConfigurationBlock>>("encryption_configuration");
        set => SetArgument("encryption_configuration", value);
    }

    /// <summary>
    /// Metrics block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Metrics block(s) allowed")]
    public TerraformList<AwsS3BucketReplicationConfigurationRuleBlockDestinationBlockMetricsBlock>? Metrics
    {
        get => GetArgument<TerraformList<AwsS3BucketReplicationConfigurationRuleBlockDestinationBlockMetricsBlock>>("metrics");
        set => SetArgument("metrics", value);
    }

    /// <summary>
    /// ReplicationTime block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReplicationTime block(s) allowed")]
    public TerraformList<AwsS3BucketReplicationConfigurationRuleBlockDestinationBlockReplicationTimeBlock>? ReplicationTime
    {
        get => GetArgument<TerraformList<AwsS3BucketReplicationConfigurationRuleBlockDestinationBlockReplicationTimeBlock>>("replication_time");
        set => SetArgument("replication_time", value);
    }

}

/// <summary>
/// Block type for access_control_translation in AwsS3BucketReplicationConfigurationRuleBlockDestinationBlock.
/// Nesting mode: list
/// </summary>
public class AwsS3BucketReplicationConfigurationRuleBlockDestinationBlockAccessControlTranslationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "access_control_translation";

    /// <summary>
    /// The owner attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Owner is required")]
    public required TerraformValue<string> Owner
    {
        get => GetRequiredArgument<TerraformValue<string>>("owner");
        set => SetArgument("owner", value);
    }

}

/// <summary>
/// Block type for encryption_configuration in AwsS3BucketReplicationConfigurationRuleBlockDestinationBlock.
/// Nesting mode: list
/// </summary>
public class AwsS3BucketReplicationConfigurationRuleBlockDestinationBlockEncryptionConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "encryption_configuration";

    /// <summary>
    /// The replica_kms_key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicaKmsKeyId is required")]
    public required TerraformValue<string> ReplicaKmsKeyId
    {
        get => GetRequiredArgument<TerraformValue<string>>("replica_kms_key_id");
        set => SetArgument("replica_kms_key_id", value);
    }

}

/// <summary>
/// Block type for metrics in AwsS3BucketReplicationConfigurationRuleBlockDestinationBlock.
/// Nesting mode: list
/// </summary>
public class AwsS3BucketReplicationConfigurationRuleBlockDestinationBlockMetricsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "metrics";

    /// <summary>
    /// The status attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Status is required")]
    public required TerraformValue<string> Status
    {
        get => GetRequiredArgument<TerraformValue<string>>("status");
        set => SetArgument("status", value);
    }

    /// <summary>
    /// EventThreshold block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EventThreshold block(s) allowed")]
    public TerraformList<AwsS3BucketReplicationConfigurationRuleBlockDestinationBlockMetricsBlockEventThresholdBlock>? EventThreshold
    {
        get => GetArgument<TerraformList<AwsS3BucketReplicationConfigurationRuleBlockDestinationBlockMetricsBlockEventThresholdBlock>>("event_threshold");
        set => SetArgument("event_threshold", value);
    }

}

/// <summary>
/// Block type for event_threshold in AwsS3BucketReplicationConfigurationRuleBlockDestinationBlockMetricsBlock.
/// Nesting mode: list
/// </summary>
public class AwsS3BucketReplicationConfigurationRuleBlockDestinationBlockMetricsBlockEventThresholdBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "event_threshold";

    /// <summary>
    /// The minutes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Minutes is required")]
    public required TerraformValue<double> Minutes
    {
        get => GetRequiredArgument<TerraformValue<double>>("minutes");
        set => SetArgument("minutes", value);
    }

}

/// <summary>
/// Block type for replication_time in AwsS3BucketReplicationConfigurationRuleBlockDestinationBlock.
/// Nesting mode: list
/// </summary>
public class AwsS3BucketReplicationConfigurationRuleBlockDestinationBlockReplicationTimeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "replication_time";

    /// <summary>
    /// The status attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Status is required")]
    public required TerraformValue<string> Status
    {
        get => GetRequiredArgument<TerraformValue<string>>("status");
        set => SetArgument("status", value);
    }

    /// <summary>
    /// Time block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Time is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Time block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Time block(s) allowed")]
    public required TerraformList<AwsS3BucketReplicationConfigurationRuleBlockDestinationBlockReplicationTimeBlockTimeBlock> Time
    {
        get => GetRequiredArgument<TerraformList<AwsS3BucketReplicationConfigurationRuleBlockDestinationBlockReplicationTimeBlockTimeBlock>>("time");
        set => SetArgument("time", value);
    }

}

/// <summary>
/// Block type for time in AwsS3BucketReplicationConfigurationRuleBlockDestinationBlockReplicationTimeBlock.
/// Nesting mode: list
/// </summary>
public class AwsS3BucketReplicationConfigurationRuleBlockDestinationBlockReplicationTimeBlockTimeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "time";

    /// <summary>
    /// The minutes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Minutes is required")]
    public required TerraformValue<double> Minutes
    {
        get => GetRequiredArgument<TerraformValue<double>>("minutes");
        set => SetArgument("minutes", value);
    }

}

/// <summary>
/// Block type for existing_object_replication in AwsS3BucketReplicationConfigurationRuleBlock.
/// Nesting mode: list
/// </summary>
public class AwsS3BucketReplicationConfigurationRuleBlockExistingObjectReplicationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "existing_object_replication";

    /// <summary>
    /// The status attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Status is required")]
    public required TerraformValue<string> Status
    {
        get => GetRequiredArgument<TerraformValue<string>>("status");
        set => SetArgument("status", value);
    }

}

/// <summary>
/// Block type for filter in AwsS3BucketReplicationConfigurationRuleBlock.
/// Nesting mode: list
/// </summary>
public class AwsS3BucketReplicationConfigurationRuleBlockFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filter";

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    public TerraformValue<string>? Prefix
    {
        get => GetArgument<TerraformValue<string>>("prefix");
        set => SetArgument("prefix", value);
    }

    /// <summary>
    /// And block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 And block(s) allowed")]
    public TerraformList<AwsS3BucketReplicationConfigurationRuleBlockFilterBlockAndBlock>? And
    {
        get => GetArgument<TerraformList<AwsS3BucketReplicationConfigurationRuleBlockFilterBlockAndBlock>>("and");
        set => SetArgument("and", value);
    }

    /// <summary>
    /// Tag block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Tag block(s) allowed")]
    public TerraformList<AwsS3BucketReplicationConfigurationRuleBlockFilterBlockTagBlock>? Tag
    {
        get => GetArgument<TerraformList<AwsS3BucketReplicationConfigurationRuleBlockFilterBlockTagBlock>>("tag");
        set => SetArgument("tag", value);
    }

}

/// <summary>
/// Block type for and in AwsS3BucketReplicationConfigurationRuleBlockFilterBlock.
/// Nesting mode: list
/// </summary>
public class AwsS3BucketReplicationConfigurationRuleBlockFilterBlockAndBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "and";

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    public TerraformValue<string>? Prefix
    {
        get => GetArgument<TerraformValue<string>>("prefix");
        set => SetArgument("prefix", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

}

/// <summary>
/// Block type for tag in AwsS3BucketReplicationConfigurationRuleBlockFilterBlock.
/// Nesting mode: list
/// </summary>
public class AwsS3BucketReplicationConfigurationRuleBlockFilterBlockTagBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tag";

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetRequiredArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for source_selection_criteria in AwsS3BucketReplicationConfigurationRuleBlock.
/// Nesting mode: list
/// </summary>
public class AwsS3BucketReplicationConfigurationRuleBlockSourceSelectionCriteriaBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "source_selection_criteria";

    /// <summary>
    /// ReplicaModifications block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReplicaModifications block(s) allowed")]
    public TerraformList<AwsS3BucketReplicationConfigurationRuleBlockSourceSelectionCriteriaBlockReplicaModificationsBlock>? ReplicaModifications
    {
        get => GetArgument<TerraformList<AwsS3BucketReplicationConfigurationRuleBlockSourceSelectionCriteriaBlockReplicaModificationsBlock>>("replica_modifications");
        set => SetArgument("replica_modifications", value);
    }

    /// <summary>
    /// SseKmsEncryptedObjects block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SseKmsEncryptedObjects block(s) allowed")]
    public TerraformList<AwsS3BucketReplicationConfigurationRuleBlockSourceSelectionCriteriaBlockSseKmsEncryptedObjectsBlock>? SseKmsEncryptedObjects
    {
        get => GetArgument<TerraformList<AwsS3BucketReplicationConfigurationRuleBlockSourceSelectionCriteriaBlockSseKmsEncryptedObjectsBlock>>("sse_kms_encrypted_objects");
        set => SetArgument("sse_kms_encrypted_objects", value);
    }

}

/// <summary>
/// Block type for replica_modifications in AwsS3BucketReplicationConfigurationRuleBlockSourceSelectionCriteriaBlock.
/// Nesting mode: list
/// </summary>
public class AwsS3BucketReplicationConfigurationRuleBlockSourceSelectionCriteriaBlockReplicaModificationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "replica_modifications";

    /// <summary>
    /// The status attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Status is required")]
    public required TerraformValue<string> Status
    {
        get => GetRequiredArgument<TerraformValue<string>>("status");
        set => SetArgument("status", value);
    }

}

/// <summary>
/// Block type for sse_kms_encrypted_objects in AwsS3BucketReplicationConfigurationRuleBlockSourceSelectionCriteriaBlock.
/// Nesting mode: list
/// </summary>
public class AwsS3BucketReplicationConfigurationRuleBlockSourceSelectionCriteriaBlockSseKmsEncryptedObjectsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sse_kms_encrypted_objects";

    /// <summary>
    /// The status attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Status is required")]
    public required TerraformValue<string> Status
    {
        get => GetRequiredArgument<TerraformValue<string>>("status");
        set => SetArgument("status", value);
    }

}


/// <summary>
/// Represents a aws_s3_bucket_replication_configuration Terraform resource.
/// Manages a aws_s3_bucket_replication_configuration resource.
/// </summary>
public partial class AwsS3BucketReplicationConfiguration(string name) : TerraformResource("aws_s3_bucket_replication_configuration", name)
{
    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformValue<string> Bucket
    {
        get => GetRequiredArgument<TerraformValue<string>>("bucket");
        set => SetArgument("bucket", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Role is required")]
    public required TerraformValue<string> Role
    {
        get => GetRequiredArgument<TerraformValue<string>>("role");
        set => SetArgument("role", value);
    }

    /// <summary>
    /// The token attribute.
    /// </summary>
    public TerraformValue<string>? Token
    {
        get => GetArgument<TerraformValue<string>>("token");
        set => SetArgument("token", value);
    }

    /// <summary>
    /// Rule block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Rule block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1000, ErrorMessage = "Maximum 1000 Rule block(s) allowed")]
    public required TerraformList<AwsS3BucketReplicationConfigurationRuleBlock> Rule
    {
        get => GetRequiredArgument<TerraformList<AwsS3BucketReplicationConfigurationRuleBlock>>("rule");
        set => SetArgument("rule", value);
    }

}
