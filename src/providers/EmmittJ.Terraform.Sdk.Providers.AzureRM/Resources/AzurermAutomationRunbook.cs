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
/// Block type for draft in .
/// Nesting mode: list
/// </summary>
public class AzurermAutomationRunbookDraftBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "draft";


    /// <summary>
    /// The edit_mode_enabled attribute.
    /// </summary>
    [TerraformArgument("edit_mode_enabled")]
    public TerraformValue<bool>? EditModeEnabled
    {
        get => new TerraformReference<bool>(this, "edit_mode_enabled");
        set => SetArgument("edit_mode_enabled", value);
    }


    /// <summary>
    /// The output_types attribute.
    /// </summary>
    [TerraformArgument("output_types")]
    public TerraformList<string>? OutputTypes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "output_types").ResolveNodes(ctx));
        set => SetArgument("output_types", value);
    }

}

/// <summary>
/// Block type for publish_content_link in .
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
    [TerraformArgument("uri")]
    public required TerraformValue<string> Uri
    {
        get => new TerraformReference<string>(this, "uri");
        set => SetArgument("uri", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformArgument("version")]
    public TerraformValue<string>? Version
    {
        get => new TerraformReference<string>(this, "version");
        set => SetArgument("version", value);
    }

}

/// <summary>
/// Block type for timeouts in .
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Manages a azurerm_automation_runbook resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermAutomationRunbook : TerraformResource
{
    public AzurermAutomationRunbook(string name) : base("azurerm_automation_runbook", name)
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
    /// The content attribute.
    /// </summary>
    [TerraformArgument("content")]
    public TerraformValue<string> Content
    {
        get => new TerraformReference<string>(this, "content");
        set => SetArgument("content", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformArgument("description")]
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
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
    /// The job_schedule attribute.
    /// </summary>
    [TerraformArgument("job_schedule")]
    public TerraformSet<object> JobSchedule
    {
        get => TerraformSet<object>.Lazy(ctx => new TerraformReference<TerraformSet<object>>(this, "job_schedule").ResolveNodes(ctx));
        set => SetArgument("job_schedule", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The log_activity_trace_level attribute.
    /// </summary>
    [TerraformArgument("log_activity_trace_level")]
    public TerraformValue<double>? LogActivityTraceLevel
    {
        get => new TerraformReference<double>(this, "log_activity_trace_level");
        set => SetArgument("log_activity_trace_level", value);
    }

    /// <summary>
    /// The log_progress attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogProgress is required")]
    [TerraformArgument("log_progress")]
    public required TerraformValue<bool> LogProgress
    {
        get => new TerraformReference<bool>(this, "log_progress");
        set => SetArgument("log_progress", value);
    }

    /// <summary>
    /// The log_verbose attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogVerbose is required")]
    [TerraformArgument("log_verbose")]
    public required TerraformValue<bool> LogVerbose
    {
        get => new TerraformReference<bool>(this, "log_verbose");
        set => SetArgument("log_verbose", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
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
    /// The runbook_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RunbookType is required")]
    [TerraformArgument("runbook_type")]
    public required TerraformValue<string> RunbookType
    {
        get => new TerraformReference<string>(this, "runbook_type");
        set => SetArgument("runbook_type", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// Block for draft.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Draft block(s) allowed")]
    [TerraformArgument("draft")]
    public TerraformList<AzurermAutomationRunbookDraftBlock> Draft { get; set; } = new();

    /// <summary>
    /// Block for publish_content_link.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PublishContentLink block(s) allowed")]
    [TerraformArgument("publish_content_link")]
    public TerraformList<AzurermAutomationRunbookPublishContentLinkBlock> PublishContentLink { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermAutomationRunbookTimeoutsBlock Timeouts { get; set; } = new();

}
