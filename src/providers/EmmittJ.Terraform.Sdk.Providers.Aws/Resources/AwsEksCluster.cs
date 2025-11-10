using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for access_config in .
/// Nesting mode: list
/// </summary>
public class AwsEksClusterAccessConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The authentication_mode attribute.
    /// </summary>
    [TerraformPropertyName("authentication_mode")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AuthenticationMode { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "authentication_mode");

    /// <summary>
    /// The bootstrap_cluster_creator_admin_permissions attribute.
    /// </summary>
    [TerraformPropertyName("bootstrap_cluster_creator_admin_permissions")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? BootstrapClusterCreatorAdminPermissions { get; set; }

}

/// <summary>
/// Block type for compute_config in .
/// Nesting mode: list
/// </summary>
public class AwsEksClusterComputeConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> Enabled { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>("", "enabled");

    /// <summary>
    /// The node_pools attribute.
    /// </summary>
    [TerraformPropertyName("node_pools")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? NodePools { get; set; }

    /// <summary>
    /// The node_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("node_role_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? NodeRoleArn { get; set; }

}

/// <summary>
/// Block type for encryption_config in .
/// Nesting mode: list
/// </summary>
public class AwsEksClusterEncryptionConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The resources attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Resources is required")]
    [TerraformPropertyName("resources")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Resources { get; set; }

}

/// <summary>
/// Block type for kubernetes_network_config in .
/// Nesting mode: list
/// </summary>
public class AwsEksClusterKubernetesNetworkConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The ip_family attribute.
    /// </summary>
    [TerraformPropertyName("ip_family")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> IpFamily { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "ip_family");

    /// <summary>
    /// The service_ipv4_cidr attribute.
    /// </summary>
    [TerraformPropertyName("service_ipv4_cidr")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ServiceIpv4Cidr { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "service_ipv4_cidr");

    /// <summary>
    /// The service_ipv6_cidr attribute.
    /// </summary>
    [TerraformPropertyName("service_ipv6_cidr")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ServiceIpv6Cidr => new TerraformReferenceProperty<TerraformProperty<string>>("", "service_ipv6_cidr");

}

/// <summary>
/// Block type for outpost_config in .
/// Nesting mode: list
/// </summary>
public class AwsEksClusterOutpostConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The control_plane_instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ControlPlaneInstanceType is required")]
    [TerraformPropertyName("control_plane_instance_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ControlPlaneInstanceType { get; set; }

    /// <summary>
    /// The outpost_arns attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OutpostArns is required")]
    [TerraformPropertyName("outpost_arns")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? OutpostArns { get; set; }

}

/// <summary>
/// Block type for remote_network_config in .
/// Nesting mode: list
/// </summary>
public class AwsEksClusterRemoteNetworkConfigBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for storage_config in .
/// Nesting mode: list
/// </summary>
public class AwsEksClusterStorageConfigBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsEksClusterTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Block type for upgrade_policy in .
/// Nesting mode: list
/// </summary>
public class AwsEksClusterUpgradePolicyBlock : ITerraformBlock
{
    /// <summary>
    /// The support_type attribute.
    /// </summary>
    [TerraformPropertyName("support_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> SupportType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "support_type");

}

/// <summary>
/// Block type for vpc_config in .
/// Nesting mode: list
/// </summary>
public class AwsEksClusterVpcConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The cluster_security_group_id attribute.
    /// </summary>
    [TerraformPropertyName("cluster_security_group_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ClusterSecurityGroupId => new TerraformReferenceProperty<TerraformProperty<string>>("", "cluster_security_group_id");

    /// <summary>
    /// The endpoint_private_access attribute.
    /// </summary>
    [TerraformPropertyName("endpoint_private_access")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EndpointPrivateAccess { get; set; }

    /// <summary>
    /// The endpoint_public_access attribute.
    /// </summary>
    [TerraformPropertyName("endpoint_public_access")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EndpointPublicAccess { get; set; }

    /// <summary>
    /// The public_access_cidrs attribute.
    /// </summary>
    [TerraformPropertyName("public_access_cidrs")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> PublicAccessCidrs { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>("", "public_access_cidrs");

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("security_group_ids")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? SecurityGroupIds { get; set; }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    [TerraformPropertyName("subnet_ids")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? SubnetIds { get; set; }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformPropertyName("vpc_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VpcId => new TerraformReferenceProperty<TerraformProperty<string>>("", "vpc_id");

}

/// <summary>
/// Block type for zonal_shift_config in .
/// Nesting mode: list
/// </summary>
public class AwsEksClusterZonalShiftConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Enabled { get; set; }

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
    public TerraformProperty<TerraformProperty<bool>>? BootstrapSelfManagedAddons { get; set; }

    /// <summary>
    /// The deletion_protection attribute.
    /// </summary>
    [TerraformPropertyName("deletion_protection")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> DeletionProtection { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "deletion_protection");

    /// <summary>
    /// The enabled_cluster_log_types attribute.
    /// </summary>
    [TerraformPropertyName("enabled_cluster_log_types")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? EnabledClusterLogTypes { get; set; }

    /// <summary>
    /// The force_update_version attribute.
    /// </summary>
    [TerraformPropertyName("force_update_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ForceUpdateVersion { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformPropertyName("role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RoleArn { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformPropertyName("version")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Version { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "version");

    /// <summary>
    /// Block for access_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccessConfig block(s) allowed")]
    [TerraformPropertyName("access_config")]
    public TerraformList<TerraformBlock<AwsEksClusterAccessConfigBlock>>? AccessConfig { get; set; } = new();

    /// <summary>
    /// Block for compute_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ComputeConfig block(s) allowed")]
    [TerraformPropertyName("compute_config")]
    public TerraformList<TerraformBlock<AwsEksClusterComputeConfigBlock>>? ComputeConfig { get; set; } = new();

    /// <summary>
    /// Block for encryption_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionConfig block(s) allowed")]
    [TerraformPropertyName("encryption_config")]
    public TerraformList<TerraformBlock<AwsEksClusterEncryptionConfigBlock>>? EncryptionConfig { get; set; } = new();

    /// <summary>
    /// Block for kubernetes_network_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KubernetesNetworkConfig block(s) allowed")]
    [TerraformPropertyName("kubernetes_network_config")]
    public TerraformList<TerraformBlock<AwsEksClusterKubernetesNetworkConfigBlock>>? KubernetesNetworkConfig { get; set; } = new();

    /// <summary>
    /// Block for outpost_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OutpostConfig block(s) allowed")]
    [TerraformPropertyName("outpost_config")]
    public TerraformList<TerraformBlock<AwsEksClusterOutpostConfigBlock>>? OutpostConfig { get; set; } = new();

    /// <summary>
    /// Block for remote_network_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RemoteNetworkConfig block(s) allowed")]
    [TerraformPropertyName("remote_network_config")]
    public TerraformList<TerraformBlock<AwsEksClusterRemoteNetworkConfigBlock>>? RemoteNetworkConfig { get; set; } = new();

    /// <summary>
    /// Block for storage_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageConfig block(s) allowed")]
    [TerraformPropertyName("storage_config")]
    public TerraformList<TerraformBlock<AwsEksClusterStorageConfigBlock>>? StorageConfig { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsEksClusterTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Block for upgrade_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UpgradePolicy block(s) allowed")]
    [TerraformPropertyName("upgrade_policy")]
    public TerraformList<TerraformBlock<AwsEksClusterUpgradePolicyBlock>>? UpgradePolicy { get; set; } = new();

    /// <summary>
    /// Block for vpc_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 VpcConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcConfig block(s) allowed")]
    [TerraformPropertyName("vpc_config")]
    public TerraformList<TerraformBlock<AwsEksClusterVpcConfigBlock>>? VpcConfig { get; set; } = new();

    /// <summary>
    /// Block for zonal_shift_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ZonalShiftConfig block(s) allowed")]
    [TerraformPropertyName("zonal_shift_config")]
    public TerraformList<TerraformBlock<AwsEksClusterZonalShiftConfigBlock>>? ZonalShiftConfig { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The certificate_authority attribute.
    /// </summary>
    [TerraformPropertyName("certificate_authority")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> CertificateAuthority => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "certificate_authority");

    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    [TerraformPropertyName("cluster_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ClusterId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "cluster_id");

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    [TerraformPropertyName("created_at")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreatedAt => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "created_at");

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformPropertyName("endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Endpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "endpoint");

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformPropertyName("identity")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Identity => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "identity");

    /// <summary>
    /// The platform_version attribute.
    /// </summary>
    [TerraformPropertyName("platform_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PlatformVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "platform_version");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Status => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

}
