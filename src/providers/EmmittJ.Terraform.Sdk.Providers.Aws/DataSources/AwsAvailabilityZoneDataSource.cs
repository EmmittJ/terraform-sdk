using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public partial class AwsAvailabilityZoneDataSourceFilterBlock : TerraformBlockBase
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
public partial class AwsAvailabilityZoneDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a aws_availability_zone.
/// </summary>
public partial class AwsAvailabilityZoneDataSource : TerraformDataSource
{
    public AwsAvailabilityZoneDataSource(string name) : base("aws_availability_zone", name)
    {
    }

    /// <summary>
    /// The all_availability_zones attribute.
    /// </summary>
    [TerraformProperty("all_availability_zones")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AllAvailabilityZones { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformProperty("state")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> State { get; set; }

    /// <summary>
    /// The zone_id attribute.
    /// </summary>
    [TerraformProperty("zone_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ZoneId { get; set; }

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("filter")]
    public partial TerraformSet<TerraformBlock<AwsAvailabilityZoneDataSourceFilterBlock>>? Filter { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsAvailabilityZoneDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The group_long_name attribute.
    /// </summary>
    [TerraformProperty("group_long_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> GroupLongName { get; }

    /// <summary>
    /// The group_name attribute.
    /// </summary>
    [TerraformProperty("group_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> GroupName { get; }

    /// <summary>
    /// The name_suffix attribute.
    /// </summary>
    [TerraformProperty("name_suffix")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> NameSuffix { get; }

    /// <summary>
    /// The network_border_group attribute.
    /// </summary>
    [TerraformProperty("network_border_group")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> NetworkBorderGroup { get; }

    /// <summary>
    /// The opt_in_status attribute.
    /// </summary>
    [TerraformProperty("opt_in_status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OptInStatus { get; }

    /// <summary>
    /// The parent_zone_id attribute.
    /// </summary>
    [TerraformProperty("parent_zone_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ParentZoneId { get; }

    /// <summary>
    /// The parent_zone_name attribute.
    /// </summary>
    [TerraformProperty("parent_zone_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ParentZoneName { get; }

    /// <summary>
    /// The zone_type attribute.
    /// </summary>
    [TerraformProperty("zone_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ZoneType { get; }

}
