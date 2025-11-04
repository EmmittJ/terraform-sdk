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
    public HashSet<string>? AvailabilityZones
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("availability_zones")?.Value;
        set => this.WithProperty("availability_zones", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The capacity_rebalance attribute.
    /// </summary>
    public bool? CapacityRebalance
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("capacity_rebalance")?.Value;
        set => this.WithProperty("capacity_rebalance", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The context attribute.
    /// </summary>
    public string? Context
    {
        get => GetProperty<TerraformLiteralProperty<string>>("context")?.Value;
        set => this.WithProperty("context", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The default_cooldown attribute.
    /// </summary>
    public double? DefaultCooldown
    {
        get => GetProperty<TerraformLiteralProperty<double>>("default_cooldown")?.Value;
        set => this.WithProperty("default_cooldown", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The default_instance_warmup attribute.
    /// </summary>
    public double? DefaultInstanceWarmup
    {
        get => GetProperty<TerraformLiteralProperty<double>>("default_instance_warmup")?.Value;
        set => this.WithProperty("default_instance_warmup", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The desired_capacity attribute.
    /// </summary>
    public double? DesiredCapacity
    {
        get => GetProperty<TerraformLiteralProperty<double>>("desired_capacity")?.Value;
        set => this.WithProperty("desired_capacity", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The desired_capacity_type attribute.
    /// </summary>
    public string? DesiredCapacityType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("desired_capacity_type")?.Value;
        set => this.WithProperty("desired_capacity_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The enabled_metrics attribute.
    /// </summary>
    public HashSet<string>? EnabledMetrics
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("enabled_metrics")?.Value;
        set => this.WithProperty("enabled_metrics", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The force_delete attribute.
    /// </summary>
    public bool? ForceDelete
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("force_delete")?.Value;
        set => this.WithProperty("force_delete", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The force_delete_warm_pool attribute.
    /// </summary>
    public bool? ForceDeleteWarmPool
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("force_delete_warm_pool")?.Value;
        set => this.WithProperty("force_delete_warm_pool", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The health_check_grace_period attribute.
    /// </summary>
    public double? HealthCheckGracePeriod
    {
        get => GetProperty<TerraformLiteralProperty<double>>("health_check_grace_period")?.Value;
        set => this.WithProperty("health_check_grace_period", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The health_check_type attribute.
    /// </summary>
    public string? HealthCheckType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("health_check_type")?.Value;
        set => this.WithProperty("health_check_type", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The ignore_failed_scaling_activities attribute.
    /// </summary>
    public bool? IgnoreFailedScalingActivities
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("ignore_failed_scaling_activities")?.Value;
        set => this.WithProperty("ignore_failed_scaling_activities", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The launch_configuration attribute.
    /// </summary>
    public string? LaunchConfiguration
    {
        get => GetProperty<TerraformLiteralProperty<string>>("launch_configuration")?.Value;
        set => this.WithProperty("launch_configuration", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The load_balancers attribute.
    /// </summary>
    public HashSet<string>? LoadBalancers
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("load_balancers")?.Value;
        set => this.WithProperty("load_balancers", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The max_instance_lifetime attribute.
    /// </summary>
    public double? MaxInstanceLifetime
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_instance_lifetime")?.Value;
        set => this.WithProperty("max_instance_lifetime", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The max_size attribute.
    /// </summary>
    public double? MaxSize
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_size")?.Value;
        set => this.WithProperty("max_size", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The metrics_granularity attribute.
    /// </summary>
    public string? MetricsGranularity
    {
        get => GetProperty<TerraformLiteralProperty<string>>("metrics_granularity")?.Value;
        set => this.WithProperty("metrics_granularity", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The min_elb_capacity attribute.
    /// </summary>
    public double? MinElbCapacity
    {
        get => GetProperty<TerraformLiteralProperty<double>>("min_elb_capacity")?.Value;
        set => this.WithProperty("min_elb_capacity", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The min_size attribute.
    /// </summary>
    public double? MinSize
    {
        get => GetProperty<TerraformLiteralProperty<double>>("min_size")?.Value;
        set => this.WithProperty("min_size", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public string? NamePrefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name_prefix")?.Value;
        set => this.WithProperty("name_prefix", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The placement_group attribute.
    /// </summary>
    public string? PlacementGroup
    {
        get => GetProperty<TerraformLiteralProperty<string>>("placement_group")?.Value;
        set => this.WithProperty("placement_group", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The protect_from_scale_in attribute.
    /// </summary>
    public bool? ProtectFromScaleIn
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("protect_from_scale_in")?.Value;
        set => this.WithProperty("protect_from_scale_in", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The service_linked_role_arn attribute.
    /// </summary>
    public string? ServiceLinkedRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_linked_role_arn")?.Value;
        set => this.WithProperty("service_linked_role_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The suspended_processes attribute.
    /// </summary>
    public HashSet<string>? SuspendedProcesses
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("suspended_processes")?.Value;
        set => this.WithProperty("suspended_processes", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The target_group_arns attribute.
    /// </summary>
    public HashSet<string>? TargetGroupArns
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("target_group_arns")?.Value;
        set => this.WithProperty("target_group_arns", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The termination_policies attribute.
    /// </summary>
    public List<string>? TerminationPolicies
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("termination_policies")?.Value;
        set => this.WithProperty("termination_policies", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The vpc_zone_identifier attribute.
    /// </summary>
    public HashSet<string>? VpcZoneIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("vpc_zone_identifier")?.Value;
        set => this.WithProperty("vpc_zone_identifier", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The wait_for_capacity_timeout attribute.
    /// </summary>
    public string? WaitForCapacityTimeout
    {
        get => GetProperty<TerraformLiteralProperty<string>>("wait_for_capacity_timeout")?.Value;
        set => this.WithProperty("wait_for_capacity_timeout", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The wait_for_elb_capacity attribute.
    /// </summary>
    public double? WaitForElbCapacity
    {
        get => GetProperty<TerraformLiteralProperty<double>>("wait_for_elb_capacity")?.Value;
        set => this.WithProperty("wait_for_elb_capacity", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
