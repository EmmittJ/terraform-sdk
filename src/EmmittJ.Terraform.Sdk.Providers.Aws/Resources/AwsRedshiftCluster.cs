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
        this.DeclareOutput("cluster_public_key");
        this.DeclareOutput("cluster_revision_number");
        this.DeclareOutput("dns_name");
        this.DeclareOutput("endpoint");
        this.DeclareOutput("master_password_secret_arn");
    }

    /// <summary>
    /// The allow_version_upgrade attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? AllowVersionUpgrade
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("allow_version_upgrade");
        set => this.WithProperty("allow_version_upgrade", value);
    }

    /// <summary>
    /// The apply_immediately attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? ApplyImmediately
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("apply_immediately");
        set => this.WithProperty("apply_immediately", value);
    }

    /// <summary>
    /// The aqua_configuration_status attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformLiteralProperty<string>? AquaConfigurationStatus
    {
        get => GetProperty<TerraformLiteralProperty<string>>("aqua_configuration_status");
        set => this.WithProperty("aqua_configuration_status", value);
    }

    /// <summary>
    /// The automated_snapshot_retention_period attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? AutomatedSnapshotRetentionPeriod
    {
        get => GetProperty<TerraformLiteralProperty<double>>("automated_snapshot_retention_period");
        set => this.WithProperty("automated_snapshot_retention_period", value);
    }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AvailabilityZone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("availability_zone");
        set => this.WithProperty("availability_zone", value);
    }

    /// <summary>
    /// The availability_zone_relocation_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? AvailabilityZoneRelocationEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("availability_zone_relocation_enabled");
        set => this.WithProperty("availability_zone_relocation_enabled", value);
    }

    /// <summary>
    /// The cluster_identifier attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ClusterIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cluster_identifier");
        set => this.WithProperty("cluster_identifier", value);
    }

    /// <summary>
    /// The cluster_parameter_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ClusterParameterGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cluster_parameter_group_name");
        set => this.WithProperty("cluster_parameter_group_name", value);
    }

    /// <summary>
    /// The cluster_subnet_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ClusterSubnetGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cluster_subnet_group_name");
        set => this.WithProperty("cluster_subnet_group_name", value);
    }

    /// <summary>
    /// The cluster_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ClusterType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cluster_type");
        set => this.WithProperty("cluster_type", value);
    }

    /// <summary>
    /// The cluster_version attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ClusterVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cluster_version");
        set => this.WithProperty("cluster_version", value);
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DatabaseName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("database_name");
        set => this.WithProperty("database_name", value);
    }

    /// <summary>
    /// The default_iam_role_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DefaultIamRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("default_iam_role_arn");
        set => this.WithProperty("default_iam_role_arn", value);
    }

    /// <summary>
    /// The elastic_ip attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ElasticIp
    {
        get => GetProperty<TerraformLiteralProperty<string>>("elastic_ip");
        set => this.WithProperty("elastic_ip", value);
    }

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Encrypted
    {
        get => GetProperty<TerraformLiteralProperty<string>>("encrypted");
        set => this.WithProperty("encrypted", value);
    }

    /// <summary>
    /// The enhanced_vpc_routing attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? EnhancedVpcRouting
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enhanced_vpc_routing");
        set => this.WithProperty("enhanced_vpc_routing", value);
    }

    /// <summary>
    /// The final_snapshot_identifier attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? FinalSnapshotIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("final_snapshot_identifier");
        set => this.WithProperty("final_snapshot_identifier", value);
    }

    /// <summary>
    /// The iam_roles attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? IamRoles
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("iam_roles");
        set => this.WithProperty("iam_roles", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? KmsKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kms_key_id");
        set => this.WithProperty("kms_key_id", value);
    }

    /// <summary>
    /// The maintenance_track_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? MaintenanceTrackName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("maintenance_track_name");
        set => this.WithProperty("maintenance_track_name", value);
    }

    /// <summary>
    /// The manage_master_password attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? ManageMasterPassword
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("manage_master_password");
        set => this.WithProperty("manage_master_password", value);
    }

    /// <summary>
    /// The manual_snapshot_retention_period attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? ManualSnapshotRetentionPeriod
    {
        get => GetProperty<TerraformLiteralProperty<double>>("manual_snapshot_retention_period");
        set => this.WithProperty("manual_snapshot_retention_period", value);
    }

    /// <summary>
    /// The master_password attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? MasterPassword
    {
        get => GetProperty<TerraformLiteralProperty<string>>("master_password");
        set => this.WithProperty("master_password", value);
    }

    /// <summary>
    /// The master_password_secret_kms_key_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? MasterPasswordSecretKmsKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("master_password_secret_kms_key_id");
        set => this.WithProperty("master_password_secret_kms_key_id", value);
    }

    /// <summary>
    /// The master_password_wo attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? MasterPasswordWo
    {
        get => GetProperty<TerraformLiteralProperty<string>>("master_password_wo");
        set => this.WithProperty("master_password_wo", value);
    }

    /// <summary>
    /// The master_password_wo_version attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? MasterPasswordWoVersion
    {
        get => GetProperty<TerraformLiteralProperty<double>>("master_password_wo_version");
        set => this.WithProperty("master_password_wo_version", value);
    }

    /// <summary>
    /// The master_username attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? MasterUsername
    {
        get => GetProperty<TerraformLiteralProperty<string>>("master_username");
        set => this.WithProperty("master_username", value);
    }

    /// <summary>
    /// The multi_az attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? MultiAz
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("multi_az");
        set => this.WithProperty("multi_az", value);
    }

    /// <summary>
    /// The node_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? NodeType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("node_type");
        set => this.WithProperty("node_type", value);
    }

    /// <summary>
    /// The number_of_nodes attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? NumberOfNodes
    {
        get => GetProperty<TerraformLiteralProperty<double>>("number_of_nodes");
        set => this.WithProperty("number_of_nodes", value);
    }

    /// <summary>
    /// The owner_account attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? OwnerAccount
    {
        get => GetProperty<TerraformLiteralProperty<string>>("owner_account");
        set => this.WithProperty("owner_account", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? Port
    {
        get => GetProperty<TerraformLiteralProperty<double>>("port");
        set => this.WithProperty("port", value);
    }

    /// <summary>
    /// The preferred_maintenance_window attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PreferredMaintenanceWindow
    {
        get => GetProperty<TerraformLiteralProperty<string>>("preferred_maintenance_window");
        set => this.WithProperty("preferred_maintenance_window", value);
    }

    /// <summary>
    /// The publicly_accessible attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? PubliclyAccessible
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("publicly_accessible");
        set => this.WithProperty("publicly_accessible", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The skip_final_snapshot attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? SkipFinalSnapshot
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("skip_final_snapshot");
        set => this.WithProperty("skip_final_snapshot", value);
    }

    /// <summary>
    /// The snapshot_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SnapshotArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("snapshot_arn");
        set => this.WithProperty("snapshot_arn", value);
    }

    /// <summary>
    /// The snapshot_cluster_identifier attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SnapshotClusterIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("snapshot_cluster_identifier");
        set => this.WithProperty("snapshot_cluster_identifier", value);
    }

    /// <summary>
    /// The snapshot_identifier attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SnapshotIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("snapshot_identifier");
        set => this.WithProperty("snapshot_identifier", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? VpcSecurityGroupIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("vpc_security_group_ids");
        set => this.WithProperty("vpc_security_group_ids", value);
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
    /// The cluster_public_key attribute.
    /// </summary>
    public TerraformExpression ClusterPublicKey => this["cluster_public_key"];

    /// <summary>
    /// The cluster_revision_number attribute.
    /// </summary>
    public TerraformExpression ClusterRevisionNumber => this["cluster_revision_number"];

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    public TerraformExpression DnsName => this["dns_name"];

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformExpression Endpoint => this["endpoint"];

    /// <summary>
    /// The master_password_secret_arn attribute.
    /// </summary>
    public TerraformExpression MasterPasswordSecretArn => this["master_password_secret_arn"];

}
