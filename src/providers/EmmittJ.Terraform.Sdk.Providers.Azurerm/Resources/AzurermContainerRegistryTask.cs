using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for agent_setting in AzurermContainerRegistryTask.
/// Nesting mode: list
/// </summary>
public class AzurermContainerRegistryTaskAgentSettingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "agent_setting";

    /// <summary>
    /// The cpu attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cpu is required")]
    public required TerraformValue<double> Cpu
    {
        get => new TerraformReference<double>(this, "cpu");
        set => SetArgument("cpu", value);
    }

}


/// <summary>
/// Block type for base_image_trigger in AzurermContainerRegistryTask.
/// Nesting mode: list
/// </summary>
public class AzurermContainerRegistryTaskBaseImageTriggerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "base_image_trigger";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The update_trigger_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? UpdateTriggerEndpoint
    {
        get => new TerraformReference<string>(this, "update_trigger_endpoint");
        set => SetArgument("update_trigger_endpoint", value);
    }

    /// <summary>
    /// The update_trigger_payload_type attribute.
    /// </summary>
    public TerraformValue<string>? UpdateTriggerPayloadType
    {
        get => new TerraformReference<string>(this, "update_trigger_payload_type");
        set => SetArgument("update_trigger_payload_type", value);
    }

}


/// <summary>
/// Block type for docker_step in AzurermContainerRegistryTask.
/// Nesting mode: list
/// </summary>
public class AzurermContainerRegistryTaskDockerStepBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "docker_step";

    /// <summary>
    /// The arguments attribute.
    /// </summary>
    public TerraformMap<string>? Arguments
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "arguments").ResolveNodes(ctx));
        set => SetArgument("arguments", value);
    }

    /// <summary>
    /// The cache_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? CacheEnabled
    {
        get => new TerraformReference<bool>(this, "cache_enabled");
        set => SetArgument("cache_enabled", value);
    }

    /// <summary>
    /// The context_access_token attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContextAccessToken is required")]
    public required TerraformValue<string> ContextAccessToken
    {
        get => new TerraformReference<string>(this, "context_access_token");
        set => SetArgument("context_access_token", value);
    }

    /// <summary>
    /// The context_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContextPath is required")]
    public required TerraformValue<string> ContextPath
    {
        get => new TerraformReference<string>(this, "context_path");
        set => SetArgument("context_path", value);
    }

    /// <summary>
    /// The dockerfile_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DockerfilePath is required")]
    public required TerraformValue<string> DockerfilePath
    {
        get => new TerraformReference<string>(this, "dockerfile_path");
        set => SetArgument("dockerfile_path", value);
    }

    /// <summary>
    /// The image_names attribute.
    /// </summary>
    public TerraformList<string>? ImageNames
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "image_names").ResolveNodes(ctx));
        set => SetArgument("image_names", value);
    }

    /// <summary>
    /// The push_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? PushEnabled
    {
        get => new TerraformReference<bool>(this, "push_enabled");
        set => SetArgument("push_enabled", value);
    }

    /// <summary>
    /// The secret_arguments attribute.
    /// </summary>
    public TerraformMap<string>? SecretArguments
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "secret_arguments").ResolveNodes(ctx));
        set => SetArgument("secret_arguments", value);
    }

    /// <summary>
    /// The target attribute.
    /// </summary>
    public TerraformValue<string>? Target
    {
        get => new TerraformReference<string>(this, "target");
        set => SetArgument("target", value);
    }

}


/// <summary>
/// Block type for encoded_step in AzurermContainerRegistryTask.
/// Nesting mode: list
/// </summary>
public class AzurermContainerRegistryTaskEncodedStepBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "encoded_step";

    /// <summary>
    /// The context_access_token attribute.
    /// </summary>
    public TerraformValue<string>? ContextAccessToken
    {
        get => new TerraformReference<string>(this, "context_access_token");
        set => SetArgument("context_access_token", value);
    }

    /// <summary>
    /// The context_path attribute.
    /// </summary>
    public TerraformValue<string>? ContextPath
    {
        get => new TerraformReference<string>(this, "context_path");
        set => SetArgument("context_path", value);
    }

    /// <summary>
    /// The secret_values attribute.
    /// </summary>
    public TerraformMap<string>? SecretValues
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "secret_values").ResolveNodes(ctx));
        set => SetArgument("secret_values", value);
    }

    /// <summary>
    /// The task_content attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TaskContent is required")]
    public required TerraformValue<string> TaskContent
    {
        get => new TerraformReference<string>(this, "task_content");
        set => SetArgument("task_content", value);
    }

    /// <summary>
    /// The value_content attribute.
    /// </summary>
    public TerraformValue<string>? ValueContent
    {
        get => new TerraformReference<string>(this, "value_content");
        set => SetArgument("value_content", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    public TerraformMap<string>? ValuesAttribute
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "values").ResolveNodes(ctx));
        set => SetArgument("values", value);
    }

}


