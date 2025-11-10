using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSentinelDataConnectorThreatIntelligenceTaxiiTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

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
        SetOutput("api_root_url");
        SetOutput("collection_id");
        SetOutput("display_name");
        SetOutput("id");
        SetOutput("log_analytics_workspace_id");
        SetOutput("lookback_date");
        SetOutput("name");
        SetOutput("password");
        SetOutput("polling_frequency");
        SetOutput("tenant_id");
        SetOutput("user_name");
    }

    /// <summary>
    /// The api_root_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiRootUrl is required")]
    public required TerraformProperty<string> ApiRootUrl
    {
        get => GetRequiredOutput<TerraformProperty<string>>("api_root_url");
        set => SetProperty("api_root_url", value);
    }

    /// <summary>
    /// The collection_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CollectionId is required")]
    public required TerraformProperty<string> CollectionId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("collection_id");
        set => SetProperty("collection_id", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The log_analytics_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogAnalyticsWorkspaceId is required")]
    public required TerraformProperty<string> LogAnalyticsWorkspaceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("log_analytics_workspace_id");
        set => SetProperty("log_analytics_workspace_id", value);
    }

    /// <summary>
    /// The lookback_date attribute.
    /// </summary>
    public TerraformProperty<string> LookbackDate
    {
        get => GetRequiredOutput<TerraformProperty<string>>("lookback_date");
        set => SetProperty("lookback_date", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    public TerraformProperty<string> Password
    {
        get => GetRequiredOutput<TerraformProperty<string>>("password");
        set => SetProperty("password", value);
    }

    /// <summary>
    /// The polling_frequency attribute.
    /// </summary>
    public TerraformProperty<string> PollingFrequency
    {
        get => GetRequiredOutput<TerraformProperty<string>>("polling_frequency");
        set => SetProperty("polling_frequency", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string> TenantId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("tenant_id");
        set => SetProperty("tenant_id", value);
    }

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    public TerraformProperty<string> UserName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("user_name");
        set => SetProperty("user_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSentinelDataConnectorThreatIntelligenceTaxiiTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
