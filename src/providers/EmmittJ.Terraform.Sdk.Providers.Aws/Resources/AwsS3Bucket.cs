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
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "allowed_headers").ResolveNodes(ctx));
        set => SetArgument("allowed_headers", value);
    }

    /// <summary>
    /// The allowed_methods attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedMethods is required")]
    public TerraformList<string>? AllowedMethods
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "allowed_methods").ResolveNodes(ctx));
        set => SetArgument("allowed_methods", value);
    }

    /// <summary>
    /// The allowed_origins attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedOrigins is required")]
    public TerraformList<string>? AllowedOrigins
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "allowed_origins").ResolveNodes(ctx));
        set => SetArgument("allowed_origins", value);
    }

    /// <summary>
    /// The expose_headers attribute.
    /// </summary>
    public TerraformList<string>? ExposeHeaders
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "expose_headers").ResolveNodes(ctx));
        set => SetArgument("expose_headers", value);
    }

    /// <summary>
    /// The max_age_seconds attribute.
    /// </summary>
    public TerraformValue<double>? MaxAgeSeconds
    {
        get => new TerraformReference<double>(this, "max_age_seconds");
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
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The permissions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Permissions is required")]
    public required TerraformSet<string> Permissions
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "permissions").ResolveNodes(ctx));
        set => SetArgument("permissions", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    public TerraformValue<string>? Uri
    {
        get => new TerraformReference<string>(this, "uri");
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
        get => new TerraformReference<double>(this, "abort_incomplete_multipart_upload_days");
        set => SetArgument("abort_incomplete_multipart_upload_days", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    public TerraformValue<string>? Prefix
    {
        get => new TerraformReference<string>(this, "prefix");
        set => SetArgument("prefix", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
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
        get => new TerraformReference<string>(this, "date");
        set => SetArgument("date", value);
    }

    /// <summary>
    /// The days attribute.
    /// </summary>
    public TerraformValue<double>? Days
    {
        get => new TerraformReference<double>(this, "days");
        set => SetArgument("days", value);
    }

    /// <summary>
    /// The expired_object_delete_marker attribute.
    /// </summary>
    public TerraformValue<bool>? ExpiredObjectDeleteMarker
    {
        get => new TerraformReference<bool>(this, "expired_object_delete_marker");
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
        get => new TerraformReference<double>(this, "days");
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
        get => new TerraformReference<double>(this, "days");
        set => SetArgument("days", value);
    }

    /// <summary>
    /// The storage_class attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageClass is required")]
    public required TerraformValue<string> StorageClass
    {
        get => new TerraformReference<string>(this, "storage_class");
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
        get => new TerraformReference<string>(this, "date");
        set => SetArgument("date", value);
    }

    /// <summary>
    /// The days attribute.
    /// </summary>
    public TerraformValue<double>? Days
    {
        get => new TerraformReference<double>(this, "days");
        set => SetArgument("days", value);
    }

    /// <summary>
    /// The storage_class attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageClass is required")]
    public required TerraformValue<string> StorageClass
    {
        get => new TerraformReference<string>(this, "storage_class");
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
        get => new TerraformReference<string>(this, "target_bucket");
        set => SetArgument("target_bucket", value);
    }

    /// <summary>
    /// The target_prefix attribute.
    /// </summary>
    public TerraformValue<string>? TargetPrefix
    {
        get => new TerraformReference<string>(this, "target_prefix");
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
        get => new TerraformReference<string>(this, "object_lock_enabled");
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
        get => new TerraformReference<double>(this, "days");
        set => SetArgument("days", value);
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    public required TerraformValue<string> Mode
    {
        get => new TerraformReference<string>(this, "mode");
        set => SetArgument("mode", value);
    }

    /// <summary>
    /// The years attribute.
    /// </summary>
    public TerraformValue<double>? Years
    {
        get => new TerraformReference<double>(this, "years");
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
        get => new TerraformReference<string>(this, "role");
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
        get => new TerraformReference<string>(this, "delete_marker_replication_status");
        set => SetArgument("delete_marker_replication_status", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    public TerraformValue<string>? Prefix
    {
        get => new TerraformReference<string>(this, "prefix");
        set => SetArgument("prefix", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    public TerraformValue<double>? Priority
    {
        get => new TerraformReference<double>(this, "priority");
        set => SetArgument("priority", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Status is required")]
    public required TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
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
        get => new TerraformReference<string>(this, "account_id");
        set => SetArgument("account_id", value);
    }

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformValue<string> Bucket
    {
        get => new TerraformReference<string>(this, "bucket");
        set => SetArgument("bucket", value);
    }

    /// <summary>
    /// The replica_kms_key_id attribute.
    /// </summary>
    public TerraformValue<string>? ReplicaKmsKeyId
    {
        get => new TerraformReference<string>(this, "replica_kms_key_id");
        set => SetArgument("replica_kms_key_id", value);
    }

    /// <summary>
    /// The storage_class attribute.
    /// </summary>
    public TerraformValue<string>? StorageClass
    {
        get => new TerraformReference<string>(this, "storage_class");
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
        get => new TerraformReference<string>(this, "owner");
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
        get => new TerraformReference<double>(this, "minutes");
        set => SetArgument("minutes", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string>? Status
    {
        get => new TerraformReference<string>(this, "status");
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
        get => new TerraformReference<double>(this, "minutes");
        set => SetArgument("minutes", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string>? Status
    {
        get => new TerraformReference<string>(this, "status");
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
        get => new TerraformReference<string>(this, "prefix");
        set => SetArgument("prefix", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
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
        get => new TerraformReference<bool>(this, "enabled");
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
        get => new TerraformReference<bool>(this, "bucket_key_enabled");
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
        get => new TerraformReference<string>(this, "kms_master_key_id");
        set => SetArgument("kms_master_key_id", value);
    }

    /// <summary>
    /// The sse_algorithm attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SseAlgorithm is required")]
    public required TerraformValue<string> SseAlgorithm
    {
        get => new TerraformReference<string>(this, "sse_algorithm");
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
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
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The mfa_delete attribute.
    /// </summary>
    public TerraformValue<bool>? MfaDelete
    {
        get => new TerraformReference<bool>(this, "mfa_delete");
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
        get => new TerraformReference<string>(this, "error_document");
        set => SetArgument("error_document", value);
    }

    /// <summary>
    /// The index_document attribute.
    /// </summary>
    public TerraformValue<string>? IndexDocument
    {
        get => new TerraformReference<string>(this, "index_document");
        set => SetArgument("index_document", value);
    }

    /// <summary>
    /// The redirect_all_requests_to attribute.
    /// </summary>
    public TerraformValue<string>? RedirectAllRequestsTo
    {
        get => new TerraformReference<string>(this, "redirect_all_requests_to");
        set => SetArgument("redirect_all_requests_to", value);
    }

    /// <summary>
    /// The routing_rules attribute.
    /// </summary>
    public TerraformValue<string>? RoutingRules
    {
        get => new TerraformReference<string>(this, "routing_rules");
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
        get => new TerraformReference<string>(this, "acceleration_status");
        set => SetArgument("acceleration_status", value);
    }

    /// <summary>
    /// The acl attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> Acl
    {
        get => new TerraformReference<string>(this, "acl");
        set => SetArgument("acl", value);
    }

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    public TerraformValue<string> Bucket
    {
        get => new TerraformReference<string>(this, "bucket");
        set => SetArgument("bucket", value);
    }

    /// <summary>
    /// The bucket_prefix attribute.
    /// </summary>
    public TerraformValue<string> BucketPrefix
    {
        get => new TerraformReference<string>(this, "bucket_prefix");
        set => SetArgument("bucket_prefix", value);
    }

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    public TerraformValue<bool>? ForceDestroy
    {
        get => new TerraformReference<bool>(this, "force_destroy");
        set => SetArgument("force_destroy", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The object_lock_enabled attribute.
    /// </summary>
    public TerraformValue<bool> ObjectLockEnabled
    {
        get => new TerraformReference<bool>(this, "object_lock_enabled");
        set => SetArgument("object_lock_enabled", value);
    }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> Policy
    {
        get => new TerraformReference<string>(this, "policy");
        set => SetArgument("policy", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The request_payer attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> RequestPayer
    {
        get => new TerraformReference<string>(this, "request_payer");
        set => SetArgument("request_payer", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The bucket_domain_name attribute.
    /// </summary>
    public TerraformValue<string> BucketDomainName
    {
        get => new TerraformReference<string>(this, "bucket_domain_name");
    }

    /// <summary>
    /// The bucket_region attribute.
    /// </summary>
    public TerraformValue<string> BucketRegion
    {
        get => new TerraformReference<string>(this, "bucket_region");
    }

    /// <summary>
    /// The bucket_regional_domain_name attribute.
    /// </summary>
    public TerraformValue<string> BucketRegionalDomainName
    {
        get => new TerraformReference<string>(this, "bucket_regional_domain_name");
    }

    /// <summary>
    /// The hosted_zone_id attribute.
    /// </summary>
    public TerraformValue<string> HostedZoneId
    {
        get => new TerraformReference<string>(this, "hosted_zone_id");
    }

    /// <summary>
    /// The website_domain attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> WebsiteDomain
    {
        get => new TerraformReference<string>(this, "website_domain");
    }

    /// <summary>
    /// The website_endpoint attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> WebsiteEndpoint
    {
        get => new TerraformReference<string>(this, "website_endpoint");
    }

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
