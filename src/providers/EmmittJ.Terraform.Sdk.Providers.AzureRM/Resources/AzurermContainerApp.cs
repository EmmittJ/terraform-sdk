using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for dapr in AzurermContainerApp.
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppDaprBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dapr";

    /// <summary>
    /// The Dapr Application Identifier.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppId is required")]
    public required TerraformValue<string> AppId
    {
        get => new TerraformReference<string>(this, "app_id");
        set => SetArgument("app_id", value);
    }

    /// <summary>
    /// The port which the application is listening on. This is the same as the `ingress` port.
    /// </summary>
    public TerraformValue<double>? AppPort
    {
        get => new TerraformReference<double>(this, "app_port");
        set => SetArgument("app_port", value);
    }

    /// <summary>
    /// The protocol for the app. Possible values include `http` and `grpc`. Defaults to `http`.
    /// </summary>
    public TerraformValue<string>? AppProtocol
    {
        get => new TerraformReference<string>(this, "app_protocol");
        set => SetArgument("app_protocol", value);
    }

}


/// <summary>
/// Block type for identity in AzurermContainerApp.
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppIdentityBlock : TerraformBlock
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
/// Block type for ingress in AzurermContainerApp.
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppIngressBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ingress";

    /// <summary>
    /// Should this ingress allow insecure connections?
    /// </summary>
    public TerraformValue<bool>? AllowInsecureConnections
    {
        get => new TerraformReference<bool>(this, "allow_insecure_connections");
        set => SetArgument("allow_insecure_connections", value);
    }

    /// <summary>
    /// Client certificate mode for mTLS authentication. Ignore indicates server drops client certificate on forwarding. Accept indicates server forwards client certificate but does not require a client certificate. Require indicates server requires a client certificate.
    /// </summary>
    public TerraformValue<string>? ClientCertificateMode
    {
        get => new TerraformReference<string>(this, "client_certificate_mode");
        set => SetArgument("client_certificate_mode", value);
    }

    /// <summary>
    /// The custom_domain attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> CustomDomain
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "custom_domain").ResolveNodes(ctx));
    }

    /// <summary>
    /// The exposed port on the container for the Ingress traffic.
    /// </summary>
    public TerraformValue<double>? ExposedPort
    {
        get => new TerraformReference<double>(this, "exposed_port");
        set => SetArgument("exposed_port", value);
    }

    /// <summary>
    /// Is this an external Ingress.
    /// </summary>
    public TerraformValue<bool>? ExternalEnabled
    {
        get => new TerraformReference<bool>(this, "external_enabled");
        set => SetArgument("external_enabled", value);
    }

    /// <summary>
    /// The FQDN of the ingress.
    /// </summary>
    public TerraformValue<string> Fqdn
    {
        get => new TerraformReference<string>(this, "fqdn");
    }

    /// <summary>
    /// The target port on the container for the Ingress traffic.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetPort is required")]
    public required TerraformValue<double> TargetPort
    {
        get => new TerraformReference<double>(this, "target_port");
        set => SetArgument("target_port", value);
    }

    /// <summary>
    /// The transport method for the Ingress. Possible values include `auto`, `http`, and `http2`, `tcp`. Defaults to `auto`
    /// </summary>
    public TerraformValue<string>? Transport
    {
        get => new TerraformReference<string>(this, "transport");
        set => SetArgument("transport", value);
    }

    /// <summary>
    /// Cors block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Cors block(s) allowed")]
    public TerraformList<AzurermContainerAppIngressBlockCorsBlock>? Cors
    {
        get => GetArgument<TerraformList<AzurermContainerAppIngressBlockCorsBlock>>("cors");
        set => SetArgument("cors", value);
    }

    /// <summary>
    /// IpSecurityRestriction block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermContainerAppIngressBlockIpSecurityRestrictionBlock>? IpSecurityRestriction
    {
        get => GetArgument<TerraformList<AzurermContainerAppIngressBlockIpSecurityRestrictionBlock>>("ip_security_restriction");
        set => SetArgument("ip_security_restriction", value);
    }

    /// <summary>
    /// TrafficWeight block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrafficWeight is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 TrafficWeight block(s) required")]
    public required TerraformList<AzurermContainerAppIngressBlockTrafficWeightBlock> TrafficWeight
    {
        get => GetRequiredArgument<TerraformList<AzurermContainerAppIngressBlockTrafficWeightBlock>>("traffic_weight");
        set => SetArgument("traffic_weight", value);
    }

}

