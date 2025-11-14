using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for timeouts in .
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
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Manages a azurerm_cost_management_scheduled_action resource.
/// </summary>
public class AzurermCostManagementScheduledAction : TerraformResource
{
    public AzurermCostManagementScheduledAction(string name) : base("azurerm_cost_management_scheduled_action", name)
    {
    }

    /// <summary>
    /// The day_of_month attribute.
    /// </summary>
    [TerraformArgument("day_of_month")]
    public TerraformValue<double>? DayOfMonth
    {
        get => new TerraformReference<double>(this, "day_of_month");
        set => SetArgument("day_of_month", value);
    }

    /// <summary>
    /// The days_of_week attribute.
    /// </summary>
    [TerraformArgument("days_of_week")]
    public TerraformList<string>? DaysOfWeek
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "days_of_week").ResolveNodes(ctx));
        set => SetArgument("days_of_week", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformArgument("display_name")]
    public required TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The email_address_sender attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EmailAddressSender is required")]
    [TerraformArgument("email_address_sender")]
    public required TerraformValue<string> EmailAddressSender
    {
        get => new TerraformReference<string>(this, "email_address_sender");
        set => SetArgument("email_address_sender", value);
    }

    /// <summary>
    /// The email_addresses attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EmailAddresses is required")]
    [TerraformArgument("email_addresses")]
    public TerraformList<string>? EmailAddresses
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "email_addresses").ResolveNodes(ctx));
        set => SetArgument("email_addresses", value);
    }

    /// <summary>
    /// The email_subject attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EmailSubject is required")]
    [TerraformArgument("email_subject")]
    public required TerraformValue<string> EmailSubject
    {
        get => new TerraformReference<string>(this, "email_subject");
        set => SetArgument("email_subject", value);
    }

    /// <summary>
    /// The end_date attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndDate is required")]
    [TerraformArgument("end_date")]
    public required TerraformValue<string> EndDate
    {
        get => new TerraformReference<string>(this, "end_date");
        set => SetArgument("end_date", value);
    }

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Frequency is required")]
    [TerraformArgument("frequency")]
    public required TerraformValue<string> Frequency
    {
        get => new TerraformReference<string>(this, "frequency");
        set => SetArgument("frequency", value);
    }

    /// <summary>
    /// The hour_of_day attribute.
    /// </summary>
    [TerraformArgument("hour_of_day")]
    public TerraformValue<double>? HourOfDay
    {
        get => new TerraformReference<double>(this, "hour_of_day");
        set => SetArgument("hour_of_day", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The message attribute.
    /// </summary>
    [TerraformArgument("message")]
    public TerraformValue<string>? Message
    {
        get => new TerraformReference<string>(this, "message");
        set => SetArgument("message", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The start_date attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartDate is required")]
    [TerraformArgument("start_date")]
    public required TerraformValue<string> StartDate
    {
        get => new TerraformReference<string>(this, "start_date");
        set => SetArgument("start_date", value);
    }

    /// <summary>
    /// The view_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ViewId is required")]
    [TerraformArgument("view_id")]
    public required TerraformValue<string> ViewId
    {
        get => new TerraformReference<string>(this, "view_id");
        set => SetArgument("view_id", value);
    }

    /// <summary>
    /// The weeks_of_month attribute.
    /// </summary>
    [TerraformArgument("weeks_of_month")]
    public TerraformList<string>? WeeksOfMonth
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "weeks_of_month").ResolveNodes(ctx));
        set => SetArgument("weeks_of_month", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermCostManagementScheduledActionTimeoutsBlock Timeouts { get; set; } = new();

}