/// <summary>
/// Block type for file_step in AzurermContainerRegistryTask.
/// Nesting mode: list
/// </summary>
public class AzurermContainerRegistryTaskFileStepBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "file_step";

    /// <summary>
    /// The context_access_token attribute.
    /// </summary>
    public TerraformValue<string>? ContextAccessToken
    {
        get => new TerraformReference<string>(this, "context_access_token");
        set => SetArgument("context_access_token", value);
    }

    /// <summary>
    /// The context_path attribute.
    /// </summary>
    public TerraformValue<string>? ContextPath
    {
        get => new TerraformReference<string>(this, "context_path");
        set => SetArgument("context_path", value);
    }

    /// <summary>
    /// The secret_values attribute.
    /// </summary>
    public TerraformMap<string>? SecretValues
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "secret_values").ResolveNodes(ctx));
        set => SetArgument("secret_values", value);
    }

    /// <summary>
    /// The task_file_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TaskFilePath is required")]
    public required TerraformValue<string> TaskFilePath
    {
        get => new TerraformReference<string>(this, "task_file_path");
        set => SetArgument("task_file_path", value);
    }

    /// <summary>
    /// The value_file_path attribute.
    /// </summary>
    public TerraformValue<string>? ValueFilePath
    {
        get => new TerraformReference<string>(this, "value_file_path");
        set => SetArgument("value_file_path", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    public TerraformMap<string>? ValuesAttribute
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "values").ResolveNodes(ctx));
        set => SetArgument("values", value);
    }

}


