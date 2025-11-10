using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for autoclass in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageBucketAutoclassBlock : TerraformBlock
{
    /// <summary>
    /// While set to true, autoclass automatically transitions objects in your bucket to appropriate storage classes based on each object&#39;s access pattern.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformProperty<bool> Enabled
    {
        get => GetRequiredProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
    }

    /// <summary>
    /// The storage class that objects in the bucket eventually transition to if they are not read for a certain length of time. Supported values include: NEARLINE, ARCHIVE.
    /// </summary>
    public TerraformProperty<string>? TerminalStorageClass
    {
        get => GetProperty<TerraformProperty<string>>("terminal_storage_class");
        set => WithProperty("terminal_storage_class", value);
    }

}

/// <summary>
/// Block type for cors in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageBucketCorsBlock : TerraformBlock
{
    /// <summary>
    /// The value, in seconds, to return in the Access-Control-Max-Age header used in preflight responses.
    /// </summary>
    public TerraformProperty<double>? MaxAgeSeconds
    {
        get => GetProperty<TerraformProperty<double>>("max_age_seconds");
        set => WithProperty("max_age_seconds", value);
    }

    /// <summary>
    /// The list of HTTP methods on which to include CORS response headers, (GET, OPTIONS, POST, etc) Note: &amp;quot;*&amp;quot; is permitted in the list of methods, and means &amp;quot;any method&amp;quot;.
    /// </summary>
    public List<TerraformProperty<string>>? Method
    {
        get => GetProperty<List<TerraformProperty<string>>>("method");
        set => WithProperty("method", value);
    }

    /// <summary>
    /// The list of Origins eligible to receive CORS response headers. Note: &amp;quot;*&amp;quot; is permitted in the list of origins, and means &amp;quot;any Origin&amp;quot;.
    /// </summary>
    public List<TerraformProperty<string>>? Origin
    {
        get => GetProperty<List<TerraformProperty<string>>>("origin");
        set => WithProperty("origin", value);
    }

    /// <summary>
    /// The list of HTTP headers other than the simple response headers to give permission for the user-agent to share across domains.
    /// </summary>
    public List<TerraformProperty<string>>? ResponseHeader
    {
        get => GetProperty<List<TerraformProperty<string>>>("response_header");
        set => WithProperty("response_header", value);
    }

}

/// <summary>
/// Block type for custom_placement_config in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageBucketCustomPlacementConfigBlock : TerraformBlock
{
    /// <summary>
    /// The list of individual regions that comprise a dual-region bucket. See the docs for a list of acceptable regions. Note: If any of the data_locations changes, it will recreate the bucket.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataLocations is required")]
    public HashSet<TerraformProperty<string>>? DataLocations
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("data_locations");
        set => WithProperty("data_locations", value);
    }

}

/// <summary>
/// Block type for encryption in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageBucketEncryptionBlock : TerraformBlock
{
    /// <summary>
    /// A Cloud KMS key that will be used to encrypt objects inserted into this bucket, if no encryption method is specified. You must pay attention to whether the crypto key is available in the location that this bucket is created in. See the docs for more details.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultKmsKeyName is required")]
    public required TerraformProperty<string> DefaultKmsKeyName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("default_kms_key_name");
        set => WithProperty("default_kms_key_name", value);
    }

}

/// <summary>
/// Block type for hierarchical_namespace in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageBucketHierarchicalNamespaceBlock : TerraformBlock
{
    /// <summary>
    /// Set this field true to organize bucket with logical file system structure.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformProperty<bool> Enabled
    {
        get => GetRequiredProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
    }

}