/// <summary>
/// Block type for cors in AzurermContainerAppIngressBlock.
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppIngressBlockCorsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cors";

    /// <summary>
    /// The allow_credentials_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? AllowCredentialsEnabled
    {
        get => new TerraformReference<bool>(this, "allow_credentials_enabled");
        set => SetArgument("allow_credentials_enabled", value);
    }

    /// <summary>
    /// The allowed_headers attribute.
    /// </summary>
    public TerraformList<string>? AllowedHeaders
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "allowed_headers").ResolveNodes(ctx));
        set => SetArgument("allowed_headers", value);
    }

    /// <summary>
    /// The allowed_methods attribute.
    /// </summary>
    public TerraformList<string>? AllowedMethods
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "allowed_methods").ResolveNodes(ctx));
        set => SetArgument("allowed_methods", value);
    }

    /// <summary>
    /// The allowed_origins attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedOrigins is required")]
    public TerraformList<string>? AllowedOrigins
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "allowed_origins").ResolveNodes(ctx));
        set => SetArgument("allowed_origins", value);
    }

    /// <summary>
    /// The exposed_headers attribute.
    /// </summary>
    public TerraformList<string>? ExposedHeaders
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "exposed_headers").ResolveNodes(ctx));
        set => SetArgument("exposed_headers", value);
    }

    /// <summary>
    /// The max_age_in_seconds attribute.
    /// </summary>
    public TerraformValue<double>? MaxAgeInSeconds
    {
        get => new TerraformReference<double>(this, "max_age_in_seconds");
        set => SetArgument("max_age_in_seconds", value);
    }

}

/// <summary>
/// Block type for ip_security_restriction in AzurermContainerAppIngressBlock.
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppIngressBlockIpSecurityRestrictionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ip_security_restriction";

    /// <summary>
    /// The action. Allow or Deny.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    public required TerraformValue<string> Action
    {
        get => new TerraformReference<string>(this, "action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// Describe the IP restriction rule that is being sent to the container-app.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The incoming IP address or range of IP addresses (in CIDR notation).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpAddressRange is required")]
    public required TerraformValue<string> IpAddressRange
    {
        get => new TerraformReference<string>(this, "ip_address_range");
        set => SetArgument("ip_address_range", value);
    }

    /// <summary>
    /// Name for the IP restriction rule.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for traffic_weight in AzurermContainerAppIngressBlock.
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppIngressBlockTrafficWeightBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "traffic_weight";

    /// <summary>
    /// The label to apply to the revision as a name prefix for routing traffic.
    /// </summary>
    public TerraformValue<string>? Label
    {
        get => new TerraformReference<string>(this, "label");
        set => SetArgument("label", value);
    }

    /// <summary>
    /// This traffic Weight relates to the latest stable Container Revision.
    /// </summary>
    public TerraformValue<bool>? LatestRevision
    {
        get => new TerraformReference<bool>(this, "latest_revision");
        set => SetArgument("latest_revision", value);
    }

    /// <summary>
    /// The percentage of traffic to send to this revision.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Percentage is required")]
    public required TerraformValue<double> Percentage
    {
        get => new TerraformReference<double>(this, "percentage");
        set => SetArgument("percentage", value);
    }

    /// <summary>
    /// The suffix string to append to the revision. This must be unique for the Container App&#39;s lifetime. A default hash created by the service will be used if this value is omitted.
    /// </summary>
    public TerraformValue<string>? RevisionSuffix
    {
        get => new TerraformReference<string>(this, "revision_suffix");
        set => SetArgument("revision_suffix", value);
    }

}


