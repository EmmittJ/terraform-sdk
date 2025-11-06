using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_storage_bucket.
/// </summary>
public class GoogleStorageBucketDataSource : TerraformDataSource
{
    public GoogleStorageBucketDataSource(string name) : base("google_storage_bucket", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("autoclass");
        this.DeclareOutput("cors");
        this.DeclareOutput("custom_placement_config");
        this.DeclareOutput("default_event_based_hold");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("enable_object_retention");
        this.DeclareOutput("encryption");
        this.DeclareOutput("force_destroy");
        this.DeclareOutput("hierarchical_namespace");
        this.DeclareOutput("ip_filter");
        this.DeclareOutput("labels");
        this.DeclareOutput("lifecycle_rule");
        this.DeclareOutput("location");
        this.DeclareOutput("logging");
        this.DeclareOutput("project_number");
        this.DeclareOutput("public_access_prevention");
        this.DeclareOutput("requester_pays");
        this.DeclareOutput("retention_policy");
        this.DeclareOutput("rpo");
        this.DeclareOutput("self_link");
        this.DeclareOutput("soft_delete_policy");
        this.DeclareOutput("storage_class");
        this.DeclareOutput("terraform_labels");
        this.DeclareOutput("time_created");
        this.DeclareOutput("uniform_bucket_level_access");
        this.DeclareOutput("updated");
        this.DeclareOutput("url");
        this.DeclareOutput("versioning");
        this.DeclareOutput("website");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name of the bucket.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The bucket&#39;s autoclass configuration.
    /// </summary>
    public TerraformExpression Autoclass => this["autoclass"];

    /// <summary>
    /// The bucket&#39;s Cross-Origin Resource Sharing (CORS) configuration.
    /// </summary>
    public TerraformExpression Cors => this["cors"];

    /// <summary>
    /// The bucket&#39;s custom location configuration, which specifies the individual regions that comprise a dual-region bucket. If the bucket is designated a single or multi-region, the parameters are empty.
    /// </summary>
    public TerraformExpression CustomPlacementConfig => this["custom_placement_config"];

    /// <summary>
    /// Whether or not to automatically apply an eventBasedHold to new objects added to the bucket.
    /// </summary>
    public TerraformExpression DefaultEventBasedHold => this["default_event_based_hold"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// Enables each object in the bucket to have its own retention policy, which prevents deletion until stored for a specific length of time.
    /// </summary>
    public TerraformExpression EnableObjectRetention => this["enable_object_retention"];

    /// <summary>
    /// The bucket&#39;s encryption configuration.
    /// </summary>
    public TerraformExpression Encryption => this["encryption"];

    /// <summary>
    /// When deleting a bucket, this boolean option will delete all contained objects, or anywhereCaches (if any). If you try to delete a bucket that contains objects or anywhereCaches, Terraform will fail that run, deleting anywhereCaches may take 80 minutes to complete.
    /// </summary>
    public TerraformExpression ForceDestroy => this["force_destroy"];

    /// <summary>
    /// The bucket&#39;s HNS configuration, which defines bucket can organize folders in logical file system structure.
    /// </summary>
    public TerraformExpression HierarchicalNamespace => this["hierarchical_namespace"];

    /// <summary>
    /// The bucket IP filtering configuration.
    /// </summary>
    public TerraformExpression IpFilter => this["ip_filter"];

    /// <summary>
    /// A set of key/value label pairs to assign to the bucket.
    /// </summary>
    public TerraformExpression Labels => this["labels"];

    /// <summary>
    /// The bucket&#39;s Lifecycle Rules configuration.
    /// </summary>
    public TerraformExpression LifecycleRule => this["lifecycle_rule"];

    /// <summary>
    /// The Google Cloud Storage location or region.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The bucket&#39;s Access &amp;amp; Storage Logs configuration.
    /// </summary>
    public TerraformExpression Logging => this["logging"];

    /// <summary>
    /// The project number of the project in which the resource belongs.
    /// </summary>
    public TerraformExpression ProjectNumber => this["project_number"];

    /// <summary>
    /// Prevents public access to a bucket.
    /// </summary>
    public TerraformExpression PublicAccessPrevention => this["public_access_prevention"];

    /// <summary>
    /// Enables Requester Pays on a storage bucket.
    /// </summary>
    public TerraformExpression RequesterPays => this["requester_pays"];

    /// <summary>
    /// Configuration of the bucket&#39;s data retention policy for how long objects in the bucket should be retained.
    /// </summary>
    public TerraformExpression RetentionPolicy => this["retention_policy"];

    /// <summary>
    /// Specifies the RPO setting of bucket. If set &#39;ASYNC_TURBO&#39;, The Turbo Replication will be enabled for the dual-region bucket. Value &#39;DEFAULT&#39; will set RPO setting to default. Turbo Replication is only for buckets in dual-regions.See the docs for more details.
    /// </summary>
    public TerraformExpression Rpo => this["rpo"];

    /// <summary>
    /// The URI of the created resource.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

    /// <summary>
    /// The bucket&#39;s soft delete policy, which defines the period of time that soft-deleted objects will be retained, and cannot be permanently deleted. If it is not provided, by default Google Cloud Storage sets this to default soft delete policy
    /// </summary>
    public TerraformExpression SoftDeletePolicy => this["soft_delete_policy"];

    /// <summary>
    /// The Storage Class of the new bucket. Supported values include: STANDARD, MULTI_REGIONAL, REGIONAL, NEARLINE, COLDLINE, ARCHIVE.
    /// </summary>
    public TerraformExpression StorageClass => this["storage_class"];

    /// <summary>
    /// The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// The creation time of the bucket in RFC 3339 format.
    /// </summary>
    public TerraformExpression TimeCreated => this["time_created"];

    /// <summary>
    /// Enables uniform bucket-level access on a bucket.
    /// </summary>
    public TerraformExpression UniformBucketLevelAccess => this["uniform_bucket_level_access"];

    /// <summary>
    /// The time at which the bucket&#39;s metadata or IAM policy was last updated, in RFC 3339 format.
    /// </summary>
    public TerraformExpression Updated => this["updated"];

    /// <summary>
    /// The base URL of the bucket, in the format gs://&amp;lt;bucket-name&amp;gt;.
    /// </summary>
    public TerraformExpression Url => this["url"];

    /// <summary>
    /// The bucket&#39;s Versioning configuration.
    /// </summary>
    public TerraformExpression Versioning => this["versioning"];

    /// <summary>
    /// Configuration if the bucket acts as a website.
    /// </summary>
    public TerraformExpression Website => this["website"];

}
