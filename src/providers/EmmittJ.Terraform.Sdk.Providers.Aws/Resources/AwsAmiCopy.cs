using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for ebs_block_device in .
/// Nesting mode: set
/// </summary>
public class AwsAmiCopyEbsBlockDeviceBlock : TerraformBlock
{
    /// <summary>
    /// The delete_on_termination attribute.
    /// </summary>
    public TerraformProperty<bool>? DeleteOnTermination
    {
        get => GetProperty<TerraformProperty<bool>>("delete_on_termination");
        set => WithProperty("delete_on_termination", value);
    }

    /// <summary>
    /// The device_name attribute.
    /// </summary>
    public TerraformProperty<string>? DeviceName
    {
        get => GetProperty<TerraformProperty<string>>("device_name");
        set => WithProperty("device_name", value);
    }

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    public TerraformProperty<bool>? Encrypted
    {
        get => GetProperty<TerraformProperty<bool>>("encrypted");
        set => WithProperty("encrypted", value);
    }

    /// <summary>
    /// The iops attribute.
    /// </summary>
    public TerraformProperty<double>? Iops
    {
        get => GetProperty<TerraformProperty<double>>("iops");
        set => WithProperty("iops", value);
    }

    /// <summary>
    /// The outpost_arn attribute.
    /// </summary>
    public TerraformProperty<string>? OutpostArn
    {
        get => GetProperty<TerraformProperty<string>>("outpost_arn");
        set => WithProperty("outpost_arn", value);
    }

    /// <summary>
    /// The snapshot_id attribute.
    /// </summary>
    public TerraformProperty<string>? SnapshotId
    {
        get => GetProperty<TerraformProperty<string>>("snapshot_id");
        set => WithProperty("snapshot_id", value);
    }

    /// <summary>
    /// The throughput attribute.
    /// </summary>
    public TerraformProperty<double>? Throughput
    {
        get => GetProperty<TerraformProperty<double>>("throughput");
        set => WithProperty("throughput", value);
    }

    /// <summary>
    /// The volume_size attribute.
    /// </summary>
    public TerraformProperty<double>? VolumeSize
    {
        get => GetProperty<TerraformProperty<double>>("volume_size");
        set => WithProperty("volume_size", value);
    }

    /// <summary>
    /// The volume_type attribute.
    /// </summary>
    public TerraformProperty<string>? VolumeType
    {
        get => GetProperty<TerraformProperty<string>>("volume_type");
        set => WithProperty("volume_type", value);
    }

}

/// <summary>
/// Block type for ephemeral_block_device in .
/// Nesting mode: set
/// </summary>
public class AwsAmiCopyEphemeralBlockDeviceBlock : TerraformBlock
{
    /// <summary>
    /// The device_name attribute.
    /// </summary>
    public TerraformProperty<string>? DeviceName
    {
        get => GetProperty<TerraformProperty<string>>("device_name");
        set => WithProperty("device_name", value);
    }