/// <summary>
/// Block type for registry in AzurermContainerApp.
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppRegistryBlock : TerraformBlock
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
/// Block type for secret in AzurermContainerApp.
/// Nesting mode: set
/// </summary>
public class AzurermContainerAppSecretBlock : TerraformBlock
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
/// Block type for template in AzurermContainerApp.
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppTemplateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "template";

    /// <summary>
    /// The maximum number of replicas for this container.
    /// </summary>
    public TerraformValue<double>? MaxReplicas
    {
        get => new TerraformReference<double>(this, "max_replicas");
        set => SetArgument("max_replicas", value);
    }

    /// <summary>
    /// The minimum number of replicas for this container.
    /// </summary>
    public TerraformValue<double>? MinReplicas
    {
        get => new TerraformReference<double>(this, "min_replicas");
        set => SetArgument("min_replicas", value);
    }

    /// <summary>
    /// The suffix for the revision. This value must be unique for the lifetime of the Resource. If omitted the service will use a hash function to create one.
    /// </summary>
    public TerraformValue<string> RevisionSuffix
    {
        get => new TerraformReference<string>(this, "revision_suffix");
        set => SetArgument("revision_suffix", value);
    }

    /// <summary>
    /// The time in seconds after the container is sent the termination signal before the process if forcibly killed.
    /// </summary>
    public TerraformValue<double>? TerminationGracePeriodSeconds
    {
        get => new TerraformReference<double>(this, "termination_grace_period_seconds");
        set => SetArgument("termination_grace_period_seconds", value);
    }

    /// <summary>
    /// AzureQueueScaleRule block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermContainerAppTemplateBlockAzureQueueScaleRuleBlock>? AzureQueueScaleRule
    {
        get => GetArgument<TerraformList<AzurermContainerAppTemplateBlockAzureQueueScaleRuleBlock>>("azure_queue_scale_rule");
        set => SetArgument("azure_queue_scale_rule", value);
    }

    /// <summary>
    /// Container block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Container is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Container block(s) required")]
    public required TerraformList<AzurermContainerAppTemplateBlockContainerBlock> Container
    {
        get => GetRequiredArgument<TerraformList<AzurermContainerAppTemplateBlockContainerBlock>>("container");
        set => SetArgument("container", value);
    }

    /// <summary>
    /// CustomScaleRule block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermContainerAppTemplateBlockCustomScaleRuleBlock>? CustomScaleRule
    {
        get => GetArgument<TerraformList<AzurermContainerAppTemplateBlockCustomScaleRuleBlock>>("custom_scale_rule");
        set => SetArgument("custom_scale_rule", value);
    }

    /// <summary>
    /// HttpScaleRule block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermContainerAppTemplateBlockHttpScaleRuleBlock>? HttpScaleRule
    {
        get => GetArgument<TerraformList<AzurermContainerAppTemplateBlockHttpScaleRuleBlock>>("http_scale_rule");
        set => SetArgument("http_scale_rule", value);
    }

    /// <summary>
    /// InitContainer block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermContainerAppTemplateBlockInitContainerBlock>? InitContainer
    {
        get => GetArgument<TerraformList<AzurermContainerAppTemplateBlockInitContainerBlock>>("init_container");
        set => SetArgument("init_container", value);
    }

    /// <summary>
    /// TcpScaleRule block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermContainerAppTemplateBlockTcpScaleRuleBlock>? TcpScaleRule
    {
        get => GetArgument<TerraformList<AzurermContainerAppTemplateBlockTcpScaleRuleBlock>>("tcp_scale_rule");
        set => SetArgument("tcp_scale_rule", value);
    }

    /// <summary>
    /// Volume block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermContainerAppTemplateBlockVolumeBlock>? Volume
    {
        get => GetArgument<TerraformList<AzurermContainerAppTemplateBlockVolumeBlock>>("volume");
        set => SetArgument("volume", value);
    }

}

/// <summary>
/// Block type for azure_queue_scale_rule in AzurermContainerAppTemplateBlock.
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppTemplateBlockAzureQueueScaleRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "azure_queue_scale_rule";

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
    /// The queue_length attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueueLength is required")]
    public required TerraformValue<double> QueueLength
    {
        get => new TerraformReference<double>(this, "queue_length");
        set => SetArgument("queue_length", value);
    }

    /// <summary>
    /// The queue_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueueName is required")]
    public required TerraformValue<string> QueueName
    {
        get => new TerraformReference<string>(this, "queue_name");
        set => SetArgument("queue_name", value);
    }

    /// <summary>
    /// Authentication block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Authentication is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Authentication block(s) required")]
    public required TerraformList<AzurermContainerAppTemplateBlockAzureQueueScaleRuleBlockAuthenticationBlock> Authentication
    {
        get => GetRequiredArgument<TerraformList<AzurermContainerAppTemplateBlockAzureQueueScaleRuleBlockAuthenticationBlock>>("authentication");
        set => SetArgument("authentication", value);
    }

}

