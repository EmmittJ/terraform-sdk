using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsRedshiftCluster.
/// Nesting mode: single
/// </summary>
public class AwsRedshiftClusterTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_redshift_cluster Terraform resource.
/// Manages a aws_redshift_cluster resource.
/// </summary>
public partial class AwsRedshiftCluster(string name) : TerraformResource("aws_redshift_cluster", name)
{
    /// <summary>
    /// The allow_version_upgrade attribute.
    /// </summary>
    public TerraformValue<bool>? AllowVersionUpgrade
    {
        get => GetArgument<TerraformValue<bool>>("allow_version_upgrade");
        set => SetArgument("allow_version_upgrade", value);
    }

    /// <summary>
    /// The apply_immediately attribute.
    /// </summary>
    public TerraformValue<bool>? ApplyImmediately
    {
        get => GetArgument<TerraformValue<bool>>("apply_immediately");
        set => SetArgument("apply_immediately", value);
    }

    /// <summary>
    /// The aqua_configuration_status attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> AquaConfigurationStatus
    {
        get => GetArgument<TerraformValue<string>>("aqua_configuration_status") ?? CreateReference("aqua_configuration_status");
        set => SetArgument("aqua_configuration_status", value);
    }

    /// <summary>
    /// The automated_snapshot_retention_period attribute.
    /// </summary>
    public TerraformValue<double>? AutomatedSnapshotRetentionPeriod
    {
        get => GetArgument<TerraformValue<double>>("automated_snapshot_retention_period");
        set => SetArgument("automated_snapshot_retention_period", value);
    }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformValue<string> AvailabilityZone
    {
        get => GetArgument<TerraformValue<string>>("availability_zone") ?? CreateReference("availability_zone");
        set => SetArgument("availability_zone", value);
    }

    /// <summary>
    /// The availability_zone_relocation_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? AvailabilityZoneRelocationEnabled
    {
        get => GetArgument<TerraformValue<bool>>("availability_zone_relocation_enabled");
        set => SetArgument("availability_zone_relocation_enabled", value);
    }

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
    /// The cluster_parameter_group_name attribute.
    /// </summary>
    public TerraformValue<string> ClusterParameterGroupName
    {
        get => GetArgument<TerraformValue<string>>("cluster_parameter_group_name") ?? CreateReference("cluster_parameter_group_name");
        set => SetArgument("cluster_parameter_group_name", value);
    }

    /// <summary>
    /// The cluster_subnet_group_name attribute.
    /// </summary>
    public TerraformValue<string> ClusterSubnetGroupName
    {
        get => GetArgument<TerraformValue<string>>("cluster_subnet_group_name") ?? CreateReference("cluster_subnet_group_name");
        set => SetArgument("cluster_subnet_group_name", value);
    }

    /// <summary>
    /// The cluster_type attribute.
    /// </summary>
    public TerraformValue<string> ClusterType
    {
        get => GetArgument<TerraformValue<string>>("cluster_type") ?? CreateReference("cluster_type");
        set => SetArgument("cluster_type", value);
    }

