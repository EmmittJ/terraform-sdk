using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for autoclass in GoogleStorageBucket.
/// Nesting mode: list
/// </summary>
public class GoogleStorageBucketAutoclassBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "autoclass";

    /// <summary>
    /// While set to true, autoclass automatically transitions objects in your bucket to appropriate storage classes based on each object&#39;s access pattern.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The storage class that objects in the bucket eventually transition to if they are not read for a certain length of time. Supported values include: NEARLINE, ARCHIVE.
    /// </summary>
    public TerraformValue<string> TerminalStorageClass
    {
        get => GetArgument<TerraformValue<string>>("terminal_storage_class") ?? CreateReference("terminal_storage_class");
        set => SetArgument("terminal_storage_class", value);
    }

}


/// <summary>
/// Block type for cors in GoogleStorageBucket.
/// Nesting mode: list
/// </summary>
public class GoogleStorageBucketCorsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cors";

    /// <summary>
    /// The value, in seconds, to return in the Access-Control-Max-Age header used in preflight responses.
    /// </summary>
    public TerraformValue<double>? MaxAgeSeconds
    {
        get => GetArgument<TerraformValue<double>>("max_age_seconds");
        set => SetArgument("max_age_seconds", value);
    }

    /// <summary>
    /// The list of HTTP methods on which to include CORS response headers, (GET, OPTIONS, POST, etc) Note: &amp;quot;*&amp;quot; is permitted in the list of methods, and means &amp;quot;any method&amp;quot;.
    /// </summary>
    public TerraformList<string>? Method
    {
        get => GetArgument<TerraformList<string>>("method");
        set => SetArgument("method", value);
    }

    /// <summary>
    /// The list of Origins eligible to receive CORS response headers. Note: &amp;quot;*&amp;quot; is permitted in the list of origins, and means &amp;quot;any Origin&amp;quot;.
    /// </summary>
    public TerraformList<string>? Origin
    {
        get => GetArgument<TerraformList<string>>("origin");
        set => SetArgument("origin", value);
    }

    /// <summary>
    /// The list of HTTP headers other than the simple response headers to give permission for the user-agent to share across domains.
    /// </summary>
    public TerraformList<string>? ResponseHeader
    {
        get => GetArgument<TerraformList<string>>("response_header");
        set => SetArgument("response_header", value);
    }

}


/// <summary>
/// Block type for custom_placement_config in GoogleStorageBucket.
/// Nesting mode: list
/// </summary>
public class GoogleStorageBucketCustomPlacementConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_placement_config";

    /// <summary>
    /// The list of individual regions that comprise a dual-region bucket. See the docs for a list of acceptable regions. Note: If any of the data_locations changes, it will recreate the bucket.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataLocations is required")]
    public required TerraformSet<string> DataLocations
    {
        get => GetRequiredArgument<TerraformSet<string>>("data_locations");
        set => SetArgument("data_locations", value);
    }

}


/// <summary>
/// Block type for encryption in GoogleStorageBucket.
/// Nesting mode: list
/// </summary>
public class GoogleStorageBucketEncryptionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "encryption";

    /// <summary>
    /// A Cloud KMS key that will be used to encrypt objects inserted into this bucket, if no encryption method is specified. You must pay attention to whether the crypto key is available in the location that this bucket is created in. See the docs for more details.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultKmsKeyName is required")]
    public required TerraformValue<string> DefaultKmsKeyName
    {
        get => GetRequiredArgument<TerraformValue<string>>("default_kms_key_name");
        set => SetArgument("default_kms_key_name", value);
    }

}


/// <summary>
/// Block type for hierarchical_namespace in GoogleStorageBucket.
/// Nesting mode: list
/// </summary>
public class GoogleStorageBucketHierarchicalNamespaceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "hierarchical_namespace";

    /// <summary>
    /// Set this field true to organize bucket with logical file system structure.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

}


