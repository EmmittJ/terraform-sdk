using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for github_action_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermAppServiceSourceControlSlotGithubActionConfigurationBlock
{
    /// <summary>
    /// Should the service generate the GitHub Action Workflow file. Defaults to `true`
    /// </summary>
    [TerraformPropertyName("generate_workflow_file")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? GenerateWorkflowFile { get; set; }


}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermAppServiceSourceControlSlotTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Manages a azurerm_app_service_source_control_slot resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermAppServiceSourceControlSlot : TerraformResource
{
    public AzurermAppServiceSourceControlSlot(string name) : base("azurerm_app_service_source_control_slot", name)
    {
    }

    /// <summary>
    /// The URL for the repository
    /// </summary>
    [TerraformPropertyName("branch")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Branch { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The branch name to use for deployments.
    /// </summary>
    [TerraformPropertyName("repo_url")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> RepoUrl { get; set; } = default!;

    /// <summary>
    /// Should the Deployment Rollback be enabled? Defaults to `false`
    /// </summary>
    [TerraformPropertyName("rollback_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? RollbackEnabled { get; set; }

    /// <summary>
    /// The ID of the Linux or Windows Web App Slot.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SlotId is required")]
    [TerraformPropertyName("slot_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> SlotId { get; set; }

    /// <summary>
    /// Should the Slot use local Git configuration.
    /// </summary>
    [TerraformPropertyName("use_local_git")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? UseLocalGit { get; set; }

    /// <summary>
    /// Should code be deployed manually. Set to `true` to disable continuous integration, such as webhooks into online repos such as GitHub. Defaults to `false`
    /// </summary>
    [TerraformPropertyName("use_manual_integration")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? UseManualIntegration { get; set; }

    /// <summary>
    /// The repository specified is Mercurial. Defaults to `false`.
    /// </summary>
    [TerraformPropertyName("use_mercurial")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? UseMercurial { get; set; }

    /// <summary>
    /// Block for github_action_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GithubActionConfiguration block(s) allowed")]
    [TerraformPropertyName("github_action_configuration")]
    public TerraformList<TerraformBlock<AzurermAppServiceSourceControlSlotGithubActionConfigurationBlock>>? GithubActionConfiguration { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermAppServiceSourceControlSlotTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The SCM Type in use. This value is decoded by the service from the repository information supplied.
    /// </summary>
    [TerraformPropertyName("scm_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ScmType => new TerraformReference(this, "scm_type");

    /// <summary>
    /// Indicates if the Slot uses a GitHub action for deployment. This value is decoded by the service from the repository information supplied.
    /// </summary>
    [TerraformPropertyName("uses_github_action")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> UsesGithubAction => new TerraformReference(this, "uses_github_action");

}
