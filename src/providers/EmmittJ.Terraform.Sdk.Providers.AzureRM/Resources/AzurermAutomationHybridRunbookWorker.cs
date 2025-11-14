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
public class AzurermAutomationHybridRunbookWorkerTimeoutsBlock : TerraformBlock
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
    [TerraformArgument("automation_account_name")]
    public required TerraformValue<string> AutomationAccountName
    {
        get => new TerraformReference<string>(this, "automation_account_name");
        set => SetArgument("automation_account_name", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The vm_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmResourceId is required")]
    [TerraformArgument("vm_resource_id")]
    public required TerraformValue<string> VmResourceId
    {
        get => new TerraformReference<string>(this, "vm_resource_id");
        set => SetArgument("vm_resource_id", value);
    }

    /// <summary>
    /// The worker_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkerGroupName is required")]
    [TerraformArgument("worker_group_name")]
    public required TerraformValue<string> WorkerGroupName
    {
        get => new TerraformReference<string>(this, "worker_group_name");
        set => SetArgument("worker_group_name", value);
    }

    /// <summary>
    /// The worker_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkerId is required")]
    [TerraformArgument("worker_id")]
    public required TerraformValue<string> WorkerId
    {
        get => new TerraformReference<string>(this, "worker_id");
        set => SetArgument("worker_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermAutomationHybridRunbookWorkerTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The ip attribute.
    /// </summary>
    [TerraformArgument("ip")]
    public TerraformValue<string> Ip
    {
        get => new TerraformReference<string>(this, "ip");
    }

    /// <summary>
    /// The last_seen_date_time attribute.
    /// </summary>
    [TerraformArgument("last_seen_date_time")]
    public TerraformValue<string> LastSeenDateTime
    {
        get => new TerraformReference<string>(this, "last_seen_date_time");
    }

    /// <summary>
    /// The registration_date_time attribute.
    /// </summary>
    [TerraformArgument("registration_date_time")]
    public TerraformValue<string> RegistrationDateTime
    {
        get => new TerraformReference<string>(this, "registration_date_time");
    }

    /// <summary>
    /// The worker_name attribute.
    /// </summary>
    [TerraformArgument("worker_name")]
    public TerraformValue<string> WorkerName
    {
        get => new TerraformReference<string>(this, "worker_name");
    }

    /// <summary>
    /// The worker_type attribute.
    /// </summary>
    [TerraformArgument("worker_type")]
    public TerraformValue<string> WorkerType
    {
        get => new TerraformReference<string>(this, "worker_type");
    }

}
