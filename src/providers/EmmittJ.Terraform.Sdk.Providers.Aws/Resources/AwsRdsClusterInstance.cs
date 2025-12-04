using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsRdsClusterInstance.
/// Nesting mode: single
/// </summary>
public class AwsRdsClusterInstanceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_rds_cluster_instance Terraform resource.
/// Manages a aws_rds_cluster_instance resource.
/// </summary>
public partial class AwsRdsClusterInstance(string name) : TerraformResource("aws_rds_cluster_instance", name)
{
    /// <summary>
    /// The apply_immediately attribute.
    /// </summary>
    public TerraformValue<bool> ApplyImmediately
    {
        get => GetArgument<TerraformValue<bool>>("apply_immediately") ?? AsReference("apply_immediately");
        set => SetArgument("apply_immediately", value);
    }

    /// <summary>
    /// The auto_minor_version_upgrade attribute.
    /// </summary>
    public TerraformValue<bool>? AutoMinorVersionUpgrade
    {
        get => GetArgument<TerraformValue<bool>>("auto_minor_version_upgrade");
        set => SetArgument("auto_minor_version_upgrade", value);
    }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformValue<string> AvailabilityZone
    {
        get => GetArgument<TerraformValue<string>>("availability_zone") ?? AsReference("availability_zone");
        set => SetArgument("availability_zone", value);
    }

    /// <summary>
    /// The ca_cert_identifier attribute.
    /// </summary>
    public TerraformValue<string> CaCertIdentifier
    {
        get => GetArgument<TerraformValue<string>>("ca_cert_identifier") ?? AsReference("ca_cert_identifier");
        set => SetArgument("ca_cert_identifier", value);
    }

    /// <summary>
    /// The cluster_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterIdentifier is required")]
    public required TerraformValue<string> ClusterIdentifier
    {
        get => GetRequiredArgument<TerraformValue<string>>("cluster_identifier");
        set => SetArgument("cluster_identifier", value);
    }

    /// <summary>
    /// The copy_tags_to_snapshot attribute.
    /// </summary>
    public TerraformValue<bool>? CopyTagsToSnapshot
    {
        get => GetArgument<TerraformValue<bool>>("copy_tags_to_snapshot");
        set => SetArgument("copy_tags_to_snapshot", value);
    }

    /// <summary>
    /// The custom_iam_instance_profile attribute.
    /// </summary>
    public TerraformValue<string>? CustomIamInstanceProfile
    {
        get => GetArgument<TerraformValue<string>>("custom_iam_instance_profile");
        set => SetArgument("custom_iam_instance_profile", value);
    }

    /// <summary>
    /// The db_parameter_group_name attribute.
    /// </summary>
    public TerraformValue<string> DbParameterGroupName
    {
        get => GetArgument<TerraformValue<string>>("db_parameter_group_name") ?? AsReference("db_parameter_group_name");
        set => SetArgument("db_parameter_group_name", value);
    }

