using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_resource_group_cost_management_view resource.
/// </summary>
public class AzurermResourceGroupCostManagementView : TerraformResource
{
    public AzurermResourceGroupCostManagementView(string name) : base("azurerm_resource_group_cost_management_view", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The accumulated attribute.
    /// </summary>
    public TerraformProperty<bool>? Accumulated
    {
        get => GetProperty<TerraformProperty<bool>>("accumulated");
        set => this.WithProperty("accumulated", value);
    }

    /// <summary>
    /// The chart_type attribute.
    /// </summary>
    public TerraformProperty<string>? ChartType
    {
        get => GetProperty<TerraformProperty<string>>("chart_type");
        set => this.WithProperty("chart_type", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
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
    /// The report_type attribute.
    /// </summary>
    public TerraformProperty<string>? ReportType
    {
        get => GetProperty<TerraformProperty<string>>("report_type");
        set => this.WithProperty("report_type", value);
    }

    /// <summary>
    /// The resource_group_id attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupId
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_id");
        set => this.WithProperty("resource_group_id", value);
    }

    /// <summary>
    /// The timeframe attribute.
    /// </summary>
    public TerraformProperty<string>? Timeframe
    {
        get => GetProperty<TerraformProperty<string>>("timeframe");
        set => this.WithProperty("timeframe", value);
    }

}
