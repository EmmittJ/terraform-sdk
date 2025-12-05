using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for preserved_state in GoogleComputeRegionPerInstanceConfig.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionPerInstanceConfigPreservedStateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "preserved_state";

    /// <summary>
    /// Preserved metadata defined for this instance. This is a list of key-&amp;gt;value pairs.
    /// </summary>
    public TerraformMap<string>? Metadata
    {
        get => GetArgument<TerraformMap<string>>("metadata");
        set => SetArgument("metadata", value);
    }

    /// <summary>
    /// Disk block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleComputeRegionPerInstanceConfigPreservedStateBlockDiskBlock>? Disk
    {
        get => GetArgument<TerraformSet<GoogleComputeRegionPerInstanceConfigPreservedStateBlockDiskBlock>>("disk");
        set => SetArgument("disk", value);
    }

    /// <summary>
    /// ExternalIp block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleComputeRegionPerInstanceConfigPreservedStateBlockExternalIpBlock>? ExternalIp
    {
        get => GetArgument<TerraformSet<GoogleComputeRegionPerInstanceConfigPreservedStateBlockExternalIpBlock>>("external_ip");
        set => SetArgument("external_ip", value);
    }

    /// <summary>
    /// InternalIp block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleComputeRegionPerInstanceConfigPreservedStateBlockInternalIpBlock>? InternalIp
    {
        get => GetArgument<TerraformSet<GoogleComputeRegionPerInstanceConfigPreservedStateBlockInternalIpBlock>>("internal_ip");
        set => SetArgument("internal_ip", value);
    }

}

/// <summary>
/// Block type for disk in GoogleComputeRegionPerInstanceConfigPreservedStateBlock.
/// Nesting mode: set
/// </summary>
public class GoogleComputeRegionPerInstanceConfigPreservedStateBlockDiskBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "disk";

    /// <summary>
    /// A value that prescribes what should happen to the stateful disk when the VM instance is deleted.
    /// The available options are &#39;NEVER&#39; and &#39;ON_PERMANENT_INSTANCE_DELETION&#39;.
    /// &#39;NEVER&#39; - detach the disk when the VM is deleted, but do not delete the disk.
    /// &#39;ON_PERMANENT_INSTANCE_DELETION&#39; will delete the stateful disk when the VM is permanently
    /// deleted from the instance group. Default value: &amp;quot;NEVER&amp;quot; Possible values: [&amp;quot;NEVER&amp;quot;, &amp;quot;ON_PERMANENT_INSTANCE_DELETION&amp;quot;]
    /// </summary>
    public TerraformValue<string>? DeleteRule
    {
        get => GetArgument<TerraformValue<string>>("delete_rule");
        set => SetArgument("delete_rule", value);
    }

    /// <summary>
    /// A unique device name that is reflected into the /dev/ tree of a Linux operating system running within the instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeviceName is required")]
    public required TerraformValue<string> DeviceName
    {
        get => GetRequiredArgument<TerraformValue<string>>("device_name");
        set => SetArgument("device_name", value);
    }

    /// <summary>
    /// The mode of the disk. Default value: &amp;quot;READ_WRITE&amp;quot; Possible values: [&amp;quot;READ_ONLY&amp;quot;, &amp;quot;READ_WRITE&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Mode
    {
        get => GetArgument<TerraformValue<string>>("mode");
        set => SetArgument("mode", value);
    }

    /// <summary>
    /// The URI of an existing persistent disk to attach under the specified device-name in the format
    /// &#39;projects/project-id/zones/zone/disks/disk-name&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    public required TerraformValue<string> Source
    {
        get => GetRequiredArgument<TerraformValue<string>>("source");
        set => SetArgument("source", value);
    }

}

/// <summary>
/// Block type for external_ip in GoogleComputeRegionPerInstanceConfigPreservedStateBlock.
/// Nesting mode: set
/// </summary>
public class GoogleComputeRegionPerInstanceConfigPreservedStateBlockExternalIpBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "external_ip";

    /// <summary>
    /// These stateful IPs will never be released during autohealing, update or VM instance recreate operations. This flag is used to configure if the IP reservation should be deleted after it is no longer used by the group, e.g. when the given instance or the whole group is deleted. Default value: &amp;quot;NEVER&amp;quot; Possible values: [&amp;quot;NEVER&amp;quot;, &amp;quot;ON_PERMANENT_INSTANCE_DELETION&amp;quot;]
    /// </summary>
    public TerraformValue<string>? AutoDelete
    {
        get => GetArgument<TerraformValue<string>>("auto_delete");
        set => SetArgument("auto_delete", value);
    }

    /// <summary>
    /// The interface_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InterfaceName is required")]
    public required TerraformValue<string> InterfaceName
    {
        get => GetRequiredArgument<TerraformValue<string>>("interface_name");
        set => SetArgument("interface_name", value);
    }

    /// <summary>
    /// IpAddress block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IpAddress block(s) allowed")]
    public TerraformList<GoogleComputeRegionPerInstanceConfigPreservedStateBlockExternalIpBlockIpAddressBlock>? IpAddress
    {
        get => GetArgument<TerraformList<GoogleComputeRegionPerInstanceConfigPreservedStateBlockExternalIpBlockIpAddressBlock>>("ip_address");
        set => SetArgument("ip_address", value);
    }

}