    /// <summary>
    /// The virtual_name attribute.
    /// </summary>
    public TerraformProperty<string>? VirtualName
    {
        get => GetProperty<TerraformProperty<string>>("virtual_name");
        set => WithProperty("virtual_name", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsAmiCopyTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_ami_copy resource.
/// </summary>
public class AwsAmiCopy : TerraformResource
{
    public AwsAmiCopy(string name) : base("aws_ami_copy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("architecture");
        this.WithOutput("arn");
        this.WithOutput("boot_mode");
        this.WithOutput("ena_support");
        this.WithOutput("hypervisor");
        this.WithOutput("image_location");
        this.WithOutput("image_owner_alias");
        this.WithOutput("image_type");
        this.WithOutput("imds_support");
        this.WithOutput("kernel_id");
        this.WithOutput("last_launched_time");
        this.WithOutput("manage_ebs_snapshots");
        this.WithOutput("owner_id");
        this.WithOutput("platform");
        this.WithOutput("platform_details");
        this.WithOutput("public");
        this.WithOutput("ramdisk_id");
        this.WithOutput("root_device_name");
        this.WithOutput("root_snapshot_id");
        this.WithOutput("sriov_net_support");
        this.WithOutput("tpm_support");
        this.WithOutput("uefi_data");
        this.WithOutput("usage_operation");
        this.WithOutput("virtualization_type");
    }

    /// <summary>
    /// The deprecation_time attribute.
    /// </summary>
    public TerraformProperty<string>? DeprecationTime
    {
        get => GetProperty<TerraformProperty<string>>("deprecation_time");
        set => this.WithProperty("deprecation_time", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The destination_outpost_arn attribute.
    /// </summary>
    public TerraformProperty<string>? DestinationOutpostArn
    {
        get => GetProperty<TerraformProperty<string>>("destination_outpost_arn");
        set => this.WithProperty("destination_outpost_arn", value);
    }

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    public TerraformProperty<bool>? Encrypted
    {
        get => GetProperty<TerraformProperty<bool>>("encrypted");
        set => this.WithProperty("encrypted", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyId
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_id");
        set => this.WithProperty("kms_key_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The source_ami_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceAmiId is required")]
    public required TerraformProperty<string> SourceAmiId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("source_ami_id");
        set => this.WithProperty("source_ami_id", value);
    }

    /// <summary>
    /// The source_ami_region attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceAmiRegion is required")]
    public required TerraformProperty<string> SourceAmiRegion
    {
        get => GetRequiredProperty<TerraformProperty<string>>("source_ami_region");
        set => this.WithProperty("source_ami_region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// Block for ebs_block_device.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsAmiCopyEbsBlockDeviceBlock>? EbsBlockDevice
    {
        get => GetProperty<HashSet<AwsAmiCopyEbsBlockDeviceBlock>>("ebs_block_device");
        set => this.WithProperty("ebs_block_device", value);
    }

    /// <summary>
    /// Block for ephemeral_block_device.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsAmiCopyEphemeralBlockDeviceBlock>? EphemeralBlockDevice
    {
        get => GetProperty<HashSet<AwsAmiCopyEphemeralBlockDeviceBlock>>("ephemeral_block_device");
        set => this.WithProperty("ephemeral_block_device", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsAmiCopyTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsAmiCopyTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The architecture attribute.
    /// </summary>
    public TerraformExpression Architecture => this["architecture"];

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The boot_mode attribute.
    /// </summary>
    public TerraformExpression BootMode => this["boot_mode"];

    /// <summary>
    /// The ena_support attribute.
    /// </summary>
    public TerraformExpression EnaSupport => this["ena_support"];

    /// <summary>
    /// The hypervisor attribute.
    /// </summary>
    public TerraformExpression Hypervisor => this["hypervisor"];

    /// <summary>
    /// The image_location attribute.
    /// </summary>
    public TerraformExpression ImageLocation => this["image_location"];

    /// <summary>
    /// The image_owner_alias attribute.
    /// </summary>
    public TerraformExpression ImageOwnerAlias => this["image_owner_alias"];

    /// <summary>
    /// The image_type attribute.
    /// </summary>
    public TerraformExpression ImageType => this["image_type"];

    /// <summary>
    /// The imds_support attribute.
    /// </summary>
    public TerraformExpression ImdsSupport => this["imds_support"];

    /// <summary>
    /// The kernel_id attribute.
    /// </summary>
    public TerraformExpression KernelId => this["kernel_id"];

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
    /// The ramdisk_id attribute.
    /// </summary>
    public TerraformExpression RamdiskId => this["ramdisk_id"];

    /// <summary>
    /// The root_device_name attribute.
    /// </summary>
    public TerraformExpression RootDeviceName => this["root_device_name"];

    /// <summary>
    /// The root_snapshot_id attribute.
    /// </summary>
    public TerraformExpression RootSnapshotId => this["root_snapshot_id"];

    /// <summary>
    /// The sriov_net_support attribute.
    /// </summary>
    public TerraformExpression SriovNetSupport => this["sriov_net_support"];

    /// <summary>
    /// The tpm_support attribute.
    /// </summary>
    public TerraformExpression TpmSupport => this["tpm_support"];

    /// <summary>
    /// The uefi_data attribute.
    /// </summary>
    public TerraformExpression UefiData => this["uefi_data"];

    /// <summary>
    /// The usage_operation attribute.
    /// </summary>
    public TerraformExpression UsageOperation => this["usage_operation"];

    /// <summary>
    /// The virtualization_type attribute.
    /// </summary>
    public TerraformExpression VirtualizationType => this["virtualization_type"];

}
