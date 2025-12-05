using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for filter in AzurermConsumptionBudgetResourceGroup.
/// Nesting mode: list
/// </summary>
public class AzurermConsumptionBudgetResourceGroupFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filter";

    /// <summary>
    /// Dimension block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermConsumptionBudgetResourceGroupFilterBlockDimensionBlock>? Dimension
    {
        get => GetArgument<TerraformSet<AzurermConsumptionBudgetResourceGroupFilterBlockDimensionBlock>>("dimension");
        set => SetArgument("dimension", value);
    }

    /// <summary>
    /// Tag block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermConsumptionBudgetResourceGroupFilterBlockTagBlock>? Tag
    {
        get => GetArgument<TerraformSet<AzurermConsumptionBudgetResourceGroupFilterBlockTagBlock>>("tag");
        set => SetArgument("tag", value);
    }

}

/// <summary>
/// Block type for dimension in AzurermConsumptionBudgetResourceGroupFilterBlock.
/// Nesting mode: set
/// </summary>
public class AzurermConsumptionBudgetResourceGroupFilterBlockDimensionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dimension";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    public TerraformValue<string>? OperatorAttribute
    {
        get => GetArgument<TerraformValue<string>>("operator");
        set => SetArgument("operator", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public TerraformList<string>? ValuesAttribute
    {
        get => GetArgument<TerraformList<string>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for tag in AzurermConsumptionBudgetResourceGroupFilterBlock.
/// Nesting mode: set
/// </summary>
public class AzurermConsumptionBudgetResourceGroupFilterBlockTagBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tag";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    public TerraformValue<string>? OperatorAttribute
    {
        get => GetArgument<TerraformValue<string>>("operator");
        set => SetArgument("operator", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public TerraformList<string>? ValuesAttribute
    {
        get => GetArgument<TerraformList<string>>("values");
        set => SetArgument("values", value);
    }

}


/// <summary>
/// Block type for notification in AzurermConsumptionBudgetResourceGroup.
/// Nesting mode: set
/// </summary>
public class AzurermConsumptionBudgetResourceGroupNotificationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "notification";

    /// <summary>
    /// The contact_emails attribute.
    /// </summary>
    public TerraformList<string>? ContactEmails
    {
        get => GetArgument<TerraformList<string>>("contact_emails");
        set => SetArgument("contact_emails", value);
    }

    /// <summary>
    /// The contact_groups attribute.
    /// </summary>
    public TerraformList<string>? ContactGroups
    {
        get => GetArgument<TerraformList<string>>("contact_groups");
        set => SetArgument("contact_groups", value);
    }

    /// <summary>
    /// The contact_roles attribute.
    /// </summary>
    public TerraformList<string>? ContactRoles
    {
        get => GetArgument<TerraformList<string>>("contact_roles");
        set => SetArgument("contact_roles", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperatorAttribute is required")]
    public required TerraformValue<string> OperatorAttribute
    {
        get => GetRequiredArgument<TerraformValue<string>>("operator");
        set => SetArgument("operator", value);
    }

    /// <summary>
    /// The threshold attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Threshold is required")]
    public required TerraformValue<double> Threshold
    {
        get => GetRequiredArgument<TerraformValue<double>>("threshold");
        set => SetArgument("threshold", value);
    }

    /// <summary>
    /// The threshold_type attribute.
    /// </summary>
    public TerraformValue<string>? ThresholdType
    {
        get => GetArgument<TerraformValue<string>>("threshold_type");
        set => SetArgument("threshold_type", value);
    }

}


/// <summary>
/// Block type for time_period in AzurermConsumptionBudgetResourceGroup.
/// Nesting mode: list
/// </summary>
public class AzurermConsumptionBudgetResourceGroupTimePeriodBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("end_date") ?? CreateReference("end_date");
        set => SetArgument("end_date", value);
    }

    /// <summary>
    /// The start_date attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartDate is required")]
    public required TerraformValue<string> StartDate
    {
        get => GetRequiredArgument<TerraformValue<string>>("start_date");
        set => SetArgument("start_date", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermConsumptionBudgetResourceGroup.
/// Nesting mode: single
/// </summary>
public class AzurermConsumptionBudgetResourceGroupTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_consumption_budget_resource_group Terraform resource.
/// Manages a azurerm_consumption_budget_resource_group resource.
/// </summary>
public partial class AzurermConsumptionBudgetResourceGroup(string name) : TerraformResource("azurerm_consumption_budget_resource_group", name)
{
    /// <summary>
    /// The amount attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Amount is required")]
    public required TerraformValue<double> Amount
    {
        get => GetRequiredArgument<TerraformValue<double>>("amount");
        set => SetArgument("amount", value);
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformValue<string> Etag
    {
        get => GetArgument<TerraformValue<string>>("etag") ?? CreateReference("etag");
        set => SetArgument("etag", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupId is required")]
    public required TerraformValue<string> ResourceGroupId
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_id");
        set => SetArgument("resource_group_id", value);
    }

    /// <summary>
    /// The time_grain attribute.
    /// </summary>
    public TerraformValue<string>? TimeGrain
    {
        get => GetArgument<TerraformValue<string>>("time_grain");
        set => SetArgument("time_grain", value);
    }

    /// <summary>
    /// Filter block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Filter block(s) allowed")]
    public TerraformList<AzurermConsumptionBudgetResourceGroupFilterBlock>? Filter
    {
        get => GetArgument<TerraformList<AzurermConsumptionBudgetResourceGroupFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

    /// <summary>
    /// Notification block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Notification is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Notification block(s) required")]
    public required TerraformSet<AzurermConsumptionBudgetResourceGroupNotificationBlock> Notification
    {
        get => GetRequiredArgument<TerraformSet<AzurermConsumptionBudgetResourceGroupNotificationBlock>>("notification");
        set => SetArgument("notification", value);
    }

    /// <summary>
    /// TimePeriod block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimePeriod is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 TimePeriod block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TimePeriod block(s) allowed")]
    public required TerraformList<AzurermConsumptionBudgetResourceGroupTimePeriodBlock> TimePeriod
    {
        get => GetRequiredArgument<TerraformList<AzurermConsumptionBudgetResourceGroupTimePeriodBlock>>("time_period");
        set => SetArgument("time_period", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermConsumptionBudgetResourceGroupTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermConsumptionBudgetResourceGroupTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
