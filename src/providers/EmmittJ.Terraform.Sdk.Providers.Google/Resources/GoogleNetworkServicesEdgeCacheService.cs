using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for log_config in GoogleNetworkServicesEdgeCacheService.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesEdgeCacheServiceLogConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "log_config";

    /// <summary>
    /// Specifies whether to enable logging for traffic served by this service.
    /// </summary>
    public TerraformValue<bool>? Enable
    {
        get => GetArgument<TerraformValue<bool>>("enable");
        set => SetArgument("enable", value);
    }

    /// <summary>
    /// Configures the sampling rate of requests, where 1.0 means all logged requests are reported and 0.0 means no logged requests are reported. The default value is 1.0, and the value of the field must be in [0, 1].
    /// 
    /// This field can only be specified if logging is enabled for this service.
    /// </summary>
    public TerraformValue<double>? SampleRate
    {
        get => GetArgument<TerraformValue<double>>("sample_rate");
        set => SetArgument("sample_rate", value);
    }

}


/// <summary>
/// Block type for routing in GoogleNetworkServicesEdgeCacheService.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesEdgeCacheServiceRoutingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "routing";

    /// <summary>
    /// HostRule block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostRule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 HostRule block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(50, ErrorMessage = "Maximum 50 HostRule block(s) allowed")]
    public required TerraformList<GoogleNetworkServicesEdgeCacheServiceRoutingBlockHostRuleBlock> HostRule
    {
        get => GetRequiredArgument<TerraformList<GoogleNetworkServicesEdgeCacheServiceRoutingBlockHostRuleBlock>>("host_rule");
        set => SetArgument("host_rule", value);
    }

    /// <summary>
    /// PathMatcher block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PathMatcher is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PathMatcher block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(50, ErrorMessage = "Maximum 50 PathMatcher block(s) allowed")]
    public required TerraformList<GoogleNetworkServicesEdgeCacheServiceRoutingBlockPathMatcherBlock> PathMatcher
    {
        get => GetRequiredArgument<TerraformList<GoogleNetworkServicesEdgeCacheServiceRoutingBlockPathMatcherBlock>>("path_matcher");
        set => SetArgument("path_matcher", value);
    }

}

/// <summary>
/// Block type for host_rule in GoogleNetworkServicesEdgeCacheServiceRoutingBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesEdgeCacheServiceRoutingBlockHostRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "host_rule";

    /// <summary>
    /// A human-readable description of the hostRule.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The list of host patterns to match.
    /// 
    /// Host patterns must be valid hostnames. Ports are not allowed. Wildcard hosts are supported in the suffix or prefix form. * matches any string of ([a-z0-9-.]*). It does not match the empty string.
    /// 
    /// When multiple hosts are specified, hosts are matched in the following priority:
    /// 
    ///   1. Exact domain names: &#39;&#39;www.foo.com&#39;&#39;.
    ///   2. Suffix domain wildcards: &#39;&#39;*.foo.com&#39;&#39; or &#39;&#39;*-bar.foo.com&#39;&#39;.
    ///   3. Prefix domain wildcards: &#39;&#39;foo.*&#39;&#39; or &#39;&#39;foo-*&#39;&#39;.
    ///   4. Special wildcard &#39;&#39;*&#39;&#39; matching any domain.
    /// 
    ///   Notes:
    /// 
    ///     The wildcard will not match the empty string. e.g. &#39;&#39;*-bar.foo.com&#39;&#39; will match &#39;&#39;baz-bar.foo.com&#39;&#39; but not &#39;&#39;-bar.foo.com&#39;&#39;. The longest wildcards match first. Only a single host in the entire service can match on &#39;&#39;*&#39;&#39;. A domain must be unique across all configured hosts within a service.
    /// 
    ///     Hosts are matched against the HTTP Host header, or for HTTP/2 and HTTP/3, the &amp;quot;:authority&amp;quot; header, from the incoming request.
    /// 
    ///     You may specify up to 10 hosts.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hosts is required")]
    public TerraformList<string>? Hosts
    {
        get => GetArgument<TerraformList<string>>("hosts");
        set => SetArgument("hosts", value);
    }

    /// <summary>
    /// The name of the pathMatcher associated with this hostRule.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PathMatcher is required")]
    public required TerraformValue<string> PathMatcher
    {
        get => GetArgument<TerraformValue<string>>("path_matcher");
        set => SetArgument("path_matcher", value);
    }

}

/// <summary>
/// Block type for path_matcher in GoogleNetworkServicesEdgeCacheServiceRoutingBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesEdgeCacheServiceRoutingBlockPathMatcherBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "path_matcher";

    /// <summary>
    /// A human-readable description of the resource.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The name to which this PathMatcher is referred by the HostRule.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// RouteRule block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RouteRule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 RouteRule block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(200, ErrorMessage = "Maximum 200 RouteRule block(s) allowed")]
    public required TerraformList<GoogleNetworkServicesEdgeCacheServiceRoutingBlockPathMatcherBlockRouteRuleBlock> RouteRule
    {
        get => GetRequiredArgument<TerraformList<GoogleNetworkServicesEdgeCacheServiceRoutingBlockPathMatcherBlockRouteRuleBlock>>("route_rule");
        set => SetArgument("route_rule", value);
    }

}

/// <summary>
/// Block type for route_rule in GoogleNetworkServicesEdgeCacheServiceRoutingBlockPathMatcherBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesEdgeCacheServiceRoutingBlockPathMatcherBlockRouteRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "route_rule";

    /// <summary>
    /// A human-readable description of the routeRule.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The Origin resource that requests to this route should fetch from when a matching response is not in cache. Origins can be defined as short names (&amp;quot;my-origin&amp;quot;) or fully-qualified resource URLs - e.g. &amp;quot;networkservices.googleapis.com/projects/my-project/global/edgecacheorigins/my-origin&amp;quot;
    /// 
    /// Only one of origin or urlRedirect can be set.
    /// </summary>
    public TerraformValue<string>? Origin
    {
        get => GetArgument<TerraformValue<string>>("origin");
        set => SetArgument("origin", value);
    }

    /// <summary>
    /// The priority of this route rule, where 1 is the highest priority.
    /// 
    /// You cannot configure two or more routeRules with the same priority. Priority for each rule must be set to a number between 1 and 999 inclusive.
    /// 
    /// Priority numbers can have gaps, which enable you to add or remove rules in the future without affecting the rest of the rules. For example, 1, 2, 3, 4, 5, 9, 12, 16 is a valid series of priority numbers
    /// to which you could add rules numbered from 6 to 8, 10 to 11, and 13 to 15 in the future without any impact on existing rules.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    public required TerraformValue<string> Priority
    {
        get => GetArgument<TerraformValue<string>>("priority");
        set => SetArgument("priority", value);
    }

    /// <summary>
    /// HeaderAction block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HeaderAction block(s) allowed")]
    public TerraformList<GoogleNetworkServicesEdgeCacheServiceRoutingBlockPathMatcherBlockRouteRuleBlockHeaderActionBlock>? HeaderAction
    {
        get => GetArgument<TerraformList<GoogleNetworkServicesEdgeCacheServiceRoutingBlockPathMatcherBlockRouteRuleBlockHeaderActionBlock>>("header_action");
        set => SetArgument("header_action", value);
    }

    /// <summary>
    /// MatchRule block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MatchRule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 MatchRule block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 MatchRule block(s) allowed")]
    public required TerraformList<GoogleNetworkServicesEdgeCacheServiceRoutingBlockPathMatcherBlockRouteRuleBlockMatchRuleBlock> MatchRule
    {
        get => GetRequiredArgument<TerraformList<GoogleNetworkServicesEdgeCacheServiceRoutingBlockPathMatcherBlockRouteRuleBlockMatchRuleBlock>>("match_rule");
        set => SetArgument("match_rule", value);
    }

    /// <summary>
    /// RouteAction block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RouteAction block(s) allowed")]
    public TerraformList<GoogleNetworkServicesEdgeCacheServiceRoutingBlockPathMatcherBlockRouteRuleBlockRouteActionBlock>? RouteAction
    {
        get => GetArgument<TerraformList<GoogleNetworkServicesEdgeCacheServiceRoutingBlockPathMatcherBlockRouteRuleBlockRouteActionBlock>>("route_action");
        set => SetArgument("route_action", value);
    }

    /// <summary>
    /// RouteMethods block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RouteMethods block(s) allowed")]
    public TerraformList<GoogleNetworkServicesEdgeCacheServiceRoutingBlockPathMatcherBlockRouteRuleBlockRouteMethodsBlock>? RouteMethods
    {
        get => GetArgument<TerraformList<GoogleNetworkServicesEdgeCacheServiceRoutingBlockPathMatcherBlockRouteRuleBlockRouteMethodsBlock>>("route_methods");
        set => SetArgument("route_methods", value);
    }

    /// <summary>
    /// UrlRedirect block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UrlRedirect block(s) allowed")]
    public TerraformList<GoogleNetworkServicesEdgeCacheServiceRoutingBlockPathMatcherBlockRouteRuleBlockUrlRedirectBlock>? UrlRedirect
    {
        get => GetArgument<TerraformList<GoogleNetworkServicesEdgeCacheServiceRoutingBlockPathMatcherBlockRouteRuleBlockUrlRedirectBlock>>("url_redirect");
        set => SetArgument("url_redirect", value);
    }

}

