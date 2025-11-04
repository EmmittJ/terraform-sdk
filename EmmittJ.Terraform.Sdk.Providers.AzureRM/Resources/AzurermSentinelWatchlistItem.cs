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
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The properties attribute.
    /// </summary>
    public Dictionary<string, string>? Properties
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("properties")?.Value;
        set => this.WithProperty("properties", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The watchlist_id attribute.
    /// </summary>
    public string? WatchlistId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("watchlist_id")?.Value;
        set => this.WithProperty("watchlist_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
