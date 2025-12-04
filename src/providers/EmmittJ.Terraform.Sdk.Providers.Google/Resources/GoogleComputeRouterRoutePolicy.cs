using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for terms in GoogleComputeRouterRoutePolicy.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRouterRoutePolicyTermsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "terms";

    /// <summary>
    /// The evaluation priority for this term, which must be between 0 (inclusive) and 231 (exclusive), and unique within the list.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    public required TerraformValue<double> Priority
    {
        get => GetArgument<TerraformValue<double>>("priority");
        set => SetArgument("priority", value);
    }

    /// <summary>
    /// Actions block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeRouterRoutePolicyTermsBlockActionsBlock>? Actions
    {
        get => GetArgument<TerraformList<GoogleComputeRouterRoutePolicyTermsBlockActionsBlock>>("actions");
        set => SetArgument("actions", value);
    }

    /// <summary>
    /// Match block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Match is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Match block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Match block(s) allowed")]
    public required TerraformList<GoogleComputeRouterRoutePolicyTermsBlockMatchBlock> Match
    {
        get => GetRequiredArgument<TerraformList<GoogleComputeRouterRoutePolicyTermsBlockMatchBlock>>("match");
        set => SetArgument("match", value);
    }

}

/// <summary>
/// Block type for actions in GoogleComputeRouterRoutePolicyTermsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRouterRoutePolicyTermsBlockActionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "actions";

    /// <summary>
    /// Description of the expression
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Textual representation of an expression in Common Expression
    /// Language syntax.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Expression is required")]
    public required TerraformValue<string> Expression
    {
        get => GetArgument<TerraformValue<string>>("expression");
        set => SetArgument("expression", value);
    }

    /// <summary>
    /// String indicating the location of the expression for error
    /// reporting, e.g. a file name and a position in the file
    /// </summary>
    public TerraformValue<string>? Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// Title for the expression, i.e. a short string describing its
    /// purpose.
    /// </summary>
    public TerraformValue<string>? Title
    {
        get => GetArgument<TerraformValue<string>>("title");
        set => SetArgument("title", value);
    }

}

/// <summary>
/// Block type for match in GoogleComputeRouterRoutePolicyTermsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRouterRoutePolicyTermsBlockMatchBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "match";

    /// <summary>
    /// Description of the expression
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Textual representation of an expression in Common Expression Language syntax.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Expression is required")]
    public required TerraformValue<string> Expression
    {
        get => GetArgument<TerraformValue<string>>("expression");
        set => SetArgument("expression", value);
    }

    /// <summary>
    /// String indicating the location of the expression for error reporting, e.g. a file name and a position in the file
    /// </summary>
    public TerraformValue<string>? Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// Title for the expression, i.e. a short string describing its purpose.
    /// </summary>
    public TerraformValue<string>? Title
    {
        get => GetArgument<TerraformValue<string>>("title");
        set => SetArgument("title", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleComputeRouterRoutePolicy.
/// Nesting mode: single
/// </summary>
public class GoogleComputeRouterRoutePolicyTimeoutsBlock : TerraformBlock
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
/// Represents a google_compute_router_route_policy Terraform resource.
/// Manages a google_compute_router_route_policy resource.
/// </summary>
public partial class GoogleComputeRouterRoutePolicy(string name) : TerraformResource("google_compute_router_route_policy", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Name of the route policy. This policy&#39;s name, which must be a resource ID segment and unique within all policies owned by the Router
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
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
    /// Region where the router and NAT reside.
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The name of the Cloud Router in which this route policy will be configured.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Router is required")]
    public required TerraformValue<string> Router
    {
        get => GetArgument<TerraformValue<string>>("router");
        set => SetArgument("router", value);
    }

    /// <summary>
    /// This is policy&#39;s type, which is one of IMPORT or EXPORT Possible values: [&amp;quot;ROUTE_POLICY_TYPE_IMPORT&amp;quot;, &amp;quot;ROUTE_POLICY_TYPE_EXPORT&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The fingerprint used for optimistic locking of this resource.  Used
    /// internally during updates.
    /// </summary>
    public TerraformValue<string> Fingerprint
        => AsReference("fingerprint");

    /// <summary>
    /// Terms block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Terms is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Terms block(s) required")]
    public required TerraformList<GoogleComputeRouterRoutePolicyTermsBlock> Terms
    {
        get => GetRequiredArgument<TerraformList<GoogleComputeRouterRoutePolicyTermsBlock>>("terms");
        set => SetArgument("terms", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleComputeRouterRoutePolicyTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleComputeRouterRoutePolicyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
