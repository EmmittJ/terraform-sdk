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
    public bool? ExchangeEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("exchange_enabled")?.Value;
        set => this.WithProperty("exchange_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The log_analytics_workspace_id attribute.
    /// </summary>
    public string? LogAnalyticsWorkspaceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("log_analytics_workspace_id")?.Value;
        set => this.WithProperty("log_analytics_workspace_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The sharepoint_enabled attribute.
    /// </summary>
    public bool? SharepointEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("sharepoint_enabled")?.Value;
        set => this.WithProperty("sharepoint_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The teams_enabled attribute.
    /// </summary>
    public bool? TeamsEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("teams_enabled")?.Value;
        set => this.WithProperty("teams_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public string? TenantId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tenant_id")?.Value;
        set => this.WithProperty("tenant_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
