using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_eks_cluster Terraform data source.
/// Retrieves information about a aws_eks_cluster.
/// </summary>
public partial class AwsEksClusterDataSource(string name) : TerraformDataSource("aws_eks_cluster", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The access_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> AccessConfig
        => AsReference("access_config");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The certificate_authority attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> CertificateAuthority
        => AsReference("certificate_authority");

    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    public TerraformValue<string> ClusterId
        => AsReference("cluster_id");

    /// <summary>
    /// The compute_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ComputeConfig
        => AsReference("compute_config");

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformValue<string> CreatedAt
        => AsReference("created_at");

    /// <summary>
    /// The deletion_protection attribute.
    /// </summary>
    public TerraformValue<bool> DeletionProtection
        => AsReference("deletion_protection");

    /// <summary>
    /// The enabled_cluster_log_types attribute.
    /// </summary>
    public TerraformSet<string> EnabledClusterLogTypes
        => AsReference("enabled_cluster_log_types");

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformValue<string> Endpoint
        => AsReference("endpoint");

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Identity
        => AsReference("identity");

    /// <summary>
    /// The kubernetes_network_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> KubernetesNetworkConfig
        => AsReference("kubernetes_network_config");

    /// <summary>
    /// The outpost_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> OutpostConfig
        => AsReference("outpost_config");

    /// <summary>
    /// The platform_version attribute.
    /// </summary>
    public TerraformValue<string> PlatformVersion
        => AsReference("platform_version");

    /// <summary>
    /// The remote_network_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> RemoteNetworkConfig
        => AsReference("remote_network_config");

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformValue<string> RoleArn
        => AsReference("role_arn");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => AsReference("status");

    /// <summary>
    /// The storage_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> StorageConfig
        => AsReference("storage_config");

    /// <summary>
    /// The upgrade_policy attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> UpgradePolicy
        => AsReference("upgrade_policy");

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string> Version
        => AsReference("version");

    /// <summary>
    /// The vpc_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> VpcConfig
        => AsReference("vpc_config");

    /// <summary>
    /// The zonal_shift_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ZonalShiftConfig
        => AsReference("zonal_shift_config");

}
