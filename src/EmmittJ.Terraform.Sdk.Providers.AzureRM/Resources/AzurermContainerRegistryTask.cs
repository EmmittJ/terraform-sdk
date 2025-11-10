using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for agent_setting in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerRegistryTaskAgentSettingBlock : TerraformBlock
{
    /// <summary>
    /// The cpu attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cpu is required")]
    public required TerraformProperty<double> Cpu
    {
        get => GetProperty<TerraformProperty<double>>("cpu");
        set => WithProperty("cpu", value);
    }

}

/// <summary>
/// Block type for base_image_trigger in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerRegistryTaskBaseImageTriggerBlock : TerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

    /// <summary>
    /// The update_trigger_endpoint attribute.
    /// </summary>
    public TerraformProperty<string>? UpdateTriggerEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("update_trigger_endpoint");
        set => WithProperty("update_trigger_endpoint", value);
    }

    /// <summary>
    /// The update_trigger_payload_type attribute.
    /// </summary>
    public TerraformProperty<string>? UpdateTriggerPayloadType
    {
        get => GetProperty<TerraformProperty<string>>("update_trigger_payload_type");
        set => WithProperty("update_trigger_payload_type", value);
    }

}

/// <summary>
/// Block type for docker_step in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerRegistryTaskDockerStepBlock : TerraformBlock
{
    /// <summary>
    /// The arguments attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Arguments
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("arguments");
        set => WithProperty("arguments", value);
    }

    /// <summary>
    /// The cache_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? CacheEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("cache_enabled");
        set => WithProperty("cache_enabled", value);
    }

    /// <summary>
    /// The context_access_token attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContextAccessToken is required")]
    public required TerraformProperty<string> ContextAccessToken
    {
        get => GetProperty<TerraformProperty<string>>("context_access_token");
        set => WithProperty("context_access_token", value);
    }

    /// <summary>
    /// The context_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContextPath is required")]
    public required TerraformProperty<string> ContextPath
    {
        get => GetProperty<TerraformProperty<string>>("context_path");
        set => WithProperty("context_path", value);
    }

    /// <summary>
    /// The dockerfile_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DockerfilePath is required")]
    public required TerraformProperty<string> DockerfilePath
    {
        get => GetProperty<TerraformProperty<string>>("dockerfile_path");
        set => WithProperty("dockerfile_path", value);
    }

    /// <summary>
    /// The image_names attribute.
    /// </summary>
    public List<TerraformProperty<string>>? ImageNames
    {
        get => GetProperty<List<TerraformProperty<string>>>("image_names");
        set => WithProperty("image_names", value);
    }

    /// <summary>
    /// The push_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? PushEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("push_enabled");
        set => WithProperty("push_enabled", value);
    }

    /// <summary>
    /// The secret_arguments attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? SecretArguments
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("secret_arguments");
        set => WithProperty("secret_arguments", value);
    }

    /// <summary>
    /// The target attribute.
    /// </summary>
    public TerraformProperty<string>? Target
    {
        get => GetProperty<TerraformProperty<string>>("target");
        set => WithProperty("target", value);
    }

}

/// <summary>
/// Block type for encoded_step in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerRegistryTaskEncodedStepBlock : TerraformBlock
{
    /// <summary>
    /// The context_access_token attribute.
    /// </summary>
    public TerraformProperty<string>? ContextAccessToken
    {
        get => GetProperty<TerraformProperty<string>>("context_access_token");
        set => WithProperty("context_access_token", value);
    }

    /// <summary>
    /// The context_path attribute.
    /// </summary>
    public TerraformProperty<string>? ContextPath
    {
        get => GetProperty<TerraformProperty<string>>("context_path");
        set => WithProperty("context_path", value);
    }

    /// <summary>
    /// The secret_values attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? SecretValues
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("secret_values");
        set => WithProperty("secret_values", value);
    }

    /// <summary>
    /// The task_content attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TaskContent is required")]
    public required TerraformProperty<string> TaskContent
    {
        get => GetProperty<TerraformProperty<string>>("task_content");
        set => WithProperty("task_content", value);
    }

    /// <summary>
    /// The value_content attribute.
    /// </summary>
    public TerraformProperty<string>? ValueContent
    {
        get => GetProperty<TerraformProperty<string>>("value_content");
        set => WithProperty("value_content", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Values
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("values");
        set => WithProperty("values", value);
    }

}