/// <summary>
/// Block type for authentication in AzurermContainerAppTemplateBlockAzureQueueScaleRuleBlock.
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppTemplateBlockAzureQueueScaleRuleBlockAuthenticationBlock : TerraformBlock
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
/// Block type for container in AzurermContainerAppTemplateBlock.
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppTemplateBlockContainerBlock : TerraformBlock
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
    public TerraformList<AzurermContainerAppTemplateBlockContainerBlockEnvBlock>? Env
    {
        get => GetArgument<TerraformList<AzurermContainerAppTemplateBlockContainerBlockEnvBlock>>("env");
        set => SetArgument("env", value);
    }

    /// <summary>
    /// LivenessProbe block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermContainerAppTemplateBlockContainerBlockLivenessProbeBlock>? LivenessProbe
    {
        get => GetArgument<TerraformList<AzurermContainerAppTemplateBlockContainerBlockLivenessProbeBlock>>("liveness_probe");
        set => SetArgument("liveness_probe", value);
    }

    /// <summary>
    /// ReadinessProbe block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermContainerAppTemplateBlockContainerBlockReadinessProbeBlock>? ReadinessProbe
    {
        get => GetArgument<TerraformList<AzurermContainerAppTemplateBlockContainerBlockReadinessProbeBlock>>("readiness_probe");
        set => SetArgument("readiness_probe", value);
    }

    /// <summary>
    /// StartupProbe block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermContainerAppTemplateBlockContainerBlockStartupProbeBlock>? StartupProbe
    {
        get => GetArgument<TerraformList<AzurermContainerAppTemplateBlockContainerBlockStartupProbeBlock>>("startup_probe");
        set => SetArgument("startup_probe", value);
    }

    /// <summary>
    /// VolumeMounts block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermContainerAppTemplateBlockContainerBlockVolumeMountsBlock>? VolumeMounts
    {
        get => GetArgument<TerraformList<AzurermContainerAppTemplateBlockContainerBlockVolumeMountsBlock>>("volume_mounts");
        set => SetArgument("volume_mounts", value);
    }

}

/// <summary>
/// Block type for env in AzurermContainerAppTemplateBlockContainerBlock.
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppTemplateBlockContainerBlockEnvBlock : TerraformBlock
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
/// Block type for liveness_probe in AzurermContainerAppTemplateBlockContainerBlock.
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppTemplateBlockContainerBlockLivenessProbeBlock : TerraformBlock
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
    public TerraformList<AzurermContainerAppTemplateBlockContainerBlockLivenessProbeBlockHeaderBlock>? Header
    {
        get => GetArgument<TerraformList<AzurermContainerAppTemplateBlockContainerBlockLivenessProbeBlockHeaderBlock>>("header");
        set => SetArgument("header", value);
    }

}

/// <summary>
/// Block type for header in AzurermContainerAppTemplateBlockContainerBlockLivenessProbeBlock.
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppTemplateBlockContainerBlockLivenessProbeBlockHeaderBlock : TerraformBlock
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
/// Block type for readiness_probe in AzurermContainerAppTemplateBlockContainerBlock.
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppTemplateBlockContainerBlockReadinessProbeBlock : TerraformBlock
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
    public TerraformList<AzurermContainerAppTemplateBlockContainerBlockReadinessProbeBlockHeaderBlock>? Header
    {
        get => GetArgument<TerraformList<AzurermContainerAppTemplateBlockContainerBlockReadinessProbeBlockHeaderBlock>>("header");
        set => SetArgument("header", value);
    }

}

/// <summary>
/// Block type for header in AzurermContainerAppTemplateBlockContainerBlockReadinessProbeBlock.
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppTemplateBlockContainerBlockReadinessProbeBlockHeaderBlock : TerraformBlock
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
/// Block type for startup_probe in AzurermContainerAppTemplateBlockContainerBlock.
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppTemplateBlockContainerBlockStartupProbeBlock : TerraformBlock
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
    public TerraformList<AzurermContainerAppTemplateBlockContainerBlockStartupProbeBlockHeaderBlock>? Header
    {
        get => GetArgument<TerraformList<AzurermContainerAppTemplateBlockContainerBlockStartupProbeBlockHeaderBlock>>("header");
        set => SetArgument("header", value);
    }

}

