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
        get => GetArgument<TerraformValue<string>>("create");
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
        get => GetArgument<TerraformValue<bool>>("copy_tags");
        set => SetArgument("copy_tags", value);
    }

    /// <summary>
    /// The destination_region attribute.
    /// </summary>
    public TerraformValue<string>? DestinationRegion
    {
        get => GetArgument<TerraformValue<string>>("destination_region");
        set => SetArgument("destination_region", value);
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
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyId
    {
        get => GetArgument<TerraformValue<string>>("kms_key_id");
        set => SetArgument("kms_key_id", value);
    }

    /// <summary>
    /// The option_group_name attribute.
    /// </summary>
    public TerraformValue<string>? OptionGroupName
    {
        get => GetArgument<TerraformValue<string>>("option_group_name");
        set => SetArgument("option_group_name", value);
    }

    /// <summary>
    /// The presigned_url attribute.
    /// </summary>
    public TerraformValue<string>? PresignedUrl
    {
        get => GetArgument<TerraformValue<string>>("presigned_url");
        set => SetArgument("presigned_url", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The shared_accounts attribute.
    /// </summary>
    public TerraformSet<string>? SharedAccounts
    {
        get => GetArgument<TerraformSet<string>>("shared_accounts");
        set => SetArgument("shared_accounts", value);
    }

    /// <summary>
    /// The source_db_snapshot_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceDbSnapshotIdentifier is required")]
    public required TerraformValue<string> SourceDbSnapshotIdentifier
    {
        get => GetArgument<TerraformValue<string>>("source_db_snapshot_identifier");
        set => SetArgument("source_db_snapshot_identifier", value);
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
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The target_custom_availability_zone attribute.
    /// </summary>
    public TerraformValue<string>? TargetCustomAvailabilityZone
    {
        get => GetArgument<TerraformValue<string>>("target_custom_availability_zone");
        set => SetArgument("target_custom_availability_zone", value);
    }

    /// <summary>
    /// The target_db_snapshot_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetDbSnapshotIdentifier is required")]
    public required TerraformValue<string> TargetDbSnapshotIdentifier
    {
        get => GetArgument<TerraformValue<string>>("target_db_snapshot_identifier");
        set => SetArgument("target_db_snapshot_identifier", value);
    }

    /// <summary>
    /// The allocated_storage attribute.
    /// </summary>
    public TerraformValue<double> AllocatedStorage
        => AsReference("allocated_storage");

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformValue<string> AvailabilityZone
        => AsReference("availability_zone");

    /// <summary>
    /// The db_snapshot_arn attribute.
    /// </summary>
    public TerraformValue<string> DbSnapshotArn
        => AsReference("db_snapshot_arn");

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    public TerraformValue<bool> Encrypted
        => AsReference("encrypted");

    /// <summary>
    /// The engine attribute.
    /// </summary>
    public TerraformValue<string> Engine
        => AsReference("engine");

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public TerraformValue<string> EngineVersion
        => AsReference("engine_version");

    /// <summary>
    /// The iops attribute.
    /// </summary>
    public TerraformValue<double> Iops
        => AsReference("iops");

    /// <summary>
    /// The license_model attribute.
    /// </summary>
    public TerraformValue<string> LicenseModel
        => AsReference("license_model");

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double> Port
        => AsReference("port");

    /// <summary>
    /// The snapshot_type attribute.
    /// </summary>
    public TerraformValue<string> SnapshotType
        => AsReference("snapshot_type");

    /// <summary>
    /// The source_region attribute.
    /// </summary>
    public TerraformValue<string> SourceRegion
        => AsReference("source_region");

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    public TerraformValue<string> StorageType
        => AsReference("storage_type");

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformValue<string> VpcId
        => AsReference("vpc_id");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsDbSnapshotCopyTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsDbSnapshotCopyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
