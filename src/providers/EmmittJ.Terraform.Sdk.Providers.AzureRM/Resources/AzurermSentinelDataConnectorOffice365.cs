using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
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
        get => new TerraformReference<bool>(this, "exchange_enabled");
        set => SetArgument("exchange_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The log_analytics_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogAnalyticsWorkspaceId is required")]
    public required TerraformValue<string> LogAnalyticsWorkspaceId
    {
        get => new TerraformReference<string>(this, "log_analytics_workspace_id");
        set => SetArgument("log_analytics_workspace_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The sharepoint_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? SharepointEnabled
    {
        get => new TerraformReference<bool>(this, "sharepoint_enabled");
        set => SetArgument("sharepoint_enabled", value);
    }

    /// <summary>
    /// The teams_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? TeamsEnabled
    {
        get => new TerraformReference<bool>(this, "teams_enabled");
        set => SetArgument("teams_enabled", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string> TenantId
    {
        get => new TerraformReference<string>(this, "tenant_id");
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
