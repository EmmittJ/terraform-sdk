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
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The solution_name attribute.
    /// </summary>
    public TerraformProperty<string>? SolutionName
    {
        get => GetProperty<TerraformProperty<string>>("solution_name");
        set => this.WithProperty("solution_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The workspace_name attribute.
    /// </summary>
    public TerraformProperty<string>? WorkspaceName
    {
        get => GetProperty<TerraformProperty<string>>("workspace_name");
        set => this.WithProperty("workspace_name", value);
    }

    /// <summary>
    /// The workspace_resource_id attribute.
    /// </summary>
    public TerraformProperty<string>? WorkspaceResourceId
    {
        get => GetProperty<TerraformProperty<string>>("workspace_resource_id");
        set => this.WithProperty("workspace_resource_id", value);
    }

}
