using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermConsumptionBudgetResourceGroupDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The resource_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupId is required")]
    [TerraformPropertyName("resource_group_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermConsumptionBudgetResourceGroupDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The amount attribute.
    /// </summary>
    [TerraformPropertyName("amount")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> Amount => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "amount");

    /// <summary>
    /// The filter attribute.
    /// </summary>
    [TerraformPropertyName("filter")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Filter => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "filter");

    /// <summary>
    /// The notification attribute.
    /// </summary>
    [TerraformPropertyName("notification")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Notification => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "notification");

    /// <summary>
    /// The time_grain attribute.
    /// </summary>
    [TerraformPropertyName("time_grain")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TimeGrain => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "time_grain");

    /// <summary>
    /// The time_period attribute.
    /// </summary>
    [TerraformPropertyName("time_period")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> TimePeriod => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "time_period");

}
