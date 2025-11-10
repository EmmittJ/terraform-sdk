using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for github_action_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermAppServiceSourceControlGithubActionConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// Should the service generate the GitHub Action Workflow file. Defaults to `true`
    /// </summary>
    [TerraformPropertyName("generate_workflow_file")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? GenerateWorkflowFile { get; set; }

    /// <summary>
    /// Denotes this action uses a Linux base image.
    /// </summary>
    [TerraformPropertyName("linux_action")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> LinuxAction => new TerraformReferenceProperty<TerraformProperty<bool>>("", "linux_action");

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermAppServiceSourceControlTimeoutsBlock : ITerraformBlock
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

}

/// <summary>
/// Manages a azurerm_app_service_source_control resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermAppServiceSourceControl : TerraformResource
{
    public AzurermAppServiceSourceControl(string name) : base("azurerm_app_service_source_control", name)
    {
    }

    /// <summary>
    /// The ID of the Windows or Linux Web App.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppId is required")]
    [TerraformPropertyName("app_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AppId { get; set; }

    /// <summary>
    /// The branch name to use for deployments.
    /// </summary>
    [TerraformPropertyName("branch")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Branch { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "branch");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The URL for the repository.
    /// </summary>
    [TerraformPropertyName("repo_url")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> RepoUrl { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "repo_url");

    /// <summary>
    /// Should the Deployment Rollback be enabled? Defaults to `false`.
    /// </summary>
    [TerraformPropertyName("rollback_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? RollbackEnabled { get; set; }

    /// <summary>
    /// Should the App use local Git configuration.
    /// </summary>
    [TerraformPropertyName("use_local_git")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? UseLocalGit { get; set; }

    /// <summary>
    /// Should code be deployed manually. Set to `false` to enable continuous integration, such as webhooks into online repos such as GitHub. Defaults to `false`.
    /// </summary>
    [TerraformPropertyName("use_manual_integration")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? UseManualIntegration { get; set; }

    /// <summary>
    /// The repository specified is Mercurial. Defaults to `false`.
    /// </summary>
    [TerraformPropertyName("use_mercurial")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? UseMercurial { get; set; }

    /// <summary>
    /// Block for github_action_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GithubActionConfiguration block(s) allowed")]
    [TerraformPropertyName("github_action_configuration")]
    public TerraformList<TerraformBlock<AzurermAppServiceSourceControlGithubActionConfigurationBlock>>? GithubActionConfiguration { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermAppServiceSourceControlTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The SCM Type in use. This value is decoded by the service from the repository information supplied.
    /// </summary>
    [TerraformPropertyName("scm_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ScmType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "scm_type");

    /// <summary>
    /// Indicates if the Slot uses a GitHub action for deployment. This value is decoded by the service from the repository information supplied.
    /// </summary>
    [TerraformPropertyName("uses_github_action")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> UsesGithubAction => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "uses_github_action");

}
