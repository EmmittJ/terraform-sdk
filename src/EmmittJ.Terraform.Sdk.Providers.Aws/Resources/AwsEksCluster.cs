using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for access_config in .
/// Nesting mode: list
/// </summary>
public class AwsEksClusterAccessConfigBlock : TerraformBlock
{
    /// <summary>
    /// The authentication_mode attribute.
    /// </summary>
    public TerraformProperty<string>? AuthenticationMode
    {
        get => GetProperty<TerraformProperty<string>>("authentication_mode");
        set => WithProperty("authentication_mode", value);
    }

    /// <summary>
    /// The bootstrap_cluster_creator_admin_permissions attribute.
    /// </summary>
    public TerraformProperty<bool>? BootstrapClusterCreatorAdminPermissions
    {
        get => GetProperty<TerraformProperty<bool>>("bootstrap_cluster_creator_admin_permissions");
        set => WithProperty("bootstrap_cluster_creator_admin_permissions", value);
    }

}

/// <summary>
/// Block type for compute_config in .
/// Nesting mode: list
/// </summary>
public class AwsEksClusterComputeConfigBlock : TerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
    }

    /// <summary>
    /// The node_pools attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? NodePools
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("node_pools");
        set => WithProperty("node_pools", value);
    }

    /// <summary>
    /// The node_role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? NodeRoleArn
    {
        get => GetProperty<TerraformProperty<string>>("node_role_arn");
        set => WithProperty("node_role_arn", value);
    }

}

/// <summary>
/// Block type for encryption_config in .
/// Nesting mode: list
/// </summary>
public class AwsEksClusterEncryptionConfigBlock : TerraformBlock
{
    /// <summary>
    /// The resources attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Resources is required")]
    public HashSet<TerraformProperty<string>>? Resources
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("resources");
        set => WithProperty("resources", value);
    }

}

/// <summary>
/// Block type for kubernetes_network_config in .
/// Nesting mode: list
/// </summary>
public class AwsEksClusterKubernetesNetworkConfigBlock : TerraformBlock
{
    /// <summary>
    /// The ip_family attribute.
    /// </summary>
    public TerraformProperty<string>? IpFamily
    {
        get => GetProperty<TerraformProperty<string>>("ip_family");
        set => WithProperty("ip_family", value);
    }

    /// <summary>
    /// The service_ipv4_cidr attribute.
    /// </summary>
    public TerraformProperty<string>? ServiceIpv4Cidr
    {
        get => GetProperty<TerraformProperty<string>>("service_ipv4_cidr");
        set => WithProperty("service_ipv4_cidr", value);
    }

    /// <summary>
    /// The service_ipv6_cidr attribute.
    /// </summary>
    public TerraformProperty<string>? ServiceIpv6Cidr
    {
        get => GetProperty<TerraformProperty<string>>("service_ipv6_cidr");
        set => WithProperty("service_ipv6_cidr", value);
    }

}

/// <summary>
/// Block type for outpost_config in .
/// Nesting mode: list
/// </summary>
public class AwsEksClusterOutpostConfigBlock : TerraformBlock
{
    /// <summary>
    /// The control_plane_instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ControlPlaneInstanceType is required")]
    public required TerraformProperty<string> ControlPlaneInstanceType
    {
        get => GetProperty<TerraformProperty<string>>("control_plane_instance_type");
        set => WithProperty("control_plane_instance_type", value);
    }

    /// <summary>
    /// The outpost_arns attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OutpostArns is required")]
    public HashSet<TerraformProperty<string>>? OutpostArns
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("outpost_arns");
        set => WithProperty("outpost_arns", value);
    }

}

/// <summary>
/// Block type for remote_network_config in .
/// Nesting mode: list
/// </summary>
public class AwsEksClusterRemoteNetworkConfigBlock : TerraformBlock
{
}

