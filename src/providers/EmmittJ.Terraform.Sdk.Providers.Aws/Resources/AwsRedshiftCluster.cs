using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsRedshiftClusterTimeoutsBlock
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
    public TerraformValue<bool>? AllowVersionUpgrade { get; set; }

    /// <summary>
    /// The apply_immediately attribute.
    /// </summary>
    [TerraformPropertyName("apply_immediately")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ApplyImmediately { get; set; }

    /// <summary>
    /// The aqua_configuration_status attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformPropertyName("aqua_configuration_status")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> AquaConfigurationStatus { get; set; } = default!;

    /// <summary>
    /// The automated_snapshot_retention_period attribute.
    /// </summary>
    [TerraformPropertyName("automated_snapshot_retention_period")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? AutomatedSnapshotRetentionPeriod { get; set; }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    [TerraformPropertyName("availability_zone")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> AvailabilityZone { get; set; } = default!;

    /// <summary>
    /// The availability_zone_relocation_enabled attribute.
    /// </summary>
    [TerraformPropertyName("availability_zone_relocation_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AvailabilityZoneRelocationEnabled { get; set; }

    /// <summary>
    /// The cluster_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterIdentifier is required")]
    [TerraformPropertyName("cluster_identifier")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ClusterIdentifier { get; set; }

    /// <summary>
    /// The cluster_parameter_group_name attribute.
    /// </summary>
    [TerraformPropertyName("cluster_parameter_group_name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ClusterParameterGroupName { get; set; } = default!;

    /// <summary>
    /// The cluster_subnet_group_name attribute.
    /// </summary>
    [TerraformPropertyName("cluster_subnet_group_name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ClusterSubnetGroupName { get; set; } = default!;

    /// <summary>
    /// The cluster_type attribute.
    /// </summary>
    [TerraformPropertyName("cluster_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ClusterType { get; set; } = default!;

    /// <summary>
    /// The cluster_version attribute.
    /// </summary>
    [TerraformPropertyName("cluster_version")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ClusterVersion { get; set; }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [TerraformPropertyName("database_name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> DatabaseName { get; set; } = default!;

    /// <summary>
    /// The default_iam_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("default_iam_role_arn")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> DefaultIamRoleArn { get; set; } = default!;

    /// <summary>
    /// The elastic_ip attribute.
    /// </summary>
    [TerraformPropertyName("elastic_ip")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ElasticIp { get; set; }

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    [TerraformPropertyName("encrypted")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Encrypted { get; set; }

    /// <summary>
    /// The enhanced_vpc_routing attribute.
    /// </summary>
    [TerraformPropertyName("enhanced_vpc_routing")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> EnhancedVpcRouting { get; set; } = default!;

    /// <summary>
    /// The final_snapshot_identifier attribute.
    /// </summary>
    [TerraformPropertyName("final_snapshot_identifier")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? FinalSnapshotIdentifier { get; set; }

    /// <summary>
    /// The iam_roles attribute.
    /// </summary>
    [TerraformPropertyName("iam_roles")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<string> IamRoles { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> KmsKeyId { get; set; } = default!;

    /// <summary>
    /// The maintenance_track_name attribute.
    /// </summary>
    [TerraformPropertyName("maintenance_track_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MaintenanceTrackName { get; set; }

    /// <summary>
    /// The manage_master_password attribute.
    /// </summary>
    [TerraformPropertyName("manage_master_password")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ManageMasterPassword { get; set; }

    /// <summary>
    /// The manual_snapshot_retention_period attribute.
    /// </summary>
    [TerraformPropertyName("manual_snapshot_retention_period")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? ManualSnapshotRetentionPeriod { get; set; }

    /// <summary>
    /// The master_password attribute.
    /// </summary>
    [TerraformPropertyName("master_password")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MasterPassword { get; set; }

    /// <summary>
    /// The master_password_secret_kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("master_password_secret_kms_key_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> MasterPasswordSecretKmsKeyId { get; set; } = default!;

    /// <summary>
    /// The master_password_wo attribute.
    /// </summary>
    [TerraformPropertyName("master_password_wo")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MasterPasswordWo { get; set; }

    /// <summary>
    /// The master_password_wo_version attribute.
    /// </summary>
    [TerraformPropertyName("master_password_wo_version")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MasterPasswordWoVersion { get; set; }

    /// <summary>
    /// The master_username attribute.
    /// </summary>
    [TerraformPropertyName("master_username")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MasterUsername { get; set; }

    /// <summary>
    /// The multi_az attribute.
    /// </summary>
    [TerraformPropertyName("multi_az")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? MultiAz { get; set; }

    /// <summary>
    /// The node_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeType is required")]
    [TerraformPropertyName("node_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> NodeType { get; set; }

    /// <summary>
    /// The number_of_nodes attribute.
    /// </summary>
    [TerraformPropertyName("number_of_nodes")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? NumberOfNodes { get; set; }

    /// <summary>
    /// The owner_account attribute.
    /// </summary>
    [TerraformPropertyName("owner_account")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? OwnerAccount { get; set; }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformPropertyName("port")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? Port { get; set; }

    /// <summary>
    /// The preferred_maintenance_window attribute.
    /// </summary>
    [TerraformPropertyName("preferred_maintenance_window")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> PreferredMaintenanceWindow { get; set; } = default!;

    /// <summary>
    /// The publicly_accessible attribute.
    /// </summary>
    [TerraformPropertyName("publicly_accessible")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? PubliclyAccessible { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The skip_final_snapshot attribute.
    /// </summary>
    [TerraformPropertyName("skip_final_snapshot")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? SkipFinalSnapshot { get; set; }

    /// <summary>
    /// The snapshot_arn attribute.
    /// </summary>
    [TerraformPropertyName("snapshot_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SnapshotArn { get; set; }

    /// <summary>
    /// The snapshot_cluster_identifier attribute.
    /// </summary>
    [TerraformPropertyName("snapshot_cluster_identifier")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SnapshotClusterIdentifier { get; set; }

    /// <summary>
    /// The snapshot_identifier attribute.
    /// </summary>
    [TerraformPropertyName("snapshot_identifier")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SnapshotIdentifier { get; set; }

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
    /// The vpc_security_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("vpc_security_group_ids")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<string> VpcSecurityGroupIds { get; set; } = default!;

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsRedshiftClusterTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The cluster_namespace_arn attribute.
    /// </summary>
    [TerraformPropertyName("cluster_namespace_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ClusterNamespaceArn => new TerraformReference(this, "cluster_namespace_arn");

    /// <summary>
    /// The cluster_nodes attribute.
    /// </summary>
    [TerraformPropertyName("cluster_nodes")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ClusterNodes => new TerraformReference(this, "cluster_nodes");

    /// <summary>
    /// The cluster_public_key attribute.
    /// </summary>
    [TerraformPropertyName("cluster_public_key")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ClusterPublicKey => new TerraformReference(this, "cluster_public_key");

    /// <summary>
    /// The cluster_revision_number attribute.
    /// </summary>
    [TerraformPropertyName("cluster_revision_number")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ClusterRevisionNumber => new TerraformReference(this, "cluster_revision_number");

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    [TerraformPropertyName("dns_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DnsName => new TerraformReference(this, "dns_name");

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformPropertyName("endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Endpoint => new TerraformReference(this, "endpoint");

    /// <summary>
    /// The master_password_secret_arn attribute.
    /// </summary>
    [TerraformPropertyName("master_password_secret_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> MasterPasswordSecretArn => new TerraformReference(this, "master_password_secret_arn");

}
