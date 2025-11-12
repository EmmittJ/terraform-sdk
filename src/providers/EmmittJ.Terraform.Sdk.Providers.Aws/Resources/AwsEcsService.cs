using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for alarms in .
/// Nesting mode: list
/// </summary>
public partial class AwsEcsServiceAlarmsBlock() : TerraformBlock("alarms")
{
    /// <summary>
    /// The alarm_names attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AlarmNames is required")]
    [TerraformProperty("alarm_names")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> AlarmNames { get; set; }

    /// <summary>
    /// The enable attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enable is required")]
    [TerraformProperty("enable")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> Enable { get; set; }

    /// <summary>
    /// The rollback attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rollback is required")]
    [TerraformProperty("rollback")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> Rollback { get; set; }

}

/// <summary>
/// Block type for capacity_provider_strategy in .
/// Nesting mode: set
/// </summary>
public partial class AwsEcsServiceCapacityProviderStrategyBlock() : TerraformBlock("capacity_provider_strategy")
{
    /// <summary>
    /// The base attribute.
    /// </summary>
    [TerraformProperty("base")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Base { get; set; }

    /// <summary>
    /// The capacity_provider attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CapacityProvider is required")]
    [TerraformProperty("capacity_provider")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> CapacityProvider { get; set; }

    /// <summary>
    /// The weight attribute.
    /// </summary>
    [TerraformProperty("weight")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Weight { get; set; }

}

/// <summary>
/// Block type for deployment_circuit_breaker in .
/// Nesting mode: list
/// </summary>
public partial class AwsEcsServiceDeploymentCircuitBreakerBlock() : TerraformBlock("deployment_circuit_breaker")
{
    /// <summary>
    /// The enable attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enable is required")]
    [TerraformProperty("enable")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> Enable { get; set; }

    /// <summary>
    /// The rollback attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rollback is required")]
    [TerraformProperty("rollback")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> Rollback { get; set; }

}

/// <summary>
/// Block type for deployment_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsEcsServiceDeploymentConfigurationBlock() : TerraformBlock("deployment_configuration")
{
    /// <summary>
    /// The bake_time_in_minutes attribute.
    /// </summary>
    [TerraformProperty("bake_time_in_minutes")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> BakeTimeInMinutes { get; set; }

    /// <summary>
    /// The strategy attribute.
    /// </summary>
    [TerraformProperty("strategy")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Strategy { get; set; }

}

/// <summary>
/// Block type for deployment_controller in .
/// Nesting mode: list
/// </summary>
public partial class AwsEcsServiceDeploymentControllerBlock() : TerraformBlock("deployment_controller")
{
    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformProperty("type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Type { get; set; }

}

/// <summary>
/// Block type for load_balancer in .
/// Nesting mode: set
/// </summary>
public partial class AwsEcsServiceLoadBalancerBlock() : TerraformBlock("load_balancer")
{
    /// <summary>
    /// The container_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerName is required")]
    [TerraformProperty("container_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ContainerName { get; set; }

    /// <summary>
    /// The container_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerPort is required")]
    [TerraformProperty("container_port")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> ContainerPort { get; set; }

    /// <summary>
    /// The elb_name attribute.
    /// </summary>
    [TerraformProperty("elb_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ElbName { get; set; }

    /// <summary>
    /// The target_group_arn attribute.
    /// </summary>
    [TerraformProperty("target_group_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TargetGroupArn { get; set; }

}

/// <summary>
/// Block type for network_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsEcsServiceNetworkConfigurationBlock() : TerraformBlock("network_configuration")
{
    /// <summary>
    /// The assign_public_ip attribute.
    /// </summary>
    [TerraformProperty("assign_public_ip")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AssignPublicIp { get; set; }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    [TerraformProperty("security_groups")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? SecurityGroups { get; set; }

    /// <summary>
    /// The subnets attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Subnets is required")]
    [TerraformProperty("subnets")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> Subnets { get; set; }

}

/// <summary>
/// Block type for ordered_placement_strategy in .
/// Nesting mode: list
/// </summary>
public partial class AwsEcsServiceOrderedPlacementStrategyBlock() : TerraformBlock("ordered_placement_strategy")
{
    /// <summary>
    /// The field attribute.
    /// </summary>
    [TerraformProperty("field")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Field { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for placement_constraints in .
/// Nesting mode: set
/// </summary>
public partial class AwsEcsServicePlacementConstraintsBlock() : TerraformBlock("placement_constraints")
{
    /// <summary>
    /// The expression attribute.
    /// </summary>
    [TerraformProperty("expression")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Expression { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for service_connect_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsEcsServiceServiceConnectConfigurationBlock() : TerraformBlock("service_connect_configuration")
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformProperty("enabled")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> Enabled { get; set; }

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    [TerraformProperty("namespace")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Namespace { get; set; }

}

/// <summary>
/// Block type for service_registries in .
/// Nesting mode: list
/// </summary>
public partial class AwsEcsServiceServiceRegistriesBlock() : TerraformBlock("service_registries")
{
    /// <summary>
    /// The container_name attribute.
    /// </summary>
    [TerraformProperty("container_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ContainerName { get; set; }

    /// <summary>
    /// The container_port attribute.
    /// </summary>
    [TerraformProperty("container_port")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? ContainerPort { get; set; }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformProperty("port")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Port { get; set; }

    /// <summary>
    /// The registry_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RegistryArn is required")]
    [TerraformProperty("registry_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RegistryArn { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsEcsServiceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for volume_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsEcsServiceVolumeConfigurationBlock() : TerraformBlock("volume_configuration")
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

}

/// <summary>
/// Block type for vpc_lattice_configurations in .
/// Nesting mode: set
/// </summary>
public partial class AwsEcsServiceVpcLatticeConfigurationsBlock() : TerraformBlock("vpc_lattice_configurations")
{
    /// <summary>
    /// The port_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PortName is required")]
    [TerraformProperty("port_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PortName { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformProperty("role_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RoleArn { get; set; }

    /// <summary>
    /// The target_group_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetGroupArn is required")]
    [TerraformProperty("target_group_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TargetGroupArn { get; set; }

}

/// <summary>
/// Manages a aws_ecs_service resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsEcsService : TerraformResource
{
    public AwsEcsService(string name) : base("aws_ecs_service", name)
    {
    }

    /// <summary>
    /// The availability_zone_rebalancing attribute.
    /// </summary>
    [TerraformProperty("availability_zone_rebalancing")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> AvailabilityZoneRebalancing { get; set; }

    /// <summary>
    /// The cluster attribute.
    /// </summary>
    [TerraformProperty("cluster")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Cluster { get; set; }

    /// <summary>
    /// The deployment_maximum_percent attribute.
    /// </summary>
    [TerraformProperty("deployment_maximum_percent")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? DeploymentMaximumPercent { get; set; }

    /// <summary>
    /// The deployment_minimum_healthy_percent attribute.
    /// </summary>
    [TerraformProperty("deployment_minimum_healthy_percent")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? DeploymentMinimumHealthyPercent { get; set; }

    /// <summary>
    /// The desired_count attribute.
    /// </summary>
    [TerraformProperty("desired_count")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? DesiredCount { get; set; }

    /// <summary>
    /// The enable_ecs_managed_tags attribute.
    /// </summary>
    [TerraformProperty("enable_ecs_managed_tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableEcsManagedTags { get; set; }

    /// <summary>
    /// The enable_execute_command attribute.
    /// </summary>
    [TerraformProperty("enable_execute_command")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableExecuteCommand { get; set; }

    /// <summary>
    /// The force_delete attribute.
    /// </summary>
    [TerraformProperty("force_delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ForceDelete { get; set; }

    /// <summary>
    /// The force_new_deployment attribute.
    /// </summary>
    [TerraformProperty("force_new_deployment")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ForceNewDeployment { get; set; }

    /// <summary>
    /// The health_check_grace_period_seconds attribute.
    /// </summary>
    [TerraformProperty("health_check_grace_period_seconds")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? HealthCheckGracePeriodSeconds { get; set; }

    /// <summary>
    /// The iam_role attribute.
    /// </summary>
    [TerraformProperty("iam_role")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> IamRole { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The launch_type attribute.
    /// </summary>
    [TerraformProperty("launch_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> LaunchType { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The platform_version attribute.
    /// </summary>
    [TerraformProperty("platform_version")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> PlatformVersion { get; set; }

    /// <summary>
    /// The propagate_tags attribute.
    /// </summary>
    [TerraformProperty("propagate_tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PropagateTags { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The scheduling_strategy attribute.
    /// </summary>
    [TerraformProperty("scheduling_strategy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SchedulingStrategy { get; set; }

    /// <summary>
    /// The sigint_rollback attribute.
    /// </summary>
    [TerraformProperty("sigint_rollback")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? SigintRollback { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The task_definition attribute.
    /// </summary>
    [TerraformProperty("task_definition")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TaskDefinition { get; set; }

    /// <summary>
    /// The triggers attribute.
    /// </summary>
    [TerraformProperty("triggers")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> Triggers { get; set; }

    /// <summary>
    /// The wait_for_steady_state attribute.
    /// </summary>
    [TerraformProperty("wait_for_steady_state")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? WaitForSteadyState { get; set; }

    /// <summary>
    /// Block for alarms.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Alarms block(s) allowed")]
    [TerraformProperty("alarms")]
    public TerraformList<AwsEcsServiceAlarmsBlock> Alarms { get; set; } = new();

    /// <summary>
    /// Block for capacity_provider_strategy.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("capacity_provider_strategy")]
    public TerraformSet<AwsEcsServiceCapacityProviderStrategyBlock> CapacityProviderStrategy { get; set; } = new();

    /// <summary>
    /// Block for deployment_circuit_breaker.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeploymentCircuitBreaker block(s) allowed")]
    [TerraformProperty("deployment_circuit_breaker")]
    public TerraformList<AwsEcsServiceDeploymentCircuitBreakerBlock> DeploymentCircuitBreaker { get; set; } = new();

    /// <summary>
    /// Block for deployment_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeploymentConfiguration block(s) allowed")]
    [TerraformProperty("deployment_configuration")]
    public TerraformList<AwsEcsServiceDeploymentConfigurationBlock> DeploymentConfiguration { get; set; } = new();

    /// <summary>
    /// Block for deployment_controller.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeploymentController block(s) allowed")]
    [TerraformProperty("deployment_controller")]
    public TerraformList<AwsEcsServiceDeploymentControllerBlock> DeploymentController { get; set; } = new();

    /// <summary>
    /// Block for load_balancer.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("load_balancer")]
    public TerraformSet<AwsEcsServiceLoadBalancerBlock> LoadBalancer { get; set; } = new();

    /// <summary>
    /// Block for network_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfiguration block(s) allowed")]
    [TerraformProperty("network_configuration")]
    public TerraformList<AwsEcsServiceNetworkConfigurationBlock> NetworkConfiguration { get; set; } = new();

    /// <summary>
    /// Block for ordered_placement_strategy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 OrderedPlacementStrategy block(s) allowed")]
    [TerraformProperty("ordered_placement_strategy")]
    public TerraformList<AwsEcsServiceOrderedPlacementStrategyBlock> OrderedPlacementStrategy { get; set; } = new();

    /// <summary>
    /// Block for placement_constraints.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 PlacementConstraints block(s) allowed")]
    [TerraformProperty("placement_constraints")]
    public TerraformSet<AwsEcsServicePlacementConstraintsBlock> PlacementConstraints { get; set; } = new();

    /// <summary>
    /// Block for service_connect_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceConnectConfiguration block(s) allowed")]
    [TerraformProperty("service_connect_configuration")]
    public TerraformList<AwsEcsServiceServiceConnectConfigurationBlock> ServiceConnectConfiguration { get; set; } = new();

    /// <summary>
    /// Block for service_registries.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceRegistries block(s) allowed")]
    [TerraformProperty("service_registries")]
    public TerraformList<AwsEcsServiceServiceRegistriesBlock> ServiceRegistries { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsEcsServiceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for volume_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VolumeConfiguration block(s) allowed")]
    [TerraformProperty("volume_configuration")]
    public TerraformList<AwsEcsServiceVolumeConfigurationBlock> VolumeConfiguration { get; set; } = new();

    /// <summary>
    /// Block for vpc_lattice_configurations.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("vpc_lattice_configurations")]
    public TerraformSet<AwsEcsServiceVpcLatticeConfigurationsBlock> VpcLatticeConfigurations { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

}
