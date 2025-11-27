using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for all_updates_rule in GoogleBillingBudget.
/// Nesting mode: list
/// </summary>
public class GoogleBillingBudgetAllUpdatesRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "all_updates_rule";

    /// <summary>
    /// Boolean. When set to true, disables default notifications sent
    /// when a threshold is exceeded. Default recipients are
    /// those with Billing Account Administrators and Billing
    /// Account Users IAM roles for the target account.
    /// </summary>
    public TerraformValue<bool>? DisableDefaultIamRecipients
    {
        get => new TerraformReference<bool>(this, "disable_default_iam_recipients");
        set => SetArgument("disable_default_iam_recipients", value);
    }

    /// <summary>
    /// When set to true, and when the budget has a single project configured,
    /// notifications will be sent to project level recipients of that project.
    /// This field will be ignored if the budget has multiple or no project configured.
    /// 
    /// Currently, project level recipients are the users with Owner role on a cloud project.
    /// </summary>
    public TerraformValue<bool>? EnableProjectLevelRecipients
    {
        get => new TerraformReference<bool>(this, "enable_project_level_recipients");
        set => SetArgument("enable_project_level_recipients", value);
    }

    /// <summary>
    /// The full resource name of a monitoring notification
    /// channel in the form
    /// projects/{project_id}/notificationChannels/{channel_id}.
    /// A maximum of 5 channels are allowed.
    /// </summary>
    public TerraformList<string>? MonitoringNotificationChannels
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "monitoring_notification_channels").ResolveNodes(ctx));
        set => SetArgument("monitoring_notification_channels", value);
    }

    /// <summary>
    /// The name of the Cloud Pub/Sub topic where budget related
    /// messages will be published, in the form
    /// projects/{project_id}/topics/{topic_id}. Updates are sent
    /// at regular intervals to the topic.
    /// </summary>
    public TerraformValue<string>? PubsubTopic
    {
        get => new TerraformReference<string>(this, "pubsub_topic");
        set => SetArgument("pubsub_topic", value);
    }

    /// <summary>
    /// The schema version of the notification. Only &amp;quot;1.0&amp;quot; is
    /// accepted. It represents the JSON schema as defined in
    /// https://cloud.google.com/billing/docs/how-to/budgets#notification_format.
    /// </summary>
    public TerraformValue<string>? SchemaVersion
    {
        get => new TerraformReference<string>(this, "schema_version");
        set => SetArgument("schema_version", value);
    }

}


/// <summary>
/// Block type for amount in GoogleBillingBudget.
/// Nesting mode: list
/// </summary>
public class GoogleBillingBudgetAmountBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "amount";

    /// <summary>
    /// Configures a budget amount that is automatically set to 100% of
    /// last period&#39;s spend.
    /// Boolean. Set value to true to use. Do not set to false, instead
    /// use the &#39;specified_amount&#39; block.
    /// </summary>
    public TerraformValue<bool>? LastPeriodAmount
    {
        get => new TerraformReference<bool>(this, "last_period_amount");
        set => SetArgument("last_period_amount", value);
    }

    /// <summary>
    /// SpecifiedAmount block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SpecifiedAmount block(s) allowed")]
    public TerraformList<GoogleBillingBudgetAmountBlockSpecifiedAmountBlock>? SpecifiedAmount
    {
        get => GetArgument<TerraformList<GoogleBillingBudgetAmountBlockSpecifiedAmountBlock>>("specified_amount");
        set => SetArgument("specified_amount", value);
    }

}

