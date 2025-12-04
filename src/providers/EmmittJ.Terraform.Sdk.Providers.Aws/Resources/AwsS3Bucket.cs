using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for cors_rule in AwsS3Bucket.
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public class AwsS3BucketCorsRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cors_rule";

    /// <summary>
    /// The allowed_headers attribute.
    /// </summary>
    public TerraformList<string>? AllowedHeaders
    {
        get => GetArgument<TerraformList<string>>("allowed_headers");
        set => SetArgument("allowed_headers", value);
    }

    /// <summary>
    /// The allowed_methods attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedMethods is required")]
    public TerraformList<string>? AllowedMethods
    {
        get => GetArgument<TerraformList<string>>("allowed_methods");
        set => SetArgument("allowed_methods", value);
    }

    /// <summary>
    /// The allowed_origins attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedOrigins is required")]
    public TerraformList<string>? AllowedOrigins
    {
        get => GetArgument<TerraformList<string>>("allowed_origins");
        set => SetArgument("allowed_origins", value);
    }

    /// <summary>
    /// The expose_headers attribute.
    /// </summary>
    public TerraformList<string>? ExposeHeaders
    {
        get => GetArgument<TerraformList<string>>("expose_headers");
        set => SetArgument("expose_headers", value);
    }

    /// <summary>
    /// The max_age_seconds attribute.
    /// </summary>
    public TerraformValue<double>? MaxAgeSeconds
    {
        get => GetArgument<TerraformValue<double>>("max_age_seconds");
        set => SetArgument("max_age_seconds", value);
    }

}


/// <summary>
/// Block type for grant in AwsS3Bucket.
/// Nesting mode: set
/// </summary>
[Obsolete("This block is deprecated.")]
public class AwsS3BucketGrantBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "grant";

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The permissions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Permissions is required")]
    public required TerraformSet<string> Permissions
    {
        get => GetRequiredArgument<TerraformSet<string>>("permissions");
        set => SetArgument("permissions", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    public TerraformValue<string>? Uri
    {
        get => GetArgument<TerraformValue<string>>("uri");
        set => SetArgument("uri", value);
    }

}


/// <summary>
/// Block type for lifecycle_rule in AwsS3Bucket.
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public class AwsS3BucketLifecycleRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "lifecycle_rule";

    /// <summary>
    /// The abort_incomplete_multipart_upload_days attribute.
    /// </summary>
    public TerraformValue<double>? AbortIncompleteMultipartUploadDays
    {
        get => GetArgument<TerraformValue<double>>("abort_incomplete_multipart_upload_days");
        set => SetArgument("abort_incomplete_multipart_upload_days", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
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

    /// <summary>
    /// Expiration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Expiration block(s) allowed")]
    public TerraformList<AwsS3BucketLifecycleRuleBlockExpirationBlock>? Expiration
    {
        get => GetArgument<TerraformList<AwsS3BucketLifecycleRuleBlockExpirationBlock>>("expiration");
        set => SetArgument("expiration", value);
    }

    /// <summary>
    /// NoncurrentVersionExpiration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NoncurrentVersionExpiration block(s) allowed")]
    public TerraformList<AwsS3BucketLifecycleRuleBlockNoncurrentVersionExpirationBlock>? NoncurrentVersionExpiration
    {
        get => GetArgument<TerraformList<AwsS3BucketLifecycleRuleBlockNoncurrentVersionExpirationBlock>>("noncurrent_version_expiration");
        set => SetArgument("noncurrent_version_expiration", value);
    }

    /// <summary>
    /// NoncurrentVersionTransition block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsS3BucketLifecycleRuleBlockNoncurrentVersionTransitionBlock>? NoncurrentVersionTransition
    {
        get => GetArgument<TerraformSet<AwsS3BucketLifecycleRuleBlockNoncurrentVersionTransitionBlock>>("noncurrent_version_transition");
        set => SetArgument("noncurrent_version_transition", value);
    }

    /// <summary>
    /// Transition block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsS3BucketLifecycleRuleBlockTransitionBlock>? Transition
    {
        get => GetArgument<TerraformSet<AwsS3BucketLifecycleRuleBlockTransitionBlock>>("transition");
        set => SetArgument("transition", value);
    }

}

/// <summary>
/// Block type for expiration in AwsS3BucketLifecycleRuleBlock.
/// Nesting mode: list
/// </summary>
public class AwsS3BucketLifecycleRuleBlockExpirationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "expiration";

    /// <summary>
    /// The date attribute.
    /// </summary>
    public TerraformValue<string>? Date
    {
        get => GetArgument<TerraformValue<string>>("date");
        set => SetArgument("date", value);
    }

    /// <summary>
    /// The days attribute.
    /// </summary>
    public TerraformValue<double>? Days
    {
        get => GetArgument<TerraformValue<double>>("days");
        set => SetArgument("days", value);
    }

    /// <summary>
    /// The expired_object_delete_marker attribute.
    /// </summary>
    public TerraformValue<bool>? ExpiredObjectDeleteMarker
    {
        get => GetArgument<TerraformValue<bool>>("expired_object_delete_marker");
        set => SetArgument("expired_object_delete_marker", value);
    }

}

/// <summary>
/// Block type for noncurrent_version_expiration in AwsS3BucketLifecycleRuleBlock.
/// Nesting mode: list
/// </summary>
public class AwsS3BucketLifecycleRuleBlockNoncurrentVersionExpirationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "noncurrent_version_expiration";

    /// <summary>
    /// The days attribute.
    /// </summary>
    public TerraformValue<double>? Days
    {
        get => GetArgument<TerraformValue<double>>("days");
        set => SetArgument("days", value);
    }

}

