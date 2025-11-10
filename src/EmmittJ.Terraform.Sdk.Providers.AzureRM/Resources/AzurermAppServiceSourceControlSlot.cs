using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for github_action_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermAppServiceSourceControlSlotGithubActionConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Should the service generate the GitHub Action Workflow file. Defaults to `true`
    /// </summary>
    public TerraformProperty<bool>? GenerateWorkflowFile
    {
        get => GetProperty<TerraformProperty<bool>>("generate_workflow_file");
        set => WithProperty("generate_workflow_file", value);
    }

    /// <summary>
    /// Denotes this action uses a Linux base image.
    /// </summary>
    public TerraformProperty<bool>? LinuxAction
    {
        get => GetProperty<TerraformProperty<bool>>("linux_action");
        set => WithProperty("linux_action", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermAppServiceSourceControlSlotTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

/// <summary>
/// Manages a azurerm_app_service_source_control_slot resource.
/// </summary>
public class AzurermAppServiceSourceControlSlot : TerraformResource
{
    public AzurermAppServiceSourceControlSlot(string name) : base("azurerm_app_service_source_control_slot", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("scm_type");
        this.DeclareOutput("uses_github_action");
    }

    /// <summary>
    /// The URL for the repository
    /// </summary>
    public TerraformProperty<string>? Branch
    {
        get => GetProperty<TerraformProperty<string>>("branch");
        set => this.WithProperty("branch", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The branch name to use for deployments.
    /// </summary>
    public TerraformProperty<string>? RepoUrl
    {
        get => GetProperty<TerraformProperty<string>>("repo_url");
        set => this.WithProperty("repo_url", value);
    }

    /// <summary>
    /// Should the Deployment Rollback be enabled? Defaults to `false`
    /// </summary>
    public TerraformProperty<bool>? RollbackEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("rollback_enabled");
        set => this.WithProperty("rollback_enabled", value);
    }

    /// <summary>
    /// The ID of the Linux or Windows Web App Slot.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SlotId is required")]
    public required TerraformProperty<string> SlotId
    {
        get => GetProperty<TerraformProperty<string>>("slot_id");
        set => this.WithProperty("slot_id", value);
    }

    /// <summary>
    /// Should the Slot use local Git configuration.
    /// </summary>
    public TerraformProperty<bool>? UseLocalGit
    {
        get => GetProperty<TerraformProperty<bool>>("use_local_git");
        set => this.WithProperty("use_local_git", value);
    }

    /// <summary>
    /// Should code be deployed manually. Set to `true` to disable continuous integration, such as webhooks into online repos such as GitHub. Defaults to `false`
    /// </summary>
    public TerraformProperty<bool>? UseManualIntegration
    {
        get => GetProperty<TerraformProperty<bool>>("use_manual_integration");
        set => this.WithProperty("use_manual_integration", value);
    }

    /// <summary>
    /// The repository specified is Mercurial. Defaults to `false`.
    /// </summary>
    public TerraformProperty<bool>? UseMercurial
    {
        get => GetProperty<TerraformProperty<bool>>("use_mercurial");
        set => this.WithProperty("use_mercurial", value);
    }

    /// <summary>
    /// Block for github_action_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GithubActionConfiguration block(s) allowed")]
    public List<AzurermAppServiceSourceControlSlotGithubActionConfigurationBlock>? GithubActionConfiguration
    {
        get => GetProperty<List<AzurermAppServiceSourceControlSlotGithubActionConfigurationBlock>>("github_action_configuration");
        set => this.WithProperty("github_action_configuration", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermAppServiceSourceControlSlotTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermAppServiceSourceControlSlotTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