/// <summary>
/// Block type for ip_filter in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageBucketIpFilterBlock : TerraformBlock
{
    /// <summary>
    /// Whether to allow all service agents to access the bucket regardless of the IP filter configuration.
    /// </summary>
    public TerraformProperty<bool>? AllowAllServiceAgentAccess
    {
        get => GetProperty<TerraformProperty<bool>>("allow_all_service_agent_access");
        set => WithProperty("allow_all_service_agent_access", value);
    }

    /// <summary>
    /// Whether to allow cross-org VPCs in the bucket&#39;s IP filter configuration.
    /// </summary>
    public TerraformProperty<bool>? AllowCrossOrgVpcs
    {
        get => GetProperty<TerraformProperty<bool>>("allow_cross_org_vpcs");
        set => WithProperty("allow_cross_org_vpcs", value);
    }

    /// <summary>
    /// The mode of the IP filter. Valid values are &#39;Enabled&#39; and &#39;Disabled&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    public required TerraformProperty<string> Mode
    {
        get => GetRequiredProperty<TerraformProperty<string>>("mode");
        set => WithProperty("mode", value);
    }

}

/// <summary>
/// Block type for lifecycle_rule in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageBucketLifecycleRuleBlock : TerraformBlock
{
}

/// <summary>
/// Block type for logging in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageBucketLoggingBlock : TerraformBlock
{
    /// <summary>
    /// The bucket that will receive log objects.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogBucket is required")]
    public required TerraformProperty<string> LogBucket
    {
        get => GetRequiredProperty<TerraformProperty<string>>("log_bucket");
        set => WithProperty("log_bucket", value);
    }

    /// <summary>
    /// The object prefix for log objects. If it&#39;s not provided, by default Google Cloud Storage sets this to this bucket&#39;s name.
    /// </summary>
    public TerraformProperty<string>? LogObjectPrefix
    {
        get => GetProperty<TerraformProperty<string>>("log_object_prefix");
        set => WithProperty("log_object_prefix", value);
    }

}

/// <summary>
/// Block type for retention_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageBucketRetentionPolicyBlock : TerraformBlock
{
    /// <summary>
    /// If set to true, the bucket will be locked and permanently restrict edits to the bucket&#39;s retention policy.  Caution: Locking a bucket is an irreversible action.
    /// </summary>
    public TerraformProperty<bool>? IsLocked
    {
        get => GetProperty<TerraformProperty<bool>>("is_locked");
        set => WithProperty("is_locked", value);
    }

    /// <summary>
    /// The period of time, in seconds, that objects in the bucket must be retained and cannot be deleted, overwritten, or archived. The value must be less than 3,155,760,000 seconds.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetentionPeriod is required")]
    public required TerraformProperty<string> RetentionPeriod
    {
        get => GetRequiredProperty<TerraformProperty<string>>("retention_period");
        set => WithProperty("retention_period", value);
    }

}