/// <summary>
/// Block type for noncurrent_version_transition in AwsS3BucketLifecycleRuleBlock.
/// Nesting mode: set
/// </summary>
public class AwsS3BucketLifecycleRuleBlockNoncurrentVersionTransitionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "noncurrent_version_transition";

    /// <summary>
    /// The days attribute.
    /// </summary>
    public TerraformValue<double>? Days
    {
        get => GetArgument<TerraformValue<double>>("days");
        set => SetArgument("days", value);
    }

    /// <summary>
    /// The storage_class attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageClass is required")]
    public required TerraformValue<string> StorageClass
    {
        get => GetRequiredArgument<TerraformValue<string>>("storage_class");
        set => SetArgument("storage_class", value);
    }

}

/// <summary>
/// Block type for transition in AwsS3BucketLifecycleRuleBlock.
/// Nesting mode: set
/// </summary>
public class AwsS3BucketLifecycleRuleBlockTransitionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "transition";

    /// <summary>
    /// The date attribute.
    /// </summary>
    public TerraformValue<string>? Date
    {
        get => GetArgument<TerraformValue<string>>("date");
        set => SetArgument("date", value);
    }

    /// <summary>
    /// The days attribute.
    /// </summary>
    public TerraformValue<double>? Days
    {
        get => GetArgument<TerraformValue<double>>("days");
        set => SetArgument("days", value);
    }

    /// <summary>
    /// The storage_class attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageClass is required")]
    public required TerraformValue<string> StorageClass
    {
        get => GetRequiredArgument<TerraformValue<string>>("storage_class");
        set => SetArgument("storage_class", value);
    }

}


/// <summary>
/// Block type for logging in AwsS3Bucket.
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public class AwsS3BucketLoggingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "logging";

    /// <summary>
    /// The target_bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetBucket is required")]
    public required TerraformValue<string> TargetBucket
    {
        get => GetRequiredArgument<TerraformValue<string>>("target_bucket");
        set => SetArgument("target_bucket", value);
    }

    /// <summary>
    /// The target_prefix attribute.
    /// </summary>
    public TerraformValue<string>? TargetPrefix
    {
        get => GetArgument<TerraformValue<string>>("target_prefix");
        set => SetArgument("target_prefix", value);
    }

}


