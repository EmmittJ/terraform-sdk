using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for filter in .
/// Nesting mode: list
/// </summary>
public partial class AzurermConsumptionBudgetResourceGroupFilterBlock() : TerraformBlock("filter")
{
}

/// <summary>
/// Block type for notification in .
/// Nesting mode: set
/// </summary>
public partial class AzurermConsumptionBudgetResourceGroupNotificationBlock() : TerraformBlock("notification")
{
    /// <summary>
    /// The contact_emails attribute.
    /// </summary>
    [TerraformProperty("contact_emails")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? ContactEmails { get; set; }

    /// <summary>
    /// The contact_groups attribute.
    /// </summary>
    [TerraformProperty("contact_groups")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? ContactGroups { get; set; }

    /// <summary>
    /// The contact_roles attribute.
    /// </summary>
    [TerraformProperty("contact_roles")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? ContactRoles { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Operator is required")]
    [TerraformProperty("operator")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Operator { get; set; }

    /// <summary>
    /// The threshold attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Threshold is required")]
    [TerraformProperty("threshold")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> Threshold { get; set; }

    /// <summary>
    /// The threshold_type attribute.
    /// </summary>
    [TerraformProperty("threshold_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ThresholdType { get; set; }

}

/// <summary>
/// Block type for time_period in .
/// Nesting mode: list
/// </summary>
public partial class AzurermConsumptionBudgetResourceGroupTimePeriodBlock() : TerraformBlock("time_period")
{
    /// <summary>
    /// The end_date attribute.
    /// </summary>
    [TerraformProperty("end_date")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> EndDate { get; set; }

    /// <summary>
    /// The start_date attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartDate is required")]
    [TerraformProperty("start_date")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> StartDate { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermConsumptionBudgetResourceGroupTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_consumption_budget_resource_group resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermConsumptionBudgetResourceGroup : TerraformResource
{
    public AzurermConsumptionBudgetResourceGroup(string name) : base("azurerm_consumption_budget_resource_group", name)
    {
    }

    /// <summary>
    /// The amount attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Amount is required")]
    [TerraformProperty("amount")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> Amount { get; set; }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    [TerraformProperty("etag")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Etag { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupId is required")]
    [TerraformProperty("resource_group_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupId { get; set; }

    /// <summary>
    /// The time_grain attribute.
    /// </summary>
    [TerraformProperty("time_grain")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TimeGrain { get; set; }

    /// <summary>
    /// Block for filter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Filter block(s) allowed")]
    [TerraformProperty("filter")]
    public TerraformList<AzurermConsumptionBudgetResourceGroupFilterBlock> Filter { get; set; } = new();

    /// <summary>
    /// Block for notification.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Notification is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Notification block(s) required")]
    [TerraformProperty("notification")]
    public required TerraformSet<AzurermConsumptionBudgetResourceGroupNotificationBlock> Notification { get; set; } = new();

    /// <summary>
    /// Block for time_period.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimePeriod is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 TimePeriod block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TimePeriod block(s) allowed")]
    [TerraformProperty("time_period")]
    public required TerraformList<AzurermConsumptionBudgetResourceGroupTimePeriodBlock> TimePeriod { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermConsumptionBudgetResourceGroupTimeoutsBlock Timeouts { get; set; } = new();

}
