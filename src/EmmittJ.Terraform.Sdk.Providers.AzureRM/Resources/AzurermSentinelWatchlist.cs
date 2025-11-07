using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_sentinel_watchlist resource.
/// </summary>
public class AzurermSentinelWatchlist : TerraformResource
{
    public AzurermSentinelWatchlist(string name) : base("azurerm_sentinel_watchlist", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The default_duration attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DefaultDuration
    {
        get => GetProperty<TerraformLiteralProperty<string>>("default_duration");
        set => this.WithProperty("default_duration", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
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
    /// The item_search_key attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ItemSearchKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("item_search_key");
        set => this.WithProperty("item_search_key", value);
    }

    /// <summary>
    /// The labels attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? Labels
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// The log_analytics_workspace_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? LogAnalyticsWorkspaceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("log_analytics_workspace_id");
        set => this.WithProperty("log_analytics_workspace_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

}
