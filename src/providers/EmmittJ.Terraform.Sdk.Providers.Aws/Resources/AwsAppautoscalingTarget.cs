using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for suspended_state in AwsAppautoscalingTarget.
/// Nesting mode: list
/// </summary>
public class AwsAppautoscalingTargetSuspendedStateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "suspended_state";

    /// <summary>
    /// The dynamic_scaling_in_suspended attribute.
    /// </summary>
    public TerraformValue<bool>? DynamicScalingInSuspended
    {
        get => GetArgument<TerraformValue<bool>>("dynamic_scaling_in_suspended");
        set => SetArgument("dynamic_scaling_in_suspended", value);
    }

    /// <summary>
    /// The dynamic_scaling_out_suspended attribute.
    /// </summary>
    public TerraformValue<bool>? DynamicScalingOutSuspended
    {
        get => GetArgument<TerraformValue<bool>>("dynamic_scaling_out_suspended");
        set => SetArgument("dynamic_scaling_out_suspended", value);
    }

    /// <summary>
    /// The scheduled_scaling_suspended attribute.
    /// </summary>
    public TerraformValue<bool>? ScheduledScalingSuspended
    {
        get => GetArgument<TerraformValue<bool>>("scheduled_scaling_suspended");
        set => SetArgument("scheduled_scaling_suspended", value);
    }

}


/// <summary>
/// Represents a aws_appautoscaling_target Terraform resource.
/// Manages a aws_appautoscaling_target resource.
/// </summary>
public partial class AwsAppautoscalingTarget(string name) : TerraformResource("aws_appautoscaling_target", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The max_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxCapacity is required")]
    public required TerraformValue<double> MaxCapacity
    {
        get => GetRequiredArgument<TerraformValue<double>>("max_capacity");
        set => SetArgument("max_capacity", value);
    }

    /// <summary>
    /// The min_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinCapacity is required")]
    public required TerraformValue<double> MinCapacity
    {
        get => GetRequiredArgument<TerraformValue<double>>("min_capacity");
        set => SetArgument("min_capacity", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceId is required")]
    public required TerraformValue<string> ResourceId
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_id");
        set => SetArgument("resource_id", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformValue<string> RoleArn
    {
        get => GetArgument<TerraformValue<string>>("role_arn") ?? CreateReference("role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// The scalable_dimension attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScalableDimension is required")]
    public required TerraformValue<string> ScalableDimension
    {
        get => GetRequiredArgument<TerraformValue<string>>("scalable_dimension");
        set => SetArgument("scalable_dimension", value);
    }

    /// <summary>
    /// The service_namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceNamespace is required")]
    public required TerraformValue<string> ServiceNamespace
    {
        get => GetRequiredArgument<TerraformValue<string>>("service_namespace");
        set => SetArgument("service_namespace", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? CreateReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// SuspendedState block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SuspendedState block(s) allowed")]
    public TerraformList<AwsAppautoscalingTargetSuspendedStateBlock>? SuspendedState
    {
        get => GetArgument<TerraformList<AwsAppautoscalingTargetSuspendedStateBlock>>("suspended_state");
        set => SetArgument("suspended_state", value);
    }

}
