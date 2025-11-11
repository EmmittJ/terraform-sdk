using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_odb_cloud_vm_clusters.
/// </summary>
public class AwsOdbCloudVmClustersDataSource : TerraformDataSource
{
    public AwsOdbCloudVmClustersDataSource(string name) : base("aws_odb_cloud_vm_clusters", name)
    {
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// List of Cloud VM Clusters. It returns only basic information about the cloud VM clusters.
    /// </summary>
    [TerraformPropertyName("cloud_vm_clusters")]
    // Output-only attribute - read-only reference
    public TerraformList<object> CloudVmClusters => new TerraformReference(this, "cloud_vm_clusters");

}
