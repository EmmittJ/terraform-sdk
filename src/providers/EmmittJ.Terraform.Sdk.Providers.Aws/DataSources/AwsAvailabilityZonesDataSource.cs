using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsAvailabilityZonesDataSourceFilterBlock : ITerraformBlock
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
public class AwsAvailabilityZonesDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a aws_availability_zones.
/// </summary>
public class AwsAvailabilityZonesDataSource : TerraformDataSource
{
    public AwsAvailabilityZonesDataSource(string name) : base("aws_availability_zones", name)
    {
    }

    /// <summary>
    /// The all_availability_zones attribute.
    /// </summary>
    [TerraformPropertyName("all_availability_zones")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AllAvailabilityZones { get; set; }

    /// <summary>
    /// The exclude_names attribute.
    /// </summary>
    [TerraformPropertyName("exclude_names")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? ExcludeNames { get; set; }

    /// <summary>
    /// The exclude_zone_ids attribute.
    /// </summary>
    [TerraformPropertyName("exclude_zone_ids")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? ExcludeZoneIds { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

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
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? State { get; set; }

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("filter")]
    public TerraformSet<TerraformBlock<AwsAvailabilityZonesDataSourceFilterBlock>>? Filter { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsAvailabilityZonesDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The group_names attribute.
    /// </summary>
    [TerraformPropertyName("group_names")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> GroupNames => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "group_names");

    /// <summary>
    /// The names attribute.
    /// </summary>
    [TerraformPropertyName("names")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> Names => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "names");

    /// <summary>
    /// The zone_ids attribute.
    /// </summary>
    [TerraformPropertyName("zone_ids")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> ZoneIds => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "zone_ids");

}
