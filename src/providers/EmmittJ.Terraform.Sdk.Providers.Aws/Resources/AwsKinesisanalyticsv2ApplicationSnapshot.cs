using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsKinesisanalyticsv2ApplicationSnapshotTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

}

/// <summary>
/// Manages a aws_kinesisanalyticsv2_application_snapshot resource.
/// </summary>
public class AwsKinesisanalyticsv2ApplicationSnapshot : TerraformResource
{
    public AwsKinesisanalyticsv2ApplicationSnapshot(string name) : base("aws_kinesisanalyticsv2_application_snapshot", name)
    {
    }

    /// <summary>
    /// The application_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationName is required")]
    [TerraformPropertyName("application_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ApplicationName { get; set; }

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
    /// The snapshot_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SnapshotName is required")]
    [TerraformPropertyName("snapshot_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SnapshotName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsKinesisanalyticsv2ApplicationSnapshotTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The application_version_id attribute.
    /// </summary>
    [TerraformPropertyName("application_version_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> ApplicationVersionId => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "application_version_id");

    /// <summary>
    /// The snapshot_creation_timestamp attribute.
    /// </summary>
    [TerraformPropertyName("snapshot_creation_timestamp")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SnapshotCreationTimestamp => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "snapshot_creation_timestamp");

}