/// <summary>
/// Block type for storage_config in .
/// Nesting mode: list
/// </summary>
public class AwsEksClusterStorageConfigBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsEksClusterTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Block type for upgrade_policy in .
/// Nesting mode: list
/// </summary>
public class AwsEksClusterUpgradePolicyBlock : TerraformBlock
{
    /// <summary>
    /// The support_type attribute.
    /// </summary>
    public TerraformProperty<string>? SupportType
    {
        get => GetProperty<TerraformProperty<string>>("support_type");
        set => WithProperty("support_type", value);
    }

}

/// <summary>
/// Block type for vpc_config in .
/// Nesting mode: list
/// </summary>
public class AwsEksClusterVpcConfigBlock : TerraformBlock
{
    /// <summary>
    /// The cluster_security_group_id attribute.
    /// </summary>
    public TerraformProperty<string>? ClusterSecurityGroupId
    {
        get => GetProperty<TerraformProperty<string>>("cluster_security_group_id");
        set => WithProperty("cluster_security_group_id", value);
    }

    /// <summary>
    /// The endpoint_private_access attribute.
    /// </summary>
    public TerraformProperty<bool>? EndpointPrivateAccess
    {
        get => GetProperty<TerraformProperty<bool>>("endpoint_private_access");
        set => WithProperty("endpoint_private_access", value);
    }

    /// <summary>
    /// The endpoint_public_access attribute.
    /// </summary>
    public TerraformProperty<bool>? EndpointPublicAccess
    {
        get => GetProperty<TerraformProperty<bool>>("endpoint_public_access");
        set => WithProperty("endpoint_public_access", value);
    }

    /// <summary>
    /// The public_access_cidrs attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? PublicAccessCidrs
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("public_access_cidrs");
        set => WithProperty("public_access_cidrs", value);
    }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SecurityGroupIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("security_group_ids");
        set => WithProperty("security_group_ids", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    public HashSet<TerraformProperty<string>>? SubnetIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("subnet_ids");
        set => WithProperty("subnet_ids", value);
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformProperty<string>? VpcId
    {
        get => GetProperty<TerraformProperty<string>>("vpc_id");
        set => WithProperty("vpc_id", value);
    }

}

/// <summary>
/// Block type for zonal_shift_config in .
/// Nesting mode: list
/// </summary>
public class AwsEksClusterZonalShiftConfigBlock : TerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
    }

}

/// <summary>
/// Manages a aws_eks_cluster resource.
/// </summary>
public class AwsEksCluster : TerraformResource
{
    public AwsEksCluster(string name) : base("aws_eks_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("certificate_authority");
        this.DeclareOutput("cluster_id");
        this.DeclareOutput("created_at");
        this.DeclareOutput("endpoint");
        this.DeclareOutput("identity");
        this.DeclareOutput("platform_version");
        this.DeclareOutput("status");
    }

    /// <summary>
    /// The bootstrap_self_managed_addons attribute.
    /// </summary>
    public TerraformProperty<bool>? BootstrapSelfManagedAddons
    {
        get => GetProperty<TerraformProperty<bool>>("bootstrap_self_managed_addons");
        set => this.WithProperty("bootstrap_self_managed_addons", value);
    }

    /// <summary>
    /// The deletion_protection attribute.
    /// </summary>
    public TerraformProperty<bool>? DeletionProtection
    {
        get => GetProperty<TerraformProperty<bool>>("deletion_protection");
        set => this.WithProperty("deletion_protection", value);
    }

