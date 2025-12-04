using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermCostManagementScheduledAction.
/// Nesting mode: single
/// </summary>
public class AzurermCostManagementScheduledActionTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_cost_management_scheduled_action Terraform resource.
/// Manages a azurerm_cost_management_scheduled_action resource.
/// </summary>
public partial class AzurermCostManagementScheduledAction(string name) : TerraformResource("azurerm_cost_management_scheduled_action", name)
{
    /// <summary>
    /// The day_of_month attribute.
    /// </summary>
    public TerraformValue<double>? DayOfMonth
    {
        get => GetArgument<TerraformValue<double>>("day_of_month");
        set => SetArgument("day_of_month", value);
    }

    /// <summary>
    /// The days_of_week attribute.
    /// </summary>
    public TerraformList<string>? DaysOfWeek
    {
        get => GetArgument<TerraformList<string>>("days_of_week");
        set => SetArgument("days_of_week", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => GetRequiredArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The email_address_sender attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EmailAddressSender is required")]
    public required TerraformValue<string> EmailAddressSender
    {
        get => GetRequiredArgument<TerraformValue<string>>("email_address_sender");
        set => SetArgument("email_address_sender", value);
    }

    /// <summary>
    /// The email_addresses attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EmailAddresses is required")]
    public TerraformList<string>? EmailAddresses
    {
        get => GetArgument<TerraformList<string>>("email_addresses");
        set => SetArgument("email_addresses", value);
    }

    /// <summary>
    /// The email_subject attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EmailSubject is required")]
    public required TerraformValue<string> EmailSubject
    {
        get => GetRequiredArgument<TerraformValue<string>>("email_subject");
        set => SetArgument("email_subject", value);
    }

    /// <summary>
    /// The end_date attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndDate is required")]
    public required TerraformValue<string> EndDate
    {
        get => GetRequiredArgument<TerraformValue<string>>("end_date");
        set => SetArgument("end_date", value);
    }

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Frequency is required")]
    public required TerraformValue<string> Frequency
    {
        get => GetRequiredArgument<TerraformValue<string>>("frequency");
        set => SetArgument("frequency", value);
    }

    /// <summary>
    /// The hour_of_day attribute.
    /// </summary>
    public TerraformValue<double>? HourOfDay
    {
        get => GetArgument<TerraformValue<double>>("hour_of_day");
        set => SetArgument("hour_of_day", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The message attribute.
    /// </summary>
    public TerraformValue<string>? Message
    {
        get => GetArgument<TerraformValue<string>>("message");
        set => SetArgument("message", value);
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
    /// The start_date attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartDate is required")]
    public required TerraformValue<string> StartDate
    {
        get => GetRequiredArgument<TerraformValue<string>>("start_date");
        set => SetArgument("start_date", value);
    }

    /// <summary>
    /// The view_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ViewId is required")]
    public required TerraformValue<string> ViewId
    {
        get => GetRequiredArgument<TerraformValue<string>>("view_id");
        set => SetArgument("view_id", value);
    }

    /// <summary>
    /// The weeks_of_month attribute.
    /// </summary>
    public TerraformList<string>? WeeksOfMonth
    {
        get => GetArgument<TerraformList<string>>("weeks_of_month");
        set => SetArgument("weeks_of_month", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermCostManagementScheduledActionTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermCostManagementScheduledActionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
