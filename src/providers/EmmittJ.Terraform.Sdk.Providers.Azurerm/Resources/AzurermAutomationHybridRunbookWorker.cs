using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermAutomationHybridRunbookWorker.
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

}


/// <summary>
/// Represents a azurerm_automation_hybrid_runbook_worker Terraform resource.
/// Manages a azurerm_automation_hybrid_runbook_worker resource.
/// </summary>
public partial class AzurermAutomationHybridRunbookWorker(string name) : TerraformResource("azurerm_automation_hybrid_runbook_worker", name)
{
    /// <summary>
    /// The automation_account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutomationAccountName is required")]
    public required TerraformValue<string> AutomationAccountName
    {
        get => GetRequiredArgument<TerraformValue<string>>("automation_account_name");
        set => SetArgument("automation_account_name", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The vm_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmResourceId is required")]
    public required TerraformValue<string> VmResourceId
    {
        get => GetRequiredArgument<TerraformValue<string>>("vm_resource_id");
        set => SetArgument("vm_resource_id", value);
    }

    /// <summary>
    /// The worker_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkerGroupName is required")]
    public required TerraformValue<string> WorkerGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("worker_group_name");
        set => SetArgument("worker_group_name", value);
    }

    /// <summary>
    /// The worker_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkerId is required")]
    public required TerraformValue<string> WorkerId
    {
        get => GetRequiredArgument<TerraformValue<string>>("worker_id");
        set => SetArgument("worker_id", value);
    }

    /// <summary>
    /// The ip attribute.
    /// </summary>
    public TerraformValue<string> Ip
        => AsReference("ip");

    /// <summary>
    /// The last_seen_date_time attribute.
    /// </summary>
    public TerraformValue<string> LastSeenDateTime
        => AsReference("last_seen_date_time");

    /// <summary>
    /// The registration_date_time attribute.
    /// </summary>
    public TerraformValue<string> RegistrationDateTime
        => AsReference("registration_date_time");

    /// <summary>
    /// The worker_name attribute.
    /// </summary>
    public TerraformValue<string> WorkerName
        => AsReference("worker_name");

    /// <summary>
    /// The worker_type attribute.
    /// </summary>
    public TerraformValue<string> WorkerType
        => AsReference("worker_type");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermAutomationHybridRunbookWorkerTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermAutomationHybridRunbookWorkerTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
