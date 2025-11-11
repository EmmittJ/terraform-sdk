using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for alarms in .
/// Nesting mode: list
/// </summary>
public class AwsEcsServiceAlarmsBlock
{
    /// <summary>
    /// The alarm_names attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AlarmNames is required")]
    [TerraformPropertyName("alarm_names")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> AlarmNames { get; set; }

    /// <summary>
    /// The enable attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enable is required")]
    [TerraformPropertyName("enable")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> Enable { get; set; }

    /// <summary>
    /// The rollback attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rollback is required")]
    [TerraformPropertyName("rollback")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> Rollback { get; set; }

}

/// <summary>
/// Block type for capacity_provider_strategy in .
/// Nesting mode: set
/// </summary>
public class AwsEcsServiceCapacityProviderStrategyBlock
{
    /// <summary>
    /// The base attribute.
    /// </summary>
    [TerraformPropertyName("base")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? Base { get; set; }

    /// <summary>
    /// The capacity_provider attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CapacityProvider is required")]
    [TerraformPropertyName("capacity_provider")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> CapacityProvider { get; set; }

    /// <summary>
    /// The weight attribute.
    /// </summary>
    [TerraformPropertyName("weight")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? Weight { get; set; }

}

/// <summary>
/// Block type for deployment_circuit_breaker in .
/// Nesting mode: list
/// </summary>
public class AwsEcsServiceDeploymentCircuitBreakerBlock
{
    /// <summary>
    /// The enable attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enable is required")]
    [TerraformPropertyName("enable")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> Enable { get; set; }

    /// <summary>
    /// The rollback attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rollback is required")]
    [TerraformPropertyName("rollback")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> Rollback { get; set; }

}

/// <summary>
/// Block type for deployment_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsEcsServiceDeploymentConfigurationBlock
{
    /// <summary>
    /// The bake_time_in_minutes attribute.
    /// </summary>
    [TerraformPropertyName("bake_time_in_minutes")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> BakeTimeInMinutes { get; set; } = default!;

    /// <summary>
    /// The strategy attribute.
    /// </summary>
    [TerraformPropertyName("strategy")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Strategy { get; set; } = default!;

}

/// <summary>
/// Block type for deployment_controller in .
/// Nesting mode: list
/// </summary>
public class AwsEcsServiceDeploymentControllerBlock
{
    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Type { get; set; }

}

/// <summary>
/// Block type for load_balancer in .
/// Nesting mode: set
/// </summary>
public class AwsEcsServiceLoadBalancerBlock
{
    /// <summary>
    /// The container_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerName is required")]
    [TerraformPropertyName("container_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ContainerName { get; set; }

    /// <summary>
    /// The container_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerPort is required")]
    [TerraformPropertyName("container_port")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> ContainerPort { get; set; }

    /// <summary>
    /// The elb_name attribute.
    /// </summary>
    [TerraformPropertyName("elb_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ElbName { get; set; }

    /// <summary>
    /// The target_group_arn attribute.
    /// </summary>
    [TerraformPropertyName("target_group_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TargetGroupArn { get; set; }

}

/// <summary>
/// Block type for network_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsEcsServiceNetworkConfigurationBlock
{
    /// <summary>
    /// The assign_public_ip attribute.
    /// </summary>
    [TerraformPropertyName("assign_public_ip")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AssignPublicIp { get; set; }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    [TerraformPropertyName("security_groups")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? SecurityGroups { get; set; }

    /// <summary>
    /// The subnets attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Subnets is required")]
    [TerraformPropertyName("subnets")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> Subnets { get; set; }

}

/// <summary>
/// Block type for ordered_placement_strategy in .
/// Nesting mode: list
/// </summary>
public class AwsEcsServiceOrderedPlacementStrategyBlock
{
    /// <summary>
    /// The field attribute.
    /// </summary>
    [TerraformPropertyName("field")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Field { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for placement_constraints in .
/// Nesting mode: set
/// </summary>
public class AwsEcsServicePlacementConstraintsBlock
{
    /// <summary>
    /// The expression attribute.
    /// </summary>
    [TerraformPropertyName("expression")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Expression { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for service_connect_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsEcsServiceServiceConnectConfigurationBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformPropertyName("enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> Enabled { get; set; }

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    [TerraformPropertyName("namespace")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Namespace { get; set; } = default!;

}

/// <summary>
/// Block type for service_registries in .
/// Nesting mode: list
/// </summary>
public class AwsEcsServiceServiceRegistriesBlock
{
    /// <summary>
    /// The container_name attribute.
    /// </summary>
    [TerraformPropertyName("container_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ContainerName { get; set; }

    /// <summary>
    /// The container_port attribute.
    /// </summary>
    [TerraformPropertyName("container_port")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? ContainerPort { get; set; }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformPropertyName("port")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? Port { get; set; }

    /// <summary>
    /// The registry_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RegistryArn is required")]
    [TerraformPropertyName("registry_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RegistryArn { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsEcsServiceTimeoutsBlock
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
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for volume_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsEcsServiceVolumeConfigurationBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

}

/// <summary>
/// Block type for vpc_lattice_configurations in .
/// Nesting mode: set
/// </summary>
public class AwsEcsServiceVpcLatticeConfigurationsBlock
{
    /// <summary>
    /// The port_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PortName is required")]
    [TerraformPropertyName("port_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> PortName { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformPropertyName("role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RoleArn { get; set; }

    /// <summary>
    /// The target_group_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetGroupArn is required")]
    [TerraformPropertyName("target_group_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> TargetGroupArn { get; set; }

}

/// <summary>
/// Manages a aws_ecs_service resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsEcsService : TerraformResource
{
    public AwsEcsService(string name) : base("aws_ecs_service", name)
    {
    }

    /// <summary>
    /// The availability_zone_rebalancing attribute.
    /// </summary>
    [TerraformPropertyName("availability_zone_rebalancing")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> AvailabilityZoneRebalancing { get; set; } = default!;

    /// <summary>
    /// The cluster attribute.
    /// </summary>
    [TerraformPropertyName("cluster")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Cluster { get; set; } = default!;

    /// <summary>
    /// The deployment_maximum_percent attribute.
    /// </summary>
    [TerraformPropertyName("deployment_maximum_percent")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? DeploymentMaximumPercent { get; set; }

    /// <summary>
    /// The deployment_minimum_healthy_percent attribute.
    /// </summary>
    [TerraformPropertyName("deployment_minimum_healthy_percent")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? DeploymentMinimumHealthyPercent { get; set; }

    /// <summary>
    /// The desired_count attribute.
    /// </summary>
    [TerraformPropertyName("desired_count")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? DesiredCount { get; set; }

    /// <summary>
    /// The enable_ecs_managed_tags attribute.
    /// </summary>
    [TerraformPropertyName("enable_ecs_managed_tags")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnableEcsManagedTags { get; set; }

    /// <summary>
    /// The enable_execute_command attribute.
    /// </summary>
    [TerraformPropertyName("enable_execute_command")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnableExecuteCommand { get; set; }

    /// <summary>
    /// The force_delete attribute.
    /// </summary>
    [TerraformPropertyName("force_delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ForceDelete { get; set; }

    /// <summary>
    /// The force_new_deployment attribute.
    /// </summary>
    [TerraformPropertyName("force_new_deployment")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ForceNewDeployment { get; set; }

    /// <summary>
    /// The health_check_grace_period_seconds attribute.
    /// </summary>
    [TerraformPropertyName("health_check_grace_period_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? HealthCheckGracePeriodSeconds { get; set; }

    /// <summary>
    /// The iam_role attribute.
    /// </summary>
    [TerraformPropertyName("iam_role")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> IamRole { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The launch_type attribute.
    /// </summary>
    [TerraformPropertyName("launch_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> LaunchType { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The platform_version attribute.
    /// </summary>
    [TerraformPropertyName("platform_version")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> PlatformVersion { get; set; } = default!;

    /// <summary>
    /// The propagate_tags attribute.
    /// </summary>
    [TerraformPropertyName("propagate_tags")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PropagateTags { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The scheduling_strategy attribute.
    /// </summary>
    [TerraformPropertyName("scheduling_strategy")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SchedulingStrategy { get; set; }

    /// <summary>
    /// The sigint_rollback attribute.
    /// </summary>
    [TerraformPropertyName("sigint_rollback")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? SigintRollback { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// The task_definition attribute.
    /// </summary>
    [TerraformPropertyName("task_definition")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TaskDefinition { get; set; }

    /// <summary>
    /// The triggers attribute.
    /// </summary>
    [TerraformPropertyName("triggers")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Triggers { get; set; } = default!;

    /// <summary>
    /// The wait_for_steady_state attribute.
    /// </summary>
    [TerraformPropertyName("wait_for_steady_state")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? WaitForSteadyState { get; set; }

    /// <summary>
    /// Block for alarms.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Alarms block(s) allowed")]
    [TerraformPropertyName("alarms")]
    public TerraformList<TerraformBlock<AwsEcsServiceAlarmsBlock>>? Alarms { get; set; }

    /// <summary>
    /// Block for capacity_provider_strategy.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("capacity_provider_strategy")]
    public TerraformSet<TerraformBlock<AwsEcsServiceCapacityProviderStrategyBlock>>? CapacityProviderStrategy { get; set; }

    /// <summary>
    /// Block for deployment_circuit_breaker.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeploymentCircuitBreaker block(s) allowed")]
    [TerraformPropertyName("deployment_circuit_breaker")]
    public TerraformList<TerraformBlock<AwsEcsServiceDeploymentCircuitBreakerBlock>>? DeploymentCircuitBreaker { get; set; }

    /// <summary>
    /// Block for deployment_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeploymentConfiguration block(s) allowed")]
    [TerraformPropertyName("deployment_configuration")]
    public TerraformList<TerraformBlock<AwsEcsServiceDeploymentConfigurationBlock>>? DeploymentConfiguration { get; set; }

    /// <summary>
    /// Block for deployment_controller.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeploymentController block(s) allowed")]
    [TerraformPropertyName("deployment_controller")]
    public TerraformList<TerraformBlock<AwsEcsServiceDeploymentControllerBlock>>? DeploymentController { get; set; }

    /// <summary>
    /// Block for load_balancer.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("load_balancer")]
    public TerraformSet<TerraformBlock<AwsEcsServiceLoadBalancerBlock>>? LoadBalancer { get; set; }

    /// <summary>
    /// Block for network_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfiguration block(s) allowed")]
    [TerraformPropertyName("network_configuration")]
    public TerraformList<TerraformBlock<AwsEcsServiceNetworkConfigurationBlock>>? NetworkConfiguration { get; set; }

    /// <summary>
    /// Block for ordered_placement_strategy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 OrderedPlacementStrategy block(s) allowed")]
    [TerraformPropertyName("ordered_placement_strategy")]
    public TerraformList<TerraformBlock<AwsEcsServiceOrderedPlacementStrategyBlock>>? OrderedPlacementStrategy { get; set; }

    /// <summary>
    /// Block for placement_constraints.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 PlacementConstraints block(s) allowed")]
    [TerraformPropertyName("placement_constraints")]
    public TerraformSet<TerraformBlock<AwsEcsServicePlacementConstraintsBlock>>? PlacementConstraints { get; set; }

    /// <summary>
    /// Block for service_connect_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceConnectConfiguration block(s) allowed")]
    [TerraformPropertyName("service_connect_configuration")]
    public TerraformList<TerraformBlock<AwsEcsServiceServiceConnectConfigurationBlock>>? ServiceConnectConfiguration { get; set; }

    /// <summary>
    /// Block for service_registries.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceRegistries block(s) allowed")]
    [TerraformPropertyName("service_registries")]
    public TerraformList<TerraformBlock<AwsEcsServiceServiceRegistriesBlock>>? ServiceRegistries { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsEcsServiceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for volume_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VolumeConfiguration block(s) allowed")]
    [TerraformPropertyName("volume_configuration")]
    public TerraformList<TerraformBlock<AwsEcsServiceVolumeConfigurationBlock>>? VolumeConfiguration { get; set; }

    /// <summary>
    /// Block for vpc_lattice_configurations.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("vpc_lattice_configurations")]
    public TerraformSet<TerraformBlock<AwsEcsServiceVpcLatticeConfigurationsBlock>>? VpcLatticeConfigurations { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

}
