using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMonitorDiagnosticCategoriesDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_monitor_diagnostic_categories.
/// </summary>
public class AzurermMonitorDiagnosticCategoriesDataSource : TerraformDataSource
{
    public AzurermMonitorDiagnosticCategoriesDataSource(string name) : base("azurerm_monitor_diagnostic_categories", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceId is required")]
    [TerraformPropertyName("resource_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermMonitorDiagnosticCategoriesDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The log_category_groups attribute.
    /// </summary>
    [TerraformPropertyName("log_category_groups")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> LogCategoryGroups => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "log_category_groups");

    /// <summary>
    /// The log_category_types attribute.
    /// </summary>
    [TerraformPropertyName("log_category_types")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> LogCategoryTypes => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "log_category_types");

    /// <summary>
    /// The metrics attribute.
    /// </summary>
    [TerraformPropertyName("metrics")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> Metrics => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "metrics");

}
