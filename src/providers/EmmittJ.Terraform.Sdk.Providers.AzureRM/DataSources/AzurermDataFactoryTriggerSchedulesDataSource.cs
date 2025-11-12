using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermDataFactoryTriggerSchedulesDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_data_factory_trigger_schedules.
/// </summary>
public partial class AzurermDataFactoryTriggerSchedulesDataSource : TerraformDataSource
{
    public AzurermDataFactoryTriggerSchedulesDataSource(string name) : base("azurerm_data_factory_trigger_schedules", name)
    {
    }

    /// <summary>
    /// The data_factory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataFactoryId is required")]
    [TerraformProperty("data_factory_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DataFactoryId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermDataFactoryTriggerSchedulesDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The items attribute.
    /// </summary>
    [TerraformProperty("items")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> Items { get; }

}
