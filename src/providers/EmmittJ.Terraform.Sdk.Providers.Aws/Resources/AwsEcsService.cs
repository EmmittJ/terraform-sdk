using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for alarms in .
/// Nesting mode: list
/// </summary>
public class AwsEcsServiceAlarmsBlock : ITerraformBlock
{
    /// <summary>
    /// The alarm_names attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AlarmNames is required")]
    [TerraformPropertyName("alarm_names")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? AlarmNames { get; set; }

    /// <summary>
    /// The enable attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enable is required")]
    [TerraformPropertyName("enable")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> Enable { get; set; }

    /// <summary>
    /// The rollback attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rollback is required")]
    [TerraformPropertyName("rollback")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> Rollback { get; set; }

}

/// <summary>
/// Block type for capacity_provider_strategy in .
/// Nesting mode: set
/// </summary>
public class AwsEcsServiceCapacityProviderStrategyBlock : ITerraformBlock
{
    /// <summary>
    /// The base attribute.
    /// </summary>
    [TerraformPropertyName("base")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Base { get; set; }

    /// <summary>
    /// The capacity_provider attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CapacityProvider is required")]
    [TerraformPropertyName("capacity_provider")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> CapacityProvider { get; set; }

    /// <summary>
    /// The weight attribute.
    /// </summary>
    [TerraformPropertyName("weight")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Weight { get; set; }

}

/// <summary>
/// Block type for deployment_circuit_breaker in .
/// Nesting mode: list
/// </summary>
public class AwsEcsServiceDeploymentCircuitBreakerBlock : ITerraformBlock
{
    /// <summary>
    /// The enable attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enable is required")]
    [TerraformPropertyName("enable")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> Enable { get; set; }

    /// <summary>
    /// The rollback attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rollback is required")]
    [TerraformPropertyName("rollback")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> Rollback { get; set; }

}

/// <summary>
/// Block type for deployment_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsEcsServiceDeploymentConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The bake_time_in_minutes attribute.
    /// </summary>
    [TerraformPropertyName("bake_time_in_minutes")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> BakeTimeInMinutes { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "bake_time_in_minutes");

    /// <summary>
    /// The strategy attribute.
    /// </summary>
    [TerraformPropertyName("strategy")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Strategy { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "strategy");

}

/// <summary>
/// Block type for deployment_controller in .
/// Nesting mode: list
/// </summary>
public class AwsEcsServiceDeploymentControllerBlock : ITerraformBlock
{
    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Type { get; set; }

}

/// <summary>
/// Block type for load_balancer in .
/// Nesting mode: set
/// </summary>
public class AwsEcsServiceLoadBalancerBlock : ITerraformBlock
{
    /// <summary>
    /// The container_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerName is required")]
    [TerraformPropertyName("container_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ContainerName { get; set; }

    /// <summary>
    /// The container_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerPort is required")]
    [TerraformPropertyName("container_port")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> ContainerPort { get; set; }

    /// <summary>
    /// The elb_name attribute.
    /// </summary>
    [TerraformPropertyName("elb_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ElbName { get; set; }

    /// <summary>
    /// The target_group_arn attribute.
    /// </summary>
    [TerraformPropertyName("target_group_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TargetGroupArn { get; set; }

}

/// <summary>
/// Block type for network_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsEcsServiceNetworkConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The assign_public_ip attribute.
    /// </summary>
    [TerraformPropertyName("assign_public_ip")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AssignPublicIp { get; set; }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    [TerraformPropertyName("security_groups")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? SecurityGroups { get; set; }

    /// <summary>
    /// The subnets attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Subnets is required")]
    [TerraformPropertyName("subnets")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Subnets { get; set; }

}

/// <summary>
/// Block type for ordered_placement_strategy in .
/// Nesting mode: list
/// </summary>
public class AwsEcsServiceOrderedPlacementStrategyBlock : ITerraformBlock
{
    /// <summary>
    /// The field attribute.
    /// </summary>
    [TerraformPropertyName("field")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Field { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

}

/// <summary>
/// Block type for placement_constraints in .
/// Nesting mode: set
/// </summary>
public class AwsEcsServicePlacementConstraintsBlock : ITerraformBlock
{
    /// <summary>
    /// The expression attribute.
    /// </summary>
    [TerraformPropertyName("expression")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Expression { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

}

/// <summary>
/// Block type for service_connect_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsEcsServiceServiceConnectConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformPropertyName("enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> Enabled { get; set; }

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    [TerraformPropertyName("namespace")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Namespace { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "namespace");

}

/// <summary>
/// Block type for service_registries in .
/// Nesting mode: list
/// </summary>
public class AwsEcsServiceServiceRegistriesBlock : ITerraformBlock
{
    /// <summary>
    /// The container_name attribute.
    /// </summary>
    [TerraformPropertyName("container_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ContainerName { get; set; }

    /// <summary>
    /// The container_port attribute.
    /// </summary>
    [TerraformPropertyName("container_port")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? ContainerPort { get; set; }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformPropertyName("port")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Port { get; set; }

    /// <summary>
    /// The registry_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RegistryArn is required")]
    [TerraformPropertyName("registry_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RegistryArn { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsEcsServiceTimeoutsBlock : ITerraformBlock
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
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Block type for volume_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsEcsServiceVolumeConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

}

/// <summary>
/// Block type for vpc_lattice_configurations in .
/// Nesting mode: set
/// </summary>
public class AwsEcsServiceVpcLatticeConfigurationsBlock : ITerraformBlock
{
    /// <summary>
    /// The port_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PortName is required")]
    [TerraformPropertyName("port_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> PortName { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformPropertyName("role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RoleArn { get; set; }

    /// <summary>
    /// The target_group_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetGroupArn is required")]
    [TerraformPropertyName("target_group_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> TargetGroupArn { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AvailabilityZoneRebalancing { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "availability_zone_rebalancing");

    /// <summary>
    /// The cluster attribute.
    /// </summary>
    [TerraformPropertyName("cluster")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Cluster { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "cluster");

    /// <summary>
    /// The deployment_maximum_percent attribute.
    /// </summary>
    [TerraformPropertyName("deployment_maximum_percent")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? DeploymentMaximumPercent { get; set; }

    /// <summary>
    /// The deployment_minimum_healthy_percent attribute.
    /// </summary>
    [TerraformPropertyName("deployment_minimum_healthy_percent")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? DeploymentMinimumHealthyPercent { get; set; }

    /// <summary>
    /// The desired_count attribute.
    /// </summary>
    [TerraformPropertyName("desired_count")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? DesiredCount { get; set; }

    /// <summary>
    /// The enable_ecs_managed_tags attribute.
    /// </summary>
    [TerraformPropertyName("enable_ecs_managed_tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableEcsManagedTags { get; set; }

    /// <summary>
    /// The enable_execute_command attribute.
    /// </summary>
    [TerraformPropertyName("enable_execute_command")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableExecuteCommand { get; set; }

    /// <summary>
    /// The force_delete attribute.
    /// </summary>
    [TerraformPropertyName("force_delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ForceDelete { get; set; }

    /// <summary>
    /// The force_new_deployment attribute.
    /// </summary>
    [TerraformPropertyName("force_new_deployment")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ForceNewDeployment { get; set; }

    /// <summary>
    /// The health_check_grace_period_seconds attribute.
    /// </summary>
    [TerraformPropertyName("health_check_grace_period_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? HealthCheckGracePeriodSeconds { get; set; }

    /// <summary>
    /// The iam_role attribute.
    /// </summary>
    [TerraformPropertyName("iam_role")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> IamRole { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "iam_role");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The launch_type attribute.
    /// </summary>
    [TerraformPropertyName("launch_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> LaunchType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "launch_type");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The platform_version attribute.
    /// </summary>
    [TerraformPropertyName("platform_version")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> PlatformVersion { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "platform_version");

    /// <summary>
    /// The propagate_tags attribute.
    /// </summary>
    [TerraformPropertyName("propagate_tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PropagateTags { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The scheduling_strategy attribute.
    /// </summary>
    [TerraformPropertyName("scheduling_strategy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SchedulingStrategy { get; set; }

    /// <summary>
    /// The sigint_rollback attribute.
    /// </summary>
    [TerraformPropertyName("sigint_rollback")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? SigintRollback { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// The task_definition attribute.
    /// </summary>
    [TerraformPropertyName("task_definition")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TaskDefinition { get; set; }

    /// <summary>
    /// The triggers attribute.
    /// </summary>
    [TerraformPropertyName("triggers")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Triggers { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "triggers");

    /// <summary>
    /// The wait_for_steady_state attribute.
    /// </summary>
    [TerraformPropertyName("wait_for_steady_state")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? WaitForSteadyState { get; set; }

    /// <summary>
    /// Block for alarms.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Alarms block(s) allowed")]
    [TerraformPropertyName("alarms")]
    public TerraformList<TerraformBlock<AwsEcsServiceAlarmsBlock>>? Alarms { get; set; } = new();

    /// <summary>
    /// Block for capacity_provider_strategy.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("capacity_provider_strategy")]
    public TerraformSet<TerraformBlock<AwsEcsServiceCapacityProviderStrategyBlock>>? CapacityProviderStrategy { get; set; } = new();

    /// <summary>
    /// Block for deployment_circuit_breaker.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeploymentCircuitBreaker block(s) allowed")]
    [TerraformPropertyName("deployment_circuit_breaker")]
    public TerraformList<TerraformBlock<AwsEcsServiceDeploymentCircuitBreakerBlock>>? DeploymentCircuitBreaker { get; set; } = new();

    /// <summary>
    /// Block for deployment_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeploymentConfiguration block(s) allowed")]
    [TerraformPropertyName("deployment_configuration")]
    public TerraformList<TerraformBlock<AwsEcsServiceDeploymentConfigurationBlock>>? DeploymentConfiguration { get; set; } = new();

    /// <summary>
    /// Block for deployment_controller.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeploymentController block(s) allowed")]
    [TerraformPropertyName("deployment_controller")]
    public TerraformList<TerraformBlock<AwsEcsServiceDeploymentControllerBlock>>? DeploymentController { get; set; } = new();

    /// <summary>
    /// Block for load_balancer.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("load_balancer")]
    public TerraformSet<TerraformBlock<AwsEcsServiceLoadBalancerBlock>>? LoadBalancer { get; set; } = new();

    /// <summary>
    /// Block for network_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfiguration block(s) allowed")]
    [TerraformPropertyName("network_configuration")]
    public TerraformList<TerraformBlock<AwsEcsServiceNetworkConfigurationBlock>>? NetworkConfiguration { get; set; } = new();

    /// <summary>
    /// Block for ordered_placement_strategy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 OrderedPlacementStrategy block(s) allowed")]
    [TerraformPropertyName("ordered_placement_strategy")]
    public TerraformList<TerraformBlock<AwsEcsServiceOrderedPlacementStrategyBlock>>? OrderedPlacementStrategy { get; set; } = new();

    /// <summary>
    /// Block for placement_constraints.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 PlacementConstraints block(s) allowed")]
    [TerraformPropertyName("placement_constraints")]
    public TerraformSet<TerraformBlock<AwsEcsServicePlacementConstraintsBlock>>? PlacementConstraints { get; set; } = new();

    /// <summary>
    /// Block for service_connect_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceConnectConfiguration block(s) allowed")]
    [TerraformPropertyName("service_connect_configuration")]
    public TerraformList<TerraformBlock<AwsEcsServiceServiceConnectConfigurationBlock>>? ServiceConnectConfiguration { get; set; } = new();

    /// <summary>
    /// Block for service_registries.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceRegistries block(s) allowed")]
    [TerraformPropertyName("service_registries")]
    public TerraformList<TerraformBlock<AwsEcsServiceServiceRegistriesBlock>>? ServiceRegistries { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsEcsServiceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Block for volume_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VolumeConfiguration block(s) allowed")]
    [TerraformPropertyName("volume_configuration")]
    public TerraformList<TerraformBlock<AwsEcsServiceVolumeConfigurationBlock>>? VolumeConfiguration { get; set; } = new();

    /// <summary>
    /// Block for vpc_lattice_configurations.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("vpc_lattice_configurations")]
    public TerraformSet<TerraformBlock<AwsEcsServiceVpcLatticeConfigurationsBlock>>? VpcLatticeConfigurations { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

}
