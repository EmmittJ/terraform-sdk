using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_consumption_budget_subscription.
/// </summary>
public class AzurermConsumptionBudgetSubscriptionDataSource : TerraformDataSource
{
    public AzurermConsumptionBudgetSubscriptionDataSource(string name) : base("azurerm_consumption_budget_subscription", name)
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
    /// The subscription_id attribute.
    /// </summary>
    public string? SubscriptionId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("subscription_id")?.Value;
        set => this.WithProperty("subscription_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
