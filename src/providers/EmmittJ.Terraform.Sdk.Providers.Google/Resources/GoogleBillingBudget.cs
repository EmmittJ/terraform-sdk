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
        set => SetProperty("disable_default_iam_recipients", value);
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
        set => SetProperty("enable_project_level_recipients", value);
    }

    /// <summary>
    /// The full resource name of a monitoring notification
    /// channel in the form
    /// projects/{project_id}/notificationChannels/{channel_id}.
    /// A maximum of 5 channels are allowed.
    /// </summary>
    public List<TerraformProperty<string>>? MonitoringNotificationChannels
    {
        set => SetProperty("monitoring_notification_channels", value);
    }

    /// <summary>
    /// The name of the Cloud Pub/Sub topic where budget related
    /// messages will be published, in the form
    /// projects/{project_id}/topics/{topic_id}. Updates are sent
    /// at regular intervals to the topic.
    /// </summary>
    public TerraformProperty<string>? PubsubTopic
    {
        set => SetProperty("pubsub_topic", value);
    }

    /// <summary>
    /// The schema version of the notification. Only &amp;quot;1.0&amp;quot; is
    /// accepted. It represents the JSON schema as defined in
    /// https://cloud.google.com/billing/docs/how-to/budgets#notification_format.
    /// </summary>
    public TerraformProperty<string>? SchemaVersion
    {
        set => SetProperty("schema_version", value);
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
        set => SetProperty("last_period_amount", value);
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
        set => SetProperty("calendar_period", value);
    }

    /// <summary>
    /// Optional. If creditTypesTreatment is INCLUDE_SPECIFIED_CREDITS,
    /// this is a list of credit types to be subtracted from gross cost to determine the spend for threshold calculations. See a list of acceptable credit type values.
    /// If creditTypesTreatment is not INCLUDE_SPECIFIED_CREDITS, this field must be empty.
    /// </summary>
    public List<TerraformProperty<string>>? CreditTypes
    {
        set => SetProperty("credit_types", value);
    }

    /// <summary>
    /// Specifies how credits should be treated when determining spend
    /// for threshold calculations. Default value: &amp;quot;INCLUDE_ALL_CREDITS&amp;quot; Possible values: [&amp;quot;INCLUDE_ALL_CREDITS&amp;quot;, &amp;quot;EXCLUDE_ALL_CREDITS&amp;quot;, &amp;quot;INCLUDE_SPECIFIED_CREDITS&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? CreditTypesTreatment
    {
        set => SetProperty("credit_types_treatment", value);
    }

    /// <summary>
    /// A single label and value pair specifying that usage from only
    /// this set of labeled resources should be included in the budget.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Labels
    {
        set => SetProperty("labels", value);
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
        set => SetProperty("projects", value);
    }

    /// <summary>
    /// A set of folder and organization names of the form folders/{folderId} or organizations/{organizationId},
    /// specifying that usage from only this set of folders and organizations should be included in the budget.
    /// If omitted, the budget includes all usage that the billing account pays for. If the folder or organization
    /// contains projects that are paid for by a different Cloud Billing account, the budget doesn&#39;t apply to those projects.
    /// </summary>
    public HashSet<TerraformProperty<string>>? ResourceAncestors
    {
        set => SetProperty("resource_ancestors", value);
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
        set => SetProperty("services", value);
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
        set => SetProperty("subaccounts", value);
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
        set => SetProperty("spend_basis", value);
    }

    /// <summary>
    /// Send an alert when this threshold is exceeded. This is a
    /// 1.0-based percentage, so 0.5 = 50%. Must be &amp;gt;= 0.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ThresholdPercent is required")]
    public required TerraformProperty<double> ThresholdPercent
    {
        set => SetProperty("threshold_percent", value);
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
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("name");
        SetOutput("billing_account");
        SetOutput("display_name");
        SetOutput("id");
        SetOutput("ownership_scope");
    }

    /// <summary>
    /// ID of the billing account to set a budget on.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BillingAccount is required")]
    public required TerraformProperty<string> BillingAccount
    {
        get => GetRequiredOutput<TerraformProperty<string>>("billing_account");
        set => SetProperty("billing_account", value);
    }

    /// <summary>
    /// User data for display name in UI. Must be &amp;lt;= 60 chars.
    /// </summary>
    public TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
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
    /// The ownership scope of the budget. The ownership scope and users&#39;
    /// IAM permissions determine who has full access to the budget&#39;s data. Possible values: [&amp;quot;OWNERSHIP_SCOPE_UNSPECIFIED&amp;quot;, &amp;quot;ALL_USERS&amp;quot;, &amp;quot;BILLING_ACCOUNT&amp;quot;]
    /// </summary>
    public TerraformProperty<string> OwnershipScope
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ownership_scope");
        set => SetProperty("ownership_scope", value);
    }

    /// <summary>
    /// Block for all_updates_rule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AllUpdatesRule block(s) allowed")]
    public List<GoogleBillingBudgetAllUpdatesRuleBlock>? AllUpdatesRule
    {
        set => SetProperty("all_updates_rule", value);
    }

    /// <summary>
    /// Block for amount.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Amount is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Amount block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Amount block(s) allowed")]
    public List<GoogleBillingBudgetAmountBlock>? Amount
    {
        set => SetProperty("amount", value);
    }

    /// <summary>
    /// Block for budget_filter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BudgetFilter block(s) allowed")]
    public List<GoogleBillingBudgetBudgetFilterBlock>? BudgetFilter
    {
        set => SetProperty("budget_filter", value);
    }

    /// <summary>
    /// Block for threshold_rules.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleBillingBudgetThresholdRulesBlock>? ThresholdRules
    {
        set => SetProperty("threshold_rules", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleBillingBudgetTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Resource name of the budget. The resource name
    /// implies the scope of a budget. Values are of the form
    /// billingAccounts/{billingAccountId}/budgets/{budgetId}.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
