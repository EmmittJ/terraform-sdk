using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for security in .
/// Nesting mode: list
/// </summary>
public class AzurermAutomationSourceControlSecurityBlock : ITerraformBlock
{
    /// <summary>
    /// The refresh_token attribute.
    /// </summary>
    [TerraformPropertyName("refresh_token")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RefreshToken { get; set; }

    /// <summary>
    /// The token attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Token is required")]
    [TerraformPropertyName("token")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Token { get; set; }

    /// <summary>
    /// The token_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TokenType is required")]
    [TerraformPropertyName("token_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> TokenType { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermAutomationSourceControlTimeoutsBlock : ITerraformBlock
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
/// Manages a azurerm_automation_source_control resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermAutomationSourceControl : TerraformResource
{
    public AzurermAutomationSourceControl(string name) : base("azurerm_automation_source_control", name)
    {
    }

    /// <summary>
    /// The automatic_sync attribute.
    /// </summary>
    [TerraformPropertyName("automatic_sync")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AutomaticSync { get; set; }

    /// <summary>
    /// The automation_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutomationAccountId is required")]
    [TerraformPropertyName("automation_account_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AutomationAccountId { get; set; }

    /// <summary>
    /// The branch attribute.
    /// </summary>
    [TerraformPropertyName("branch")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Branch { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The folder_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FolderPath is required")]
    [TerraformPropertyName("folder_path")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> FolderPath { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The publish_runbook_enabled attribute.
    /// </summary>
    [TerraformPropertyName("publish_runbook_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? PublishRunbookEnabled { get; set; }

    /// <summary>
    /// The repository_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryUrl is required")]
    [TerraformPropertyName("repository_url")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RepositoryUrl { get; set; }

    /// <summary>
    /// The source_control_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceControlType is required")]
    [TerraformPropertyName("source_control_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SourceControlType { get; set; }

    /// <summary>
    /// Block for security.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Security is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Security block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Security block(s) allowed")]
    [TerraformPropertyName("security")]
    public TerraformList<TerraformBlock<AzurermAutomationSourceControlSecurityBlock>>? Security { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermAutomationSourceControlTimeoutsBlock>? Timeouts { get; set; } = new();

}
