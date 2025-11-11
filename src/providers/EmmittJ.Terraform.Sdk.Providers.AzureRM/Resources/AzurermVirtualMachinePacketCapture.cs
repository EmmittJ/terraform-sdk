using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for filter in .
/// Nesting mode: list
/// </summary>
public partial class AzurermVirtualMachinePacketCaptureFilterBlock : TerraformBlockBase
{
    /// <summary>
    /// The local_ip_address attribute.
    /// </summary>
    [TerraformProperty("local_ip_address")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? LocalIpAddress { get; set; }

    /// <summary>
    /// The local_port attribute.
    /// </summary>
    [TerraformProperty("local_port")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? LocalPort { get; set; }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    [TerraformProperty("protocol")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Protocol { get; set; }

    /// <summary>
    /// The remote_ip_address attribute.
    /// </summary>
    [TerraformProperty("remote_ip_address")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? RemoteIpAddress { get; set; }

    /// <summary>
    /// The remote_port attribute.
    /// </summary>
    [TerraformProperty("remote_port")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? RemotePort { get; set; }

}

/// <summary>
/// Block type for storage_location in .
/// Nesting mode: list
/// </summary>
public partial class AzurermVirtualMachinePacketCaptureStorageLocationBlock : TerraformBlockBase
{
    /// <summary>
    /// The file_path attribute.
    /// </summary>
    [TerraformProperty("file_path")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? FilePath { get; set; }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [TerraformProperty("storage_account_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? StorageAccountId { get; set; }


}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermVirtualMachinePacketCaptureTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Manages a azurerm_virtual_machine_packet_capture resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermVirtualMachinePacketCapture : TerraformResource
{
    public AzurermVirtualMachinePacketCapture(string name) : base("azurerm_virtual_machine_packet_capture", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The maximum_bytes_per_packet attribute.
    /// </summary>
    [TerraformProperty("maximum_bytes_per_packet")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MaximumBytesPerPacket { get; set; }

    /// <summary>
    /// The maximum_bytes_per_session attribute.
    /// </summary>
    [TerraformProperty("maximum_bytes_per_session")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MaximumBytesPerSession { get; set; }

    /// <summary>
    /// The maximum_capture_duration_in_seconds attribute.
    /// </summary>
    [TerraformProperty("maximum_capture_duration_in_seconds")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MaximumCaptureDurationInSeconds { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The network_watcher_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkWatcherId is required")]
    [TerraformProperty("network_watcher_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> NetworkWatcherId { get; set; }

    /// <summary>
    /// The virtual_machine_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualMachineId is required")]
    [TerraformProperty("virtual_machine_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> VirtualMachineId { get; set; }

    /// <summary>
    /// Block for filter.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("filter")]
    public TerraformList<TerraformBlock<AzurermVirtualMachinePacketCaptureFilterBlock>>? Filter { get; set; }

    /// <summary>
    /// Block for storage_location.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageLocation is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 StorageLocation block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageLocation block(s) allowed")]
    [TerraformProperty("storage_location")]
    public TerraformList<TerraformBlock<AzurermVirtualMachinePacketCaptureStorageLocationBlock>>? StorageLocation { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermVirtualMachinePacketCaptureTimeoutsBlock>? Timeouts { get; set; }

}
