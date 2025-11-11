using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for suspended_state in .
/// Nesting mode: list
/// </summary>
public class AwsAppautoscalingTargetSuspendedStateBlock
{
    /// <summary>
    /// The dynamic_scaling_in_suspended attribute.
    /// </summary>
    [TerraformPropertyName("dynamic_scaling_in_suspended")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? DynamicScalingInSuspended { get; set; }

    /// <summary>
    /// The dynamic_scaling_out_suspended attribute.
    /// </summary>
    [TerraformPropertyName("dynamic_scaling_out_suspended")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? DynamicScalingOutSuspended { get; set; }

    /// <summary>
    /// The scheduled_scaling_suspended attribute.
    /// </summary>
    [TerraformPropertyName("scheduled_scaling_suspended")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ScheduledScalingSuspended { get; set; }

}

/// <summary>
/// Manages a aws_appautoscaling_target resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsAppautoscalingTarget : TerraformResource
{
    public AwsAppautoscalingTarget(string name) : base("aws_appautoscaling_target", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceId is required")]
    [TerraformPropertyName("resource_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceId { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [TerraformPropertyName("role_arn")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> RoleArn { get; set; } = default!;

    /// <summary>
    /// The scalable_dimension attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScalableDimension is required")]
    [TerraformPropertyName("scalable_dimension")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ScalableDimension { get; set; }

    /// <summary>
    /// The service_namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceNamespace is required")]
    [TerraformPropertyName("service_namespace")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ServiceNamespace { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// Block for suspended_state.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SuspendedState block(s) allowed")]
    [TerraformPropertyName("suspended_state")]
    public TerraformList<TerraformBlock<AwsAppautoscalingTargetSuspendedStateBlock>>? SuspendedState { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

}
