using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for rules in GoogleNetworkServicesHttpRoute.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesHttpRouteRulesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rules";

    /// <summary>
    /// Action block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Action block(s) allowed")]
    public TerraformList<GoogleNetworkServicesHttpRouteRulesBlockActionBlock>? Action
    {
        get => GetArgument<TerraformList<GoogleNetworkServicesHttpRouteRulesBlockActionBlock>>("action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// Matches block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleNetworkServicesHttpRouteRulesBlockMatchesBlock>? Matches
    {
        get => GetArgument<TerraformList<GoogleNetworkServicesHttpRouteRulesBlockMatchesBlock>>("matches");
        set => SetArgument("matches", value);
    }

}

/// <summary>
/// Block type for action in GoogleNetworkServicesHttpRouteRulesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesHttpRouteRulesBlockActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "action";

    /// <summary>
    /// Specifies the timeout for selected route.
    /// </summary>
    public TerraformValue<string>? Timeout
    {
        get => new TerraformReference<string>(this, "timeout");
        set => SetArgument("timeout", value);
    }

    /// <summary>
    /// CorsPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CorsPolicy block(s) allowed")]
    public TerraformList<GoogleNetworkServicesHttpRouteRulesBlockActionBlockCorsPolicyBlock>? CorsPolicy
    {
        get => GetArgument<TerraformList<GoogleNetworkServicesHttpRouteRulesBlockActionBlockCorsPolicyBlock>>("cors_policy");
        set => SetArgument("cors_policy", value);
    }

    /// <summary>
    /// Destinations block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleNetworkServicesHttpRouteRulesBlockActionBlockDestinationsBlock>? Destinations
    {
        get => GetArgument<TerraformList<GoogleNetworkServicesHttpRouteRulesBlockActionBlockDestinationsBlock>>("destinations");
        set => SetArgument("destinations", value);
    }

    /// <summary>
    /// FaultInjectionPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FaultInjectionPolicy block(s) allowed")]
    public TerraformList<GoogleNetworkServicesHttpRouteRulesBlockActionBlockFaultInjectionPolicyBlock>? FaultInjectionPolicy
    {
        get => GetArgument<TerraformList<GoogleNetworkServicesHttpRouteRulesBlockActionBlockFaultInjectionPolicyBlock>>("fault_injection_policy");
        set => SetArgument("fault_injection_policy", value);
    }

    /// <summary>
    /// Redirect block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Redirect block(s) allowed")]
    public TerraformList<GoogleNetworkServicesHttpRouteRulesBlockActionBlockRedirectBlock>? Redirect
    {
        get => GetArgument<TerraformList<GoogleNetworkServicesHttpRouteRulesBlockActionBlockRedirectBlock>>("redirect");
        set => SetArgument("redirect", value);
    }

    /// <summary>
    /// RequestHeaderModifier block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RequestHeaderModifier block(s) allowed")]
    public TerraformList<GoogleNetworkServicesHttpRouteRulesBlockActionBlockRequestHeaderModifierBlock>? RequestHeaderModifier
    {
        get => GetArgument<TerraformList<GoogleNetworkServicesHttpRouteRulesBlockActionBlockRequestHeaderModifierBlock>>("request_header_modifier");
        set => SetArgument("request_header_modifier", value);
    }

    /// <summary>
    /// RequestMirrorPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RequestMirrorPolicy block(s) allowed")]
    public TerraformList<GoogleNetworkServicesHttpRouteRulesBlockActionBlockRequestMirrorPolicyBlock>? RequestMirrorPolicy
    {
        get => GetArgument<TerraformList<GoogleNetworkServicesHttpRouteRulesBlockActionBlockRequestMirrorPolicyBlock>>("request_mirror_policy");
        set => SetArgument("request_mirror_policy", value);
    }

    /// <summary>
    /// ResponseHeaderModifier block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ResponseHeaderModifier block(s) allowed")]
    public TerraformList<GoogleNetworkServicesHttpRouteRulesBlockActionBlockResponseHeaderModifierBlock>? ResponseHeaderModifier
    {
        get => GetArgument<TerraformList<GoogleNetworkServicesHttpRouteRulesBlockActionBlockResponseHeaderModifierBlock>>("response_header_modifier");
        set => SetArgument("response_header_modifier", value);
    }

    /// <summary>
    /// RetryPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetryPolicy block(s) allowed")]
    public TerraformList<GoogleNetworkServicesHttpRouteRulesBlockActionBlockRetryPolicyBlock>? RetryPolicy
    {
        get => GetArgument<TerraformList<GoogleNetworkServicesHttpRouteRulesBlockActionBlockRetryPolicyBlock>>("retry_policy");
        set => SetArgument("retry_policy", value);
    }

    /// <summary>
    /// UrlRewrite block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UrlRewrite block(s) allowed")]
    public TerraformList<GoogleNetworkServicesHttpRouteRulesBlockActionBlockUrlRewriteBlock>? UrlRewrite
    {
        get => GetArgument<TerraformList<GoogleNetworkServicesHttpRouteRulesBlockActionBlockUrlRewriteBlock>>("url_rewrite");
        set => SetArgument("url_rewrite", value);
    }

}

