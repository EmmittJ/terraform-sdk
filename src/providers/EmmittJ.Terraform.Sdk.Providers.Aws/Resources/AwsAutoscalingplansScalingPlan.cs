using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for application_source in .
/// Nesting mode: list
/// </summary>
public partial class AwsAutoscalingplansScalingPlanApplicationSourceBlock : TerraformBlockBase
{
    /// <summary>
    /// The cloudformation_stack_arn attribute.
    /// </summary>
    [TerraformProperty("cloudformation_stack_arn")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CloudformationStackArn { get; set; }

}

/// <summary>
/// Block type for scaling_instruction in .
/// Nesting mode: set
/// </summary>
public partial class AwsAutoscalingplansScalingPlanScalingInstructionBlock : TerraformBlockBase
{
    /// <summary>
    /// The disable_dynamic_scaling attribute.
    /// </summary>
    [TerraformProperty("disable_dynamic_scaling")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? DisableDynamicScaling { get; set; }

    /// <summary>
    /// The max_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxCapacity is required")]
    [TerraformProperty("max_capacity")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> MaxCapacity { get; set; }

    /// <summary>
    /// The min_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinCapacity is required")]
    [TerraformProperty("min_capacity")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> MinCapacity { get; set; }

    /// <summary>
    /// The predictive_scaling_max_capacity_behavior attribute.
    /// </summary>
    [TerraformProperty("predictive_scaling_max_capacity_behavior")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PredictiveScalingMaxCapacityBehavior { get; set; }

    /// <summary>
    /// The predictive_scaling_max_capacity_buffer attribute.
    /// </summary>
    [TerraformProperty("predictive_scaling_max_capacity_buffer")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> PredictiveScalingMaxCapacityBuffer { get; set; }

    /// <summary>
    /// The predictive_scaling_mode attribute.
    /// </summary>
    [TerraformProperty("predictive_scaling_mode")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PredictiveScalingMode { get; set; }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceId is required")]
    [TerraformProperty("resource_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceId { get; set; }

    /// <summary>
    /// The scalable_dimension attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScalableDimension is required")]
    [TerraformProperty("scalable_dimension")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ScalableDimension { get; set; }

    /// <summary>
    /// The scaling_policy_update_behavior attribute.
    /// </summary>
    [TerraformProperty("scaling_policy_update_behavior")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ScalingPolicyUpdateBehavior { get; set; }

    /// <summary>
    /// The scheduled_action_buffer_time attribute.
    /// </summary>
    [TerraformProperty("scheduled_action_buffer_time")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? ScheduledActionBufferTime { get; set; }

    /// <summary>
    /// The service_namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceNamespace is required")]
    [TerraformProperty("service_namespace")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ServiceNamespace { get; set; }

}

/// <summary>
/// Manages a aws_autoscalingplans_scaling_plan resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsAutoscalingplansScalingPlan : TerraformResource
{
    public AwsAutoscalingplansScalingPlan(string name) : base("aws_autoscalingplans_scaling_plan", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for application_source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationSource is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ApplicationSource block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApplicationSource block(s) allowed")]
    [TerraformProperty("application_source")]
    public TerraformList<TerraformBlock<AwsAutoscalingplansScalingPlanApplicationSourceBlock>>? ApplicationSource { get; set; }

    /// <summary>
    /// Block for scaling_instruction.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScalingInstruction is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ScalingInstruction block(s) required")]
    [TerraformProperty("scaling_instruction")]
    public TerraformSet<TerraformBlock<AwsAutoscalingplansScalingPlanScalingInstructionBlock>>? ScalingInstruction { get; set; }

    /// <summary>
    /// The scaling_plan_version attribute.
    /// </summary>
    [TerraformProperty("scaling_plan_version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> ScalingPlanVersion { get; }

}
