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
    public TerraformLiteralProperty<string>? Category
    {
        get => GetProperty<TerraformLiteralProperty<string>>("category");
        set => this.WithProperty("category", value);
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
    /// The function_alias attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? FunctionAlias
    {
        get => GetProperty<TerraformLiteralProperty<string>>("function_alias");
        set => this.WithProperty("function_alias", value);
    }

    /// <summary>
    /// The function_parameters attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? FunctionParameters
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("function_parameters");
        set => this.WithProperty("function_parameters", value);
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

    /// <summary>
    /// The query attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Query
    {
        get => GetProperty<TerraformLiteralProperty<string>>("query");
        set => this.WithProperty("query", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

}
