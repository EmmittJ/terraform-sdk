using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for github_action_configuration in AzurermAppServiceSourceControlSlot.
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
        get => GetArgument<TerraformValue<bool>>("generate_workflow_file");
        set => SetArgument("generate_workflow_file", value);
    }

    /// <summary>
    /// Denotes this action uses a Linux base image.
    /// </summary>
    public TerraformValue<bool> LinuxAction
        => CreateReference("linux_action");

    /// <summary>
    /// CodeConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CodeConfiguration block(s) allowed")]
    public TerraformList<AzurermAppServiceSourceControlSlotGithubActionConfigurationBlockCodeConfigurationBlock>? CodeConfiguration
    {
        get => GetArgument<TerraformList<AzurermAppServiceSourceControlSlotGithubActionConfigurationBlockCodeConfigurationBlock>>("code_configuration");
        set => SetArgument("code_configuration", value);
    }

    /// <summary>
    /// ContainerConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ContainerConfiguration block(s) allowed")]
    public TerraformList<AzurermAppServiceSourceControlSlotGithubActionConfigurationBlockContainerConfigurationBlock>? ContainerConfiguration
    {
        get => GetArgument<TerraformList<AzurermAppServiceSourceControlSlotGithubActionConfigurationBlockContainerConfigurationBlock>>("container_configuration");
        set => SetArgument("container_configuration", value);
    }

}

/// <summary>
/// Block type for code_configuration in AzurermAppServiceSourceControlSlotGithubActionConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AzurermAppServiceSourceControlSlotGithubActionConfigurationBlockCodeConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "code_configuration";

    /// <summary>
    /// The value to use for the Runtime Stack in the workflow file content for code base apps.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuntimeStack is required")]
    public required TerraformValue<string> RuntimeStack
    {
        get => GetRequiredArgument<TerraformValue<string>>("runtime_stack");
        set => SetArgument("runtime_stack", value);
    }

    /// <summary>
    /// The value to use for the Runtime Version in the workflow file content for code base apps.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuntimeVersion is required")]
    public required TerraformValue<string> RuntimeVersion
    {
        get => GetRequiredArgument<TerraformValue<string>>("runtime_version");
        set => SetArgument("runtime_version", value);
    }

}

/// <summary>
/// Block type for container_configuration in AzurermAppServiceSourceControlSlotGithubActionConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AzurermAppServiceSourceControlSlotGithubActionConfigurationBlockContainerConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "container_configuration";

    /// <summary>
    /// The image name for the build.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ImageName is required")]
    public required TerraformValue<string> ImageName
    {
        get => GetRequiredArgument<TerraformValue<string>>("image_name");
        set => SetArgument("image_name", value);
    }

    /// <summary>
    /// The password used to upload the image to the container registry.
    /// </summary>
    public TerraformValue<string>? RegistryPassword
    {
        get => GetArgument<TerraformValue<string>>("registry_password");
        set => SetArgument("registry_password", value);
    }

    /// <summary>
    /// The server URL for the container registry where the build will be hosted.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RegistryUrl is required")]
    public required TerraformValue<string> RegistryUrl
    {
        get => GetRequiredArgument<TerraformValue<string>>("registry_url");
        set => SetArgument("registry_url", value);
    }

    /// <summary>
    /// The username used to upload the image to the container registry.
    /// </summary>
    public TerraformValue<string>? RegistryUsername
    {
        get => GetArgument<TerraformValue<string>>("registry_username");
        set => SetArgument("registry_username", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermAppServiceSourceControlSlot.
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
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
        get => GetArgument<TerraformValue<string>>("branch") ?? CreateReference("branch");
        set => SetArgument("branch", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The branch name to use for deployments.
    /// </summary>
    public TerraformValue<string> RepoUrl
    {
        get => GetArgument<TerraformValue<string>>("repo_url") ?? CreateReference("repo_url");
        set => SetArgument("repo_url", value);
    }

    /// <summary>
    /// Should the Deployment Rollback be enabled? Defaults to `false`
    /// </summary>
    public TerraformValue<bool>? RollbackEnabled
    {
        get => GetArgument<TerraformValue<bool>>("rollback_enabled");
        set => SetArgument("rollback_enabled", value);
    }

    /// <summary>
    /// The ID of the Linux or Windows Web App Slot.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SlotId is required")]
    public required TerraformValue<string> SlotId
    {
        get => GetRequiredArgument<TerraformValue<string>>("slot_id");
        set => SetArgument("slot_id", value);
    }

    /// <summary>
    /// Should the Slot use local Git configuration.
    /// </summary>
    public TerraformValue<bool>? UseLocalGit
    {
        get => GetArgument<TerraformValue<bool>>("use_local_git");
        set => SetArgument("use_local_git", value);
    }

    /// <summary>
    /// Should code be deployed manually. Set to `true` to disable continuous integration, such as webhooks into online repos such as GitHub. Defaults to `false`
    /// </summary>
    public TerraformValue<bool>? UseManualIntegration
    {
        get => GetArgument<TerraformValue<bool>>("use_manual_integration");
        set => SetArgument("use_manual_integration", value);
    }

    /// <summary>
    /// The repository specified is Mercurial. Defaults to `false`.
    /// </summary>
    public TerraformValue<bool>? UseMercurial
    {
        get => GetArgument<TerraformValue<bool>>("use_mercurial");
        set => SetArgument("use_mercurial", value);
    }

    /// <summary>
    /// The SCM Type in use. This value is decoded by the service from the repository information supplied.
    /// </summary>
    public TerraformValue<string> ScmType
        => CreateReference("scm_type");

    /// <summary>
    /// Indicates if the Slot uses a GitHub action for deployment. This value is decoded by the service from the repository information supplied.
    /// </summary>
    public TerraformValue<bool> UsesGithubAction
        => CreateReference("uses_github_action");

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
