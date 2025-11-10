using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for customer_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleDiscoveryEngineAssistantCustomerPolicyBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for generation_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDiscoveryEngineAssistantGenerationConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The default language to use for the generation of the assistant response.
    /// Use an ISO 639-1 language code such as &#39;en&#39;.
    /// If not specified, the language will be automatically detected.
    /// </summary>
    [TerraformPropertyName("default_language")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DefaultLanguage { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDiscoveryEngineAssistantTimeoutsBlock : ITerraformBlock
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
/// Manages a google_discovery_engine_assistant resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDiscoveryEngineAssistant : TerraformResource
{
    public GoogleDiscoveryEngineAssistant(string name) : base("google_discovery_engine_assistant", name)
    {
    }

    /// <summary>
    /// The unique id of the assistant.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AssistantId is required")]
    [TerraformPropertyName("assistant_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AssistantId { get; set; }

    /// <summary>
    /// The unique id of the collection.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CollectionId is required")]
    [TerraformPropertyName("collection_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> CollectionId { get; set; }

    /// <summary>
    /// Description for additional information. Expected to be shown on the
    /// configuration UI, not to the users of the assistant.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The assistant display name.
    /// 
    /// It must be a UTF-8 encoded string with a length limit of 128 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformPropertyName("display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DisplayName { get; set; }

    /// <summary>
    /// The unique id of the engine.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EngineId is required")]
    [TerraformPropertyName("engine_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> EngineId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The geographic location where the data store should reside. The value can
    /// only be one of &amp;quot;global&amp;quot;, &amp;quot;us&amp;quot; and &amp;quot;eu&amp;quot;.
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
    /// The type of web grounding to use.
    /// The supported values: &#39;WEB_GROUNDING_TYPE_DISABLED&#39;, &#39;WEB_GROUNDING_TYPE_GOOGLE_SEARCH&#39;, &#39;WEB_GROUNDING_TYPE_ENTERPRISE_WEB_SEARCH&#39;.
    /// </summary>
    [TerraformPropertyName("web_grounding_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? WebGroundingType { get; set; }

    /// <summary>
    /// Block for customer_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomerPolicy block(s) allowed")]
    [TerraformPropertyName("customer_policy")]
    public TerraformList<TerraformBlock<GoogleDiscoveryEngineAssistantCustomerPolicyBlock>>? CustomerPolicy { get; set; } = new();

    /// <summary>
    /// Block for generation_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GenerationConfig block(s) allowed")]
    [TerraformPropertyName("generation_config")]
    public TerraformList<TerraformBlock<GoogleDiscoveryEngineAssistantGenerationConfigBlock>>? GenerationConfig { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleDiscoveryEngineAssistantTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Resource name of the assistant.
    /// Format:
    /// &#39;projects/{project}/locations/{location}/collections/{collection}/engines/{engine}/assistants/{assistant}&#39;
    /// 
    /// It must be a UTF-8 encoded string with a length limit of 1024 characters.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

}
