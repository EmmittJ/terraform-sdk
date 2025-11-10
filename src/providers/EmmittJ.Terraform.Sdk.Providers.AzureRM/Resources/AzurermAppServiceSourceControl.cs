using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for github_action_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermAppServiceSourceControlGithubActionConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Should the service generate the GitHub Action Workflow file. Defaults to `true`
    /// </summary>
    public TerraformProperty<bool>? GenerateWorkflowFile
    {
        set => SetProperty("generate_workflow_file", value);
    }

    /// <summary>
    /// Denotes this action uses a Linux base image.
    /// </summary>
    public TerraformProperty<bool>? LinuxAction
    {
        set => SetProperty("linux_action", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermAppServiceSourceControlTimeoutsBlock : TerraformBlock
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

}

/// <summary>
/// Manages a azurerm_app_service_source_control resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermAppServiceSourceControl : TerraformResource
{
    public AzurermAppServiceSourceControl(string name) : base("azurerm_app_service_source_control", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("scm_type");
        SetOutput("uses_github_action");
        SetOutput("app_id");
        SetOutput("branch");
        SetOutput("id");
        SetOutput("repo_url");
        SetOutput("rollback_enabled");
        SetOutput("use_local_git");
        SetOutput("use_manual_integration");
        SetOutput("use_mercurial");
    }

    /// <summary>
    /// The ID of the Windows or Linux Web App.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppId is required")]
    public required TerraformProperty<string> AppId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("app_id");
        set => SetProperty("app_id", value);
    }

    /// <summary>
    /// The branch name to use for deployments.
    /// </summary>
    public TerraformProperty<string> Branch
    {
        get => GetRequiredOutput<TerraformProperty<string>>("branch");
        set => SetProperty("branch", value);
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
    /// The URL for the repository.
    /// </summary>
    public TerraformProperty<string> RepoUrl
    {
        get => GetRequiredOutput<TerraformProperty<string>>("repo_url");
        set => SetProperty("repo_url", value);
    }

    /// <summary>
    /// Should the Deployment Rollback be enabled? Defaults to `false`.
    /// </summary>
    public TerraformProperty<bool> RollbackEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("rollback_enabled");
        set => SetProperty("rollback_enabled", value);
    }

    /// <summary>
    /// Should the App use local Git configuration.
    /// </summary>
    public TerraformProperty<bool> UseLocalGit
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("use_local_git");
        set => SetProperty("use_local_git", value);
    }

    /// <summary>
    /// Should code be deployed manually. Set to `false` to enable continuous integration, such as webhooks into online repos such as GitHub. Defaults to `false`.
    /// </summary>
    public TerraformProperty<bool> UseManualIntegration
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("use_manual_integration");
        set => SetProperty("use_manual_integration", value);
    }

    /// <summary>
    /// The repository specified is Mercurial. Defaults to `false`.
    /// </summary>
    public TerraformProperty<bool> UseMercurial
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("use_mercurial");
        set => SetProperty("use_mercurial", value);
    }

    /// <summary>
    /// Block for github_action_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GithubActionConfiguration block(s) allowed")]
    public List<AzurermAppServiceSourceControlGithubActionConfigurationBlock>? GithubActionConfiguration
    {
        set => SetProperty("github_action_configuration", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermAppServiceSourceControlTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The SCM Type in use. This value is decoded by the service from the repository information supplied.
    /// </summary>
    public TerraformExpression ScmType => this["scm_type"];

    /// <summary>
    /// Indicates if the Slot uses a GitHub action for deployment. This value is decoded by the service from the repository information supplied.
    /// </summary>
    public TerraformExpression UsesGithubAction => this["uses_github_action"];

}
