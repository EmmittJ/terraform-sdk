using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for access_config in AwsEksCluster.
/// Nesting mode: list
/// </summary>
public class AwsEksClusterAccessConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "access_config";

    /// <summary>
    /// The authentication_mode attribute.
    /// </summary>
    public TerraformValue<string> AuthenticationMode
    {
        get => new TerraformReference<string>(this, "authentication_mode");
        set => SetArgument("authentication_mode", value);
    }

    /// <summary>
    /// The bootstrap_cluster_creator_admin_permissions attribute.
    /// </summary>
    public TerraformValue<bool>? BootstrapClusterCreatorAdminPermissions
    {
        get => new TerraformReference<bool>(this, "bootstrap_cluster_creator_admin_permissions");
        set => SetArgument("bootstrap_cluster_creator_admin_permissions", value);
    }

}


/// <summary>
/// Block type for compute_config in AwsEksCluster.
/// Nesting mode: list
/// </summary>
public class AwsEksClusterComputeConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "compute_config";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool> Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The node_pools attribute.
    /// </summary>
    public TerraformSet<string>? NodePools
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "node_pools").ResolveNodes(ctx));
        set => SetArgument("node_pools", value);
    }

    /// <summary>
    /// The node_role_arn attribute.
    /// </summary>
    public TerraformValue<string>? NodeRoleArn
    {
        get => new TerraformReference<string>(this, "node_role_arn");
        set => SetArgument("node_role_arn", value);
    }

}


/// <summary>
/// Block type for encryption_config in AwsEksCluster.
/// Nesting mode: list
/// </summary>
public class AwsEksClusterEncryptionConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "encryption_config";

    /// <summary>
    /// The resources attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Resources is required")]
    public required TerraformSet<string> Resources
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "resources").ResolveNodes(ctx));
        set => SetArgument("resources", value);
    }

    /// <summary>
    /// ProviderAttribute block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProviderAttribute is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ProviderAttribute block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ProviderAttribute block(s) allowed")]
    public required TerraformList<AwsEksClusterEncryptionConfigBlockProviderAttributeBlock> ProviderAttribute
    {
        get => GetRequiredArgument<TerraformList<AwsEksClusterEncryptionConfigBlockProviderAttributeBlock>>("provider");
        set => SetArgument("provider", value);
    }

}

/// <summary>
/// Block type for provider in AwsEksClusterEncryptionConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsEksClusterEncryptionConfigBlockProviderAttributeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "provider";

    /// <summary>
    /// The key_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyArn is required")]
    public required TerraformValue<string> KeyArn
    {
        get => new TerraformReference<string>(this, "key_arn");
        set => SetArgument("key_arn", value);
    }

}


/// <summary>
/// Block type for kubernetes_network_config in AwsEksCluster.
/// Nesting mode: list
/// </summary>
public class AwsEksClusterKubernetesNetworkConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "kubernetes_network_config";

    /// <summary>
    /// The ip_family attribute.
    /// </summary>
    public TerraformValue<string> IpFamily
    {
        get => new TerraformReference<string>(this, "ip_family");
        set => SetArgument("ip_family", value);
    }

    /// <summary>
    /// The service_ipv4_cidr attribute.
    /// </summary>
    public TerraformValue<string> ServiceIpv4Cidr
    {
        get => new TerraformReference<string>(this, "service_ipv4_cidr");
        set => SetArgument("service_ipv4_cidr", value);
    }

    /// <summary>
    /// The service_ipv6_cidr attribute.
    /// </summary>
    public TerraformValue<string> ServiceIpv6Cidr
    {
        get => new TerraformReference<string>(this, "service_ipv6_cidr");
    }

    /// <summary>
    /// ElasticLoadBalancing block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ElasticLoadBalancing block(s) allowed")]
    public TerraformList<AwsEksClusterKubernetesNetworkConfigBlockElasticLoadBalancingBlock>? ElasticLoadBalancing
    {
        get => GetArgument<TerraformList<AwsEksClusterKubernetesNetworkConfigBlockElasticLoadBalancingBlock>>("elastic_load_balancing");
        set => SetArgument("elastic_load_balancing", value);
    }

}

