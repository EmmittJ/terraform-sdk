using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for draft in .
/// Nesting mode: list
/// </summary>
public class AzurermAutomationRunbookDraftBlock : ITerraformBlock
{
    /// <summary>
    /// The creation_time attribute.
    /// </summary>
    [TerraformPropertyName("creation_time")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreationTime => new TerraformReferenceProperty<TerraformProperty<string>>("", "creation_time");

    /// <summary>
    /// The edit_mode_enabled attribute.
    /// </summary>
    [TerraformPropertyName("edit_mode_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EditModeEnabled { get; set; }

    /// <summary>
    /// The last_modified_time attribute.
    /// </summary>
    [TerraformPropertyName("last_modified_time")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LastModifiedTime => new TerraformReferenceProperty<TerraformProperty<string>>("", "last_modified_time");

    /// <summary>
    /// The output_types attribute.
    /// </summary>
    [TerraformPropertyName("output_types")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? OutputTypes { get; set; }

}

/// <summary>
/// Block type for publish_content_link in .
/// Nesting mode: list
/// </summary>
public class AzurermAutomationRunbookPublishContentLinkBlock : ITerraformBlock
{
    /// <summary>
    /// The uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    [TerraformPropertyName("uri")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Uri { get; set; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformPropertyName("version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Version { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermAutomationRunbookTimeoutsBlock : ITerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

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
    [TerraformPropertyName("automation_account_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AutomationAccountName { get; set; }

    /// <summary>
    /// The content attribute.
    /// </summary>
    [TerraformPropertyName("content")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Content { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "content");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The job_schedule attribute.
    /// </summary>
    [TerraformPropertyName("job_schedule")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<object>>> JobSchedule { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "job_schedule");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The log_activity_trace_level attribute.
    /// </summary>
    [TerraformPropertyName("log_activity_trace_level")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? LogActivityTraceLevel { get; set; }

    /// <summary>
    /// The log_progress attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogProgress is required")]
    [TerraformPropertyName("log_progress")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> LogProgress { get; set; }

    /// <summary>
    /// The log_verbose attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogVerbose is required")]
    [TerraformPropertyName("log_verbose")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> LogVerbose { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// The runbook_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RunbookType is required")]
    [TerraformPropertyName("runbook_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RunbookType { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// Block for draft.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Draft block(s) allowed")]
    [TerraformPropertyName("draft")]
    public TerraformList<TerraformBlock<AzurermAutomationRunbookDraftBlock>>? Draft { get; set; } = new();

    /// <summary>
    /// Block for publish_content_link.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PublishContentLink block(s) allowed")]
    [TerraformPropertyName("publish_content_link")]
    public TerraformList<TerraformBlock<AzurermAutomationRunbookPublishContentLinkBlock>>? PublishContentLink { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermAutomationRunbookTimeoutsBlock>? Timeouts { get; set; } = new();

}
