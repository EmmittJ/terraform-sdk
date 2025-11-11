using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for autoclass in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageBucketAutoclassBlock
{
    /// <summary>
    /// While set to true, autoclass automatically transitions objects in your bucket to appropriate storage classes based on each object&#39;s access pattern.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformPropertyName("enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> Enabled { get; set; }

    /// <summary>
    /// The storage class that objects in the bucket eventually transition to if they are not read for a certain length of time. Supported values include: NEARLINE, ARCHIVE.
    /// </summary>
    [TerraformPropertyName("terminal_storage_class")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> TerminalStorageClass { get; set; } = default!;

}

/// <summary>
/// Block type for cors in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageBucketCorsBlock
{
    /// <summary>
    /// The value, in seconds, to return in the Access-Control-Max-Age header used in preflight responses.
    /// </summary>
    [TerraformPropertyName("max_age_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MaxAgeSeconds { get; set; }

    /// <summary>
    /// The list of HTTP methods on which to include CORS response headers, (GET, OPTIONS, POST, etc) Note: &amp;quot;*&amp;quot; is permitted in the list of methods, and means &amp;quot;any method&amp;quot;.
    /// </summary>
    [TerraformPropertyName("method")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? Method { get; set; }

    /// <summary>
    /// The list of Origins eligible to receive CORS response headers. Note: &amp;quot;*&amp;quot; is permitted in the list of origins, and means &amp;quot;any Origin&amp;quot;.
    /// </summary>
    [TerraformPropertyName("origin")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? Origin { get; set; }

    /// <summary>
    /// The list of HTTP headers other than the simple response headers to give permission for the user-agent to share across domains.
    /// </summary>
    [TerraformPropertyName("response_header")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? ResponseHeader { get; set; }

}

/// <summary>
/// Block type for custom_placement_config in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageBucketCustomPlacementConfigBlock
{
    /// <summary>
    /// The list of individual regions that comprise a dual-region bucket. See the docs for a list of acceptable regions. Note: If any of the data_locations changes, it will recreate the bucket.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataLocations is required")]
    [TerraformPropertyName("data_locations")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> DataLocations { get; set; }

}

/// <summary>
/// Block type for encryption in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageBucketEncryptionBlock
{
    /// <summary>
    /// A Cloud KMS key that will be used to encrypt objects inserted into this bucket, if no encryption method is specified. You must pay attention to whether the crypto key is available in the location that this bucket is created in. See the docs for more details.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultKmsKeyName is required")]
    [TerraformPropertyName("default_kms_key_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DefaultKmsKeyName { get; set; }

}

/// <summary>
/// Block type for hierarchical_namespace in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageBucketHierarchicalNamespaceBlock
{
    /// <summary>
    /// Set this field true to organize bucket with logical file system structure.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformPropertyName("enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> Enabled { get; set; }

}

/// <summary>
/// Block type for ip_filter in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageBucketIpFilterBlock
{
    /// <summary>
    /// Whether to allow all service agents to access the bucket regardless of the IP filter configuration.
    /// </summary>
    [TerraformPropertyName("allow_all_service_agent_access")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AllowAllServiceAgentAccess { get; set; }

    /// <summary>
    /// Whether to allow cross-org VPCs in the bucket&#39;s IP filter configuration.
    /// </summary>
    [TerraformPropertyName("allow_cross_org_vpcs")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AllowCrossOrgVpcs { get; set; }

    /// <summary>
    /// The mode of the IP filter. Valid values are &#39;Enabled&#39; and &#39;Disabled&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    [TerraformPropertyName("mode")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Mode { get; set; }

}

/// <summary>
/// Block type for lifecycle_rule in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageBucketLifecycleRuleBlock
{
}

/// <summary>
/// Block type for logging in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageBucketLoggingBlock
{
    /// <summary>
    /// The bucket that will receive log objects.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogBucket is required")]
    [TerraformPropertyName("log_bucket")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> LogBucket { get; set; }

    /// <summary>
    /// The object prefix for log objects. If it&#39;s not provided, by default Google Cloud Storage sets this to this bucket&#39;s name.
    /// </summary>
    [TerraformPropertyName("log_object_prefix")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> LogObjectPrefix { get; set; } = default!;

}

/// <summary>
/// Block type for retention_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageBucketRetentionPolicyBlock
{
    /// <summary>
    /// If set to true, the bucket will be locked and permanently restrict edits to the bucket&#39;s retention policy.  Caution: Locking a bucket is an irreversible action.
    /// </summary>
    [TerraformPropertyName("is_locked")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? IsLocked { get; set; }

    /// <summary>
    /// The period of time, in seconds, that objects in the bucket must be retained and cannot be deleted, overwritten, or archived. The value must be less than 3,155,760,000 seconds.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetentionPeriod is required")]
    [TerraformPropertyName("retention_period")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RetentionPeriod { get; set; }

}

/// <summary>
/// Block type for soft_delete_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageBucketSoftDeletePolicyBlock
{

    /// <summary>
    /// The duration in seconds that soft-deleted objects in the bucket will be retained and cannot be permanently deleted. Default value is 604800.
    /// </summary>
    [TerraformPropertyName("retention_duration_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? RetentionDurationSeconds { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleStorageBucketTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for versioning in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageBucketVersioningBlock
{
    /// <summary>
    /// While set to true, versioning is fully enabled for this bucket.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformPropertyName("enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> Enabled { get; set; }

}

/// <summary>
/// Block type for website in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageBucketWebsiteBlock
{
    /// <summary>
    /// Behaves as the bucket&#39;s directory index where missing objects are treated as potential directories.
    /// </summary>
    [TerraformPropertyName("main_page_suffix")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MainPageSuffix { get; set; }

    /// <summary>
    /// The custom object to return when a requested resource is not found.
    /// </summary>
    [TerraformPropertyName("not_found_page")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? NotFoundPage { get; set; }

}

/// <summary>
/// Manages a google_storage_bucket resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleStorageBucket : TerraformResource
{
    public GoogleStorageBucket(string name) : base("google_storage_bucket", name)
    {
    }

    /// <summary>
    /// Whether or not to automatically apply an eventBasedHold to new objects added to the bucket.
    /// </summary>
    [TerraformPropertyName("default_event_based_hold")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? DefaultEventBasedHold { get; set; }

    /// <summary>
    /// Enables each object in the bucket to have its own retention policy, which prevents deletion until stored for a specific length of time.
    /// </summary>
    [TerraformPropertyName("enable_object_retention")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnableObjectRetention { get; set; }

    /// <summary>
    /// When deleting a bucket, this boolean option will delete all contained objects, or anywhereCaches (if any). If you try to delete a bucket that contains objects or anywhereCaches, Terraform will fail that run, deleting anywhereCaches may take 80 minutes to complete.
    /// </summary>
    [TerraformPropertyName("force_destroy")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ForceDestroy { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// A set of key/value label pairs to assign to the bucket.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The Google Cloud Storage location or region.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name of the bucket.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// Prevents public access to a bucket.
    /// </summary>
    [TerraformPropertyName("public_access_prevention")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> PublicAccessPrevention { get; set; } = default!;

    /// <summary>
    /// Enables Requester Pays on a storage bucket.
    /// </summary>
    [TerraformPropertyName("requester_pays")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? RequesterPays { get; set; }

    /// <summary>
    /// Specifies the RPO setting of bucket. If set &#39;ASYNC_TURBO&#39;, The Turbo Replication will be enabled for the dual-region bucket. Value &#39;DEFAULT&#39; will set RPO setting to default. Turbo Replication is only for buckets in dual-regions.See the docs for more details.
    /// </summary>
    [TerraformPropertyName("rpo")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Rpo { get; set; } = default!;

    /// <summary>
    /// The Storage Class of the new bucket. Supported values include: STANDARD, MULTI_REGIONAL, REGIONAL, NEARLINE, COLDLINE, ARCHIVE.
    /// </summary>
    [TerraformPropertyName("storage_class")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? StorageClass { get; set; }

    /// <summary>
    /// Enables uniform bucket-level access on a bucket.
    /// </summary>
    [TerraformPropertyName("uniform_bucket_level_access")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> UniformBucketLevelAccess { get; set; } = default!;

    /// <summary>
    /// Block for autoclass.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Autoclass block(s) allowed")]
    [TerraformPropertyName("autoclass")]
    public TerraformList<TerraformBlock<GoogleStorageBucketAutoclassBlock>>? Autoclass { get; set; }

    /// <summary>
    /// Block for cors.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("cors")]
    public TerraformList<TerraformBlock<GoogleStorageBucketCorsBlock>>? Cors { get; set; }

    /// <summary>
    /// Block for custom_placement_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomPlacementConfig block(s) allowed")]
    [TerraformPropertyName("custom_placement_config")]
    public TerraformList<TerraformBlock<GoogleStorageBucketCustomPlacementConfigBlock>>? CustomPlacementConfig { get; set; }

    /// <summary>
    /// Block for encryption.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Encryption block(s) allowed")]
    [TerraformPropertyName("encryption")]
    public TerraformList<TerraformBlock<GoogleStorageBucketEncryptionBlock>>? Encryption { get; set; }

    /// <summary>
    /// Block for hierarchical_namespace.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HierarchicalNamespace block(s) allowed")]
    [TerraformPropertyName("hierarchical_namespace")]
    public TerraformList<TerraformBlock<GoogleStorageBucketHierarchicalNamespaceBlock>>? HierarchicalNamespace { get; set; }

    /// <summary>
    /// Block for ip_filter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IpFilter block(s) allowed")]
    [TerraformPropertyName("ip_filter")]
    public TerraformList<TerraformBlock<GoogleStorageBucketIpFilterBlock>>? IpFilter { get; set; }

    /// <summary>
    /// Block for lifecycle_rule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(100, ErrorMessage = "Maximum 100 LifecycleRule block(s) allowed")]
    [TerraformPropertyName("lifecycle_rule")]
    public TerraformList<TerraformBlock<GoogleStorageBucketLifecycleRuleBlock>>? LifecycleRule { get; set; }

    /// <summary>
    /// Block for logging.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Logging block(s) allowed")]
    [TerraformPropertyName("logging")]
    public TerraformList<TerraformBlock<GoogleStorageBucketLoggingBlock>>? Logging { get; set; }

    /// <summary>
    /// Block for retention_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionPolicy block(s) allowed")]
    [TerraformPropertyName("retention_policy")]
    public TerraformList<TerraformBlock<GoogleStorageBucketRetentionPolicyBlock>>? RetentionPolicy { get; set; }

    /// <summary>
    /// Block for soft_delete_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SoftDeletePolicy block(s) allowed")]
    [TerraformPropertyName("soft_delete_policy")]
    public TerraformList<TerraformBlock<GoogleStorageBucketSoftDeletePolicyBlock>>? SoftDeletePolicy { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleStorageBucketTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for versioning.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Versioning block(s) allowed")]
    [TerraformPropertyName("versioning")]
    public TerraformList<TerraformBlock<GoogleStorageBucketVersioningBlock>>? Versioning { get; set; }

    /// <summary>
    /// Block for website.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Website block(s) allowed")]
    [TerraformPropertyName("website")]
    public TerraformList<TerraformBlock<GoogleStorageBucketWebsiteBlock>>? Website { get; set; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> EffectiveLabels => new TerraformReference(this, "effective_labels");

    /// <summary>
    /// The project number of the project in which the resource belongs.
    /// </summary>
    [TerraformPropertyName("project_number")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> ProjectNumber => new TerraformReference(this, "project_number");

    /// <summary>
    /// The URI of the created resource.
    /// </summary>
    [TerraformPropertyName("self_link")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SelfLink => new TerraformReference(this, "self_link");

    /// <summary>
    /// The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> TerraformLabels => new TerraformReference(this, "terraform_labels");

    /// <summary>
    /// The creation time of the bucket in RFC 3339 format.
    /// </summary>
    [TerraformPropertyName("time_created")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TimeCreated => new TerraformReference(this, "time_created");

    /// <summary>
    /// The time at which the bucket&#39;s metadata or IAM policy was last updated, in RFC 3339 format.
    /// </summary>
    [TerraformPropertyName("updated")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Updated => new TerraformReference(this, "updated");

    /// <summary>
    /// The base URL of the bucket, in the format gs://&amp;lt;bucket-name&amp;gt;.
    /// </summary>
    [TerraformPropertyName("url")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Url => new TerraformReference(this, "url");

}
