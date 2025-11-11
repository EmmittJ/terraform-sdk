using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermDevCenterProjectPoolTimeoutsBlock : TerraformBlockBase
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_dev_center_project_pool resource.
/// </summary>
public partial class AzurermDevCenterProjectPool : TerraformResource
{
    public AzurermDevCenterProjectPool(string name) : base("azurerm_dev_center_project_pool", name)
    {
    }

    /// <summary>
    /// The dev_box_definition_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DevBoxDefinitionName is required")]
    [TerraformProperty("dev_box_definition_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DevBoxDefinitionName { get; set; }

    /// <summary>
    /// The dev_center_attached_network_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DevCenterAttachedNetworkName is required")]
    [TerraformProperty("dev_center_attached_network_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DevCenterAttachedNetworkName { get; set; }

    /// <summary>
    /// The dev_center_project_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DevCenterProjectId is required")]
    [TerraformProperty("dev_center_project_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DevCenterProjectId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The local_administrator_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocalAdministratorEnabled is required")]
    [TerraformProperty("local_administrator_enabled")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> LocalAdministratorEnabled { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The managed_virtual_network_regions attribute.
    /// </summary>
    [TerraformProperty("managed_virtual_network_regions")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? ManagedVirtualNetworkRegions { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The single_sign_on_enabled attribute.
    /// </summary>
    [TerraformProperty("single_sign_on_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? SingleSignOnEnabled { get; set; }

    /// <summary>
    /// The stop_on_disconnect_grace_period_minutes attribute.
    /// </summary>
    [TerraformProperty("stop_on_disconnect_grace_period_minutes")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? StopOnDisconnectGracePeriodMinutes { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermDevCenterProjectPoolTimeoutsBlock>? Timeouts { get; set; }

}
