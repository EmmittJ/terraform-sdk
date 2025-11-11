using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_odb_cloud_autonomous_vm_clusters.
/// </summary>
public partial class AwsOdbCloudAutonomousVmClustersDataSource : TerraformDataSource
{
    public AwsOdbCloudAutonomousVmClustersDataSource(string name) : base("aws_odb_cloud_autonomous_vm_clusters", name)
    {
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// List of Cloud Autonomous VM Clusters. The list going to contain basic information about the cloud autonomous VM clusters.
    /// </summary>
    [TerraformProperty("cloud_autonomous_vm_clusters")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> CloudAutonomousVmClusters { get; }

}
