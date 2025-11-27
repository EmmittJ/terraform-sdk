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
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public required TerraformSet<string> ValuesAttribute
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "values").ResolveNodes(ctx));
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
        get => new TerraformReference<string>(this, "read");
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
        get => new TerraformReference<bool>(this, "allow_unsafe_filter");
        set => SetArgument("allow_unsafe_filter", value);
    }

    /// <summary>
    /// The executable_users attribute.
    /// </summary>
    public TerraformList<string>? ExecutableUsers
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "executable_users").ResolveNodes(ctx));
        set => SetArgument("executable_users", value);
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
    /// The include_deprecated attribute.
    /// </summary>
    public TerraformValue<bool>? IncludeDeprecated
    {
        get => new TerraformReference<bool>(this, "include_deprecated");
        set => SetArgument("include_deprecated", value);
    }

    /// <summary>
    /// The most_recent attribute.
    /// </summary>
    public TerraformValue<bool>? MostRecent
    {
        get => new TerraformReference<bool>(this, "most_recent");
        set => SetArgument("most_recent", value);
    }

    /// <summary>
    /// The name_regex attribute.
    /// </summary>
    public TerraformValue<string>? NameRegex
    {
        get => new TerraformReference<string>(this, "name_regex");
        set => SetArgument("name_regex", value);
    }

    /// <summary>
    /// The owners attribute.
    /// </summary>
    public TerraformList<string>? Owners
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "owners").ResolveNodes(ctx));
        set => SetArgument("owners", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The uefi_data attribute.
    /// </summary>
    public TerraformValue<string>? UefiData
    {
        get => new TerraformReference<string>(this, "uefi_data");
        set => SetArgument("uefi_data", value);
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
    /// The block_device_mappings attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> BlockDeviceMappings
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "block_device_mappings").ResolveNodes(ctx));
    }

    /// <summary>
    /// The boot_mode attribute.
    /// </summary>
    public TerraformValue<string> BootMode
    {
        get => new TerraformReference<string>(this, "boot_mode");
    }

    /// <summary>
    /// The creation_date attribute.
    /// </summary>
    public TerraformValue<string> CreationDate
    {
        get => new TerraformReference<string>(this, "creation_date");
    }

    /// <summary>
    /// The deprecation_time attribute.
    /// </summary>
    public TerraformValue<string> DeprecationTime
    {
        get => new TerraformReference<string>(this, "deprecation_time");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
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
    /// The image_id attribute.
    /// </summary>
    public TerraformValue<string> ImageId
    {
        get => new TerraformReference<string>(this, "image_id");
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
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
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
    /// The product_codes attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> ProductCodes
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "product_codes").ResolveNodes(ctx));
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
    /// The root_device_type attribute.
    /// </summary>
    public TerraformValue<string> RootDeviceType
    {
        get => new TerraformReference<string>(this, "root_device_type");
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
    /// The state attribute.
    /// </summary>
    public TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
    }

    /// <summary>
    /// The state_reason attribute.
    /// </summary>
    public TerraformMap<string> StateReason
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "state_reason").ResolveNodes(ctx));
    }

    /// <summary>
    /// The tpm_support attribute.
    /// </summary>
    public TerraformValue<string> TpmSupport
    {
        get => new TerraformReference<string>(this, "tpm_support");
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
