using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_compute_image.
/// </summary>
public class GoogleComputeImageDataSource : TerraformDataSource
{
    public GoogleComputeImageDataSource(string name) : base("google_compute_image", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("archive_size_bytes");
        this.DeclareOutput("creation_timestamp");
        this.DeclareOutput("description");
        this.DeclareOutput("disk_size_gb");
        this.DeclareOutput("image_encryption_key_sha256");
        this.DeclareOutput("image_id");
        this.DeclareOutput("label_fingerprint");
        this.DeclareOutput("labels");
        this.DeclareOutput("licenses");
        this.DeclareOutput("self_link");
        this.DeclareOutput("source_disk");
        this.DeclareOutput("source_disk_encryption_key_sha256");
        this.DeclareOutput("source_disk_id");
        this.DeclareOutput("source_image_id");
        this.DeclareOutput("status");
    }

    /// <summary>
    /// The family attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Family
    {
        get => GetProperty<TerraformLiteralProperty<string>>("family");
        set => this.WithProperty("family", value);
    }

    /// <summary>
    /// The filter attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Filter
    {
        get => GetProperty<TerraformLiteralProperty<string>>("filter");
        set => this.WithProperty("filter", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The most_recent attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? MostRecent
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("most_recent");
        set => this.WithProperty("most_recent", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The archive_size_bytes attribute.
    /// </summary>
    public TerraformExpression ArchiveSizeBytes => this["archive_size_bytes"];

    /// <summary>
    /// The creation_timestamp attribute.
    /// </summary>
    public TerraformExpression CreationTimestamp => this["creation_timestamp"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The disk_size_gb attribute.
    /// </summary>
    public TerraformExpression DiskSizeGb => this["disk_size_gb"];

    /// <summary>
    /// The image_encryption_key_sha256 attribute.
    /// </summary>
    public TerraformExpression ImageEncryptionKeySha256 => this["image_encryption_key_sha256"];

    /// <summary>
    /// The image_id attribute.
    /// </summary>
    public TerraformExpression ImageId => this["image_id"];

    /// <summary>
    /// The label_fingerprint attribute.
    /// </summary>
    public TerraformExpression LabelFingerprint => this["label_fingerprint"];

    /// <summary>
    /// The labels attribute.
    /// </summary>
    public TerraformExpression Labels => this["labels"];

    /// <summary>
    /// The licenses attribute.
    /// </summary>
    public TerraformExpression Licenses => this["licenses"];

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

    /// <summary>
    /// The source_disk attribute.
    /// </summary>
    public TerraformExpression SourceDisk => this["source_disk"];

    /// <summary>
    /// The source_disk_encryption_key_sha256 attribute.
    /// </summary>
    public TerraformExpression SourceDiskEncryptionKeySha256 => this["source_disk_encryption_key_sha256"];

    /// <summary>
    /// The source_disk_id attribute.
    /// </summary>
    public TerraformExpression SourceDiskId => this["source_disk_id"];

    /// <summary>
    /// The source_image_id attribute.
    /// </summary>
    public TerraformExpression SourceImageId => this["source_image_id"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

}
