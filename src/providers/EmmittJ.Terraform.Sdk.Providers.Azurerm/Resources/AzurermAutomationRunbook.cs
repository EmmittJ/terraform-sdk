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
    {
        get => new TerraformReference<string>(this, "creation_time");
    }

    /// <summary>
    /// The edit_mode_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? EditModeEnabled
    {
        get => new TerraformReference<bool>(this, "edit_mode_enabled");
        set => SetArgument("edit_mode_enabled", value);
    }

    /// <summary>
    /// The last_modified_time attribute.
    /// </summary>
    public TerraformValue<string> LastModifiedTime
    {
        get => new TerraformReference<string>(this, "last_modified_time");
    }

    /// <summary>
    /// The output_types attribute.
    /// </summary>
    public TerraformList<string>? OutputTypes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "output_types").ResolveNodes(ctx));
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
        get => new TerraformReference<string>(this, "uri");
        set => SetArgument("uri", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string>? Version
    {
        get => new TerraformReference<string>(this, "version");
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
        get => new TerraformReference<string>(this, "algorithm");
        set => SetArgument("algorithm", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
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
        get => new TerraformReference<string>(this, "default_value");
        set => SetArgument("default_value", value);
    }

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => new TerraformReference<string>(this, "key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The mandatory attribute.
    /// </summary>
    public TerraformValue<bool>? Mandatory
    {
        get => new TerraformReference<bool>(this, "mandatory");
        set => SetArgument("mandatory", value);
    }

    /// <summary>
    /// The position attribute.
    /// </summary>
    public TerraformValue<double>? Position
    {
        get => new TerraformReference<double>(this, "position");
        set => SetArgument("position", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
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
        get => new TerraformReference<string>(this, "uri");
        set => SetArgument("uri", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string>? Version
    {
        get => new TerraformReference<string>(this, "version");
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
        get => new TerraformReference<string>(this, "algorithm");
        set => SetArgument("algorithm", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
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
        get => new TerraformReference<string>(this, "automation_account_name");
        set => SetArgument("automation_account_name", value);
    }

    /// <summary>
    /// The content attribute.
    /// </summary>
    public TerraformValue<string> Content
    {
        get => new TerraformReference<string>(this, "content");
        set => SetArgument("content", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
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
    /// The job_schedule attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> JobSchedule
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "job_schedule").ResolveNodes(ctx));
        set => SetArgument("job_schedule", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The log_activity_trace_level attribute.
    /// </summary>
    public TerraformValue<double>? LogActivityTraceLevel
    {
        get => new TerraformReference<double>(this, "log_activity_trace_level");
        set => SetArgument("log_activity_trace_level", value);
    }

    /// <summary>
    /// The log_progress attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogProgress is required")]
    public required TerraformValue<bool> LogProgress
    {
        get => new TerraformReference<bool>(this, "log_progress");
        set => SetArgument("log_progress", value);
    }

    /// <summary>
    /// The log_verbose attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogVerbose is required")]
    public required TerraformValue<bool> LogVerbose
    {
        get => new TerraformReference<bool>(this, "log_verbose");
        set => SetArgument("log_verbose", value);
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
    /// The runbook_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RunbookType is required")]
    public required TerraformValue<string> RunbookType
    {
        get => new TerraformReference<string>(this, "runbook_type");
        set => SetArgument("runbook_type", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
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
