using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for scalable_target_action in .
/// Nesting mode: list
/// </summary>
public class AwsAppautoscalingScheduledActionScalableTargetActionBlock : TerraformBlock
{
    /// <summary>
    /// The max_capacity attribute.
    /// </summary>
    public TerraformProperty<string>? MaxCapacity
    {
        set => SetProperty("max_capacity", value);
    }

    /// <summary>
    /// The min_capacity attribute.
    /// </summary>
    public TerraformProperty<string>? MinCapacity
    {
        set => SetProperty("min_capacity", value);
    }

}

/// <summary>
/// Manages a aws_appautoscaling_scheduled_action resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsAppautoscalingScheduledAction : TerraformResource
{
    public AwsAppautoscalingScheduledAction(string name) : base("aws_appautoscaling_scheduled_action", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("end_time");
        SetOutput("id");
        SetOutput("name");
        SetOutput("region");
        SetOutput("resource_id");
        SetOutput("scalable_dimension");
        SetOutput("schedule");
        SetOutput("service_namespace");
        SetOutput("start_time");
        SetOutput("timezone");
    }

    /// <summary>
    /// The end_time attribute.
    /// </summary>
    public TerraformProperty<string> EndTime
    {
        get => GetRequiredOutput<TerraformProperty<string>>("end_time");
        set => SetProperty("end_time", value);
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
    /// The resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceId is required")]
    public required TerraformProperty<string> ResourceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_id");
        set => SetProperty("resource_id", value);
    }

    /// <summary>
    /// The scalable_dimension attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScalableDimension is required")]
    public required TerraformProperty<string> ScalableDimension
    {
        get => GetRequiredOutput<TerraformProperty<string>>("scalable_dimension");
        set => SetProperty("scalable_dimension", value);
    }

    /// <summary>
    /// The schedule attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Schedule is required")]
    public required TerraformProperty<string> Schedule
    {
        get => GetRequiredOutput<TerraformProperty<string>>("schedule");
        set => SetProperty("schedule", value);
    }

    /// <summary>
    /// The service_namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceNamespace is required")]
    public required TerraformProperty<string> ServiceNamespace
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service_namespace");
        set => SetProperty("service_namespace", value);
    }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    public TerraformProperty<string> StartTime
    {
        get => GetRequiredOutput<TerraformProperty<string>>("start_time");
        set => SetProperty("start_time", value);
    }

    /// <summary>
    /// The timezone attribute.
    /// </summary>
    public TerraformProperty<string> Timezone
    {
        get => GetRequiredOutput<TerraformProperty<string>>("timezone");
        set => SetProperty("timezone", value);
    }

    /// <summary>
    /// Block for scalable_target_action.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScalableTargetAction is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ScalableTargetAction block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScalableTargetAction block(s) allowed")]
    public List<AwsAppautoscalingScheduledActionScalableTargetActionBlock>? ScalableTargetAction
    {
        set => SetProperty("scalable_target_action", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