/// <summary>
/// Block type for header in AzurermContainerAppTemplateBlockContainerBlockStartupProbeBlock.
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppTemplateBlockContainerBlockStartupProbeBlockHeaderBlock : TerraformBlock
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
/// Block type for volume_mounts in AzurermContainerAppTemplateBlockContainerBlock.
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppTemplateBlockContainerBlockVolumeMountsBlock : TerraformBlock
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
/// Block type for custom_scale_rule in AzurermContainerAppTemplateBlock.
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppTemplateBlockCustomScaleRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_scale_rule";

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
    public TerraformList<AzurermContainerAppTemplateBlockCustomScaleRuleBlockAuthenticationBlock>? Authentication
    {
        get => GetArgument<TerraformList<AzurermContainerAppTemplateBlockCustomScaleRuleBlockAuthenticationBlock>>("authentication");
        set => SetArgument("authentication", value);
    }

}

/// <summary>
/// Block type for authentication in AzurermContainerAppTemplateBlockCustomScaleRuleBlock.
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppTemplateBlockCustomScaleRuleBlockAuthenticationBlock : TerraformBlock
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
/// Block type for http_scale_rule in AzurermContainerAppTemplateBlock.
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppTemplateBlockHttpScaleRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "http_scale_rule";

    /// <summary>
    /// The concurrent_requests attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConcurrentRequests is required")]
    public required TerraformValue<string> ConcurrentRequests
    {
        get => new TerraformReference<string>(this, "concurrent_requests");
        set => SetArgument("concurrent_requests", value);
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
    public TerraformList<AzurermContainerAppTemplateBlockHttpScaleRuleBlockAuthenticationBlock>? Authentication
    {
        get => GetArgument<TerraformList<AzurermContainerAppTemplateBlockHttpScaleRuleBlockAuthenticationBlock>>("authentication");
        set => SetArgument("authentication", value);
    }

}

/// <summary>
/// Block type for authentication in AzurermContainerAppTemplateBlockHttpScaleRuleBlock.
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppTemplateBlockHttpScaleRuleBlockAuthenticationBlock : TerraformBlock
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
    public TerraformValue<string>? TriggerParameter
    {
        get => new TerraformReference<string>(this, "trigger_parameter");
        set => SetArgument("trigger_parameter", value);
    }

}

/// <summary>
/// Block type for init_container in AzurermContainerAppTemplateBlock.
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppTemplateBlockInitContainerBlock : TerraformBlock
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
    public TerraformList<AzurermContainerAppTemplateBlockInitContainerBlockEnvBlock>? Env
    {
        get => GetArgument<TerraformList<AzurermContainerAppTemplateBlockInitContainerBlockEnvBlock>>("env");
        set => SetArgument("env", value);
    }

    /// <summary>
    /// VolumeMounts block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermContainerAppTemplateBlockInitContainerBlockVolumeMountsBlock>? VolumeMounts
    {
        get => GetArgument<TerraformList<AzurermContainerAppTemplateBlockInitContainerBlockVolumeMountsBlock>>("volume_mounts");
        set => SetArgument("volume_mounts", value);
    }

}

/// <summary>
/// Block type for env in AzurermContainerAppTemplateBlockInitContainerBlock.
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppTemplateBlockInitContainerBlockEnvBlock : TerraformBlock
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
/// Block type for volume_mounts in AzurermContainerAppTemplateBlockInitContainerBlock.
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppTemplateBlockInitContainerBlockVolumeMountsBlock : TerraformBlock
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
/// Block type for tcp_scale_rule in AzurermContainerAppTemplateBlock.
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppTemplateBlockTcpScaleRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tcp_scale_rule";

    /// <summary>
    /// The concurrent_requests attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConcurrentRequests is required")]
    public required TerraformValue<string> ConcurrentRequests
    {
        get => new TerraformReference<string>(this, "concurrent_requests");
        set => SetArgument("concurrent_requests", value);
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
    public TerraformList<AzurermContainerAppTemplateBlockTcpScaleRuleBlockAuthenticationBlock>? Authentication
    {
        get => GetArgument<TerraformList<AzurermContainerAppTemplateBlockTcpScaleRuleBlockAuthenticationBlock>>("authentication");
        set => SetArgument("authentication", value);
    }

}

