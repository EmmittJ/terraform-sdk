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
/// Block type for agent_setting in .
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
    [TerraformArgument("cpu")]
    public required TerraformValue<double> Cpu
    {
        get => new TerraformReference<double>(this, "cpu");
        set => SetArgument("cpu", value);
    }

}

/// <summary>
/// Block type for base_image_trigger in .
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
    [TerraformArgument("enabled")]
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformArgument("type")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The update_trigger_endpoint attribute.
    /// </summary>
    [TerraformArgument("update_trigger_endpoint")]
    public TerraformValue<string>? UpdateTriggerEndpoint
    {
        get => new TerraformReference<string>(this, "update_trigger_endpoint");
        set => SetArgument("update_trigger_endpoint", value);
    }

    /// <summary>
    /// The update_trigger_payload_type attribute.
    /// </summary>
    [TerraformArgument("update_trigger_payload_type")]
    public TerraformValue<string>? UpdateTriggerPayloadType
    {
        get => new TerraformReference<string>(this, "update_trigger_payload_type");
        set => SetArgument("update_trigger_payload_type", value);
    }

}

/// <summary>
/// Block type for docker_step in .
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
    [TerraformArgument("arguments")]
    public TerraformMap<string>? Arguments
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "arguments").ResolveNodes(ctx));
        set => SetArgument("arguments", value);
    }

    /// <summary>
    /// The cache_enabled attribute.
    /// </summary>
    [TerraformArgument("cache_enabled")]
    public TerraformValue<bool>? CacheEnabled
    {
        get => new TerraformReference<bool>(this, "cache_enabled");
        set => SetArgument("cache_enabled", value);
    }

    /// <summary>
    /// The context_access_token attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContextAccessToken is required")]
    [TerraformArgument("context_access_token")]
    public required TerraformValue<string> ContextAccessToken
    {
        get => new TerraformReference<string>(this, "context_access_token");
        set => SetArgument("context_access_token", value);
    }

    /// <summary>
    /// The context_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContextPath is required")]
    [TerraformArgument("context_path")]
    public required TerraformValue<string> ContextPath
    {
        get => new TerraformReference<string>(this, "context_path");
        set => SetArgument("context_path", value);
    }

    /// <summary>
    /// The dockerfile_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DockerfilePath is required")]
    [TerraformArgument("dockerfile_path")]
    public required TerraformValue<string> DockerfilePath
    {
        get => new TerraformReference<string>(this, "dockerfile_path");
        set => SetArgument("dockerfile_path", value);
    }

    /// <summary>
    /// The image_names attribute.
    /// </summary>
    [TerraformArgument("image_names")]
    public TerraformList<string>? ImageNames
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "image_names").ResolveNodes(ctx));
        set => SetArgument("image_names", value);
    }

    /// <summary>
    /// The push_enabled attribute.
    /// </summary>
    [TerraformArgument("push_enabled")]
    public TerraformValue<bool>? PushEnabled
    {
        get => new TerraformReference<bool>(this, "push_enabled");
        set => SetArgument("push_enabled", value);
    }

    /// <summary>
    /// The secret_arguments attribute.
    /// </summary>
    [TerraformArgument("secret_arguments")]
    public TerraformMap<string>? SecretArguments
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "secret_arguments").ResolveNodes(ctx));
        set => SetArgument("secret_arguments", value);
    }

    /// <summary>
    /// The target attribute.
    /// </summary>
    [TerraformArgument("target")]
    public TerraformValue<string>? Target
    {
        get => new TerraformReference<string>(this, "target");
        set => SetArgument("target", value);
    }

}

