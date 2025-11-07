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
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
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
    /// The license_model attribute.
    /// </summary>
    public TerraformProperty<string>? LicenseModel
    {
        get => GetProperty<TerraformProperty<string>>("license_model");
        set => this.WithProperty("license_model", value);
    }

    /// <summary>
    /// The preferred_instance_classes attribute.
    /// </summary>
    public TerraformProperty<List<string>>? PreferredInstanceClasses
    {
        get => GetProperty<TerraformProperty<List<string>>>("preferred_instance_classes");
        set => this.WithProperty("preferred_instance_classes", value);
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
    /// The vpc attribute.
    /// </summary>
    public TerraformProperty<bool>? Vpc
    {
        get => GetProperty<TerraformProperty<bool>>("vpc");
        set => this.WithProperty("vpc", value);
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
