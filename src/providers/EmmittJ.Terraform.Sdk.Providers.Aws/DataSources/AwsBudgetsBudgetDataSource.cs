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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AccountId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "account_id");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    [TerraformPropertyName("name_prefix")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? NamePrefix { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The auto_adjust_data attribute.
    /// </summary>
    [TerraformPropertyName("auto_adjust_data")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> AutoAdjustData => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "auto_adjust_data");

    /// <summary>
    /// The billing_view_arn attribute.
    /// </summary>
    [TerraformPropertyName("billing_view_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> BillingViewArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "billing_view_arn");

    /// <summary>
    /// The budget_exceeded attribute.
    /// </summary>
    [TerraformPropertyName("budget_exceeded")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> BudgetExceeded => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "budget_exceeded");

    /// <summary>
    /// The budget_limit attribute.
    /// </summary>
    [TerraformPropertyName("budget_limit")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> BudgetLimit => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "budget_limit");

    /// <summary>
    /// The budget_type attribute.
    /// </summary>
    [TerraformPropertyName("budget_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> BudgetType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "budget_type");

    /// <summary>
    /// The calculated_spend attribute.
    /// </summary>
    [TerraformPropertyName("calculated_spend")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> CalculatedSpend => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "calculated_spend");

    /// <summary>
    /// The cost_filter attribute.
    /// </summary>
    [TerraformPropertyName("cost_filter")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> CostFilter => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "cost_filter");

    /// <summary>
    /// The cost_types attribute.
    /// </summary>
    [TerraformPropertyName("cost_types")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> CostTypes => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "cost_types");

    /// <summary>
    /// The notification attribute.
    /// </summary>
    [TerraformPropertyName("notification")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> Notification => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "notification");

    /// <summary>
    /// The planned_limit attribute.
    /// </summary>
    [TerraformPropertyName("planned_limit")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> PlannedLimit => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "planned_limit");

    /// <summary>
    /// The time_period_end attribute.
    /// </summary>
    [TerraformPropertyName("time_period_end")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TimePeriodEnd => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "time_period_end");

    /// <summary>
    /// The time_period_start attribute.
    /// </summary>
    [TerraformPropertyName("time_period_start")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TimePeriodStart => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "time_period_start");

    /// <summary>
    /// The time_unit attribute.
    /// </summary>
    [TerraformPropertyName("time_unit")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TimeUnit => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "time_unit");

}
