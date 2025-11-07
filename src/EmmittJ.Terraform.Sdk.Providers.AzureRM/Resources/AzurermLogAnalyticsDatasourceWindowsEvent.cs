using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_log_analytics_datasource_windows_event resource.
/// </summary>
public class AzurermLogAnalyticsDatasourceWindowsEvent : TerraformResource
{
    public AzurermLogAnalyticsDatasourceWindowsEvent(string name) : base("azurerm_log_analytics_datasource_windows_event", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The event_log_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EventLogName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("event_log_name");
        set => this.WithProperty("event_log_name", value);
    }

    /// <summary>
    /// The event_types attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? EventTypes
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("event_types");
        set => this.WithProperty("event_types", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The workspace_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? WorkspaceName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("workspace_name");
        set => this.WithProperty("workspace_name", value);
    }

}
