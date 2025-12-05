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
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
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
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The bucket&#39;s autoclass configuration.
    /// </summary>
    public TerraformList<TerraformMap<object>> Autoclass
        => CreateReference("autoclass");

    /// <summary>
    /// The bucket&#39;s Cross-Origin Resource Sharing (CORS) configuration.
    /// </summary>
    public TerraformList<TerraformMap<object>> Cors
        => CreateReference("cors");

    /// <summary>
    /// The bucket&#39;s custom location configuration, which specifies the individual regions that comprise a dual-region bucket. If the bucket is designated a single or multi-region, the parameters are empty.
    /// </summary>
    public TerraformList<TerraformMap<object>> CustomPlacementConfig
        => CreateReference("custom_placement_config");

    /// <summary>
    /// Whether or not to automatically apply an eventBasedHold to new objects added to the bucket.
    /// </summary>
    public TerraformValue<bool> DefaultEventBasedHold
        => CreateReference("default_event_based_hold");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => CreateReference("effective_labels");

    /// <summary>
    /// Enables each object in the bucket to have its own retention policy, which prevents deletion until stored for a specific length of time.
    /// </summary>
    public TerraformValue<bool> EnableObjectRetention
        => CreateReference("enable_object_retention");

    /// <summary>
    /// The bucket&#39;s encryption configuration.
    /// </summary>
    public TerraformList<TerraformMap<object>> Encryption
        => CreateReference("encryption");

    /// <summary>
    /// When deleting a bucket, this boolean option will delete all contained objects, or anywhereCaches (if any). If you try to delete a bucket that contains objects or anywhereCaches, Terraform will fail that run, deleting anywhereCaches may take 80 minutes to complete.
    /// </summary>
    public TerraformValue<bool> ForceDestroy
        => CreateReference("force_destroy");

    /// <summary>
    /// The bucket&#39;s HNS configuration, which defines bucket can organize folders in logical file system structure.
    /// </summary>
    public TerraformList<TerraformMap<object>> HierarchicalNamespace
        => CreateReference("hierarchical_namespace");

    /// <summary>
    /// The bucket IP filtering configuration.
    /// </summary>
    public TerraformList<TerraformMap<object>> IpFilter
        => CreateReference("ip_filter");

    /// <summary>
    /// A set of key/value label pairs to assign to the bucket.
    /// </summary>
    public TerraformMap<string> Labels
        => CreateReference("labels");

    /// <summary>
    /// The bucket&#39;s Lifecycle Rules configuration.
    /// </summary>
    public TerraformList<TerraformMap<object>> LifecycleRule
        => CreateReference("lifecycle_rule");

    /// <summary>
    /// The Google Cloud Storage location or region.
    /// </summary>
    public TerraformValue<string> Location
        => CreateReference("location");

    /// <summary>
    /// The bucket&#39;s Access &amp;amp; Storage Logs configuration.
    /// </summary>
    public TerraformList<TerraformMap<object>> Logging
        => CreateReference("logging");

    /// <summary>
    /// The project number of the project in which the resource belongs.
    /// </summary>
    public TerraformValue<double> ProjectNumber
        => CreateReference("project_number");

    /// <summary>
    /// Prevents public access to a bucket.
    /// </summary>
    public TerraformValue<string> PublicAccessPrevention
        => CreateReference("public_access_prevention");

    /// <summary>
    /// Enables Requester Pays on a storage bucket.
    /// </summary>
    public TerraformValue<bool> RequesterPays
        => CreateReference("requester_pays");

    /// <summary>
    /// Configuration of the bucket&#39;s data retention policy for how long objects in the bucket should be retained.
    /// </summary>
    public TerraformList<TerraformMap<object>> RetentionPolicy
        => CreateReference("retention_policy");

    /// <summary>
    /// Specifies the RPO setting of bucket. If set &#39;ASYNC_TURBO&#39;, The Turbo Replication will be enabled for the dual-region bucket. Value &#39;DEFAULT&#39; will set RPO setting to default. Turbo Replication is only for buckets in dual-regions.See the docs for more details.
    /// </summary>
    public TerraformValue<string> Rpo
        => CreateReference("rpo");

    /// <summary>
    /// The URI of the created resource.
    /// </summary>
    public TerraformValue<string> SelfLink
        => CreateReference("self_link");

    /// <summary>
    /// The bucket&#39;s soft delete policy, which defines the period of time that soft-deleted objects will be retained, and cannot be permanently deleted. If it is not provided, by default Google Cloud Storage sets this to default soft delete policy
    /// </summary>
    public TerraformList<TerraformMap<object>> SoftDeletePolicy
        => CreateReference("soft_delete_policy");

    /// <summary>
    /// The Storage Class of the new bucket. Supported values include: STANDARD, MULTI_REGIONAL, REGIONAL, NEARLINE, COLDLINE, ARCHIVE.
    /// </summary>
    public TerraformValue<string> StorageClass
        => CreateReference("storage_class");

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
    /// Enables uniform bucket-level access on a bucket.
    /// </summary>
    public TerraformValue<bool> UniformBucketLevelAccess
        => CreateReference("uniform_bucket_level_access");

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
    /// The bucket&#39;s Versioning configuration.
    /// </summary>
    public TerraformList<TerraformMap<object>> Versioning
        => CreateReference("versioning");

    /// <summary>
    /// Configuration if the bucket acts as a website.
    /// </summary>
    public TerraformList<TerraformMap<object>> Website
        => CreateReference("website");

}
