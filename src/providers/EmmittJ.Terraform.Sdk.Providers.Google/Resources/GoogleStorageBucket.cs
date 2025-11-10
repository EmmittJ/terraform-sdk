using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for autoclass in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageBucketAutoclassBlock : ITerraformBlock
{
    /// <summary>
    /// While set to true, autoclass automatically transitions objects in your bucket to appropriate storage classes based on each object&#39;s access pattern.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformPropertyName("enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> Enabled { get; set; }

    /// <summary>
    /// The storage class that objects in the bucket eventually transition to if they are not read for a certain length of time. Supported values include: NEARLINE, ARCHIVE.
    /// </summary>
    [TerraformPropertyName("terminal_storage_class")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> TerminalStorageClass { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "terminal_storage_class");

}

/// <summary>
/// Block type for cors in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageBucketCorsBlock : ITerraformBlock
{
    /// <summary>
    /// The value, in seconds, to return in the Access-Control-Max-Age header used in preflight responses.
    /// </summary>
    [TerraformPropertyName("max_age_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MaxAgeSeconds { get; set; }

    /// <summary>
    /// The list of HTTP methods on which to include CORS response headers, (GET, OPTIONS, POST, etc) Note: &amp;quot;*&amp;quot; is permitted in the list of methods, and means &amp;quot;any method&amp;quot;.
    /// </summary>
    [TerraformPropertyName("method")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? Method { get; set; }

    /// <summary>
    /// The list of Origins eligible to receive CORS response headers. Note: &amp;quot;*&amp;quot; is permitted in the list of origins, and means &amp;quot;any Origin&amp;quot;.
    /// </summary>
    [TerraformPropertyName("origin")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? Origin { get; set; }

    /// <summary>
    /// The list of HTTP headers other than the simple response headers to give permission for the user-agent to share across domains.
    /// </summary>
    [TerraformPropertyName("response_header")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? ResponseHeader { get; set; }

}

/// <summary>
/// Block type for custom_placement_config in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageBucketCustomPlacementConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The list of individual regions that comprise a dual-region bucket. See the docs for a list of acceptable regions. Note: If any of the data_locations changes, it will recreate the bucket.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataLocations is required")]
    [TerraformPropertyName("data_locations")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? DataLocations { get; set; }

}

/// <summary>
/// Block type for encryption in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageBucketEncryptionBlock : ITerraformBlock
{
    /// <summary>
    /// A Cloud KMS key that will be used to encrypt objects inserted into this bucket, if no encryption method is specified. You must pay attention to whether the crypto key is available in the location that this bucket is created in. See the docs for more details.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultKmsKeyName is required")]
    [TerraformPropertyName("default_kms_key_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DefaultKmsKeyName { get; set; }

}

/// <summary>
/// Block type for hierarchical_namespace in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageBucketHierarchicalNamespaceBlock : ITerraformBlock
{
    /// <summary>
    /// Set this field true to organize bucket with logical file system structure.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformPropertyName("enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> Enabled { get; set; }

}

/// <summary>
/// Block type for ip_filter in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageBucketIpFilterBlock : ITerraformBlock
{
    /// <summary>
    /// Whether to allow all service agents to access the bucket regardless of the IP filter configuration.
    /// </summary>
    [TerraformPropertyName("allow_all_service_agent_access")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AllowAllServiceAgentAccess { get; set; }

    /// <summary>
    /// Whether to allow cross-org VPCs in the bucket&#39;s IP filter configuration.
    /// </summary>
    [TerraformPropertyName("allow_cross_org_vpcs")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AllowCrossOrgVpcs { get; set; }

    /// <summary>
    /// The mode of the IP filter. Valid values are &#39;Enabled&#39; and &#39;Disabled&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    [TerraformPropertyName("mode")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Mode { get; set; }

}

/// <summary>
/// Block type for lifecycle_rule in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageBucketLifecycleRuleBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for logging in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageBucketLoggingBlock : ITerraformBlock
{
    /// <summary>
    /// The bucket that will receive log objects.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogBucket is required")]
    [TerraformPropertyName("log_bucket")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> LogBucket { get; set; }

    /// <summary>
    /// The object prefix for log objects. If it&#39;s not provided, by default Google Cloud Storage sets this to this bucket&#39;s name.
    /// </summary>
    [TerraformPropertyName("log_object_prefix")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> LogObjectPrefix { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "log_object_prefix");

}

/// <summary>
/// Block type for retention_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageBucketRetentionPolicyBlock : ITerraformBlock
{
    /// <summary>
    /// If set to true, the bucket will be locked and permanently restrict edits to the bucket&#39;s retention policy.  Caution: Locking a bucket is an irreversible action.
    /// </summary>
    [TerraformPropertyName("is_locked")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IsLocked { get; set; }

    /// <summary>
    /// The period of time, in seconds, that objects in the bucket must be retained and cannot be deleted, overwritten, or archived. The value must be less than 3,155,760,000 seconds.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetentionPeriod is required")]
    [TerraformPropertyName("retention_period")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RetentionPeriod { get; set; }

}

/// <summary>
/// Block type for soft_delete_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageBucketSoftDeletePolicyBlock : ITerraformBlock
{
    /// <summary>
    /// Server-determined value that indicates the time from which the policy, or one with a greater retention, was effective. This value is in RFC 3339 format.
    /// </summary>
    [TerraformPropertyName("effective_time")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EffectiveTime => new TerraformReferenceProperty<TerraformProperty<string>>("", "effective_time");

    /// <summary>
    /// The duration in seconds that soft-deleted objects in the bucket will be retained and cannot be permanently deleted. Default value is 604800.
    /// </summary>
    [TerraformPropertyName("retention_duration_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? RetentionDurationSeconds { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleStorageBucketTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Block type for versioning in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageBucketVersioningBlock : ITerraformBlock
{
    /// <summary>
    /// While set to true, versioning is fully enabled for this bucket.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformPropertyName("enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> Enabled { get; set; }

}

/// <summary>
/// Block type for website in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageBucketWebsiteBlock : ITerraformBlock
{
    /// <summary>
    /// Behaves as the bucket&#39;s directory index where missing objects are treated as potential directories.
    /// </summary>
    [TerraformPropertyName("main_page_suffix")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MainPageSuffix { get; set; }

    /// <summary>
    /// The custom object to return when a requested resource is not found.
    /// </summary>
    [TerraformPropertyName("not_found_page")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? NotFoundPage { get; set; }

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
    public TerraformProperty<TerraformProperty<bool>>? DefaultEventBasedHold { get; set; }

    /// <summary>
    /// Enables each object in the bucket to have its own retention policy, which prevents deletion until stored for a specific length of time.
    /// </summary>
    [TerraformPropertyName("enable_object_retention")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableObjectRetention { get; set; }

    /// <summary>
    /// When deleting a bucket, this boolean option will delete all contained objects, or anywhereCaches (if any). If you try to delete a bucket that contains objects or anywhereCaches, Terraform will fail that run, deleting anywhereCaches may take 80 minutes to complete.
    /// </summary>
    [TerraformPropertyName("force_destroy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ForceDestroy { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// A set of key/value label pairs to assign to the bucket.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Labels { get; set; }

    /// <summary>
    /// The Google Cloud Storage location or region.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The name of the bucket.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Prevents public access to a bucket.
    /// </summary>
    [TerraformPropertyName("public_access_prevention")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> PublicAccessPrevention { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "public_access_prevention");

    /// <summary>
    /// Enables Requester Pays on a storage bucket.
    /// </summary>
    [TerraformPropertyName("requester_pays")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? RequesterPays { get; set; }

    /// <summary>
    /// Specifies the RPO setting of bucket. If set &#39;ASYNC_TURBO&#39;, The Turbo Replication will be enabled for the dual-region bucket. Value &#39;DEFAULT&#39; will set RPO setting to default. Turbo Replication is only for buckets in dual-regions.See the docs for more details.
    /// </summary>
    [TerraformPropertyName("rpo")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Rpo { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "rpo");

    /// <summary>
    /// The Storage Class of the new bucket. Supported values include: STANDARD, MULTI_REGIONAL, REGIONAL, NEARLINE, COLDLINE, ARCHIVE.
    /// </summary>
    [TerraformPropertyName("storage_class")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? StorageClass { get; set; }

    /// <summary>
    /// Enables uniform bucket-level access on a bucket.
    /// </summary>
    [TerraformPropertyName("uniform_bucket_level_access")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> UniformBucketLevelAccess { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "uniform_bucket_level_access");

    /// <summary>
    /// Block for autoclass.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Autoclass block(s) allowed")]
    [TerraformPropertyName("autoclass")]
    public TerraformList<TerraformBlock<GoogleStorageBucketAutoclassBlock>>? Autoclass { get; set; } = new();

    /// <summary>
    /// Block for cors.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("cors")]
    public TerraformList<TerraformBlock<GoogleStorageBucketCorsBlock>>? Cors { get; set; } = new();

    /// <summary>
    /// Block for custom_placement_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomPlacementConfig block(s) allowed")]
    [TerraformPropertyName("custom_placement_config")]
    public TerraformList<TerraformBlock<GoogleStorageBucketCustomPlacementConfigBlock>>? CustomPlacementConfig { get; set; } = new();

    /// <summary>
    /// Block for encryption.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Encryption block(s) allowed")]
    [TerraformPropertyName("encryption")]
    public TerraformList<TerraformBlock<GoogleStorageBucketEncryptionBlock>>? Encryption { get; set; } = new();

    /// <summary>
    /// Block for hierarchical_namespace.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HierarchicalNamespace block(s) allowed")]
    [TerraformPropertyName("hierarchical_namespace")]
    public TerraformList<TerraformBlock<GoogleStorageBucketHierarchicalNamespaceBlock>>? HierarchicalNamespace { get; set; } = new();

    /// <summary>
    /// Block for ip_filter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IpFilter block(s) allowed")]
    [TerraformPropertyName("ip_filter")]
    public TerraformList<TerraformBlock<GoogleStorageBucketIpFilterBlock>>? IpFilter { get; set; } = new();

    /// <summary>
    /// Block for lifecycle_rule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(100, ErrorMessage = "Maximum 100 LifecycleRule block(s) allowed")]
    [TerraformPropertyName("lifecycle_rule")]
    public TerraformList<TerraformBlock<GoogleStorageBucketLifecycleRuleBlock>>? LifecycleRule { get; set; } = new();

    /// <summary>
    /// Block for logging.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Logging block(s) allowed")]
    [TerraformPropertyName("logging")]
    public TerraformList<TerraformBlock<GoogleStorageBucketLoggingBlock>>? Logging { get; set; } = new();

    /// <summary>
    /// Block for retention_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionPolicy block(s) allowed")]
    [TerraformPropertyName("retention_policy")]
    public TerraformList<TerraformBlock<GoogleStorageBucketRetentionPolicyBlock>>? RetentionPolicy { get; set; } = new();

    /// <summary>
    /// Block for soft_delete_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SoftDeletePolicy block(s) allowed")]
    [TerraformPropertyName("soft_delete_policy")]
    public TerraformList<TerraformBlock<GoogleStorageBucketSoftDeletePolicyBlock>>? SoftDeletePolicy { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleStorageBucketTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Block for versioning.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Versioning block(s) allowed")]
    [TerraformPropertyName("versioning")]
    public TerraformList<TerraformBlock<GoogleStorageBucketVersioningBlock>>? Versioning { get; set; } = new();

    /// <summary>
    /// Block for website.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Website block(s) allowed")]
    [TerraformPropertyName("website")]
    public TerraformList<TerraformBlock<GoogleStorageBucketWebsiteBlock>>? Website { get; set; } = new();

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_labels");

    /// <summary>
    /// The project number of the project in which the resource belongs.
    /// </summary>
    [TerraformPropertyName("project_number")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> ProjectNumber => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "project_number");

    /// <summary>
    /// The URI of the created resource.
    /// </summary>
    [TerraformPropertyName("self_link")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SelfLink => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "self_link");

    /// <summary>
    /// The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TerraformLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "terraform_labels");

    /// <summary>
    /// The creation time of the bucket in RFC 3339 format.
    /// </summary>
    [TerraformPropertyName("time_created")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TimeCreated => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "time_created");

    /// <summary>
    /// The time at which the bucket&#39;s metadata or IAM policy was last updated, in RFC 3339 format.
    /// </summary>
    [TerraformPropertyName("updated")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Updated => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "updated");

    /// <summary>
    /// The base URL of the bucket, in the format gs://&amp;lt;bucket-name&amp;gt;.
    /// </summary>
    [TerraformPropertyName("url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Url => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "url");

}
