using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for client_data in AwsEbsSnapshotImport.
/// Nesting mode: list
/// </summary>
public class AwsEbsSnapshotImportClientDataBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "client_data";

    /// <summary>
    /// The comment attribute.
    /// </summary>
    public TerraformValue<string>? Comment
    {
        get => GetArgument<TerraformValue<string>>("comment");
        set => SetArgument("comment", value);
    }

    /// <summary>
    /// The upload_end attribute.
    /// </summary>
    public TerraformValue<string> UploadEnd
    {
        get => GetArgument<TerraformValue<string>>("upload_end") ?? CreateReference("upload_end");
        set => SetArgument("upload_end", value);
    }

    /// <summary>
    /// The upload_size attribute.
    /// </summary>
    public TerraformValue<double> UploadSize
    {
        get => GetArgument<TerraformValue<double>>("upload_size") ?? CreateReference("upload_size");
        set => SetArgument("upload_size", value);
    }

    /// <summary>
    /// The upload_start attribute.
    /// </summary>
    public TerraformValue<string> UploadStart
    {
        get => GetArgument<TerraformValue<string>>("upload_start") ?? CreateReference("upload_start");
        set => SetArgument("upload_start", value);
    }

}


/// <summary>
/// Block type for disk_container in AwsEbsSnapshotImport.
/// Nesting mode: list
/// </summary>
public class AwsEbsSnapshotImportDiskContainerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "disk_container";

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The format attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Format is required")]
    public required TerraformValue<string> Format
    {
        get => GetRequiredArgument<TerraformValue<string>>("format");
        set => SetArgument("format", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    public TerraformValue<string>? Url
    {
        get => GetArgument<TerraformValue<string>>("url");
        set => SetArgument("url", value);
    }

    /// <summary>
    /// UserBucket block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UserBucket block(s) allowed")]
    public TerraformList<AwsEbsSnapshotImportDiskContainerBlockUserBucketBlock>? UserBucket
    {
        get => GetArgument<TerraformList<AwsEbsSnapshotImportDiskContainerBlockUserBucketBlock>>("user_bucket");
        set => SetArgument("user_bucket", value);
    }

}

/// <summary>
/// Block type for user_bucket in AwsEbsSnapshotImportDiskContainerBlock.
/// Nesting mode: list
/// </summary>
public class AwsEbsSnapshotImportDiskContainerBlockUserBucketBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "user_bucket";

    /// <summary>
    /// The s3_bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Bucket is required")]
    public required TerraformValue<string> S3Bucket
    {
        get => GetRequiredArgument<TerraformValue<string>>("s3_bucket");
        set => SetArgument("s3_bucket", value);
    }

    /// <summary>
    /// The s3_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Key is required")]
    public required TerraformValue<string> S3Key
    {
        get => GetRequiredArgument<TerraformValue<string>>("s3_key");
        set => SetArgument("s3_key", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsEbsSnapshotImport.
/// Nesting mode: single
/// </summary>
public class AwsEbsSnapshotImportTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

}


/// <summary>
/// Represents a aws_ebs_snapshot_import Terraform resource.
/// Manages a aws_ebs_snapshot_import resource.
/// </summary>
public partial class AwsEbsSnapshotImport(string name) : TerraformResource("aws_ebs_snapshot_import", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => GetArgument<TerraformValue<string>>("description") ?? CreateReference("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    public TerraformValue<bool>? Encrypted
    {
        get => GetArgument<TerraformValue<bool>>("encrypted");
        set => SetArgument("encrypted", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyId
    {
        get => GetArgument<TerraformValue<string>>("kms_key_id");
        set => SetArgument("kms_key_id", value);
    }

    /// <summary>
    /// The permanent_restore attribute.
    /// </summary>
    public TerraformValue<bool>? PermanentRestore
    {
        get => GetArgument<TerraformValue<bool>>("permanent_restore");
        set => SetArgument("permanent_restore", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The role_name attribute.
    /// </summary>
    public TerraformValue<string>? RoleName
    {
        get => GetArgument<TerraformValue<string>>("role_name");
        set => SetArgument("role_name", value);
    }

    /// <summary>
    /// The storage_tier attribute.
    /// </summary>
    public TerraformValue<string> StorageTier
    {
        get => GetArgument<TerraformValue<string>>("storage_tier") ?? CreateReference("storage_tier");
        set => SetArgument("storage_tier", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? CreateReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The temporary_restore_days attribute.
    /// </summary>
    public TerraformValue<double>? TemporaryRestoreDays
    {
        get => GetArgument<TerraformValue<double>>("temporary_restore_days");
        set => SetArgument("temporary_restore_days", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The data_encryption_key_id attribute.
    /// </summary>
    public TerraformValue<string> DataEncryptionKeyId
        => CreateReference("data_encryption_key_id");

    /// <summary>
    /// The outpost_arn attribute.
    /// </summary>
    public TerraformValue<string> OutpostArn
        => CreateReference("outpost_arn");

    /// <summary>
    /// The owner_alias attribute.
    /// </summary>
    public TerraformValue<string> OwnerAlias
        => CreateReference("owner_alias");

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformValue<string> OwnerId
        => CreateReference("owner_id");

    /// <summary>
    /// The volume_id attribute.
    /// </summary>
    public TerraformValue<string> VolumeId
        => CreateReference("volume_id");

    /// <summary>
    /// The volume_size attribute.
    /// </summary>
    public TerraformValue<double> VolumeSize
        => CreateReference("volume_size");

    /// <summary>
    /// ClientData block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClientData block(s) allowed")]
    public TerraformList<AwsEbsSnapshotImportClientDataBlock>? ClientData
    {
        get => GetArgument<TerraformList<AwsEbsSnapshotImportClientDataBlock>>("client_data");
        set => SetArgument("client_data", value);
    }

    /// <summary>
    /// DiskContainer block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DiskContainer is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DiskContainer block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DiskContainer block(s) allowed")]
    public required TerraformList<AwsEbsSnapshotImportDiskContainerBlock> DiskContainer
    {
        get => GetRequiredArgument<TerraformList<AwsEbsSnapshotImportDiskContainerBlock>>("disk_container");
        set => SetArgument("disk_container", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsEbsSnapshotImportTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsEbsSnapshotImportTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