/// <summary>
/// Block type for header_action in GoogleNetworkServicesEdgeCacheServiceRoutingBlockPathMatcherBlockRouteRuleBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesEdgeCacheServiceRoutingBlockPathMatcherBlockRouteRuleBlockHeaderActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "header_action";

    /// <summary>
    /// RequestHeaderToAdd block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(25, ErrorMessage = "Maximum 25 RequestHeaderToAdd block(s) allowed")]
    public TerraformList<GoogleNetworkServicesEdgeCacheServiceRoutingBlockPathMatcherBlockRouteRuleBlockHeaderActionBlockRequestHeaderToAddBlock>? RequestHeaderToAdd
    {
        get => GetArgument<TerraformList<GoogleNetworkServicesEdgeCacheServiceRoutingBlockPathMatcherBlockRouteRuleBlockHeaderActionBlockRequestHeaderToAddBlock>>("request_header_to_add");
        set => SetArgument("request_header_to_add", value);
    }

    /// <summary>
    /// RequestHeaderToRemove block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(25, ErrorMessage = "Maximum 25 RequestHeaderToRemove block(s) allowed")]
    public TerraformList<GoogleNetworkServicesEdgeCacheServiceRoutingBlockPathMatcherBlockRouteRuleBlockHeaderActionBlockRequestHeaderToRemoveBlock>? RequestHeaderToRemove
    {
        get => GetArgument<TerraformList<GoogleNetworkServicesEdgeCacheServiceRoutingBlockPathMatcherBlockRouteRuleBlockHeaderActionBlockRequestHeaderToRemoveBlock>>("request_header_to_remove");
        set => SetArgument("request_header_to_remove", value);
    }

    /// <summary>
    /// ResponseHeaderToAdd block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(25, ErrorMessage = "Maximum 25 ResponseHeaderToAdd block(s) allowed")]
    public TerraformList<GoogleNetworkServicesEdgeCacheServiceRoutingBlockPathMatcherBlockRouteRuleBlockHeaderActionBlockResponseHeaderToAddBlock>? ResponseHeaderToAdd
    {
        get => GetArgument<TerraformList<GoogleNetworkServicesEdgeCacheServiceRoutingBlockPathMatcherBlockRouteRuleBlockHeaderActionBlockResponseHeaderToAddBlock>>("response_header_to_add");
        set => SetArgument("response_header_to_add", value);
    }

    /// <summary>
    /// ResponseHeaderToRemove block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(25, ErrorMessage = "Maximum 25 ResponseHeaderToRemove block(s) allowed")]
    public TerraformList<GoogleNetworkServicesEdgeCacheServiceRoutingBlockPathMatcherBlockRouteRuleBlockHeaderActionBlockResponseHeaderToRemoveBlock>? ResponseHeaderToRemove
    {
        get => GetArgument<TerraformList<GoogleNetworkServicesEdgeCacheServiceRoutingBlockPathMatcherBlockRouteRuleBlockHeaderActionBlockResponseHeaderToRemoveBlock>>("response_header_to_remove");
        set => SetArgument("response_header_to_remove", value);
    }

}

/// <summary>
/// Block type for request_header_to_add in GoogleNetworkServicesEdgeCacheServiceRoutingBlockPathMatcherBlockRouteRuleBlockHeaderActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesEdgeCacheServiceRoutingBlockPathMatcherBlockRouteRuleBlockHeaderActionBlockRequestHeaderToAddBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "request_header_to_add";

    /// <summary>
    /// The name of the header to add.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HeaderName is required")]
    public required TerraformValue<string> HeaderName
    {
        get => GetArgument<TerraformValue<string>>("header_name");
        set => SetArgument("header_name", value);
    }

    /// <summary>
    /// The value of the header to add.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HeaderValue is required")]
    public required TerraformValue<string> HeaderValue
    {
        get => GetArgument<TerraformValue<string>>("header_value");
        set => SetArgument("header_value", value);
    }

    /// <summary>
    /// Whether to replace all existing headers with the same name.
    /// </summary>
    public TerraformValue<bool>? Replace
    {
        get => GetArgument<TerraformValue<bool>>("replace");
        set => SetArgument("replace", value);
    }

}

/// <summary>
/// Block type for request_header_to_remove in GoogleNetworkServicesEdgeCacheServiceRoutingBlockPathMatcherBlockRouteRuleBlockHeaderActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesEdgeCacheServiceRoutingBlockPathMatcherBlockRouteRuleBlockHeaderActionBlockRequestHeaderToRemoveBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "request_header_to_remove";

    /// <summary>
    /// The name of the header to remove.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HeaderName is required")]
    public required TerraformValue<string> HeaderName
    {
        get => GetArgument<TerraformValue<string>>("header_name");
        set => SetArgument("header_name", value);
    }

}

/// <summary>
/// Block type for response_header_to_add in GoogleNetworkServicesEdgeCacheServiceRoutingBlockPathMatcherBlockRouteRuleBlockHeaderActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesEdgeCacheServiceRoutingBlockPathMatcherBlockRouteRuleBlockHeaderActionBlockResponseHeaderToAddBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "response_header_to_add";

    /// <summary>
    /// The name of the header to add.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HeaderName is required")]
    public required TerraformValue<string> HeaderName
    {
        get => GetArgument<TerraformValue<string>>("header_name");
        set => SetArgument("header_name", value);
    }

    /// <summary>
    /// The value of the header to add.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HeaderValue is required")]
    public required TerraformValue<string> HeaderValue
    {
        get => GetArgument<TerraformValue<string>>("header_value");
        set => SetArgument("header_value", value);
    }

    /// <summary>
    /// Whether to replace all existing headers with the same name.
    /// </summary>
    public TerraformValue<bool>? Replace
    {
        get => GetArgument<TerraformValue<bool>>("replace");
        set => SetArgument("replace", value);
    }

}

