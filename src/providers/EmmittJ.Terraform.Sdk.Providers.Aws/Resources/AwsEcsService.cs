using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for alarms in .
/// Nesting mode: list
/// </summary>
public class AwsEcsServiceAlarmsBlock : TerraformBlock
{
    /// <summary>
    /// The alarm_names attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AlarmNames is required")]
    public HashSet<TerraformProperty<string>>? AlarmNames
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("alarm_names");
        set => WithProperty("alarm_names", value);
    }

    /// <summary>
    /// The enable attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enable is required")]
    public required TerraformProperty<bool> Enable
    {
        get => GetRequiredProperty<TerraformProperty<bool>>("enable");
        set => WithProperty("enable", value);
    }

    /// <summary>
    /// The rollback attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rollback is required")]
    public required TerraformProperty<bool> Rollback
    {
        get => GetRequiredProperty<TerraformProperty<bool>>("rollback");
        set => WithProperty("rollback", value);
    }

}

/// <summary>
/// Block type for capacity_provider_strategy in .
/// Nesting mode: set
/// </summary>
public class AwsEcsServiceCapacityProviderStrategyBlock : TerraformBlock
{
    /// <summary>
    /// The base attribute.
    /// </summary>
    public TerraformProperty<double>? Base
    {
        get => GetProperty<TerraformProperty<double>>("base");
        set => WithProperty("base", value);
    }

    /// <summary>
    /// The capacity_provider attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CapacityProvider is required")]
    public required TerraformProperty<string> CapacityProvider
    {
        get => GetRequiredProperty<TerraformProperty<string>>("capacity_provider");
        set => WithProperty("capacity_provider", value);
    }

    /// <summary>
    /// The weight attribute.
    /// </summary>
    public TerraformProperty<double>? Weight
    {
        get => GetProperty<TerraformProperty<double>>("weight");
        set => WithProperty("weight", value);
    }

}

/// <summary>
/// Block type for deployment_circuit_breaker in .
/// Nesting mode: list
/// </summary>
public class AwsEcsServiceDeploymentCircuitBreakerBlock : TerraformBlock
{
    /// <summary>
    /// The enable attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enable is required")]
    public required TerraformProperty<bool> Enable
    {
        get => GetRequiredProperty<TerraformProperty<bool>>("enable");
        set => WithProperty("enable", value);
    }

    /// <summary>
    /// The rollback attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rollback is required")]
    public required TerraformProperty<bool> Rollback
    {
        get => GetRequiredProperty<TerraformProperty<bool>>("rollback");
        set => WithProperty("rollback", value);
    }

}

/// <summary>
/// Block type for deployment_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsEcsServiceDeploymentConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The bake_time_in_minutes attribute.
    /// </summary>
    public TerraformProperty<string>? BakeTimeInMinutes
    {
        get => GetProperty<TerraformProperty<string>>("bake_time_in_minutes");
        set => WithProperty("bake_time_in_minutes", value);
    }

    /// <summary>
    /// The strategy attribute.
    /// </summary>
    public TerraformProperty<string>? Strategy
    {
        get => GetProperty<TerraformProperty<string>>("strategy");
        set => WithProperty("strategy", value);
    }

}

/// <summary>
/// Block type for deployment_controller in .
/// Nesting mode: list
/// </summary>
public class AwsEcsServiceDeploymentControllerBlock : TerraformBlock
{
    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for load_balancer in .
/// Nesting mode: set
/// </summary>
public class AwsEcsServiceLoadBalancerBlock : TerraformBlock
{
    /// <summary>
    /// The container_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerName is required")]
    public required TerraformProperty<string> ContainerName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("container_name");
        set => WithProperty("container_name", value);
    }

    /// <summary>
    /// The container_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerPort is required")]
    public required TerraformProperty<double> ContainerPort
    {
        get => GetRequiredProperty<TerraformProperty<double>>("container_port");
        set => WithProperty("container_port", value);
    }

    /// <summary>
    /// The elb_name attribute.
    /// </summary>
    public TerraformProperty<string>? ElbName
    {
        get => GetProperty<TerraformProperty<string>>("elb_name");
        set => WithProperty("elb_name", value);
    }

    /// <summary>
    /// The target_group_arn attribute.
    /// </summary>
    public TerraformProperty<string>? TargetGroupArn
    {
        get => GetProperty<TerraformProperty<string>>("target_group_arn");
        set => WithProperty("target_group_arn", value);
    }

}

