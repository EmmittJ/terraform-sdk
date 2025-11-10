using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermAutomationHybridRunbookWorkerTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Manages a azurerm_automation_hybrid_runbook_worker resource.
/// </summary>
public class AzurermAutomationHybridRunbookWorker : TerraformResource
{
    public AzurermAutomationHybridRunbookWorker(string name) : base("azurerm_automation_hybrid_runbook_worker", name)
    {
    }

    /// <summary>
    /// The automation_account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutomationAccountName is required")]
    [TerraformPropertyName("automation_account_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AutomationAccountName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// The vm_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmResourceId is required")]
    [TerraformPropertyName("vm_resource_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> VmResourceId { get; set; }

    /// <summary>
    /// The worker_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkerGroupName is required")]
    [TerraformPropertyName("worker_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> WorkerGroupName { get; set; }

    /// <summary>
    /// The worker_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkerId is required")]
    [TerraformPropertyName("worker_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> WorkerId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermAutomationHybridRunbookWorkerTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The ip attribute.
    /// </summary>
    [TerraformPropertyName("ip")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Ip => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ip");

    /// <summary>
    /// The last_seen_date_time attribute.
    /// </summary>
    [TerraformPropertyName("last_seen_date_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LastSeenDateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "last_seen_date_time");

    /// <summary>
    /// The registration_date_time attribute.
    /// </summary>
    [TerraformPropertyName("registration_date_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RegistrationDateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "registration_date_time");

    /// <summary>
    /// The worker_name attribute.
    /// </summary>
    [TerraformPropertyName("worker_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> WorkerName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "worker_name");

    /// <summary>
    /// The worker_type attribute.
    /// </summary>
    [TerraformPropertyName("worker_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> WorkerType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "worker_type");

}
