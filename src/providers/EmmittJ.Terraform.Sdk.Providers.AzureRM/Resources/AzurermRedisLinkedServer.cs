using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermRedisLinkedServerTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Manages a azurerm_redis_linked_server resource.
/// </summary>
public partial class AzurermRedisLinkedServer : TerraformResource
{
    public AzurermRedisLinkedServer(string name) : base("azurerm_redis_linked_server", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The linked_redis_cache_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LinkedRedisCacheId is required")]
    [TerraformProperty("linked_redis_cache_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> LinkedRedisCacheId { get; set; }

    /// <summary>
    /// The linked_redis_cache_location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LinkedRedisCacheLocation is required")]
    [TerraformProperty("linked_redis_cache_location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> LinkedRedisCacheLocation { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The server_role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerRole is required")]
    [TerraformProperty("server_role")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ServerRole { get; set; }

    /// <summary>
    /// The target_redis_cache_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetRedisCacheName is required")]
    [TerraformProperty("target_redis_cache_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TargetRedisCacheName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermRedisLinkedServerTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The geo_replicated_primary_host_name attribute.
    /// </summary>
    [TerraformProperty("geo_replicated_primary_host_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> GeoReplicatedPrimaryHostName { get; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

}
