using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermLogAnalyticsWorkspaceTableDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_log_analytics_workspace_table.
/// </summary>
public class AzurermLogAnalyticsWorkspaceTableDataSource : TerraformDataSource
{
    public AzurermLogAnalyticsWorkspaceTableDataSource(string name) : base("azurerm_log_analytics_workspace_table", name)
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
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    [TerraformPropertyName("workspace_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> WorkspaceId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermLogAnalyticsWorkspaceTableDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The plan attribute.
    /// </summary>
    [TerraformPropertyName("plan")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Plan => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "plan");

    /// <summary>
    /// The retention_in_days attribute.
    /// </summary>
    [TerraformPropertyName("retention_in_days")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> RetentionInDays => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "retention_in_days");

    /// <summary>
    /// The total_retention_in_days attribute.
    /// </summary>
    [TerraformPropertyName("total_retention_in_days")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> TotalRetentionInDays => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "total_retention_in_days");

}