/// <summary>
/// Block type for authentication in AzurermContainerAppTemplateBlockTcpScaleRuleBlock.
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppTemplateBlockTcpScaleRuleBlockAuthenticationBlock : TerraformBlock
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
    public TerraformValue<string>? TriggerParameter
    {
        get => new TerraformReference<string>(this, "trigger_parameter");
        set => SetArgument("trigger_parameter", value);
    }

}

/// <summary>
/// Block type for volume in AzurermContainerAppTemplateBlock.
/// Nesting mode: list
/// </summary>
public class AzurermContainerAppTemplateBlockVolumeBlock : TerraformBlock
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
/// Block type for timeouts in AzurermContainerApp.
/// Nesting mode: single
/// </summary>
public class AzurermContainerAppTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_container_app Terraform resource.
/// Manages a azurerm_container_app resource.
/// </summary>
public partial class AzurermContainerApp(string name) : TerraformResource("azurerm_container_app", name)
{
    /// <summary>
    /// The ID of the Container App Environment to host this Container App.
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
    /// The max_inactive_revisions attribute.
    /// </summary>
    public TerraformValue<double>? MaxInactiveRevisions
    {
        get => new TerraformReference<double>(this, "max_inactive_revisions");
        set => SetArgument("max_inactive_revisions", value);
    }

    /// <summary>
    /// The name for this Container App.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
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
    /// The revision_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RevisionMode is required")]
    public required TerraformValue<string> RevisionMode
    {
        get => new TerraformReference<string>(this, "revision_mode");
        set => SetArgument("revision_mode", value);
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
    /// The ID of the Custom Domain Verification for this Container App.
    /// </summary>
    public TerraformValue<string> CustomDomainVerificationId
    {
        get => new TerraformReference<string>(this, "custom_domain_verification_id");
    }

    /// <summary>
    /// The FQDN of the Latest Revision of the Container App.
    /// </summary>
    public TerraformValue<string> LatestRevisionFqdn
    {
        get => new TerraformReference<string>(this, "latest_revision_fqdn");
    }

    /// <summary>
    /// The name of the latest Container Revision.
    /// </summary>
    public TerraformValue<string> LatestRevisionName
    {
        get => new TerraformReference<string>(this, "latest_revision_name");
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The outbound_ip_addresses attribute.
    /// </summary>
    public TerraformList<string> OutboundIpAddresses
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "outbound_ip_addresses").ResolveNodes(ctx));
    }

    /// <summary>
    /// Dapr block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Dapr block(s) allowed")]
    public TerraformList<AzurermContainerAppDaprBlock>? Dapr
    {
        get => GetArgument<TerraformList<AzurermContainerAppDaprBlock>>("dapr");
        set => SetArgument("dapr", value);
    }

    /// <summary>
    /// Identity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public TerraformList<AzurermContainerAppIdentityBlock>? Identity
    {
        get => GetArgument<TerraformList<AzurermContainerAppIdentityBlock>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// Ingress block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Ingress block(s) allowed")]
    public TerraformList<AzurermContainerAppIngressBlock>? Ingress
    {
        get => GetArgument<TerraformList<AzurermContainerAppIngressBlock>>("ingress");
        set => SetArgument("ingress", value);
    }

    /// <summary>
    /// Registry block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermContainerAppRegistryBlock>? Registry
    {
        get => GetArgument<TerraformList<AzurermContainerAppRegistryBlock>>("registry");
        set => SetArgument("registry", value);
    }

    /// <summary>
    /// Secret block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermContainerAppSecretBlock>? Secret
    {
        get => GetArgument<TerraformSet<AzurermContainerAppSecretBlock>>("secret");
        set => SetArgument("secret", value);
    }

    /// <summary>
    /// Template block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Template is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Template block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Template block(s) allowed")]
    public required TerraformList<AzurermContainerAppTemplateBlock> Template
    {
        get => GetRequiredArgument<TerraformList<AzurermContainerAppTemplateBlock>>("template");
        set => SetArgument("template", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermContainerAppTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermContainerAppTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
