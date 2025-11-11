using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for agent_setting in .
/// Nesting mode: list
/// </summary>
public partial class AzurermContainerRegistryTaskAgentSettingBlock : TerraformBlockBase
{
    /// <summary>
    /// The cpu attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cpu is required")]
    [TerraformProperty("cpu")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> Cpu { get; set; }

}

/// <summary>
/// Block type for base_image_trigger in .
/// Nesting mode: list
/// </summary>
public partial class AzurermContainerRegistryTaskBaseImageTriggerBlock : TerraformBlockBase
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

    /// <summary>
    /// The update_trigger_endpoint attribute.
    /// </summary>
    [TerraformProperty("update_trigger_endpoint")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? UpdateTriggerEndpoint { get; set; }

    /// <summary>
    /// The update_trigger_payload_type attribute.
    /// </summary>
    [TerraformProperty("update_trigger_payload_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? UpdateTriggerPayloadType { get; set; }

}

/// <summary>
/// Block type for docker_step in .
/// Nesting mode: list
/// </summary>
public partial class AzurermContainerRegistryTaskDockerStepBlock : TerraformBlockBase
{
    /// <summary>
    /// The arguments attribute.
    /// </summary>
    [TerraformProperty("arguments")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Arguments { get; set; }

    /// <summary>
    /// The cache_enabled attribute.
    /// </summary>
    [TerraformProperty("cache_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? CacheEnabled { get; set; }

    /// <summary>
    /// The context_access_token attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContextAccessToken is required")]
    [TerraformProperty("context_access_token")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ContextAccessToken { get; set; }

    /// <summary>
    /// The context_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContextPath is required")]
    [TerraformProperty("context_path")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ContextPath { get; set; }

    /// <summary>
    /// The dockerfile_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DockerfilePath is required")]
    [TerraformProperty("dockerfile_path")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DockerfilePath { get; set; }

    /// <summary>
    /// The image_names attribute.
    /// </summary>
    [TerraformProperty("image_names")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? ImageNames { get; set; }

    /// <summary>
    /// The push_enabled attribute.
    /// </summary>
    [TerraformProperty("push_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? PushEnabled { get; set; }

    /// <summary>
    /// The secret_arguments attribute.
    /// </summary>
    [TerraformProperty("secret_arguments")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? SecretArguments { get; set; }

    /// <summary>
    /// The target attribute.
    /// </summary>
    [TerraformProperty("target")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Target { get; set; }

}

/// <summary>
/// Block type for encoded_step in .
/// Nesting mode: list
/// </summary>
public partial class AzurermContainerRegistryTaskEncodedStepBlock : TerraformBlockBase
{
    /// <summary>
    /// The context_access_token attribute.
    /// </summary>
    [TerraformProperty("context_access_token")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ContextAccessToken { get; set; }

    /// <summary>
    /// The context_path attribute.
    /// </summary>
    [TerraformProperty("context_path")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ContextPath { get; set; }

    /// <summary>
    /// The secret_values attribute.
    /// </summary>
    [TerraformProperty("secret_values")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? SecretValues { get; set; }

    /// <summary>
    /// The task_content attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TaskContent is required")]
    [TerraformProperty("task_content")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TaskContent { get; set; }

    /// <summary>
    /// The value_content attribute.
    /// </summary>
    [TerraformProperty("value_content")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ValueContent { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [TerraformProperty("values")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Values { get; set; }

}

/// <summary>
/// Block type for file_step in .
/// Nesting mode: list
/// </summary>
public partial class AzurermContainerRegistryTaskFileStepBlock : TerraformBlockBase
{
    /// <summary>
    /// The context_access_token attribute.
    /// </summary>
    [TerraformProperty("context_access_token")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ContextAccessToken { get; set; }

    /// <summary>
    /// The context_path attribute.
    /// </summary>
    [TerraformProperty("context_path")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ContextPath { get; set; }

    /// <summary>
    /// The secret_values attribute.
    /// </summary>
    [TerraformProperty("secret_values")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? SecretValues { get; set; }

    /// <summary>
    /// The task_file_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TaskFilePath is required")]
    [TerraformProperty("task_file_path")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TaskFilePath { get; set; }

    /// <summary>
    /// The value_file_path attribute.
    /// </summary>
    [TerraformProperty("value_file_path")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ValueFilePath { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [TerraformProperty("values")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Values { get; set; }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public partial class AzurermContainerRegistryTaskIdentityBlock : TerraformBlockBase
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformProperty("identity_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? IdentityIds { get; set; }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for platform in .
/// Nesting mode: list
/// </summary>
public partial class AzurermContainerRegistryTaskPlatformBlock : TerraformBlockBase
{
    /// <summary>
    /// The architecture attribute.
    /// </summary>
    [TerraformProperty("architecture")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Architecture { get; set; }

    /// <summary>
    /// The os attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Os is required")]
    [TerraformProperty("os")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Os { get; set; }

    /// <summary>
    /// The variant attribute.
    /// </summary>
    [TerraformProperty("variant")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Variant { get; set; }

}

/// <summary>
/// Block type for registry_credential in .
/// Nesting mode: list
/// </summary>
public partial class AzurermContainerRegistryTaskRegistryCredentialBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for source_trigger in .
/// Nesting mode: list
/// </summary>
public partial class AzurermContainerRegistryTaskSourceTriggerBlock : TerraformBlockBase
{
    /// <summary>
    /// The branch attribute.
    /// </summary>
    [TerraformProperty("branch")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Branch { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The events attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Events is required")]
    [TerraformProperty("events")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? Events { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The repository_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryUrl is required")]
    [TerraformProperty("repository_url")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RepositoryUrl { get; set; }

    /// <summary>
    /// The source_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceType is required")]
    [TerraformProperty("source_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SourceType { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermContainerRegistryTaskTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for timer_trigger in .
/// Nesting mode: list
/// </summary>
public partial class AzurermContainerRegistryTaskTimerTriggerBlock : TerraformBlockBase
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The schedule attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Schedule is required")]
    [TerraformProperty("schedule")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Schedule { get; set; }

}

/// <summary>
/// Manages a azurerm_container_registry_task resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermContainerRegistryTask : TerraformResource
{
    public AzurermContainerRegistryTask(string name) : base("azurerm_container_registry_task", name)
    {
    }

    /// <summary>
    /// The agent_pool_name attribute.
    /// </summary>
    [TerraformProperty("agent_pool_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AgentPoolName { get; set; }

    /// <summary>
    /// The container_registry_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerRegistryId is required")]
    [TerraformProperty("container_registry_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ContainerRegistryId { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The is_system_task attribute.
    /// </summary>
    [TerraformProperty("is_system_task")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? IsSystemTask { get; set; }

    /// <summary>
    /// The log_template attribute.
    /// </summary>
    [TerraformProperty("log_template")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? LogTemplate { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The timeout_in_seconds attribute.
    /// </summary>
    [TerraformProperty("timeout_in_seconds")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? TimeoutInSeconds { get; set; }

    /// <summary>
    /// Block for agent_setting.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AgentSetting block(s) allowed")]
    [TerraformProperty("agent_setting")]
    public partial TerraformList<TerraformBlock<AzurermContainerRegistryTaskAgentSettingBlock>>? AgentSetting { get; set; }

    /// <summary>
    /// Block for base_image_trigger.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BaseImageTrigger block(s) allowed")]
    [TerraformProperty("base_image_trigger")]
    public partial TerraformList<TerraformBlock<AzurermContainerRegistryTaskBaseImageTriggerBlock>>? BaseImageTrigger { get; set; }

    /// <summary>
    /// Block for docker_step.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DockerStep block(s) allowed")]
    [TerraformProperty("docker_step")]
    public partial TerraformList<TerraformBlock<AzurermContainerRegistryTaskDockerStepBlock>>? DockerStep { get; set; }

    /// <summary>
    /// Block for encoded_step.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncodedStep block(s) allowed")]
    [TerraformProperty("encoded_step")]
    public partial TerraformList<TerraformBlock<AzurermContainerRegistryTaskEncodedStepBlock>>? EncodedStep { get; set; }

    /// <summary>
    /// Block for file_step.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FileStep block(s) allowed")]
    [TerraformProperty("file_step")]
    public partial TerraformList<TerraformBlock<AzurermContainerRegistryTaskFileStepBlock>>? FileStep { get; set; }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformProperty("identity")]
    public partial TerraformList<TerraformBlock<AzurermContainerRegistryTaskIdentityBlock>>? Identity { get; set; }

    /// <summary>
    /// Block for platform.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Platform block(s) allowed")]
    [TerraformProperty("platform")]
    public partial TerraformList<TerraformBlock<AzurermContainerRegistryTaskPlatformBlock>>? Platform { get; set; }

    /// <summary>
    /// Block for registry_credential.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RegistryCredential block(s) allowed")]
    [TerraformProperty("registry_credential")]
    public partial TerraformList<TerraformBlock<AzurermContainerRegistryTaskRegistryCredentialBlock>>? RegistryCredential { get; set; }

    /// <summary>
    /// Block for source_trigger.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("source_trigger")]
    public partial TerraformList<TerraformBlock<AzurermContainerRegistryTaskSourceTriggerBlock>>? SourceTrigger { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermContainerRegistryTaskTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for timer_trigger.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("timer_trigger")]
    public partial TerraformList<TerraformBlock<AzurermContainerRegistryTaskTimerTriggerBlock>>? TimerTrigger { get; set; }

}
