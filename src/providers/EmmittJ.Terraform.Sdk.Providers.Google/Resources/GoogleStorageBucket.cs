using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for autoclass in .
/// Nesting mode: list
/// </summary>
public partial class GoogleStorageBucketAutoclassBlock() : TerraformBlock("autoclass")
{
    /// <summary>
    /// While set to true, autoclass automatically transitions objects in your bucket to appropriate storage classes based on each object&#39;s access pattern.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformProperty("enabled")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> Enabled { get; set; }

    /// <summary>
    /// The storage class that objects in the bucket eventually transition to if they are not read for a certain length of time. Supported values include: NEARLINE, ARCHIVE.
    /// </summary>
    [TerraformProperty("terminal_storage_class")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> TerminalStorageClass { get; set; }

}

/// <summary>
/// Block type for cors in .
/// Nesting mode: list
/// </summary>
public partial class GoogleStorageBucketCorsBlock() : TerraformBlock("cors")
{
    /// <summary>
    /// The value, in seconds, to return in the Access-Control-Max-Age header used in preflight responses.
    /// </summary>
    [TerraformProperty("max_age_seconds")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MaxAgeSeconds { get; set; }

    /// <summary>
    /// The list of HTTP methods on which to include CORS response headers, (GET, OPTIONS, POST, etc) Note: &amp;quot;*&amp;quot; is permitted in the list of methods, and means &amp;quot;any method&amp;quot;.
    /// </summary>
    [TerraformProperty("method")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? Method { get; set; }

    /// <summary>
    /// The list of Origins eligible to receive CORS response headers. Note: &amp;quot;*&amp;quot; is permitted in the list of origins, and means &amp;quot;any Origin&amp;quot;.
    /// </summary>
    [TerraformProperty("origin")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? Origin { get; set; }

    /// <summary>
    /// The list of HTTP headers other than the simple response headers to give permission for the user-agent to share across domains.
    /// </summary>
    [TerraformProperty("response_header")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? ResponseHeader { get; set; }

}

/// <summary>
/// Block type for custom_placement_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleStorageBucketCustomPlacementConfigBlock() : TerraformBlock("custom_placement_config")
{
    /// <summary>
    /// The list of individual regions that comprise a dual-region bucket. See the docs for a list of acceptable regions. Note: If any of the data_locations changes, it will recreate the bucket.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataLocations is required")]
    [TerraformProperty("data_locations")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> DataLocations { get; set; }

}

/// <summary>
/// Block type for encryption in .
/// Nesting mode: list
/// </summary>
public partial class GoogleStorageBucketEncryptionBlock() : TerraformBlock("encryption")
{
    /// <summary>
    /// A Cloud KMS key that will be used to encrypt objects inserted into this bucket, if no encryption method is specified. You must pay attention to whether the crypto key is available in the location that this bucket is created in. See the docs for more details.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultKmsKeyName is required")]
    [TerraformProperty("default_kms_key_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DefaultKmsKeyName { get; set; }

}

/// <summary>
/// Block type for hierarchical_namespace in .
/// Nesting mode: list
/// </summary>
public partial class GoogleStorageBucketHierarchicalNamespaceBlock() : TerraformBlock("hierarchical_namespace")
{
    /// <summary>
    /// Set this field true to organize bucket with logical file system structure.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformProperty("enabled")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> Enabled { get; set; }

}

/// <summary>
/// Block type for ip_filter in .
/// Nesting mode: list
/// </summary>
public partial class GoogleStorageBucketIpFilterBlock() : TerraformBlock("ip_filter")
{
    /// <summary>
    /// Whether to allow all service agents to access the bucket regardless of the IP filter configuration.
    /// </summary>
    [TerraformProperty("allow_all_service_agent_access")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AllowAllServiceAgentAccess { get; set; }

    /// <summary>
    /// Whether to allow cross-org VPCs in the bucket&#39;s IP filter configuration.
    /// </summary>
    [TerraformProperty("allow_cross_org_vpcs")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AllowCrossOrgVpcs { get; set; }

    /// <summary>
    /// The mode of the IP filter. Valid values are &#39;Enabled&#39; and &#39;Disabled&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    [TerraformProperty("mode")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Mode { get; set; }

}

/// <summary>
/// Block type for lifecycle_rule in .
/// Nesting mode: list
/// </summary>
public partial class GoogleStorageBucketLifecycleRuleBlock() : TerraformBlock("lifecycle_rule")
{
}

/// <summary>
/// Block type for logging in .
/// Nesting mode: list
/// </summary>
public partial class GoogleStorageBucketLoggingBlock() : TerraformBlock("logging")
{
    /// <summary>
    /// The bucket that will receive log objects.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogBucket is required")]
    [TerraformProperty("log_bucket")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> LogBucket { get; set; }

    /// <summary>
    /// The object prefix for log objects. If it&#39;s not provided, by default Google Cloud Storage sets this to this bucket&#39;s name.
    /// </summary>
    [TerraformProperty("log_object_prefix")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> LogObjectPrefix { get; set; }

}

/// <summary>
/// Block type for retention_policy in .
/// Nesting mode: list
/// </summary>
public partial class GoogleStorageBucketRetentionPolicyBlock() : TerraformBlock("retention_policy")
{
    /// <summary>
    /// If set to true, the bucket will be locked and permanently restrict edits to the bucket&#39;s retention policy.  Caution: Locking a bucket is an irreversible action.
    /// </summary>
    [TerraformProperty("is_locked")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? IsLocked { get; set; }

    /// <summary>
    /// The period of time, in seconds, that objects in the bucket must be retained and cannot be deleted, overwritten, or archived. The value must be less than 3,155,760,000 seconds.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetentionPeriod is required")]
    [TerraformProperty("retention_period")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RetentionPeriod { get; set; }

}

/// <summary>
/// Block type for soft_delete_policy in .
/// Nesting mode: list
/// </summary>
public partial class GoogleStorageBucketSoftDeletePolicyBlock() : TerraformBlock("soft_delete_policy")
{

    /// <summary>
    /// The duration in seconds that soft-deleted objects in the bucket will be retained and cannot be permanently deleted. Default value is 604800.
    /// </summary>
    [TerraformProperty("retention_duration_seconds")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? RetentionDurationSeconds { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleStorageBucketTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for versioning in .
/// Nesting mode: list
/// </summary>
public partial class GoogleStorageBucketVersioningBlock() : TerraformBlock("versioning")
{
    /// <summary>
    /// While set to true, versioning is fully enabled for this bucket.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformProperty("enabled")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> Enabled { get; set; }

}

/// <summary>
/// Block type for website in .
/// Nesting mode: list
/// </summary>
public partial class GoogleStorageBucketWebsiteBlock() : TerraformBlock("website")
{
    /// <summary>
    /// Behaves as the bucket&#39;s directory index where missing objects are treated as potential directories.
    /// </summary>
    [TerraformProperty("main_page_suffix")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MainPageSuffix { get; set; }

    /// <summary>
    /// The custom object to return when a requested resource is not found.
    /// </summary>
    [TerraformProperty("not_found_page")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? NotFoundPage { get; set; }

}

/// <summary>
/// Manages a google_storage_bucket resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleStorageBucket : TerraformResource
{
    public GoogleStorageBucket(string name) : base("google_storage_bucket", name)
    {
    }

    /// <summary>
    /// Whether or not to automatically apply an eventBasedHold to new objects added to the bucket.
    /// </summary>
    [TerraformProperty("default_event_based_hold")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DefaultEventBasedHold { get; set; }

    /// <summary>
    /// Enables each object in the bucket to have its own retention policy, which prevents deletion until stored for a specific length of time.
    /// </summary>
    [TerraformProperty("enable_object_retention")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableObjectRetention { get; set; }

    /// <summary>
    /// When deleting a bucket, this boolean option will delete all contained objects, or anywhereCaches (if any). If you try to delete a bucket that contains objects or anywhereCaches, Terraform will fail that run, deleting anywhereCaches may take 80 minutes to complete.
    /// </summary>
    [TerraformProperty("force_destroy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ForceDestroy { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// A set of key/value label pairs to assign to the bucket.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The Google Cloud Storage location or region.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name of the bucket.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Prevents public access to a bucket.
    /// </summary>
    [TerraformProperty("public_access_prevention")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> PublicAccessPrevention { get; set; }

    /// <summary>
    /// Enables Requester Pays on a storage bucket.
    /// </summary>
    [TerraformProperty("requester_pays")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? RequesterPays { get; set; }

    /// <summary>
    /// Specifies the RPO setting of bucket. If set &#39;ASYNC_TURBO&#39;, The Turbo Replication will be enabled for the dual-region bucket. Value &#39;DEFAULT&#39; will set RPO setting to default. Turbo Replication is only for buckets in dual-regions.See the docs for more details.
    /// </summary>
    [TerraformProperty("rpo")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Rpo { get; set; }

    /// <summary>
    /// The Storage Class of the new bucket. Supported values include: STANDARD, MULTI_REGIONAL, REGIONAL, NEARLINE, COLDLINE, ARCHIVE.
    /// </summary>
    [TerraformProperty("storage_class")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? StorageClass { get; set; }

    /// <summary>
    /// Enables uniform bucket-level access on a bucket.
    /// </summary>
    [TerraformProperty("uniform_bucket_level_access")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> UniformBucketLevelAccess { get; set; }

    /// <summary>
    /// Block for autoclass.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Autoclass block(s) allowed")]
    [TerraformProperty("autoclass")]
    public TerraformList<GoogleStorageBucketAutoclassBlock> Autoclass { get; set; } = new();

    /// <summary>
    /// Block for cors.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("cors")]
    public TerraformList<GoogleStorageBucketCorsBlock> Cors { get; set; } = new();

    /// <summary>
    /// Block for custom_placement_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomPlacementConfig block(s) allowed")]
    [TerraformProperty("custom_placement_config")]
    public TerraformList<GoogleStorageBucketCustomPlacementConfigBlock> CustomPlacementConfig { get; set; } = new();

    /// <summary>
    /// Block for encryption.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Encryption block(s) allowed")]
    [TerraformProperty("encryption")]
    public TerraformList<GoogleStorageBucketEncryptionBlock> Encryption { get; set; } = new();

    /// <summary>
    /// Block for hierarchical_namespace.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HierarchicalNamespace block(s) allowed")]
    [TerraformProperty("hierarchical_namespace")]
    public TerraformList<GoogleStorageBucketHierarchicalNamespaceBlock> HierarchicalNamespace { get; set; } = new();

    /// <summary>
    /// Block for ip_filter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IpFilter block(s) allowed")]
    [TerraformProperty("ip_filter")]
    public TerraformList<GoogleStorageBucketIpFilterBlock> IpFilter { get; set; } = new();

    /// <summary>
    /// Block for lifecycle_rule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(100, ErrorMessage = "Maximum 100 LifecycleRule block(s) allowed")]
    [TerraformProperty("lifecycle_rule")]
    public TerraformList<GoogleStorageBucketLifecycleRuleBlock> LifecycleRule { get; set; } = new();

    /// <summary>
    /// Block for logging.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Logging block(s) allowed")]
    [TerraformProperty("logging")]
    public TerraformList<GoogleStorageBucketLoggingBlock> Logging { get; set; } = new();

    /// <summary>
    /// Block for retention_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionPolicy block(s) allowed")]
    [TerraformProperty("retention_policy")]
    public TerraformList<GoogleStorageBucketRetentionPolicyBlock> RetentionPolicy { get; set; } = new();

    /// <summary>
    /// Block for soft_delete_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SoftDeletePolicy block(s) allowed")]
    [TerraformProperty("soft_delete_policy")]
    public TerraformList<GoogleStorageBucketSoftDeletePolicyBlock> SoftDeletePolicy { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleStorageBucketTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for versioning.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Versioning block(s) allowed")]
    [TerraformProperty("versioning")]
    public TerraformList<GoogleStorageBucketVersioningBlock> Versioning { get; set; } = new();

    /// <summary>
    /// Block for website.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Website block(s) allowed")]
    [TerraformProperty("website")]
    public TerraformList<GoogleStorageBucketWebsiteBlock> Website { get; set; } = new();

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// The project number of the project in which the resource belongs.
    /// </summary>
    [TerraformProperty("project_number")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> ProjectNumber { get; }

    /// <summary>
    /// The URI of the created resource.
    /// </summary>
    [TerraformProperty("self_link")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SelfLink { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TerraformLabels { get; }

    /// <summary>
    /// The creation time of the bucket in RFC 3339 format.
    /// </summary>
    [TerraformProperty("time_created")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> TimeCreated { get; }

    /// <summary>
    /// The time at which the bucket&#39;s metadata or IAM policy was last updated, in RFC 3339 format.
    /// </summary>
    [TerraformProperty("updated")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Updated { get; }

    /// <summary>
    /// The base URL of the bucket, in the format gs://&amp;lt;bucket-name&amp;gt;.
    /// </summary>
    [TerraformProperty("url")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Url { get; }

}
