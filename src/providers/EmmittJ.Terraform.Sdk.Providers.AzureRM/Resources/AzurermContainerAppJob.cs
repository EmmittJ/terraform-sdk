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
/// Block type for event_trigger_config in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppJobEventTriggerConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "event_trigger_config";

    /// <summary>
    /// The parallelism attribute.
    /// </summary>
    [TerraformArgument("parallelism")]
    public TerraformValue<double>? Parallelism
    {
        get => new TerraformReference<double>(this, "parallelism");
        set => SetArgument("parallelism", value);
    }

    /// <summary>
    /// The replica_completion_count attribute.
    /// </summary>
    [TerraformArgument("replica_completion_count")]
    public TerraformValue<double>? ReplicaCompletionCount
    {
        get => new TerraformReference<double>(this, "replica_completion_count");
        set => SetArgument("replica_completion_count", value);
    }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppJobIdentityBlock : TerraformBlock
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
/// Block type for manual_trigger_config in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppJobManualTriggerConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "manual_trigger_config";

    /// <summary>
    /// The parallelism attribute.
    /// </summary>
    [TerraformArgument("parallelism")]
    public TerraformValue<double>? Parallelism
    {
        get => new TerraformReference<double>(this, "parallelism");
        set => SetArgument("parallelism", value);
    }

    /// <summary>
    /// The replica_completion_count attribute.
    /// </summary>
    [TerraformArgument("replica_completion_count")]
    public TerraformValue<double>? ReplicaCompletionCount
    {
        get => new TerraformReference<double>(this, "replica_completion_count");
        set => SetArgument("replica_completion_count", value);
    }

}

/// <summary>
/// Block type for registry in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppJobRegistryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "registry";

    /// <summary>
    /// ID of the System or User Managed Identity used to pull images from the Container Registry
    /// </summary>
    [TerraformArgument("identity")]
    public TerraformValue<string>? Identity
    {
        get => new TerraformReference<string>(this, "identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// The name of the Secret Reference containing the password value for this user on the Container Registry.
    /// </summary>
    [TerraformArgument("password_secret_name")]
    public TerraformValue<string>? PasswordSecretName
    {
        get => new TerraformReference<string>(this, "password_secret_name");
        set => SetArgument("password_secret_name", value);
    }

    /// <summary>
    /// The hostname for the Container Registry.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Server is required")]
    [TerraformArgument("server")]
    public required TerraformValue<string> Server
    {
        get => new TerraformReference<string>(this, "server");
        set => SetArgument("server", value);
    }

    /// <summary>
    /// The username to use for this Container Registry.
    /// </summary>
    [TerraformArgument("username")]
    public TerraformValue<string>? Username
    {
        get => new TerraformReference<string>(this, "username");
        set => SetArgument("username", value);
    }

}

/// <summary>
/// Block type for schedule_trigger_config in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppJobScheduleTriggerConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "schedule_trigger_config";

    /// <summary>
    /// The cron_expression attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CronExpression is required")]
    [TerraformArgument("cron_expression")]
    public required TerraformValue<string> CronExpression
    {
        get => new TerraformReference<string>(this, "cron_expression");
        set => SetArgument("cron_expression", value);
    }

    /// <summary>
    /// The parallelism attribute.
    /// </summary>
    [TerraformArgument("parallelism")]
    public TerraformValue<double>? Parallelism
    {
        get => new TerraformReference<double>(this, "parallelism");
        set => SetArgument("parallelism", value);
    }

    /// <summary>
    /// The replica_completion_count attribute.
    /// </summary>
    [TerraformArgument("replica_completion_count")]
    public TerraformValue<double>? ReplicaCompletionCount
    {
        get => new TerraformReference<double>(this, "replica_completion_count");
        set => SetArgument("replica_completion_count", value);
    }

}