    /// <summary>
    /// The db_subnet_group_name attribute.
    /// </summary>
    public TerraformValue<string> DbSubnetGroupName
    {
        get => GetArgument<TerraformValue<string>>("db_subnet_group_name") ?? AsReference("db_subnet_group_name");
        set => SetArgument("db_subnet_group_name", value);
    }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Engine is required")]
    public required TerraformValue<string> Engine
    {
        get => GetRequiredArgument<TerraformValue<string>>("engine");
        set => SetArgument("engine", value);
    }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public TerraformValue<string> EngineVersion
    {
        get => GetArgument<TerraformValue<string>>("engine_version") ?? AsReference("engine_version");
        set => SetArgument("engine_version", value);
    }

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    public TerraformValue<bool>? ForceDestroy
    {
        get => GetArgument<TerraformValue<bool>>("force_destroy");
        set => SetArgument("force_destroy", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The identifier attribute.
    /// </summary>
    public TerraformValue<string> Identifier
    {
        get => GetArgument<TerraformValue<string>>("identifier") ?? AsReference("identifier");
        set => SetArgument("identifier", value);
    }

    /// <summary>
    /// The identifier_prefix attribute.
    /// </summary>
    public TerraformValue<string> IdentifierPrefix
    {
        get => GetArgument<TerraformValue<string>>("identifier_prefix") ?? AsReference("identifier_prefix");
        set => SetArgument("identifier_prefix", value);
    }

    /// <summary>
    /// The instance_class attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceClass is required")]
    public required TerraformValue<string> InstanceClass
    {
        get => GetRequiredArgument<TerraformValue<string>>("instance_class");
        set => SetArgument("instance_class", value);
    }

    /// <summary>
    /// The monitoring_interval attribute.
    /// </summary>
    public TerraformValue<double>? MonitoringInterval
    {
        get => GetArgument<TerraformValue<double>>("monitoring_interval");
        set => SetArgument("monitoring_interval", value);
    }

    /// <summary>
    /// The monitoring_role_arn attribute.
    /// </summary>
    public TerraformValue<string> MonitoringRoleArn
    {
        get => GetArgument<TerraformValue<string>>("monitoring_role_arn") ?? AsReference("monitoring_role_arn");
        set => SetArgument("monitoring_role_arn", value);
    }

    /// <summary>
    /// The performance_insights_enabled attribute.
    /// </summary>
    public TerraformValue<bool> PerformanceInsightsEnabled
    {
        get => GetArgument<TerraformValue<bool>>("performance_insights_enabled") ?? AsReference("performance_insights_enabled");
        set => SetArgument("performance_insights_enabled", value);
    }

    /// <summary>
    /// The performance_insights_kms_key_id attribute.
    /// </summary>
    public TerraformValue<string> PerformanceInsightsKmsKeyId
    {
        get => GetArgument<TerraformValue<string>>("performance_insights_kms_key_id") ?? AsReference("performance_insights_kms_key_id");
        set => SetArgument("performance_insights_kms_key_id", value);
    }

    /// <summary>
    /// The performance_insights_retention_period attribute.
    /// </summary>
    public TerraformValue<double> PerformanceInsightsRetentionPeriod
    {
        get => GetArgument<TerraformValue<double>>("performance_insights_retention_period") ?? AsReference("performance_insights_retention_period");
        set => SetArgument("performance_insights_retention_period", value);
    }

    /// <summary>
    /// The preferred_backup_window attribute.
    /// </summary>
    public TerraformValue<string> PreferredBackupWindow
    {
        get => GetArgument<TerraformValue<string>>("preferred_backup_window") ?? AsReference("preferred_backup_window");
        set => SetArgument("preferred_backup_window", value);
    }

    /// <summary>
    /// The preferred_maintenance_window attribute.
    /// </summary>
    public TerraformValue<string> PreferredMaintenanceWindow
    {
        get => GetArgument<TerraformValue<string>>("preferred_maintenance_window") ?? AsReference("preferred_maintenance_window");
        set => SetArgument("preferred_maintenance_window", value);
    }

    /// <summary>
    /// The promotion_tier attribute.
    /// </summary>
    public TerraformValue<double>? PromotionTier
    {
        get => GetArgument<TerraformValue<double>>("promotion_tier");
        set => SetArgument("promotion_tier", value);
    }

    /// <summary>
    /// The publicly_accessible attribute.
    /// </summary>
    public TerraformValue<bool> PubliclyAccessible
    {
        get => GetArgument<TerraformValue<bool>>("publicly_accessible") ?? AsReference("publicly_accessible");
        set => SetArgument("publicly_accessible", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? AsReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The dbi_resource_id attribute.
    /// </summary>
    public TerraformValue<string> DbiResourceId
        => AsReference("dbi_resource_id");

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformValue<string> Endpoint
        => AsReference("endpoint");

    /// <summary>
    /// The engine_version_actual attribute.
    /// </summary>
    public TerraformValue<string> EngineVersionActual
        => AsReference("engine_version_actual");

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string> KmsKeyId
        => AsReference("kms_key_id");

    /// <summary>
    /// The network_type attribute.
    /// </summary>
    public TerraformValue<string> NetworkType
        => AsReference("network_type");

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double> Port
        => AsReference("port");

    /// <summary>
    /// The storage_encrypted attribute.
    /// </summary>
    public TerraformValue<bool> StorageEncrypted
        => AsReference("storage_encrypted");

    /// <summary>
    /// The writer attribute.
    /// </summary>
    public TerraformValue<bool> Writer
        => AsReference("writer");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsRdsClusterInstanceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsRdsClusterInstanceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