/// <summary>
/// Block type for cors_policy in GoogleNetworkServicesHttpRouteRulesBlockActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesHttpRouteRulesBlockActionBlockCorsPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cors_policy";

    /// <summary>
    /// In response to a preflight request, setting this to true indicates that the actual request can include user credentials.
    /// </summary>
    public TerraformValue<bool>? AllowCredentials
    {
        get => new TerraformReference<bool>(this, "allow_credentials");
        set => SetArgument("allow_credentials", value);
    }

    /// <summary>
    /// Specifies the content for Access-Control-Allow-Headers header.
    /// </summary>
    public TerraformList<string>? AllowHeaders
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "allow_headers").ResolveNodes(ctx));
        set => SetArgument("allow_headers", value);
    }

    /// <summary>
    /// Specifies the content for Access-Control-Allow-Methods header.
    /// </summary>
    public TerraformList<string>? AllowMethods
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "allow_methods").ResolveNodes(ctx));
        set => SetArgument("allow_methods", value);
    }

    /// <summary>
    /// Specifies the regular expression patterns that match allowed origins.
    /// </summary>
    public TerraformList<string>? AllowOriginRegexes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "allow_origin_regexes").ResolveNodes(ctx));
        set => SetArgument("allow_origin_regexes", value);
    }

    /// <summary>
    /// Specifies the list of origins that will be allowed to do CORS requests.
    /// </summary>
    public TerraformList<string>? AllowOrigins
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "allow_origins").ResolveNodes(ctx));
        set => SetArgument("allow_origins", value);
    }

    /// <summary>
    /// If true, the CORS policy is disabled. The default value is false, which indicates that the CORS policy is in effect.
    /// </summary>
    public TerraformValue<bool>? Disabled
    {
        get => new TerraformReference<bool>(this, "disabled");
        set => SetArgument("disabled", value);
    }

    /// <summary>
    /// Specifies the content for Access-Control-Expose-Headers header.
    /// </summary>
    public TerraformList<string>? ExposeHeaders
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "expose_headers").ResolveNodes(ctx));
        set => SetArgument("expose_headers", value);
    }

    /// <summary>
    /// Specifies how long result of a preflight request can be cached in seconds.
    /// </summary>
    public TerraformValue<string>? MaxAge
    {
        get => new TerraformReference<string>(this, "max_age");
        set => SetArgument("max_age", value);
    }

}

/// <summary>
/// Block type for destinations in GoogleNetworkServicesHttpRouteRulesBlockActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesHttpRouteRulesBlockActionBlockDestinationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "destinations";

    /// <summary>
    /// The URL of a BackendService to route traffic to.
    /// </summary>
    public TerraformValue<string>? ServiceName
    {
        get => new TerraformReference<string>(this, "service_name");
        set => SetArgument("service_name", value);
    }

    /// <summary>
    /// Specifies the proportion of requests forwarded to the backend referenced by the serviceName field. This is computed as: weight/Sum(weights in this destination list). For non-zero values, there may be some epsilon from the exact proportion defined here depending on the precision an implementation supports.
    /// If only one serviceName is specified and it has a weight greater than 0, 100% of the traffic is forwarded to that backend.
    /// If weights are specified for any one service name, they need to be specified for all of them.
    /// If weights are unspecified for all services, then, traffic is distributed in equal proportions to all of them.
    /// </summary>
    public TerraformValue<double>? Weight
    {
        get => new TerraformReference<double>(this, "weight");
        set => SetArgument("weight", value);
    }

}

