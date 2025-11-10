using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for common_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDiscoveryEngineSearchEngineCommonConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The name of the company, business or entity that is associated with the engine. Setting this may help improve LLM related features.cd
    /// </summary>
    [TerraformPropertyName("company_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CompanyName { get; set; }

}

/// <summary>
/// Block type for search_engine_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDiscoveryEngineSearchEngineSearchEngineConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The add-on that this search engine enables. Possible values: [&amp;quot;SEARCH_ADD_ON_LLM&amp;quot;]
    /// </summary>
    [TerraformPropertyName("search_add_ons")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? SearchAddOns { get; set; }

    /// <summary>
    /// The search feature tier of this engine. Defaults to SearchTier.SEARCH_TIER_STANDARD if not specified. Default value: &amp;quot;SEARCH_TIER_STANDARD&amp;quot; Possible values: [&amp;quot;SEARCH_TIER_STANDARD&amp;quot;, &amp;quot;SEARCH_TIER_ENTERPRISE&amp;quot;]
    /// </summary>
    [TerraformPropertyName("search_tier")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SearchTier { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDiscoveryEngineSearchEngineTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a google_discovery_engine_search_engine resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDiscoveryEngineSearchEngine : TerraformResource
{
    public GoogleDiscoveryEngineSearchEngine(string name) : base("google_discovery_engine_search_engine", name)
    {
    }

    /// <summary>
    /// This is the application type this engine resource represents.
    /// The supported values: &#39;APP_TYPE_UNSPECIFIED&#39;, &#39;APP_TYPE_INTRANET&#39;.
    /// </summary>
    [TerraformPropertyName("app_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AppType { get; set; }

    /// <summary>
    /// The collection ID.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CollectionId is required")]
    [TerraformPropertyName("collection_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> CollectionId { get; set; }

    /// <summary>
    /// The data stores associated with this engine. For SOLUTION_TYPE_SEARCH type of engines, they can only associate with at most one data store.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataStoreIds is required")]
    [TerraformPropertyName("data_store_ids")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<List<TerraformProperty<string>>>? DataStoreIds { get; set; }

    /// <summary>
    /// Required. The display name of the engine. Should be human readable. UTF-8 encoded string with limit of 1024 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformPropertyName("display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DisplayName { get; set; }

    /// <summary>
    /// Unique ID to use for Search Engine App.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EngineId is required")]
    [TerraformPropertyName("engine_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> EngineId { get; set; }

    /// <summary>
    /// A map of the feature config for the engine to opt in or opt out of features.
    /// </summary>
    [TerraformPropertyName("features")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Features { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The industry vertical that the engine registers. The restriction of the Engine industry vertical is based on DataStore: If unspecified, default to GENERIC. Vertical on Engine has to match vertical of the DataStore liniked to the engine. Default value: &amp;quot;GENERIC&amp;quot; Possible values: [&amp;quot;GENERIC&amp;quot;, &amp;quot;MEDIA&amp;quot;, &amp;quot;HEALTHCARE_FHIR&amp;quot;]
    /// </summary>
    [TerraformPropertyName("industry_vertical")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? IndustryVertical { get; set; }

    /// <summary>
    /// The KMS key to be used to protect this Engine at creation time.
    /// 
    /// Must be set for requests that need to comply with CMEK Org Policy
    /// protections.
    /// 
    /// If this field is set and processed successfully, the Engine will be
    /// protected by the KMS key, as indicated in the cmek_config field.
    /// </summary>
    [TerraformPropertyName("kms_key_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? KmsKeyName { get; set; }

    /// <summary>
    /// Location.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Block for common_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CommonConfig block(s) allowed")]
    [TerraformPropertyName("common_config")]
    public TerraformList<TerraformBlock<GoogleDiscoveryEngineSearchEngineCommonConfigBlock>>? CommonConfig { get; set; } = new();

    /// <summary>
    /// Block for search_engine_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SearchEngineConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SearchEngineConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SearchEngineConfig block(s) allowed")]
    [TerraformPropertyName("search_engine_config")]
    public TerraformList<TerraformBlock<GoogleDiscoveryEngineSearchEngineSearchEngineConfigBlock>>? SearchEngineConfig { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleDiscoveryEngineSearchEngineTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Timestamp the Engine was created at.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// The unique full resource name of the search engine. Values are of the format
    /// &#39;projects/{project}/locations/{location}/collections/{collection_id}/engines/{engine_id}&#39;.
    /// This field must be a UTF-8 encoded string with a length limit of 1024
    /// characters.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// Timestamp the Engine was last updated.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "update_time");

}
