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
/// Block type for github_action_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermAppServiceSourceControlGithubActionConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "github_action_configuration";

    /// <summary>
    /// Should the service generate the GitHub Action Workflow file. Defaults to `true`
    /// </summary>
    [TerraformArgument("generate_workflow_file")]
    public TerraformValue<bool>? GenerateWorkflowFile
    {
        get => new TerraformReference<bool>(this, "generate_workflow_file");
        set => SetArgument("generate_workflow_file", value);
    }


}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermAppServiceSourceControlTimeoutsBlock : TerraformBlock
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
    [TerraformArgument("app_id")]
    public required TerraformValue<string> AppId
    {
        get => new TerraformReference<string>(this, "app_id");
        set => SetArgument("app_id", value);
    }

    /// <summary>
    /// The branch name to use for deployments.
    /// </summary>
    [TerraformArgument("branch")]
    public TerraformValue<string> Branch
    {
        get => new TerraformReference<string>(this, "branch");
        set => SetArgument("branch", value);
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
    /// The URL for the repository.
    /// </summary>
    [TerraformArgument("repo_url")]
    public TerraformValue<string> RepoUrl
    {
        get => new TerraformReference<string>(this, "repo_url");
        set => SetArgument("repo_url", value);
    }

    /// <summary>
    /// Should the Deployment Rollback be enabled? Defaults to `false`.
    /// </summary>
    [TerraformArgument("rollback_enabled")]
    public TerraformValue<bool>? RollbackEnabled
    {
        get => new TerraformReference<bool>(this, "rollback_enabled");
        set => SetArgument("rollback_enabled", value);
    }

    /// <summary>
    /// Should the App use local Git configuration.
    /// </summary>
    [TerraformArgument("use_local_git")]
    public TerraformValue<bool>? UseLocalGit
    {
        get => new TerraformReference<bool>(this, "use_local_git");
        set => SetArgument("use_local_git", value);
    }

    /// <summary>
    /// Should code be deployed manually. Set to `false` to enable continuous integration, such as webhooks into online repos such as GitHub. Defaults to `false`.
    /// </summary>
    [TerraformArgument("use_manual_integration")]
    public TerraformValue<bool>? UseManualIntegration
    {
        get => new TerraformReference<bool>(this, "use_manual_integration");
        set => SetArgument("use_manual_integration", value);
    }

    /// <summary>
    /// The repository specified is Mercurial. Defaults to `false`.
    /// </summary>
    [TerraformArgument("use_mercurial")]
    public TerraformValue<bool>? UseMercurial
    {
        get => new TerraformReference<bool>(this, "use_mercurial");
        set => SetArgument("use_mercurial", value);
    }

    /// <summary>
    /// Block for github_action_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GithubActionConfiguration block(s) allowed")]
    [TerraformArgument("github_action_configuration")]
    public TerraformList<AzurermAppServiceSourceControlGithubActionConfigurationBlock> GithubActionConfiguration { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermAppServiceSourceControlTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The SCM Type in use. This value is decoded by the service from the repository information supplied.
    /// </summary>
    [TerraformArgument("scm_type")]
    public TerraformValue<string> ScmType
    {
        get => new TerraformReference<string>(this, "scm_type");
    }

    /// <summary>
    /// Indicates if the Slot uses a GitHub action for deployment. This value is decoded by the service from the repository information supplied.
    /// </summary>
    [TerraformArgument("uses_github_action")]
    public TerraformValue<bool> UsesGithubAction
    {
        get => new TerraformReference<bool>(this, "uses_github_action");
    }

}
