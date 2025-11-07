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
    public TerraformLiteralProperty<bool>? Accumulated
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("accumulated");
        set => this.WithProperty("accumulated", value);
    }

    /// <summary>
    /// The chart_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ChartType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("chart_type");
        set => this.WithProperty("chart_type", value);
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
    /// The report_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ReportType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("report_type");
        set => this.WithProperty("report_type", value);
    }

    /// <summary>
    /// The subscription_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SubscriptionId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("subscription_id");
        set => this.WithProperty("subscription_id", value);
    }

    /// <summary>
    /// The timeframe attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Timeframe
    {
        get => GetProperty<TerraformLiteralProperty<string>>("timeframe");
        set => this.WithProperty("timeframe", value);
    }

}
