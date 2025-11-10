using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for common_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDiscoveryEngineRecommendationEngineCommonConfigBlock : TerraformBlock
{
    /// <summary>
    /// The name of the company, business or entity that is associated with the engine. Setting this may help improve LLM related features.cd
    /// </summary>
    public TerraformProperty<string>? CompanyName
    {
        get => GetProperty<TerraformProperty<string>>("company_name");
        set => WithProperty("company_name", value);
    }

}

/// <summary>
/// Block type for media_recommendation_engine_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDiscoveryEngineRecommendationEngineMediaRecommendationEngineConfigBlock : TerraformBlock
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
    public TerraformProperty<string>? OptimizationObjective
    {
        get => GetProperty<TerraformProperty<string>>("optimization_objective");
        set => WithProperty("optimization_objective", value);
    }

    /// <summary>
    /// The training state that the engine is in (e.g. &#39;TRAINING&#39; or &#39;PAUSED&#39;).
    /// Since part of the cost of running the service
    /// is frequency of training - this can be used to determine when to train
    /// engine in order to control cost. If not specified: the default value for
    /// &#39;CreateEngine&#39; method is &#39;TRAINING&#39;. The default value for
    /// &#39;UpdateEngine&#39; method is to keep the state the same as before. Possible values: [&amp;quot;PAUSED&amp;quot;, &amp;quot;TRAINING&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? TrainingState
    {
        get => GetProperty<TerraformProperty<string>>("training_state");
        set => WithProperty("training_state", value);
    }

    /// <summary>
    /// The type of engine. e.g., &#39;recommended-for-you&#39;.
    /// This field together with MediaRecommendationEngineConfig.optimizationObjective describes
    /// engine metadata to use to control engine training and serving.
    /// Currently supported values: &#39;recommended-for-you&#39;, &#39;others-you-may-like&#39;,
    /// &#39;more-like-this&#39;, &#39;most-popular-items&#39;.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDiscoveryEngineRecommendationEngineTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a google_discovery_engine_recommendation_engine resource.
/// </summary>
public class GoogleDiscoveryEngineRecommendationEngine : TerraformResource
{
    public GoogleDiscoveryEngineRecommendationEngine(string name) : base("google_discovery_engine_recommendation_engine", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("name");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// The data stores associated with this engine. For SOLUTION_TYPE_RECOMMENDATION type of engines, they can only associate with at most one data store.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataStoreIds is required")]
    public List<TerraformProperty<string>>? DataStoreIds
    {
        get => GetProperty<List<TerraformProperty<string>>>("data_store_ids");
        set => this.WithProperty("data_store_ids", value);
    }

    /// <summary>
    /// Required. The display name of the engine. Should be human readable. UTF-8 encoded string with limit of 1024 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// Unique ID to use for Recommendation Engine.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EngineId is required")]
    public required TerraformProperty<string> EngineId
    {
        get => GetProperty<TerraformProperty<string>>("engine_id");
        set => this.WithProperty("engine_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The industry vertical that the engine registers. The restriction of the Engine industry vertical is based on DataStore: If unspecified, default to GENERIC. Vertical on Engine has to match vertical of the DataStore liniked to the engine. Default value: &amp;quot;GENERIC&amp;quot; Possible values: [&amp;quot;GENERIC&amp;quot;, &amp;quot;MEDIA&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? IndustryVertical
    {
        get => GetProperty<TerraformProperty<string>>("industry_vertical");
        set => this.WithProperty("industry_vertical", value);
    }

    /// <summary>
    /// The geographic location where the data store should reside. The value can
    /// only be one of &amp;quot;global&amp;quot;, &amp;quot;us&amp;quot; and &amp;quot;eu&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// Block for common_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CommonConfig block(s) allowed")]
    public List<GoogleDiscoveryEngineRecommendationEngineCommonConfigBlock>? CommonConfig
    {
        get => GetProperty<List<GoogleDiscoveryEngineRecommendationEngineCommonConfigBlock>>("common_config");
        set => this.WithProperty("common_config", value);
    }

    /// <summary>
    /// Block for media_recommendation_engine_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MediaRecommendationEngineConfig block(s) allowed")]
    public List<GoogleDiscoveryEngineRecommendationEngineMediaRecommendationEngineConfigBlock>? MediaRecommendationEngineConfig
    {
        get => GetProperty<List<GoogleDiscoveryEngineRecommendationEngineMediaRecommendationEngineConfigBlock>>("media_recommendation_engine_config");
        set => this.WithProperty("media_recommendation_engine_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDiscoveryEngineRecommendationEngineTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleDiscoveryEngineRecommendationEngineTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Timestamp the Engine was created at.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// The unique full resource name of the recommendation engine. Values are of the format
    /// &#39;projects/{project}/locations/{location}/collections/{collection}/engines/{engine_id}&#39;.
    /// This field must be a UTF-8 encoded string with a length limit of 1024 characters.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// Timestamp the Engine was last updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
