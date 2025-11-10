using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsAmiDataSourceFilterBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    public HashSet<TerraformProperty<string>>? Values
    {
        set => SetProperty("values", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsAmiDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

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
        SetOutput("architecture");
        SetOutput("arn");
        SetOutput("block_device_mappings");
        SetOutput("boot_mode");
        SetOutput("creation_date");
        SetOutput("deprecation_time");
        SetOutput("description");
        SetOutput("ena_support");
        SetOutput("hypervisor");
        SetOutput("image_id");
        SetOutput("image_location");
        SetOutput("image_owner_alias");
        SetOutput("image_type");
        SetOutput("imds_support");
        SetOutput("kernel_id");
        SetOutput("last_launched_time");
        SetOutput("name");
        SetOutput("owner_id");
        SetOutput("platform");
        SetOutput("platform_details");
        SetOutput("product_codes");
        SetOutput("public");
        SetOutput("ramdisk_id");
        SetOutput("root_device_name");
        SetOutput("root_device_type");
        SetOutput("root_snapshot_id");
        SetOutput("sriov_net_support");
        SetOutput("state");
        SetOutput("state_reason");
        SetOutput("tpm_support");
        SetOutput("usage_operation");
        SetOutput("virtualization_type");
        SetOutput("allow_unsafe_filter");
        SetOutput("executable_users");
        SetOutput("id");
        SetOutput("include_deprecated");
        SetOutput("most_recent");
        SetOutput("name_regex");
        SetOutput("owners");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("uefi_data");
    }

    /// <summary>
    /// The allow_unsafe_filter attribute.
    /// </summary>
    public TerraformProperty<bool> AllowUnsafeFilter
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("allow_unsafe_filter");
        set => SetProperty("allow_unsafe_filter", value);
    }

    /// <summary>
    /// The executable_users attribute.
    /// </summary>
    public List<TerraformProperty<string>> ExecutableUsers
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("executable_users");
        set => SetProperty("executable_users", value);
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
    /// The include_deprecated attribute.
    /// </summary>
    public TerraformProperty<bool> IncludeDeprecated
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("include_deprecated");
        set => SetProperty("include_deprecated", value);
    }

    /// <summary>
    /// The most_recent attribute.
    /// </summary>
    public TerraformProperty<bool> MostRecent
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("most_recent");
        set => SetProperty("most_recent", value);
    }

    /// <summary>
    /// The name_regex attribute.
    /// </summary>
    public TerraformProperty<string> NameRegex
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name_regex");
        set => SetProperty("name_regex", value);
    }

    /// <summary>
    /// The owners attribute.
    /// </summary>
    public List<TerraformProperty<string>> Owners
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("owners");
        set => SetProperty("owners", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
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
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsAmiDataSourceFilterBlock>? Filter
    {
        set => SetProperty("filter", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsAmiDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
