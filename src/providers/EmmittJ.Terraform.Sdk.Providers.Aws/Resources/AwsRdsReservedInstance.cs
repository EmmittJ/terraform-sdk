using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsRdsReservedInstanceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_rds_reserved_instance resource.
/// </summary>
public partial class AwsRdsReservedInstance : TerraformResource
{
    public AwsRdsReservedInstance(string name) : base("aws_rds_reserved_instance", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The instance_count attribute.
    /// </summary>
    [TerraformProperty("instance_count")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? InstanceCount { get; set; }

    /// <summary>
    /// The offering_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OfferingId is required")]
    [TerraformProperty("offering_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> OfferingId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The reservation_id attribute.
    /// </summary>
    [TerraformProperty("reservation_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ReservationId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsRdsReservedInstanceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The currency_code attribute.
    /// </summary>
    [TerraformProperty("currency_code")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CurrencyCode { get; }

    /// <summary>
    /// The db_instance_class attribute.
    /// </summary>
    [TerraformProperty("db_instance_class")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DbInstanceClass { get; }

    /// <summary>
    /// The duration attribute.
    /// </summary>
    [TerraformProperty("duration")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> Duration { get; }

    /// <summary>
    /// The fixed_price attribute.
    /// </summary>
    [TerraformProperty("fixed_price")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> FixedPrice { get; }

    /// <summary>
    /// The lease_id attribute.
    /// </summary>
    [TerraformProperty("lease_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LeaseId { get; }

    /// <summary>
    /// The multi_az attribute.
    /// </summary>
    [TerraformProperty("multi_az")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> MultiAz { get; }

    /// <summary>
    /// The offering_type attribute.
    /// </summary>
    [TerraformProperty("offering_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OfferingType { get; }

    /// <summary>
    /// The product_description attribute.
    /// </summary>
    [TerraformProperty("product_description")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ProductDescription { get; }

    /// <summary>
    /// The recurring_charges attribute.
    /// </summary>
    [TerraformProperty("recurring_charges")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> RecurringCharges { get; }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    [TerraformProperty("start_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> StartTime { get; }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

    /// <summary>
    /// The usage_price attribute.
    /// </summary>
    [TerraformProperty("usage_price")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> UsagePrice { get; }

}
