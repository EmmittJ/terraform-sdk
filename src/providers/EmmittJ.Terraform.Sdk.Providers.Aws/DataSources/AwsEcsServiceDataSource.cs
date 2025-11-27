using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_ecs_service Terraform data source.
/// Retrieves information about a aws_ecs_service.
/// </summary>
public partial class AwsEcsServiceDataSource(string name) : TerraformDataSource("aws_ecs_service", name)
{
    /// <summary>
    /// The cluster_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterArn is required")]
    public required TerraformValue<string> ClusterArn
    {
        get => new TerraformReference<string>(this, "cluster_arn");
        set => SetArgument("cluster_arn", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceName is required")]
    public required TerraformValue<string> ServiceName
    {
        get => new TerraformReference<string>(this, "service_name");
        set => SetArgument("service_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The availability_zone_rebalancing attribute.
    /// </summary>
    public TerraformValue<string> AvailabilityZoneRebalancing
    {
        get => new TerraformReference<string>(this, "availability_zone_rebalancing");
    }

    /// <summary>
    /// The desired_count attribute.
    /// </summary>
    public TerraformValue<double> DesiredCount
    {
        get => new TerraformReference<double>(this, "desired_count");
    }

    /// <summary>
    /// The launch_type attribute.
    /// </summary>
    public TerraformValue<string> LaunchType
    {
        get => new TerraformReference<string>(this, "launch_type");
    }

    /// <summary>
    /// The load_balancer attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> LoadBalancer
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "load_balancer").ResolveNodes(ctx));
    }

    /// <summary>
    /// The scheduling_strategy attribute.
    /// </summary>
    public TerraformValue<string> SchedulingStrategy
    {
        get => new TerraformReference<string>(this, "scheduling_strategy");
    }

    /// <summary>
    /// The task_definition attribute.
    /// </summary>
    public TerraformValue<string> TaskDefinition
    {
        get => new TerraformReference<string>(this, "task_definition");
    }

}
