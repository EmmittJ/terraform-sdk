using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for filter in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualMachineScaleSetPacketCaptureFilterBlock : TerraformBlock
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
/// Block type for machine_scope in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualMachineScaleSetPacketCaptureMachineScopeBlock : TerraformBlock
{
    /// <summary>
    /// The exclude_instance_ids attribute.
    /// </summary>
    public List<TerraformProperty<string>>? ExcludeInstanceIds
    {
        get => GetProperty<List<TerraformProperty<string>>>("exclude_instance_ids");
        set => WithProperty("exclude_instance_ids", value);
    }

    /// <summary>
    /// The include_instance_ids attribute.
    /// </summary>
    public List<TerraformProperty<string>>? IncludeInstanceIds
    {
        get => GetProperty<List<TerraformProperty<string>>>("include_instance_ids");
        set => WithProperty("include_instance_ids", value);
    }

}

/// <summary>
/// Block type for storage_location in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualMachineScaleSetPacketCaptureStorageLocationBlock : TerraformBlock
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
public class AzurermVirtualMachineScaleSetPacketCaptureTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_virtual_machine_scale_set_packet_capture resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermVirtualMachineScaleSetPacketCapture : TerraformResource
{
    public AzurermVirtualMachineScaleSetPacketCapture(string name) : base("azurerm_virtual_machine_scale_set_packet_capture", name)
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
    /// The maximum_capture_duration_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? MaximumCaptureDurationInSeconds
    {
        get => GetProperty<TerraformProperty<double>>("maximum_capture_duration_in_seconds");
        set => this.WithProperty("maximum_capture_duration_in_seconds", value);
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
    /// The network_watcher_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkWatcherId is required")]
    public required TerraformProperty<string> NetworkWatcherId
    {
        get => GetProperty<TerraformProperty<string>>("network_watcher_id");
        set => this.WithProperty("network_watcher_id", value);
    }

    /// <summary>
    /// The virtual_machine_scale_set_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualMachineScaleSetId is required")]
    public required TerraformProperty<string> VirtualMachineScaleSetId
    {
        get => GetProperty<TerraformProperty<string>>("virtual_machine_scale_set_id");
        set => this.WithProperty("virtual_machine_scale_set_id", value);
    }

    /// <summary>
    /// Block for filter.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermVirtualMachineScaleSetPacketCaptureFilterBlock>? Filter
    {
        get => GetProperty<List<AzurermVirtualMachineScaleSetPacketCaptureFilterBlock>>("filter");
        set => this.WithProperty("filter", value);
    }

    /// <summary>
    /// Block for machine_scope.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MachineScope block(s) allowed")]
    public List<AzurermVirtualMachineScaleSetPacketCaptureMachineScopeBlock>? MachineScope
    {
        get => GetProperty<List<AzurermVirtualMachineScaleSetPacketCaptureMachineScopeBlock>>("machine_scope");
        set => this.WithProperty("machine_scope", value);
    }

    /// <summary>
    /// Block for storage_location.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 StorageLocation block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageLocation block(s) allowed")]
    public List<AzurermVirtualMachineScaleSetPacketCaptureStorageLocationBlock>? StorageLocation
    {
        get => GetProperty<List<AzurermVirtualMachineScaleSetPacketCaptureStorageLocationBlock>>("storage_location");
        set => this.WithProperty("storage_location", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermVirtualMachineScaleSetPacketCaptureTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermVirtualMachineScaleSetPacketCaptureTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
