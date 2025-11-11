using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsElasticacheGlobalReplicationGroupTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_elasticache_global_replication_group resource.
/// </summary>
public partial class AwsElasticacheGlobalReplicationGroup : TerraformResource
{
    public AwsElasticacheGlobalReplicationGroup(string name) : base("aws_elasticache_global_replication_group", name)
    {
    }

    /// <summary>
    /// The automatic_failover_enabled attribute.
    /// </summary>
    [TerraformProperty("automatic_failover_enabled")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> AutomaticFailoverEnabled { get; set; }

    /// <summary>
    /// The cache_node_type attribute.
    /// </summary>
    [TerraformProperty("cache_node_type")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> CacheNodeType { get; set; }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    [TerraformProperty("engine")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Engine { get; set; }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    [TerraformProperty("engine_version")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> EngineVersion { get; set; }

    /// <summary>
    /// The global_replication_group_description attribute.
    /// </summary>
    [TerraformProperty("global_replication_group_description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? GlobalReplicationGroupDescription { get; set; }

    /// <summary>
    /// The global_replication_group_id_suffix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GlobalReplicationGroupIdSuffix is required")]
    [TerraformProperty("global_replication_group_id_suffix")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> GlobalReplicationGroupIdSuffix { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The num_node_groups attribute.
    /// </summary>
    [TerraformProperty("num_node_groups")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> NumNodeGroups { get; set; }

    /// <summary>
    /// The parameter_group_name attribute.
    /// </summary>
    [TerraformProperty("parameter_group_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ParameterGroupName { get; set; }

    /// <summary>
    /// The primary_replication_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrimaryReplicationGroupId is required")]
    [TerraformProperty("primary_replication_group_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> PrimaryReplicationGroupId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AwsElasticacheGlobalReplicationGroupTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The at_rest_encryption_enabled attribute.
    /// </summary>
    [TerraformProperty("at_rest_encryption_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> AtRestEncryptionEnabled { get; }

    /// <summary>
    /// The auth_token_enabled attribute.
    /// </summary>
    [TerraformProperty("auth_token_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> AuthTokenEnabled { get; }

    /// <summary>
    /// The cluster_enabled attribute.
    /// </summary>
    [TerraformProperty("cluster_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> ClusterEnabled { get; }

    /// <summary>
    /// The engine_version_actual attribute.
    /// </summary>
    [TerraformProperty("engine_version_actual")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> EngineVersionActual { get; }

    /// <summary>
    /// The global_node_groups attribute.
    /// </summary>
    [TerraformProperty("global_node_groups")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<object> GlobalNodeGroups { get; }

    /// <summary>
    /// The global_replication_group_id attribute.
    /// </summary>
    [TerraformProperty("global_replication_group_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> GlobalReplicationGroupId { get; }

    /// <summary>
    /// The transit_encryption_enabled attribute.
    /// </summary>
    [TerraformProperty("transit_encryption_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> TransitEncryptionEnabled { get; }

}
