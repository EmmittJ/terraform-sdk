using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsEbsSnapshot.
/// Nesting mode: single
/// </summary>
public class AwsEbsSnapshotTimeoutsBlock : TerraformBlock
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
/// Represents a aws_ebs_snapshot Terraform resource.
/// Manages a aws_ebs_snapshot resource.
/// </summary>
public partial class AwsEbsSnapshot(string name) : TerraformResource("aws_ebs_snapshot", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The outpost_arn attribute.
    /// </summary>
    public TerraformValue<string>? OutpostArn
    {
        get => GetArgument<TerraformValue<string>>("outpost_arn");
        set => SetArgument("outpost_arn", value);
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
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The storage_tier attribute.
    /// </summary>
    public TerraformValue<string> StorageTier
    {
        get => GetArgument<TerraformValue<string>>("storage_tier") ?? AsReference("storage_tier");
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
        get => GetArgument<TerraformMap<string>>("tags_all") ?? AsReference("tags_all");
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
    /// The volume_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VolumeId is required")]
    public required TerraformValue<string> VolumeId
    {
        get => GetRequiredArgument<TerraformValue<string>>("volume_id");
        set => SetArgument("volume_id", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The data_encryption_key_id attribute.
    /// </summary>
    public TerraformValue<string> DataEncryptionKeyId
        => AsReference("data_encryption_key_id");

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    public TerraformValue<bool> Encrypted
        => AsReference("encrypted");

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string> KmsKeyId
        => AsReference("kms_key_id");

    /// <summary>
    /// The owner_alias attribute.
    /// </summary>
    public TerraformValue<string> OwnerAlias
        => AsReference("owner_alias");

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformValue<string> OwnerId
        => AsReference("owner_id");

    /// <summary>
    /// The volume_size attribute.
    /// </summary>
    public TerraformValue<double> VolumeSize
        => AsReference("volume_size");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsEbsSnapshotTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsEbsSnapshotTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