/// <summary>
/// Block type for ip_filter in GoogleStorageBucket.
/// Nesting mode: list
/// </summary>
public class GoogleStorageBucketIpFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ip_filter";

    /// <summary>
    /// Whether to allow all service agents to access the bucket regardless of the IP filter configuration.
    /// </summary>
    public TerraformValue<bool>? AllowAllServiceAgentAccess
    {
        get => GetArgument<TerraformValue<bool>>("allow_all_service_agent_access");
        set => SetArgument("allow_all_service_agent_access", value);
    }

    /// <summary>
    /// Whether to allow cross-org VPCs in the bucket&#39;s IP filter configuration.
    /// </summary>
    public TerraformValue<bool>? AllowCrossOrgVpcs
    {
        get => GetArgument<TerraformValue<bool>>("allow_cross_org_vpcs");
        set => SetArgument("allow_cross_org_vpcs", value);
    }

    /// <summary>
    /// The mode of the IP filter. Valid values are &#39;Enabled&#39; and &#39;Disabled&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    public required TerraformValue<string> Mode
    {
        get => GetRequiredArgument<TerraformValue<string>>("mode");
        set => SetArgument("mode", value);
    }

    /// <summary>
    /// PublicNetworkSource block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PublicNetworkSource block(s) allowed")]
    public TerraformList<GoogleStorageBucketIpFilterBlockPublicNetworkSourceBlock>? PublicNetworkSource
    {
        get => GetArgument<TerraformList<GoogleStorageBucketIpFilterBlockPublicNetworkSourceBlock>>("public_network_source");
        set => SetArgument("public_network_source", value);
    }

    /// <summary>
    /// VpcNetworkSources block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleStorageBucketIpFilterBlockVpcNetworkSourcesBlock>? VpcNetworkSources
    {
        get => GetArgument<TerraformList<GoogleStorageBucketIpFilterBlockVpcNetworkSourcesBlock>>("vpc_network_sources");
        set => SetArgument("vpc_network_sources", value);
    }

}

/// <summary>
/// Block type for public_network_source in GoogleStorageBucketIpFilterBlock.
/// Nesting mode: list
/// </summary>
public class GoogleStorageBucketIpFilterBlockPublicNetworkSourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "public_network_source";

    /// <summary>
    /// The list of public IPv4, IPv6 cidr ranges that are allowed to access the bucket.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedIpCidrRanges is required")]
    public TerraformList<string>? AllowedIpCidrRanges
    {
        get => GetArgument<TerraformList<string>>("allowed_ip_cidr_ranges");
        set => SetArgument("allowed_ip_cidr_ranges", value);
    }

}

/// <summary>
/// Block type for vpc_network_sources in GoogleStorageBucketIpFilterBlock.
/// Nesting mode: list
/// </summary>
public class GoogleStorageBucketIpFilterBlockVpcNetworkSourcesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "vpc_network_sources";

    /// <summary>
    /// The list of public or private IPv4 and IPv6 CIDR ranges that can access the bucket.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedIpCidrRanges is required")]
    public TerraformList<string>? AllowedIpCidrRanges
    {
        get => GetArgument<TerraformList<string>>("allowed_ip_cidr_ranges");
        set => SetArgument("allowed_ip_cidr_ranges", value);
    }

    /// <summary>
    /// Name of the network. Format: projects/{PROJECT_ID}/global/networks/{NETWORK_NAME}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    public required TerraformValue<string> Network
    {
        get => GetRequiredArgument<TerraformValue<string>>("network");
        set => SetArgument("network", value);
    }

}


/// <summary>
/// Block type for lifecycle_rule in GoogleStorageBucket.
/// Nesting mode: list
/// </summary>
public class GoogleStorageBucketLifecycleRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "lifecycle_rule";

    /// <summary>
    /// Action block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Action block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Action block(s) allowed")]
    public required TerraformSet<GoogleStorageBucketLifecycleRuleBlockActionBlock> Action
    {
        get => GetRequiredArgument<TerraformSet<GoogleStorageBucketLifecycleRuleBlockActionBlock>>("action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// Condition block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Condition is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Condition block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Condition block(s) allowed")]
    public required TerraformSet<GoogleStorageBucketLifecycleRuleBlockConditionBlock> Condition
    {
        get => GetRequiredArgument<TerraformSet<GoogleStorageBucketLifecycleRuleBlockConditionBlock>>("condition");
        set => SetArgument("condition", value);
    }

}

/// <summary>
/// Block type for action in GoogleStorageBucketLifecycleRuleBlock.
/// Nesting mode: set
/// </summary>
public class GoogleStorageBucketLifecycleRuleBlockActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "action";

    /// <summary>
    /// The target Storage Class of objects affected by this Lifecycle Rule. Supported values include: MULTI_REGIONAL, REGIONAL, NEARLINE, COLDLINE, ARCHIVE.
    /// </summary>
    public TerraformValue<string>? StorageClass
    {
        get => GetArgument<TerraformValue<string>>("storage_class");
        set => SetArgument("storage_class", value);
    }

    /// <summary>
    /// The type of the action of this Lifecycle Rule. Supported values include: Delete, SetStorageClass and AbortIncompleteMultipartUpload.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for condition in GoogleStorageBucketLifecycleRuleBlock.
