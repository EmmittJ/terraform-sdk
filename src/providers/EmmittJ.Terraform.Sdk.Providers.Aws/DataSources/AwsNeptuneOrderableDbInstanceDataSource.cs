using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_neptune_orderable_db_instance Terraform data source.
/// Retrieves information about a aws_neptune_orderable_db_instance.
/// </summary>
public partial class AwsNeptuneOrderableDbInstanceDataSource(string name) : TerraformDataSource("aws_neptune_orderable_db_instance", name)
{
    /// <summary>
    /// The engine attribute.
    /// </summary>
    public TerraformValue<string>? Engine
    {
        get => new TerraformReference<string>(this, "engine");
        set => SetArgument("engine", value);
    }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public TerraformValue<string> EngineVersion
    {
        get => new TerraformReference<string>(this, "engine_version");
        set => SetArgument("engine_version", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The instance_class attribute.
    /// </summary>
    public TerraformValue<string> InstanceClass
    {
        get => new TerraformReference<string>(this, "instance_class");
        set => SetArgument("instance_class", value);
    }

    /// <summary>
    /// The license_model attribute.
    /// </summary>
    public TerraformValue<string>? LicenseModel
    {
        get => new TerraformReference<string>(this, "license_model");
        set => SetArgument("license_model", value);
    }

    /// <summary>
    /// The preferred_instance_classes attribute.
    /// </summary>
    public TerraformList<string>? PreferredInstanceClasses
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "preferred_instance_classes").ResolveNodes(ctx));
        set => SetArgument("preferred_instance_classes", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The vpc attribute.
    /// </summary>
    public TerraformValue<bool> Vpc
    {
        get => new TerraformReference<bool>(this, "vpc");
        set => SetArgument("vpc", value);
    }

    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    public TerraformList<string> AvailabilityZones
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "availability_zones").ResolveNodes(ctx));
    }

    /// <summary>
    /// The max_iops_per_db_instance attribute.
    /// </summary>
    public TerraformValue<double> MaxIopsPerDbInstance
    {
        get => new TerraformReference<double>(this, "max_iops_per_db_instance");
    }

    /// <summary>
    /// The max_iops_per_gib attribute.
    /// </summary>
    public TerraformValue<double> MaxIopsPerGib
    {
        get => new TerraformReference<double>(this, "max_iops_per_gib");
    }

    /// <summary>
    /// The max_storage_size attribute.
    /// </summary>
    public TerraformValue<double> MaxStorageSize
    {
        get => new TerraformReference<double>(this, "max_storage_size");
    }

    /// <summary>
    /// The min_iops_per_db_instance attribute.
    /// </summary>
    public TerraformValue<double> MinIopsPerDbInstance
    {
        get => new TerraformReference<double>(this, "min_iops_per_db_instance");
    }

    /// <summary>
    /// The min_iops_per_gib attribute.
    /// </summary>
    public TerraformValue<double> MinIopsPerGib
    {
        get => new TerraformReference<double>(this, "min_iops_per_gib");
    }

    /// <summary>
    /// The min_storage_size attribute.
    /// </summary>
    public TerraformValue<double> MinStorageSize
    {
        get => new TerraformReference<double>(this, "min_storage_size");
    }

    /// <summary>
    /// The multi_az_capable attribute.
    /// </summary>
    public TerraformValue<bool> MultiAzCapable
    {
        get => new TerraformReference<bool>(this, "multi_az_capable");
    }

    /// <summary>
    /// The read_replica_capable attribute.
    /// </summary>
    public TerraformValue<bool> ReadReplicaCapable
    {
        get => new TerraformReference<bool>(this, "read_replica_capable");
    }

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    public TerraformValue<string> StorageType
    {
        get => new TerraformReference<string>(this, "storage_type");
    }

    /// <summary>
    /// The supports_enhanced_monitoring attribute.
    /// </summary>
    public TerraformValue<bool> SupportsEnhancedMonitoring
    {
        get => new TerraformReference<bool>(this, "supports_enhanced_monitoring");
    }

    /// <summary>
    /// The supports_iam_database_authentication attribute.
    /// </summary>
    public TerraformValue<bool> SupportsIamDatabaseAuthentication
    {
        get => new TerraformReference<bool>(this, "supports_iam_database_authentication");
    }

    /// <summary>
    /// The supports_iops attribute.
    /// </summary>
    public TerraformValue<bool> SupportsIops
    {
        get => new TerraformReference<bool>(this, "supports_iops");
    }

    /// <summary>
    /// The supports_performance_insights attribute.
    /// </summary>
    public TerraformValue<bool> SupportsPerformanceInsights
    {
        get => new TerraformReference<bool>(this, "supports_performance_insights");
    }

    /// <summary>
    /// The supports_storage_encryption attribute.
    /// </summary>
    public TerraformValue<bool> SupportsStorageEncryption
    {
        get => new TerraformReference<bool>(this, "supports_storage_encryption");
    }

}
