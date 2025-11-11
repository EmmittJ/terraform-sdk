using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for cluster_endpoints in .
/// Nesting mode: list
/// </summary>
public partial class GoogleRedisClusterUserCreatedConnectionsClusterEndpointsBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleRedisClusterUserCreatedConnectionsTimeoutsBlock : TerraformBlockBase
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
/// Manages a google_redis_cluster_user_created_connections resource.
/// </summary>
public partial class GoogleRedisClusterUserCreatedConnections : TerraformResource
{
    public GoogleRedisClusterUserCreatedConnections(string name) : base("google_redis_cluster_user_created_connections", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name of the Redis cluster these endpoints should be added to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The name of the region of the Redis cluster these endpoints should be added to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Region is required")]
    [TerraformProperty("region")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for cluster_endpoints.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("cluster_endpoints")]
    public TerraformList<TerraformBlock<GoogleRedisClusterUserCreatedConnectionsClusterEndpointsBlock>>? ClusterEndpoints { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleRedisClusterUserCreatedConnectionsTimeoutsBlock>? Timeouts { get; set; }

}
