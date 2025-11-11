using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for recurrence in .
/// Nesting mode: list
/// </summary>
public partial class AwsSsmcontactsRotationRecurrenceBlock : TerraformBlockBase
{
    /// <summary>
    /// The number_of_on_calls attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NumberOfOnCalls is required")]
    [TerraformProperty("number_of_on_calls")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> NumberOfOnCalls { get; set; }

    /// <summary>
    /// The recurrence_multiplier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecurrenceMultiplier is required")]
    [TerraformProperty("recurrence_multiplier")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> RecurrenceMultiplier { get; set; }

}

/// <summary>
/// Manages a aws_ssmcontacts_rotation resource.
/// </summary>
public partial class AwsSsmcontactsRotation : TerraformResource
{
    public AwsSsmcontactsRotation(string name) : base("aws_ssmcontacts_rotation", name)
    {
    }

    /// <summary>
    /// The contact_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContactIds is required")]
    [TerraformProperty("contact_ids")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? ContactIds { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    [TerraformProperty("start_time")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? StartTime { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The time_zone_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeZoneId is required")]
    [TerraformProperty("time_zone_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TimeZoneId { get; set; }

    /// <summary>
    /// Block for recurrence.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("recurrence")]
    public partial TerraformList<TerraformBlock<AwsSsmcontactsRotationRecurrenceBlock>>? Recurrence { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Id { get; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TagsAll { get; }

}
