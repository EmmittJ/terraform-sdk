using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsAvailabilityZoneDataSourceFilterBlock : ITerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    [TerraformPropertyName("values")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Values { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsAvailabilityZoneDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    public TerraformProperty<TerraformProperty<bool>>? AllAvailabilityZones { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Name { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformPropertyName("state")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> State { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state");

    /// <summary>
    /// The zone_id attribute.
    /// </summary>
    [TerraformPropertyName("zone_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ZoneId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "zone_id");

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("filter")]
    public TerraformSet<TerraformBlock<AwsAvailabilityZoneDataSourceFilterBlock>>? Filter { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsAvailabilityZoneDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The group_long_name attribute.
    /// </summary>
    [TerraformPropertyName("group_long_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> GroupLongName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "group_long_name");

    /// <summary>
    /// The group_name attribute.
    /// </summary>
    [TerraformPropertyName("group_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> GroupName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "group_name");

    /// <summary>
    /// The name_suffix attribute.
    /// </summary>
    [TerraformPropertyName("name_suffix")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NameSuffix => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name_suffix");

    /// <summary>
    /// The network_border_group attribute.
    /// </summary>
    [TerraformPropertyName("network_border_group")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NetworkBorderGroup => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "network_border_group");

    /// <summary>
    /// The opt_in_status attribute.
    /// </summary>
    [TerraformPropertyName("opt_in_status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OptInStatus => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "opt_in_status");

    /// <summary>
    /// The parent_zone_id attribute.
    /// </summary>
    [TerraformPropertyName("parent_zone_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ParentZoneId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "parent_zone_id");

    /// <summary>
    /// The parent_zone_name attribute.
    /// </summary>
    [TerraformPropertyName("parent_zone_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ParentZoneName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "parent_zone_name");

    /// <summary>
    /// The zone_type attribute.
    /// </summary>
    [TerraformPropertyName("zone_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ZoneType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "zone_type");

}