/// Nesting mode: set
/// </summary>
public class GoogleStorageBucketLifecycleRuleBlockConditionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "condition";

    /// <summary>
    /// Minimum age of an object in days to satisfy this condition.
    /// </summary>
    public TerraformValue<double>? Age
    {
        get => GetArgument<TerraformValue<double>>("age");
        set => SetArgument("age", value);
    }

    /// <summary>
    /// Creation date of an object in RFC 3339 (e.g. 2017-06-13) to satisfy this condition.
    /// </summary>
    public TerraformValue<string>? CreatedBefore
    {
        get => GetArgument<TerraformValue<string>>("created_before");
        set => SetArgument("created_before", value);
    }

    /// <summary>
    /// Creation date of an object in RFC 3339 (e.g. 2017-06-13) to satisfy this condition.
    /// </summary>
    public TerraformValue<string>? CustomTimeBefore
    {
        get => GetArgument<TerraformValue<string>>("custom_time_before");
        set => SetArgument("custom_time_before", value);
    }

    /// <summary>
    /// Number of days elapsed since the user-specified timestamp set on an object.
    /// </summary>
    public TerraformValue<double>? DaysSinceCustomTime
    {
        get => GetArgument<TerraformValue<double>>("days_since_custom_time");
        set => SetArgument("days_since_custom_time", value);
    }

    /// <summary>
    /// Number of days elapsed since the noncurrent timestamp of an object. This
    /// 										condition is relevant only for versioned objects.
    /// </summary>
    public TerraformValue<double>? DaysSinceNoncurrentTime
    {
        get => GetArgument<TerraformValue<double>>("days_since_noncurrent_time");
        set => SetArgument("days_since_noncurrent_time", value);
    }

    /// <summary>
    /// One or more matching name prefixes to satisfy this condition.
    /// </summary>
    public TerraformList<string>? MatchesPrefix
    {
        get => GetArgument<TerraformList<string>>("matches_prefix");
        set => SetArgument("matches_prefix", value);
    }

    /// <summary>
    /// Storage Class of objects to satisfy this condition. Supported values include: MULTI_REGIONAL, REGIONAL, NEARLINE, COLDLINE, ARCHIVE, STANDARD, DURABLE_REDUCED_AVAILABILITY.
    /// </summary>
    public TerraformList<string>? MatchesStorageClass
    {
        get => GetArgument<TerraformList<string>>("matches_storage_class");
        set => SetArgument("matches_storage_class", value);
    }

    /// <summary>
    /// One or more matching name suffixes to satisfy this condition.
    /// </summary>
    public TerraformList<string>? MatchesSuffix
    {
        get => GetArgument<TerraformList<string>>("matches_suffix");
        set => SetArgument("matches_suffix", value);
    }

    /// <summary>
    /// Creation date of an object in RFC 3339 (e.g. 2017-06-13) to satisfy this condition.
    /// </summary>
    public TerraformValue<string>? NoncurrentTimeBefore
    {
        get => GetArgument<TerraformValue<string>>("noncurrent_time_before");
        set => SetArgument("noncurrent_time_before", value);
    }

    /// <summary>
    /// Relevant only for versioned objects. The number of newer versions of an object to satisfy this condition.
    /// </summary>
    public TerraformValue<double>? NumNewerVersions
    {
        get => GetArgument<TerraformValue<double>>("num_newer_versions");
        set => SetArgument("num_newer_versions", value);
    }

    /// <summary>
    /// While set true, age value will be sent in the request even for zero value of the field. This field is only useful for setting 0 value to the age field. It can be used alone or together with age.
    /// </summary>
    public TerraformValue<bool>? SendAgeIfZero
    {
        get => GetArgument<TerraformValue<bool>>("send_age_if_zero");
        set => SetArgument("send_age_if_zero", value);
    }

    /// <summary>
    /// While set true, days_since_custom_time value will be sent in the request even for zero value of the field. This field is only useful for setting 0 value to the days_since_custom_time field. It can be used alone or together with days_since_custom_time.
    /// </summary>
    public TerraformValue<bool>? SendDaysSinceCustomTimeIfZero
    {
        get => GetArgument<TerraformValue<bool>>("send_days_since_custom_time_if_zero");
        set => SetArgument("send_days_since_custom_time_if_zero", value);
    }

    /// <summary>
    /// While set true, days_since_noncurrent_time value will be sent in the request even for zero value of the field. This field is only useful for setting 0 value to the days_since_noncurrent_time field. It can be used alone or together with days_since_noncurrent_time.
    /// </summary>
    public TerraformValue<bool>? SendDaysSinceNoncurrentTimeIfZero
    {
        get => GetArgument<TerraformValue<bool>>("send_days_since_noncurrent_time_if_zero");
        set => SetArgument("send_days_since_noncurrent_time_if_zero", value);
    }

    /// <summary>
    /// While set true, num_newer_versions value will be sent in the request even for zero value of the field. This field is only useful for setting 0 value to the num_newer_versions field. It can be used alone or together with num_newer_versions.
    /// </summary>
    public TerraformValue<bool>? SendNumNewerVersionsIfZero
    {
        get => GetArgument<TerraformValue<bool>>("send_num_newer_versions_if_zero");
        set => SetArgument("send_num_newer_versions_if_zero", value);
    }

    /// <summary>
    /// Match to live and/or archived objects. Unversioned buckets have only live objects. Supported values include: &amp;quot;LIVE&amp;quot;, &amp;quot;ARCHIVED&amp;quot;, &amp;quot;ANY&amp;quot;.
    /// </summary>
    public TerraformValue<string> WithState
    {
        get => GetArgument<TerraformValue<string>>("with_state") ?? CreateReference("with_state");
        set => SetArgument("with_state", value);
    }

}


