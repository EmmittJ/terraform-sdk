using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_neptune_orderable_db_instance.
/// </summary>
public class AwsNeptuneOrderableDbInstanceDataSource : TerraformDataSource
{
    public AwsNeptuneOrderableDbInstanceDataSource(string name) : base("aws_neptune_orderable_db_instance", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("availability_zones");
        this.DeclareOutput("max_iops_per_db_instance");
        this.DeclareOutput("max_iops_per_gib");
        this.DeclareOutput("max_storage_size");
        this.DeclareOutput("min_iops_per_db_instance");
        this.DeclareOutput("min_iops_per_gib");
        this.DeclareOutput("min_storage_size");
        this.DeclareOutput("multi_az_capable");
        this.DeclareOutput("read_replica_capable");
        this.DeclareOutput("storage_type");
        this.DeclareOutput("supports_enhanced_monitoring");
        this.DeclareOutput("supports_iam_database_authentication");
        this.DeclareOutput("supports_iops");
        this.DeclareOutput("supports_performance_insights");
        this.DeclareOutput("supports_storage_encryption");
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
    /// The instance_class attribute.
    /// </summary>
    public string? InstanceClass
    {
        get => GetProperty<TerraformLiteralProperty<string>>("instance_class")?.Value;
        set => this.WithProperty("instance_class", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The license_model attribute.
    /// </summary>
    public string? LicenseModel
    {
        get => GetProperty<TerraformLiteralProperty<string>>("license_model")?.Value;
        set => this.WithProperty("license_model", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The preferred_instance_classes attribute.
    /// </summary>
    public List<string>? PreferredInstanceClasses
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("preferred_instance_classes")?.Value;
        set => this.WithProperty("preferred_instance_classes", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
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
    /// The vpc attribute.
    /// </summary>
    public bool? Vpc
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("vpc")?.Value;
        set => this.WithProperty("vpc", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    public TerraformExpression AvailabilityZones => this["availability_zones"];

    /// <summary>
    /// The max_iops_per_db_instance attribute.
    /// </summary>
    public TerraformExpression MaxIopsPerDbInstance => this["max_iops_per_db_instance"];

    /// <summary>
    /// The max_iops_per_gib attribute.
    /// </summary>
    public TerraformExpression MaxIopsPerGib => this["max_iops_per_gib"];

    /// <summary>
    /// The max_storage_size attribute.
    /// </summary>
    public TerraformExpression MaxStorageSize => this["max_storage_size"];

    /// <summary>
    /// The min_iops_per_db_instance attribute.
    /// </summary>
    public TerraformExpression MinIopsPerDbInstance => this["min_iops_per_db_instance"];

    /// <summary>
    /// The min_iops_per_gib attribute.
    /// </summary>
    public TerraformExpression MinIopsPerGib => this["min_iops_per_gib"];

    /// <summary>
    /// The min_storage_size attribute.
    /// </summary>
    public TerraformExpression MinStorageSize => this["min_storage_size"];

    /// <summary>
    /// The multi_az_capable attribute.
    /// </summary>
    public TerraformExpression MultiAzCapable => this["multi_az_capable"];

    /// <summary>
    /// The read_replica_capable attribute.
    /// </summary>
    public TerraformExpression ReadReplicaCapable => this["read_replica_capable"];

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    public TerraformExpression StorageType => this["storage_type"];

    /// <summary>
    /// The supports_enhanced_monitoring attribute.
    /// </summary>
    public TerraformExpression SupportsEnhancedMonitoring => this["supports_enhanced_monitoring"];

    /// <summary>
    /// The supports_iam_database_authentication attribute.
    /// </summary>
    public TerraformExpression SupportsIamDatabaseAuthentication => this["supports_iam_database_authentication"];

    /// <summary>
    /// The supports_iops attribute.
    /// </summary>
    public TerraformExpression SupportsIops => this["supports_iops"];

    /// <summary>
    /// The supports_performance_insights attribute.
    /// </summary>
    public TerraformExpression SupportsPerformanceInsights => this["supports_performance_insights"];

    /// <summary>
    /// The supports_storage_encryption attribute.
    /// </summary>
    public TerraformExpression SupportsStorageEncryption => this["supports_storage_encryption"];

}
