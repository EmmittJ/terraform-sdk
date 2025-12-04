using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in AwsAmiDataSource.
/// Nesting mode: set
/// </summary>
public class AwsAmiDataSourceFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filter";

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
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public required TerraformSet<string> ValuesAttribute
    {
        get => GetRequiredArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsAmiDataSource.
/// Nesting mode: single
/// </summary>
public class AwsAmiDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a aws_ami Terraform data source.
/// Retrieves information about a aws_ami.
/// </summary>
public partial class AwsAmiDataSource(string name) : TerraformDataSource("aws_ami", name)
{
    /// <summary>
    /// The allow_unsafe_filter attribute.
    /// </summary>
    public TerraformValue<bool>? AllowUnsafeFilter
    {
        get => GetArgument<TerraformValue<bool>>("allow_unsafe_filter");
        set => SetArgument("allow_unsafe_filter", value);
    }

    /// <summary>
    /// The executable_users attribute.
    /// </summary>
    public TerraformList<string>? ExecutableUsers
    {
        get => GetArgument<TerraformList<string>>("executable_users");
        set => SetArgument("executable_users", value);
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
    /// The include_deprecated attribute.
    /// </summary>
    public TerraformValue<bool>? IncludeDeprecated
    {
        get => GetArgument<TerraformValue<bool>>("include_deprecated");
        set => SetArgument("include_deprecated", value);
    }

    /// <summary>
    /// The most_recent attribute.
    /// </summary>
    public TerraformValue<bool>? MostRecent
    {
        get => GetArgument<TerraformValue<bool>>("most_recent");
        set => SetArgument("most_recent", value);
    }

    /// <summary>
    /// The name_regex attribute.
    /// </summary>
    public TerraformValue<string>? NameRegex
    {
        get => GetArgument<TerraformValue<string>>("name_regex");
        set => SetArgument("name_regex", value);
    }

    /// <summary>
    /// The owners attribute.
    /// </summary>
    public TerraformList<string>? Owners
    {
        get => GetArgument<TerraformList<string>>("owners");
        set => SetArgument("owners", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => GetArgument<TerraformMap<string>>("tags") ?? AsReference("tags");
        set => SetArgument("tags", value);
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
    /// The block_device_mappings attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> BlockDeviceMappings
        => AsReference("block_device_mappings");

    /// <summary>
    /// The boot_mode attribute.
    /// </summary>
    public TerraformValue<string> BootMode
        => AsReference("boot_mode");

    /// <summary>
    /// The creation_date attribute.
    /// </summary>
    public TerraformValue<string> CreationDate
        => AsReference("creation_date");

    /// <summary>
    /// The deprecation_time attribute.
    /// </summary>
    public TerraformValue<string> DeprecationTime
        => AsReference("deprecation_time");

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

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
    /// The image_id attribute.
    /// </summary>
    public TerraformValue<string> ImageId
        => AsReference("image_id");

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
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

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
    /// The product_codes attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> ProductCodes
        => AsReference("product_codes");

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
    /// The root_device_type attribute.
    /// </summary>
    public TerraformValue<string> RootDeviceType
        => AsReference("root_device_type");

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
    /// The state attribute.
    /// </summary>
    public TerraformValue<string> State
        => AsReference("state");

    /// <summary>
    /// The state_reason attribute.
    /// </summary>
    public TerraformMap<string> StateReason
        => AsReference("state_reason");

    /// <summary>
    /// The tpm_support attribute.
    /// </summary>
    public TerraformValue<string> TpmSupport
        => AsReference("tpm_support");

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
    /// Filter block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsAmiDataSourceFilterBlock>? Filter
    {
        get => GetArgument<TerraformSet<AwsAmiDataSourceFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsAmiDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsAmiDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
