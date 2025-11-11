using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ec2_capacity_block_offering.
/// </summary>
public class AwsEc2CapacityBlockOfferingDataSource : TerraformDataSource
{
    public AwsEc2CapacityBlockOfferingDataSource(string name) : base("aws_ec2_capacity_block_offering", name)
    {
    }

    /// <summary>
    /// The capacity_duration_hours attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CapacityDurationHours is required")]
    [TerraformPropertyName("capacity_duration_hours")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> CapacityDurationHours { get; set; }

    /// <summary>
    /// The end_date_range attribute.
    /// </summary>
    [TerraformPropertyName("end_date_range")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> EndDateRange { get; set; } = default!;

    /// <summary>
    /// The instance_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceCount is required")]
    [TerraformPropertyName("instance_count")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> InstanceCount { get; set; }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceType is required")]
    [TerraformPropertyName("instance_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> InstanceType { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The start_date_range attribute.
    /// </summary>
    [TerraformPropertyName("start_date_range")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> StartDateRange { get; set; } = default!;

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    [TerraformPropertyName("availability_zone")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AvailabilityZone => new TerraformReference(this, "availability_zone");

    /// <summary>
    /// The capacity_block_offering_id attribute.
    /// </summary>
    [TerraformPropertyName("capacity_block_offering_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CapacityBlockOfferingId => new TerraformReference(this, "capacity_block_offering_id");

    /// <summary>
    /// The currency_code attribute.
    /// </summary>
    [TerraformPropertyName("currency_code")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CurrencyCode => new TerraformReference(this, "currency_code");

    /// <summary>
    /// The tenancy attribute.
    /// </summary>
    [TerraformPropertyName("tenancy")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Tenancy => new TerraformReference(this, "tenancy");

    /// <summary>
    /// The upfront_fee attribute.
    /// </summary>
    [TerraformPropertyName("upfront_fee")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UpfrontFee => new TerraformReference(this, "upfront_fee");

}
