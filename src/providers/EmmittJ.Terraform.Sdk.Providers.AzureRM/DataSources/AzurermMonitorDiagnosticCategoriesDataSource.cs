using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMonitorDiagnosticCategoriesDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

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
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceId is required")]
    [TerraformPropertyName("resource_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermMonitorDiagnosticCategoriesDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The log_category_groups attribute.
    /// </summary>
    [TerraformPropertyName("log_category_groups")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> LogCategoryGroups => new TerraformReference(this, "log_category_groups");

    /// <summary>
    /// The log_category_types attribute.
    /// </summary>
    [TerraformPropertyName("log_category_types")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> LogCategoryTypes => new TerraformReference(this, "log_category_types");

    /// <summary>
    /// The metrics attribute.
    /// </summary>
    [TerraformPropertyName("metrics")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> Metrics => new TerraformReference(this, "metrics");

}
