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
        set => SetProperty("read", value);
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
        SetOutput("amount");
        SetOutput("filter");
        SetOutput("notification");
        SetOutput("time_grain");
        SetOutput("time_period");
        SetOutput("id");
        SetOutput("name");
        SetOutput("subscription_id");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The subscription_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubscriptionId is required")]
    public required TerraformProperty<string> SubscriptionId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("subscription_id");
        set => SetProperty("subscription_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermConsumptionBudgetSubscriptionDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
