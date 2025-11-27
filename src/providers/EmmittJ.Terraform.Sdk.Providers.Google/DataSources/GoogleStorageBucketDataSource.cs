using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_storage_bucket Terraform data source.
/// Retrieves information about a google_storage_bucket.
/// </summary>
public partial class GoogleStorageBucketDataSource(string name) : TerraformDataSource("google_storage_bucket", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name of the bucket.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The bucket&#39;s autoclass configuration.
    /// </summary>
    public TerraformList<TerraformMap<object>> Autoclass
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "autoclass").ResolveNodes(ctx));
    }

    /// <summary>
    /// The bucket&#39;s Cross-Origin Resource Sharing (CORS) configuration.
    /// </summary>
    public TerraformList<TerraformMap<object>> Cors
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "cors").ResolveNodes(ctx));
    }

    /// <summary>
    /// The bucket&#39;s custom location configuration, which specifies the individual regions that comprise a dual-region bucket. If the bucket is designated a single or multi-region, the parameters are empty.
    /// </summary>
    public TerraformList<TerraformMap<object>> CustomPlacementConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "custom_placement_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// Whether or not to automatically apply an eventBasedHold to new objects added to the bucket.
    /// </summary>
    public TerraformValue<bool> DefaultEventBasedHold
    {
        get => new TerraformReference<bool>(this, "default_event_based_hold");
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "effective_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// Enables each object in the bucket to have its own retention policy, which prevents deletion until stored for a specific length of time.
    /// </summary>
    public TerraformValue<bool> EnableObjectRetention
    {
        get => new TerraformReference<bool>(this, "enable_object_retention");
    }

    /// <summary>
    /// The bucket&#39;s encryption configuration.
    /// </summary>
    public TerraformList<TerraformMap<object>> Encryption
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "encryption").ResolveNodes(ctx));
    }

    /// <summary>
    /// When deleting a bucket, this boolean option will delete all contained objects, or anywhereCaches (if any). If you try to delete a bucket that contains objects or anywhereCaches, Terraform will fail that run, deleting anywhereCaches may take 80 minutes to complete.
    /// </summary>
    public TerraformValue<bool> ForceDestroy
    {
        get => new TerraformReference<bool>(this, "force_destroy");
    }

    /// <summary>
    /// The bucket&#39;s HNS configuration, which defines bucket can organize folders in logical file system structure.
    /// </summary>
    public TerraformList<TerraformMap<object>> HierarchicalNamespace
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "hierarchical_namespace").ResolveNodes(ctx));
    }

    /// <summary>
    /// The bucket IP filtering configuration.
    /// </summary>
    public TerraformList<TerraformMap<object>> IpFilter
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "ip_filter").ResolveNodes(ctx));
    }

    /// <summary>
    /// A set of key/value label pairs to assign to the bucket.
    /// </summary>
    public TerraformMap<string> Labels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// The bucket&#39;s Lifecycle Rules configuration.
    /// </summary>
    public TerraformList<TerraformMap<object>> LifecycleRule
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "lifecycle_rule").ResolveNodes(ctx));
    }

    /// <summary>
    /// The Google Cloud Storage location or region.
    /// </summary>
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The bucket&#39;s Access &amp;amp; Storage Logs configuration.
    /// </summary>
    public TerraformList<TerraformMap<object>> Logging
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "logging").ResolveNodes(ctx));
    }

    /// <summary>
    /// The project number of the project in which the resource belongs.
    /// </summary>
    public TerraformValue<double> ProjectNumber
    {
        get => new TerraformReference<double>(this, "project_number");
    }

    /// <summary>
    /// Prevents public access to a bucket.
    /// </summary>
    public TerraformValue<string> PublicAccessPrevention
    {
        get => new TerraformReference<string>(this, "public_access_prevention");
    }

    /// <summary>
    /// Enables Requester Pays on a storage bucket.
    /// </summary>
    public TerraformValue<bool> RequesterPays
    {
        get => new TerraformReference<bool>(this, "requester_pays");
    }

    /// <summary>
    /// Configuration of the bucket&#39;s data retention policy for how long objects in the bucket should be retained.
    /// </summary>
    public TerraformList<TerraformMap<object>> RetentionPolicy
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "retention_policy").ResolveNodes(ctx));
    }

    /// <summary>
    /// Specifies the RPO setting of bucket. If set &#39;ASYNC_TURBO&#39;, The Turbo Replication will be enabled for the dual-region bucket. Value &#39;DEFAULT&#39; will set RPO setting to default. Turbo Replication is only for buckets in dual-regions.See the docs for more details.
    /// </summary>
    public TerraformValue<string> Rpo
    {
        get => new TerraformReference<string>(this, "rpo");
    }

    /// <summary>
    /// The URI of the created resource.
    /// </summary>
    public TerraformValue<string> SelfLink
    {
        get => new TerraformReference<string>(this, "self_link");
    }

    /// <summary>
    /// The bucket&#39;s soft delete policy, which defines the period of time that soft-deleted objects will be retained, and cannot be permanently deleted. If it is not provided, by default Google Cloud Storage sets this to default soft delete policy
    /// </summary>
    public TerraformList<TerraformMap<object>> SoftDeletePolicy
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "soft_delete_policy").ResolveNodes(ctx));
    }

    /// <summary>
    /// The Storage Class of the new bucket. Supported values include: STANDARD, MULTI_REGIONAL, REGIONAL, NEARLINE, COLDLINE, ARCHIVE.
    /// </summary>
    public TerraformValue<string> StorageClass
    {
        get => new TerraformReference<string>(this, "storage_class");
    }

    /// <summary>
    /// The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "terraform_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// The creation time of the bucket in RFC 3339 format.
    /// </summary>
    public TerraformValue<string> TimeCreated
    {
        get => new TerraformReference<string>(this, "time_created");
    }

    /// <summary>
    /// Enables uniform bucket-level access on a bucket.
    /// </summary>
    public TerraformValue<bool> UniformBucketLevelAccess
    {
        get => new TerraformReference<bool>(this, "uniform_bucket_level_access");
    }

    /// <summary>
    /// The time at which the bucket&#39;s metadata or IAM policy was last updated, in RFC 3339 format.
    /// </summary>
    public TerraformValue<string> Updated
    {
        get => new TerraformReference<string>(this, "updated");
    }

    /// <summary>
    /// The base URL of the bucket, in the format gs://&amp;lt;bucket-name&amp;gt;.
    /// </summary>
    public TerraformValue<string> Url
    {
        get => new TerraformReference<string>(this, "url");
    }

    /// <summary>
    /// The bucket&#39;s Versioning configuration.
    /// </summary>
    public TerraformList<TerraformMap<object>> Versioning
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "versioning").ResolveNodes(ctx));
    }

    /// <summary>
    /// Configuration if the bucket acts as a website.
    /// </summary>
    public TerraformList<TerraformMap<object>> Website
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "website").ResolveNodes(ctx));
    }

}
