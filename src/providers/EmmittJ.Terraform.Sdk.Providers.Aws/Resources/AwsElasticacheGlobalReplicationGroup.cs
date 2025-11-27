using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsElasticacheGlobalReplicationGroup.
/// Nesting mode: single
/// </summary>
public class AwsElasticacheGlobalReplicationGroupTimeoutsBlock : TerraformBlock
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
/// Represents a aws_elasticache_global_replication_group Terraform resource.
/// Manages a aws_elasticache_global_replication_group resource.
/// </summary>
public partial class AwsElasticacheGlobalReplicationGroup(string name) : TerraformResource("aws_elasticache_global_replication_group", name)
{
    /// <summary>
    /// The automatic_failover_enabled attribute.
    /// </summary>
    public TerraformValue<bool> AutomaticFailoverEnabled
    {
        get => new TerraformReference<bool>(this, "automatic_failover_enabled");
        set => SetArgument("automatic_failover_enabled", value);
    }

    /// <summary>
    /// The cache_node_type attribute.
    /// </summary>
    public TerraformValue<string> CacheNodeType
    {
        get => new TerraformReference<string>(this, "cache_node_type");
        set => SetArgument("cache_node_type", value);
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
    /// The global_replication_group_description attribute.
    /// </summary>
    public TerraformValue<string>? GlobalReplicationGroupDescription
    {
        get => new TerraformReference<string>(this, "global_replication_group_description");
        set => SetArgument("global_replication_group_description", value);
    }

    /// <summary>
    /// The global_replication_group_id_suffix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GlobalReplicationGroupIdSuffix is required")]
    public required TerraformValue<string> GlobalReplicationGroupIdSuffix
    {
        get => new TerraformReference<string>(this, "global_replication_group_id_suffix");
        set => SetArgument("global_replication_group_id_suffix", value);
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
    /// The num_node_groups attribute.
    /// </summary>
    public TerraformValue<double> NumNodeGroups
    {
        get => new TerraformReference<double>(this, "num_node_groups");
        set => SetArgument("num_node_groups", value);
    }

    /// <summary>
    /// The parameter_group_name attribute.
    /// </summary>
    public TerraformValue<string>? ParameterGroupName
    {
        get => new TerraformReference<string>(this, "parameter_group_name");
        set => SetArgument("parameter_group_name", value);
    }

    /// <summary>
    /// The primary_replication_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrimaryReplicationGroupId is required")]
    public required TerraformValue<string> PrimaryReplicationGroupId
    {
        get => new TerraformReference<string>(this, "primary_replication_group_id");
        set => SetArgument("primary_replication_group_id", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The at_rest_encryption_enabled attribute.
    /// </summary>
    public TerraformValue<bool> AtRestEncryptionEnabled
    {
        get => new TerraformReference<bool>(this, "at_rest_encryption_enabled");
    }

    /// <summary>
    /// The auth_token_enabled attribute.
    /// </summary>
    public TerraformValue<bool> AuthTokenEnabled
    {
        get => new TerraformReference<bool>(this, "auth_token_enabled");
    }

    /// <summary>
    /// The cluster_enabled attribute.
    /// </summary>
    public TerraformValue<bool> ClusterEnabled
    {
        get => new TerraformReference<bool>(this, "cluster_enabled");
    }

    /// <summary>
    /// The engine_version_actual attribute.
    /// </summary>
    public TerraformValue<string> EngineVersionActual
    {
        get => new TerraformReference<string>(this, "engine_version_actual");
    }

    /// <summary>
    /// The global_node_groups attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> GlobalNodeGroups
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "global_node_groups").ResolveNodes(ctx));
    }

    /// <summary>
    /// The global_replication_group_id attribute.
    /// </summary>
    public TerraformValue<string> GlobalReplicationGroupId
    {
        get => new TerraformReference<string>(this, "global_replication_group_id");
    }

    /// <summary>
    /// The transit_encryption_enabled attribute.
    /// </summary>
    public TerraformValue<bool> TransitEncryptionEnabled
    {
        get => new TerraformReference<bool>(this, "transit_encryption_enabled");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsElasticacheGlobalReplicationGroupTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsElasticacheGlobalReplicationGroupTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
