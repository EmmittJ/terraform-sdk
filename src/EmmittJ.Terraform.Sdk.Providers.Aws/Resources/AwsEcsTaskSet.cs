using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for capacity_provider_strategy in .
/// Nesting mode: set
/// </summary>
public class AwsEcsTaskSetCapacityProviderStrategyBlock : TerraformBlock
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
        get => GetProperty<TerraformProperty<string>>("capacity_provider");
        set => WithProperty("capacity_provider", value);
    }

    /// <summary>
    /// The weight attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Weight is required")]
    public required TerraformProperty<double> Weight
    {
        get => GetProperty<TerraformProperty<double>>("weight");
        set => WithProperty("weight", value);
    }

}

/// <summary>
/// Block type for load_balancer in .
/// Nesting mode: set
/// </summary>
public class AwsEcsTaskSetLoadBalancerBlock : TerraformBlock
{
    /// <summary>
    /// The container_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerName is required")]
    public required TerraformProperty<string> ContainerName
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
    /// The load_balancer_name attribute.
    /// </summary>
    public TerraformProperty<string>? LoadBalancerName
    {
        get => GetProperty<TerraformProperty<string>>("load_balancer_name");
        set => WithProperty("load_balancer_name", value);
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
public class AwsEcsTaskSetNetworkConfigurationBlock : TerraformBlock
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
/// Block type for scale in .
/// Nesting mode: list
/// </summary>
public class AwsEcsTaskSetScaleBlock : TerraformBlock
{
    /// <summary>
    /// The unit attribute.
    /// </summary>
    public TerraformProperty<string>? Unit
    {
        get => GetProperty<TerraformProperty<string>>("unit");
        set => WithProperty("unit", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformProperty<double>? Value
    {
        get => GetProperty<TerraformProperty<double>>("value");
        set => WithProperty("value", value);
    }

}

/// <summary>
/// Block type for service_registries in .
/// Nesting mode: list
/// </summary>
public class AwsEcsTaskSetServiceRegistriesBlock : TerraformBlock
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
        get => GetProperty<TerraformProperty<string>>("registry_arn");
        set => WithProperty("registry_arn", value);
    }

}

/// <summary>
/// Manages a aws_ecs_task_set resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsEcsTaskSet : TerraformResource
{
    public AwsEcsTaskSet(string name) : base("aws_ecs_task_set", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("stability_status");
        this.DeclareOutput("status");
        this.DeclareOutput("task_set_id");
    }

    /// <summary>
    /// The cluster attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cluster is required")]
    public required TerraformProperty<string> Cluster
    {
        get => GetProperty<TerraformProperty<string>>("cluster");
        set => this.WithProperty("cluster", value);
    }

    /// <summary>
    /// The external_id attribute.
    /// </summary>
    public TerraformProperty<string>? ExternalId
    {
        get => GetProperty<TerraformProperty<string>>("external_id");
        set => this.WithProperty("external_id", value);
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
    /// The platform_version attribute.
    /// </summary>
    public TerraformProperty<string>? PlatformVersion
    {
        get => GetProperty<TerraformProperty<string>>("platform_version");
        set => this.WithProperty("platform_version", value);
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
    /// The service attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    public required TerraformProperty<string> Service
    {
        get => GetProperty<TerraformProperty<string>>("service");
        set => this.WithProperty("service", value);
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TaskDefinition is required")]
    public required TerraformProperty<string> TaskDefinition
    {
        get => GetProperty<TerraformProperty<string>>("task_definition");
        set => this.WithProperty("task_definition", value);
    }

    /// <summary>
    /// The wait_until_stable attribute.
    /// </summary>
    public TerraformProperty<bool>? WaitUntilStable
    {
        get => GetProperty<TerraformProperty<bool>>("wait_until_stable");
        set => this.WithProperty("wait_until_stable", value);
    }

    /// <summary>
    /// The wait_until_stable_timeout attribute.
    /// </summary>
    public TerraformProperty<string>? WaitUntilStableTimeout
    {
        get => GetProperty<TerraformProperty<string>>("wait_until_stable_timeout");
        set => this.WithProperty("wait_until_stable_timeout", value);
    }

    /// <summary>
    /// Block for capacity_provider_strategy.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsEcsTaskSetCapacityProviderStrategyBlock>? CapacityProviderStrategy
    {
        get => GetProperty<HashSet<AwsEcsTaskSetCapacityProviderStrategyBlock>>("capacity_provider_strategy");
        set => this.WithProperty("capacity_provider_strategy", value);
    }

    /// <summary>
    /// Block for load_balancer.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsEcsTaskSetLoadBalancerBlock>? LoadBalancer
    {
        get => GetProperty<HashSet<AwsEcsTaskSetLoadBalancerBlock>>("load_balancer");
        set => this.WithProperty("load_balancer", value);
    }

    /// <summary>
    /// Block for network_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfiguration block(s) allowed")]
    public List<AwsEcsTaskSetNetworkConfigurationBlock>? NetworkConfiguration
    {
        get => GetProperty<List<AwsEcsTaskSetNetworkConfigurationBlock>>("network_configuration");
        set => this.WithProperty("network_configuration", value);
    }

    /// <summary>
    /// Block for scale.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Scale block(s) allowed")]
    public List<AwsEcsTaskSetScaleBlock>? Scale
    {
        get => GetProperty<List<AwsEcsTaskSetScaleBlock>>("scale");
        set => this.WithProperty("scale", value);
    }

    /// <summary>
    /// Block for service_registries.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceRegistries block(s) allowed")]
    public List<AwsEcsTaskSetServiceRegistriesBlock>? ServiceRegistries
    {
        get => GetProperty<List<AwsEcsTaskSetServiceRegistriesBlock>>("service_registries");
        set => this.WithProperty("service_registries", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The stability_status attribute.
    /// </summary>
    public TerraformExpression StabilityStatus => this["stability_status"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The task_set_id attribute.
    /// </summary>
    public TerraformExpression TaskSetId => this["task_set_id"];

}
