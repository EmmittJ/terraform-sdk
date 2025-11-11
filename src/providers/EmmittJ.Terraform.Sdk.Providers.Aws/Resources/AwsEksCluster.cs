using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for access_config in .
/// Nesting mode: list
/// </summary>
public class AwsEksClusterAccessConfigBlock
{
    /// <summary>
    /// The authentication_mode attribute.
    /// </summary>
    [TerraformPropertyName("authentication_mode")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> AuthenticationMode { get; set; } = default!;

    /// <summary>
    /// The bootstrap_cluster_creator_admin_permissions attribute.
    /// </summary>
    [TerraformPropertyName("bootstrap_cluster_creator_admin_permissions")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? BootstrapClusterCreatorAdminPermissions { get; set; }

}

/// <summary>
/// Block type for compute_config in .
/// Nesting mode: list
/// </summary>
public class AwsEksClusterComputeConfigBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> Enabled { get; set; } = default!;

    /// <summary>
    /// The node_pools attribute.
    /// </summary>
    [TerraformPropertyName("node_pools")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? NodePools { get; set; }

    /// <summary>
    /// The node_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("node_role_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? NodeRoleArn { get; set; }

}

/// <summary>
/// Block type for encryption_config in .
/// Nesting mode: list
/// </summary>
public class AwsEksClusterEncryptionConfigBlock
{
    /// <summary>
    /// The resources attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Resources is required")]
    [TerraformPropertyName("resources")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> Resources { get; set; }

}

/// <summary>
/// Block type for kubernetes_network_config in .
/// Nesting mode: list
/// </summary>
public class AwsEksClusterKubernetesNetworkConfigBlock
{
    /// <summary>
    /// The ip_family attribute.
    /// </summary>
    [TerraformPropertyName("ip_family")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> IpFamily { get; set; } = default!;

    /// <summary>
    /// The service_ipv4_cidr attribute.
    /// </summary>
    [TerraformPropertyName("service_ipv4_cidr")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ServiceIpv4Cidr { get; set; } = default!;


}

/// <summary>
/// Block type for outpost_config in .
/// Nesting mode: list
/// </summary>
public class AwsEksClusterOutpostConfigBlock
{
    /// <summary>
    /// The control_plane_instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ControlPlaneInstanceType is required")]
    [TerraformPropertyName("control_plane_instance_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ControlPlaneInstanceType { get; set; }

    /// <summary>
    /// The outpost_arns attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OutpostArns is required")]
    [TerraformPropertyName("outpost_arns")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> OutpostArns { get; set; }

}

/// <summary>
/// Block type for remote_network_config in .
/// Nesting mode: list
/// </summary>
public class AwsEksClusterRemoteNetworkConfigBlock
{
}

/// <summary>
/// Block type for storage_config in .
/// Nesting mode: list
/// </summary>
public class AwsEksClusterStorageConfigBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsEksClusterTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for upgrade_policy in .
/// Nesting mode: list
/// </summary>
public class AwsEksClusterUpgradePolicyBlock
{
    /// <summary>
    /// The support_type attribute.
    /// </summary>
    [TerraformPropertyName("support_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> SupportType { get; set; } = default!;

}

/// <summary>
/// Block type for vpc_config in .
/// Nesting mode: list
/// </summary>
public class AwsEksClusterVpcConfigBlock
{

    /// <summary>
    /// The endpoint_private_access attribute.
    /// </summary>
    [TerraformPropertyName("endpoint_private_access")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EndpointPrivateAccess { get; set; }

    /// <summary>
    /// The endpoint_public_access attribute.
    /// </summary>
    [TerraformPropertyName("endpoint_public_access")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EndpointPublicAccess { get; set; }

    /// <summary>
    /// The public_access_cidrs attribute.
    /// </summary>
    [TerraformPropertyName("public_access_cidrs")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<string> PublicAccessCidrs { get; set; } = default!;

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("security_group_ids")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? SecurityGroupIds { get; set; }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    [TerraformPropertyName("subnet_ids")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> SubnetIds { get; set; }


}

/// <summary>
/// Block type for zonal_shift_config in .
/// Nesting mode: list
/// </summary>
public class AwsEksClusterZonalShiftConfigBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Enabled { get; set; }

}

/// <summary>
/// Manages a aws_eks_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsEksCluster : TerraformResource
{
    public AwsEksCluster(string name) : base("aws_eks_cluster", name)
    {
    }

    /// <summary>
    /// The bootstrap_self_managed_addons attribute.
    /// </summary>
    [TerraformPropertyName("bootstrap_self_managed_addons")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? BootstrapSelfManagedAddons { get; set; }

    /// <summary>
    /// The deletion_protection attribute.
    /// </summary>
    [TerraformPropertyName("deletion_protection")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> DeletionProtection { get; set; } = default!;

    /// <summary>
    /// The enabled_cluster_log_types attribute.
    /// </summary>
    [TerraformPropertyName("enabled_cluster_log_types")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? EnabledClusterLogTypes { get; set; }

    /// <summary>
    /// The force_update_version attribute.
    /// </summary>
    [TerraformPropertyName("force_update_version")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ForceUpdateVersion { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformPropertyName("role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RoleArn { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformPropertyName("version")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Version { get; set; } = default!;

    /// <summary>
    /// Block for access_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccessConfig block(s) allowed")]
    [TerraformPropertyName("access_config")]
    public TerraformList<TerraformBlock<AwsEksClusterAccessConfigBlock>>? AccessConfig { get; set; }

    /// <summary>
    /// Block for compute_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ComputeConfig block(s) allowed")]
    [TerraformPropertyName("compute_config")]
    public TerraformList<TerraformBlock<AwsEksClusterComputeConfigBlock>>? ComputeConfig { get; set; }

    /// <summary>
    /// Block for encryption_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionConfig block(s) allowed")]
    [TerraformPropertyName("encryption_config")]
    public TerraformList<TerraformBlock<AwsEksClusterEncryptionConfigBlock>>? EncryptionConfig { get; set; }

    /// <summary>
    /// Block for kubernetes_network_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KubernetesNetworkConfig block(s) allowed")]
    [TerraformPropertyName("kubernetes_network_config")]
    public TerraformList<TerraformBlock<AwsEksClusterKubernetesNetworkConfigBlock>>? KubernetesNetworkConfig { get; set; }

    /// <summary>
    /// Block for outpost_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OutpostConfig block(s) allowed")]
    [TerraformPropertyName("outpost_config")]
    public TerraformList<TerraformBlock<AwsEksClusterOutpostConfigBlock>>? OutpostConfig { get; set; }

    /// <summary>
    /// Block for remote_network_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RemoteNetworkConfig block(s) allowed")]
    [TerraformPropertyName("remote_network_config")]
    public TerraformList<TerraformBlock<AwsEksClusterRemoteNetworkConfigBlock>>? RemoteNetworkConfig { get; set; }

    /// <summary>
    /// Block for storage_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageConfig block(s) allowed")]
    [TerraformPropertyName("storage_config")]
    public TerraformList<TerraformBlock<AwsEksClusterStorageConfigBlock>>? StorageConfig { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsEksClusterTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for upgrade_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UpgradePolicy block(s) allowed")]
    [TerraformPropertyName("upgrade_policy")]
    public TerraformList<TerraformBlock<AwsEksClusterUpgradePolicyBlock>>? UpgradePolicy { get; set; }

    /// <summary>
    /// Block for vpc_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 VpcConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcConfig block(s) allowed")]
    [TerraformPropertyName("vpc_config")]
    public TerraformList<TerraformBlock<AwsEksClusterVpcConfigBlock>>? VpcConfig { get; set; }

    /// <summary>
    /// Block for zonal_shift_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ZonalShiftConfig block(s) allowed")]
    [TerraformPropertyName("zonal_shift_config")]
    public TerraformList<TerraformBlock<AwsEksClusterZonalShiftConfigBlock>>? ZonalShiftConfig { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The certificate_authority attribute.
    /// </summary>
    [TerraformPropertyName("certificate_authority")]
    // Output-only attribute - read-only reference
    public TerraformList<object> CertificateAuthority => new TerraformReference(this, "certificate_authority");

    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    [TerraformPropertyName("cluster_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ClusterId => new TerraformReference(this, "cluster_id");

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    [TerraformPropertyName("created_at")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreatedAt => new TerraformReference(this, "created_at");

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformPropertyName("endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Endpoint => new TerraformReference(this, "endpoint");

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformPropertyName("identity")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Identity => new TerraformReference(this, "identity");

    /// <summary>
    /// The platform_version attribute.
    /// </summary>
    [TerraformPropertyName("platform_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PlatformVersion => new TerraformReference(this, "platform_version");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Status => new TerraformReference(this, "status");

}
