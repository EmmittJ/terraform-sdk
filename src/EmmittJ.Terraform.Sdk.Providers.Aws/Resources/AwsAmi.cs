using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
        this.DeclareOutput("arn");
        this.DeclareOutput("hypervisor");
        this.DeclareOutput("image_owner_alias");
        this.DeclareOutput("image_type");
        this.DeclareOutput("last_launched_time");
        this.DeclareOutput("manage_ebs_snapshots");
        this.DeclareOutput("owner_id");
        this.DeclareOutput("platform");
        this.DeclareOutput("platform_details");
        this.DeclareOutput("public");
        this.DeclareOutput("root_snapshot_id");
        this.DeclareOutput("usage_operation");
    }

    /// <summary>
    /// The architecture attribute.
    /// </summary>
    public TerraformProperty<string>? Architecture
    {
        get => GetProperty<TerraformProperty<string>>("architecture");
        set => this.WithProperty("architecture", value);
    }

    /// <summary>
    /// The boot_mode attribute.
    /// </summary>
    public TerraformProperty<string>? BootMode
    {
        get => GetProperty<TerraformProperty<string>>("boot_mode");
        set => this.WithProperty("boot_mode", value);
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
    /// The ena_support attribute.
    /// </summary>
    public TerraformProperty<bool>? EnaSupport
    {
        get => GetProperty<TerraformProperty<bool>>("ena_support");
        set => this.WithProperty("ena_support", value);
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
    /// The image_location attribute.
    /// </summary>
    public TerraformProperty<string>? ImageLocation
    {
        get => GetProperty<TerraformProperty<string>>("image_location");
        set => this.WithProperty("image_location", value);
    }

    /// <summary>
    /// The imds_support attribute.
    /// </summary>
    public TerraformProperty<string>? ImdsSupport
    {
        get => GetProperty<TerraformProperty<string>>("imds_support");
        set => this.WithProperty("imds_support", value);
    }

    /// <summary>
    /// The kernel_id attribute.
    /// </summary>
    public TerraformProperty<string>? KernelId
    {
        get => GetProperty<TerraformProperty<string>>("kernel_id");
        set => this.WithProperty("kernel_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The ramdisk_id attribute.
    /// </summary>
    public TerraformProperty<string>? RamdiskId
    {
        get => GetProperty<TerraformProperty<string>>("ramdisk_id");
        set => this.WithProperty("ramdisk_id", value);
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
    /// The root_device_name attribute.
    /// </summary>
    public TerraformProperty<string>? RootDeviceName
    {
        get => GetProperty<TerraformProperty<string>>("root_device_name");
        set => this.WithProperty("root_device_name", value);
    }

    /// <summary>
    /// The sriov_net_support attribute.
    /// </summary>
    public TerraformProperty<string>? SriovNetSupport
    {
        get => GetProperty<TerraformProperty<string>>("sriov_net_support");
        set => this.WithProperty("sriov_net_support", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMapProperty<string>? TagsAll
    {
        get => GetProperty<TerraformMapProperty<string>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The tpm_support attribute.
    /// </summary>
    public TerraformProperty<string>? TpmSupport
    {
        get => GetProperty<TerraformProperty<string>>("tpm_support");
        set => this.WithProperty("tpm_support", value);
    }

    /// <summary>
    /// The uefi_data attribute.
    /// </summary>
    public TerraformProperty<string>? UefiData
    {
        get => GetProperty<TerraformProperty<string>>("uefi_data");
        set => this.WithProperty("uefi_data", value);
    }

    /// <summary>
    /// The virtualization_type attribute.
    /// </summary>
    public TerraformProperty<string>? VirtualizationType
    {
        get => GetProperty<TerraformProperty<string>>("virtualization_type");
        set => this.WithProperty("virtualization_type", value);
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
