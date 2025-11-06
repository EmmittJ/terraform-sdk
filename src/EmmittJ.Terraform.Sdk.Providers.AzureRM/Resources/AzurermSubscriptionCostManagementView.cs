using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_subscription_cost_management_view resource.
/// </summary>
public class AzurermSubscriptionCostManagementView : TerraformResource
{
    public AzurermSubscriptionCostManagementView(string name) : base("azurerm_subscription_cost_management_view", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The accumulated attribute.
    /// </summary>
    public bool? Accumulated
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("accumulated")?.Value;
        set => this.WithProperty("accumulated", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The chart_type attribute.
    /// </summary>
    public string? ChartType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("chart_type")?.Value;
        set => this.WithProperty("chart_type", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The report_type attribute.
    /// </summary>
    public string? ReportType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("report_type")?.Value;
        set => this.WithProperty("report_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The subscription_id attribute.
    /// </summary>
    public string? SubscriptionId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("subscription_id")?.Value;
        set => this.WithProperty("subscription_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The timeframe attribute.
    /// </summary>
    public string? Timeframe
    {
        get => GetProperty<TerraformLiteralProperty<string>>("timeframe")?.Value;
        set => this.WithProperty("timeframe", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
