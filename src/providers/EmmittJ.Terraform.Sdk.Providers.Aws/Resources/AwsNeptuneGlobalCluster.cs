using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsNeptuneGlobalCluster.
/// Nesting mode: single
/// </summary>
public class AwsNeptuneGlobalClusterTimeoutsBlock : TerraformBlock
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
/// Represents a aws_neptune_global_cluster Terraform resource.
/// Manages a aws_neptune_global_cluster resource.
/// </summary>
public partial class AwsNeptuneGlobalCluster(string name) : TerraformResource("aws_neptune_global_cluster", name)
{
    /// <summary>
    /// The deletion_protection attribute.
    /// </summary>
    public TerraformValue<bool>? DeletionProtection
    {
        get => new TerraformReference<bool>(this, "deletion_protection");
        set => SetArgument("deletion_protection", value);
    }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    public TerraformValue<string> Engine
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
    /// The global_cluster_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GlobalClusterIdentifier is required")]
    public required TerraformValue<string> GlobalClusterIdentifier
    {
        get => new TerraformReference<string>(this, "global_cluster_identifier");
        set => SetArgument("global_cluster_identifier", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The source_db_cluster_identifier attribute.
    /// </summary>
    public TerraformValue<string> SourceDbClusterIdentifier
    {
        get => new TerraformReference<string>(this, "source_db_cluster_identifier");
        set => SetArgument("source_db_cluster_identifier", value);
    }

    /// <summary>
    /// The storage_encrypted attribute.
    /// </summary>
    public TerraformValue<bool> StorageEncrypted
    {
        get => new TerraformReference<bool>(this, "storage_encrypted");
        set => SetArgument("storage_encrypted", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The global_cluster_members attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> GlobalClusterMembers
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "global_cluster_members").ResolveNodes(ctx));
    }

    /// <summary>
    /// The global_cluster_resource_id attribute.
    /// </summary>
    public TerraformValue<string> GlobalClusterResourceId
    {
        get => new TerraformReference<string>(this, "global_cluster_resource_id");
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsNeptuneGlobalClusterTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsNeptuneGlobalClusterTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