/// <summary>
/// Block type for logging in GoogleStorageBucket.
/// Nesting mode: list
/// </summary>
public class GoogleStorageBucketLoggingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "logging";

    /// <summary>
    /// The bucket that will receive log objects.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogBucket is required")]
    public required TerraformValue<string> LogBucket
    {
        get => GetRequiredArgument<TerraformValue<string>>("log_bucket");
        set => SetArgument("log_bucket", value);
    }

    /// <summary>
    /// The object prefix for log objects. If it&#39;s not provided, by default Google Cloud Storage sets this to this bucket&#39;s name.
    /// </summary>
    public TerraformValue<string> LogObjectPrefix
    {
        get => GetArgument<TerraformValue<string>>("log_object_prefix") ?? CreateReference("log_object_prefix");
        set => SetArgument("log_object_prefix", value);
    }

}


/// <summary>
/// Block type for retention_policy in GoogleStorageBucket.
/// Nesting mode: list
/// </summary>
public class GoogleStorageBucketRetentionPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "retention_policy";

    /// <summary>
    /// If set to true, the bucket will be locked and permanently restrict edits to the bucket&#39;s retention policy.  Caution: Locking a bucket is an irreversible action.
    /// </summary>
    public TerraformValue<bool>? IsLocked
    {
        get => GetArgument<TerraformValue<bool>>("is_locked");
        set => SetArgument("is_locked", value);
    }

    /// <summary>
    /// The period of time, in seconds, that objects in the bucket must be retained and cannot be deleted, overwritten, or archived. The value must be less than 3,155,760,000 seconds.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetentionPeriod is required")]
    public required TerraformValue<string> RetentionPeriod
    {
        get => GetRequiredArgument<TerraformValue<string>>("retention_period");
        set => SetArgument("retention_period", value);
    }

}


/// <summary>
/// Block type for soft_delete_policy in GoogleStorageBucket.
/// Nesting mode: list
/// </summary>
public class GoogleStorageBucketSoftDeletePolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "soft_delete_policy";

    /// <summary>
    /// Server-determined value that indicates the time from which the policy, or one with a greater retention, was effective. This value is in RFC 3339 format.
    /// </summary>
    public TerraformValue<string> EffectiveTime
        => CreateReference("effective_time");

    /// <summary>
    /// The duration in seconds that soft-deleted objects in the bucket will be retained and cannot be permanently deleted. Default value is 604800.
    /// </summary>
    public TerraformValue<double>? RetentionDurationSeconds
    {
        get => GetArgument<TerraformValue<double>>("retention_duration_seconds");
        set => SetArgument("retention_duration_seconds", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleStorageBucket.
/// Nesting mode: single
/// </summary>
public class GoogleStorageBucketTimeoutsBlock : TerraformBlock
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
/// Block type for versioning in GoogleStorageBucket.
/// Nesting mode: list
/// </summary>
public class GoogleStorageBucketVersioningBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "versioning";

    /// <summary>
    /// While set to true, versioning is fully enabled for this bucket.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

}


/// <summary>
/// Block type for website in GoogleStorageBucket.
/// Nesting mode: list
/// </summary>
public class GoogleStorageBucketWebsiteBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "website";

    /// <summary>
    /// Behaves as the bucket&#39;s directory index where missing objects are treated as potential directories.
    /// </summary>
    public TerraformValue<string>? MainPageSuffix
    {
        get => GetArgument<TerraformValue<string>>("main_page_suffix");
        set => SetArgument("main_page_suffix", value);
    }

    /// <summary>
    /// The custom object to return when a requested resource is not found.
    /// </summary>
    public TerraformValue<string>? NotFoundPage
    {
        get => GetArgument<TerraformValue<string>>("not_found_page");
        set => SetArgument("not_found_page", value);
    }

}


