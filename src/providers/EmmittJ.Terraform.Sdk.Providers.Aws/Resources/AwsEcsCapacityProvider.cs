using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for auto_scaling_group_provider in .
/// Nesting mode: list
/// </summary>
public class AwsEcsCapacityProviderAutoScalingGroupProviderBlock
{
    /// <summary>
    /// The auto_scaling_group_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutoScalingGroupArn is required")]
    [TerraformPropertyName("auto_scaling_group_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AutoScalingGroupArn { get; set; }

    /// <summary>
    /// The managed_draining attribute.
    /// </summary>
    [TerraformPropertyName("managed_draining")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ManagedDraining { get; set; } = default!;

    /// <summary>
    /// The managed_termination_protection attribute.
    /// </summary>
    [TerraformPropertyName("managed_termination_protection")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ManagedTerminationProtection { get; set; } = default!;

}

/// <summary>
/// Block type for managed_instances_provider in .
/// Nesting mode: list
/// </summary>
public class AwsEcsCapacityProviderManagedInstancesProviderBlock
{
    /// <summary>
    /// The infrastructure_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InfrastructureRoleArn is required")]
    [TerraformPropertyName("infrastructure_role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> InfrastructureRoleArn { get; set; }

    /// <summary>
    /// The propagate_tags attribute.
    /// </summary>
    [TerraformPropertyName("propagate_tags")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PropagateTags { get; set; }

}

/// <summary>
/// Manages a aws_ecs_capacity_provider resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsEcsCapacityProvider : TerraformResource
{
    public AwsEcsCapacityProvider(string name) : base("aws_ecs_capacity_provider", name)
    {
    }

    /// <summary>
    /// The cluster attribute.
    /// </summary>
    [TerraformPropertyName("cluster")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Cluster { get; set; }

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
    /// Block for auto_scaling_group_provider.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoScalingGroupProvider block(s) allowed")]
    [TerraformPropertyName("auto_scaling_group_provider")]
    public TerraformList<TerraformBlock<AwsEcsCapacityProviderAutoScalingGroupProviderBlock>>? AutoScalingGroupProvider { get; set; }

    /// <summary>
    /// Block for managed_instances_provider.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManagedInstancesProvider block(s) allowed")]
    [TerraformPropertyName("managed_instances_provider")]
    public TerraformList<TerraformBlock<AwsEcsCapacityProviderManagedInstancesProviderBlock>>? ManagedInstancesProvider { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

}
