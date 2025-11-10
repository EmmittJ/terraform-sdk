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
        get => GetProperty<TerraformProperty<string>>("cloudformation_stack_arn");
        set => WithProperty("cloudformation_stack_arn", value);
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
        get => GetProperty<TerraformProperty<bool>>("disable_dynamic_scaling");
        set => WithProperty("disable_dynamic_scaling", value);
    }

    /// <summary>
    /// The max_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxCapacity is required")]
    public required TerraformProperty<double> MaxCapacity
    {
        get => GetProperty<TerraformProperty<double>>("max_capacity");
        set => WithProperty("max_capacity", value);
    }

    /// <summary>
    /// The min_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinCapacity is required")]
    public required TerraformProperty<double> MinCapacity
    {
        get => GetProperty<TerraformProperty<double>>("min_capacity");
        set => WithProperty("min_capacity", value);
    }

    /// <summary>
    /// The predictive_scaling_max_capacity_behavior attribute.
    /// </summary>
    public TerraformProperty<string>? PredictiveScalingMaxCapacityBehavior
    {
        get => GetProperty<TerraformProperty<string>>("predictive_scaling_max_capacity_behavior");
        set => WithProperty("predictive_scaling_max_capacity_behavior", value);
    }

    /// <summary>
    /// The predictive_scaling_max_capacity_buffer attribute.
    /// </summary>
    public TerraformProperty<double>? PredictiveScalingMaxCapacityBuffer
    {
        get => GetProperty<TerraformProperty<double>>("predictive_scaling_max_capacity_buffer");
        set => WithProperty("predictive_scaling_max_capacity_buffer", value);
    }

    /// <summary>
    /// The predictive_scaling_mode attribute.
    /// </summary>
    public TerraformProperty<string>? PredictiveScalingMode
    {
        get => GetProperty<TerraformProperty<string>>("predictive_scaling_mode");
        set => WithProperty("predictive_scaling_mode", value);
    }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceId is required")]
    public required TerraformProperty<string> ResourceId
    {
        get => GetProperty<TerraformProperty<string>>("resource_id");
        set => WithProperty("resource_id", value);
    }

    /// <summary>
    /// The scalable_dimension attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScalableDimension is required")]
    public required TerraformProperty<string> ScalableDimension
    {
        get => GetProperty<TerraformProperty<string>>("scalable_dimension");
        set => WithProperty("scalable_dimension", value);
    }

    /// <summary>
    /// The scaling_policy_update_behavior attribute.
    /// </summary>
    public TerraformProperty<string>? ScalingPolicyUpdateBehavior
    {
        get => GetProperty<TerraformProperty<string>>("scaling_policy_update_behavior");
        set => WithProperty("scaling_policy_update_behavior", value);
    }

    /// <summary>
    /// The scheduled_action_buffer_time attribute.
    /// </summary>
    public TerraformProperty<double>? ScheduledActionBufferTime
    {
        get => GetProperty<TerraformProperty<double>>("scheduled_action_buffer_time");
        set => WithProperty("scheduled_action_buffer_time", value);
    }

    /// <summary>
    /// The service_namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceNamespace is required")]
    public required TerraformProperty<string> ServiceNamespace
    {
        get => GetProperty<TerraformProperty<string>>("service_namespace");
        set => WithProperty("service_namespace", value);
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
        this.DeclareOutput("scaling_plan_version");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// Block for application_source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ApplicationSource block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApplicationSource block(s) allowed")]
    public List<AwsAutoscalingplansScalingPlanApplicationSourceBlock>? ApplicationSource
    {
        get => GetProperty<List<AwsAutoscalingplansScalingPlanApplicationSourceBlock>>("application_source");
        set => this.WithProperty("application_source", value);
    }

    /// <summary>
    /// Block for scaling_instruction.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ScalingInstruction block(s) required")]
    public HashSet<AwsAutoscalingplansScalingPlanScalingInstructionBlock>? ScalingInstruction
    {
        get => GetProperty<HashSet<AwsAutoscalingplansScalingPlanScalingInstructionBlock>>("scaling_instruction");
        set => this.WithProperty("scaling_instruction", value);
    }

    /// <summary>
    /// The scaling_plan_version attribute.
    /// </summary>
    public TerraformExpression ScalingPlanVersion => this["scaling_plan_version"];

}
