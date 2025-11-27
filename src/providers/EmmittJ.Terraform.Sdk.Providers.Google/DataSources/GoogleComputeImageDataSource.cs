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
    public TerraformValue<string> Family
    {
        get => new TerraformReference<string>(this, "family");
        set => SetArgument("family", value);
    }

    /// <summary>
    /// The filter attribute.
    /// </summary>
    public TerraformValue<string>? Filter
    {
        get => new TerraformReference<string>(this, "filter");
        set => SetArgument("filter", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The most_recent attribute.
    /// </summary>
    public TerraformValue<bool>? MostRecent
    {
        get => new TerraformReference<bool>(this, "most_recent");
        set => SetArgument("most_recent", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The archive_size_bytes attribute.
    /// </summary>
    public TerraformValue<double> ArchiveSizeBytes
    {
        get => new TerraformReference<double>(this, "archive_size_bytes");
    }

    /// <summary>
    /// The creation_timestamp attribute.
    /// </summary>
    public TerraformValue<string> CreationTimestamp
    {
        get => new TerraformReference<string>(this, "creation_timestamp");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// The disk_size_gb attribute.
    /// </summary>
    public TerraformValue<double> DiskSizeGb
    {
        get => new TerraformReference<double>(this, "disk_size_gb");
    }

    /// <summary>
    /// The image_encryption_key_sha256 attribute.
    /// </summary>
    public TerraformValue<string> ImageEncryptionKeySha256
    {
        get => new TerraformReference<string>(this, "image_encryption_key_sha256");
    }

    /// <summary>
    /// The image_id attribute.
    /// </summary>
    public TerraformValue<string> ImageId
    {
        get => new TerraformReference<string>(this, "image_id");
    }

    /// <summary>
    /// The label_fingerprint attribute.
    /// </summary>
    public TerraformValue<string> LabelFingerprint
    {
        get => new TerraformReference<string>(this, "label_fingerprint");
    }

    /// <summary>
    /// The labels attribute.
    /// </summary>
    public TerraformMap<string> Labels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// The licenses attribute.
    /// </summary>
    public TerraformList<string> Licenses
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "licenses").ResolveNodes(ctx));
    }

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformValue<string> SelfLink
    {
        get => new TerraformReference<string>(this, "self_link");
    }

    /// <summary>
    /// The source_disk attribute.
    /// </summary>
    public TerraformValue<string> SourceDisk
    {
        get => new TerraformReference<string>(this, "source_disk");
    }

    /// <summary>
    /// The source_disk_encryption_key_sha256 attribute.
    /// </summary>
    public TerraformValue<string> SourceDiskEncryptionKeySha256
    {
        get => new TerraformReference<string>(this, "source_disk_encryption_key_sha256");
    }

    /// <summary>
    /// The source_disk_id attribute.
    /// </summary>
    public TerraformValue<string> SourceDiskId
    {
        get => new TerraformReference<string>(this, "source_disk_id");
    }

    /// <summary>
    /// The source_image_id attribute.
    /// </summary>
    public TerraformValue<string> SourceImageId
    {
        get => new TerraformReference<string>(this, "source_image_id");
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

}
