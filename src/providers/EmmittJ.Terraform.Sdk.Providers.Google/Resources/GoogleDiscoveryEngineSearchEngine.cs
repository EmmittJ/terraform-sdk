using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for common_config in GoogleDiscoveryEngineSearchEngine.
/// Nesting mode: list
/// </summary>
public class GoogleDiscoveryEngineSearchEngineCommonConfigBlock : TerraformBlock
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
/// Block type for search_engine_config in GoogleDiscoveryEngineSearchEngine.
/// Nesting mode: list
/// </summary>
public class GoogleDiscoveryEngineSearchEngineSearchEngineConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "search_engine_config";

    /// <summary>
    /// The add-on that this search engine enables. Possible values: [&amp;quot;SEARCH_ADD_ON_LLM&amp;quot;]
    /// </summary>
    public TerraformList<string>? SearchAddOns
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "search_add_ons").ResolveNodes(ctx));
        set => SetArgument("search_add_ons", value);
    }

    /// <summary>
    /// The search feature tier of this engine. Defaults to SearchTier.SEARCH_TIER_STANDARD if not specified. Default value: &amp;quot;SEARCH_TIER_STANDARD&amp;quot; Possible values: [&amp;quot;SEARCH_TIER_STANDARD&amp;quot;, &amp;quot;SEARCH_TIER_ENTERPRISE&amp;quot;]
    /// </summary>
    public TerraformValue<string>? SearchTier
    {
        get => new TerraformReference<string>(this, "search_tier");
        set => SetArgument("search_tier", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleDiscoveryEngineSearchEngine.
/// Nesting mode: single
/// </summary>
public class GoogleDiscoveryEngineSearchEngineTimeoutsBlock : TerraformBlock
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
/// Represents a google_discovery_engine_search_engine Terraform resource.
/// Manages a google_discovery_engine_search_engine resource.
/// </summary>
public partial class GoogleDiscoveryEngineSearchEngine(string name) : TerraformResource("google_discovery_engine_search_engine", name)
{
    /// <summary>
    /// This is the application type this engine resource represents.
    /// The supported values: &#39;APP_TYPE_UNSPECIFIED&#39;, &#39;APP_TYPE_INTRANET&#39;.
    /// </summary>
    public TerraformValue<string>? AppType
    {
        get => new TerraformReference<string>(this, "app_type");
        set => SetArgument("app_type", value);
    }

    /// <summary>
    /// The collection ID.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CollectionId is required")]
    public required TerraformValue<string> CollectionId
    {
        get => new TerraformReference<string>(this, "collection_id");
        set => SetArgument("collection_id", value);
    }

    /// <summary>
    /// The data stores associated with this engine. For SOLUTION_TYPE_SEARCH type of engines, they can only associate with at most one data store.
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
    /// Unique ID to use for Search Engine App.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EngineId is required")]
    public required TerraformValue<string> EngineId
    {
        get => new TerraformReference<string>(this, "engine_id");
        set => SetArgument("engine_id", value);
    }

    /// <summary>
    /// A map of the feature config for the engine to opt in or opt out of features.
    /// </summary>
    public TerraformMap<string>? Features
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "features").ResolveNodes(ctx));
        set => SetArgument("features", value);
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
    /// The industry vertical that the engine registers. The restriction of the Engine industry vertical is based on DataStore: If unspecified, default to GENERIC. Vertical on Engine has to match vertical of the DataStore liniked to the engine. Default value: &amp;quot;GENERIC&amp;quot; Possible values: [&amp;quot;GENERIC&amp;quot;, &amp;quot;MEDIA&amp;quot;, &amp;quot;HEALTHCARE_FHIR&amp;quot;]
    /// </summary>
    public TerraformValue<string>? IndustryVertical
    {
        get => new TerraformReference<string>(this, "industry_vertical");
        set => SetArgument("industry_vertical", value);
    }

    /// <summary>
    /// The KMS key to be used to protect this Engine at creation time.
    /// 
    /// Must be set for requests that need to comply with CMEK Org Policy
    /// protections.
    /// 
    /// If this field is set and processed successfully, the Engine will be
    /// protected by the KMS key, as indicated in the cmek_config field.
    /// </summary>
    public TerraformValue<string>? KmsKeyName
    {
        get => new TerraformReference<string>(this, "kms_key_name");
        set => SetArgument("kms_key_name", value);
    }

    /// <summary>
    /// Location.
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
    /// The unique full resource name of the search engine. Values are of the format
    /// &#39;projects/{project}/locations/{location}/collections/{collection_id}/engines/{engine_id}&#39;.
    /// This field must be a UTF-8 encoded string with a length limit of 1024
    /// characters.
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
    public TerraformList<GoogleDiscoveryEngineSearchEngineCommonConfigBlock>? CommonConfig
    {
        get => GetArgument<TerraformList<GoogleDiscoveryEngineSearchEngineCommonConfigBlock>>("common_config");
        set => SetArgument("common_config", value);
    }

    /// <summary>
    /// SearchEngineConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SearchEngineConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SearchEngineConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SearchEngineConfig block(s) allowed")]
    public required TerraformList<GoogleDiscoveryEngineSearchEngineSearchEngineConfigBlock> SearchEngineConfig
    {
        get => GetRequiredArgument<TerraformList<GoogleDiscoveryEngineSearchEngineSearchEngineConfigBlock>>("search_engine_config");
        set => SetArgument("search_engine_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleDiscoveryEngineSearchEngineTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleDiscoveryEngineSearchEngineTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
