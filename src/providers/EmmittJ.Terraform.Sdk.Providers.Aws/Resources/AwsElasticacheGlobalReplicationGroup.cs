using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsElasticacheGlobalReplicationGroupTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a aws_elasticache_global_replication_group resource.
/// </summary>
public class AwsElasticacheGlobalReplicationGroup : TerraformResource
{
    public AwsElasticacheGlobalReplicationGroup(string name) : base("aws_elasticache_global_replication_group", name)
    {
    }

    /// <summary>
    /// The automatic_failover_enabled attribute.
    /// </summary>
    [TerraformPropertyName("automatic_failover_enabled")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> AutomaticFailoverEnabled { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "automatic_failover_enabled");

    /// <summary>
    /// The cache_node_type attribute.
    /// </summary>
    [TerraformPropertyName("cache_node_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> CacheNodeType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "cache_node_type");

    /// <summary>
    /// The engine attribute.
    /// </summary>
    [TerraformPropertyName("engine")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Engine { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "engine");

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    [TerraformPropertyName("engine_version")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> EngineVersion { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "engine_version");

    /// <summary>
    /// The global_replication_group_description attribute.
    /// </summary>
    [TerraformPropertyName("global_replication_group_description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? GlobalReplicationGroupDescription { get; set; }

    /// <summary>
    /// The global_replication_group_id_suffix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GlobalReplicationGroupIdSuffix is required")]
    [TerraformPropertyName("global_replication_group_id_suffix")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> GlobalReplicationGroupIdSuffix { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The num_node_groups attribute.
    /// </summary>
    [TerraformPropertyName("num_node_groups")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> NumNodeGroups { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "num_node_groups");

    /// <summary>
    /// The parameter_group_name attribute.
    /// </summary>
    [TerraformPropertyName("parameter_group_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ParameterGroupName { get; set; }

    /// <summary>
    /// The primary_replication_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrimaryReplicationGroupId is required")]
    [TerraformPropertyName("primary_replication_group_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> PrimaryReplicationGroupId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsElasticacheGlobalReplicationGroupTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The at_rest_encryption_enabled attribute.
    /// </summary>
    [TerraformPropertyName("at_rest_encryption_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> AtRestEncryptionEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "at_rest_encryption_enabled");

    /// <summary>
    /// The auth_token_enabled attribute.
    /// </summary>
    [TerraformPropertyName("auth_token_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> AuthTokenEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "auth_token_enabled");

    /// <summary>
    /// The cluster_enabled attribute.
    /// </summary>
    [TerraformPropertyName("cluster_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> ClusterEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "cluster_enabled");

    /// <summary>
    /// The engine_version_actual attribute.
    /// </summary>
    [TerraformPropertyName("engine_version_actual")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EngineVersionActual => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "engine_version_actual");

    /// <summary>
    /// The global_node_groups attribute.
    /// </summary>
    [TerraformPropertyName("global_node_groups")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> GlobalNodeGroups => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "global_node_groups");

    /// <summary>
    /// The global_replication_group_id attribute.
    /// </summary>
    [TerraformPropertyName("global_replication_group_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> GlobalReplicationGroupId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "global_replication_group_id");

    /// <summary>
    /// The transit_encryption_enabled attribute.
    /// </summary>
    [TerraformPropertyName("transit_encryption_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> TransitEncryptionEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "transit_encryption_enabled");

}
