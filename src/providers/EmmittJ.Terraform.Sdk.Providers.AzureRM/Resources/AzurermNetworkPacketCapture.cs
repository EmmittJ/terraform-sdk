using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for filter in .
/// Nesting mode: list
/// </summary>
public class AzurermNetworkPacketCaptureFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filter";

    /// <summary>
    /// The local_ip_address attribute.
    /// </summary>
    public TerraformValue<string>? LocalIpAddress
    {
        get => new TerraformReference<string>(this, "local_ip_address");
        set => SetArgument("local_ip_address", value);
    }

    /// <summary>
    /// The local_port attribute.
    /// </summary>
    public TerraformValue<string>? LocalPort
    {
        get => new TerraformReference<string>(this, "local_port");
        set => SetArgument("local_port", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformValue<string> Protocol
    {
        get => new TerraformReference<string>(this, "protocol");
        set => SetArgument("protocol", value);
    }

    /// <summary>
    /// The remote_ip_address attribute.
    /// </summary>
    public TerraformValue<string>? RemoteIpAddress
    {
        get => new TerraformReference<string>(this, "remote_ip_address");
        set => SetArgument("remote_ip_address", value);
    }

    /// <summary>
    /// The remote_port attribute.
    /// </summary>
    public TerraformValue<string>? RemotePort
    {
        get => new TerraformReference<string>(this, "remote_port");
        set => SetArgument("remote_port", value);
    }

}

/// <summary>
/// Block type for storage_location in .
/// Nesting mode: list
/// </summary>
public class AzurermNetworkPacketCaptureStorageLocationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "storage_location";

    /// <summary>
    /// The file_path attribute.
    /// </summary>
    public TerraformValue<string>? FilePath
    {
        get => new TerraformReference<string>(this, "file_path");
        set => SetArgument("file_path", value);
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    public TerraformValue<string>? StorageAccountId
    {
        get => new TerraformReference<string>(this, "storage_account_id");
        set => SetArgument("storage_account_id", value);
    }

    /// <summary>
    /// The storage_path attribute.
    /// </summary>
    public TerraformValue<string> StoragePath
    {
        get => new TerraformReference<string>(this, "storage_path");
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermNetworkPacketCaptureTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

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
/// Represents a azurerm_network_packet_capture Terraform resource.
/// Manages a azurerm_network_packet_capture resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public partial class AzurermNetworkPacketCapture(string name) : TerraformResource("azurerm_network_packet_capture", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The maximum_bytes_per_packet attribute.
    /// </summary>
    public TerraformValue<double>? MaximumBytesPerPacket
    {
        get => new TerraformReference<double>(this, "maximum_bytes_per_packet");
        set => SetArgument("maximum_bytes_per_packet", value);
    }

    /// <summary>
    /// The maximum_bytes_per_session attribute.
    /// </summary>
    public TerraformValue<double>? MaximumBytesPerSession
    {
        get => new TerraformReference<double>(this, "maximum_bytes_per_session");
        set => SetArgument("maximum_bytes_per_session", value);
    }

    /// <summary>
    /// The maximum_capture_duration attribute.
    /// </summary>
    public TerraformValue<double>? MaximumCaptureDuration
    {
        get => new TerraformReference<double>(this, "maximum_capture_duration");
        set => SetArgument("maximum_capture_duration", value);
    }

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
    /// The network_watcher_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkWatcherName is required")]
    public required TerraformValue<string> NetworkWatcherName
    {
        get => new TerraformReference<string>(this, "network_watcher_name");
        set => SetArgument("network_watcher_name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The target_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetResourceId is required")]
    public required TerraformValue<string> TargetResourceId
    {
        get => new TerraformReference<string>(this, "target_resource_id");
        set => SetArgument("target_resource_id", value);
    }

    /// <summary>
    /// Filter block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermNetworkPacketCaptureFilterBlock>? Filter
    {
        get => GetArgument<TerraformList<AzurermNetworkPacketCaptureFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

    /// <summary>
    /// StorageLocation block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageLocation is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 StorageLocation block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageLocation block(s) allowed")]
    public required TerraformList<AzurermNetworkPacketCaptureStorageLocationBlock> StorageLocation
    {
        get => GetRequiredArgument<TerraformList<AzurermNetworkPacketCaptureStorageLocationBlock>>("storage_location");
        set => SetArgument("storage_location", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermNetworkPacketCaptureTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermNetworkPacketCaptureTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