/// <summary>
/// Block type for object_lock_configuration in AwsS3Bucket.
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public class AwsS3BucketObjectLockConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "object_lock_configuration";

    /// <summary>
    /// The object_lock_enabled attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string>? ObjectLockEnabled
    {
        get => GetArgument<TerraformValue<string>>("object_lock_enabled");
        set => SetArgument("object_lock_enabled", value);
    }

    /// <summary>
    /// Rule block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Rule block(s) allowed")]
    [Obsolete("This block is deprecated.")]
    public TerraformList<AwsS3BucketObjectLockConfigurationBlockRuleBlock>? Rule
    {
        get => GetArgument<TerraformList<AwsS3BucketObjectLockConfigurationBlockRuleBlock>>("rule");
        set => SetArgument("rule", value);
    }

}

/// <summary>
/// Block type for rule in AwsS3BucketObjectLockConfigurationBlock.
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public class AwsS3BucketObjectLockConfigurationBlockRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rule";

    /// <summary>
    /// DefaultRetention block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultRetention is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DefaultRetention block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultRetention block(s) allowed")]
    public required TerraformList<AwsS3BucketObjectLockConfigurationBlockRuleBlockDefaultRetentionBlock> DefaultRetention
    {
        get => GetRequiredArgument<TerraformList<AwsS3BucketObjectLockConfigurationBlockRuleBlockDefaultRetentionBlock>>("default_retention");
        set => SetArgument("default_retention", value);
    }

}

/// <summary>
/// Block type for default_retention in AwsS3BucketObjectLockConfigurationBlockRuleBlock.
/// Nesting mode: list
/// </summary>
public class AwsS3BucketObjectLockConfigurationBlockRuleBlockDefaultRetentionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "default_retention";

    /// <summary>
    /// The days attribute.
    /// </summary>
    public TerraformValue<double>? Days
    {
        get => GetArgument<TerraformValue<double>>("days");
        set => SetArgument("days", value);
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    public required TerraformValue<string> Mode
    {
        get => GetRequiredArgument<TerraformValue<string>>("mode");
        set => SetArgument("mode", value);
    }

    /// <summary>
    /// The years attribute.
    /// </summary>
    public TerraformValue<double>? Years
    {
        get => GetArgument<TerraformValue<double>>("years");
        set => SetArgument("years", value);
    }

}


/// <summary>
/// Block type for replication_configuration in AwsS3Bucket.
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public class AwsS3BucketReplicationConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "replication_configuration";

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
    /// Rules block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rules is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Rules block(s) required")]
    public required TerraformSet<AwsS3BucketReplicationConfigurationBlockRulesBlock> Rules
    {
        get => GetRequiredArgument<TerraformSet<AwsS3BucketReplicationConfigurationBlockRulesBlock>>("rules");
        set => SetArgument("rules", value);
    }

}

