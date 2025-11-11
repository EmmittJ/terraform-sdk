using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for agent_setting in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerRegistryTaskAgentSettingBlock
{
    /// <summary>
    /// The cpu attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cpu is required")]
    [TerraformPropertyName("cpu")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> Cpu { get; set; }

}

/// <summary>
/// Block type for base_image_trigger in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerRegistryTaskBaseImageTriggerBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Type { get; set; }

    /// <summary>
    /// The update_trigger_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("update_trigger_endpoint")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? UpdateTriggerEndpoint { get; set; }

    /// <summary>
    /// The update_trigger_payload_type attribute.
    /// </summary>
    [TerraformPropertyName("update_trigger_payload_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? UpdateTriggerPayloadType { get; set; }

}

/// <summary>
/// Block type for docker_step in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerRegistryTaskDockerStepBlock
{
    /// <summary>
    /// The arguments attribute.
    /// </summary>
    [TerraformPropertyName("arguments")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Arguments { get; set; }

    /// <summary>
    /// The cache_enabled attribute.
    /// </summary>
    [TerraformPropertyName("cache_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? CacheEnabled { get; set; }

    /// <summary>
    /// The context_access_token attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContextAccessToken is required")]
    [TerraformPropertyName("context_access_token")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ContextAccessToken { get; set; }

    /// <summary>
    /// The context_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContextPath is required")]
    [TerraformPropertyName("context_path")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ContextPath { get; set; }

    /// <summary>
    /// The dockerfile_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DockerfilePath is required")]
    [TerraformPropertyName("dockerfile_path")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DockerfilePath { get; set; }

    /// <summary>
    /// The image_names attribute.
    /// </summary>
    [TerraformPropertyName("image_names")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? ImageNames { get; set; }

    /// <summary>
    /// The push_enabled attribute.
    /// </summary>
    [TerraformPropertyName("push_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? PushEnabled { get; set; }

    /// <summary>
    /// The secret_arguments attribute.
    /// </summary>
    [TerraformPropertyName("secret_arguments")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? SecretArguments { get; set; }

    /// <summary>
    /// The target attribute.
    /// </summary>
    [TerraformPropertyName("target")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Target { get; set; }

}

/// <summary>
/// Block type for encoded_step in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerRegistryTaskEncodedStepBlock
{
    /// <summary>
    /// The context_access_token attribute.
    /// </summary>
    [TerraformPropertyName("context_access_token")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ContextAccessToken { get; set; }

    /// <summary>
    /// The context_path attribute.
    /// </summary>
    [TerraformPropertyName("context_path")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ContextPath { get; set; }

    /// <summary>
    /// The secret_values attribute.
    /// </summary>
    [TerraformPropertyName("secret_values")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? SecretValues { get; set; }

    /// <summary>
    /// The task_content attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TaskContent is required")]
    [TerraformPropertyName("task_content")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> TaskContent { get; set; }

    /// <summary>
    /// The value_content attribute.
    /// </summary>
    [TerraformPropertyName("value_content")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ValueContent { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [TerraformPropertyName("values")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Values { get; set; }

}

/// <summary>
/// Block type for file_step in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerRegistryTaskFileStepBlock
{
    /// <summary>
    /// The context_access_token attribute.
    /// </summary>
    [TerraformPropertyName("context_access_token")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ContextAccessToken { get; set; }

    /// <summary>
    /// The context_path attribute.
    /// </summary>
    [TerraformPropertyName("context_path")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ContextPath { get; set; }

    /// <summary>
    /// The secret_values attribute.
    /// </summary>
    [TerraformPropertyName("secret_values")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? SecretValues { get; set; }

    /// <summary>
    /// The task_file_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TaskFilePath is required")]
    [TerraformPropertyName("task_file_path")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> TaskFilePath { get; set; }

    /// <summary>
    /// The value_file_path attribute.
    /// </summary>
    [TerraformPropertyName("value_file_path")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ValueFilePath { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [TerraformPropertyName("values")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Values { get; set; }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerRegistryTaskIdentityBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformPropertyName("identity_ids")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? IdentityIds { get; set; }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for platform in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerRegistryTaskPlatformBlock
{
    /// <summary>
    /// The architecture attribute.
    /// </summary>
    [TerraformPropertyName("architecture")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Architecture { get; set; }

    /// <summary>
    /// The os attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Os is required")]
    [TerraformPropertyName("os")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Os { get; set; }

    /// <summary>
    /// The variant attribute.
    /// </summary>
    [TerraformPropertyName("variant")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Variant { get; set; }

}

/// <summary>
/// Block type for registry_credential in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerRegistryTaskRegistryCredentialBlock
{
}

/// <summary>
/// Block type for source_trigger in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerRegistryTaskSourceTriggerBlock
{
    /// <summary>
    /// The branch attribute.
    /// </summary>
    [TerraformPropertyName("branch")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Branch { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The events attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Events is required")]
    [TerraformPropertyName("events")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformList<string>? Events { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The repository_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryUrl is required")]
    [TerraformPropertyName("repository_url")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RepositoryUrl { get; set; }

    /// <summary>
    /// The source_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceType is required")]
    [TerraformPropertyName("source_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> SourceType { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermContainerRegistryTaskTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for timer_trigger in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerRegistryTaskTimerTriggerBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The schedule attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Schedule is required")]
    [TerraformPropertyName("schedule")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Schedule { get; set; }

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
    [TerraformPropertyName("agent_pool_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AgentPoolName { get; set; }

    /// <summary>
    /// The container_registry_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerRegistryId is required")]
    [TerraformPropertyName("container_registry_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ContainerRegistryId { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The is_system_task attribute.
    /// </summary>
    [TerraformPropertyName("is_system_task")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? IsSystemTask { get; set; }

    /// <summary>
    /// The log_template attribute.
    /// </summary>
    [TerraformPropertyName("log_template")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? LogTemplate { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The timeout_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("timeout_in_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? TimeoutInSeconds { get; set; }

    /// <summary>
    /// Block for agent_setting.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AgentSetting block(s) allowed")]
    [TerraformPropertyName("agent_setting")]
    public TerraformList<TerraformBlock<AzurermContainerRegistryTaskAgentSettingBlock>>? AgentSetting { get; set; }

    /// <summary>
    /// Block for base_image_trigger.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BaseImageTrigger block(s) allowed")]
    [TerraformPropertyName("base_image_trigger")]
    public TerraformList<TerraformBlock<AzurermContainerRegistryTaskBaseImageTriggerBlock>>? BaseImageTrigger { get; set; }

    /// <summary>
    /// Block for docker_step.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DockerStep block(s) allowed")]
    [TerraformPropertyName("docker_step")]
    public TerraformList<TerraformBlock<AzurermContainerRegistryTaskDockerStepBlock>>? DockerStep { get; set; }

    /// <summary>
    /// Block for encoded_step.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncodedStep block(s) allowed")]
    [TerraformPropertyName("encoded_step")]
    public TerraformList<TerraformBlock<AzurermContainerRegistryTaskEncodedStepBlock>>? EncodedStep { get; set; }

    /// <summary>
    /// Block for file_step.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FileStep block(s) allowed")]
    [TerraformPropertyName("file_step")]
    public TerraformList<TerraformBlock<AzurermContainerRegistryTaskFileStepBlock>>? FileStep { get; set; }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformPropertyName("identity")]
    public TerraformList<TerraformBlock<AzurermContainerRegistryTaskIdentityBlock>>? Identity { get; set; }

    /// <summary>
    /// Block for platform.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Platform block(s) allowed")]
    [TerraformPropertyName("platform")]
    public TerraformList<TerraformBlock<AzurermContainerRegistryTaskPlatformBlock>>? Platform { get; set; }

    /// <summary>
    /// Block for registry_credential.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RegistryCredential block(s) allowed")]
    [TerraformPropertyName("registry_credential")]
    public TerraformList<TerraformBlock<AzurermContainerRegistryTaskRegistryCredentialBlock>>? RegistryCredential { get; set; }

    /// <summary>
    /// Block for source_trigger.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("source_trigger")]
    public TerraformList<TerraformBlock<AzurermContainerRegistryTaskSourceTriggerBlock>>? SourceTrigger { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermContainerRegistryTaskTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for timer_trigger.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("timer_trigger")]
    public TerraformList<TerraformBlock<AzurermContainerRegistryTaskTimerTriggerBlock>>? TimerTrigger { get; set; }

}
