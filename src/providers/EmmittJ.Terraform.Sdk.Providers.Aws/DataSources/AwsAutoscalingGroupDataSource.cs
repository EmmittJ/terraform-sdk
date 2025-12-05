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
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    public TerraformSet<string> AvailabilityZones
        => CreateReference("availability_zones");

    /// <summary>
    /// The default_cooldown attribute.
    /// </summary>
    public TerraformValue<double> DefaultCooldown
        => CreateReference("default_cooldown");

    /// <summary>
    /// The desired_capacity attribute.
    /// </summary>
    public TerraformValue<double> DesiredCapacity
        => CreateReference("desired_capacity");

    /// <summary>
    /// The desired_capacity_type attribute.
    /// </summary>
    public TerraformValue<string> DesiredCapacityType
        => CreateReference("desired_capacity_type");

    /// <summary>
    /// The enabled_metrics attribute.
    /// </summary>
    public TerraformSet<string> EnabledMetrics
        => CreateReference("enabled_metrics");

    /// <summary>
    /// The health_check_grace_period attribute.
    /// </summary>
    public TerraformValue<double> HealthCheckGracePeriod
        => CreateReference("health_check_grace_period");

    /// <summary>
    /// The health_check_type attribute.
    /// </summary>
    public TerraformValue<string> HealthCheckType
        => CreateReference("health_check_type");

    /// <summary>
    /// The instance_maintenance_policy attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> InstanceMaintenancePolicy
        => CreateReference("instance_maintenance_policy");

    /// <summary>
    /// The launch_configuration attribute.
    /// </summary>
    public TerraformValue<string> LaunchConfiguration
        => CreateReference("launch_configuration");

    /// <summary>
    /// The launch_template attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> LaunchTemplate
        => CreateReference("launch_template");

    /// <summary>
    /// The load_balancers attribute.
    /// </summary>
    public TerraformSet<string> LoadBalancers
        => CreateReference("load_balancers");

    /// <summary>
    /// The max_instance_lifetime attribute.
    /// </summary>
    public TerraformValue<double> MaxInstanceLifetime
        => CreateReference("max_instance_lifetime");

    /// <summary>
    /// The max_size attribute.
    /// </summary>
    public TerraformValue<double> MaxSize
        => CreateReference("max_size");

    /// <summary>
    /// The min_size attribute.
    /// </summary>
    public TerraformValue<double> MinSize
        => CreateReference("min_size");

    /// <summary>
    /// The mixed_instances_policy attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> MixedInstancesPolicy
        => CreateReference("mixed_instances_policy");

    /// <summary>
    /// The new_instances_protected_from_scale_in attribute.
    /// </summary>
    public TerraformValue<bool> NewInstancesProtectedFromScaleIn
        => CreateReference("new_instances_protected_from_scale_in");

    /// <summary>
    /// The placement_group attribute.
    /// </summary>
    public TerraformValue<string> PlacementGroup
        => CreateReference("placement_group");

    /// <summary>
    /// The predicted_capacity attribute.
    /// </summary>
    public TerraformValue<double> PredictedCapacity
        => CreateReference("predicted_capacity");

    /// <summary>
    /// The service_linked_role_arn attribute.
    /// </summary>
    public TerraformValue<string> ServiceLinkedRoleArn
        => CreateReference("service_linked_role_arn");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => CreateReference("status");

    /// <summary>
    /// The suspended_processes attribute.
    /// </summary>
    public TerraformSet<string> SuspendedProcesses
        => CreateReference("suspended_processes");

    /// <summary>
    /// The tag attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> Tag
        => CreateReference("tag");

    /// <summary>
    /// The target_group_arns attribute.
    /// </summary>
    public TerraformSet<string> TargetGroupArns
        => CreateReference("target_group_arns");

    /// <summary>
    /// The termination_policies attribute.
    /// </summary>
    public TerraformSet<string> TerminationPolicies
        => CreateReference("termination_policies");

    /// <summary>
    /// The traffic_source attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> TrafficSource
        => CreateReference("traffic_source");

    /// <summary>
    /// The vpc_zone_identifier attribute.
    /// </summary>
    public TerraformValue<string> VpcZoneIdentifier
        => CreateReference("vpc_zone_identifier");

    /// <summary>
    /// The warm_pool attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> WarmPool
        => CreateReference("warm_pool");

    /// <summary>
    /// The warm_pool_size attribute.
    /// </summary>
    public TerraformValue<double> WarmPoolSize
        => CreateReference("warm_pool_size");

}
