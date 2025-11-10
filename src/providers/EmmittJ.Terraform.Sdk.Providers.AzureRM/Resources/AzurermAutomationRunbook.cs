using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for draft in .
/// Nesting mode: list
/// </summary>
public class AzurermAutomationRunbookDraftBlock : TerraformBlock
{
    /// <summary>
    /// The creation_time attribute.
    /// </summary>
    public TerraformProperty<string>? CreationTime
    {
        set => SetProperty("creation_time", value);
    }

    /// <summary>
    /// The edit_mode_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? EditModeEnabled
    {
        set => SetProperty("edit_mode_enabled", value);
    }

    /// <summary>
    /// The last_modified_time attribute.
    /// </summary>
    public TerraformProperty<string>? LastModifiedTime
    {
        set => SetProperty("last_modified_time", value);
    }

    /// <summary>
    /// The output_types attribute.
    /// </summary>
    public List<TerraformProperty<string>>? OutputTypes
    {
        set => SetProperty("output_types", value);
    }

}

/// <summary>
/// Block type for publish_content_link in .
/// Nesting mode: list
/// </summary>
public class AzurermAutomationRunbookPublishContentLinkBlock : TerraformBlock
{
    /// <summary>
    /// The uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    public required TerraformProperty<string> Uri
    {
        set => SetProperty("uri", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformProperty<string>? Version
    {
        set => SetProperty("version", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermAutomationRunbookTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("automation_account_name");
        SetOutput("content");
        SetOutput("description");
        SetOutput("id");
        SetOutput("job_schedule");
        SetOutput("location");
        SetOutput("log_activity_trace_level");
        SetOutput("log_progress");
        SetOutput("log_verbose");
        SetOutput("name");
        SetOutput("resource_group_name");
        SetOutput("runbook_type");
        SetOutput("tags");
    }

    /// <summary>
    /// The automation_account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutomationAccountName is required")]
    public required TerraformProperty<string> AutomationAccountName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("automation_account_name");
        set => SetProperty("automation_account_name", value);
    }

    /// <summary>
    /// The content attribute.
    /// </summary>
    public TerraformProperty<string> Content
    {
        get => GetRequiredOutput<TerraformProperty<string>>("content");
        set => SetProperty("content", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The job_schedule attribute.
    /// </summary>
    public HashSet<TerraformProperty<object>> JobSchedule
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<object>>>("job_schedule");
        set => SetProperty("job_schedule", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The log_activity_trace_level attribute.
    /// </summary>
    public TerraformProperty<double> LogActivityTraceLevel
    {
        get => GetRequiredOutput<TerraformProperty<double>>("log_activity_trace_level");
        set => SetProperty("log_activity_trace_level", value);
    }

    /// <summary>
    /// The log_progress attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogProgress is required")]
    public required TerraformProperty<bool> LogProgress
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("log_progress");
        set => SetProperty("log_progress", value);
    }

    /// <summary>
    /// The log_verbose attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogVerbose is required")]
    public required TerraformProperty<bool> LogVerbose
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("log_verbose");
        set => SetProperty("log_verbose", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The runbook_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RunbookType is required")]
    public required TerraformProperty<string> RunbookType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("runbook_type");
        set => SetProperty("runbook_type", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// Block for draft.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Draft block(s) allowed")]
    public List<AzurermAutomationRunbookDraftBlock>? Draft
    {
        set => SetProperty("draft", value);
    }

    /// <summary>
    /// Block for publish_content_link.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PublishContentLink block(s) allowed")]
    public List<AzurermAutomationRunbookPublishContentLinkBlock>? PublishContentLink
    {
        set => SetProperty("publish_content_link", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermAutomationRunbookTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
