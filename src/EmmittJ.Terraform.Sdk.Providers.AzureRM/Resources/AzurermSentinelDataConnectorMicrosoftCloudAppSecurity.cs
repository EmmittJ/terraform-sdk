using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_sentinel_data_connector_microsoft_cloud_app_security resource.
/// </summary>
public class AzurermSentinelDataConnectorMicrosoftCloudAppSecurity : TerraformResource
{
    public AzurermSentinelDataConnectorMicrosoftCloudAppSecurity(string name) : base("azurerm_sentinel_data_connector_microsoft_cloud_app_security", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The alerts_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? AlertsEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("alerts_enabled");
        set => this.WithProperty("alerts_enabled", value);
    }

    /// <summary>
    /// The discovery_logs_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? DiscoveryLogsEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("discovery_logs_enabled");
        set => this.WithProperty("discovery_logs_enabled", value);
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
    /// The log_analytics_workspace_id attribute.
    /// </summary>
    public TerraformProperty<string>? LogAnalyticsWorkspaceId
    {
        get => GetProperty<TerraformProperty<string>>("log_analytics_workspace_id");
        set => this.WithProperty("log_analytics_workspace_id", value);
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
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        get => GetProperty<TerraformProperty<string>>("tenant_id");
        set => this.WithProperty("tenant_id", value);
    }

}
