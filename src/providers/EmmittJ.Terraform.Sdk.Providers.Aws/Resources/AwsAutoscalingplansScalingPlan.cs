using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for application_source in .
/// Nesting mode: list
/// </summary>
public class AwsAutoscalingplansScalingPlanApplicationSourceBlock : TerraformBlock
{
    /// <summary>
    /// The cloudformation_stack_arn attribute.
    /// </summary>
    public TerraformProperty<string>? CloudformationStackArn
    {
        set => SetProperty("cloudformation_stack_arn", value);
    }

}

/// <summary>
/// Block type for scaling_instruction in .
/// Nesting mode: set
/// </summary>
public class AwsAutoscalingplansScalingPlanScalingInstructionBlock : TerraformBlock
{
    /// <summary>
    /// The disable_dynamic_scaling attribute.
    /// </summary>
    public TerraformProperty<bool>? DisableDynamicScaling
    {
        set => SetProperty("disable_dynamic_scaling", value);
    }

    /// <summary>
    /// The max_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxCapacity is required")]
    public required TerraformProperty<double> MaxCapacity
    {
        set => SetProperty("max_capacity", value);
    }

    /// <summary>
    /// The min_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinCapacity is required")]
    public required TerraformProperty<double> MinCapacity
    {
        set => SetProperty("min_capacity", value);
    }

    /// <summary>
    /// The predictive_scaling_max_capacity_behavior attribute.
    /// </summary>
    public TerraformProperty<string>? PredictiveScalingMaxCapacityBehavior
    {
        set => SetProperty("predictive_scaling_max_capacity_behavior", value);
    }

    /// <summary>
    /// The predictive_scaling_max_capacity_buffer attribute.
    /// </summary>
    public TerraformProperty<double>? PredictiveScalingMaxCapacityBuffer
    {
        set => SetProperty("predictive_scaling_max_capacity_buffer", value);
    }

    /// <summary>
    /// The predictive_scaling_mode attribute.
    /// </summary>
    public TerraformProperty<string>? PredictiveScalingMode
    {
        set => SetProperty("predictive_scaling_mode", value);
    }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceId is required")]
    public required TerraformProperty<string> ResourceId
    {
        set => SetProperty("resource_id", value);
    }

    /// <summary>
    /// The scalable_dimension attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScalableDimension is required")]
    public required TerraformProperty<string> ScalableDimension
    {
        set => SetProperty("scalable_dimension", value);
    }

    /// <summary>
    /// The scaling_policy_update_behavior attribute.
    /// </summary>
    public TerraformProperty<string>? ScalingPolicyUpdateBehavior
    {
        set => SetProperty("scaling_policy_update_behavior", value);
    }

    /// <summary>
    /// The scheduled_action_buffer_time attribute.
    /// </summary>
    public TerraformProperty<double>? ScheduledActionBufferTime
    {
        set => SetProperty("scheduled_action_buffer_time", value);
    }

    /// <summary>
    /// The service_namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceNamespace is required")]
    public required TerraformProperty<string> ServiceNamespace
    {
        set => SetProperty("service_namespace", value);
    }

}

/// <summary>
/// Manages a aws_autoscalingplans_scaling_plan resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsAutoscalingplansScalingPlan : TerraformResource
{
    public AwsAutoscalingplansScalingPlan(string name) : base("aws_autoscalingplans_scaling_plan", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("scaling_plan_version");
        SetOutput("id");
        SetOutput("name");
        SetOutput("region");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// Block for application_source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationSource is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ApplicationSource block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApplicationSource block(s) allowed")]
    public List<AwsAutoscalingplansScalingPlanApplicationSourceBlock>? ApplicationSource
    {
        set => SetProperty("application_source", value);
    }

    /// <summary>
    /// Block for scaling_instruction.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScalingInstruction is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ScalingInstruction block(s) required")]
    public HashSet<AwsAutoscalingplansScalingPlanScalingInstructionBlock>? ScalingInstruction
    {
        set => SetProperty("scaling_instruction", value);
    }

    /// <summary>
    /// The scaling_plan_version attribute.
    /// </summary>
    public TerraformExpression ScalingPlanVersion => this["scaling_plan_version"];

}
