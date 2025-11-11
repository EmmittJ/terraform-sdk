using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for capacity_provider_strategy in .
/// Nesting mode: set
/// </summary>
public class AwsEcsTaskSetCapacityProviderStrategyBlock
{
    /// <summary>
    /// The base attribute.
    /// </summary>
    [TerraformPropertyName("base")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? Base { get; set; }

    /// <summary>
    /// The capacity_provider attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CapacityProvider is required")]
    [TerraformPropertyName("capacity_provider")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> CapacityProvider { get; set; }

    /// <summary>
    /// The weight attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Weight is required")]
    [TerraformPropertyName("weight")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> Weight { get; set; }

}

/// <summary>
/// Block type for load_balancer in .
/// Nesting mode: set
/// </summary>
public class AwsEcsTaskSetLoadBalancerBlock
{
    /// <summary>
    /// The container_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerName is required")]
    [TerraformPropertyName("container_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ContainerName { get; set; }

    /// <summary>
    /// The container_port attribute.
    /// </summary>
    [TerraformPropertyName("container_port")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? ContainerPort { get; set; }

    /// <summary>
    /// The load_balancer_name attribute.
    /// </summary>
    [TerraformPropertyName("load_balancer_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? LoadBalancerName { get; set; }

    /// <summary>
    /// The target_group_arn attribute.
    /// </summary>
    [TerraformPropertyName("target_group_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TargetGroupArn { get; set; }

}

/// <summary>
/// Block type for network_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsEcsTaskSetNetworkConfigurationBlock
{
    /// <summary>
    /// The assign_public_ip attribute.
    /// </summary>
    [TerraformPropertyName("assign_public_ip")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AssignPublicIp { get; set; }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    [TerraformPropertyName("security_groups")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? SecurityGroups { get; set; }

    /// <summary>
    /// The subnets attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Subnets is required")]
    [TerraformPropertyName("subnets")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> Subnets { get; set; }

}

/// <summary>
/// Block type for scale in .
/// Nesting mode: list
/// </summary>
public class AwsEcsTaskSetScaleBlock
{
    /// <summary>
    /// The unit attribute.
    /// </summary>
    [TerraformPropertyName("unit")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Unit { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [TerraformPropertyName("value")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? Value { get; set; }

}

/// <summary>
/// Block type for service_registries in .
/// Nesting mode: list
/// </summary>
public class AwsEcsTaskSetServiceRegistriesBlock
{
    /// <summary>
    /// The container_name attribute.
    /// </summary>
    [TerraformPropertyName("container_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ContainerName { get; set; }

    /// <summary>
    /// The container_port attribute.
    /// </summary>
    [TerraformPropertyName("container_port")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? ContainerPort { get; set; }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformPropertyName("port")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? Port { get; set; }

    /// <summary>
    /// The registry_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RegistryArn is required")]
    [TerraformPropertyName("registry_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RegistryArn { get; set; }

}

/// <summary>
/// Manages a aws_ecs_task_set resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsEcsTaskSet : TerraformResource
{
    public AwsEcsTaskSet(string name) : base("aws_ecs_task_set", name)
    {
    }

    /// <summary>
    /// The cluster attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cluster is required")]
    [TerraformPropertyName("cluster")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Cluster { get; set; }

    /// <summary>
    /// The external_id attribute.
    /// </summary>
    [TerraformPropertyName("external_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ExternalId { get; set; } = default!;

    /// <summary>
    /// The force_delete attribute.
    /// </summary>
    [TerraformPropertyName("force_delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ForceDelete { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The launch_type attribute.
    /// </summary>
    [TerraformPropertyName("launch_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> LaunchType { get; set; } = default!;

    /// <summary>
    /// The platform_version attribute.
    /// </summary>
    [TerraformPropertyName("platform_version")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> PlatformVersion { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The service attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    [TerraformPropertyName("service")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Service { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// The task_definition attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TaskDefinition is required")]
    [TerraformPropertyName("task_definition")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> TaskDefinition { get; set; }

    /// <summary>
    /// The wait_until_stable attribute.
    /// </summary>
    [TerraformPropertyName("wait_until_stable")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? WaitUntilStable { get; set; }

    /// <summary>
    /// The wait_until_stable_timeout attribute.
    /// </summary>
    [TerraformPropertyName("wait_until_stable_timeout")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? WaitUntilStableTimeout { get; set; }

    /// <summary>
    /// Block for capacity_provider_strategy.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("capacity_provider_strategy")]
    public TerraformSet<TerraformBlock<AwsEcsTaskSetCapacityProviderStrategyBlock>>? CapacityProviderStrategy { get; set; }

    /// <summary>
    /// Block for load_balancer.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("load_balancer")]
    public TerraformSet<TerraformBlock<AwsEcsTaskSetLoadBalancerBlock>>? LoadBalancer { get; set; }

    /// <summary>
    /// Block for network_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfiguration block(s) allowed")]
    [TerraformPropertyName("network_configuration")]
    public TerraformList<TerraformBlock<AwsEcsTaskSetNetworkConfigurationBlock>>? NetworkConfiguration { get; set; }

    /// <summary>
    /// Block for scale.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Scale block(s) allowed")]
    [TerraformPropertyName("scale")]
    public TerraformList<TerraformBlock<AwsEcsTaskSetScaleBlock>>? Scale { get; set; }

    /// <summary>
    /// Block for service_registries.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceRegistries block(s) allowed")]
    [TerraformPropertyName("service_registries")]
    public TerraformList<TerraformBlock<AwsEcsTaskSetServiceRegistriesBlock>>? ServiceRegistries { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The stability_status attribute.
    /// </summary>
    [TerraformPropertyName("stability_status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> StabilityStatus => new TerraformReference(this, "stability_status");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Status => new TerraformReference(this, "status");

    /// <summary>
    /// The task_set_id attribute.
    /// </summary>
    [TerraformPropertyName("task_set_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TaskSetId => new TerraformReference(this, "task_set_id");

}
