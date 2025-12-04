using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for boost_action in GoogleDiscoveryEngineControl.
/// Nesting mode: list
/// </summary>
public class GoogleDiscoveryEngineControlBoostActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "boost_action";

    /// <summary>
    /// The data store to boost.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataStore is required")]
    public required TerraformValue<string> DataStore
    {
        get => GetArgument<TerraformValue<string>>("data_store");
        set => SetArgument("data_store", value);
    }

    /// <summary>
    /// The filter to apply to the search results.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filter is required")]
    public required TerraformValue<string> Filter
    {
        get => GetArgument<TerraformValue<string>>("filter");
        set => SetArgument("filter", value);
    }

    /// <summary>
    /// The fixed boost value to apply to the search results. Positive values will increase the relevance of the results, while negative values will decrease the relevance. The value must be between -100 and 100.
    /// </summary>
    public TerraformValue<double>? FixedBoost
    {
        get => GetArgument<TerraformValue<double>>("fixed_boost");
        set => SetArgument("fixed_boost", value);
    }

    /// <summary>
    /// InterpolationBoostSpec block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InterpolationBoostSpec block(s) allowed")]
    public TerraformList<GoogleDiscoveryEngineControlBoostActionBlockInterpolationBoostSpecBlock>? InterpolationBoostSpec
    {
        get => GetArgument<TerraformList<GoogleDiscoveryEngineControlBoostActionBlockInterpolationBoostSpecBlock>>("interpolation_boost_spec");
        set => SetArgument("interpolation_boost_spec", value);
    }

}

/// <summary>
/// Block type for interpolation_boost_spec in GoogleDiscoveryEngineControlBoostActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDiscoveryEngineControlBoostActionBlockInterpolationBoostSpecBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "interpolation_boost_spec";

    /// <summary>
    /// The attribute type to be used to determine the boost amount. Possible values: [&amp;quot;NUMERICAL&amp;quot;, &amp;quot;FRESHNESS&amp;quot;]
    /// </summary>
    public TerraformValue<string>? AttributeType
    {
        get => GetArgument<TerraformValue<string>>("attribute_type");
        set => SetArgument("attribute_type", value);
    }

    /// <summary>
    /// The name of the field whose value will be used to determine the boost amount.
    /// </summary>
    public TerraformValue<string>? FieldName
    {
        get => GetArgument<TerraformValue<string>>("field_name");
        set => SetArgument("field_name", value);
    }

    /// <summary>
    /// The interpolation type to be applied to connect the control points. Possible values: [&amp;quot;LINEAR&amp;quot;]
    /// </summary>
    public TerraformValue<string>? InterpolationType
    {
        get => GetArgument<TerraformValue<string>>("interpolation_type");
        set => SetArgument("interpolation_type", value);
    }

    /// <summary>
    /// ControlPoint block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ControlPoint block(s) allowed")]
    public TerraformList<GoogleDiscoveryEngineControlBoostActionBlockInterpolationBoostSpecBlockControlPointBlock>? ControlPoint
    {
        get => GetArgument<TerraformList<GoogleDiscoveryEngineControlBoostActionBlockInterpolationBoostSpecBlockControlPointBlock>>("control_point");
        set => SetArgument("control_point", value);
    }

}

/// <summary>
/// Block type for control_point in GoogleDiscoveryEngineControlBoostActionBlockInterpolationBoostSpecBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDiscoveryEngineControlBoostActionBlockInterpolationBoostSpecBlockControlPointBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "control_point";

    /// <summary>
    /// The attribute value of the control point.
    /// </summary>
    public TerraformValue<string>? AttributeValue
    {
        get => GetArgument<TerraformValue<string>>("attribute_value");
        set => SetArgument("attribute_value", value);
    }

    /// <summary>
    /// The value between -1 to 1 by which to boost the score if the attributeValue
    /// evaluates to the value specified above.
    /// </summary>
    public TerraformValue<double>? BoostAmount
    {
        get => GetArgument<TerraformValue<double>>("boost_amount");
        set => SetArgument("boost_amount", value);
    }

}


/// <summary>
/// Block type for conditions in GoogleDiscoveryEngineControl.
/// Nesting mode: list
/// </summary>
public class GoogleDiscoveryEngineControlConditionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "conditions";

    /// <summary>
    /// The regular expression that the query must match for this condition to be met.
    /// </summary>
    public TerraformValue<string>? QueryRegex
    {
        get => GetArgument<TerraformValue<string>>("query_regex");
        set => SetArgument("query_regex", value);
    }

    /// <summary>
    /// ActiveTimeRange block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDiscoveryEngineControlConditionsBlockActiveTimeRangeBlock>? ActiveTimeRange
    {
        get => GetArgument<TerraformList<GoogleDiscoveryEngineControlConditionsBlockActiveTimeRangeBlock>>("active_time_range");
        set => SetArgument("active_time_range", value);
    }

    /// <summary>
    /// QueryTerms block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDiscoveryEngineControlConditionsBlockQueryTermsBlock>? QueryTerms
    {
        get => GetArgument<TerraformList<GoogleDiscoveryEngineControlConditionsBlockQueryTermsBlock>>("query_terms");
        set => SetArgument("query_terms", value);
    }

}

