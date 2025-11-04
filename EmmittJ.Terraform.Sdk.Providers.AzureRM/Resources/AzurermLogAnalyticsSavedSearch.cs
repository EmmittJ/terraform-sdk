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
    public string? Category
    {
        get => GetProperty<TerraformLiteralProperty<string>>("category")?.Value;
        set => this.WithProperty("category", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The function_alias attribute.
    /// </summary>
    public string? FunctionAlias
    {
        get => GetProperty<TerraformLiteralProperty<string>>("function_alias")?.Value;
        set => this.WithProperty("function_alias", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The function_parameters attribute.
    /// </summary>
    public List<string>? FunctionParameters
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("function_parameters")?.Value;
        set => this.WithProperty("function_parameters", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
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
    /// The log_analytics_workspace_id attribute.
    /// </summary>
    public string? LogAnalyticsWorkspaceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("log_analytics_workspace_id")?.Value;
        set => this.WithProperty("log_analytics_workspace_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The query attribute.
    /// </summary>
    public string? Query
    {
        get => GetProperty<TerraformLiteralProperty<string>>("query")?.Value;
        set => this.WithProperty("query", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

}
