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
        this.WithOutput("cluster_certificates");
        this.WithOutput("security_group_id");
        this.WithOutput("subnet_ids");
        this.WithOutput("vpc_id");
    }

    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterId is required")]
    public required TerraformProperty<string> ClusterId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("cluster_id");
        set => this.WithProperty("cluster_id", value);
    }

    /// <summary>
    /// The cluster_state attribute.
    /// </summary>
    public TerraformProperty<string>? ClusterState
    {
        get => GetProperty<TerraformProperty<string>>("cluster_state");
        set => this.WithProperty("cluster_state", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
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
