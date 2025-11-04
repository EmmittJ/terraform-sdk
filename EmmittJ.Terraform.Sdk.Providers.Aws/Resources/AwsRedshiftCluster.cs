using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_redshift_cluster resource.
/// </summary>
public class AwsRedshiftCluster : TerraformResource
{
    public AwsRedshiftCluster(string name) : base("aws_redshift_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("cluster_namespace_arn");
        this.DeclareOutput("cluster_nodes");
        this.DeclareOutput("dns_name");
        this.DeclareOutput("master_password_secret_arn");
    }

    /// <summary>
    /// The allow_version_upgrade attribute.
    /// </summary>
    public bool? AllowVersionUpgrade
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("allow_version_upgrade")?.Value;
        set => this.WithProperty("allow_version_upgrade", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The apply_immediately attribute.
    /// </summary>
    public bool? ApplyImmediately
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("apply_immediately")?.Value;
        set => this.WithProperty("apply_immediately", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The aqua_configuration_status attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public string? AquaConfigurationStatus
    {
        get => GetProperty<TerraformLiteralProperty<string>>("aqua_configuration_status")?.Value;
        set => this.WithProperty("aqua_configuration_status", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The automated_snapshot_retention_period attribute.
    /// </summary>
    public double? AutomatedSnapshotRetentionPeriod
    {
        get => GetProperty<TerraformLiteralProperty<double>>("automated_snapshot_retention_period")?.Value;
        set => this.WithProperty("automated_snapshot_retention_period", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public string? AvailabilityZone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("availability_zone")?.Value;
        set => this.WithProperty("availability_zone", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The availability_zone_relocation_enabled attribute.
    /// </summary>
    public bool? AvailabilityZoneRelocationEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("availability_zone_relocation_enabled")?.Value;
        set => this.WithProperty("availability_zone_relocation_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The cluster_identifier attribute.
    /// </summary>
    public string? ClusterIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cluster_identifier")?.Value;
        set => this.WithProperty("cluster_identifier", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The cluster_parameter_group_name attribute.
    /// </summary>
    public string? ClusterParameterGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cluster_parameter_group_name")?.Value;
        set => this.WithProperty("cluster_parameter_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The cluster_public_key attribute.
    /// </summary>
    public string? ClusterPublicKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cluster_public_key")?.Value;
        set => this.WithProperty("cluster_public_key", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The cluster_revision_number attribute.
    /// </summary>
    public string? ClusterRevisionNumber
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cluster_revision_number")?.Value;
        set => this.WithProperty("cluster_revision_number", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The cluster_subnet_group_name attribute.
    /// </summary>
    public string? ClusterSubnetGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cluster_subnet_group_name")?.Value;
        set => this.WithProperty("cluster_subnet_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The cluster_type attribute.
    /// </summary>
    public string? ClusterType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cluster_type")?.Value;
        set => this.WithProperty("cluster_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The cluster_version attribute.
    /// </summary>
    public string? ClusterVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cluster_version")?.Value;
        set => this.WithProperty("cluster_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    public string? DatabaseName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("database_name")?.Value;
        set => this.WithProperty("database_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The default_iam_role_arn attribute.
    /// </summary>
    public string? DefaultIamRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("default_iam_role_arn")?.Value;
        set => this.WithProperty("default_iam_role_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The elastic_ip attribute.
    /// </summary>
    public string? ElasticIp
    {
        get => GetProperty<TerraformLiteralProperty<string>>("elastic_ip")?.Value;
        set => this.WithProperty("elastic_ip", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    public bool? Encrypted
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("encrypted")?.Value;
        set => this.WithProperty("encrypted", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public string? Endpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("endpoint")?.Value;
        set => this.WithProperty("endpoint", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The enhanced_vpc_routing attribute.
    /// </summary>
    public bool? EnhancedVpcRouting
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enhanced_vpc_routing")?.Value;
        set => this.WithProperty("enhanced_vpc_routing", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The final_snapshot_identifier attribute.
    /// </summary>
    public string? FinalSnapshotIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("final_snapshot_identifier")?.Value;
        set => this.WithProperty("final_snapshot_identifier", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The iam_roles attribute.
    /// </summary>
    public HashSet<string>? IamRoles
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("iam_roles")?.Value;
        set => this.WithProperty("iam_roles", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public string? KmsKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kms_key_id")?.Value;
        set => this.WithProperty("kms_key_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The maintenance_track_name attribute.
    /// </summary>
    public string? MaintenanceTrackName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("maintenance_track_name")?.Value;
        set => this.WithProperty("maintenance_track_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The manage_master_password attribute.
    /// </summary>
    public bool? ManageMasterPassword
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("manage_master_password")?.Value;
        set => this.WithProperty("manage_master_password", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The manual_snapshot_retention_period attribute.
    /// </summary>
    public double? ManualSnapshotRetentionPeriod
    {
        get => GetProperty<TerraformLiteralProperty<double>>("manual_snapshot_retention_period")?.Value;
        set => this.WithProperty("manual_snapshot_retention_period", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The master_password attribute.
    /// </summary>
    public string? MasterPassword
    {
        get => GetProperty<TerraformLiteralProperty<string>>("master_password")?.Value;
        set => this.WithProperty("master_password", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The master_password_secret_kms_key_id attribute.
    /// </summary>
    public string? MasterPasswordSecretKmsKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("master_password_secret_kms_key_id")?.Value;
        set => this.WithProperty("master_password_secret_kms_key_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The master_password_wo attribute.
    /// </summary>
    public string? MasterPasswordWo
    {
        get => GetProperty<TerraformLiteralProperty<string>>("master_password_wo")?.Value;
        set => this.WithProperty("master_password_wo", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The master_password_wo_version attribute.
    /// </summary>
    public double? MasterPasswordWoVersion
    {
        get => GetProperty<TerraformLiteralProperty<double>>("master_password_wo_version")?.Value;
        set => this.WithProperty("master_password_wo_version", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The master_username attribute.
    /// </summary>
    public string? MasterUsername
    {
        get => GetProperty<TerraformLiteralProperty<string>>("master_username")?.Value;
        set => this.WithProperty("master_username", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The multi_az attribute.
    /// </summary>
    public bool? MultiAz
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("multi_az")?.Value;
        set => this.WithProperty("multi_az", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The node_type attribute.
    /// </summary>
    public string? NodeType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("node_type")?.Value;
        set => this.WithProperty("node_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The number_of_nodes attribute.
    /// </summary>
    public double? NumberOfNodes
    {
        get => GetProperty<TerraformLiteralProperty<double>>("number_of_nodes")?.Value;
        set => this.WithProperty("number_of_nodes", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The owner_account attribute.
    /// </summary>
    public string? OwnerAccount
    {
        get => GetProperty<TerraformLiteralProperty<string>>("owner_account")?.Value;
        set => this.WithProperty("owner_account", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public double? Port
    {
        get => GetProperty<TerraformLiteralProperty<double>>("port")?.Value;
        set => this.WithProperty("port", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The preferred_maintenance_window attribute.
    /// </summary>
    public string? PreferredMaintenanceWindow
    {
        get => GetProperty<TerraformLiteralProperty<string>>("preferred_maintenance_window")?.Value;
        set => this.WithProperty("preferred_maintenance_window", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The publicly_accessible attribute.
    /// </summary>
    public bool? PubliclyAccessible
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("publicly_accessible")?.Value;
        set => this.WithProperty("publicly_accessible", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The skip_final_snapshot attribute.
    /// </summary>
    public bool? SkipFinalSnapshot
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("skip_final_snapshot")?.Value;
        set => this.WithProperty("skip_final_snapshot", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The snapshot_arn attribute.
    /// </summary>
    public string? SnapshotArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("snapshot_arn")?.Value;
        set => this.WithProperty("snapshot_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The snapshot_cluster_identifier attribute.
    /// </summary>
    public string? SnapshotClusterIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("snapshot_cluster_identifier")?.Value;
        set => this.WithProperty("snapshot_cluster_identifier", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The snapshot_identifier attribute.
    /// </summary>
    public string? SnapshotIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("snapshot_identifier")?.Value;
        set => this.WithProperty("snapshot_identifier", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    public HashSet<string>? VpcSecurityGroupIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("vpc_security_group_ids")?.Value;
        set => this.WithProperty("vpc_security_group_ids", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The cluster_namespace_arn attribute.
    /// </summary>
    public TerraformExpression ClusterNamespaceArn => this["cluster_namespace_arn"];

    /// <summary>
    /// The cluster_nodes attribute.
    /// </summary>
    public TerraformExpression ClusterNodes => this["cluster_nodes"];

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    public TerraformExpression DnsName => this["dns_name"];

    /// <summary>
    /// The master_password_secret_arn attribute.
    /// </summary>
    public TerraformExpression MasterPasswordSecretArn => this["master_password_secret_arn"];

}
