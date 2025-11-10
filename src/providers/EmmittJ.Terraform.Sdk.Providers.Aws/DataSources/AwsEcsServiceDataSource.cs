using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ecs_service.
/// </summary>
public class AwsEcsServiceDataSource : TerraformDataSource
{
    public AwsEcsServiceDataSource(string name) : base("aws_ecs_service", name)
    {
    }

    /// <summary>
    /// The cluster_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterArn is required")]
    [TerraformPropertyName("cluster_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ClusterArn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceName is required")]
    [TerraformPropertyName("service_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ServiceName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The availability_zone_rebalancing attribute.
    /// </summary>
    [TerraformPropertyName("availability_zone_rebalancing")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AvailabilityZoneRebalancing => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "availability_zone_rebalancing");

    /// <summary>
    /// The desired_count attribute.
    /// </summary>
    [TerraformPropertyName("desired_count")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> DesiredCount => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "desired_count");

    /// <summary>
    /// The launch_type attribute.
    /// </summary>
    [TerraformPropertyName("launch_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LaunchType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "launch_type");

    /// <summary>
    /// The load_balancer attribute.
    /// </summary>
    [TerraformPropertyName("load_balancer")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> LoadBalancer => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "load_balancer");

    /// <summary>
    /// The scheduling_strategy attribute.
    /// </summary>
    [TerraformPropertyName("scheduling_strategy")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SchedulingStrategy => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "scheduling_strategy");

    /// <summary>
    /// The task_definition attribute.
    /// </summary>
    [TerraformPropertyName("task_definition")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TaskDefinition => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "task_definition");

}