/// <summary>
/// Block type for secret in .
/// Nesting mode: set
/// </summary>
public class AzurermContainerAppJobSecretBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "secret";

    /// <summary>
    /// The identity to use for accessing key vault reference.
    /// </summary>
    [TerraformArgument("identity")]
    public TerraformValue<string>? Identity
    {
        get => new TerraformReference<string>(this, "identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// The Key Vault Secret ID. Could be either one of `id` or `versionless_id`.
    /// </summary>
    [TerraformArgument("key_vault_secret_id")]
    public TerraformValue<string>? KeyVaultSecretId
    {
        get => new TerraformReference<string>(this, "key_vault_secret_id");
        set => SetArgument("key_vault_secret_id", value);
    }

    /// <summary>
    /// The secret name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The value for this secret.
    /// </summary>
    [TerraformArgument("value")]
    public TerraformValue<string>? Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for template in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppJobTemplateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "template";

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermContainerAppJobTimeoutsBlock : TerraformBlock
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
    [TerraformArgument("container_app_environment_id")]
    public required TerraformValue<string> ContainerAppEnvironmentId
    {
        get => new TerraformReference<string>(this, "container_app_environment_id");
        set => SetArgument("container_app_environment_id", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
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
    /// The replica_retry_limit attribute.
    /// </summary>
    [TerraformArgument("replica_retry_limit")]
    public TerraformValue<double>? ReplicaRetryLimit
    {
        get => new TerraformReference<double>(this, "replica_retry_limit");
        set => SetArgument("replica_retry_limit", value);
    }

    /// <summary>
    /// The replica_timeout_in_seconds attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicaTimeoutInSeconds is required")]
    [TerraformArgument("replica_timeout_in_seconds")]
    public required TerraformValue<double> ReplicaTimeoutInSeconds
    {
        get => new TerraformReference<double>(this, "replica_timeout_in_seconds");
        set => SetArgument("replica_timeout_in_seconds", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
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
    /// The workload_profile_name attribute.
    /// </summary>
    [TerraformArgument("workload_profile_name")]
    public TerraformValue<string>? WorkloadProfileName
    {
        get => new TerraformReference<string>(this, "workload_profile_name");
        set => SetArgument("workload_profile_name", value);
    }

    /// <summary>
    /// Block for event_trigger_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EventTriggerConfig block(s) allowed")]
    [TerraformArgument("event_trigger_config")]
    public TerraformList<AzurermContainerAppJobEventTriggerConfigBlock> EventTriggerConfig { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformArgument("identity")]
    public TerraformList<AzurermContainerAppJobIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for manual_trigger_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManualTriggerConfig block(s) allowed")]
    [TerraformArgument("manual_trigger_config")]
    public TerraformList<AzurermContainerAppJobManualTriggerConfigBlock> ManualTriggerConfig { get; set; } = new();

    /// <summary>
    /// Block for registry.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("registry")]
    public TerraformList<AzurermContainerAppJobRegistryBlock> Registry { get; set; } = new();

    /// <summary>
    /// Block for schedule_trigger_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScheduleTriggerConfig block(s) allowed")]
    [TerraformArgument("schedule_trigger_config")]
    public TerraformList<AzurermContainerAppJobScheduleTriggerConfigBlock> ScheduleTriggerConfig { get; set; } = new();

    /// <summary>
    /// Block for secret.
    /// Nesting mode: set
    /// </summary>
    [TerraformArgument("secret")]
    public TerraformSet<AzurermContainerAppJobSecretBlock> Secret { get; set; } = new();

    /// <summary>
    /// Block for template.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Template is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Template block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Template block(s) allowed")]
    [TerraformArgument("template")]
    public required TerraformList<AzurermContainerAppJobTemplateBlock> Template { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermContainerAppJobTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The event_stream_endpoint attribute.
    /// </summary>
    [TerraformArgument("event_stream_endpoint")]
    public TerraformValue<string> EventStreamEndpoint
    {
        get => new TerraformReference<string>(this, "event_stream_endpoint");
    }

    /// <summary>
    /// The outbound_ip_addresses attribute.
    /// </summary>
    [TerraformArgument("outbound_ip_addresses")]
    public TerraformList<string> OutboundIpAddresses
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "outbound_ip_addresses").ResolveNodes(ctx));
    }

}
