using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_sentinel_data_connector_office_365 resource.
/// </summary>
public class AzurermSentinelDataConnectorOffice365 : TerraformResource
{
    public AzurermSentinelDataConnectorOffice365(string name) : base("azurerm_sentinel_data_connector_office_365", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The exchange_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ExchangeEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("exchange_enabled");
        set => this.WithProperty("exchange_enabled", value);
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
    /// The sharepoint_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? SharepointEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("sharepoint_enabled");
        set => this.WithProperty("sharepoint_enabled", value);
    }

    /// <summary>
    /// The teams_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? TeamsEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("teams_enabled");
        set => this.WithProperty("teams_enabled", value);
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
