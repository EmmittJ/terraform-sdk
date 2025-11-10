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
        this.WithOutput("arn");
        this.WithOutput("availability_zone_rebalancing");
        this.WithOutput("desired_count");
        this.WithOutput("launch_type");
        this.WithOutput("load_balancer");
        this.WithOutput("scheduling_strategy");
        this.WithOutput("task_definition");
    }

    /// <summary>
    /// The cluster_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterArn is required")]
    public required TerraformProperty<string> ClusterArn
    {
        get => GetRequiredProperty<TerraformProperty<string>>("cluster_arn");
        set => this.WithProperty("cluster_arn", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceName is required")]
    public required TerraformProperty<string> ServiceName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("service_name");
        set => this.WithProperty("service_name", value);
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
