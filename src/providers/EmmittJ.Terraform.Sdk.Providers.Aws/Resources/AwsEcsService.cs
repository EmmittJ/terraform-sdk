using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for alarms in AwsEcsService.
/// Nesting mode: list
/// </summary>
public class AwsEcsServiceAlarmsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "alarms";

    /// <summary>
    /// The alarm_names attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AlarmNames is required")]
    public required TerraformSet<string> AlarmNames
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "alarm_names").ResolveNodes(ctx));
        set => SetArgument("alarm_names", value);
    }

    /// <summary>
    /// The enable attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enable is required")]
    public required TerraformValue<bool> Enable
    {
        get => new TerraformReference<bool>(this, "enable");
        set => SetArgument("enable", value);
    }

    /// <summary>
    /// The rollback attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rollback is required")]
    public required TerraformValue<bool> Rollback
    {
        get => new TerraformReference<bool>(this, "rollback");
        set => SetArgument("rollback", value);
    }

}


/// <summary>
/// Block type for capacity_provider_strategy in AwsEcsService.
/// Nesting mode: set
/// </summary>
public class AwsEcsServiceCapacityProviderStrategyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "capacity_provider_strategy";

    /// <summary>
    /// The base attribute.
    /// </summary>
    public TerraformValue<double>? BaseAttribute
    {
        get => new TerraformReference<double>(this, "base");
        set => SetArgument("base", value);
    }

    /// <summary>
    /// The capacity_provider attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CapacityProvider is required")]
    public required TerraformValue<string> CapacityProvider
    {
        get => new TerraformReference<string>(this, "capacity_provider");
        set => SetArgument("capacity_provider", value);
    }

    /// <summary>
    /// The weight attribute.
    /// </summary>
    public TerraformValue<double>? Weight
    {
        get => new TerraformReference<double>(this, "weight");
        set => SetArgument("weight", value);
    }

}


/// <summary>
/// Block type for deployment_circuit_breaker in AwsEcsService.
/// Nesting mode: list
/// </summary>
public class AwsEcsServiceDeploymentCircuitBreakerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "deployment_circuit_breaker";

    /// <summary>
    /// The enable attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enable is required")]
    public required TerraformValue<bool> Enable
    {
        get => new TerraformReference<bool>(this, "enable");
        set => SetArgument("enable", value);
    }

    /// <summary>
    /// The rollback attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rollback is required")]
    public required TerraformValue<bool> Rollback
    {
        get => new TerraformReference<bool>(this, "rollback");
        set => SetArgument("rollback", value);
    }

}


/// <summary>
/// Block type for deployment_configuration in AwsEcsService.
/// Nesting mode: list
/// </summary>
public class AwsEcsServiceDeploymentConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "deployment_configuration";

    /// <summary>
    /// The bake_time_in_minutes attribute.
    /// </summary>
    public TerraformValue<string> BakeTimeInMinutes
    {
        get => new TerraformReference<string>(this, "bake_time_in_minutes");
        set => SetArgument("bake_time_in_minutes", value);
    }

    /// <summary>
    /// The strategy attribute.
    /// </summary>
    public TerraformValue<string> Strategy
    {
        get => new TerraformReference<string>(this, "strategy");
        set => SetArgument("strategy", value);
    }

    /// <summary>
    /// LifecycleHook block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsEcsServiceDeploymentConfigurationBlockLifecycleHookBlock>? LifecycleHook
    {
        get => GetArgument<TerraformSet<AwsEcsServiceDeploymentConfigurationBlockLifecycleHookBlock>>("lifecycle_hook");
        set => SetArgument("lifecycle_hook", value);
    }

}

/// <summary>
/// Block type for lifecycle_hook in AwsEcsServiceDeploymentConfigurationBlock.
/// Nesting mode: set
/// </summary>
public class AwsEcsServiceDeploymentConfigurationBlockLifecycleHookBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "lifecycle_hook";

    /// <summary>
    /// The hook_details attribute.
    /// </summary>
    public TerraformValue<string>? HookDetails
    {
        get => new TerraformReference<string>(this, "hook_details");
        set => SetArgument("hook_details", value);
    }

    /// <summary>
    /// The hook_target_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HookTargetArn is required")]
    public required TerraformValue<string> HookTargetArn
    {
        get => new TerraformReference<string>(this, "hook_target_arn");
        set => SetArgument("hook_target_arn", value);
    }

    /// <summary>
    /// The lifecycle_stages attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LifecycleStages is required")]
    public TerraformList<string>? LifecycleStages
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "lifecycle_stages").ResolveNodes(ctx));
        set => SetArgument("lifecycle_stages", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformValue<string> RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
        set => SetArgument("role_arn", value);
    }

}


