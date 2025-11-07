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
    public TerraformProperty<bool>? AutomaticFailoverEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("automatic_failover_enabled");
        set => this.WithProperty("automatic_failover_enabled", value);
    }

    /// <summary>
    /// The cache_node_type attribute.
    /// </summary>
    public TerraformProperty<string>? CacheNodeType
    {
        get => GetProperty<TerraformProperty<string>>("cache_node_type");
        set => this.WithProperty("cache_node_type", value);
    }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    public TerraformProperty<string>? Engine
    {
        get => GetProperty<TerraformProperty<string>>("engine");
        set => this.WithProperty("engine", value);
    }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public TerraformProperty<string>? EngineVersion
    {
        get => GetProperty<TerraformProperty<string>>("engine_version");
        set => this.WithProperty("engine_version", value);
    }

    /// <summary>
    /// The global_replication_group_description attribute.
    /// </summary>
    public TerraformProperty<string>? GlobalReplicationGroupDescription
    {
        get => GetProperty<TerraformProperty<string>>("global_replication_group_description");
        set => this.WithProperty("global_replication_group_description", value);
    }

    /// <summary>
    /// The global_replication_group_id_suffix attribute.
    /// </summary>
    public TerraformProperty<string>? GlobalReplicationGroupIdSuffix
    {
        get => GetProperty<TerraformProperty<string>>("global_replication_group_id_suffix");
        set => this.WithProperty("global_replication_group_id_suffix", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The num_node_groups attribute.
    /// </summary>
    public TerraformProperty<double>? NumNodeGroups
    {
        get => GetProperty<TerraformProperty<double>>("num_node_groups");
        set => this.WithProperty("num_node_groups", value);
    }

    /// <summary>
    /// The parameter_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ParameterGroupName
    {
        get => GetProperty<TerraformProperty<string>>("parameter_group_name");
        set => this.WithProperty("parameter_group_name", value);
    }

    /// <summary>
    /// The primary_replication_group_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrimaryReplicationGroupId
    {
        get => GetProperty<TerraformProperty<string>>("primary_replication_group_id");
        set => this.WithProperty("primary_replication_group_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
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
