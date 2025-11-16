using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

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
    public TerraformValue<double>? Parallelism
    {
        get => new TerraformReference<double>(this, "parallelism");
        set => SetArgument("parallelism", value);
    }

    /// <summary>
    /// The replica_completion_count attribute.
    /// </summary>
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
    public TerraformSet<string>? IdentityIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "identity_ids").ResolveNodes(ctx));
        set => SetArgument("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformValue<string> PrincipalId
    {
        get => new TerraformReference<string>(this, "principal_id");
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string> TenantId
    {
        get => new TerraformReference<string>(this, "tenant_id");
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
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
    public TerraformValue<double>? Parallelism
    {
        get => new TerraformReference<double>(this, "parallelism");
        set => SetArgument("parallelism", value);
    }

    /// <summary>
    /// The replica_completion_count attribute.
    /// </summary>
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
    public TerraformValue<string>? Identity
    {
        get => new TerraformReference<string>(this, "identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// The name of the Secret Reference containing the password value for this user on the Container Registry.
    /// </summary>
    public TerraformValue<string>? PasswordSecretName
    {
        get => new TerraformReference<string>(this, "password_secret_name");
        set => SetArgument("password_secret_name", value);
    }

    /// <summary>
    /// The hostname for the Container Registry.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Server is required")]
    public required TerraformValue<string> Server
    {
        get => new TerraformReference<string>(this, "server");
        set => SetArgument("server", value);
    }

    /// <summary>
    /// The username to use for this Container Registry.
    /// </summary>
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
    public required TerraformValue<string> CronExpression
    {
        get => new TerraformReference<string>(this, "cron_expression");
        set => SetArgument("cron_expression", value);
    }

    /// <summary>
    /// The parallelism attribute.
    /// </summary>
    public TerraformValue<double>? Parallelism
    {
        get => new TerraformReference<double>(this, "parallelism");
        set => SetArgument("parallelism", value);
    }

    /// <summary>
    /// The replica_completion_count attribute.
    /// </summary>
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
    public TerraformValue<string>? Identity
    {
        get => new TerraformReference<string>(this, "identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// The Key Vault Secret ID. Could be either one of `id` or `versionless_id`.
    /// </summary>
    public TerraformValue<string>? KeyVaultSecretId
    {
        get => new TerraformReference<string>(this, "key_vault_secret_id");
        set => SetArgument("key_vault_secret_id", value);
    }

    /// <summary>
    /// The secret name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The value for this secret.
    /// </summary>
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
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Represents a azurerm_container_app_job Terraform resource.
/// Manages a azurerm_container_app_job resource.
/// </summary>
public partial class AzurermContainerAppJob(string name) : TerraformResource("azurerm_container_app_job", name)
{
    /// <summary>
    /// The container_app_environment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerAppEnvironmentId is required")]
    public required TerraformValue<string> ContainerAppEnvironmentId
    {
        get => new TerraformReference<string>(this, "container_app_environment_id");
        set => SetArgument("container_app_environment_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The replica_retry_limit attribute.
    /// </summary>
    public TerraformValue<double>? ReplicaRetryLimit
    {
        get => new TerraformReference<double>(this, "replica_retry_limit");
        set => SetArgument("replica_retry_limit", value);
    }

    /// <summary>
    /// The replica_timeout_in_seconds attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicaTimeoutInSeconds is required")]
    public required TerraformValue<double> ReplicaTimeoutInSeconds
    {
        get => new TerraformReference<double>(this, "replica_timeout_in_seconds");
        set => SetArgument("replica_timeout_in_seconds", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The workload_profile_name attribute.
    /// </summary>
    public TerraformValue<string>? WorkloadProfileName
    {
        get => new TerraformReference<string>(this, "workload_profile_name");
        set => SetArgument("workload_profile_name", value);
    }

    /// <summary>
    /// EventTriggerConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EventTriggerConfig block(s) allowed")]
    public TerraformList<AzurermContainerAppJobEventTriggerConfigBlock>? EventTriggerConfig
    {
        get => GetArgument<TerraformList<AzurermContainerAppJobEventTriggerConfigBlock>>("event_trigger_config");
        set => SetArgument("event_trigger_config", value);
    }

    /// <summary>
    /// Identity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public TerraformList<AzurermContainerAppJobIdentityBlock>? Identity
    {
        get => GetArgument<TerraformList<AzurermContainerAppJobIdentityBlock>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// ManualTriggerConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManualTriggerConfig block(s) allowed")]
    public TerraformList<AzurermContainerAppJobManualTriggerConfigBlock>? ManualTriggerConfig
    {
        get => GetArgument<TerraformList<AzurermContainerAppJobManualTriggerConfigBlock>>("manual_trigger_config");
        set => SetArgument("manual_trigger_config", value);
    }

    /// <summary>
    /// Registry block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermContainerAppJobRegistryBlock>? Registry
    {
        get => GetArgument<TerraformList<AzurermContainerAppJobRegistryBlock>>("registry");
        set => SetArgument("registry", value);
    }

    /// <summary>
    /// ScheduleTriggerConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScheduleTriggerConfig block(s) allowed")]
    public TerraformList<AzurermContainerAppJobScheduleTriggerConfigBlock>? ScheduleTriggerConfig
    {
        get => GetArgument<TerraformList<AzurermContainerAppJobScheduleTriggerConfigBlock>>("schedule_trigger_config");
        set => SetArgument("schedule_trigger_config", value);
    }

    /// <summary>
    /// Secret block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermContainerAppJobSecretBlock>? Secret
    {
        get => GetArgument<TerraformSet<AzurermContainerAppJobSecretBlock>>("secret");
        set => SetArgument("secret", value);
    }

    /// <summary>
    /// Template block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Template is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Template block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Template block(s) allowed")]
    public required TerraformList<AzurermContainerAppJobTemplateBlock> Template
    {
        get => GetRequiredArgument<TerraformList<AzurermContainerAppJobTemplateBlock>>("template");
        set => SetArgument("template", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermContainerAppJobTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermContainerAppJobTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
