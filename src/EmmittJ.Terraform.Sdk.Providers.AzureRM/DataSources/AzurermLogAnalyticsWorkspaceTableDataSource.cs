using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_log_analytics_workspace_table.
/// </summary>
public class AzurermLogAnalyticsWorkspaceTableDataSource : TerraformDataSource
{
    public AzurermLogAnalyticsWorkspaceTableDataSource(string name) : base("azurerm_log_analytics_workspace_table", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("plan");
        this.DeclareOutput("retention_in_days");
        this.DeclareOutput("total_retention_in_days");
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    public TerraformProperty<string>? WorkspaceId
    {
        get => GetProperty<TerraformProperty<string>>("workspace_id");
        set => this.WithProperty("workspace_id", value);
    }

    /// <summary>
    /// The plan attribute.
    /// </summary>
    public TerraformExpression Plan => this["plan"];

    /// <summary>
    /// The retention_in_days attribute.
    /// </summary>
    public TerraformExpression RetentionInDays => this["retention_in_days"];

    /// <summary>
    /// The total_retention_in_days attribute.
    /// </summary>
    public TerraformExpression TotalRetentionInDays => this["total_retention_in_days"];

}
