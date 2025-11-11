using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for capacity_provider_strategy in .
/// Nesting mode: set
/// </summary>
public partial class AwsEcsTaskSetCapacityProviderStrategyBlock : TerraformBlockBase
{
    /// <summary>
    /// The base attribute.
    /// </summary>
    [TerraformProperty("base")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? Base { get; set; }

    /// <summary>
    /// The capacity_provider attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CapacityProvider is required")]
    [TerraformProperty("capacity_provider")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> CapacityProvider { get; set; }

    /// <summary>
    /// The weight attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Weight is required")]
    [TerraformProperty("weight")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> Weight { get; set; }

}

/// <summary>
/// Block type for load_balancer in .
/// Nesting mode: set
/// </summary>
public partial class AwsEcsTaskSetLoadBalancerBlock : TerraformBlockBase
{
    /// <summary>
    /// The container_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerName is required")]
    [TerraformProperty("container_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ContainerName { get; set; }

    /// <summary>
    /// The container_port attribute.
    /// </summary>
    [TerraformProperty("container_port")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? ContainerPort { get; set; }

    /// <summary>
    /// The load_balancer_name attribute.
    /// </summary>
    [TerraformProperty("load_balancer_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? LoadBalancerName { get; set; }

    /// <summary>
    /// The target_group_arn attribute.
    /// </summary>
    [TerraformProperty("target_group_arn")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? TargetGroupArn { get; set; }

}

/// <summary>
/// Block type for network_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsEcsTaskSetNetworkConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The assign_public_ip attribute.
    /// </summary>
    [TerraformProperty("assign_public_ip")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? AssignPublicIp { get; set; }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    [TerraformProperty("security_groups")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? SecurityGroups { get; set; }

    /// <summary>
    /// The subnets attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Subnets is required")]
    [TerraformProperty("subnets")]
    // Required argument - source generator will implement get/set
    public required TerraformSet<string> Subnets { get; set; }

}

/// <summary>
/// Block type for scale in .
/// Nesting mode: list
/// </summary>
public partial class AwsEcsTaskSetScaleBlock : TerraformBlockBase
{
    /// <summary>
    /// The unit attribute.
    /// </summary>
    [TerraformProperty("unit")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Unit { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [TerraformProperty("value")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? Value { get; set; }

}

/// <summary>
/// Block type for service_registries in .
/// Nesting mode: list
/// </summary>
public partial class AwsEcsTaskSetServiceRegistriesBlock : TerraformBlockBase
{
    /// <summary>
    /// The container_name attribute.
    /// </summary>
    [TerraformProperty("container_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ContainerName { get; set; }

    /// <summary>
    /// The container_port attribute.
    /// </summary>
    [TerraformProperty("container_port")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? ContainerPort { get; set; }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformProperty("port")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? Port { get; set; }

    /// <summary>
    /// The registry_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RegistryArn is required")]
    [TerraformProperty("registry_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> RegistryArn { get; set; }

}

/// <summary>
/// Manages a aws_ecs_task_set resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsEcsTaskSet : TerraformResource
{
    public AwsEcsTaskSet(string name) : base("aws_ecs_task_set", name)
    {
    }

    /// <summary>
    /// The cluster attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cluster is required")]
    [TerraformProperty("cluster")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Cluster { get; set; }

    /// <summary>
    /// The external_id attribute.
    /// </summary>
    [TerraformProperty("external_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ExternalId { get; set; }

    /// <summary>
    /// The force_delete attribute.
    /// </summary>
    [TerraformProperty("force_delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? ForceDelete { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The launch_type attribute.
    /// </summary>
    [TerraformProperty("launch_type")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> LaunchType { get; set; }

    /// <summary>
    /// The platform_version attribute.
    /// </summary>
    [TerraformProperty("platform_version")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> PlatformVersion { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The service attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    [TerraformProperty("service")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Service { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The task_definition attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TaskDefinition is required")]
    [TerraformProperty("task_definition")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> TaskDefinition { get; set; }

    /// <summary>
    /// The wait_until_stable attribute.
    /// </summary>
    [TerraformProperty("wait_until_stable")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? WaitUntilStable { get; set; }

    /// <summary>
    /// The wait_until_stable_timeout attribute.
    /// </summary>
    [TerraformProperty("wait_until_stable_timeout")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? WaitUntilStableTimeout { get; set; }

    /// <summary>
    /// Block for capacity_provider_strategy.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("capacity_provider_strategy")]
    public TerraformSet<TerraformBlock<AwsEcsTaskSetCapacityProviderStrategyBlock>>? CapacityProviderStrategy { get; set; }

    /// <summary>
    /// Block for load_balancer.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("load_balancer")]
    public TerraformSet<TerraformBlock<AwsEcsTaskSetLoadBalancerBlock>>? LoadBalancer { get; set; }

    /// <summary>
    /// Block for network_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfiguration block(s) allowed")]
    [TerraformProperty("network_configuration")]
    public TerraformList<TerraformBlock<AwsEcsTaskSetNetworkConfigurationBlock>>? NetworkConfiguration { get; set; }

    /// <summary>
    /// Block for scale.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Scale block(s) allowed")]
    [TerraformProperty("scale")]
    public TerraformList<TerraformBlock<AwsEcsTaskSetScaleBlock>>? Scale { get; set; }

    /// <summary>
    /// Block for service_registries.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceRegistries block(s) allowed")]
    [TerraformProperty("service_registries")]
    public TerraformList<TerraformBlock<AwsEcsTaskSetServiceRegistriesBlock>>? ServiceRegistries { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The stability_status attribute.
    /// </summary>
    [TerraformProperty("stability_status")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> StabilityStatus { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Status { get; }

    /// <summary>
    /// The task_set_id attribute.
    /// </summary>
    [TerraformProperty("task_set_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> TaskSetId { get; }

}
