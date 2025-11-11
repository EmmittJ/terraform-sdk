using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_redshift_snapshot_copy resource.
/// </summary>
public partial class AwsRedshiftSnapshotCopy : TerraformResource
{
    public AwsRedshiftSnapshotCopy(string name) : base("aws_redshift_snapshot_copy", name)
    {
    }

    /// <summary>
    /// The cluster_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterIdentifier is required")]
    [TerraformProperty("cluster_identifier")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ClusterIdentifier { get; set; }

    /// <summary>
    /// The destination_region attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationRegion is required")]
    [TerraformProperty("destination_region")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DestinationRegion { get; set; }

    /// <summary>
    /// The manual_snapshot_retention_period attribute.
    /// </summary>
    [TerraformProperty("manual_snapshot_retention_period")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> ManualSnapshotRetentionPeriod { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The retention_period attribute.
    /// </summary>
    [TerraformProperty("retention_period")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> RetentionPeriod { get; set; }

    /// <summary>
    /// The snapshot_copy_grant_name attribute.
    /// </summary>
    [TerraformProperty("snapshot_copy_grant_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SnapshotCopyGrantName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Id { get; }

}
