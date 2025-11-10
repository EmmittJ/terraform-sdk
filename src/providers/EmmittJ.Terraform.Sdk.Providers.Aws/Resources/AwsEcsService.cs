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
        set => SetProperty("alarm_names", value);
    }

    /// <summary>
    /// The enable attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enable is required")]
    public required TerraformProperty<bool> Enable
    {
        set => SetProperty("enable", value);
    }

    /// <summary>
    /// The rollback attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rollback is required")]
    public required TerraformProperty<bool> Rollback
    {
        set => SetProperty("rollback", value);
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
        set => SetProperty("base", value);
    }

    /// <summary>
    /// The capacity_provider attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CapacityProvider is required")]
    public required TerraformProperty<string> CapacityProvider
    {
        set => SetProperty("capacity_provider", value);
    }

    /// <summary>
    /// The weight attribute.
    /// </summary>
    public TerraformProperty<double>? Weight
    {
        set => SetProperty("weight", value);
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
        set => SetProperty("enable", value);
    }

    /// <summary>
    /// The rollback attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rollback is required")]
    public required TerraformProperty<bool> Rollback
    {
        set => SetProperty("rollback", value);
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
        set => SetProperty("bake_time_in_minutes", value);
    }

    /// <summary>
    /// The strategy attribute.
    /// </summary>
    public TerraformProperty<string>? Strategy
    {
        set => SetProperty("strategy", value);
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
        set => SetProperty("type", value);
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
        set => SetProperty("container_name", value);
    }

    /// <summary>
    /// The container_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerPort is required")]
    public required TerraformProperty<double> ContainerPort
    {
        set => SetProperty("container_port", value);
    }

    /// <summary>
    /// The elb_name attribute.
    /// </summary>
    public TerraformProperty<string>? ElbName
    {
        set => SetProperty("elb_name", value);
    }

    /// <summary>
    /// The target_group_arn attribute.
    /// </summary>
    public TerraformProperty<string>? TargetGroupArn
    {
        set => SetProperty("target_group_arn", value);
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
        set => SetProperty("assign_public_ip", value);
    }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SecurityGroups
    {
        set => SetProperty("security_groups", value);
    }

    /// <summary>
    /// The subnets attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Subnets is required")]
    public HashSet<TerraformProperty<string>>? Subnets
    {
        set => SetProperty("subnets", value);
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
        set => SetProperty("field", value);
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
        set => SetProperty("expression", value);
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
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    public TerraformProperty<string>? Namespace
    {
        set => SetProperty("namespace", value);
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
        set => SetProperty("container_name", value);
    }

    /// <summary>
    /// The container_port attribute.
    /// </summary>
    public TerraformProperty<double>? ContainerPort
    {
        set => SetProperty("container_port", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformProperty<double>? Port
    {
        set => SetProperty("port", value);
    }

    /// <summary>
    /// The registry_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RegistryArn is required")]
    public required TerraformProperty<string> RegistryArn
    {
        set => SetProperty("registry_arn", value);
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
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        set => SetProperty("name", value);
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
        set => SetProperty("port_name", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        set => SetProperty("role_arn", value);
    }

    /// <summary>
    /// The target_group_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetGroupArn is required")]
    public required TerraformProperty<string> TargetGroupArn
    {
        set => SetProperty("target_group_arn", value);
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
        SetOutput("arn");
        SetOutput("availability_zone_rebalancing");
        SetOutput("cluster");
        SetOutput("deployment_maximum_percent");
        SetOutput("deployment_minimum_healthy_percent");
        SetOutput("desired_count");
        SetOutput("enable_ecs_managed_tags");
        SetOutput("enable_execute_command");
        SetOutput("force_delete");
        SetOutput("force_new_deployment");
        SetOutput("health_check_grace_period_seconds");
        SetOutput("iam_role");
        SetOutput("id");
        SetOutput("launch_type");
        SetOutput("name");
        SetOutput("platform_version");
        SetOutput("propagate_tags");
        SetOutput("region");
        SetOutput("scheduling_strategy");
        SetOutput("sigint_rollback");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("task_definition");
        SetOutput("triggers");
        SetOutput("wait_for_steady_state");
    }

    /// <summary>
    /// The availability_zone_rebalancing attribute.
    /// </summary>
    public TerraformProperty<string> AvailabilityZoneRebalancing
    {
        get => GetRequiredOutput<TerraformProperty<string>>("availability_zone_rebalancing");
        set => SetProperty("availability_zone_rebalancing", value);
    }

    /// <summary>
    /// The cluster attribute.
    /// </summary>
    public TerraformProperty<string> Cluster
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cluster");
        set => SetProperty("cluster", value);
    }

    /// <summary>
    /// The deployment_maximum_percent attribute.
    /// </summary>
    public TerraformProperty<double> DeploymentMaximumPercent
    {
        get => GetRequiredOutput<TerraformProperty<double>>("deployment_maximum_percent");
        set => SetProperty("deployment_maximum_percent", value);
    }

    /// <summary>
    /// The deployment_minimum_healthy_percent attribute.
    /// </summary>
    public TerraformProperty<double> DeploymentMinimumHealthyPercent
    {
        get => GetRequiredOutput<TerraformProperty<double>>("deployment_minimum_healthy_percent");
        set => SetProperty("deployment_minimum_healthy_percent", value);
    }

    /// <summary>
    /// The desired_count attribute.
    /// </summary>
    public TerraformProperty<double> DesiredCount
    {
        get => GetRequiredOutput<TerraformProperty<double>>("desired_count");
        set => SetProperty("desired_count", value);
    }

    /// <summary>
    /// The enable_ecs_managed_tags attribute.
    /// </summary>
    public TerraformProperty<bool> EnableEcsManagedTags
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_ecs_managed_tags");
        set => SetProperty("enable_ecs_managed_tags", value);
    }

    /// <summary>
    /// The enable_execute_command attribute.
    /// </summary>
    public TerraformProperty<bool> EnableExecuteCommand
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_execute_command");
        set => SetProperty("enable_execute_command", value);
    }

    /// <summary>
    /// The force_delete attribute.
    /// </summary>
    public TerraformProperty<bool> ForceDelete
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("force_delete");
        set => SetProperty("force_delete", value);
    }

    /// <summary>
    /// The force_new_deployment attribute.
    /// </summary>
    public TerraformProperty<bool> ForceNewDeployment
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("force_new_deployment");
        set => SetProperty("force_new_deployment", value);
    }

    /// <summary>
    /// The health_check_grace_period_seconds attribute.
    /// </summary>
    public TerraformProperty<double> HealthCheckGracePeriodSeconds
    {
        get => GetRequiredOutput<TerraformProperty<double>>("health_check_grace_period_seconds");
        set => SetProperty("health_check_grace_period_seconds", value);
    }

    /// <summary>
    /// The iam_role attribute.
    /// </summary>
    public TerraformProperty<string> IamRole
    {
        get => GetRequiredOutput<TerraformProperty<string>>("iam_role");
        set => SetProperty("iam_role", value);
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
    /// The launch_type attribute.
    /// </summary>
    public TerraformProperty<string> LaunchType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("launch_type");
        set => SetProperty("launch_type", value);
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
    /// The platform_version attribute.
    /// </summary>
    public TerraformProperty<string> PlatformVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("platform_version");
        set => SetProperty("platform_version", value);
    }

    /// <summary>
    /// The propagate_tags attribute.
    /// </summary>
    public TerraformProperty<string> PropagateTags
    {
        get => GetRequiredOutput<TerraformProperty<string>>("propagate_tags");
        set => SetProperty("propagate_tags", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The scheduling_strategy attribute.
    /// </summary>
    public TerraformProperty<string> SchedulingStrategy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("scheduling_strategy");
        set => SetProperty("scheduling_strategy", value);
    }

    /// <summary>
    /// The sigint_rollback attribute.
    /// </summary>
    public TerraformProperty<bool> SigintRollback
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("sigint_rollback");
        set => SetProperty("sigint_rollback", value);
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The task_definition attribute.
    /// </summary>
    public TerraformProperty<string> TaskDefinition
    {
        get => GetRequiredOutput<TerraformProperty<string>>("task_definition");
        set => SetProperty("task_definition", value);
    }

    /// <summary>
    /// The triggers attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Triggers
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("triggers");
        set => SetProperty("triggers", value);
    }

    /// <summary>
    /// The wait_for_steady_state attribute.
    /// </summary>
    public TerraformProperty<bool> WaitForSteadyState
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("wait_for_steady_state");
        set => SetProperty("wait_for_steady_state", value);
    }

    /// <summary>
    /// Block for alarms.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Alarms block(s) allowed")]
    public List<AwsEcsServiceAlarmsBlock>? Alarms
    {
        set => SetProperty("alarms", value);
    }

    /// <summary>
    /// Block for capacity_provider_strategy.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsEcsServiceCapacityProviderStrategyBlock>? CapacityProviderStrategy
    {
        set => SetProperty("capacity_provider_strategy", value);
    }

    /// <summary>
    /// Block for deployment_circuit_breaker.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeploymentCircuitBreaker block(s) allowed")]
    public List<AwsEcsServiceDeploymentCircuitBreakerBlock>? DeploymentCircuitBreaker
    {
        set => SetProperty("deployment_circuit_breaker", value);
    }

    /// <summary>
    /// Block for deployment_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeploymentConfiguration block(s) allowed")]
    public List<AwsEcsServiceDeploymentConfigurationBlock>? DeploymentConfiguration
    {
        set => SetProperty("deployment_configuration", value);
    }

    /// <summary>
    /// Block for deployment_controller.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeploymentController block(s) allowed")]
    public List<AwsEcsServiceDeploymentControllerBlock>? DeploymentController
    {
        set => SetProperty("deployment_controller", value);
    }

    /// <summary>
    /// Block for load_balancer.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsEcsServiceLoadBalancerBlock>? LoadBalancer
    {
        set => SetProperty("load_balancer", value);
    }

    /// <summary>
    /// Block for network_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfiguration block(s) allowed")]
    public List<AwsEcsServiceNetworkConfigurationBlock>? NetworkConfiguration
    {
        set => SetProperty("network_configuration", value);
    }

    /// <summary>
    /// Block for ordered_placement_strategy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 OrderedPlacementStrategy block(s) allowed")]
    public List<AwsEcsServiceOrderedPlacementStrategyBlock>? OrderedPlacementStrategy
    {
        set => SetProperty("ordered_placement_strategy", value);
    }

    /// <summary>
    /// Block for placement_constraints.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 PlacementConstraints block(s) allowed")]
    public HashSet<AwsEcsServicePlacementConstraintsBlock>? PlacementConstraints
    {
        set => SetProperty("placement_constraints", value);
    }

    /// <summary>
    /// Block for service_connect_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceConnectConfiguration block(s) allowed")]
    public List<AwsEcsServiceServiceConnectConfigurationBlock>? ServiceConnectConfiguration
    {
        set => SetProperty("service_connect_configuration", value);
    }

    /// <summary>
    /// Block for service_registries.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceRegistries block(s) allowed")]
    public List<AwsEcsServiceServiceRegistriesBlock>? ServiceRegistries
    {
        set => SetProperty("service_registries", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsEcsServiceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for volume_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VolumeConfiguration block(s) allowed")]
    public List<AwsEcsServiceVolumeConfigurationBlock>? VolumeConfiguration
    {
        set => SetProperty("volume_configuration", value);
    }

    /// <summary>
    /// Block for vpc_lattice_configurations.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsEcsServiceVpcLatticeConfigurationsBlock>? VpcLatticeConfigurations
    {
        set => SetProperty("vpc_lattice_configurations", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
