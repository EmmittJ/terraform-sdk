using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for ebs_block_device in AwsAmiFromInstance.
/// Nesting mode: set
/// </summary>
public class AwsAmiFromInstanceEbsBlockDeviceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ebs_block_device";

    /// <summary>
    /// The delete_on_termination attribute.
    /// </summary>
    public TerraformValue<bool> DeleteOnTermination
    {
        get => new TerraformReference<bool>(this, "delete_on_termination");
    }

    /// <summary>
    /// The device_name attribute.
    /// </summary>
    public TerraformValue<string> DeviceName
    {
        get => new TerraformReference<string>(this, "device_name");
    }

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    public TerraformValue<bool> Encrypted
    {
        get => new TerraformReference<bool>(this, "encrypted");
    }

    /// <summary>
    /// The iops attribute.
    /// </summary>
    public TerraformValue<double> Iops
    {
        get => new TerraformReference<double>(this, "iops");
    }

    /// <summary>
    /// The outpost_arn attribute.
    /// </summary>
    public TerraformValue<string> OutpostArn
    {
        get => new TerraformReference<string>(this, "outpost_arn");
    }

    /// <summary>
    /// The snapshot_id attribute.
    /// </summary>
    public TerraformValue<string> SnapshotId
    {
        get => new TerraformReference<string>(this, "snapshot_id");
    }

    /// <summary>
    /// The throughput attribute.
    /// </summary>
    public TerraformValue<double> Throughput
    {
        get => new TerraformReference<double>(this, "throughput");
    }

    /// <summary>
    /// The volume_size attribute.
    /// </summary>
    public TerraformValue<double> VolumeSize
    {
        get => new TerraformReference<double>(this, "volume_size");
    }

    /// <summary>
    /// The volume_type attribute.
    /// </summary>
    public TerraformValue<string> VolumeType
    {
        get => new TerraformReference<string>(this, "volume_type");
    }

}


/// <summary>
/// Block type for ephemeral_block_device in AwsAmiFromInstance.
/// Nesting mode: set
/// </summary>
public class AwsAmiFromInstanceEphemeralBlockDeviceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ephemeral_block_device";

    /// <summary>
    /// The device_name attribute.
    /// </summary>
    public TerraformValue<string> DeviceName
    {
        get => new TerraformReference<string>(this, "device_name");
    }

    /// <summary>
    /// The virtual_name attribute.
    /// </summary>
    public TerraformValue<string> VirtualName
    {
        get => new TerraformReference<string>(this, "virtual_name");
    }

}