/// <summary>
/// Block type for response_header_to_remove in GoogleNetworkServicesEdgeCacheServiceRoutingBlockPathMatcherBlockRouteRuleBlockHeaderActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesEdgeCacheServiceRoutingBlockPathMatcherBlockRouteRuleBlockHeaderActionBlockResponseHeaderToRemoveBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "response_header_to_remove";

    /// <summary>
    /// Headers to remove from the response prior to sending it back to the client.
    /// 
    /// Response headers are only sent to the client, and do not have an effect on the cache serving the response.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HeaderName is required")]
    public required TerraformValue<string> HeaderName
    {
        get => GetArgument<TerraformValue<string>>("header_name");
        set => SetArgument("header_name", value);
    }

}

/// <summary>
/// Block type for match_rule in GoogleNetworkServicesEdgeCacheServiceRoutingBlockPathMatcherBlockRouteRuleBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesEdgeCacheServiceRoutingBlockPathMatcherBlockRouteRuleBlockMatchRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "match_rule";

    /// <summary>
    /// For satisfying the matchRule condition, the path of the request must exactly match the value specified in fullPathMatch after removing any query parameters and anchor that may be part of the original URL.
    /// </summary>
    public TerraformValue<string>? FullPathMatch
    {
        get => GetArgument<TerraformValue<string>>("full_path_match");
        set => SetArgument("full_path_match", value);
    }

    /// <summary>
    /// Specifies that prefixMatch and fullPathMatch matches are case sensitive.
    /// </summary>
    public TerraformValue<bool>? IgnoreCase
    {
        get => GetArgument<TerraformValue<bool>>("ignore_case");
        set => SetArgument("ignore_case", value);
    }

    /// <summary>
    /// For satisfying the matchRule condition, the path of the request
    /// must match the wildcard pattern specified in pathTemplateMatch
    /// after removing any query parameters and anchor that may be part
    /// of the original URL.
    /// 
    /// pathTemplateMatch must be between 1 and 255 characters
    /// (inclusive).  The pattern specified by pathTemplateMatch may
    /// have at most 5 wildcard operators and at most 5 variable
    /// captures in total.
    /// </summary>
    public TerraformValue<string>? PathTemplateMatch
    {
        get => GetArgument<TerraformValue<string>>("path_template_match");
        set => SetArgument("path_template_match", value);
    }

    /// <summary>
    /// For satisfying the matchRule condition, the request&#39;s path must begin with the specified prefixMatch. prefixMatch must begin with a /.
    /// </summary>
    public TerraformValue<string>? PrefixMatch
    {
        get => GetArgument<TerraformValue<string>>("prefix_match");
        set => SetArgument("prefix_match", value);
    }

    /// <summary>
    /// HeaderMatch block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(3, ErrorMessage = "Maximum 3 HeaderMatch block(s) allowed")]
    public TerraformList<GoogleNetworkServicesEdgeCacheServiceRoutingBlockPathMatcherBlockRouteRuleBlockMatchRuleBlockHeaderMatchBlock>? HeaderMatch
    {
        get => GetArgument<TerraformList<GoogleNetworkServicesEdgeCacheServiceRoutingBlockPathMatcherBlockRouteRuleBlockMatchRuleBlockHeaderMatchBlock>>("header_match");
        set => SetArgument("header_match", value);
    }

    /// <summary>
    /// QueryParameterMatch block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 QueryParameterMatch block(s) allowed")]
    public TerraformList<GoogleNetworkServicesEdgeCacheServiceRoutingBlockPathMatcherBlockRouteRuleBlockMatchRuleBlockQueryParameterMatchBlock>? QueryParameterMatch
    {
        get => GetArgument<TerraformList<GoogleNetworkServicesEdgeCacheServiceRoutingBlockPathMatcherBlockRouteRuleBlockMatchRuleBlockQueryParameterMatchBlock>>("query_parameter_match");
        set => SetArgument("query_parameter_match", value);
    }

}

/// <summary>
/// Block type for header_match in GoogleNetworkServicesEdgeCacheServiceRoutingBlockPathMatcherBlockRouteRuleBlockMatchRuleBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesEdgeCacheServiceRoutingBlockPathMatcherBlockRouteRuleBlockMatchRuleBlockHeaderMatchBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "header_match";

    /// <summary>
    /// The value of the header should exactly match contents of exactMatch.
    /// </summary>
    public TerraformValue<string>? ExactMatch
    {
        get => GetArgument<TerraformValue<string>>("exact_match");
        set => SetArgument("exact_match", value);
    }

    /// <summary>
    /// The header name to match on.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HeaderName is required")]
    public required TerraformValue<string> HeaderName
    {
        get => GetArgument<TerraformValue<string>>("header_name");
        set => SetArgument("header_name", value);
    }

    /// <summary>
    /// If set to false (default), the headerMatch is considered a match if the match criteria above are met.
    /// If set to true, the headerMatch is considered a match if the match criteria above are NOT met.
    /// </summary>
    public TerraformValue<bool>? InvertMatch
    {
        get => GetArgument<TerraformValue<bool>>("invert_match");
        set => SetArgument("invert_match", value);
    }

    /// <summary>
    /// The value of the header must start with the contents of prefixMatch.
    /// </summary>
    public TerraformValue<string>? PrefixMatch
    {
        get => GetArgument<TerraformValue<string>>("prefix_match");
        set => SetArgument("prefix_match", value);
    }

    /// <summary>
    /// A header with the contents of headerName must exist. The match takes place whether or not the request&#39;s header has a value.
    /// </summary>
    public TerraformValue<bool>? PresentMatch
    {
        get => GetArgument<TerraformValue<bool>>("present_match");
        set => SetArgument("present_match", value);
    }

    /// <summary>
    /// The value of the header must end with the contents of suffixMatch.
    /// </summary>
    public TerraformValue<string>? SuffixMatch
    {
        get => GetArgument<TerraformValue<string>>("suffix_match");
        set => SetArgument("suffix_match", value);
    }

}

/// <summary>
/// Block type for query_parameter_match in GoogleNetworkServicesEdgeCacheServiceRoutingBlockPathMatcherBlockRouteRuleBlockMatchRuleBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesEdgeCacheServiceRoutingBlockPathMatcherBlockRouteRuleBlockMatchRuleBlockQueryParameterMatchBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "query_parameter_match";

    /// <summary>
    /// The queryParameterMatch matches if the value of the parameter exactly matches the contents of exactMatch.
    /// </summary>
    public TerraformValue<string>? ExactMatch
    {
        get => GetArgument<TerraformValue<string>>("exact_match");
        set => SetArgument("exact_match", value);
    }

    /// <summary>
    /// The name of the query parameter to match. The query parameter must exist in the request, in the absence of which the request match fails.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Specifies that the queryParameterMatch matches if the request contains the query parameter, irrespective of whether the parameter has a value or not.
    /// </summary>
    public TerraformValue<bool>? PresentMatch
    {
        get => GetArgument<TerraformValue<bool>>("present_match");
        set => SetArgument("present_match", value);
    }

}

