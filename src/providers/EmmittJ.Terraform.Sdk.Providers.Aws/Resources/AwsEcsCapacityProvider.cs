using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for auto_scaling_group_provider in .
/// Nesting mode: list
/// </summary>
public class AwsEcsCapacityProviderAutoScalingGroupProviderBlock : ITerraformBlock
{
    /// <summary>
    /// The auto_scaling_group_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutoScalingGroupArn is required")]
    [TerraformPropertyName("auto_scaling_group_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AutoScalingGroupArn { get; set; }

    /// <summary>
    /// The managed_draining attribute.
    /// </summary>
    [TerraformPropertyName("managed_draining")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ManagedDraining { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "managed_draining");

    /// <summary>
    /// The managed_termination_protection attribute.
    /// </summary>
    [TerraformPropertyName("managed_termination_protection")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ManagedTerminationProtection { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "managed_termination_protection");

}

/// <summary>
/// Block type for managed_instances_provider in .
/// Nesting mode: list
/// </summary>
public class AwsEcsCapacityProviderManagedInstancesProviderBlock : ITerraformBlock
{
    /// <summary>
    /// The infrastructure_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InfrastructureRoleArn is required")]
    [TerraformPropertyName("infrastructure_role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> InfrastructureRoleArn { get; set; }

    /// <summary>
    /// The propagate_tags attribute.
    /// </summary>
    [TerraformPropertyName("propagate_tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PropagateTags { get; set; }

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
    public TerraformProperty<TerraformProperty<string>>? Cluster { get; set; }

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
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// Block for auto_scaling_group_provider.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoScalingGroupProvider block(s) allowed")]
    [TerraformPropertyName("auto_scaling_group_provider")]
    public TerraformList<TerraformBlock<AwsEcsCapacityProviderAutoScalingGroupProviderBlock>>? AutoScalingGroupProvider { get; set; } = new();

    /// <summary>
    /// Block for managed_instances_provider.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManagedInstancesProvider block(s) allowed")]
    [TerraformPropertyName("managed_instances_provider")]
    public TerraformList<TerraformBlock<AwsEcsCapacityProviderManagedInstancesProviderBlock>>? ManagedInstancesProvider { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

}
