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
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Tags { get; set; } = default!;

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The base_capacity attribute.
    /// </summary>
    [TerraformPropertyName("base_capacity")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> BaseCapacity => new TerraformReference(this, "base_capacity");

    /// <summary>
    /// The compute_configuration attribute.
    /// </summary>
    [TerraformPropertyName("compute_configuration")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ComputeConfiguration => new TerraformReference(this, "compute_configuration");

    /// <summary>
    /// The compute_type attribute.
    /// </summary>
    [TerraformPropertyName("compute_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ComputeType => new TerraformReference(this, "compute_type");

    /// <summary>
    /// The created attribute.
    /// </summary>
    [TerraformPropertyName("created")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Created => new TerraformReference(this, "created");

    /// <summary>
    /// The environment_type attribute.
    /// </summary>
    [TerraformPropertyName("environment_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> EnvironmentType => new TerraformReference(this, "environment_type");

    /// <summary>
    /// The fleet_service_role attribute.
    /// </summary>
    [TerraformPropertyName("fleet_service_role")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> FleetServiceRole => new TerraformReference(this, "fleet_service_role");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Id => new TerraformReference(this, "id");

    /// <summary>
    /// The image_id attribute.
    /// </summary>
    [TerraformPropertyName("image_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ImageId => new TerraformReference(this, "image_id");

    /// <summary>
    /// The last_modified attribute.
    /// </summary>
    [TerraformPropertyName("last_modified")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LastModified => new TerraformReference(this, "last_modified");

    /// <summary>
    /// The overflow_behavior attribute.
    /// </summary>
    [TerraformPropertyName("overflow_behavior")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OverflowBehavior => new TerraformReference(this, "overflow_behavior");

    /// <summary>
    /// The scaling_configuration attribute.
    /// </summary>
    [TerraformPropertyName("scaling_configuration")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ScalingConfiguration => new TerraformReference(this, "scaling_configuration");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformSet<object> Status => new TerraformReference(this, "status");

    /// <summary>
    /// The vpc_config attribute.
    /// </summary>
    [TerraformPropertyName("vpc_config")]
    // Output-only attribute - read-only reference
    public TerraformList<object> VpcConfig => new TerraformReference(this, "vpc_config");

}