/// <summary>
/// Block type for rules in AwsS3BucketReplicationConfigurationBlock.
/// Nesting mode: set
/// </summary>
public class AwsS3BucketReplicationConfigurationBlockRulesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rules";

    /// <summary>
    /// The delete_marker_replication_status attribute.
    /// </summary>
    public TerraformValue<string>? DeleteMarkerReplicationStatus
    {
        get => GetArgument<TerraformValue<string>>("delete_marker_replication_status");
        set => SetArgument("delete_marker_replication_status", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
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
    /// Destination block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destination is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Destination block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Destination block(s) allowed")]
    public required TerraformList<AwsS3BucketReplicationConfigurationBlockRulesBlockDestinationBlock> Destination
    {
        get => GetRequiredArgument<TerraformList<AwsS3BucketReplicationConfigurationBlockRulesBlockDestinationBlock>>("destination");
        set => SetArgument("destination", value);
    }

    /// <summary>
    /// Filter block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Filter block(s) allowed")]
    public TerraformList<AwsS3BucketReplicationConfigurationBlockRulesBlockFilterBlock>? Filter
    {
        get => GetArgument<TerraformList<AwsS3BucketReplicationConfigurationBlockRulesBlockFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

    /// <summary>
    /// SourceSelectionCriteria block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceSelectionCriteria block(s) allowed")]
    public TerraformList<AwsS3BucketReplicationConfigurationBlockRulesBlockSourceSelectionCriteriaBlock>? SourceSelectionCriteria
    {
        get => GetArgument<TerraformList<AwsS3BucketReplicationConfigurationBlockRulesBlockSourceSelectionCriteriaBlock>>("source_selection_criteria");
        set => SetArgument("source_selection_criteria", value);
    }

}

/// <summary>
/// Block type for destination in AwsS3BucketReplicationConfigurationBlockRulesBlock.
/// Nesting mode: list
/// </summary>
public class AwsS3BucketReplicationConfigurationBlockRulesBlockDestinationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "destination";

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    public TerraformValue<string>? AccountId
    {
        get => GetArgument<TerraformValue<string>>("account_id");
        set => SetArgument("account_id", value);
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
    /// The replica_kms_key_id attribute.
    /// </summary>
    public TerraformValue<string>? ReplicaKmsKeyId
    {
        get => GetArgument<TerraformValue<string>>("replica_kms_key_id");
        set => SetArgument("replica_kms_key_id", value);
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
    public TerraformList<AwsS3BucketReplicationConfigurationBlockRulesBlockDestinationBlockAccessControlTranslationBlock>? AccessControlTranslation
    {
        get => GetArgument<TerraformList<AwsS3BucketReplicationConfigurationBlockRulesBlockDestinationBlockAccessControlTranslationBlock>>("access_control_translation");
        set => SetArgument("access_control_translation", value);
    }

    /// <summary>
    /// Metrics block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Metrics block(s) allowed")]
    public TerraformList<AwsS3BucketReplicationConfigurationBlockRulesBlockDestinationBlockMetricsBlock>? Metrics
    {
        get => GetArgument<TerraformList<AwsS3BucketReplicationConfigurationBlockRulesBlockDestinationBlockMetricsBlock>>("metrics");
        set => SetArgument("metrics", value);
    }

    /// <summary>
    /// ReplicationTime block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReplicationTime block(s) allowed")]
    public TerraformList<AwsS3BucketReplicationConfigurationBlockRulesBlockDestinationBlockReplicationTimeBlock>? ReplicationTime
    {
        get => GetArgument<TerraformList<AwsS3BucketReplicationConfigurationBlockRulesBlockDestinationBlockReplicationTimeBlock>>("replication_time");
        set => SetArgument("replication_time", value);
    }

}

/// <summary>
/// Block type for access_control_translation in AwsS3BucketReplicationConfigurationBlockRulesBlockDestinationBlock.
/// Nesting mode: list
/// </summary>
public class AwsS3BucketReplicationConfigurationBlockRulesBlockDestinationBlockAccessControlTranslationBlock : TerraformBlock
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
/// Block type for metrics in AwsS3BucketReplicationConfigurationBlockRulesBlockDestinationBlock.
/// Nesting mode: list
/// </summary>
public class AwsS3BucketReplicationConfigurationBlockRulesBlockDestinationBlockMetricsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "metrics";

    /// <summary>
    /// The minutes attribute.
    /// </summary>
    public TerraformValue<double>? Minutes
    {
        get => GetArgument<TerraformValue<double>>("minutes");
        set => SetArgument("minutes", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string>? Status
    {
        get => GetArgument<TerraformValue<string>>("status");
        set => SetArgument("status", value);
    }

}

/// <summary>
/// Block type for replication_time in AwsS3BucketReplicationConfigurationBlockRulesBlockDestinationBlock.
/// Nesting mode: list
/// </summary>
public class AwsS3BucketReplicationConfigurationBlockRulesBlockDestinationBlockReplicationTimeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "replication_time";

    /// <summary>
    /// The minutes attribute.
    /// </summary>
    public TerraformValue<double>? Minutes
    {
        get => GetArgument<TerraformValue<double>>("minutes");
        set => SetArgument("minutes", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string>? Status
    {
        get => GetArgument<TerraformValue<string>>("status");
        set => SetArgument("status", value);
    }

}

/// <summary>
/// Block type for filter in AwsS3BucketReplicationConfigurationBlockRulesBlock.
/// Nesting mode: list
/// </summary>
public class AwsS3BucketReplicationConfigurationBlockRulesBlockFilterBlock : TerraformBlock
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

}

/// <summary>
/// Block type for source_selection_criteria in AwsS3BucketReplicationConfigurationBlockRulesBlock.
/// Nesting mode: list
/// </summary>
public class AwsS3BucketReplicationConfigurationBlockRulesBlockSourceSelectionCriteriaBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "source_selection_criteria";

    /// <summary>
    /// SseKmsEncryptedObjects block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SseKmsEncryptedObjects block(s) allowed")]
    public TerraformList<AwsS3BucketReplicationConfigurationBlockRulesBlockSourceSelectionCriteriaBlockSseKmsEncryptedObjectsBlock>? SseKmsEncryptedObjects
    {
        get => GetArgument<TerraformList<AwsS3BucketReplicationConfigurationBlockRulesBlockSourceSelectionCriteriaBlockSseKmsEncryptedObjectsBlock>>("sse_kms_encrypted_objects");
        set => SetArgument("sse_kms_encrypted_objects", value);
    }

}

/// <summary>
/// Block type for sse_kms_encrypted_objects in AwsS3BucketReplicationConfigurationBlockRulesBlockSourceSelectionCriteriaBlock.
/// Nesting mode: list
/// </summary>
public class AwsS3BucketReplicationConfigurationBlockRulesBlockSourceSelectionCriteriaBlockSseKmsEncryptedObjectsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sse_kms_encrypted_objects";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

}


/// <summary>
/// Block type for server_side_encryption_configuration in AwsS3Bucket.
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public class AwsS3BucketServerSideEncryptionConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "server_side_encryption_configuration";

    /// <summary>
    /// Rule block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Rule block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Rule block(s) allowed")]
    public required TerraformList<AwsS3BucketServerSideEncryptionConfigurationBlockRuleBlock> Rule
    {
        get => GetRequiredArgument<TerraformList<AwsS3BucketServerSideEncryptionConfigurationBlockRuleBlock>>("rule");
        set => SetArgument("rule", value);
    }

}

/// <summary>
/// Block type for rule in AwsS3BucketServerSideEncryptionConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsS3BucketServerSideEncryptionConfigurationBlockRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rule";

    /// <summary>
    /// The bucket_key_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? BucketKeyEnabled
    {
        get => GetArgument<TerraformValue<bool>>("bucket_key_enabled");
        set => SetArgument("bucket_key_enabled", value);
    }

    /// <summary>
    /// ApplyServerSideEncryptionByDefault block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplyServerSideEncryptionByDefault is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ApplyServerSideEncryptionByDefault block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApplyServerSideEncryptionByDefault block(s) allowed")]
    public required TerraformList<AwsS3BucketServerSideEncryptionConfigurationBlockRuleBlockApplyServerSideEncryptionByDefaultBlock> ApplyServerSideEncryptionByDefault
    {
        get => GetRequiredArgument<TerraformList<AwsS3BucketServerSideEncryptionConfigurationBlockRuleBlockApplyServerSideEncryptionByDefaultBlock>>("apply_server_side_encryption_by_default");
        set => SetArgument("apply_server_side_encryption_by_default", value);
    }

}

