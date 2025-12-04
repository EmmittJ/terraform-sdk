using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_autoscaling_group Terraform data source.
/// Retrieves information about a aws_autoscaling_group.
/// </summary>
public partial class AwsAutoscalingGroupDataSource(string name) : TerraformDataSource("aws_autoscaling_group", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    public TerraformSet<string> AvailabilityZones
        => AsReference("availability_zones");

    /// <summary>
    /// The default_cooldown attribute.
    /// </summary>
    public TerraformValue<double> DefaultCooldown
        => AsReference("default_cooldown");

    /// <summary>
    /// The desired_capacity attribute.
    /// </summary>
    public TerraformValue<double> DesiredCapacity
        => AsReference("desired_capacity");

    /// <summary>
    /// The desired_capacity_type attribute.
    /// </summary>
    public TerraformValue<string> DesiredCapacityType
        => AsReference("desired_capacity_type");

    /// <summary>
    /// The enabled_metrics attribute.
    /// </summary>
    public TerraformSet<string> EnabledMetrics
        => AsReference("enabled_metrics");

    /// <summary>
    /// The health_check_grace_period attribute.
    /// </summary>
    public TerraformValue<double> HealthCheckGracePeriod
        => AsReference("health_check_grace_period");

    /// <summary>
    /// The health_check_type attribute.
    /// </summary>
    public TerraformValue<string> HealthCheckType
        => AsReference("health_check_type");

    /// <summary>
    /// The instance_maintenance_policy attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> InstanceMaintenancePolicy
        => AsReference("instance_maintenance_policy");

    /// <summary>
    /// The launch_configuration attribute.
    /// </summary>
    public TerraformValue<string> LaunchConfiguration
        => AsReference("launch_configuration");

    /// <summary>
    /// The launch_template attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> LaunchTemplate
        => AsReference("launch_template");

    /// <summary>
    /// The load_balancers attribute.
    /// </summary>
    public TerraformSet<string> LoadBalancers
        => AsReference("load_balancers");

    /// <summary>
    /// The max_instance_lifetime attribute.
    /// </summary>
    public TerraformValue<double> MaxInstanceLifetime
        => AsReference("max_instance_lifetime");

    /// <summary>
    /// The max_size attribute.
    /// </summary>
    public TerraformValue<double> MaxSize
        => AsReference("max_size");

    /// <summary>
    /// The min_size attribute.
    /// </summary>
    public TerraformValue<double> MinSize
        => AsReference("min_size");

    /// <summary>
    /// The mixed_instances_policy attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> MixedInstancesPolicy
        => AsReference("mixed_instances_policy");

    /// <summary>
    /// The new_instances_protected_from_scale_in attribute.
    /// </summary>
    public TerraformValue<bool> NewInstancesProtectedFromScaleIn
        => AsReference("new_instances_protected_from_scale_in");

    /// <summary>
    /// The placement_group attribute.
    /// </summary>
    public TerraformValue<string> PlacementGroup
        => AsReference("placement_group");

    /// <summary>
    /// The predicted_capacity attribute.
    /// </summary>
    public TerraformValue<double> PredictedCapacity
        => AsReference("predicted_capacity");

    /// <summary>
    /// The service_linked_role_arn attribute.
    /// </summary>
    public TerraformValue<string> ServiceLinkedRoleArn
        => AsReference("service_linked_role_arn");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => AsReference("status");

    /// <summary>
    /// The suspended_processes attribute.
    /// </summary>
    public TerraformSet<string> SuspendedProcesses
        => AsReference("suspended_processes");

    /// <summary>
    /// The tag attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> Tag
        => AsReference("tag");

    /// <summary>
    /// The target_group_arns attribute.
    /// </summary>
    public TerraformSet<string> TargetGroupArns
        => AsReference("target_group_arns");

    /// <summary>
    /// The termination_policies attribute.
    /// </summary>
    public TerraformSet<string> TerminationPolicies
        => AsReference("termination_policies");

    /// <summary>
    /// The traffic_source attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> TrafficSource
        => AsReference("traffic_source");

    /// <summary>
    /// The vpc_zone_identifier attribute.
    /// </summary>
    public TerraformValue<string> VpcZoneIdentifier
        => AsReference("vpc_zone_identifier");

    /// <summary>
    /// The warm_pool attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> WarmPool
        => AsReference("warm_pool");

    /// <summary>
    /// The warm_pool_size attribute.
    /// </summary>
    public TerraformValue<double> WarmPoolSize
        => AsReference("warm_pool_size");

}
