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
        SetOutput("availability_zones");
        SetOutput("max_iops_per_db_instance");
        SetOutput("max_iops_per_gib");
        SetOutput("max_storage_size");
        SetOutput("min_iops_per_db_instance");
        SetOutput("min_iops_per_gib");
        SetOutput("min_storage_size");
        SetOutput("multi_az_capable");
        SetOutput("read_replica_capable");
        SetOutput("storage_type");
        SetOutput("supports_enhanced_monitoring");
        SetOutput("supports_iam_database_authentication");
        SetOutput("supports_iops");
        SetOutput("supports_performance_insights");
        SetOutput("supports_storage_encryption");
        SetOutput("engine");
        SetOutput("engine_version");
        SetOutput("id");
        SetOutput("instance_class");
        SetOutput("license_model");
        SetOutput("preferred_instance_classes");
        SetOutput("region");
        SetOutput("vpc");
    }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    public TerraformProperty<string> Engine
    {
        get => GetRequiredOutput<TerraformProperty<string>>("engine");
        set => SetProperty("engine", value);
    }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public TerraformProperty<string> EngineVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("engine_version");
        set => SetProperty("engine_version", value);
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
    /// The instance_class attribute.
    /// </summary>
    public TerraformProperty<string> InstanceClass
    {
        get => GetRequiredOutput<TerraformProperty<string>>("instance_class");
        set => SetProperty("instance_class", value);
    }

    /// <summary>
    /// The license_model attribute.
    /// </summary>
    public TerraformProperty<string> LicenseModel
    {
        get => GetRequiredOutput<TerraformProperty<string>>("license_model");
        set => SetProperty("license_model", value);
    }

    /// <summary>
    /// The preferred_instance_classes attribute.
    /// </summary>
    public List<TerraformProperty<string>> PreferredInstanceClasses
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("preferred_instance_classes");
        set => SetProperty("preferred_instance_classes", value);
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
    /// The vpc attribute.
    /// </summary>
    public TerraformProperty<bool> Vpc
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("vpc");
        set => SetProperty("vpc", value);
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
