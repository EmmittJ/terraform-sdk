using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for github_action_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AzurermAppServiceSourceControlSlotGithubActionConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// Should the service generate the GitHub Action Workflow file. Defaults to `true`
    /// </summary>
    [TerraformProperty("generate_workflow_file")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? GenerateWorkflowFile { get; set; }


}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermAppServiceSourceControlSlotTimeoutsBlock : TerraformBlockBase
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

}

/// <summary>
/// Manages a azurerm_app_service_source_control_slot resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermAppServiceSourceControlSlot : TerraformResource
{
    public AzurermAppServiceSourceControlSlot(string name) : base("azurerm_app_service_source_control_slot", name)
    {
    }

    /// <summary>
    /// The URL for the repository
    /// </summary>
    [TerraformProperty("branch")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Branch { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The branch name to use for deployments.
    /// </summary>
    [TerraformProperty("repo_url")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> RepoUrl { get; set; }

    /// <summary>
    /// Should the Deployment Rollback be enabled? Defaults to `false`
    /// </summary>
    [TerraformProperty("rollback_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? RollbackEnabled { get; set; }

    /// <summary>
    /// The ID of the Linux or Windows Web App Slot.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SlotId is required")]
    [TerraformProperty("slot_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SlotId { get; set; }

    /// <summary>
    /// Should the Slot use local Git configuration.
    /// </summary>
    [TerraformProperty("use_local_git")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? UseLocalGit { get; set; }

    /// <summary>
    /// Should code be deployed manually. Set to `true` to disable continuous integration, such as webhooks into online repos such as GitHub. Defaults to `false`
    /// </summary>
    [TerraformProperty("use_manual_integration")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? UseManualIntegration { get; set; }

    /// <summary>
    /// The repository specified is Mercurial. Defaults to `false`.
    /// </summary>
    [TerraformProperty("use_mercurial")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? UseMercurial { get; set; }

    /// <summary>
    /// Block for github_action_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GithubActionConfiguration block(s) allowed")]
    [TerraformProperty("github_action_configuration")]
    public TerraformList<TerraformBlock<AzurermAppServiceSourceControlSlotGithubActionConfigurationBlock>>? GithubActionConfiguration { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermAppServiceSourceControlSlotTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The SCM Type in use. This value is decoded by the service from the repository information supplied.
    /// </summary>
    [TerraformProperty("scm_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ScmType { get; }

    /// <summary>
    /// Indicates if the Slot uses a GitHub action for deployment. This value is decoded by the service from the repository information supplied.
    /// </summary>
    [TerraformProperty("uses_github_action")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> UsesGithubAction { get; }

}
