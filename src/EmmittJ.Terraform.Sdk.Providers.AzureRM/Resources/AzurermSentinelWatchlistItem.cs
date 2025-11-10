using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSentinelWatchlistItemTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_sentinel_watchlist_item resource.
/// </summary>
public class AzurermSentinelWatchlistItem : TerraformResource
{
    public AzurermSentinelWatchlistItem(string name) : base("azurerm_sentinel_watchlist_item", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The properties attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Properties is required")]
    public Dictionary<string, TerraformProperty<string>>? Properties
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("properties");
        set => this.WithProperty("properties", value);
    }

    /// <summary>
    /// The watchlist_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WatchlistId is required")]
    public required TerraformProperty<string> WatchlistId
    {
        get => GetProperty<TerraformProperty<string>>("watchlist_id");
        set => this.WithProperty("watchlist_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSentinelWatchlistItemTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermSentinelWatchlistItemTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
