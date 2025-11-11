using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for chat_engine_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDiscoveryEngineChatEngineChatEngineConfigBlock
{
    /// <summary>
    /// If the flag set to true, we allow the agent and engine are in
    /// different locations, otherwise the agent and engine are required to be
    /// in the same location. The flag is set to false by default.
    /// Note that the &#39;allow_cross_region&#39; are one-time consumed by and passed
    /// to EngineService.CreateEngine. It means they cannot be retrieved using
    /// EngineService.GetEngine or EngineService.ListEngines API after engine
    /// creation.
    /// </summary>
    [TerraformPropertyName("allow_cross_region")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AllowCrossRegion { get; set; }

    /// <summary>
    /// The resource name of an existing Dialogflow agent to link to this Chat Engine. Format: &#39;projects/&amp;lt;Project_ID&amp;gt;/locations/&amp;lt;Location_ID&amp;gt;/agents/&amp;lt;Agent_ID&amp;gt;&#39;.
    /// Exactly one of &#39;agent_creation_config&#39; or &#39;dialogflow_agent_to_link&#39; must be set.
    /// </summary>
    [TerraformPropertyName("dialogflow_agent_to_link")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DialogflowAgentToLink { get; set; }

}

/// <summary>
/// Block type for common_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDiscoveryEngineChatEngineCommonConfigBlock
{
    /// <summary>
    /// The name of the company, business or entity that is associated with the engine. Setting this may help improve LLM related features.
    /// </summary>
    [TerraformPropertyName("company_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CompanyName { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDiscoveryEngineChatEngineTimeoutsBlock
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
/// Manages a google_discovery_engine_chat_engine resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDiscoveryEngineChatEngine : TerraformResource
{
    public GoogleDiscoveryEngineChatEngine(string name) : base("google_discovery_engine_chat_engine", name)
    {
    }

    /// <summary>
    /// The collection ID.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CollectionId is required")]
    [TerraformPropertyName("collection_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> CollectionId { get; set; }

    /// <summary>
    /// The data stores associated with this engine. Multiple DataStores in the same Collection can be associated here. All listed DataStores must be &#39;SOLUTION_TYPE_CHAT&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataStoreIds is required")]
    [TerraformPropertyName("data_store_ids")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformList<string>? DataStoreIds { get; set; }

    /// <summary>
    /// The display name of the engine. Should be human readable. UTF-8 encoded string with limit of 1024 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformPropertyName("display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The ID to use for chat engine.
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
    /// The industry vertical that the chat engine registers. Vertical on Engine has to match vertical of the DataStore linked to the engine. Default value: &amp;quot;GENERIC&amp;quot; Possible values: [&amp;quot;GENERIC&amp;quot;]
    /// </summary>
    [TerraformPropertyName("industry_vertical")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? IndustryVertical { get; set; }

    /// <summary>
    /// Location.
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
    /// Block for chat_engine_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ChatEngineConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ChatEngineConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ChatEngineConfig block(s) allowed")]
    [TerraformPropertyName("chat_engine_config")]
    public TerraformList<TerraformBlock<GoogleDiscoveryEngineChatEngineChatEngineConfigBlock>>? ChatEngineConfig { get; set; }

    /// <summary>
    /// Block for common_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CommonConfig block(s) allowed")]
    [TerraformPropertyName("common_config")]
    public TerraformList<TerraformBlock<GoogleDiscoveryEngineChatEngineCommonConfigBlock>>? CommonConfig { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleDiscoveryEngineChatEngineTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Additional information of the Chat Engine.
    /// </summary>
    [TerraformPropertyName("chat_engine_metadata")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ChatEngineMetadata => new TerraformReference(this, "chat_engine_metadata");

    /// <summary>
    /// Timestamp the Engine was created at.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreateTime => new TerraformReference(this, "create_time");

    /// <summary>
    /// The unique full resource name of the chat engine. Values are of the format
    /// &#39;projects/{project}/locations/{location}/collections/{collection_id}/engines/{engine_id}&#39;.
    /// This field must be a UTF-8 encoded string with a length limit of 1024
    /// characters.
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
