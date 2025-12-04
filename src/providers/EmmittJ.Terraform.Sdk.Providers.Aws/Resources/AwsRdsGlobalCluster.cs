using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsRdsGlobalCluster.
/// Nesting mode: single
/// </summary>
public class AwsRdsGlobalClusterTimeoutsBlock : TerraformBlock
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
/// Represents a aws_rds_global_cluster Terraform resource.
/// Manages a aws_rds_global_cluster resource.
/// </summary>
public partial class AwsRdsGlobalCluster(string name) : TerraformResource("aws_rds_global_cluster", name)
{
    /// <summary>
    /// The database_name attribute.
    /// </summary>
    public TerraformValue<string>? DatabaseName
    {
        get => GetArgument<TerraformValue<string>>("database_name");
        set => SetArgument("database_name", value);
    }

    /// <summary>
    /// The deletion_protection attribute.
    /// </summary>
    public TerraformValue<bool>? DeletionProtection
    {
        get => GetArgument<TerraformValue<bool>>("deletion_protection");
        set => SetArgument("deletion_protection", value);
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
    /// The engine_lifecycle_support attribute.
    /// </summary>
    public TerraformValue<string>? EngineLifecycleSupport
    {
        get => GetArgument<TerraformValue<string>>("engine_lifecycle_support");
        set => SetArgument("engine_lifecycle_support", value);
    }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public TerraformValue<string>? EngineVersion
    {
        get => GetArgument<TerraformValue<string>>("engine_version");
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
    /// The global_cluster_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GlobalClusterIdentifier is required")]
    public required TerraformValue<string> GlobalClusterIdentifier
    {
        get => GetArgument<TerraformValue<string>>("global_cluster_identifier");
        set => SetArgument("global_cluster_identifier", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The source_db_cluster_identifier attribute.
    /// </summary>
    public TerraformValue<string>? SourceDbClusterIdentifier
    {
        get => GetArgument<TerraformValue<string>>("source_db_cluster_identifier");
        set => SetArgument("source_db_cluster_identifier", value);
    }

    /// <summary>
    /// The storage_encrypted attribute.
    /// </summary>
    public TerraformValue<bool>? StorageEncrypted
    {
        get => GetArgument<TerraformValue<bool>>("storage_encrypted");
        set => SetArgument("storage_encrypted", value);
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
    /// The global_cluster_members attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> GlobalClusterMembers
        => AsReference("global_cluster_members");

    /// <summary>
    /// The global_cluster_resource_id attribute.
    /// </summary>
    public TerraformValue<string> GlobalClusterResourceId
        => AsReference("global_cluster_resource_id");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsRdsGlobalClusterTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsRdsGlobalClusterTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
