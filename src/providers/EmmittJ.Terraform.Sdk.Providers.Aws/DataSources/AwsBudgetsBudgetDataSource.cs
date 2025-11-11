using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_budgets_budget.
/// </summary>
public class AwsBudgetsBudgetDataSource : TerraformDataSource
{
    public AwsBudgetsBudgetDataSource(string name) : base("aws_budgets_budget", name)
    {
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    [TerraformPropertyName("account_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> AccountId { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    [TerraformPropertyName("name_prefix")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? NamePrefix { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Tags { get; set; } = default!;

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The auto_adjust_data attribute.
    /// </summary>
    [TerraformPropertyName("auto_adjust_data")]
    // Output-only attribute - read-only reference
    public TerraformList<object> AutoAdjustData => new TerraformReference(this, "auto_adjust_data");

    /// <summary>
    /// The billing_view_arn attribute.
    /// </summary>
    [TerraformPropertyName("billing_view_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> BillingViewArn => new TerraformReference(this, "billing_view_arn");

    /// <summary>
    /// The budget_exceeded attribute.
    /// </summary>
    [TerraformPropertyName("budget_exceeded")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> BudgetExceeded => new TerraformReference(this, "budget_exceeded");

    /// <summary>
    /// The budget_limit attribute.
    /// </summary>
    [TerraformPropertyName("budget_limit")]
    // Output-only attribute - read-only reference
    public TerraformList<object> BudgetLimit => new TerraformReference(this, "budget_limit");

    /// <summary>
    /// The budget_type attribute.
    /// </summary>
    [TerraformPropertyName("budget_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> BudgetType => new TerraformReference(this, "budget_type");

    /// <summary>
    /// The calculated_spend attribute.
    /// </summary>
    [TerraformPropertyName("calculated_spend")]
    // Output-only attribute - read-only reference
    public TerraformList<object> CalculatedSpend => new TerraformReference(this, "calculated_spend");

    /// <summary>
    /// The cost_filter attribute.
    /// </summary>
    [TerraformPropertyName("cost_filter")]
    // Output-only attribute - read-only reference
    public TerraformSet<object> CostFilter => new TerraformReference(this, "cost_filter");

    /// <summary>
    /// The cost_types attribute.
    /// </summary>
    [TerraformPropertyName("cost_types")]
    // Output-only attribute - read-only reference
    public TerraformList<object> CostTypes => new TerraformReference(this, "cost_types");

    /// <summary>
    /// The notification attribute.
    /// </summary>
    [TerraformPropertyName("notification")]
    // Output-only attribute - read-only reference
    public TerraformSet<object> Notification => new TerraformReference(this, "notification");

    /// <summary>
    /// The planned_limit attribute.
    /// </summary>
    [TerraformPropertyName("planned_limit")]
    // Output-only attribute - read-only reference
    public TerraformSet<object> PlannedLimit => new TerraformReference(this, "planned_limit");

    /// <summary>
    /// The time_period_end attribute.
    /// </summary>
    [TerraformPropertyName("time_period_end")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TimePeriodEnd => new TerraformReference(this, "time_period_end");

    /// <summary>
    /// The time_period_start attribute.
    /// </summary>
    [TerraformPropertyName("time_period_start")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TimePeriodStart => new TerraformReference(this, "time_period_start");

    /// <summary>
    /// The time_unit attribute.
    /// </summary>
    [TerraformPropertyName("time_unit")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TimeUnit => new TerraformReference(this, "time_unit");

}
