using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for chat_engine_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDiscoveryEngineChatEngineChatEngineConfigBlock : TerraformBlock
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
    public TerraformProperty<bool>? AllowCrossRegion
    {
        set => SetProperty("allow_cross_region", value);
    }

    /// <summary>
    /// The resource name of an existing Dialogflow agent to link to this Chat Engine. Format: &#39;projects/&amp;lt;Project_ID&amp;gt;/locations/&amp;lt;Location_ID&amp;gt;/agents/&amp;lt;Agent_ID&amp;gt;&#39;.
    /// Exactly one of &#39;agent_creation_config&#39; or &#39;dialogflow_agent_to_link&#39; must be set.
    /// </summary>
    public TerraformProperty<string>? DialogflowAgentToLink
    {
        set => SetProperty("dialogflow_agent_to_link", value);
    }

}

/// <summary>
/// Block type for common_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDiscoveryEngineChatEngineCommonConfigBlock : TerraformBlock
{
    /// <summary>
    /// The name of the company, business or entity that is associated with the engine. Setting this may help improve LLM related features.
    /// </summary>
    public TerraformProperty<string>? CompanyName
    {
        set => SetProperty("company_name", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDiscoveryEngineChatEngineTimeoutsBlock : TerraformBlock
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
/// Manages a google_discovery_engine_chat_engine resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDiscoveryEngineChatEngine : TerraformResource
{
    public GoogleDiscoveryEngineChatEngine(string name) : base("google_discovery_engine_chat_engine", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("chat_engine_metadata");
        SetOutput("create_time");
        SetOutput("name");
        SetOutput("update_time");
        SetOutput("collection_id");
        SetOutput("data_store_ids");
        SetOutput("display_name");
        SetOutput("engine_id");
        SetOutput("id");
        SetOutput("industry_vertical");
        SetOutput("location");
        SetOutput("project");
    }

    /// <summary>
    /// The collection ID.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CollectionId is required")]
    public required TerraformProperty<string> CollectionId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("collection_id");
        set => SetProperty("collection_id", value);
    }

    /// <summary>
    /// The data stores associated with this engine. Multiple DataStores in the same Collection can be associated here. All listed DataStores must be &#39;SOLUTION_TYPE_CHAT&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataStoreIds is required")]
    public List<TerraformProperty<string>> DataStoreIds
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("data_store_ids");
        set => SetProperty("data_store_ids", value);
    }

    /// <summary>
    /// The display name of the engine. Should be human readable. UTF-8 encoded string with limit of 1024 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// The ID to use for chat engine.
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
    /// The industry vertical that the chat engine registers. Vertical on Engine has to match vertical of the DataStore linked to the engine. Default value: &amp;quot;GENERIC&amp;quot; Possible values: [&amp;quot;GENERIC&amp;quot;]
    /// </summary>
    public TerraformProperty<string> IndustryVertical
    {
        get => GetRequiredOutput<TerraformProperty<string>>("industry_vertical");
        set => SetProperty("industry_vertical", value);
    }

    /// <summary>
    /// Location.
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
    /// Block for chat_engine_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ChatEngineConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ChatEngineConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ChatEngineConfig block(s) allowed")]
    public List<GoogleDiscoveryEngineChatEngineChatEngineConfigBlock>? ChatEngineConfig
    {
        set => SetProperty("chat_engine_config", value);
    }

    /// <summary>
    /// Block for common_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CommonConfig block(s) allowed")]
    public List<GoogleDiscoveryEngineChatEngineCommonConfigBlock>? CommonConfig
    {
        set => SetProperty("common_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDiscoveryEngineChatEngineTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Additional information of the Chat Engine.
    /// </summary>
    public TerraformExpression ChatEngineMetadata => this["chat_engine_metadata"];

    /// <summary>
    /// Timestamp the Engine was created at.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// The unique full resource name of the chat engine. Values are of the format
    /// &#39;projects/{project}/locations/{location}/collections/{collection_id}/engines/{engine_id}&#39;.
    /// This field must be a UTF-8 encoded string with a length limit of 1024
    /// characters.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// Timestamp the Engine was last updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
