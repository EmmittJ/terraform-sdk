using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for security in .
/// Nesting mode: list
/// </summary>
public partial class AzurermAutomationSourceControlSecurityBlock : TerraformBlockBase
{
    /// <summary>
    /// The refresh_token attribute.
    /// </summary>
    [TerraformProperty("refresh_token")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? RefreshToken { get; set; }

    /// <summary>
    /// The token attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Token is required")]
    [TerraformProperty("token")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Token { get; set; }

    /// <summary>
    /// The token_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TokenType is required")]
    [TerraformProperty("token_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> TokenType { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermAutomationSourceControlTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_automation_source_control resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermAutomationSourceControl : TerraformResource
{
    public AzurermAutomationSourceControl(string name) : base("azurerm_automation_source_control", name)
    {
    }

    /// <summary>
    /// The automatic_sync attribute.
    /// </summary>
    [TerraformProperty("automatic_sync")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? AutomaticSync { get; set; }

    /// <summary>
    /// The automation_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutomationAccountId is required")]
    [TerraformProperty("automation_account_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> AutomationAccountId { get; set; }

    /// <summary>
    /// The branch attribute.
    /// </summary>
    [TerraformProperty("branch")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Branch { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The folder_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FolderPath is required")]
    [TerraformProperty("folder_path")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> FolderPath { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The publish_runbook_enabled attribute.
    /// </summary>
    [TerraformProperty("publish_runbook_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? PublishRunbookEnabled { get; set; }

    /// <summary>
    /// The repository_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryUrl is required")]
    [TerraformProperty("repository_url")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> RepositoryUrl { get; set; }

    /// <summary>
    /// The source_control_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceControlType is required")]
    [TerraformProperty("source_control_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SourceControlType { get; set; }

    /// <summary>
    /// Block for security.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Security is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Security block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Security block(s) allowed")]
    [TerraformProperty("security")]
    public TerraformList<TerraformBlock<AzurermAutomationSourceControlSecurityBlock>>? Security { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermAutomationSourceControlTimeoutsBlock>? Timeouts { get; set; }

}