/// <summary>
/// Block type for route_action in GoogleNetworkServicesEdgeCacheServiceRoutingBlockPathMatcherBlockRouteRuleBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesEdgeCacheServiceRoutingBlockPathMatcherBlockRouteRuleBlockRouteActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "route_action";

    /// <summary>
    /// Setting the compression mode to automatic enables dynamic compression for every eligible response.
    /// 
    /// When dynamic compression is enabled, it is recommended to also set a cache policy to maximize efficiency. Possible values: [&amp;quot;DISABLED&amp;quot;, &amp;quot;AUTOMATIC&amp;quot;]
    /// </summary>
    public TerraformValue<string>? CompressionMode
    {
        get => GetArgument<TerraformValue<string>>("compression_mode");
        set => SetArgument("compression_mode", value);
    }

    /// <summary>
    /// CdnPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CdnPolicy block(s) allowed")]
    public TerraformList<GoogleNetworkServicesEdgeCacheServiceRoutingBlockPathMatcherBlockRouteRuleBlockRouteActionBlockCdnPolicyBlock>? CdnPolicy
    {
        get => GetArgument<TerraformList<GoogleNetworkServicesEdgeCacheServiceRoutingBlockPathMatcherBlockRouteRuleBlockRouteActionBlockCdnPolicyBlock>>("cdn_policy");
        set => SetArgument("cdn_policy", value);
    }

    /// <summary>
    /// CorsPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CorsPolicy block(s) allowed")]
    public TerraformList<GoogleNetworkServicesEdgeCacheServiceRoutingBlockPathMatcherBlockRouteRuleBlockRouteActionBlockCorsPolicyBlock>? CorsPolicy
    {
        get => GetArgument<TerraformList<GoogleNetworkServicesEdgeCacheServiceRoutingBlockPathMatcherBlockRouteRuleBlockRouteActionBlockCorsPolicyBlock>>("cors_policy");
        set => SetArgument("cors_policy", value);
    }

    /// <summary>
    /// UrlRewrite block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UrlRewrite block(s) allowed")]
    public TerraformList<GoogleNetworkServicesEdgeCacheServiceRoutingBlockPathMatcherBlockRouteRuleBlockRouteActionBlockUrlRewriteBlock>? UrlRewrite
    {
        get => GetArgument<TerraformList<GoogleNetworkServicesEdgeCacheServiceRoutingBlockPathMatcherBlockRouteRuleBlockRouteActionBlockUrlRewriteBlock>>("url_rewrite");
        set => SetArgument("url_rewrite", value);
    }

}

