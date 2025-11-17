using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for event_trigger_config in AzurermContainerAppJob.
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

    /// <summary>
    /// Scale block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermContainerAppJobEventTriggerConfigBlockScaleBlock>? Scale
    {
        get => GetArgument<TerraformList<AzurermContainerAppJobEventTriggerConfigBlockScaleBlock>>("scale");
        set => SetArgument("scale", value);
    }

}

/// <summary>
/// Block type for scale in AzurermContainerAppJobEventTriggerConfigBlock.
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppJobEventTriggerConfigBlockScaleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "scale";

    /// <summary>
    /// The max_executions attribute.
    /// </summary>
    public TerraformValue<double>? MaxExecutions
    {
        get => new TerraformReference<double>(this, "max_executions");
        set => SetArgument("max_executions", value);
    }

    /// <summary>
    /// The min_executions attribute.
    /// </summary>
    public TerraformValue<double>? MinExecutions
    {
        get => new TerraformReference<double>(this, "min_executions");
        set => SetArgument("min_executions", value);
    }

    /// <summary>
    /// The polling_interval_in_seconds attribute.
    /// </summary>
    public TerraformValue<double>? PollingIntervalInSeconds
    {
        get => new TerraformReference<double>(this, "polling_interval_in_seconds");
        set => SetArgument("polling_interval_in_seconds", value);
    }

    /// <summary>
    /// Rules block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermContainerAppJobEventTriggerConfigBlockScaleBlockRulesBlock>? Rules
    {
        get => GetArgument<TerraformList<AzurermContainerAppJobEventTriggerConfigBlockScaleBlockRulesBlock>>("rules");
        set => SetArgument("rules", value);
    }

}

/// <summary>
/// Block type for rules in AzurermContainerAppJobEventTriggerConfigBlockScaleBlock.
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppJobEventTriggerConfigBlockScaleBlockRulesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rules";

    /// <summary>
    /// The custom_rule_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomRuleType is required")]
    public required TerraformValue<string> CustomRuleType
    {
        get => new TerraformReference<string>(this, "custom_rule_type");
        set => SetArgument("custom_rule_type", value);
    }

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Metadata is required")]
    public required TerraformMap<string> Metadata
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "metadata").ResolveNodes(ctx));
        set => SetArgument("metadata", value);
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
    /// Authentication block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermContainerAppJobEventTriggerConfigBlockScaleBlockRulesBlockAuthenticationBlock>? Authentication
    {
        get => GetArgument<TerraformList<AzurermContainerAppJobEventTriggerConfigBlockScaleBlockRulesBlockAuthenticationBlock>>("authentication");
        set => SetArgument("authentication", value);
    }

}

/// <summary>
/// Block type for authentication in AzurermContainerAppJobEventTriggerConfigBlockScaleBlockRulesBlock.
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppJobEventTriggerConfigBlockScaleBlockRulesBlockAuthenticationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "authentication";

    /// <summary>
    /// The secret_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretName is required")]
    public required TerraformValue<string> SecretName
    {
        get => new TerraformReference<string>(this, "secret_name");
        set => SetArgument("secret_name", value);
    }

    /// <summary>
    /// The trigger_parameter attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TriggerParameter is required")]
    public required TerraformValue<string> TriggerParameter
    {
        get => new TerraformReference<string>(this, "trigger_parameter");
        set => SetArgument("trigger_parameter", value);
    }

}


