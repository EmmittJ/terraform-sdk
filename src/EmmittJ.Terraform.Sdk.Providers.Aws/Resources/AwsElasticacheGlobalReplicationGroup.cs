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
        this.DeclareOutput("engine_version_actual");
        this.DeclareOutput("global_node_groups");
        this.DeclareOutput("global_replication_group_id");
        this.DeclareOutput("transit_encryption_enabled");
    }

    /// <summary>
    /// The automatic_failover_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? AutomaticFailoverEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("automatic_failover_enabled");
        set => this.WithProperty("automatic_failover_enabled", value);
    }

    /// <summary>
    /// The cache_node_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CacheNodeType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cache_node_type");
        set => this.WithProperty("cache_node_type", value);
    }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Engine
    {
        get => GetProperty<TerraformLiteralProperty<string>>("engine");
        set => this.WithProperty("engine", value);
    }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EngineVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("engine_version");
        set => this.WithProperty("engine_version", value);
    }

    /// <summary>
    /// The global_replication_group_description attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? GlobalReplicationGroupDescription
    {
        get => GetProperty<TerraformLiteralProperty<string>>("global_replication_group_description");
        set => this.WithProperty("global_replication_group_description", value);
    }

    /// <summary>
    /// The global_replication_group_id_suffix attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? GlobalReplicationGroupIdSuffix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("global_replication_group_id_suffix");
        set => this.WithProperty("global_replication_group_id_suffix", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The num_node_groups attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? NumNodeGroups
    {
        get => GetProperty<TerraformLiteralProperty<double>>("num_node_groups");
        set => this.WithProperty("num_node_groups", value);
    }

    /// <summary>
    /// The parameter_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ParameterGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("parameter_group_name");
        set => this.WithProperty("parameter_group_name", value);
    }

    /// <summary>
    /// The primary_replication_group_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PrimaryReplicationGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("primary_replication_group_id");
        set => this.WithProperty("primary_replication_group_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
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
