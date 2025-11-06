using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_log_analytics_data_export_rule resource.
/// </summary>
public class AzurermLogAnalyticsDataExportRule : TerraformResource
{
    public AzurermLogAnalyticsDataExportRule(string name) : base("azurerm_log_analytics_data_export_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("export_rule_id");
    }

    /// <summary>
    /// The destination_resource_id attribute.
    /// </summary>
    public string? DestinationResourceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("destination_resource_id")?.Value;
        set => this.WithProperty("destination_resource_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public bool? Enabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enabled")?.Value;
        set => this.WithProperty("enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The table_names attribute.
    /// </summary>
    public HashSet<string>? TableNames
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("table_names")?.Value;
        set => this.WithProperty("table_names", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The workspace_resource_id attribute.
    /// </summary>
    public string? WorkspaceResourceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("workspace_resource_id")?.Value;
        set => this.WithProperty("workspace_resource_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The export_rule_id attribute.
    /// </summary>
    public TerraformExpression ExportRuleId => this["export_rule_id"];

}