/// <summary>
/// Block type for identity in AzurermContainerAppJob.
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
/// Block type for manual_trigger_config in AzurermContainerAppJob.
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
/// Block type for registry in AzurermContainerAppJob.
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
/// Block type for schedule_trigger_config in AzurermContainerAppJob.
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
/// Block type for secret in AzurermContainerAppJob.
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
/// Block type for template in AzurermContainerAppJob.
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppJobTemplateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "template";

    /// <summary>
    /// Container block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Container is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Container block(s) required")]
    public required TerraformList<AzurermContainerAppJobTemplateBlockContainerBlock> Container
    {
        get => GetRequiredArgument<TerraformList<AzurermContainerAppJobTemplateBlockContainerBlock>>("container");
        set => SetArgument("container", value);
    }

    /// <summary>
    /// InitContainer block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermContainerAppJobTemplateBlockInitContainerBlock>? InitContainer
    {
        get => GetArgument<TerraformList<AzurermContainerAppJobTemplateBlockInitContainerBlock>>("init_container");
        set => SetArgument("init_container", value);
    }

    /// <summary>
    /// Volume block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermContainerAppJobTemplateBlockVolumeBlock>? Volume
    {
        get => GetArgument<TerraformList<AzurermContainerAppJobTemplateBlockVolumeBlock>>("volume");
        set => SetArgument("volume", value);
    }

}

/// <summary>
/// Block type for container in AzurermContainerAppJobTemplateBlock.
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppJobTemplateBlockContainerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "container";

    /// <summary>
    /// A list of args to pass to the container.
    /// </summary>
    public TerraformList<string>? Args
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "args").ResolveNodes(ctx));
        set => SetArgument("args", value);
    }

    /// <summary>
    /// A command to pass to the container to override the default. This is provided as a list of command line elements without spaces.
    /// </summary>
    public TerraformList<string>? Command
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "command").ResolveNodes(ctx));
        set => SetArgument("command", value);
    }

    /// <summary>
    /// The amount of vCPU to allocate to the container.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cpu is required")]
    public required TerraformValue<double> Cpu
    {
        get => new TerraformReference<double>(this, "cpu");
        set => SetArgument("cpu", value);
    }

    /// <summary>
    /// The amount of ephemeral storage available to the Container App.
    /// </summary>
    public TerraformValue<string> EphemeralStorage
    {
        get => new TerraformReference<string>(this, "ephemeral_storage");
    }

    /// <summary>
    /// The image to use to create the container.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Image is required")]
    public required TerraformValue<string> Image
    {
        get => new TerraformReference<string>(this, "image");
        set => SetArgument("image", value);
    }

    /// <summary>
    /// The amount of memory to allocate to the container.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Memory is required")]
    public required TerraformValue<string> Memory
    {
        get => new TerraformReference<string>(this, "memory");
        set => SetArgument("memory", value);
    }

    /// <summary>
    /// The name of the container.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Env block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermContainerAppJobTemplateBlockContainerBlockEnvBlock>? Env
    {
        get => GetArgument<TerraformList<AzurermContainerAppJobTemplateBlockContainerBlockEnvBlock>>("env");
        set => SetArgument("env", value);
    }

    /// <summary>
    /// LivenessProbe block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermContainerAppJobTemplateBlockContainerBlockLivenessProbeBlock>? LivenessProbe
    {
        get => GetArgument<TerraformList<AzurermContainerAppJobTemplateBlockContainerBlockLivenessProbeBlock>>("liveness_probe");
        set => SetArgument("liveness_probe", value);
    }

    /// <summary>
    /// ReadinessProbe block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermContainerAppJobTemplateBlockContainerBlockReadinessProbeBlock>? ReadinessProbe
    {
        get => GetArgument<TerraformList<AzurermContainerAppJobTemplateBlockContainerBlockReadinessProbeBlock>>("readiness_probe");
        set => SetArgument("readiness_probe", value);
    }

    /// <summary>
    /// StartupProbe block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermContainerAppJobTemplateBlockContainerBlockStartupProbeBlock>? StartupProbe
    {
        get => GetArgument<TerraformList<AzurermContainerAppJobTemplateBlockContainerBlockStartupProbeBlock>>("startup_probe");
        set => SetArgument("startup_probe", value);
    }

    /// <summary>
    /// VolumeMounts block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermContainerAppJobTemplateBlockContainerBlockVolumeMountsBlock>? VolumeMounts
    {
        get => GetArgument<TerraformList<AzurermContainerAppJobTemplateBlockContainerBlockVolumeMountsBlock>>("volume_mounts");
        set => SetArgument("volume_mounts", value);
    }

}