/// <summary>
/// Block type for deployment_controller in AwsEcsService.
/// Nesting mode: list
/// </summary>
public class AwsEcsServiceDeploymentControllerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "deployment_controller";

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for load_balancer in AwsEcsService.
/// Nesting mode: set
/// </summary>
public class AwsEcsServiceLoadBalancerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "load_balancer";

    /// <summary>
    /// The container_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerName is required")]
    public required TerraformValue<string> ContainerName
    {
        get => new TerraformReference<string>(this, "container_name");
        set => SetArgument("container_name", value);
    }

    /// <summary>
    /// The container_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerPort is required")]
    public required TerraformValue<double> ContainerPort
    {
        get => new TerraformReference<double>(this, "container_port");
        set => SetArgument("container_port", value);
    }

    /// <summary>
    /// The elb_name attribute.
    /// </summary>
    public TerraformValue<string>? ElbName
    {
        get => new TerraformReference<string>(this, "elb_name");
        set => SetArgument("elb_name", value);
    }

    /// <summary>
    /// The target_group_arn attribute.
    /// </summary>
    public TerraformValue<string>? TargetGroupArn
    {
        get => new TerraformReference<string>(this, "target_group_arn");
        set => SetArgument("target_group_arn", value);
    }

    /// <summary>
    /// AdvancedConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdvancedConfiguration block(s) allowed")]
    public TerraformList<AwsEcsServiceLoadBalancerBlockAdvancedConfigurationBlock>? AdvancedConfiguration
    {
        get => GetArgument<TerraformList<AwsEcsServiceLoadBalancerBlockAdvancedConfigurationBlock>>("advanced_configuration");
        set => SetArgument("advanced_configuration", value);
    }

}

/// <summary>
/// Block type for advanced_configuration in AwsEcsServiceLoadBalancerBlock.
/// Nesting mode: list
/// </summary>
public class AwsEcsServiceLoadBalancerBlockAdvancedConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "advanced_configuration";

    /// <summary>
    /// The alternate_target_group_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AlternateTargetGroupArn is required")]
    public required TerraformValue<string> AlternateTargetGroupArn
    {
        get => new TerraformReference<string>(this, "alternate_target_group_arn");
        set => SetArgument("alternate_target_group_arn", value);
    }

    /// <summary>
    /// The production_listener_rule attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProductionListenerRule is required")]
    public required TerraformValue<string> ProductionListenerRule
    {
        get => new TerraformReference<string>(this, "production_listener_rule");
        set => SetArgument("production_listener_rule", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformValue<string> RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// The test_listener_rule attribute.
    /// </summary>
    public TerraformValue<string>? TestListenerRule
    {
        get => new TerraformReference<string>(this, "test_listener_rule");
        set => SetArgument("test_listener_rule", value);
    }

}


/// <summary>
/// Block type for network_configuration in AwsEcsService.
/// Nesting mode: list
/// </summary>
public class AwsEcsServiceNetworkConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_configuration";

    /// <summary>
    /// The assign_public_ip attribute.
    /// </summary>
    public TerraformValue<bool>? AssignPublicIp
    {
        get => new TerraformReference<bool>(this, "assign_public_ip");
        set => SetArgument("assign_public_ip", value);
    }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    public TerraformSet<string>? SecurityGroups
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "security_groups").ResolveNodes(ctx));
        set => SetArgument("security_groups", value);
    }

    /// <summary>
    /// The subnets attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Subnets is required")]
    public required TerraformSet<string> Subnets
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "subnets").ResolveNodes(ctx));
        set => SetArgument("subnets", value);
    }

}