/// <summary>
/// Block type for encoded_step in .
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
    [TerraformArgument("context_access_token")]
    public TerraformValue<string>? ContextAccessToken
    {
        get => new TerraformReference<string>(this, "context_access_token");
        set => SetArgument("context_access_token", value);
    }

    /// <summary>
    /// The context_path attribute.
    /// </summary>
    [TerraformArgument("context_path")]
    public TerraformValue<string>? ContextPath
    {
        get => new TerraformReference<string>(this, "context_path");
        set => SetArgument("context_path", value);
    }

    /// <summary>
    /// The secret_values attribute.
    /// </summary>
    [TerraformArgument("secret_values")]
    public TerraformMap<string>? SecretValues
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "secret_values").ResolveNodes(ctx));
        set => SetArgument("secret_values", value);
    }

    /// <summary>
    /// The task_content attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TaskContent is required")]
    [TerraformArgument("task_content")]
    public required TerraformValue<string> TaskContent
    {
        get => new TerraformReference<string>(this, "task_content");
        set => SetArgument("task_content", value);
    }

    /// <summary>
    /// The value_content attribute.
    /// </summary>
    [TerraformArgument("value_content")]
    public TerraformValue<string>? ValueContent
    {
        get => new TerraformReference<string>(this, "value_content");
        set => SetArgument("value_content", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [TerraformArgument("values")]
    public TerraformMap<string>? Values
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "values").ResolveNodes(ctx));
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for file_step in .
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
    [TerraformArgument("context_access_token")]
    public TerraformValue<string>? ContextAccessToken
    {
        get => new TerraformReference<string>(this, "context_access_token");
        set => SetArgument("context_access_token", value);
    }

    /// <summary>
    /// The context_path attribute.
    /// </summary>
    [TerraformArgument("context_path")]
    public TerraformValue<string>? ContextPath
    {
        get => new TerraformReference<string>(this, "context_path");
        set => SetArgument("context_path", value);
    }

    /// <summary>
    /// The secret_values attribute.
    /// </summary>
    [TerraformArgument("secret_values")]
    public TerraformMap<string>? SecretValues
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "secret_values").ResolveNodes(ctx));
        set => SetArgument("secret_values", value);
    }

    /// <summary>
    /// The task_file_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TaskFilePath is required")]
    [TerraformArgument("task_file_path")]
    public required TerraformValue<string> TaskFilePath
    {
        get => new TerraformReference<string>(this, "task_file_path");
        set => SetArgument("task_file_path", value);
    }

    /// <summary>
    /// The value_file_path attribute.
    /// </summary>
    [TerraformArgument("value_file_path")]
    public TerraformValue<string>? ValueFilePath
    {
        get => new TerraformReference<string>(this, "value_file_path");
        set => SetArgument("value_file_path", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [TerraformArgument("values")]
    public TerraformMap<string>? Values
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "values").ResolveNodes(ctx));
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for identity in .
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
    [TerraformArgument("identity_ids")]
    public TerraformSet<string>? IdentityIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "identity_ids").ResolveNodes(ctx));
        set => SetArgument("identity_ids", value);
    }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformArgument("type")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for platform in .
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
    [TerraformArgument("architecture")]
    public TerraformValue<string>? Architecture
    {
        get => new TerraformReference<string>(this, "architecture");
        set => SetArgument("architecture", value);
    }

    /// <summary>
    /// The os attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Os is required")]
    [TerraformArgument("os")]
    public required TerraformValue<string> Os
    {
        get => new TerraformReference<string>(this, "os");
        set => SetArgument("os", value);
    }

    /// <summary>
    /// The variant attribute.
    /// </summary>
    [TerraformArgument("variant")]
    public TerraformValue<string>? Variant
    {
        get => new TerraformReference<string>(this, "variant");
        set => SetArgument("variant", value);
    }

}

/// <summary>
/// Block type for registry_credential in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerRegistryTaskRegistryCredentialBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "registry_credential";

}

