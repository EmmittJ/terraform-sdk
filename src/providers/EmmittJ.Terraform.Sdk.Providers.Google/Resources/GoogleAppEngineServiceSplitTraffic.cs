using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for split in .
/// Nesting mode: list
/// </summary>
public partial class GoogleAppEngineServiceSplitTrafficSplitBlock : TerraformBlockBase
{
    /// <summary>
    /// Mapping from version IDs within the service to fractional (0.000, 1] allocations of traffic for that version. Each version can be specified only once, but some versions in the service may not have any traffic allocation. Services that have traffic allocated cannot be deleted until either the service is deleted or their traffic allocation is removed. Allocations must sum to 1. Up to two decimal place precision is supported for IP-based splits and up to three decimal places is supported for cookie-based splits.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Allocations is required")]
    [TerraformProperty("allocations")]
    // Required argument - source generator will implement get/set
    public required TerraformMap<string> Allocations { get; set; }

    /// <summary>
    /// Mechanism used to determine which version a request is sent to. The traffic selection algorithm will be stable for either type until allocations are changed. Possible values: [&amp;quot;UNSPECIFIED&amp;quot;, &amp;quot;COOKIE&amp;quot;, &amp;quot;IP&amp;quot;, &amp;quot;RANDOM&amp;quot;]
    /// </summary>
    [TerraformProperty("shard_by")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ShardBy { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleAppEngineServiceSplitTrafficTimeoutsBlock : TerraformBlockBase
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
/// Manages a google_app_engine_service_split_traffic resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleAppEngineServiceSplitTraffic : TerraformResource
{
    public GoogleAppEngineServiceSplitTraffic(string name) : base("google_app_engine_service_split_traffic", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// If set to true traffic will be migrated to this version.
    /// </summary>
    [TerraformProperty("migrate_traffic")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? MigrateTraffic { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The name of the service these settings apply to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    [TerraformProperty("service")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Service { get; set; }

    /// <summary>
    /// Block for split.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Split is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Split block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Split block(s) allowed")]
    [TerraformProperty("split")]
    public TerraformList<TerraformBlock<GoogleAppEngineServiceSplitTrafficSplitBlock>>? Split { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleAppEngineServiceSplitTrafficTimeoutsBlock>? Timeouts { get; set; }

}
