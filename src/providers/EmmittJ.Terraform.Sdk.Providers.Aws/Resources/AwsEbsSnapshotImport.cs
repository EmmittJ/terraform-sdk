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
        set => SetProperty("comment", value);
    }

    /// <summary>
    /// The upload_end attribute.
    /// </summary>
    public TerraformProperty<string>? UploadEnd
    {
        set => SetProperty("upload_end", value);
    }

    /// <summary>
    /// The upload_size attribute.
    /// </summary>
    public TerraformProperty<double>? UploadSize
    {
        set => SetProperty("upload_size", value);
    }

    /// <summary>
    /// The upload_start attribute.
    /// </summary>
    public TerraformProperty<string>? UploadStart
    {
        set => SetProperty("upload_start", value);
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
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The format attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Format is required")]
    public required TerraformProperty<string> Format
    {
        set => SetProperty("format", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    public TerraformProperty<string>? Url
    {
        set => SetProperty("url", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

}

/// <summary>
/// Manages a aws_ebs_snapshot_import resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsEbsSnapshotImport : TerraformResource
{
    public AwsEbsSnapshotImport(string name) : base("aws_ebs_snapshot_import", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("data_encryption_key_id");
        SetOutput("outpost_arn");
        SetOutput("owner_alias");
        SetOutput("owner_id");
        SetOutput("volume_id");
        SetOutput("volume_size");
        SetOutput("description");
        SetOutput("encrypted");
        SetOutput("id");
        SetOutput("kms_key_id");
        SetOutput("permanent_restore");
        SetOutput("region");
        SetOutput("role_name");
        SetOutput("storage_tier");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("temporary_restore_days");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    public TerraformProperty<bool> Encrypted
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("encrypted");
        set => SetProperty("encrypted", value);
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
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string> KmsKeyId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kms_key_id");
        set => SetProperty("kms_key_id", value);
    }

    /// <summary>
    /// The permanent_restore attribute.
    /// </summary>
    public TerraformProperty<bool> PermanentRestore
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("permanent_restore");
        set => SetProperty("permanent_restore", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The role_name attribute.
    /// </summary>
    public TerraformProperty<string> RoleName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("role_name");
        set => SetProperty("role_name", value);
    }

    /// <summary>
    /// The storage_tier attribute.
    /// </summary>
    public TerraformProperty<string> StorageTier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("storage_tier");
        set => SetProperty("storage_tier", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The temporary_restore_days attribute.
    /// </summary>
    public TerraformProperty<double> TemporaryRestoreDays
    {
        get => GetRequiredOutput<TerraformProperty<double>>("temporary_restore_days");
        set => SetProperty("temporary_restore_days", value);
    }

    /// <summary>
    /// Block for client_data.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClientData block(s) allowed")]
    public List<AwsEbsSnapshotImportClientDataBlock>? ClientData
    {
        set => SetProperty("client_data", value);
    }

    /// <summary>
    /// Block for disk_container.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DiskContainer is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DiskContainer block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DiskContainer block(s) allowed")]
    public List<AwsEbsSnapshotImportDiskContainerBlock>? DiskContainer
    {
        set => SetProperty("disk_container", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsEbsSnapshotImportTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
