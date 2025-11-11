using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_redshift_cluster.
/// </summary>
public partial class AwsRedshiftClusterDataSource : TerraformDataSource
{
    public AwsRedshiftClusterDataSource(string name) : base("aws_redshift_cluster", name)
    {
    }

    /// <summary>
    /// The cluster_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterIdentifier is required")]
    [TerraformProperty("cluster_identifier")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ClusterIdentifier { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// The allow_version_upgrade attribute.
    /// </summary>
    [TerraformProperty("allow_version_upgrade")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> AllowVersionUpgrade { get; }

    /// <summary>
    /// The aqua_configuration_status attribute.
    /// </summary>
    [TerraformProperty("aqua_configuration_status")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> AquaConfigurationStatus { get; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The automated_snapshot_retention_period attribute.
    /// </summary>
    [TerraformProperty("automated_snapshot_retention_period")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> AutomatedSnapshotRetentionPeriod { get; }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    [TerraformProperty("availability_zone")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> AvailabilityZone { get; }

    /// <summary>
    /// The availability_zone_relocation_enabled attribute.
    /// </summary>
    [TerraformProperty("availability_zone_relocation_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> AvailabilityZoneRelocationEnabled { get; }

    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    [TerraformProperty("bucket_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> BucketName { get; }

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
    /// The cluster_parameter_group_name attribute.
    /// </summary>
    [TerraformProperty("cluster_parameter_group_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ClusterParameterGroupName { get; }

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
    /// The cluster_subnet_group_name attribute.
    /// </summary>
    [TerraformProperty("cluster_subnet_group_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ClusterSubnetGroupName { get; }

    /// <summary>
    /// The cluster_type attribute.
    /// </summary>
    [TerraformProperty("cluster_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ClusterType { get; }

    /// <summary>
    /// The cluster_version attribute.
    /// </summary>
    [TerraformProperty("cluster_version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ClusterVersion { get; }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [TerraformProperty("database_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DatabaseName { get; }

    /// <summary>
    /// The default_iam_role_arn attribute.
    /// </summary>
    [TerraformProperty("default_iam_role_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DefaultIamRoleArn { get; }

    /// <summary>
    /// The elastic_ip attribute.
    /// </summary>
    [TerraformProperty("elastic_ip")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ElasticIp { get; }

    /// <summary>
    /// The enable_logging attribute.
    /// </summary>
    [TerraformProperty("enable_logging")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> EnableLogging { get; }

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    [TerraformProperty("encrypted")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> Encrypted { get; }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformProperty("endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Endpoint { get; }

    /// <summary>
    /// The enhanced_vpc_routing attribute.
    /// </summary>
    [TerraformProperty("enhanced_vpc_routing")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> EnhancedVpcRouting { get; }

    /// <summary>
    /// The iam_roles attribute.
    /// </summary>
    [TerraformProperty("iam_roles")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> IamRoles { get; }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformProperty("kms_key_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> KmsKeyId { get; }

    /// <summary>
    /// The log_destination_type attribute.
    /// </summary>
    [TerraformProperty("log_destination_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LogDestinationType { get; }

    /// <summary>
    /// The log_exports attribute.
    /// </summary>
    [TerraformProperty("log_exports")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<string> LogExports { get; }

    /// <summary>
    /// The maintenance_track_name attribute.
    /// </summary>
    [TerraformProperty("maintenance_track_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> MaintenanceTrackName { get; }

    /// <summary>
    /// The manual_snapshot_retention_period attribute.
    /// </summary>
    [TerraformProperty("manual_snapshot_retention_period")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> ManualSnapshotRetentionPeriod { get; }

    /// <summary>
    /// The master_username attribute.
    /// </summary>
    [TerraformProperty("master_username")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> MasterUsername { get; }

    /// <summary>
    /// The multi_az attribute.
    /// </summary>
    [TerraformProperty("multi_az")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> MultiAz { get; }

    /// <summary>
    /// The node_type attribute.
    /// </summary>
    [TerraformProperty("node_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> NodeType { get; }

    /// <summary>
    /// The number_of_nodes attribute.
    /// </summary>
    [TerraformProperty("number_of_nodes")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> NumberOfNodes { get; }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformProperty("port")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> Port { get; }

    /// <summary>
    /// The preferred_maintenance_window attribute.
    /// </summary>
    [TerraformProperty("preferred_maintenance_window")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PreferredMaintenanceWindow { get; }

    /// <summary>
    /// The publicly_accessible attribute.
    /// </summary>
    [TerraformProperty("publicly_accessible")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> PubliclyAccessible { get; }

    /// <summary>
    /// The s3_key_prefix attribute.
    /// </summary>
    [TerraformProperty("s3_key_prefix")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> S3KeyPrefix { get; }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformProperty("vpc_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> VpcId { get; }

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    [TerraformProperty("vpc_security_group_ids")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> VpcSecurityGroupIds { get; }

}
