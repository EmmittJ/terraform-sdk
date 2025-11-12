using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleVertexAiCacheConfigTimeoutsBlock() : TerraformBlock("timeouts")
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
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_vertex_ai_cache_config resource.
/// </summary>
public partial class GoogleVertexAiCacheConfig : TerraformResource
{
    public GoogleVertexAiCacheConfig(string name) : base("google_vertex_ai_cache_config", name)
    {
    }

    /// <summary>
    /// If set to true, disables GenAI caching. Otherwise caching is enabled.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisableCache is required")]
    [TerraformProperty("disable_cache")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> DisableCache { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleVertexAiCacheConfigTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Identifier. name of the cache config. Format: - &#39;projects/{project}/cacheConfig&#39;.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

}
