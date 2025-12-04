using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermLogAnalyticsDatasourceWindowsEvent.
/// Nesting mode: single
/// </summary>
public class AzurermLogAnalyticsDatasourceWindowsEventTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_log_analytics_datasource_windows_event Terraform resource.
/// Manages a azurerm_log_analytics_datasource_windows_event resource.
/// </summary>
public partial class AzurermLogAnalyticsDatasourceWindowsEvent(string name) : TerraformResource("azurerm_log_analytics_datasource_windows_event", name)
{
    /// <summary>
    /// The event_log_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventLogName is required")]
    public required TerraformValue<string> EventLogName
    {
        get => GetArgument<TerraformValue<string>>("event_log_name");
        set => SetArgument("event_log_name", value);
    }

    /// <summary>
    /// The event_types attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventTypes is required")]
    public required TerraformSet<string> EventTypes
    {
        get => GetArgument<TerraformSet<string>>("event_types");
        set => SetArgument("event_types", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The workspace_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceName is required")]
    public required TerraformValue<string> WorkspaceName
    {
        get => GetArgument<TerraformValue<string>>("workspace_name");
        set => SetArgument("workspace_name", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermLogAnalyticsDatasourceWindowsEventTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermLogAnalyticsDatasourceWindowsEventTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
