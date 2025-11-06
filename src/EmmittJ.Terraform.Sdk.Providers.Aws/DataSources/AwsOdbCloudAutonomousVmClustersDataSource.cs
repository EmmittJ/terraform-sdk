using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_odb_cloud_autonomous_vm_clusters.
/// </summary>
public class AwsOdbCloudAutonomousVmClustersDataSource : TerraformDataSource
{
    public AwsOdbCloudAutonomousVmClustersDataSource(string name) : base("aws_odb_cloud_autonomous_vm_clusters", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("cloud_autonomous_vm_clusters");
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// List of Cloud Autonomous VM Clusters. The list going to contain basic information about the cloud autonomous VM clusters.
    /// </summary>
    public TerraformExpression CloudAutonomousVmClusters => this["cloud_autonomous_vm_clusters"];

}