    /// <summary>
    /// The enabled_cluster_log_types attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? EnabledClusterLogTypes
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("enabled_cluster_log_types");
        set => this.WithProperty("enabled_cluster_log_types", value);
    }

    /// <summary>
    /// The force_update_version attribute.
    /// </summary>
    public TerraformProperty<bool>? ForceUpdateVersion
    {
        get => GetProperty<TerraformProperty<bool>>("force_update_version");
        set => this.WithProperty("force_update_version", value);
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
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        get => GetProperty<TerraformProperty<string>>("role_arn");
        set => this.WithProperty("role_arn", value);
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformProperty<string>? Version
    {
        get => GetProperty<TerraformProperty<string>>("version");
        set => this.WithProperty("version", value);
    }

    /// <summary>
    /// Block for access_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccessConfig block(s) allowed")]
    public List<AwsEksClusterAccessConfigBlock>? AccessConfig
    {
        get => GetProperty<List<AwsEksClusterAccessConfigBlock>>("access_config");
        set => this.WithProperty("access_config", value);
    }

    /// <summary>
    /// Block for compute_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ComputeConfig block(s) allowed")]
    public List<AwsEksClusterComputeConfigBlock>? ComputeConfig
    {
        get => GetProperty<List<AwsEksClusterComputeConfigBlock>>("compute_config");
        set => this.WithProperty("compute_config", value);
    }

    /// <summary>
    /// Block for encryption_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionConfig block(s) allowed")]
    public List<AwsEksClusterEncryptionConfigBlock>? EncryptionConfig
    {
        get => GetProperty<List<AwsEksClusterEncryptionConfigBlock>>("encryption_config");
        set => this.WithProperty("encryption_config", value);
    }

    /// <summary>
    /// Block for kubernetes_network_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KubernetesNetworkConfig block(s) allowed")]
    public List<AwsEksClusterKubernetesNetworkConfigBlock>? KubernetesNetworkConfig
    {
        get => GetProperty<List<AwsEksClusterKubernetesNetworkConfigBlock>>("kubernetes_network_config");
        set => this.WithProperty("kubernetes_network_config", value);
    }

    /// <summary>
    /// Block for outpost_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OutpostConfig block(s) allowed")]
    public List<AwsEksClusterOutpostConfigBlock>? OutpostConfig
    {
        get => GetProperty<List<AwsEksClusterOutpostConfigBlock>>("outpost_config");
        set => this.WithProperty("outpost_config", value);
    }

    /// <summary>
    /// Block for remote_network_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RemoteNetworkConfig block(s) allowed")]
    public List<AwsEksClusterRemoteNetworkConfigBlock>? RemoteNetworkConfig
    {
        get => GetProperty<List<AwsEksClusterRemoteNetworkConfigBlock>>("remote_network_config");
        set => this.WithProperty("remote_network_config", value);
    }

    /// <summary>
    /// Block for storage_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageConfig block(s) allowed")]
    public List<AwsEksClusterStorageConfigBlock>? StorageConfig
    {
        get => GetProperty<List<AwsEksClusterStorageConfigBlock>>("storage_config");
        set => this.WithProperty("storage_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsEksClusterTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsEksClusterTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for upgrade_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UpgradePolicy block(s) allowed")]
    public List<AwsEksClusterUpgradePolicyBlock>? UpgradePolicy
    {
        get => GetProperty<List<AwsEksClusterUpgradePolicyBlock>>("upgrade_policy");
        set => this.WithProperty("upgrade_policy", value);
    }

    /// <summary>
    /// Block for vpc_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 VpcConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcConfig block(s) allowed")]
    public List<AwsEksClusterVpcConfigBlock>? VpcConfig
    {
        get => GetProperty<List<AwsEksClusterVpcConfigBlock>>("vpc_config");
        set => this.WithProperty("vpc_config", value);
    }

    /// <summary>
    /// Block for zonal_shift_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ZonalShiftConfig block(s) allowed")]
    public List<AwsEksClusterZonalShiftConfigBlock>? ZonalShiftConfig
    {
        get => GetProperty<List<AwsEksClusterZonalShiftConfigBlock>>("zonal_shift_config");
        set => this.WithProperty("zonal_shift_config", value);
    }

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
    /// The created_at attribute.
    /// </summary>
    public TerraformExpression CreatedAt => this["created_at"];

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformExpression Endpoint => this["endpoint"];

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformExpression Identity => this["identity"];

    /// <summary>
    /// The platform_version attribute.
    /// </summary>
    public TerraformExpression PlatformVersion => this["platform_version"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

}