/// <summary>
/// Block type for fault_injection_policy in GoogleNetworkServicesHttpRouteRulesBlockActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesHttpRouteRulesBlockActionBlockFaultInjectionPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "fault_injection_policy";

    /// <summary>
    /// Abort block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Abort block(s) allowed")]
    public TerraformList<GoogleNetworkServicesHttpRouteRulesBlockActionBlockFaultInjectionPolicyBlockAbortBlock>? Abort
    {
        get => GetArgument<TerraformList<GoogleNetworkServicesHttpRouteRulesBlockActionBlockFaultInjectionPolicyBlockAbortBlock>>("abort");
        set => SetArgument("abort", value);
    }

    /// <summary>
    /// Delay block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Delay block(s) allowed")]
    public TerraformList<GoogleNetworkServicesHttpRouteRulesBlockActionBlockFaultInjectionPolicyBlockDelayBlock>? Delay
    {
        get => GetArgument<TerraformList<GoogleNetworkServicesHttpRouteRulesBlockActionBlockFaultInjectionPolicyBlockDelayBlock>>("delay");
        set => SetArgument("delay", value);
    }

}

/// <summary>
/// Block type for abort in GoogleNetworkServicesHttpRouteRulesBlockActionBlockFaultInjectionPolicyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesHttpRouteRulesBlockActionBlockFaultInjectionPolicyBlockAbortBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "abort";

    /// <summary>
    /// The HTTP status code used to abort the request.
    /// </summary>
    public TerraformValue<double>? HttpStatus
    {
        get => new TerraformReference<double>(this, "http_status");
        set => SetArgument("http_status", value);
    }

    /// <summary>
    /// The percentage of traffic which will be aborted.
    /// </summary>
    public TerraformValue<double>? Percentage
    {
        get => new TerraformReference<double>(this, "percentage");
        set => SetArgument("percentage", value);
    }

}

/// <summary>
/// Block type for delay in GoogleNetworkServicesHttpRouteRulesBlockActionBlockFaultInjectionPolicyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesHttpRouteRulesBlockActionBlockFaultInjectionPolicyBlockDelayBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "delay";

    /// <summary>
    /// Specify a fixed delay before forwarding the request.
    /// </summary>
    public TerraformValue<string>? FixedDelay
    {
        get => new TerraformReference<string>(this, "fixed_delay");
        set => SetArgument("fixed_delay", value);
    }

    /// <summary>
    /// The percentage of traffic on which delay will be injected.
    /// </summary>
    public TerraformValue<double>? Percentage
    {
        get => new TerraformReference<double>(this, "percentage");
        set => SetArgument("percentage", value);
    }

}

