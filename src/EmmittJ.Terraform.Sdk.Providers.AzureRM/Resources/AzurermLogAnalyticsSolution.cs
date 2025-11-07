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
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The solution_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SolutionName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("solution_name");
        set => this.WithProperty("solution_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The workspace_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? WorkspaceName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("workspace_name");
        set => this.WithProperty("workspace_name", value);
    }

    /// <summary>
    /// The workspace_resource_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? WorkspaceResourceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("workspace_resource_id");
        set => this.WithProperty("workspace_resource_id", value);
    }

}
