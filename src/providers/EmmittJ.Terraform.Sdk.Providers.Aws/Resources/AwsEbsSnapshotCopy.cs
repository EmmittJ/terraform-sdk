using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsEbsSnapshotCopy.
/// Nesting mode: single
/// </summary>
public class AwsEbsSnapshotCopyTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

}


/// <summary>
/// Represents a aws_ebs_snapshot_copy Terraform resource.
/// Manages a aws_ebs_snapshot_copy resource.
/// </summary>
public partial class AwsEbsSnapshotCopy(string name) : TerraformResource("aws_ebs_snapshot_copy", name)
{
    /// <summary>
    /// The completion_duration_minutes attribute.
    /// </summary>
    public TerraformValue<double>? CompletionDurationMinutes
    {
        get => new TerraformReference<double>(this, "completion_duration_minutes");
        set => SetArgument("completion_duration_minutes", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    public TerraformValue<bool>? Encrypted
    {
        get => new TerraformReference<bool>(this, "encrypted");
        set => SetArgument("encrypted", value);
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
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyId
    {
        get => new TerraformReference<string>(this, "kms_key_id");
        set => SetArgument("kms_key_id", value);
    }

    /// <summary>
    /// The permanent_restore attribute.
    /// </summary>
    public TerraformValue<bool>? PermanentRestore
    {
        get => new TerraformReference<bool>(this, "permanent_restore");
        set => SetArgument("permanent_restore", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The source_region attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceRegion is required")]
    public required TerraformValue<string> SourceRegion
    {
        get => new TerraformReference<string>(this, "source_region");
        set => SetArgument("source_region", value);
    }

    /// <summary>
    /// The source_snapshot_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceSnapshotId is required")]
    public required TerraformValue<string> SourceSnapshotId
    {
        get => new TerraformReference<string>(this, "source_snapshot_id");
        set => SetArgument("source_snapshot_id", value);
    }

    /// <summary>
    /// The storage_tier attribute.
    /// </summary>
    public TerraformValue<string> StorageTier
    {
        get => new TerraformReference<string>(this, "storage_tier");
        set => SetArgument("storage_tier", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The temporary_restore_days attribute.
    /// </summary>
    public TerraformValue<double>? TemporaryRestoreDays
    {
        get => new TerraformReference<double>(this, "temporary_restore_days");
        set => SetArgument("temporary_restore_days", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The data_encryption_key_id attribute.
    /// </summary>
    public TerraformValue<string> DataEncryptionKeyId
    {
        get => new TerraformReference<string>(this, "data_encryption_key_id");
    }

    /// <summary>
    /// The outpost_arn attribute.
    /// </summary>
    public TerraformValue<string> OutpostArn
    {
        get => new TerraformReference<string>(this, "outpost_arn");
    }

    /// <summary>
    /// The owner_alias attribute.
    /// </summary>
    public TerraformValue<string> OwnerAlias
    {
        get => new TerraformReference<string>(this, "owner_alias");
    }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformValue<string> OwnerId
    {
        get => new TerraformReference<string>(this, "owner_id");
    }

    /// <summary>
    /// The volume_id attribute.
    /// </summary>
    public TerraformValue<string> VolumeId
    {
        get => new TerraformReference<string>(this, "volume_id");
    }

    /// <summary>
    /// The volume_size attribute.
    /// </summary>
    public TerraformValue<double> VolumeSize
    {
        get => new TerraformReference<double>(this, "volume_size");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsEbsSnapshotCopyTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsEbsSnapshotCopyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