/// <summary>
/// Block type for redirect in GoogleNetworkServicesHttpRouteRulesBlockActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesHttpRouteRulesBlockActionBlockRedirectBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "redirect";

    /// <summary>
    /// The host that will be used in the redirect response instead of the one that was supplied in the request.
    /// </summary>
    public TerraformValue<string>? HostRedirect
    {
        get => new TerraformReference<string>(this, "host_redirect");
        set => SetArgument("host_redirect", value);
    }

    /// <summary>
    /// If set to true, the URL scheme in the redirected request is set to https.
    /// </summary>
    public TerraformValue<bool>? HttpsRedirect
    {
        get => new TerraformReference<bool>(this, "https_redirect");
        set => SetArgument("https_redirect", value);
    }

    /// <summary>
    /// The path that will be used in the redirect response instead of the one that was supplied in the request. pathRedirect can not be supplied together with prefixRedirect. Supply one alone or neither. If neither is supplied, the path of the original request will be used for the redirect.
    /// </summary>
    public TerraformValue<string>? PathRedirect
    {
        get => new TerraformReference<string>(this, "path_redirect");
        set => SetArgument("path_redirect", value);
    }

    /// <summary>
    /// The port that will be used in the redirected request instead of the one that was supplied in the request.
    /// </summary>
    public TerraformValue<double>? PortRedirect
    {
        get => new TerraformReference<double>(this, "port_redirect");
        set => SetArgument("port_redirect", value);
    }

    /// <summary>
    /// Indicates that during redirection, the matched prefix (or path) should be swapped with this value.
    /// </summary>
    public TerraformValue<string>? PrefixRewrite
    {
        get => new TerraformReference<string>(this, "prefix_rewrite");
        set => SetArgument("prefix_rewrite", value);
    }

    /// <summary>
    /// The HTTP Status code to use for the redirect.
    /// </summary>
    public TerraformValue<string>? ResponseCode
    {
        get => new TerraformReference<string>(this, "response_code");
        set => SetArgument("response_code", value);
    }

    /// <summary>
    /// If set to true, any accompanying query portion of the original URL is removed prior to redirecting the request.
    /// </summary>
    public TerraformValue<bool>? StripQuery
    {
        get => new TerraformReference<bool>(this, "strip_query");
        set => SetArgument("strip_query", value);
    }

}

/// <summary>
/// Block type for request_header_modifier in GoogleNetworkServicesHttpRouteRulesBlockActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesHttpRouteRulesBlockActionBlockRequestHeaderModifierBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "request_header_modifier";

    /// <summary>
    /// Add the headers with given map where key is the name of the header, value is the value of the header.
    /// </summary>
    public TerraformMap<string>? AddAttribute
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "add").ResolveNodes(ctx));
        set => SetArgument("add", value);
    }

    /// <summary>
    /// Remove headers (matching by header names) specified in the list.
    /// </summary>
    public TerraformList<string>? RemoveAttribute
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "remove").ResolveNodes(ctx));
        set => SetArgument("remove", value);
    }

    /// <summary>
    /// Completely overwrite/replace the headers with given map where key is the name of the header, value is the value of the header.
    /// </summary>
    public TerraformMap<string>? Set
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "set").ResolveNodes(ctx));
        set => SetArgument("set", value);
    }

}

/// <summary>
/// Block type for request_mirror_policy in GoogleNetworkServicesHttpRouteRulesBlockActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesHttpRouteRulesBlockActionBlockRequestMirrorPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "request_mirror_policy";

    /// <summary>
    /// Destination block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Destination block(s) allowed")]
    public TerraformList<GoogleNetworkServicesHttpRouteRulesBlockActionBlockRequestMirrorPolicyBlockDestinationBlock>? Destination
    {
        get => GetArgument<TerraformList<GoogleNetworkServicesHttpRouteRulesBlockActionBlockRequestMirrorPolicyBlockDestinationBlock>>("destination");
        set => SetArgument("destination", value);
    }

}

/// <summary>
/// Block type for destination in GoogleNetworkServicesHttpRouteRulesBlockActionBlockRequestMirrorPolicyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesHttpRouteRulesBlockActionBlockRequestMirrorPolicyBlockDestinationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "destination";

    /// <summary>
    /// The URL of a BackendService to route traffic to.
    /// </summary>
    public TerraformValue<string>? ServiceName
    {
        get => new TerraformReference<string>(this, "service_name");
        set => SetArgument("service_name", value);
    }

    /// <summary>
    /// Specifies the proportion of requests forwarded to the backend referenced by the serviceName field. This is computed as: weight/Sum(weights in this destination list). For non-zero values, there may be some epsilon from the exact proportion defined here depending on the precision an implementation supports.
    /// If only one serviceName is specified and it has a weight greater than 0, 100% of the traffic is forwarded to that backend.
    /// If weights are specified for any one service name, they need to be specified for all of them.
    /// If weights are unspecified for all services, then, traffic is distributed in equal proportions to all of them.
    /// </summary>
    public TerraformValue<double>? Weight
    {
        get => new TerraformReference<double>(this, "weight");
        set => SetArgument("weight", value);
    }

}

