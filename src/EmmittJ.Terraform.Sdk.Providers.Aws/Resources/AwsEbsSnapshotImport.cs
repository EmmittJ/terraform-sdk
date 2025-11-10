using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for client_data in .
/// Nesting mode: list
/// </summary>
public class AwsEbsSnapshotImportClientDataBlock : TerraformBlock
{
    /// <summary>
    /// The comment attribute.
    /// </summary>
    public TerraformProperty<string>? Comment
    {
        get => GetProperty<TerraformProperty<string>>("comment");
        set => WithProperty("comment", value);
    }

    /// <summary>
    /// The upload_end attribute.
    /// </summary>
    public TerraformProperty<string>? UploadEnd
    {
        get => GetProperty<TerraformProperty<string>>("upload_end");
        set => WithProperty("upload_end", value);
    }

    /// <summary>
    /// The upload_size attribute.
    /// </summary>
    public TerraformProperty<double>? UploadSize
    {
        get => GetProperty<TerraformProperty<double>>("upload_size");
        set => WithProperty("upload_size", value);
    }

    /// <summary>
    /// The upload_start attribute.
    /// </summary>
    public TerraformProperty<string>? UploadStart
    {
        get => GetProperty<TerraformProperty<string>>("upload_start");
        set => WithProperty("upload_start", value);
    }

}

/// <summary>
/// Block type for disk_container in .
/// Nesting mode: list
/// </summary>
public class AwsEbsSnapshotImportDiskContainerBlock : TerraformBlock
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => WithProperty("description", value);
    }

    /// <summary>
    /// The format attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Format is required")]
    public required TerraformProperty<string> Format
    {
        get => GetProperty<TerraformProperty<string>>("format");
        set => WithProperty("format", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    public TerraformProperty<string>? Url
    {
        get => GetProperty<TerraformProperty<string>>("url");
        set => WithProperty("url", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsEbsSnapshotImportTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

}

/// <summary>
/// Manages a aws_ebs_snapshot_import resource.
/// </summary>
public class AwsEbsSnapshotImport : TerraformResource
{
    public AwsEbsSnapshotImport(string name) : base("aws_ebs_snapshot_import", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("data_encryption_key_id");
        this.DeclareOutput("outpost_arn");
        this.DeclareOutput("owner_alias");
        this.DeclareOutput("owner_id");
        this.DeclareOutput("volume_id");
        this.DeclareOutput("volume_size");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    public TerraformProperty<bool>? Encrypted
    {
        get => GetProperty<TerraformProperty<bool>>("encrypted");
        set => this.WithProperty("encrypted", value);
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
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyId
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_id");
        set => this.WithProperty("kms_key_id", value);
    }

    /// <summary>
    /// The permanent_restore attribute.
    /// </summary>
    public TerraformProperty<bool>? PermanentRestore
    {
        get => GetProperty<TerraformProperty<bool>>("permanent_restore");
        set => this.WithProperty("permanent_restore", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The role_name attribute.
    /// </summary>
    public TerraformProperty<string>? RoleName
    {
        get => GetProperty<TerraformProperty<string>>("role_name");
        set => this.WithProperty("role_name", value);
    }

    /// <summary>
    /// The storage_tier attribute.
    /// </summary>
    public TerraformProperty<string>? StorageTier
    {
        get => GetProperty<TerraformProperty<string>>("storage_tier");
        set => this.WithProperty("storage_tier", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The temporary_restore_days attribute.
    /// </summary>
    public TerraformProperty<double>? TemporaryRestoreDays
    {
        get => GetProperty<TerraformProperty<double>>("temporary_restore_days");
        set => this.WithProperty("temporary_restore_days", value);
    }

    /// <summary>
    /// Block for client_data.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClientData block(s) allowed")]
    public List<AwsEbsSnapshotImportClientDataBlock>? ClientData
    {
        get => GetProperty<List<AwsEbsSnapshotImportClientDataBlock>>("client_data");
        set => this.WithProperty("client_data", value);
    }

    /// <summary>
    /// Block for disk_container.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DiskContainer block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DiskContainer block(s) allowed")]
    public List<AwsEbsSnapshotImportDiskContainerBlock>? DiskContainer
    {
        get => GetProperty<List<AwsEbsSnapshotImportDiskContainerBlock>>("disk_container");
        set => this.WithProperty("disk_container", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsEbsSnapshotImportTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsEbsSnapshotImportTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The data_encryption_key_id attribute.
    /// </summary>
    public TerraformExpression DataEncryptionKeyId => this["data_encryption_key_id"];

    /// <summary>
    /// The outpost_arn attribute.
    /// </summary>
    public TerraformExpression OutpostArn => this["outpost_arn"];

    /// <summary>
    /// The owner_alias attribute.
    /// </summary>
    public TerraformExpression OwnerAlias => this["owner_alias"];

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformExpression OwnerId => this["owner_id"];

    /// <summary>
    /// The volume_id attribute.
    /// </summary>
    public TerraformExpression VolumeId => this["volume_id"];

    /// <summary>
    /// The volume_size attribute.
    /// </summary>
    public TerraformExpression VolumeSize => this["volume_size"];

}
