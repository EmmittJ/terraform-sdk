using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsElasticacheGlobalReplicationGroupTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_elasticache_global_replication_group resource.
/// </summary>
public class AwsElasticacheGlobalReplicationGroup : TerraformResource
{
    public AwsElasticacheGlobalReplicationGroup(string name) : base("aws_elasticache_global_replication_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("at_rest_encryption_enabled");
        SetOutput("auth_token_enabled");
        SetOutput("cluster_enabled");
        SetOutput("engine_version_actual");
        SetOutput("global_node_groups");
        SetOutput("global_replication_group_id");
        SetOutput("transit_encryption_enabled");
        SetOutput("automatic_failover_enabled");
        SetOutput("cache_node_type");
        SetOutput("engine");
        SetOutput("engine_version");
        SetOutput("global_replication_group_description");
        SetOutput("global_replication_group_id_suffix");
        SetOutput("id");
        SetOutput("num_node_groups");
        SetOutput("parameter_group_name");
        SetOutput("primary_replication_group_id");
        SetOutput("region");
    }

    /// <summary>
    /// The automatic_failover_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> AutomaticFailoverEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("automatic_failover_enabled");
        set => SetProperty("automatic_failover_enabled", value);
    }

    /// <summary>
    /// The cache_node_type attribute.
    /// </summary>
    public TerraformProperty<string> CacheNodeType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cache_node_type");
        set => SetProperty("cache_node_type", value);
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
    /// The global_replication_group_description attribute.
    /// </summary>
    public TerraformProperty<string> GlobalReplicationGroupDescription
    {
        get => GetRequiredOutput<TerraformProperty<string>>("global_replication_group_description");
        set => SetProperty("global_replication_group_description", value);
    }

    /// <summary>
    /// The global_replication_group_id_suffix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GlobalReplicationGroupIdSuffix is required")]
    public required TerraformProperty<string> GlobalReplicationGroupIdSuffix
    {
        get => GetRequiredOutput<TerraformProperty<string>>("global_replication_group_id_suffix");
        set => SetProperty("global_replication_group_id_suffix", value);
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
    /// The num_node_groups attribute.
    /// </summary>
    public TerraformProperty<double> NumNodeGroups
    {
        get => GetRequiredOutput<TerraformProperty<double>>("num_node_groups");
        set => SetProperty("num_node_groups", value);
    }

    /// <summary>
    /// The parameter_group_name attribute.
    /// </summary>
    public TerraformProperty<string> ParameterGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("parameter_group_name");
        set => SetProperty("parameter_group_name", value);
    }

    /// <summary>
    /// The primary_replication_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrimaryReplicationGroupId is required")]
    public required TerraformProperty<string> PrimaryReplicationGroupId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("primary_replication_group_id");
        set => SetProperty("primary_replication_group_id", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsElasticacheGlobalReplicationGroupTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The at_rest_encryption_enabled attribute.
    /// </summary>
    public TerraformExpression AtRestEncryptionEnabled => this["at_rest_encryption_enabled"];

    /// <summary>
    /// The auth_token_enabled attribute.
    /// </summary>
    public TerraformExpression AuthTokenEnabled => this["auth_token_enabled"];

    /// <summary>
    /// The cluster_enabled attribute.
    /// </summary>
    public TerraformExpression ClusterEnabled => this["cluster_enabled"];

    /// <summary>
    /// The engine_version_actual attribute.
    /// </summary>
    public TerraformExpression EngineVersionActual => this["engine_version_actual"];

    /// <summary>
    /// The global_node_groups attribute.
    /// </summary>
    public TerraformExpression GlobalNodeGroups => this["global_node_groups"];

    /// <summary>
    /// The global_replication_group_id attribute.
    /// </summary>
    public TerraformExpression GlobalReplicationGroupId => this["global_replication_group_id"];

    /// <summary>
    /// The transit_encryption_enabled attribute.
    /// </summary>
    public TerraformExpression TransitEncryptionEnabled => this["transit_encryption_enabled"];

}