/// <summary>
/// Block type for specified_amount in GoogleBillingBudgetAmountBlock.
/// Nesting mode: list
/// </summary>
public class GoogleBillingBudgetAmountBlockSpecifiedAmountBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "specified_amount";

    /// <summary>
    /// The 3-letter currency code defined in ISO 4217.
    /// </summary>
    public TerraformValue<string> CurrencyCode
    {
        get => new TerraformReference<string>(this, "currency_code");
        set => SetArgument("currency_code", value);
    }

    /// <summary>
    /// Number of nano (10^-9) units of the amount.
    /// The value must be between -999,999,999 and +999,999,999
    /// inclusive. If units is positive, nanos must be positive or
    /// zero. If units is zero, nanos can be positive, zero, or
    /// negative. If units is negative, nanos must be negative or
    /// zero. For example $-1.75 is represented as units=-1 and
    /// nanos=-750,000,000.
    /// </summary>
    public TerraformValue<double>? Nanos
    {
        get => new TerraformReference<double>(this, "nanos");
        set => SetArgument("nanos", value);
    }

    /// <summary>
    /// The whole units of the amount. For example if currencyCode
    /// is &amp;quot;USD&amp;quot;, then 1 unit is one US dollar.
    /// </summary>
    public TerraformValue<string>? Units
    {
        get => new TerraformReference<string>(this, "units");
        set => SetArgument("units", value);
    }

}


/// <summary>
/// Block type for budget_filter in GoogleBillingBudget.
/// Nesting mode: list
/// </summary>
public class GoogleBillingBudgetBudgetFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "budget_filter";

    /// <summary>
    /// A CalendarPeriod represents the abstract concept of a recurring time period that has a
    /// canonical start. Grammatically, &amp;quot;the start of the current CalendarPeriod&amp;quot;.
    /// All calendar times begin at 12 AM US and Canadian Pacific Time (UTC-8).
    /// 
    /// Exactly one of &#39;calendar_period&#39;, &#39;custom_period&#39; must be provided. Possible values: [&amp;quot;MONTH&amp;quot;, &amp;quot;QUARTER&amp;quot;, &amp;quot;YEAR&amp;quot;, &amp;quot;CALENDAR_PERIOD_UNSPECIFIED&amp;quot;]
    /// </summary>
    public TerraformValue<string>? CalendarPeriod
    {
        get => new TerraformReference<string>(this, "calendar_period");
        set => SetArgument("calendar_period", value);
    }

    /// <summary>
    /// Optional. If creditTypesTreatment is INCLUDE_SPECIFIED_CREDITS,
    /// this is a list of credit types to be subtracted from gross cost to determine the spend for threshold calculations. See a list of acceptable credit type values.
    /// If creditTypesTreatment is not INCLUDE_SPECIFIED_CREDITS, this field must be empty.
    /// </summary>
    public TerraformList<string>? CreditTypes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "credit_types").ResolveNodes(ctx));
        set => SetArgument("credit_types", value);
    }

    /// <summary>
    /// Specifies how credits should be treated when determining spend
    /// for threshold calculations. Default value: &amp;quot;INCLUDE_ALL_CREDITS&amp;quot; Possible values: [&amp;quot;INCLUDE_ALL_CREDITS&amp;quot;, &amp;quot;EXCLUDE_ALL_CREDITS&amp;quot;, &amp;quot;INCLUDE_SPECIFIED_CREDITS&amp;quot;]
    /// </summary>
    public TerraformValue<string>? CreditTypesTreatment
    {
        get => new TerraformReference<string>(this, "credit_types_treatment");
        set => SetArgument("credit_types_treatment", value);
    }

    /// <summary>
    /// A single label and value pair specifying that usage from only
    /// this set of labeled resources should be included in the budget.
    /// </summary>
    public TerraformMap<string> Labels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "labels").ResolveNodes(ctx));
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// A set of projects of the form projects/{project_number},
    /// specifying that usage from only this set of projects should be
    /// included in the budget. If omitted, the report will include
    /// all usage for the billing account, regardless of which project
    /// the usage occurred on.
    /// </summary>
    public TerraformSet<string>? Projects
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "projects").ResolveNodes(ctx));
        set => SetArgument("projects", value);
    }

    /// <summary>
    /// A set of folder and organization names of the form folders/{folderId} or organizations/{organizationId},
    /// specifying that usage from only this set of folders and organizations should be included in the budget.
    /// If omitted, the budget includes all usage that the billing account pays for. If the folder or organization
    /// contains projects that are paid for by a different Cloud Billing account, the budget doesn&#39;t apply to those projects.
    /// </summary>
    public TerraformSet<string>? ResourceAncestors
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "resource_ancestors").ResolveNodes(ctx));
        set => SetArgument("resource_ancestors", value);
    }

    /// <summary>
    /// A set of services of the form services/{service_id},
    /// specifying that usage from only this set of services should be
    /// included in the budget. If omitted, the report will include
    /// usage for all the services. The service names are available
    /// through the Catalog API:
    /// https://cloud.google.com/billing/v1/how-tos/catalog-api.
    /// </summary>
    public TerraformList<string> Services
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "services").ResolveNodes(ctx));
        set => SetArgument("services", value);
    }

    /// <summary>
    /// A set of subaccounts of the form billingAccounts/{account_id},
    /// specifying that usage from only this set of subaccounts should
    /// be included in the budget. If a subaccount is set to the name of
    /// the parent account, usage from the parent account will be included.
    /// If the field is omitted, the report will include usage from the parent
    /// account and all subaccounts, if they exist.
    /// </summary>
    public TerraformList<string>? Subaccounts
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "subaccounts").ResolveNodes(ctx));
        set => SetArgument("subaccounts", value);
    }

    /// <summary>
    /// CustomPeriod block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomPeriod block(s) allowed")]
    public TerraformList<GoogleBillingBudgetBudgetFilterBlockCustomPeriodBlock>? CustomPeriod
    {
        get => GetArgument<TerraformList<GoogleBillingBudgetBudgetFilterBlockCustomPeriodBlock>>("custom_period");
        set => SetArgument("custom_period", value);
    }

}

