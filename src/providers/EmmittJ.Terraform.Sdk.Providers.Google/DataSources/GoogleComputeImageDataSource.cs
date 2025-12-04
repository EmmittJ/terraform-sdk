using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_compute_image Terraform data source.
/// Retrieves information about a google_compute_image.
/// </summary>
public partial class GoogleComputeImageDataSource(string name) : TerraformDataSource("google_compute_image", name)
{
    /// <summary>
    /// The family attribute.
    /// </summary>
    public TerraformValue<string>? Family
    {
        get => GetArgument<TerraformValue<string>>("family");
        set => SetArgument("family", value);
    }

    /// <summary>
    /// The filter attribute.
    /// </summary>
    public TerraformValue<string>? Filter
    {
        get => GetArgument<TerraformValue<string>>("filter");
        set => SetArgument("filter", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The most_recent attribute.
    /// </summary>
    public TerraformValue<bool>? MostRecent
    {
        get => GetArgument<TerraformValue<bool>>("most_recent");
        set => SetArgument("most_recent", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The archive_size_bytes attribute.
    /// </summary>
    public TerraformValue<double> ArchiveSizeBytes
        => AsReference("archive_size_bytes");

    /// <summary>
    /// The creation_timestamp attribute.
    /// </summary>
    public TerraformValue<string> CreationTimestamp
        => AsReference("creation_timestamp");

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// The disk_size_gb attribute.
    /// </summary>
    public TerraformValue<double> DiskSizeGb
        => AsReference("disk_size_gb");

    /// <summary>
    /// The image_encryption_key_sha256 attribute.
    /// </summary>
    public TerraformValue<string> ImageEncryptionKeySha256
        => AsReference("image_encryption_key_sha256");

    /// <summary>
    /// The image_id attribute.
    /// </summary>
    public TerraformValue<string> ImageId
        => AsReference("image_id");

    /// <summary>
    /// The label_fingerprint attribute.
    /// </summary>
    public TerraformValue<string> LabelFingerprint
        => AsReference("label_fingerprint");

    /// <summary>
    /// The labels attribute.
    /// </summary>
    public TerraformMap<string> Labels
        => AsReference("labels");

    /// <summary>
    /// The licenses attribute.
    /// </summary>
    public TerraformList<string> Licenses
        => AsReference("licenses");

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformValue<string> SelfLink
        => AsReference("self_link");

    /// <summary>
    /// The source_disk attribute.
    /// </summary>
    public TerraformValue<string> SourceDisk
        => AsReference("source_disk");

    /// <summary>
    /// The source_disk_encryption_key_sha256 attribute.
    /// </summary>
    public TerraformValue<string> SourceDiskEncryptionKeySha256
        => AsReference("source_disk_encryption_key_sha256");

    /// <summary>
    /// The source_disk_id attribute.
    /// </summary>
    public TerraformValue<string> SourceDiskId
        => AsReference("source_disk_id");

    /// <summary>
    /// The source_image_id attribute.
    /// </summary>
    public TerraformValue<string> SourceImageId
        => AsReference("source_image_id");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => AsReference("status");

}
