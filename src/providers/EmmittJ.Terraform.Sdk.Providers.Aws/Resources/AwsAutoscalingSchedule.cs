using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_autoscaling_schedule resource.
/// </summary>
public class AwsAutoscalingSchedule : TerraformResource
{
    public AwsAutoscalingSchedule(string name) : base("aws_autoscaling_schedule", name)
    {
    }

    /// <summary>
    /// The autoscaling_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutoscalingGroupName is required")]
    [TerraformPropertyName("autoscaling_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AutoscalingGroupName { get; set; }

    /// <summary>
    /// The desired_capacity attribute.
    /// </summary>
    [TerraformPropertyName("desired_capacity")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> DesiredCapacity { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "desired_capacity");

    /// <summary>
    /// The end_time attribute.
    /// </summary>
    [TerraformPropertyName("end_time")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> EndTime { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "end_time");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The max_size attribute.
    /// </summary>
    [TerraformPropertyName("max_size")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> MaxSize { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "max_size");

    /// <summary>
    /// The min_size attribute.
    /// </summary>
    [TerraformPropertyName("min_size")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> MinSize { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "min_size");

    /// <summary>
    /// The recurrence attribute.
    /// </summary>
    [TerraformPropertyName("recurrence")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Recurrence { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "recurrence");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The scheduled_action_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScheduledActionName is required")]
    [TerraformPropertyName("scheduled_action_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ScheduledActionName { get; set; }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    [TerraformPropertyName("start_time")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> StartTime { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "start_time");

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    [TerraformPropertyName("time_zone")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> TimeZone { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "time_zone");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

}