/// <summary>
/// Block type for response_header_modifier in GoogleNetworkServicesHttpRouteRulesBlockActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesHttpRouteRulesBlockActionBlockResponseHeaderModifierBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "response_header_modifier";

    /// <summary>
    /// Add the headers with given map where key is the name of the header, value is the value of the header.
    /// </summary>
    public TerraformMap<string>? AddAttribute
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "add").ResolveNodes(ctx));
        set => SetArgument("add", value);
    }

    /// <summary>
    /// Remove headers (matching by header names) specified in the list.
    /// </summary>
    public TerraformList<string>? RemoveAttribute
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "remove").ResolveNodes(ctx));
        set => SetArgument("remove", value);
    }

    /// <summary>
    /// Completely overwrite/replace the headers with given map where key is the name of the header, value is the value of the header.
    /// </summary>
    public TerraformMap<string>? Set
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "set").ResolveNodes(ctx));
        set => SetArgument("set", value);
    }

}

/// <summary>
/// Block type for retry_policy in GoogleNetworkServicesHttpRouteRulesBlockActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesHttpRouteRulesBlockActionBlockRetryPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "retry_policy";

    /// <summary>
    /// Specifies the allowed number of retries.
    /// </summary>
    public TerraformValue<double>? NumRetries
    {
        get => new TerraformReference<double>(this, "num_retries");
        set => SetArgument("num_retries", value);
    }

    /// <summary>
    /// Specifies a non-zero timeout per retry attempt. A duration in seconds with up to nine fractional digits, ending with &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    public TerraformValue<string>? PerTryTimeout
    {
        get => new TerraformReference<string>(this, "per_try_timeout");
        set => SetArgument("per_try_timeout", value);
    }

    /// <summary>
    /// Specifies one or more conditions when this retry policy applies.
    /// </summary>
    public TerraformList<string>? RetryConditions
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "retry_conditions").ResolveNodes(ctx));
        set => SetArgument("retry_conditions", value);
    }

}

/// <summary>
/// Block type for url_rewrite in GoogleNetworkServicesHttpRouteRulesBlockActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesHttpRouteRulesBlockActionBlockUrlRewriteBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "url_rewrite";

    /// <summary>
    /// Prior to forwarding the request to the selected destination, the requests host header is replaced by this value.
    /// </summary>
    public TerraformValue<string>? HostRewrite
    {
        get => new TerraformReference<string>(this, "host_rewrite");
        set => SetArgument("host_rewrite", value);
    }

    /// <summary>
    /// Prior to forwarding the request to the selected destination, the matching portion of the requests path is replaced by this value.
    /// </summary>
    public TerraformValue<string>? PathPrefixRewrite
    {
        get => new TerraformReference<string>(this, "path_prefix_rewrite");
        set => SetArgument("path_prefix_rewrite", value);
    }

}

/// <summary>
/// Block type for matches in GoogleNetworkServicesHttpRouteRulesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesHttpRouteRulesBlockMatchesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "matches";

    /// <summary>
    /// The HTTP request path value should exactly match this value.
    /// </summary>
    public TerraformValue<string>? FullPathMatch
    {
        get => new TerraformReference<string>(this, "full_path_match");
        set => SetArgument("full_path_match", value);
    }

    /// <summary>
    /// Specifies if prefixMatch and fullPathMatch matches are case sensitive. The default value is false.
    /// </summary>
    public TerraformValue<bool>? IgnoreCase
    {
        get => new TerraformReference<bool>(this, "ignore_case");
        set => SetArgument("ignore_case", value);
    }

    /// <summary>
    /// The HTTP request path value must begin with specified prefixMatch. prefixMatch must begin with a /.
    /// </summary>
    public TerraformValue<string>? PrefixMatch
    {
        get => new TerraformReference<string>(this, "prefix_match");
        set => SetArgument("prefix_match", value);
    }

    /// <summary>
    /// The HTTP request path value must satisfy the regular expression specified by regexMatch after removing any query parameters and anchor supplied with the original URL. For regular expression grammar, please see https://github.com/google/re2/wiki/Syntax
    /// </summary>
    public TerraformValue<string>? RegexMatch
    {
        get => new TerraformReference<string>(this, "regex_match");
        set => SetArgument("regex_match", value);
    }

    /// <summary>
    /// Headers block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleNetworkServicesHttpRouteRulesBlockMatchesBlockHeadersBlock>? Headers
    {
        get => GetArgument<TerraformList<GoogleNetworkServicesHttpRouteRulesBlockMatchesBlockHeadersBlock>>("headers");
        set => SetArgument("headers", value);
    }

    /// <summary>
    /// QueryParameters block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleNetworkServicesHttpRouteRulesBlockMatchesBlockQueryParametersBlock>? QueryParameters
    {
        get => GetArgument<TerraformList<GoogleNetworkServicesHttpRouteRulesBlockMatchesBlockQueryParametersBlock>>("query_parameters");
        set => SetArgument("query_parameters", value);
    }

}

