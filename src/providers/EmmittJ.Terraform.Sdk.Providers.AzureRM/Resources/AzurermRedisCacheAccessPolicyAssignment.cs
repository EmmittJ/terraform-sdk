using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermRedisCacheAccessPolicyAssignmentTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_redis_cache_access_policy_assignment resource.
/// </summary>
public partial class AzurermRedisCacheAccessPolicyAssignment : TerraformResource
{
    public AzurermRedisCacheAccessPolicyAssignment(string name) : base("azurerm_redis_cache_access_policy_assignment", name)
    {
    }

    /// <summary>
    /// The access_policy_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessPolicyName is required")]
    [TerraformProperty("access_policy_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AccessPolicyName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The object_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectId is required")]
    [TerraformProperty("object_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ObjectId { get; set; }

    /// <summary>
    /// The object_id_alias attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectIdAlias is required")]
    [TerraformProperty("object_id_alias")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ObjectIdAlias { get; set; }

    /// <summary>
    /// The redis_cache_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RedisCacheId is required")]
    [TerraformProperty("redis_cache_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RedisCacheId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermRedisCacheAccessPolicyAssignmentTimeoutsBlock>? Timeouts { get; set; }

}