/// <summary>
/// Block type for apply_server_side_encryption_by_default in AwsS3BucketServerSideEncryptionConfigurationBlockRuleBlock.
/// Nesting mode: list
/// </summary>
public class AwsS3BucketServerSideEncryptionConfigurationBlockRuleBlockApplyServerSideEncryptionByDefaultBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "apply_server_side_encryption_by_default";

    /// <summary>
    /// The kms_master_key_id attribute.
    /// </summary>
    public TerraformValue<string>? KmsMasterKeyId
    {
        get => GetArgument<TerraformValue<string>>("kms_master_key_id");
        set => SetArgument("kms_master_key_id", value);
    }

    /// <summary>
    /// The sse_algorithm attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SseAlgorithm is required")]
    public required TerraformValue<string> SseAlgorithm
    {
        get => GetRequiredArgument<TerraformValue<string>>("sse_algorithm");
        set => SetArgument("sse_algorithm", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsS3Bucket.
/// Nesting mode: single
/// </summary>
public class AwsS3BucketTimeoutsBlock : TerraformBlock
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
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
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
/// Block type for versioning in AwsS3Bucket.
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public class AwsS3BucketVersioningBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "versioning";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The mfa_delete attribute.
    /// </summary>
    public TerraformValue<bool>? MfaDelete
    {
        get => GetArgument<TerraformValue<bool>>("mfa_delete");
        set => SetArgument("mfa_delete", value);
    }

}


/// <summary>
/// Block type for website in AwsS3Bucket.
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public class AwsS3BucketWebsiteBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "website";

    /// <summary>
    /// The error_document attribute.
    /// </summary>
    public TerraformValue<string>? ErrorDocument
    {
        get => GetArgument<TerraformValue<string>>("error_document");
        set => SetArgument("error_document", value);
    }

    /// <summary>
    /// The index_document attribute.
    /// </summary>
    public TerraformValue<string>? IndexDocument
    {
        get => GetArgument<TerraformValue<string>>("index_document");
        set => SetArgument("index_document", value);
    }

    /// <summary>
    /// The redirect_all_requests_to attribute.
    /// </summary>
    public TerraformValue<string>? RedirectAllRequestsTo
    {
        get => GetArgument<TerraformValue<string>>("redirect_all_requests_to");
        set => SetArgument("redirect_all_requests_to", value);
    }

    /// <summary>
    /// The routing_rules attribute.
    /// </summary>
    public TerraformValue<string>? RoutingRules
    {
        get => GetArgument<TerraformValue<string>>("routing_rules");
        set => SetArgument("routing_rules", value);
    }

}


