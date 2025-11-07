using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
    }

    /// <summary>
    /// The category attribute.
    /// </summary>
    public TerraformProperty<string>? Category
    {
        get => GetProperty<TerraformProperty<string>>("category");
        set => this.WithProperty("category", value);
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
    /// The function_alias attribute.
    /// </summary>
    public TerraformProperty<string>? FunctionAlias
    {
        get => GetProperty<TerraformProperty<string>>("function_alias");
        set => this.WithProperty("function_alias", value);
    }

    /// <summary>
    /// The function_parameters attribute.
    /// </summary>
    public TerraformProperty<List<string>>? FunctionParameters
    {
        get => GetProperty<TerraformProperty<List<string>>>("function_parameters");
        set => this.WithProperty("function_parameters", value);
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

    /// <summary>
    /// The query attribute.
    /// </summary>
    public TerraformProperty<string>? Query
    {
        get => GetProperty<TerraformProperty<string>>("query");
        set => this.WithProperty("query", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

}
