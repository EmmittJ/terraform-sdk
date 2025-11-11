using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermMonitorDiagnosticCategoriesDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_monitor_diagnostic_categories.
/// </summary>
public partial class AzurermMonitorDiagnosticCategoriesDataSource : TerraformDataSource
{
    public AzurermMonitorDiagnosticCategoriesDataSource(string name) : base("azurerm_monitor_diagnostic_categories", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceId is required")]
    [TerraformProperty("resource_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermMonitorDiagnosticCategoriesDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The log_category_groups attribute.
    /// </summary>
    [TerraformProperty("log_category_groups")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> LogCategoryGroups { get; }

    /// <summary>
    /// The log_category_types attribute.
    /// </summary>
    [TerraformProperty("log_category_types")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> LogCategoryTypes { get; }

    /// <summary>
    /// The metrics attribute.
    /// </summary>
    [TerraformProperty("metrics")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> Metrics { get; }

}
