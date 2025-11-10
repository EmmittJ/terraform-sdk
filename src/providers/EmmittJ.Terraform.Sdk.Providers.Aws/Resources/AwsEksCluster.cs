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
        set => SetProperty("authentication_mode", value);
    }

    /// <summary>
    /// The bootstrap_cluster_creator_admin_permissions attribute.
    /// </summary>
    public TerraformProperty<bool>? BootstrapClusterCreatorAdminPermissions
    {
        set => SetProperty("bootstrap_cluster_creator_admin_permissions", value);
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
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The node_pools attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? NodePools
    {
        set => SetProperty("node_pools", value);
    }

    /// <summary>
    /// The node_role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? NodeRoleArn
    {
        set => SetProperty("node_role_arn", value);
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
        set => SetProperty("resources", value);
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
        set => SetProperty("ip_family", value);
    }

    /// <summary>
    /// The service_ipv4_cidr attribute.
    /// </summary>
    public TerraformProperty<string>? ServiceIpv4Cidr
    {
        set => SetProperty("service_ipv4_cidr", value);
    }

    /// <summary>
    /// The service_ipv6_cidr attribute.
    /// </summary>
    public TerraformProperty<string>? ServiceIpv6Cidr
    {
        set => SetProperty("service_ipv6_cidr", value);
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
        set => SetProperty("control_plane_instance_type", value);
    }

    /// <summary>
    /// The outpost_arns attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OutpostArns is required")]
    public HashSet<TerraformProperty<string>>? OutpostArns
    {
        set => SetProperty("outpost_arns", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        set => SetProperty("support_type", value);
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
        set => SetProperty("cluster_security_group_id", value);
    }

    /// <summary>
    /// The endpoint_private_access attribute.
    /// </summary>
    public TerraformProperty<bool>? EndpointPrivateAccess
    {
        set => SetProperty("endpoint_private_access", value);
    }

    /// <summary>
    /// The endpoint_public_access attribute.
    /// </summary>
    public TerraformProperty<bool>? EndpointPublicAccess
    {
        set => SetProperty("endpoint_public_access", value);
    }

    /// <summary>
    /// The public_access_cidrs attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? PublicAccessCidrs
    {
        set => SetProperty("public_access_cidrs", value);
    }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SecurityGroupIds
    {
        set => SetProperty("security_group_ids", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    public HashSet<TerraformProperty<string>>? SubnetIds
    {
        set => SetProperty("subnet_ids", value);
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformProperty<string>? VpcId
    {
        set => SetProperty("vpc_id", value);
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
        set => SetProperty("enabled", value);
    }

}

/// <summary>
/// Manages a aws_eks_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsEksCluster : TerraformResource
{
    public AwsEksCluster(string name) : base("aws_eks_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("certificate_authority");
        SetOutput("cluster_id");
        SetOutput("created_at");
        SetOutput("endpoint");
        SetOutput("identity");
        SetOutput("platform_version");
        SetOutput("status");
        SetOutput("bootstrap_self_managed_addons");
        SetOutput("deletion_protection");
        SetOutput("enabled_cluster_log_types");
        SetOutput("force_update_version");
        SetOutput("id");
        SetOutput("name");
        SetOutput("region");
        SetOutput("role_arn");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("version");
    }

    /// <summary>
    /// The bootstrap_self_managed_addons attribute.
    /// </summary>
    public TerraformProperty<bool> BootstrapSelfManagedAddons
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("bootstrap_self_managed_addons");
        set => SetProperty("bootstrap_self_managed_addons", value);
    }

    /// <summary>
    /// The deletion_protection attribute.
    /// </summary>
    public TerraformProperty<bool> DeletionProtection
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("deletion_protection");
        set => SetProperty("deletion_protection", value);
    }

    /// <summary>
    /// The enabled_cluster_log_types attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> EnabledClusterLogTypes
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("enabled_cluster_log_types");
        set => SetProperty("enabled_cluster_log_types", value);
    }

    /// <summary>
    /// The force_update_version attribute.
    /// </summary>
    public TerraformProperty<bool> ForceUpdateVersion
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("force_update_version");
        set => SetProperty("force_update_version", value);
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
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("role_arn");
        set => SetProperty("role_arn", value);
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformProperty<string> Version
    {
        get => GetRequiredOutput<TerraformProperty<string>>("version");
        set => SetProperty("version", value);
    }

    /// <summary>
    /// Block for access_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccessConfig block(s) allowed")]
    public List<AwsEksClusterAccessConfigBlock>? AccessConfig
    {
        set => SetProperty("access_config", value);
    }

    /// <summary>
    /// Block for compute_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ComputeConfig block(s) allowed")]
    public List<AwsEksClusterComputeConfigBlock>? ComputeConfig
    {
        set => SetProperty("compute_config", value);
    }

    /// <summary>
    /// Block for encryption_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionConfig block(s) allowed")]
    public List<AwsEksClusterEncryptionConfigBlock>? EncryptionConfig
    {
        set => SetProperty("encryption_config", value);
    }

    /// <summary>
    /// Block for kubernetes_network_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KubernetesNetworkConfig block(s) allowed")]
    public List<AwsEksClusterKubernetesNetworkConfigBlock>? KubernetesNetworkConfig
    {
        set => SetProperty("kubernetes_network_config", value);
    }

    /// <summary>
    /// Block for outpost_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OutpostConfig block(s) allowed")]
    public List<AwsEksClusterOutpostConfigBlock>? OutpostConfig
    {
        set => SetProperty("outpost_config", value);
    }

    /// <summary>
    /// Block for remote_network_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RemoteNetworkConfig block(s) allowed")]
    public List<AwsEksClusterRemoteNetworkConfigBlock>? RemoteNetworkConfig
    {
        set => SetProperty("remote_network_config", value);
    }

    /// <summary>
    /// Block for storage_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageConfig block(s) allowed")]
    public List<AwsEksClusterStorageConfigBlock>? StorageConfig
    {
        set => SetProperty("storage_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsEksClusterTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for upgrade_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UpgradePolicy block(s) allowed")]
    public List<AwsEksClusterUpgradePolicyBlock>? UpgradePolicy
    {
        set => SetProperty("upgrade_policy", value);
    }

    /// <summary>
    /// Block for vpc_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 VpcConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcConfig block(s) allowed")]
    public List<AwsEksClusterVpcConfigBlock>? VpcConfig
    {
        set => SetProperty("vpc_config", value);
    }

    /// <summary>
    /// Block for zonal_shift_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ZonalShiftConfig block(s) allowed")]
    public List<AwsEksClusterZonalShiftConfigBlock>? ZonalShiftConfig
    {
        set => SetProperty("zonal_shift_config", value);
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
