using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for github_action_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermAppServiceSourceControlSlotGithubActionConfigurationBlock : TerraformBlock
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
public class AzurermAppServiceSourceControlSlotTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_app_service_source_control_slot Terraform resource.
/// Manages a azurerm_app_service_source_control_slot resource.
/// </summary>
public partial class AzurermAppServiceSourceControlSlot(string name) : TerraformResource("azurerm_app_service_source_control_slot", name)
{
    /// <summary>
    /// The URL for the repository
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
    /// The branch name to use for deployments.
    /// </summary>
    public TerraformValue<string> RepoUrl
    {
        get => new TerraformReference<string>(this, "repo_url");
        set => SetArgument("repo_url", value);
    }

    /// <summary>
    /// Should the Deployment Rollback be enabled? Defaults to `false`
    /// </summary>
    public TerraformValue<bool>? RollbackEnabled
    {
        get => new TerraformReference<bool>(this, "rollback_enabled");
        set => SetArgument("rollback_enabled", value);
    }

    /// <summary>
    /// The ID of the Linux or Windows Web App Slot.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SlotId is required")]
    public required TerraformValue<string> SlotId
    {
        get => new TerraformReference<string>(this, "slot_id");
        set => SetArgument("slot_id", value);
    }

    /// <summary>
    /// Should the Slot use local Git configuration.
    /// </summary>
    public TerraformValue<bool>? UseLocalGit
    {
        get => new TerraformReference<bool>(this, "use_local_git");
        set => SetArgument("use_local_git", value);
    }

    /// <summary>
    /// Should code be deployed manually. Set to `true` to disable continuous integration, such as webhooks into online repos such as GitHub. Defaults to `false`
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
    public TerraformList<AzurermAppServiceSourceControlSlotGithubActionConfigurationBlock>? GithubActionConfiguration
    {
        get => GetArgument<TerraformList<AzurermAppServiceSourceControlSlotGithubActionConfigurationBlock>>("github_action_configuration");
        set => SetArgument("github_action_configuration", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermAppServiceSourceControlSlotTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermAppServiceSourceControlSlotTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
