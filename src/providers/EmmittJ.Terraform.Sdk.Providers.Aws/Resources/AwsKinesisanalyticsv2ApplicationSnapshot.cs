using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsKinesisanalyticsv2ApplicationSnapshotTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

}

/// <summary>
/// Manages a aws_kinesisanalyticsv2_application_snapshot resource.
/// </summary>
public partial class AwsKinesisanalyticsv2ApplicationSnapshot : TerraformResource
{
    public AwsKinesisanalyticsv2ApplicationSnapshot(string name) : base("aws_kinesisanalyticsv2_application_snapshot", name)
    {
    }

    /// <summary>
    /// The application_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationName is required")]
    [TerraformProperty("application_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ApplicationName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The snapshot_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SnapshotName is required")]
    [TerraformProperty("snapshot_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SnapshotName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AwsKinesisanalyticsv2ApplicationSnapshotTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The application_version_id attribute.
    /// </summary>
    [TerraformProperty("application_version_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> ApplicationVersionId { get; }

    /// <summary>
    /// The snapshot_creation_timestamp attribute.
    /// </summary>
    [TerraformProperty("snapshot_creation_timestamp")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SnapshotCreationTimestamp { get; }

}
