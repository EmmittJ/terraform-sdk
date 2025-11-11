using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for reservation_plan_settings in .
/// Nesting mode: list
/// </summary>
public partial class AwsMediaConvertQueueReservationPlanSettingsBlock : TerraformBlockBase
{
    /// <summary>
    /// The commitment attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Commitment is required")]
    [TerraformProperty("commitment")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Commitment { get; set; }

    /// <summary>
    /// The renewal_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RenewalType is required")]
    [TerraformProperty("renewal_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> RenewalType { get; set; }

    /// <summary>
    /// The reserved_slots attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReservedSlots is required")]
    [TerraformProperty("reserved_slots")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> ReservedSlots { get; set; }

}

/// <summary>
/// Manages a aws_media_convert_queue resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsMediaConvertQueue : TerraformResource
{
    public AwsMediaConvertQueue(string name) : base("aws_media_convert_queue", name)
    {
    }

    /// <summary>
    /// The concurrent_jobs attribute.
    /// </summary>
    [TerraformProperty("concurrent_jobs")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> ConcurrentJobs { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

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
    /// The pricing_plan attribute.
    /// </summary>
    [TerraformProperty("pricing_plan")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PricingPlan { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Status { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for reservation_plan_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReservationPlanSettings block(s) allowed")]
    [TerraformProperty("reservation_plan_settings")]
    public TerraformList<TerraformBlock<AwsMediaConvertQueueReservationPlanSettingsBlock>>? ReservationPlanSettings { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

}
