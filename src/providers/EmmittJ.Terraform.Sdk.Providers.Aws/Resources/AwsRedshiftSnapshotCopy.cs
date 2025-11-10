using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_redshift_snapshot_copy resource.
/// </summary>
public class AwsRedshiftSnapshotCopy : TerraformResource
{
    public AwsRedshiftSnapshotCopy(string name) : base("aws_redshift_snapshot_copy", name)
    {
    }

    /// <summary>
    /// The cluster_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterIdentifier is required")]
    [TerraformPropertyName("cluster_identifier")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ClusterIdentifier { get; set; }

    /// <summary>
    /// The destination_region attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationRegion is required")]
    [TerraformPropertyName("destination_region")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DestinationRegion { get; set; }

    /// <summary>
    /// The manual_snapshot_retention_period attribute.
    /// </summary>
    [TerraformPropertyName("manual_snapshot_retention_period")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> ManualSnapshotRetentionPeriod { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "manual_snapshot_retention_period");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The retention_period attribute.
    /// </summary>
    [TerraformPropertyName("retention_period")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> RetentionPeriod { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "retention_period");

    /// <summary>
    /// The snapshot_copy_grant_name attribute.
    /// </summary>
    [TerraformPropertyName("snapshot_copy_grant_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SnapshotCopyGrantName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

}