/// <summary>
/// Block type for cdn_policy in GoogleNetworkServicesEdgeCacheServiceRoutingBlockPathMatcherBlockRouteRuleBlockRouteActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesEdgeCacheServiceRoutingBlockPathMatcherBlockRouteRuleBlockRouteActionBlockCdnPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cdn_policy";

    /// <summary>
    /// Cache modes allow users to control the behaviour of the cache, what content it should cache automatically, whether to respect origin headers, or whether to unconditionally cache all responses.
    /// 
    /// For all cache modes, Cache-Control headers will be passed to the client. Use clientTtl to override what is sent to the client. Possible values: [&amp;quot;CACHE_ALL_STATIC&amp;quot;, &amp;quot;USE_ORIGIN_HEADERS&amp;quot;, &amp;quot;FORCE_CACHE_ALL&amp;quot;, &amp;quot;BYPASS_CACHE&amp;quot;]
    /// </summary>
    public TerraformValue<string>? CacheMode
    {
        get => GetArgument<TerraformValue<string>>("cache_mode");
        set => SetArgument("cache_mode", value);
    }

    /// <summary>
    /// Specifies a separate client (e.g. browser client) TTL, separate from the TTL used by the edge caches. Leaving this empty will use the same cache TTL for both the CDN and the client-facing response.
    /// 
    /// - The TTL must be &amp;gt; 0 and &amp;lt;= 86400s (1 day)
    /// - The clientTtl cannot be larger than the defaultTtl (if set)
    /// - Fractions of a second are not allowed.
    /// 
    /// Omit this field to use the defaultTtl, or the max-age set by the origin, as the client-facing TTL.
    /// 
    /// When the cache mode is set to &amp;quot;USE_ORIGIN_HEADERS&amp;quot; or &amp;quot;BYPASS_CACHE&amp;quot;, you must omit this field.
    /// A duration in seconds terminated by &#39;s&#39;. Example: &amp;quot;3s&amp;quot;.
    /// </summary>
    public TerraformValue<string>? ClientTtl
    {
        get => GetArgument<TerraformValue<string>>("client_ttl");
        set => SetArgument("client_ttl", value);
    }

    /// <summary>
    /// Specifies the default TTL for cached content served by this origin for responses that do not have an existing valid TTL (max-age or s-max-age).
    /// 
    /// Defaults to 3600s (1 hour).
    /// 
    /// - The TTL must be &amp;gt;= 0 and &amp;lt;= 31,536,000 seconds (1 year)
    /// - Setting a TTL of &amp;quot;0&amp;quot; means &amp;quot;always revalidate&amp;quot; (equivalent to must-revalidate)
    /// - The value of defaultTTL cannot be set to a value greater than that of maxTTL.
    /// - Fractions of a second are not allowed.
    /// - When the cacheMode is set to FORCE_CACHE_ALL, the defaultTTL will overwrite the TTL set in all responses.
    /// 
    /// Note that infrequently accessed objects may be evicted from the cache before the defined TTL. Objects that expire will be revalidated with the origin.
    /// 
    /// When the cache mode is set to &amp;quot;USE_ORIGIN_HEADERS&amp;quot; or &amp;quot;BYPASS_CACHE&amp;quot;, you must omit this field.
    /// 
    /// A duration in seconds terminated by &#39;s&#39;. Example: &amp;quot;3s&amp;quot;.
    /// </summary>
    public TerraformValue<string>? DefaultTtl
    {
        get => GetArgument<TerraformValue<string>>("default_ttl");
        set => SetArgument("default_ttl", value);
    }

    /// <summary>
    /// Specifies the maximum allowed TTL for cached content served by this origin.
    /// 
    /// Defaults to 86400s (1 day).
    /// 
    /// Cache directives that attempt to set a max-age or s-maxage higher than this, or an Expires header more than maxTtl seconds in the future will be capped at the value of maxTTL, as if it were the value of an s-maxage Cache-Control directive.
    /// 
    /// - The TTL must be &amp;gt;= 0 and &amp;lt;= 31,536,000 seconds (1 year)
    /// - Setting a TTL of &amp;quot;0&amp;quot; means &amp;quot;always revalidate&amp;quot;
    /// - The value of maxTtl must be equal to or greater than defaultTtl.
    /// - Fractions of a second are not allowed.
    /// 
    /// When the cache mode is set to &amp;quot;USE_ORIGIN_HEADERS&amp;quot;, &amp;quot;FORCE_CACHE_ALL&amp;quot;, or &amp;quot;BYPASS_CACHE&amp;quot;, you must omit this field.
    /// 
    /// A duration in seconds terminated by &#39;s&#39;. Example: &amp;quot;3s&amp;quot;.
    /// </summary>
    public TerraformValue<string>? MaxTtl
    {
        get => GetArgument<TerraformValue<string>>("max_ttl");
        set => SetArgument("max_ttl", value);
    }

    /// <summary>
    /// Negative caching allows per-status code TTLs to be set, in order to apply fine-grained caching for common errors or redirects. This can reduce the load on your origin and improve end-user experience by reducing response latency.
    /// 
    /// By default, the CDNPolicy will apply the following default TTLs to these status codes:
    /// 
    /// - HTTP 300 (Multiple Choice), 301, 308 (Permanent Redirects): 10m
    /// - HTTP 404 (Not Found), 410 (Gone), 451 (Unavailable For Legal Reasons): 120s
    /// - HTTP 405 (Method Not Found), 414 (URI Too Long), 501 (Not Implemented): 60s
    /// 
    /// These defaults can be overridden in negativeCachingPolicy
    /// </summary>
    public TerraformValue<bool>? NegativeCaching
    {
        get => GetArgument<TerraformValue<bool>>("negative_caching");
        set => SetArgument("negative_caching", value);
    }

    /// <summary>
    /// Sets a cache TTL for the specified HTTP status code. negativeCaching must be enabled to configure negativeCachingPolicy.
    /// 
    /// - Omitting the policy and leaving negativeCaching enabled will use the default TTLs for each status code, defined in negativeCaching.
    /// - TTLs must be &amp;gt;= 0 (where 0 is &amp;quot;always revalidate&amp;quot;) and &amp;lt;= 86400s (1 day)
    /// 
    /// Note that when specifying an explicit negativeCachingPolicy, you should take care to specify a cache TTL for all response codes that you wish to cache. The CDNPolicy will not apply any default negative caching when a policy exists.
    /// </summary>
    public TerraformMap<string>? NegativeCachingPolicy
    {
        get => GetArgument<TerraformMap<string>>("negative_caching_policy");
        set => SetArgument("negative_caching_policy", value);
    }

    /// <summary>
    /// The EdgeCacheKeyset containing the set of public keys used to validate signed requests at the edge.
    /// </summary>
    public TerraformValue<string>? SignedRequestKeyset
    {
        get => GetArgument<TerraformValue<string>>("signed_request_keyset");
        set => SetArgument("signed_request_keyset", value);
    }

    /// <summary>
    /// Limit how far into the future the expiration time of a signed request may be.
    /// 
    /// When set, a signed request is rejected if its expiration time is later than now + signedRequestMaximumExpirationTtl, where now is the time at which the signed request is first handled by the CDN.
    /// 
    /// - The TTL must be &amp;gt; 0.
    /// - Fractions of a second are not allowed.
    /// 
    /// By default, signedRequestMaximumExpirationTtl is not set and the expiration time of a signed request may be arbitrarily far into future.
    /// </summary>
    public TerraformValue<string>? SignedRequestMaximumExpirationTtl
    {
        get => GetArgument<TerraformValue<string>>("signed_request_maximum_expiration_ttl");
        set => SetArgument("signed_request_maximum_expiration_ttl", value);
    }

    /// <summary>
    /// Whether to enforce signed requests. The default value is DISABLED, which means all content is public, and does not authorize access.
    /// 
    /// You must also set a signedRequestKeyset to enable signed requests.
    /// 
    /// When set to REQUIRE_SIGNATURES, all matching requests will have their signature validated. Requests that were not signed with the corresponding private key, or that are otherwise invalid (expired, do not match the signature, IP address, or header) will be rejected with a HTTP 403 and (if enabled) logged. Possible values: [&amp;quot;DISABLED&amp;quot;, &amp;quot;REQUIRE_SIGNATURES&amp;quot;, &amp;quot;REQUIRE_TOKENS&amp;quot;]
    /// </summary>
    public TerraformValue<string>? SignedRequestMode
    {
        get => GetArgument<TerraformValue<string>>("signed_request_mode");
        set => SetArgument("signed_request_mode", value);
    }

    /// <summary>
    /// AddSignatures block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AddSignatures block(s) allowed")]
    public TerraformList<GoogleNetworkServicesEdgeCacheServiceRoutingBlockPathMatcherBlockRouteRuleBlockRouteActionBlockCdnPolicyBlockAddSignaturesBlock>? AddSignatures
    {
        get => GetArgument<TerraformList<GoogleNetworkServicesEdgeCacheServiceRoutingBlockPathMatcherBlockRouteRuleBlockRouteActionBlockCdnPolicyBlockAddSignaturesBlock>>("add_signatures");
        set => SetArgument("add_signatures", value);
    }

    /// <summary>
    /// CacheKeyPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CacheKeyPolicy block(s) allowed")]
    public TerraformList<GoogleNetworkServicesEdgeCacheServiceRoutingBlockPathMatcherBlockRouteRuleBlockRouteActionBlockCdnPolicyBlockCacheKeyPolicyBlock>? CacheKeyPolicy
    {
        get => GetArgument<TerraformList<GoogleNetworkServicesEdgeCacheServiceRoutingBlockPathMatcherBlockRouteRuleBlockRouteActionBlockCdnPolicyBlockCacheKeyPolicyBlock>>("cache_key_policy");
        set => SetArgument("cache_key_policy", value);
    }

    /// <summary>
    /// SignedTokenOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SignedTokenOptions block(s) allowed")]
    public TerraformList<GoogleNetworkServicesEdgeCacheServiceRoutingBlockPathMatcherBlockRouteRuleBlockRouteActionBlockCdnPolicyBlockSignedTokenOptionsBlock>? SignedTokenOptions
    {
        get => GetArgument<TerraformList<GoogleNetworkServicesEdgeCacheServiceRoutingBlockPathMatcherBlockRouteRuleBlockRouteActionBlockCdnPolicyBlockSignedTokenOptionsBlock>>("signed_token_options");
        set => SetArgument("signed_token_options", value);
    }

}

