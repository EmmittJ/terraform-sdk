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
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    public TerraformSet<string> AvailabilityZones
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "availability_zones").ResolveNodes(ctx));
    }

    /// <summary>
    /// The default_cooldown attribute.
    /// </summary>
    public TerraformValue<double> DefaultCooldown
    {
        get => new TerraformReference<double>(this, "default_cooldown");
    }

    /// <summary>
    /// The desired_capacity attribute.
    /// </summary>
    public TerraformValue<double> DesiredCapacity
    {
        get => new TerraformReference<double>(this, "desired_capacity");
    }

    /// <summary>
    /// The desired_capacity_type attribute.
    /// </summary>
    public TerraformValue<string> DesiredCapacityType
    {
        get => new TerraformReference<string>(this, "desired_capacity_type");
    }

    /// <summary>
    /// The enabled_metrics attribute.
    /// </summary>
    public TerraformSet<string> EnabledMetrics
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "enabled_metrics").ResolveNodes(ctx));
    }

    /// <summary>
    /// The health_check_grace_period attribute.
    /// </summary>
    public TerraformValue<double> HealthCheckGracePeriod
    {
        get => new TerraformReference<double>(this, "health_check_grace_period");
    }

    /// <summary>
    /// The health_check_type attribute.
    /// </summary>
    public TerraformValue<string> HealthCheckType
    {
        get => new TerraformReference<string>(this, "health_check_type");
    }

    /// <summary>
    /// The instance_maintenance_policy attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> InstanceMaintenancePolicy
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "instance_maintenance_policy").ResolveNodes(ctx));
    }

    /// <summary>
    /// The launch_configuration attribute.
    /// </summary>
    public TerraformValue<string> LaunchConfiguration
    {
        get => new TerraformReference<string>(this, "launch_configuration");
    }

    /// <summary>
    /// The launch_template attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> LaunchTemplate
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "launch_template").ResolveNodes(ctx));
    }

    /// <summary>
    /// The load_balancers attribute.
    /// </summary>
    public TerraformSet<string> LoadBalancers
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "load_balancers").ResolveNodes(ctx));
    }

    /// <summary>
    /// The max_instance_lifetime attribute.
    /// </summary>
    public TerraformValue<double> MaxInstanceLifetime
    {
        get => new TerraformReference<double>(this, "max_instance_lifetime");
    }

    /// <summary>
    /// The max_size attribute.
    /// </summary>
    public TerraformValue<double> MaxSize
    {
        get => new TerraformReference<double>(this, "max_size");
    }

    /// <summary>
    /// The min_size attribute.
    /// </summary>
    public TerraformValue<double> MinSize
    {
        get => new TerraformReference<double>(this, "min_size");
    }

    /// <summary>
    /// The mixed_instances_policy attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> MixedInstancesPolicy
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "mixed_instances_policy").ResolveNodes(ctx));
    }

    /// <summary>
    /// The new_instances_protected_from_scale_in attribute.
    /// </summary>
    public TerraformValue<bool> NewInstancesProtectedFromScaleIn
    {
        get => new TerraformReference<bool>(this, "new_instances_protected_from_scale_in");
    }

    /// <summary>
    /// The placement_group attribute.
    /// </summary>
    public TerraformValue<string> PlacementGroup
    {
        get => new TerraformReference<string>(this, "placement_group");
    }

    /// <summary>
    /// The predicted_capacity attribute.
    /// </summary>
    public TerraformValue<double> PredictedCapacity
    {
        get => new TerraformReference<double>(this, "predicted_capacity");
    }

    /// <summary>
    /// The service_linked_role_arn attribute.
    /// </summary>
    public TerraformValue<string> ServiceLinkedRoleArn
    {
        get => new TerraformReference<string>(this, "service_linked_role_arn");
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

    /// <summary>
    /// The suspended_processes attribute.
    /// </summary>
    public TerraformSet<string> SuspendedProcesses
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "suspended_processes").ResolveNodes(ctx));
    }

    /// <summary>
    /// The tag attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> Tag
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "tag").ResolveNodes(ctx));
    }

    /// <summary>
    /// The target_group_arns attribute.
    /// </summary>
    public TerraformSet<string> TargetGroupArns
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "target_group_arns").ResolveNodes(ctx));
    }

    /// <summary>
    /// The termination_policies attribute.
    /// </summary>
    public TerraformSet<string> TerminationPolicies
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "termination_policies").ResolveNodes(ctx));
    }

    /// <summary>
    /// The traffic_source attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> TrafficSource
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "traffic_source").ResolveNodes(ctx));
    }

    /// <summary>
    /// The vpc_zone_identifier attribute.
    /// </summary>
    public TerraformValue<string> VpcZoneIdentifier
    {
        get => new TerraformReference<string>(this, "vpc_zone_identifier");
    }

    /// <summary>
    /// The warm_pool attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> WarmPool
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "warm_pool").ResolveNodes(ctx));
    }

    /// <summary>
    /// The warm_pool_size attribute.
    /// </summary>
    public TerraformValue<double> WarmPoolSize
    {
        get => new TerraformReference<double>(this, "warm_pool_size");
    }

}
