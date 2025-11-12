using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for access_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsEksClusterAccessConfigBlock() : TerraformBlock("access_config")
{
    /// <summary>
    /// The authentication_mode attribute.
    /// </summary>
    [TerraformProperty("authentication_mode")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> AuthenticationMode { get; set; }

    /// <summary>
    /// The bootstrap_cluster_creator_admin_permissions attribute.
    /// </summary>
    [TerraformProperty("bootstrap_cluster_creator_admin_permissions")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? BootstrapClusterCreatorAdminPermissions { get; set; }

}

/// <summary>
/// Block type for compute_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsEksClusterComputeConfigBlock() : TerraformBlock("compute_config")
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> Enabled { get; set; }

    /// <summary>
    /// The node_pools attribute.
    /// </summary>
    [TerraformProperty("node_pools")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? NodePools { get; set; }

    /// <summary>
    /// The node_role_arn attribute.
    /// </summary>
    [TerraformProperty("node_role_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? NodeRoleArn { get; set; }

}

/// <summary>
/// Block type for encryption_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsEksClusterEncryptionConfigBlock() : TerraformBlock("encryption_config")
{
    /// <summary>
    /// The resources attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Resources is required")]
    [TerraformProperty("resources")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> Resources { get; set; }

}

/// <summary>
/// Block type for kubernetes_network_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsEksClusterKubernetesNetworkConfigBlock() : TerraformBlock("kubernetes_network_config")
{
    /// <summary>
    /// The ip_family attribute.
    /// </summary>
    [TerraformProperty("ip_family")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> IpFamily { get; set; }

    /// <summary>
    /// The service_ipv4_cidr attribute.
    /// </summary>
    [TerraformProperty("service_ipv4_cidr")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ServiceIpv4Cidr { get; set; }


}

/// <summary>
/// Block type for outpost_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsEksClusterOutpostConfigBlock() : TerraformBlock("outpost_config")
{
    /// <summary>
    /// The control_plane_instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ControlPlaneInstanceType is required")]
    [TerraformProperty("control_plane_instance_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ControlPlaneInstanceType { get; set; }

    /// <summary>
    /// The outpost_arns attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OutpostArns is required")]
    [TerraformProperty("outpost_arns")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> OutpostArns { get; set; }

}

/// <summary>
/// Block type for remote_network_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsEksClusterRemoteNetworkConfigBlock() : TerraformBlock("remote_network_config")
{
}

/// <summary>
/// Block type for storage_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsEksClusterStorageConfigBlock() : TerraformBlock("storage_config")
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsEksClusterTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for upgrade_policy in .
/// Nesting mode: list
/// </summary>
public partial class AwsEksClusterUpgradePolicyBlock() : TerraformBlock("upgrade_policy")
{
    /// <summary>
    /// The support_type attribute.
    /// </summary>
    [TerraformProperty("support_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> SupportType { get; set; }

}

/// <summary>
/// Block type for vpc_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsEksClusterVpcConfigBlock() : TerraformBlock("vpc_config")
{

    /// <summary>
    /// The endpoint_private_access attribute.
    /// </summary>
    [TerraformProperty("endpoint_private_access")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EndpointPrivateAccess { get; set; }

    /// <summary>
    /// The endpoint_public_access attribute.
    /// </summary>
    [TerraformProperty("endpoint_public_access")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EndpointPublicAccess { get; set; }

    /// <summary>
    /// The public_access_cidrs attribute.
    /// </summary>
    [TerraformProperty("public_access_cidrs")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> PublicAccessCidrs { get; set; }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [TerraformProperty("security_group_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? SecurityGroupIds { get; set; }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    [TerraformProperty("subnet_ids")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> SubnetIds { get; set; }


}

/// <summary>
/// Block type for zonal_shift_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsEksClusterZonalShiftConfigBlock() : TerraformBlock("zonal_shift_config")
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Enabled { get; set; }

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
    public partial TerraformValue<bool>? BootstrapSelfManagedAddons { get; set; }

    /// <summary>
    /// The deletion_protection attribute.
    /// </summary>
    [TerraformProperty("deletion_protection")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> DeletionProtection { get; set; }

    /// <summary>
    /// The enabled_cluster_log_types attribute.
    /// </summary>
    [TerraformProperty("enabled_cluster_log_types")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? EnabledClusterLogTypes { get; set; }

    /// <summary>
    /// The force_update_version attribute.
    /// </summary>
    [TerraformProperty("force_update_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ForceUpdateVersion { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformProperty("role_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RoleArn { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformProperty("version")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Version { get; set; }

    /// <summary>
    /// Block for access_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccessConfig block(s) allowed")]
    [TerraformProperty("access_config")]
    public TerraformList<AwsEksClusterAccessConfigBlock> AccessConfig { get; set; } = new();

    /// <summary>
    /// Block for compute_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ComputeConfig block(s) allowed")]
    [TerraformProperty("compute_config")]
    public TerraformList<AwsEksClusterComputeConfigBlock> ComputeConfig { get; set; } = new();

    /// <summary>
    /// Block for encryption_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionConfig block(s) allowed")]
    [TerraformProperty("encryption_config")]
    public TerraformList<AwsEksClusterEncryptionConfigBlock> EncryptionConfig { get; set; } = new();

    /// <summary>
    /// Block for kubernetes_network_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KubernetesNetworkConfig block(s) allowed")]
    [TerraformProperty("kubernetes_network_config")]
    public TerraformList<AwsEksClusterKubernetesNetworkConfigBlock> KubernetesNetworkConfig { get; set; } = new();

    /// <summary>
    /// Block for outpost_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OutpostConfig block(s) allowed")]
    [TerraformProperty("outpost_config")]
    public TerraformList<AwsEksClusterOutpostConfigBlock> OutpostConfig { get; set; } = new();

    /// <summary>
    /// Block for remote_network_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RemoteNetworkConfig block(s) allowed")]
    [TerraformProperty("remote_network_config")]
    public TerraformList<AwsEksClusterRemoteNetworkConfigBlock> RemoteNetworkConfig { get; set; } = new();

    /// <summary>
    /// Block for storage_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageConfig block(s) allowed")]
    [TerraformProperty("storage_config")]
    public TerraformList<AwsEksClusterStorageConfigBlock> StorageConfig { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsEksClusterTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for upgrade_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UpgradePolicy block(s) allowed")]
    [TerraformProperty("upgrade_policy")]
    public TerraformList<AwsEksClusterUpgradePolicyBlock> UpgradePolicy { get; set; } = new();

    /// <summary>
    /// Block for vpc_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 VpcConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcConfig block(s) allowed")]
    [TerraformProperty("vpc_config")]
    public required TerraformList<AwsEksClusterVpcConfigBlock> VpcConfig { get; set; } = new();

    /// <summary>
    /// Block for zonal_shift_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ZonalShiftConfig block(s) allowed")]
    [TerraformProperty("zonal_shift_config")]
    public TerraformList<AwsEksClusterZonalShiftConfigBlock> ZonalShiftConfig { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The certificate_authority attribute.
    /// </summary>
    [TerraformProperty("certificate_authority")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> CertificateAuthority { get; }

    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    [TerraformProperty("cluster_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ClusterId { get; }

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    [TerraformProperty("created_at")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreatedAt { get; }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformProperty("endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Endpoint { get; }

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformProperty("identity")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Identity { get; }

    /// <summary>
    /// The platform_version attribute.
    /// </summary>
    [TerraformProperty("platform_version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PlatformVersion { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Status { get; }

}
