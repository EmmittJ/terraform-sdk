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
        SetOutput("archive_size_bytes");
        SetOutput("creation_timestamp");
        SetOutput("description");
        SetOutput("disk_size_gb");
        SetOutput("image_encryption_key_sha256");
        SetOutput("image_id");
        SetOutput("label_fingerprint");
        SetOutput("labels");
        SetOutput("licenses");
        SetOutput("self_link");
        SetOutput("source_disk");
        SetOutput("source_disk_encryption_key_sha256");
        SetOutput("source_disk_id");
        SetOutput("source_image_id");
        SetOutput("status");
        SetOutput("family");
        SetOutput("filter");
        SetOutput("id");
        SetOutput("most_recent");
        SetOutput("name");
        SetOutput("project");
    }

    /// <summary>
    /// The family attribute.
    /// </summary>
    public TerraformProperty<string> Family
    {
        get => GetRequiredOutput<TerraformProperty<string>>("family");
        set => SetProperty("family", value);
    }

    /// <summary>
    /// The filter attribute.
    /// </summary>
    public TerraformProperty<string> Filter
    {
        get => GetRequiredOutput<TerraformProperty<string>>("filter");
        set => SetProperty("filter", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The most_recent attribute.
    /// </summary>
    public TerraformProperty<bool> MostRecent
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("most_recent");
        set => SetProperty("most_recent", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
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
