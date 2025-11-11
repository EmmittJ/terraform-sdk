using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ec2_capacity_block_offering.
/// </summary>
public partial class AwsEc2CapacityBlockOfferingDataSource : TerraformDataSource
{
    public AwsEc2CapacityBlockOfferingDataSource(string name) : base("aws_ec2_capacity_block_offering", name)
    {
    }

    /// <summary>
    /// The capacity_duration_hours attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CapacityDurationHours is required")]
    [TerraformProperty("capacity_duration_hours")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> CapacityDurationHours { get; set; }

    /// <summary>
    /// The end_date_range attribute.
    /// </summary>
    [TerraformProperty("end_date_range")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> EndDateRange { get; set; }

    /// <summary>
    /// The instance_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceCount is required")]
    [TerraformProperty("instance_count")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> InstanceCount { get; set; }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceType is required")]
    [TerraformProperty("instance_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> InstanceType { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The start_date_range attribute.
    /// </summary>
    [TerraformProperty("start_date_range")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> StartDateRange { get; set; }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    [TerraformProperty("availability_zone")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AvailabilityZone { get; }

    /// <summary>
    /// The capacity_block_offering_id attribute.
    /// </summary>
    [TerraformProperty("capacity_block_offering_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CapacityBlockOfferingId { get; }

    /// <summary>
    /// The currency_code attribute.
    /// </summary>
    [TerraformProperty("currency_code")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CurrencyCode { get; }

    /// <summary>
    /// The tenancy attribute.
    /// </summary>
    [TerraformProperty("tenancy")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Tenancy { get; }

    /// <summary>
    /// The upfront_fee attribute.
    /// </summary>
    [TerraformProperty("upfront_fee")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpfrontFee { get; }

}