/// <summary>
/// Block type for file_step in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerRegistryTaskFileStepBlock : TerraformBlock
{
    /// <summary>
    /// The context_access_token attribute.
    /// </summary>
    public TerraformProperty<string>? ContextAccessToken
    {
        get => GetProperty<TerraformProperty<string>>("context_access_token");
        set => WithProperty("context_access_token", value);
    }

    /// <summary>
    /// The context_path attribute.
    /// </summary>
    public TerraformProperty<string>? ContextPath
    {
        get => GetProperty<TerraformProperty<string>>("context_path");
        set => WithProperty("context_path", value);
    }

    /// <summary>
    /// The secret_values attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? SecretValues
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("secret_values");
        set => WithProperty("secret_values", value);
    }

    /// <summary>
    /// The task_file_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TaskFilePath is required")]
    public required TerraformProperty<string> TaskFilePath
    {
        get => GetProperty<TerraformProperty<string>>("task_file_path");
        set => WithProperty("task_file_path", value);
    }

    /// <summary>
    /// The value_file_path attribute.
    /// </summary>
    public TerraformProperty<string>? ValueFilePath
    {
        get => GetProperty<TerraformProperty<string>>("value_file_path");
        set => WithProperty("value_file_path", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Values
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("values");
        set => WithProperty("values", value);
    }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerRegistryTaskIdentityBlock : TerraformBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? IdentityIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("identity_ids");
        set => WithProperty("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrincipalId
    {
        get => GetProperty<TerraformProperty<string>>("principal_id");
        set => WithProperty("principal_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        get => GetProperty<TerraformProperty<string>>("tenant_id");
        set => WithProperty("tenant_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for platform in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerRegistryTaskPlatformBlock : TerraformBlock
{
    /// <summary>
    /// The architecture attribute.
    /// </summary>
    public TerraformProperty<string>? Architecture
    {
        get => GetProperty<TerraformProperty<string>>("architecture");
        set => WithProperty("architecture", value);
    }

    /// <summary>
    /// The os attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Os is required")]
    public required TerraformProperty<string> Os
    {
        get => GetProperty<TerraformProperty<string>>("os");
        set => WithProperty("os", value);
    }

    /// <summary>
    /// The variant attribute.
    /// </summary>
    public TerraformProperty<string>? Variant
    {
        get => GetProperty<TerraformProperty<string>>("variant");
        set => WithProperty("variant", value);
    }

}

/// <summary>
/// Block type for registry_credential in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerRegistryTaskRegistryCredentialBlock : TerraformBlock
{
}

/// <summary>
/// Block type for source_trigger in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerRegistryTaskSourceTriggerBlock : TerraformBlock
{
    /// <summary>
    /// The branch attribute.
    /// </summary>
    public TerraformProperty<string>? Branch
    {
        get => GetProperty<TerraformProperty<string>>("branch");
        set => WithProperty("branch", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
    }

    /// <summary>
    /// The events attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Events is required")]
    public List<TerraformProperty<string>>? Events
    {
        get => GetProperty<List<TerraformProperty<string>>>("events");
        set => WithProperty("events", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The repository_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryUrl is required")]
    public required TerraformProperty<string> RepositoryUrl
    {
        get => GetProperty<TerraformProperty<string>>("repository_url");
        set => WithProperty("repository_url", value);
    }

    /// <summary>
    /// The source_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceType is required")]
    public required TerraformProperty<string> SourceType
    {
        get => GetProperty<TerraformProperty<string>>("source_type");
        set => WithProperty("source_type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermContainerRegistryTaskTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Block type for timer_trigger in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerRegistryTaskTimerTriggerBlock : TerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The schedule attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Schedule is required")]
    public required TerraformProperty<string> Schedule
    {
        get => GetProperty<TerraformProperty<string>>("schedule");
        set => WithProperty("schedule", value);
    }

}

/// <summary>
/// Manages a azurerm_container_registry_task resource.
/// </summary>
public class AzurermContainerRegistryTask : TerraformResource
{
    public AzurermContainerRegistryTask(string name) : base("azurerm_container_registry_task", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The agent_pool_name attribute.
    /// </summary>
    public TerraformProperty<string>? AgentPoolName
    {
        get => GetProperty<TerraformProperty<string>>("agent_pool_name");
        set => this.WithProperty("agent_pool_name", value);
    }

    /// <summary>
    /// The container_registry_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerRegistryId is required")]
    public required TerraformProperty<string> ContainerRegistryId
    {
        get => GetProperty<TerraformProperty<string>>("container_registry_id");
        set => this.WithProperty("container_registry_id", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => this.WithProperty("enabled", value);
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
    /// The is_system_task attribute.
    /// </summary>
    public TerraformProperty<bool>? IsSystemTask
    {
        get => GetProperty<TerraformProperty<bool>>("is_system_task");
        set => this.WithProperty("is_system_task", value);
    }

    /// <summary>
    /// The log_template attribute.
    /// </summary>
    public TerraformProperty<string>? LogTemplate
    {
        get => GetProperty<TerraformProperty<string>>("log_template");
        set => this.WithProperty("log_template", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The timeout_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? TimeoutInSeconds
    {
        get => GetProperty<TerraformProperty<double>>("timeout_in_seconds");
        set => this.WithProperty("timeout_in_seconds", value);
    }

    /// <summary>
    /// Block for agent_setting.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AgentSetting block(s) allowed")]
    public List<AzurermContainerRegistryTaskAgentSettingBlock>? AgentSetting
    {
        get => GetProperty<List<AzurermContainerRegistryTaskAgentSettingBlock>>("agent_setting");
        set => this.WithProperty("agent_setting", value);
    }

    /// <summary>
    /// Block for base_image_trigger.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BaseImageTrigger block(s) allowed")]
    public List<AzurermContainerRegistryTaskBaseImageTriggerBlock>? BaseImageTrigger
    {
        get => GetProperty<List<AzurermContainerRegistryTaskBaseImageTriggerBlock>>("base_image_trigger");
        set => this.WithProperty("base_image_trigger", value);
    }

    /// <summary>
    /// Block for docker_step.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DockerStep block(s) allowed")]
    public List<AzurermContainerRegistryTaskDockerStepBlock>? DockerStep
    {
        get => GetProperty<List<AzurermContainerRegistryTaskDockerStepBlock>>("docker_step");
        set => this.WithProperty("docker_step", value);
    }

    /// <summary>
    /// Block for encoded_step.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncodedStep block(s) allowed")]
    public List<AzurermContainerRegistryTaskEncodedStepBlock>? EncodedStep
    {
        get => GetProperty<List<AzurermContainerRegistryTaskEncodedStepBlock>>("encoded_step");
        set => this.WithProperty("encoded_step", value);
    }

    /// <summary>
    /// Block for file_step.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FileStep block(s) allowed")]
    public List<AzurermContainerRegistryTaskFileStepBlock>? FileStep
    {
        get => GetProperty<List<AzurermContainerRegistryTaskFileStepBlock>>("file_step");
        set => this.WithProperty("file_step", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermContainerRegistryTaskIdentityBlock>? Identity
    {
        get => GetProperty<List<AzurermContainerRegistryTaskIdentityBlock>>("identity");
        set => this.WithProperty("identity", value);
    }

    /// <summary>
    /// Block for platform.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Platform block(s) allowed")]
    public List<AzurermContainerRegistryTaskPlatformBlock>? Platform
    {
        get => GetProperty<List<AzurermContainerRegistryTaskPlatformBlock>>("platform");
        set => this.WithProperty("platform", value);
    }

    /// <summary>
    /// Block for registry_credential.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RegistryCredential block(s) allowed")]
    public List<AzurermContainerRegistryTaskRegistryCredentialBlock>? RegistryCredential
    {
        get => GetProperty<List<AzurermContainerRegistryTaskRegistryCredentialBlock>>("registry_credential");
        set => this.WithProperty("registry_credential", value);
    }

    /// <summary>
    /// Block for source_trigger.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermContainerRegistryTaskSourceTriggerBlock>? SourceTrigger
    {
        get => GetProperty<List<AzurermContainerRegistryTaskSourceTriggerBlock>>("source_trigger");
        set => this.WithProperty("source_trigger", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermContainerRegistryTaskTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermContainerRegistryTaskTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for timer_trigger.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermContainerRegistryTaskTimerTriggerBlock>? TimerTrigger
    {
        get => GetProperty<List<AzurermContainerRegistryTaskTimerTriggerBlock>>("timer_trigger");
        set => this.WithProperty("timer_trigger", value);
    }

}
