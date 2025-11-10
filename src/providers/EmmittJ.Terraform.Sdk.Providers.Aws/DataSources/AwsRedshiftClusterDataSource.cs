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
    public required TerraformProperty<TerraformProperty<string>> ClusterIdentifier { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The allow_version_upgrade attribute.
    /// </summary>
    [TerraformPropertyName("allow_version_upgrade")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> AllowVersionUpgrade => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "allow_version_upgrade");

    /// <summary>
    /// The aqua_configuration_status attribute.
    /// </summary>
    [TerraformPropertyName("aqua_configuration_status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AquaConfigurationStatus => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "aqua_configuration_status");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The automated_snapshot_retention_period attribute.
    /// </summary>
    [TerraformPropertyName("automated_snapshot_retention_period")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> AutomatedSnapshotRetentionPeriod => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "automated_snapshot_retention_period");

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    [TerraformPropertyName("availability_zone")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AvailabilityZone => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "availability_zone");

    /// <summary>
    /// The availability_zone_relocation_enabled attribute.
    /// </summary>
    [TerraformPropertyName("availability_zone_relocation_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> AvailabilityZoneRelocationEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "availability_zone_relocation_enabled");

    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    [TerraformPropertyName("bucket_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> BucketName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "bucket_name");

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
    /// The cluster_parameter_group_name attribute.
    /// </summary>
    [TerraformPropertyName("cluster_parameter_group_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ClusterParameterGroupName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "cluster_parameter_group_name");

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
    /// The cluster_subnet_group_name attribute.
    /// </summary>
    [TerraformPropertyName("cluster_subnet_group_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ClusterSubnetGroupName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "cluster_subnet_group_name");

    /// <summary>
    /// The cluster_type attribute.
    /// </summary>
    [TerraformPropertyName("cluster_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ClusterType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "cluster_type");

    /// <summary>
    /// The cluster_version attribute.
    /// </summary>
    [TerraformPropertyName("cluster_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ClusterVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "cluster_version");

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [TerraformPropertyName("database_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DatabaseName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "database_name");

    /// <summary>
    /// The default_iam_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("default_iam_role_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DefaultIamRoleArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "default_iam_role_arn");

    /// <summary>
    /// The elastic_ip attribute.
    /// </summary>
    [TerraformPropertyName("elastic_ip")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ElasticIp => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "elastic_ip");

    /// <summary>
    /// The enable_logging attribute.
    /// </summary>
    [TerraformPropertyName("enable_logging")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> EnableLogging => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "enable_logging");

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    [TerraformPropertyName("encrypted")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> Encrypted => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "encrypted");

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformPropertyName("endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Endpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "endpoint");

    /// <summary>
    /// The enhanced_vpc_routing attribute.
    /// </summary>
    [TerraformPropertyName("enhanced_vpc_routing")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> EnhancedVpcRouting => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "enhanced_vpc_routing");

    /// <summary>
    /// The iam_roles attribute.
    /// </summary>
    [TerraformPropertyName("iam_roles")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> IamRoles => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "iam_roles");

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> KmsKeyId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "kms_key_id");

    /// <summary>
    /// The log_destination_type attribute.
    /// </summary>
    [TerraformPropertyName("log_destination_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LogDestinationType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "log_destination_type");

    /// <summary>
    /// The log_exports attribute.
    /// </summary>
    [TerraformPropertyName("log_exports")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> LogExports => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "log_exports");

    /// <summary>
    /// The maintenance_track_name attribute.
    /// </summary>
    [TerraformPropertyName("maintenance_track_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> MaintenanceTrackName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "maintenance_track_name");

    /// <summary>
    /// The manual_snapshot_retention_period attribute.
    /// </summary>
    [TerraformPropertyName("manual_snapshot_retention_period")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> ManualSnapshotRetentionPeriod => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "manual_snapshot_retention_period");

    /// <summary>
    /// The master_username attribute.
    /// </summary>
    [TerraformPropertyName("master_username")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> MasterUsername => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "master_username");

    /// <summary>
    /// The multi_az attribute.
    /// </summary>
    [TerraformPropertyName("multi_az")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> MultiAz => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "multi_az");

    /// <summary>
    /// The node_type attribute.
    /// </summary>
    [TerraformPropertyName("node_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NodeType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "node_type");

    /// <summary>
    /// The number_of_nodes attribute.
    /// </summary>
    [TerraformPropertyName("number_of_nodes")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> NumberOfNodes => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "number_of_nodes");

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformPropertyName("port")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> Port => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "port");

    /// <summary>
    /// The preferred_maintenance_window attribute.
    /// </summary>
    [TerraformPropertyName("preferred_maintenance_window")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PreferredMaintenanceWindow => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "preferred_maintenance_window");

    /// <summary>
    /// The publicly_accessible attribute.
    /// </summary>
    [TerraformPropertyName("publicly_accessible")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> PubliclyAccessible => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "publicly_accessible");

    /// <summary>
    /// The s3_key_prefix attribute.
    /// </summary>
    [TerraformPropertyName("s3_key_prefix")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> S3KeyPrefix => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "s3_key_prefix");

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformPropertyName("vpc_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VpcId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "vpc_id");

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("vpc_security_group_ids")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> VpcSecurityGroupIds => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "vpc_security_group_ids");

}
