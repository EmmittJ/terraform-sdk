using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermConsumptionBudgetResourceGroupDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_consumption_budget_resource_group.
/// </summary>
public partial class AzurermConsumptionBudgetResourceGroupDataSource : TerraformDataSource
{
    public AzurermConsumptionBudgetResourceGroupDataSource(string name) : base("azurerm_consumption_budget_resource_group", name)
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
    /// The resource_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupId is required")]
    [TerraformProperty("resource_group_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermConsumptionBudgetResourceGroupDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The amount attribute.
    /// </summary>
    [TerraformProperty("amount")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> Amount { get; }

    /// <summary>
    /// The filter attribute.
    /// </summary>
    [TerraformProperty("filter")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Filter { get; }

    /// <summary>
    /// The notification attribute.
    /// </summary>
    [TerraformProperty("notification")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Notification { get; }

    /// <summary>
    /// The time_grain attribute.
    /// </summary>
    [TerraformProperty("time_grain")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> TimeGrain { get; }

    /// <summary>
    /// The time_period attribute.
    /// </summary>
    [TerraformProperty("time_period")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> TimePeriod { get; }

}
