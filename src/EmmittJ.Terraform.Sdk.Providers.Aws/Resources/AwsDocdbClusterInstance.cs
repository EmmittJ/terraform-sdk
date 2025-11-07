using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_docdb_cluster_instance resource.
/// </summary>
public class AwsDocdbClusterInstance : TerraformResource
{
    public AwsDocdbClusterInstance(string name) : base("aws_docdb_cluster_instance", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("db_subnet_group_name");
        this.DeclareOutput("dbi_resource_id");
        this.DeclareOutput("endpoint");
        this.DeclareOutput("engine_version");
        this.DeclareOutput("kms_key_id");
        this.DeclareOutput("port");
        this.DeclareOutput("preferred_backup_window");
        this.DeclareOutput("publicly_accessible");
        this.DeclareOutput("storage_encrypted");
        this.DeclareOutput("writer");
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
    /// The auto_minor_version_upgrade attribute.
    /// </summary>
    public TerraformProperty<bool>? AutoMinorVersionUpgrade
    {
        get => GetProperty<TerraformProperty<bool>>("auto_minor_version_upgrade");
        set => this.WithProperty("auto_minor_version_upgrade", value);
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
    /// The ca_cert_identifier attribute.
    /// </summary>
    public TerraformProperty<string>? CaCertIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("ca_cert_identifier");
        set => this.WithProperty("ca_cert_identifier", value);
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
    /// The copy_tags_to_snapshot attribute.
    /// </summary>
    public TerraformProperty<bool>? CopyTagsToSnapshot
    {
        get => GetProperty<TerraformProperty<bool>>("copy_tags_to_snapshot");
        set => this.WithProperty("copy_tags_to_snapshot", value);
    }

    /// <summary>
    /// The enable_performance_insights attribute.
    /// </summary>
    public TerraformProperty<bool>? EnablePerformanceInsights
    {
        get => GetProperty<TerraformProperty<bool>>("enable_performance_insights");
        set => this.WithProperty("enable_performance_insights", value);
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
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The identifier attribute.
    /// </summary>
    public TerraformProperty<string>? Identifier
    {
        get => GetProperty<TerraformProperty<string>>("identifier");
        set => this.WithProperty("identifier", value);
    }

    /// <summary>
    /// The identifier_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? IdentifierPrefix
    {
        get => GetProperty<TerraformProperty<string>>("identifier_prefix");
        set => this.WithProperty("identifier_prefix", value);
    }

    /// <summary>
    /// The instance_class attribute.
    /// </summary>
    public TerraformProperty<string>? InstanceClass
    {
        get => GetProperty<TerraformProperty<string>>("instance_class");
        set => this.WithProperty("instance_class", value);
    }

    /// <summary>
    /// The performance_insights_kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? PerformanceInsightsKmsKeyId
    {
        get => GetProperty<TerraformProperty<string>>("performance_insights_kms_key_id");
        set => this.WithProperty("performance_insights_kms_key_id", value);
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
    /// The promotion_tier attribute.
    /// </summary>
    public TerraformProperty<double>? PromotionTier
    {
        get => GetProperty<TerraformProperty<double>>("promotion_tier");
        set => this.WithProperty("promotion_tier", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The db_subnet_group_name attribute.
    /// </summary>
    public TerraformExpression DbSubnetGroupName => this["db_subnet_group_name"];

    /// <summary>
    /// The dbi_resource_id attribute.
    /// </summary>
    public TerraformExpression DbiResourceId => this["dbi_resource_id"];

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformExpression Endpoint => this["endpoint"];

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public TerraformExpression EngineVersion => this["engine_version"];

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformExpression KmsKeyId => this["kms_key_id"];

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformExpression Port => this["port"];

    /// <summary>
    /// The preferred_backup_window attribute.
    /// </summary>
    public TerraformExpression PreferredBackupWindow => this["preferred_backup_window"];

    /// <summary>
    /// The publicly_accessible attribute.
    /// </summary>
    public TerraformExpression PubliclyAccessible => this["publicly_accessible"];

    /// <summary>
    /// The storage_encrypted attribute.
    /// </summary>
    public TerraformExpression StorageEncrypted => this["storage_encrypted"];

    /// <summary>
    /// The writer attribute.
    /// </summary>
    public TerraformExpression Writer => this["writer"];

}
