using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for common_config in GoogleDiscoveryEngineRecommendationEngine.
/// Nesting mode: list
/// </summary>
public class GoogleDiscoveryEngineRecommendationEngineCommonConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "common_config";

    /// <summary>
    /// The name of the company, business or entity that is associated with the engine. Setting this may help improve LLM related features.cd
    /// </summary>
    public TerraformValue<string>? CompanyName
    {
        get => new TerraformReference<string>(this, "company_name");
        set => SetArgument("company_name", value);
    }

}


/// <summary>
/// Block type for media_recommendation_engine_config in GoogleDiscoveryEngineRecommendationEngine.
/// Nesting mode: list
/// </summary>
public class GoogleDiscoveryEngineRecommendationEngineMediaRecommendationEngineConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "media_recommendation_engine_config";

    /// <summary>
    /// The optimization objective. e.g., &#39;cvr&#39;.
    /// This field together with MediaRecommendationEngineConfig.type describes
    /// engine metadata to use to control engine training and serving.
    /// Currently supported values: &#39;ctr&#39;, &#39;cvr&#39;.
    /// If not specified, we choose default based on engine type. Default depends on type of recommendation:
    /// &#39;recommended-for-you&#39; =&amp;gt; &#39;ctr&#39;
    /// &#39;others-you-may-like&#39; =&amp;gt; &#39;ctr&#39;
    /// </summary>
    public TerraformValue<string>? OptimizationObjective
    {
        get => new TerraformReference<string>(this, "optimization_objective");
        set => SetArgument("optimization_objective", value);
    }

    /// <summary>
    /// The training state that the engine is in (e.g. &#39;TRAINING&#39; or &#39;PAUSED&#39;).
    /// Since part of the cost of running the service
    /// is frequency of training - this can be used to determine when to train
    /// engine in order to control cost. If not specified: the default value for
    /// &#39;CreateEngine&#39; method is &#39;TRAINING&#39;. The default value for
    /// &#39;UpdateEngine&#39; method is to keep the state the same as before. Possible values: [&amp;quot;PAUSED&amp;quot;, &amp;quot;TRAINING&amp;quot;]
    /// </summary>
    public TerraformValue<string>? TrainingState
    {
        get => new TerraformReference<string>(this, "training_state");
        set => SetArgument("training_state", value);
    }

    /// <summary>
    /// The type of engine. e.g., &#39;recommended-for-you&#39;.
    /// This field together with MediaRecommendationEngineConfig.optimizationObjective describes
    /// engine metadata to use to control engine training and serving.
    /// Currently supported values: &#39;recommended-for-you&#39;, &#39;others-you-may-like&#39;,
    /// &#39;more-like-this&#39;, &#39;most-popular-items&#39;.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// EngineFeaturesConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EngineFeaturesConfig block(s) allowed")]
    public TerraformList<GoogleDiscoveryEngineRecommendationEngineMediaRecommendationEngineConfigBlockEngineFeaturesConfigBlock>? EngineFeaturesConfig
    {
        get => GetArgument<TerraformList<GoogleDiscoveryEngineRecommendationEngineMediaRecommendationEngineConfigBlockEngineFeaturesConfigBlock>>("engine_features_config");
        set => SetArgument("engine_features_config", value);
    }

    /// <summary>
    /// OptimizationObjectiveConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OptimizationObjectiveConfig block(s) allowed")]
    public TerraformList<GoogleDiscoveryEngineRecommendationEngineMediaRecommendationEngineConfigBlockOptimizationObjectiveConfigBlock>? OptimizationObjectiveConfig
    {
        get => GetArgument<TerraformList<GoogleDiscoveryEngineRecommendationEngineMediaRecommendationEngineConfigBlockOptimizationObjectiveConfigBlock>>("optimization_objective_config");
        set => SetArgument("optimization_objective_config", value);
    }

}

/// <summary>
/// Block type for engine_features_config in GoogleDiscoveryEngineRecommendationEngineMediaRecommendationEngineConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDiscoveryEngineRecommendationEngineMediaRecommendationEngineConfigBlockEngineFeaturesConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "engine_features_config";

    /// <summary>
    /// MostPopularConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MostPopularConfig block(s) allowed")]
    public TerraformList<GoogleDiscoveryEngineRecommendationEngineMediaRecommendationEngineConfigBlockEngineFeaturesConfigBlockMostPopularConfigBlock>? MostPopularConfig
    {
        get => GetArgument<TerraformList<GoogleDiscoveryEngineRecommendationEngineMediaRecommendationEngineConfigBlockEngineFeaturesConfigBlockMostPopularConfigBlock>>("most_popular_config");
        set => SetArgument("most_popular_config", value);
    }

    /// <summary>
    /// RecommendedForYouConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RecommendedForYouConfig block(s) allowed")]
    public TerraformList<GoogleDiscoveryEngineRecommendationEngineMediaRecommendationEngineConfigBlockEngineFeaturesConfigBlockRecommendedForYouConfigBlock>? RecommendedForYouConfig
    {
        get => GetArgument<TerraformList<GoogleDiscoveryEngineRecommendationEngineMediaRecommendationEngineConfigBlockEngineFeaturesConfigBlockRecommendedForYouConfigBlock>>("recommended_for_you_config");
        set => SetArgument("recommended_for_you_config", value);
    }

}

/// <summary>
/// Block type for most_popular_config in GoogleDiscoveryEngineRecommendationEngineMediaRecommendationEngineConfigBlockEngineFeaturesConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDiscoveryEngineRecommendationEngineMediaRecommendationEngineConfigBlockEngineFeaturesConfigBlockMostPopularConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "most_popular_config";

    /// <summary>
    /// The time window of which the engine is queried at training and
    /// prediction time. Positive integers only. The value translates to the
    /// last X days of events. Currently required for the &#39;most-popular-items&#39;
    /// engine.
    /// </summary>
    public TerraformValue<double>? TimeWindowDays
    {
        get => new TerraformReference<double>(this, "time_window_days");
        set => SetArgument("time_window_days", value);
    }

}

