using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsRedshiftClusterTimeoutsBlock : ITerraformBlock
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
/// Manages a aws_redshift_cluster resource.
/// </summary>
public class AwsRedshiftCluster : TerraformResource
{
    public AwsRedshiftCluster(string name) : base("aws_redshift_cluster", name)
    {
    }

    /// <summary>
    /// The allow_version_upgrade attribute.
    /// </summary>
    [TerraformPropertyName("allow_version_upgrade")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AllowVersionUpgrade { get; set; }

    /// <summary>
    /// The apply_immediately attribute.
    /// </summary>
    [TerraformPropertyName("apply_immediately")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ApplyImmediately { get; set; }

    /// <summary>
    /// The aqua_configuration_status attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformPropertyName("aqua_configuration_status")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AquaConfigurationStatus { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "aqua_configuration_status");

    /// <summary>
    /// The automated_snapshot_retention_period attribute.
    /// </summary>
    [TerraformPropertyName("automated_snapshot_retention_period")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? AutomatedSnapshotRetentionPeriod { get; set; }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    [TerraformPropertyName("availability_zone")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AvailabilityZone { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "availability_zone");

    /// <summary>
    /// The availability_zone_relocation_enabled attribute.
    /// </summary>
    [TerraformPropertyName("availability_zone_relocation_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AvailabilityZoneRelocationEnabled { get; set; }

    /// <summary>
    /// The cluster_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterIdentifier is required")]
    [TerraformPropertyName("cluster_identifier")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ClusterIdentifier { get; set; }

    /// <summary>
    /// The cluster_parameter_group_name attribute.
    /// </summary>
    [TerraformPropertyName("cluster_parameter_group_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ClusterParameterGroupName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "cluster_parameter_group_name");

    /// <summary>
    /// The cluster_subnet_group_name attribute.
    /// </summary>
    [TerraformPropertyName("cluster_subnet_group_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ClusterSubnetGroupName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "cluster_subnet_group_name");

    /// <summary>
    /// The cluster_type attribute.
    /// </summary>
    [TerraformPropertyName("cluster_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ClusterType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "cluster_type");

    /// <summary>
    /// The cluster_version attribute.
    /// </summary>
    [TerraformPropertyName("cluster_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ClusterVersion { get; set; }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [TerraformPropertyName("database_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DatabaseName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "database_name");

    /// <summary>
    /// The default_iam_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("default_iam_role_arn")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DefaultIamRoleArn { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "default_iam_role_arn");

    /// <summary>
    /// The elastic_ip attribute.
    /// </summary>
    [TerraformPropertyName("elastic_ip")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ElasticIp { get; set; }

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    [TerraformPropertyName("encrypted")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Encrypted { get; set; }

    /// <summary>
    /// The enhanced_vpc_routing attribute.
    /// </summary>
    [TerraformPropertyName("enhanced_vpc_routing")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> EnhancedVpcRouting { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "enhanced_vpc_routing");

    /// <summary>
    /// The final_snapshot_identifier attribute.
    /// </summary>
    [TerraformPropertyName("final_snapshot_identifier")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? FinalSnapshotIdentifier { get; set; }

    /// <summary>
    /// The iam_roles attribute.
    /// </summary>
    [TerraformPropertyName("iam_roles")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> IamRoles { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "iam_roles");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> KmsKeyId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "kms_key_id");

    /// <summary>
    /// The maintenance_track_name attribute.
    /// </summary>
    [TerraformPropertyName("maintenance_track_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MaintenanceTrackName { get; set; }

    /// <summary>
    /// The manage_master_password attribute.
    /// </summary>
    [TerraformPropertyName("manage_master_password")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ManageMasterPassword { get; set; }

    /// <summary>
    /// The manual_snapshot_retention_period attribute.
    /// </summary>
    [TerraformPropertyName("manual_snapshot_retention_period")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? ManualSnapshotRetentionPeriod { get; set; }

    /// <summary>
    /// The master_password attribute.
    /// </summary>
    [TerraformPropertyName("master_password")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MasterPassword { get; set; }

    /// <summary>
    /// The master_password_secret_kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("master_password_secret_kms_key_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> MasterPasswordSecretKmsKeyId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "master_password_secret_kms_key_id");

    /// <summary>
    /// The master_password_wo attribute.
    /// </summary>
    [TerraformPropertyName("master_password_wo")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MasterPasswordWo { get; set; }

    /// <summary>
    /// The master_password_wo_version attribute.
    /// </summary>
    [TerraformPropertyName("master_password_wo_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MasterPasswordWoVersion { get; set; }

    /// <summary>
    /// The master_username attribute.
    /// </summary>
    [TerraformPropertyName("master_username")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MasterUsername { get; set; }

    /// <summary>
    /// The multi_az attribute.
    /// </summary>
    [TerraformPropertyName("multi_az")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? MultiAz { get; set; }

    /// <summary>
    /// The node_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeType is required")]
    [TerraformPropertyName("node_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> NodeType { get; set; }

    /// <summary>
    /// The number_of_nodes attribute.
    /// </summary>
    [TerraformPropertyName("number_of_nodes")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? NumberOfNodes { get; set; }

    /// <summary>
    /// The owner_account attribute.
    /// </summary>
    [TerraformPropertyName("owner_account")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? OwnerAccount { get; set; }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformPropertyName("port")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Port { get; set; }

    /// <summary>
    /// The preferred_maintenance_window attribute.
    /// </summary>
    [TerraformPropertyName("preferred_maintenance_window")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> PreferredMaintenanceWindow { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "preferred_maintenance_window");

    /// <summary>
    /// The publicly_accessible attribute.
    /// </summary>
    [TerraformPropertyName("publicly_accessible")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? PubliclyAccessible { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The skip_final_snapshot attribute.
    /// </summary>
    [TerraformPropertyName("skip_final_snapshot")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? SkipFinalSnapshot { get; set; }

    /// <summary>
    /// The snapshot_arn attribute.
    /// </summary>
    [TerraformPropertyName("snapshot_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SnapshotArn { get; set; }

    /// <summary>
    /// The snapshot_cluster_identifier attribute.
    /// </summary>
    [TerraformPropertyName("snapshot_cluster_identifier")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SnapshotClusterIdentifier { get; set; }

    /// <summary>
    /// The snapshot_identifier attribute.
    /// </summary>
    [TerraformPropertyName("snapshot_identifier")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SnapshotIdentifier { get; set; }

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
    /// The vpc_security_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("vpc_security_group_ids")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> VpcSecurityGroupIds { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "vpc_security_group_ids");

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsRedshiftClusterTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The cluster_namespace_arn attribute.
    /// </summary>
    [TerraformPropertyName("cluster_namespace_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ClusterNamespaceArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "cluster_namespace_arn");

    /// <summary>
    /// The cluster_nodes attribute.
    /// </summary>
    [TerraformPropertyName("cluster_nodes")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ClusterNodes => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "cluster_nodes");

    /// <summary>
    /// The cluster_public_key attribute.
    /// </summary>
    [TerraformPropertyName("cluster_public_key")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ClusterPublicKey => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "cluster_public_key");

    /// <summary>
    /// The cluster_revision_number attribute.
    /// </summary>
    [TerraformPropertyName("cluster_revision_number")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ClusterRevisionNumber => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "cluster_revision_number");

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    [TerraformPropertyName("dns_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DnsName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "dns_name");

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformPropertyName("endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Endpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "endpoint");

    /// <summary>
    /// The master_password_secret_arn attribute.
    /// </summary>
    [TerraformPropertyName("master_password_secret_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> MasterPasswordSecretArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "master_password_secret_arn");

}
