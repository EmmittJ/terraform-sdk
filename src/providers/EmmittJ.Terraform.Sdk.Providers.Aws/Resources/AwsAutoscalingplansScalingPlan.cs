using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for application_source in .
/// Nesting mode: list
/// </summary>
public class AwsAutoscalingplansScalingPlanApplicationSourceBlock
{
    /// <summary>
    /// The cloudformation_stack_arn attribute.
    /// </summary>
    [TerraformPropertyName("cloudformation_stack_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CloudformationStackArn { get; set; }

}

/// <summary>
/// Block type for scaling_instruction in .
/// Nesting mode: set
/// </summary>
public class AwsAutoscalingplansScalingPlanScalingInstructionBlock
{
    /// <summary>
    /// The disable_dynamic_scaling attribute.
    /// </summary>
    [TerraformPropertyName("disable_dynamic_scaling")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? DisableDynamicScaling { get; set; }

    /// <summary>
    /// The max_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxCapacity is required")]
    [TerraformPropertyName("max_capacity")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> MaxCapacity { get; set; }

    /// <summary>
    /// The min_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinCapacity is required")]
    [TerraformPropertyName("min_capacity")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> MinCapacity { get; set; }

    /// <summary>
    /// The predictive_scaling_max_capacity_behavior attribute.
    /// </summary>
    [TerraformPropertyName("predictive_scaling_max_capacity_behavior")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PredictiveScalingMaxCapacityBehavior { get; set; }

    /// <summary>
    /// The predictive_scaling_max_capacity_buffer attribute.
    /// </summary>
    [TerraformPropertyName("predictive_scaling_max_capacity_buffer")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> PredictiveScalingMaxCapacityBuffer { get; set; } = default!;

    /// <summary>
    /// The predictive_scaling_mode attribute.
    /// </summary>
    [TerraformPropertyName("predictive_scaling_mode")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PredictiveScalingMode { get; set; }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceId is required")]
    [TerraformPropertyName("resource_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceId { get; set; }

    /// <summary>
    /// The scalable_dimension attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScalableDimension is required")]
    [TerraformPropertyName("scalable_dimension")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ScalableDimension { get; set; }

    /// <summary>
    /// The scaling_policy_update_behavior attribute.
    /// </summary>
    [TerraformPropertyName("scaling_policy_update_behavior")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ScalingPolicyUpdateBehavior { get; set; }

    /// <summary>
    /// The scheduled_action_buffer_time attribute.
    /// </summary>
    [TerraformPropertyName("scheduled_action_buffer_time")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? ScheduledActionBufferTime { get; set; }

    /// <summary>
    /// The service_namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceNamespace is required")]
    [TerraformPropertyName("service_namespace")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ServiceNamespace { get; set; }

}

/// <summary>
/// Manages a aws_autoscalingplans_scaling_plan resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsAutoscalingplansScalingPlan : TerraformResource
{
    public AwsAutoscalingplansScalingPlan(string name) : base("aws_autoscalingplans_scaling_plan", name)
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
    /// Block for application_source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationSource is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ApplicationSource block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApplicationSource block(s) allowed")]
    [TerraformPropertyName("application_source")]
    public TerraformList<TerraformBlock<AwsAutoscalingplansScalingPlanApplicationSourceBlock>>? ApplicationSource { get; set; }

    /// <summary>
    /// Block for scaling_instruction.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScalingInstruction is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ScalingInstruction block(s) required")]
    [TerraformPropertyName("scaling_instruction")]
    public TerraformSet<TerraformBlock<AwsAutoscalingplansScalingPlanScalingInstructionBlock>>? ScalingInstruction { get; set; }

    /// <summary>
    /// The scaling_plan_version attribute.
    /// </summary>
    [TerraformPropertyName("scaling_plan_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> ScalingPlanVersion => new TerraformReference(this, "scaling_plan_version");

}
