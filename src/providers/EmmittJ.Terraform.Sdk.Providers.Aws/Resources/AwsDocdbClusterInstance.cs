using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsDocdbClusterInstance.
/// Nesting mode: single
/// </summary>
public class AwsDocdbClusterInstanceTimeoutsBlock : TerraformBlock
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
/// Represents a aws_docdb_cluster_instance Terraform resource.
/// Manages a aws_docdb_cluster_instance resource.
/// </summary>
public partial class AwsDocdbClusterInstance(string name) : TerraformResource("aws_docdb_cluster_instance", name)
{
    /// <summary>
    /// The apply_immediately attribute.
    /// </summary>
    public TerraformValue<bool>? ApplyImmediately
    {
        get => GetArgument<TerraformValue<bool>>("apply_immediately");
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
    public TerraformValue<string>? AvailabilityZone
    {
        get => GetArgument<TerraformValue<string>>("availability_zone");
        set => SetArgument("availability_zone", value);
    }

    /// <summary>
    /// The ca_cert_identifier attribute.
    /// </summary>
    public TerraformValue<string>? CaCertIdentifier
    {
        get => GetArgument<TerraformValue<string>>("ca_cert_identifier");
        set => SetArgument("ca_cert_identifier", value);
    }

    /// <summary>
    /// The cluster_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterIdentifier is required")]
    public required TerraformValue<string> ClusterIdentifier
    {
        get => GetArgument<TerraformValue<string>>("cluster_identifier");
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
    /// The enable_performance_insights attribute.
    /// </summary>
    public TerraformValue<bool>? EnablePerformanceInsights
    {
        get => GetArgument<TerraformValue<bool>>("enable_performance_insights");
        set => SetArgument("enable_performance_insights", value);
    }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    public TerraformValue<string>? Engine
    {
        get => GetArgument<TerraformValue<string>>("engine");
        set => SetArgument("engine", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The identifier attribute.
    /// </summary>
    public TerraformValue<string>? Identifier
    {
        get => GetArgument<TerraformValue<string>>("identifier");
        set => SetArgument("identifier", value);
    }

    /// <summary>
    /// The identifier_prefix attribute.
    /// </summary>
    public TerraformValue<string>? IdentifierPrefix
    {
        get => GetArgument<TerraformValue<string>>("identifier_prefix");
        set => SetArgument("identifier_prefix", value);
    }

    /// <summary>
    /// The instance_class attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceClass is required")]
    public required TerraformValue<string> InstanceClass
    {
        get => GetArgument<TerraformValue<string>>("instance_class");
        set => SetArgument("instance_class", value);
    }

    /// <summary>
    /// The performance_insights_kms_key_id attribute.
    /// </summary>
    public TerraformValue<string>? PerformanceInsightsKmsKeyId
    {
        get => GetArgument<TerraformValue<string>>("performance_insights_kms_key_id");
        set => SetArgument("performance_insights_kms_key_id", value);
    }

    /// <summary>
    /// The preferred_maintenance_window attribute.
    /// </summary>
    public TerraformValue<string>? PreferredMaintenanceWindow
    {
        get => GetArgument<TerraformValue<string>>("preferred_maintenance_window");
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
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
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The db_subnet_group_name attribute.
    /// </summary>
    public TerraformValue<string> DbSubnetGroupName
        => AsReference("db_subnet_group_name");

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
    /// The engine_version attribute.
    /// </summary>
    public TerraformValue<string> EngineVersion
        => AsReference("engine_version");

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string> KmsKeyId
        => AsReference("kms_key_id");

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double> Port
        => AsReference("port");

    /// <summary>
    /// The preferred_backup_window attribute.
    /// </summary>
    public TerraformValue<string> PreferredBackupWindow
        => AsReference("preferred_backup_window");

    /// <summary>
    /// The publicly_accessible attribute.
    /// </summary>
    public TerraformValue<bool> PubliclyAccessible
        => AsReference("publicly_accessible");

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
    public AwsDocdbClusterInstanceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsDocdbClusterInstanceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
