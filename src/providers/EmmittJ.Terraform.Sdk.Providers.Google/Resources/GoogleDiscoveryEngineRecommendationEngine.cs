using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for common_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDiscoveryEngineRecommendationEngineCommonConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The name of the company, business or entity that is associated with the engine. Setting this may help improve LLM related features.cd
    /// </summary>
    [TerraformProperty("company_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CompanyName { get; set; }

}

/// <summary>
/// Block type for media_recommendation_engine_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDiscoveryEngineRecommendationEngineMediaRecommendationEngineConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The optimization objective. e.g., &#39;cvr&#39;.
    /// This field together with MediaRecommendationEngineConfig.type describes
    /// engine metadata to use to control engine training and serving.
    /// Currently supported values: &#39;ctr&#39;, &#39;cvr&#39;.
    /// If not specified, we choose default based on engine type. Default depends on type of recommendation:
    /// &#39;recommended-for-you&#39; =&amp;gt; &#39;ctr&#39;
    /// &#39;others-you-may-like&#39; =&amp;gt; &#39;ctr&#39;
    /// </summary>
    [TerraformProperty("optimization_objective")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? OptimizationObjective { get; set; }

    /// <summary>
    /// The training state that the engine is in (e.g. &#39;TRAINING&#39; or &#39;PAUSED&#39;).
    /// Since part of the cost of running the service
    /// is frequency of training - this can be used to determine when to train
    /// engine in order to control cost. If not specified: the default value for
    /// &#39;CreateEngine&#39; method is &#39;TRAINING&#39;. The default value for
    /// &#39;UpdateEngine&#39; method is to keep the state the same as before. Possible values: [&amp;quot;PAUSED&amp;quot;, &amp;quot;TRAINING&amp;quot;]
    /// </summary>
    [TerraformProperty("training_state")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TrainingState { get; set; }

    /// <summary>
    /// The type of engine. e.g., &#39;recommended-for-you&#39;.
    /// This field together with MediaRecommendationEngineConfig.optimizationObjective describes
    /// engine metadata to use to control engine training and serving.
    /// Currently supported values: &#39;recommended-for-you&#39;, &#39;others-you-may-like&#39;,
    /// &#39;more-like-this&#39;, &#39;most-popular-items&#39;.
    /// </summary>
    [TerraformProperty("type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Type { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleDiscoveryEngineRecommendationEngineTimeoutsBlock : TerraformBlockBase
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
/// Manages a google_discovery_engine_recommendation_engine resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleDiscoveryEngineRecommendationEngine : TerraformResource
{
    public GoogleDiscoveryEngineRecommendationEngine(string name) : base("google_discovery_engine_recommendation_engine", name)
    {
    }

    /// <summary>
    /// The data stores associated with this engine. For SOLUTION_TYPE_RECOMMENDATION type of engines, they can only associate with at most one data store.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataStoreIds is required")]
    [TerraformProperty("data_store_ids")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? DataStoreIds { get; set; }

    /// <summary>
    /// Required. The display name of the engine. Should be human readable. UTF-8 encoded string with limit of 1024 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformProperty("display_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// Unique ID to use for Recommendation Engine.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EngineId is required")]
    [TerraformProperty("engine_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> EngineId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The industry vertical that the engine registers. The restriction of the Engine industry vertical is based on DataStore: If unspecified, default to GENERIC. Vertical on Engine has to match vertical of the DataStore liniked to the engine. Default value: &amp;quot;GENERIC&amp;quot; Possible values: [&amp;quot;GENERIC&amp;quot;, &amp;quot;MEDIA&amp;quot;]
    /// </summary>
    [TerraformProperty("industry_vertical")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? IndustryVertical { get; set; }

    /// <summary>
    /// The geographic location where the data store should reside. The value can
    /// only be one of &amp;quot;global&amp;quot;, &amp;quot;us&amp;quot; and &amp;quot;eu&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for common_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CommonConfig block(s) allowed")]
    [TerraformProperty("common_config")]
    public partial TerraformList<TerraformBlock<GoogleDiscoveryEngineRecommendationEngineCommonConfigBlock>>? CommonConfig { get; set; }

    /// <summary>
    /// Block for media_recommendation_engine_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MediaRecommendationEngineConfig block(s) allowed")]
    [TerraformProperty("media_recommendation_engine_config")]
    public partial TerraformList<TerraformBlock<GoogleDiscoveryEngineRecommendationEngineMediaRecommendationEngineConfigBlock>>? MediaRecommendationEngineConfig { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleDiscoveryEngineRecommendationEngineTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Timestamp the Engine was created at.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// The unique full resource name of the recommendation engine. Values are of the format
    /// &#39;projects/{project}/locations/{location}/collections/{collection}/engines/{engine_id}&#39;.
    /// This field must be a UTF-8 encoded string with a length limit of 1024 characters.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// Timestamp the Engine was last updated.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}