/// <summary>
/// Block type for add_signatures in GoogleNetworkServicesEdgeCacheServiceRoutingBlockPathMatcherBlockRouteRuleBlockRouteActionBlockCdnPolicyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesEdgeCacheServiceRoutingBlockPathMatcherBlockRouteRuleBlockRouteActionBlockCdnPolicyBlockAddSignaturesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "add_signatures";

    /// <summary>
    /// The actions to take to add signatures to responses. Possible values: [&amp;quot;GENERATE_COOKIE&amp;quot;, &amp;quot;GENERATE_TOKEN_HLS_COOKIELESS&amp;quot;, &amp;quot;PROPAGATE_TOKEN_HLS_COOKIELESS&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Actions is required")]
    public TerraformList<string>? Actions
    {
        get => GetArgument<TerraformList<string>>("actions");
        set => SetArgument("actions", value);
    }

    /// <summary>
    /// The parameters to copy from the verified token to the generated token.
    /// 
    /// Only the following parameters may be copied:
    /// 
    ///   * &#39;PathGlobs&#39;
    ///   * &#39;paths&#39;
    ///   * &#39;acl&#39;
    ///   * &#39;URLPrefix&#39;
    ///   * &#39;IPRanges&#39;
    ///   * &#39;SessionID&#39;
    ///   * &#39;id&#39;
    ///   * &#39;Data&#39;
    ///   * &#39;data&#39;
    ///   * &#39;payload&#39;
    ///   * &#39;Headers&#39;
    /// 
    /// You may specify up to 6 parameters to copy.  A given parameter is be copied only if the parameter exists in the verified token.  Parameter names are matched exactly as specified.  The order of the parameters does not matter.  Duplicates are not allowed.
    /// 
    /// This field may only be specified when the GENERATE_COOKIE or GENERATE_TOKEN_HLS_COOKIELESS actions are specified.
    /// </summary>
    public TerraformList<string>? CopiedParameters
    {
        get => GetArgument<TerraformList<string>>("copied_parameters");
        set => SetArgument("copied_parameters", value);
    }

    /// <summary>
    /// The keyset to use for signature generation.
    /// 
    /// The following are both valid paths to an EdgeCacheKeyset resource:
    /// 
    ///   * &#39;projects/project/locations/global/edgeCacheKeysets/yourKeyset&#39;
    ///   * &#39;yourKeyset&#39;
    /// 
    /// This must be specified when the GENERATE_COOKIE or GENERATE_TOKEN_HLS_COOKIELESS actions are specified.  This field may not be specified otherwise.
    /// </summary>
    public TerraformValue<string>? Keyset
    {
        get => GetArgument<TerraformValue<string>>("keyset");
        set => SetArgument("keyset", value);
    }

    /// <summary>
    /// The query parameter in which to put the generated token.
    /// 
    /// If not specified, defaults to &#39;edge-cache-token&#39;.
    /// 
    /// If specified, the name must be 1-64 characters long and match the regular expression &#39;[a-zA-Z]([a-zA-Z0-9_-])*&#39; which means the first character must be a letter, and all following characters must be a dash, underscore, letter or digit.
    /// 
    /// This field may only be set when the GENERATE_TOKEN_HLS_COOKIELESS or PROPAGATE_TOKEN_HLS_COOKIELESS actions are specified.
    /// </summary>
    public TerraformValue<string>? TokenQueryParameter
    {
        get => GetArgument<TerraformValue<string>>("token_query_parameter");
        set => SetArgument("token_query_parameter", value);
    }

    /// <summary>
    /// The duration the token is valid starting from the moment the token is first generated.
    /// 
    /// Defaults to &#39;86400s&#39; (1 day).
    /// 
    /// The TTL must be &amp;gt;= 0 and &amp;lt;= 604,800 seconds (1 week).
    /// 
    /// This field may only be specified when the GENERATE_COOKIE or GENERATE_TOKEN_HLS_COOKIELESS actions are specified.
    /// 
    /// A duration in seconds with up to nine fractional digits, terminated by &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    public TerraformValue<string>? TokenTtl
    {
        get => GetArgument<TerraformValue<string>>("token_ttl");
        set => SetArgument("token_ttl", value);
    }

}

/// <summary>
/// Block type for cache_key_policy in GoogleNetworkServicesEdgeCacheServiceRoutingBlockPathMatcherBlockRouteRuleBlockRouteActionBlockCdnPolicyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesEdgeCacheServiceRoutingBlockPathMatcherBlockRouteRuleBlockRouteActionBlockCdnPolicyBlockCacheKeyPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cache_key_policy";

    /// <summary>
    /// If true, requests to different hosts will be cached separately.
    /// 
    /// Note: this should only be enabled if hosts share the same origin and content. Removing the host from the cache key may inadvertently result in different objects being cached than intended, depending on which route the first user matched.
    /// </summary>
    public TerraformValue<bool>? ExcludeHost
    {
        get => GetArgument<TerraformValue<bool>>("exclude_host");
        set => SetArgument("exclude_host", value);
    }

    /// <summary>
    /// If true, exclude query string parameters from the cache key
    /// 
    /// If false (the default), include the query string parameters in
    /// the cache key according to includeQueryParameters and
    /// excludeQueryParameters. If neither includeQueryParameters nor
    /// excludeQueryParameters is set, the entire query string will be
    /// included.
    /// </summary>
    public TerraformValue<bool>? ExcludeQueryString
    {
        get => GetArgument<TerraformValue<bool>>("exclude_query_string");
        set => SetArgument("exclude_query_string", value);
    }

    /// <summary>
    /// Names of query string parameters to exclude from cache keys. All other parameters will be included.
    /// 
    /// Either specify includedQueryParameters or excludedQueryParameters, not both. &#39;&amp;amp;&#39; and &#39;=&#39; will be percent encoded and not treated as delimiters.
    /// </summary>
    public TerraformList<string>? ExcludedQueryParameters
    {
        get => GetArgument<TerraformList<string>>("excluded_query_parameters");
        set => SetArgument("excluded_query_parameters", value);
    }

    /// <summary>
    /// If true, http and https requests will be cached separately.
    /// </summary>
    public TerraformValue<bool>? IncludeProtocol
    {
        get => GetArgument<TerraformValue<bool>>("include_protocol");
        set => SetArgument("include_protocol", value);
    }

    /// <summary>
    /// Names of Cookies to include in cache keys.  The cookie name and cookie value of each cookie named will be used as part of the cache key.
    /// 
    /// Cookie names:
    ///   - must be valid RFC 6265 &amp;quot;cookie-name&amp;quot; tokens
    ///   - are case sensitive
    ///   - cannot start with &amp;quot;Edge-Cache-&amp;quot; (case insensitive)
    /// 
    ///   Note that specifying several cookies, and/or cookies that have a large range of values (e.g., per-user) will dramatically impact the cache hit rate, and may result in a higher eviction rate and reduced performance.
    /// 
    ///   You may specify up to three cookie names.
    /// </summary>
    public TerraformList<string>? IncludedCookieNames
    {
        get => GetArgument<TerraformList<string>>("included_cookie_names");
        set => SetArgument("included_cookie_names", value);
    }

    /// <summary>
    /// Names of HTTP request headers to include in cache keys. The value of the header field will be used as part of the cache key.
    /// 
    /// - Header names must be valid HTTP RFC 7230 header field values.
    /// - Header field names are case insensitive
    /// - To include the HTTP method, use &amp;quot;:method&amp;quot;
    /// 
    /// Note that specifying several headers, and/or headers that have a large range of values (e.g. per-user) will dramatically impact the cache hit rate, and may result in a higher eviction rate and reduced performance.
    /// </summary>
    public TerraformList<string>? IncludedHeaderNames
    {
        get => GetArgument<TerraformList<string>>("included_header_names");
        set => SetArgument("included_header_names", value);
    }

    /// <summary>
    /// Names of query string parameters to include in cache keys. All other parameters will be excluded.
    /// 
    /// Either specify includedQueryParameters or excludedQueryParameters, not both. &#39;&amp;amp;&#39; and &#39;=&#39; will be percent encoded and not treated as delimiters.
    /// </summary>
    public TerraformList<string>? IncludedQueryParameters
    {
        get => GetArgument<TerraformList<string>>("included_query_parameters");
        set => SetArgument("included_query_parameters", value);
    }

}

/// <summary>
/// Block type for signed_token_options in GoogleNetworkServicesEdgeCacheServiceRoutingBlockPathMatcherBlockRouteRuleBlockRouteActionBlockCdnPolicyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesEdgeCacheServiceRoutingBlockPathMatcherBlockRouteRuleBlockRouteActionBlockCdnPolicyBlockSignedTokenOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "signed_token_options";

    /// <summary>
    /// The allowed signature algorithms to use.
    /// 
    /// Defaults to using only ED25519.
    /// 
    /// You may specify up to 3 signature algorithms to use. Possible values: [&amp;quot;ED25519&amp;quot;, &amp;quot;HMAC_SHA_256&amp;quot;, &amp;quot;HMAC_SHA1&amp;quot;]
    /// </summary>
    public TerraformList<string>? AllowedSignatureAlgorithms
    {
        get => GetArgument<TerraformList<string>>("allowed_signature_algorithms");
        set => SetArgument("allowed_signature_algorithms", value);
    }

    /// <summary>
    /// The query parameter in which to find the token.
    /// 
    /// The name must be 1-64 characters long and match the regular expression &#39;[a-zA-Z]([a-zA-Z0-9_-])*&#39; which means the first character must be a letter, and all following characters must be a dash, underscore, letter or digit.
    /// 
    /// Defaults to &#39;edge-cache-token&#39;.
    /// </summary>
    public TerraformValue<string>? TokenQueryParameter
    {
        get => GetArgument<TerraformValue<string>>("token_query_parameter");
        set => SetArgument("token_query_parameter", value);
    }

}

