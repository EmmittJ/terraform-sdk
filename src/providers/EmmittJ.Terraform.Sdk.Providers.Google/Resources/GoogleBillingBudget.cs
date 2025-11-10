using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for all_updates_rule in .
/// Nesting mode: list
/// </summary>
public class GoogleBillingBudgetAllUpdatesRuleBlock : TerraformBlock
{
    /// <summary>
    /// Boolean. When set to true, disables default notifications sent
    /// when a threshold is exceeded. Default recipients are
    /// those with Billing Account Administrators and Billing
    /// Account Users IAM roles for the target account.
    /// </summary>
    public TerraformProperty<bool>? DisableDefaultIamRecipients
    {
        get => GetProperty<TerraformProperty<bool>>("disable_default_iam_recipients");
        set => WithProperty("disable_default_iam_recipients", value);
    }

    /// <summary>
    /// When set to true, and when the budget has a single project configured,
    /// notifications will be sent to project level recipients of that project.
    /// This field will be ignored if the budget has multiple or no project configured.
    /// 
    /// Currently, project level recipients are the users with Owner role on a cloud project.
    /// </summary>
    public TerraformProperty<bool>? EnableProjectLevelRecipients
    {
        get => GetProperty<TerraformProperty<bool>>("enable_project_level_recipients");
        set => WithProperty("enable_project_level_recipients", value);
    }

    /// <summary>
    /// The full resource name of a monitoring notification
    /// channel in the form
    /// projects/{project_id}/notificationChannels/{channel_id}.
    /// A maximum of 5 channels are allowed.
    /// </summary>
    public List<TerraformProperty<string>>? MonitoringNotificationChannels
    {
        get => GetProperty<List<TerraformProperty<string>>>("monitoring_notification_channels");
        set => WithProperty("monitoring_notification_channels", value);
    }

    /// <summary>
    /// The name of the Cloud Pub/Sub topic where budget related
    /// messages will be published, in the form
    /// projects/{project_id}/topics/{topic_id}. Updates are sent
    /// at regular intervals to the topic.
    /// </summary>
    public TerraformProperty<string>? PubsubTopic
    {
        get => GetProperty<TerraformProperty<string>>("pubsub_topic");
        set => WithProperty("pubsub_topic", value);
    }

    /// <summary>
    /// The schema version of the notification. Only &amp;quot;1.0&amp;quot; is
    /// accepted. It represents the JSON schema as defined in
    /// https://cloud.google.com/billing/docs/how-to/budgets#notification_format.
    /// </summary>
    public TerraformProperty<string>? SchemaVersion
    {
        get => GetProperty<TerraformProperty<string>>("schema_version");
        set => WithProperty("schema_version", value);
    }

}

/// <summary>
/// Block type for amount in .
/// Nesting mode: list
/// </summary>
public class GoogleBillingBudgetAmountBlock : TerraformBlock
{
    /// <summary>
    /// Configures a budget amount that is automatically set to 100% of
    /// last period&#39;s spend.
    /// Boolean. Set value to true to use. Do not set to false, instead
    /// use the &#39;specified_amount&#39; block.
    /// </summary>
    public TerraformProperty<bool>? LastPeriodAmount
    {
        get => GetProperty<TerraformProperty<bool>>("last_period_amount");
        set => WithProperty("last_period_amount", value);
    }

}

/// <summary>
/// Block type for budget_filter in .
/// Nesting mode: list
/// </summary>
public class GoogleBillingBudgetBudgetFilterBlock : TerraformBlock
{
    /// <summary>
    /// A CalendarPeriod represents the abstract concept of a recurring time period that has a
    /// canonical start. Grammatically, &amp;quot;the start of the current CalendarPeriod&amp;quot;.
    /// All calendar times begin at 12 AM US and Canadian Pacific Time (UTC-8).
    /// 
    /// Exactly one of &#39;calendar_period&#39;, &#39;custom_period&#39; must be provided. Possible values: [&amp;quot;MONTH&amp;quot;, &amp;quot;QUARTER&amp;quot;, &amp;quot;YEAR&amp;quot;, &amp;quot;CALENDAR_PERIOD_UNSPECIFIED&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? CalendarPeriod
    {
        get => GetProperty<TerraformProperty<string>>("calendar_period");
        set => WithProperty("calendar_period", value);
    }

    /// <summary>
    /// Optional. If creditTypesTreatment is INCLUDE_SPECIFIED_CREDITS,
    /// this is a list of credit types to be subtracted from gross cost to determine the spend for threshold calculations. See a list of acceptable credit type values.
    /// If creditTypesTreatment is not INCLUDE_SPECIFIED_CREDITS, this field must be empty.
    /// </summary>
    public List<TerraformProperty<string>>? CreditTypes
    {
        get => GetProperty<List<TerraformProperty<string>>>("credit_types");
        set => WithProperty("credit_types", value);
    }

    /// <summary>
    /// Specifies how credits should be treated when determining spend
    /// for threshold calculations. Default value: &amp;quot;INCLUDE_ALL_CREDITS&amp;quot; Possible values: [&amp;quot;INCLUDE_ALL_CREDITS&amp;quot;, &amp;quot;EXCLUDE_ALL_CREDITS&amp;quot;, &amp;quot;INCLUDE_SPECIFIED_CREDITS&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? CreditTypesTreatment
    {
        get => GetProperty<TerraformProperty<string>>("credit_types_treatment");
        set => WithProperty("credit_types_treatment", value);
    }

