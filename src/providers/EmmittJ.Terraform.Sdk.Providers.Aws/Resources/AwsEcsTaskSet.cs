using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for capacity_provider_strategy in AwsEcsTaskSet.
/// Nesting mode: set
/// </summary>
public class AwsEcsTaskSetCapacityProviderStrategyBlock : TerraformBlock
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Weight is required")]
    public required TerraformValue<double> Weight
    {
        get => new TerraformReference<double>(this, "weight");
        set => SetArgument("weight", value);
    }

}


/// <summary>
/// Block type for load_balancer in AwsEcsTaskSet.
/// Nesting mode: set
/// </summary>
public class AwsEcsTaskSetLoadBalancerBlock : TerraformBlock
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
    public TerraformValue<double>? ContainerPort
    {
        get => new TerraformReference<double>(this, "container_port");
        set => SetArgument("container_port", value);
    }

    /// <summary>
    /// The load_balancer_name attribute.
    /// </summary>
    public TerraformValue<string>? LoadBalancerName
    {
        get => new TerraformReference<string>(this, "load_balancer_name");
        set => SetArgument("load_balancer_name", value);
    }

    /// <summary>
    /// The target_group_arn attribute.
    /// </summary>
    public TerraformValue<string>? TargetGroupArn
    {
        get => new TerraformReference<string>(this, "target_group_arn");
        set => SetArgument("target_group_arn", value);
    }

}


/// <summary>
/// Block type for network_configuration in AwsEcsTaskSet.
/// Nesting mode: list
/// </summary>
public class AwsEcsTaskSetNetworkConfigurationBlock : TerraformBlock
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
/// Block type for scale in AwsEcsTaskSet.
/// Nesting mode: list
/// </summary>
public class AwsEcsTaskSetScaleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "scale";

    /// <summary>
    /// The unit attribute.
    /// </summary>
    public TerraformValue<string>? Unit
    {
        get => new TerraformReference<string>(this, "unit");
        set => SetArgument("unit", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformValue<double>? Value
    {
        get => new TerraformReference<double>(this, "value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for service_registries in AwsEcsTaskSet.
/// Nesting mode: list
/// </summary>
public class AwsEcsTaskSetServiceRegistriesBlock : TerraformBlock
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
/// Represents a aws_ecs_task_set Terraform resource.
/// Manages a aws_ecs_task_set resource.
/// </summary>
public partial class AwsEcsTaskSet(string name) : TerraformResource("aws_ecs_task_set", name)
{
    /// <summary>
    /// The cluster attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cluster is required")]
    public required TerraformValue<string> Cluster
    {
        get => new TerraformReference<string>(this, "cluster");
        set => SetArgument("cluster", value);
    }

    /// <summary>
    /// The external_id attribute.
    /// </summary>
    public TerraformValue<string> ExternalId
    {
        get => new TerraformReference<string>(this, "external_id");
        set => SetArgument("external_id", value);
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
    /// The platform_version attribute.
    /// </summary>
    public TerraformValue<string> PlatformVersion
    {
        get => new TerraformReference<string>(this, "platform_version");
        set => SetArgument("platform_version", value);
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
    /// The service attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    public required TerraformValue<string> Service
    {
        get => new TerraformReference<string>(this, "service");
        set => SetArgument("service", value);
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TaskDefinition is required")]
    public required TerraformValue<string> TaskDefinition
    {
        get => new TerraformReference<string>(this, "task_definition");
        set => SetArgument("task_definition", value);
    }

    /// <summary>
    /// The wait_until_stable attribute.
    /// </summary>
    public TerraformValue<bool>? WaitUntilStable
    {
        get => new TerraformReference<bool>(this, "wait_until_stable");
        set => SetArgument("wait_until_stable", value);
    }

    /// <summary>
    /// The wait_until_stable_timeout attribute.
    /// </summary>
    public TerraformValue<string>? WaitUntilStableTimeout
    {
        get => new TerraformReference<string>(this, "wait_until_stable_timeout");
        set => SetArgument("wait_until_stable_timeout", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The stability_status attribute.
    /// </summary>
    public TerraformValue<string> StabilityStatus
    {
        get => new TerraformReference<string>(this, "stability_status");
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

    /// <summary>
    /// The task_set_id attribute.
    /// </summary>
    public TerraformValue<string> TaskSetId
    {
        get => new TerraformReference<string>(this, "task_set_id");
    }

    /// <summary>
    /// CapacityProviderStrategy block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsEcsTaskSetCapacityProviderStrategyBlock>? CapacityProviderStrategy
    {
        get => GetArgument<TerraformSet<AwsEcsTaskSetCapacityProviderStrategyBlock>>("capacity_provider_strategy");
        set => SetArgument("capacity_provider_strategy", value);
    }

    /// <summary>
    /// LoadBalancer block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsEcsTaskSetLoadBalancerBlock>? LoadBalancer
    {
        get => GetArgument<TerraformSet<AwsEcsTaskSetLoadBalancerBlock>>("load_balancer");
        set => SetArgument("load_balancer", value);
    }

    /// <summary>
    /// NetworkConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfiguration block(s) allowed")]
    public TerraformList<AwsEcsTaskSetNetworkConfigurationBlock>? NetworkConfiguration
    {
        get => GetArgument<TerraformList<AwsEcsTaskSetNetworkConfigurationBlock>>("network_configuration");
        set => SetArgument("network_configuration", value);
    }

    /// <summary>
    /// Scale block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Scale block(s) allowed")]
    public TerraformList<AwsEcsTaskSetScaleBlock>? Scale
    {
        get => GetArgument<TerraformList<AwsEcsTaskSetScaleBlock>>("scale");
        set => SetArgument("scale", value);
    }

    /// <summary>
    /// ServiceRegistries block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceRegistries block(s) allowed")]
    public TerraformList<AwsEcsTaskSetServiceRegistriesBlock>? ServiceRegistries
    {
        get => GetArgument<TerraformList<AwsEcsTaskSetServiceRegistriesBlock>>("service_registries");
        set => SetArgument("service_registries", value);
    }

}
