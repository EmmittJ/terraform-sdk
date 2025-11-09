using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
    public TerraformMapProperty<string>? Properties
    {
        get => GetProperty<TerraformMapProperty<string>>("properties");
        set => this.WithProperty("properties", value);
    }

    /// <summary>
    /// The watchlist_id attribute.
    /// </summary>
    public TerraformProperty<string>? WatchlistId
    {
        get => GetProperty<TerraformProperty<string>>("watchlist_id");
        set => this.WithProperty("watchlist_id", value);
    }

}
