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
        set => SetProperty("cpu", value);
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
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
    }

    /// <summary>
    /// The update_trigger_endpoint attribute.
    /// </summary>
    public TerraformProperty<string>? UpdateTriggerEndpoint
    {
        set => SetProperty("update_trigger_endpoint", value);
    }

    /// <summary>
    /// The update_trigger_payload_type attribute.
    /// </summary>
    public TerraformProperty<string>? UpdateTriggerPayloadType
    {
        set => SetProperty("update_trigger_payload_type", value);
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
        set => SetProperty("arguments", value);
    }

    /// <summary>
    /// The cache_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? CacheEnabled
    {
        set => SetProperty("cache_enabled", value);
    }

    /// <summary>
    /// The context_access_token attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContextAccessToken is required")]
    public required TerraformProperty<string> ContextAccessToken
    {
        set => SetProperty("context_access_token", value);
    }

    /// <summary>
    /// The context_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContextPath is required")]
    public required TerraformProperty<string> ContextPath
    {
        set => SetProperty("context_path", value);
    }

    /// <summary>
    /// The dockerfile_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DockerfilePath is required")]
    public required TerraformProperty<string> DockerfilePath
    {
        set => SetProperty("dockerfile_path", value);
    }

    /// <summary>
    /// The image_names attribute.
    /// </summary>
    public List<TerraformProperty<string>>? ImageNames
    {
        set => SetProperty("image_names", value);
    }

    /// <summary>
    /// The push_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? PushEnabled
    {
        set => SetProperty("push_enabled", value);
    }

    /// <summary>
    /// The secret_arguments attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? SecretArguments
    {
        set => SetProperty("secret_arguments", value);
    }

    /// <summary>
    /// The target attribute.
    /// </summary>
    public TerraformProperty<string>? Target
    {
        set => SetProperty("target", value);
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
        set => SetProperty("context_access_token", value);
    }

    /// <summary>
    /// The context_path attribute.
    /// </summary>
    public TerraformProperty<string>? ContextPath
    {
        set => SetProperty("context_path", value);
    }

    /// <summary>
    /// The secret_values attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? SecretValues
    {
        set => SetProperty("secret_values", value);
    }

    /// <summary>
    /// The task_content attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TaskContent is required")]
    public required TerraformProperty<string> TaskContent
    {
        set => SetProperty("task_content", value);
    }

    /// <summary>
    /// The value_content attribute.
    /// </summary>
    public TerraformProperty<string>? ValueContent
    {
        set => SetProperty("value_content", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Values
    {
        set => SetProperty("values", value);
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
        set => SetProperty("context_access_token", value);
    }

    /// <summary>
    /// The context_path attribute.
    /// </summary>
    public TerraformProperty<string>? ContextPath
    {
        set => SetProperty("context_path", value);
    }

    /// <summary>
    /// The secret_values attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? SecretValues
    {
        set => SetProperty("secret_values", value);
    }

    /// <summary>
    /// The task_file_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TaskFilePath is required")]
    public required TerraformProperty<string> TaskFilePath
    {
        set => SetProperty("task_file_path", value);
    }

    /// <summary>
    /// The value_file_path attribute.
    /// </summary>
    public TerraformProperty<string>? ValueFilePath
    {
        set => SetProperty("value_file_path", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Values
    {
        set => SetProperty("values", value);
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
        set => SetProperty("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrincipalId
    {
        set => SetProperty("principal_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        set => SetProperty("tenant_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
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
        set => SetProperty("architecture", value);
    }

    /// <summary>
    /// The os attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Os is required")]
    public required TerraformProperty<string> Os
    {
        set => SetProperty("os", value);
    }

    /// <summary>
    /// The variant attribute.
    /// </summary>
    public TerraformProperty<string>? Variant
    {
        set => SetProperty("variant", value);
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
        set => SetProperty("branch", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The events attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Events is required")]
    public List<TerraformProperty<string>>? Events
    {
        set => SetProperty("events", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The repository_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryUrl is required")]
    public required TerraformProperty<string> RepositoryUrl
    {
        set => SetProperty("repository_url", value);
    }

    /// <summary>
    /// The source_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceType is required")]
    public required TerraformProperty<string> SourceType
    {
        set => SetProperty("source_type", value);
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The schedule attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Schedule is required")]
    public required TerraformProperty<string> Schedule
    {
        set => SetProperty("schedule", value);
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
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("agent_pool_name");
        SetOutput("container_registry_id");
        SetOutput("enabled");
        SetOutput("id");
        SetOutput("is_system_task");
        SetOutput("log_template");
        SetOutput("name");
        SetOutput("tags");
        SetOutput("timeout_in_seconds");
    }

    /// <summary>
    /// The agent_pool_name attribute.
    /// </summary>
    public TerraformProperty<string> AgentPoolName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("agent_pool_name");
        set => SetProperty("agent_pool_name", value);
    }

    /// <summary>
    /// The container_registry_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerRegistryId is required")]
    public required TerraformProperty<string> ContainerRegistryId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("container_registry_id");
        set => SetProperty("container_registry_id", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool> Enabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enabled");
        set => SetProperty("enabled", value);
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
    /// The is_system_task attribute.
    /// </summary>
    public TerraformProperty<bool> IsSystemTask
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("is_system_task");
        set => SetProperty("is_system_task", value);
    }

    /// <summary>
    /// The log_template attribute.
    /// </summary>
    public TerraformProperty<string> LogTemplate
    {
        get => GetRequiredOutput<TerraformProperty<string>>("log_template");
        set => SetProperty("log_template", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The timeout_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double> TimeoutInSeconds
    {
        get => GetRequiredOutput<TerraformProperty<double>>("timeout_in_seconds");
        set => SetProperty("timeout_in_seconds", value);
    }

    /// <summary>
    /// Block for agent_setting.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AgentSetting block(s) allowed")]
    public List<AzurermContainerRegistryTaskAgentSettingBlock>? AgentSetting
    {
        set => SetProperty("agent_setting", value);
    }

    /// <summary>
    /// Block for base_image_trigger.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BaseImageTrigger block(s) allowed")]
    public List<AzurermContainerRegistryTaskBaseImageTriggerBlock>? BaseImageTrigger
    {
        set => SetProperty("base_image_trigger", value);
    }

    /// <summary>
    /// Block for docker_step.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DockerStep block(s) allowed")]
    public List<AzurermContainerRegistryTaskDockerStepBlock>? DockerStep
    {
        set => SetProperty("docker_step", value);
    }

    /// <summary>
    /// Block for encoded_step.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncodedStep block(s) allowed")]
    public List<AzurermContainerRegistryTaskEncodedStepBlock>? EncodedStep
    {
        set => SetProperty("encoded_step", value);
    }

    /// <summary>
    /// Block for file_step.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FileStep block(s) allowed")]
    public List<AzurermContainerRegistryTaskFileStepBlock>? FileStep
    {
        set => SetProperty("file_step", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermContainerRegistryTaskIdentityBlock>? Identity
    {
        set => SetProperty("identity", value);
    }

    /// <summary>
    /// Block for platform.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Platform block(s) allowed")]
    public List<AzurermContainerRegistryTaskPlatformBlock>? Platform
    {
        set => SetProperty("platform", value);
    }

    /// <summary>
    /// Block for registry_credential.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RegistryCredential block(s) allowed")]
    public List<AzurermContainerRegistryTaskRegistryCredentialBlock>? RegistryCredential
    {
        set => SetProperty("registry_credential", value);
    }

    /// <summary>
    /// Block for source_trigger.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermContainerRegistryTaskSourceTriggerBlock>? SourceTrigger
    {
        set => SetProperty("source_trigger", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermContainerRegistryTaskTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for timer_trigger.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermContainerRegistryTaskTimerTriggerBlock>? TimerTrigger
    {
        set => SetProperty("timer_trigger", value);
    }

}
