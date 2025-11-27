using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for chat_engine_config in GoogleDiscoveryEngineChatEngine.
/// Nesting mode: list
/// </summary>
public class GoogleDiscoveryEngineChatEngineChatEngineConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "chat_engine_config";

    /// <summary>
    /// If the flag set to true, we allow the agent and engine are in
    /// different locations, otherwise the agent and engine are required to be
    /// in the same location. The flag is set to false by default.
    /// Note that the &#39;allow_cross_region&#39; are one-time consumed by and passed
    /// to EngineService.CreateEngine. It means they cannot be retrieved using
    /// EngineService.GetEngine or EngineService.ListEngines API after engine
    /// creation.
    /// </summary>
    public TerraformValue<bool>? AllowCrossRegion
    {
        get => new TerraformReference<bool>(this, "allow_cross_region");
        set => SetArgument("allow_cross_region", value);
    }

    /// <summary>
    /// The resource name of an existing Dialogflow agent to link to this Chat Engine. Format: &#39;projects/&amp;lt;Project_ID&amp;gt;/locations/&amp;lt;Location_ID&amp;gt;/agents/&amp;lt;Agent_ID&amp;gt;&#39;.
    /// Exactly one of &#39;agent_creation_config&#39; or &#39;dialogflow_agent_to_link&#39; must be set.
    /// </summary>
    public TerraformValue<string>? DialogflowAgentToLink
    {
        get => new TerraformReference<string>(this, "dialogflow_agent_to_link");
        set => SetArgument("dialogflow_agent_to_link", value);
    }

    /// <summary>
    /// AgentCreationConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AgentCreationConfig block(s) allowed")]
    public TerraformList<GoogleDiscoveryEngineChatEngineChatEngineConfigBlockAgentCreationConfigBlock>? AgentCreationConfig
    {
        get => GetArgument<TerraformList<GoogleDiscoveryEngineChatEngineChatEngineConfigBlockAgentCreationConfigBlock>>("agent_creation_config");
        set => SetArgument("agent_creation_config", value);
    }

}

/// <summary>
/// Block type for agent_creation_config in GoogleDiscoveryEngineChatEngineChatEngineConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDiscoveryEngineChatEngineChatEngineConfigBlockAgentCreationConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "agent_creation_config";

    /// <summary>
    /// Name of the company, organization or other entity that the agent represents. Used for knowledge connector LLM prompt and for knowledge search.
    /// </summary>
    public TerraformValue<string>? Business
    {
        get => new TerraformReference<string>(this, "business");
        set => SetArgument("business", value);
    }

    /// <summary>
    /// The default language of the agent as a language tag. See [Language Support](https://cloud.google.com/dialogflow/docs/reference/language) for a list of the currently supported language codes.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultLanguageCode is required")]
    public required TerraformValue<string> DefaultLanguageCode
    {
        get => new TerraformReference<string>(this, "default_language_code");
        set => SetArgument("default_language_code", value);
    }

    /// <summary>
    /// Agent location for Agent creation, currently supported values: global/us/eu, it needs to be the same region as the Chat Engine.
    /// </summary>
    public TerraformValue<string>? Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The time zone of the agent from the [time zone database](https://www.iana.org/time-zones), e.g., America/New_York, Europe/Paris.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeZone is required")]
    public required TerraformValue<string> TimeZone
    {
        get => new TerraformReference<string>(this, "time_zone");
        set => SetArgument("time_zone", value);
    }

}


/// <summary>
/// Block type for common_config in GoogleDiscoveryEngineChatEngine.
/// Nesting mode: list
/// </summary>
public class GoogleDiscoveryEngineChatEngineCommonConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "common_config";

    /// <summary>
    /// The name of the company, business or entity that is associated with the engine. Setting this may help improve LLM related features.
    /// </summary>
    public TerraformValue<string>? CompanyName
    {
        get => new TerraformReference<string>(this, "company_name");
        set => SetArgument("company_name", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleDiscoveryEngineChatEngine.
/// Nesting mode: single
/// </summary>
public class GoogleDiscoveryEngineChatEngineTimeoutsBlock : TerraformBlock
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
/// Represents a google_discovery_engine_chat_engine Terraform resource.
/// Manages a google_discovery_engine_chat_engine resource.
/// </summary>
public partial class GoogleDiscoveryEngineChatEngine(string name) : TerraformResource("google_discovery_engine_chat_engine", name)
{
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
    /// The data stores associated with this engine. Multiple DataStores in the same Collection can be associated here. All listed DataStores must be &#39;SOLUTION_TYPE_CHAT&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataStoreIds is required")]
    public TerraformList<string>? DataStoreIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "data_store_ids").ResolveNodes(ctx));
        set => SetArgument("data_store_ids", value);
    }

    /// <summary>
    /// The display name of the engine. Should be human readable. UTF-8 encoded string with limit of 1024 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The ID to use for chat engine.
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
    /// The industry vertical that the chat engine registers. Vertical on Engine has to match vertical of the DataStore linked to the engine. Default value: &amp;quot;GENERIC&amp;quot; Possible values: [&amp;quot;GENERIC&amp;quot;]
    /// </summary>
    public TerraformValue<string>? IndustryVertical
    {
        get => new TerraformReference<string>(this, "industry_vertical");
        set => SetArgument("industry_vertical", value);
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
    /// Additional information of the Chat Engine.
    /// </summary>
    public TerraformList<TerraformMap<object>> ChatEngineMetadata
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "chat_engine_metadata").ResolveNodes(ctx));
    }

    /// <summary>
    /// Timestamp the Engine was created at.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// The unique full resource name of the chat engine. Values are of the format
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
    /// ChatEngineConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ChatEngineConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ChatEngineConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ChatEngineConfig block(s) allowed")]
    public required TerraformList<GoogleDiscoveryEngineChatEngineChatEngineConfigBlock> ChatEngineConfig
    {
        get => GetRequiredArgument<TerraformList<GoogleDiscoveryEngineChatEngineChatEngineConfigBlock>>("chat_engine_config");
        set => SetArgument("chat_engine_config", value);
    }

    /// <summary>
    /// CommonConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CommonConfig block(s) allowed")]
    public TerraformList<GoogleDiscoveryEngineChatEngineCommonConfigBlock>? CommonConfig
    {
        get => GetArgument<TerraformList<GoogleDiscoveryEngineChatEngineCommonConfigBlock>>("common_config");
        set => SetArgument("common_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleDiscoveryEngineChatEngineTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleDiscoveryEngineChatEngineTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