/// <summary>
/// Block type for timeouts in AwsAmiFromInstance.
/// Nesting mode: single
/// </summary>
public class AwsAmiFromInstanceTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_ami_from_instance Terraform resource.
/// Manages a aws_ami_from_instance resource.
/// </summary>
public partial class AwsAmiFromInstance(string name) : TerraformResource("aws_ami_from_instance", name)
{
    /// <summary>
    /// The deprecation_time attribute.
    /// </summary>
    public TerraformValue<string>? DeprecationTime
    {
        get => new TerraformReference<string>(this, "deprecation_time");
        set => SetArgument("deprecation_time", value);
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
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
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
    /// The snapshot_without_reboot attribute.
    /// </summary>
    public TerraformValue<bool>? SnapshotWithoutReboot
    {
        get => new TerraformReference<bool>(this, "snapshot_without_reboot");
        set => SetArgument("snapshot_without_reboot", value);
    }

    /// <summary>
    /// The source_instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceInstanceId is required")]
    public required TerraformValue<string> SourceInstanceId
    {
        get => new TerraformReference<string>(this, "source_instance_id");
        set => SetArgument("source_instance_id", value);
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
    /// The architecture attribute.
    /// </summary>
    public TerraformValue<string> Architecture
    {
        get => new TerraformReference<string>(this, "architecture");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The boot_mode attribute.
    /// </summary>
    public TerraformValue<string> BootMode
    {
        get => new TerraformReference<string>(this, "boot_mode");
    }

    /// <summary>
    /// The ena_support attribute.
    /// </summary>
    public TerraformValue<bool> EnaSupport
    {
        get => new TerraformReference<bool>(this, "ena_support");
    }

    /// <summary>
    /// The hypervisor attribute.
    /// </summary>
    public TerraformValue<string> Hypervisor
    {
        get => new TerraformReference<string>(this, "hypervisor");
    }

    /// <summary>
    /// The image_location attribute.
    /// </summary>
    public TerraformValue<string> ImageLocation
    {
        get => new TerraformReference<string>(this, "image_location");
    }

    /// <summary>
    /// The image_owner_alias attribute.
    /// </summary>
    public TerraformValue<string> ImageOwnerAlias
    {
        get => new TerraformReference<string>(this, "image_owner_alias");
    }

    /// <summary>
    /// The image_type attribute.
    /// </summary>
    public TerraformValue<string> ImageType
    {
        get => new TerraformReference<string>(this, "image_type");
    }

    /// <summary>
    /// The imds_support attribute.
    /// </summary>
    public TerraformValue<string> ImdsSupport
    {
        get => new TerraformReference<string>(this, "imds_support");
    }

    /// <summary>
    /// The kernel_id attribute.
    /// </summary>
    public TerraformValue<string> KernelId
    {
        get => new TerraformReference<string>(this, "kernel_id");
    }

    /// <summary>
    /// The last_launched_time attribute.
    /// </summary>
    public TerraformValue<string> LastLaunchedTime
    {
        get => new TerraformReference<string>(this, "last_launched_time");
    }

    /// <summary>
    /// The manage_ebs_snapshots attribute.
    /// </summary>
    public TerraformValue<bool> ManageEbsSnapshots
    {
        get => new TerraformReference<bool>(this, "manage_ebs_snapshots");
    }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformValue<string> OwnerId
    {
        get => new TerraformReference<string>(this, "owner_id");
    }

    /// <summary>
    /// The platform attribute.
    /// </summary>
    public TerraformValue<string> Platform
    {
        get => new TerraformReference<string>(this, "platform");
    }

    /// <summary>
    /// The platform_details attribute.
    /// </summary>
    public TerraformValue<string> PlatformDetails
    {
        get => new TerraformReference<string>(this, "platform_details");
    }

    /// <summary>
    /// The public attribute.
    /// </summary>
    public TerraformValue<bool> PublicAttribute
    {
        get => new TerraformReference<bool>(this, "public");
    }

    /// <summary>
    /// The ramdisk_id attribute.
    /// </summary>
    public TerraformValue<string> RamdiskId
    {
        get => new TerraformReference<string>(this, "ramdisk_id");
    }

    /// <summary>
    /// The root_device_name attribute.
    /// </summary>
    public TerraformValue<string> RootDeviceName
    {
        get => new TerraformReference<string>(this, "root_device_name");
    }

    /// <summary>
    /// The root_snapshot_id attribute.
    /// </summary>
    public TerraformValue<string> RootSnapshotId
    {
        get => new TerraformReference<string>(this, "root_snapshot_id");
    }

    /// <summary>
    /// The sriov_net_support attribute.
    /// </summary>
    public TerraformValue<string> SriovNetSupport
    {
        get => new TerraformReference<string>(this, "sriov_net_support");
    }

    /// <summary>
    /// The tpm_support attribute.
    /// </summary>
    public TerraformValue<string> TpmSupport
    {
        get => new TerraformReference<string>(this, "tpm_support");
    }

    /// <summary>
    /// The uefi_data attribute.
    /// </summary>
    public TerraformValue<string> UefiData
    {
        get => new TerraformReference<string>(this, "uefi_data");
    }

    /// <summary>
    /// The usage_operation attribute.
    /// </summary>
    public TerraformValue<string> UsageOperation
    {
        get => new TerraformReference<string>(this, "usage_operation");
    }

    /// <summary>
    /// The virtualization_type attribute.
    /// </summary>
    public TerraformValue<string> VirtualizationType
    {
        get => new TerraformReference<string>(this, "virtualization_type");
    }

    /// <summary>
    /// EbsBlockDevice block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsAmiFromInstanceEbsBlockDeviceBlock>? EbsBlockDevice
    {
        get => GetArgument<TerraformSet<AwsAmiFromInstanceEbsBlockDeviceBlock>>("ebs_block_device");
        set => SetArgument("ebs_block_device", value);
    }

    /// <summary>
    /// EphemeralBlockDevice block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsAmiFromInstanceEphemeralBlockDeviceBlock>? EphemeralBlockDevice
    {
        get => GetArgument<TerraformSet<AwsAmiFromInstanceEphemeralBlockDeviceBlock>>("ephemeral_block_device");
        set => SetArgument("ephemeral_block_device", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsAmiFromInstanceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsAmiFromInstanceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
