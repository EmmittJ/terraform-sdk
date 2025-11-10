using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for scalable_target_action in .
/// Nesting mode: list
/// </summary>
public class AwsAppautoscalingScheduledActionScalableTargetActionBlock : ITerraformBlock
{
    /// <summary>
    /// The max_capacity attribute.
    /// </summary>
    [TerraformPropertyName("max_capacity")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MaxCapacity { get; set; }

    /// <summary>
    /// The min_capacity attribute.
    /// </summary>
    [TerraformPropertyName("min_capacity")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MinCapacity { get; set; }

}

/// <summary>
/// Manages a aws_appautoscaling_scheduled_action resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsAppautoscalingScheduledAction : TerraformResource
{
    public AwsAppautoscalingScheduledAction(string name) : base("aws_appautoscaling_scheduled_action", name)
    {
    }

    /// <summary>
    /// The end_time attribute.
    /// </summary>
    [TerraformPropertyName("end_time")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? EndTime { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceId is required")]
    [TerraformPropertyName("resource_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceId { get; set; }

    /// <summary>
    /// The scalable_dimension attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScalableDimension is required")]
    [TerraformPropertyName("scalable_dimension")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ScalableDimension { get; set; }

    /// <summary>
    /// The schedule attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Schedule is required")]
    [TerraformPropertyName("schedule")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Schedule { get; set; }

    /// <summary>
    /// The service_namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceNamespace is required")]
    [TerraformPropertyName("service_namespace")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ServiceNamespace { get; set; }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    [TerraformPropertyName("start_time")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? StartTime { get; set; }

    /// <summary>
    /// The timezone attribute.
    /// </summary>
    [TerraformPropertyName("timezone")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Timezone { get; set; }

    /// <summary>
    /// Block for scalable_target_action.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScalableTargetAction is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ScalableTargetAction block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScalableTargetAction block(s) allowed")]
    [TerraformPropertyName("scalable_target_action")]
    public TerraformList<TerraformBlock<AwsAppautoscalingScheduledActionScalableTargetActionBlock>>? ScalableTargetAction { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

}
