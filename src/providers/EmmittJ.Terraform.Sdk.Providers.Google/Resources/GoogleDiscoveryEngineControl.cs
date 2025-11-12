using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for boost_action in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDiscoveryEngineControlBoostActionBlock() : TerraformBlock("boost_action")
{
    /// <summary>
    /// The data store to boost.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataStore is required")]
    [TerraformProperty("data_store")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DataStore { get; set; }

    /// <summary>
    /// The filter to apply to the search results.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filter is required")]
    [TerraformProperty("filter")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Filter { get; set; }

    /// <summary>
    /// The fixed boost value to apply to the search results. Positive values will increase the relevance of the results, while negative values will decrease the relevance. The value must be between -100 and 100.
    /// </summary>
    [TerraformProperty("fixed_boost")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? FixedBoost { get; set; }

}

/// <summary>
/// Block type for conditions in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDiscoveryEngineControlConditionsBlock() : TerraformBlock("conditions")
{
    /// <summary>
    /// The regular expression that the query must match for this condition to be met.
    /// </summary>
    [TerraformProperty("query_regex")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? QueryRegex { get; set; }

}

/// <summary>
/// Block type for filter_action in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDiscoveryEngineControlFilterActionBlock() : TerraformBlock("filter_action")
{
    /// <summary>
    /// The data store to filter.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataStore is required")]
    [TerraformProperty("data_store")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DataStore { get; set; }

    /// <summary>
    /// The filter to apply to the search results.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filter is required")]
    [TerraformProperty("filter")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Filter { get; set; }

}

/// <summary>
/// Block type for promote_action in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDiscoveryEngineControlPromoteActionBlock() : TerraformBlock("promote_action")
{
    /// <summary>
    /// The data store to promote.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataStore is required")]
    [TerraformProperty("data_store")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DataStore { get; set; }

}

/// <summary>
/// Block type for redirect_action in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDiscoveryEngineControlRedirectActionBlock() : TerraformBlock("redirect_action")
{
    /// <summary>
    /// The URI to redirect to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RedirectUri is required")]
    [TerraformProperty("redirect_uri")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RedirectUri { get; set; }

}

/// <summary>
/// Block type for synonyms_action in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDiscoveryEngineControlSynonymsActionBlock() : TerraformBlock("synonyms_action")
{
    /// <summary>
    /// The synonyms to apply to the search results.
    /// </summary>
    [TerraformProperty("synonyms")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? Synonyms { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleDiscoveryEngineControlTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_discovery_engine_control resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleDiscoveryEngineControl : TerraformResource
{
    public GoogleDiscoveryEngineControl(string name) : base("google_discovery_engine_control", name)
    {
    }

    /// <summary>
    /// The collection ID. Currently only accepts &amp;quot;default_collection&amp;quot;.
    /// </summary>
    [TerraformProperty("collection_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CollectionId { get; set; }

    /// <summary>
    /// The unique id of the control.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ControlId is required")]
    [TerraformProperty("control_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ControlId { get; set; }

    /// <summary>
    /// The display name of the control. This field must be a UTF-8 encoded
    /// string with a length limit of 128 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformProperty("display_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The engine to add the control to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EngineId is required")]
    [TerraformProperty("engine_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> EngineId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The geographic location where the data store should reside. The value can
    /// only be one of &amp;quot;global&amp;quot;, &amp;quot;us&amp;quot; and &amp;quot;eu&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The solution type that the control belongs to. Possible values: [&amp;quot;SOLUTION_TYPE_RECOMMENDATION&amp;quot;, &amp;quot;SOLUTION_TYPE_SEARCH&amp;quot;, &amp;quot;SOLUTION_TYPE_CHAT&amp;quot;, &amp;quot;SOLUTION_TYPE_GENERATIVE_CHAT&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SolutionType is required")]
    [TerraformProperty("solution_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SolutionType { get; set; }

    /// <summary>
    /// The use cases that the control is used for. Possible values: [&amp;quot;SEARCH_USE_CASE_SEARCH&amp;quot;, &amp;quot;SEARCH_USE_CASE_BROWSE&amp;quot;]
    /// </summary>
    [TerraformProperty("use_cases")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? UseCases { get; set; }

    /// <summary>
    /// Block for boost_action.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BoostAction block(s) allowed")]
    [TerraformProperty("boost_action")]
    public TerraformList<GoogleDiscoveryEngineControlBoostActionBlock> BoostAction { get; set; } = new();

    /// <summary>
    /// Block for conditions.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("conditions")]
    public TerraformList<GoogleDiscoveryEngineControlConditionsBlock> Conditions { get; set; } = new();

    /// <summary>
    /// Block for filter_action.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FilterAction block(s) allowed")]
    [TerraformProperty("filter_action")]
    public TerraformList<GoogleDiscoveryEngineControlFilterActionBlock> FilterAction { get; set; } = new();

    /// <summary>
    /// Block for promote_action.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PromoteAction block(s) allowed")]
    [TerraformProperty("promote_action")]
    public TerraformList<GoogleDiscoveryEngineControlPromoteActionBlock> PromoteAction { get; set; } = new();

    /// <summary>
    /// Block for redirect_action.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RedirectAction block(s) allowed")]
    [TerraformProperty("redirect_action")]
    public TerraformList<GoogleDiscoveryEngineControlRedirectActionBlock> RedirectAction { get; set; } = new();

    /// <summary>
    /// Block for synonyms_action.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SynonymsAction block(s) allowed")]
    [TerraformProperty("synonyms_action")]
    public TerraformList<GoogleDiscoveryEngineControlSynonymsActionBlock> SynonymsAction { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleDiscoveryEngineControlTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The unique full resource name of the control. Values are of the format
    /// &#39;projects/{project}/locations/{location}/collections/{collection_id}/engines/{engine_id}/controls/{control_id}&#39;.
    /// This field must be a UTF-8 encoded string with a length limit of 1024
    /// characters.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

}
