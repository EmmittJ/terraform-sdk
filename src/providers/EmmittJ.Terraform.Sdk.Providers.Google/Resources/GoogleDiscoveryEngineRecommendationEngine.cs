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
        set => SetProperty("company_name", value);
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
        set => SetProperty("optimization_objective", value);
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
        set => SetProperty("training_state", value);
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
        set => SetProperty("type", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a google_discovery_engine_recommendation_engine resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDiscoveryEngineRecommendationEngine : TerraformResource
{
    public GoogleDiscoveryEngineRecommendationEngine(string name) : base("google_discovery_engine_recommendation_engine", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("create_time");
        SetOutput("name");
        SetOutput("update_time");
        SetOutput("data_store_ids");
        SetOutput("display_name");
        SetOutput("engine_id");
        SetOutput("id");
        SetOutput("industry_vertical");
        SetOutput("location");
        SetOutput("project");
    }

    /// <summary>
    /// The data stores associated with this engine. For SOLUTION_TYPE_RECOMMENDATION type of engines, they can only associate with at most one data store.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataStoreIds is required")]
    public List<TerraformProperty<string>> DataStoreIds
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("data_store_ids");
        set => SetProperty("data_store_ids", value);
    }

    /// <summary>
    /// Required. The display name of the engine. Should be human readable. UTF-8 encoded string with limit of 1024 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// Unique ID to use for Recommendation Engine.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EngineId is required")]
    public required TerraformProperty<string> EngineId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("engine_id");
        set => SetProperty("engine_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The industry vertical that the engine registers. The restriction of the Engine industry vertical is based on DataStore: If unspecified, default to GENERIC. Vertical on Engine has to match vertical of the DataStore liniked to the engine. Default value: &amp;quot;GENERIC&amp;quot; Possible values: [&amp;quot;GENERIC&amp;quot;, &amp;quot;MEDIA&amp;quot;]
    /// </summary>
    public TerraformProperty<string> IndustryVertical
    {
        get => GetRequiredOutput<TerraformProperty<string>>("industry_vertical");
        set => SetProperty("industry_vertical", value);
    }

    /// <summary>
    /// The geographic location where the data store should reside. The value can
    /// only be one of &amp;quot;global&amp;quot;, &amp;quot;us&amp;quot; and &amp;quot;eu&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// Block for common_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CommonConfig block(s) allowed")]
    public List<GoogleDiscoveryEngineRecommendationEngineCommonConfigBlock>? CommonConfig
    {
        set => SetProperty("common_config", value);
    }

    /// <summary>
    /// Block for media_recommendation_engine_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MediaRecommendationEngineConfig block(s) allowed")]
    public List<GoogleDiscoveryEngineRecommendationEngineMediaRecommendationEngineConfigBlock>? MediaRecommendationEngineConfig
    {
        set => SetProperty("media_recommendation_engine_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDiscoveryEngineRecommendationEngineTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
