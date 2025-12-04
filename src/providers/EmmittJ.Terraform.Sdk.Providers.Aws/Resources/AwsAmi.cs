using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for ebs_block_device in AwsAmi.
/// Nesting mode: set
/// </summary>
public class AwsAmiEbsBlockDeviceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ebs_block_device";

    /// <summary>
    /// The delete_on_termination attribute.
    /// </summary>
    public TerraformValue<bool>? DeleteOnTermination
    {
        get => GetArgument<TerraformValue<bool>>("delete_on_termination");
        set => SetArgument("delete_on_termination", value);
    }

    /// <summary>
    /// The device_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeviceName is required")]
    public required TerraformValue<string> DeviceName
    {
        get => GetRequiredArgument<TerraformValue<string>>("device_name");
        set => SetArgument("device_name", value);
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
    /// The iops attribute.
    /// </summary>
    public TerraformValue<double>? Iops
    {
        get => GetArgument<TerraformValue<double>>("iops");
        set => SetArgument("iops", value);
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
    /// The snapshot_id attribute.
    /// </summary>
    public TerraformValue<string>? SnapshotId
    {
        get => GetArgument<TerraformValue<string>>("snapshot_id");
        set => SetArgument("snapshot_id", value);
    }

    /// <summary>
    /// The throughput attribute.
    /// </summary>
    public TerraformValue<double> Throughput
    {
        get => GetArgument<TerraformValue<double>>("throughput") ?? AsReference("throughput");
        set => SetArgument("throughput", value);
    }

    /// <summary>
    /// The volume_size attribute.
    /// </summary>
    public TerraformValue<double> VolumeSize
    {
        get => GetArgument<TerraformValue<double>>("volume_size") ?? AsReference("volume_size");
        set => SetArgument("volume_size", value);
    }

    /// <summary>
    /// The volume_type attribute.
    /// </summary>
    public TerraformValue<string>? VolumeType
    {
        get => GetArgument<TerraformValue<string>>("volume_type");
        set => SetArgument("volume_type", value);
    }

}


/// <summary>
/// Block type for ephemeral_block_device in AwsAmi.
/// Nesting mode: set
/// </summary>
public class AwsAmiEphemeralBlockDeviceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ephemeral_block_device";

    /// <summary>
    /// The device_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeviceName is required")]
    public required TerraformValue<string> DeviceName
    {
        get => GetRequiredArgument<TerraformValue<string>>("device_name");
        set => SetArgument("device_name", value);
    }

    /// <summary>
    /// The virtual_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualName is required")]
    public required TerraformValue<string> VirtualName
    {
        get => GetRequiredArgument<TerraformValue<string>>("virtual_name");
        set => SetArgument("virtual_name", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsAmi.
/// Nesting mode: single
/// </summary>
public class AwsAmiTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_ami Terraform resource.
/// Manages a aws_ami resource.
/// </summary>
public partial class AwsAmi(string name) : TerraformResource("aws_ami", name)
{
    /// <summary>
    /// The architecture attribute.
    /// </summary>
    public TerraformValue<string>? Architecture
    {
        get => GetArgument<TerraformValue<string>>("architecture");
        set => SetArgument("architecture", value);
    }

    /// <summary>
    /// The boot_mode attribute.
    /// </summary>
    public TerraformValue<string>? BootMode
    {
        get => GetArgument<TerraformValue<string>>("boot_mode");
        set => SetArgument("boot_mode", value);
    }

    /// <summary>
    /// The deprecation_time attribute.
    /// </summary>
    public TerraformValue<string>? DeprecationTime
    {
        get => GetArgument<TerraformValue<string>>("deprecation_time");
        set => SetArgument("deprecation_time", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The ena_support attribute.
    /// </summary>
    public TerraformValue<bool>? EnaSupport
    {
        get => GetArgument<TerraformValue<bool>>("ena_support");
        set => SetArgument("ena_support", value);
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
    /// The image_location attribute.
    /// </summary>
    public TerraformValue<string> ImageLocation
    {
        get => GetArgument<TerraformValue<string>>("image_location") ?? AsReference("image_location");
        set => SetArgument("image_location", value);
    }

    /// <summary>
    /// The imds_support attribute.
    /// </summary>
    public TerraformValue<string>? ImdsSupport
    {
        get => GetArgument<TerraformValue<string>>("imds_support");
        set => SetArgument("imds_support", value);
    }

    /// <summary>
    /// The kernel_id attribute.
    /// </summary>
    public TerraformValue<string>? KernelId
    {
        get => GetArgument<TerraformValue<string>>("kernel_id");
        set => SetArgument("kernel_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The ramdisk_id attribute.
    /// </summary>
    public TerraformValue<string>? RamdiskId
    {
        get => GetArgument<TerraformValue<string>>("ramdisk_id");
        set => SetArgument("ramdisk_id", value);
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
    /// The root_device_name attribute.
    /// </summary>
    public TerraformValue<string>? RootDeviceName
    {
        get => GetArgument<TerraformValue<string>>("root_device_name");
        set => SetArgument("root_device_name", value);
    }

    /// <summary>
    /// The sriov_net_support attribute.
    /// </summary>
    public TerraformValue<string>? SriovNetSupport
    {
        get => GetArgument<TerraformValue<string>>("sriov_net_support");
        set => SetArgument("sriov_net_support", value);
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
    /// The tpm_support attribute.
    /// </summary>
    public TerraformValue<string>? TpmSupport
    {
        get => GetArgument<TerraformValue<string>>("tpm_support");
        set => SetArgument("tpm_support", value);
    }

    /// <summary>
    /// The uefi_data attribute.
    /// </summary>
    public TerraformValue<string>? UefiData
    {
        get => GetArgument<TerraformValue<string>>("uefi_data");
        set => SetArgument("uefi_data", value);
    }

    /// <summary>
    /// The virtualization_type attribute.
    /// </summary>
    public TerraformValue<string>? VirtualizationType
    {
        get => GetArgument<TerraformValue<string>>("virtualization_type");
        set => SetArgument("virtualization_type", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The hypervisor attribute.
    /// </summary>
    public TerraformValue<string> Hypervisor
        => AsReference("hypervisor");

    /// <summary>
    /// The image_owner_alias attribute.
    /// </summary>
    public TerraformValue<string> ImageOwnerAlias
        => AsReference("image_owner_alias");

    /// <summary>
    /// The image_type attribute.
    /// </summary>
    public TerraformValue<string> ImageType
        => AsReference("image_type");

    /// <summary>
    /// The last_launched_time attribute.
    /// </summary>
    public TerraformValue<string> LastLaunchedTime
        => AsReference("last_launched_time");

    /// <summary>
    /// The manage_ebs_snapshots attribute.
    /// </summary>
    public TerraformValue<bool> ManageEbsSnapshots
        => AsReference("manage_ebs_snapshots");

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformValue<string> OwnerId
        => AsReference("owner_id");

    /// <summary>
    /// The platform attribute.
    /// </summary>
    public TerraformValue<string> Platform
        => AsReference("platform");

    /// <summary>
    /// The platform_details attribute.
    /// </summary>
    public TerraformValue<string> PlatformDetails
        => AsReference("platform_details");

    /// <summary>
    /// The public attribute.
    /// </summary>
    public TerraformValue<bool> PublicAttribute
        => AsReference("public");

    /// <summary>
    /// The root_snapshot_id attribute.
    /// </summary>
    public TerraformValue<string> RootSnapshotId
        => AsReference("root_snapshot_id");

    /// <summary>
    /// The usage_operation attribute.
    /// </summary>
    public TerraformValue<string> UsageOperation
        => AsReference("usage_operation");

    /// <summary>
    /// EbsBlockDevice block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsAmiEbsBlockDeviceBlock>? EbsBlockDevice
    {
        get => GetArgument<TerraformSet<AwsAmiEbsBlockDeviceBlock>>("ebs_block_device");
        set => SetArgument("ebs_block_device", value);
    }

    /// <summary>
    /// EphemeralBlockDevice block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsAmiEphemeralBlockDeviceBlock>? EphemeralBlockDevice
    {
        get => GetArgument<TerraformSet<AwsAmiEphemeralBlockDeviceBlock>>("ephemeral_block_device");
        set => SetArgument("ephemeral_block_device", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsAmiTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsAmiTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
