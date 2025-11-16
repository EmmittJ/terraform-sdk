using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
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
        get => new TerraformReference<string>(this, "read");
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
        get => new TerraformReference<string>(this, "automation_account_name");
        set => SetArgument("automation_account_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The content attribute.
    /// </summary>
    public TerraformValue<string> Content
    {
        get => new TerraformReference<string>(this, "content");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The log_activity_trace_level attribute.
    /// </summary>
    public TerraformValue<double> LogActivityTraceLevel
    {
        get => new TerraformReference<double>(this, "log_activity_trace_level");
    }

    /// <summary>
    /// The log_progress attribute.
    /// </summary>
    public TerraformValue<bool> LogProgress
    {
        get => new TerraformReference<bool>(this, "log_progress");
    }

    /// <summary>
    /// The log_verbose attribute.
    /// </summary>
    public TerraformValue<bool> LogVerbose
    {
        get => new TerraformReference<bool>(this, "log_verbose");
    }

    /// <summary>
    /// The runbook_type attribute.
    /// </summary>
    public TerraformValue<string> RunbookType
    {
        get => new TerraformReference<string>(this, "runbook_type");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermAutomationRunbookDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermAutomationRunbookDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
