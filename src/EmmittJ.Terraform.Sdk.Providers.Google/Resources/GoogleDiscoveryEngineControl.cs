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
        get => GetProperty<TerraformProperty<string>>("data_store");
        set => WithProperty("data_store", value);
    }

    /// <summary>
    /// The filter to apply to the search results.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filter is required")]
    public required TerraformProperty<string> Filter
    {
        get => GetProperty<TerraformProperty<string>>("filter");
        set => WithProperty("filter", value);
    }

    /// <summary>
    /// The fixed boost value to apply to the search results. Positive values will increase the relevance of the results, while negative values will decrease the relevance. The value must be between -100 and 100.
    /// </summary>
    public TerraformProperty<double>? FixedBoost
    {
        get => GetProperty<TerraformProperty<double>>("fixed_boost");
        set => WithProperty("fixed_boost", value);
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
        get => GetProperty<TerraformProperty<string>>("query_regex");
        set => WithProperty("query_regex", value);
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
        get => GetProperty<TerraformProperty<string>>("data_store");
        set => WithProperty("data_store", value);
    }

    /// <summary>
    /// The filter to apply to the search results.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filter is required")]
    public required TerraformProperty<string> Filter
    {
        get => GetProperty<TerraformProperty<string>>("filter");
        set => WithProperty("filter", value);
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
        get => GetProperty<TerraformProperty<string>>("data_store");
        set => WithProperty("data_store", value);
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
        get => GetProperty<TerraformProperty<string>>("redirect_uri");
        set => WithProperty("redirect_uri", value);
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
        get => GetProperty<List<TerraformProperty<string>>>("synonyms");
        set => WithProperty("synonyms", value);
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
/// Manages a google_discovery_engine_control resource.
/// </summary>
public class GoogleDiscoveryEngineControl : TerraformResource
{
    public GoogleDiscoveryEngineControl(string name) : base("google_discovery_engine_control", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("name");
    }

    /// <summary>
    /// The collection ID. Currently only accepts &amp;quot;default_collection&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? CollectionId
    {
        get => GetProperty<TerraformProperty<string>>("collection_id");
        set => this.WithProperty("collection_id", value);
    }

    /// <summary>
    /// The unique id of the control.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ControlId is required")]
    public required TerraformProperty<string> ControlId
    {
        get => GetProperty<TerraformProperty<string>>("control_id");
        set => this.WithProperty("control_id", value);
    }

    /// <summary>
    /// The display name of the control. This field must be a UTF-8 encoded
    /// string with a length limit of 128 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// The engine to add the control to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EngineId is required")]
    public required TerraformProperty<string> EngineId
    {
        get => GetProperty<TerraformProperty<string>>("engine_id");
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
        get => GetProperty<TerraformProperty<string>>("location");
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
    /// The solution type that the control belongs to. Possible values: [&amp;quot;SOLUTION_TYPE_RECOMMENDATION&amp;quot;, &amp;quot;SOLUTION_TYPE_SEARCH&amp;quot;, &amp;quot;SOLUTION_TYPE_CHAT&amp;quot;, &amp;quot;SOLUTION_TYPE_GENERATIVE_CHAT&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SolutionType is required")]
    public required TerraformProperty<string> SolutionType
    {
        get => GetProperty<TerraformProperty<string>>("solution_type");
        set => this.WithProperty("solution_type", value);
    }

    /// <summary>
    /// The use cases that the control is used for. Possible values: [&amp;quot;SEARCH_USE_CASE_SEARCH&amp;quot;, &amp;quot;SEARCH_USE_CASE_BROWSE&amp;quot;]
    /// </summary>
    public List<TerraformProperty<string>>? UseCases
    {
        get => GetProperty<List<TerraformProperty<string>>>("use_cases");
        set => this.WithProperty("use_cases", value);
    }

    /// <summary>
    /// Block for boost_action.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BoostAction block(s) allowed")]
    public List<GoogleDiscoveryEngineControlBoostActionBlock>? BoostAction
    {
        get => GetProperty<List<GoogleDiscoveryEngineControlBoostActionBlock>>("boost_action");
        set => this.WithProperty("boost_action", value);
    }

    /// <summary>
    /// Block for conditions.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleDiscoveryEngineControlConditionsBlock>? Conditions
    {
        get => GetProperty<List<GoogleDiscoveryEngineControlConditionsBlock>>("conditions");
        set => this.WithProperty("conditions", value);
    }

    /// <summary>
    /// Block for filter_action.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FilterAction block(s) allowed")]
    public List<GoogleDiscoveryEngineControlFilterActionBlock>? FilterAction
    {
        get => GetProperty<List<GoogleDiscoveryEngineControlFilterActionBlock>>("filter_action");
        set => this.WithProperty("filter_action", value);
    }

    /// <summary>
    /// Block for promote_action.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PromoteAction block(s) allowed")]
    public List<GoogleDiscoveryEngineControlPromoteActionBlock>? PromoteAction
    {
        get => GetProperty<List<GoogleDiscoveryEngineControlPromoteActionBlock>>("promote_action");
        set => this.WithProperty("promote_action", value);
    }

    /// <summary>
    /// Block for redirect_action.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RedirectAction block(s) allowed")]
    public List<GoogleDiscoveryEngineControlRedirectActionBlock>? RedirectAction
    {
        get => GetProperty<List<GoogleDiscoveryEngineControlRedirectActionBlock>>("redirect_action");
        set => this.WithProperty("redirect_action", value);
    }

    /// <summary>
    /// Block for synonyms_action.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SynonymsAction block(s) allowed")]
    public List<GoogleDiscoveryEngineControlSynonymsActionBlock>? SynonymsAction
    {
        get => GetProperty<List<GoogleDiscoveryEngineControlSynonymsActionBlock>>("synonyms_action");
        set => this.WithProperty("synonyms_action", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDiscoveryEngineControlTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleDiscoveryEngineControlTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The unique full resource name of the control. Values are of the format
    /// &#39;projects/{project}/locations/{location}/collections/{collection_id}/engines/{engine_id}/controls/{control_id}&#39;.
    /// This field must be a UTF-8 encoded string with a length limit of 1024
    /// characters.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
