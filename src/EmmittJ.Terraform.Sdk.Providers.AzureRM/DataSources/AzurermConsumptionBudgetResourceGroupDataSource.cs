using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_consumption_budget_resource_group.
/// </summary>
public class AzurermConsumptionBudgetResourceGroupDataSource : TerraformDataSource
{
    public AzurermConsumptionBudgetResourceGroupDataSource(string name) : base("azurerm_consumption_budget_resource_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("amount");
        this.DeclareOutput("filter");
        this.DeclareOutput("notification");
        this.DeclareOutput("time_grain");
        this.DeclareOutput("time_period");
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
    /// The resource_group_id attribute.
    /// </summary>
    public string? ResourceGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_id")?.Value;
        set => this.WithProperty("resource_group_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The amount attribute.
    /// </summary>
    public TerraformExpression Amount => this["amount"];

    /// <summary>
    /// The filter attribute.
    /// </summary>
    public TerraformExpression Filter => this["filter"];

    /// <summary>
    /// The notification attribute.
    /// </summary>
    public TerraformExpression Notification => this["notification"];

    /// <summary>
    /// The time_grain attribute.
    /// </summary>
    public TerraformExpression TimeGrain => this["time_grain"];

    /// <summary>
    /// The time_period attribute.
    /// </summary>
    public TerraformExpression TimePeriod => this["time_period"];

}
