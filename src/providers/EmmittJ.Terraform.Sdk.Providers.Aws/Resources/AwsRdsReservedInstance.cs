using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsRdsReservedInstanceTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_rds_reserved_instance resource.
/// </summary>
public class AwsRdsReservedInstance : TerraformResource
{
    public AwsRdsReservedInstance(string name) : base("aws_rds_reserved_instance", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The instance_count attribute.
    /// </summary>
    [TerraformPropertyName("instance_count")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? InstanceCount { get; set; }

    /// <summary>
    /// The offering_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OfferingId is required")]
    [TerraformPropertyName("offering_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> OfferingId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The reservation_id attribute.
    /// </summary>
    [TerraformPropertyName("reservation_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ReservationId { get; set; }

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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsRdsReservedInstanceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The currency_code attribute.
    /// </summary>
    [TerraformPropertyName("currency_code")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CurrencyCode => new TerraformReference(this, "currency_code");

    /// <summary>
    /// The db_instance_class attribute.
    /// </summary>
    [TerraformPropertyName("db_instance_class")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DbInstanceClass => new TerraformReference(this, "db_instance_class");

    /// <summary>
    /// The duration attribute.
    /// </summary>
    [TerraformPropertyName("duration")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> Duration => new TerraformReference(this, "duration");

    /// <summary>
    /// The fixed_price attribute.
    /// </summary>
    [TerraformPropertyName("fixed_price")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> FixedPrice => new TerraformReference(this, "fixed_price");

    /// <summary>
    /// The lease_id attribute.
    /// </summary>
    [TerraformPropertyName("lease_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LeaseId => new TerraformReference(this, "lease_id");

    /// <summary>
    /// The multi_az attribute.
    /// </summary>
    [TerraformPropertyName("multi_az")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> MultiAz => new TerraformReference(this, "multi_az");

    /// <summary>
    /// The offering_type attribute.
    /// </summary>
    [TerraformPropertyName("offering_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OfferingType => new TerraformReference(this, "offering_type");

    /// <summary>
    /// The product_description attribute.
    /// </summary>
    [TerraformPropertyName("product_description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ProductDescription => new TerraformReference(this, "product_description");

    /// <summary>
    /// The recurring_charges attribute.
    /// </summary>
    [TerraformPropertyName("recurring_charges")]
    // Output-only attribute - read-only reference
    public TerraformList<object> RecurringCharges => new TerraformReference(this, "recurring_charges");

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    [TerraformPropertyName("start_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> StartTime => new TerraformReference(this, "start_time");

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> State => new TerraformReference(this, "state");

    /// <summary>
    /// The usage_price attribute.
    /// </summary>
    [TerraformPropertyName("usage_price")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> UsagePrice => new TerraformReference(this, "usage_price");

}