/// <summary>
/// Represents a google_storage_bucket Terraform resource.
/// Manages a google_storage_bucket resource.
/// </summary>
public partial class GoogleStorageBucket(string name) : TerraformResource("google_storage_bucket", name)
{
    /// <summary>
    /// Whether or not to automatically apply an eventBasedHold to new objects added to the bucket.
    /// </summary>
    public TerraformValue<bool>? DefaultEventBasedHold
    {
        get => GetArgument<TerraformValue<bool>>("default_event_based_hold");
        set => SetArgument("default_event_based_hold", value);
    }

    /// <summary>
    /// Enables each object in the bucket to have its own retention policy, which prevents deletion until stored for a specific length of time.
    /// </summary>
    public TerraformValue<bool>? EnableObjectRetention
    {
        get => GetArgument<TerraformValue<bool>>("enable_object_retention");
        set => SetArgument("enable_object_retention", value);
    }

    /// <summary>
    /// When deleting a bucket, this boolean option will delete all contained objects, or anywhereCaches (if any). If you try to delete a bucket that contains objects or anywhereCaches, Terraform will fail that run, deleting anywhereCaches may take 80 minutes to complete.
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
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// A set of key/value label pairs to assign to the bucket.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The Google Cloud Storage location or region.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name of the bucket.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? CreateReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Prevents public access to a bucket.
    /// </summary>
    public TerraformValue<string> PublicAccessPrevention
    {
        get => GetArgument<TerraformValue<string>>("public_access_prevention") ?? CreateReference("public_access_prevention");
        set => SetArgument("public_access_prevention", value);
    }

    /// <summary>
    /// Enables Requester Pays on a storage bucket.
    /// </summary>
    public TerraformValue<bool>? RequesterPays
    {
        get => GetArgument<TerraformValue<bool>>("requester_pays");
        set => SetArgument("requester_pays", value);
    }

    /// <summary>
    /// Specifies the RPO setting of bucket. If set &#39;ASYNC_TURBO&#39;, The Turbo Replication will be enabled for the dual-region bucket. Value &#39;DEFAULT&#39; will set RPO setting to default. Turbo Replication is only for buckets in dual-regions.See the docs for more details.
    /// </summary>
    public TerraformValue<string> Rpo
    {
        get => GetArgument<TerraformValue<string>>("rpo") ?? CreateReference("rpo");
        set => SetArgument("rpo", value);
    }

    /// <summary>
    /// The Storage Class of the new bucket. Supported values include: STANDARD, MULTI_REGIONAL, REGIONAL, NEARLINE, COLDLINE, ARCHIVE.
    /// </summary>
    public TerraformValue<string>? StorageClass
    {
        get => GetArgument<TerraformValue<string>>("storage_class");
        set => SetArgument("storage_class", value);
    }

