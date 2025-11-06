using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_neptune_cluster_instance resource.
/// </summary>
public class AwsNeptuneClusterInstance : TerraformResource
{
    public AwsNeptuneClusterInstance(string name) : base("aws_neptune_cluster_instance", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("address");
        this.DeclareOutput("arn");
        this.DeclareOutput("dbi_resource_id");
        this.DeclareOutput("endpoint");
        this.DeclareOutput("kms_key_arn");
        this.DeclareOutput("storage_encrypted");
        this.DeclareOutput("storage_type");
        this.DeclareOutput("writer");
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
    /// The auto_minor_version_upgrade attribute.
    /// </summary>
    public bool? AutoMinorVersionUpgrade
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("auto_minor_version_upgrade")?.Value;
        set => this.WithProperty("auto_minor_version_upgrade", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The cluster_identifier attribute.
    /// </summary>
    public string? ClusterIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cluster_identifier")?.Value;
        set => this.WithProperty("cluster_identifier", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    public string? Engine
    {
        get => GetProperty<TerraformLiteralProperty<string>>("engine")?.Value;
        set => this.WithProperty("engine", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public string? EngineVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("engine_version")?.Value;
        set => this.WithProperty("engine_version", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The identifier attribute.
    /// </summary>
    public string? Identifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("identifier")?.Value;
        set => this.WithProperty("identifier", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The identifier_prefix attribute.
    /// </summary>
    public string? IdentifierPrefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("identifier_prefix")?.Value;
        set => this.WithProperty("identifier_prefix", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The instance_class attribute.
    /// </summary>
    public string? InstanceClass
    {
        get => GetProperty<TerraformLiteralProperty<string>>("instance_class")?.Value;
        set => this.WithProperty("instance_class", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The neptune_parameter_group_name attribute.
    /// </summary>
    public string? NeptuneParameterGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("neptune_parameter_group_name")?.Value;
        set => this.WithProperty("neptune_parameter_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The neptune_subnet_group_name attribute.
    /// </summary>
    public string? NeptuneSubnetGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("neptune_subnet_group_name")?.Value;
        set => this.WithProperty("neptune_subnet_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The preferred_backup_window attribute.
    /// </summary>
    public string? PreferredBackupWindow
    {
        get => GetProperty<TerraformLiteralProperty<string>>("preferred_backup_window")?.Value;
        set => this.WithProperty("preferred_backup_window", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The promotion_tier attribute.
    /// </summary>
    public double? PromotionTier
    {
        get => GetProperty<TerraformLiteralProperty<double>>("promotion_tier")?.Value;
        set => this.WithProperty("promotion_tier", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The address attribute.
    /// </summary>
    public TerraformExpression Address => this["address"];

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The dbi_resource_id attribute.
    /// </summary>
    public TerraformExpression DbiResourceId => this["dbi_resource_id"];

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformExpression Endpoint => this["endpoint"];

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformExpression KmsKeyArn => this["kms_key_arn"];

    /// <summary>
    /// The storage_encrypted attribute.
    /// </summary>
    public TerraformExpression StorageEncrypted => this["storage_encrypted"];

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    public TerraformExpression StorageType => this["storage_type"];

    /// <summary>
    /// The writer attribute.
    /// </summary>
    public TerraformExpression Writer => this["writer"];

}
