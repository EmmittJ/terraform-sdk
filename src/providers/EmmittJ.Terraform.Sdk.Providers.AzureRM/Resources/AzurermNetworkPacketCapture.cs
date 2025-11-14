using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

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
    [TerraformArgument("local_ip_address")]
    public TerraformValue<string>? LocalIpAddress
    {
        get => new TerraformReference<string>(this, "local_ip_address");
        set => SetArgument("local_ip_address", value);
    }

    /// <summary>
    /// The local_port attribute.
    /// </summary>
    [TerraformArgument("local_port")]
    public TerraformValue<string>? LocalPort
    {
        get => new TerraformReference<string>(this, "local_port");
        set => SetArgument("local_port", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    [TerraformArgument("protocol")]
    public required TerraformValue<string> Protocol
    {
        get => new TerraformReference<string>(this, "protocol");
        set => SetArgument("protocol", value);
    }

    /// <summary>
    /// The remote_ip_address attribute.
    /// </summary>
    [TerraformArgument("remote_ip_address")]
    public TerraformValue<string>? RemoteIpAddress
    {
        get => new TerraformReference<string>(this, "remote_ip_address");
        set => SetArgument("remote_ip_address", value);
    }

    /// <summary>
    /// The remote_port attribute.
    /// </summary>
    [TerraformArgument("remote_port")]
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
    [TerraformArgument("file_path")]
    public TerraformValue<string>? FilePath
    {
        get => new TerraformReference<string>(this, "file_path");
        set => SetArgument("file_path", value);
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [TerraformArgument("storage_account_id")]
    public TerraformValue<string>? StorageAccountId
    {
        get => new TerraformReference<string>(this, "storage_account_id");
        set => SetArgument("storage_account_id", value);
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
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Manages a azurerm_network_packet_capture resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermNetworkPacketCapture : TerraformResource
{
    public AzurermNetworkPacketCapture(string name) : base("azurerm_network_packet_capture", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The maximum_bytes_per_packet attribute.
    /// </summary>
    [TerraformArgument("maximum_bytes_per_packet")]
    public TerraformValue<double>? MaximumBytesPerPacket
    {
        get => new TerraformReference<double>(this, "maximum_bytes_per_packet");
        set => SetArgument("maximum_bytes_per_packet", value);
    }

    /// <summary>
    /// The maximum_bytes_per_session attribute.
    /// </summary>
    [TerraformArgument("maximum_bytes_per_session")]
    public TerraformValue<double>? MaximumBytesPerSession
    {
        get => new TerraformReference<double>(this, "maximum_bytes_per_session");
        set => SetArgument("maximum_bytes_per_session", value);
    }

    /// <summary>
    /// The maximum_capture_duration attribute.
    /// </summary>
    [TerraformArgument("maximum_capture_duration")]
    public TerraformValue<double>? MaximumCaptureDuration
    {
        get => new TerraformReference<double>(this, "maximum_capture_duration");
        set => SetArgument("maximum_capture_duration", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The network_watcher_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkWatcherName is required")]
    [TerraformArgument("network_watcher_name")]
    public required TerraformValue<string> NetworkWatcherName
    {
        get => new TerraformReference<string>(this, "network_watcher_name");
        set => SetArgument("network_watcher_name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The target_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetResourceId is required")]
    [TerraformArgument("target_resource_id")]
    public required TerraformValue<string> TargetResourceId
    {
        get => new TerraformReference<string>(this, "target_resource_id");
        set => SetArgument("target_resource_id", value);
    }

    /// <summary>
    /// Block for filter.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("filter")]
    public TerraformList<AzurermNetworkPacketCaptureFilterBlock> Filter { get; set; } = new();

    /// <summary>
    /// Block for storage_location.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageLocation is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 StorageLocation block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageLocation block(s) allowed")]
    [TerraformArgument("storage_location")]
    public required TerraformList<AzurermNetworkPacketCaptureStorageLocationBlock> StorageLocation { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermNetworkPacketCaptureTimeoutsBlock Timeouts { get; set; } = new();

}