/// <summary>
/// Block type for identity in AzurermContainerRegistryTask.
/// Nesting mode: list
/// </summary>
public class AzurermContainerRegistryTaskIdentityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "identity";

    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    public TerraformSet<string>? IdentityIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "identity_ids").ResolveNodes(ctx));
        set => SetArgument("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformValue<string> PrincipalId
    {
        get => new TerraformReference<string>(this, "principal_id");
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string> TenantId
    {
        get => new TerraformReference<string>(this, "tenant_id");
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for platform in AzurermContainerRegistryTask.
/// Nesting mode: list
/// </summary>
public class AzurermContainerRegistryTaskPlatformBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "platform";

    /// <summary>
    /// The architecture attribute.
    /// </summary>
    public TerraformValue<string>? Architecture
    {
        get => new TerraformReference<string>(this, "architecture");
        set => SetArgument("architecture", value);
    }

    /// <summary>
    /// The os attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Os is required")]
    public required TerraformValue<string> Os
    {
        get => new TerraformReference<string>(this, "os");
        set => SetArgument("os", value);
    }

    /// <summary>
    /// The variant attribute.
    /// </summary>
    public TerraformValue<string>? Variant
    {
        get => new TerraformReference<string>(this, "variant");
        set => SetArgument("variant", value);
    }

}


/// <summary>
/// Block type for registry_credential in AzurermContainerRegistryTask.
/// Nesting mode: list
/// </summary>
public class AzurermContainerRegistryTaskRegistryCredentialBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "registry_credential";

    /// <summary>
    /// Custom block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermContainerRegistryTaskRegistryCredentialBlockCustomBlock>? Custom
    {
        get => GetArgument<TerraformSet<AzurermContainerRegistryTaskRegistryCredentialBlockCustomBlock>>("custom");
        set => SetArgument("custom", value);
    }

    /// <summary>
    /// Source block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Source block(s) allowed")]
    public TerraformList<AzurermContainerRegistryTaskRegistryCredentialBlockSourceBlock>? Source
    {
        get => GetArgument<TerraformList<AzurermContainerRegistryTaskRegistryCredentialBlockSourceBlock>>("source");
        set => SetArgument("source", value);
    }

}

/// <summary>
/// Block type for custom in AzurermContainerRegistryTaskRegistryCredentialBlock.
/// Nesting mode: set
/// </summary>
public class AzurermContainerRegistryTaskRegistryCredentialBlockCustomBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom";

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformValue<string>? Identity
    {
        get => new TerraformReference<string>(this, "identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// The login_server attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoginServer is required")]
    public required TerraformValue<string> LoginServer
    {
        get => new TerraformReference<string>(this, "login_server");
        set => SetArgument("login_server", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    public TerraformValue<string>? Password
    {
        get => new TerraformReference<string>(this, "password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    public TerraformValue<string>? Username
    {
        get => new TerraformReference<string>(this, "username");
        set => SetArgument("username", value);
    }

}

/// <summary>
/// Block type for source in AzurermContainerRegistryTaskRegistryCredentialBlock.
/// Nesting mode: list
/// </summary>
public class AzurermContainerRegistryTaskRegistryCredentialBlockSourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "source";

    /// <summary>
    /// The login_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoginMode is required")]
    public required TerraformValue<string> LoginMode
    {
        get => new TerraformReference<string>(this, "login_mode");
        set => SetArgument("login_mode", value);
    }

}


/// <summary>
/// Block type for source_trigger in AzurermContainerRegistryTask.
/// Nesting mode: list
/// </summary>
public class AzurermContainerRegistryTaskSourceTriggerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "source_trigger";

    /// <summary>
    /// The branch attribute.
    /// </summary>
    public TerraformValue<string>? Branch
    {
        get => new TerraformReference<string>(this, "branch");
        set => SetArgument("branch", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The events attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Events is required")]
    public TerraformList<string>? Events
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "events").ResolveNodes(ctx));
        set => SetArgument("events", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The repository_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryUrl is required")]
    public required TerraformValue<string> RepositoryUrl
    {
        get => new TerraformReference<string>(this, "repository_url");
        set => SetArgument("repository_url", value);
    }

    /// <summary>
    /// The source_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceType is required")]
    public required TerraformValue<string> SourceType
    {
        get => new TerraformReference<string>(this, "source_type");
        set => SetArgument("source_type", value);
    }

    /// <summary>
    /// Authentication block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Authentication block(s) allowed")]
    public TerraformList<AzurermContainerRegistryTaskSourceTriggerBlockAuthenticationBlock>? Authentication
    {
        get => GetArgument<TerraformList<AzurermContainerRegistryTaskSourceTriggerBlockAuthenticationBlock>>("authentication");
        set => SetArgument("authentication", value);
    }

}

/// <summary>
/// Block type for authentication in AzurermContainerRegistryTaskSourceTriggerBlock.
/// Nesting mode: list
/// </summary>
public class AzurermContainerRegistryTaskSourceTriggerBlockAuthenticationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "authentication";

    /// <summary>
    /// The expire_in_seconds attribute.
    /// </summary>
    public TerraformValue<double>? ExpireInSeconds
    {
        get => new TerraformReference<double>(this, "expire_in_seconds");
        set => SetArgument("expire_in_seconds", value);
    }

    /// <summary>
    /// The refresh_token attribute.
    /// </summary>
    public TerraformValue<string>? RefreshToken
    {
        get => new TerraformReference<string>(this, "refresh_token");
        set => SetArgument("refresh_token", value);
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    public TerraformValue<string>? Scope
    {
        get => new TerraformReference<string>(this, "scope");
        set => SetArgument("scope", value);
    }

    /// <summary>
    /// The token attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Token is required")]
    public required TerraformValue<string> Token
    {
        get => new TerraformReference<string>(this, "token");
        set => SetArgument("token", value);
    }

    /// <summary>
    /// The token_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TokenType is required")]
    public required TerraformValue<string> TokenType
    {
        get => new TerraformReference<string>(this, "token_type");
        set => SetArgument("token_type", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermContainerRegistryTask.
/// Nesting mode: single
/// </summary>
public class AzurermContainerRegistryTaskTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Block type for timer_trigger in AzurermContainerRegistryTask.
/// Nesting mode: list
/// </summary>
public class AzurermContainerRegistryTaskTimerTriggerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timer_trigger";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The schedule attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Schedule is required")]
    public required TerraformValue<string> Schedule
    {
        get => new TerraformReference<string>(this, "schedule");
        set => SetArgument("schedule", value);
    }

}


/// <summary>
/// Represents a azurerm_container_registry_task Terraform resource.
/// Manages a azurerm_container_registry_task resource.
/// </summary>
public partial class AzurermContainerRegistryTask(string name) : TerraformResource("azurerm_container_registry_task", name)
{
    /// <summary>
    /// The agent_pool_name attribute.
    /// </summary>
    public TerraformValue<string>? AgentPoolName
    {
        get => new TerraformReference<string>(this, "agent_pool_name");
        set => SetArgument("agent_pool_name", value);
    }

    /// <summary>
    /// The container_registry_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerRegistryId is required")]
    public required TerraformValue<string> ContainerRegistryId
    {
        get => new TerraformReference<string>(this, "container_registry_id");
        set => SetArgument("container_registry_id", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
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
    /// The is_system_task attribute.
    /// </summary>
    public TerraformValue<bool>? IsSystemTask
    {
        get => new TerraformReference<bool>(this, "is_system_task");
        set => SetArgument("is_system_task", value);
    }

    /// <summary>
    /// The log_template attribute.
    /// </summary>
    public TerraformValue<string>? LogTemplate
    {
        get => new TerraformReference<string>(this, "log_template");
        set => SetArgument("log_template", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The timeout_in_seconds attribute.
    /// </summary>
    public TerraformValue<double>? TimeoutInSeconds
    {
        get => new TerraformReference<double>(this, "timeout_in_seconds");
        set => SetArgument("timeout_in_seconds", value);
    }

    /// <summary>
    /// AgentSetting block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AgentSetting block(s) allowed")]
    public TerraformList<AzurermContainerRegistryTaskAgentSettingBlock>? AgentSetting
    {
        get => GetArgument<TerraformList<AzurermContainerRegistryTaskAgentSettingBlock>>("agent_setting");
        set => SetArgument("agent_setting", value);
    }

    /// <summary>
    /// BaseImageTrigger block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BaseImageTrigger block(s) allowed")]
    public TerraformList<AzurermContainerRegistryTaskBaseImageTriggerBlock>? BaseImageTrigger
    {
        get => GetArgument<TerraformList<AzurermContainerRegistryTaskBaseImageTriggerBlock>>("base_image_trigger");
        set => SetArgument("base_image_trigger", value);
    }

    /// <summary>
    /// DockerStep block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DockerStep block(s) allowed")]
    public TerraformList<AzurermContainerRegistryTaskDockerStepBlock>? DockerStep
    {
        get => GetArgument<TerraformList<AzurermContainerRegistryTaskDockerStepBlock>>("docker_step");
        set => SetArgument("docker_step", value);
    }

    /// <summary>
    /// EncodedStep block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncodedStep block(s) allowed")]
    public TerraformList<AzurermContainerRegistryTaskEncodedStepBlock>? EncodedStep
    {
        get => GetArgument<TerraformList<AzurermContainerRegistryTaskEncodedStepBlock>>("encoded_step");
        set => SetArgument("encoded_step", value);
    }

    /// <summary>
    /// FileStep block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FileStep block(s) allowed")]
    public TerraformList<AzurermContainerRegistryTaskFileStepBlock>? FileStep
    {
        get => GetArgument<TerraformList<AzurermContainerRegistryTaskFileStepBlock>>("file_step");
        set => SetArgument("file_step", value);
    }

    /// <summary>
    /// Identity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public TerraformList<AzurermContainerRegistryTaskIdentityBlock>? Identity
    {
        get => GetArgument<TerraformList<AzurermContainerRegistryTaskIdentityBlock>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// Platform block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Platform block(s) allowed")]
    public TerraformList<AzurermContainerRegistryTaskPlatformBlock>? Platform
    {
        get => GetArgument<TerraformList<AzurermContainerRegistryTaskPlatformBlock>>("platform");
        set => SetArgument("platform", value);
    }

    /// <summary>
    /// RegistryCredential block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RegistryCredential block(s) allowed")]
    public TerraformList<AzurermContainerRegistryTaskRegistryCredentialBlock>? RegistryCredential
    {
        get => GetArgument<TerraformList<AzurermContainerRegistryTaskRegistryCredentialBlock>>("registry_credential");
        set => SetArgument("registry_credential", value);
    }

    /// <summary>
    /// SourceTrigger block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermContainerRegistryTaskSourceTriggerBlock>? SourceTrigger
    {
        get => GetArgument<TerraformList<AzurermContainerRegistryTaskSourceTriggerBlock>>("source_trigger");
        set => SetArgument("source_trigger", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermContainerRegistryTaskTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermContainerRegistryTaskTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// TimerTrigger block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermContainerRegistryTaskTimerTriggerBlock>? TimerTrigger
    {
        get => GetArgument<TerraformList<AzurermContainerRegistryTaskTimerTriggerBlock>>("timer_trigger");
        set => SetArgument("timer_trigger", value);
    }

}