/// <summary>
/// Block type for headers in GoogleNetworkServicesHttpRouteRulesBlockMatchesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesHttpRouteRulesBlockMatchesBlockHeadersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "headers";

    /// <summary>
    /// The value of the header should match exactly the content of exactMatch.
    /// </summary>
    public TerraformValue<string>? ExactMatch
    {
        get => new TerraformReference<string>(this, "exact_match");
        set => SetArgument("exact_match", value);
    }

    /// <summary>
    /// The name of the HTTP header to match against.
    /// </summary>
    public TerraformValue<string>? Header
    {
        get => new TerraformReference<string>(this, "header");
        set => SetArgument("header", value);
    }

    /// <summary>
    /// If specified, the match result will be inverted before checking. Default value is set to false.
    /// </summary>
    public TerraformValue<bool>? InvertMatch
    {
        get => new TerraformReference<bool>(this, "invert_match");
        set => SetArgument("invert_match", value);
    }

    /// <summary>
    /// The value of the header must start with the contents of prefixMatch.
    /// </summary>
    public TerraformValue<string>? PrefixMatch
    {
        get => new TerraformReference<string>(this, "prefix_match");
        set => SetArgument("prefix_match", value);
    }

    /// <summary>
    /// A header with headerName must exist. The match takes place whether or not the header has a value.
    /// </summary>
    public TerraformValue<bool>? PresentMatch
    {
        get => new TerraformReference<bool>(this, "present_match");
        set => SetArgument("present_match", value);
    }

    /// <summary>
    /// The value of the header must match the regular expression specified in regexMatch.
    /// </summary>
    public TerraformValue<string>? RegexMatch
    {
        get => new TerraformReference<string>(this, "regex_match");
        set => SetArgument("regex_match", value);
    }

    /// <summary>
    /// The value of the header must end with the contents of suffixMatch.
    /// </summary>
    public TerraformValue<string>? SuffixMatch
    {
        get => new TerraformReference<string>(this, "suffix_match");
        set => SetArgument("suffix_match", value);
    }

    /// <summary>
    /// RangeMatch block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RangeMatch block(s) allowed")]
    public TerraformList<GoogleNetworkServicesHttpRouteRulesBlockMatchesBlockHeadersBlockRangeMatchBlock>? RangeMatch
    {
        get => GetArgument<TerraformList<GoogleNetworkServicesHttpRouteRulesBlockMatchesBlockHeadersBlockRangeMatchBlock>>("range_match");
        set => SetArgument("range_match", value);
    }

}

/// <summary>
/// Block type for range_match in GoogleNetworkServicesHttpRouteRulesBlockMatchesBlockHeadersBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesHttpRouteRulesBlockMatchesBlockHeadersBlockRangeMatchBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "range_match";

    /// <summary>
    /// End of the range (exclusive).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "End is required")]
    public required TerraformValue<double> End
    {
        get => new TerraformReference<double>(this, "end");
        set => SetArgument("end", value);
    }

    /// <summary>
    /// Start of the range (inclusive).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Start is required")]
    public required TerraformValue<double> Start
    {
        get => new TerraformReference<double>(this, "start");
        set => SetArgument("start", value);
    }

}