/// <summary>
/// Block type for elastic_load_balancing in AwsEksClusterKubernetesNetworkConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsEksClusterKubernetesNetworkConfigBlockElasticLoadBalancingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "elastic_load_balancing";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool> Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

}


/// <summary>
/// Block type for outpost_config in AwsEksCluster.
/// Nesting mode: list
/// </summary>
public class AwsEksClusterOutpostConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "outpost_config";

    /// <summary>
    /// The control_plane_instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ControlPlaneInstanceType is required")]
    public required TerraformValue<string> ControlPlaneInstanceType
    {
        get => new TerraformReference<string>(this, "control_plane_instance_type");
        set => SetArgument("control_plane_instance_type", value);
    }

    /// <summary>
    /// The outpost_arns attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OutpostArns is required")]
    public required TerraformSet<string> OutpostArns
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "outpost_arns").ResolveNodes(ctx));
        set => SetArgument("outpost_arns", value);
    }

    /// <summary>
    /// ControlPlanePlacement block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ControlPlanePlacement block(s) allowed")]
    public TerraformList<AwsEksClusterOutpostConfigBlockControlPlanePlacementBlock>? ControlPlanePlacement
    {
        get => GetArgument<TerraformList<AwsEksClusterOutpostConfigBlockControlPlanePlacementBlock>>("control_plane_placement");
        set => SetArgument("control_plane_placement", value);
    }

}

/// <summary>
/// Block type for control_plane_placement in AwsEksClusterOutpostConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsEksClusterOutpostConfigBlockControlPlanePlacementBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "control_plane_placement";

    /// <summary>
    /// The group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GroupName is required")]
    public required TerraformValue<string> GroupName
    {
        get => new TerraformReference<string>(this, "group_name");
        set => SetArgument("group_name", value);
    }

}


/// <summary>
/// Block type for remote_network_config in AwsEksCluster.
/// Nesting mode: list
/// </summary>
public class AwsEksClusterRemoteNetworkConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "remote_network_config";

    /// <summary>
    /// RemoteNodeNetworks block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RemoteNodeNetworks is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 RemoteNodeNetworks block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RemoteNodeNetworks block(s) allowed")]
    public required TerraformList<AwsEksClusterRemoteNetworkConfigBlockRemoteNodeNetworksBlock> RemoteNodeNetworks
    {
        get => GetRequiredArgument<TerraformList<AwsEksClusterRemoteNetworkConfigBlockRemoteNodeNetworksBlock>>("remote_node_networks");
        set => SetArgument("remote_node_networks", value);
    }

    /// <summary>
    /// RemotePodNetworks block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RemotePodNetworks block(s) allowed")]
    public TerraformList<AwsEksClusterRemoteNetworkConfigBlockRemotePodNetworksBlock>? RemotePodNetworks
    {
        get => GetArgument<TerraformList<AwsEksClusterRemoteNetworkConfigBlockRemotePodNetworksBlock>>("remote_pod_networks");
        set => SetArgument("remote_pod_networks", value);
    }

}

/// <summary>
/// Block type for remote_node_networks in AwsEksClusterRemoteNetworkConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsEksClusterRemoteNetworkConfigBlockRemoteNodeNetworksBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "remote_node_networks";

    /// <summary>
    /// The cidrs attribute.
    /// </summary>
    public TerraformSet<string>? Cidrs
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "cidrs").ResolveNodes(ctx));
        set => SetArgument("cidrs", value);
    }

}

/// <summary>
/// Block type for remote_pod_networks in AwsEksClusterRemoteNetworkConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsEksClusterRemoteNetworkConfigBlockRemotePodNetworksBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "remote_pod_networks";

    /// <summary>
    /// The cidrs attribute.
    /// </summary>
    public TerraformSet<string>? Cidrs
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "cidrs").ResolveNodes(ctx));
        set => SetArgument("cidrs", value);
    }

}


