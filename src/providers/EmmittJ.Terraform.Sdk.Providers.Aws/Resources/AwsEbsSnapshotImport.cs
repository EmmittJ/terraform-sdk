using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for client_data in .
/// Nesting mode: list
/// </summary>
public class AwsEbsSnapshotImportClientDataBlock : ITerraformBlock
{
    /// <summary>
    /// The comment attribute.
    /// </summary>
    [TerraformPropertyName("comment")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Comment { get; set; }

    /// <summary>
    /// The upload_end attribute.
    /// </summary>
    [TerraformPropertyName("upload_end")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> UploadEnd { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "upload_end");

    /// <summary>
    /// The upload_size attribute.
    /// </summary>
    [TerraformPropertyName("upload_size")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> UploadSize { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "upload_size");

    /// <summary>
    /// The upload_start attribute.
    /// </summary>
    [TerraformPropertyName("upload_start")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> UploadStart { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "upload_start");

}

/// <summary>
/// Block type for disk_container in .
/// Nesting mode: list
/// </summary>
public class AwsEbsSnapshotImportDiskContainerBlock : ITerraformBlock
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The format attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Format is required")]
    [TerraformPropertyName("format")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Format { get; set; }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [TerraformPropertyName("url")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Url { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsEbsSnapshotImportTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

}

/// <summary>
/// Manages a aws_ebs_snapshot_import resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsEbsSnapshotImport : TerraformResource
{
    public AwsEbsSnapshotImport(string name) : base("aws_ebs_snapshot_import", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Description { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    [TerraformPropertyName("encrypted")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Encrypted { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? KmsKeyId { get; set; }

    /// <summary>
    /// The permanent_restore attribute.
    /// </summary>
    [TerraformPropertyName("permanent_restore")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? PermanentRestore { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The role_name attribute.
    /// </summary>
    [TerraformPropertyName("role_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RoleName { get; set; }

    /// <summary>
    /// The storage_tier attribute.
    /// </summary>
    [TerraformPropertyName("storage_tier")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> StorageTier { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "storage_tier");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// The temporary_restore_days attribute.
    /// </summary>
    [TerraformPropertyName("temporary_restore_days")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? TemporaryRestoreDays { get; set; }

    /// <summary>
    /// Block for client_data.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClientData block(s) allowed")]
    [TerraformPropertyName("client_data")]
    public TerraformList<TerraformBlock<AwsEbsSnapshotImportClientDataBlock>>? ClientData { get; set; } = new();

    /// <summary>
    /// Block for disk_container.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DiskContainer is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DiskContainer block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DiskContainer block(s) allowed")]
    [TerraformPropertyName("disk_container")]
    public TerraformList<TerraformBlock<AwsEbsSnapshotImportDiskContainerBlock>>? DiskContainer { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsEbsSnapshotImportTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The data_encryption_key_id attribute.
    /// </summary>
    [TerraformPropertyName("data_encryption_key_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DataEncryptionKeyId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "data_encryption_key_id");

    /// <summary>
    /// The outpost_arn attribute.
    /// </summary>
    [TerraformPropertyName("outpost_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OutpostArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "outpost_arn");

    /// <summary>
    /// The owner_alias attribute.
    /// </summary>
    [TerraformPropertyName("owner_alias")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OwnerAlias => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "owner_alias");

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformPropertyName("owner_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OwnerId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "owner_id");

    /// <summary>
    /// The volume_id attribute.
    /// </summary>
    [TerraformPropertyName("volume_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VolumeId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "volume_id");

    /// <summary>
    /// The volume_size attribute.
    /// </summary>
    [TerraformPropertyName("volume_size")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> VolumeSize => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "volume_size");

}