/// <summary>
/// Block type for query_parameters in GoogleNetworkServicesHttpRouteRulesBlockMatchesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesHttpRouteRulesBlockMatchesBlockQueryParametersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "query_parameters";

    /// <summary>
    /// The value of the query parameter must exactly match the contents of exactMatch.
    /// </summary>
    public TerraformValue<string>? ExactMatch
    {
        get => new TerraformReference<string>(this, "exact_match");
        set => SetArgument("exact_match", value);
    }

    /// <summary>
    /// Specifies that the QueryParameterMatcher matches if request contains query parameter, irrespective of whether the parameter has a value or not.
    /// </summary>
    public TerraformValue<bool>? PresentMatch
    {
        get => new TerraformReference<bool>(this, "present_match");
        set => SetArgument("present_match", value);
    }

    /// <summary>
    /// The name of the query parameter to match.
    /// </summary>
    public TerraformValue<string>? QueryParameter
    {
        get => new TerraformReference<string>(this, "query_parameter");
        set => SetArgument("query_parameter", value);
    }

    /// <summary>
    /// The value of the query parameter must match the regular expression specified by regexMatch.For regular expression grammar, please see https://github.com/google/re2/wiki/Syntax
    /// </summary>
    public TerraformValue<string>? RegexMatch
    {
        get => new TerraformReference<string>(this, "regex_match");
        set => SetArgument("regex_match", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleNetworkServicesHttpRoute.
/// Nesting mode: single
/// </summary>
public class GoogleNetworkServicesHttpRouteTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_network_services_http_route Terraform resource.
/// Manages a google_network_services_http_route resource.
/// </summary>
public partial class GoogleNetworkServicesHttpRoute(string name) : TerraformResource("google_network_services_http_route", name)
{
    /// <summary>
    /// A free-text description of the resource. Max length 1024 characters.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Gateways defines a list of gateways this HttpRoute is attached to, as one of the routing rules to route the requests served by the gateway.
    /// Each gateway reference should match the pattern: projects/*/locations/global/gateways/&amp;lt;gateway_name&amp;gt;
    /// </summary>
    public TerraformList<string>? Gateways
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "gateways").ResolveNodes(ctx));
        set => SetArgument("gateways", value);
    }

    /// <summary>
    /// Set of hosts that should match against the HTTP host header to select a HttpRoute to process the request.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hostnames is required")]
    public TerraformList<string>? Hostnames
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "hostnames").ResolveNodes(ctx));
        set => SetArgument("hostnames", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Set of label tags associated with the HttpRoute resource.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "labels").ResolveNodes(ctx));
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// Meshes defines a list of meshes this HttpRoute is attached to, as one of the routing rules to route the requests served by the mesh.
    /// Each mesh reference should match the pattern: projects/*/locations/global/meshes/&amp;lt;mesh_name&amp;gt;.
    /// The attached Mesh should be of a type SIDECAR.
    /// </summary>
    public TerraformList<string>? Meshes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "meshes").ResolveNodes(ctx));
        set => SetArgument("meshes", value);
    }

    /// <summary>
    /// Name of the HttpRoute resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Time the HttpRoute was created in UTC.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "effective_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// Server-defined URL of this resource.
    /// </summary>
    public TerraformValue<string> SelfLink
    {
        get => new TerraformReference<string>(this, "self_link");
    }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "terraform_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// Time the HttpRoute was updated in UTC.
    /// </summary>
    public TerraformValue<string> UpdateTime
    {
        get => new TerraformReference<string>(this, "update_time");
    }

    /// <summary>
    /// Rules block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rules is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Rules block(s) required")]
    public required TerraformList<GoogleNetworkServicesHttpRouteRulesBlock> Rules
    {
        get => GetRequiredArgument<TerraformList<GoogleNetworkServicesHttpRouteRulesBlock>>("rules");
        set => SetArgument("rules", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleNetworkServicesHttpRouteTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleNetworkServicesHttpRouteTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
