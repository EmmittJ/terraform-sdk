using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for scalable_target_action in AwsAppautoscalingScheduledAction.
/// Nesting mode: list
/// </summary>
public class AwsAppautoscalingScheduledActionScalableTargetActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "scalable_target_action";

    /// <summary>
    /// The max_capacity attribute.
    /// </summary>
    public TerraformValue<string>? MaxCapacity
    {
        get => new TerraformReference<string>(this, "max_capacity");
        set => SetArgument("max_capacity", value);
    }

    /// <summary>
    /// The min_capacity attribute.
    /// </summary>
    public TerraformValue<string>? MinCapacity
    {
        get => new TerraformReference<string>(this, "min_capacity");
        set => SetArgument("min_capacity", value);
    }

}


/// <summary>
/// Represents a aws_appautoscaling_scheduled_action Terraform resource.
/// Manages a aws_appautoscaling_scheduled_action resource.
/// </summary>
public partial class AwsAppautoscalingScheduledAction(string name) : TerraformResource("aws_appautoscaling_scheduled_action", name)
{
    /// <summary>
    /// The end_time attribute.
    /// </summary>
    public TerraformValue<string>? EndTime
    {
        get => new TerraformReference<string>(this, "end_time");
        set => SetArgument("end_time", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceId is required")]
    public required TerraformValue<string> ResourceId
    {
        get => new TerraformReference<string>(this, "resource_id");
        set => SetArgument("resource_id", value);
    }

    /// <summary>
    /// The scalable_dimension attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScalableDimension is required")]
    public required TerraformValue<string> ScalableDimension
    {
        get => new TerraformReference<string>(this, "scalable_dimension");
        set => SetArgument("scalable_dimension", value);
    }

    /// <summary>
    /// The schedule attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Schedule is required")]
    public required TerraformValue<string> Schedule
    {
        get => new TerraformReference<string>(this, "schedule");
        set => SetArgument("schedule", value);
    }

    /// <summary>
    /// The service_namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceNamespace is required")]
    public required TerraformValue<string> ServiceNamespace
    {
        get => new TerraformReference<string>(this, "service_namespace");
        set => SetArgument("service_namespace", value);
    }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    public TerraformValue<string>? StartTime
    {
        get => new TerraformReference<string>(this, "start_time");
        set => SetArgument("start_time", value);
    }

    /// <summary>
    /// The timezone attribute.
    /// </summary>
    public TerraformValue<string>? Timezone
    {
        get => new TerraformReference<string>(this, "timezone");
        set => SetArgument("timezone", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// ScalableTargetAction block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScalableTargetAction is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ScalableTargetAction block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScalableTargetAction block(s) allowed")]
    public required TerraformList<AwsAppautoscalingScheduledActionScalableTargetActionBlock> ScalableTargetAction
    {
        get => GetRequiredArgument<TerraformList<AwsAppautoscalingScheduledActionScalableTargetActionBlock>>("scalable_target_action");
        set => SetArgument("scalable_target_action", value);
    }

}
