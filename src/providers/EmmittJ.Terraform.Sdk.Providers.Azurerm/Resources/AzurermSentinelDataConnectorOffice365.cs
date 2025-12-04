using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermSentinelDataConnectorOffice365.
/// Nesting mode: single
/// </summary>
public class AzurermSentinelDataConnectorOffice365TimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_sentinel_data_connector_office_365 Terraform resource.
/// Manages a azurerm_sentinel_data_connector_office_365 resource.
/// </summary>
public partial class AzurermSentinelDataConnectorOffice365(string name) : TerraformResource("azurerm_sentinel_data_connector_office_365", name)
{
    /// <summary>
    /// The exchange_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? ExchangeEnabled
    {
        get => GetArgument<TerraformValue<bool>>("exchange_enabled");
        set => SetArgument("exchange_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The log_analytics_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogAnalyticsWorkspaceId is required")]
    public required TerraformValue<string> LogAnalyticsWorkspaceId
    {
        get => GetRequiredArgument<TerraformValue<string>>("log_analytics_workspace_id");
        set => SetArgument("log_analytics_workspace_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The sharepoint_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? SharepointEnabled
    {
        get => GetArgument<TerraformValue<bool>>("sharepoint_enabled");
        set => SetArgument("sharepoint_enabled", value);
    }

    /// <summary>
    /// The teams_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? TeamsEnabled
    {
        get => GetArgument<TerraformValue<bool>>("teams_enabled");
        set => SetArgument("teams_enabled", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string> TenantId
    {
        get => GetArgument<TerraformValue<string>>("tenant_id") ?? AsReference("tenant_id");
        set => SetArgument("tenant_id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSentinelDataConnectorOffice365TimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSentinelDataConnectorOffice365TimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
