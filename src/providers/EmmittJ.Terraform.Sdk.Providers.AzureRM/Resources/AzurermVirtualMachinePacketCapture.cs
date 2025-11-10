using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for filter in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualMachinePacketCaptureFilterBlock : TerraformBlock
{
    /// <summary>
    /// The local_ip_address attribute.
    /// </summary>
    public TerraformProperty<string>? LocalIpAddress
    {
        set => SetProperty("local_ip_address", value);
    }

    /// <summary>
    /// The local_port attribute.
    /// </summary>
    public TerraformProperty<string>? LocalPort
    {
        set => SetProperty("local_port", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformProperty<string> Protocol
    {
        set => SetProperty("protocol", value);
    }

    /// <summary>
    /// The remote_ip_address attribute.
    /// </summary>
    public TerraformProperty<string>? RemoteIpAddress
    {
        set => SetProperty("remote_ip_address", value);
    }

    /// <summary>
    /// The remote_port attribute.
    /// </summary>
    public TerraformProperty<string>? RemotePort
    {
        set => SetProperty("remote_port", value);
    }

}

/// <summary>
/// Block type for storage_location in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualMachinePacketCaptureStorageLocationBlock : TerraformBlock
{
    /// <summary>
    /// The file_path attribute.
    /// </summary>
    public TerraformProperty<string>? FilePath
    {
        set => SetProperty("file_path", value);
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    public TerraformProperty<string>? StorageAccountId
    {
        set => SetProperty("storage_account_id", value);
    }

    /// <summary>
    /// The storage_path attribute.
    /// </summary>
    public TerraformProperty<string>? StoragePath
    {
        set => SetProperty("storage_path", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermVirtualMachinePacketCaptureTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

/// <summary>
/// Manages a azurerm_virtual_machine_packet_capture resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermVirtualMachinePacketCapture : TerraformResource
{
    public AzurermVirtualMachinePacketCapture(string name) : base("azurerm_virtual_machine_packet_capture", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("id");
        SetOutput("maximum_bytes_per_packet");
        SetOutput("maximum_bytes_per_session");
        SetOutput("maximum_capture_duration_in_seconds");
        SetOutput("name");
        SetOutput("network_watcher_id");
        SetOutput("virtual_machine_id");
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
    /// The maximum_bytes_per_packet attribute.
    /// </summary>
    public TerraformProperty<double> MaximumBytesPerPacket
    {
        get => GetRequiredOutput<TerraformProperty<double>>("maximum_bytes_per_packet");
        set => SetProperty("maximum_bytes_per_packet", value);
    }

    /// <summary>
    /// The maximum_bytes_per_session attribute.
    /// </summary>
    public TerraformProperty<double> MaximumBytesPerSession
    {
        get => GetRequiredOutput<TerraformProperty<double>>("maximum_bytes_per_session");
        set => SetProperty("maximum_bytes_per_session", value);
    }

    /// <summary>
    /// The maximum_capture_duration_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double> MaximumCaptureDurationInSeconds
    {
        get => GetRequiredOutput<TerraformProperty<double>>("maximum_capture_duration_in_seconds");
        set => SetProperty("maximum_capture_duration_in_seconds", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The network_watcher_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkWatcherId is required")]
    public required TerraformProperty<string> NetworkWatcherId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("network_watcher_id");
        set => SetProperty("network_watcher_id", value);
    }

    /// <summary>
    /// The virtual_machine_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualMachineId is required")]
    public required TerraformProperty<string> VirtualMachineId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("virtual_machine_id");
        set => SetProperty("virtual_machine_id", value);
    }

    /// <summary>
    /// Block for filter.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermVirtualMachinePacketCaptureFilterBlock>? Filter
    {
        set => SetProperty("filter", value);
    }

    /// <summary>
    /// Block for storage_location.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageLocation is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 StorageLocation block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageLocation block(s) allowed")]
    public List<AzurermVirtualMachinePacketCaptureStorageLocationBlock>? StorageLocation
    {
        set => SetProperty("storage_location", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermVirtualMachinePacketCaptureTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
