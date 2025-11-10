using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for filter in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualMachinePacketCaptureFilterBlock : ITerraformBlock
{
    /// <summary>
    /// The local_ip_address attribute.
    /// </summary>
    [TerraformPropertyName("local_ip_address")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? LocalIpAddress { get; set; }

    /// <summary>
    /// The local_port attribute.
    /// </summary>
    [TerraformPropertyName("local_port")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? LocalPort { get; set; }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    [TerraformPropertyName("protocol")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Protocol { get; set; }

    /// <summary>
    /// The remote_ip_address attribute.
    /// </summary>
    [TerraformPropertyName("remote_ip_address")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RemoteIpAddress { get; set; }

    /// <summary>
    /// The remote_port attribute.
    /// </summary>
    [TerraformPropertyName("remote_port")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RemotePort { get; set; }

}

/// <summary>
/// Block type for storage_location in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualMachinePacketCaptureStorageLocationBlock : ITerraformBlock
{
    /// <summary>
    /// The file_path attribute.
    /// </summary>
    [TerraformPropertyName("file_path")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? FilePath { get; set; }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [TerraformPropertyName("storage_account_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? StorageAccountId { get; set; }

    /// <summary>
    /// The storage_path attribute.
    /// </summary>
    [TerraformPropertyName("storage_path")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StoragePath => new TerraformReferenceProperty<TerraformProperty<string>>("", "storage_path");

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermVirtualMachinePacketCaptureTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Manages a azurerm_virtual_machine_packet_capture resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermVirtualMachinePacketCapture : TerraformResource
{
    public AzurermVirtualMachinePacketCapture(string name) : base("azurerm_virtual_machine_packet_capture", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The maximum_bytes_per_packet attribute.
    /// </summary>
    [TerraformPropertyName("maximum_bytes_per_packet")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MaximumBytesPerPacket { get; set; }

    /// <summary>
    /// The maximum_bytes_per_session attribute.
    /// </summary>
    [TerraformPropertyName("maximum_bytes_per_session")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MaximumBytesPerSession { get; set; }

    /// <summary>
    /// The maximum_capture_duration_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("maximum_capture_duration_in_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MaximumCaptureDurationInSeconds { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The network_watcher_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkWatcherId is required")]
    [TerraformPropertyName("network_watcher_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> NetworkWatcherId { get; set; }

    /// <summary>
    /// The virtual_machine_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualMachineId is required")]
    [TerraformPropertyName("virtual_machine_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> VirtualMachineId { get; set; }

    /// <summary>
    /// Block for filter.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("filter")]
    public TerraformList<TerraformBlock<AzurermVirtualMachinePacketCaptureFilterBlock>>? Filter { get; set; } = new();

    /// <summary>
    /// Block for storage_location.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageLocation is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 StorageLocation block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageLocation block(s) allowed")]
    [TerraformPropertyName("storage_location")]
    public TerraformList<TerraformBlock<AzurermVirtualMachinePacketCaptureStorageLocationBlock>>? StorageLocation { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermVirtualMachinePacketCaptureTimeoutsBlock>? Timeouts { get; set; } = new();

}
