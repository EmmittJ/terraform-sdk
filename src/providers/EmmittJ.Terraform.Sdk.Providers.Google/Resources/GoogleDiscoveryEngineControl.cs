using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for boost_action in .
/// Nesting mode: list
/// </summary>
public class GoogleDiscoveryEngineControlBoostActionBlock : ITerraformBlock
{
    /// <summary>
    /// The data store to boost.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataStore is required")]
    [TerraformPropertyName("data_store")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DataStore { get; set; }

    /// <summary>
    /// The filter to apply to the search results.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filter is required")]
    [TerraformPropertyName("filter")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Filter { get; set; }

    /// <summary>
    /// The fixed boost value to apply to the search results. Positive values will increase the relevance of the results, while negative values will decrease the relevance. The value must be between -100 and 100.
    /// </summary>
    [TerraformPropertyName("fixed_boost")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? FixedBoost { get; set; }

}

/// <summary>
/// Block type for conditions in .
/// Nesting mode: list
/// </summary>
public class GoogleDiscoveryEngineControlConditionsBlock : ITerraformBlock
{
    /// <summary>
    /// The regular expression that the query must match for this condition to be met.
    /// </summary>
    [TerraformPropertyName("query_regex")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? QueryRegex { get; set; }

}

/// <summary>
/// Block type for filter_action in .
/// Nesting mode: list
/// </summary>
public class GoogleDiscoveryEngineControlFilterActionBlock : ITerraformBlock
{
    /// <summary>
    /// The data store to filter.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataStore is required")]
    [TerraformPropertyName("data_store")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DataStore { get; set; }

    /// <summary>
    /// The filter to apply to the search results.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filter is required")]
    [TerraformPropertyName("filter")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Filter { get; set; }

}

/// <summary>
/// Block type for promote_action in .
/// Nesting mode: list
/// </summary>
public class GoogleDiscoveryEngineControlPromoteActionBlock : ITerraformBlock
{
    /// <summary>
    /// The data store to promote.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataStore is required")]
    [TerraformPropertyName("data_store")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DataStore { get; set; }

}

/// <summary>
/// Block type for redirect_action in .
/// Nesting mode: list
/// </summary>
public class GoogleDiscoveryEngineControlRedirectActionBlock : ITerraformBlock
{
    /// <summary>
    /// The URI to redirect to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RedirectUri is required")]
    [TerraformPropertyName("redirect_uri")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RedirectUri { get; set; }

}

/// <summary>
/// Block type for synonyms_action in .
/// Nesting mode: list
/// </summary>
public class GoogleDiscoveryEngineControlSynonymsActionBlock : ITerraformBlock
{
    /// <summary>
    /// The synonyms to apply to the search results.
    /// </summary>
    [TerraformPropertyName("synonyms")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? Synonyms { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDiscoveryEngineControlTimeoutsBlock : ITerraformBlock
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
/// Manages a google_discovery_engine_control resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDiscoveryEngineControl : TerraformResource
{
    public GoogleDiscoveryEngineControl(string name) : base("google_discovery_engine_control", name)
    {
    }

    /// <summary>
    /// The collection ID. Currently only accepts &amp;quot;default_collection&amp;quot;.
    /// </summary>
    [TerraformPropertyName("collection_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CollectionId { get; set; }

    /// <summary>
    /// The unique id of the control.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ControlId is required")]
    [TerraformPropertyName("control_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ControlId { get; set; }

    /// <summary>
    /// The display name of the control. This field must be a UTF-8 encoded
    /// string with a length limit of 128 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformPropertyName("display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DisplayName { get; set; }

    /// <summary>
    /// The engine to add the control to.
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
    /// The solution type that the control belongs to. Possible values: [&amp;quot;SOLUTION_TYPE_RECOMMENDATION&amp;quot;, &amp;quot;SOLUTION_TYPE_SEARCH&amp;quot;, &amp;quot;SOLUTION_TYPE_CHAT&amp;quot;, &amp;quot;SOLUTION_TYPE_GENERATIVE_CHAT&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SolutionType is required")]
    [TerraformPropertyName("solution_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SolutionType { get; set; }

    /// <summary>
    /// The use cases that the control is used for. Possible values: [&amp;quot;SEARCH_USE_CASE_SEARCH&amp;quot;, &amp;quot;SEARCH_USE_CASE_BROWSE&amp;quot;]
    /// </summary>
    [TerraformPropertyName("use_cases")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? UseCases { get; set; }

    /// <summary>
    /// Block for boost_action.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BoostAction block(s) allowed")]
    [TerraformPropertyName("boost_action")]
    public TerraformList<TerraformBlock<GoogleDiscoveryEngineControlBoostActionBlock>>? BoostAction { get; set; } = new();

    /// <summary>
    /// Block for conditions.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("conditions")]
    public TerraformList<TerraformBlock<GoogleDiscoveryEngineControlConditionsBlock>>? Conditions { get; set; } = new();

    /// <summary>
    /// Block for filter_action.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FilterAction block(s) allowed")]
    [TerraformPropertyName("filter_action")]
    public TerraformList<TerraformBlock<GoogleDiscoveryEngineControlFilterActionBlock>>? FilterAction { get; set; } = new();

    /// <summary>
    /// Block for promote_action.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PromoteAction block(s) allowed")]
    [TerraformPropertyName("promote_action")]
    public TerraformList<TerraformBlock<GoogleDiscoveryEngineControlPromoteActionBlock>>? PromoteAction { get; set; } = new();

    /// <summary>
    /// Block for redirect_action.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RedirectAction block(s) allowed")]
    [TerraformPropertyName("redirect_action")]
    public TerraformList<TerraformBlock<GoogleDiscoveryEngineControlRedirectActionBlock>>? RedirectAction { get; set; } = new();

    /// <summary>
    /// Block for synonyms_action.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SynonymsAction block(s) allowed")]
    [TerraformPropertyName("synonyms_action")]
    public TerraformList<TerraformBlock<GoogleDiscoveryEngineControlSynonymsActionBlock>>? SynonymsAction { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleDiscoveryEngineControlTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The unique full resource name of the control. Values are of the format
    /// &#39;projects/{project}/locations/{location}/collections/{collection_id}/engines/{engine_id}/controls/{control_id}&#39;.
    /// This field must be a UTF-8 encoded string with a length limit of 1024
    /// characters.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

}
