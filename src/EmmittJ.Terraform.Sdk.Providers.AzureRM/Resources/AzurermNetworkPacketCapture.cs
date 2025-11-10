using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for filter in .
/// Nesting mode: list
/// </summary>
public class AzurermNetworkPacketCaptureFilterBlock : TerraformBlock
{
    /// <summary>
    /// The local_ip_address attribute.
    /// </summary>
    public TerraformProperty<string>? LocalIpAddress
    {
        get => GetProperty<TerraformProperty<string>>("local_ip_address");
        set => WithProperty("local_ip_address", value);
    }

    /// <summary>
    /// The local_port attribute.
    /// </summary>
    public TerraformProperty<string>? LocalPort
    {
        get => GetProperty<TerraformProperty<string>>("local_port");
        set => WithProperty("local_port", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformProperty<string> Protocol
    {
        get => GetProperty<TerraformProperty<string>>("protocol");
        set => WithProperty("protocol", value);
    }

    /// <summary>
    /// The remote_ip_address attribute.
    /// </summary>
    public TerraformProperty<string>? RemoteIpAddress
    {
        get => GetProperty<TerraformProperty<string>>("remote_ip_address");
        set => WithProperty("remote_ip_address", value);
    }

    /// <summary>
    /// The remote_port attribute.
    /// </summary>
    public TerraformProperty<string>? RemotePort
    {
        get => GetProperty<TerraformProperty<string>>("remote_port");
        set => WithProperty("remote_port", value);
    }

}

/// <summary>
/// Block type for storage_location in .
/// Nesting mode: list
/// </summary>
public class AzurermNetworkPacketCaptureStorageLocationBlock : TerraformBlock
{
    /// <summary>
    /// The file_path attribute.
    /// </summary>
    public TerraformProperty<string>? FilePath
    {
        get => GetProperty<TerraformProperty<string>>("file_path");
        set => WithProperty("file_path", value);
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    public TerraformProperty<string>? StorageAccountId
    {
        get => GetProperty<TerraformProperty<string>>("storage_account_id");
        set => WithProperty("storage_account_id", value);
    }

    /// <summary>
    /// The storage_path attribute.
    /// </summary>
    public TerraformProperty<string>? StoragePath
    {
        get => GetProperty<TerraformProperty<string>>("storage_path");
        set => WithProperty("storage_path", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermNetworkPacketCaptureTimeoutsBlock : TerraformBlock
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
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
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
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The maximum_bytes_per_packet attribute.
    /// </summary>
    public TerraformProperty<double>? MaximumBytesPerPacket
    {
        get => GetProperty<TerraformProperty<double>>("maximum_bytes_per_packet");
        set => this.WithProperty("maximum_bytes_per_packet", value);
    }

    /// <summary>
    /// The maximum_bytes_per_session attribute.
    /// </summary>
    public TerraformProperty<double>? MaximumBytesPerSession
    {
        get => GetProperty<TerraformProperty<double>>("maximum_bytes_per_session");
        set => this.WithProperty("maximum_bytes_per_session", value);
    }

    /// <summary>
    /// The maximum_capture_duration attribute.
    /// </summary>
    public TerraformProperty<double>? MaximumCaptureDuration
    {
        get => GetProperty<TerraformProperty<double>>("maximum_capture_duration");
        set => this.WithProperty("maximum_capture_duration", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The network_watcher_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkWatcherName is required")]
    public required TerraformProperty<string> NetworkWatcherName
    {
        get => GetProperty<TerraformProperty<string>>("network_watcher_name");
        set => this.WithProperty("network_watcher_name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The target_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetResourceId is required")]
    public required TerraformProperty<string> TargetResourceId
    {
        get => GetProperty<TerraformProperty<string>>("target_resource_id");
        set => this.WithProperty("target_resource_id", value);
    }

    /// <summary>
    /// Block for filter.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermNetworkPacketCaptureFilterBlock>? Filter
    {
        get => GetProperty<List<AzurermNetworkPacketCaptureFilterBlock>>("filter");
        set => this.WithProperty("filter", value);
    }

    /// <summary>
    /// Block for storage_location.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 StorageLocation block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageLocation block(s) allowed")]
    public List<AzurermNetworkPacketCaptureStorageLocationBlock>? StorageLocation
    {
        get => GetProperty<List<AzurermNetworkPacketCaptureStorageLocationBlock>>("storage_location");
        set => this.WithProperty("storage_location", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermNetworkPacketCaptureTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermNetworkPacketCaptureTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
