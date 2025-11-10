using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsEc2InstanceTypeOfferingsDataSourceFilterBlock : ITerraformBlock
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
public class AwsEc2InstanceTypeOfferingsDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a aws_ec2_instance_type_offerings.
/// </summary>
public class AwsEc2InstanceTypeOfferingsDataSource : TerraformDataSource
{
    public AwsEc2InstanceTypeOfferingsDataSource(string name) : base("aws_ec2_instance_type_offerings", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The location_type attribute.
    /// </summary>
    [TerraformPropertyName("location_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? LocationType { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("filter")]
    public TerraformSet<TerraformBlock<AwsEc2InstanceTypeOfferingsDataSourceFilterBlock>>? Filter { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsEc2InstanceTypeOfferingsDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The instance_types attribute.
    /// </summary>
    [TerraformPropertyName("instance_types")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> InstanceTypes => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "instance_types");

    /// <summary>
    /// The location_types attribute.
    /// </summary>
    [TerraformPropertyName("location_types")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> LocationTypes => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "location_types");

    /// <summary>
    /// The locations attribute.
    /// </summary>
    [TerraformPropertyName("locations")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> Locations => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "locations");

}
