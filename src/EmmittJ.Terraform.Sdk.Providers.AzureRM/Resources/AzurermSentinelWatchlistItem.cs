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
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The properties attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Properties
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("properties");
        set => this.WithProperty("properties", value);
    }

    /// <summary>
    /// The watchlist_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? WatchlistId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("watchlist_id");
        set => this.WithProperty("watchlist_id", value);
    }

}
