using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for boost_action in .
/// Nesting mode: list
/// </summary>
public class GoogleDiscoveryEngineControlBoostActionBlock : TerraformBlock
{
    /// <summary>
    /// The data store to boost.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataStore is required")]
    public required TerraformProperty<string> DataStore
    {
        set => SetProperty("data_store", value);
    }

    /// <summary>
    /// The filter to apply to the search results.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filter is required")]
    public required TerraformProperty<string> Filter
    {
        set => SetProperty("filter", value);
    }

    /// <summary>
    /// The fixed boost value to apply to the search results. Positive values will increase the relevance of the results, while negative values will decrease the relevance. The value must be between -100 and 100.
    /// </summary>
    public TerraformProperty<double>? FixedBoost
    {
        set => SetProperty("fixed_boost", value);
    }

}

/// <summary>
/// Block type for conditions in .
/// Nesting mode: list
/// </summary>
public class GoogleDiscoveryEngineControlConditionsBlock : TerraformBlock
{
    /// <summary>
    /// The regular expression that the query must match for this condition to be met.
    /// </summary>
    public TerraformProperty<string>? QueryRegex
    {
        set => SetProperty("query_regex", value);
    }

}

/// <summary>
/// Block type for filter_action in .
/// Nesting mode: list
/// </summary>
public class GoogleDiscoveryEngineControlFilterActionBlock : TerraformBlock
{
    /// <summary>
    /// The data store to filter.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataStore is required")]
    public required TerraformProperty<string> DataStore
    {
        set => SetProperty("data_store", value);
    }

    /// <summary>
    /// The filter to apply to the search results.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filter is required")]
    public required TerraformProperty<string> Filter
    {
        set => SetProperty("filter", value);
    }

}

/// <summary>
/// Block type for promote_action in .
/// Nesting mode: list
/// </summary>
public class GoogleDiscoveryEngineControlPromoteActionBlock : TerraformBlock
{
    /// <summary>
    /// The data store to promote.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataStore is required")]
    public required TerraformProperty<string> DataStore
    {
        set => SetProperty("data_store", value);
    }

}

/// <summary>
/// Block type for redirect_action in .
/// Nesting mode: list
/// </summary>
public class GoogleDiscoveryEngineControlRedirectActionBlock : TerraformBlock
{
    /// <summary>
    /// The URI to redirect to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RedirectUri is required")]
    public required TerraformProperty<string> RedirectUri
    {
        set => SetProperty("redirect_uri", value);
    }

}

/// <summary>
/// Block type for synonyms_action in .
/// Nesting mode: list
/// </summary>
public class GoogleDiscoveryEngineControlSynonymsActionBlock : TerraformBlock
{
    /// <summary>
    /// The synonyms to apply to the search results.
    /// </summary>
    public List<TerraformProperty<string>>? Synonyms
    {
        set => SetProperty("synonyms", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDiscoveryEngineControlTimeoutsBlock : TerraformBlock
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
/// Manages a google_discovery_engine_control resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDiscoveryEngineControl : TerraformResource
{
    public GoogleDiscoveryEngineControl(string name) : base("google_discovery_engine_control", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("name");
        SetOutput("collection_id");
        SetOutput("control_id");
        SetOutput("display_name");
        SetOutput("engine_id");
        SetOutput("id");
        SetOutput("location");
        SetOutput("project");
        SetOutput("solution_type");
        SetOutput("use_cases");
    }

    /// <summary>
    /// The collection ID. Currently only accepts &amp;quot;default_collection&amp;quot;.
    /// </summary>
    public TerraformProperty<string> CollectionId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("collection_id");
        set => SetProperty("collection_id", value);
    }

    /// <summary>
    /// The unique id of the control.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ControlId is required")]
    public required TerraformProperty<string> ControlId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("control_id");
        set => SetProperty("control_id", value);
    }

    /// <summary>
    /// The display name of the control. This field must be a UTF-8 encoded
    /// string with a length limit of 128 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// The engine to add the control to.
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
    /// The geographic location where the data store should reside. The value can
    /// only be one of &amp;quot;global&amp;quot;, &amp;quot;us&amp;quot; and &amp;quot;eu&amp;quot;.
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
    /// The solution type that the control belongs to. Possible values: [&amp;quot;SOLUTION_TYPE_RECOMMENDATION&amp;quot;, &amp;quot;SOLUTION_TYPE_SEARCH&amp;quot;, &amp;quot;SOLUTION_TYPE_CHAT&amp;quot;, &amp;quot;SOLUTION_TYPE_GENERATIVE_CHAT&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SolutionType is required")]
    public required TerraformProperty<string> SolutionType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("solution_type");
        set => SetProperty("solution_type", value);
    }

    /// <summary>
    /// The use cases that the control is used for. Possible values: [&amp;quot;SEARCH_USE_CASE_SEARCH&amp;quot;, &amp;quot;SEARCH_USE_CASE_BROWSE&amp;quot;]
    /// </summary>
    public List<TerraformProperty<string>> UseCases
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("use_cases");
        set => SetProperty("use_cases", value);
    }

    /// <summary>
    /// Block for boost_action.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BoostAction block(s) allowed")]
    public List<GoogleDiscoveryEngineControlBoostActionBlock>? BoostAction
    {
        set => SetProperty("boost_action", value);
    }

    /// <summary>
    /// Block for conditions.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleDiscoveryEngineControlConditionsBlock>? Conditions
    {
        set => SetProperty("conditions", value);
    }

    /// <summary>
    /// Block for filter_action.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FilterAction block(s) allowed")]
    public List<GoogleDiscoveryEngineControlFilterActionBlock>? FilterAction
    {
        set => SetProperty("filter_action", value);
    }

    /// <summary>
    /// Block for promote_action.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PromoteAction block(s) allowed")]
    public List<GoogleDiscoveryEngineControlPromoteActionBlock>? PromoteAction
    {
        set => SetProperty("promote_action", value);
    }

    /// <summary>
    /// Block for redirect_action.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RedirectAction block(s) allowed")]
    public List<GoogleDiscoveryEngineControlRedirectActionBlock>? RedirectAction
    {
        set => SetProperty("redirect_action", value);
    }

    /// <summary>
    /// Block for synonyms_action.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SynonymsAction block(s) allowed")]
    public List<GoogleDiscoveryEngineControlSynonymsActionBlock>? SynonymsAction
    {
        set => SetProperty("synonyms_action", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDiscoveryEngineControlTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The unique full resource name of the control. Values are of the format
    /// &#39;projects/{project}/locations/{location}/collections/{collection_id}/engines/{engine_id}/controls/{control_id}&#39;.
    /// This field must be a UTF-8 encoded string with a length limit of 1024
    /// characters.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