/// <summary>
/// Represents a aws_s3_bucket Terraform resource.
/// Manages a aws_s3_bucket resource.
/// </summary>
public partial class AwsS3Bucket(string name) : TerraformResource("aws_s3_bucket", name)
{
    /// <summary>
    /// The acceleration_status attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> AccelerationStatus
    {
        get => GetArgument<TerraformValue<string>>("acceleration_status") ?? AsReference("acceleration_status");
        set => SetArgument("acceleration_status", value);
    }

    /// <summary>
    /// The acl attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> Acl
    {
        get => GetArgument<TerraformValue<string>>("acl") ?? AsReference("acl");
        set => SetArgument("acl", value);
    }

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    public TerraformValue<string> Bucket
    {
        get => GetArgument<TerraformValue<string>>("bucket") ?? AsReference("bucket");
        set => SetArgument("bucket", value);
    }

    /// <summary>
    /// The bucket_prefix attribute.
    /// </summary>
    public TerraformValue<string> BucketPrefix
    {
        get => GetArgument<TerraformValue<string>>("bucket_prefix") ?? AsReference("bucket_prefix");
        set => SetArgument("bucket_prefix", value);
    }

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    public TerraformValue<bool>? ForceDestroy
    {
        get => GetArgument<TerraformValue<bool>>("force_destroy");
        set => SetArgument("force_destroy", value);
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
    /// The object_lock_enabled attribute.
    /// </summary>
    public TerraformValue<bool> ObjectLockEnabled
    {
        get => GetArgument<TerraformValue<bool>>("object_lock_enabled") ?? AsReference("object_lock_enabled");
        set => SetArgument("object_lock_enabled", value);
    }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> Policy
    {
        get => GetArgument<TerraformValue<string>>("policy") ?? AsReference("policy");
        set => SetArgument("policy", value);
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
    /// The request_payer attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> RequestPayer
    {
        get => GetArgument<TerraformValue<string>>("request_payer") ?? AsReference("request_payer");
        set => SetArgument("request_payer", value);
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
        get => GetArgument<TerraformMap<string>>("tags_all") ?? AsReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The bucket_domain_name attribute.
    /// </summary>
    public TerraformValue<string> BucketDomainName
        => AsReference("bucket_domain_name");

    /// <summary>
    /// The bucket_region attribute.
    /// </summary>
    public TerraformValue<string> BucketRegion
        => AsReference("bucket_region");

    /// <summary>
    /// The bucket_regional_domain_name attribute.
    /// </summary>
    public TerraformValue<string> BucketRegionalDomainName
        => AsReference("bucket_regional_domain_name");

    /// <summary>
    /// The hosted_zone_id attribute.
    /// </summary>
    public TerraformValue<string> HostedZoneId
        => AsReference("hosted_zone_id");

    /// <summary>
    /// The website_domain attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> WebsiteDomain
        => AsReference("website_domain");

    /// <summary>
    /// The website_endpoint attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> WebsiteEndpoint
        => AsReference("website_endpoint");

    /// <summary>
    /// CorsRule block (nesting mode: list).
    /// </summary>
    [Obsolete("This block is deprecated.")]
    public TerraformList<AwsS3BucketCorsRuleBlock>? CorsRule
    {
        get => GetArgument<TerraformList<AwsS3BucketCorsRuleBlock>>("cors_rule");
        set => SetArgument("cors_rule", value);
    }

    /// <summary>
    /// Grant block (nesting mode: set).
    /// </summary>
    [Obsolete("This block is deprecated.")]
    public TerraformSet<AwsS3BucketGrantBlock>? Grant
    {
        get => GetArgument<TerraformSet<AwsS3BucketGrantBlock>>("grant");
        set => SetArgument("grant", value);
    }

    /// <summary>
    /// LifecycleRule block (nesting mode: list).
    /// </summary>
    [Obsolete("This block is deprecated.")]
    public TerraformList<AwsS3BucketLifecycleRuleBlock>? LifecycleRule
    {
        get => GetArgument<TerraformList<AwsS3BucketLifecycleRuleBlock>>("lifecycle_rule");
        set => SetArgument("lifecycle_rule", value);
    }

    /// <summary>
    /// Logging block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Logging block(s) allowed")]
    [Obsolete("This block is deprecated.")]
    public TerraformList<AwsS3BucketLoggingBlock>? Logging
    {
        get => GetArgument<TerraformList<AwsS3BucketLoggingBlock>>("logging");
        set => SetArgument("logging", value);
    }

    /// <summary>
    /// ObjectLockConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ObjectLockConfiguration block(s) allowed")]
    [Obsolete("This block is deprecated.")]
    public TerraformList<AwsS3BucketObjectLockConfigurationBlock>? ObjectLockConfiguration
    {
        get => GetArgument<TerraformList<AwsS3BucketObjectLockConfigurationBlock>>("object_lock_configuration");
        set => SetArgument("object_lock_configuration", value);
    }

    /// <summary>
    /// ReplicationConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReplicationConfiguration block(s) allowed")]
    [Obsolete("This block is deprecated.")]
    public TerraformList<AwsS3BucketReplicationConfigurationBlock>? ReplicationConfiguration
    {
        get => GetArgument<TerraformList<AwsS3BucketReplicationConfigurationBlock>>("replication_configuration");
        set => SetArgument("replication_configuration", value);
    }

    /// <summary>
    /// ServerSideEncryptionConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServerSideEncryptionConfiguration block(s) allowed")]
    [Obsolete("This block is deprecated.")]
    public TerraformList<AwsS3BucketServerSideEncryptionConfigurationBlock>? ServerSideEncryptionConfiguration
    {
        get => GetArgument<TerraformList<AwsS3BucketServerSideEncryptionConfigurationBlock>>("server_side_encryption_configuration");
        set => SetArgument("server_side_encryption_configuration", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsS3BucketTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsS3BucketTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// Versioning block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Versioning block(s) allowed")]
    [Obsolete("This block is deprecated.")]
    public TerraformList<AwsS3BucketVersioningBlock>? Versioning
    {
        get => GetArgument<TerraformList<AwsS3BucketVersioningBlock>>("versioning");
        set => SetArgument("versioning", value);
    }

    /// <summary>
    /// Website block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Website block(s) allowed")]
    [Obsolete("This block is deprecated.")]
    public TerraformList<AwsS3BucketWebsiteBlock>? Website
    {
        get => GetArgument<TerraformList<AwsS3BucketWebsiteBlock>>("website");
        set => SetArgument("website", value);
    }

}
