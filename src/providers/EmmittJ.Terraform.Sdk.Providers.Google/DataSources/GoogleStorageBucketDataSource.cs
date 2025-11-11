using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_storage_bucket.
/// </summary>
public partial class GoogleStorageBucketDataSource : TerraformDataSource
{
    public GoogleStorageBucketDataSource(string name) : base("google_storage_bucket", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name of the bucket.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    [TerraformProperty("project")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// The bucket&#39;s autoclass configuration.
    /// </summary>
    [TerraformProperty("autoclass")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Autoclass { get; }

    /// <summary>
    /// The bucket&#39;s Cross-Origin Resource Sharing (CORS) configuration.
    /// </summary>
    [TerraformProperty("cors")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Cors { get; }

    /// <summary>
    /// The bucket&#39;s custom location configuration, which specifies the individual regions that comprise a dual-region bucket. If the bucket is designated a single or multi-region, the parameters are empty.
    /// </summary>
    [TerraformProperty("custom_placement_config")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> CustomPlacementConfig { get; }

    /// <summary>
    /// Whether or not to automatically apply an eventBasedHold to new objects added to the bucket.
    /// </summary>
    [TerraformProperty("default_event_based_hold")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> DefaultEventBasedHold { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// Enables each object in the bucket to have its own retention policy, which prevents deletion until stored for a specific length of time.
    /// </summary>
    [TerraformProperty("enable_object_retention")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> EnableObjectRetention { get; }

    /// <summary>
    /// The bucket&#39;s encryption configuration.
    /// </summary>
    [TerraformProperty("encryption")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Encryption { get; }

    /// <summary>
    /// When deleting a bucket, this boolean option will delete all contained objects, or anywhereCaches (if any). If you try to delete a bucket that contains objects or anywhereCaches, Terraform will fail that run, deleting anywhereCaches may take 80 minutes to complete.
    /// </summary>
    [TerraformProperty("force_destroy")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> ForceDestroy { get; }

    /// <summary>
    /// The bucket&#39;s HNS configuration, which defines bucket can organize folders in logical file system structure.
    /// </summary>
    [TerraformProperty("hierarchical_namespace")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> HierarchicalNamespace { get; }

    /// <summary>
    /// The bucket IP filtering configuration.
    /// </summary>
    [TerraformProperty("ip_filter")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> IpFilter { get; }

    /// <summary>
    /// A set of key/value label pairs to assign to the bucket.
    /// </summary>
    [TerraformProperty("labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> Labels { get; }

    /// <summary>
    /// The bucket&#39;s Lifecycle Rules configuration.
    /// </summary>
    [TerraformProperty("lifecycle_rule")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> LifecycleRule { get; }

    /// <summary>
    /// The Google Cloud Storage location or region.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Location { get; }

    /// <summary>
    /// The bucket&#39;s Access &amp;amp; Storage Logs configuration.
    /// </summary>
    [TerraformProperty("logging")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Logging { get; }

    /// <summary>
    /// The project number of the project in which the resource belongs.
    /// </summary>
    [TerraformProperty("project_number")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> ProjectNumber { get; }

    /// <summary>
    /// Prevents public access to a bucket.
    /// </summary>
    [TerraformProperty("public_access_prevention")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PublicAccessPrevention { get; }

    /// <summary>
    /// Enables Requester Pays on a storage bucket.
    /// </summary>
    [TerraformProperty("requester_pays")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> RequesterPays { get; }

    /// <summary>
    /// Configuration of the bucket&#39;s data retention policy for how long objects in the bucket should be retained.
    /// </summary>
    [TerraformProperty("retention_policy")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> RetentionPolicy { get; }

    /// <summary>
    /// Specifies the RPO setting of bucket. If set &#39;ASYNC_TURBO&#39;, The Turbo Replication will be enabled for the dual-region bucket. Value &#39;DEFAULT&#39; will set RPO setting to default. Turbo Replication is only for buckets in dual-regions.See the docs for more details.
    /// </summary>
    [TerraformProperty("rpo")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Rpo { get; }

    /// <summary>
    /// The URI of the created resource.
    /// </summary>
    [TerraformProperty("self_link")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SelfLink { get; }

    /// <summary>
    /// The bucket&#39;s soft delete policy, which defines the period of time that soft-deleted objects will be retained, and cannot be permanently deleted. If it is not provided, by default Google Cloud Storage sets this to default soft delete policy
    /// </summary>
    [TerraformProperty("soft_delete_policy")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> SoftDeletePolicy { get; }

    /// <summary>
    /// The Storage Class of the new bucket. Supported values include: STANDARD, MULTI_REGIONAL, REGIONAL, NEARLINE, COLDLINE, ARCHIVE.
    /// </summary>
    [TerraformProperty("storage_class")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> StorageClass { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> TerraformLabels { get; }

    /// <summary>
    /// The creation time of the bucket in RFC 3339 format.
    /// </summary>
    [TerraformProperty("time_created")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> TimeCreated { get; }

    /// <summary>
    /// Enables uniform bucket-level access on a bucket.
    /// </summary>
    [TerraformProperty("uniform_bucket_level_access")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> UniformBucketLevelAccess { get; }

    /// <summary>
    /// The time at which the bucket&#39;s metadata or IAM policy was last updated, in RFC 3339 format.
    /// </summary>
    [TerraformProperty("updated")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Updated { get; }

    /// <summary>
    /// The base URL of the bucket, in the format gs://&amp;lt;bucket-name&amp;gt;.
    /// </summary>
    [TerraformProperty("url")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Url { get; }

    /// <summary>
    /// The bucket&#39;s Versioning configuration.
    /// </summary>
    [TerraformProperty("versioning")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Versioning { get; }

    /// <summary>
    /// Configuration if the bucket acts as a website.
    /// </summary>
    [TerraformProperty("website")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Website { get; }

}
