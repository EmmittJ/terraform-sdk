using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for event_trigger_config in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppJobEventTriggerConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The parallelism attribute.
    /// </summary>
    [TerraformPropertyName("parallelism")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Parallelism { get; set; }

    /// <summary>
    /// The replica_completion_count attribute.
    /// </summary>
    [TerraformPropertyName("replica_completion_count")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? ReplicaCompletionCount { get; set; }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppJobIdentityBlock : ITerraformBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformPropertyName("identity_ids")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? IdentityIds { get; set; }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    [TerraformPropertyName("principal_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrincipalId => new TerraformReferenceProperty<TerraformProperty<string>>("", "principal_id");

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [TerraformPropertyName("tenant_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TenantId => new TerraformReferenceProperty<TerraformProperty<string>>("", "tenant_id");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

}

/// <summary>
/// Block type for manual_trigger_config in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppJobManualTriggerConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The parallelism attribute.
    /// </summary>
    [TerraformPropertyName("parallelism")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Parallelism { get; set; }

    /// <summary>
    /// The replica_completion_count attribute.
    /// </summary>
    [TerraformPropertyName("replica_completion_count")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? ReplicaCompletionCount { get; set; }

}

/// <summary>
/// Block type for registry in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppJobRegistryBlock : ITerraformBlock
{
    /// <summary>
    /// ID of the System or User Managed Identity used to pull images from the Container Registry
    /// </summary>
    [TerraformPropertyName("identity")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Identity { get; set; }

    /// <summary>
    /// The name of the Secret Reference containing the password value for this user on the Container Registry.
    /// </summary>
    [TerraformPropertyName("password_secret_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PasswordSecretName { get; set; }

    /// <summary>
    /// The hostname for the Container Registry.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Server is required")]
    [TerraformPropertyName("server")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Server { get; set; }

    /// <summary>
    /// The username to use for this Container Registry.
    /// </summary>
    [TerraformPropertyName("username")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Username { get; set; }

}

/// <summary>
/// Block type for schedule_trigger_config in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppJobScheduleTriggerConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The cron_expression attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CronExpression is required")]
    [TerraformPropertyName("cron_expression")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> CronExpression { get; set; }

    /// <summary>
    /// The parallelism attribute.
    /// </summary>
    [TerraformPropertyName("parallelism")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Parallelism { get; set; }

    /// <summary>
    /// The replica_completion_count attribute.
    /// </summary>
    [TerraformPropertyName("replica_completion_count")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? ReplicaCompletionCount { get; set; }

}

/// <summary>
/// Block type for secret in .
/// Nesting mode: set
/// </summary>
public class AzurermContainerAppJobSecretBlock : ITerraformBlock
{
    /// <summary>
    /// The identity to use for accessing key vault reference.
    /// </summary>
    [TerraformPropertyName("identity")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Identity { get; set; }

    /// <summary>
    /// The Key Vault Secret ID. Could be either one of `id` or `versionless_id`.
    /// </summary>
    [TerraformPropertyName("key_vault_secret_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? KeyVaultSecretId { get; set; }

    /// <summary>
    /// The secret name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The value for this secret.
    /// </summary>
    [TerraformPropertyName("value")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Value { get; set; }

}

/// <summary>
/// Block type for template in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppJobTemplateBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermContainerAppJobTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_container_app_job resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermContainerAppJob : TerraformResource
{
    public AzurermContainerAppJob(string name) : base("azurerm_container_app_job", name)
    {
    }

    /// <summary>
    /// The container_app_environment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerAppEnvironmentId is required")]
    [TerraformPropertyName("container_app_environment_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ContainerAppEnvironmentId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The replica_retry_limit attribute.
    /// </summary>
    [TerraformPropertyName("replica_retry_limit")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? ReplicaRetryLimit { get; set; }

    /// <summary>
    /// The replica_timeout_in_seconds attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicaTimeoutInSeconds is required")]
    [TerraformPropertyName("replica_timeout_in_seconds")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> ReplicaTimeoutInSeconds { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The workload_profile_name attribute.
    /// </summary>
    [TerraformPropertyName("workload_profile_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? WorkloadProfileName { get; set; }

    /// <summary>
    /// Block for event_trigger_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EventTriggerConfig block(s) allowed")]
    [TerraformPropertyName("event_trigger_config")]
    public TerraformList<TerraformBlock<AzurermContainerAppJobEventTriggerConfigBlock>>? EventTriggerConfig { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformPropertyName("identity")]
    public TerraformList<TerraformBlock<AzurermContainerAppJobIdentityBlock>>? Identity { get; set; } = new();

    /// <summary>
    /// Block for manual_trigger_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManualTriggerConfig block(s) allowed")]
    [TerraformPropertyName("manual_trigger_config")]
    public TerraformList<TerraformBlock<AzurermContainerAppJobManualTriggerConfigBlock>>? ManualTriggerConfig { get; set; } = new();

    /// <summary>
    /// Block for registry.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("registry")]
    public TerraformList<TerraformBlock<AzurermContainerAppJobRegistryBlock>>? Registry { get; set; } = new();

    /// <summary>
    /// Block for schedule_trigger_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScheduleTriggerConfig block(s) allowed")]
    [TerraformPropertyName("schedule_trigger_config")]
    public TerraformList<TerraformBlock<AzurermContainerAppJobScheduleTriggerConfigBlock>>? ScheduleTriggerConfig { get; set; } = new();

    /// <summary>
    /// Block for secret.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("secret")]
    public TerraformSet<TerraformBlock<AzurermContainerAppJobSecretBlock>>? Secret { get; set; } = new();

    /// <summary>
    /// Block for template.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Template is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Template block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Template block(s) allowed")]
    [TerraformPropertyName("template")]
    public TerraformList<TerraformBlock<AzurermContainerAppJobTemplateBlock>>? Template { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermContainerAppJobTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The event_stream_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("event_stream_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EventStreamEndpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "event_stream_endpoint");

    /// <summary>
    /// The outbound_ip_addresses attribute.
    /// </summary>
    [TerraformPropertyName("outbound_ip_addresses")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> OutboundIpAddresses => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "outbound_ip_addresses");

}
