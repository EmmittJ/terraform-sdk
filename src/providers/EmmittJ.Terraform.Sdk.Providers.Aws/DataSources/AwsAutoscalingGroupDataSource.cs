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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    [TerraformPropertyName("availability_zones")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> AvailabilityZones => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "availability_zones");

    /// <summary>
    /// The default_cooldown attribute.
    /// </summary>
    [TerraformPropertyName("default_cooldown")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> DefaultCooldown => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "default_cooldown");

    /// <summary>
    /// The desired_capacity attribute.
    /// </summary>
    [TerraformPropertyName("desired_capacity")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> DesiredCapacity => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "desired_capacity");

    /// <summary>
    /// The desired_capacity_type attribute.
    /// </summary>
    [TerraformPropertyName("desired_capacity_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DesiredCapacityType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "desired_capacity_type");

    /// <summary>
    /// The enabled_metrics attribute.
    /// </summary>
    [TerraformPropertyName("enabled_metrics")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> EnabledMetrics => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "enabled_metrics");

    /// <summary>
    /// The health_check_grace_period attribute.
    /// </summary>
    [TerraformPropertyName("health_check_grace_period")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> HealthCheckGracePeriod => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "health_check_grace_period");

    /// <summary>
    /// The health_check_type attribute.
    /// </summary>
    [TerraformPropertyName("health_check_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> HealthCheckType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "health_check_type");

    /// <summary>
    /// The instance_maintenance_policy attribute.
    /// </summary>
    [TerraformPropertyName("instance_maintenance_policy")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> InstanceMaintenancePolicy => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "instance_maintenance_policy");

    /// <summary>
    /// The launch_configuration attribute.
    /// </summary>
    [TerraformPropertyName("launch_configuration")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LaunchConfiguration => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "launch_configuration");

    /// <summary>
    /// The launch_template attribute.
    /// </summary>
    [TerraformPropertyName("launch_template")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> LaunchTemplate => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "launch_template");

    /// <summary>
    /// The load_balancers attribute.
    /// </summary>
    [TerraformPropertyName("load_balancers")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> LoadBalancers => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "load_balancers");

    /// <summary>
    /// The max_instance_lifetime attribute.
    /// </summary>
    [TerraformPropertyName("max_instance_lifetime")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MaxInstanceLifetime => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "max_instance_lifetime");

    /// <summary>
    /// The max_size attribute.
    /// </summary>
    [TerraformPropertyName("max_size")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MaxSize => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "max_size");

    /// <summary>
    /// The min_size attribute.
    /// </summary>
    [TerraformPropertyName("min_size")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MinSize => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "min_size");

    /// <summary>
    /// The mixed_instances_policy attribute.
    /// </summary>
    [TerraformPropertyName("mixed_instances_policy")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> MixedInstancesPolicy => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "mixed_instances_policy");

    /// <summary>
    /// The new_instances_protected_from_scale_in attribute.
    /// </summary>
    [TerraformPropertyName("new_instances_protected_from_scale_in")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> NewInstancesProtectedFromScaleIn => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "new_instances_protected_from_scale_in");

    /// <summary>
    /// The placement_group attribute.
    /// </summary>
    [TerraformPropertyName("placement_group")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PlacementGroup => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "placement_group");

    /// <summary>
    /// The predicted_capacity attribute.
    /// </summary>
    [TerraformPropertyName("predicted_capacity")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> PredictedCapacity => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "predicted_capacity");

    /// <summary>
    /// The service_linked_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("service_linked_role_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ServiceLinkedRoleArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "service_linked_role_arn");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Status => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

    /// <summary>
    /// The suspended_processes attribute.
    /// </summary>
    [TerraformPropertyName("suspended_processes")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> SuspendedProcesses => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "suspended_processes");

    /// <summary>
    /// The tag attribute.
    /// </summary>
    [TerraformPropertyName("tag")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> Tag => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "tag");

    /// <summary>
    /// The target_group_arns attribute.
    /// </summary>
    [TerraformPropertyName("target_group_arns")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> TargetGroupArns => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "target_group_arns");

    /// <summary>
    /// The termination_policies attribute.
    /// </summary>
    [TerraformPropertyName("termination_policies")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> TerminationPolicies => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "termination_policies");

    /// <summary>
    /// The traffic_source attribute.
    /// </summary>
    [TerraformPropertyName("traffic_source")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> TrafficSource => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "traffic_source");

    /// <summary>
    /// The vpc_zone_identifier attribute.
    /// </summary>
    [TerraformPropertyName("vpc_zone_identifier")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VpcZoneIdentifier => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "vpc_zone_identifier");

    /// <summary>
    /// The warm_pool attribute.
    /// </summary>
    [TerraformPropertyName("warm_pool")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> WarmPool => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "warm_pool");

    /// <summary>
    /// The warm_pool_size attribute.
    /// </summary>
    [TerraformPropertyName("warm_pool_size")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> WarmPoolSize => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "warm_pool_size");

}