/// <summary>
/// Block type for ordered_placement_strategy in AwsEcsService.
/// Nesting mode: list
/// </summary>
public class AwsEcsServiceOrderedPlacementStrategyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ordered_placement_strategy";

    /// <summary>
    /// The field attribute.
    /// </summary>
    public TerraformValue<string>? Field
    {
        get => new TerraformReference<string>(this, "field");
        set => SetArgument("field", value);
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
/// Block type for placement_constraints in AwsEcsService.
/// Nesting mode: set
/// </summary>
public class AwsEcsServicePlacementConstraintsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "placement_constraints";

    /// <summary>
    /// The expression attribute.
    /// </summary>
    public TerraformValue<string>? Expression
    {
        get => new TerraformReference<string>(this, "expression");
        set => SetArgument("expression", value);
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
/// Block type for service_connect_configuration in AwsEcsService.
/// Nesting mode: list
/// </summary>
public class AwsEcsServiceServiceConnectConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "service_connect_configuration";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    public TerraformValue<string> NamespaceAttribute
    {
        get => new TerraformReference<string>(this, "namespace");
        set => SetArgument("namespace", value);
    }

    /// <summary>
    /// LogConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LogConfiguration block(s) allowed")]
    public TerraformList<AwsEcsServiceServiceConnectConfigurationBlockLogConfigurationBlock>? LogConfiguration
    {
        get => GetArgument<TerraformList<AwsEcsServiceServiceConnectConfigurationBlockLogConfigurationBlock>>("log_configuration");
        set => SetArgument("log_configuration", value);
    }

    /// <summary>
    /// Service block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsEcsServiceServiceConnectConfigurationBlockServiceBlock>? Service
    {
        get => GetArgument<TerraformList<AwsEcsServiceServiceConnectConfigurationBlockServiceBlock>>("service");
        set => SetArgument("service", value);
    }

}

/// <summary>
/// Block type for log_configuration in AwsEcsServiceServiceConnectConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsEcsServiceServiceConnectConfigurationBlockLogConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "log_configuration";

    /// <summary>
    /// The log_driver attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogDriver is required")]
    public required TerraformValue<string> LogDriver
    {
        get => new TerraformReference<string>(this, "log_driver");
        set => SetArgument("log_driver", value);
    }

    /// <summary>
    /// The options attribute.
    /// </summary>
    public TerraformMap<string> Options
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "options").ResolveNodes(ctx));
        set => SetArgument("options", value);
    }

    /// <summary>
    /// SecretOption block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsEcsServiceServiceConnectConfigurationBlockLogConfigurationBlockSecretOptionBlock>? SecretOption
    {
        get => GetArgument<TerraformList<AwsEcsServiceServiceConnectConfigurationBlockLogConfigurationBlockSecretOptionBlock>>("secret_option");
        set => SetArgument("secret_option", value);
    }

}

/// <summary>
/// Block type for secret_option in AwsEcsServiceServiceConnectConfigurationBlockLogConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsEcsServiceServiceConnectConfigurationBlockLogConfigurationBlockSecretOptionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "secret_option";

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
    /// The value_from attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValueFrom is required")]
    public required TerraformValue<string> ValueFrom
    {
        get => new TerraformReference<string>(this, "value_from");
        set => SetArgument("value_from", value);
    }

}

/// <summary>
/// Block type for service in AwsEcsServiceServiceConnectConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsEcsServiceServiceConnectConfigurationBlockServiceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "service";

    /// <summary>
    /// The discovery_name attribute.
    /// </summary>
    public TerraformValue<string> DiscoveryName
    {
        get => new TerraformReference<string>(this, "discovery_name");
        set => SetArgument("discovery_name", value);
    }

    /// <summary>
    /// The ingress_port_override attribute.
    /// </summary>
    public TerraformValue<double>? IngressPortOverride
    {
        get => new TerraformReference<double>(this, "ingress_port_override");
        set => SetArgument("ingress_port_override", value);
    }

    /// <summary>
    /// The port_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PortName is required")]
    public required TerraformValue<string> PortName
    {
        get => new TerraformReference<string>(this, "port_name");
        set => SetArgument("port_name", value);
    }

    /// <summary>
    /// ClientAlias block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClientAlias block(s) allowed")]
    public TerraformList<AwsEcsServiceServiceConnectConfigurationBlockServiceBlockClientAliasBlock>? ClientAlias
    {
        get => GetArgument<TerraformList<AwsEcsServiceServiceConnectConfigurationBlockServiceBlockClientAliasBlock>>("client_alias");
        set => SetArgument("client_alias", value);
    }

    /// <summary>
    /// Timeout block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Timeout block(s) allowed")]
    public TerraformList<AwsEcsServiceServiceConnectConfigurationBlockServiceBlockTimeoutBlock>? Timeout
    {
        get => GetArgument<TerraformList<AwsEcsServiceServiceConnectConfigurationBlockServiceBlockTimeoutBlock>>("timeout");
        set => SetArgument("timeout", value);
    }

    /// <summary>
    /// Tls block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Tls block(s) allowed")]
    public TerraformList<AwsEcsServiceServiceConnectConfigurationBlockServiceBlockTlsBlock>? Tls
    {
        get => GetArgument<TerraformList<AwsEcsServiceServiceConnectConfigurationBlockServiceBlockTlsBlock>>("tls");
        set => SetArgument("tls", value);
    }

}

