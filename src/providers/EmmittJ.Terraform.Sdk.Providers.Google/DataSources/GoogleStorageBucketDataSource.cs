using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_storage_bucket.
/// </summary>
public class GoogleStorageBucketDataSource : TerraformDataSource
{
    public GoogleStorageBucketDataSource(string name) : base("google_storage_bucket", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

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
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Project { get; set; }

    /// <summary>
    /// The bucket&#39;s autoclass configuration.
    /// </summary>
    [TerraformPropertyName("autoclass")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Autoclass => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "autoclass");

    /// <summary>
    /// The bucket&#39;s Cross-Origin Resource Sharing (CORS) configuration.
    /// </summary>
    [TerraformPropertyName("cors")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Cors => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "cors");

    /// <summary>
    /// The bucket&#39;s custom location configuration, which specifies the individual regions that comprise a dual-region bucket. If the bucket is designated a single or multi-region, the parameters are empty.
    /// </summary>
    [TerraformPropertyName("custom_placement_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> CustomPlacementConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "custom_placement_config");

    /// <summary>
    /// Whether or not to automatically apply an eventBasedHold to new objects added to the bucket.
    /// </summary>
    [TerraformPropertyName("default_event_based_hold")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> DefaultEventBasedHold => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "default_event_based_hold");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_labels");

    /// <summary>
    /// Enables each object in the bucket to have its own retention policy, which prevents deletion until stored for a specific length of time.
    /// </summary>
    [TerraformPropertyName("enable_object_retention")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> EnableObjectRetention => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "enable_object_retention");

    /// <summary>
    /// The bucket&#39;s encryption configuration.
    /// </summary>
    [TerraformPropertyName("encryption")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Encryption => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "encryption");

    /// <summary>
    /// When deleting a bucket, this boolean option will delete all contained objects, or anywhereCaches (if any). If you try to delete a bucket that contains objects or anywhereCaches, Terraform will fail that run, deleting anywhereCaches may take 80 minutes to complete.
    /// </summary>
    [TerraformPropertyName("force_destroy")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> ForceDestroy => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "force_destroy");

    /// <summary>
    /// The bucket&#39;s HNS configuration, which defines bucket can organize folders in logical file system structure.
    /// </summary>
    [TerraformPropertyName("hierarchical_namespace")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> HierarchicalNamespace => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "hierarchical_namespace");

    /// <summary>
    /// The bucket IP filtering configuration.
    /// </summary>
    [TerraformPropertyName("ip_filter")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> IpFilter => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "ip_filter");

    /// <summary>
    /// A set of key/value label pairs to assign to the bucket.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Labels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "labels");

    /// <summary>
    /// The bucket&#39;s Lifecycle Rules configuration.
    /// </summary>
    [TerraformPropertyName("lifecycle_rule")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> LifecycleRule => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "lifecycle_rule");

    /// <summary>
    /// The Google Cloud Storage location or region.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Location => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

    /// <summary>
    /// The bucket&#39;s Access &amp;amp; Storage Logs configuration.
    /// </summary>
    [TerraformPropertyName("logging")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Logging => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "logging");

    /// <summary>
    /// The project number of the project in which the resource belongs.
    /// </summary>
    [TerraformPropertyName("project_number")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> ProjectNumber => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "project_number");

    /// <summary>
    /// Prevents public access to a bucket.
    /// </summary>
    [TerraformPropertyName("public_access_prevention")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PublicAccessPrevention => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "public_access_prevention");

    /// <summary>
    /// Enables Requester Pays on a storage bucket.
    /// </summary>
    [TerraformPropertyName("requester_pays")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> RequesterPays => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "requester_pays");

    /// <summary>
    /// Configuration of the bucket&#39;s data retention policy for how long objects in the bucket should be retained.
    /// </summary>
    [TerraformPropertyName("retention_policy")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> RetentionPolicy => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "retention_policy");

    /// <summary>
    /// Specifies the RPO setting of bucket. If set &#39;ASYNC_TURBO&#39;, The Turbo Replication will be enabled for the dual-region bucket. Value &#39;DEFAULT&#39; will set RPO setting to default. Turbo Replication is only for buckets in dual-regions.See the docs for more details.
    /// </summary>
    [TerraformPropertyName("rpo")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Rpo => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "rpo");

    /// <summary>
    /// The URI of the created resource.
    /// </summary>
    [TerraformPropertyName("self_link")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SelfLink => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "self_link");

    /// <summary>
    /// The bucket&#39;s soft delete policy, which defines the period of time that soft-deleted objects will be retained, and cannot be permanently deleted. If it is not provided, by default Google Cloud Storage sets this to default soft delete policy
    /// </summary>
    [TerraformPropertyName("soft_delete_policy")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> SoftDeletePolicy => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "soft_delete_policy");

    /// <summary>
    /// The Storage Class of the new bucket. Supported values include: STANDARD, MULTI_REGIONAL, REGIONAL, NEARLINE, COLDLINE, ARCHIVE.
    /// </summary>
    [TerraformPropertyName("storage_class")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StorageClass => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "storage_class");

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
    /// Enables uniform bucket-level access on a bucket.
    /// </summary>
    [TerraformPropertyName("uniform_bucket_level_access")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> UniformBucketLevelAccess => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "uniform_bucket_level_access");

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

    /// <summary>
    /// The bucket&#39;s Versioning configuration.
    /// </summary>
    [TerraformPropertyName("versioning")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Versioning => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "versioning");

    /// <summary>
    /// Configuration if the bucket acts as a website.
    /// </summary>
    [TerraformPropertyName("website")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Website => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "website");

}
