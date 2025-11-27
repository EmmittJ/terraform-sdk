using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsDbSnapshotCopy.
/// Nesting mode: single
/// </summary>
public class AwsDbSnapshotCopyTimeoutsBlock : TerraformBlock
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

}


/// <summary>
/// Represents a aws_db_snapshot_copy Terraform resource.
/// Manages a aws_db_snapshot_copy resource.
/// </summary>
public partial class AwsDbSnapshotCopy(string name) : TerraformResource("aws_db_snapshot_copy", name)
{
    /// <summary>
    /// The copy_tags attribute.
    /// </summary>
    public TerraformValue<bool>? CopyTags
    {
        get => new TerraformReference<bool>(this, "copy_tags");
        set => SetArgument("copy_tags", value);
    }

    /// <summary>
    /// The destination_region attribute.
    /// </summary>
    public TerraformValue<string>? DestinationRegion
    {
        get => new TerraformReference<string>(this, "destination_region");
        set => SetArgument("destination_region", value);
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
    /// The option_group_name attribute.
    /// </summary>
    public TerraformValue<string> OptionGroupName
    {
        get => new TerraformReference<string>(this, "option_group_name");
        set => SetArgument("option_group_name", value);
    }

    /// <summary>
    /// The presigned_url attribute.
    /// </summary>
    public TerraformValue<string>? PresignedUrl
    {
        get => new TerraformReference<string>(this, "presigned_url");
        set => SetArgument("presigned_url", value);
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
    /// The shared_accounts attribute.
    /// </summary>
    public TerraformSet<string>? SharedAccounts
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "shared_accounts").ResolveNodes(ctx));
        set => SetArgument("shared_accounts", value);
    }

    /// <summary>
    /// The source_db_snapshot_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceDbSnapshotIdentifier is required")]
    public required TerraformValue<string> SourceDbSnapshotIdentifier
    {
        get => new TerraformReference<string>(this, "source_db_snapshot_identifier");
        set => SetArgument("source_db_snapshot_identifier", value);
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
    /// The target_custom_availability_zone attribute.
    /// </summary>
    public TerraformValue<string>? TargetCustomAvailabilityZone
    {
        get => new TerraformReference<string>(this, "target_custom_availability_zone");
        set => SetArgument("target_custom_availability_zone", value);
    }

    /// <summary>
    /// The target_db_snapshot_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetDbSnapshotIdentifier is required")]
    public required TerraformValue<string> TargetDbSnapshotIdentifier
    {
        get => new TerraformReference<string>(this, "target_db_snapshot_identifier");
        set => SetArgument("target_db_snapshot_identifier", value);
    }

    /// <summary>
    /// The allocated_storage attribute.
    /// </summary>
    public TerraformValue<double> AllocatedStorage
    {
        get => new TerraformReference<double>(this, "allocated_storage");
    }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformValue<string> AvailabilityZone
    {
        get => new TerraformReference<string>(this, "availability_zone");
    }

    /// <summary>
    /// The db_snapshot_arn attribute.
    /// </summary>
    public TerraformValue<string> DbSnapshotArn
    {
        get => new TerraformReference<string>(this, "db_snapshot_arn");
    }

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    public TerraformValue<bool> Encrypted
    {
        get => new TerraformReference<bool>(this, "encrypted");
    }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    public TerraformValue<string> Engine
    {
        get => new TerraformReference<string>(this, "engine");
    }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public TerraformValue<string> EngineVersion
    {
        get => new TerraformReference<string>(this, "engine_version");
    }

    /// <summary>
    /// The iops attribute.
    /// </summary>
    public TerraformValue<double> Iops
    {
        get => new TerraformReference<double>(this, "iops");
    }

    /// <summary>
    /// The license_model attribute.
    /// </summary>
    public TerraformValue<string> LicenseModel
    {
        get => new TerraformReference<string>(this, "license_model");
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double> Port
    {
        get => new TerraformReference<double>(this, "port");
    }

    /// <summary>
    /// The snapshot_type attribute.
    /// </summary>
    public TerraformValue<string> SnapshotType
    {
        get => new TerraformReference<string>(this, "snapshot_type");
    }

    /// <summary>
    /// The source_region attribute.
    /// </summary>
    public TerraformValue<string> SourceRegion
    {
        get => new TerraformReference<string>(this, "source_region");
    }

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    public TerraformValue<string> StorageType
    {
        get => new TerraformReference<string>(this, "storage_type");
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformValue<string> VpcId
    {
        get => new TerraformReference<string>(this, "vpc_id");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsDbSnapshotCopyTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsDbSnapshotCopyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
