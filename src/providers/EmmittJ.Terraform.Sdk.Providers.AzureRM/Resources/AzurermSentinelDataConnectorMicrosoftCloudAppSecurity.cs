using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSentinelDataConnectorMicrosoftCloudAppSecurityTimeoutsBlock : TerraformBlock
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
        SetOutput("alerts_enabled");
        SetOutput("discovery_logs_enabled");
        SetOutput("id");
        SetOutput("log_analytics_workspace_id");
        SetOutput("name");
        SetOutput("tenant_id");
    }

    /// <summary>
    /// The alerts_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> AlertsEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("alerts_enabled");
        set => SetProperty("alerts_enabled", value);
    }

    /// <summary>
    /// The discovery_logs_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> DiscoveryLogsEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("discovery_logs_enabled");
        set => SetProperty("discovery_logs_enabled", value);
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
    public AzurermSentinelDataConnectorMicrosoftCloudAppSecurityTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
