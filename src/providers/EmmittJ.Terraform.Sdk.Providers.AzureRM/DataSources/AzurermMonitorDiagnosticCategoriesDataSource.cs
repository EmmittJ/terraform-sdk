using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMonitorDiagnosticCategoriesDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_monitor_diagnostic_categories.
/// </summary>
public class AzurermMonitorDiagnosticCategoriesDataSource : TerraformDataSource
{
    public AzurermMonitorDiagnosticCategoriesDataSource(string name) : base("azurerm_monitor_diagnostic_categories", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("log_category_groups");
        this.WithOutput("log_category_types");
        this.WithOutput("metrics");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceId is required")]
    public required TerraformProperty<string> ResourceId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_id");
        set => this.WithProperty("resource_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMonitorDiagnosticCategoriesDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermMonitorDiagnosticCategoriesDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The log_category_groups attribute.
    /// </summary>
    public TerraformExpression LogCategoryGroups => this["log_category_groups"];

    /// <summary>
    /// The log_category_types attribute.
    /// </summary>
    public TerraformExpression LogCategoryTypes => this["log_category_types"];

    /// <summary>
    /// The metrics attribute.
    /// </summary>
    public TerraformExpression Metrics => this["metrics"];

}
