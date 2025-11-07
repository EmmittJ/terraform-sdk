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
    public TerraformProperty<string>? DefaultDuration
    {
        get => GetProperty<TerraformProperty<string>>("default_duration");
        set => this.WithProperty("default_duration", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
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
    /// The item_search_key attribute.
    /// </summary>
    public TerraformProperty<string>? ItemSearchKey
    {
        get => GetProperty<TerraformProperty<string>>("item_search_key");
        set => this.WithProperty("item_search_key", value);
    }

    /// <summary>
    /// The labels attribute.
    /// </summary>
    public TerraformProperty<List<string>>? Labels
    {
        get => GetProperty<TerraformProperty<List<string>>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// The log_analytics_workspace_id attribute.
    /// </summary>
    public TerraformProperty<string>? LogAnalyticsWorkspaceId
    {
        get => GetProperty<TerraformProperty<string>>("log_analytics_workspace_id");
        set => this.WithProperty("log_analytics_workspace_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

}
