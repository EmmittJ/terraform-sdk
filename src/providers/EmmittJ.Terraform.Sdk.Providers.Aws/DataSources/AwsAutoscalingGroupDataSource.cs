using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_autoscaling_group.
/// </summary>
public class AwsAutoscalingGroupDataSource : TerraformDataSource
{
    public AwsAutoscalingGroupDataSource(string name) : base("aws_autoscaling_group", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    [TerraformPropertyName("availability_zones")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> AvailabilityZones => new TerraformReference(this, "availability_zones");

    /// <summary>
    /// The default_cooldown attribute.
    /// </summary>
    [TerraformPropertyName("default_cooldown")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> DefaultCooldown => new TerraformReference(this, "default_cooldown");

    /// <summary>
    /// The desired_capacity attribute.
    /// </summary>
    [TerraformPropertyName("desired_capacity")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> DesiredCapacity => new TerraformReference(this, "desired_capacity");

    /// <summary>
    /// The desired_capacity_type attribute.
    /// </summary>
    [TerraformPropertyName("desired_capacity_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DesiredCapacityType => new TerraformReference(this, "desired_capacity_type");

    /// <summary>
    /// The enabled_metrics attribute.
    /// </summary>
    [TerraformPropertyName("enabled_metrics")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> EnabledMetrics => new TerraformReference(this, "enabled_metrics");

    /// <summary>
    /// The health_check_grace_period attribute.
    /// </summary>
    [TerraformPropertyName("health_check_grace_period")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> HealthCheckGracePeriod => new TerraformReference(this, "health_check_grace_period");

    /// <summary>
    /// The health_check_type attribute.
    /// </summary>
    [TerraformPropertyName("health_check_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> HealthCheckType => new TerraformReference(this, "health_check_type");

    /// <summary>
    /// The instance_maintenance_policy attribute.
    /// </summary>
    [TerraformPropertyName("instance_maintenance_policy")]
    // Output-only attribute - read-only reference
    public TerraformList<object> InstanceMaintenancePolicy => new TerraformReference(this, "instance_maintenance_policy");

    /// <summary>
    /// The launch_configuration attribute.
    /// </summary>
    [TerraformPropertyName("launch_configuration")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LaunchConfiguration => new TerraformReference(this, "launch_configuration");

    /// <summary>
    /// The launch_template attribute.
    /// </summary>
    [TerraformPropertyName("launch_template")]
    // Output-only attribute - read-only reference
    public TerraformList<object> LaunchTemplate => new TerraformReference(this, "launch_template");

    /// <summary>
    /// The load_balancers attribute.
    /// </summary>
    [TerraformPropertyName("load_balancers")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> LoadBalancers => new TerraformReference(this, "load_balancers");

    /// <summary>
    /// The max_instance_lifetime attribute.
    /// </summary>
    [TerraformPropertyName("max_instance_lifetime")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> MaxInstanceLifetime => new TerraformReference(this, "max_instance_lifetime");

    /// <summary>
    /// The max_size attribute.
    /// </summary>
    [TerraformPropertyName("max_size")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> MaxSize => new TerraformReference(this, "max_size");

    /// <summary>
    /// The min_size attribute.
    /// </summary>
    [TerraformPropertyName("min_size")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> MinSize => new TerraformReference(this, "min_size");

    /// <summary>
    /// The mixed_instances_policy attribute.
    /// </summary>
    [TerraformPropertyName("mixed_instances_policy")]
    // Output-only attribute - read-only reference
    public TerraformList<object> MixedInstancesPolicy => new TerraformReference(this, "mixed_instances_policy");

    /// <summary>
    /// The new_instances_protected_from_scale_in attribute.
    /// </summary>
    [TerraformPropertyName("new_instances_protected_from_scale_in")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> NewInstancesProtectedFromScaleIn => new TerraformReference(this, "new_instances_protected_from_scale_in");

    /// <summary>
    /// The placement_group attribute.
    /// </summary>
    [TerraformPropertyName("placement_group")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PlacementGroup => new TerraformReference(this, "placement_group");

    /// <summary>
    /// The predicted_capacity attribute.
    /// </summary>
    [TerraformPropertyName("predicted_capacity")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> PredictedCapacity => new TerraformReference(this, "predicted_capacity");

    /// <summary>
    /// The service_linked_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("service_linked_role_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ServiceLinkedRoleArn => new TerraformReference(this, "service_linked_role_arn");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Status => new TerraformReference(this, "status");

    /// <summary>
    /// The suspended_processes attribute.
    /// </summary>
    [TerraformPropertyName("suspended_processes")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> SuspendedProcesses => new TerraformReference(this, "suspended_processes");

    /// <summary>
    /// The tag attribute.
    /// </summary>
    [TerraformPropertyName("tag")]
    // Output-only attribute - read-only reference
    public TerraformSet<object> Tag => new TerraformReference(this, "tag");

    /// <summary>
    /// The target_group_arns attribute.
    /// </summary>
    [TerraformPropertyName("target_group_arns")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> TargetGroupArns => new TerraformReference(this, "target_group_arns");

    /// <summary>
    /// The termination_policies attribute.
    /// </summary>
    [TerraformPropertyName("termination_policies")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> TerminationPolicies => new TerraformReference(this, "termination_policies");

    /// <summary>
    /// The traffic_source attribute.
    /// </summary>
    [TerraformPropertyName("traffic_source")]
    // Output-only attribute - read-only reference
    public TerraformSet<object> TrafficSource => new TerraformReference(this, "traffic_source");

    /// <summary>
    /// The vpc_zone_identifier attribute.
    /// </summary>
    [TerraformPropertyName("vpc_zone_identifier")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> VpcZoneIdentifier => new TerraformReference(this, "vpc_zone_identifier");

    /// <summary>
    /// The warm_pool attribute.
    /// </summary>
    [TerraformPropertyName("warm_pool")]
    // Output-only attribute - read-only reference
    public TerraformList<object> WarmPool => new TerraformReference(this, "warm_pool");

    /// <summary>
    /// The warm_pool_size attribute.
    /// </summary>
    [TerraformPropertyName("warm_pool_size")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> WarmPoolSize => new TerraformReference(this, "warm_pool_size");

}
