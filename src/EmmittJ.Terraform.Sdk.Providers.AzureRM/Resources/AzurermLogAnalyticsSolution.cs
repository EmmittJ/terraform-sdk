using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_log_analytics_solution resource.
/// </summary>
public class AzurermLogAnalyticsSolution : TerraformResource
{
    public AzurermLogAnalyticsSolution(string name) : base("azurerm_log_analytics_solution", name)
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
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The solution_name attribute.
    /// </summary>
    public string? SolutionName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("solution_name")?.Value;
        set => this.WithProperty("solution_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The workspace_name attribute.
    /// </summary>
    public string? WorkspaceName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("workspace_name")?.Value;
        set => this.WithProperty("workspace_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The workspace_resource_id attribute.
    /// </summary>
    public string? WorkspaceResourceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("workspace_resource_id")?.Value;
        set => this.WithProperty("workspace_resource_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
