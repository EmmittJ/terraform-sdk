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
    public TerraformProperty<HashSet<string>>? AvailabilityZones
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("availability_zones");
        set => this.WithProperty("availability_zones", value);
    }

    /// <summary>
    /// The capacity_rebalance attribute.
    /// </summary>
    public TerraformProperty<bool>? CapacityRebalance
    {
        get => GetProperty<TerraformProperty<bool>>("capacity_rebalance");
        set => this.WithProperty("capacity_rebalance", value);
    }

    /// <summary>
    /// The context attribute.
    /// </summary>
    public TerraformProperty<string>? Context
    {
        get => GetProperty<TerraformProperty<string>>("context");
        set => this.WithProperty("context", value);
    }

    /// <summary>
    /// The default_cooldown attribute.
    /// </summary>
    public TerraformProperty<double>? DefaultCooldown
    {
        get => GetProperty<TerraformProperty<double>>("default_cooldown");
        set => this.WithProperty("default_cooldown", value);
    }

    /// <summary>
    /// The default_instance_warmup attribute.
    /// </summary>
    public TerraformProperty<double>? DefaultInstanceWarmup
    {
        get => GetProperty<TerraformProperty<double>>("default_instance_warmup");
        set => this.WithProperty("default_instance_warmup", value);
    }

    /// <summary>
    /// The desired_capacity attribute.
    /// </summary>
    public TerraformProperty<double>? DesiredCapacity
    {
        get => GetProperty<TerraformProperty<double>>("desired_capacity");
        set => this.WithProperty("desired_capacity", value);
    }

    /// <summary>
    /// The desired_capacity_type attribute.
    /// </summary>
    public TerraformProperty<string>? DesiredCapacityType
    {
        get => GetProperty<TerraformProperty<string>>("desired_capacity_type");
        set => this.WithProperty("desired_capacity_type", value);
    }

    /// <summary>
    /// The enabled_metrics attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? EnabledMetrics
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("enabled_metrics");
        set => this.WithProperty("enabled_metrics", value);
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
    /// The force_delete_warm_pool attribute.
    /// </summary>
    public TerraformProperty<bool>? ForceDeleteWarmPool
    {
        get => GetProperty<TerraformProperty<bool>>("force_delete_warm_pool");
        set => this.WithProperty("force_delete_warm_pool", value);
    }

    /// <summary>
    /// The health_check_grace_period attribute.
    /// </summary>
    public TerraformProperty<double>? HealthCheckGracePeriod
    {
        get => GetProperty<TerraformProperty<double>>("health_check_grace_period");
        set => this.WithProperty("health_check_grace_period", value);
    }

    /// <summary>
    /// The health_check_type attribute.
    /// </summary>
    public TerraformProperty<string>? HealthCheckType
    {
        get => GetProperty<TerraformProperty<string>>("health_check_type");
        set => this.WithProperty("health_check_type", value);
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
    /// The ignore_failed_scaling_activities attribute.
    /// </summary>
    public TerraformProperty<bool>? IgnoreFailedScalingActivities
    {
        get => GetProperty<TerraformProperty<bool>>("ignore_failed_scaling_activities");
        set => this.WithProperty("ignore_failed_scaling_activities", value);
    }

    /// <summary>
    /// The launch_configuration attribute.
    /// </summary>
    public TerraformProperty<string>? LaunchConfiguration
    {
        get => GetProperty<TerraformProperty<string>>("launch_configuration");
        set => this.WithProperty("launch_configuration", value);
    }

    /// <summary>
    /// The load_balancers attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? LoadBalancers
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("load_balancers");
        set => this.WithProperty("load_balancers", value);
    }

    /// <summary>
    /// The max_instance_lifetime attribute.
    /// </summary>
    public TerraformProperty<double>? MaxInstanceLifetime
    {
        get => GetProperty<TerraformProperty<double>>("max_instance_lifetime");
        set => this.WithProperty("max_instance_lifetime", value);
    }

    /// <summary>
    /// The max_size attribute.
    /// </summary>
    public TerraformProperty<double>? MaxSize
    {
        get => GetProperty<TerraformProperty<double>>("max_size");
        set => this.WithProperty("max_size", value);
    }

    /// <summary>
    /// The metrics_granularity attribute.
    /// </summary>
    public TerraformProperty<string>? MetricsGranularity
    {
        get => GetProperty<TerraformProperty<string>>("metrics_granularity");
        set => this.WithProperty("metrics_granularity", value);
    }

    /// <summary>
    /// The min_elb_capacity attribute.
    /// </summary>
    public TerraformProperty<double>? MinElbCapacity
    {
        get => GetProperty<TerraformProperty<double>>("min_elb_capacity");
        set => this.WithProperty("min_elb_capacity", value);
    }

    /// <summary>
    /// The min_size attribute.
    /// </summary>
    public TerraformProperty<double>? MinSize
    {
        get => GetProperty<TerraformProperty<double>>("min_size");
        set => this.WithProperty("min_size", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? NamePrefix
    {
        get => GetProperty<TerraformProperty<string>>("name_prefix");
        set => this.WithProperty("name_prefix", value);
    }

    /// <summary>
    /// The placement_group attribute.
    /// </summary>
    public TerraformProperty<string>? PlacementGroup
    {
        get => GetProperty<TerraformProperty<string>>("placement_group");
        set => this.WithProperty("placement_group", value);
    }

    /// <summary>
    /// The protect_from_scale_in attribute.
    /// </summary>
    public TerraformProperty<bool>? ProtectFromScaleIn
    {
        get => GetProperty<TerraformProperty<bool>>("protect_from_scale_in");
        set => this.WithProperty("protect_from_scale_in", value);
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
    /// The service_linked_role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? ServiceLinkedRoleArn
    {
        get => GetProperty<TerraformProperty<string>>("service_linked_role_arn");
        set => this.WithProperty("service_linked_role_arn", value);
    }

    /// <summary>
    /// The suspended_processes attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? SuspendedProcesses
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("suspended_processes");
        set => this.WithProperty("suspended_processes", value);
    }

    /// <summary>
    /// The target_group_arns attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? TargetGroupArns
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("target_group_arns");
        set => this.WithProperty("target_group_arns", value);
    }

    /// <summary>
    /// The termination_policies attribute.
    /// </summary>
    public TerraformProperty<List<string>>? TerminationPolicies
    {
        get => GetProperty<TerraformProperty<List<string>>>("termination_policies");
        set => this.WithProperty("termination_policies", value);
    }

    /// <summary>
    /// The vpc_zone_identifier attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? VpcZoneIdentifier
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("vpc_zone_identifier");
        set => this.WithProperty("vpc_zone_identifier", value);
    }

    /// <summary>
    /// The wait_for_capacity_timeout attribute.
    /// </summary>
    public TerraformProperty<string>? WaitForCapacityTimeout
    {
        get => GetProperty<TerraformProperty<string>>("wait_for_capacity_timeout");
        set => this.WithProperty("wait_for_capacity_timeout", value);
    }

    /// <summary>
    /// The wait_for_elb_capacity attribute.
    /// </summary>
    public TerraformProperty<double>? WaitForElbCapacity
    {
        get => GetProperty<TerraformProperty<double>>("wait_for_elb_capacity");
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