/// <summary>
/// Block type for client_alias in AwsEcsServiceServiceConnectConfigurationBlockServiceBlock.
/// Nesting mode: list
/// </summary>
public class AwsEcsServiceServiceConnectConfigurationBlockServiceBlockClientAliasBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "client_alias";

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    public TerraformValue<string> DnsName
    {
        get => new TerraformReference<string>(this, "dns_name");
        set => SetArgument("dns_name", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    public required TerraformValue<double> Port
    {
        get => new TerraformReference<double>(this, "port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// TestTrafficRules block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsEcsServiceServiceConnectConfigurationBlockServiceBlockClientAliasBlockTestTrafficRulesBlock>? TestTrafficRules
    {
        get => GetArgument<TerraformList<AwsEcsServiceServiceConnectConfigurationBlockServiceBlockClientAliasBlockTestTrafficRulesBlock>>("test_traffic_rules");
        set => SetArgument("test_traffic_rules", value);
    }

}

/// <summary>
/// Block type for test_traffic_rules in AwsEcsServiceServiceConnectConfigurationBlockServiceBlockClientAliasBlock.
/// Nesting mode: list
/// </summary>
public class AwsEcsServiceServiceConnectConfigurationBlockServiceBlockClientAliasBlockTestTrafficRulesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "test_traffic_rules";

    /// <summary>
    /// Header block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Header block(s) allowed")]
    public TerraformList<AwsEcsServiceServiceConnectConfigurationBlockServiceBlockClientAliasBlockTestTrafficRulesBlockHeaderBlock>? Header
    {
        get => GetArgument<TerraformList<AwsEcsServiceServiceConnectConfigurationBlockServiceBlockClientAliasBlockTestTrafficRulesBlockHeaderBlock>>("header");
        set => SetArgument("header", value);
    }

}

/// <summary>
/// Block type for header in AwsEcsServiceServiceConnectConfigurationBlockServiceBlockClientAliasBlockTestTrafficRulesBlock.
/// Nesting mode: list
/// </summary>
public class AwsEcsServiceServiceConnectConfigurationBlockServiceBlockClientAliasBlockTestTrafficRulesBlockHeaderBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "header";

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
    /// Value block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Value block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Value block(s) allowed")]
    public required TerraformList<AwsEcsServiceServiceConnectConfigurationBlockServiceBlockClientAliasBlockTestTrafficRulesBlockHeaderBlockValueBlock> Value
    {
        get => GetRequiredArgument<TerraformList<AwsEcsServiceServiceConnectConfigurationBlockServiceBlockClientAliasBlockTestTrafficRulesBlockHeaderBlockValueBlock>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for value in AwsEcsServiceServiceConnectConfigurationBlockServiceBlockClientAliasBlockTestTrafficRulesBlockHeaderBlock.
/// Nesting mode: list
/// </summary>
public class AwsEcsServiceServiceConnectConfigurationBlockServiceBlockClientAliasBlockTestTrafficRulesBlockHeaderBlockValueBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "value";

    /// <summary>
    /// The exact attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Exact is required")]
    public required TerraformValue<string> Exact
    {
        get => new TerraformReference<string>(this, "exact");
        set => SetArgument("exact", value);
    }

}

/// <summary>
/// Block type for timeout in AwsEcsServiceServiceConnectConfigurationBlockServiceBlock.
/// Nesting mode: list
/// </summary>
public class AwsEcsServiceServiceConnectConfigurationBlockServiceBlockTimeoutBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeout";

    /// <summary>
    /// The idle_timeout_seconds attribute.
    /// </summary>
    public TerraformValue<double>? IdleTimeoutSeconds
    {
        get => new TerraformReference<double>(this, "idle_timeout_seconds");
        set => SetArgument("idle_timeout_seconds", value);
    }

    /// <summary>
    /// The per_request_timeout_seconds attribute.
    /// </summary>
    public TerraformValue<double>? PerRequestTimeoutSeconds
    {
        get => new TerraformReference<double>(this, "per_request_timeout_seconds");
        set => SetArgument("per_request_timeout_seconds", value);
    }

}

/// <summary>
/// Block type for tls in AwsEcsServiceServiceConnectConfigurationBlockServiceBlock.
/// Nesting mode: list
/// </summary>
public class AwsEcsServiceServiceConnectConfigurationBlockServiceBlockTlsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tls";

    /// <summary>
    /// The kms_key attribute.
    /// </summary>
    public TerraformValue<string>? KmsKey
    {
        get => new TerraformReference<string>(this, "kms_key");
        set => SetArgument("kms_key", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformValue<string>? RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// IssuerCertAuthority block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IssuerCertAuthority is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 IssuerCertAuthority block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IssuerCertAuthority block(s) allowed")]
    public required TerraformList<AwsEcsServiceServiceConnectConfigurationBlockServiceBlockTlsBlockIssuerCertAuthorityBlock> IssuerCertAuthority
    {
        get => GetRequiredArgument<TerraformList<AwsEcsServiceServiceConnectConfigurationBlockServiceBlockTlsBlockIssuerCertAuthorityBlock>>("issuer_cert_authority");
        set => SetArgument("issuer_cert_authority", value);
    }

}

/// <summary>
/// Block type for issuer_cert_authority in AwsEcsServiceServiceConnectConfigurationBlockServiceBlockTlsBlock.
/// Nesting mode: list
/// </summary>
public class AwsEcsServiceServiceConnectConfigurationBlockServiceBlockTlsBlockIssuerCertAuthorityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "issuer_cert_authority";

    /// <summary>
    /// The aws_pca_authority_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AwsPcaAuthorityArn is required")]
    public required TerraformValue<string> AwsPcaAuthorityArn
    {
        get => new TerraformReference<string>(this, "aws_pca_authority_arn");
        set => SetArgument("aws_pca_authority_arn", value);
    }

}


/// <summary>
/// Block type for service_registries in AwsEcsService.
/// Nesting mode: list
/// </summary>
public class AwsEcsServiceServiceRegistriesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "service_registries";

    /// <summary>
    /// The container_name attribute.
    /// </summary>
    public TerraformValue<string>? ContainerName
    {
        get => new TerraformReference<string>(this, "container_name");
        set => SetArgument("container_name", value);
    }

    /// <summary>
    /// The container_port attribute.
    /// </summary>
    public TerraformValue<double>? ContainerPort
    {
        get => new TerraformReference<double>(this, "container_port");
        set => SetArgument("container_port", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double>? Port
    {
        get => new TerraformReference<double>(this, "port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The registry_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RegistryArn is required")]
    public required TerraformValue<string> RegistryArn
    {
        get => new TerraformReference<string>(this, "registry_arn");
        set => SetArgument("registry_arn", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsEcsService.
/// Nesting mode: single
/// </summary>
public class AwsEcsServiceTimeoutsBlock : TerraformBlock
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
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Block type for volume_configuration in AwsEcsService.
/// Nesting mode: list
/// </summary>
public class AwsEcsServiceVolumeConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "volume_configuration";

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
    /// ManagedEbsVolume block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedEbsVolume is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ManagedEbsVolume block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManagedEbsVolume block(s) allowed")]
    public required TerraformList<AwsEcsServiceVolumeConfigurationBlockManagedEbsVolumeBlock> ManagedEbsVolume
    {
        get => GetRequiredArgument<TerraformList<AwsEcsServiceVolumeConfigurationBlockManagedEbsVolumeBlock>>("managed_ebs_volume");
        set => SetArgument("managed_ebs_volume", value);
    }

}

/// <summary>
/// Block type for managed_ebs_volume in AwsEcsServiceVolumeConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsEcsServiceVolumeConfigurationBlockManagedEbsVolumeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "managed_ebs_volume";

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    public TerraformValue<bool>? Encrypted
    {
        get => new TerraformReference<bool>(this, "encrypted");
        set => SetArgument("encrypted", value);
    }

    /// <summary>
    /// The file_system_type attribute.
    /// </summary>
    public TerraformValue<string>? FileSystemType
    {
        get => new TerraformReference<string>(this, "file_system_type");
        set => SetArgument("file_system_type", value);
    }

    /// <summary>
    /// The iops attribute.
    /// </summary>
    public TerraformValue<double>? Iops
    {
        get => new TerraformReference<double>(this, "iops");
        set => SetArgument("iops", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyId
    {
        get => new TerraformReference<string>(this, "kms_key_id");
        set => SetArgument("kms_key_id", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformValue<string> RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// The size_in_gb attribute.
    /// </summary>
    public TerraformValue<double>? SizeInGb
    {
        get => new TerraformReference<double>(this, "size_in_gb");
        set => SetArgument("size_in_gb", value);
    }

    /// <summary>
    /// The snapshot_id attribute.
    /// </summary>
    public TerraformValue<string>? SnapshotId
    {
        get => new TerraformReference<string>(this, "snapshot_id");
        set => SetArgument("snapshot_id", value);
    }

    /// <summary>
    /// The throughput attribute.
    /// </summary>
    public TerraformValue<double>? Throughput
    {
        get => new TerraformReference<double>(this, "throughput");
        set => SetArgument("throughput", value);
    }

    /// <summary>
    /// The volume_initialization_rate attribute.
    /// </summary>
    public TerraformValue<double>? VolumeInitializationRate
    {
        get => new TerraformReference<double>(this, "volume_initialization_rate");
        set => SetArgument("volume_initialization_rate", value);
    }

    /// <summary>
    /// The volume_type attribute.
    /// </summary>
    public TerraformValue<string>? VolumeType
    {
        get => new TerraformReference<string>(this, "volume_type");
        set => SetArgument("volume_type", value);
    }

    /// <summary>
    /// TagSpecifications block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsEcsServiceVolumeConfigurationBlockManagedEbsVolumeBlockTagSpecificationsBlock>? TagSpecifications
    {
        get => GetArgument<TerraformList<AwsEcsServiceVolumeConfigurationBlockManagedEbsVolumeBlockTagSpecificationsBlock>>("tag_specifications");
        set => SetArgument("tag_specifications", value);
    }

}

/// <summary>
/// Block type for tag_specifications in AwsEcsServiceVolumeConfigurationBlockManagedEbsVolumeBlock.
/// Nesting mode: list
/// </summary>
public class AwsEcsServiceVolumeConfigurationBlockManagedEbsVolumeBlockTagSpecificationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tag_specifications";

    /// <summary>
    /// The propagate_tags attribute.
    /// </summary>
    public TerraformValue<string>? PropagateTags
    {
        get => new TerraformReference<string>(this, "propagate_tags");
        set => SetArgument("propagate_tags", value);
    }

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceTypeAttribute is required")]
    public required TerraformValue<string> ResourceTypeAttribute
    {
        get => new TerraformReference<string>(this, "resource_type");
        set => SetArgument("resource_type", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

}


/// <summary>
/// Block type for vpc_lattice_configurations in AwsEcsService.
/// Nesting mode: set
/// </summary>
public class AwsEcsServiceVpcLatticeConfigurationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "vpc_lattice_configurations";

    /// <summary>
    /// The port_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PortName is required")]
    public required TerraformValue<string> PortName
    {
        get => new TerraformReference<string>(this, "port_name");
        set => SetArgument("port_name", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformValue<string> RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// The target_group_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetGroupArn is required")]
    public required TerraformValue<string> TargetGroupArn
    {
        get => new TerraformReference<string>(this, "target_group_arn");
        set => SetArgument("target_group_arn", value);
    }

}


/// <summary>
/// Represents a aws_ecs_service Terraform resource.
/// Manages a aws_ecs_service resource.
/// </summary>
public partial class AwsEcsService(string name) : TerraformResource("aws_ecs_service", name)
{
    /// <summary>
    /// The availability_zone_rebalancing attribute.
    /// </summary>
    public TerraformValue<string> AvailabilityZoneRebalancing
    {
        get => new TerraformReference<string>(this, "availability_zone_rebalancing");
        set => SetArgument("availability_zone_rebalancing", value);
    }

    /// <summary>
    /// The cluster attribute.
    /// </summary>
    public TerraformValue<string> Cluster
    {
        get => new TerraformReference<string>(this, "cluster");
        set => SetArgument("cluster", value);
    }

    /// <summary>
    /// The deployment_maximum_percent attribute.
    /// </summary>
    public TerraformValue<double>? DeploymentMaximumPercent
    {
        get => new TerraformReference<double>(this, "deployment_maximum_percent");
        set => SetArgument("deployment_maximum_percent", value);
    }

    /// <summary>
    /// The deployment_minimum_healthy_percent attribute.
    /// </summary>
    public TerraformValue<double>? DeploymentMinimumHealthyPercent
    {
        get => new TerraformReference<double>(this, "deployment_minimum_healthy_percent");
        set => SetArgument("deployment_minimum_healthy_percent", value);
    }

    /// <summary>
    /// The desired_count attribute.
    /// </summary>
    public TerraformValue<double>? DesiredCount
    {
        get => new TerraformReference<double>(this, "desired_count");
        set => SetArgument("desired_count", value);
    }

    /// <summary>
    /// The enable_ecs_managed_tags attribute.
    /// </summary>
    public TerraformValue<bool>? EnableEcsManagedTags
    {
        get => new TerraformReference<bool>(this, "enable_ecs_managed_tags");
        set => SetArgument("enable_ecs_managed_tags", value);
    }

    /// <summary>
    /// The enable_execute_command attribute.
    /// </summary>
    public TerraformValue<bool>? EnableExecuteCommand
    {
        get => new TerraformReference<bool>(this, "enable_execute_command");
        set => SetArgument("enable_execute_command", value);
    }

    /// <summary>
    /// The force_delete attribute.
    /// </summary>
    public TerraformValue<bool>? ForceDelete
    {
        get => new TerraformReference<bool>(this, "force_delete");
        set => SetArgument("force_delete", value);
    }

    /// <summary>
    /// The force_new_deployment attribute.
    /// </summary>
    public TerraformValue<bool>? ForceNewDeployment
    {
        get => new TerraformReference<bool>(this, "force_new_deployment");
        set => SetArgument("force_new_deployment", value);
    }

    /// <summary>
    /// The health_check_grace_period_seconds attribute.
    /// </summary>
    public TerraformValue<double>? HealthCheckGracePeriodSeconds
    {
        get => new TerraformReference<double>(this, "health_check_grace_period_seconds");
        set => SetArgument("health_check_grace_period_seconds", value);
    }

    /// <summary>
    /// The iam_role attribute.
    /// </summary>
    public TerraformValue<string> IamRole
    {
        get => new TerraformReference<string>(this, "iam_role");
        set => SetArgument("iam_role", value);
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
    /// The launch_type attribute.
    /// </summary>
    public TerraformValue<string> LaunchType
    {
        get => new TerraformReference<string>(this, "launch_type");
        set => SetArgument("launch_type", value);
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
    /// The platform_version attribute.
    /// </summary>
    public TerraformValue<string> PlatformVersion
    {
        get => new TerraformReference<string>(this, "platform_version");
        set => SetArgument("platform_version", value);
    }

    /// <summary>
    /// The propagate_tags attribute.
    /// </summary>
    public TerraformValue<string>? PropagateTags
    {
        get => new TerraformReference<string>(this, "propagate_tags");
        set => SetArgument("propagate_tags", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The scheduling_strategy attribute.
    /// </summary>
    public TerraformValue<string>? SchedulingStrategy
    {
        get => new TerraformReference<string>(this, "scheduling_strategy");
        set => SetArgument("scheduling_strategy", value);
    }

    /// <summary>
    /// The sigint_rollback attribute.
    /// </summary>
    public TerraformValue<bool>? SigintRollback
    {
        get => new TerraformReference<bool>(this, "sigint_rollback");
        set => SetArgument("sigint_rollback", value);
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
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The task_definition attribute.
    /// </summary>
    public TerraformValue<string>? TaskDefinition
    {
        get => new TerraformReference<string>(this, "task_definition");
        set => SetArgument("task_definition", value);
    }

    /// <summary>
    /// The triggers attribute.
    /// </summary>
    public TerraformMap<string> Triggers
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "triggers").ResolveNodes(ctx));
        set => SetArgument("triggers", value);
    }

    /// <summary>
    /// The wait_for_steady_state attribute.
    /// </summary>
    public TerraformValue<bool>? WaitForSteadyState
    {
        get => new TerraformReference<bool>(this, "wait_for_steady_state");
        set => SetArgument("wait_for_steady_state", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// Alarms block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Alarms block(s) allowed")]
    public TerraformList<AwsEcsServiceAlarmsBlock>? Alarms
    {
        get => GetArgument<TerraformList<AwsEcsServiceAlarmsBlock>>("alarms");
        set => SetArgument("alarms", value);
    }

    /// <summary>
    /// CapacityProviderStrategy block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsEcsServiceCapacityProviderStrategyBlock>? CapacityProviderStrategy
    {
        get => GetArgument<TerraformSet<AwsEcsServiceCapacityProviderStrategyBlock>>("capacity_provider_strategy");
        set => SetArgument("capacity_provider_strategy", value);
    }

    /// <summary>
    /// DeploymentCircuitBreaker block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeploymentCircuitBreaker block(s) allowed")]
    public TerraformList<AwsEcsServiceDeploymentCircuitBreakerBlock>? DeploymentCircuitBreaker
    {
        get => GetArgument<TerraformList<AwsEcsServiceDeploymentCircuitBreakerBlock>>("deployment_circuit_breaker");
        set => SetArgument("deployment_circuit_breaker", value);
    }

    /// <summary>
    /// DeploymentConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeploymentConfiguration block(s) allowed")]
    public TerraformList<AwsEcsServiceDeploymentConfigurationBlock>? DeploymentConfiguration
    {
        get => GetArgument<TerraformList<AwsEcsServiceDeploymentConfigurationBlock>>("deployment_configuration");
        set => SetArgument("deployment_configuration", value);
    }

    /// <summary>
    /// DeploymentController block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeploymentController block(s) allowed")]
    public TerraformList<AwsEcsServiceDeploymentControllerBlock>? DeploymentController
    {
        get => GetArgument<TerraformList<AwsEcsServiceDeploymentControllerBlock>>("deployment_controller");
        set => SetArgument("deployment_controller", value);
    }

    /// <summary>
    /// LoadBalancer block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsEcsServiceLoadBalancerBlock>? LoadBalancer
    {
        get => GetArgument<TerraformSet<AwsEcsServiceLoadBalancerBlock>>("load_balancer");
        set => SetArgument("load_balancer", value);
    }

    /// <summary>
    /// NetworkConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfiguration block(s) allowed")]
    public TerraformList<AwsEcsServiceNetworkConfigurationBlock>? NetworkConfiguration
    {
        get => GetArgument<TerraformList<AwsEcsServiceNetworkConfigurationBlock>>("network_configuration");
        set => SetArgument("network_configuration", value);
    }

    /// <summary>
    /// OrderedPlacementStrategy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 OrderedPlacementStrategy block(s) allowed")]
    public TerraformList<AwsEcsServiceOrderedPlacementStrategyBlock>? OrderedPlacementStrategy
    {
        get => GetArgument<TerraformList<AwsEcsServiceOrderedPlacementStrategyBlock>>("ordered_placement_strategy");
        set => SetArgument("ordered_placement_strategy", value);
    }

    /// <summary>
    /// PlacementConstraints block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 PlacementConstraints block(s) allowed")]
    public TerraformSet<AwsEcsServicePlacementConstraintsBlock>? PlacementConstraints
    {
        get => GetArgument<TerraformSet<AwsEcsServicePlacementConstraintsBlock>>("placement_constraints");
        set => SetArgument("placement_constraints", value);
    }

    /// <summary>
    /// ServiceConnectConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceConnectConfiguration block(s) allowed")]
    public TerraformList<AwsEcsServiceServiceConnectConfigurationBlock>? ServiceConnectConfiguration
    {
        get => GetArgument<TerraformList<AwsEcsServiceServiceConnectConfigurationBlock>>("service_connect_configuration");
        set => SetArgument("service_connect_configuration", value);
    }

    /// <summary>
    /// ServiceRegistries block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceRegistries block(s) allowed")]
    public TerraformList<AwsEcsServiceServiceRegistriesBlock>? ServiceRegistries
    {
        get => GetArgument<TerraformList<AwsEcsServiceServiceRegistriesBlock>>("service_registries");
        set => SetArgument("service_registries", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsEcsServiceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsEcsServiceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// VolumeConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VolumeConfiguration block(s) allowed")]
    public TerraformList<AwsEcsServiceVolumeConfigurationBlock>? VolumeConfiguration
    {
        get => GetArgument<TerraformList<AwsEcsServiceVolumeConfigurationBlock>>("volume_configuration");
        set => SetArgument("volume_configuration", value);
    }

    /// <summary>
    /// VpcLatticeConfigurations block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsEcsServiceVpcLatticeConfigurationsBlock>? VpcLatticeConfigurations
    {
        get => GetArgument<TerraformSet<AwsEcsServiceVpcLatticeConfigurationsBlock>>("vpc_lattice_configurations");
        set => SetArgument("vpc_lattice_configurations", value);
    }

}
