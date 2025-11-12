using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for auto_scaling_group_provider in .
/// Nesting mode: list
/// </summary>
public partial class AwsEcsCapacityProviderAutoScalingGroupProviderBlock() : TerraformBlock("auto_scaling_group_provider")
{
    /// <summary>
    /// The auto_scaling_group_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutoScalingGroupArn is required")]
    [TerraformProperty("auto_scaling_group_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AutoScalingGroupArn { get; set; }

    /// <summary>
    /// The managed_draining attribute.
    /// </summary>
    [TerraformProperty("managed_draining")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ManagedDraining { get; set; }

    /// <summary>
    /// The managed_termination_protection attribute.
    /// </summary>
    [TerraformProperty("managed_termination_protection")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ManagedTerminationProtection { get; set; }

}

/// <summary>
/// Block type for managed_instances_provider in .
/// Nesting mode: list
/// </summary>
public partial class AwsEcsCapacityProviderManagedInstancesProviderBlock() : TerraformBlock("managed_instances_provider")
{
    /// <summary>
    /// The infrastructure_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InfrastructureRoleArn is required")]
    [TerraformProperty("infrastructure_role_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> InfrastructureRoleArn { get; set; }

    /// <summary>
    /// The propagate_tags attribute.
    /// </summary>
    [TerraformProperty("propagate_tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PropagateTags { get; set; }

}

/// <summary>
/// Manages a aws_ecs_capacity_provider resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsEcsCapacityProvider : TerraformResource
{
    public AwsEcsCapacityProvider(string name) : base("aws_ecs_capacity_provider", name)
    {
    }

    /// <summary>
    /// The cluster attribute.
    /// </summary>
    [TerraformProperty("cluster")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Cluster { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for auto_scaling_group_provider.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoScalingGroupProvider block(s) allowed")]
    [TerraformProperty("auto_scaling_group_provider")]
    public TerraformList<AwsEcsCapacityProviderAutoScalingGroupProviderBlock> AutoScalingGroupProvider { get; set; } = new();

    /// <summary>
    /// Block for managed_instances_provider.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManagedInstancesProvider block(s) allowed")]
    [TerraformProperty("managed_instances_provider")]
    public TerraformList<AwsEcsCapacityProviderManagedInstancesProviderBlock> ManagedInstancesProvider { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

}
