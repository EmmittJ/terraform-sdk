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
    public required TerraformProperty<TerraformProperty<double>> CapacityDurationHours { get; set; }

    /// <summary>
    /// The end_date_range attribute.
    /// </summary>
    [TerraformPropertyName("end_date_range")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> EndDateRange { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "end_date_range");

    /// <summary>
    /// The instance_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceCount is required")]
    [TerraformPropertyName("instance_count")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> InstanceCount { get; set; }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceType is required")]
    [TerraformPropertyName("instance_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> InstanceType { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The start_date_range attribute.
    /// </summary>
    [TerraformPropertyName("start_date_range")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> StartDateRange { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "start_date_range");

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    [TerraformPropertyName("availability_zone")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AvailabilityZone => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "availability_zone");

    /// <summary>
    /// The capacity_block_offering_id attribute.
    /// </summary>
    [TerraformPropertyName("capacity_block_offering_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CapacityBlockOfferingId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "capacity_block_offering_id");

    /// <summary>
    /// The currency_code attribute.
    /// </summary>
    [TerraformPropertyName("currency_code")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CurrencyCode => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "currency_code");

    /// <summary>
    /// The tenancy attribute.
    /// </summary>
    [TerraformPropertyName("tenancy")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Tenancy => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "tenancy");

    /// <summary>
    /// The upfront_fee attribute.
    /// </summary>
    [TerraformPropertyName("upfront_fee")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpfrontFee => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "upfront_fee");

}
