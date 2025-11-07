using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_storage_bucket resource.
/// </summary>
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
    public TerraformProperty<Dictionary<string, string>>? Labels
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// The Google Cloud Storage location or region.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name of the bucket.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
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
