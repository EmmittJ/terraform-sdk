using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for filter in .
/// Nesting mode: list
/// </summary>
public class AzurermConsumptionBudgetSubscriptionFilterBlock : TerraformBlock
{
}

/// <summary>
/// Block type for notification in .
/// Nesting mode: set
/// </summary>
public class AzurermConsumptionBudgetSubscriptionNotificationBlock : TerraformBlock
{
    /// <summary>
    /// The contact_emails attribute.
    /// </summary>
    public List<TerraformProperty<string>>? ContactEmails
    {
        set => SetProperty("contact_emails", value);
    }

    /// <summary>
    /// The contact_groups attribute.
    /// </summary>
    public List<TerraformProperty<string>>? ContactGroups
    {
        set => SetProperty("contact_groups", value);
    }

    /// <summary>
    /// The contact_roles attribute.
    /// </summary>
    public List<TerraformProperty<string>>? ContactRoles
    {
        set => SetProperty("contact_roles", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Operator is required")]
    public required TerraformProperty<string> Operator
    {
        set => SetProperty("operator", value);
    }

    /// <summary>
    /// The threshold attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Threshold is required")]
    public required TerraformProperty<double> Threshold
    {
        set => SetProperty("threshold", value);
    }

    /// <summary>
    /// The threshold_type attribute.
    /// </summary>
    public TerraformProperty<string>? ThresholdType
    {
        set => SetProperty("threshold_type", value);
    }

}

/// <summary>
/// Block type for time_period in .
/// Nesting mode: list
/// </summary>
public class AzurermConsumptionBudgetSubscriptionTimePeriodBlock : TerraformBlock
{
    /// <summary>
    /// The end_date attribute.
    /// </summary>
    public TerraformProperty<string>? EndDate
    {
        set => SetProperty("end_date", value);
    }

    /// <summary>
    /// The start_date attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartDate is required")]
    public required TerraformProperty<string> StartDate
    {
        set => SetProperty("start_date", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermConsumptionBudgetSubscriptionTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_consumption_budget_subscription resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermConsumptionBudgetSubscription : TerraformResource
{
    public AzurermConsumptionBudgetSubscription(string name) : base("azurerm_consumption_budget_subscription", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("amount");
        SetOutput("etag");
        SetOutput("id");
        SetOutput("name");
        SetOutput("subscription_id");
        SetOutput("time_grain");
    }

    /// <summary>
    /// The amount attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Amount is required")]
    public required TerraformProperty<double> Amount
    {
        get => GetRequiredOutput<TerraformProperty<double>>("amount");
        set => SetProperty("amount", value);
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformProperty<string> Etag
    {
        get => GetRequiredOutput<TerraformProperty<string>>("etag");
        set => SetProperty("etag", value);
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
    /// The time_grain attribute.
    /// </summary>
    public TerraformProperty<string> TimeGrain
    {
        get => GetRequiredOutput<TerraformProperty<string>>("time_grain");
        set => SetProperty("time_grain", value);
    }

    /// <summary>
    /// Block for filter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Filter block(s) allowed")]
    public List<AzurermConsumptionBudgetSubscriptionFilterBlock>? Filter
    {
        set => SetProperty("filter", value);
    }

    /// <summary>
    /// Block for notification.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Notification is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Notification block(s) required")]
    public HashSet<AzurermConsumptionBudgetSubscriptionNotificationBlock>? Notification
    {
        set => SetProperty("notification", value);
    }

    /// <summary>
    /// Block for time_period.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimePeriod is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 TimePeriod block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TimePeriod block(s) allowed")]
    public List<AzurermConsumptionBudgetSubscriptionTimePeriodBlock>? TimePeriod
    {
        set => SetProperty("time_period", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermConsumptionBudgetSubscriptionTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
