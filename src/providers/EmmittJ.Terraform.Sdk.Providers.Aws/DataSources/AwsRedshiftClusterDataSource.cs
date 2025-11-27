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
        get => new TerraformReference<string>(this, "cluster_identifier");
        set => SetArgument("cluster_identifier", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The allow_version_upgrade attribute.
    /// </summary>
    public TerraformValue<bool> AllowVersionUpgrade
    {
        get => new TerraformReference<bool>(this, "allow_version_upgrade");
    }

    /// <summary>
    /// The aqua_configuration_status attribute.
    /// </summary>
    public TerraformValue<string> AquaConfigurationStatus
    {
        get => new TerraformReference<string>(this, "aqua_configuration_status");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The automated_snapshot_retention_period attribute.
    /// </summary>
    public TerraformValue<double> AutomatedSnapshotRetentionPeriod
    {
        get => new TerraformReference<double>(this, "automated_snapshot_retention_period");
    }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformValue<string> AvailabilityZone
    {
        get => new TerraformReference<string>(this, "availability_zone");
    }

    /// <summary>
    /// The availability_zone_relocation_enabled attribute.
    /// </summary>
    public TerraformValue<bool> AvailabilityZoneRelocationEnabled
    {
        get => new TerraformReference<bool>(this, "availability_zone_relocation_enabled");
    }

    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    public TerraformValue<string> BucketName
    {
        get => new TerraformReference<string>(this, "bucket_name");
    }

    /// <summary>
    /// The cluster_namespace_arn attribute.
    /// </summary>
    public TerraformValue<string> ClusterNamespaceArn
    {
        get => new TerraformReference<string>(this, "cluster_namespace_arn");
    }

    /// <summary>
    /// The cluster_nodes attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ClusterNodes
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "cluster_nodes").ResolveNodes(ctx));
    }

    /// <summary>
    /// The cluster_parameter_group_name attribute.
    /// </summary>
    public TerraformValue<string> ClusterParameterGroupName
    {
        get => new TerraformReference<string>(this, "cluster_parameter_group_name");
    }

    /// <summary>
    /// The cluster_public_key attribute.
    /// </summary>
    public TerraformValue<string> ClusterPublicKey
    {
        get => new TerraformReference<string>(this, "cluster_public_key");
    }

    /// <summary>
    /// The cluster_revision_number attribute.
    /// </summary>
    public TerraformValue<string> ClusterRevisionNumber
    {
        get => new TerraformReference<string>(this, "cluster_revision_number");
    }

    /// <summary>
    /// The cluster_subnet_group_name attribute.
    /// </summary>
    public TerraformValue<string> ClusterSubnetGroupName
    {
        get => new TerraformReference<string>(this, "cluster_subnet_group_name");
    }

    /// <summary>
    /// The cluster_type attribute.
    /// </summary>
    public TerraformValue<string> ClusterType
    {
        get => new TerraformReference<string>(this, "cluster_type");
    }

    /// <summary>
    /// The cluster_version attribute.
    /// </summary>
    public TerraformValue<string> ClusterVersion
    {
        get => new TerraformReference<string>(this, "cluster_version");
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    public TerraformValue<string> DatabaseName
    {
        get => new TerraformReference<string>(this, "database_name");
    }

    /// <summary>
    /// The default_iam_role_arn attribute.
    /// </summary>
    public TerraformValue<string> DefaultIamRoleArn
    {
        get => new TerraformReference<string>(this, "default_iam_role_arn");
    }

    /// <summary>
    /// The elastic_ip attribute.
    /// </summary>
    public TerraformValue<string> ElasticIp
    {
        get => new TerraformReference<string>(this, "elastic_ip");
    }

    /// <summary>
    /// The enable_logging attribute.
    /// </summary>
    public TerraformValue<bool> EnableLogging
    {
        get => new TerraformReference<bool>(this, "enable_logging");
    }

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    public TerraformValue<bool> Encrypted
    {
        get => new TerraformReference<bool>(this, "encrypted");
    }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformValue<string> Endpoint
    {
        get => new TerraformReference<string>(this, "endpoint");
    }

    /// <summary>
    /// The enhanced_vpc_routing attribute.
    /// </summary>
    public TerraformValue<bool> EnhancedVpcRouting
    {
        get => new TerraformReference<bool>(this, "enhanced_vpc_routing");
    }

    /// <summary>
    /// The iam_roles attribute.
    /// </summary>
    public TerraformList<string> IamRoles
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "iam_roles").ResolveNodes(ctx));
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string> KmsKeyId
    {
        get => new TerraformReference<string>(this, "kms_key_id");
    }

    /// <summary>
    /// The log_destination_type attribute.
    /// </summary>
    public TerraformValue<string> LogDestinationType
    {
        get => new TerraformReference<string>(this, "log_destination_type");
    }

    /// <summary>
    /// The log_exports attribute.
    /// </summary>
    public TerraformSet<string> LogExports
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "log_exports").ResolveNodes(ctx));
    }

    /// <summary>
    /// The maintenance_track_name attribute.
    /// </summary>
    public TerraformValue<string> MaintenanceTrackName
    {
        get => new TerraformReference<string>(this, "maintenance_track_name");
    }

    /// <summary>
    /// The manual_snapshot_retention_period attribute.
    /// </summary>
    public TerraformValue<double> ManualSnapshotRetentionPeriod
    {
        get => new TerraformReference<double>(this, "manual_snapshot_retention_period");
    }

    /// <summary>
    /// The master_username attribute.
    /// </summary>
    public TerraformValue<string> MasterUsername
    {
        get => new TerraformReference<string>(this, "master_username");
    }

    /// <summary>
    /// The multi_az attribute.
    /// </summary>
    public TerraformValue<bool> MultiAz
    {
        get => new TerraformReference<bool>(this, "multi_az");
    }

    /// <summary>
    /// The node_type attribute.
    /// </summary>
    public TerraformValue<string> NodeType
    {
        get => new TerraformReference<string>(this, "node_type");
    }

    /// <summary>
    /// The number_of_nodes attribute.
    /// </summary>
    public TerraformValue<double> NumberOfNodes
    {
        get => new TerraformReference<double>(this, "number_of_nodes");
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double> Port
    {
        get => new TerraformReference<double>(this, "port");
    }

    /// <summary>
    /// The preferred_maintenance_window attribute.
    /// </summary>
    public TerraformValue<string> PreferredMaintenanceWindow
    {
        get => new TerraformReference<string>(this, "preferred_maintenance_window");
    }

    /// <summary>
    /// The publicly_accessible attribute.
    /// </summary>
    public TerraformValue<bool> PubliclyAccessible
    {
        get => new TerraformReference<bool>(this, "publicly_accessible");
    }

    /// <summary>
    /// The s3_key_prefix attribute.
    /// </summary>
    public TerraformValue<string> S3KeyPrefix
    {
        get => new TerraformReference<string>(this, "s3_key_prefix");
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformValue<string> VpcId
    {
        get => new TerraformReference<string>(this, "vpc_id");
    }

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    public TerraformList<string> VpcSecurityGroupIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "vpc_security_group_ids").ResolveNodes(ctx));
    }

}
