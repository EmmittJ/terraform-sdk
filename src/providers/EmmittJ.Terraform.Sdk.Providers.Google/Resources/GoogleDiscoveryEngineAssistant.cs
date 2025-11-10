using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for customer_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleDiscoveryEngineAssistantCustomerPolicyBlock : TerraformBlock
{
}

/// <summary>
/// Block type for generation_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDiscoveryEngineAssistantGenerationConfigBlock : TerraformBlock
{
    /// <summary>
    /// The default language to use for the generation of the assistant response.
    /// Use an ISO 639-1 language code such as &#39;en&#39;.
    /// If not specified, the language will be automatically detected.
    /// </summary>
    public TerraformProperty<string>? DefaultLanguage
    {
        get => GetProperty<TerraformProperty<string>>("default_language");
        set => WithProperty("default_language", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDiscoveryEngineAssistantTimeoutsBlock : TerraformBlock
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
/// Manages a google_discovery_engine_assistant resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDiscoveryEngineAssistant : TerraformResource
{
    public GoogleDiscoveryEngineAssistant(string name) : base("google_discovery_engine_assistant", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("name");
    }

    /// <summary>
    /// The unique id of the assistant.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AssistantId is required")]
    public required TerraformProperty<string> AssistantId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("assistant_id");
        set => this.WithProperty("assistant_id", value);
    }

    /// <summary>
    /// The unique id of the collection.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CollectionId is required")]
    public required TerraformProperty<string> CollectionId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("collection_id");
        set => this.WithProperty("collection_id", value);
    }

    /// <summary>
    /// Description for additional information. Expected to be shown on the
    /// configuration UI, not to the users of the assistant.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The assistant display name.
    /// 
    /// It must be a UTF-8 encoded string with a length limit of 128 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// The unique id of the engine.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EngineId is required")]
    public required TerraformProperty<string> EngineId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("engine_id");
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
    /// The geographic location where the data store should reside. The value can
    /// only be one of &amp;quot;global&amp;quot;, &amp;quot;us&amp;quot; and &amp;quot;eu&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
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
    /// The type of web grounding to use.
    /// The supported values: &#39;WEB_GROUNDING_TYPE_DISABLED&#39;, &#39;WEB_GROUNDING_TYPE_GOOGLE_SEARCH&#39;, &#39;WEB_GROUNDING_TYPE_ENTERPRISE_WEB_SEARCH&#39;.
    /// </summary>
    public TerraformProperty<string>? WebGroundingType
    {
        get => GetProperty<TerraformProperty<string>>("web_grounding_type");
        set => this.WithProperty("web_grounding_type", value);
    }

    /// <summary>
    /// Block for customer_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomerPolicy block(s) allowed")]
    public List<GoogleDiscoveryEngineAssistantCustomerPolicyBlock>? CustomerPolicy
    {
        get => GetProperty<List<GoogleDiscoveryEngineAssistantCustomerPolicyBlock>>("customer_policy");
        set => this.WithProperty("customer_policy", value);
    }

    /// <summary>
    /// Block for generation_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GenerationConfig block(s) allowed")]
    public List<GoogleDiscoveryEngineAssistantGenerationConfigBlock>? GenerationConfig
    {
        get => GetProperty<List<GoogleDiscoveryEngineAssistantGenerationConfigBlock>>("generation_config");
        set => this.WithProperty("generation_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDiscoveryEngineAssistantTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleDiscoveryEngineAssistantTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Resource name of the assistant.
    /// Format:
    /// &#39;projects/{project}/locations/{location}/collections/{collection}/engines/{engine}/assistants/{assistant}&#39;
    /// 
    /// It must be a UTF-8 encoded string with a length limit of 1024 characters.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
