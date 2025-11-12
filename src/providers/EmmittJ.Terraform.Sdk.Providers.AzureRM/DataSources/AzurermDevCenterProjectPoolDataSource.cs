using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermDevCenterProjectPoolDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_dev_center_project_pool.
/// </summary>
public partial class AzurermDevCenterProjectPoolDataSource : TerraformDataSource
{
    public AzurermDevCenterProjectPoolDataSource(string name) : base("azurerm_dev_center_project_pool", name)
    {
    }

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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermDevCenterProjectPoolDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The dev_box_definition_name attribute.
    /// </summary>
    [TerraformProperty("dev_box_definition_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DevBoxDefinitionName { get; }

    /// <summary>
    /// The dev_center_attached_network_name attribute.
    /// </summary>
    [TerraformProperty("dev_center_attached_network_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DevCenterAttachedNetworkName { get; }

    /// <summary>
    /// The local_administrator_enabled attribute.
    /// </summary>
    [TerraformProperty("local_administrator_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> LocalAdministratorEnabled { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Location { get; }

    /// <summary>
    /// The single_sign_on_enabled attribute.
    /// </summary>
    [TerraformProperty("single_sign_on_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> SingleSignOnEnabled { get; }

    /// <summary>
    /// The stop_on_disconnect_grace_period_minutes attribute.
    /// </summary>
    [TerraformProperty("stop_on_disconnect_grace_period_minutes")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> StopOnDisconnectGracePeriodMinutes { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Tags { get; }

}
