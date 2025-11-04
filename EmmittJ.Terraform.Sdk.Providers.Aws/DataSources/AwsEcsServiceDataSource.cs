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
        this.DeclareOutput("arn");
        this.DeclareOutput("availability_zone_rebalancing");
        this.DeclareOutput("desired_count");
        this.DeclareOutput("launch_type");
        this.DeclareOutput("load_balancer");
        this.DeclareOutput("scheduling_strategy");
        this.DeclareOutput("task_definition");
    }

    /// <summary>
    /// The cluster_arn attribute.
    /// </summary>
    public string? ClusterArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cluster_arn")?.Value;
        set => this.WithProperty("cluster_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The service_name attribute.
    /// </summary>
    public string? ServiceName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_name")?.Value;
        set => this.WithProperty("service_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
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