/// <summary>
/// Block type for active_time_range in GoogleDiscoveryEngineControlConditionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDiscoveryEngineControlConditionsBlockActiveTimeRangeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "active_time_range";

    /// <summary>
    /// The end time of the active time range.
    /// </summary>
    public TerraformValue<string>? EndTime
    {
        get => GetArgument<TerraformValue<string>>("end_time");
        set => SetArgument("end_time", value);
    }

    /// <summary>
    /// The start time of the active time range.
    /// </summary>
    public TerraformValue<string>? StartTime
    {
        get => GetArgument<TerraformValue<string>>("start_time");
        set => SetArgument("start_time", value);
    }

}

/// <summary>
/// Block type for query_terms in GoogleDiscoveryEngineControlConditionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDiscoveryEngineControlConditionsBlockQueryTermsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "query_terms";

    /// <summary>
    /// If true, the query term must be an exact match. Otherwise, the query term can be a partial match.
    /// </summary>
    public TerraformValue<bool>? FullMatch
    {
        get => GetArgument<TerraformValue<bool>>("full_match");
        set => SetArgument("full_match", value);
    }

    /// <summary>
    /// The value of the query term.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for filter_action in GoogleDiscoveryEngineControl.
/// Nesting mode: list
/// </summary>
public class GoogleDiscoveryEngineControlFilterActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filter_action";

    /// <summary>
    /// The data store to filter.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataStore is required")]
    public required TerraformValue<string> DataStore
    {
        get => GetArgument<TerraformValue<string>>("data_store");
        set => SetArgument("data_store", value);
    }

    /// <summary>
    /// The filter to apply to the search results.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filter is required")]
    public required TerraformValue<string> Filter
    {
        get => GetArgument<TerraformValue<string>>("filter");
        set => SetArgument("filter", value);
    }

}


/// <summary>
/// Block type for promote_action in GoogleDiscoveryEngineControl.
/// Nesting mode: list
/// </summary>
public class GoogleDiscoveryEngineControlPromoteActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "promote_action";

    /// <summary>
    /// The data store to promote.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataStore is required")]
    public required TerraformValue<string> DataStore
    {
        get => GetArgument<TerraformValue<string>>("data_store");
        set => SetArgument("data_store", value);
    }

    /// <summary>
    /// SearchLinkPromotion block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SearchLinkPromotion is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SearchLinkPromotion block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SearchLinkPromotion block(s) allowed")]
    public required TerraformList<GoogleDiscoveryEngineControlPromoteActionBlockSearchLinkPromotionBlock> SearchLinkPromotion
    {
        get => GetRequiredArgument<TerraformList<GoogleDiscoveryEngineControlPromoteActionBlockSearchLinkPromotionBlock>>("search_link_promotion");
        set => SetArgument("search_link_promotion", value);
    }

}

/// <summary>
/// Block type for search_link_promotion in GoogleDiscoveryEngineControlPromoteActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDiscoveryEngineControlPromoteActionBlockSearchLinkPromotionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "search_link_promotion";

    /// <summary>
    /// The description of the promoted link.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The document to promote.
    /// </summary>
    public TerraformValue<string>? Document
    {
        get => GetArgument<TerraformValue<string>>("document");
        set => SetArgument("document", value);
    }

    /// <summary>
    /// Return promotions for basic site search.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The image URI of the promoted link.
    /// </summary>
    public TerraformValue<string>? ImageUri
    {
        get => GetArgument<TerraformValue<string>>("image_uri");
        set => SetArgument("image_uri", value);
    }

    /// <summary>
    /// The title of the promoted link.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Title is required")]
    public required TerraformValue<string> Title
    {
        get => GetArgument<TerraformValue<string>>("title");
        set => SetArgument("title", value);
    }

    /// <summary>
    /// The URI to promote.
    /// </summary>
    public TerraformValue<string>? Uri
    {
        get => GetArgument<TerraformValue<string>>("uri");
        set => SetArgument("uri", value);
    }

}


/// <summary>
/// Block type for redirect_action in GoogleDiscoveryEngineControl.
/// Nesting mode: list
/// </summary>
public class GoogleDiscoveryEngineControlRedirectActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "redirect_action";

    /// <summary>
    /// The URI to redirect to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RedirectUri is required")]
    public required TerraformValue<string> RedirectUri
    {
        get => GetArgument<TerraformValue<string>>("redirect_uri");
        set => SetArgument("redirect_uri", value);
    }

}