/// <summary>
/// Block type for recommended_for_you_config in GoogleDiscoveryEngineRecommendationEngineMediaRecommendationEngineConfigBlockEngineFeaturesConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDiscoveryEngineRecommendationEngineMediaRecommendationEngineConfigBlockEngineFeaturesConfigBlockRecommendedForYouConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "recommended_for_you_config";

    /// <summary>
    /// The type of event with which the engine is queried at prediction time.
    /// If set to &#39;generic&#39;, only &#39;view-item&#39;, &#39;media-play&#39;,and
    /// &#39;media-complete&#39; will be used as &#39;context-event&#39; in engine training. If
    /// set to &#39;view-home-page&#39;, &#39;view-home-page&#39; will also be used as
    /// &#39;context-events&#39; in addition to &#39;view-item&#39;, &#39;media-play&#39;, and
    /// &#39;media-complete&#39;. Currently supported for the &#39;recommended-for-you&#39;
    /// engine. Currently supported values: &#39;view-home-page&#39;, &#39;generic&#39;.
    /// </summary>
    public TerraformValue<string>? ContextEventType
    {
        get => new TerraformReference<string>(this, "context_event_type");
        set => SetArgument("context_event_type", value);
    }

}

/// <summary>
/// Block type for optimization_objective_config in GoogleDiscoveryEngineRecommendationEngineMediaRecommendationEngineConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDiscoveryEngineRecommendationEngineMediaRecommendationEngineConfigBlockOptimizationObjectiveConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "optimization_objective_config";

    /// <summary>
    /// The name of the field to target. Currently supported values: &#39;watch-percentage&#39;, &#39;watch-time&#39;.
    /// </summary>
    public TerraformValue<string>? TargetField
    {
        get => new TerraformReference<string>(this, "target_field");
        set => SetArgument("target_field", value);
    }

    /// <summary>
    /// The threshold to be applied to the target (e.g., 0.5).
    /// </summary>
    public TerraformValue<double>? TargetFieldValueFloat
    {
        get => new TerraformReference<double>(this, "target_field_value_float");
        set => SetArgument("target_field_value_float", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleDiscoveryEngineRecommendationEngine.
/// Nesting mode: single
/// </summary>
public class GoogleDiscoveryEngineRecommendationEngineTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_discovery_engine_recommendation_engine Terraform resource.
/// Manages a google_discovery_engine_recommendation_engine resource.
/// </summary>
public partial class GoogleDiscoveryEngineRecommendationEngine(string name) : TerraformResource("google_discovery_engine_recommendation_engine", name)
{
    /// <summary>
    /// The data stores associated with this engine. For SOLUTION_TYPE_RECOMMENDATION type of engines, they can only associate with at most one data store.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataStoreIds is required")]
    public TerraformList<string>? DataStoreIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "data_store_ids").ResolveNodes(ctx));
        set => SetArgument("data_store_ids", value);
    }

    /// <summary>
    /// Required. The display name of the engine. Should be human readable. UTF-8 encoded string with limit of 1024 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// Unique ID to use for Recommendation Engine.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EngineId is required")]
    public required TerraformValue<string> EngineId
    {
        get => new TerraformReference<string>(this, "engine_id");
        set => SetArgument("engine_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The industry vertical that the engine registers. The restriction of the Engine industry vertical is based on DataStore: If unspecified, default to GENERIC. Vertical on Engine has to match vertical of the DataStore liniked to the engine. Default value: &amp;quot;GENERIC&amp;quot; Possible values: [&amp;quot;GENERIC&amp;quot;, &amp;quot;MEDIA&amp;quot;]
    /// </summary>
    public TerraformValue<string>? IndustryVertical
    {
        get => new TerraformReference<string>(this, "industry_vertical");
        set => SetArgument("industry_vertical", value);
    }

    /// <summary>
    /// The geographic location where the data store should reside. The value can
    /// only be one of &amp;quot;global&amp;quot;, &amp;quot;us&amp;quot; and &amp;quot;eu&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Timestamp the Engine was created at.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// The unique full resource name of the recommendation engine. Values are of the format
    /// &#39;projects/{project}/locations/{location}/collections/{collection}/engines/{engine_id}&#39;.
    /// This field must be a UTF-8 encoded string with a length limit of 1024 characters.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// Timestamp the Engine was last updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
    {
        get => new TerraformReference<string>(this, "update_time");
    }

    /// <summary>
    /// CommonConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CommonConfig block(s) allowed")]
    public TerraformList<GoogleDiscoveryEngineRecommendationEngineCommonConfigBlock>? CommonConfig
    {
        get => GetArgument<TerraformList<GoogleDiscoveryEngineRecommendationEngineCommonConfigBlock>>("common_config");
        set => SetArgument("common_config", value);
    }

    /// <summary>
    /// MediaRecommendationEngineConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MediaRecommendationEngineConfig block(s) allowed")]
    public TerraformList<GoogleDiscoveryEngineRecommendationEngineMediaRecommendationEngineConfigBlock>? MediaRecommendationEngineConfig
    {
        get => GetArgument<TerraformList<GoogleDiscoveryEngineRecommendationEngineMediaRecommendationEngineConfigBlock>>("media_recommendation_engine_config");
        set => SetArgument("media_recommendation_engine_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleDiscoveryEngineRecommendationEngineTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleDiscoveryEngineRecommendationEngineTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
