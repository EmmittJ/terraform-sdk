using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_odb_cloud_vm_clusters.
/// </summary>
public class AwsOdbCloudVmClustersDataSource : TerraformDataSource
{
    public AwsOdbCloudVmClustersDataSource(string name) : base("aws_odb_cloud_vm_clusters", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("cloud_vm_clusters");
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// List of Cloud VM Clusters. It returns only basic information about the cloud VM clusters.
    /// </summary>
    public TerraformExpression CloudVmClusters => this["cloud_vm_clusters"];

}