/// <summary>
/// Block type for storage_config in AwsEksCluster.
/// Nesting mode: list
/// </summary>
public class AwsEksClusterStorageConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "storage_config";

    /// <summary>
    /// BlockStorage block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BlockStorage block(s) allowed")]
    public TerraformList<AwsEksClusterStorageConfigBlockBlockStorageBlock>? BlockStorage
    {
        get => GetArgument<TerraformList<AwsEksClusterStorageConfigBlockBlockStorageBlock>>("block_storage");
        set => SetArgument("block_storage", value);
    }

}

/// <summary>
/// Block type for block_storage in AwsEksClusterStorageConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsEksClusterStorageConfigBlockBlockStorageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "block_storage";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool> Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsEksCluster.
/// Nesting mode: single
/// </summary>
public class AwsEksClusterTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Block type for upgrade_policy in AwsEksCluster.
/// Nesting mode: list
/// </summary>
public class AwsEksClusterUpgradePolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "upgrade_policy";

    /// <summary>
    /// The support_type attribute.
    /// </summary>
    public TerraformValue<string> SupportType
    {
        get => new TerraformReference<string>(this, "support_type");
        set => SetArgument("support_type", value);
    }

}


/// <summary>
/// Block type for vpc_config in AwsEksCluster.
/// Nesting mode: list
/// </summary>
public class AwsEksClusterVpcConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "vpc_config";

    /// <summary>
    /// The cluster_security_group_id attribute.
    /// </summary>
    public TerraformValue<string> ClusterSecurityGroupId
    {
        get => new TerraformReference<string>(this, "cluster_security_group_id");
    }

    /// <summary>
    /// The endpoint_private_access attribute.
    /// </summary>
    public TerraformValue<bool>? EndpointPrivateAccess
    {
        get => new TerraformReference<bool>(this, "endpoint_private_access");
        set => SetArgument("endpoint_private_access", value);
    }

    /// <summary>
    /// The endpoint_public_access attribute.
    /// </summary>
    public TerraformValue<bool>? EndpointPublicAccess
    {
        get => new TerraformReference<bool>(this, "endpoint_public_access");
        set => SetArgument("endpoint_public_access", value);
    }

    /// <summary>
    /// The public_access_cidrs attribute.
    /// </summary>
    public TerraformSet<string> PublicAccessCidrs
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "public_access_cidrs").ResolveNodes(ctx));
        set => SetArgument("public_access_cidrs", value);
    }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public TerraformSet<string>? SecurityGroupIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "security_group_ids").ResolveNodes(ctx));
        set => SetArgument("security_group_ids", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    public required TerraformSet<string> SubnetIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "subnet_ids").ResolveNodes(ctx));
        set => SetArgument("subnet_ids", value);
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformValue<string> VpcId
    {
        get => new TerraformReference<string>(this, "vpc_id");
    }

}


/// <summary>
/// Block type for zonal_shift_config in AwsEksCluster.
/// Nesting mode: list
/// </summary>
public class AwsEksClusterZonalShiftConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "zonal_shift_config";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

}


/// <summary>
/// Represents a aws_eks_cluster Terraform resource.
/// Manages a aws_eks_cluster resource.
/// </summary>
public partial class AwsEksCluster(string name) : TerraformResource("aws_eks_cluster", name)
{
    /// <summary>
    /// The bootstrap_self_managed_addons attribute.
    /// </summary>
    public TerraformValue<bool>? BootstrapSelfManagedAddons
    {
        get => new TerraformReference<bool>(this, "bootstrap_self_managed_addons");
        set => SetArgument("bootstrap_self_managed_addons", value);
    }

    /// <summary>
    /// The deletion_protection attribute.
    /// </summary>
    public TerraformValue<bool> DeletionProtection
    {
        get => new TerraformReference<bool>(this, "deletion_protection");
        set => SetArgument("deletion_protection", value);
    }

