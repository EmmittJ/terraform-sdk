using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for event_trigger_config in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppJobEventTriggerConfigBlock : TerraformBlock
{
    /// <summary>
    /// The parallelism attribute.
    /// </summary>
    public TerraformProperty<double>? Parallelism
    {
        get => GetProperty<TerraformProperty<double>>("parallelism");
        set => WithProperty("parallelism", value);
    }

    /// <summary>
    /// The replica_completion_count attribute.
    /// </summary>
    public TerraformProperty<double>? ReplicaCompletionCount
    {
        get => GetProperty<TerraformProperty<double>>("replica_completion_count");
        set => WithProperty("replica_completion_count", value);
    }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppJobIdentityBlock : TerraformBlock
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
        get => GetRequiredProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for manual_trigger_config in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppJobManualTriggerConfigBlock : TerraformBlock
{
    /// <summary>
    /// The parallelism attribute.
    /// </summary>
    public TerraformProperty<double>? Parallelism
    {
        get => GetProperty<TerraformProperty<double>>("parallelism");
        set => WithProperty("parallelism", value);
    }

    /// <summary>
    /// The replica_completion_count attribute.
    /// </summary>
    public TerraformProperty<double>? ReplicaCompletionCount
    {
        get => GetProperty<TerraformProperty<double>>("replica_completion_count");
        set => WithProperty("replica_completion_count", value);
    }

}

/// <summary>
/// Block type for registry in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppJobRegistryBlock : TerraformBlock
{
    /// <summary>
    /// ID of the System or User Managed Identity used to pull images from the Container Registry
    /// </summary>
    public TerraformProperty<string>? Identity
    {
        get => GetProperty<TerraformProperty<string>>("identity");
        set => WithProperty("identity", value);
    }

    /// <summary>
    /// The name of the Secret Reference containing the password value for this user on the Container Registry.
    /// </summary>
    public TerraformProperty<string>? PasswordSecretName
    {
        get => GetProperty<TerraformProperty<string>>("password_secret_name");
        set => WithProperty("password_secret_name", value);
    }

    /// <summary>
    /// The hostname for the Container Registry.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Server is required")]
    public required TerraformProperty<string> Server
    {
        get => GetRequiredProperty<TerraformProperty<string>>("server");
        set => WithProperty("server", value);
    }

    /// <summary>
    /// The username to use for this Container Registry.
    /// </summary>
    public TerraformProperty<string>? Username
    {
        get => GetProperty<TerraformProperty<string>>("username");
        set => WithProperty("username", value);
    }

}

/// <summary>
/// Block type for schedule_trigger_config in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppJobScheduleTriggerConfigBlock : TerraformBlock
{
    /// <summary>
    /// The cron_expression attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CronExpression is required")]
    public required TerraformProperty<string> CronExpression
    {
        get => GetRequiredProperty<TerraformProperty<string>>("cron_expression");
        set => WithProperty("cron_expression", value);
    }

    /// <summary>
    /// The parallelism attribute.
    /// </summary>
    public TerraformProperty<double>? Parallelism
    {
        get => GetProperty<TerraformProperty<double>>("parallelism");
        set => WithProperty("parallelism", value);
    }

    /// <summary>
    /// The replica_completion_count attribute.
    /// </summary>
    public TerraformProperty<double>? ReplicaCompletionCount
    {
        get => GetProperty<TerraformProperty<double>>("replica_completion_count");
        set => WithProperty("replica_completion_count", value);
    }

}

/// <summary>
/// Block type for secret in .
/// Nesting mode: set
/// </summary>
public class AzurermContainerAppJobSecretBlock : TerraformBlock
{
    /// <summary>
    /// The identity to use for accessing key vault reference.
    /// </summary>
    public TerraformProperty<string>? Identity
    {
        get => GetProperty<TerraformProperty<string>>("identity");
        set => WithProperty("identity", value);
    }

    /// <summary>
    /// The Key Vault Secret ID. Could be either one of `id` or `versionless_id`.
    /// </summary>
    public TerraformProperty<string>? KeyVaultSecretId
    {
        get => GetProperty<TerraformProperty<string>>("key_vault_secret_id");
        set => WithProperty("key_vault_secret_id", value);
    }

    /// <summary>
    /// The secret name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The value for this secret.
    /// </summary>
    public TerraformProperty<string>? Value
    {
        get => GetProperty<TerraformProperty<string>>("value");
        set => WithProperty("value", value);
    }

}

/// <summary>
/// Block type for template in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppJobTemplateBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermContainerAppJobTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_container_app_job resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermContainerAppJob : TerraformResource
{
    public AzurermContainerAppJob(string name) : base("azurerm_container_app_job", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("event_stream_endpoint");
        this.WithOutput("outbound_ip_addresses");
    }

    /// <summary>
    /// The container_app_environment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerAppEnvironmentId is required")]
    public required TerraformProperty<string> ContainerAppEnvironmentId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("container_app_environment_id");
        set => this.WithProperty("container_app_environment_id", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The replica_retry_limit attribute.
    /// </summary>
    public TerraformProperty<double>? ReplicaRetryLimit
    {
        get => GetProperty<TerraformProperty<double>>("replica_retry_limit");
        set => this.WithProperty("replica_retry_limit", value);
    }

    /// <summary>
    /// The replica_timeout_in_seconds attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicaTimeoutInSeconds is required")]
    public required TerraformProperty<double> ReplicaTimeoutInSeconds
    {
        get => GetRequiredProperty<TerraformProperty<double>>("replica_timeout_in_seconds");
        set => this.WithProperty("replica_timeout_in_seconds", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
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
    /// The workload_profile_name attribute.
    /// </summary>
    public TerraformProperty<string>? WorkloadProfileName
    {
        get => GetProperty<TerraformProperty<string>>("workload_profile_name");
        set => this.WithProperty("workload_profile_name", value);
    }

    /// <summary>
    /// Block for event_trigger_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EventTriggerConfig block(s) allowed")]
    public List<AzurermContainerAppJobEventTriggerConfigBlock>? EventTriggerConfig
    {
        get => GetProperty<List<AzurermContainerAppJobEventTriggerConfigBlock>>("event_trigger_config");
        set => this.WithProperty("event_trigger_config", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermContainerAppJobIdentityBlock>? Identity
    {
        get => GetProperty<List<AzurermContainerAppJobIdentityBlock>>("identity");
        set => this.WithProperty("identity", value);
    }

    /// <summary>
    /// Block for manual_trigger_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManualTriggerConfig block(s) allowed")]
    public List<AzurermContainerAppJobManualTriggerConfigBlock>? ManualTriggerConfig
    {
        get => GetProperty<List<AzurermContainerAppJobManualTriggerConfigBlock>>("manual_trigger_config");
        set => this.WithProperty("manual_trigger_config", value);
    }

    /// <summary>
    /// Block for registry.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermContainerAppJobRegistryBlock>? Registry
    {
        get => GetProperty<List<AzurermContainerAppJobRegistryBlock>>("registry");
        set => this.WithProperty("registry", value);
    }

    /// <summary>
    /// Block for schedule_trigger_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScheduleTriggerConfig block(s) allowed")]
    public List<AzurermContainerAppJobScheduleTriggerConfigBlock>? ScheduleTriggerConfig
    {
        get => GetProperty<List<AzurermContainerAppJobScheduleTriggerConfigBlock>>("schedule_trigger_config");
        set => this.WithProperty("schedule_trigger_config", value);
    }

    /// <summary>
    /// Block for secret.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermContainerAppJobSecretBlock>? Secret
    {
        get => GetProperty<HashSet<AzurermContainerAppJobSecretBlock>>("secret");
        set => this.WithProperty("secret", value);
    }

    /// <summary>
    /// Block for template.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Template block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Template block(s) allowed")]
    public List<AzurermContainerAppJobTemplateBlock>? Template
    {
        get => GetProperty<List<AzurermContainerAppJobTemplateBlock>>("template");
        set => this.WithProperty("template", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermContainerAppJobTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermContainerAppJobTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The event_stream_endpoint attribute.
    /// </summary>
    public TerraformExpression EventStreamEndpoint => this["event_stream_endpoint"];

    /// <summary>
    /// The outbound_ip_addresses attribute.
    /// </summary>
    public TerraformExpression OutboundIpAddresses => this["outbound_ip_addresses"];

}
