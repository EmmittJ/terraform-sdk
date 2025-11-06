using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
        this.DeclareOutput("log_category_groups");
        this.DeclareOutput("log_category_types");
        this.DeclareOutput("metrics");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    public string? ResourceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_id")?.Value;
        set => this.WithProperty("resource_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
