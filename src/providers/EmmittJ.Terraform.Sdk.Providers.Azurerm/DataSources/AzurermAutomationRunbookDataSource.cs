using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermAutomationRunbookDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermAutomationRunbookDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

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
/// Represents a azurerm_automation_runbook Terraform data source.
/// Retrieves information about a azurerm_automation_runbook.
/// </summary>
public partial class AzurermAutomationRunbookDataSource(string name) : TerraformDataSource("azurerm_automation_runbook", name)
{
    /// <summary>
    /// The automation_account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutomationAccountName is required")]
    public required TerraformValue<string> AutomationAccountName
    {
        get => GetArgument<TerraformValue<string>>("automation_account_name");
        set => SetArgument("automation_account_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The content attribute.
    /// </summary>
    public TerraformValue<string> Content
        => AsReference("content");

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => AsReference("location");

    /// <summary>
    /// The log_activity_trace_level attribute.
    /// </summary>
    public TerraformValue<double> LogActivityTraceLevel
        => AsReference("log_activity_trace_level");

    /// <summary>
    /// The log_progress attribute.
    /// </summary>
    public TerraformValue<bool> LogProgress
        => AsReference("log_progress");

    /// <summary>
    /// The log_verbose attribute.
    /// </summary>
    public TerraformValue<bool> LogVerbose
        => AsReference("log_verbose");

    /// <summary>
    /// The runbook_type attribute.
    /// </summary>
    public TerraformValue<string> RunbookType
        => AsReference("runbook_type");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => AsReference("tags");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermAutomationRunbookDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermAutomationRunbookDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
