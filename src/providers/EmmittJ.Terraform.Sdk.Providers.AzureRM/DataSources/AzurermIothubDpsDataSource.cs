using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermIothubDpsDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_iothub_dps.
/// </summary>
public class AzurermIothubDpsDataSource : TerraformDataSource
{
    public AzurermIothubDpsDataSource(string name) : base("azurerm_iothub_dps", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermIothubDpsDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The allocation_policy attribute.
    /// </summary>
    [TerraformPropertyName("allocation_policy")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AllocationPolicy => new TerraformReference(this, "allocation_policy");

    /// <summary>
    /// The device_provisioning_host_name attribute.
    /// </summary>
    [TerraformPropertyName("device_provisioning_host_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DeviceProvisioningHostName => new TerraformReference(this, "device_provisioning_host_name");

    /// <summary>
    /// The id_scope attribute.
    /// </summary>
    [TerraformPropertyName("id_scope")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> IdScope => new TerraformReference(this, "id_scope");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Location => new TerraformReference(this, "location");

    /// <summary>
    /// The service_operations_host_name attribute.
    /// </summary>
    [TerraformPropertyName("service_operations_host_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ServiceOperationsHostName => new TerraformReference(this, "service_operations_host_name");

}
