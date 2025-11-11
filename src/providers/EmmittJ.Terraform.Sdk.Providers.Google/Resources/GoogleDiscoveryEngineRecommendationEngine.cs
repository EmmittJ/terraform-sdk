using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for common_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDiscoveryEngineRecommendationEngineCommonConfigBlock
{
    /// <summary>
    /// The name of the company, business or entity that is associated with the engine. Setting this may help improve LLM related features.cd
    /// </summary>
    [TerraformPropertyName("company_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CompanyName { get; set; }

}

/// <summary>
/// Block type for media_recommendation_engine_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDiscoveryEngineRecommendationEngineMediaRecommendationEngineConfigBlock
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
    [TerraformPropertyName("optimization_objective")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? OptimizationObjective { get; set; }

    /// <summary>
    /// The training state that the engine is in (e.g. &#39;TRAINING&#39; or &#39;PAUSED&#39;).
    /// Since part of the cost of running the service
    /// is frequency of training - this can be used to determine when to train
    /// engine in order to control cost. If not specified: the default value for
    /// &#39;CreateEngine&#39; method is &#39;TRAINING&#39;. The default value for
    /// &#39;UpdateEngine&#39; method is to keep the state the same as before. Possible values: [&amp;quot;PAUSED&amp;quot;, &amp;quot;TRAINING&amp;quot;]
    /// </summary>
    [TerraformPropertyName("training_state")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TrainingState { get; set; }

    /// <summary>
    /// The type of engine. e.g., &#39;recommended-for-you&#39;.
    /// This field together with MediaRecommendationEngineConfig.optimizationObjective describes
    /// engine metadata to use to control engine training and serving.
    /// Currently supported values: &#39;recommended-for-you&#39;, &#39;others-you-may-like&#39;,
    /// &#39;more-like-this&#39;, &#39;most-popular-items&#39;.
    /// </summary>
    [TerraformPropertyName("type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Type { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDiscoveryEngineRecommendationEngineTimeoutsBlock
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
/// Manages a google_discovery_engine_recommendation_engine resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDiscoveryEngineRecommendationEngine : TerraformResource
{
    public GoogleDiscoveryEngineRecommendationEngine(string name) : base("google_discovery_engine_recommendation_engine", name)
    {
    }

    /// <summary>
    /// The data stores associated with this engine. For SOLUTION_TYPE_RECOMMENDATION type of engines, they can only associate with at most one data store.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataStoreIds is required")]
    [TerraformPropertyName("data_store_ids")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformList<string>? DataStoreIds { get; set; }

    /// <summary>
    /// Required. The display name of the engine. Should be human readable. UTF-8 encoded string with limit of 1024 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformPropertyName("display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// Unique ID to use for Recommendation Engine.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EngineId is required")]
    [TerraformPropertyName("engine_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> EngineId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The industry vertical that the engine registers. The restriction of the Engine industry vertical is based on DataStore: If unspecified, default to GENERIC. Vertical on Engine has to match vertical of the DataStore liniked to the engine. Default value: &amp;quot;GENERIC&amp;quot; Possible values: [&amp;quot;GENERIC&amp;quot;, &amp;quot;MEDIA&amp;quot;]
    /// </summary>
    [TerraformPropertyName("industry_vertical")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? IndustryVertical { get; set; }

    /// <summary>
    /// The geographic location where the data store should reside. The value can
    /// only be one of &amp;quot;global&amp;quot;, &amp;quot;us&amp;quot; and &amp;quot;eu&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// Block for common_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CommonConfig block(s) allowed")]
    [TerraformPropertyName("common_config")]
    public TerraformList<TerraformBlock<GoogleDiscoveryEngineRecommendationEngineCommonConfigBlock>>? CommonConfig { get; set; }

    /// <summary>
    /// Block for media_recommendation_engine_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MediaRecommendationEngineConfig block(s) allowed")]
    [TerraformPropertyName("media_recommendation_engine_config")]
    public TerraformList<TerraformBlock<GoogleDiscoveryEngineRecommendationEngineMediaRecommendationEngineConfigBlock>>? MediaRecommendationEngineConfig { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleDiscoveryEngineRecommendationEngineTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Timestamp the Engine was created at.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreateTime => new TerraformReference(this, "create_time");

    /// <summary>
    /// The unique full resource name of the recommendation engine. Values are of the format
    /// &#39;projects/{project}/locations/{location}/collections/{collection}/engines/{engine_id}&#39;.
    /// This field must be a UTF-8 encoded string with a length limit of 1024 characters.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

    /// <summary>
    /// Timestamp the Engine was last updated.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UpdateTime => new TerraformReference(this, "update_time");

}
