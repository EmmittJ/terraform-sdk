using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for github_action_configuration in AzurermAppServiceSourceControl.
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
        get => GetArgument<TerraformValue<bool>>("generate_workflow_file");
        set => SetArgument("generate_workflow_file", value);
    }

    /// <summary>
    /// Denotes this action uses a Linux base image.
    /// </summary>
    public TerraformValue<bool> LinuxAction
        => AsReference("linux_action");

    /// <summary>
    /// CodeConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CodeConfiguration block(s) allowed")]
    public TerraformList<AzurermAppServiceSourceControlGithubActionConfigurationBlockCodeConfigurationBlock>? CodeConfiguration
    {
        get => GetArgument<TerraformList<AzurermAppServiceSourceControlGithubActionConfigurationBlockCodeConfigurationBlock>>("code_configuration");
        set => SetArgument("code_configuration", value);
    }

    /// <summary>
    /// ContainerConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ContainerConfiguration block(s) allowed")]
    public TerraformList<AzurermAppServiceSourceControlGithubActionConfigurationBlockContainerConfigurationBlock>? ContainerConfiguration
    {
        get => GetArgument<TerraformList<AzurermAppServiceSourceControlGithubActionConfigurationBlockContainerConfigurationBlock>>("container_configuration");
        set => SetArgument("container_configuration", value);
    }

}

/// <summary>
/// Block type for code_configuration in AzurermAppServiceSourceControlGithubActionConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AzurermAppServiceSourceControlGithubActionConfigurationBlockCodeConfigurationBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("runtime_stack");
        set => SetArgument("runtime_stack", value);
    }

    /// <summary>
    /// The value to use for the Runtime Version in the workflow file content for code base apps.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuntimeVersion is required")]
    public required TerraformValue<string> RuntimeVersion
    {
        get => GetArgument<TerraformValue<string>>("runtime_version");
        set => SetArgument("runtime_version", value);
    }

}

/// <summary>
/// Block type for container_configuration in AzurermAppServiceSourceControlGithubActionConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AzurermAppServiceSourceControlGithubActionConfigurationBlockContainerConfigurationBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("image_name");
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
        get => GetArgument<TerraformValue<string>>("registry_url");
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
/// Block type for timeouts in AzurermAppServiceSourceControl.
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
        get => GetArgument<TerraformValue<string>>("app_id");
        set => SetArgument("app_id", value);
    }

    /// <summary>
    /// The branch name to use for deployments.
    /// </summary>
    public TerraformValue<string>? Branch
    {
        get => GetArgument<TerraformValue<string>>("branch");
        set => SetArgument("branch", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The URL for the repository.
    /// </summary>
    public TerraformValue<string>? RepoUrl
    {
        get => GetArgument<TerraformValue<string>>("repo_url");
        set => SetArgument("repo_url", value);
    }

    /// <summary>
    /// Should the Deployment Rollback be enabled? Defaults to `false`.
    /// </summary>
    public TerraformValue<bool>? RollbackEnabled
    {
        get => GetArgument<TerraformValue<bool>>("rollback_enabled");
        set => SetArgument("rollback_enabled", value);
    }

    /// <summary>
    /// Should the App use local Git configuration.
    /// </summary>
    public TerraformValue<bool>? UseLocalGit
    {
        get => GetArgument<TerraformValue<bool>>("use_local_git");
        set => SetArgument("use_local_git", value);
    }

    /// <summary>
    /// Should code be deployed manually. Set to `false` to enable continuous integration, such as webhooks into online repos such as GitHub. Defaults to `false`.
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
        => AsReference("scm_type");

    /// <summary>
    /// Indicates if the Slot uses a GitHub action for deployment. This value is decoded by the service from the repository information supplied.
    /// </summary>
    public TerraformValue<bool> UsesGithubAction
        => AsReference("uses_github_action");

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