/// <summary>
/// Block type for synonyms_action in GoogleDiscoveryEngineControl.
/// Nesting mode: list
/// </summary>
public class GoogleDiscoveryEngineControlSynonymsActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "synonyms_action";

    /// <summary>
    /// The synonyms to apply to the search results.
    /// </summary>
    public TerraformList<string>? Synonyms
    {
        get => GetArgument<TerraformList<string>>("synonyms");
        set => SetArgument("synonyms", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleDiscoveryEngineControl.
/// Nesting mode: single
/// </summary>
public class GoogleDiscoveryEngineControlTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_discovery_engine_control Terraform resource.
/// Manages a google_discovery_engine_control resource.
/// </summary>
public partial class GoogleDiscoveryEngineControl(string name) : TerraformResource("google_discovery_engine_control", name)
{
    /// <summary>
    /// The collection ID. Currently only accepts &amp;quot;default_collection&amp;quot;.
    /// </summary>
    public TerraformValue<string>? CollectionId
    {
        get => GetArgument<TerraformValue<string>>("collection_id");
        set => SetArgument("collection_id", value);
    }

    /// <summary>
    /// The unique id of the control.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ControlId is required")]
    public required TerraformValue<string> ControlId
    {
        get => GetArgument<TerraformValue<string>>("control_id");
        set => SetArgument("control_id", value);
    }

    /// <summary>
    /// The display name of the control. This field must be a UTF-8 encoded
    /// string with a length limit of 128 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The engine to add the control to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EngineId is required")]
    public required TerraformValue<string> EngineId
    {
        get => GetArgument<TerraformValue<string>>("engine_id");
        set => SetArgument("engine_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The geographic location where the data store should reside. The value can
    /// only be one of &amp;quot;global&amp;quot;, &amp;quot;us&amp;quot; and &amp;quot;eu&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The solution type that the control belongs to. Possible values: [&amp;quot;SOLUTION_TYPE_RECOMMENDATION&amp;quot;, &amp;quot;SOLUTION_TYPE_SEARCH&amp;quot;, &amp;quot;SOLUTION_TYPE_CHAT&amp;quot;, &amp;quot;SOLUTION_TYPE_GENERATIVE_CHAT&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SolutionType is required")]
    public required TerraformValue<string> SolutionType
    {
        get => GetArgument<TerraformValue<string>>("solution_type");
        set => SetArgument("solution_type", value);
    }

    /// <summary>
    /// The use cases that the control is used for. Possible values: [&amp;quot;SEARCH_USE_CASE_SEARCH&amp;quot;, &amp;quot;SEARCH_USE_CASE_BROWSE&amp;quot;]
    /// </summary>
    public TerraformList<string>? UseCases
    {
        get => GetArgument<TerraformList<string>>("use_cases");
        set => SetArgument("use_cases", value);
    }

    /// <summary>
    /// The unique full resource name of the control. Values are of the format
    /// &#39;projects/{project}/locations/{location}/collections/{collection_id}/engines/{engine_id}/controls/{control_id}&#39;.
    /// This field must be a UTF-8 encoded string with a length limit of 1024
    /// characters.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// BoostAction block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BoostAction block(s) allowed")]
    public TerraformList<GoogleDiscoveryEngineControlBoostActionBlock>? BoostAction
    {
        get => GetArgument<TerraformList<GoogleDiscoveryEngineControlBoostActionBlock>>("boost_action");
        set => SetArgument("boost_action", value);
    }

    /// <summary>
    /// Conditions block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDiscoveryEngineControlConditionsBlock>? Conditions
    {
        get => GetArgument<TerraformList<GoogleDiscoveryEngineControlConditionsBlock>>("conditions");
        set => SetArgument("conditions", value);
    }

    /// <summary>
    /// FilterAction block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FilterAction block(s) allowed")]
    public TerraformList<GoogleDiscoveryEngineControlFilterActionBlock>? FilterAction
    {
        get => GetArgument<TerraformList<GoogleDiscoveryEngineControlFilterActionBlock>>("filter_action");
        set => SetArgument("filter_action", value);
    }

    /// <summary>
    /// PromoteAction block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PromoteAction block(s) allowed")]
    public TerraformList<GoogleDiscoveryEngineControlPromoteActionBlock>? PromoteAction
    {
        get => GetArgument<TerraformList<GoogleDiscoveryEngineControlPromoteActionBlock>>("promote_action");
        set => SetArgument("promote_action", value);
    }

    /// <summary>
    /// RedirectAction block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RedirectAction block(s) allowed")]
    public TerraformList<GoogleDiscoveryEngineControlRedirectActionBlock>? RedirectAction
    {
        get => GetArgument<TerraformList<GoogleDiscoveryEngineControlRedirectActionBlock>>("redirect_action");
        set => SetArgument("redirect_action", value);
    }

    /// <summary>
    /// SynonymsAction block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SynonymsAction block(s) allowed")]
    public TerraformList<GoogleDiscoveryEngineControlSynonymsActionBlock>? SynonymsAction
    {
        get => GetArgument<TerraformList<GoogleDiscoveryEngineControlSynonymsActionBlock>>("synonyms_action");
        set => SetArgument("synonyms_action", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleDiscoveryEngineControlTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleDiscoveryEngineControlTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
