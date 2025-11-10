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
        get => GetProperty<TerraformProperty<string>>("max_capacity");
        set => WithProperty("max_capacity", value);
    }

    /// <summary>
    /// The min_capacity attribute.
    /// </summary>
    public TerraformProperty<string>? MinCapacity
    {
        get => GetProperty<TerraformProperty<string>>("min_capacity");
        set => WithProperty("min_capacity", value);
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
        this.WithOutput("arn");
    }

    /// <summary>
    /// The end_time attribute.
    /// </summary>
    public TerraformProperty<string>? EndTime
    {
        get => GetProperty<TerraformProperty<string>>("end_time");
        set => this.WithProperty("end_time", value);
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
        get => GetRequiredProperty<TerraformProperty<string>>("name");
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
    /// The resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceId is required")]
    public required TerraformProperty<string> ResourceId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_id");
        set => this.WithProperty("resource_id", value);
    }

    /// <summary>
    /// The scalable_dimension attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScalableDimension is required")]
    public required TerraformProperty<string> ScalableDimension
    {
        get => GetRequiredProperty<TerraformProperty<string>>("scalable_dimension");
        set => this.WithProperty("scalable_dimension", value);
    }

    /// <summary>
    /// The schedule attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Schedule is required")]
    public required TerraformProperty<string> Schedule
    {
        get => GetRequiredProperty<TerraformProperty<string>>("schedule");
        set => this.WithProperty("schedule", value);
    }

    /// <summary>
    /// The service_namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceNamespace is required")]
    public required TerraformProperty<string> ServiceNamespace
    {
        get => GetRequiredProperty<TerraformProperty<string>>("service_namespace");
        set => this.WithProperty("service_namespace", value);
    }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    public TerraformProperty<string>? StartTime
    {
        get => GetProperty<TerraformProperty<string>>("start_time");
        set => this.WithProperty("start_time", value);
    }

    /// <summary>
    /// The timezone attribute.
    /// </summary>
    public TerraformProperty<string>? Timezone
    {
        get => GetProperty<TerraformProperty<string>>("timezone");
        set => this.WithProperty("timezone", value);
    }

    /// <summary>
    /// Block for scalable_target_action.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ScalableTargetAction block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScalableTargetAction block(s) allowed")]
    public List<AwsAppautoscalingScheduledActionScalableTargetActionBlock>? ScalableTargetAction
    {
        get => GetProperty<List<AwsAppautoscalingScheduledActionScalableTargetActionBlock>>("scalable_target_action");
        set => this.WithProperty("scalable_target_action", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