/// <summary>
/// Block type for network_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsEcsServiceNetworkConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The assign_public_ip attribute.
    /// </summary>
    public TerraformProperty<bool>? AssignPublicIp
    {
        get => GetProperty<TerraformProperty<bool>>("assign_public_ip");
        set => WithProperty("assign_public_ip", value);
    }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SecurityGroups
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("security_groups");
        set => WithProperty("security_groups", value);
    }

    /// <summary>
    /// The subnets attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Subnets is required")]
    public HashSet<TerraformProperty<string>>? Subnets
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("subnets");
        set => WithProperty("subnets", value);
    }

}

/// <summary>
/// Block type for ordered_placement_strategy in .
/// Nesting mode: list
/// </summary>
public class AwsEcsServiceOrderedPlacementStrategyBlock : TerraformBlock
{
    /// <summary>
    /// The field attribute.
    /// </summary>
    public TerraformProperty<string>? Field
    {
        get => GetProperty<TerraformProperty<string>>("field");
        set => WithProperty("field", value);
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
/// Block type for placement_constraints in .
/// Nesting mode: set
/// </summary>
public class AwsEcsServicePlacementConstraintsBlock : TerraformBlock
{
    /// <summary>
    /// The expression attribute.
    /// </summary>
    public TerraformProperty<string>? Expression
    {
        get => GetProperty<TerraformProperty<string>>("expression");
        set => WithProperty("expression", value);
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
/// Block type for service_connect_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsEcsServiceServiceConnectConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformProperty<bool> Enabled
    {
        get => GetRequiredProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
    }

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    public TerraformProperty<string>? Namespace
    {
        get => GetProperty<TerraformProperty<string>>("namespace");
        set => WithProperty("namespace", value);
    }

}

/// <summary>
/// Block type for service_registries in .
/// Nesting mode: list
/// </summary>
public class AwsEcsServiceServiceRegistriesBlock : TerraformBlock
{
    /// <summary>
    /// The container_name attribute.
    /// </summary>
    public TerraformProperty<string>? ContainerName
    {
        get => GetProperty<TerraformProperty<string>>("container_name");
        set => WithProperty("container_name", value);
    }

    /// <summary>
    /// The container_port attribute.
    /// </summary>
    public TerraformProperty<double>? ContainerPort
    {
        get => GetProperty<TerraformProperty<double>>("container_port");
        set => WithProperty("container_port", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformProperty<double>? Port
    {
        get => GetProperty<TerraformProperty<double>>("port");
        set => WithProperty("port", value);
    }

    /// <summary>
    /// The registry_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RegistryArn is required")]
    public required TerraformProperty<string> RegistryArn
    {
        get => GetRequiredProperty<TerraformProperty<string>>("registry_arn");
        set => WithProperty("registry_arn", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsEcsServiceTimeoutsBlock : TerraformBlock
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
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Block type for volume_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsEcsServiceVolumeConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

}

/// <summary>
/// Block type for vpc_lattice_configurations in .
/// Nesting mode: set
/// </summary>
public class AwsEcsServiceVpcLatticeConfigurationsBlock : TerraformBlock
{
    /// <summary>
    /// The port_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PortName is required")]
    public required TerraformProperty<string> PortName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("port_name");
        set => WithProperty("port_name", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        get => GetRequiredProperty<TerraformProperty<string>>("role_arn");
        set => WithProperty("role_arn", value);
    }

    /// <summary>
    /// The target_group_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetGroupArn is required")]
    public required TerraformProperty<string> TargetGroupArn
    {
        get => GetRequiredProperty<TerraformProperty<string>>("target_group_arn");
        set => WithProperty("target_group_arn", value);
    }

}

/// <summary>
/// Manages a aws_ecs_service resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsEcsService : TerraformResource
{
    public AwsEcsService(string name) : base("aws_ecs_service", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The availability_zone_rebalancing attribute.
    /// </summary>
    public TerraformProperty<string>? AvailabilityZoneRebalancing
    {
        get => GetProperty<TerraformProperty<string>>("availability_zone_rebalancing");
        set => this.WithProperty("availability_zone_rebalancing", value);
    }

    /// <summary>
    /// The cluster attribute.
    /// </summary>
    public TerraformProperty<string>? Cluster
    {
        get => GetProperty<TerraformProperty<string>>("cluster");
        set => this.WithProperty("cluster", value);
    }

    /// <summary>
    /// The deployment_maximum_percent attribute.
    /// </summary>
    public TerraformProperty<double>? DeploymentMaximumPercent
    {
        get => GetProperty<TerraformProperty<double>>("deployment_maximum_percent");
        set => this.WithProperty("deployment_maximum_percent", value);
    }

    /// <summary>
    /// The deployment_minimum_healthy_percent attribute.
    /// </summary>
    public TerraformProperty<double>? DeploymentMinimumHealthyPercent
    {
        get => GetProperty<TerraformProperty<double>>("deployment_minimum_healthy_percent");
        set => this.WithProperty("deployment_minimum_healthy_percent", value);
    }

    /// <summary>
    /// The desired_count attribute.
    /// </summary>
    public TerraformProperty<double>? DesiredCount
    {
        get => GetProperty<TerraformProperty<double>>("desired_count");
        set => this.WithProperty("desired_count", value);
    }

    /// <summary>
    /// The enable_ecs_managed_tags attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableEcsManagedTags
    {
        get => GetProperty<TerraformProperty<bool>>("enable_ecs_managed_tags");
        set => this.WithProperty("enable_ecs_managed_tags", value);
    }

    /// <summary>
    /// The enable_execute_command attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableExecuteCommand
    {
        get => GetProperty<TerraformProperty<bool>>("enable_execute_command");
        set => this.WithProperty("enable_execute_command", value);
    }

    /// <summary>
    /// The force_delete attribute.
    /// </summary>
    public TerraformProperty<bool>? ForceDelete
    {
        get => GetProperty<TerraformProperty<bool>>("force_delete");
        set => this.WithProperty("force_delete", value);
    }

    /// <summary>
    /// The force_new_deployment attribute.
    /// </summary>
    public TerraformProperty<bool>? ForceNewDeployment
    {
        get => GetProperty<TerraformProperty<bool>>("force_new_deployment");
        set => this.WithProperty("force_new_deployment", value);
    }

    /// <summary>
    /// The health_check_grace_period_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? HealthCheckGracePeriodSeconds
    {
        get => GetProperty<TerraformProperty<double>>("health_check_grace_period_seconds");
        set => this.WithProperty("health_check_grace_period_seconds", value);
    }

    /// <summary>
    /// The iam_role attribute.
    /// </summary>
    public TerraformProperty<string>? IamRole
    {
        get => GetProperty<TerraformProperty<string>>("iam_role");
        set => this.WithProperty("iam_role", value);
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
    /// The launch_type attribute.
    /// </summary>
    public TerraformProperty<string>? LaunchType
    {
        get => GetProperty<TerraformProperty<string>>("launch_type");
        set => this.WithProperty("launch_type", value);
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
    /// The platform_version attribute.
    /// </summary>
    public TerraformProperty<string>? PlatformVersion
    {
        get => GetProperty<TerraformProperty<string>>("platform_version");
        set => this.WithProperty("platform_version", value);
    }

    /// <summary>
    /// The propagate_tags attribute.
    /// </summary>
    public TerraformProperty<string>? PropagateTags
    {
        get => GetProperty<TerraformProperty<string>>("propagate_tags");
        set => this.WithProperty("propagate_tags", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The scheduling_strategy attribute.
    /// </summary>
    public TerraformProperty<string>? SchedulingStrategy
    {
        get => GetProperty<TerraformProperty<string>>("scheduling_strategy");
        set => this.WithProperty("scheduling_strategy", value);
    }

    /// <summary>
    /// The sigint_rollback attribute.
    /// </summary>
    public TerraformProperty<bool>? SigintRollback
    {
        get => GetProperty<TerraformProperty<bool>>("sigint_rollback");
        set => this.WithProperty("sigint_rollback", value);
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The task_definition attribute.
    /// </summary>
    public TerraformProperty<string>? TaskDefinition
    {
        get => GetProperty<TerraformProperty<string>>("task_definition");
        set => this.WithProperty("task_definition", value);
    }

    /// <summary>
    /// The triggers attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Triggers
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("triggers");
        set => this.WithProperty("triggers", value);
    }

    /// <summary>
    /// The wait_for_steady_state attribute.
    /// </summary>
    public TerraformProperty<bool>? WaitForSteadyState
    {
        get => GetProperty<TerraformProperty<bool>>("wait_for_steady_state");
        set => this.WithProperty("wait_for_steady_state", value);
    }

    /// <summary>
    /// Block for alarms.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Alarms block(s) allowed")]
    public List<AwsEcsServiceAlarmsBlock>? Alarms
    {
        get => GetProperty<List<AwsEcsServiceAlarmsBlock>>("alarms");
        set => this.WithProperty("alarms", value);
    }

    /// <summary>
    /// Block for capacity_provider_strategy.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsEcsServiceCapacityProviderStrategyBlock>? CapacityProviderStrategy
    {
        get => GetProperty<HashSet<AwsEcsServiceCapacityProviderStrategyBlock>>("capacity_provider_strategy");
        set => this.WithProperty("capacity_provider_strategy", value);
    }

    /// <summary>
    /// Block for deployment_circuit_breaker.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeploymentCircuitBreaker block(s) allowed")]
    public List<AwsEcsServiceDeploymentCircuitBreakerBlock>? DeploymentCircuitBreaker
    {
        get => GetProperty<List<AwsEcsServiceDeploymentCircuitBreakerBlock>>("deployment_circuit_breaker");
        set => this.WithProperty("deployment_circuit_breaker", value);
    }

    /// <summary>
    /// Block for deployment_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeploymentConfiguration block(s) allowed")]
    public List<AwsEcsServiceDeploymentConfigurationBlock>? DeploymentConfiguration
    {
        get => GetProperty<List<AwsEcsServiceDeploymentConfigurationBlock>>("deployment_configuration");
        set => this.WithProperty("deployment_configuration", value);
    }

    /// <summary>
    /// Block for deployment_controller.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeploymentController block(s) allowed")]
    public List<AwsEcsServiceDeploymentControllerBlock>? DeploymentController
    {
        get => GetProperty<List<AwsEcsServiceDeploymentControllerBlock>>("deployment_controller");
        set => this.WithProperty("deployment_controller", value);
    }

    /// <summary>
    /// Block for load_balancer.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsEcsServiceLoadBalancerBlock>? LoadBalancer
    {
        get => GetProperty<HashSet<AwsEcsServiceLoadBalancerBlock>>("load_balancer");
        set => this.WithProperty("load_balancer", value);
    }

    /// <summary>
    /// Block for network_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfiguration block(s) allowed")]
    public List<AwsEcsServiceNetworkConfigurationBlock>? NetworkConfiguration
    {
        get => GetProperty<List<AwsEcsServiceNetworkConfigurationBlock>>("network_configuration");
        set => this.WithProperty("network_configuration", value);
    }

    /// <summary>
    /// Block for ordered_placement_strategy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 OrderedPlacementStrategy block(s) allowed")]
    public List<AwsEcsServiceOrderedPlacementStrategyBlock>? OrderedPlacementStrategy
    {
        get => GetProperty<List<AwsEcsServiceOrderedPlacementStrategyBlock>>("ordered_placement_strategy");
        set => this.WithProperty("ordered_placement_strategy", value);
    }

    /// <summary>
    /// Block for placement_constraints.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 PlacementConstraints block(s) allowed")]
    public HashSet<AwsEcsServicePlacementConstraintsBlock>? PlacementConstraints
    {
        get => GetProperty<HashSet<AwsEcsServicePlacementConstraintsBlock>>("placement_constraints");
        set => this.WithProperty("placement_constraints", value);
    }

    /// <summary>
    /// Block for service_connect_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceConnectConfiguration block(s) allowed")]
    public List<AwsEcsServiceServiceConnectConfigurationBlock>? ServiceConnectConfiguration
    {
        get => GetProperty<List<AwsEcsServiceServiceConnectConfigurationBlock>>("service_connect_configuration");
        set => this.WithProperty("service_connect_configuration", value);
    }

    /// <summary>
    /// Block for service_registries.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceRegistries block(s) allowed")]
    public List<AwsEcsServiceServiceRegistriesBlock>? ServiceRegistries
    {
        get => GetProperty<List<AwsEcsServiceServiceRegistriesBlock>>("service_registries");
        set => this.WithProperty("service_registries", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsEcsServiceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsEcsServiceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for volume_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VolumeConfiguration block(s) allowed")]
    public List<AwsEcsServiceVolumeConfigurationBlock>? VolumeConfiguration
    {
        get => GetProperty<List<AwsEcsServiceVolumeConfigurationBlock>>("volume_configuration");
        set => this.WithProperty("volume_configuration", value);
    }

    /// <summary>
    /// Block for vpc_lattice_configurations.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsEcsServiceVpcLatticeConfigurationsBlock>? VpcLatticeConfigurations
    {
        get => GetProperty<HashSet<AwsEcsServiceVpcLatticeConfigurationsBlock>>("vpc_lattice_configurations");
        set => this.WithProperty("vpc_lattice_configurations", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
