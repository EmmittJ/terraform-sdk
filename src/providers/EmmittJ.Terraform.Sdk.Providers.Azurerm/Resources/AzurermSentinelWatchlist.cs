using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermSentinelWatchlist.
/// Nesting mode: single
/// </summary>
public class AzurermSentinelWatchlistTimeoutsBlock : TerraformBlock
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

}


/// <summary>
/// Represents a azurerm_sentinel_watchlist Terraform resource.
/// Manages a azurerm_sentinel_watchlist resource.
/// </summary>
public partial class AzurermSentinelWatchlist(string name) : TerraformResource("azurerm_sentinel_watchlist", name)
{
    /// <summary>
    /// The default_duration attribute.
    /// </summary>
    public TerraformValue<string>? DefaultDuration
    {
        get => GetArgument<TerraformValue<string>>("default_duration");
        set => SetArgument("default_duration", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
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
    /// The item_search_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ItemSearchKey is required")]
    public required TerraformValue<string> ItemSearchKey
    {
        get => GetArgument<TerraformValue<string>>("item_search_key");
        set => SetArgument("item_search_key", value);
    }

    /// <summary>
    /// The labels attribute.
    /// </summary>
    public TerraformList<string>? Labels
    {
        get => GetArgument<TerraformList<string>>("labels");
        set => SetArgument("labels", value);
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
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSentinelWatchlistTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSentinelWatchlistTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
