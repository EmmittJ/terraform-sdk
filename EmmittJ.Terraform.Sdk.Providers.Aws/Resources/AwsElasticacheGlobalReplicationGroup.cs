using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
        this.DeclareOutput("arn");
        this.DeclareOutput("at_rest_encryption_enabled");
        this.DeclareOutput("auth_token_enabled");
        this.DeclareOutput("cluster_enabled");
        this.DeclareOutput("engine");
        this.DeclareOutput("engine_version_actual");
        this.DeclareOutput("global_node_groups");
        this.DeclareOutput("global_replication_group_id");
        this.DeclareOutput("transit_encryption_enabled");
    }

    /// <summary>
    /// The automatic_failover_enabled attribute.
    /// </summary>
    public bool? AutomaticFailoverEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("automatic_failover_enabled")?.Value;
        set => this.WithProperty("automatic_failover_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The cache_node_type attribute.
    /// </summary>
    public string? CacheNodeType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cache_node_type")?.Value;
        set => this.WithProperty("cache_node_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public string? EngineVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("engine_version")?.Value;
        set => this.WithProperty("engine_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The global_replication_group_description attribute.
    /// </summary>
    public string? GlobalReplicationGroupDescription
    {
        get => GetProperty<TerraformLiteralProperty<string>>("global_replication_group_description")?.Value;
        set => this.WithProperty("global_replication_group_description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The global_replication_group_id_suffix attribute.
    /// </summary>
    public string? GlobalReplicationGroupIdSuffix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("global_replication_group_id_suffix")?.Value;
        set => this.WithProperty("global_replication_group_id_suffix", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The num_node_groups attribute.
    /// </summary>
    public double? NumNodeGroups
    {
        get => GetProperty<TerraformLiteralProperty<double>>("num_node_groups")?.Value;
        set => this.WithProperty("num_node_groups", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The parameter_group_name attribute.
    /// </summary>
    public string? ParameterGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("parameter_group_name")?.Value;
        set => this.WithProperty("parameter_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The primary_replication_group_id attribute.
    /// </summary>
    public string? PrimaryReplicationGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("primary_replication_group_id")?.Value;
        set => this.WithProperty("primary_replication_group_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The engine attribute.
    /// </summary>
    public TerraformExpression Engine => this["engine"];

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
