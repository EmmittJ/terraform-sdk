using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_redshift_cluster.
/// </summary>
public class AwsRedshiftClusterDataSource : TerraformDataSource
{
    public AwsRedshiftClusterDataSource(string name) : base("aws_redshift_cluster", name)
    {
    }

    /// <summary>
    /// The cluster_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterIdentifier is required")]
    [TerraformPropertyName("cluster_identifier")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ClusterIdentifier { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Tags { get; set; } = default!;

    /// <summary>
    /// The allow_version_upgrade attribute.
    /// </summary>
    [TerraformPropertyName("allow_version_upgrade")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> AllowVersionUpgrade => new TerraformReference(this, "allow_version_upgrade");

    /// <summary>
    /// The aqua_configuration_status attribute.
    /// </summary>
    [TerraformPropertyName("aqua_configuration_status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AquaConfigurationStatus => new TerraformReference(this, "aqua_configuration_status");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The automated_snapshot_retention_period attribute.
    /// </summary>
    [TerraformPropertyName("automated_snapshot_retention_period")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> AutomatedSnapshotRetentionPeriod => new TerraformReference(this, "automated_snapshot_retention_period");

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    [TerraformPropertyName("availability_zone")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AvailabilityZone => new TerraformReference(this, "availability_zone");

    /// <summary>
    /// The availability_zone_relocation_enabled attribute.
    /// </summary>
    [TerraformPropertyName("availability_zone_relocation_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> AvailabilityZoneRelocationEnabled => new TerraformReference(this, "availability_zone_relocation_enabled");

    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    [TerraformPropertyName("bucket_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> BucketName => new TerraformReference(this, "bucket_name");

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
    /// The cluster_parameter_group_name attribute.
    /// </summary>
    [TerraformPropertyName("cluster_parameter_group_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ClusterParameterGroupName => new TerraformReference(this, "cluster_parameter_group_name");

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
    /// The cluster_subnet_group_name attribute.
    /// </summary>
    [TerraformPropertyName("cluster_subnet_group_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ClusterSubnetGroupName => new TerraformReference(this, "cluster_subnet_group_name");

    /// <summary>
    /// The cluster_type attribute.
    /// </summary>
    [TerraformPropertyName("cluster_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ClusterType => new TerraformReference(this, "cluster_type");

    /// <summary>
    /// The cluster_version attribute.
    /// </summary>
    [TerraformPropertyName("cluster_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ClusterVersion => new TerraformReference(this, "cluster_version");

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [TerraformPropertyName("database_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DatabaseName => new TerraformReference(this, "database_name");

    /// <summary>
    /// The default_iam_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("default_iam_role_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DefaultIamRoleArn => new TerraformReference(this, "default_iam_role_arn");

    /// <summary>
    /// The elastic_ip attribute.
    /// </summary>
    [TerraformPropertyName("elastic_ip")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ElasticIp => new TerraformReference(this, "elastic_ip");

    /// <summary>
    /// The enable_logging attribute.
    /// </summary>
    [TerraformPropertyName("enable_logging")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> EnableLogging => new TerraformReference(this, "enable_logging");

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    [TerraformPropertyName("encrypted")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> Encrypted => new TerraformReference(this, "encrypted");

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformPropertyName("endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Endpoint => new TerraformReference(this, "endpoint");

    /// <summary>
    /// The enhanced_vpc_routing attribute.
    /// </summary>
    [TerraformPropertyName("enhanced_vpc_routing")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> EnhancedVpcRouting => new TerraformReference(this, "enhanced_vpc_routing");

    /// <summary>
    /// The iam_roles attribute.
    /// </summary>
    [TerraformPropertyName("iam_roles")]
    // Output-only attribute - read-only reference
    public TerraformList<string> IamRoles => new TerraformReference(this, "iam_roles");

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> KmsKeyId => new TerraformReference(this, "kms_key_id");

    /// <summary>
    /// The log_destination_type attribute.
    /// </summary>
    [TerraformPropertyName("log_destination_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LogDestinationType => new TerraformReference(this, "log_destination_type");

    /// <summary>
    /// The log_exports attribute.
    /// </summary>
    [TerraformPropertyName("log_exports")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> LogExports => new TerraformReference(this, "log_exports");

    /// <summary>
    /// The maintenance_track_name attribute.
    /// </summary>
    [TerraformPropertyName("maintenance_track_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> MaintenanceTrackName => new TerraformReference(this, "maintenance_track_name");

    /// <summary>
    /// The manual_snapshot_retention_period attribute.
    /// </summary>
    [TerraformPropertyName("manual_snapshot_retention_period")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> ManualSnapshotRetentionPeriod => new TerraformReference(this, "manual_snapshot_retention_period");

    /// <summary>
    /// The master_username attribute.
    /// </summary>
    [TerraformPropertyName("master_username")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> MasterUsername => new TerraformReference(this, "master_username");

    /// <summary>
    /// The multi_az attribute.
    /// </summary>
    [TerraformPropertyName("multi_az")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> MultiAz => new TerraformReference(this, "multi_az");

    /// <summary>
    /// The node_type attribute.
    /// </summary>
    [TerraformPropertyName("node_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> NodeType => new TerraformReference(this, "node_type");

    /// <summary>
    /// The number_of_nodes attribute.
    /// </summary>
    [TerraformPropertyName("number_of_nodes")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> NumberOfNodes => new TerraformReference(this, "number_of_nodes");

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformPropertyName("port")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> Port => new TerraformReference(this, "port");

    /// <summary>
    /// The preferred_maintenance_window attribute.
    /// </summary>
    [TerraformPropertyName("preferred_maintenance_window")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PreferredMaintenanceWindow => new TerraformReference(this, "preferred_maintenance_window");

    /// <summary>
    /// The publicly_accessible attribute.
    /// </summary>
    [TerraformPropertyName("publicly_accessible")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> PubliclyAccessible => new TerraformReference(this, "publicly_accessible");

    /// <summary>
    /// The s3_key_prefix attribute.
    /// </summary>
    [TerraformPropertyName("s3_key_prefix")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> S3KeyPrefix => new TerraformReference(this, "s3_key_prefix");

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformPropertyName("vpc_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> VpcId => new TerraformReference(this, "vpc_id");

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("vpc_security_group_ids")]
    // Output-only attribute - read-only reference
    public TerraformList<string> VpcSecurityGroupIds => new TerraformReference(this, "vpc_security_group_ids");

}