/// <summary>
/// Block type for soft_delete_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageBucketSoftDeletePolicyBlock : TerraformBlock
{
    /// <summary>
    /// Server-determined value that indicates the time from which the policy, or one with a greater retention, was effective. This value is in RFC 3339 format.
    /// </summary>
    public TerraformProperty<string>? EffectiveTime
    {
        get => GetProperty<TerraformProperty<string>>("effective_time");
        set => WithProperty("effective_time", value);
    }

    /// <summary>
    /// The duration in seconds that soft-deleted objects in the bucket will be retained and cannot be permanently deleted. Default value is 604800.
    /// </summary>
    public TerraformProperty<double>? RetentionDurationSeconds
    {
        get => GetProperty<TerraformProperty<double>>("retention_duration_seconds");
        set => WithProperty("retention_duration_seconds", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleStorageBucketTimeoutsBlock : TerraformBlock
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
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
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
/// Block type for versioning in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageBucketVersioningBlock : TerraformBlock
{
    /// <summary>
    /// While set to true, versioning is fully enabled for this bucket.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformProperty<bool> Enabled
    {
        get => GetRequiredProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
    }

}

/// <summary>
/// Block type for website in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageBucketWebsiteBlock : TerraformBlock
{
    /// <summary>
    /// Behaves as the bucket&#39;s directory index where missing objects are treated as potential directories.
    /// </summary>
    public TerraformProperty<string>? MainPageSuffix
    {
        get => GetProperty<TerraformProperty<string>>("main_page_suffix");
        set => WithProperty("main_page_suffix", value);
    }

    /// <summary>
    /// The custom object to return when a requested resource is not found.
    /// </summary>
    public TerraformProperty<string>? NotFoundPage
    {
        get => GetProperty<TerraformProperty<string>>("not_found_page");
        set => WithProperty("not_found_page", value);
    }

}

/// <summary>
/// Manages a google_storage_bucket resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleStorageBucket : TerraformResource
{
    public GoogleStorageBucket(string name) : base("google_storage_bucket", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("project_number");
        this.DeclareOutput("self_link");
        this.DeclareOutput("terraform_labels");
        this.DeclareOutput("time_created");
        this.DeclareOutput("updated");
        this.DeclareOutput("url");
    }

    /// <summary>
    /// Whether or not to automatically apply an eventBasedHold to new objects added to the bucket.
    /// </summary>
    public TerraformProperty<bool>? DefaultEventBasedHold
    {
        get => GetProperty<TerraformProperty<bool>>("default_event_based_hold");
        set => this.WithProperty("default_event_based_hold", value);
    }

    /// <summary>
    /// Enables each object in the bucket to have its own retention policy, which prevents deletion until stored for a specific length of time.
    /// </summary>
    public TerraformProperty<bool>? EnableObjectRetention
    {
        get => GetProperty<TerraformProperty<bool>>("enable_object_retention");
        set => this.WithProperty("enable_object_retention", value);
    }

    /// <summary>
    /// When deleting a bucket, this boolean option will delete all contained objects, or anywhereCaches (if any). If you try to delete a bucket that contains objects or anywhereCaches, Terraform will fail that run, deleting anywhereCaches may take 80 minutes to complete.
    /// </summary>
    public TerraformProperty<bool>? ForceDestroy
    {
        get => GetProperty<TerraformProperty<bool>>("force_destroy");
        set => this.WithProperty("force_destroy", value);
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
    /// A set of key/value label pairs to assign to the bucket.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Labels
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// The Google Cloud Storage location or region.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name of the bucket.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// Prevents public access to a bucket.
    /// </summary>
    public TerraformProperty<string>? PublicAccessPrevention
    {
        get => GetProperty<TerraformProperty<string>>("public_access_prevention");
        set => this.WithProperty("public_access_prevention", value);
    }

    /// <summary>
    /// Enables Requester Pays on a storage bucket.
    /// </summary>
    public TerraformProperty<bool>? RequesterPays
    {
        get => GetProperty<TerraformProperty<bool>>("requester_pays");
        set => this.WithProperty("requester_pays", value);
    }

    /// <summary>
    /// Specifies the RPO setting of bucket. If set &#39;ASYNC_TURBO&#39;, The Turbo Replication will be enabled for the dual-region bucket. Value &#39;DEFAULT&#39; will set RPO setting to default. Turbo Replication is only for buckets in dual-regions.See the docs for more details.
    /// </summary>
    public TerraformProperty<string>? Rpo
    {
        get => GetProperty<TerraformProperty<string>>("rpo");
        set => this.WithProperty("rpo", value);
    }

    /// <summary>
    /// The Storage Class of the new bucket. Supported values include: STANDARD, MULTI_REGIONAL, REGIONAL, NEARLINE, COLDLINE, ARCHIVE.
    /// </summary>
    public TerraformProperty<string>? StorageClass
    {
        get => GetProperty<TerraformProperty<string>>("storage_class");
        set => this.WithProperty("storage_class", value);
    }

    /// <summary>
    /// Enables uniform bucket-level access on a bucket.
    /// </summary>
    public TerraformProperty<bool>? UniformBucketLevelAccess
    {
        get => GetProperty<TerraformProperty<bool>>("uniform_bucket_level_access");
        set => this.WithProperty("uniform_bucket_level_access", value);
    }

    /// <summary>
    /// Block for autoclass.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Autoclass block(s) allowed")]
    public List<GoogleStorageBucketAutoclassBlock>? Autoclass
    {
        get => GetProperty<List<GoogleStorageBucketAutoclassBlock>>("autoclass");
        set => this.WithProperty("autoclass", value);
    }

    /// <summary>
    /// Block for cors.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleStorageBucketCorsBlock>? Cors
    {
        get => GetProperty<List<GoogleStorageBucketCorsBlock>>("cors");
        set => this.WithProperty("cors", value);
    }

    /// <summary>
    /// Block for custom_placement_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomPlacementConfig block(s) allowed")]
    public List<GoogleStorageBucketCustomPlacementConfigBlock>? CustomPlacementConfig
    {
        get => GetProperty<List<GoogleStorageBucketCustomPlacementConfigBlock>>("custom_placement_config");
        set => this.WithProperty("custom_placement_config", value);
    }

    /// <summary>
    /// Block for encryption.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Encryption block(s) allowed")]
    public List<GoogleStorageBucketEncryptionBlock>? Encryption
    {
        get => GetProperty<List<GoogleStorageBucketEncryptionBlock>>("encryption");
        set => this.WithProperty("encryption", value);
    }

    /// <summary>
    /// Block for hierarchical_namespace.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HierarchicalNamespace block(s) allowed")]
    public List<GoogleStorageBucketHierarchicalNamespaceBlock>? HierarchicalNamespace
    {
        get => GetProperty<List<GoogleStorageBucketHierarchicalNamespaceBlock>>("hierarchical_namespace");
        set => this.WithProperty("hierarchical_namespace", value);
    }

    /// <summary>
    /// Block for ip_filter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IpFilter block(s) allowed")]
    public List<GoogleStorageBucketIpFilterBlock>? IpFilter
    {
        get => GetProperty<List<GoogleStorageBucketIpFilterBlock>>("ip_filter");
        set => this.WithProperty("ip_filter", value);
    }

    /// <summary>
    /// Block for lifecycle_rule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(100, ErrorMessage = "Maximum 100 LifecycleRule block(s) allowed")]
    public List<GoogleStorageBucketLifecycleRuleBlock>? LifecycleRule
    {
        get => GetProperty<List<GoogleStorageBucketLifecycleRuleBlock>>("lifecycle_rule");
        set => this.WithProperty("lifecycle_rule", value);
    }

    /// <summary>
    /// Block for logging.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Logging block(s) allowed")]
    public List<GoogleStorageBucketLoggingBlock>? Logging
    {
        get => GetProperty<List<GoogleStorageBucketLoggingBlock>>("logging");
        set => this.WithProperty("logging", value);
    }

    /// <summary>
    /// Block for retention_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionPolicy block(s) allowed")]
    public List<GoogleStorageBucketRetentionPolicyBlock>? RetentionPolicy
    {
        get => GetProperty<List<GoogleStorageBucketRetentionPolicyBlock>>("retention_policy");
        set => this.WithProperty("retention_policy", value);
    }

    /// <summary>
    /// Block for soft_delete_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SoftDeletePolicy block(s) allowed")]
    public List<GoogleStorageBucketSoftDeletePolicyBlock>? SoftDeletePolicy
    {
        get => GetProperty<List<GoogleStorageBucketSoftDeletePolicyBlock>>("soft_delete_policy");
        set => this.WithProperty("soft_delete_policy", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleStorageBucketTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleStorageBucketTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for versioning.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Versioning block(s) allowed")]
    public List<GoogleStorageBucketVersioningBlock>? Versioning
    {
        get => GetProperty<List<GoogleStorageBucketVersioningBlock>>("versioning");
        set => this.WithProperty("versioning", value);
    }

    /// <summary>
    /// Block for website.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Website block(s) allowed")]
    public List<GoogleStorageBucketWebsiteBlock>? Website
    {
        get => GetProperty<List<GoogleStorageBucketWebsiteBlock>>("website");
        set => this.WithProperty("website", value);
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The project number of the project in which the resource belongs.
    /// </summary>
    public TerraformExpression ProjectNumber => this["project_number"];

    /// <summary>
    /// The URI of the created resource.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

    /// <summary>
    /// The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// The creation time of the bucket in RFC 3339 format.
    /// </summary>
    public TerraformExpression TimeCreated => this["time_created"];

    /// <summary>
    /// The time at which the bucket&#39;s metadata or IAM policy was last updated, in RFC 3339 format.
    /// </summary>
    public TerraformExpression Updated => this["updated"];

    /// <summary>
    /// The base URL of the bucket, in the format gs://&amp;lt;bucket-name&amp;gt;.
    /// </summary>
    public TerraformExpression Url => this["url"];

}
