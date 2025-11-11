using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_odb_cloud_autonomous_vm_clusters.
/// </summary>
public class AwsOdbCloudAutonomousVmClustersDataSource : TerraformDataSource
{
    public AwsOdbCloudAutonomousVmClustersDataSource(string name) : base("aws_odb_cloud_autonomous_vm_clusters", name)
    {
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// List of Cloud Autonomous VM Clusters. The list going to contain basic information about the cloud autonomous VM clusters.
    /// </summary>
    [TerraformPropertyName("cloud_autonomous_vm_clusters")]
    // Output-only attribute - read-only reference
    public TerraformList<object> CloudAutonomousVmClusters => new TerraformReference(this, "cloud_autonomous_vm_clusters");

}
