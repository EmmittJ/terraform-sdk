using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsRdsReservedInstanceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The instance_count attribute.
    /// </summary>
    [TerraformPropertyName("instance_count")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? InstanceCount { get; set; }

    /// <summary>
    /// The offering_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OfferingId is required")]
    [TerraformPropertyName("offering_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> OfferingId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The reservation_id attribute.
    /// </summary>
    [TerraformPropertyName("reservation_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ReservationId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsRdsReservedInstanceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The currency_code attribute.
    /// </summary>
    [TerraformPropertyName("currency_code")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CurrencyCode => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "currency_code");

    /// <summary>
    /// The db_instance_class attribute.
    /// </summary>
    [TerraformPropertyName("db_instance_class")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DbInstanceClass => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "db_instance_class");

    /// <summary>
    /// The duration attribute.
    /// </summary>
    [TerraformPropertyName("duration")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> Duration => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "duration");

    /// <summary>
    /// The fixed_price attribute.
    /// </summary>
    [TerraformPropertyName("fixed_price")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> FixedPrice => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "fixed_price");

    /// <summary>
    /// The lease_id attribute.
    /// </summary>
    [TerraformPropertyName("lease_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LeaseId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "lease_id");

    /// <summary>
    /// The multi_az attribute.
    /// </summary>
    [TerraformPropertyName("multi_az")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> MultiAz => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "multi_az");

    /// <summary>
    /// The offering_type attribute.
    /// </summary>
    [TerraformPropertyName("offering_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OfferingType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "offering_type");

    /// <summary>
    /// The product_description attribute.
    /// </summary>
    [TerraformPropertyName("product_description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ProductDescription => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "product_description");

    /// <summary>
    /// The recurring_charges attribute.
    /// </summary>
    [TerraformPropertyName("recurring_charges")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> RecurringCharges => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "recurring_charges");

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    [TerraformPropertyName("start_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StartTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "start_time");

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state");

    /// <summary>
    /// The usage_price attribute.
    /// </summary>
    [TerraformPropertyName("usage_price")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> UsagePrice => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "usage_price");

}
