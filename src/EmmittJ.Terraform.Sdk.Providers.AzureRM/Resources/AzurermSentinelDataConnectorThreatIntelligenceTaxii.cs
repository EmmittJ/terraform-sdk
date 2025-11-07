using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_sentinel_data_connector_threat_intelligence_taxii resource.
/// </summary>
public class AzurermSentinelDataConnectorThreatIntelligenceTaxii : TerraformResource
{
    public AzurermSentinelDataConnectorThreatIntelligenceTaxii(string name) : base("azurerm_sentinel_data_connector_threat_intelligence_taxii", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The api_root_url attribute.
    /// </summary>
    public TerraformProperty<string>? ApiRootUrl
    {
        get => GetProperty<TerraformProperty<string>>("api_root_url");
        set => this.WithProperty("api_root_url", value);
    }

    /// <summary>
    /// The collection_id attribute.
    /// </summary>
    public TerraformProperty<string>? CollectionId
    {
        get => GetProperty<TerraformProperty<string>>("collection_id");
        set => this.WithProperty("collection_id", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
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
    /// The lookback_date attribute.
    /// </summary>
    public TerraformProperty<string>? LookbackDate
    {
        get => GetProperty<TerraformProperty<string>>("lookback_date");
        set => this.WithProperty("lookback_date", value);
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
    /// The password attribute.
    /// </summary>
    public TerraformProperty<string>? Password
    {
        get => GetProperty<TerraformProperty<string>>("password");
        set => this.WithProperty("password", value);
    }

    /// <summary>
    /// The polling_frequency attribute.
    /// </summary>
    public TerraformProperty<string>? PollingFrequency
    {
        get => GetProperty<TerraformProperty<string>>("polling_frequency");
        set => this.WithProperty("polling_frequency", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        get => GetProperty<TerraformProperty<string>>("tenant_id");
        set => this.WithProperty("tenant_id", value);
    }

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    public TerraformProperty<string>? UserName
    {
        get => GetProperty<TerraformProperty<string>>("user_name");
        set => this.WithProperty("user_name", value);
    }

}