/// <summary>
/// Block type for cors_policy in GoogleNetworkServicesEdgeCacheServiceRoutingBlockPathMatcherBlockRouteRuleBlockRouteActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesEdgeCacheServiceRoutingBlockPathMatcherBlockRouteRuleBlockRouteActionBlockCorsPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cors_policy";

    /// <summary>
    /// In response to a preflight request, setting this to true indicates that the actual request can include user credentials.
    /// 
    /// This translates to the Access-Control-Allow-Credentials response header.
    /// </summary>
    public TerraformValue<bool>? AllowCredentials
    {
        get => GetArgument<TerraformValue<bool>>("allow_credentials");
        set => SetArgument("allow_credentials", value);
    }

    /// <summary>
    /// Specifies the content for the Access-Control-Allow-Headers response header.
    /// </summary>
    public TerraformList<string>? AllowHeaders
    {
        get => GetArgument<TerraformList<string>>("allow_headers");
        set => SetArgument("allow_headers", value);
    }

    /// <summary>
    /// Specifies the content for the Access-Control-Allow-Methods response header.
    /// </summary>
    public TerraformList<string>? AllowMethods
    {
        get => GetArgument<TerraformList<string>>("allow_methods");
        set => SetArgument("allow_methods", value);
    }

    /// <summary>
    /// Specifies the list of origins that will be allowed to do CORS requests.
    /// 
    /// This translates to the Access-Control-Allow-Origin response header.
    /// </summary>
    public TerraformList<string>? AllowOrigins
    {
        get => GetArgument<TerraformList<string>>("allow_origins");
        set => SetArgument("allow_origins", value);
    }

    /// <summary>
    /// If true, specifies the CORS policy is disabled. The default value is false, which indicates that the CORS policy is in effect.
    /// </summary>
    public TerraformValue<bool>? Disabled
    {
        get => GetArgument<TerraformValue<bool>>("disabled");
        set => SetArgument("disabled", value);
    }

    /// <summary>
    /// Specifies the content for the Access-Control-Allow-Headers response header.
    /// </summary>
    public TerraformList<string>? ExposeHeaders
    {
        get => GetArgument<TerraformList<string>>("expose_headers");
        set => SetArgument("expose_headers", value);
    }

    /// <summary>
    /// Specifies how long results of a preflight request can be cached by a client in seconds. Note that many browser clients enforce a maximum TTL of 600s (10 minutes).
    /// 
    /// - Setting the value to -1 forces a pre-flight check for all requests (not recommended)
    /// - A maximum TTL of 86400s can be set, but note that (as above) some clients may force pre-flight checks at a more regular interval.
    /// - This translates to the Access-Control-Max-Age header.
    /// 
    /// A duration in seconds with up to nine fractional digits, terminated by &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxAge is required")]
    public required TerraformValue<string> MaxAge
    {
        get => GetArgument<TerraformValue<string>>("max_age");
        set => SetArgument("max_age", value);
    }

}

/// <summary>
/// Block type for url_rewrite in GoogleNetworkServicesEdgeCacheServiceRoutingBlockPathMatcherBlockRouteRuleBlockRouteActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesEdgeCacheServiceRoutingBlockPathMatcherBlockRouteRuleBlockRouteActionBlockUrlRewriteBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "url_rewrite";

    /// <summary>
    /// Prior to forwarding the request to the selected origin, the request&#39;s host header is replaced with contents of hostRewrite.
    /// </summary>
    public TerraformValue<string>? HostRewrite
    {
        get => GetArgument<TerraformValue<string>>("host_rewrite");
        set => SetArgument("host_rewrite", value);
    }

    /// <summary>
    /// Prior to forwarding the request to the selected origin, the matching portion of the request&#39;s path is replaced by pathPrefixRewrite.
    /// </summary>
    public TerraformValue<string>? PathPrefixRewrite
    {
        get => GetArgument<TerraformValue<string>>("path_prefix_rewrite");
        set => SetArgument("path_prefix_rewrite", value);
    }

    /// <summary>
    /// Prior to forwarding the request to the selected origin, if the
    /// request matched a pathTemplateMatch, the matching portion of the
    /// request&#39;s path is replaced re-written using the pattern specified
    /// by pathTemplateRewrite.
    /// 
    /// pathTemplateRewrite must be between 1 and 255 characters
    /// (inclusive), must start with a &#39;/&#39;, and must only use variables
    /// captured by the route&#39;s pathTemplate matchers.
    /// 
    /// pathTemplateRewrite may only be used when all of a route&#39;s
    /// MatchRules specify pathTemplate.
    /// 
    /// Only one of pathPrefixRewrite and pathTemplateRewrite may be
    /// specified.
    /// </summary>
    public TerraformValue<string>? PathTemplateRewrite
    {
        get => GetArgument<TerraformValue<string>>("path_template_rewrite");
        set => SetArgument("path_template_rewrite", value);
    }

}

/// <summary>
/// Block type for route_methods in GoogleNetworkServicesEdgeCacheServiceRoutingBlockPathMatcherBlockRouteRuleBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesEdgeCacheServiceRoutingBlockPathMatcherBlockRouteRuleBlockRouteMethodsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "route_methods";

    /// <summary>
    /// The non-empty set of HTTP methods that are allowed for this route.
    /// 
    /// Any combination of &amp;quot;GET&amp;quot;, &amp;quot;HEAD&amp;quot;, &amp;quot;OPTIONS&amp;quot;, &amp;quot;PUT&amp;quot;, &amp;quot;POST&amp;quot;, &amp;quot;DELETE&amp;quot;, and &amp;quot;PATCH&amp;quot;.
    /// </summary>
    public TerraformList<string>? AllowedMethods
    {
        get => GetArgument<TerraformList<string>>("allowed_methods");
        set => SetArgument("allowed_methods", value);
    }

}