    /// <summary>
    /// A single label and value pair specifying that usage from only
    /// this set of labeled resources should be included in the budget.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Labels
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("labels");
        set => WithProperty("labels", value);
    }

    /// <summary>
    /// A set of projects of the form projects/{project_number},
    /// specifying that usage from only this set of projects should be
    /// included in the budget. If omitted, the report will include
    /// all usage for the billing account, regardless of which project
    /// the usage occurred on.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Projects
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("projects");
        set => WithProperty("projects", value);
    }

    /// <summary>
    /// A set of folder and organization names of the form folders/{folderId} or organizations/{organizationId},
    /// specifying that usage from only this set of folders and organizations should be included in the budget.
    /// If omitted, the budget includes all usage that the billing account pays for. If the folder or organization
    /// contains projects that are paid for by a different Cloud Billing account, the budget doesn&#39;t apply to those projects.
    /// </summary>
    public HashSet<TerraformProperty<string>>? ResourceAncestors
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("resource_ancestors");
        set => WithProperty("resource_ancestors", value);
    }

    /// <summary>
    /// A set of services of the form services/{service_id},
    /// specifying that usage from only this set of services should be
    /// included in the budget. If omitted, the report will include
    /// usage for all the services. The service names are available
    /// through the Catalog API:
    /// https://cloud.google.com/billing/v1/how-tos/catalog-api.
    /// </summary>
    public List<TerraformProperty<string>>? Services
    {
        get => GetProperty<List<TerraformProperty<string>>>("services");
        set => WithProperty("services", value);
    }

    /// <summary>
    /// A set of subaccounts of the form billingAccounts/{account_id},
    /// specifying that usage from only this set of subaccounts should
    /// be included in the budget. If a subaccount is set to the name of
    /// the parent account, usage from the parent account will be included.
    /// If the field is omitted, the report will include usage from the parent
    /// account and all subaccounts, if they exist.
    /// </summary>
    public List<TerraformProperty<string>>? Subaccounts
    {
        get => GetProperty<List<TerraformProperty<string>>>("subaccounts");
        set => WithProperty("subaccounts", value);
    }

}

/// <summary>
/// Block type for threshold_rules in .
/// Nesting mode: list
/// </summary>
public class GoogleBillingBudgetThresholdRulesBlock : TerraformBlock
{
    /// <summary>
    /// The type of basis used to determine if spend has passed
    /// the threshold. Default value: &amp;quot;CURRENT_SPEND&amp;quot; Possible values: [&amp;quot;CURRENT_SPEND&amp;quot;, &amp;quot;FORECASTED_SPEND&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? SpendBasis
    {
        get => GetProperty<TerraformProperty<string>>("spend_basis");
        set => WithProperty("spend_basis", value);
    }

    /// <summary>
    /// Send an alert when this threshold is exceeded. This is a
    /// 1.0-based percentage, so 0.5 = 50%. Must be &amp;gt;= 0.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ThresholdPercent is required")]
    public required TerraformProperty<double> ThresholdPercent
    {
        get => GetRequiredProperty<TerraformProperty<double>>("threshold_percent");
        set => WithProperty("threshold_percent", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleBillingBudgetTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a google_billing_budget resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleBillingBudget : TerraformResource
{
    public GoogleBillingBudget(string name) : base("google_billing_budget", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("name");
    }

    /// <summary>
    /// ID of the billing account to set a budget on.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BillingAccount is required")]
    public required TerraformProperty<string> BillingAccount
    {
        get => GetRequiredProperty<TerraformProperty<string>>("billing_account");
        set => this.WithProperty("billing_account", value);
    }

    /// <summary>
    /// User data for display name in UI. Must be &amp;lt;= 60 chars.
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
    /// The ownership scope of the budget. The ownership scope and users&#39;
    /// IAM permissions determine who has full access to the budget&#39;s data. Possible values: [&amp;quot;OWNERSHIP_SCOPE_UNSPECIFIED&amp;quot;, &amp;quot;ALL_USERS&amp;quot;, &amp;quot;BILLING_ACCOUNT&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? OwnershipScope
    {
        get => GetProperty<TerraformProperty<string>>("ownership_scope");
        set => this.WithProperty("ownership_scope", value);
    }

    /// <summary>
    /// Block for all_updates_rule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AllUpdatesRule block(s) allowed")]
    public List<GoogleBillingBudgetAllUpdatesRuleBlock>? AllUpdatesRule
    {
        get => GetProperty<List<GoogleBillingBudgetAllUpdatesRuleBlock>>("all_updates_rule");
        set => this.WithProperty("all_updates_rule", value);
    }

    /// <summary>
    /// Block for amount.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Amount block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Amount block(s) allowed")]
    public List<GoogleBillingBudgetAmountBlock>? Amount
    {
        get => GetProperty<List<GoogleBillingBudgetAmountBlock>>("amount");
        set => this.WithProperty("amount", value);
    }

    /// <summary>
    /// Block for budget_filter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BudgetFilter block(s) allowed")]
    public List<GoogleBillingBudgetBudgetFilterBlock>? BudgetFilter
    {
        get => GetProperty<List<GoogleBillingBudgetBudgetFilterBlock>>("budget_filter");
        set => this.WithProperty("budget_filter", value);
    }

    /// <summary>
    /// Block for threshold_rules.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleBillingBudgetThresholdRulesBlock>? ThresholdRules
    {
        get => GetProperty<List<GoogleBillingBudgetThresholdRulesBlock>>("threshold_rules");
        set => this.WithProperty("threshold_rules", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleBillingBudgetTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleBillingBudgetTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Resource name of the budget. The resource name
    /// implies the scope of a budget. Values are of the form
    /// billingAccounts/{billingAccountId}/budgets/{budgetId}.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
