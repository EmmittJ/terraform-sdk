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
        SetOutput("access_config");
        SetOutput("arn");
        SetOutput("certificate_authority");
        SetOutput("cluster_id");
        SetOutput("compute_config");
        SetOutput("created_at");
        SetOutput("deletion_protection");
        SetOutput("enabled_cluster_log_types");
        SetOutput("endpoint");
        SetOutput("identity");
        SetOutput("kubernetes_network_config");
        SetOutput("outpost_config");
        SetOutput("platform_version");
        SetOutput("remote_network_config");
        SetOutput("role_arn");
        SetOutput("status");
        SetOutput("storage_config");
        SetOutput("upgrade_policy");
        SetOutput("version");
        SetOutput("vpc_config");
        SetOutput("zonal_shift_config");
        SetOutput("id");
        SetOutput("name");
        SetOutput("region");
        SetOutput("tags");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
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
