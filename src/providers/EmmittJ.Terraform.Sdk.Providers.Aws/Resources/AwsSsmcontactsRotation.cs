using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for recurrence in .
/// Nesting mode: list
/// </summary>
public class AwsSsmcontactsRotationRecurrenceBlock
{
    /// <summary>
    /// The number_of_on_calls attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NumberOfOnCalls is required")]
    [TerraformPropertyName("number_of_on_calls")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> NumberOfOnCalls { get; set; }

    /// <summary>
    /// The recurrence_multiplier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecurrenceMultiplier is required")]
    [TerraformPropertyName("recurrence_multiplier")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> RecurrenceMultiplier { get; set; }

}

/// <summary>
/// Manages a aws_ssmcontacts_rotation resource.
/// </summary>
public class AwsSsmcontactsRotation : TerraformResource
{
    public AwsSsmcontactsRotation(string name) : base("aws_ssmcontacts_rotation", name)
    {
    }

    /// <summary>
    /// The contact_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContactIds is required")]
    [TerraformPropertyName("contact_ids")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformList<string>? ContactIds { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    [TerraformPropertyName("start_time")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? StartTime { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The time_zone_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeZoneId is required")]
    [TerraformPropertyName("time_zone_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> TimeZoneId { get; set; }

    /// <summary>
    /// Block for recurrence.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("recurrence")]
    public TerraformList<TerraformBlock<AwsSsmcontactsRotationRecurrenceBlock>>? Recurrence { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Id => new TerraformReference(this, "id");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> TagsAll => new TerraformReference(this, "tags_all");

}
