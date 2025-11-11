using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_budgets_budget.
/// </summary>
public partial class AwsBudgetsBudgetDataSource : TerraformDataSource
{
    public AwsBudgetsBudgetDataSource(string name) : base("aws_budgets_budget", name)
    {
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    [TerraformProperty("account_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> AccountId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    [TerraformProperty("name_prefix")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? NamePrefix { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The auto_adjust_data attribute.
    /// </summary>
    [TerraformProperty("auto_adjust_data")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> AutoAdjustData { get; }

    /// <summary>
    /// The billing_view_arn attribute.
    /// </summary>
    [TerraformProperty("billing_view_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> BillingViewArn { get; }

    /// <summary>
    /// The budget_exceeded attribute.
    /// </summary>
    [TerraformProperty("budget_exceeded")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> BudgetExceeded { get; }

    /// <summary>
    /// The budget_limit attribute.
    /// </summary>
    [TerraformProperty("budget_limit")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> BudgetLimit { get; }

    /// <summary>
    /// The budget_type attribute.
    /// </summary>
    [TerraformProperty("budget_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> BudgetType { get; }

    /// <summary>
    /// The calculated_spend attribute.
    /// </summary>
    [TerraformProperty("calculated_spend")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> CalculatedSpend { get; }

    /// <summary>
    /// The cost_filter attribute.
    /// </summary>
    [TerraformProperty("cost_filter")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<object> CostFilter { get; }

    /// <summary>
    /// The cost_types attribute.
    /// </summary>
    [TerraformProperty("cost_types")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> CostTypes { get; }

    /// <summary>
    /// The notification attribute.
    /// </summary>
    [TerraformProperty("notification")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<object> Notification { get; }

    /// <summary>
    /// The planned_limit attribute.
    /// </summary>
    [TerraformProperty("planned_limit")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<object> PlannedLimit { get; }

    /// <summary>
    /// The time_period_end attribute.
    /// </summary>
    [TerraformProperty("time_period_end")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> TimePeriodEnd { get; }

    /// <summary>
    /// The time_period_start attribute.
    /// </summary>
    [TerraformProperty("time_period_start")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> TimePeriodStart { get; }

    /// <summary>
    /// The time_unit attribute.
    /// </summary>
    [TerraformProperty("time_unit")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> TimeUnit { get; }

}
