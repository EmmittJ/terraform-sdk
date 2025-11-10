using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for ebs_block_device in .
/// Nesting mode: set
/// </summary>
public class AwsAmiEbsBlockDeviceBlock : TerraformBlock
{
    /// <summary>
    /// The delete_on_termination attribute.
    /// </summary>
    public TerraformProperty<bool>? DeleteOnTermination
    {
        set => SetProperty("delete_on_termination", value);
    }

    /// <summary>
    /// The device_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeviceName is required")]
    public required TerraformProperty<string> DeviceName
    {
        set => SetProperty("device_name", value);
    }

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    public TerraformProperty<bool>? Encrypted
    {
        set => SetProperty("encrypted", value);
    }

    /// <summary>
    /// The iops attribute.
    /// </summary>
    public TerraformProperty<double>? Iops
    {
        set => SetProperty("iops", value);
    }

    /// <summary>
    /// The outpost_arn attribute.
    /// </summary>
    public TerraformProperty<string>? OutpostArn
    {
        set => SetProperty("outpost_arn", value);
    }

    /// <summary>
    /// The snapshot_id attribute.
    /// </summary>
    public TerraformProperty<string>? SnapshotId
    {
        set => SetProperty("snapshot_id", value);
    }

    /// <summary>
    /// The throughput attribute.
    /// </summary>
    public TerraformProperty<double>? Throughput
    {
        set => SetProperty("throughput", value);
    }

    /// <summary>
    /// The volume_size attribute.
    /// </summary>
    public TerraformProperty<double>? VolumeSize
    {
        set => SetProperty("volume_size", value);
    }

    /// <summary>
    /// The volume_type attribute.
    /// </summary>
    public TerraformProperty<string>? VolumeType
    {
        set => SetProperty("volume_type", value);
    }

}

/// <summary>
/// Block type for ephemeral_block_device in .
/// Nesting mode: set
/// </summary>
public class AwsAmiEphemeralBlockDeviceBlock : TerraformBlock
{
    /// <summary>
    /// The device_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeviceName is required")]
    public required TerraformProperty<string> DeviceName
    {
        set => SetProperty("device_name", value);
    }

