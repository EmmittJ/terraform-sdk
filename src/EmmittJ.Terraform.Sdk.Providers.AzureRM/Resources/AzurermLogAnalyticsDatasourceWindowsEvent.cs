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
    public string? EventLogName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("event_log_name")?.Value;
        set => this.WithProperty("event_log_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The event_types attribute.
    /// </summary>
    public HashSet<string>? EventTypes
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("event_types")?.Value;
        set => this.WithProperty("event_types", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
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
    /// The workspace_name attribute.
    /// </summary>
    public string? WorkspaceName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("workspace_name")?.Value;
        set => this.WithProperty("workspace_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
