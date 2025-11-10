using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_autoscaling_group.
/// </summary>
public class AwsAutoscalingGroupDataSource : TerraformDataSource
{
    public AwsAutoscalingGroupDataSource(string name) : base("aws_autoscaling_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("availability_zones");
        SetOutput("default_cooldown");
        SetOutput("desired_capacity");
        SetOutput("desired_capacity_type");
        SetOutput("enabled_metrics");
        SetOutput("health_check_grace_period");
        SetOutput("health_check_type");
        SetOutput("instance_maintenance_policy");
        SetOutput("launch_configuration");
        SetOutput("launch_template");
        SetOutput("load_balancers");
        SetOutput("max_instance_lifetime");
        SetOutput("max_size");
        SetOutput("min_size");
        SetOutput("mixed_instances_policy");
        SetOutput("new_instances_protected_from_scale_in");
        SetOutput("placement_group");
        SetOutput("predicted_capacity");
        SetOutput("service_linked_role_arn");
        SetOutput("status");
        SetOutput("suspended_processes");
        SetOutput("tag");
        SetOutput("target_group_arns");
        SetOutput("termination_policies");
        SetOutput("traffic_source");
        SetOutput("vpc_zone_identifier");
        SetOutput("warm_pool");
        SetOutput("warm_pool_size");
        SetOutput("id");
        SetOutput("name");
        SetOutput("region");
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    public TerraformExpression AvailabilityZones => this["availability_zones"];

    /// <summary>
    /// The default_cooldown attribute.
    /// </summary>
    public TerraformExpression DefaultCooldown => this["default_cooldown"];

    /// <summary>
    /// The desired_capacity attribute.
    /// </summary>
    public TerraformExpression DesiredCapacity => this["desired_capacity"];

    /// <summary>
    /// The desired_capacity_type attribute.
    /// </summary>
    public TerraformExpression DesiredCapacityType => this["desired_capacity_type"];

    /// <summary>
    /// The enabled_metrics attribute.
    /// </summary>
    public TerraformExpression EnabledMetrics => this["enabled_metrics"];

    /// <summary>
    /// The health_check_grace_period attribute.
    /// </summary>
    public TerraformExpression HealthCheckGracePeriod => this["health_check_grace_period"];

    /// <summary>
    /// The health_check_type attribute.
    /// </summary>
    public TerraformExpression HealthCheckType => this["health_check_type"];

    /// <summary>
    /// The instance_maintenance_policy attribute.
    /// </summary>
    public TerraformExpression InstanceMaintenancePolicy => this["instance_maintenance_policy"];

    /// <summary>
    /// The launch_configuration attribute.
    /// </summary>
    public TerraformExpression LaunchConfiguration => this["launch_configuration"];

    /// <summary>
    /// The launch_template attribute.
    /// </summary>
    public TerraformExpression LaunchTemplate => this["launch_template"];

    /// <summary>
    /// The load_balancers attribute.
    /// </summary>
    public TerraformExpression LoadBalancers => this["load_balancers"];

    /// <summary>
    /// The max_instance_lifetime attribute.
    /// </summary>
    public TerraformExpression MaxInstanceLifetime => this["max_instance_lifetime"];

    /// <summary>
    /// The max_size attribute.
    /// </summary>
    public TerraformExpression MaxSize => this["max_size"];

    /// <summary>
    /// The min_size attribute.
    /// </summary>
    public TerraformExpression MinSize => this["min_size"];

    /// <summary>
    /// The mixed_instances_policy attribute.
    /// </summary>
    public TerraformExpression MixedInstancesPolicy => this["mixed_instances_policy"];

    /// <summary>
    /// The new_instances_protected_from_scale_in attribute.
    /// </summary>
    public TerraformExpression NewInstancesProtectedFromScaleIn => this["new_instances_protected_from_scale_in"];

    /// <summary>
    /// The placement_group attribute.
    /// </summary>
    public TerraformExpression PlacementGroup => this["placement_group"];

    /// <summary>
    /// The predicted_capacity attribute.
    /// </summary>
    public TerraformExpression PredictedCapacity => this["predicted_capacity"];

    /// <summary>
    /// The service_linked_role_arn attribute.
    /// </summary>
    public TerraformExpression ServiceLinkedRoleArn => this["service_linked_role_arn"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The suspended_processes attribute.
    /// </summary>
    public TerraformExpression SuspendedProcesses => this["suspended_processes"];

    /// <summary>
    /// The tag attribute.
    /// </summary>
    public TerraformExpression Tag => this["tag"];

    /// <summary>
    /// The target_group_arns attribute.
    /// </summary>
    public TerraformExpression TargetGroupArns => this["target_group_arns"];

    /// <summary>
    /// The termination_policies attribute.
    /// </summary>
    public TerraformExpression TerminationPolicies => this["termination_policies"];

    /// <summary>
    /// The traffic_source attribute.
    /// </summary>
    public TerraformExpression TrafficSource => this["traffic_source"];

    /// <summary>
    /// The vpc_zone_identifier attribute.
    /// </summary>
    public TerraformExpression VpcZoneIdentifier => this["vpc_zone_identifier"];

    /// <summary>
    /// The warm_pool attribute.
    /// </summary>
    public TerraformExpression WarmPool => this["warm_pool"];

    /// <summary>
    /// The warm_pool_size attribute.
    /// </summary>
    public TerraformExpression WarmPoolSize => this["warm_pool_size"];

}
