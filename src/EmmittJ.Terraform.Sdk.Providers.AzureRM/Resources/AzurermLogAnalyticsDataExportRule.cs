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
    public TerraformProperty<string>? DestinationResourceId
    {
        get => GetProperty<TerraformProperty<string>>("destination_resource_id");
        set => this.WithProperty("destination_resource_id", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => this.WithProperty("enabled", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The table_names attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? TableNames
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("table_names");
        set => this.WithProperty("table_names", value);
    }

    /// <summary>
    /// The workspace_resource_id attribute.
    /// </summary>
    public TerraformProperty<string>? WorkspaceResourceId
    {
        get => GetProperty<TerraformProperty<string>>("workspace_resource_id");
        set => this.WithProperty("workspace_resource_id", value);
    }

    /// <summary>
    /// The export_rule_id attribute.
    /// </summary>
    public TerraformExpression ExportRuleId => this["export_rule_id"];

}
