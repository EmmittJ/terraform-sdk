using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermSentinelWatchlistItem.
/// Nesting mode: single
/// </summary>
public class AzurermSentinelWatchlistItemTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_sentinel_watchlist_item Terraform resource.
/// Manages a azurerm_sentinel_watchlist_item resource.
/// </summary>
public partial class AzurermSentinelWatchlistItem(string name) : TerraformResource("azurerm_sentinel_watchlist_item", name)
{
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
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The properties attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Properties is required")]
    public required TerraformMap<string> Properties
    {
        get => GetArgument<TerraformMap<string>>("properties");
        set => SetArgument("properties", value);
    }

    /// <summary>
    /// The watchlist_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WatchlistId is required")]
    public required TerraformValue<string> WatchlistId
    {
        get => GetArgument<TerraformValue<string>>("watchlist_id");
        set => SetArgument("watchlist_id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSentinelWatchlistItemTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSentinelWatchlistItemTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
