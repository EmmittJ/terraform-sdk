using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for common_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDiscoveryEngineSearchEngineCommonConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The name of the company, business or entity that is associated with the engine. Setting this may help improve LLM related features.cd
    /// </summary>
    [TerraformProperty("company_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CompanyName { get; set; }

}

/// <summary>
/// Block type for search_engine_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDiscoveryEngineSearchEngineSearchEngineConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The add-on that this search engine enables. Possible values: [&amp;quot;SEARCH_ADD_ON_LLM&amp;quot;]
    /// </summary>
    [TerraformProperty("search_add_ons")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? SearchAddOns { get; set; }

    /// <summary>
    /// The search feature tier of this engine. Defaults to SearchTier.SEARCH_TIER_STANDARD if not specified. Default value: &amp;quot;SEARCH_TIER_STANDARD&amp;quot; Possible values: [&amp;quot;SEARCH_TIER_STANDARD&amp;quot;, &amp;quot;SEARCH_TIER_ENTERPRISE&amp;quot;]
    /// </summary>
    [TerraformProperty("search_tier")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SearchTier { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleDiscoveryEngineSearchEngineTimeoutsBlock : TerraformBlockBase
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
/// Manages a google_discovery_engine_search_engine resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleDiscoveryEngineSearchEngine : TerraformResource
{
    public GoogleDiscoveryEngineSearchEngine(string name) : base("google_discovery_engine_search_engine", name)
    {
    }

    /// <summary>
    /// This is the application type this engine resource represents.
    /// The supported values: &#39;APP_TYPE_UNSPECIFIED&#39;, &#39;APP_TYPE_INTRANET&#39;.
    /// </summary>
    [TerraformProperty("app_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? AppType { get; set; }

    /// <summary>
    /// The collection ID.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CollectionId is required")]
    [TerraformProperty("collection_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> CollectionId { get; set; }

    /// <summary>
    /// The data stores associated with this engine. For SOLUTION_TYPE_SEARCH type of engines, they can only associate with at most one data store.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataStoreIds is required")]
    [TerraformProperty("data_store_ids")]
    // Required argument - source generator will implement get/set
    public TerraformList<string>? DataStoreIds { get; set; }

    /// <summary>
    /// Required. The display name of the engine. Should be human readable. UTF-8 encoded string with limit of 1024 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformProperty("display_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// Unique ID to use for Search Engine App.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EngineId is required")]
    [TerraformProperty("engine_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> EngineId { get; set; }

    /// <summary>
    /// A map of the feature config for the engine to opt in or opt out of features.
    /// </summary>
    [TerraformProperty("features")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Features { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The industry vertical that the engine registers. The restriction of the Engine industry vertical is based on DataStore: If unspecified, default to GENERIC. Vertical on Engine has to match vertical of the DataStore liniked to the engine. Default value: &amp;quot;GENERIC&amp;quot; Possible values: [&amp;quot;GENERIC&amp;quot;, &amp;quot;MEDIA&amp;quot;, &amp;quot;HEALTHCARE_FHIR&amp;quot;]
    /// </summary>
    [TerraformProperty("industry_vertical")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? IndustryVertical { get; set; }

    /// <summary>
    /// The KMS key to be used to protect this Engine at creation time.
    /// 
    /// Must be set for requests that need to comply with CMEK Org Policy
    /// protections.
    /// 
    /// If this field is set and processed successfully, the Engine will be
    /// protected by the KMS key, as indicated in the cmek_config field.
    /// </summary>
    [TerraformProperty("kms_key_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? KmsKeyName { get; set; }

    /// <summary>
    /// Location.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for common_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CommonConfig block(s) allowed")]
    [TerraformProperty("common_config")]
    public TerraformList<TerraformBlock<GoogleDiscoveryEngineSearchEngineCommonConfigBlock>>? CommonConfig { get; set; }

    /// <summary>
    /// Block for search_engine_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SearchEngineConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SearchEngineConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SearchEngineConfig block(s) allowed")]
    [TerraformProperty("search_engine_config")]
    public TerraformList<TerraformBlock<GoogleDiscoveryEngineSearchEngineSearchEngineConfigBlock>>? SearchEngineConfig { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleDiscoveryEngineSearchEngineTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Timestamp the Engine was created at.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// The unique full resource name of the search engine. Values are of the format
    /// &#39;projects/{project}/locations/{location}/collections/{collection_id}/engines/{engine_id}&#39;.
    /// This field must be a UTF-8 encoded string with a length limit of 1024
    /// characters.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

    /// <summary>
    /// Timestamp the Engine was last updated.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UpdateTime { get; }

}
