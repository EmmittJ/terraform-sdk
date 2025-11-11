using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsAvailabilityZoneDataSourceFilterBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    [TerraformPropertyName("values")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> Values { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsAvailabilityZoneDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a aws_availability_zone.
/// </summary>
public class AwsAvailabilityZoneDataSource : TerraformDataSource
{
    public AwsAvailabilityZoneDataSource(string name) : base("aws_availability_zone", name)
    {
    }

    /// <summary>
    /// The all_availability_zones attribute.
    /// </summary>
    [TerraformPropertyName("all_availability_zones")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AllAvailabilityZones { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Name { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformPropertyName("state")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> State { get; set; } = default!;

    /// <summary>
    /// The zone_id attribute.
    /// </summary>
    [TerraformPropertyName("zone_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ZoneId { get; set; } = default!;

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("filter")]
    public TerraformSet<TerraformBlock<AwsAvailabilityZoneDataSourceFilterBlock>>? Filter { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsAvailabilityZoneDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The group_long_name attribute.
    /// </summary>
    [TerraformPropertyName("group_long_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> GroupLongName => new TerraformReference(this, "group_long_name");

    /// <summary>
    /// The group_name attribute.
    /// </summary>
    [TerraformPropertyName("group_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> GroupName => new TerraformReference(this, "group_name");

    /// <summary>
    /// The name_suffix attribute.
    /// </summary>
    [TerraformPropertyName("name_suffix")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> NameSuffix => new TerraformReference(this, "name_suffix");

    /// <summary>
    /// The network_border_group attribute.
    /// </summary>
    [TerraformPropertyName("network_border_group")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> NetworkBorderGroup => new TerraformReference(this, "network_border_group");

    /// <summary>
    /// The opt_in_status attribute.
    /// </summary>
    [TerraformPropertyName("opt_in_status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OptInStatus => new TerraformReference(this, "opt_in_status");

    /// <summary>
    /// The parent_zone_id attribute.
    /// </summary>
    [TerraformPropertyName("parent_zone_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ParentZoneId => new TerraformReference(this, "parent_zone_id");

    /// <summary>
    /// The parent_zone_name attribute.
    /// </summary>
    [TerraformPropertyName("parent_zone_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ParentZoneName => new TerraformReference(this, "parent_zone_name");

    /// <summary>
    /// The zone_type attribute.
    /// </summary>
    [TerraformPropertyName("zone_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ZoneType => new TerraformReference(this, "zone_type");

}
