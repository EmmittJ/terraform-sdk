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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("arn");
        SetOutput("cluster_namespace_arn");
        SetOutput("cluster_nodes");
        SetOutput("cluster_public_key");
        SetOutput("cluster_revision_number");
        SetOutput("dns_name");
        SetOutput("endpoint");
        SetOutput("master_password_secret_arn");
        SetOutput("allow_version_upgrade");
        SetOutput("apply_immediately");
        SetOutput("aqua_configuration_status");
        SetOutput("automated_snapshot_retention_period");
        SetOutput("availability_zone");
        SetOutput("availability_zone_relocation_enabled");
        SetOutput("cluster_identifier");
        SetOutput("cluster_parameter_group_name");
        SetOutput("cluster_subnet_group_name");
        SetOutput("cluster_type");
        SetOutput("cluster_version");
        SetOutput("database_name");
        SetOutput("default_iam_role_arn");
        SetOutput("elastic_ip");
        SetOutput("encrypted");
        SetOutput("enhanced_vpc_routing");
        SetOutput("final_snapshot_identifier");
        SetOutput("iam_roles");
        SetOutput("id");
        SetOutput("kms_key_id");
        SetOutput("maintenance_track_name");
        SetOutput("manage_master_password");
        SetOutput("manual_snapshot_retention_period");
        SetOutput("master_password");
        SetOutput("master_password_secret_kms_key_id");
        SetOutput("master_password_wo");
        SetOutput("master_password_wo_version");
        SetOutput("master_username");
        SetOutput("multi_az");
        SetOutput("node_type");
        SetOutput("number_of_nodes");
        SetOutput("owner_account");
        SetOutput("port");
        SetOutput("preferred_maintenance_window");
        SetOutput("publicly_accessible");
        SetOutput("region");
        SetOutput("skip_final_snapshot");
        SetOutput("snapshot_arn");
        SetOutput("snapshot_cluster_identifier");
        SetOutput("snapshot_identifier");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("vpc_security_group_ids");
    }

    /// <summary>
    /// The allow_version_upgrade attribute.
    /// </summary>
    public TerraformProperty<bool> AllowVersionUpgrade
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("allow_version_upgrade");
        set => SetProperty("allow_version_upgrade", value);
    }

    /// <summary>
    /// The apply_immediately attribute.
    /// </summary>
    public TerraformProperty<bool> ApplyImmediately
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("apply_immediately");
        set => SetProperty("apply_immediately", value);
    }

    /// <summary>
    /// The aqua_configuration_status attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<string> AquaConfigurationStatus
    {
        get => GetRequiredOutput<TerraformProperty<string>>("aqua_configuration_status");
        set => SetProperty("aqua_configuration_status", value);
    }

    /// <summary>
    /// The automated_snapshot_retention_period attribute.
    /// </summary>
    public TerraformProperty<double> AutomatedSnapshotRetentionPeriod
    {
        get => GetRequiredOutput<TerraformProperty<double>>("automated_snapshot_retention_period");
        set => SetProperty("automated_snapshot_retention_period", value);
    }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformProperty<string> AvailabilityZone
    {
        get => GetRequiredOutput<TerraformProperty<string>>("availability_zone");
        set => SetProperty("availability_zone", value);
    }

    /// <summary>
    /// The availability_zone_relocation_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> AvailabilityZoneRelocationEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("availability_zone_relocation_enabled");
        set => SetProperty("availability_zone_relocation_enabled", value);
    }

    /// <summary>
    /// The cluster_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterIdentifier is required")]
    public required TerraformProperty<string> ClusterIdentifier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cluster_identifier");
        set => SetProperty("cluster_identifier", value);
    }

    /// <summary>
    /// The cluster_parameter_group_name attribute.
    /// </summary>
    public TerraformProperty<string> ClusterParameterGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cluster_parameter_group_name");
        set => SetProperty("cluster_parameter_group_name", value);
    }

    /// <summary>
    /// The cluster_subnet_group_name attribute.
    /// </summary>
    public TerraformProperty<string> ClusterSubnetGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cluster_subnet_group_name");
        set => SetProperty("cluster_subnet_group_name", value);
    }

    /// <summary>
    /// The cluster_type attribute.
    /// </summary>
    public TerraformProperty<string> ClusterType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cluster_type");
        set => SetProperty("cluster_type", value);
    }

    /// <summary>
    /// The cluster_version attribute.
    /// </summary>
    public TerraformProperty<string> ClusterVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cluster_version");
        set => SetProperty("cluster_version", value);
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    public TerraformProperty<string> DatabaseName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("database_name");
        set => SetProperty("database_name", value);
    }

    /// <summary>
    /// The default_iam_role_arn attribute.
    /// </summary>
    public TerraformProperty<string> DefaultIamRoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("default_iam_role_arn");
        set => SetProperty("default_iam_role_arn", value);
    }

    /// <summary>
    /// The elastic_ip attribute.
    /// </summary>
    public TerraformProperty<string> ElasticIp
    {
        get => GetRequiredOutput<TerraformProperty<string>>("elastic_ip");
        set => SetProperty("elastic_ip", value);
    }

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    public TerraformProperty<string> Encrypted
    {
        get => GetRequiredOutput<TerraformProperty<string>>("encrypted");
        set => SetProperty("encrypted", value);
    }

    /// <summary>
    /// The enhanced_vpc_routing attribute.
    /// </summary>
    public TerraformProperty<bool> EnhancedVpcRouting
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enhanced_vpc_routing");
        set => SetProperty("enhanced_vpc_routing", value);
    }

    /// <summary>
    /// The final_snapshot_identifier attribute.
    /// </summary>
    public TerraformProperty<string> FinalSnapshotIdentifier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("final_snapshot_identifier");
        set => SetProperty("final_snapshot_identifier", value);
    }

    /// <summary>
    /// The iam_roles attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> IamRoles
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("iam_roles");
        set => SetProperty("iam_roles", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string> KmsKeyId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kms_key_id");
        set => SetProperty("kms_key_id", value);
    }

    /// <summary>
    /// The maintenance_track_name attribute.
    /// </summary>
    public TerraformProperty<string> MaintenanceTrackName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("maintenance_track_name");
        set => SetProperty("maintenance_track_name", value);
    }

    /// <summary>
    /// The manage_master_password attribute.
    /// </summary>
    public TerraformProperty<bool> ManageMasterPassword
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("manage_master_password");
        set => SetProperty("manage_master_password", value);
    }

    /// <summary>
    /// The manual_snapshot_retention_period attribute.
    /// </summary>
    public TerraformProperty<double> ManualSnapshotRetentionPeriod
    {
        get => GetRequiredOutput<TerraformProperty<double>>("manual_snapshot_retention_period");
        set => SetProperty("manual_snapshot_retention_period", value);
    }

    /// <summary>
    /// The master_password attribute.
    /// </summary>
    public TerraformProperty<string> MasterPassword
    {
        get => GetRequiredOutput<TerraformProperty<string>>("master_password");
        set => SetProperty("master_password", value);
    }

    /// <summary>
    /// The master_password_secret_kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string> MasterPasswordSecretKmsKeyId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("master_password_secret_kms_key_id");
        set => SetProperty("master_password_secret_kms_key_id", value);
    }

    /// <summary>
    /// The master_password_wo attribute.
    /// </summary>
    public TerraformProperty<string> MasterPasswordWo
    {
        get => GetRequiredOutput<TerraformProperty<string>>("master_password_wo");
        set => SetProperty("master_password_wo", value);
    }

    /// <summary>
    /// The master_password_wo_version attribute.
    /// </summary>
    public TerraformProperty<double> MasterPasswordWoVersion
    {
        get => GetRequiredOutput<TerraformProperty<double>>("master_password_wo_version");
        set => SetProperty("master_password_wo_version", value);
    }

    /// <summary>
    /// The master_username attribute.
    /// </summary>
    public TerraformProperty<string> MasterUsername
    {
        get => GetRequiredOutput<TerraformProperty<string>>("master_username");
        set => SetProperty("master_username", value);
    }

    /// <summary>
    /// The multi_az attribute.
    /// </summary>
    public TerraformProperty<bool> MultiAz
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("multi_az");
        set => SetProperty("multi_az", value);
    }

    /// <summary>
    /// The node_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeType is required")]
    public required TerraformProperty<string> NodeType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("node_type");
        set => SetProperty("node_type", value);
    }

    /// <summary>
    /// The number_of_nodes attribute.
    /// </summary>
    public TerraformProperty<double> NumberOfNodes
    {
        get => GetRequiredOutput<TerraformProperty<double>>("number_of_nodes");
        set => SetProperty("number_of_nodes", value);
    }

    /// <summary>
    /// The owner_account attribute.
    /// </summary>
    public TerraformProperty<string> OwnerAccount
    {
        get => GetRequiredOutput<TerraformProperty<string>>("owner_account");
        set => SetProperty("owner_account", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformProperty<double> Port
    {
        get => GetRequiredOutput<TerraformProperty<double>>("port");
        set => SetProperty("port", value);
    }

    /// <summary>
    /// The preferred_maintenance_window attribute.
    /// </summary>
    public TerraformProperty<string> PreferredMaintenanceWindow
    {
        get => GetRequiredOutput<TerraformProperty<string>>("preferred_maintenance_window");
        set => SetProperty("preferred_maintenance_window", value);
    }

    /// <summary>
    /// The publicly_accessible attribute.
    /// </summary>
    public TerraformProperty<bool> PubliclyAccessible
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("publicly_accessible");
        set => SetProperty("publicly_accessible", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The skip_final_snapshot attribute.
    /// </summary>
    public TerraformProperty<bool> SkipFinalSnapshot
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("skip_final_snapshot");
        set => SetProperty("skip_final_snapshot", value);
    }

    /// <summary>
    /// The snapshot_arn attribute.
    /// </summary>
    public TerraformProperty<string> SnapshotArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("snapshot_arn");
        set => SetProperty("snapshot_arn", value);
    }

    /// <summary>
    /// The snapshot_cluster_identifier attribute.
    /// </summary>
    public TerraformProperty<string> SnapshotClusterIdentifier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("snapshot_cluster_identifier");
        set => SetProperty("snapshot_cluster_identifier", value);
    }

    /// <summary>
    /// The snapshot_identifier attribute.
    /// </summary>
    public TerraformProperty<string> SnapshotIdentifier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("snapshot_identifier");
        set => SetProperty("snapshot_identifier", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> VpcSecurityGroupIds
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("vpc_security_group_ids");
        set => SetProperty("vpc_security_group_ids", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsRedshiftClusterTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
