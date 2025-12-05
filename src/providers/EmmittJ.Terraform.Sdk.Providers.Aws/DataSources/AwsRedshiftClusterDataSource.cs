using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_redshift_cluster Terraform data source.
/// Retrieves information about a aws_redshift_cluster.
/// </summary>
public partial class AwsRedshiftClusterDataSource(string name) : TerraformDataSource("aws_redshift_cluster", name)
{
    /// <summary>
    /// The cluster_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterIdentifier is required")]
    public required TerraformValue<string> ClusterIdentifier
    {
        get => GetRequiredArgument<TerraformValue<string>>("cluster_identifier");
        set => SetArgument("cluster_identifier", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => GetArgument<TerraformMap<string>>("tags") ?? CreateReference("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The allow_version_upgrade attribute.
    /// </summary>
    public TerraformValue<bool> AllowVersionUpgrade
        => CreateReference("allow_version_upgrade");

    /// <summary>
    /// The aqua_configuration_status attribute.
    /// </summary>
    public TerraformValue<string> AquaConfigurationStatus
        => CreateReference("aqua_configuration_status");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The automated_snapshot_retention_period attribute.
    /// </summary>
    public TerraformValue<double> AutomatedSnapshotRetentionPeriod
        => CreateReference("automated_snapshot_retention_period");

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformValue<string> AvailabilityZone
        => CreateReference("availability_zone");

    /// <summary>
    /// The availability_zone_relocation_enabled attribute.
    /// </summary>
    public TerraformValue<bool> AvailabilityZoneRelocationEnabled
        => CreateReference("availability_zone_relocation_enabled");

    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    public TerraformValue<string> BucketName
        => CreateReference("bucket_name");

    /// <summary>
    /// The cluster_namespace_arn attribute.
    /// </summary>
    public TerraformValue<string> ClusterNamespaceArn
        => CreateReference("cluster_namespace_arn");

    /// <summary>
    /// The cluster_nodes attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ClusterNodes
        => CreateReference("cluster_nodes");

    /// <summary>
    /// The cluster_parameter_group_name attribute.
    /// </summary>
    public TerraformValue<string> ClusterParameterGroupName
        => CreateReference("cluster_parameter_group_name");

    /// <summary>
    /// The cluster_public_key attribute.
    /// </summary>
    public TerraformValue<string> ClusterPublicKey
        => CreateReference("cluster_public_key");

    /// <summary>
    /// The cluster_revision_number attribute.
    /// </summary>
    public TerraformValue<string> ClusterRevisionNumber
        => CreateReference("cluster_revision_number");

    /// <summary>
    /// The cluster_subnet_group_name attribute.
    /// </summary>
    public TerraformValue<string> ClusterSubnetGroupName
        => CreateReference("cluster_subnet_group_name");

    /// <summary>
    /// The cluster_type attribute.
    /// </summary>
    public TerraformValue<string> ClusterType
        => CreateReference("cluster_type");

    /// <summary>
    /// The cluster_version attribute.
    /// </summary>
    public TerraformValue<string> ClusterVersion
        => CreateReference("cluster_version");

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    public TerraformValue<string> DatabaseName
        => CreateReference("database_name");

    /// <summary>
    /// The default_iam_role_arn attribute.
    /// </summary>
    public TerraformValue<string> DefaultIamRoleArn
        => CreateReference("default_iam_role_arn");

    /// <summary>
    /// The elastic_ip attribute.
    /// </summary>
    public TerraformValue<string> ElasticIp
        => CreateReference("elastic_ip");

    /// <summary>
    /// The enable_logging attribute.
    /// </summary>
    public TerraformValue<bool> EnableLogging
        => CreateReference("enable_logging");

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    public TerraformValue<bool> Encrypted
        => CreateReference("encrypted");

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformValue<string> Endpoint
        => CreateReference("endpoint");

    /// <summary>
    /// The enhanced_vpc_routing attribute.
    /// </summary>
    public TerraformValue<bool> EnhancedVpcRouting
        => CreateReference("enhanced_vpc_routing");

    /// <summary>
    /// The iam_roles attribute.
    /// </summary>
    public TerraformList<string> IamRoles
        => CreateReference("iam_roles");

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string> KmsKeyId
        => CreateReference("kms_key_id");

    /// <summary>
    /// The log_destination_type attribute.
    /// </summary>
    public TerraformValue<string> LogDestinationType
        => CreateReference("log_destination_type");

    /// <summary>
    /// The log_exports attribute.
    /// </summary>
    public TerraformSet<string> LogExports
        => CreateReference("log_exports");

    /// <summary>
    /// The maintenance_track_name attribute.
    /// </summary>
    public TerraformValue<string> MaintenanceTrackName
        => CreateReference("maintenance_track_name");

    /// <summary>
    /// The manual_snapshot_retention_period attribute.
    /// </summary>
    public TerraformValue<double> ManualSnapshotRetentionPeriod
        => CreateReference("manual_snapshot_retention_period");

    /// <summary>
    /// The master_username attribute.
    /// </summary>
    public TerraformValue<string> MasterUsername
        => CreateReference("master_username");

    /// <summary>
    /// The multi_az attribute.
    /// </summary>
    public TerraformValue<bool> MultiAz
        => CreateReference("multi_az");

    /// <summary>
    /// The node_type attribute.
    /// </summary>
    public TerraformValue<string> NodeType
        => CreateReference("node_type");

    /// <summary>
    /// The number_of_nodes attribute.
    /// </summary>
    public TerraformValue<double> NumberOfNodes
        => CreateReference("number_of_nodes");

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double> Port
        => CreateReference("port");

    /// <summary>
    /// The preferred_maintenance_window attribute.
    /// </summary>
    public TerraformValue<string> PreferredMaintenanceWindow
        => CreateReference("preferred_maintenance_window");

    /// <summary>
    /// The publicly_accessible attribute.
    /// </summary>
    public TerraformValue<bool> PubliclyAccessible
        => CreateReference("publicly_accessible");

    /// <summary>
    /// The s3_key_prefix attribute.
    /// </summary>
    public TerraformValue<string> S3KeyPrefix
        => CreateReference("s3_key_prefix");

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformValue<string> VpcId
        => CreateReference("vpc_id");

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    public TerraformList<string> VpcSecurityGroupIds
        => CreateReference("vpc_security_group_ids");

}
