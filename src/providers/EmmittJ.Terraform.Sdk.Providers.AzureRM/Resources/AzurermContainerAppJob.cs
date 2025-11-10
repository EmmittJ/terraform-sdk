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
        set => SetProperty("parallelism", value);
    }

    /// <summary>
    /// The replica_completion_count attribute.
    /// </summary>
    public TerraformProperty<double>? ReplicaCompletionCount
    {
        set => SetProperty("replica_completion_count", value);
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
        set => SetProperty("parallelism", value);
    }

    /// <summary>
    /// The replica_completion_count attribute.
    /// </summary>
    public TerraformProperty<double>? ReplicaCompletionCount
    {
        set => SetProperty("replica_completion_count", value);
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
        set => SetProperty("identity", value);
    }

    /// <summary>
    /// The name of the Secret Reference containing the password value for this user on the Container Registry.
    /// </summary>
    public TerraformProperty<string>? PasswordSecretName
    {
        set => SetProperty("password_secret_name", value);
    }

    /// <summary>
    /// The hostname for the Container Registry.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Server is required")]
    public required TerraformProperty<string> Server
    {
        set => SetProperty("server", value);
    }

    /// <summary>
    /// The username to use for this Container Registry.
    /// </summary>
    public TerraformProperty<string>? Username
    {
        set => SetProperty("username", value);
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
        set => SetProperty("cron_expression", value);
    }

    /// <summary>
    /// The parallelism attribute.
    /// </summary>
    public TerraformProperty<double>? Parallelism
    {
        set => SetProperty("parallelism", value);
    }

    /// <summary>
    /// The replica_completion_count attribute.
    /// </summary>
    public TerraformProperty<double>? ReplicaCompletionCount
    {
        set => SetProperty("replica_completion_count", value);
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
        set => SetProperty("identity", value);
    }

    /// <summary>
    /// The Key Vault Secret ID. Could be either one of `id` or `versionless_id`.
    /// </summary>
    public TerraformProperty<string>? KeyVaultSecretId
    {
        set => SetProperty("key_vault_secret_id", value);
    }

    /// <summary>
    /// The secret name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The value for this secret.
    /// </summary>
    public TerraformProperty<string>? Value
    {
        set => SetProperty("value", value);
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
        SetOutput("event_stream_endpoint");
        SetOutput("outbound_ip_addresses");
        SetOutput("container_app_environment_id");
        SetOutput("id");
        SetOutput("location");
        SetOutput("name");
        SetOutput("replica_retry_limit");
        SetOutput("replica_timeout_in_seconds");
        SetOutput("resource_group_name");
        SetOutput("tags");
        SetOutput("workload_profile_name");
    }

    /// <summary>
    /// The container_app_environment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerAppEnvironmentId is required")]
    public required TerraformProperty<string> ContainerAppEnvironmentId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("container_app_environment_id");
        set => SetProperty("container_app_environment_id", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
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
    /// The replica_retry_limit attribute.
    /// </summary>
    public TerraformProperty<double> ReplicaRetryLimit
    {
        get => GetRequiredOutput<TerraformProperty<double>>("replica_retry_limit");
        set => SetProperty("replica_retry_limit", value);
    }

    /// <summary>
    /// The replica_timeout_in_seconds attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicaTimeoutInSeconds is required")]
    public required TerraformProperty<double> ReplicaTimeoutInSeconds
    {
        get => GetRequiredOutput<TerraformProperty<double>>("replica_timeout_in_seconds");
        set => SetProperty("replica_timeout_in_seconds", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
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
    /// The workload_profile_name attribute.
    /// </summary>
    public TerraformProperty<string> WorkloadProfileName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("workload_profile_name");
        set => SetProperty("workload_profile_name", value);
    }

    /// <summary>
    /// Block for event_trigger_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EventTriggerConfig block(s) allowed")]
    public List<AzurermContainerAppJobEventTriggerConfigBlock>? EventTriggerConfig
    {
        set => SetProperty("event_trigger_config", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermContainerAppJobIdentityBlock>? Identity
    {
        set => SetProperty("identity", value);
    }

    /// <summary>
    /// Block for manual_trigger_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManualTriggerConfig block(s) allowed")]
    public List<AzurermContainerAppJobManualTriggerConfigBlock>? ManualTriggerConfig
    {
        set => SetProperty("manual_trigger_config", value);
    }

    /// <summary>
    /// Block for registry.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermContainerAppJobRegistryBlock>? Registry
    {
        set => SetProperty("registry", value);
    }

    /// <summary>
    /// Block for schedule_trigger_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScheduleTriggerConfig block(s) allowed")]
    public List<AzurermContainerAppJobScheduleTriggerConfigBlock>? ScheduleTriggerConfig
    {
        set => SetProperty("schedule_trigger_config", value);
    }

    /// <summary>
    /// Block for secret.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermContainerAppJobSecretBlock>? Secret
    {
        set => SetProperty("secret", value);
    }

    /// <summary>
    /// Block for template.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Template is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Template block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Template block(s) allowed")]
    public List<AzurermContainerAppJobTemplateBlock>? Template
    {
        set => SetProperty("template", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermContainerAppJobTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
