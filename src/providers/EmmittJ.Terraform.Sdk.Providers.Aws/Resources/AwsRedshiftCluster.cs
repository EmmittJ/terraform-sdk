using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsRedshiftClusterTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

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
        this.WithOutput("arn");
        this.WithOutput("cluster_namespace_arn");
        this.WithOutput("cluster_nodes");
        this.WithOutput("cluster_public_key");
        this.WithOutput("cluster_revision_number");
        this.WithOutput("dns_name");
        this.WithOutput("endpoint");
        this.WithOutput("master_password_secret_arn");
    }

    /// <summary>
    /// The allow_version_upgrade attribute.
    /// </summary>
    public TerraformProperty<bool>? AllowVersionUpgrade
    {
        get => GetProperty<TerraformProperty<bool>>("allow_version_upgrade");
        set => this.WithProperty("allow_version_upgrade", value);
    }

    /// <summary>
    /// The apply_immediately attribute.
    /// </summary>
    public TerraformProperty<bool>? ApplyImmediately
    {
        get => GetProperty<TerraformProperty<bool>>("apply_immediately");
        set => this.WithProperty("apply_immediately", value);
    }

    /// <summary>
    /// The aqua_configuration_status attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<string>? AquaConfigurationStatus
    {
        get => GetProperty<TerraformProperty<string>>("aqua_configuration_status");
        set => this.WithProperty("aqua_configuration_status", value);
    }

    /// <summary>
    /// The automated_snapshot_retention_period attribute.
    /// </summary>
    public TerraformProperty<double>? AutomatedSnapshotRetentionPeriod
    {
        get => GetProperty<TerraformProperty<double>>("automated_snapshot_retention_period");
        set => this.WithProperty("automated_snapshot_retention_period", value);
    }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformProperty<string>? AvailabilityZone
    {
        get => GetProperty<TerraformProperty<string>>("availability_zone");
        set => this.WithProperty("availability_zone", value);
    }

    /// <summary>
    /// The availability_zone_relocation_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? AvailabilityZoneRelocationEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("availability_zone_relocation_enabled");
        set => this.WithProperty("availability_zone_relocation_enabled", value);
    }

    /// <summary>
    /// The cluster_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterIdentifier is required")]
    public required TerraformProperty<string> ClusterIdentifier
    {
        get => GetRequiredProperty<TerraformProperty<string>>("cluster_identifier");
        set => this.WithProperty("cluster_identifier", value);
    }

    /// <summary>
    /// The cluster_parameter_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ClusterParameterGroupName
    {
        get => GetProperty<TerraformProperty<string>>("cluster_parameter_group_name");
        set => this.WithProperty("cluster_parameter_group_name", value);
    }

    /// <summary>
    /// The cluster_subnet_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ClusterSubnetGroupName
    {
        get => GetProperty<TerraformProperty<string>>("cluster_subnet_group_name");
        set => this.WithProperty("cluster_subnet_group_name", value);
    }

    /// <summary>
    /// The cluster_type attribute.
    /// </summary>
    public TerraformProperty<string>? ClusterType
    {
        get => GetProperty<TerraformProperty<string>>("cluster_type");
        set => this.WithProperty("cluster_type", value);
    }

    /// <summary>
    /// The cluster_version attribute.
    /// </summary>
    public TerraformProperty<string>? ClusterVersion
    {
        get => GetProperty<TerraformProperty<string>>("cluster_version");
        set => this.WithProperty("cluster_version", value);
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    public TerraformProperty<string>? DatabaseName
    {
        get => GetProperty<TerraformProperty<string>>("database_name");
        set => this.WithProperty("database_name", value);
    }

    /// <summary>
    /// The default_iam_role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? DefaultIamRoleArn
    {
        get => GetProperty<TerraformProperty<string>>("default_iam_role_arn");
        set => this.WithProperty("default_iam_role_arn", value);
    }

    /// <summary>
    /// The elastic_ip attribute.
    /// </summary>
    public TerraformProperty<string>? ElasticIp
    {
        get => GetProperty<TerraformProperty<string>>("elastic_ip");
        set => this.WithProperty("elastic_ip", value);
    }

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    public TerraformProperty<string>? Encrypted
    {
        get => GetProperty<TerraformProperty<string>>("encrypted");
        set => this.WithProperty("encrypted", value);
    }

    /// <summary>
    /// The enhanced_vpc_routing attribute.
    /// </summary>
    public TerraformProperty<bool>? EnhancedVpcRouting
    {
        get => GetProperty<TerraformProperty<bool>>("enhanced_vpc_routing");
        set => this.WithProperty("enhanced_vpc_routing", value);
    }

    /// <summary>
    /// The final_snapshot_identifier attribute.
    /// </summary>
    public TerraformProperty<string>? FinalSnapshotIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("final_snapshot_identifier");
        set => this.WithProperty("final_snapshot_identifier", value);
    }

    /// <summary>
    /// The iam_roles attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? IamRoles
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("iam_roles");
        set => this.WithProperty("iam_roles", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyId
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_id");
        set => this.WithProperty("kms_key_id", value);
    }

    /// <summary>
    /// The maintenance_track_name attribute.
    /// </summary>
    public TerraformProperty<string>? MaintenanceTrackName
    {
        get => GetProperty<TerraformProperty<string>>("maintenance_track_name");
        set => this.WithProperty("maintenance_track_name", value);
    }

    /// <summary>
    /// The manage_master_password attribute.
    /// </summary>
    public TerraformProperty<bool>? ManageMasterPassword
    {
        get => GetProperty<TerraformProperty<bool>>("manage_master_password");
        set => this.WithProperty("manage_master_password", value);
    }

    /// <summary>
    /// The manual_snapshot_retention_period attribute.
    /// </summary>
    public TerraformProperty<double>? ManualSnapshotRetentionPeriod
    {
        get => GetProperty<TerraformProperty<double>>("manual_snapshot_retention_period");
        set => this.WithProperty("manual_snapshot_retention_period", value);
    }

    /// <summary>
    /// The master_password attribute.
    /// </summary>
    public TerraformProperty<string>? MasterPassword
    {
        get => GetProperty<TerraformProperty<string>>("master_password");
        set => this.WithProperty("master_password", value);
    }

    /// <summary>
    /// The master_password_secret_kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? MasterPasswordSecretKmsKeyId
    {
        get => GetProperty<TerraformProperty<string>>("master_password_secret_kms_key_id");
        set => this.WithProperty("master_password_secret_kms_key_id", value);
    }

    /// <summary>
    /// The master_password_wo attribute.
    /// </summary>
    public TerraformProperty<string>? MasterPasswordWo
    {
        get => GetProperty<TerraformProperty<string>>("master_password_wo");
        set => this.WithProperty("master_password_wo", value);
    }

    /// <summary>
    /// The master_password_wo_version attribute.
    /// </summary>
    public TerraformProperty<double>? MasterPasswordWoVersion
    {
        get => GetProperty<TerraformProperty<double>>("master_password_wo_version");
        set => this.WithProperty("master_password_wo_version", value);
    }

    /// <summary>
    /// The master_username attribute.
    /// </summary>
    public TerraformProperty<string>? MasterUsername
    {
        get => GetProperty<TerraformProperty<string>>("master_username");
        set => this.WithProperty("master_username", value);
    }

    /// <summary>
    /// The multi_az attribute.
    /// </summary>
    public TerraformProperty<bool>? MultiAz
    {
        get => GetProperty<TerraformProperty<bool>>("multi_az");
        set => this.WithProperty("multi_az", value);
    }

    /// <summary>
    /// The node_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeType is required")]
    public required TerraformProperty<string> NodeType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("node_type");
        set => this.WithProperty("node_type", value);
    }

    /// <summary>
    /// The number_of_nodes attribute.
    /// </summary>
    public TerraformProperty<double>? NumberOfNodes
    {
        get => GetProperty<TerraformProperty<double>>("number_of_nodes");
        set => this.WithProperty("number_of_nodes", value);
    }

    /// <summary>
    /// The owner_account attribute.
    /// </summary>
    public TerraformProperty<string>? OwnerAccount
    {
        get => GetProperty<TerraformProperty<string>>("owner_account");
        set => this.WithProperty("owner_account", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformProperty<double>? Port
    {
        get => GetProperty<TerraformProperty<double>>("port");
        set => this.WithProperty("port", value);
    }

    /// <summary>
    /// The preferred_maintenance_window attribute.
    /// </summary>
    public TerraformProperty<string>? PreferredMaintenanceWindow
    {
        get => GetProperty<TerraformProperty<string>>("preferred_maintenance_window");
        set => this.WithProperty("preferred_maintenance_window", value);
    }

    /// <summary>
    /// The publicly_accessible attribute.
    /// </summary>
    public TerraformProperty<bool>? PubliclyAccessible
    {
        get => GetProperty<TerraformProperty<bool>>("publicly_accessible");
        set => this.WithProperty("publicly_accessible", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The skip_final_snapshot attribute.
    /// </summary>
    public TerraformProperty<bool>? SkipFinalSnapshot
    {
        get => GetProperty<TerraformProperty<bool>>("skip_final_snapshot");
        set => this.WithProperty("skip_final_snapshot", value);
    }

    /// <summary>
    /// The snapshot_arn attribute.
    /// </summary>
    public TerraformProperty<string>? SnapshotArn
    {
        get => GetProperty<TerraformProperty<string>>("snapshot_arn");
        set => this.WithProperty("snapshot_arn", value);
    }

    /// <summary>
    /// The snapshot_cluster_identifier attribute.
    /// </summary>
    public TerraformProperty<string>? SnapshotClusterIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("snapshot_cluster_identifier");
        set => this.WithProperty("snapshot_cluster_identifier", value);
    }

    /// <summary>
    /// The snapshot_identifier attribute.
    /// </summary>
    public TerraformProperty<string>? SnapshotIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("snapshot_identifier");
        set => this.WithProperty("snapshot_identifier", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? VpcSecurityGroupIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("vpc_security_group_ids");
        set => this.WithProperty("vpc_security_group_ids", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsRedshiftClusterTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsRedshiftClusterTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
