using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermSentinelDataConnectorMicrosoftCloudAppSecurity.
/// Nesting mode: single
/// </summary>
public class AzurermSentinelDataConnectorMicrosoftCloudAppSecurityTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_sentinel_data_connector_microsoft_cloud_app_security Terraform resource.
/// Manages a azurerm_sentinel_data_connector_microsoft_cloud_app_security resource.
/// </summary>
public partial class AzurermSentinelDataConnectorMicrosoftCloudAppSecurity(string name) : TerraformResource("azurerm_sentinel_data_connector_microsoft_cloud_app_security", name)
{
    /// <summary>
    /// The alerts_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? AlertsEnabled
    {
        get => GetArgument<TerraformValue<bool>>("alerts_enabled");
        set => SetArgument("alerts_enabled", value);
    }

    /// <summary>
    /// The discovery_logs_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? DiscoveryLogsEnabled
    {
        get => GetArgument<TerraformValue<bool>>("discovery_logs_enabled");
        set => SetArgument("discovery_logs_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The log_analytics_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogAnalyticsWorkspaceId is required")]
    public required TerraformValue<string> LogAnalyticsWorkspaceId
    {
        get => GetArgument<TerraformValue<string>>("log_analytics_workspace_id");
        set => SetArgument("log_analytics_workspace_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string>? TenantId
    {
        get => GetArgument<TerraformValue<string>>("tenant_id");
        set => SetArgument("tenant_id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSentinelDataConnectorMicrosoftCloudAppSecurityTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSentinelDataConnectorMicrosoftCloudAppSecurityTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
