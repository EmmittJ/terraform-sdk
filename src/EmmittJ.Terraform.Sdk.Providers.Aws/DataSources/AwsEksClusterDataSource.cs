using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_eks_cluster.
/// </summary>
public class AwsEksClusterDataSource : TerraformDataSource
{
    public AwsEksClusterDataSource(string name) : base("aws_eks_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("access_config");
        this.DeclareOutput("arn");
        this.DeclareOutput("certificate_authority");
        this.DeclareOutput("cluster_id");
        this.DeclareOutput("compute_config");
        this.DeclareOutput("created_at");
        this.DeclareOutput("deletion_protection");
        this.DeclareOutput("enabled_cluster_log_types");
        this.DeclareOutput("endpoint");
        this.DeclareOutput("identity");
        this.DeclareOutput("kubernetes_network_config");
        this.DeclareOutput("outpost_config");
        this.DeclareOutput("platform_version");
        this.DeclareOutput("remote_network_config");
        this.DeclareOutput("role_arn");
        this.DeclareOutput("status");
        this.DeclareOutput("storage_config");
        this.DeclareOutput("upgrade_policy");
        this.DeclareOutput("version");
        this.DeclareOutput("vpc_config");
        this.DeclareOutput("zonal_shift_config");
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The access_config attribute.
    /// </summary>
    public TerraformExpression AccessConfig => this["access_config"];

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The certificate_authority attribute.
    /// </summary>
    public TerraformExpression CertificateAuthority => this["certificate_authority"];

    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    public TerraformExpression ClusterId => this["cluster_id"];

    /// <summary>
    /// The compute_config attribute.
    /// </summary>
    public TerraformExpression ComputeConfig => this["compute_config"];

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformExpression CreatedAt => this["created_at"];

    /// <summary>
    /// The deletion_protection attribute.
    /// </summary>
    public TerraformExpression DeletionProtection => this["deletion_protection"];

    /// <summary>
    /// The enabled_cluster_log_types attribute.
    /// </summary>
    public TerraformExpression EnabledClusterLogTypes => this["enabled_cluster_log_types"];

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformExpression Endpoint => this["endpoint"];

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformExpression Identity => this["identity"];

    /// <summary>
    /// The kubernetes_network_config attribute.
    /// </summary>
    public TerraformExpression KubernetesNetworkConfig => this["kubernetes_network_config"];

    /// <summary>
    /// The outpost_config attribute.
    /// </summary>
    public TerraformExpression OutpostConfig => this["outpost_config"];

    /// <summary>
    /// The platform_version attribute.
    /// </summary>
    public TerraformExpression PlatformVersion => this["platform_version"];

    /// <summary>
    /// The remote_network_config attribute.
    /// </summary>
    public TerraformExpression RemoteNetworkConfig => this["remote_network_config"];

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformExpression RoleArn => this["role_arn"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The storage_config attribute.
    /// </summary>
    public TerraformExpression StorageConfig => this["storage_config"];

    /// <summary>
    /// The upgrade_policy attribute.
    /// </summary>
    public TerraformExpression UpgradePolicy => this["upgrade_policy"];

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformExpression Version => this["version"];

    /// <summary>
    /// The vpc_config attribute.
    /// </summary>
    public TerraformExpression VpcConfig => this["vpc_config"];

    /// <summary>
    /// The zonal_shift_config attribute.
    /// </summary>
    public TerraformExpression ZonalShiftConfig => this["zonal_shift_config"];

}
