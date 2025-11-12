using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for event_trigger_config in .
/// Nesting mode: list
/// </summary>
public partial class AzurermContainerAppJobEventTriggerConfigBlock() : TerraformBlock("event_trigger_config")
{
    /// <summary>
    /// The parallelism attribute.
    /// </summary>
    [TerraformProperty("parallelism")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Parallelism { get; set; }

    /// <summary>
    /// The replica_completion_count attribute.
    /// </summary>
    [TerraformProperty("replica_completion_count")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? ReplicaCompletionCount { get; set; }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public partial class AzurermContainerAppJobIdentityBlock() : TerraformBlock("identity")
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
/// Block type for manual_trigger_config in .
/// Nesting mode: list
/// </summary>
public partial class AzurermContainerAppJobManualTriggerConfigBlock() : TerraformBlock("manual_trigger_config")
{
    /// <summary>
    /// The parallelism attribute.
    /// </summary>
    [TerraformProperty("parallelism")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Parallelism { get; set; }

    /// <summary>
    /// The replica_completion_count attribute.
    /// </summary>
    [TerraformProperty("replica_completion_count")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? ReplicaCompletionCount { get; set; }

}

/// <summary>
/// Block type for registry in .
/// Nesting mode: list
/// </summary>
public partial class AzurermContainerAppJobRegistryBlock() : TerraformBlock("registry")
{
    /// <summary>
    /// ID of the System or User Managed Identity used to pull images from the Container Registry
    /// </summary>
    [TerraformProperty("identity")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Identity { get; set; }

    /// <summary>
    /// The name of the Secret Reference containing the password value for this user on the Container Registry.
    /// </summary>
    [TerraformProperty("password_secret_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PasswordSecretName { get; set; }

    /// <summary>
    /// The hostname for the Container Registry.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Server is required")]
    [TerraformProperty("server")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Server { get; set; }

    /// <summary>
    /// The username to use for this Container Registry.
    /// </summary>
    [TerraformProperty("username")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Username { get; set; }

}

/// <summary>
/// Block type for schedule_trigger_config in .
/// Nesting mode: list
/// </summary>
public partial class AzurermContainerAppJobScheduleTriggerConfigBlock() : TerraformBlock("schedule_trigger_config")
{
    /// <summary>
    /// The cron_expression attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CronExpression is required")]
    [TerraformProperty("cron_expression")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> CronExpression { get; set; }

    /// <summary>
    /// The parallelism attribute.
    /// </summary>
    [TerraformProperty("parallelism")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Parallelism { get; set; }

    /// <summary>
    /// The replica_completion_count attribute.
    /// </summary>
    [TerraformProperty("replica_completion_count")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? ReplicaCompletionCount { get; set; }

}

/// <summary>
/// Block type for secret in .
/// Nesting mode: set
/// </summary>
public partial class AzurermContainerAppJobSecretBlock() : TerraformBlock("secret")
{
    /// <summary>
    /// The identity to use for accessing key vault reference.
    /// </summary>
    [TerraformProperty("identity")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Identity { get; set; }

    /// <summary>
    /// The Key Vault Secret ID. Could be either one of `id` or `versionless_id`.
    /// </summary>
    [TerraformProperty("key_vault_secret_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KeyVaultSecretId { get; set; }

    /// <summary>
    /// The secret name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The value for this secret.
    /// </summary>
    [TerraformProperty("value")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Value { get; set; }

}

/// <summary>
/// Block type for template in .
/// Nesting mode: list
/// </summary>
public partial class AzurermContainerAppJobTemplateBlock() : TerraformBlock("template")
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermContainerAppJobTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_container_app_job resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermContainerAppJob : TerraformResource
{
    public AzurermContainerAppJob(string name) : base("azurerm_container_app_job", name)
    {
    }

    /// <summary>
    /// The container_app_environment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerAppEnvironmentId is required")]
    [TerraformProperty("container_app_environment_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ContainerAppEnvironmentId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The replica_retry_limit attribute.
    /// </summary>
    [TerraformProperty("replica_retry_limit")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? ReplicaRetryLimit { get; set; }

    /// <summary>
    /// The replica_timeout_in_seconds attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicaTimeoutInSeconds is required")]
    [TerraformProperty("replica_timeout_in_seconds")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> ReplicaTimeoutInSeconds { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The workload_profile_name attribute.
    /// </summary>
    [TerraformProperty("workload_profile_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? WorkloadProfileName { get; set; }

    /// <summary>
    /// Block for event_trigger_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EventTriggerConfig block(s) allowed")]
    [TerraformProperty("event_trigger_config")]
    public TerraformList<AzurermContainerAppJobEventTriggerConfigBlock> EventTriggerConfig { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformProperty("identity")]
    public TerraformList<AzurermContainerAppJobIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for manual_trigger_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManualTriggerConfig block(s) allowed")]
    [TerraformProperty("manual_trigger_config")]
    public TerraformList<AzurermContainerAppJobManualTriggerConfigBlock> ManualTriggerConfig { get; set; } = new();

    /// <summary>
    /// Block for registry.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("registry")]
    public TerraformList<AzurermContainerAppJobRegistryBlock> Registry { get; set; } = new();

    /// <summary>
    /// Block for schedule_trigger_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScheduleTriggerConfig block(s) allowed")]
    [TerraformProperty("schedule_trigger_config")]
    public TerraformList<AzurermContainerAppJobScheduleTriggerConfigBlock> ScheduleTriggerConfig { get; set; } = new();

    /// <summary>
    /// Block for secret.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("secret")]
    public TerraformSet<AzurermContainerAppJobSecretBlock> Secret { get; set; } = new();

    /// <summary>
    /// Block for template.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Template is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Template block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Template block(s) allowed")]
    [TerraformProperty("template")]
    public required TerraformList<AzurermContainerAppJobTemplateBlock> Template { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermContainerAppJobTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The event_stream_endpoint attribute.
    /// </summary>
    [TerraformProperty("event_stream_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> EventStreamEndpoint { get; }

    /// <summary>
    /// The outbound_ip_addresses attribute.
    /// </summary>
    [TerraformProperty("outbound_ip_addresses")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> OutboundIpAddresses { get; }

}
