using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for filter in .
/// Nesting mode: list
/// </summary>
public class AzurermConsumptionBudgetManagementGroupFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filter";

}

/// <summary>
/// Block type for notification in .
/// Nesting mode: set
/// </summary>
public class AzurermConsumptionBudgetManagementGroupNotificationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "notification";

    /// <summary>
    /// The contact_emails attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContactEmails is required")]
    public TerraformList<string>? ContactEmails
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "contact_emails").ResolveNodes(ctx));
        set => SetArgument("contact_emails", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperatorAttribute is required")]
    public required TerraformValue<string> OperatorAttribute
    {
        get => new TerraformReference<string>(this, "operator");
        set => SetArgument("operator", value);
    }

    /// <summary>
    /// The threshold attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Threshold is required")]
    public required TerraformValue<double> Threshold
    {
        get => new TerraformReference<double>(this, "threshold");
        set => SetArgument("threshold", value);
    }

    /// <summary>
    /// The threshold_type attribute.
    /// </summary>
    public TerraformValue<string>? ThresholdType
    {
        get => new TerraformReference<string>(this, "threshold_type");
        set => SetArgument("threshold_type", value);
    }

}

/// <summary>
/// Block type for time_period in .
/// Nesting mode: list
/// </summary>
public class AzurermConsumptionBudgetManagementGroupTimePeriodBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "time_period";

    /// <summary>
    /// The end_date attribute.
    /// </summary>
    public TerraformValue<string> EndDate
    {
        get => new TerraformReference<string>(this, "end_date");
        set => SetArgument("end_date", value);
    }

    /// <summary>
    /// The start_date attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartDate is required")]
    public required TerraformValue<string> StartDate
    {
        get => new TerraformReference<string>(this, "start_date");
        set => SetArgument("start_date", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermConsumptionBudgetManagementGroupTimeoutsBlock : TerraformBlock
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
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
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
/// Represents a azurerm_consumption_budget_management_group Terraform resource.
/// Manages a azurerm_consumption_budget_management_group resource.
/// </summary>
public partial class AzurermConsumptionBudgetManagementGroup(string name) : TerraformResource("azurerm_consumption_budget_management_group", name)
{
    /// <summary>
    /// The amount attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Amount is required")]
    public required TerraformValue<double> Amount
    {
        get => new TerraformReference<double>(this, "amount");
        set => SetArgument("amount", value);
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformValue<string> Etag
    {
        get => new TerraformReference<string>(this, "etag");
        set => SetArgument("etag", value);
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
    /// The management_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagementGroupId is required")]
    public required TerraformValue<string> ManagementGroupId
    {
        get => new TerraformReference<string>(this, "management_group_id");
        set => SetArgument("management_group_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The time_grain attribute.
    /// </summary>
    public TerraformValue<string>? TimeGrain
    {
        get => new TerraformReference<string>(this, "time_grain");
        set => SetArgument("time_grain", value);
    }

    /// <summary>
    /// Filter block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Filter block(s) allowed")]
    public TerraformList<AzurermConsumptionBudgetManagementGroupFilterBlock>? Filter
    {
        get => GetArgument<TerraformList<AzurermConsumptionBudgetManagementGroupFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

    /// <summary>
    /// Notification block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Notification is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Notification block(s) required")]
    public required TerraformSet<AzurermConsumptionBudgetManagementGroupNotificationBlock> Notification
    {
        get => GetRequiredArgument<TerraformSet<AzurermConsumptionBudgetManagementGroupNotificationBlock>>("notification");
        set => SetArgument("notification", value);
    }

    /// <summary>
    /// TimePeriod block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimePeriod is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 TimePeriod block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TimePeriod block(s) allowed")]
    public required TerraformList<AzurermConsumptionBudgetManagementGroupTimePeriodBlock> TimePeriod
    {
        get => GetRequiredArgument<TerraformList<AzurermConsumptionBudgetManagementGroupTimePeriodBlock>>("time_period");
        set => SetArgument("time_period", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermConsumptionBudgetManagementGroupTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermConsumptionBudgetManagementGroupTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
