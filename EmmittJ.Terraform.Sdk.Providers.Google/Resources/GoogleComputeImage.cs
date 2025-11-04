using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_compute_image resource.
/// </summary>
public class GoogleComputeImage : TerraformResource
{
    public GoogleComputeImage(string name) : base("google_compute_image", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("archive_size_bytes");
        this.DeclareOutput("creation_timestamp");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("label_fingerprint");
        this.DeclareOutput("self_link");
        this.DeclareOutput("terraform_labels");
    }

    /// <summary>
    /// An optional description of this resource. Provide this property when
    /// you create the resource.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Size of the image when restored onto a persistent disk (in GB).
    /// </summary>
    public double? DiskSizeGb
    {
        get => GetProperty<TerraformLiteralProperty<double>>("disk_size_gb")?.Value;
        set => this.WithProperty("disk_size_gb", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The name of the image family to which this image belongs. You can
    /// create disks by specifying an image family instead of a specific
    /// image name. The image family always returns its latest image that is
    /// not deprecated. The name of the image family must comply with
    /// RFC1035.
    /// </summary>
    public string? Family
    {
        get => GetProperty<TerraformLiteralProperty<string>>("family")?.Value;
        set => this.WithProperty("family", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// Labels to apply to this Image.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, string>? Labels
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("labels")?.Value;
        set => this.WithProperty("labels", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// Any applicable license URI.
    /// </summary>
    public List<string>? Licenses
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("licenses")?.Value;
        set => this.WithProperty("licenses", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// Name of the resource; provided by the client when the resource is
    /// created. The name must be 1-63 characters long, and comply with
    /// RFC1035. Specifically, the name must be 1-63 characters long and
    /// match the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39; which means
    /// the first character must be a lowercase letter, and all following
    /// characters must be a dash, lowercase letter, or digit, except the
    /// last character, which cannot be a dash.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The source disk to create this image based on.
    /// You must provide either this property or the
    /// rawDisk.source property but not both to create an image.
    /// </summary>
    public string? SourceDisk
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_disk")?.Value;
        set => this.WithProperty("source_disk", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// URL of the source image used to create this image. In order to create an image, you must provide the full or partial
    /// URL of one of the following:
    /// 
    /// * The selfLink URL
    /// * This property
    /// * The rawDisk.source URL
    /// * The sourceDisk URL
    /// </summary>
    public string? SourceImage
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_image")?.Value;
        set => this.WithProperty("source_image", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// URL of the source snapshot used to create this image.
    /// 
    /// In order to create an image, you must provide the full or partial URL of one of the following:
    /// 
    /// * The selfLink URL
    /// * This property
    /// * The sourceImage URL
    /// * The rawDisk.source URL
    /// * The sourceDisk URL
    /// </summary>
    public string? SourceSnapshot
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_snapshot")?.Value;
        set => this.WithProperty("source_snapshot", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Cloud Storage bucket storage location of the image
    /// (regional or multi-regional).
    /// Reference link: https://cloud.google.com/compute/docs/reference/rest/v1/images
    /// </summary>
    public List<string>? StorageLocations
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("storage_locations")?.Value;
        set => this.WithProperty("storage_locations", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// Size of the image tar.gz archive stored in Google Cloud Storage (in
    /// bytes).
    /// </summary>
    public TerraformExpression ArchiveSizeBytes => this["archive_size_bytes"];

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformExpression CreationTimestamp => this["creation_timestamp"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The fingerprint used for optimistic locking of this resource. Used
    /// internally during updates.
    /// </summary>
    public TerraformExpression LabelFingerprint => this["label_fingerprint"];

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

}
