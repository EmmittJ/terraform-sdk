using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_codebuild_fleet.
/// </summary>
public partial class AwsCodebuildFleetDataSource : TerraformDataSource
{
    public AwsCodebuildFleetDataSource(string name) : base("aws_codebuild_fleet", name)
    {
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The base_capacity attribute.
    /// </summary>
    [TerraformProperty("base_capacity")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> BaseCapacity { get; }

    /// <summary>
    /// The compute_configuration attribute.
    /// </summary>
    [TerraformProperty("compute_configuration")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> ComputeConfiguration { get; }

    /// <summary>
    /// The compute_type attribute.
    /// </summary>
    [TerraformProperty("compute_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ComputeType { get; }

    /// <summary>
    /// The created attribute.
    /// </summary>
    [TerraformProperty("created")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Created { get; }

    /// <summary>
    /// The environment_type attribute.
    /// </summary>
    [TerraformProperty("environment_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> EnvironmentType { get; }

    /// <summary>
    /// The fleet_service_role attribute.
    /// </summary>
    [TerraformProperty("fleet_service_role")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> FleetServiceRole { get; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Id { get; }

    /// <summary>
    /// The image_id attribute.
    /// </summary>
    [TerraformProperty("image_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ImageId { get; }

    /// <summary>
    /// The last_modified attribute.
    /// </summary>
    [TerraformProperty("last_modified")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LastModified { get; }

    /// <summary>
    /// The overflow_behavior attribute.
    /// </summary>
    [TerraformProperty("overflow_behavior")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> OverflowBehavior { get; }

    /// <summary>
    /// The scaling_configuration attribute.
    /// </summary>
    [TerraformProperty("scaling_configuration")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> ScalingConfiguration { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<object> Status { get; }

    /// <summary>
    /// The vpc_config attribute.
    /// </summary>
    [TerraformProperty("vpc_config")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> VpcConfig { get; }

}
