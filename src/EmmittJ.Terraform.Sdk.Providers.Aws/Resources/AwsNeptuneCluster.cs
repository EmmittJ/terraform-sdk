using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_neptune_cluster resource.
/// </summary>
public class AwsNeptuneCluster : TerraformResource
{
    public AwsNeptuneCluster(string name) : base("aws_neptune_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("cluster_members");
        this.DeclareOutput("cluster_resource_id");
        this.DeclareOutput("endpoint");
        this.DeclareOutput("hosted_zone_id");
        this.DeclareOutput("reader_endpoint");
    }

    /// <summary>
    /// The allow_major_version_upgrade attribute.
    /// </summary>
    public TerraformProperty<bool>? AllowMajorVersionUpgrade
    {
        get => GetProperty<TerraformProperty<bool>>("allow_major_version_upgrade");
        set => this.WithProperty("allow_major_version_upgrade", value);
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
    /// The availability_zones attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? AvailabilityZones
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("availability_zones");
        set => this.WithProperty("availability_zones", value);
    }

    /// <summary>
    /// The backup_retention_period attribute.
    /// </summary>
    public TerraformProperty<double>? BackupRetentionPeriod
    {
        get => GetProperty<TerraformProperty<double>>("backup_retention_period");
        set => this.WithProperty("backup_retention_period", value);
    }

    /// <summary>
    /// The cluster_identifier attribute.
    /// </summary>
    public TerraformProperty<string>? ClusterIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("cluster_identifier");
        set => this.WithProperty("cluster_identifier", value);
    }

    /// <summary>
    /// The cluster_identifier_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? ClusterIdentifierPrefix
    {
        get => GetProperty<TerraformProperty<string>>("cluster_identifier_prefix");
        set => this.WithProperty("cluster_identifier_prefix", value);
    }

    /// <summary>
    /// The copy_tags_to_snapshot attribute.
    /// </summary>
    public TerraformProperty<bool>? CopyTagsToSnapshot
    {
        get => GetProperty<TerraformProperty<bool>>("copy_tags_to_snapshot");
        set => this.WithProperty("copy_tags_to_snapshot", value);
    }

    /// <summary>
    /// The deletion_protection attribute.
    /// </summary>
    public TerraformProperty<bool>? DeletionProtection
    {
        get => GetProperty<TerraformProperty<bool>>("deletion_protection");
        set => this.WithProperty("deletion_protection", value);
    }

    /// <summary>
    /// The enable_cloudwatch_logs_exports attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? EnableCloudwatchLogsExports
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("enable_cloudwatch_logs_exports");
        set => this.WithProperty("enable_cloudwatch_logs_exports", value);
    }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    public TerraformProperty<string>? Engine
    {
        get => GetProperty<TerraformProperty<string>>("engine");
        set => this.WithProperty("engine", value);
    }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public TerraformProperty<string>? EngineVersion
    {
        get => GetProperty<TerraformProperty<string>>("engine_version");
        set => this.WithProperty("engine_version", value);
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
    /// The global_cluster_identifier attribute.
    /// </summary>
    public TerraformProperty<string>? GlobalClusterIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("global_cluster_identifier");
        set => this.WithProperty("global_cluster_identifier", value);
    }

    /// <summary>
    /// The iam_database_authentication_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? IamDatabaseAuthenticationEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("iam_database_authentication_enabled");
        set => this.WithProperty("iam_database_authentication_enabled", value);
    }

    /// <summary>
    /// The iam_roles attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? IamRoles
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("iam_roles");
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
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyArn
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_arn");
        set => this.WithProperty("kms_key_arn", value);
    }

    /// <summary>
    /// The neptune_cluster_parameter_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? NeptuneClusterParameterGroupName
    {
        get => GetProperty<TerraformProperty<string>>("neptune_cluster_parameter_group_name");
        set => this.WithProperty("neptune_cluster_parameter_group_name", value);
    }

    /// <summary>
    /// The neptune_instance_parameter_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? NeptuneInstanceParameterGroupName
    {
        get => GetProperty<TerraformProperty<string>>("neptune_instance_parameter_group_name");
        set => this.WithProperty("neptune_instance_parameter_group_name", value);
    }

    /// <summary>
    /// The neptune_subnet_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? NeptuneSubnetGroupName
    {
        get => GetProperty<TerraformProperty<string>>("neptune_subnet_group_name");
        set => this.WithProperty("neptune_subnet_group_name", value);
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
    /// The preferred_backup_window attribute.
    /// </summary>
    public TerraformProperty<string>? PreferredBackupWindow
    {
        get => GetProperty<TerraformProperty<string>>("preferred_backup_window");
        set => this.WithProperty("preferred_backup_window", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The replication_source_identifier attribute.
    /// </summary>
    public TerraformProperty<string>? ReplicationSourceIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("replication_source_identifier");
        set => this.WithProperty("replication_source_identifier", value);
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
    /// The snapshot_identifier attribute.
    /// </summary>
    public TerraformProperty<string>? SnapshotIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("snapshot_identifier");
        set => this.WithProperty("snapshot_identifier", value);
    }

    /// <summary>
    /// The storage_encrypted attribute.
    /// </summary>
    public TerraformProperty<bool>? StorageEncrypted
    {
        get => GetProperty<TerraformProperty<bool>>("storage_encrypted");
        set => this.WithProperty("storage_encrypted", value);
    }

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    public TerraformProperty<string>? StorageType
    {
        get => GetProperty<TerraformProperty<string>>("storage_type");
        set => this.WithProperty("storage_type", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? VpcSecurityGroupIds
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("vpc_security_group_ids");
        set => this.WithProperty("vpc_security_group_ids", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The cluster_members attribute.
    /// </summary>
    public TerraformExpression ClusterMembers => this["cluster_members"];

    /// <summary>
    /// The cluster_resource_id attribute.
    /// </summary>
    public TerraformExpression ClusterResourceId => this["cluster_resource_id"];

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformExpression Endpoint => this["endpoint"];

    /// <summary>
    /// The hosted_zone_id attribute.
    /// </summary>
    public TerraformExpression HostedZoneId => this["hosted_zone_id"];

    /// <summary>
    /// The reader_endpoint attribute.
    /// </summary>
    public TerraformExpression ReaderEndpoint => this["reader_endpoint"];

}
