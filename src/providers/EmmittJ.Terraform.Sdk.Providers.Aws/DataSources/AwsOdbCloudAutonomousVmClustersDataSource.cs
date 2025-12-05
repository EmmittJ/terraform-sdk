using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_odb_cloud_autonomous_vm_clusters Terraform data source.
/// Retrieves information about a aws_odb_cloud_autonomous_vm_clusters.
/// </summary>
public partial class AwsOdbCloudAutonomousVmClustersDataSource(string name) : TerraformDataSource("aws_odb_cloud_autonomous_vm_clusters", name)
{
    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// List of Cloud Autonomous VM Clusters. The list going to contain basic information about the cloud autonomous VM clusters.
    /// </summary>
    public TerraformList<TerraformMap<object>> CloudAutonomousVmClusters
        => CreateReference("cloud_autonomous_vm_clusters");

}
