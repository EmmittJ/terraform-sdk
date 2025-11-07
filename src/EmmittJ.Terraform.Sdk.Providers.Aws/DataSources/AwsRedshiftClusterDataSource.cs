using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_redshift_cluster.
/// </summary>
public class AwsRedshiftClusterDataSource : TerraformDataSource
{
    public AwsRedshiftClusterDataSource(string name) : base("aws_redshift_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("allow_version_upgrade");
        this.DeclareOutput("aqua_configuration_status");
        this.DeclareOutput("arn");
        this.DeclareOutput("automated_snapshot_retention_period");
        this.DeclareOutput("availability_zone");
        this.DeclareOutput("availability_zone_relocation_enabled");
        this.DeclareOutput("bucket_name");
        this.DeclareOutput("cluster_namespace_arn");
        this.DeclareOutput("cluster_nodes");
        this.DeclareOutput("cluster_parameter_group_name");
        this.DeclareOutput("cluster_public_key");
        this.DeclareOutput("cluster_revision_number");
        this.DeclareOutput("cluster_subnet_group_name");
        this.DeclareOutput("cluster_type");
        this.DeclareOutput("cluster_version");
        this.DeclareOutput("database_name");
        this.DeclareOutput("default_iam_role_arn");
        this.DeclareOutput("elastic_ip");
        this.DeclareOutput("enable_logging");
        this.DeclareOutput("encrypted");
        this.DeclareOutput("endpoint");
        this.DeclareOutput("enhanced_vpc_routing");
        this.DeclareOutput("iam_roles");
        this.DeclareOutput("kms_key_id");
        this.DeclareOutput("log_destination_type");
        this.DeclareOutput("log_exports");
        this.DeclareOutput("maintenance_track_name");
        this.DeclareOutput("manual_snapshot_retention_period");
        this.DeclareOutput("master_username");
        this.DeclareOutput("multi_az");
        this.DeclareOutput("node_type");
        this.DeclareOutput("number_of_nodes");
        this.DeclareOutput("port");
        this.DeclareOutput("preferred_maintenance_window");
        this.DeclareOutput("publicly_accessible");
        this.DeclareOutput("s3_key_prefix");
        this.DeclareOutput("vpc_id");
        this.DeclareOutput("vpc_security_group_ids");
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
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The allow_version_upgrade attribute.
    /// </summary>
    public TerraformExpression AllowVersionUpgrade => this["allow_version_upgrade"];

    /// <summary>
    /// The aqua_configuration_status attribute.
    /// </summary>
    public TerraformExpression AquaConfigurationStatus => this["aqua_configuration_status"];

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The automated_snapshot_retention_period attribute.
    /// </summary>
    public TerraformExpression AutomatedSnapshotRetentionPeriod => this["automated_snapshot_retention_period"];

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformExpression AvailabilityZone => this["availability_zone"];

    /// <summary>
    /// The availability_zone_relocation_enabled attribute.
    /// </summary>
    public TerraformExpression AvailabilityZoneRelocationEnabled => this["availability_zone_relocation_enabled"];

    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    public TerraformExpression BucketName => this["bucket_name"];

    /// <summary>
    /// The cluster_namespace_arn attribute.
    /// </summary>
    public TerraformExpression ClusterNamespaceArn => this["cluster_namespace_arn"];

    /// <summary>
    /// The cluster_nodes attribute.
    /// </summary>
    public TerraformExpression ClusterNodes => this["cluster_nodes"];

    /// <summary>
    /// The cluster_parameter_group_name attribute.
    /// </summary>
    public TerraformExpression ClusterParameterGroupName => this["cluster_parameter_group_name"];

    /// <summary>
    /// The cluster_public_key attribute.
    /// </summary>
    public TerraformExpression ClusterPublicKey => this["cluster_public_key"];

    /// <summary>
    /// The cluster_revision_number attribute.
    /// </summary>
    public TerraformExpression ClusterRevisionNumber => this["cluster_revision_number"];

    /// <summary>
    /// The cluster_subnet_group_name attribute.
    /// </summary>
    public TerraformExpression ClusterSubnetGroupName => this["cluster_subnet_group_name"];

    /// <summary>
    /// The cluster_type attribute.
    /// </summary>
    public TerraformExpression ClusterType => this["cluster_type"];

    /// <summary>
    /// The cluster_version attribute.
    /// </summary>
    public TerraformExpression ClusterVersion => this["cluster_version"];

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    public TerraformExpression DatabaseName => this["database_name"];

    /// <summary>
    /// The default_iam_role_arn attribute.
    /// </summary>
    public TerraformExpression DefaultIamRoleArn => this["default_iam_role_arn"];

    /// <summary>
    /// The elastic_ip attribute.
    /// </summary>
    public TerraformExpression ElasticIp => this["elastic_ip"];

    /// <summary>
    /// The enable_logging attribute.
    /// </summary>
    public TerraformExpression EnableLogging => this["enable_logging"];

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    public TerraformExpression Encrypted => this["encrypted"];

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformExpression Endpoint => this["endpoint"];

    /// <summary>
    /// The enhanced_vpc_routing attribute.
    /// </summary>
    public TerraformExpression EnhancedVpcRouting => this["enhanced_vpc_routing"];

    /// <summary>
    /// The iam_roles attribute.
    /// </summary>
    public TerraformExpression IamRoles => this["iam_roles"];

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformExpression KmsKeyId => this["kms_key_id"];

    /// <summary>
    /// The log_destination_type attribute.
    /// </summary>
    public TerraformExpression LogDestinationType => this["log_destination_type"];

    /// <summary>
    /// The log_exports attribute.
    /// </summary>
    public TerraformExpression LogExports => this["log_exports"];

    /// <summary>
    /// The maintenance_track_name attribute.
    /// </summary>
    public TerraformExpression MaintenanceTrackName => this["maintenance_track_name"];

    /// <summary>
    /// The manual_snapshot_retention_period attribute.
    /// </summary>
    public TerraformExpression ManualSnapshotRetentionPeriod => this["manual_snapshot_retention_period"];

    /// <summary>
    /// The master_username attribute.
    /// </summary>
    public TerraformExpression MasterUsername => this["master_username"];

    /// <summary>
    /// The multi_az attribute.
    /// </summary>
    public TerraformExpression MultiAz => this["multi_az"];

    /// <summary>
    /// The node_type attribute.
    /// </summary>
    public TerraformExpression NodeType => this["node_type"];

    /// <summary>
    /// The number_of_nodes attribute.
    /// </summary>
    public TerraformExpression NumberOfNodes => this["number_of_nodes"];

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformExpression Port => this["port"];

    /// <summary>
    /// The preferred_maintenance_window attribute.
    /// </summary>
    public TerraformExpression PreferredMaintenanceWindow => this["preferred_maintenance_window"];

    /// <summary>
    /// The publicly_accessible attribute.
    /// </summary>
    public TerraformExpression PubliclyAccessible => this["publicly_accessible"];

    /// <summary>
    /// The s3_key_prefix attribute.
    /// </summary>
    public TerraformExpression S3KeyPrefix => this["s3_key_prefix"];

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformExpression VpcId => this["vpc_id"];

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    public TerraformExpression VpcSecurityGroupIds => this["vpc_security_group_ids"];

}
