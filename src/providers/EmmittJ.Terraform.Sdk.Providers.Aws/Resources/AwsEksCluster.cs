using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for access_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsEksClusterAccessConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The authentication_mode attribute.
    /// </summary>
    [TerraformProperty("authentication_mode")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> AuthenticationMode { get; set; }

    /// <summary>
    /// The bootstrap_cluster_creator_admin_permissions attribute.
    /// </summary>
    [TerraformProperty("bootstrap_cluster_creator_admin_permissions")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? BootstrapClusterCreatorAdminPermissions { get; set; }

}

/// <summary>
/// Block type for compute_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsEksClusterComputeConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> Enabled { get; set; }

    /// <summary>
    /// The node_pools attribute.
    /// </summary>
    [TerraformProperty("node_pools")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? NodePools { get; set; }

    /// <summary>
    /// The node_role_arn attribute.
    /// </summary>
    [TerraformProperty("node_role_arn")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? NodeRoleArn { get; set; }

}

/// <summary>
/// Block type for encryption_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsEksClusterEncryptionConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The resources attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Resources is required")]
    [TerraformProperty("resources")]
    // Required argument - source generator will implement get/set
    public required TerraformSet<string> Resources { get; set; }

}

/// <summary>
/// Block type for kubernetes_network_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsEksClusterKubernetesNetworkConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The ip_family attribute.
    /// </summary>
    [TerraformProperty("ip_family")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> IpFamily { get; set; }

    /// <summary>
    /// The service_ipv4_cidr attribute.
    /// </summary>
    [TerraformProperty("service_ipv4_cidr")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ServiceIpv4Cidr { get; set; }


}

/// <summary>
/// Block type for outpost_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsEksClusterOutpostConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The control_plane_instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ControlPlaneInstanceType is required")]
    [TerraformProperty("control_plane_instance_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ControlPlaneInstanceType { get; set; }

    /// <summary>
    /// The outpost_arns attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OutpostArns is required")]
    [TerraformProperty("outpost_arns")]
    // Required argument - source generator will implement get/set
    public required TerraformSet<string> OutpostArns { get; set; }

}

/// <summary>
/// Block type for remote_network_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsEksClusterRemoteNetworkConfigBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for storage_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsEksClusterStorageConfigBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsEksClusterTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for upgrade_policy in .
/// Nesting mode: list
/// </summary>
public partial class AwsEksClusterUpgradePolicyBlock : TerraformBlockBase
{
    /// <summary>
    /// The support_type attribute.
    /// </summary>
    [TerraformProperty("support_type")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> SupportType { get; set; }

}

/// <summary>
/// Block type for vpc_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsEksClusterVpcConfigBlock : TerraformBlockBase
{

    /// <summary>
    /// The endpoint_private_access attribute.
    /// </summary>
    [TerraformProperty("endpoint_private_access")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? EndpointPrivateAccess { get; set; }

    /// <summary>
    /// The endpoint_public_access attribute.
    /// </summary>
    [TerraformProperty("endpoint_public_access")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? EndpointPublicAccess { get; set; }

    /// <summary>
    /// The public_access_cidrs attribute.
    /// </summary>
    [TerraformProperty("public_access_cidrs")]
    // Optional+Computed - source generator will implement get/set
    public TerraformSet<string> PublicAccessCidrs { get; set; }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [TerraformProperty("security_group_ids")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? SecurityGroupIds { get; set; }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    [TerraformProperty("subnet_ids")]
    // Required argument - source generator will implement get/set
    public required TerraformSet<string> SubnetIds { get; set; }


}

/// <summary>
/// Block type for zonal_shift_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsEksClusterZonalShiftConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Enabled { get; set; }

}

/// <summary>
/// Manages a aws_eks_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsEksCluster : TerraformResource
{
    public AwsEksCluster(string name) : base("aws_eks_cluster", name)
    {
    }

    /// <summary>
    /// The bootstrap_self_managed_addons attribute.
    /// </summary>
    [TerraformProperty("bootstrap_self_managed_addons")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? BootstrapSelfManagedAddons { get; set; }

    /// <summary>
    /// The deletion_protection attribute.
    /// </summary>
    [TerraformProperty("deletion_protection")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> DeletionProtection { get; set; }

    /// <summary>
    /// The enabled_cluster_log_types attribute.
    /// </summary>
    [TerraformProperty("enabled_cluster_log_types")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? EnabledClusterLogTypes { get; set; }

    /// <summary>
    /// The force_update_version attribute.
    /// </summary>
    [TerraformProperty("force_update_version")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? ForceUpdateVersion { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformProperty("role_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> RoleArn { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformProperty("version")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Version { get; set; }

    /// <summary>
    /// Block for access_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccessConfig block(s) allowed")]
    [TerraformProperty("access_config")]
    public TerraformList<TerraformBlock<AwsEksClusterAccessConfigBlock>>? AccessConfig { get; set; }

    /// <summary>
    /// Block for compute_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ComputeConfig block(s) allowed")]
    [TerraformProperty("compute_config")]
    public TerraformList<TerraformBlock<AwsEksClusterComputeConfigBlock>>? ComputeConfig { get; set; }

    /// <summary>
    /// Block for encryption_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionConfig block(s) allowed")]
    [TerraformProperty("encryption_config")]
    public TerraformList<TerraformBlock<AwsEksClusterEncryptionConfigBlock>>? EncryptionConfig { get; set; }

    /// <summary>
    /// Block for kubernetes_network_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KubernetesNetworkConfig block(s) allowed")]
    [TerraformProperty("kubernetes_network_config")]
    public TerraformList<TerraformBlock<AwsEksClusterKubernetesNetworkConfigBlock>>? KubernetesNetworkConfig { get; set; }

    /// <summary>
    /// Block for outpost_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OutpostConfig block(s) allowed")]
    [TerraformProperty("outpost_config")]
    public TerraformList<TerraformBlock<AwsEksClusterOutpostConfigBlock>>? OutpostConfig { get; set; }

    /// <summary>
    /// Block for remote_network_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RemoteNetworkConfig block(s) allowed")]
    [TerraformProperty("remote_network_config")]
    public TerraformList<TerraformBlock<AwsEksClusterRemoteNetworkConfigBlock>>? RemoteNetworkConfig { get; set; }

    /// <summary>
    /// Block for storage_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageConfig block(s) allowed")]
    [TerraformProperty("storage_config")]
    public TerraformList<TerraformBlock<AwsEksClusterStorageConfigBlock>>? StorageConfig { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AwsEksClusterTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for upgrade_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UpgradePolicy block(s) allowed")]
    [TerraformProperty("upgrade_policy")]
    public TerraformList<TerraformBlock<AwsEksClusterUpgradePolicyBlock>>? UpgradePolicy { get; set; }

    /// <summary>
    /// Block for vpc_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 VpcConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcConfig block(s) allowed")]
    [TerraformProperty("vpc_config")]
    public TerraformList<TerraformBlock<AwsEksClusterVpcConfigBlock>>? VpcConfig { get; set; }

    /// <summary>
    /// Block for zonal_shift_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ZonalShiftConfig block(s) allowed")]
    [TerraformProperty("zonal_shift_config")]
    public TerraformList<TerraformBlock<AwsEksClusterZonalShiftConfigBlock>>? ZonalShiftConfig { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The certificate_authority attribute.
    /// </summary>
    [TerraformProperty("certificate_authority")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> CertificateAuthority { get; }

    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    [TerraformProperty("cluster_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ClusterId { get; }

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    [TerraformProperty("created_at")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreatedAt { get; }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformProperty("endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Endpoint { get; }

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformProperty("identity")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Identity { get; }

    /// <summary>
    /// The platform_version attribute.
    /// </summary>
    [TerraformProperty("platform_version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PlatformVersion { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Status { get; }

}
