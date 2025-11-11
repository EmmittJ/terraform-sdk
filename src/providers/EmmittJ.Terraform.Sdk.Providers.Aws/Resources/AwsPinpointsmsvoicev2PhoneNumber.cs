using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsPinpointsmsvoicev2PhoneNumberTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_pinpointsmsvoicev2_phone_number resource.
/// </summary>
public partial class AwsPinpointsmsvoicev2PhoneNumber : TerraformResource
{
    public AwsPinpointsmsvoicev2PhoneNumber(string name) : base("aws_pinpointsmsvoicev2_phone_number", name)
    {
    }

    /// <summary>
    /// The deletion_protection_enabled attribute.
    /// </summary>
    [TerraformProperty("deletion_protection_enabled")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> DeletionProtectionEnabled { get; set; }

    /// <summary>
    /// The iso_country_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IsoCountryCode is required")]
    [TerraformProperty("iso_country_code")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> IsoCountryCode { get; set; }

    /// <summary>
    /// The message_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MessageType is required")]
    [TerraformProperty("message_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> MessageType { get; set; }

    /// <summary>
    /// The number_capabilities attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NumberCapabilities is required")]
    [TerraformProperty("number_capabilities")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> NumberCapabilities { get; set; }

    /// <summary>
    /// The number_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NumberType is required")]
    [TerraformProperty("number_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> NumberType { get; set; }

    /// <summary>
    /// The opt_out_list_name attribute.
    /// </summary>
    [TerraformProperty("opt_out_list_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> OptOutListName { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The registration_id attribute.
    /// </summary>
    [TerraformProperty("registration_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RegistrationId { get; set; }

    /// <summary>
    /// The self_managed_opt_outs_enabled attribute.
    /// </summary>
    [TerraformProperty("self_managed_opt_outs_enabled")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> SelfManagedOptOutsEnabled { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The two_way_channel_arn attribute.
    /// </summary>
    [TerraformProperty("two_way_channel_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TwoWayChannelArn { get; set; }

    /// <summary>
    /// The two_way_channel_enabled attribute.
    /// </summary>
    [TerraformProperty("two_way_channel_enabled")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> TwoWayChannelEnabled { get; set; }

    /// <summary>
    /// The two_way_channel_role attribute.
    /// </summary>
    [TerraformProperty("two_way_channel_role")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TwoWayChannelRole { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsPinpointsmsvoicev2PhoneNumberTimeoutsBlock>? Timeouts { get; set; }

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
    /// The monthly_leasing_price attribute.
    /// </summary>
    [TerraformProperty("monthly_leasing_price")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> MonthlyLeasingPrice { get; }

    /// <summary>
    /// The phone_number attribute.
    /// </summary>
    [TerraformProperty("phone_number")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PhoneNumber { get; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TagsAll { get; }

}
