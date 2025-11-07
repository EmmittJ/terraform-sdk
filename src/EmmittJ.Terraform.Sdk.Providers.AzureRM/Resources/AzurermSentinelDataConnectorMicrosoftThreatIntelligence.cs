using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_sentinel_data_connector_microsoft_threat_intelligence resource.
/// </summary>
public class AzurermSentinelDataConnectorMicrosoftThreatIntelligence : TerraformResource
{
    public AzurermSentinelDataConnectorMicrosoftThreatIntelligence(string name) : base("azurerm_sentinel_data_connector_microsoft_threat_intelligence", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The microsoft_emerging_threat_feed_lookback_date attribute.
    /// </summary>
    public TerraformProperty<string>? MicrosoftEmergingThreatFeedLookbackDate
    {
        get => GetProperty<TerraformProperty<string>>("microsoft_emerging_threat_feed_lookback_date");
        set => this.WithProperty("microsoft_emerging_threat_feed_lookback_date", value);
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
