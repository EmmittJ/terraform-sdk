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
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The plan attribute.
    /// </summary>
    public string? Plan
    {
        get => GetProperty<TerraformLiteralProperty<string>>("plan")?.Value;
        set => this.WithProperty("plan", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The retention_in_days attribute.
    /// </summary>
    public double? RetentionInDays
    {
        get => GetProperty<TerraformLiteralProperty<double>>("retention_in_days")?.Value;
        set => this.WithProperty("retention_in_days", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The total_retention_in_days attribute.
    /// </summary>
    public double? TotalRetentionInDays
    {
        get => GetProperty<TerraformLiteralProperty<double>>("total_retention_in_days")?.Value;
        set => this.WithProperty("total_retention_in_days", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    public string? WorkspaceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("workspace_id")?.Value;
        set => this.WithProperty("workspace_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