/// <summary>
/// Block type for env in AzurermContainerAppJobTemplateBlockContainerBlock.
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppJobTemplateBlockContainerBlockEnvBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "env";

    /// <summary>
    /// The name of the environment variable for the container.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The name of the secret that contains the value for this environment variable.
    /// </summary>
    public TerraformValue<string>? SecretName
    {
        get => new TerraformReference<string>(this, "secret_name");
        set => SetArgument("secret_name", value);
    }

    /// <summary>
    /// The value for this environment variable. **NOTE:** This value is ignored if `secret_name` is used
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for liveness_probe in AzurermContainerAppJobTemplateBlockContainerBlock.
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppJobTemplateBlockContainerBlockLivenessProbeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "liveness_probe";

    /// <summary>
    /// The number of consecutive failures required to consider this probe as failed. Possible values are between `1` and `30`. Defaults to `3`.
    /// </summary>
    public TerraformValue<double>? FailureCountThreshold
    {
        get => new TerraformReference<double>(this, "failure_count_threshold");
        set => SetArgument("failure_count_threshold", value);
    }

    /// <summary>
    /// The probe hostname. Defaults to the pod IP address. Setting a value for `Host` in `headers` can be used to override this for `http` and `https` type probes.
    /// </summary>
    public TerraformValue<string>? Host
    {
        get => new TerraformReference<string>(this, "host");
        set => SetArgument("host", value);
    }

    /// <summary>
    /// The number of seconds elapsed after the container has started before the probe is initiated. Possible values are between `0` and `60`. Defaults to `1` seconds.
    /// </summary>
    public TerraformValue<double>? InitialDelay
    {
        get => new TerraformReference<double>(this, "initial_delay");
        set => SetArgument("initial_delay", value);
    }

    /// <summary>
    /// How often, in seconds, the probe should run. Possible values are between `1` and `240`. Defaults to `10`
    /// </summary>
    public TerraformValue<double>? IntervalSeconds
    {
        get => new TerraformReference<double>(this, "interval_seconds");
        set => SetArgument("interval_seconds", value);
    }

    /// <summary>
    /// The URI to use with the `host` for http type probes. Not valid for `TCP` type probes. Defaults to `/`.
    /// </summary>
    public TerraformValue<string> Path
    {
        get => new TerraformReference<string>(this, "path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// The port number on which to connect. Possible values are between `1` and `65535`.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    public required TerraformValue<double> Port
    {
        get => new TerraformReference<double>(this, "port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The time in seconds after the container is sent the termination signal before the process if forcibly killed.
    /// </summary>
    public TerraformValue<double> TerminationGracePeriodSeconds
    {
        get => new TerraformReference<double>(this, "termination_grace_period_seconds");
    }

    /// <summary>
    /// Time in seconds after which the probe times out. Possible values are between `1` an `240`. Defaults to `1`.
    /// </summary>
    public TerraformValue<double>? Timeout
    {
        get => new TerraformReference<double>(this, "timeout");
        set => SetArgument("timeout", value);
    }

    /// <summary>
    /// Type of probe. Possible values are `TCP`, `HTTP`, and `HTTPS`.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Transport is required")]
    public required TerraformValue<string> Transport
    {
        get => new TerraformReference<string>(this, "transport");
        set => SetArgument("transport", value);
    }

    /// <summary>
    /// Header block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermContainerAppJobTemplateBlockContainerBlockLivenessProbeBlockHeaderBlock>? Header
    {
        get => GetArgument<TerraformList<AzurermContainerAppJobTemplateBlockContainerBlockLivenessProbeBlockHeaderBlock>>("header");
        set => SetArgument("header", value);
    }

}

/// <summary>
/// Block type for header in AzurermContainerAppJobTemplateBlockContainerBlockLivenessProbeBlock.
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppJobTemplateBlockContainerBlockLivenessProbeBlockHeaderBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "header";

    /// <summary>
    /// The HTTP Header Name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The HTTP Header value.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for readiness_probe in AzurermContainerAppJobTemplateBlockContainerBlock.
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppJobTemplateBlockContainerBlockReadinessProbeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "readiness_probe";

    /// <summary>
    /// The number of consecutive failures required to consider this probe as failed. Possible values are between `1` and `30`. Defaults to `3`.
    /// </summary>
    public TerraformValue<double>? FailureCountThreshold
    {
        get => new TerraformReference<double>(this, "failure_count_threshold");
        set => SetArgument("failure_count_threshold", value);
    }

    /// <summary>
    /// The probe hostname. Defaults to the pod IP address. Setting a value for `Host` in `headers` can be used to override this for `http` and `https` type probes.
    /// </summary>
    public TerraformValue<string>? Host
    {
        get => new TerraformReference<string>(this, "host");
        set => SetArgument("host", value);
    }

    /// <summary>
    /// The number of seconds elapsed after the container has started before the probe is initiated. Possible values are between `0` and `60`. Defaults to `0` seconds.
    /// </summary>
    public TerraformValue<double>? InitialDelay
    {
        get => new TerraformReference<double>(this, "initial_delay");
        set => SetArgument("initial_delay", value);
    }

    /// <summary>
    /// How often, in seconds, the probe should run. Possible values are between `1` and `240`. Defaults to `10`
    /// </summary>
    public TerraformValue<double>? IntervalSeconds
    {
        get => new TerraformReference<double>(this, "interval_seconds");
        set => SetArgument("interval_seconds", value);
    }

    /// <summary>
    /// The URI to use for http type probes. Not valid for `TCP` type probes. Defaults to `/`.
    /// </summary>
    public TerraformValue<string> Path
    {
        get => new TerraformReference<string>(this, "path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// The port number on which to connect. Possible values are between `1` and `65535`.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    public required TerraformValue<double> Port
    {
        get => new TerraformReference<double>(this, "port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The number of consecutive successful responses required to consider this probe as successful. Possible values are between `1` and `10`. Defaults to `3`.
    /// </summary>
    public TerraformValue<double>? SuccessCountThreshold
    {
        get => new TerraformReference<double>(this, "success_count_threshold");
        set => SetArgument("success_count_threshold", value);
    }

    /// <summary>
    /// Time in seconds after which the probe times out. Possible values are between `1` an `240`. Defaults to `1`.
    /// </summary>
    public TerraformValue<double>? Timeout
    {
        get => new TerraformReference<double>(this, "timeout");
        set => SetArgument("timeout", value);
    }

    /// <summary>
    /// Type of probe. Possible values are `TCP`, `HTTP`, and `HTTPS`.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Transport is required")]
    public required TerraformValue<string> Transport
    {
        get => new TerraformReference<string>(this, "transport");
        set => SetArgument("transport", value);
    }

    /// <summary>
    /// Header block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermContainerAppJobTemplateBlockContainerBlockReadinessProbeBlockHeaderBlock>? Header
    {
        get => GetArgument<TerraformList<AzurermContainerAppJobTemplateBlockContainerBlockReadinessProbeBlockHeaderBlock>>("header");
        set => SetArgument("header", value);
    }

}

/// <summary>
/// Block type for header in AzurermContainerAppJobTemplateBlockContainerBlockReadinessProbeBlock.
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppJobTemplateBlockContainerBlockReadinessProbeBlockHeaderBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "header";

    /// <summary>
    /// The HTTP Header Name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The HTTP Header value.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for startup_probe in AzurermContainerAppJobTemplateBlockContainerBlock.
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppJobTemplateBlockContainerBlockStartupProbeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "startup_probe";

    /// <summary>
    /// The number of consecutive failures required to consider this probe as failed. Possible values are between `1` and `30`. Defaults to `3`.
    /// </summary>
    public TerraformValue<double>? FailureCountThreshold
    {
        get => new TerraformReference<double>(this, "failure_count_threshold");
        set => SetArgument("failure_count_threshold", value);
    }

    /// <summary>
    /// The probe hostname. Defaults to the pod IP address. Setting a value for `Host` in `headers` can be used to override this for `http` and `https` type probes.
    /// </summary>
    public TerraformValue<string>? Host
    {
        get => new TerraformReference<string>(this, "host");
        set => SetArgument("host", value);
    }

    /// <summary>
    /// The number of seconds elapsed after the container has started before the probe is initiated. Possible values are between `0` and `60`. Defaults to `0` seconds.
    /// </summary>
    public TerraformValue<double>? InitialDelay
    {
        get => new TerraformReference<double>(this, "initial_delay");
        set => SetArgument("initial_delay", value);
    }

    /// <summary>
    /// How often, in seconds, the probe should run. Possible values are between `1` and `240`. Defaults to `10`
    /// </summary>
    public TerraformValue<double>? IntervalSeconds
    {
        get => new TerraformReference<double>(this, "interval_seconds");
        set => SetArgument("interval_seconds", value);
    }

    /// <summary>
    /// The URI to use with the `host` for http type probes. Not valid for `TCP` type probes. Defaults to `/`.
    /// </summary>
    public TerraformValue<string> Path
    {
        get => new TerraformReference<string>(this, "path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// The port number on which to connect. Possible values are between `1` and `65535`.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    public required TerraformValue<double> Port
    {
        get => new TerraformReference<double>(this, "port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The time in seconds after the container is sent the termination signal before the process if forcibly killed.
    /// </summary>
    public TerraformValue<double> TerminationGracePeriodSeconds
    {
        get => new TerraformReference<double>(this, "termination_grace_period_seconds");
    }

    /// <summary>
    /// Time in seconds after which the probe times out. Possible values are between `1` an `240`. Defaults to `1`.
    /// </summary>
    public TerraformValue<double>? Timeout
    {
        get => new TerraformReference<double>(this, "timeout");
        set => SetArgument("timeout", value);
    }

    /// <summary>
    /// Type of probe. Possible values are `TCP`, `HTTP`, and `HTTPS`.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Transport is required")]
    public required TerraformValue<string> Transport
    {
        get => new TerraformReference<string>(this, "transport");
        set => SetArgument("transport", value);
    }

    /// <summary>
    /// Header block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermContainerAppJobTemplateBlockContainerBlockStartupProbeBlockHeaderBlock>? Header
    {
        get => GetArgument<TerraformList<AzurermContainerAppJobTemplateBlockContainerBlockStartupProbeBlockHeaderBlock>>("header");
        set => SetArgument("header", value);
    }

}

/// <summary>
/// Block type for header in AzurermContainerAppJobTemplateBlockContainerBlockStartupProbeBlock.
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppJobTemplateBlockContainerBlockStartupProbeBlockHeaderBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "header";

    /// <summary>
    /// The HTTP Header Name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The HTTP Header value.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for volume_mounts in AzurermContainerAppJobTemplateBlockContainerBlock.
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppJobTemplateBlockContainerBlockVolumeMountsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "volume_mounts";

    /// <summary>
    /// The name of the Volume to be mounted in the container.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The path in the container at which to mount this volume.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    public required TerraformValue<string> Path
    {
        get => new TerraformReference<string>(this, "path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// The sub path of the volume to be mounted in the container.
    /// </summary>
    public TerraformValue<string>? SubPath
    {
        get => new TerraformReference<string>(this, "sub_path");
        set => SetArgument("sub_path", value);
    }

}

/// <summary>
/// Block type for init_container in AzurermContainerAppJobTemplateBlock.
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppJobTemplateBlockInitContainerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "init_container";

    /// <summary>
    /// A list of args to pass to the container.
    /// </summary>
    public TerraformList<string>? Args
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "args").ResolveNodes(ctx));
        set => SetArgument("args", value);
    }

    /// <summary>
    /// A command to pass to the container to override the default. This is provided as a list of command line elements without spaces.
    /// </summary>
    public TerraformList<string>? Command
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "command").ResolveNodes(ctx));
        set => SetArgument("command", value);
    }

    /// <summary>
    /// The amount of vCPU to allocate to the container.
    /// </summary>
    public TerraformValue<double>? Cpu
    {
        get => new TerraformReference<double>(this, "cpu");
        set => SetArgument("cpu", value);
    }

    /// <summary>
    /// The amount of ephemeral storage available to the Container App.
    /// </summary>
    public TerraformValue<string> EphemeralStorage
    {
        get => new TerraformReference<string>(this, "ephemeral_storage");
    }

    /// <summary>
    /// The image to use to create the container.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Image is required")]
    public required TerraformValue<string> Image
    {
        get => new TerraformReference<string>(this, "image");
        set => SetArgument("image", value);
    }

    /// <summary>
    /// The amount of memory to allocate to the container.
    /// </summary>
    public TerraformValue<string>? Memory
    {
        get => new TerraformReference<string>(this, "memory");
        set => SetArgument("memory", value);
    }

    /// <summary>
    /// The name of the container.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Env block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermContainerAppJobTemplateBlockInitContainerBlockEnvBlock>? Env
    {
        get => GetArgument<TerraformList<AzurermContainerAppJobTemplateBlockInitContainerBlockEnvBlock>>("env");
        set => SetArgument("env", value);
    }

    /// <summary>
    /// VolumeMounts block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermContainerAppJobTemplateBlockInitContainerBlockVolumeMountsBlock>? VolumeMounts
    {
        get => GetArgument<TerraformList<AzurermContainerAppJobTemplateBlockInitContainerBlockVolumeMountsBlock>>("volume_mounts");
        set => SetArgument("volume_mounts", value);
    }

}

/// <summary>
/// Block type for env in AzurermContainerAppJobTemplateBlockInitContainerBlock.
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppJobTemplateBlockInitContainerBlockEnvBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "env";

    /// <summary>
    /// The name of the environment variable for the container.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The name of the secret that contains the value for this environment variable.
    /// </summary>
    public TerraformValue<string>? SecretName
    {
        get => new TerraformReference<string>(this, "secret_name");
        set => SetArgument("secret_name", value);
    }

    /// <summary>
    /// The value for this environment variable. **NOTE:** This value is ignored if `secret_name` is used
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for volume_mounts in AzurermContainerAppJobTemplateBlockInitContainerBlock.
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppJobTemplateBlockInitContainerBlockVolumeMountsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "volume_mounts";

    /// <summary>
    /// The name of the Volume to be mounted in the container.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The path in the container at which to mount this volume.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    public required TerraformValue<string> Path
    {
        get => new TerraformReference<string>(this, "path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// The sub path of the volume to be mounted in the container.
    /// </summary>
    public TerraformValue<string>? SubPath
    {
        get => new TerraformReference<string>(this, "sub_path");
        set => SetArgument("sub_path", value);
    }

}

/// <summary>
/// Block type for volume in AzurermContainerAppJobTemplateBlock.
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppJobTemplateBlockVolumeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "volume";

    /// <summary>
    /// Mount options used while mounting the AzureFile. Must be a comma-separated string.
    /// </summary>
    public TerraformValue<string>? MountOptions
    {
        get => new TerraformReference<string>(this, "mount_options");
        set => SetArgument("mount_options", value);
    }

    /// <summary>
    /// The name of the volume.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The name of the `AzureFile` storage. Required when `storage_type` is `AzureFile`
    /// </summary>
    public TerraformValue<string>? StorageName
    {
        get => new TerraformReference<string>(this, "storage_name");
        set => SetArgument("storage_name", value);
    }

    /// <summary>
    /// The type of storage volume. Possible values include `AzureFile` and `EmptyDir`. Defaults to `EmptyDir`.
    /// </summary>
    public TerraformValue<string>? StorageType
    {
        get => new TerraformReference<string>(this, "storage_type");
        set => SetArgument("storage_type", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermContainerAppJob.
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
    /// The event_stream_endpoint attribute.
    /// </summary>
    public TerraformValue<string> EventStreamEndpoint
    {
        get => new TerraformReference<string>(this, "event_stream_endpoint");
    }

    /// <summary>
    /// The outbound_ip_addresses attribute.
    /// </summary>
    public TerraformList<string> OutboundIpAddresses
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "outbound_ip_addresses").ResolveNodes(ctx));
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
