using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for draft in AzurermAutomationRunbook.
/// Nesting mode: list
/// </summary>
public class AzurermAutomationRunbookDraftBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "draft";

    /// <summary>
    /// The creation_time attribute.
    /// </summary>
    public TerraformValue<string> CreationTime
        => AsReference("creation_time");

    /// <summary>
    /// The edit_mode_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? EditModeEnabled
    {
        get => GetArgument<TerraformValue<bool>>("edit_mode_enabled");
        set => SetArgument("edit_mode_enabled", value);
    }

    /// <summary>
    /// The last_modified_time attribute.
    /// </summary>
    public TerraformValue<string> LastModifiedTime
        => AsReference("last_modified_time");

    /// <summary>
    /// The output_types attribute.
    /// </summary>
    public TerraformList<string>? OutputTypes
    {
        get => GetArgument<TerraformList<string>>("output_types");
        set => SetArgument("output_types", value);
    }

    /// <summary>
    /// ContentLink block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ContentLink block(s) allowed")]
    public TerraformList<AzurermAutomationRunbookDraftBlockContentLinkBlock>? ContentLink
    {
        get => GetArgument<TerraformList<AzurermAutomationRunbookDraftBlockContentLinkBlock>>("content_link");
        set => SetArgument("content_link", value);
    }

    /// <summary>
    /// Parameters block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermAutomationRunbookDraftBlockParametersBlock>? Parameters
    {
        get => GetArgument<TerraformList<AzurermAutomationRunbookDraftBlockParametersBlock>>("parameters");
        set => SetArgument("parameters", value);
    }

}

/// <summary>
/// Block type for content_link in AzurermAutomationRunbookDraftBlock.
/// Nesting mode: list
/// </summary>
public class AzurermAutomationRunbookDraftBlockContentLinkBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "content_link";

    /// <summary>
    /// The uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    public required TerraformValue<string> Uri
    {
        get => GetArgument<TerraformValue<string>>("uri");
        set => SetArgument("uri", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string>? Version
    {
        get => GetArgument<TerraformValue<string>>("version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// Hash block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Hash block(s) allowed")]
    public TerraformList<AzurermAutomationRunbookDraftBlockContentLinkBlockHashBlock>? Hash
    {
        get => GetArgument<TerraformList<AzurermAutomationRunbookDraftBlockContentLinkBlockHashBlock>>("hash");
        set => SetArgument("hash", value);
    }

}

/// <summary>
/// Block type for hash in AzurermAutomationRunbookDraftBlockContentLinkBlock.
/// Nesting mode: list
/// </summary>
public class AzurermAutomationRunbookDraftBlockContentLinkBlockHashBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "hash";

    /// <summary>
    /// The algorithm attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Algorithm is required")]
    public required TerraformValue<string> Algorithm
    {
        get => GetArgument<TerraformValue<string>>("algorithm");
        set => SetArgument("algorithm", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for parameters in AzurermAutomationRunbookDraftBlock.
/// Nesting mode: list
/// </summary>
public class AzurermAutomationRunbookDraftBlockParametersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "parameters";

    /// <summary>
    /// The default_value attribute.
    /// </summary>
    public TerraformValue<string>? DefaultValue
    {
        get => GetArgument<TerraformValue<string>>("default_value");
        set => SetArgument("default_value", value);
    }

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The mandatory attribute.
    /// </summary>
    public TerraformValue<bool>? Mandatory
    {
        get => GetArgument<TerraformValue<bool>>("mandatory");
        set => SetArgument("mandatory", value);
    }

    /// <summary>
    /// The position attribute.
    /// </summary>
    public TerraformValue<double>? Position
    {
        get => GetArgument<TerraformValue<double>>("position");
        set => SetArgument("position", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for publish_content_link in AzurermAutomationRunbook.
/// Nesting mode: list
/// </summary>
public class AzurermAutomationRunbookPublishContentLinkBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "publish_content_link";

    /// <summary>
    /// The uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    public required TerraformValue<string> Uri
    {
        get => GetArgument<TerraformValue<string>>("uri");
        set => SetArgument("uri", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string>? Version
    {
        get => GetArgument<TerraformValue<string>>("version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// Hash block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Hash block(s) allowed")]
    public TerraformList<AzurermAutomationRunbookPublishContentLinkBlockHashBlock>? Hash
    {
        get => GetArgument<TerraformList<AzurermAutomationRunbookPublishContentLinkBlockHashBlock>>("hash");
        set => SetArgument("hash", value);
    }

}

/// <summary>
/// Block type for hash in AzurermAutomationRunbookPublishContentLinkBlock.
/// Nesting mode: list
/// </summary>
public class AzurermAutomationRunbookPublishContentLinkBlockHashBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "hash";

    /// <summary>
    /// The algorithm attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Algorithm is required")]
    public required TerraformValue<string> Algorithm
    {
        get => GetArgument<TerraformValue<string>>("algorithm");
        set => SetArgument("algorithm", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermAutomationRunbook.
/// Nesting mode: single
/// </summary>
public class AzurermAutomationRunbookTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_automation_runbook Terraform resource.
/// Manages a azurerm_automation_runbook resource.
/// </summary>
public partial class AzurermAutomationRunbook(string name) : TerraformResource("azurerm_automation_runbook", name)
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
    /// The content attribute.
    /// </summary>
    public TerraformValue<string>? Content
    {
        get => GetArgument<TerraformValue<string>>("content");
        set => SetArgument("content", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
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
    /// The job_schedule attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>>? JobSchedule
    {
        get => GetArgument<TerraformSet<TerraformMap<object>>>("job_schedule");
        set => SetArgument("job_schedule", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The log_activity_trace_level attribute.
    /// </summary>
    public TerraformValue<double>? LogActivityTraceLevel
    {
        get => GetArgument<TerraformValue<double>>("log_activity_trace_level");
        set => SetArgument("log_activity_trace_level", value);
    }

    /// <summary>
    /// The log_progress attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogProgress is required")]
    public required TerraformValue<bool> LogProgress
    {
        get => GetArgument<TerraformValue<bool>>("log_progress");
        set => SetArgument("log_progress", value);
    }

    /// <summary>
    /// The log_verbose attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogVerbose is required")]
    public required TerraformValue<bool> LogVerbose
    {
        get => GetArgument<TerraformValue<bool>>("log_verbose");
        set => SetArgument("log_verbose", value);
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
    /// The runbook_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RunbookType is required")]
    public required TerraformValue<string> RunbookType
    {
        get => GetArgument<TerraformValue<string>>("runbook_type");
        set => SetArgument("runbook_type", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// Draft block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Draft block(s) allowed")]
    public TerraformList<AzurermAutomationRunbookDraftBlock>? Draft
    {
        get => GetArgument<TerraformList<AzurermAutomationRunbookDraftBlock>>("draft");
        set => SetArgument("draft", value);
    }

    /// <summary>
    /// PublishContentLink block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PublishContentLink block(s) allowed")]
    public TerraformList<AzurermAutomationRunbookPublishContentLinkBlock>? PublishContentLink
    {
        get => GetArgument<TerraformList<AzurermAutomationRunbookPublishContentLinkBlock>>("publish_content_link");
        set => SetArgument("publish_content_link", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermAutomationRunbookTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermAutomationRunbookTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
