using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSentinelWatchlistTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

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
        SetOutput("default_duration");
        SetOutput("description");
        SetOutput("display_name");
        SetOutput("id");
        SetOutput("item_search_key");
        SetOutput("labels");
        SetOutput("log_analytics_workspace_id");
        SetOutput("name");
    }

    /// <summary>
    /// The default_duration attribute.
    /// </summary>
    public TerraformProperty<string> DefaultDuration
    {
        get => GetRequiredOutput<TerraformProperty<string>>("default_duration");
        set => SetProperty("default_duration", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The item_search_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ItemSearchKey is required")]
    public required TerraformProperty<string> ItemSearchKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("item_search_key");
        set => SetProperty("item_search_key", value);
    }

    /// <summary>
    /// The labels attribute.
    /// </summary>
    public List<TerraformProperty<string>> Labels
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("labels");
        set => SetProperty("labels", value);
    }

    /// <summary>
    /// The log_analytics_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogAnalyticsWorkspaceId is required")]
    public required TerraformProperty<string> LogAnalyticsWorkspaceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("log_analytics_workspace_id");
        set => SetProperty("log_analytics_workspace_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSentinelWatchlistTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
