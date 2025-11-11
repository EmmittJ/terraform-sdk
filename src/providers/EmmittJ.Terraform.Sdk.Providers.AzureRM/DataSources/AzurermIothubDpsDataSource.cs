using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermIothubDpsDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_iothub_dps.
/// </summary>
public partial class AzurermIothubDpsDataSource : TerraformDataSource
{
    public AzurermIothubDpsDataSource(string name) : base("azurerm_iothub_dps", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermIothubDpsDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The allocation_policy attribute.
    /// </summary>
    [TerraformProperty("allocation_policy")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> AllocationPolicy { get; }

    /// <summary>
    /// The device_provisioning_host_name attribute.
    /// </summary>
    [TerraformProperty("device_provisioning_host_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DeviceProvisioningHostName { get; }

    /// <summary>
    /// The id_scope attribute.
    /// </summary>
    [TerraformProperty("id_scope")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> IdScope { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Location { get; }

    /// <summary>
    /// The service_operations_host_name attribute.
    /// </summary>
    [TerraformProperty("service_operations_host_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ServiceOperationsHostName { get; }

}
