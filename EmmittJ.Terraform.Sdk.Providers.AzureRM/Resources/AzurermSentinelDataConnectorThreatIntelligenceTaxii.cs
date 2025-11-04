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
    public string? ApiRootUrl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("api_root_url")?.Value;
        set => this.WithProperty("api_root_url", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The collection_id attribute.
    /// </summary>
    public string? CollectionId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("collection_id")?.Value;
        set => this.WithProperty("collection_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The lookback_date attribute.
    /// </summary>
    public string? LookbackDate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("lookback_date")?.Value;
        set => this.WithProperty("lookback_date", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The password attribute.
    /// </summary>
    public string? Password
    {
        get => GetProperty<TerraformLiteralProperty<string>>("password")?.Value;
        set => this.WithProperty("password", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The polling_frequency attribute.
    /// </summary>
    public string? PollingFrequency
    {
        get => GetProperty<TerraformLiteralProperty<string>>("polling_frequency")?.Value;
        set => this.WithProperty("polling_frequency", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public string? TenantId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tenant_id")?.Value;
        set => this.WithProperty("tenant_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    public string? UserName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user_name")?.Value;
        set => this.WithProperty("user_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
