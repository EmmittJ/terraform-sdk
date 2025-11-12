using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public partial class AwsEc2InstanceTypeOfferingsDataSourceFilterBlock() : TerraformBlock("filter")
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    [TerraformProperty("values")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> Values { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsEc2InstanceTypeOfferingsDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a aws_ec2_instance_type_offerings.
/// </summary>
public partial class AwsEc2InstanceTypeOfferingsDataSource : TerraformDataSource
{
    public AwsEc2InstanceTypeOfferingsDataSource(string name) : base("aws_ec2_instance_type_offerings", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location_type attribute.
    /// </summary>
    [TerraformProperty("location_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? LocationType { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("filter")]
    public TerraformSet<AwsEc2InstanceTypeOfferingsDataSourceFilterBlock> Filter { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsEc2InstanceTypeOfferingsDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The instance_types attribute.
    /// </summary>
    [TerraformProperty("instance_types")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> InstanceTypes { get; }

    /// <summary>
    /// The location_types attribute.
    /// </summary>
    [TerraformProperty("location_types")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> LocationTypes { get; }

    /// <summary>
    /// The locations attribute.
    /// </summary>
    [TerraformProperty("locations")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> Locations { get; }

}
