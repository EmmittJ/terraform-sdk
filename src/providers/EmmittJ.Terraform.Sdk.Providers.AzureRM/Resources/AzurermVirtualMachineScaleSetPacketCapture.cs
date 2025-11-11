using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for filter in .
/// Nesting mode: list
/// </summary>
public partial class AzurermVirtualMachineScaleSetPacketCaptureFilterBlock : TerraformBlockBase
{
    /// <summary>
    /// The local_ip_address attribute.
    /// </summary>
    [TerraformProperty("local_ip_address")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? LocalIpAddress { get; set; }

    /// <summary>
    /// The local_port attribute.
    /// </summary>
    [TerraformProperty("local_port")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? LocalPort { get; set; }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    [TerraformProperty("protocol")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Protocol { get; set; }

    /// <summary>
    /// The remote_ip_address attribute.
    /// </summary>
    [TerraformProperty("remote_ip_address")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RemoteIpAddress { get; set; }

    /// <summary>
    /// The remote_port attribute.
    /// </summary>
    [TerraformProperty("remote_port")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RemotePort { get; set; }

}

/// <summary>
/// Block type for machine_scope in .
/// Nesting mode: list
/// </summary>
public partial class AzurermVirtualMachineScaleSetPacketCaptureMachineScopeBlock : TerraformBlockBase
{
    /// <summary>
    /// The exclude_instance_ids attribute.
    /// </summary>
    [TerraformProperty("exclude_instance_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? ExcludeInstanceIds { get; set; }

    /// <summary>
    /// The include_instance_ids attribute.
    /// </summary>
    [TerraformProperty("include_instance_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? IncludeInstanceIds { get; set; }

}

/// <summary>
/// Block type for storage_location in .
/// Nesting mode: list
/// </summary>
public partial class AzurermVirtualMachineScaleSetPacketCaptureStorageLocationBlock : TerraformBlockBase
{
    /// <summary>
    /// The file_path attribute.
    /// </summary>
    [TerraformProperty("file_path")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? FilePath { get; set; }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [TerraformProperty("storage_account_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? StorageAccountId { get; set; }


}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermVirtualMachineScaleSetPacketCaptureTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Manages a azurerm_virtual_machine_scale_set_packet_capture resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermVirtualMachineScaleSetPacketCapture : TerraformResource
{
    public AzurermVirtualMachineScaleSetPacketCapture(string name) : base("azurerm_virtual_machine_scale_set_packet_capture", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The maximum_bytes_per_packet attribute.
    /// </summary>
    [TerraformProperty("maximum_bytes_per_packet")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MaximumBytesPerPacket { get; set; }

    /// <summary>
    /// The maximum_bytes_per_session attribute.
    /// </summary>
    [TerraformProperty("maximum_bytes_per_session")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MaximumBytesPerSession { get; set; }

    /// <summary>
    /// The maximum_capture_duration_in_seconds attribute.
    /// </summary>
    [TerraformProperty("maximum_capture_duration_in_seconds")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MaximumCaptureDurationInSeconds { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The network_watcher_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkWatcherId is required")]
    [TerraformProperty("network_watcher_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> NetworkWatcherId { get; set; }

    /// <summary>
    /// The virtual_machine_scale_set_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualMachineScaleSetId is required")]
    [TerraformProperty("virtual_machine_scale_set_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> VirtualMachineScaleSetId { get; set; }

    /// <summary>
    /// Block for filter.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("filter")]
    public partial TerraformList<TerraformBlock<AzurermVirtualMachineScaleSetPacketCaptureFilterBlock>>? Filter { get; set; }

    /// <summary>
    /// Block for machine_scope.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MachineScope block(s) allowed")]
    [TerraformProperty("machine_scope")]
    public partial TerraformList<TerraformBlock<AzurermVirtualMachineScaleSetPacketCaptureMachineScopeBlock>>? MachineScope { get; set; }

    /// <summary>
    /// Block for storage_location.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageLocation is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 StorageLocation block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageLocation block(s) allowed")]
    [TerraformProperty("storage_location")]
    public partial TerraformList<TerraformBlock<AzurermVirtualMachineScaleSetPacketCaptureStorageLocationBlock>>? StorageLocation { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermVirtualMachineScaleSetPacketCaptureTimeoutsBlock>? Timeouts { get; set; }

}
