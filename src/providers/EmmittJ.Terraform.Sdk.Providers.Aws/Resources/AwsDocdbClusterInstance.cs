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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
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
        get => new TerraformReference<bool>(this, "apply_immediately");
        set => SetArgument("apply_immediately", value);
    }

    /// <summary>
    /// The auto_minor_version_upgrade attribute.
    /// </summary>
    public TerraformValue<bool>? AutoMinorVersionUpgrade
    {
        get => new TerraformReference<bool>(this, "auto_minor_version_upgrade");
        set => SetArgument("auto_minor_version_upgrade", value);
    }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformValue<string> AvailabilityZone
    {
        get => new TerraformReference<string>(this, "availability_zone");
        set => SetArgument("availability_zone", value);
    }

    /// <summary>
    /// The ca_cert_identifier attribute.
    /// </summary>
    public TerraformValue<string> CaCertIdentifier
    {
        get => new TerraformReference<string>(this, "ca_cert_identifier");
        set => SetArgument("ca_cert_identifier", value);
    }

    /// <summary>
    /// The cluster_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterIdentifier is required")]
    public required TerraformValue<string> ClusterIdentifier
    {
        get => new TerraformReference<string>(this, "cluster_identifier");
        set => SetArgument("cluster_identifier", value);
    }

    /// <summary>
    /// The copy_tags_to_snapshot attribute.
    /// </summary>
    public TerraformValue<bool>? CopyTagsToSnapshot
    {
        get => new TerraformReference<bool>(this, "copy_tags_to_snapshot");
        set => SetArgument("copy_tags_to_snapshot", value);
    }

    /// <summary>
    /// The enable_performance_insights attribute.
    /// </summary>
    public TerraformValue<bool>? EnablePerformanceInsights
    {
        get => new TerraformReference<bool>(this, "enable_performance_insights");
        set => SetArgument("enable_performance_insights", value);
    }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    public TerraformValue<string>? Engine
    {
        get => new TerraformReference<string>(this, "engine");
        set => SetArgument("engine", value);
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
    /// The identifier attribute.
    /// </summary>
    public TerraformValue<string> Identifier
    {
        get => new TerraformReference<string>(this, "identifier");
        set => SetArgument("identifier", value);
    }

    /// <summary>
    /// The identifier_prefix attribute.
    /// </summary>
    public TerraformValue<string> IdentifierPrefix
    {
        get => new TerraformReference<string>(this, "identifier_prefix");
        set => SetArgument("identifier_prefix", value);
    }

    /// <summary>
    /// The instance_class attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceClass is required")]
    public required TerraformValue<string> InstanceClass
    {
        get => new TerraformReference<string>(this, "instance_class");
        set => SetArgument("instance_class", value);
    }

    /// <summary>
    /// The performance_insights_kms_key_id attribute.
    /// </summary>
    public TerraformValue<string> PerformanceInsightsKmsKeyId
    {
        get => new TerraformReference<string>(this, "performance_insights_kms_key_id");
        set => SetArgument("performance_insights_kms_key_id", value);
    }

    /// <summary>
    /// The preferred_maintenance_window attribute.
    /// </summary>
    public TerraformValue<string> PreferredMaintenanceWindow
    {
        get => new TerraformReference<string>(this, "preferred_maintenance_window");
        set => SetArgument("preferred_maintenance_window", value);
    }

    /// <summary>
    /// The promotion_tier attribute.
    /// </summary>
    public TerraformValue<double>? PromotionTier
    {
        get => new TerraformReference<double>(this, "promotion_tier");
        set => SetArgument("promotion_tier", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The db_subnet_group_name attribute.
    /// </summary>
    public TerraformValue<string> DbSubnetGroupName
    {
        get => new TerraformReference<string>(this, "db_subnet_group_name");
    }

    /// <summary>
    /// The dbi_resource_id attribute.
    /// </summary>
    public TerraformValue<string> DbiResourceId
    {
        get => new TerraformReference<string>(this, "dbi_resource_id");
    }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformValue<string> Endpoint
    {
        get => new TerraformReference<string>(this, "endpoint");
    }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public TerraformValue<string> EngineVersion
    {
        get => new TerraformReference<string>(this, "engine_version");
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string> KmsKeyId
    {
        get => new TerraformReference<string>(this, "kms_key_id");
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double> Port
    {
        get => new TerraformReference<double>(this, "port");
    }

    /// <summary>
    /// The preferred_backup_window attribute.
    /// </summary>
    public TerraformValue<string> PreferredBackupWindow
    {
        get => new TerraformReference<string>(this, "preferred_backup_window");
    }

    /// <summary>
    /// The publicly_accessible attribute.
    /// </summary>
    public TerraformValue<bool> PubliclyAccessible
    {
        get => new TerraformReference<bool>(this, "publicly_accessible");
    }

    /// <summary>
    /// The storage_encrypted attribute.
    /// </summary>
    public TerraformValue<bool> StorageEncrypted
    {
        get => new TerraformReference<bool>(this, "storage_encrypted");
    }

    /// <summary>
    /// The writer attribute.
    /// </summary>
    public TerraformValue<bool> Writer
    {
        get => new TerraformReference<bool>(this, "writer");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsDocdbClusterInstanceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsDocdbClusterInstanceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
