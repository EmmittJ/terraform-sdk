using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsRedshiftClusterTimeoutsBlock : TerraformBlockBase
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
/// Manages a aws_redshift_cluster resource.
/// </summary>
public partial class AwsRedshiftCluster : TerraformResource
{
    public AwsRedshiftCluster(string name) : base("aws_redshift_cluster", name)
    {
    }

    /// <summary>
    /// The allow_version_upgrade attribute.
    /// </summary>
    [TerraformProperty("allow_version_upgrade")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? AllowVersionUpgrade { get; set; }

    /// <summary>
    /// The apply_immediately attribute.
    /// </summary>
    [TerraformProperty("apply_immediately")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? ApplyImmediately { get; set; }

    /// <summary>
    /// The aqua_configuration_status attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformProperty("aqua_configuration_status")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> AquaConfigurationStatus { get; set; }

    /// <summary>
    /// The automated_snapshot_retention_period attribute.
    /// </summary>
    [TerraformProperty("automated_snapshot_retention_period")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? AutomatedSnapshotRetentionPeriod { get; set; }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    [TerraformProperty("availability_zone")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> AvailabilityZone { get; set; }

    /// <summary>
    /// The availability_zone_relocation_enabled attribute.
    /// </summary>
    [TerraformProperty("availability_zone_relocation_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? AvailabilityZoneRelocationEnabled { get; set; }

    /// <summary>
    /// The cluster_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterIdentifier is required")]
    [TerraformProperty("cluster_identifier")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ClusterIdentifier { get; set; }

    /// <summary>
    /// The cluster_parameter_group_name attribute.
    /// </summary>
    [TerraformProperty("cluster_parameter_group_name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ClusterParameterGroupName { get; set; }

    /// <summary>
    /// The cluster_subnet_group_name attribute.
    /// </summary>
    [TerraformProperty("cluster_subnet_group_name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ClusterSubnetGroupName { get; set; }

    /// <summary>
    /// The cluster_type attribute.
    /// </summary>
    [TerraformProperty("cluster_type")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ClusterType { get; set; }

    /// <summary>
    /// The cluster_version attribute.
    /// </summary>
    [TerraformProperty("cluster_version")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ClusterVersion { get; set; }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [TerraformProperty("database_name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> DatabaseName { get; set; }

    /// <summary>
    /// The default_iam_role_arn attribute.
    /// </summary>
    [TerraformProperty("default_iam_role_arn")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> DefaultIamRoleArn { get; set; }

    /// <summary>
    /// The elastic_ip attribute.
    /// </summary>
    [TerraformProperty("elastic_ip")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ElasticIp { get; set; }

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    [TerraformProperty("encrypted")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Encrypted { get; set; }

    /// <summary>
    /// The enhanced_vpc_routing attribute.
    /// </summary>
    [TerraformProperty("enhanced_vpc_routing")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> EnhancedVpcRouting { get; set; }

    /// <summary>
    /// The final_snapshot_identifier attribute.
    /// </summary>
    [TerraformProperty("final_snapshot_identifier")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? FinalSnapshotIdentifier { get; set; }

    /// <summary>
    /// The iam_roles attribute.
    /// </summary>
    [TerraformProperty("iam_roles")]
    // Optional+Computed - source generator will implement get/set
    public TerraformSet<string> IamRoles { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformProperty("kms_key_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> KmsKeyId { get; set; }

    /// <summary>
    /// The maintenance_track_name attribute.
    /// </summary>
    [TerraformProperty("maintenance_track_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? MaintenanceTrackName { get; set; }

    /// <summary>
    /// The manage_master_password attribute.
    /// </summary>
    [TerraformProperty("manage_master_password")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? ManageMasterPassword { get; set; }

    /// <summary>
    /// The manual_snapshot_retention_period attribute.
    /// </summary>
    [TerraformProperty("manual_snapshot_retention_period")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? ManualSnapshotRetentionPeriod { get; set; }

    /// <summary>
    /// The master_password attribute.
    /// </summary>
    [TerraformProperty("master_password")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? MasterPassword { get; set; }

    /// <summary>
    /// The master_password_secret_kms_key_id attribute.
    /// </summary>
    [TerraformProperty("master_password_secret_kms_key_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> MasterPasswordSecretKmsKeyId { get; set; }

    /// <summary>
    /// The master_password_wo attribute.
    /// </summary>
    [TerraformProperty("master_password_wo")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? MasterPasswordWo { get; set; }

    /// <summary>
    /// The master_password_wo_version attribute.
    /// </summary>
    [TerraformProperty("master_password_wo_version")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MasterPasswordWoVersion { get; set; }

    /// <summary>
    /// The master_username attribute.
    /// </summary>
    [TerraformProperty("master_username")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? MasterUsername { get; set; }

    /// <summary>
    /// The multi_az attribute.
    /// </summary>
    [TerraformProperty("multi_az")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? MultiAz { get; set; }

    /// <summary>
    /// The node_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeType is required")]
    [TerraformProperty("node_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> NodeType { get; set; }

    /// <summary>
    /// The number_of_nodes attribute.
    /// </summary>
    [TerraformProperty("number_of_nodes")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? NumberOfNodes { get; set; }

    /// <summary>
    /// The owner_account attribute.
    /// </summary>
    [TerraformProperty("owner_account")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? OwnerAccount { get; set; }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformProperty("port")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? Port { get; set; }

    /// <summary>
    /// The preferred_maintenance_window attribute.
    /// </summary>
    [TerraformProperty("preferred_maintenance_window")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> PreferredMaintenanceWindow { get; set; }

    /// <summary>
    /// The publicly_accessible attribute.
    /// </summary>
    [TerraformProperty("publicly_accessible")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? PubliclyAccessible { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The skip_final_snapshot attribute.
    /// </summary>
    [TerraformProperty("skip_final_snapshot")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? SkipFinalSnapshot { get; set; }

    /// <summary>
    /// The snapshot_arn attribute.
    /// </summary>
    [TerraformProperty("snapshot_arn")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SnapshotArn { get; set; }

    /// <summary>
    /// The snapshot_cluster_identifier attribute.
    /// </summary>
    [TerraformProperty("snapshot_cluster_identifier")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SnapshotClusterIdentifier { get; set; }

    /// <summary>
    /// The snapshot_identifier attribute.
    /// </summary>
    [TerraformProperty("snapshot_identifier")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SnapshotIdentifier { get; set; }

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
    /// The vpc_security_group_ids attribute.
    /// </summary>
    [TerraformProperty("vpc_security_group_ids")]
    // Optional+Computed - source generator will implement get/set
    public TerraformSet<string> VpcSecurityGroupIds { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AwsRedshiftClusterTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The cluster_namespace_arn attribute.
    /// </summary>
    [TerraformProperty("cluster_namespace_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ClusterNamespaceArn { get; }

    /// <summary>
    /// The cluster_nodes attribute.
    /// </summary>
    [TerraformProperty("cluster_nodes")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> ClusterNodes { get; }

    /// <summary>
    /// The cluster_public_key attribute.
    /// </summary>
    [TerraformProperty("cluster_public_key")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ClusterPublicKey { get; }

    /// <summary>
    /// The cluster_revision_number attribute.
    /// </summary>
    [TerraformProperty("cluster_revision_number")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ClusterRevisionNumber { get; }

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    [TerraformProperty("dns_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DnsName { get; }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformProperty("endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Endpoint { get; }

    /// <summary>
    /// The master_password_secret_arn attribute.
    /// </summary>
    [TerraformProperty("master_password_secret_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> MasterPasswordSecretArn { get; }

}