/// <summary>
/// Block type for ip_address in GoogleComputeRegionPerInstanceConfigPreservedStateBlockExternalIpBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionPerInstanceConfigPreservedStateBlockExternalIpBlockIpAddressBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ip_address";

    /// <summary>
    /// The URL of the reservation for this IP address.
    /// </summary>
    public TerraformValue<string>? Address
    {
        get => GetArgument<TerraformValue<string>>("address");
        set => SetArgument("address", value);
    }

}

/// <summary>
/// Block type for internal_ip in GoogleComputeRegionPerInstanceConfigPreservedStateBlock.
/// Nesting mode: set
/// </summary>
public class GoogleComputeRegionPerInstanceConfigPreservedStateBlockInternalIpBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "internal_ip";

    /// <summary>
    /// These stateful IPs will never be released during autohealing, update or VM instance recreate operations. This flag is used to configure if the IP reservation should be deleted after it is no longer used by the group, e.g. when the given instance or the whole group is deleted. Default value: &amp;quot;NEVER&amp;quot; Possible values: [&amp;quot;NEVER&amp;quot;, &amp;quot;ON_PERMANENT_INSTANCE_DELETION&amp;quot;]
    /// </summary>
    public TerraformValue<string>? AutoDelete
    {
        get => GetArgument<TerraformValue<string>>("auto_delete");
        set => SetArgument("auto_delete", value);
    }

    /// <summary>
    /// The interface_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InterfaceName is required")]
    public required TerraformValue<string> InterfaceName
    {
        get => GetRequiredArgument<TerraformValue<string>>("interface_name");
        set => SetArgument("interface_name", value);
    }

    /// <summary>
    /// IpAddress block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IpAddress block(s) allowed")]
    public TerraformList<GoogleComputeRegionPerInstanceConfigPreservedStateBlockInternalIpBlockIpAddressBlock>? IpAddress
    {
        get => GetArgument<TerraformList<GoogleComputeRegionPerInstanceConfigPreservedStateBlockInternalIpBlockIpAddressBlock>>("ip_address");
        set => SetArgument("ip_address", value);
    }

}

/// <summary>
/// Block type for ip_address in GoogleComputeRegionPerInstanceConfigPreservedStateBlockInternalIpBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionPerInstanceConfigPreservedStateBlockInternalIpBlockIpAddressBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ip_address";

    /// <summary>
    /// The URL of the reservation for this IP address.
    /// </summary>
    public TerraformValue<string>? Address
    {
        get => GetArgument<TerraformValue<string>>("address");
        set => SetArgument("address", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleComputeRegionPerInstanceConfig.
/// Nesting mode: single
/// </summary>
public class GoogleComputeRegionPerInstanceConfigTimeoutsBlock : TerraformBlock
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
/// Represents a google_compute_region_per_instance_config Terraform resource.
/// Manages a google_compute_region_per_instance_config resource.
/// </summary>
public partial class GoogleComputeRegionPerInstanceConfig(string name) : TerraformResource("google_compute_region_per_instance_config", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The minimal action to perform on the instance during an update.
    /// Default is &#39;NONE&#39;. Possible values are:
    /// * REPLACE
    /// * RESTART
    /// * REFRESH
    /// * NONE
    /// </summary>
    public TerraformValue<string>? MinimalAction
    {
        get => GetArgument<TerraformValue<string>>("minimal_action");
        set => SetArgument("minimal_action", value);
    }

    /// <summary>
    /// The most disruptive action to perform on the instance during an update.
    /// Default is &#39;REPLACE&#39;. Possible values are:
    /// * REPLACE
    /// * RESTART
    /// * REFRESH
    /// * NONE
    /// </summary>
    public TerraformValue<string>? MostDisruptiveAllowedAction
    {
        get => GetArgument<TerraformValue<string>>("most_disruptive_allowed_action");
        set => SetArgument("most_disruptive_allowed_action", value);
    }

    /// <summary>
    /// The name for this per-instance config and its corresponding instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? CreateReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Region where the containing instance group manager is located
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The region instance group manager this instance config is part of.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RegionInstanceGroupManager is required")]
    public required TerraformValue<string> RegionInstanceGroupManager
    {
        get => GetRequiredArgument<TerraformValue<string>>("region_instance_group_manager");
        set => SetArgument("region_instance_group_manager", value);
    }

    /// <summary>
    /// When true, deleting this config will immediately remove the underlying instance.
    /// When false, deleting this config will use the behavior as determined by remove_instance_on_destroy.
    /// </summary>
    public TerraformValue<bool>? RemoveInstanceOnDestroy
    {
        get => GetArgument<TerraformValue<bool>>("remove_instance_on_destroy");
        set => SetArgument("remove_instance_on_destroy", value);
    }

    /// <summary>
    /// When true, deleting this config will immediately remove any specified state from the underlying instance.
    /// When false, deleting this config will *not* immediately remove any state from the underlying instance.
    /// State will be removed on the next instance recreation or update.
    /// </summary>
    public TerraformValue<bool>? RemoveInstanceStateOnDestroy
    {
        get => GetArgument<TerraformValue<bool>>("remove_instance_state_on_destroy");
        set => SetArgument("remove_instance_state_on_destroy", value);
    }

    /// <summary>
    /// PreservedState block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PreservedState block(s) allowed")]
    public TerraformList<GoogleComputeRegionPerInstanceConfigPreservedStateBlock>? PreservedState
    {
        get => GetArgument<TerraformList<GoogleComputeRegionPerInstanceConfigPreservedStateBlock>>("preserved_state");
        set => SetArgument("preserved_state", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleComputeRegionPerInstanceConfigTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleComputeRegionPerInstanceConfigTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