/// <summary>
/// Block type for custom_period in GoogleBillingBudgetBudgetFilterBlock.
/// Nesting mode: list
/// </summary>
public class GoogleBillingBudgetBudgetFilterBlockCustomPeriodBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_period";

    /// <summary>
    /// EndDate block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EndDate block(s) allowed")]
    public TerraformList<GoogleBillingBudgetBudgetFilterBlockCustomPeriodBlockEndDateBlock>? EndDate
    {
        get => GetArgument<TerraformList<GoogleBillingBudgetBudgetFilterBlockCustomPeriodBlockEndDateBlock>>("end_date");
        set => SetArgument("end_date", value);
    }

    /// <summary>
    /// StartDate block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartDate is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 StartDate block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StartDate block(s) allowed")]
    public required TerraformList<GoogleBillingBudgetBudgetFilterBlockCustomPeriodBlockStartDateBlock> StartDate
    {
        get => GetRequiredArgument<TerraformList<GoogleBillingBudgetBudgetFilterBlockCustomPeriodBlockStartDateBlock>>("start_date");
        set => SetArgument("start_date", value);
    }

}

/// <summary>
/// Block type for end_date in GoogleBillingBudgetBudgetFilterBlockCustomPeriodBlock.
/// Nesting mode: list
/// </summary>
public class GoogleBillingBudgetBudgetFilterBlockCustomPeriodBlockEndDateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "end_date";

    /// <summary>
    /// Day of a month. Must be from 1 to 31 and valid for the year and month.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Day is required")]
    public required TerraformValue<double> Day
    {
        get => new TerraformReference<double>(this, "day");
        set => SetArgument("day", value);
    }

    /// <summary>
    /// Month of a year. Must be from 1 to 12.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Month is required")]
    public required TerraformValue<double> Month
    {
        get => new TerraformReference<double>(this, "month");
        set => SetArgument("month", value);
    }

    /// <summary>
    /// Year of the date. Must be from 1 to 9999.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Year is required")]
    public required TerraformValue<double> Year
    {
        get => new TerraformReference<double>(this, "year");
        set => SetArgument("year", value);
    }

}

/// <summary>
/// Block type for start_date in GoogleBillingBudgetBudgetFilterBlockCustomPeriodBlock.
/// Nesting mode: list
/// </summary>
public class GoogleBillingBudgetBudgetFilterBlockCustomPeriodBlockStartDateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "start_date";

    /// <summary>
    /// Day of a month. Must be from 1 to 31 and valid for the year and month.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Day is required")]
    public required TerraformValue<double> Day
    {
        get => new TerraformReference<double>(this, "day");
        set => SetArgument("day", value);
    }

    /// <summary>
    /// Month of a year. Must be from 1 to 12.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Month is required")]
    public required TerraformValue<double> Month
    {
        get => new TerraformReference<double>(this, "month");
        set => SetArgument("month", value);
    }

    /// <summary>
    /// Year of the date. Must be from 1 to 9999.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Year is required")]
    public required TerraformValue<double> Year
    {
        get => new TerraformReference<double>(this, "year");
        set => SetArgument("year", value);
    }

}


