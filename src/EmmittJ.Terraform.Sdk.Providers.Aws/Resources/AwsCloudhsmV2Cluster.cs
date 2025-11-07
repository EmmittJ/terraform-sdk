using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cloudhsm_v2_cluster resource.
/// </summary>
public class AwsCloudhsmV2Cluster : TerraformResource
{
    public AwsCloudhsmV2Cluster(string name) : base("aws_cloudhsm_v2_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("cluster_certificates");
        this.DeclareOutput("cluster_id");
        this.DeclareOutput("cluster_state");
        this.DeclareOutput("security_group_id");
        this.DeclareOutput("vpc_id");
    }

    /// <summary>
    /// The hsm_type attribute.
    /// </summary>
    public TerraformProperty<string>? HsmType
    {
        get => GetProperty<TerraformProperty<string>>("hsm_type");
        set => this.WithProperty("hsm_type", value);
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
    /// The mode attribute.
    /// </summary>
    public TerraformProperty<string>? Mode
    {
        get => GetProperty<TerraformProperty<string>>("mode");
        set => this.WithProperty("mode", value);
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
    /// The source_backup_identifier attribute.
    /// </summary>
    public TerraformProperty<string>? SourceBackupIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("source_backup_identifier");
        set => this.WithProperty("source_backup_identifier", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? SubnetIds
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("subnet_ids");
        set => this.WithProperty("subnet_ids", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The cluster_certificates attribute.
    /// </summary>
    public TerraformExpression ClusterCertificates => this["cluster_certificates"];

    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    public TerraformExpression ClusterId => this["cluster_id"];

    /// <summary>
    /// The cluster_state attribute.
    /// </summary>
    public TerraformExpression ClusterState => this["cluster_state"];

    /// <summary>
    /// The security_group_id attribute.
    /// </summary>
    public TerraformExpression SecurityGroupId => this["security_group_id"];

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformExpression VpcId => this["vpc_id"];

}
