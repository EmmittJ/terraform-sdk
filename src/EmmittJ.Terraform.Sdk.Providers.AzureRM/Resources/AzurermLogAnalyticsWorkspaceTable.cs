using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_log_analytics_workspace_table resource.
/// </summary>
public class AzurermLogAnalyticsWorkspaceTable : TerraformResource
{
    public AzurermLogAnalyticsWorkspaceTable(string name) : base("azurerm_log_analytics_workspace_table", name)
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
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The plan attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Plan
    {
        get => GetProperty<TerraformLiteralProperty<string>>("plan");
        set => this.WithProperty("plan", value);
    }

    /// <summary>
    /// The retention_in_days attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? RetentionInDays
    {
        get => GetProperty<TerraformLiteralProperty<double>>("retention_in_days");
        set => this.WithProperty("retention_in_days", value);
    }

    /// <summary>
    /// The total_retention_in_days attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? TotalRetentionInDays
    {
        get => GetProperty<TerraformLiteralProperty<double>>("total_retention_in_days");
        set => this.WithProperty("total_retention_in_days", value);
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? WorkspaceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("workspace_id");
        set => this.WithProperty("workspace_id", value);
    }

}
