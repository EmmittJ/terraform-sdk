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
    public string? Architecture
    {
        get => GetProperty<TerraformLiteralProperty<string>>("architecture")?.Value;
        set => this.WithProperty("architecture", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The boot_mode attribute.
    /// </summary>
    public string? BootMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("boot_mode")?.Value;
        set => this.WithProperty("boot_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The deprecation_time attribute.
    /// </summary>
    public string? DeprecationTime
    {
        get => GetProperty<TerraformLiteralProperty<string>>("deprecation_time")?.Value;
        set => this.WithProperty("deprecation_time", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ena_support attribute.
    /// </summary>
    public bool? EnaSupport
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("ena_support")?.Value;
        set => this.WithProperty("ena_support", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The image_location attribute.
    /// </summary>
    public string? ImageLocation
    {
        get => GetProperty<TerraformLiteralProperty<string>>("image_location")?.Value;
        set => this.WithProperty("image_location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The imds_support attribute.
    /// </summary>
    public string? ImdsSupport
    {
        get => GetProperty<TerraformLiteralProperty<string>>("imds_support")?.Value;
        set => this.WithProperty("imds_support", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The kernel_id attribute.
    /// </summary>
    public string? KernelId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kernel_id")?.Value;
        set => this.WithProperty("kernel_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ramdisk_id attribute.
    /// </summary>
    public string? RamdiskId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ramdisk_id")?.Value;
        set => this.WithProperty("ramdisk_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The root_device_name attribute.
    /// </summary>
    public string? RootDeviceName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("root_device_name")?.Value;
        set => this.WithProperty("root_device_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The sriov_net_support attribute.
    /// </summary>
    public string? SriovNetSupport
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sriov_net_support")?.Value;
        set => this.WithProperty("sriov_net_support", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tpm_support attribute.
    /// </summary>
    public string? TpmSupport
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tpm_support")?.Value;
        set => this.WithProperty("tpm_support", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The uefi_data attribute.
    /// </summary>
    public string? UefiData
    {
        get => GetProperty<TerraformLiteralProperty<string>>("uefi_data")?.Value;
        set => this.WithProperty("uefi_data", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The virtualization_type attribute.
    /// </summary>
    public string? VirtualizationType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("virtualization_type")?.Value;
        set => this.WithProperty("virtualization_type", value == null ? null : new TerraformLiteralProperty<string>(value));
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
