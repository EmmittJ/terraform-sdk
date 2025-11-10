using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_codebuild_fleet.
/// </summary>
public class AwsCodebuildFleetDataSource : TerraformDataSource
{
    public AwsCodebuildFleetDataSource(string name) : base("aws_codebuild_fleet", name)
    {
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The base_capacity attribute.
    /// </summary>
    [TerraformPropertyName("base_capacity")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> BaseCapacity => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "base_capacity");

    /// <summary>
    /// The compute_configuration attribute.
    /// </summary>
    [TerraformPropertyName("compute_configuration")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ComputeConfiguration => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "compute_configuration");

    /// <summary>
    /// The compute_type attribute.
    /// </summary>
    [TerraformPropertyName("compute_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ComputeType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "compute_type");

    /// <summary>
    /// The created attribute.
    /// </summary>
    [TerraformPropertyName("created")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Created => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "created");

    /// <summary>
    /// The environment_type attribute.
    /// </summary>
    [TerraformPropertyName("environment_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EnvironmentType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "environment_type");

    /// <summary>
    /// The fleet_service_role attribute.
    /// </summary>
    [TerraformPropertyName("fleet_service_role")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> FleetServiceRole => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "fleet_service_role");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The image_id attribute.
    /// </summary>
    [TerraformPropertyName("image_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ImageId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "image_id");

    /// <summary>
    /// The last_modified attribute.
    /// </summary>
    [TerraformPropertyName("last_modified")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LastModified => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "last_modified");

    /// <summary>
    /// The overflow_behavior attribute.
    /// </summary>
    [TerraformPropertyName("overflow_behavior")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OverflowBehavior => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "overflow_behavior");

    /// <summary>
    /// The scaling_configuration attribute.
    /// </summary>
    [TerraformPropertyName("scaling_configuration")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ScalingConfiguration => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "scaling_configuration");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> Status => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "status");

    /// <summary>
    /// The vpc_config attribute.
    /// </summary>
    [TerraformPropertyName("vpc_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> VpcConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "vpc_config");

}