    /// <summary>
    /// Enables uniform bucket-level access on a bucket.
    /// </summary>
    public TerraformValue<bool> UniformBucketLevelAccess
    {
        get => GetArgument<TerraformValue<bool>>("uniform_bucket_level_access") ?? CreateReference("uniform_bucket_level_access");
        set => SetArgument("uniform_bucket_level_access", value);
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => CreateReference("effective_labels");

    /// <summary>
    /// The project number of the project in which the resource belongs.
    /// </summary>
    public TerraformValue<double> ProjectNumber
        => CreateReference("project_number");

    /// <summary>
    /// The URI of the created resource.
    /// </summary>
    public TerraformValue<string> SelfLink
        => CreateReference("self_link");

    /// <summary>
    /// The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => CreateReference("terraform_labels");

    /// <summary>
    /// The creation time of the bucket in RFC 3339 format.
    /// </summary>
    public TerraformValue<string> TimeCreated
        => CreateReference("time_created");

    /// <summary>
    /// The time at which the bucket&#39;s metadata or IAM policy was last updated, in RFC 3339 format.
    /// </summary>
    public TerraformValue<string> Updated
        => CreateReference("updated");

    /// <summary>
    /// The base URL of the bucket, in the format gs://&amp;lt;bucket-name&amp;gt;.
    /// </summary>
    public TerraformValue<string> Url
        => CreateReference("url");

    /// <summary>
    /// Autoclass block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Autoclass block(s) allowed")]
    public TerraformList<GoogleStorageBucketAutoclassBlock>? Autoclass
    {
        get => GetArgument<TerraformList<GoogleStorageBucketAutoclassBlock>>("autoclass");
        set => SetArgument("autoclass", value);
    }

    /// <summary>
    /// Cors block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleStorageBucketCorsBlock>? Cors
    {
        get => GetArgument<TerraformList<GoogleStorageBucketCorsBlock>>("cors");
        set => SetArgument("cors", value);
    }

    /// <summary>
    /// CustomPlacementConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomPlacementConfig block(s) allowed")]
    public TerraformList<GoogleStorageBucketCustomPlacementConfigBlock>? CustomPlacementConfig
    {
        get => GetArgument<TerraformList<GoogleStorageBucketCustomPlacementConfigBlock>>("custom_placement_config");
        set => SetArgument("custom_placement_config", value);
    }

    /// <summary>
    /// Encryption block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Encryption block(s) allowed")]
    public TerraformList<GoogleStorageBucketEncryptionBlock>? Encryption
    {
        get => GetArgument<TerraformList<GoogleStorageBucketEncryptionBlock>>("encryption");
        set => SetArgument("encryption", value);
    }

    /// <summary>
    /// HierarchicalNamespace block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HierarchicalNamespace block(s) allowed")]
    public TerraformList<GoogleStorageBucketHierarchicalNamespaceBlock>? HierarchicalNamespace
    {
        get => GetArgument<TerraformList<GoogleStorageBucketHierarchicalNamespaceBlock>>("hierarchical_namespace");
        set => SetArgument("hierarchical_namespace", value);
    }

    /// <summary>
    /// IpFilter block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IpFilter block(s) allowed")]
    public TerraformList<GoogleStorageBucketIpFilterBlock>? IpFilter
    {
        get => GetArgument<TerraformList<GoogleStorageBucketIpFilterBlock>>("ip_filter");
        set => SetArgument("ip_filter", value);
    }

    /// <summary>
    /// LifecycleRule block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(100, ErrorMessage = "Maximum 100 LifecycleRule block(s) allowed")]
    public TerraformList<GoogleStorageBucketLifecycleRuleBlock>? LifecycleRule
    {
        get => GetArgument<TerraformList<GoogleStorageBucketLifecycleRuleBlock>>("lifecycle_rule");
        set => SetArgument("lifecycle_rule", value);
    }

    /// <summary>
    /// Logging block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Logging block(s) allowed")]
    public TerraformList<GoogleStorageBucketLoggingBlock>? Logging
    {
        get => GetArgument<TerraformList<GoogleStorageBucketLoggingBlock>>("logging");
        set => SetArgument("logging", value);
    }

    /// <summary>
    /// RetentionPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionPolicy block(s) allowed")]
    public TerraformList<GoogleStorageBucketRetentionPolicyBlock>? RetentionPolicy
    {
        get => GetArgument<TerraformList<GoogleStorageBucketRetentionPolicyBlock>>("retention_policy");
        set => SetArgument("retention_policy", value);
    }

    /// <summary>
    /// SoftDeletePolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SoftDeletePolicy block(s) allowed")]
    public TerraformList<GoogleStorageBucketSoftDeletePolicyBlock>? SoftDeletePolicy
    {
        get => GetArgument<TerraformList<GoogleStorageBucketSoftDeletePolicyBlock>>("soft_delete_policy");
        set => SetArgument("soft_delete_policy", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleStorageBucketTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleStorageBucketTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// Versioning block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Versioning block(s) allowed")]
    public TerraformList<GoogleStorageBucketVersioningBlock>? Versioning
    {
        get => GetArgument<TerraformList<GoogleStorageBucketVersioningBlock>>("versioning");
        set => SetArgument("versioning", value);
    }

    /// <summary>
    /// Website block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Website block(s) allowed")]
    public TerraformList<GoogleStorageBucketWebsiteBlock>? Website
    {
        get => GetArgument<TerraformList<GoogleStorageBucketWebsiteBlock>>("website");
        set => SetArgument("website", value);
    }

}
