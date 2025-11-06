using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_cloudhsm_v2_cluster.
/// </summary>
public class AwsCloudhsmV2ClusterDataSource : TerraformDataSource
{
    public AwsCloudhsmV2ClusterDataSource(string name) : base("aws_cloudhsm_v2_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("cluster_certificates");
        this.DeclareOutput("security_group_id");
        this.DeclareOutput("subnet_ids");
        this.DeclareOutput("vpc_id");
    }

    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    public string? ClusterId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cluster_id")?.Value;
        set => this.WithProperty("cluster_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The cluster_state attribute.
    /// </summary>
    public string? ClusterState
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cluster_state")?.Value;
        set => this.WithProperty("cluster_state", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The cluster_certificates attribute.
    /// </summary>
    public TerraformExpression ClusterCertificates => this["cluster_certificates"];

    /// <summary>
    /// The security_group_id attribute.
    /// </summary>
    public TerraformExpression SecurityGroupId => this["security_group_id"];

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public TerraformExpression SubnetIds => this["subnet_ids"];

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformExpression VpcId => this["vpc_id"];

}
