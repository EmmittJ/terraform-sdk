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
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The access_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> AccessConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "access_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The certificate_authority attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> CertificateAuthority
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "certificate_authority").ResolveNodes(ctx));
    }

    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    public TerraformValue<string> ClusterId
    {
        get => new TerraformReference<string>(this, "cluster_id");
    }

    /// <summary>
    /// The compute_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ComputeConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "compute_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformValue<string> CreatedAt
    {
        get => new TerraformReference<string>(this, "created_at");
    }

    /// <summary>
    /// The deletion_protection attribute.
    /// </summary>
    public TerraformValue<bool> DeletionProtection
    {
        get => new TerraformReference<bool>(this, "deletion_protection");
    }

    /// <summary>
    /// The enabled_cluster_log_types attribute.
    /// </summary>
    public TerraformSet<string> EnabledClusterLogTypes
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "enabled_cluster_log_types").ResolveNodes(ctx));
    }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformValue<string> Endpoint
    {
        get => new TerraformReference<string>(this, "endpoint");
    }

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Identity
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "identity").ResolveNodes(ctx));
    }

    /// <summary>
    /// The kubernetes_network_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> KubernetesNetworkConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "kubernetes_network_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// The outpost_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> OutpostConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "outpost_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// The platform_version attribute.
    /// </summary>
    public TerraformValue<string> PlatformVersion
    {
        get => new TerraformReference<string>(this, "platform_version");
    }

    /// <summary>
    /// The remote_network_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> RemoteNetworkConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "remote_network_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformValue<string> RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

    /// <summary>
    /// The storage_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> StorageConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "storage_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// The upgrade_policy attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> UpgradePolicy
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "upgrade_policy").ResolveNodes(ctx));
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string> Version
    {
        get => new TerraformReference<string>(this, "version");
    }

    /// <summary>
    /// The vpc_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> VpcConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "vpc_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// The zonal_shift_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ZonalShiftConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "zonal_shift_config").ResolveNodes(ctx));
    }

}
