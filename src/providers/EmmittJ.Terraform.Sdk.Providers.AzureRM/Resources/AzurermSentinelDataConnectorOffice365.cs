using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSentinelDataConnectorOffice365TimeoutsBlock : TerraformBlock
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
        SetOutput("exchange_enabled");
        SetOutput("id");
        SetOutput("log_analytics_workspace_id");
        SetOutput("name");
        SetOutput("sharepoint_enabled");
        SetOutput("teams_enabled");
        SetOutput("tenant_id");
    }

    /// <summary>
    /// The exchange_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> ExchangeEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("exchange_enabled");
        set => SetProperty("exchange_enabled", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The sharepoint_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> SharepointEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("sharepoint_enabled");
        set => SetProperty("sharepoint_enabled", value);
    }

    /// <summary>
    /// The teams_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> TeamsEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("teams_enabled");
        set => SetProperty("teams_enabled", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSentinelDataConnectorOffice365TimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