    /// <summary>
    /// The virtual_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualName is required")]
    public required TerraformProperty<string> VirtualName
    {
        set => SetProperty("virtual_name", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsAmiTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_ami resource.
/// </summary>
public class AwsAmi : TerraformResource
{
    public AwsAmi(string name) : base("aws_ami", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("hypervisor");
        SetOutput("image_owner_alias");
        SetOutput("image_type");
        SetOutput("last_launched_time");
        SetOutput("manage_ebs_snapshots");
        SetOutput("owner_id");
        SetOutput("platform");
        SetOutput("platform_details");
        SetOutput("public");
        SetOutput("root_snapshot_id");
        SetOutput("usage_operation");
        SetOutput("architecture");
        SetOutput("boot_mode");
        SetOutput("deprecation_time");
        SetOutput("description");
        SetOutput("ena_support");
        SetOutput("id");
        SetOutput("image_location");
        SetOutput("imds_support");
        SetOutput("kernel_id");
        SetOutput("name");
        SetOutput("ramdisk_id");
        SetOutput("region");
        SetOutput("root_device_name");
        SetOutput("sriov_net_support");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("tpm_support");
        SetOutput("uefi_data");
        SetOutput("virtualization_type");
    }

    /// <summary>
    /// The architecture attribute.
    /// </summary>
    public TerraformProperty<string> Architecture
    {
        get => GetRequiredOutput<TerraformProperty<string>>("architecture");
        set => SetProperty("architecture", value);
    }

    /// <summary>
    /// The boot_mode attribute.
    /// </summary>
    public TerraformProperty<string> BootMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("boot_mode");
        set => SetProperty("boot_mode", value);
    }

    /// <summary>
    /// The deprecation_time attribute.
    /// </summary>
    public TerraformProperty<string> DeprecationTime
    {
        get => GetRequiredOutput<TerraformProperty<string>>("deprecation_time");
        set => SetProperty("deprecation_time", value);
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
    /// The ena_support attribute.
    /// </summary>
    public TerraformProperty<bool> EnaSupport
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("ena_support");
        set => SetProperty("ena_support", value);
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
    /// The image_location attribute.
    /// </summary>
    public TerraformProperty<string> ImageLocation
    {
        get => GetRequiredOutput<TerraformProperty<string>>("image_location");
        set => SetProperty("image_location", value);
    }

    /// <summary>
    /// The imds_support attribute.
    /// </summary>
    public TerraformProperty<string> ImdsSupport
    {
        get => GetRequiredOutput<TerraformProperty<string>>("imds_support");
        set => SetProperty("imds_support", value);
    }

    /// <summary>
    /// The kernel_id attribute.
    /// </summary>
    public TerraformProperty<string> KernelId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kernel_id");
        set => SetProperty("kernel_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The ramdisk_id attribute.
    /// </summary>
    public TerraformProperty<string> RamdiskId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ramdisk_id");
        set => SetProperty("ramdisk_id", value);
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
    /// The root_device_name attribute.
    /// </summary>
    public TerraformProperty<string> RootDeviceName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("root_device_name");
        set => SetProperty("root_device_name", value);
    }

    /// <summary>
    /// The sriov_net_support attribute.
    /// </summary>
    public TerraformProperty<string> SriovNetSupport
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sriov_net_support");
        set => SetProperty("sriov_net_support", value);
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
    /// The tpm_support attribute.
    /// </summary>
    public TerraformProperty<string> TpmSupport
    {
        get => GetRequiredOutput<TerraformProperty<string>>("tpm_support");
        set => SetProperty("tpm_support", value);
    }

    /// <summary>
    /// The uefi_data attribute.
    /// </summary>
    public TerraformProperty<string> UefiData
    {
        get => GetRequiredOutput<TerraformProperty<string>>("uefi_data");
        set => SetProperty("uefi_data", value);
    }

    /// <summary>
    /// The virtualization_type attribute.
    /// </summary>
    public TerraformProperty<string> VirtualizationType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("virtualization_type");
        set => SetProperty("virtualization_type", value);
    }

    /// <summary>
    /// Block for ebs_block_device.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsAmiEbsBlockDeviceBlock>? EbsBlockDevice
    {
        set => SetProperty("ebs_block_device", value);
    }

    /// <summary>
    /// Block for ephemeral_block_device.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsAmiEphemeralBlockDeviceBlock>? EphemeralBlockDevice
    {
        set => SetProperty("ephemeral_block_device", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsAmiTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The hypervisor attribute.
    /// </summary>
    public TerraformExpression Hypervisor => this["hypervisor"];

    /// <summary>
    /// The image_owner_alias attribute.
    /// </summary>
    public TerraformExpression ImageOwnerAlias => this["image_owner_alias"];

    /// <summary>
    /// The image_type attribute.
    /// </summary>
    public TerraformExpression ImageType => this["image_type"];

    /// <summary>
    /// The last_launched_time attribute.
    /// </summary>
    public TerraformExpression LastLaunchedTime => this["last_launched_time"];

    /// <summary>
    /// The manage_ebs_snapshots attribute.
    /// </summary>
    public TerraformExpression ManageEbsSnapshots => this["manage_ebs_snapshots"];

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformExpression OwnerId => this["owner_id"];

    /// <summary>
    /// The platform attribute.
    /// </summary>
    public TerraformExpression Platform => this["platform"];

    /// <summary>
    /// The platform_details attribute.
    /// </summary>
    public TerraformExpression PlatformDetails => this["platform_details"];

    /// <summary>
    /// The public attribute.
    /// </summary>
    public TerraformExpression Public => this["public"];

    /// <summary>
    /// The root_snapshot_id attribute.
    /// </summary>
    public TerraformExpression RootSnapshotId => this["root_snapshot_id"];

    /// <summary>
    /// The usage_operation attribute.
    /// </summary>
    public TerraformExpression UsageOperation => this["usage_operation"];

}
