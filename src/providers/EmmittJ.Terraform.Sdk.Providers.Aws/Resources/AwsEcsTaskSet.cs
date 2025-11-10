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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Weight is required")]
    public required TerraformProperty<double> Weight
    {
        set => SetProperty("weight", value);
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
    /// The load_balancer_name attribute.
    /// </summary>
    public TerraformProperty<string>? LoadBalancerName
    {
        set => SetProperty("load_balancer_name", value);
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
public class AwsEcsTaskSetNetworkConfigurationBlock : TerraformBlock
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
        set => SetProperty("unit", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformProperty<double>? Value
    {
        set => SetProperty("value", value);
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
        SetOutput("arn");
        SetOutput("stability_status");
        SetOutput("status");
        SetOutput("task_set_id");
        SetOutput("cluster");
        SetOutput("external_id");
        SetOutput("force_delete");
        SetOutput("id");
        SetOutput("launch_type");
        SetOutput("platform_version");
        SetOutput("region");
        SetOutput("service");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("task_definition");
        SetOutput("wait_until_stable");
        SetOutput("wait_until_stable_timeout");
    }

    /// <summary>
    /// The cluster attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cluster is required")]
    public required TerraformProperty<string> Cluster
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cluster");
        set => SetProperty("cluster", value);
    }

    /// <summary>
    /// The external_id attribute.
    /// </summary>
    public TerraformProperty<string> ExternalId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("external_id");
        set => SetProperty("external_id", value);
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
    /// The platform_version attribute.
    /// </summary>
    public TerraformProperty<string> PlatformVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("platform_version");
        set => SetProperty("platform_version", value);
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
    /// The service attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    public required TerraformProperty<string> Service
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service");
        set => SetProperty("service", value);
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TaskDefinition is required")]
    public required TerraformProperty<string> TaskDefinition
    {
        get => GetRequiredOutput<TerraformProperty<string>>("task_definition");
        set => SetProperty("task_definition", value);
    }

    /// <summary>
    /// The wait_until_stable attribute.
    /// </summary>
    public TerraformProperty<bool> WaitUntilStable
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("wait_until_stable");
        set => SetProperty("wait_until_stable", value);
    }

    /// <summary>
    /// The wait_until_stable_timeout attribute.
    /// </summary>
    public TerraformProperty<string> WaitUntilStableTimeout
    {
        get => GetRequiredOutput<TerraformProperty<string>>("wait_until_stable_timeout");
        set => SetProperty("wait_until_stable_timeout", value);
    }

    /// <summary>
    /// Block for capacity_provider_strategy.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsEcsTaskSetCapacityProviderStrategyBlock>? CapacityProviderStrategy
    {
        set => SetProperty("capacity_provider_strategy", value);
    }

    /// <summary>
    /// Block for load_balancer.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsEcsTaskSetLoadBalancerBlock>? LoadBalancer
    {
        set => SetProperty("load_balancer", value);
    }

    /// <summary>
    /// Block for network_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfiguration block(s) allowed")]
    public List<AwsEcsTaskSetNetworkConfigurationBlock>? NetworkConfiguration
    {
        set => SetProperty("network_configuration", value);
    }

    /// <summary>
    /// Block for scale.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Scale block(s) allowed")]
    public List<AwsEcsTaskSetScaleBlock>? Scale
    {
        set => SetProperty("scale", value);
    }

    /// <summary>
    /// Block for service_registries.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceRegistries block(s) allowed")]
    public List<AwsEcsTaskSetServiceRegistriesBlock>? ServiceRegistries
    {
        set => SetProperty("service_registries", value);
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
