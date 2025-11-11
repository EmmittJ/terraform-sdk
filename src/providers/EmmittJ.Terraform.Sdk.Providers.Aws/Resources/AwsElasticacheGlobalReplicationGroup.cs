using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsElasticacheGlobalReplicationGroupTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

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
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> AutomaticFailoverEnabled { get; set; } = default!;

    /// <summary>
    /// The cache_node_type attribute.
    /// </summary>
    [TerraformPropertyName("cache_node_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> CacheNodeType { get; set; } = default!;

    /// <summary>
    /// The engine attribute.
    /// </summary>
    [TerraformPropertyName("engine")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Engine { get; set; } = default!;

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    [TerraformPropertyName("engine_version")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> EngineVersion { get; set; } = default!;

    /// <summary>
    /// The global_replication_group_description attribute.
    /// </summary>
    [TerraformPropertyName("global_replication_group_description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? GlobalReplicationGroupDescription { get; set; }

    /// <summary>
    /// The global_replication_group_id_suffix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GlobalReplicationGroupIdSuffix is required")]
    [TerraformPropertyName("global_replication_group_id_suffix")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> GlobalReplicationGroupIdSuffix { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The num_node_groups attribute.
    /// </summary>
    [TerraformPropertyName("num_node_groups")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> NumNodeGroups { get; set; } = default!;

    /// <summary>
    /// The parameter_group_name attribute.
    /// </summary>
    [TerraformPropertyName("parameter_group_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ParameterGroupName { get; set; }

    /// <summary>
    /// The primary_replication_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrimaryReplicationGroupId is required")]
    [TerraformPropertyName("primary_replication_group_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> PrimaryReplicationGroupId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsElasticacheGlobalReplicationGroupTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The at_rest_encryption_enabled attribute.
    /// </summary>
    [TerraformPropertyName("at_rest_encryption_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> AtRestEncryptionEnabled => new TerraformReference(this, "at_rest_encryption_enabled");

    /// <summary>
    /// The auth_token_enabled attribute.
    /// </summary>
    [TerraformPropertyName("auth_token_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> AuthTokenEnabled => new TerraformReference(this, "auth_token_enabled");

    /// <summary>
    /// The cluster_enabled attribute.
    /// </summary>
    [TerraformPropertyName("cluster_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> ClusterEnabled => new TerraformReference(this, "cluster_enabled");

    /// <summary>
    /// The engine_version_actual attribute.
    /// </summary>
    [TerraformPropertyName("engine_version_actual")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> EngineVersionActual => new TerraformReference(this, "engine_version_actual");

    /// <summary>
    /// The global_node_groups attribute.
    /// </summary>
    [TerraformPropertyName("global_node_groups")]
    // Output-only attribute - read-only reference
    public TerraformSet<object> GlobalNodeGroups => new TerraformReference(this, "global_node_groups");

    /// <summary>
    /// The global_replication_group_id attribute.
    /// </summary>
    [TerraformPropertyName("global_replication_group_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> GlobalReplicationGroupId => new TerraformReference(this, "global_replication_group_id");

    /// <summary>
    /// The transit_encryption_enabled attribute.
    /// </summary>
    [TerraformPropertyName("transit_encryption_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> TransitEncryptionEnabled => new TerraformReference(this, "transit_encryption_enabled");

}