    /// <summary>
    /// The cluster_version attribute.
    /// </summary>
    public TerraformValue<string>? ClusterVersion
    {
        get => GetArgument<TerraformValue<string>>("cluster_version");
        set => SetArgument("cluster_version", value);
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    public TerraformValue<string> DatabaseName
    {
        get => GetArgument<TerraformValue<string>>("database_name") ?? CreateReference("database_name");
        set => SetArgument("database_name", value);
    }

    /// <summary>
    /// The default_iam_role_arn attribute.
    /// </summary>
    public TerraformValue<string> DefaultIamRoleArn
    {
        get => GetArgument<TerraformValue<string>>("default_iam_role_arn") ?? CreateReference("default_iam_role_arn");
        set => SetArgument("default_iam_role_arn", value);
    }

    /// <summary>
    /// The elastic_ip attribute.
    /// </summary>
    public TerraformValue<string>? ElasticIp
    {
        get => GetArgument<TerraformValue<string>>("elastic_ip");
        set => SetArgument("elastic_ip", value);
    }

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    public TerraformValue<string>? Encrypted
    {
        get => GetArgument<TerraformValue<string>>("encrypted");
        set => SetArgument("encrypted", value);
    }

    /// <summary>
    /// The enhanced_vpc_routing attribute.
    /// </summary>
    public TerraformValue<bool> EnhancedVpcRouting
    {
        get => GetArgument<TerraformValue<bool>>("enhanced_vpc_routing") ?? CreateReference("enhanced_vpc_routing");
        set => SetArgument("enhanced_vpc_routing", value);
    }

    /// <summary>
    /// The final_snapshot_identifier attribute.
    /// </summary>
    public TerraformValue<string>? FinalSnapshotIdentifier
    {
        get => GetArgument<TerraformValue<string>>("final_snapshot_identifier");
        set => SetArgument("final_snapshot_identifier", value);
    }

    /// <summary>
    /// The iam_roles attribute.
    /// </summary>
    public TerraformSet<string> IamRoles
    {
        get => GetArgument<TerraformSet<string>>("iam_roles") ?? CreateReference("iam_roles");
        set => SetArgument("iam_roles", value);
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
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string> KmsKeyId
    {
        get => GetArgument<TerraformValue<string>>("kms_key_id") ?? CreateReference("kms_key_id");
        set => SetArgument("kms_key_id", value);
    }

    /// <summary>
    /// The maintenance_track_name attribute.
    /// </summary>
    public TerraformValue<string>? MaintenanceTrackName
    {
        get => GetArgument<TerraformValue<string>>("maintenance_track_name");
        set => SetArgument("maintenance_track_name", value);
    }

    /// <summary>
    /// The manage_master_password attribute.
    /// </summary>
    public TerraformValue<bool>? ManageMasterPassword
    {
        get => GetArgument<TerraformValue<bool>>("manage_master_password");
        set => SetArgument("manage_master_password", value);
    }

    /// <summary>
    /// The manual_snapshot_retention_period attribute.
    /// </summary>
    public TerraformValue<double>? ManualSnapshotRetentionPeriod
    {
        get => GetArgument<TerraformValue<double>>("manual_snapshot_retention_period");
        set => SetArgument("manual_snapshot_retention_period", value);
    }

    /// <summary>
    /// The master_password attribute.
    /// </summary>
    public TerraformValue<string>? MasterPassword
    {
        get => GetArgument<TerraformValue<string>>("master_password");
        set => SetArgument("master_password", value);
    }

    /// <summary>
    /// The master_password_secret_kms_key_id attribute.
    /// </summary>
    public TerraformValue<string> MasterPasswordSecretKmsKeyId
    {
        get => GetArgument<TerraformValue<string>>("master_password_secret_kms_key_id") ?? CreateReference("master_password_secret_kms_key_id");
        set => SetArgument("master_password_secret_kms_key_id", value);
    }

    /// <summary>
    /// The master_password_wo attribute.
    /// </summary>
    public TerraformValue<string>? MasterPasswordWo
    {
        get => GetArgument<TerraformValue<string>>("master_password_wo");
        set => SetArgument("master_password_wo", value);
    }

    /// <summary>
    /// The master_password_wo_version attribute.
    /// </summary>
    public TerraformValue<double>? MasterPasswordWoVersion
    {
        get => GetArgument<TerraformValue<double>>("master_password_wo_version");
        set => SetArgument("master_password_wo_version", value);
    }

    /// <summary>
    /// The master_username attribute.
    /// </summary>
    public TerraformValue<string>? MasterUsername
    {
        get => GetArgument<TerraformValue<string>>("master_username");
        set => SetArgument("master_username", value);
    }

    /// <summary>
    /// The multi_az attribute.
    /// </summary>
    public TerraformValue<bool>? MultiAz
    {
        get => GetArgument<TerraformValue<bool>>("multi_az");
        set => SetArgument("multi_az", value);
    }

    /// <summary>
    /// The node_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeType is required")]
    public required TerraformValue<string> NodeType
    {
        get => GetRequiredArgument<TerraformValue<string>>("node_type");
        set => SetArgument("node_type", value);
    }

    /// <summary>
    /// The number_of_nodes attribute.
    /// </summary>
    public TerraformValue<double>? NumberOfNodes
    {
        get => GetArgument<TerraformValue<double>>("number_of_nodes");
        set => SetArgument("number_of_nodes", value);
    }

    /// <summary>
    /// The owner_account attribute.
    /// </summary>
    public TerraformValue<string>? OwnerAccount
    {
        get => GetArgument<TerraformValue<string>>("owner_account");
        set => SetArgument("owner_account", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double>? Port
    {
        get => GetArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The preferred_maintenance_window attribute.
    /// </summary>
    public TerraformValue<string> PreferredMaintenanceWindow
    {
        get => GetArgument<TerraformValue<string>>("preferred_maintenance_window") ?? CreateReference("preferred_maintenance_window");
        set => SetArgument("preferred_maintenance_window", value);
    }

    /// <summary>
    /// The publicly_accessible attribute.
    /// </summary>
    public TerraformValue<bool>? PubliclyAccessible
    {
        get => GetArgument<TerraformValue<bool>>("publicly_accessible");
        set => SetArgument("publicly_accessible", value);
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
    /// The skip_final_snapshot attribute.
    /// </summary>
    public TerraformValue<bool>? SkipFinalSnapshot
    {
        get => GetArgument<TerraformValue<bool>>("skip_final_snapshot");
        set => SetArgument("skip_final_snapshot", value);
    }

    /// <summary>
    /// The snapshot_arn attribute.
    /// </summary>
    public TerraformValue<string>? SnapshotArn
    {
        get => GetArgument<TerraformValue<string>>("snapshot_arn");
        set => SetArgument("snapshot_arn", value);
    }

    /// <summary>
    /// The snapshot_cluster_identifier attribute.
    /// </summary>
    public TerraformValue<string>? SnapshotClusterIdentifier
    {
        get => GetArgument<TerraformValue<string>>("snapshot_cluster_identifier");
        set => SetArgument("snapshot_cluster_identifier", value);
    }

    /// <summary>
    /// The snapshot_identifier attribute.
    /// </summary>
    public TerraformValue<string>? SnapshotIdentifier
    {
        get => GetArgument<TerraformValue<string>>("snapshot_identifier");
        set => SetArgument("snapshot_identifier", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? CreateReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    public TerraformSet<string> VpcSecurityGroupIds
    {
        get => GetArgument<TerraformSet<string>>("vpc_security_group_ids") ?? CreateReference("vpc_security_group_ids");
        set => SetArgument("vpc_security_group_ids", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

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
    /// The dns_name attribute.
    /// </summary>
    public TerraformValue<string> DnsName
        => CreateReference("dns_name");

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformValue<string> Endpoint
        => CreateReference("endpoint");

    /// <summary>
    /// The master_password_secret_arn attribute.
    /// </summary>
    public TerraformValue<string> MasterPasswordSecretArn
        => CreateReference("master_password_secret_arn");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsRedshiftClusterTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsRedshiftClusterTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
