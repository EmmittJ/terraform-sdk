using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_odb_cloud_vm_clusters Terraform data source.
/// Retrieves information about a aws_odb_cloud_vm_clusters.
/// </summary>
public partial class AwsOdbCloudVmClustersDataSource(string name) : TerraformDataSource("aws_odb_cloud_vm_clusters", name)
{
    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// List of Cloud VM Clusters. It returns only basic information about the cloud VM clusters.
    /// </summary>
    public TerraformList<TerraformMap<object>> CloudVmClusters
        => AsReference("cloud_vm_clusters");

}
