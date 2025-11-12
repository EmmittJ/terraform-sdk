using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for suspended_state in .
/// Nesting mode: list
/// </summary>
public partial class AwsAppautoscalingTargetSuspendedStateBlock() : TerraformBlock("suspended_state")
{
    /// <summary>
    /// The dynamic_scaling_in_suspended attribute.
    /// </summary>
    [TerraformProperty("dynamic_scaling_in_suspended")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DynamicScalingInSuspended { get; set; }

    /// <summary>
    /// The dynamic_scaling_out_suspended attribute.
    /// </summary>
    [TerraformProperty("dynamic_scaling_out_suspended")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DynamicScalingOutSuspended { get; set; }

    /// <summary>
    /// The scheduled_scaling_suspended attribute.
    /// </summary>
    [TerraformProperty("scheduled_scaling_suspended")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ScheduledScalingSuspended { get; set; }

}

/// <summary>
/// Manages a aws_appautoscaling_target resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsAppautoscalingTarget : TerraformResource
{
    public AwsAppautoscalingTarget(string name) : base("aws_appautoscaling_target", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The max_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxCapacity is required")]
    [TerraformProperty("max_capacity")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> MaxCapacity { get; set; }

    /// <summary>
    /// The min_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinCapacity is required")]
    [TerraformProperty("min_capacity")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> MinCapacity { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceId is required")]
    [TerraformProperty("resource_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceId { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [TerraformProperty("role_arn")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> RoleArn { get; set; }

    /// <summary>
    /// The scalable_dimension attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScalableDimension is required")]
    [TerraformProperty("scalable_dimension")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ScalableDimension { get; set; }

    /// <summary>
    /// The service_namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceNamespace is required")]
    [TerraformProperty("service_namespace")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ServiceNamespace { get; set; }

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
    /// Block for suspended_state.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SuspendedState block(s) allowed")]
    [TerraformProperty("suspended_state")]
    public TerraformList<AwsAppautoscalingTargetSuspendedStateBlock> SuspendedState { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

}
