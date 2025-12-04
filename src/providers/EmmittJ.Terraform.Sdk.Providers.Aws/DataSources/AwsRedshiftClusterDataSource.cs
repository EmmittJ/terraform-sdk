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
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => GetArgument<TerraformMap<string>>("tags") ?? AsReference("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The allow_version_upgrade attribute.
    /// </summary>
    public TerraformValue<bool> AllowVersionUpgrade
        => AsReference("allow_version_upgrade");

    /// <summary>
    /// The aqua_configuration_status attribute.
    /// </summary>
    public TerraformValue<string> AquaConfigurationStatus
        => AsReference("aqua_configuration_status");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The automated_snapshot_retention_period attribute.
    /// </summary>
    public TerraformValue<double> AutomatedSnapshotRetentionPeriod
        => AsReference("automated_snapshot_retention_period");

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformValue<string> AvailabilityZone
        => AsReference("availability_zone");

    /// <summary>
    /// The availability_zone_relocation_enabled attribute.
    /// </summary>
    public TerraformValue<bool> AvailabilityZoneRelocationEnabled
        => AsReference("availability_zone_relocation_enabled");

    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    public TerraformValue<string> BucketName
        => AsReference("bucket_name");

    /// <summary>
    /// The cluster_namespace_arn attribute.
    /// </summary>
    public TerraformValue<string> ClusterNamespaceArn
        => AsReference("cluster_namespace_arn");

    /// <summary>
    /// The cluster_nodes attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ClusterNodes
        => AsReference("cluster_nodes");

    /// <summary>
    /// The cluster_parameter_group_name attribute.
    /// </summary>
    public TerraformValue<string> ClusterParameterGroupName
        => AsReference("cluster_parameter_group_name");

    /// <summary>
    /// The cluster_public_key attribute.
    /// </summary>
    public TerraformValue<string> ClusterPublicKey
        => AsReference("cluster_public_key");

    /// <summary>
    /// The cluster_revision_number attribute.
    /// </summary>
    public TerraformValue<string> ClusterRevisionNumber
        => AsReference("cluster_revision_number");

    /// <summary>
    /// The cluster_subnet_group_name attribute.
    /// </summary>
    public TerraformValue<string> ClusterSubnetGroupName
        => AsReference("cluster_subnet_group_name");

    /// <summary>
    /// The cluster_type attribute.
    /// </summary>
    public TerraformValue<string> ClusterType
        => AsReference("cluster_type");

    /// <summary>
    /// The cluster_version attribute.
    /// </summary>
    public TerraformValue<string> ClusterVersion
        => AsReference("cluster_version");

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    public TerraformValue<string> DatabaseName
        => AsReference("database_name");

    /// <summary>
    /// The default_iam_role_arn attribute.
    /// </summary>
    public TerraformValue<string> DefaultIamRoleArn
        => AsReference("default_iam_role_arn");

    /// <summary>
    /// The elastic_ip attribute.
    /// </summary>
    public TerraformValue<string> ElasticIp
        => AsReference("elastic_ip");

    /// <summary>
    /// The enable_logging attribute.
    /// </summary>
    public TerraformValue<bool> EnableLogging
        => AsReference("enable_logging");

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    public TerraformValue<bool> Encrypted
        => AsReference("encrypted");

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformValue<string> Endpoint
        => AsReference("endpoint");

    /// <summary>
    /// The enhanced_vpc_routing attribute.
    /// </summary>
    public TerraformValue<bool> EnhancedVpcRouting
        => AsReference("enhanced_vpc_routing");

    /// <summary>
    /// The iam_roles attribute.
    /// </summary>
    public TerraformList<string> IamRoles
        => AsReference("iam_roles");

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string> KmsKeyId
        => AsReference("kms_key_id");

    /// <summary>
    /// The log_destination_type attribute.
    /// </summary>
    public TerraformValue<string> LogDestinationType
        => AsReference("log_destination_type");

    /// <summary>
    /// The log_exports attribute.
    /// </summary>
    public TerraformSet<string> LogExports
        => AsReference("log_exports");

    /// <summary>
    /// The maintenance_track_name attribute.
    /// </summary>
    public TerraformValue<string> MaintenanceTrackName
        => AsReference("maintenance_track_name");

    /// <summary>
    /// The manual_snapshot_retention_period attribute.
    /// </summary>
    public TerraformValue<double> ManualSnapshotRetentionPeriod
        => AsReference("manual_snapshot_retention_period");

    /// <summary>
    /// The master_username attribute.
    /// </summary>
    public TerraformValue<string> MasterUsername
        => AsReference("master_username");

    /// <summary>
    /// The multi_az attribute.
    /// </summary>
    public TerraformValue<bool> MultiAz
        => AsReference("multi_az");

    /// <summary>
    /// The node_type attribute.
    /// </summary>
    public TerraformValue<string> NodeType
        => AsReference("node_type");

    /// <summary>
    /// The number_of_nodes attribute.
    /// </summary>
    public TerraformValue<double> NumberOfNodes
        => AsReference("number_of_nodes");

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double> Port
        => AsReference("port");

    /// <summary>
    /// The preferred_maintenance_window attribute.
    /// </summary>
    public TerraformValue<string> PreferredMaintenanceWindow
        => AsReference("preferred_maintenance_window");

    /// <summary>
    /// The publicly_accessible attribute.
    /// </summary>
    public TerraformValue<bool> PubliclyAccessible
        => AsReference("publicly_accessible");

    /// <summary>
    /// The s3_key_prefix attribute.
    /// </summary>
    public TerraformValue<string> S3KeyPrefix
        => AsReference("s3_key_prefix");

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformValue<string> VpcId
        => AsReference("vpc_id");

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    public TerraformList<string> VpcSecurityGroupIds
        => AsReference("vpc_security_group_ids");

}
