using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for ebs_block_device in AwsAmiCopy.
/// Nesting mode: set
/// </summary>
public class AwsAmiCopyEbsBlockDeviceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ebs_block_device";

    /// <summary>
    /// The delete_on_termination attribute.
    /// </summary>
    public TerraformValue<bool> DeleteOnTermination
        => AsReference("delete_on_termination");

    /// <summary>
    /// The device_name attribute.
    /// </summary>
    public TerraformValue<string> DeviceName
        => AsReference("device_name");

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    public TerraformValue<bool> Encrypted
        => AsReference("encrypted");

    /// <summary>
    /// The iops attribute.
    /// </summary>
    public TerraformValue<double> Iops
        => AsReference("iops");

    /// <summary>
    /// The outpost_arn attribute.
    /// </summary>
    public TerraformValue<string> OutpostArn
        => AsReference("outpost_arn");

    /// <summary>
    /// The snapshot_id attribute.
    /// </summary>
    public TerraformValue<string> SnapshotId
        => AsReference("snapshot_id");

    /// <summary>
    /// The throughput attribute.
    /// </summary>
    public TerraformValue<double> Throughput
        => AsReference("throughput");

    /// <summary>
    /// The volume_size attribute.
    /// </summary>
    public TerraformValue<double> VolumeSize
        => AsReference("volume_size");

    /// <summary>
    /// The volume_type attribute.
    /// </summary>
    public TerraformValue<string> VolumeType
        => AsReference("volume_type");

}


/// <summary>
/// Block type for ephemeral_block_device in AwsAmiCopy.
/// Nesting mode: set
/// </summary>
public class AwsAmiCopyEphemeralBlockDeviceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ephemeral_block_device";

    /// <summary>
    /// The device_name attribute.
    /// </summary>
    public TerraformValue<string> DeviceName
        => AsReference("device_name");

    /// <summary>
    /// The virtual_name attribute.
    /// </summary>
    public TerraformValue<string> VirtualName
        => AsReference("virtual_name");

}


/// <summary>
/// Block type for timeouts in AwsAmiCopy.
/// Nesting mode: single
/// </summary>
public class AwsAmiCopyTimeoutsBlock : TerraformBlock
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
/// Represents a aws_ami_copy Terraform resource.
/// Manages a aws_ami_copy resource.
/// </summary>
public partial class AwsAmiCopy(string name) : TerraformResource("aws_ami_copy", name)
{
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
    /// The destination_outpost_arn attribute.
    /// </summary>
    public TerraformValue<string>? DestinationOutpostArn
    {
        get => GetArgument<TerraformValue<string>>("destination_outpost_arn");
        set => SetArgument("destination_outpost_arn", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
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
    /// The source_ami_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceAmiId is required")]
    public required TerraformValue<string> SourceAmiId
    {
        get => GetArgument<TerraformValue<string>>("source_ami_id");
        set => SetArgument("source_ami_id", value);
    }

    /// <summary>
    /// The source_ami_region attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceAmiRegion is required")]
    public required TerraformValue<string> SourceAmiRegion
    {
        get => GetArgument<TerraformValue<string>>("source_ami_region");
        set => SetArgument("source_ami_region", value);
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
    /// The architecture attribute.
    /// </summary>
    public TerraformValue<string> Architecture
        => AsReference("architecture");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The boot_mode attribute.
    /// </summary>
    public TerraformValue<string> BootMode
        => AsReference("boot_mode");

    /// <summary>
    /// The ena_support attribute.
    /// </summary>
    public TerraformValue<bool> EnaSupport
        => AsReference("ena_support");

    /// <summary>
    /// The hypervisor attribute.
    /// </summary>
    public TerraformValue<string> Hypervisor
        => AsReference("hypervisor");

    /// <summary>
    /// The image_location attribute.
    /// </summary>
    public TerraformValue<string> ImageLocation
        => AsReference("image_location");

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
    /// The imds_support attribute.
    /// </summary>
    public TerraformValue<string> ImdsSupport
        => AsReference("imds_support");

    /// <summary>
    /// The kernel_id attribute.
    /// </summary>
    public TerraformValue<string> KernelId
        => AsReference("kernel_id");

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
    /// The ramdisk_id attribute.
    /// </summary>
    public TerraformValue<string> RamdiskId
        => AsReference("ramdisk_id");

    /// <summary>
    /// The root_device_name attribute.
    /// </summary>
    public TerraformValue<string> RootDeviceName
        => AsReference("root_device_name");

    /// <summary>
    /// The root_snapshot_id attribute.
    /// </summary>
    public TerraformValue<string> RootSnapshotId
        => AsReference("root_snapshot_id");

    /// <summary>
    /// The sriov_net_support attribute.
    /// </summary>
    public TerraformValue<string> SriovNetSupport
        => AsReference("sriov_net_support");

    /// <summary>
    /// The tpm_support attribute.
    /// </summary>
    public TerraformValue<string> TpmSupport
        => AsReference("tpm_support");

    /// <summary>
    /// The uefi_data attribute.
    /// </summary>
    public TerraformValue<string> UefiData
        => AsReference("uefi_data");

    /// <summary>
    /// The usage_operation attribute.
    /// </summary>
    public TerraformValue<string> UsageOperation
        => AsReference("usage_operation");

    /// <summary>
    /// The virtualization_type attribute.
    /// </summary>
    public TerraformValue<string> VirtualizationType
        => AsReference("virtualization_type");

    /// <summary>
    /// EbsBlockDevice block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsAmiCopyEbsBlockDeviceBlock>? EbsBlockDevice
    {
        get => GetArgument<TerraformSet<AwsAmiCopyEbsBlockDeviceBlock>>("ebs_block_device");
        set => SetArgument("ebs_block_device", value);
    }

    /// <summary>
    /// EphemeralBlockDevice block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsAmiCopyEphemeralBlockDeviceBlock>? EphemeralBlockDevice
    {
        get => GetArgument<TerraformSet<AwsAmiCopyEphemeralBlockDeviceBlock>>("ephemeral_block_device");
        set => SetArgument("ephemeral_block_device", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsAmiCopyTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsAmiCopyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
