using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for customer_policy in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDiscoveryEngineAssistantCustomerPolicyBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for generation_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDiscoveryEngineAssistantGenerationConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The default language to use for the generation of the assistant response.
    /// Use an ISO 639-1 language code such as &#39;en&#39;.
    /// If not specified, the language will be automatically detected.
    /// </summary>
    [TerraformProperty("default_language")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DefaultLanguage { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleDiscoveryEngineAssistantTimeoutsBlock : TerraformBlockBase
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
/// Manages a google_discovery_engine_assistant resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleDiscoveryEngineAssistant : TerraformResource
{
    public GoogleDiscoveryEngineAssistant(string name) : base("google_discovery_engine_assistant", name)
    {
    }

    /// <summary>
    /// The unique id of the assistant.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AssistantId is required")]
    [TerraformProperty("assistant_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> AssistantId { get; set; }

    /// <summary>
    /// The unique id of the collection.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CollectionId is required")]
    [TerraformProperty("collection_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> CollectionId { get; set; }

    /// <summary>
    /// Description for additional information. Expected to be shown on the
    /// configuration UI, not to the users of the assistant.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The assistant display name.
    /// 
    /// It must be a UTF-8 encoded string with a length limit of 128 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformProperty("display_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The unique id of the engine.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EngineId is required")]
    [TerraformProperty("engine_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> EngineId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The geographic location where the data store should reside. The value can
    /// only be one of &amp;quot;global&amp;quot;, &amp;quot;us&amp;quot; and &amp;quot;eu&amp;quot;.
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
    /// The type of web grounding to use.
    /// The supported values: &#39;WEB_GROUNDING_TYPE_DISABLED&#39;, &#39;WEB_GROUNDING_TYPE_GOOGLE_SEARCH&#39;, &#39;WEB_GROUNDING_TYPE_ENTERPRISE_WEB_SEARCH&#39;.
    /// </summary>
    [TerraformProperty("web_grounding_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? WebGroundingType { get; set; }

    /// <summary>
    /// Block for customer_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomerPolicy block(s) allowed")]
    [TerraformProperty("customer_policy")]
    public TerraformList<TerraformBlock<GoogleDiscoveryEngineAssistantCustomerPolicyBlock>>? CustomerPolicy { get; set; }

    /// <summary>
    /// Block for generation_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GenerationConfig block(s) allowed")]
    [TerraformProperty("generation_config")]
    public TerraformList<TerraformBlock<GoogleDiscoveryEngineAssistantGenerationConfigBlock>>? GenerationConfig { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleDiscoveryEngineAssistantTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Resource name of the assistant.
    /// Format:
    /// &#39;projects/{project}/locations/{location}/collections/{collection}/engines/{engine}/assistants/{assistant}&#39;
    /// 
    /// It must be a UTF-8 encoded string with a length limit of 1024 characters.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

}