/// <summary>
/// Block type for url_redirect in GoogleNetworkServicesEdgeCacheServiceRoutingBlockPathMatcherBlockRouteRuleBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesEdgeCacheServiceRoutingBlockPathMatcherBlockRouteRuleBlockUrlRedirectBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "url_redirect";

    /// <summary>
    /// The host that will be used in the redirect response instead of the one that was supplied in the request.
    /// </summary>
    public TerraformValue<string>? HostRedirect
    {
        get => GetArgument<TerraformValue<string>>("host_redirect");
        set => SetArgument("host_redirect", value);
    }

    /// <summary>
    /// If set to true, the URL scheme in the redirected request is set to https. If set to false, the URL scheme of the redirected request will remain the same as that of the request.
    /// 
    /// This can only be set if there is at least one (1) edgeSslCertificate set on the service.
    /// </summary>
    public TerraformValue<bool>? HttpsRedirect
    {
        get => GetArgument<TerraformValue<bool>>("https_redirect");
        set => SetArgument("https_redirect", value);
    }

    /// <summary>
    /// The path that will be used in the redirect response instead of the one that was supplied in the request.
    /// 
    /// pathRedirect cannot be supplied together with prefixRedirect. Supply one alone or neither. If neither is supplied, the path of the original request will be used for the redirect.
    /// 
    /// The path value must be between 1 and 1024 characters.
    /// </summary>
    public TerraformValue<string>? PathRedirect
    {
        get => GetArgument<TerraformValue<string>>("path_redirect");
        set => SetArgument("path_redirect", value);
    }

    /// <summary>
    /// The prefix that replaces the prefixMatch specified in the routeRule, retaining the remaining portion of the URL before redirecting the request.
    /// 
    /// prefixRedirect cannot be supplied together with pathRedirect. Supply one alone or neither. If neither is supplied, the path of the original request will be used for the redirect.
    /// </summary>
    public TerraformValue<string>? PrefixRedirect
    {
        get => GetArgument<TerraformValue<string>>("prefix_redirect");
        set => SetArgument("prefix_redirect", value);
    }

    /// <summary>
    /// The HTTP Status code to use for this RedirectAction.
    /// 
    /// The supported values are:
    /// 
    /// - &#39;MOVED_PERMANENTLY_DEFAULT&#39;, which is the default value and corresponds to 301.
    /// - &#39;FOUND&#39;, which corresponds to 302.
    /// - &#39;SEE_OTHER&#39; which corresponds to 303.
    /// - &#39;TEMPORARY_REDIRECT&#39;, which corresponds to 307. in this case, the request method will be retained.
    /// - &#39;PERMANENT_REDIRECT&#39;, which corresponds to 308. in this case, the request method will be retained. Possible values: [&amp;quot;MOVED_PERMANENTLY_DEFAULT&amp;quot;, &amp;quot;FOUND&amp;quot;, &amp;quot;SEE_OTHER&amp;quot;, &amp;quot;TEMPORARY_REDIRECT&amp;quot;, &amp;quot;PERMANENT_REDIRECT&amp;quot;]
    /// </summary>
    public TerraformValue<string>? RedirectResponseCode
    {
        get => GetArgument<TerraformValue<string>>("redirect_response_code");
        set => SetArgument("redirect_response_code", value);
    }

    /// <summary>
    /// If set to true, any accompanying query portion of the original URL is removed prior to redirecting the request. If set to false, the query portion of the original URL is retained.
    /// </summary>
    public TerraformValue<bool>? StripQuery
    {
        get => GetArgument<TerraformValue<bool>>("strip_query");
        set => SetArgument("strip_query", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleNetworkServicesEdgeCacheService.
/// Nesting mode: single
/// </summary>
public class GoogleNetworkServicesEdgeCacheServiceTimeoutsBlock : TerraformBlock
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
/// Represents a google_network_services_edge_cache_service Terraform resource.
/// Manages a google_network_services_edge_cache_service resource.
/// </summary>
public partial class GoogleNetworkServicesEdgeCacheService(string name) : TerraformResource("google_network_services_edge_cache_service", name)
{
    /// <summary>
    /// A human-readable description of the resource.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Disables HTTP/2.
    /// 
    /// HTTP/2 (h2) is enabled by default and recommended for performance. HTTP/2 improves connection re-use and reduces connection setup overhead by sending multiple streams over the same connection.
    /// 
    /// Some legacy HTTP clients may have issues with HTTP/2 connections due to broken HTTP/2 implementations. Setting this to true will prevent HTTP/2 from being advertised and negotiated.
    /// </summary>
    public TerraformValue<bool>? DisableHttp2
    {
        get => GetArgument<TerraformValue<bool>>("disable_http2");
        set => SetArgument("disable_http2", value);
    }

    /// <summary>
    /// HTTP/3 (IETF QUIC) and Google QUIC are enabled by default.
    /// </summary>
    public TerraformValue<bool>? DisableQuic
    {
        get => GetArgument<TerraformValue<bool>>("disable_quic");
        set => SetArgument("disable_quic", value);
    }

    /// <summary>
    /// Resource URL that points at the Cloud Armor edge security policy that is applied on each request against the EdgeCacheService.
    /// </summary>
    public TerraformValue<string>? EdgeSecurityPolicy
    {
        get => GetArgument<TerraformValue<string>>("edge_security_policy");
        set => SetArgument("edge_security_policy", value);
    }

    /// <summary>
    /// URLs to sslCertificate resources that are used to authenticate connections between users and the EdgeCacheService.
    /// 
    /// Note that only &amp;quot;global&amp;quot; certificates with a &amp;quot;scope&amp;quot; of &amp;quot;EDGE_CACHE&amp;quot; can be attached to an EdgeCacheService.
    /// </summary>
    public TerraformList<string>? EdgeSslCertificates
    {
        get => GetArgument<TerraformList<string>>("edge_ssl_certificates");
        set => SetArgument("edge_ssl_certificates", value);
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
    /// Set of label tags associated with the EdgeCache resource.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// Name of the resource; provided by the client when the resource is created.
    /// The name must be 1-64 characters long, and match the regular expression [a-zA-Z][a-zA-Z0-9_-]* which means the first character must be a letter,
    /// and all following characters must be a dash, underscore, letter or digit.
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
    /// Require TLS (HTTPS) for all clients connecting to this service.
    /// 
    /// Clients who connect over HTTP (port 80) will receive a HTTP 301 to the same URL over HTTPS (port 443).
    /// You must have at least one (1) edgeSslCertificate specified to enable this.
    /// </summary>
    public TerraformValue<bool>? RequireTls
    {
        get => GetArgument<TerraformValue<bool>>("require_tls");
        set => SetArgument("require_tls", value);
    }

    /// <summary>
    /// URL of the SslPolicy resource that will be associated with the EdgeCacheService.
    /// 
    /// If not set, the EdgeCacheService has no SSL policy configured, and will default to the &amp;quot;COMPATIBLE&amp;quot; policy.
    /// </summary>
    public TerraformValue<string>? SslPolicy
    {
        get => GetArgument<TerraformValue<string>>("ssl_policy");
        set => SetArgument("ssl_policy", value);
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => AsReference("effective_labels");

    /// <summary>
    /// The IPv4 addresses associated with this service. Addresses are static for the lifetime of the service.
    /// </summary>
    public TerraformList<string> Ipv4Addresses
        => AsReference("ipv4_addresses");

    /// <summary>
    /// The IPv6 addresses associated with this service. Addresses are static for the lifetime of the service.
    /// </summary>
    public TerraformList<string> Ipv6Addresses
        => AsReference("ipv6_addresses");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => AsReference("terraform_labels");

    /// <summary>
    /// LogConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LogConfig block(s) allowed")]
    public TerraformList<GoogleNetworkServicesEdgeCacheServiceLogConfigBlock>? LogConfig
    {
        get => GetArgument<TerraformList<GoogleNetworkServicesEdgeCacheServiceLogConfigBlock>>("log_config");
        set => SetArgument("log_config", value);
    }

    /// <summary>
    /// Routing block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Routing is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Routing block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Routing block(s) allowed")]
    public required TerraformList<GoogleNetworkServicesEdgeCacheServiceRoutingBlock> Routing
    {
        get => GetRequiredArgument<TerraformList<GoogleNetworkServicesEdgeCacheServiceRoutingBlock>>("routing");
        set => SetArgument("routing", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleNetworkServicesEdgeCacheServiceTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleNetworkServicesEdgeCacheServiceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
