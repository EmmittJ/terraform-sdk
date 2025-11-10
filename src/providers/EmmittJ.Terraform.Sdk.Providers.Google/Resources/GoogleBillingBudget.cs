using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for all_updates_rule in .
/// Nesting mode: list
/// </summary>
public class GoogleBillingBudgetAllUpdatesRuleBlock : ITerraformBlock
{
    /// <summary>
    /// Boolean. When set to true, disables default notifications sent
    /// when a threshold is exceeded. Default recipients are
    /// those with Billing Account Administrators and Billing
    /// Account Users IAM roles for the target account.
    /// </summary>
    [TerraformPropertyName("disable_default_iam_recipients")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DisableDefaultIamRecipients { get; set; }

    /// <summary>
    /// When set to true, and when the budget has a single project configured,
    /// notifications will be sent to project level recipients of that project.
    /// This field will be ignored if the budget has multiple or no project configured.
    /// 
    /// Currently, project level recipients are the users with Owner role on a cloud project.
    /// </summary>
    [TerraformPropertyName("enable_project_level_recipients")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableProjectLevelRecipients { get; set; }

    /// <summary>
    /// The full resource name of a monitoring notification
    /// channel in the form
    /// projects/{project_id}/notificationChannels/{channel_id}.
    /// A maximum of 5 channels are allowed.
    /// </summary>
    [TerraformPropertyName("monitoring_notification_channels")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? MonitoringNotificationChannels { get; set; }

    /// <summary>
    /// The name of the Cloud Pub/Sub topic where budget related
    /// messages will be published, in the form
    /// projects/{project_id}/topics/{topic_id}. Updates are sent
    /// at regular intervals to the topic.
    /// </summary>
    [TerraformPropertyName("pubsub_topic")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PubsubTopic { get; set; }

    /// <summary>
    /// The schema version of the notification. Only &amp;quot;1.0&amp;quot; is
    /// accepted. It represents the JSON schema as defined in
    /// https://cloud.google.com/billing/docs/how-to/budgets#notification_format.
    /// </summary>
    [TerraformPropertyName("schema_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SchemaVersion { get; set; }

}

/// <summary>
/// Block type for amount in .
/// Nesting mode: list
/// </summary>
public class GoogleBillingBudgetAmountBlock : ITerraformBlock
{
    /// <summary>
    /// Configures a budget amount that is automatically set to 100% of
    /// last period&#39;s spend.
    /// Boolean. Set value to true to use. Do not set to false, instead
    /// use the &#39;specified_amount&#39; block.
    /// </summary>
    [TerraformPropertyName("last_period_amount")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? LastPeriodAmount { get; set; }

}

/// <summary>
/// Block type for budget_filter in .
/// Nesting mode: list
/// </summary>
public class GoogleBillingBudgetBudgetFilterBlock : ITerraformBlock
{
    /// <summary>
    /// A CalendarPeriod represents the abstract concept of a recurring time period that has a
    /// canonical start. Grammatically, &amp;quot;the start of the current CalendarPeriod&amp;quot;.
    /// All calendar times begin at 12 AM US and Canadian Pacific Time (UTC-8).
    /// 
    /// Exactly one of &#39;calendar_period&#39;, &#39;custom_period&#39; must be provided. Possible values: [&amp;quot;MONTH&amp;quot;, &amp;quot;QUARTER&amp;quot;, &amp;quot;YEAR&amp;quot;, &amp;quot;CALENDAR_PERIOD_UNSPECIFIED&amp;quot;]
    /// </summary>
    [TerraformPropertyName("calendar_period")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CalendarPeriod { get; set; }

    /// <summary>
    /// Optional. If creditTypesTreatment is INCLUDE_SPECIFIED_CREDITS,
    /// this is a list of credit types to be subtracted from gross cost to determine the spend for threshold calculations. See a list of acceptable credit type values.
    /// If creditTypesTreatment is not INCLUDE_SPECIFIED_CREDITS, this field must be empty.
    /// </summary>
    [TerraformPropertyName("credit_types")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? CreditTypes { get; set; }

    /// <summary>
    /// Specifies how credits should be treated when determining spend
    /// for threshold calculations. Default value: &amp;quot;INCLUDE_ALL_CREDITS&amp;quot; Possible values: [&amp;quot;INCLUDE_ALL_CREDITS&amp;quot;, &amp;quot;EXCLUDE_ALL_CREDITS&amp;quot;, &amp;quot;INCLUDE_SPECIFIED_CREDITS&amp;quot;]
    /// </summary>
    [TerraformPropertyName("credit_types_treatment")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CreditTypesTreatment { get; set; }

    /// <summary>
    /// A single label and value pair specifying that usage from only
    /// this set of labeled resources should be included in the budget.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Labels { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>("", "labels");

    /// <summary>
    /// A set of projects of the form projects/{project_number},
    /// specifying that usage from only this set of projects should be
    /// included in the budget. If omitted, the report will include
    /// all usage for the billing account, regardless of which project
    /// the usage occurred on.
    /// </summary>
    [TerraformPropertyName("projects")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Projects { get; set; }

    /// <summary>
    /// A set of folder and organization names of the form folders/{folderId} or organizations/{organizationId},
    /// specifying that usage from only this set of folders and organizations should be included in the budget.
    /// If omitted, the budget includes all usage that the billing account pays for. If the folder or organization
    /// contains projects that are paid for by a different Cloud Billing account, the budget doesn&#39;t apply to those projects.
    /// </summary>
    [TerraformPropertyName("resource_ancestors")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? ResourceAncestors { get; set; }

    /// <summary>
    /// A set of services of the form services/{service_id},
    /// specifying that usage from only this set of services should be
    /// included in the budget. If omitted, the report will include
    /// usage for all the services. The service names are available
    /// through the Catalog API:
    /// https://cloud.google.com/billing/v1/how-tos/catalog-api.
    /// </summary>
    [TerraformPropertyName("services")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<List<TerraformProperty<string>>> Services { get; set; } = new TerraformReferenceProperty<List<TerraformProperty<string>>>("", "services");

    /// <summary>
    /// A set of subaccounts of the form billingAccounts/{account_id},
    /// specifying that usage from only this set of subaccounts should
    /// be included in the budget. If a subaccount is set to the name of
    /// the parent account, usage from the parent account will be included.
    /// If the field is omitted, the report will include usage from the parent
    /// account and all subaccounts, if they exist.
    /// </summary>
    [TerraformPropertyName("subaccounts")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? Subaccounts { get; set; }

}

/// <summary>
/// Block type for threshold_rules in .
/// Nesting mode: list
/// </summary>
public class GoogleBillingBudgetThresholdRulesBlock : ITerraformBlock
{
    /// <summary>
    /// The type of basis used to determine if spend has passed
    /// the threshold. Default value: &amp;quot;CURRENT_SPEND&amp;quot; Possible values: [&amp;quot;CURRENT_SPEND&amp;quot;, &amp;quot;FORECASTED_SPEND&amp;quot;]
    /// </summary>
    [TerraformPropertyName("spend_basis")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SpendBasis { get; set; }

    /// <summary>
    /// Send an alert when this threshold is exceeded. This is a
    /// 1.0-based percentage, so 0.5 = 50%. Must be &amp;gt;= 0.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ThresholdPercent is required")]
    [TerraformPropertyName("threshold_percent")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> ThresholdPercent { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleBillingBudgetTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a google_billing_budget resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleBillingBudget : TerraformResource
{
    public GoogleBillingBudget(string name) : base("google_billing_budget", name)
    {
    }

    /// <summary>
    /// ID of the billing account to set a budget on.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BillingAccount is required")]
    [TerraformPropertyName("billing_account")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> BillingAccount { get; set; }

    /// <summary>
    /// User data for display name in UI. Must be &amp;lt;= 60 chars.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The ownership scope of the budget. The ownership scope and users&#39;
    /// IAM permissions determine who has full access to the budget&#39;s data. Possible values: [&amp;quot;OWNERSHIP_SCOPE_UNSPECIFIED&amp;quot;, &amp;quot;ALL_USERS&amp;quot;, &amp;quot;BILLING_ACCOUNT&amp;quot;]
    /// </summary>
    [TerraformPropertyName("ownership_scope")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? OwnershipScope { get; set; }

    /// <summary>
    /// Block for all_updates_rule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AllUpdatesRule block(s) allowed")]
    [TerraformPropertyName("all_updates_rule")]
    public TerraformList<TerraformBlock<GoogleBillingBudgetAllUpdatesRuleBlock>>? AllUpdatesRule { get; set; } = new();

    /// <summary>
    /// Block for amount.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Amount is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Amount block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Amount block(s) allowed")]
    [TerraformPropertyName("amount")]
    public TerraformList<TerraformBlock<GoogleBillingBudgetAmountBlock>>? Amount { get; set; } = new();

    /// <summary>
    /// Block for budget_filter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BudgetFilter block(s) allowed")]
    [TerraformPropertyName("budget_filter")]
    public TerraformList<TerraformBlock<GoogleBillingBudgetBudgetFilterBlock>>? BudgetFilter { get; set; } = new();

    /// <summary>
    /// Block for threshold_rules.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("threshold_rules")]
    public TerraformList<TerraformBlock<GoogleBillingBudgetThresholdRulesBlock>>? ThresholdRules { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleBillingBudgetTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Resource name of the budget. The resource name
    /// implies the scope of a budget. Values are of the form
    /// billingAccounts/{billingAccountId}/budgets/{budgetId}.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

}
