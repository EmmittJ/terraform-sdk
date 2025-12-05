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
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => GetArgument<TerraformMap<string>>("tags") ?? CreateReference("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The access_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> AccessConfig
        => CreateReference("access_config");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The certificate_authority attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> CertificateAuthority
        => CreateReference("certificate_authority");

    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    public TerraformValue<string> ClusterId
        => CreateReference("cluster_id");

    /// <summary>
    /// The compute_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ComputeConfig
        => CreateReference("compute_config");

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformValue<string> CreatedAt
        => CreateReference("created_at");

    /// <summary>
    /// The deletion_protection attribute.
    /// </summary>
    public TerraformValue<bool> DeletionProtection
        => CreateReference("deletion_protection");

    /// <summary>
    /// The enabled_cluster_log_types attribute.
    /// </summary>
    public TerraformSet<string> EnabledClusterLogTypes
        => CreateReference("enabled_cluster_log_types");

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformValue<string> Endpoint
        => CreateReference("endpoint");

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Identity
        => CreateReference("identity");

    /// <summary>
    /// The kubernetes_network_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> KubernetesNetworkConfig
        => CreateReference("kubernetes_network_config");

    /// <summary>
    /// The outpost_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> OutpostConfig
        => CreateReference("outpost_config");

    /// <summary>
    /// The platform_version attribute.
    /// </summary>
    public TerraformValue<string> PlatformVersion
        => CreateReference("platform_version");

    /// <summary>
    /// The remote_network_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> RemoteNetworkConfig
        => CreateReference("remote_network_config");

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformValue<string> RoleArn
        => CreateReference("role_arn");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => CreateReference("status");

    /// <summary>
    /// The storage_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> StorageConfig
        => CreateReference("storage_config");

    /// <summary>
    /// The upgrade_policy attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> UpgradePolicy
        => CreateReference("upgrade_policy");

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string> Version
        => CreateReference("version");

    /// <summary>
    /// The vpc_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> VpcConfig
        => CreateReference("vpc_config");

    /// <summary>
    /// The zonal_shift_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ZonalShiftConfig
        => CreateReference("zonal_shift_config");

}