/// <summary>
/// Block type for threshold_rules in GoogleBillingBudget.
/// Nesting mode: list
/// </summary>
public class GoogleBillingBudgetThresholdRulesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "threshold_rules";

    /// <summary>
    /// The type of basis used to determine if spend has passed
    /// the threshold. Default value: &amp;quot;CURRENT_SPEND&amp;quot; Possible values: [&amp;quot;CURRENT_SPEND&amp;quot;, &amp;quot;FORECASTED_SPEND&amp;quot;]
    /// </summary>
    public TerraformValue<string>? SpendBasis
    {
        get => new TerraformReference<string>(this, "spend_basis");
        set => SetArgument("spend_basis", value);
    }

    /// <summary>
    /// Send an alert when this threshold is exceeded. This is a
    /// 1.0-based percentage, so 0.5 = 50%. Must be &amp;gt;= 0.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ThresholdPercent is required")]
    public required TerraformValue<double> ThresholdPercent
    {
        get => new TerraformReference<double>(this, "threshold_percent");
        set => SetArgument("threshold_percent", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleBillingBudget.
/// Nesting mode: single
/// </summary>
public class GoogleBillingBudgetTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_billing_budget Terraform resource.
/// Manages a google_billing_budget resource.
/// </summary>
public partial class GoogleBillingBudget(string name) : TerraformResource("google_billing_budget", name)
{
    /// <summary>
    /// ID of the billing account to set a budget on.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BillingAccount is required")]
    public required TerraformValue<string> BillingAccount
    {
        get => new TerraformReference<string>(this, "billing_account");
        set => SetArgument("billing_account", value);
    }

    /// <summary>
    /// User data for display name in UI. Must be &amp;lt;= 60 chars.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The ownership scope of the budget. The ownership scope and users&#39;
    /// IAM permissions determine who has full access to the budget&#39;s data. Possible values: [&amp;quot;OWNERSHIP_SCOPE_UNSPECIFIED&amp;quot;, &amp;quot;ALL_USERS&amp;quot;, &amp;quot;BILLING_ACCOUNT&amp;quot;]
    /// </summary>
    public TerraformValue<string>? OwnershipScope
    {
        get => new TerraformReference<string>(this, "ownership_scope");
        set => SetArgument("ownership_scope", value);
    }

    /// <summary>
    /// Resource name of the budget. The resource name
    /// implies the scope of a budget. Values are of the form
    /// billingAccounts/{billingAccountId}/budgets/{budgetId}.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// AllUpdatesRule block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AllUpdatesRule block(s) allowed")]
    public TerraformList<GoogleBillingBudgetAllUpdatesRuleBlock>? AllUpdatesRule
    {
        get => GetArgument<TerraformList<GoogleBillingBudgetAllUpdatesRuleBlock>>("all_updates_rule");
        set => SetArgument("all_updates_rule", value);
    }

    /// <summary>
    /// Amount block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Amount is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Amount block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Amount block(s) allowed")]
    public required TerraformList<GoogleBillingBudgetAmountBlock> Amount
    {
        get => GetRequiredArgument<TerraformList<GoogleBillingBudgetAmountBlock>>("amount");
        set => SetArgument("amount", value);
    }

    /// <summary>
    /// BudgetFilter block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BudgetFilter block(s) allowed")]
    public TerraformList<GoogleBillingBudgetBudgetFilterBlock>? BudgetFilter
    {
        get => GetArgument<TerraformList<GoogleBillingBudgetBudgetFilterBlock>>("budget_filter");
        set => SetArgument("budget_filter", value);
    }

    /// <summary>
    /// ThresholdRules block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleBillingBudgetThresholdRulesBlock>? ThresholdRules
    {
        get => GetArgument<TerraformList<GoogleBillingBudgetThresholdRulesBlock>>("threshold_rules");
        set => SetArgument("threshold_rules", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleBillingBudgetTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleBillingBudgetTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
