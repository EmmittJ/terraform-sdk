using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermConsumptionBudgetSubscriptionDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

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
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The subscription_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubscriptionId is required")]
    public required TerraformProperty<string> SubscriptionId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("subscription_id");
        set => this.WithProperty("subscription_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermConsumptionBudgetSubscriptionDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermConsumptionBudgetSubscriptionDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
