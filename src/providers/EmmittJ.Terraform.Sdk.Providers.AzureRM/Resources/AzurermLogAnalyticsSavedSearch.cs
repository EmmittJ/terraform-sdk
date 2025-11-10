using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermLogAnalyticsSavedSearchTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_log_analytics_saved_search resource.
/// </summary>
public class AzurermLogAnalyticsSavedSearch : TerraformResource
{
    public AzurermLogAnalyticsSavedSearch(string name) : base("azurerm_log_analytics_saved_search", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("category");
        SetOutput("display_name");
        SetOutput("function_alias");
        SetOutput("function_parameters");
        SetOutput("id");
        SetOutput("log_analytics_workspace_id");
        SetOutput("name");
        SetOutput("query");
        SetOutput("tags");
    }

    /// <summary>
    /// The category attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Category is required")]
    public required TerraformProperty<string> Category
    {
        get => GetRequiredOutput<TerraformProperty<string>>("category");
        set => SetProperty("category", value);
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
    /// The function_alias attribute.
    /// </summary>
    public TerraformProperty<string> FunctionAlias
    {
        get => GetRequiredOutput<TerraformProperty<string>>("function_alias");
        set => SetProperty("function_alias", value);
    }

    /// <summary>
    /// The function_parameters attribute.
    /// </summary>
    public List<TerraformProperty<string>> FunctionParameters
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("function_parameters");
        set => SetProperty("function_parameters", value);
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
    /// The query attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Query is required")]
    public required TerraformProperty<string> Query
    {
        get => GetRequiredOutput<TerraformProperty<string>>("query");
        set => SetProperty("query", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermLogAnalyticsSavedSearchTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
