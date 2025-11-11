using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermCostManagementScheduledActionTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_cost_management_scheduled_action resource.
/// </summary>
public partial class AzurermCostManagementScheduledAction : TerraformResource
{
    public AzurermCostManagementScheduledAction(string name) : base("azurerm_cost_management_scheduled_action", name)
    {
    }

    /// <summary>
    /// The day_of_month attribute.
    /// </summary>
    [TerraformProperty("day_of_month")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? DayOfMonth { get; set; }

    /// <summary>
    /// The days_of_week attribute.
    /// </summary>
    [TerraformProperty("days_of_week")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? DaysOfWeek { get; set; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformProperty("display_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The email_address_sender attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EmailAddressSender is required")]
    [TerraformProperty("email_address_sender")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> EmailAddressSender { get; set; }

    /// <summary>
    /// The email_addresses attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EmailAddresses is required")]
    [TerraformProperty("email_addresses")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? EmailAddresses { get; set; }

    /// <summary>
    /// The email_subject attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EmailSubject is required")]
    [TerraformProperty("email_subject")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> EmailSubject { get; set; }

    /// <summary>
    /// The end_date attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndDate is required")]
    [TerraformProperty("end_date")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> EndDate { get; set; }

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Frequency is required")]
    [TerraformProperty("frequency")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Frequency { get; set; }

    /// <summary>
    /// The hour_of_day attribute.
    /// </summary>
    [TerraformProperty("hour_of_day")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? HourOfDay { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The message attribute.
    /// </summary>
    [TerraformProperty("message")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Message { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The start_date attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartDate is required")]
    [TerraformProperty("start_date")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> StartDate { get; set; }

    /// <summary>
    /// The view_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ViewId is required")]
    [TerraformProperty("view_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ViewId { get; set; }

    /// <summary>
    /// The weeks_of_month attribute.
    /// </summary>
    [TerraformProperty("weeks_of_month")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? WeeksOfMonth { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermCostManagementScheduledActionTimeoutsBlock>? Timeouts { get; set; }

}
