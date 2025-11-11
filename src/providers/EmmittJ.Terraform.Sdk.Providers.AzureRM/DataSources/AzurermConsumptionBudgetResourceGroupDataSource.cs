using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermConsumptionBudgetResourceGroupDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_consumption_budget_resource_group.
/// </summary>
public class AzurermConsumptionBudgetResourceGroupDataSource : TerraformDataSource
{
    public AzurermConsumptionBudgetResourceGroupDataSource(string name) : base("azurerm_consumption_budget_resource_group", name)
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
    /// The resource_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupId is required")]
    [TerraformPropertyName("resource_group_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermConsumptionBudgetResourceGroupDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The amount attribute.
    /// </summary>
    [TerraformPropertyName("amount")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> Amount => new TerraformReference(this, "amount");

    /// <summary>
    /// The filter attribute.
    /// </summary>
    [TerraformPropertyName("filter")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Filter => new TerraformReference(this, "filter");

    /// <summary>
    /// The notification attribute.
    /// </summary>
    [TerraformPropertyName("notification")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Notification => new TerraformReference(this, "notification");

    /// <summary>
    /// The time_grain attribute.
    /// </summary>
    [TerraformPropertyName("time_grain")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TimeGrain => new TerraformReference(this, "time_grain");

    /// <summary>
    /// The time_period attribute.
    /// </summary>
    [TerraformPropertyName("time_period")]
    // Output-only attribute - read-only reference
    public TerraformList<object> TimePeriod => new TerraformReference(this, "time_period");

}
