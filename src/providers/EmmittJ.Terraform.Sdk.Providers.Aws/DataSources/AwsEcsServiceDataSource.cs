using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ecs_service.
/// </summary>
public class AwsEcsServiceDataSource : TerraformDataSource
{
    public AwsEcsServiceDataSource(string name) : base("aws_ecs_service", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("availability_zone_rebalancing");
        SetOutput("desired_count");
        SetOutput("launch_type");
        SetOutput("load_balancer");
        SetOutput("scheduling_strategy");
        SetOutput("task_definition");
        SetOutput("cluster_arn");
        SetOutput("id");
        SetOutput("region");
        SetOutput("service_name");
        SetOutput("tags");
    }

    /// <summary>
    /// The cluster_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterArn is required")]
    public required TerraformProperty<string> ClusterArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cluster_arn");
        set => SetProperty("cluster_arn", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceName is required")]
    public required TerraformProperty<string> ServiceName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service_name");
        set => SetProperty("service_name", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The availability_zone_rebalancing attribute.
    /// </summary>
    public TerraformExpression AvailabilityZoneRebalancing => this["availability_zone_rebalancing"];

    /// <summary>
    /// The desired_count attribute.
    /// </summary>
    public TerraformExpression DesiredCount => this["desired_count"];

    /// <summary>
    /// The launch_type attribute.
    /// </summary>
    public TerraformExpression LaunchType => this["launch_type"];

    /// <summary>
    /// The load_balancer attribute.
    /// </summary>
    public TerraformExpression LoadBalancer => this["load_balancer"];

    /// <summary>
    /// The scheduling_strategy attribute.
    /// </summary>
    public TerraformExpression SchedulingStrategy => this["scheduling_strategy"];

    /// <summary>
    /// The task_definition attribute.
    /// </summary>
    public TerraformExpression TaskDefinition => this["task_definition"];

}
