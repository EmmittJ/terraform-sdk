using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ami.
/// </summary>
public class AwsAmiDataSource : TerraformDataSource
{
    public AwsAmiDataSource(string name) : base("aws_ami", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("architecture");
        this.DeclareOutput("arn");
        this.DeclareOutput("block_device_mappings");
        this.DeclareOutput("boot_mode");
        this.DeclareOutput("creation_date");
        this.DeclareOutput("deprecation_time");
        this.DeclareOutput("description");
        this.DeclareOutput("ena_support");
        this.DeclareOutput("hypervisor");
        this.DeclareOutput("image_id");
        this.DeclareOutput("image_location");
        this.DeclareOutput("image_owner_alias");
        this.DeclareOutput("image_type");
        this.DeclareOutput("imds_support");
        this.DeclareOutput("kernel_id");
        this.DeclareOutput("last_launched_time");
        this.DeclareOutput("name");
        this.DeclareOutput("owner_id");
        this.DeclareOutput("platform");
        this.DeclareOutput("platform_details");
        this.DeclareOutput("product_codes");
        this.DeclareOutput("public");
        this.DeclareOutput("ramdisk_id");
        this.DeclareOutput("root_device_name");
        this.DeclareOutput("root_device_type");
        this.DeclareOutput("root_snapshot_id");
        this.DeclareOutput("sriov_net_support");
        this.DeclareOutput("state");
        this.DeclareOutput("state_reason");
        this.DeclareOutput("tpm_support");
        this.DeclareOutput("usage_operation");
        this.DeclareOutput("virtualization_type");
    }

    /// <summary>
    /// The allow_unsafe_filter attribute.
    /// </summary>
    public TerraformProperty<bool>? AllowUnsafeFilter
    {
        get => GetProperty<TerraformProperty<bool>>("allow_unsafe_filter");
        set => this.WithProperty("allow_unsafe_filter", value);
    }

    /// <summary>
    /// The executable_users attribute.
    /// </summary>
    public TerraformProperty<List<string>>? ExecutableUsers
    {
        get => GetProperty<TerraformProperty<List<string>>>("executable_users");
        set => this.WithProperty("executable_users", value);
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
    /// The include_deprecated attribute.
    /// </summary>
    public TerraformProperty<bool>? IncludeDeprecated
    {
        get => GetProperty<TerraformProperty<bool>>("include_deprecated");
        set => this.WithProperty("include_deprecated", value);
    }

    /// <summary>
    /// The most_recent attribute.
    /// </summary>
    public TerraformProperty<bool>? MostRecent
    {
        get => GetProperty<TerraformProperty<bool>>("most_recent");
        set => this.WithProperty("most_recent", value);
    }

    /// <summary>
    /// The name_regex attribute.
    /// </summary>
    public TerraformProperty<string>? NameRegex
    {
        get => GetProperty<TerraformProperty<string>>("name_regex");
        set => this.WithProperty("name_regex", value);
    }

    /// <summary>
    /// The owners attribute.
    /// </summary>
    public TerraformProperty<List<string>>? Owners
    {
        get => GetProperty<TerraformProperty<List<string>>>("owners");
        set => this.WithProperty("owners", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
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
    /// The architecture attribute.
    /// </summary>
    public TerraformExpression Architecture => this["architecture"];

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The block_device_mappings attribute.
    /// </summary>
    public TerraformExpression BlockDeviceMappings => this["block_device_mappings"];

    /// <summary>
    /// The boot_mode attribute.
    /// </summary>
    public TerraformExpression BootMode => this["boot_mode"];

    /// <summary>
    /// The creation_date attribute.
    /// </summary>
    public TerraformExpression CreationDate => this["creation_date"];

    /// <summary>
    /// The deprecation_time attribute.
    /// </summary>
    public TerraformExpression DeprecationTime => this["deprecation_time"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The ena_support attribute.
    /// </summary>
    public TerraformExpression EnaSupport => this["ena_support"];

    /// <summary>
    /// The hypervisor attribute.
    /// </summary>
    public TerraformExpression Hypervisor => this["hypervisor"];

    /// <summary>
    /// The image_id attribute.
    /// </summary>
    public TerraformExpression ImageId => this["image_id"];

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
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

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
    /// The product_codes attribute.
    /// </summary>
    public TerraformExpression ProductCodes => this["product_codes"];

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
    /// The root_device_type attribute.
    /// </summary>
    public TerraformExpression RootDeviceType => this["root_device_type"];

    /// <summary>
    /// The root_snapshot_id attribute.
    /// </summary>
    public TerraformExpression RootSnapshotId => this["root_snapshot_id"];

    /// <summary>
    /// The sriov_net_support attribute.
    /// </summary>
    public TerraformExpression SriovNetSupport => this["sriov_net_support"];

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// The state_reason attribute.
    /// </summary>
    public TerraformExpression StateReason => this["state_reason"];

    /// <summary>
    /// The tpm_support attribute.
    /// </summary>
    public TerraformExpression TpmSupport => this["tpm_support"];

    /// <summary>
    /// The usage_operation attribute.
    /// </summary>
    public TerraformExpression UsageOperation => this["usage_operation"];

    /// <summary>
    /// The virtualization_type attribute.
    /// </summary>
    public TerraformExpression VirtualizationType => this["virtualization_type"];

}
