using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

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
    public TerraformValue<bool>? GenerateWorkflowFile
    {
        get => new TerraformReference<bool>(this, "generate_workflow_file");
        set => SetArgument("generate_workflow_file", value);
    }

    /// <summary>
    /// Denotes this action uses a Linux base image.
    /// </summary>
    public TerraformValue<bool> LinuxAction
    {
        get => new TerraformReference<bool>(this, "linux_action");
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
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Represents a azurerm_app_service_source_control Terraform resource.
/// Manages a azurerm_app_service_source_control resource.
/// </summary>
public partial class AzurermAppServiceSourceControl(string name) : TerraformResource("azurerm_app_service_source_control", name)
{
    /// <summary>
    /// The ID of the Windows or Linux Web App.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppId is required")]
    public required TerraformValue<string> AppId
    {
        get => new TerraformReference<string>(this, "app_id");
        set => SetArgument("app_id", value);
    }

    /// <summary>
    /// The branch name to use for deployments.
    /// </summary>
    public TerraformValue<string> Branch
    {
        get => new TerraformReference<string>(this, "branch");
        set => SetArgument("branch", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The URL for the repository.
    /// </summary>
    public TerraformValue<string> RepoUrl
    {
        get => new TerraformReference<string>(this, "repo_url");
        set => SetArgument("repo_url", value);
    }

    /// <summary>
    /// Should the Deployment Rollback be enabled? Defaults to `false`.
    /// </summary>
    public TerraformValue<bool>? RollbackEnabled
    {
        get => new TerraformReference<bool>(this, "rollback_enabled");
        set => SetArgument("rollback_enabled", value);
    }

    /// <summary>
    /// Should the App use local Git configuration.
    /// </summary>
    public TerraformValue<bool>? UseLocalGit
    {
        get => new TerraformReference<bool>(this, "use_local_git");
        set => SetArgument("use_local_git", value);
    }

    /// <summary>
    /// Should code be deployed manually. Set to `false` to enable continuous integration, such as webhooks into online repos such as GitHub. Defaults to `false`.
    /// </summary>
    public TerraformValue<bool>? UseManualIntegration
    {
        get => new TerraformReference<bool>(this, "use_manual_integration");
        set => SetArgument("use_manual_integration", value);
    }

    /// <summary>
    /// The repository specified is Mercurial. Defaults to `false`.
    /// </summary>
    public TerraformValue<bool>? UseMercurial
    {
        get => new TerraformReference<bool>(this, "use_mercurial");
        set => SetArgument("use_mercurial", value);
    }

    /// <summary>
    /// The SCM Type in use. This value is decoded by the service from the repository information supplied.
    /// </summary>
    public TerraformValue<string> ScmType
    {
        get => new TerraformReference<string>(this, "scm_type");
    }

    /// <summary>
    /// Indicates if the Slot uses a GitHub action for deployment. This value is decoded by the service from the repository information supplied.
    /// </summary>
    public TerraformValue<bool> UsesGithubAction
    {
        get => new TerraformReference<bool>(this, "uses_github_action");
    }

    /// <summary>
    /// GithubActionConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GithubActionConfiguration block(s) allowed")]
    public TerraformList<AzurermAppServiceSourceControlGithubActionConfigurationBlock>? GithubActionConfiguration
    {
        get => GetArgument<TerraformList<AzurermAppServiceSourceControlGithubActionConfigurationBlock>>("github_action_configuration");
        set => SetArgument("github_action_configuration", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermAppServiceSourceControlTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermAppServiceSourceControlTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
