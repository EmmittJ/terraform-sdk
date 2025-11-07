using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_autoscaling_group resource.
/// </summary>
public class AwsAutoscalingGroup : TerraformResource
{
    public AwsAutoscalingGroup(string name) : base("aws_autoscaling_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("predicted_capacity");
        this.DeclareOutput("warm_pool_size");
    }

    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? AvailabilityZones
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("availability_zones");
        set => this.WithProperty("availability_zones", value);
    }

    /// <summary>
    /// The capacity_rebalance attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? CapacityRebalance
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("capacity_rebalance");
        set => this.WithProperty("capacity_rebalance", value);
    }

    /// <summary>
    /// The context attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Context
    {
        get => GetProperty<TerraformLiteralProperty<string>>("context");
        set => this.WithProperty("context", value);
    }

    /// <summary>
    /// The default_cooldown attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? DefaultCooldown
    {
        get => GetProperty<TerraformLiteralProperty<double>>("default_cooldown");
        set => this.WithProperty("default_cooldown", value);
    }

    /// <summary>
    /// The default_instance_warmup attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? DefaultInstanceWarmup
    {
        get => GetProperty<TerraformLiteralProperty<double>>("default_instance_warmup");
        set => this.WithProperty("default_instance_warmup", value);
    }

    /// <summary>
    /// The desired_capacity attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? DesiredCapacity
    {
        get => GetProperty<TerraformLiteralProperty<double>>("desired_capacity");
        set => this.WithProperty("desired_capacity", value);
    }

    /// <summary>
    /// The desired_capacity_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DesiredCapacityType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("desired_capacity_type");
        set => this.WithProperty("desired_capacity_type", value);
    }

    /// <summary>
    /// The enabled_metrics attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? EnabledMetrics
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("enabled_metrics");
        set => this.WithProperty("enabled_metrics", value);
    }

    /// <summary>
    /// The force_delete attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? ForceDelete
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("force_delete");
        set => this.WithProperty("force_delete", value);
    }

    /// <summary>
    /// The force_delete_warm_pool attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? ForceDeleteWarmPool
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("force_delete_warm_pool");
        set => this.WithProperty("force_delete_warm_pool", value);
    }

    /// <summary>
    /// The health_check_grace_period attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? HealthCheckGracePeriod
    {
        get => GetProperty<TerraformLiteralProperty<double>>("health_check_grace_period");
        set => this.WithProperty("health_check_grace_period", value);
    }

    /// <summary>
    /// The health_check_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? HealthCheckType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("health_check_type");
        set => this.WithProperty("health_check_type", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The ignore_failed_scaling_activities attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? IgnoreFailedScalingActivities
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("ignore_failed_scaling_activities");
        set => this.WithProperty("ignore_failed_scaling_activities", value);
    }

    /// <summary>
    /// The launch_configuration attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? LaunchConfiguration
    {
        get => GetProperty<TerraformLiteralProperty<string>>("launch_configuration");
        set => this.WithProperty("launch_configuration", value);
    }

    /// <summary>
    /// The load_balancers attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? LoadBalancers
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("load_balancers");
        set => this.WithProperty("load_balancers", value);
    }

    /// <summary>
    /// The max_instance_lifetime attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? MaxInstanceLifetime
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_instance_lifetime");
        set => this.WithProperty("max_instance_lifetime", value);
    }

    /// <summary>
    /// The max_size attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? MaxSize
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_size");
        set => this.WithProperty("max_size", value);
    }

    /// <summary>
    /// The metrics_granularity attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? MetricsGranularity
    {
        get => GetProperty<TerraformLiteralProperty<string>>("metrics_granularity");
        set => this.WithProperty("metrics_granularity", value);
    }

    /// <summary>
    /// The min_elb_capacity attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? MinElbCapacity
    {
        get => GetProperty<TerraformLiteralProperty<double>>("min_elb_capacity");
        set => this.WithProperty("min_elb_capacity", value);
    }

    /// <summary>
    /// The min_size attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? MinSize
    {
        get => GetProperty<TerraformLiteralProperty<double>>("min_size");
        set => this.WithProperty("min_size", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? NamePrefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name_prefix");
        set => this.WithProperty("name_prefix", value);
    }

    /// <summary>
    /// The placement_group attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PlacementGroup
    {
        get => GetProperty<TerraformLiteralProperty<string>>("placement_group");
        set => this.WithProperty("placement_group", value);
    }

    /// <summary>
    /// The protect_from_scale_in attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? ProtectFromScaleIn
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("protect_from_scale_in");
        set => this.WithProperty("protect_from_scale_in", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The service_linked_role_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ServiceLinkedRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_linked_role_arn");
        set => this.WithProperty("service_linked_role_arn", value);
    }

    /// <summary>
    /// The suspended_processes attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? SuspendedProcesses
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("suspended_processes");
        set => this.WithProperty("suspended_processes", value);
    }

    /// <summary>
    /// The target_group_arns attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? TargetGroupArns
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("target_group_arns");
        set => this.WithProperty("target_group_arns", value);
    }

    /// <summary>
    /// The termination_policies attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? TerminationPolicies
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("termination_policies");
        set => this.WithProperty("termination_policies", value);
    }

    /// <summary>
    /// The vpc_zone_identifier attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? VpcZoneIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("vpc_zone_identifier");
        set => this.WithProperty("vpc_zone_identifier", value);
    }

    /// <summary>
    /// The wait_for_capacity_timeout attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? WaitForCapacityTimeout
    {
        get => GetProperty<TerraformLiteralProperty<string>>("wait_for_capacity_timeout");
        set => this.WithProperty("wait_for_capacity_timeout", value);
    }

    /// <summary>
    /// The wait_for_elb_capacity attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? WaitForElbCapacity
    {
        get => GetProperty<TerraformLiteralProperty<double>>("wait_for_elb_capacity");
        set => this.WithProperty("wait_for_elb_capacity", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The predicted_capacity attribute.
    /// </summary>
    public TerraformExpression PredictedCapacity => this["predicted_capacity"];

    /// <summary>
    /// The warm_pool_size attribute.
    /// </summary>
    public TerraformExpression WarmPoolSize => this["warm_pool_size"];

}