    /// <summary>
    /// The enabled_cluster_log_types attribute.
    /// </summary>
    public TerraformSet<string>? EnabledClusterLogTypes
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "enabled_cluster_log_types").ResolveNodes(ctx));
        set => SetArgument("enabled_cluster_log_types", value);
    }

    /// <summary>
    /// The force_update_version attribute.
    /// </summary>
    public TerraformValue<bool>? ForceUpdateVersion
    {
        get => new TerraformReference<bool>(this, "force_update_version");
        set => SetArgument("force_update_version", value);
    }

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
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformValue<string> RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string> Version
    {
        get => new TerraformReference<string>(this, "version");
        set => SetArgument("version", value);
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
    /// The created_at attribute.
    /// </summary>
    public TerraformValue<string> CreatedAt
    {
        get => new TerraformReference<string>(this, "created_at");
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
    /// The platform_version attribute.
    /// </summary>
    public TerraformValue<string> PlatformVersion
    {
        get => new TerraformReference<string>(this, "platform_version");
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

    /// <summary>
    /// AccessConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccessConfig block(s) allowed")]
    public TerraformList<AwsEksClusterAccessConfigBlock>? AccessConfig
    {
        get => GetArgument<TerraformList<AwsEksClusterAccessConfigBlock>>("access_config");
        set => SetArgument("access_config", value);
    }

    /// <summary>
    /// ComputeConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ComputeConfig block(s) allowed")]
    public TerraformList<AwsEksClusterComputeConfigBlock>? ComputeConfig
    {
        get => GetArgument<TerraformList<AwsEksClusterComputeConfigBlock>>("compute_config");
        set => SetArgument("compute_config", value);
    }

    /// <summary>
    /// EncryptionConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionConfig block(s) allowed")]
    public TerraformList<AwsEksClusterEncryptionConfigBlock>? EncryptionConfig
    {
        get => GetArgument<TerraformList<AwsEksClusterEncryptionConfigBlock>>("encryption_config");
        set => SetArgument("encryption_config", value);
    }

    /// <summary>
    /// KubernetesNetworkConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KubernetesNetworkConfig block(s) allowed")]
    public TerraformList<AwsEksClusterKubernetesNetworkConfigBlock>? KubernetesNetworkConfig
    {
        get => GetArgument<TerraformList<AwsEksClusterKubernetesNetworkConfigBlock>>("kubernetes_network_config");
        set => SetArgument("kubernetes_network_config", value);
    }

    /// <summary>
    /// OutpostConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OutpostConfig block(s) allowed")]
    public TerraformList<AwsEksClusterOutpostConfigBlock>? OutpostConfig
    {
        get => GetArgument<TerraformList<AwsEksClusterOutpostConfigBlock>>("outpost_config");
        set => SetArgument("outpost_config", value);
    }

    /// <summary>
    /// RemoteNetworkConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RemoteNetworkConfig block(s) allowed")]
    public TerraformList<AwsEksClusterRemoteNetworkConfigBlock>? RemoteNetworkConfig
    {
        get => GetArgument<TerraformList<AwsEksClusterRemoteNetworkConfigBlock>>("remote_network_config");
        set => SetArgument("remote_network_config", value);
    }

    /// <summary>
    /// StorageConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageConfig block(s) allowed")]
    public TerraformList<AwsEksClusterStorageConfigBlock>? StorageConfig
    {
        get => GetArgument<TerraformList<AwsEksClusterStorageConfigBlock>>("storage_config");
        set => SetArgument("storage_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsEksClusterTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsEksClusterTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// UpgradePolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UpgradePolicy block(s) allowed")]
    public TerraformList<AwsEksClusterUpgradePolicyBlock>? UpgradePolicy
    {
        get => GetArgument<TerraformList<AwsEksClusterUpgradePolicyBlock>>("upgrade_policy");
        set => SetArgument("upgrade_policy", value);
    }

    /// <summary>
    /// VpcConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 VpcConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcConfig block(s) allowed")]
    public required TerraformList<AwsEksClusterVpcConfigBlock> VpcConfig
    {
        get => GetRequiredArgument<TerraformList<AwsEksClusterVpcConfigBlock>>("vpc_config");
        set => SetArgument("vpc_config", value);
    }

    /// <summary>
    /// ZonalShiftConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ZonalShiftConfig block(s) allowed")]
    public TerraformList<AwsEksClusterZonalShiftConfigBlock>? ZonalShiftConfig
    {
        get => GetArgument<TerraformList<AwsEksClusterZonalShiftConfigBlock>>("zonal_shift_config");
        set => SetArgument("zonal_shift_config", value);
    }

}
