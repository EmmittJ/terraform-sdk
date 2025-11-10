using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsPinpointsmsvoicev2PhoneNumberTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a aws_pinpointsmsvoicev2_phone_number resource.
/// </summary>
public class AwsPinpointsmsvoicev2PhoneNumber : TerraformResource
{
    public AwsPinpointsmsvoicev2PhoneNumber(string name) : base("aws_pinpointsmsvoicev2_phone_number", name)
    {
    }

    /// <summary>
    /// The deletion_protection_enabled attribute.
    /// </summary>
    [TerraformPropertyName("deletion_protection_enabled")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> DeletionProtectionEnabled { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "deletion_protection_enabled");

    /// <summary>
    /// The iso_country_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IsoCountryCode is required")]
    [TerraformPropertyName("iso_country_code")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> IsoCountryCode { get; set; }

    /// <summary>
    /// The message_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MessageType is required")]
    [TerraformPropertyName("message_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> MessageType { get; set; }

    /// <summary>
    /// The number_capabilities attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NumberCapabilities is required")]
    [TerraformPropertyName("number_capabilities")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? NumberCapabilities { get; set; }

    /// <summary>
    /// The number_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NumberType is required")]
    [TerraformPropertyName("number_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> NumberType { get; set; }

    /// <summary>
    /// The opt_out_list_name attribute.
    /// </summary>
    [TerraformPropertyName("opt_out_list_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> OptOutListName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "opt_out_list_name");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The registration_id attribute.
    /// </summary>
    [TerraformPropertyName("registration_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RegistrationId { get; set; }

    /// <summary>
    /// The self_managed_opt_outs_enabled attribute.
    /// </summary>
    [TerraformPropertyName("self_managed_opt_outs_enabled")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> SelfManagedOptOutsEnabled { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "self_managed_opt_outs_enabled");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The two_way_channel_arn attribute.
    /// </summary>
    [TerraformPropertyName("two_way_channel_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TwoWayChannelArn { get; set; }

    /// <summary>
    /// The two_way_channel_enabled attribute.
    /// </summary>
    [TerraformPropertyName("two_way_channel_enabled")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> TwoWayChannelEnabled { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "two_way_channel_enabled");

    /// <summary>
    /// The two_way_channel_role attribute.
    /// </summary>
    [TerraformPropertyName("two_way_channel_role")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TwoWayChannelRole { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsPinpointsmsvoicev2PhoneNumberTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The monthly_leasing_price attribute.
    /// </summary>
    [TerraformPropertyName("monthly_leasing_price")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> MonthlyLeasingPrice => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "monthly_leasing_price");

    /// <summary>
    /// The phone_number attribute.
    /// </summary>
    [TerraformPropertyName("phone_number")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PhoneNumber => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "phone_number");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

}
