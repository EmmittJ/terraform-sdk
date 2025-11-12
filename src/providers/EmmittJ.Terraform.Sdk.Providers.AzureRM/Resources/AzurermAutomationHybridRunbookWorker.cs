using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermAutomationHybridRunbookWorkerTimeoutsBlock() : TerraformBlock("timeouts")
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

}

/// <summary>
/// Manages a azurerm_automation_hybrid_runbook_worker resource.
/// </summary>
public partial class AzurermAutomationHybridRunbookWorker : TerraformResource
{
    public AzurermAutomationHybridRunbookWorker(string name) : base("azurerm_automation_hybrid_runbook_worker", name)
    {
    }

    /// <summary>
    /// The automation_account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutomationAccountName is required")]
    [TerraformProperty("automation_account_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AutomationAccountName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The vm_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmResourceId is required")]
    [TerraformProperty("vm_resource_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> VmResourceId { get; set; }

    /// <summary>
    /// The worker_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkerGroupName is required")]
    [TerraformProperty("worker_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> WorkerGroupName { get; set; }

    /// <summary>
    /// The worker_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkerId is required")]
    [TerraformProperty("worker_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> WorkerId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermAutomationHybridRunbookWorkerTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The ip attribute.
    /// </summary>
    [TerraformProperty("ip")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Ip { get; }

    /// <summary>
    /// The last_seen_date_time attribute.
    /// </summary>
    [TerraformProperty("last_seen_date_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LastSeenDateTime { get; }

    /// <summary>
    /// The registration_date_time attribute.
    /// </summary>
    [TerraformProperty("registration_date_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> RegistrationDateTime { get; }

    /// <summary>
    /// The worker_name attribute.
    /// </summary>
    [TerraformProperty("worker_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> WorkerName { get; }

    /// <summary>
    /// The worker_type attribute.
    /// </summary>
    [TerraformProperty("worker_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> WorkerType { get; }

}