/// <summary>
/// Block type for source_trigger in .
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
    [TerraformArgument("branch")]
    public TerraformValue<string>? Branch
    {
        get => new TerraformReference<string>(this, "branch");
        set => SetArgument("branch", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformArgument("enabled")]
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The events attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Events is required")]
    [TerraformArgument("events")]
    public TerraformList<string>? Events
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "events").ResolveNodes(ctx));
        set => SetArgument("events", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The repository_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryUrl is required")]
    [TerraformArgument("repository_url")]
    public required TerraformValue<string> RepositoryUrl
    {
        get => new TerraformReference<string>(this, "repository_url");
        set => SetArgument("repository_url", value);
    }

    /// <summary>
    /// The source_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceType is required")]
    [TerraformArgument("source_type")]
    public required TerraformValue<string> SourceType
    {
        get => new TerraformReference<string>(this, "source_type");
        set => SetArgument("source_type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Block type for timer_trigger in .
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
    [TerraformArgument("enabled")]
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The schedule attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Schedule is required")]
    [TerraformArgument("schedule")]
    public required TerraformValue<string> Schedule
    {
        get => new TerraformReference<string>(this, "schedule");
        set => SetArgument("schedule", value);
    }

}

/// <summary>
/// Manages a azurerm_container_registry_task resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermContainerRegistryTask : TerraformResource
{
    public AzurermContainerRegistryTask(string name) : base("azurerm_container_registry_task", name)
    {
    }

    /// <summary>
    /// The agent_pool_name attribute.
    /// </summary>
    [TerraformArgument("agent_pool_name")]
    public TerraformValue<string>? AgentPoolName
    {
        get => new TerraformReference<string>(this, "agent_pool_name");
        set => SetArgument("agent_pool_name", value);
    }

    /// <summary>
    /// The container_registry_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerRegistryId is required")]
    [TerraformArgument("container_registry_id")]
    public required TerraformValue<string> ContainerRegistryId
    {
        get => new TerraformReference<string>(this, "container_registry_id");
        set => SetArgument("container_registry_id", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformArgument("enabled")]
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
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
    /// The is_system_task attribute.
    /// </summary>
    [TerraformArgument("is_system_task")]
    public TerraformValue<bool>? IsSystemTask
    {
        get => new TerraformReference<bool>(this, "is_system_task");
        set => SetArgument("is_system_task", value);
    }

    /// <summary>
    /// The log_template attribute.
    /// </summary>
    [TerraformArgument("log_template")]
    public TerraformValue<string>? LogTemplate
    {
        get => new TerraformReference<string>(this, "log_template");
        set => SetArgument("log_template", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The timeout_in_seconds attribute.
    /// </summary>
    [TerraformArgument("timeout_in_seconds")]
    public TerraformValue<double>? TimeoutInSeconds
    {
        get => new TerraformReference<double>(this, "timeout_in_seconds");
        set => SetArgument("timeout_in_seconds", value);
    }

    /// <summary>
    /// Block for agent_setting.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AgentSetting block(s) allowed")]
    [TerraformArgument("agent_setting")]
    public TerraformList<AzurermContainerRegistryTaskAgentSettingBlock> AgentSetting { get; set; } = new();

    /// <summary>
    /// Block for base_image_trigger.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BaseImageTrigger block(s) allowed")]
    [TerraformArgument("base_image_trigger")]
    public TerraformList<AzurermContainerRegistryTaskBaseImageTriggerBlock> BaseImageTrigger { get; set; } = new();

    /// <summary>
    /// Block for docker_step.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DockerStep block(s) allowed")]
    [TerraformArgument("docker_step")]
    public TerraformList<AzurermContainerRegistryTaskDockerStepBlock> DockerStep { get; set; } = new();

    /// <summary>
    /// Block for encoded_step.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncodedStep block(s) allowed")]
    [TerraformArgument("encoded_step")]
    public TerraformList<AzurermContainerRegistryTaskEncodedStepBlock> EncodedStep { get; set; } = new();

    /// <summary>
    /// Block for file_step.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FileStep block(s) allowed")]
    [TerraformArgument("file_step")]
    public TerraformList<AzurermContainerRegistryTaskFileStepBlock> FileStep { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformArgument("identity")]
    public TerraformList<AzurermContainerRegistryTaskIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for platform.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Platform block(s) allowed")]
    [TerraformArgument("platform")]
    public TerraformList<AzurermContainerRegistryTaskPlatformBlock> Platform { get; set; } = new();

    /// <summary>
    /// Block for registry_credential.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RegistryCredential block(s) allowed")]
    [TerraformArgument("registry_credential")]
    public TerraformList<AzurermContainerRegistryTaskRegistryCredentialBlock> RegistryCredential { get; set; } = new();

    /// <summary>
    /// Block for source_trigger.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("source_trigger")]
    public TerraformList<AzurermContainerRegistryTaskSourceTriggerBlock> SourceTrigger { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermContainerRegistryTaskTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for timer_trigger.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("timer_trigger")]
    public TerraformList<AzurermContainerRegistryTaskTimerTriggerBlock> TimerTrigger { get; set; } = new();

}
