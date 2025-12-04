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
        get => GetArgument<TerraformValue<string>>("cluster_arn");
        set => SetArgument("cluster_arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceName is required")]
    public required TerraformValue<string> ServiceName
    {
        get => GetArgument<TerraformValue<string>>("service_name");
        set => SetArgument("service_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The availability_zone_rebalancing attribute.
    /// </summary>
    public TerraformValue<string> AvailabilityZoneRebalancing
        => AsReference("availability_zone_rebalancing");

    /// <summary>
    /// The desired_count attribute.
    /// </summary>
    public TerraformValue<double> DesiredCount
        => AsReference("desired_count");

    /// <summary>
    /// The launch_type attribute.
    /// </summary>
    public TerraformValue<string> LaunchType
        => AsReference("launch_type");

    /// <summary>
    /// The load_balancer attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> LoadBalancer
        => AsReference("load_balancer");

    /// <summary>
    /// The scheduling_strategy attribute.
    /// </summary>
    public TerraformValue<string> SchedulingStrategy
        => AsReference("scheduling_strategy");

    /// <summary>
    /// The task_definition attribute.
    /// </summary>
    public TerraformValue<string> TaskDefinition
        => AsReference("task_definition");

}
