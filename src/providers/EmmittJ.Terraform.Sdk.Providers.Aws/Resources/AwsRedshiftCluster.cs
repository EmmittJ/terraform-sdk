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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
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
        get => new TerraformReference<bool>(this, "allow_version_upgrade");
        set => SetArgument("allow_version_upgrade", value);
    }

    /// <summary>
    /// The apply_immediately attribute.
    /// </summary>
    public TerraformValue<bool>? ApplyImmediately
    {
        get => new TerraformReference<bool>(this, "apply_immediately");
        set => SetArgument("apply_immediately", value);
    }

    /// <summary>
    /// The aqua_configuration_status attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> AquaConfigurationStatus
    {
        get => new TerraformReference<string>(this, "aqua_configuration_status");
        set => SetArgument("aqua_configuration_status", value);
    }

    /// <summary>
    /// The automated_snapshot_retention_period attribute.
    /// </summary>
    public TerraformValue<double>? AutomatedSnapshotRetentionPeriod
    {
        get => new TerraformReference<double>(this, "automated_snapshot_retention_period");
        set => SetArgument("automated_snapshot_retention_period", value);
    }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformValue<string> AvailabilityZone
    {
        get => new TerraformReference<string>(this, "availability_zone");
        set => SetArgument("availability_zone", value);
    }

    /// <summary>
    /// The availability_zone_relocation_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? AvailabilityZoneRelocationEnabled
    {
        get => new TerraformReference<bool>(this, "availability_zone_relocation_enabled");
        set => SetArgument("availability_zone_relocation_enabled", value);
    }

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
    /// The cluster_parameter_group_name attribute.
    /// </summary>
    public TerraformValue<string> ClusterParameterGroupName
    {
        get => new TerraformReference<string>(this, "cluster_parameter_group_name");
        set => SetArgument("cluster_parameter_group_name", value);
    }

    /// <summary>
    /// The cluster_subnet_group_name attribute.
    /// </summary>
    public TerraformValue<string> ClusterSubnetGroupName
    {
        get => new TerraformReference<string>(this, "cluster_subnet_group_name");
        set => SetArgument("cluster_subnet_group_name", value);
    }

    /// <summary>
    /// The cluster_type attribute.
    /// </summary>
    public TerraformValue<string> ClusterType
    {
        get => new TerraformReference<string>(this, "cluster_type");
        set => SetArgument("cluster_type", value);
    }

    /// <summary>
    /// The cluster_version attribute.
    /// </summary>
    public TerraformValue<string>? ClusterVersion
    {
        get => new TerraformReference<string>(this, "cluster_version");
        set => SetArgument("cluster_version", value);
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    public TerraformValue<string> DatabaseName
    {
        get => new TerraformReference<string>(this, "database_name");
        set => SetArgument("database_name", value);
    }

    /// <summary>
    /// The default_iam_role_arn attribute.
    /// </summary>
    public TerraformValue<string> DefaultIamRoleArn
    {
        get => new TerraformReference<string>(this, "default_iam_role_arn");
        set => SetArgument("default_iam_role_arn", value);
    }

    /// <summary>
    /// The elastic_ip attribute.
    /// </summary>
    public TerraformValue<string>? ElasticIp
    {
        get => new TerraformReference<string>(this, "elastic_ip");
        set => SetArgument("elastic_ip", value);
    }

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    public TerraformValue<string>? Encrypted
    {
        get => new TerraformReference<string>(this, "encrypted");
        set => SetArgument("encrypted", value);
    }

    /// <summary>
    /// The enhanced_vpc_routing attribute.
    /// </summary>
    public TerraformValue<bool> EnhancedVpcRouting
    {
        get => new TerraformReference<bool>(this, "enhanced_vpc_routing");
        set => SetArgument("enhanced_vpc_routing", value);
    }

    /// <summary>
    /// The final_snapshot_identifier attribute.
    /// </summary>
    public TerraformValue<string>? FinalSnapshotIdentifier
    {
        get => new TerraformReference<string>(this, "final_snapshot_identifier");
        set => SetArgument("final_snapshot_identifier", value);
    }

    /// <summary>
    /// The iam_roles attribute.
    /// </summary>
    public TerraformSet<string> IamRoles
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "iam_roles").ResolveNodes(ctx));
        set => SetArgument("iam_roles", value);
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
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string> KmsKeyId
    {
        get => new TerraformReference<string>(this, "kms_key_id");
        set => SetArgument("kms_key_id", value);
    }

    /// <summary>
    /// The maintenance_track_name attribute.
    /// </summary>
    public TerraformValue<string>? MaintenanceTrackName
    {
        get => new TerraformReference<string>(this, "maintenance_track_name");
        set => SetArgument("maintenance_track_name", value);
    }

    /// <summary>
    /// The manage_master_password attribute.
    /// </summary>
    public TerraformValue<bool>? ManageMasterPassword
    {
        get => new TerraformReference<bool>(this, "manage_master_password");
        set => SetArgument("manage_master_password", value);
    }

    /// <summary>
    /// The manual_snapshot_retention_period attribute.
    /// </summary>
    public TerraformValue<double>? ManualSnapshotRetentionPeriod
    {
        get => new TerraformReference<double>(this, "manual_snapshot_retention_period");
        set => SetArgument("manual_snapshot_retention_period", value);
    }

    /// <summary>
    /// The master_password attribute.
    /// </summary>
    public TerraformValue<string>? MasterPassword
    {
        get => new TerraformReference<string>(this, "master_password");
        set => SetArgument("master_password", value);
    }

    /// <summary>
    /// The master_password_secret_kms_key_id attribute.
    /// </summary>
    public TerraformValue<string> MasterPasswordSecretKmsKeyId
    {
        get => new TerraformReference<string>(this, "master_password_secret_kms_key_id");
        set => SetArgument("master_password_secret_kms_key_id", value);
    }

    /// <summary>
    /// The master_password_wo attribute.
    /// </summary>
    public TerraformValue<string>? MasterPasswordWo
    {
        get => new TerraformReference<string>(this, "master_password_wo");
        set => SetArgument("master_password_wo", value);
    }

    /// <summary>
    /// The master_password_wo_version attribute.
    /// </summary>
    public TerraformValue<double>? MasterPasswordWoVersion
    {
        get => new TerraformReference<double>(this, "master_password_wo_version");
        set => SetArgument("master_password_wo_version", value);
    }

    /// <summary>
    /// The master_username attribute.
    /// </summary>
    public TerraformValue<string>? MasterUsername
    {
        get => new TerraformReference<string>(this, "master_username");
        set => SetArgument("master_username", value);
    }

    /// <summary>
    /// The multi_az attribute.
    /// </summary>
    public TerraformValue<bool>? MultiAz
    {
        get => new TerraformReference<bool>(this, "multi_az");
        set => SetArgument("multi_az", value);
    }

    /// <summary>
    /// The node_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeType is required")]
    public required TerraformValue<string> NodeType
    {
        get => new TerraformReference<string>(this, "node_type");
        set => SetArgument("node_type", value);
    }

    /// <summary>
    /// The number_of_nodes attribute.
    /// </summary>
    public TerraformValue<double>? NumberOfNodes
    {
        get => new TerraformReference<double>(this, "number_of_nodes");
        set => SetArgument("number_of_nodes", value);
    }

    /// <summary>
    /// The owner_account attribute.
    /// </summary>
    public TerraformValue<string>? OwnerAccount
    {
        get => new TerraformReference<string>(this, "owner_account");
        set => SetArgument("owner_account", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double>? Port
    {
        get => new TerraformReference<double>(this, "port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The preferred_maintenance_window attribute.
    /// </summary>
    public TerraformValue<string> PreferredMaintenanceWindow
    {
        get => new TerraformReference<string>(this, "preferred_maintenance_window");
        set => SetArgument("preferred_maintenance_window", value);
    }

    /// <summary>
    /// The publicly_accessible attribute.
    /// </summary>
    public TerraformValue<bool>? PubliclyAccessible
    {
        get => new TerraformReference<bool>(this, "publicly_accessible");
        set => SetArgument("publicly_accessible", value);
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
    /// The skip_final_snapshot attribute.
    /// </summary>
    public TerraformValue<bool>? SkipFinalSnapshot
    {
        get => new TerraformReference<bool>(this, "skip_final_snapshot");
        set => SetArgument("skip_final_snapshot", value);
    }

    /// <summary>
    /// The snapshot_arn attribute.
    /// </summary>
    public TerraformValue<string>? SnapshotArn
    {
        get => new TerraformReference<string>(this, "snapshot_arn");
        set => SetArgument("snapshot_arn", value);
    }

    /// <summary>
    /// The snapshot_cluster_identifier attribute.
    /// </summary>
    public TerraformValue<string>? SnapshotClusterIdentifier
    {
        get => new TerraformReference<string>(this, "snapshot_cluster_identifier");
        set => SetArgument("snapshot_cluster_identifier", value);
    }

    /// <summary>
    /// The snapshot_identifier attribute.
    /// </summary>
    public TerraformValue<string>? SnapshotIdentifier
    {
        get => new TerraformReference<string>(this, "snapshot_identifier");
        set => SetArgument("snapshot_identifier", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    public TerraformSet<string> VpcSecurityGroupIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "vpc_security_group_ids").ResolveNodes(ctx));
        set => SetArgument("vpc_security_group_ids", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
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
    /// The dns_name attribute.
    /// </summary>
    public TerraformValue<string> DnsName
    {
        get => new TerraformReference<string>(this, "dns_name");
    }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformValue<string> Endpoint
    {
        get => new TerraformReference<string>(this, "endpoint");
    }

    /// <summary>
    /// The master_password_secret_arn attribute.
    /// </summary>
    public TerraformValue<string> MasterPasswordSecretArn
    {
        get => new TerraformReference<string>(this, "master_password_secret_arn");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsRedshiftClusterTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsRedshiftClusterTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
