using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for default_route_action in GoogleComputeRegionUrlMap.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionUrlMapDefaultRouteActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "default_route_action";

    /// <summary>
    /// CorsPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CorsPolicy block(s) allowed")]
    public TerraformList<GoogleComputeRegionUrlMapDefaultRouteActionBlockCorsPolicyBlock>? CorsPolicy
    {
        get => GetArgument<TerraformList<GoogleComputeRegionUrlMapDefaultRouteActionBlockCorsPolicyBlock>>("cors_policy");
        set => SetArgument("cors_policy", value);
    }

    /// <summary>
    /// FaultInjectionPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FaultInjectionPolicy block(s) allowed")]
    public TerraformList<GoogleComputeRegionUrlMapDefaultRouteActionBlockFaultInjectionPolicyBlock>? FaultInjectionPolicy
    {
        get => GetArgument<TerraformList<GoogleComputeRegionUrlMapDefaultRouteActionBlockFaultInjectionPolicyBlock>>("fault_injection_policy");
        set => SetArgument("fault_injection_policy", value);
    }

    /// <summary>
    /// RequestMirrorPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RequestMirrorPolicy block(s) allowed")]
    public TerraformList<GoogleComputeRegionUrlMapDefaultRouteActionBlockRequestMirrorPolicyBlock>? RequestMirrorPolicy
    {
        get => GetArgument<TerraformList<GoogleComputeRegionUrlMapDefaultRouteActionBlockRequestMirrorPolicyBlock>>("request_mirror_policy");
        set => SetArgument("request_mirror_policy", value);
    }

    /// <summary>
    /// RetryPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetryPolicy block(s) allowed")]
    public TerraformList<GoogleComputeRegionUrlMapDefaultRouteActionBlockRetryPolicyBlock>? RetryPolicy
    {
        get => GetArgument<TerraformList<GoogleComputeRegionUrlMapDefaultRouteActionBlockRetryPolicyBlock>>("retry_policy");
        set => SetArgument("retry_policy", value);
    }

    /// <summary>
    /// Timeout block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Timeout block(s) allowed")]
    public TerraformList<GoogleComputeRegionUrlMapDefaultRouteActionBlockTimeoutBlock>? Timeout
    {
        get => GetArgument<TerraformList<GoogleComputeRegionUrlMapDefaultRouteActionBlockTimeoutBlock>>("timeout");
        set => SetArgument("timeout", value);
    }

    /// <summary>
    /// UrlRewrite block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UrlRewrite block(s) allowed")]
    public TerraformList<GoogleComputeRegionUrlMapDefaultRouteActionBlockUrlRewriteBlock>? UrlRewrite
    {
        get => GetArgument<TerraformList<GoogleComputeRegionUrlMapDefaultRouteActionBlockUrlRewriteBlock>>("url_rewrite");
        set => SetArgument("url_rewrite", value);
    }

    /// <summary>
    /// WeightedBackendServices block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeRegionUrlMapDefaultRouteActionBlockWeightedBackendServicesBlock>? WeightedBackendServices
    {
        get => GetArgument<TerraformList<GoogleComputeRegionUrlMapDefaultRouteActionBlockWeightedBackendServicesBlock>>("weighted_backend_services");
        set => SetArgument("weighted_backend_services", value);
    }

}

/// <summary>
/// Block type for cors_policy in GoogleComputeRegionUrlMapDefaultRouteActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionUrlMapDefaultRouteActionBlockCorsPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cors_policy";

    /// <summary>
    /// In response to a preflight request, setting this to true indicates that the actual request can include user credentials. This field translates to the Access-Control-Allow-Credentials header.
    /// Default is false.
    /// </summary>
    public TerraformValue<bool>? AllowCredentials
    {
        get => GetArgument<TerraformValue<bool>>("allow_credentials");
        set => SetArgument("allow_credentials", value);
    }

    /// <summary>
    /// Specifies the content for the Access-Control-Allow-Headers header.
    /// </summary>
    public TerraformList<string>? AllowHeaders
    {
        get => GetArgument<TerraformList<string>>("allow_headers");
        set => SetArgument("allow_headers", value);
    }

    /// <summary>
    /// Specifies the content for the Access-Control-Allow-Methods header.
    /// </summary>
    public TerraformList<string>? AllowMethods
    {
        get => GetArgument<TerraformList<string>>("allow_methods");
        set => SetArgument("allow_methods", value);
    }

    /// <summary>
    /// Specifies the regualar expression patterns that match allowed origins. For regular expression grammar
    /// please see en.cppreference.com/w/cpp/regex/ecmascript
    /// An origin is allowed if it matches either an item in allowOrigins or an item in allowOriginRegexes.
    /// </summary>
    public TerraformList<string>? AllowOriginRegexes
    {
        get => GetArgument<TerraformList<string>>("allow_origin_regexes");
        set => SetArgument("allow_origin_regexes", value);
    }

    /// <summary>
    /// Specifies the list of origins that will be allowed to do CORS requests.
    /// An origin is allowed if it matches either an item in allowOrigins or an item in allowOriginRegexes.
    /// </summary>
    public TerraformList<string>? AllowOrigins
    {
        get => GetArgument<TerraformList<string>>("allow_origins");
        set => SetArgument("allow_origins", value);
    }

    /// <summary>
    /// If true, the setting specifies the CORS policy is disabled. The default value of false, which indicates that the CORS policy is in effect.
    /// </summary>
    public TerraformValue<bool>? Disabled
    {
        get => GetArgument<TerraformValue<bool>>("disabled");
        set => SetArgument("disabled", value);
    }

    /// <summary>
    /// Specifies the content for the Access-Control-Expose-Headers header.
    /// </summary>
    public TerraformList<string>? ExposeHeaders
    {
        get => GetArgument<TerraformList<string>>("expose_headers");
        set => SetArgument("expose_headers", value);
    }

    /// <summary>
    /// Specifies how long results of a preflight request can be cached in seconds.
    /// This translates to the Access-Control-Max-Age header.
    /// </summary>
    public TerraformValue<double>? MaxAge
    {
        get => GetArgument<TerraformValue<double>>("max_age");
        set => SetArgument("max_age", value);
    }

}

/// <summary>
/// Block type for fault_injection_policy in GoogleComputeRegionUrlMapDefaultRouteActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionUrlMapDefaultRouteActionBlockFaultInjectionPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "fault_injection_policy";

    /// <summary>
    /// Abort block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Abort block(s) allowed")]
    public TerraformList<GoogleComputeRegionUrlMapDefaultRouteActionBlockFaultInjectionPolicyBlockAbortBlock>? Abort
    {
        get => GetArgument<TerraformList<GoogleComputeRegionUrlMapDefaultRouteActionBlockFaultInjectionPolicyBlockAbortBlock>>("abort");
        set => SetArgument("abort", value);
    }

    /// <summary>
    /// Delay block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Delay block(s) allowed")]
    public TerraformList<GoogleComputeRegionUrlMapDefaultRouteActionBlockFaultInjectionPolicyBlockDelayBlock>? Delay
    {
        get => GetArgument<TerraformList<GoogleComputeRegionUrlMapDefaultRouteActionBlockFaultInjectionPolicyBlockDelayBlock>>("delay");
        set => SetArgument("delay", value);
    }

}

/// <summary>
/// Block type for abort in GoogleComputeRegionUrlMapDefaultRouteActionBlockFaultInjectionPolicyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionUrlMapDefaultRouteActionBlockFaultInjectionPolicyBlockAbortBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "abort";

    /// <summary>
    /// The HTTP status code used to abort the request.
    /// The value must be between 200 and 599 inclusive.
    /// </summary>
    public TerraformValue<double>? HttpStatus
    {
        get => GetArgument<TerraformValue<double>>("http_status");
        set => SetArgument("http_status", value);
    }

    /// <summary>
    /// The percentage of traffic (connections/operations/requests) which will be aborted as part of fault injection.
    /// The value must be between 0.0 and 100.0 inclusive.
    /// </summary>
    public TerraformValue<double>? Percentage
    {
        get => GetArgument<TerraformValue<double>>("percentage");
        set => SetArgument("percentage", value);
    }

}

/// <summary>
/// Block type for delay in GoogleComputeRegionUrlMapDefaultRouteActionBlockFaultInjectionPolicyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionUrlMapDefaultRouteActionBlockFaultInjectionPolicyBlockDelayBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "delay";

    /// <summary>
    /// The percentage of traffic (connections/operations/requests) on which delay will be introduced as part of fault injection.
    /// The value must be between 0.0 and 100.0 inclusive.
    /// </summary>
    public TerraformValue<double>? Percentage
    {
        get => GetArgument<TerraformValue<double>>("percentage");
        set => SetArgument("percentage", value);
    }

    /// <summary>
    /// FixedDelay block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FixedDelay block(s) allowed")]
    public TerraformList<GoogleComputeRegionUrlMapDefaultRouteActionBlockFaultInjectionPolicyBlockDelayBlockFixedDelayBlock>? FixedDelay
    {
        get => GetArgument<TerraformList<GoogleComputeRegionUrlMapDefaultRouteActionBlockFaultInjectionPolicyBlockDelayBlockFixedDelayBlock>>("fixed_delay");
        set => SetArgument("fixed_delay", value);
    }

}

/// <summary>
/// Block type for fixed_delay in GoogleComputeRegionUrlMapDefaultRouteActionBlockFaultInjectionPolicyBlockDelayBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionUrlMapDefaultRouteActionBlockFaultInjectionPolicyBlockDelayBlockFixedDelayBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "fixed_delay";

    /// <summary>
    /// Span of time that&#39;s a fraction of a second at nanosecond resolution. Durations less than one second are
    /// represented with a 0 seconds field and a positive nanos field. Must be from 0 to 999,999,999 inclusive.
    /// </summary>
    public TerraformValue<double>? Nanos
    {
        get => GetArgument<TerraformValue<double>>("nanos");
        set => SetArgument("nanos", value);
    }

    /// <summary>
    /// Span of time at a resolution of a second. Must be from 0 to 315,576,000,000 inclusive.
    /// Note: these bounds are computed from: 60 sec/min * 60 min/hr * 24 hr/day * 365.25 days/year * 10000 years
    /// </summary>
    public TerraformValue<string>? Seconds
    {
        get => GetArgument<TerraformValue<string>>("seconds");
        set => SetArgument("seconds", value);
    }

}

/// <summary>
/// Block type for request_mirror_policy in GoogleComputeRegionUrlMapDefaultRouteActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionUrlMapDefaultRouteActionBlockRequestMirrorPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "request_mirror_policy";

    /// <summary>
    /// The full or partial URL to the RegionBackendService resource being mirrored to.
    /// The backend service configured for a mirroring policy must reference backends that are of the same type as the original backend service matched in the URL map.
    /// Serverless NEG backends are not currently supported as a mirrored backend service.
    /// </summary>
    public TerraformValue<string>? BackendService
    {
        get => GetArgument<TerraformValue<string>>("backend_service");
        set => SetArgument("backend_service", value);
    }

}

/// <summary>
/// Block type for retry_policy in GoogleComputeRegionUrlMapDefaultRouteActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionUrlMapDefaultRouteActionBlockRetryPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "retry_policy";

    /// <summary>
    /// Specifies the allowed number retries. This number must be &amp;gt; 0. If not specified, defaults to 1.
    /// </summary>
    public TerraformValue<double>? NumRetries
    {
        get => GetArgument<TerraformValue<double>>("num_retries");
        set => SetArgument("num_retries", value);
    }

    /// <summary>
    /// Specifies one or more conditions when this retry policy applies.
    /// Valid values are listed below. Only the following codes are supported when the URL map is bound to target gRPC proxy that has validateForProxyless field set to true: cancelled, deadline-exceeded, internal, resource-exhausted, unavailable.
    ///   - 5xx : retry is attempted if the instance or endpoint responds with any 5xx response code, or if the instance or endpoint does not respond at all. For example, disconnects, reset, read timeout, connection failure, and refused streams.
    ///   - gateway-error : Similar to 5xx, but only applies to response codes 502, 503 or 504.
    ///   - connect-failure : a retry is attempted on failures connecting to the instance or endpoint. For example, connection timeouts.
    ///   - retriable-4xx : a retry is attempted if the instance or endpoint responds with a 4xx response code. The only error that you can retry is error code 409.
    ///   - refused-stream : a retry is attempted if the instance or endpoint resets the stream with a REFUSED_STREAM error code. This reset type indicates that it is safe to retry.
    ///   - cancelled : a retry is attempted if the gRPC status code in the response header is set to cancelled.
    ///   - deadline-exceeded : a retry is attempted if the gRPC status code in the response header is set to deadline-exceeded.
    ///   - internal :  a retry is attempted if the gRPC status code in the response header is set to internal.
    ///   - resource-exhausted : a retry is attempted if the gRPC status code in the response header is set to resource-exhausted.
    ///   - unavailable : a retry is attempted if the gRPC status code in the response header is set to unavailable.
    /// </summary>
    public TerraformList<string>? RetryConditions
    {
        get => GetArgument<TerraformList<string>>("retry_conditions");
        set => SetArgument("retry_conditions", value);
    }

    /// <summary>
    /// PerTryTimeout block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PerTryTimeout block(s) allowed")]
    public TerraformList<GoogleComputeRegionUrlMapDefaultRouteActionBlockRetryPolicyBlockPerTryTimeoutBlock>? PerTryTimeout
    {
        get => GetArgument<TerraformList<GoogleComputeRegionUrlMapDefaultRouteActionBlockRetryPolicyBlockPerTryTimeoutBlock>>("per_try_timeout");
        set => SetArgument("per_try_timeout", value);
    }

}

/// <summary>
/// Block type for per_try_timeout in GoogleComputeRegionUrlMapDefaultRouteActionBlockRetryPolicyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionUrlMapDefaultRouteActionBlockRetryPolicyBlockPerTryTimeoutBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "per_try_timeout";

    /// <summary>
    /// Span of time that&#39;s a fraction of a second at nanosecond resolution. Durations less than one second are
    /// represented with a 0 seconds field and a positive nanos field. Must be from 0 to 999,999,999 inclusive.
    /// </summary>
    public TerraformValue<double>? Nanos
    {
        get => GetArgument<TerraformValue<double>>("nanos");
        set => SetArgument("nanos", value);
    }

    /// <summary>
    /// Span of time at a resolution of a second. Must be from 0 to 315,576,000,000 inclusive.
    /// Note: these bounds are computed from: 60 sec/min * 60 min/hr * 24 hr/day * 365.25 days/year * 10000 years
    /// </summary>
    public TerraformValue<string>? Seconds
    {
        get => GetArgument<TerraformValue<string>>("seconds");
        set => SetArgument("seconds", value);
    }

}

/// <summary>
/// Block type for timeout in GoogleComputeRegionUrlMapDefaultRouteActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionUrlMapDefaultRouteActionBlockTimeoutBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeout";

    /// <summary>
    /// Span of time that&#39;s a fraction of a second at nanosecond resolution. Durations less than one second are represented with a 0 seconds field and a positive nanos field. Must be from 0 to 999,999,999 inclusive.
    /// </summary>
    public TerraformValue<double>? Nanos
    {
        get => GetArgument<TerraformValue<double>>("nanos");
        set => SetArgument("nanos", value);
    }

    /// <summary>
    /// Span of time at a resolution of a second. Must be from 0 to 315,576,000,000 inclusive. Note: these bounds are computed from: 60 sec/min * 60 min/hr * 24 hr/day * 365.25 days/year * 10000 years
    /// </summary>
    public TerraformValue<string>? Seconds
    {
        get => GetArgument<TerraformValue<string>>("seconds");
        set => SetArgument("seconds", value);
    }

}

/// <summary>
/// Block type for url_rewrite in GoogleComputeRegionUrlMapDefaultRouteActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionUrlMapDefaultRouteActionBlockUrlRewriteBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "url_rewrite";

    /// <summary>
    /// Before forwarding the request to the selected service, the request&#39;s host header is replaced with contents of hostRewrite.
    /// The value must be from 1 to 255 characters.
    /// </summary>
    public TerraformValue<string>? HostRewrite
    {
        get => GetArgument<TerraformValue<string>>("host_rewrite");
        set => SetArgument("host_rewrite", value);
    }

    /// <summary>
    /// Before forwarding the request to the selected backend service, the matching portion of the request&#39;s path is replaced by pathPrefixRewrite.
    /// The value must be from 1 to 1024 characters.
    /// </summary>
    public TerraformValue<string>? PathPrefixRewrite
    {
        get => GetArgument<TerraformValue<string>>("path_prefix_rewrite");
        set => SetArgument("path_prefix_rewrite", value);
    }

}

/// <summary>
/// Block type for weighted_backend_services in GoogleComputeRegionUrlMapDefaultRouteActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionUrlMapDefaultRouteActionBlockWeightedBackendServicesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "weighted_backend_services";

    /// <summary>
    /// The full or partial URL to the default BackendService resource. Before forwarding the request to backendService, the load balancer applies any relevant headerActions specified as part of this backendServiceWeight.
    /// </summary>
    public TerraformValue<string>? BackendService
    {
        get => GetArgument<TerraformValue<string>>("backend_service");
        set => SetArgument("backend_service", value);
    }

    /// <summary>
    /// Specifies the fraction of traffic sent to a backend service, computed as weight / (sum of all weightedBackendService weights in routeAction) .
    /// The selection of a backend service is determined only for new traffic. Once a user&#39;s request has been directed to a backend service, subsequent requests are sent to the same backend service as determined by the backend service&#39;s session affinity policy.
    /// The value must be from 0 to 1000.
    /// </summary>
    public TerraformValue<double>? Weight
    {
        get => GetArgument<TerraformValue<double>>("weight");
        set => SetArgument("weight", value);
    }

    /// <summary>
    /// HeaderAction block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HeaderAction block(s) allowed")]
    public TerraformList<GoogleComputeRegionUrlMapDefaultRouteActionBlockWeightedBackendServicesBlockHeaderActionBlock>? HeaderAction
    {
        get => GetArgument<TerraformList<GoogleComputeRegionUrlMapDefaultRouteActionBlockWeightedBackendServicesBlockHeaderActionBlock>>("header_action");
        set => SetArgument("header_action", value);
    }

}

/// <summary>
/// Block type for header_action in GoogleComputeRegionUrlMapDefaultRouteActionBlockWeightedBackendServicesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionUrlMapDefaultRouteActionBlockWeightedBackendServicesBlockHeaderActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "header_action";

    /// <summary>
    /// A list of header names for headers that need to be removed from the request before forwarding the request to the backendService.
    /// </summary>
    public TerraformList<string>? RequestHeadersToRemove
    {
        get => GetArgument<TerraformList<string>>("request_headers_to_remove");
        set => SetArgument("request_headers_to_remove", value);
    }

    /// <summary>
    /// A list of header names for headers that need to be removed from the response before sending the response back to the client.
    /// </summary>
    public TerraformList<string>? ResponseHeadersToRemove
    {
        get => GetArgument<TerraformList<string>>("response_headers_to_remove");
        set => SetArgument("response_headers_to_remove", value);
    }

    /// <summary>
    /// RequestHeadersToAdd block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeRegionUrlMapDefaultRouteActionBlockWeightedBackendServicesBlockHeaderActionBlockRequestHeadersToAddBlock>? RequestHeadersToAdd
    {
        get => GetArgument<TerraformList<GoogleComputeRegionUrlMapDefaultRouteActionBlockWeightedBackendServicesBlockHeaderActionBlockRequestHeadersToAddBlock>>("request_headers_to_add");
        set => SetArgument("request_headers_to_add", value);
    }

    /// <summary>
    /// ResponseHeadersToAdd block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeRegionUrlMapDefaultRouteActionBlockWeightedBackendServicesBlockHeaderActionBlockResponseHeadersToAddBlock>? ResponseHeadersToAdd
    {
        get => GetArgument<TerraformList<GoogleComputeRegionUrlMapDefaultRouteActionBlockWeightedBackendServicesBlockHeaderActionBlockResponseHeadersToAddBlock>>("response_headers_to_add");
        set => SetArgument("response_headers_to_add", value);
    }

}

/// <summary>
/// Block type for request_headers_to_add in GoogleComputeRegionUrlMapDefaultRouteActionBlockWeightedBackendServicesBlockHeaderActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionUrlMapDefaultRouteActionBlockWeightedBackendServicesBlockHeaderActionBlockRequestHeadersToAddBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "request_headers_to_add";

    /// <summary>
    /// The name of the header.
    /// </summary>
    public TerraformValue<string>? HeaderName
    {
        get => GetArgument<TerraformValue<string>>("header_name");
        set => SetArgument("header_name", value);
    }

    /// <summary>
    /// The value of the header to add.
    /// </summary>
    public TerraformValue<string>? HeaderValue
    {
        get => GetArgument<TerraformValue<string>>("header_value");
        set => SetArgument("header_value", value);
    }

    /// <summary>
    /// If false, headerValue is appended to any values that already exist for the header. If true, headerValue is set for the header, discarding any values that were set for that header.
    /// The default value is false.
    /// </summary>
    public TerraformValue<bool>? Replace
    {
        get => GetArgument<TerraformValue<bool>>("replace");
        set => SetArgument("replace", value);
    }

}

/// <summary>
/// Block type for response_headers_to_add in GoogleComputeRegionUrlMapDefaultRouteActionBlockWeightedBackendServicesBlockHeaderActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionUrlMapDefaultRouteActionBlockWeightedBackendServicesBlockHeaderActionBlockResponseHeadersToAddBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "response_headers_to_add";

    /// <summary>
    /// The name of the header.
    /// </summary>
    public TerraformValue<string>? HeaderName
    {
        get => GetArgument<TerraformValue<string>>("header_name");
        set => SetArgument("header_name", value);
    }

    /// <summary>
    /// The value of the header to add.
    /// </summary>
    public TerraformValue<string>? HeaderValue
    {
        get => GetArgument<TerraformValue<string>>("header_value");
        set => SetArgument("header_value", value);
    }

    /// <summary>
    /// If false, headerValue is appended to any values that already exist for the header. If true, headerValue is set for the header, discarding any values that were set for that header.
    /// The default value is false.
    /// </summary>
    public TerraformValue<bool>? Replace
    {
        get => GetArgument<TerraformValue<bool>>("replace");
        set => SetArgument("replace", value);
    }

}


/// <summary>
/// Block type for default_url_redirect in GoogleComputeRegionUrlMap.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionUrlMapDefaultUrlRedirectBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "default_url_redirect";

    /// <summary>
    /// The host that will be used in the redirect response instead of the one that was
    /// supplied in the request. The value must be between 1 and 255 characters.
    /// </summary>
    public TerraformValue<string>? HostRedirect
    {
        get => GetArgument<TerraformValue<string>>("host_redirect");
        set => SetArgument("host_redirect", value);
    }

    /// <summary>
    /// If set to true, the URL scheme in the redirected request is set to https. If set to
    /// false, the URL scheme of the redirected request will remain the same as that of the
    /// request. This must only be set for UrlMaps used in TargetHttpProxys. Setting this
    /// true for TargetHttpsProxy is not permitted. The default is set to false.
    /// </summary>
    public TerraformValue<bool>? HttpsRedirect
    {
        get => GetArgument<TerraformValue<bool>>("https_redirect");
        set => SetArgument("https_redirect", value);
    }

    /// <summary>
    /// The path that will be used in the redirect response instead of the one that was
    /// supplied in the request. pathRedirect cannot be supplied together with
    /// prefixRedirect. Supply one alone or neither. If neither is supplied, the path of the
    /// original request will be used for the redirect. The value must be between 1 and 1024
    /// characters.
    /// </summary>
    public TerraformValue<string>? PathRedirect
    {
        get => GetArgument<TerraformValue<string>>("path_redirect");
        set => SetArgument("path_redirect", value);
    }

    /// <summary>
    /// The prefix that replaces the prefixMatch specified in the HttpRouteRuleMatch,
    /// retaining the remaining portion of the URL before redirecting the request.
    /// prefixRedirect cannot be supplied together with pathRedirect. Supply one alone or
    /// neither. If neither is supplied, the path of the original request will be used for
    /// the redirect. The value must be between 1 and 1024 characters.
    /// </summary>
    public TerraformValue<string>? PrefixRedirect
    {
        get => GetArgument<TerraformValue<string>>("prefix_redirect");
        set => SetArgument("prefix_redirect", value);
    }

    /// <summary>
    /// The HTTP Status code to use for this RedirectAction. Supported values are:
    /// 
    /// * MOVED_PERMANENTLY_DEFAULT, which is the default value and corresponds to 301.
    /// 
    /// * FOUND, which corresponds to 302.
    /// 
    /// * SEE_OTHER which corresponds to 303.
    /// 
    /// * TEMPORARY_REDIRECT, which corresponds to 307. In this case, the request method
    /// will be retained.
    /// 
    /// * PERMANENT_REDIRECT, which corresponds to 308. In this case,
    /// the request method will be retained. Possible values: [&amp;quot;FOUND&amp;quot;, &amp;quot;MOVED_PERMANENTLY_DEFAULT&amp;quot;, &amp;quot;PERMANENT_REDIRECT&amp;quot;, &amp;quot;SEE_OTHER&amp;quot;, &amp;quot;TEMPORARY_REDIRECT&amp;quot;]
    /// </summary>
    public TerraformValue<string>? RedirectResponseCode
    {
        get => GetArgument<TerraformValue<string>>("redirect_response_code");
        set => SetArgument("redirect_response_code", value);
    }

    /// <summary>
    /// If set to true, any accompanying query portion of the original URL is removed prior
    /// to redirecting the request. If set to false, the query portion of the original URL is
    /// retained.
    ///  This field is required to ensure an empty block is not set. The normal default value is false.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StripQuery is required")]
    public required TerraformValue<bool> StripQuery
    {
        get => GetRequiredArgument<TerraformValue<bool>>("strip_query");
        set => SetArgument("strip_query", value);
    }

}


/// <summary>
/// Block type for header_action in GoogleComputeRegionUrlMap.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionUrlMapHeaderActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "header_action";

    /// <summary>
    /// A list of header names for headers that need to be removed from the request before forwarding the request to the backendService.
    /// </summary>
    public TerraformList<string>? RequestHeadersToRemove
    {
        get => GetArgument<TerraformList<string>>("request_headers_to_remove");
        set => SetArgument("request_headers_to_remove", value);
    }

    /// <summary>
    /// A list of header names for headers that need to be removed from the response before sending the response back to the client.
    /// </summary>
    public TerraformList<string>? ResponseHeadersToRemove
    {
        get => GetArgument<TerraformList<string>>("response_headers_to_remove");
        set => SetArgument("response_headers_to_remove", value);
    }

    /// <summary>
    /// RequestHeadersToAdd block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeRegionUrlMapHeaderActionBlockRequestHeadersToAddBlock>? RequestHeadersToAdd
    {
        get => GetArgument<TerraformList<GoogleComputeRegionUrlMapHeaderActionBlockRequestHeadersToAddBlock>>("request_headers_to_add");
        set => SetArgument("request_headers_to_add", value);
    }

    /// <summary>
    /// ResponseHeadersToAdd block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeRegionUrlMapHeaderActionBlockResponseHeadersToAddBlock>? ResponseHeadersToAdd
    {
        get => GetArgument<TerraformList<GoogleComputeRegionUrlMapHeaderActionBlockResponseHeadersToAddBlock>>("response_headers_to_add");
        set => SetArgument("response_headers_to_add", value);
    }

}

/// <summary>
/// Block type for request_headers_to_add in GoogleComputeRegionUrlMapHeaderActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionUrlMapHeaderActionBlockRequestHeadersToAddBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "request_headers_to_add";

    /// <summary>
    /// The name of the header.
    /// </summary>
    public TerraformValue<string>? HeaderName
    {
        get => GetArgument<TerraformValue<string>>("header_name");
        set => SetArgument("header_name", value);
    }

    /// <summary>
    /// The value of the header to add.
    /// </summary>
    public TerraformValue<string>? HeaderValue
    {
        get => GetArgument<TerraformValue<string>>("header_value");
        set => SetArgument("header_value", value);
    }

    /// <summary>
    /// If false, headerValue is appended to any values that already exist for the header. If true, headerValue is set for the header, discarding any values that were set for that header.
    /// The default value is false.
    /// </summary>
    public TerraformValue<bool>? Replace
    {
        get => GetArgument<TerraformValue<bool>>("replace");
        set => SetArgument("replace", value);
    }

}

/// <summary>
/// Block type for response_headers_to_add in GoogleComputeRegionUrlMapHeaderActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionUrlMapHeaderActionBlockResponseHeadersToAddBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "response_headers_to_add";

    /// <summary>
    /// The name of the header.
    /// </summary>
    public TerraformValue<string>? HeaderName
    {
        get => GetArgument<TerraformValue<string>>("header_name");
        set => SetArgument("header_name", value);
    }

    /// <summary>
    /// The value of the header to add.
    /// </summary>
    public TerraformValue<string>? HeaderValue
    {
        get => GetArgument<TerraformValue<string>>("header_value");
        set => SetArgument("header_value", value);
    }

    /// <summary>
    /// If false, headerValue is appended to any values that already exist for the header. If true, headerValue is set for the header, discarding any values that were set for that header.
    /// The default value is false.
    /// </summary>
    public TerraformValue<bool>? Replace
    {
        get => GetArgument<TerraformValue<bool>>("replace");
        set => SetArgument("replace", value);
    }

}


/// <summary>
/// Block type for host_rule in GoogleComputeRegionUrlMap.
/// Nesting mode: set
/// </summary>
public class GoogleComputeRegionUrlMapHostRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "host_rule";

    /// <summary>
    /// An optional description of this HostRule. Provide this property
    /// when you create the resource.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The list of host patterns to match. They must be valid
    /// hostnames, except * will match any string of ([a-z0-9-.]*). In
    /// that case, * must be the first character and must be followed in
    /// the pattern by either - or ..
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hosts is required")]
    public required TerraformSet<string> Hosts
    {
        get => GetRequiredArgument<TerraformSet<string>>("hosts");
        set => SetArgument("hosts", value);
    }

    /// <summary>
    /// The name of the PathMatcher to use to match the path portion of
    /// the URL if the hostRule matches the URL&#39;s host portion.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PathMatcher is required")]
    public required TerraformValue<string> PathMatcher
    {
        get => GetRequiredArgument<TerraformValue<string>>("path_matcher");
        set => SetArgument("path_matcher", value);
    }

}


/// <summary>
/// Block type for path_matcher in GoogleComputeRegionUrlMap.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionUrlMapPathMatcherBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "path_matcher";

    /// <summary>
    /// A reference to a RegionBackendService resource. This will be used if
    /// none of the pathRules defined by this PathMatcher is matched by
    /// the URL&#39;s path portion.
    /// </summary>
    public TerraformValue<string>? DefaultService
    {
        get => GetArgument<TerraformValue<string>>("default_service");
        set => SetArgument("default_service", value);
    }

    /// <summary>
    /// An optional description of this resource.
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
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// DefaultRouteAction block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultRouteAction block(s) allowed")]
    public TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockDefaultRouteActionBlock>? DefaultRouteAction
    {
        get => GetArgument<TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockDefaultRouteActionBlock>>("default_route_action");
        set => SetArgument("default_route_action", value);
    }

    /// <summary>
    /// DefaultUrlRedirect block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultUrlRedirect block(s) allowed")]
    public TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockDefaultUrlRedirectBlock>? DefaultUrlRedirect
    {
        get => GetArgument<TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockDefaultUrlRedirectBlock>>("default_url_redirect");
        set => SetArgument("default_url_redirect", value);
    }

    /// <summary>
    /// HeaderAction block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HeaderAction block(s) allowed")]
    public TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockHeaderActionBlock>? HeaderAction
    {
        get => GetArgument<TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockHeaderActionBlock>>("header_action");
        set => SetArgument("header_action", value);
    }

    /// <summary>
    /// PathRule block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockPathRuleBlock>? PathRule
    {
        get => GetArgument<TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockPathRuleBlock>>("path_rule");
        set => SetArgument("path_rule", value);
    }

    /// <summary>
    /// RouteRules block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlock>? RouteRules
    {
        get => GetArgument<TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlock>>("route_rules");
        set => SetArgument("route_rules", value);
    }

}

/// <summary>
/// Block type for default_route_action in GoogleComputeRegionUrlMapPathMatcherBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionUrlMapPathMatcherBlockDefaultRouteActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "default_route_action";

    /// <summary>
    /// CorsPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CorsPolicy block(s) allowed")]
    public TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockDefaultRouteActionBlockCorsPolicyBlock>? CorsPolicy
    {
        get => GetArgument<TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockDefaultRouteActionBlockCorsPolicyBlock>>("cors_policy");
        set => SetArgument("cors_policy", value);
    }

    /// <summary>
    /// FaultInjectionPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FaultInjectionPolicy block(s) allowed")]
    public TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockDefaultRouteActionBlockFaultInjectionPolicyBlock>? FaultInjectionPolicy
    {
        get => GetArgument<TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockDefaultRouteActionBlockFaultInjectionPolicyBlock>>("fault_injection_policy");
        set => SetArgument("fault_injection_policy", value);
    }

    /// <summary>
    /// MaxStreamDuration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaxStreamDuration block(s) allowed")]
    public TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockDefaultRouteActionBlockMaxStreamDurationBlock>? MaxStreamDuration
    {
        get => GetArgument<TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockDefaultRouteActionBlockMaxStreamDurationBlock>>("max_stream_duration");
        set => SetArgument("max_stream_duration", value);
    }

    /// <summary>
    /// RequestMirrorPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RequestMirrorPolicy block(s) allowed")]
    public TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockDefaultRouteActionBlockRequestMirrorPolicyBlock>? RequestMirrorPolicy
    {
        get => GetArgument<TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockDefaultRouteActionBlockRequestMirrorPolicyBlock>>("request_mirror_policy");
        set => SetArgument("request_mirror_policy", value);
    }

    /// <summary>
    /// RetryPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetryPolicy block(s) allowed")]
    public TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockDefaultRouteActionBlockRetryPolicyBlock>? RetryPolicy
    {
        get => GetArgument<TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockDefaultRouteActionBlockRetryPolicyBlock>>("retry_policy");
        set => SetArgument("retry_policy", value);
    }

    /// <summary>
    /// Timeout block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Timeout block(s) allowed")]
    public TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockDefaultRouteActionBlockTimeoutBlock>? Timeout
    {
        get => GetArgument<TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockDefaultRouteActionBlockTimeoutBlock>>("timeout");
        set => SetArgument("timeout", value);
    }

    /// <summary>
    /// UrlRewrite block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UrlRewrite block(s) allowed")]
    public TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockDefaultRouteActionBlockUrlRewriteBlock>? UrlRewrite
    {
        get => GetArgument<TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockDefaultRouteActionBlockUrlRewriteBlock>>("url_rewrite");
        set => SetArgument("url_rewrite", value);
    }

    /// <summary>
    /// WeightedBackendServices block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockDefaultRouteActionBlockWeightedBackendServicesBlock>? WeightedBackendServices
    {
        get => GetArgument<TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockDefaultRouteActionBlockWeightedBackendServicesBlock>>("weighted_backend_services");
        set => SetArgument("weighted_backend_services", value);
    }

}

/// <summary>
/// Block type for cors_policy in GoogleComputeRegionUrlMapPathMatcherBlockDefaultRouteActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionUrlMapPathMatcherBlockDefaultRouteActionBlockCorsPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cors_policy";

    /// <summary>
    /// In response to a preflight request, setting this to true indicates that the actual request can include user credentials.
    /// This translates to the Access-Control-Allow-Credentials header.
    /// </summary>
    public TerraformValue<bool>? AllowCredentials
    {
        get => GetArgument<TerraformValue<bool>>("allow_credentials");
        set => SetArgument("allow_credentials", value);
    }

    /// <summary>
    /// Specifies the content for the Access-Control-Allow-Headers header.
    /// </summary>
    public TerraformList<string>? AllowHeaders
    {
        get => GetArgument<TerraformList<string>>("allow_headers");
        set => SetArgument("allow_headers", value);
    }

    /// <summary>
    /// Specifies the content for the Access-Control-Allow-Methods header.
    /// </summary>
    public TerraformList<string>? AllowMethods
    {
        get => GetArgument<TerraformList<string>>("allow_methods");
        set => SetArgument("allow_methods", value);
    }

    /// <summary>
    /// Specifies the regular expression patterns that match allowed origins. For regular expression grammar
    /// please see en.cppreference.com/w/cpp/regex/ecmascript
    /// An origin is allowed if it matches either an item in allowOrigins or an item in allowOriginRegexes.
    /// </summary>
    public TerraformList<string>? AllowOriginRegexes
    {
        get => GetArgument<TerraformList<string>>("allow_origin_regexes");
        set => SetArgument("allow_origin_regexes", value);
    }

    /// <summary>
    /// Specifies the list of origins that will be allowed to do CORS requests.
    /// An origin is allowed if it matches either an item in allowOrigins or an item in allowOriginRegexes.
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
    /// Specifies the content for the Access-Control-Expose-Headers header.
    /// </summary>
    public TerraformList<string>? ExposeHeaders
    {
        get => GetArgument<TerraformList<string>>("expose_headers");
        set => SetArgument("expose_headers", value);
    }

    /// <summary>
    /// Specifies how long results of a preflight request can be cached in seconds.
    /// This translates to the Access-Control-Max-Age header.
    /// </summary>
    public TerraformValue<double>? MaxAge
    {
        get => GetArgument<TerraformValue<double>>("max_age");
        set => SetArgument("max_age", value);
    }

}

/// <summary>
/// Block type for fault_injection_policy in GoogleComputeRegionUrlMapPathMatcherBlockDefaultRouteActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionUrlMapPathMatcherBlockDefaultRouteActionBlockFaultInjectionPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "fault_injection_policy";

    /// <summary>
    /// Abort block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Abort block(s) allowed")]
    public TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockDefaultRouteActionBlockFaultInjectionPolicyBlockAbortBlock>? Abort
    {
        get => GetArgument<TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockDefaultRouteActionBlockFaultInjectionPolicyBlockAbortBlock>>("abort");
        set => SetArgument("abort", value);
    }

    /// <summary>
    /// Delay block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Delay block(s) allowed")]
    public TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockDefaultRouteActionBlockFaultInjectionPolicyBlockDelayBlock>? Delay
    {
        get => GetArgument<TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockDefaultRouteActionBlockFaultInjectionPolicyBlockDelayBlock>>("delay");
        set => SetArgument("delay", value);
    }

}

/// <summary>
/// Block type for abort in GoogleComputeRegionUrlMapPathMatcherBlockDefaultRouteActionBlockFaultInjectionPolicyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionUrlMapPathMatcherBlockDefaultRouteActionBlockFaultInjectionPolicyBlockAbortBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "abort";

    /// <summary>
    /// The HTTP status code used to abort the request.
    /// The value must be between 200 and 599 inclusive.
    /// </summary>
    public TerraformValue<double>? HttpStatus
    {
        get => GetArgument<TerraformValue<double>>("http_status");
        set => SetArgument("http_status", value);
    }

    /// <summary>
    /// The percentage of traffic (connections/operations/requests) which will be aborted as part of fault injection.
    /// The value must be between 0.0 and 100.0 inclusive.
    /// </summary>
    public TerraformValue<double>? Percentage
    {
        get => GetArgument<TerraformValue<double>>("percentage");
        set => SetArgument("percentage", value);
    }

}

/// <summary>
/// Block type for delay in GoogleComputeRegionUrlMapPathMatcherBlockDefaultRouteActionBlockFaultInjectionPolicyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionUrlMapPathMatcherBlockDefaultRouteActionBlockFaultInjectionPolicyBlockDelayBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "delay";

    /// <summary>
    /// The percentage of traffic (connections/operations/requests) on which delay will be introduced as part of fault injection.
    /// The value must be between 0.0 and 100.0 inclusive.
    /// </summary>
    public TerraformValue<double>? Percentage
    {
        get => GetArgument<TerraformValue<double>>("percentage");
        set => SetArgument("percentage", value);
    }

    /// <summary>
    /// FixedDelay block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FixedDelay block(s) allowed")]
    public TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockDefaultRouteActionBlockFaultInjectionPolicyBlockDelayBlockFixedDelayBlock>? FixedDelay
    {
        get => GetArgument<TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockDefaultRouteActionBlockFaultInjectionPolicyBlockDelayBlockFixedDelayBlock>>("fixed_delay");
        set => SetArgument("fixed_delay", value);
    }

}

/// <summary>
/// Block type for fixed_delay in GoogleComputeRegionUrlMapPathMatcherBlockDefaultRouteActionBlockFaultInjectionPolicyBlockDelayBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionUrlMapPathMatcherBlockDefaultRouteActionBlockFaultInjectionPolicyBlockDelayBlockFixedDelayBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "fixed_delay";

    /// <summary>
    /// Span of time that&#39;s a fraction of a second at nanosecond resolution. Durations less than one second are
    /// represented with a 0 seconds field and a positive nanos field. Must be from 0 to 999,999,999 inclusive.
    /// </summary>
    public TerraformValue<double>? Nanos
    {
        get => GetArgument<TerraformValue<double>>("nanos");
        set => SetArgument("nanos", value);
    }

    /// <summary>
    /// Span of time at a resolution of a second. Must be from 0 to 315,576,000,000 inclusive.
    /// Note: these bounds are computed from: 60 sec/min * 60 min/hr * 24 hr/day * 365.25 days/year * 10000 years
    /// </summary>
    public TerraformValue<string>? Seconds
    {
        get => GetArgument<TerraformValue<string>>("seconds");
        set => SetArgument("seconds", value);
    }

}

/// <summary>
/// Block type for max_stream_duration in GoogleComputeRegionUrlMapPathMatcherBlockDefaultRouteActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionUrlMapPathMatcherBlockDefaultRouteActionBlockMaxStreamDurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "max_stream_duration";

    /// <summary>
    /// Span of time that&#39;s a fraction of a second at nanosecond resolution. Durations less than one second are represented
    /// with a 0 seconds field and a positive nanos field. Must be from 0 to 999,999,999 inclusive.
    /// </summary>
    public TerraformValue<double>? Nanos
    {
        get => GetArgument<TerraformValue<double>>("nanos");
        set => SetArgument("nanos", value);
    }

    /// <summary>
    /// Span of time at a resolution of a second. Must be from 0 to 315,576,000,000 inclusive.
    /// Note: these bounds are computed from: 60 sec/min * 60 min/hr * 24 hr/day * 365.25 days/year * 10000 years
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Seconds is required")]
    public required TerraformValue<string> Seconds
    {
        get => GetRequiredArgument<TerraformValue<string>>("seconds");
        set => SetArgument("seconds", value);
    }

}

/// <summary>
/// Block type for request_mirror_policy in GoogleComputeRegionUrlMapPathMatcherBlockDefaultRouteActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionUrlMapPathMatcherBlockDefaultRouteActionBlockRequestMirrorPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "request_mirror_policy";

    /// <summary>
    /// The full or partial URL to the BackendService resource being mirrored to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackendService is required")]
    public required TerraformValue<string> BackendService
    {
        get => GetRequiredArgument<TerraformValue<string>>("backend_service");
        set => SetArgument("backend_service", value);
    }

}

/// <summary>
/// Block type for retry_policy in GoogleComputeRegionUrlMapPathMatcherBlockDefaultRouteActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionUrlMapPathMatcherBlockDefaultRouteActionBlockRetryPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "retry_policy";

    /// <summary>
    /// Specifies the allowed number retries. This number must be &amp;gt; 0. If not specified, defaults to 1.
    /// </summary>
    public TerraformValue<double>? NumRetries
    {
        get => GetArgument<TerraformValue<double>>("num_retries");
        set => SetArgument("num_retries", value);
    }

    /// <summary>
    /// Specfies one or more conditions when this retry rule applies. Valid values are:
    /// 
    /// * 5xx: Loadbalancer will attempt a retry if the backend service responds with any 5xx response code,
    ///   or if the backend service does not respond at all, example: disconnects, reset, read timeout,
    /// * connection failure, and refused streams.
    /// * gateway-error: Similar to 5xx, but only applies to response codes 502, 503 or 504.
    /// * connect-failure: Loadbalancer will retry on failures connecting to backend services,
    ///   for example due to connection timeouts.
    /// * retriable-4xx: Loadbalancer will retry for retriable 4xx response codes.
    ///   Currently the only retriable error supported is 409.
    /// * refused-stream:Loadbalancer will retry if the backend service resets the stream with a REFUSED_STREAM error code.
    ///   This reset type indicates that it is safe to retry.
    /// * cancelled: Loadbalancer will retry if the gRPC status code in the response header is set to cancelled
    /// * deadline-exceeded: Loadbalancer will retry if the gRPC status code in the response header is set to deadline-exceeded
    /// * resource-exhausted: Loadbalancer will retry if the gRPC status code in the response header is set to resource-exhausted
    /// * unavailable: Loadbalancer will retry if the gRPC status code in the response header is set to unavailable
    /// </summary>
    public TerraformList<string>? RetryConditions
    {
        get => GetArgument<TerraformList<string>>("retry_conditions");
        set => SetArgument("retry_conditions", value);
    }

    /// <summary>
    /// PerTryTimeout block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PerTryTimeout block(s) allowed")]
    public TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockDefaultRouteActionBlockRetryPolicyBlockPerTryTimeoutBlock>? PerTryTimeout
    {
        get => GetArgument<TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockDefaultRouteActionBlockRetryPolicyBlockPerTryTimeoutBlock>>("per_try_timeout");
        set => SetArgument("per_try_timeout", value);
    }

}

/// <summary>
/// Block type for per_try_timeout in GoogleComputeRegionUrlMapPathMatcherBlockDefaultRouteActionBlockRetryPolicyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionUrlMapPathMatcherBlockDefaultRouteActionBlockRetryPolicyBlockPerTryTimeoutBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "per_try_timeout";

    /// <summary>
    /// Span of time that&#39;s a fraction of a second at nanosecond resolution. Durations less than one second are
    /// represented with a 0 seconds field and a positive nanos field. Must be from 0 to 999,999,999 inclusive.
    /// </summary>
    public TerraformValue<double>? Nanos
    {
        get => GetArgument<TerraformValue<double>>("nanos");
        set => SetArgument("nanos", value);
    }

    /// <summary>
    /// Span of time at a resolution of a second. Must be from 0 to 315,576,000,000 inclusive.
    /// Note: these bounds are computed from: 60 sec/min * 60 min/hr * 24 hr/day * 365.25 days/year * 10000 years
    /// </summary>
    public TerraformValue<string>? Seconds
    {
        get => GetArgument<TerraformValue<string>>("seconds");
        set => SetArgument("seconds", value);
    }

}

/// <summary>
/// Block type for timeout in GoogleComputeRegionUrlMapPathMatcherBlockDefaultRouteActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionUrlMapPathMatcherBlockDefaultRouteActionBlockTimeoutBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeout";

    /// <summary>
    /// Span of time that&#39;s a fraction of a second at nanosecond resolution. Durations less than one second are represented
    /// with a 0 seconds field and a positive nanos field. Must be from 0 to 999,999,999 inclusive.
    /// </summary>
    public TerraformValue<double>? Nanos
    {
        get => GetArgument<TerraformValue<double>>("nanos");
        set => SetArgument("nanos", value);
    }

    /// <summary>
    /// Span of time at a resolution of a second. Must be from 0 to 315,576,000,000 inclusive.
    /// Note: these bounds are computed from: 60 sec/min * 60 min/hr * 24 hr/day * 365.25 days/year * 10000 years
    /// </summary>
    public TerraformValue<string>? Seconds
    {
        get => GetArgument<TerraformValue<string>>("seconds");
        set => SetArgument("seconds", value);
    }

}

/// <summary>
/// Block type for url_rewrite in GoogleComputeRegionUrlMapPathMatcherBlockDefaultRouteActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionUrlMapPathMatcherBlockDefaultRouteActionBlockUrlRewriteBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "url_rewrite";

    /// <summary>
    /// Prior to forwarding the request to the selected service, the request&#39;s host header is replaced
    /// with contents of hostRewrite.
    /// 
    /// The value must be between 1 and 255 characters.
    /// </summary>
    public TerraformValue<string>? HostRewrite
    {
        get => GetArgument<TerraformValue<string>>("host_rewrite");
        set => SetArgument("host_rewrite", value);
    }

    /// <summary>
    /// Prior to forwarding the request to the selected backend service, the matching portion of the
    /// request&#39;s path is replaced by pathPrefixRewrite.
    /// 
    /// The value must be between 1 and 1024 characters.
    /// </summary>
    public TerraformValue<string>? PathPrefixRewrite
    {
        get => GetArgument<TerraformValue<string>>("path_prefix_rewrite");
        set => SetArgument("path_prefix_rewrite", value);
    }

    /// <summary>
    /// If specified, the pattern rewrites the URL path (based on the :path header) using the HTTP template syntax.
    /// 
    /// A corresponding pathTemplateMatch must be specified. Any template variables must exist in the pathTemplateMatch field.
    /// 
    /// * At least one variable must be specified in the pathTemplateMatch field
    /// * You can omit variables from the rewritten URL
    /// * The * and ** operators cannot be matched unless they have a corresponding variable name - e.g. {format=*} or {var=**}.
    /// 
    /// For example, a pathTemplateMatch of /static/{format=**} could be rewritten as /static/content/{format} to prefix
    /// /content to the URL. Variables can also be re-ordered in a rewrite, so that /{country}/{format}/{suffix=**} can be
    /// rewritten as /content/{format}/{country}/{suffix}.
    /// 
    /// At least one non-empty routeRules[].matchRules[].path_template_match is required.
    /// 
    /// Only one of pathPrefixRewrite or pathTemplateRewrite may be specified.
    /// </summary>
    public TerraformValue<string>? PathTemplateRewrite
    {
        get => GetArgument<TerraformValue<string>>("path_template_rewrite");
        set => SetArgument("path_template_rewrite", value);
    }

}

/// <summary>
/// Block type for weighted_backend_services in GoogleComputeRegionUrlMapPathMatcherBlockDefaultRouteActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionUrlMapPathMatcherBlockDefaultRouteActionBlockWeightedBackendServicesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "weighted_backend_services";

    /// <summary>
    /// The full or partial URL to the default BackendService resource. Before forwarding the
    /// request to backendService, the loadbalancer applies any relevant headerActions
    /// specified as part of this backendServiceWeight.
    /// </summary>
    public TerraformValue<string>? BackendService
    {
        get => GetArgument<TerraformValue<string>>("backend_service");
        set => SetArgument("backend_service", value);
    }

    /// <summary>
    /// Specifies the fraction of traffic sent to backendService, computed as
    /// weight / (sum of all weightedBackendService weights in routeAction) .
    /// 
    /// The selection of a backend service is determined only for new traffic. Once a user&#39;s request
    /// has been directed to a backendService, subsequent requests will be sent to the same backendService
    /// as determined by the BackendService&#39;s session affinity policy.
    /// 
    /// The value must be between 0 and 1000
    /// </summary>
    public TerraformValue<double>? Weight
    {
        get => GetArgument<TerraformValue<double>>("weight");
        set => SetArgument("weight", value);
    }

    /// <summary>
    /// HeaderAction block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HeaderAction block(s) allowed")]
    public TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockDefaultRouteActionBlockWeightedBackendServicesBlockHeaderActionBlock>? HeaderAction
    {
        get => GetArgument<TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockDefaultRouteActionBlockWeightedBackendServicesBlockHeaderActionBlock>>("header_action");
        set => SetArgument("header_action", value);
    }

}

/// <summary>
/// Block type for header_action in GoogleComputeRegionUrlMapPathMatcherBlockDefaultRouteActionBlockWeightedBackendServicesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionUrlMapPathMatcherBlockDefaultRouteActionBlockWeightedBackendServicesBlockHeaderActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "header_action";

    /// <summary>
    /// A list of header names for headers that need to be removed from the request prior to
    /// forwarding the request to the backendService.
    /// </summary>
    public TerraformList<string>? RequestHeadersToRemove
    {
        get => GetArgument<TerraformList<string>>("request_headers_to_remove");
        set => SetArgument("request_headers_to_remove", value);
    }

    /// <summary>
    /// A list of header names for headers that need to be removed from the response prior to sending the
    /// response back to the client.
    /// </summary>
    public TerraformList<string>? ResponseHeadersToRemove
    {
        get => GetArgument<TerraformList<string>>("response_headers_to_remove");
        set => SetArgument("response_headers_to_remove", value);
    }

    /// <summary>
    /// RequestHeadersToAdd block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockDefaultRouteActionBlockWeightedBackendServicesBlockHeaderActionBlockRequestHeadersToAddBlock>? RequestHeadersToAdd
    {
        get => GetArgument<TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockDefaultRouteActionBlockWeightedBackendServicesBlockHeaderActionBlockRequestHeadersToAddBlock>>("request_headers_to_add");
        set => SetArgument("request_headers_to_add", value);
    }

    /// <summary>
    /// ResponseHeadersToAdd block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockDefaultRouteActionBlockWeightedBackendServicesBlockHeaderActionBlockResponseHeadersToAddBlock>? ResponseHeadersToAdd
    {
        get => GetArgument<TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockDefaultRouteActionBlockWeightedBackendServicesBlockHeaderActionBlockResponseHeadersToAddBlock>>("response_headers_to_add");
        set => SetArgument("response_headers_to_add", value);
    }

}

/// <summary>
/// Block type for request_headers_to_add in GoogleComputeRegionUrlMapPathMatcherBlockDefaultRouteActionBlockWeightedBackendServicesBlockHeaderActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionUrlMapPathMatcherBlockDefaultRouteActionBlockWeightedBackendServicesBlockHeaderActionBlockRequestHeadersToAddBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "request_headers_to_add";

    /// <summary>
    /// The name of the header to add.
    /// </summary>
    public TerraformValue<string>? HeaderName
    {
        get => GetArgument<TerraformValue<string>>("header_name");
        set => SetArgument("header_name", value);
    }

    /// <summary>
    /// The value of the header to add.
    /// </summary>
    public TerraformValue<string>? HeaderValue
    {
        get => GetArgument<TerraformValue<string>>("header_value");
        set => SetArgument("header_value", value);
    }

    /// <summary>
    /// If false, headerValue is appended to any values that already exist for the header.
    /// If true, headerValue is set for the header, discarding any values that were set for that header.
    /// </summary>
    public TerraformValue<bool>? Replace
    {
        get => GetArgument<TerraformValue<bool>>("replace");
        set => SetArgument("replace", value);
    }

}

/// <summary>
/// Block type for response_headers_to_add in GoogleComputeRegionUrlMapPathMatcherBlockDefaultRouteActionBlockWeightedBackendServicesBlockHeaderActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionUrlMapPathMatcherBlockDefaultRouteActionBlockWeightedBackendServicesBlockHeaderActionBlockResponseHeadersToAddBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "response_headers_to_add";

    /// <summary>
    /// The name of the header to add.
    /// </summary>
    public TerraformValue<string>? HeaderName
    {
        get => GetArgument<TerraformValue<string>>("header_name");
        set => SetArgument("header_name", value);
    }

    /// <summary>
    /// The value of the header to add.
    /// </summary>
    public TerraformValue<string>? HeaderValue
    {
        get => GetArgument<TerraformValue<string>>("header_value");
        set => SetArgument("header_value", value);
    }

    /// <summary>
    /// If false, headerValue is appended to any values that already exist for the header.
    /// If true, headerValue is set for the header, discarding any values that were set for that header.
    /// </summary>
    public TerraformValue<bool>? Replace
    {
        get => GetArgument<TerraformValue<bool>>("replace");
        set => SetArgument("replace", value);
    }

}

/// <summary>
/// Block type for default_url_redirect in GoogleComputeRegionUrlMapPathMatcherBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionUrlMapPathMatcherBlockDefaultUrlRedirectBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "default_url_redirect";

    /// <summary>
    /// The host that will be used in the redirect response instead of the one that was
    /// supplied in the request. The value must be between 1 and 255 characters.
    /// </summary>
    public TerraformValue<string>? HostRedirect
    {
        get => GetArgument<TerraformValue<string>>("host_redirect");
        set => SetArgument("host_redirect", value);
    }

    /// <summary>
    /// If set to true, the URL scheme in the redirected request is set to https. If set to
    /// false, the URL scheme of the redirected request will remain the same as that of the
    /// request. This must only be set for UrlMaps used in TargetHttpProxys. Setting this
    /// true for TargetHttpsProxy is not permitted. The default is set to false.
    /// </summary>
    public TerraformValue<bool>? HttpsRedirect
    {
        get => GetArgument<TerraformValue<bool>>("https_redirect");
        set => SetArgument("https_redirect", value);
    }

    /// <summary>
    /// The path that will be used in the redirect response instead of the one that was
    /// supplied in the request. pathRedirect cannot be supplied together with
    /// prefixRedirect. Supply one alone or neither. If neither is supplied, the path of the
    /// original request will be used for the redirect. The value must be between 1 and 1024
    /// characters.
    /// </summary>
    public TerraformValue<string>? PathRedirect
    {
        get => GetArgument<TerraformValue<string>>("path_redirect");
        set => SetArgument("path_redirect", value);
    }

    /// <summary>
    /// The prefix that replaces the prefixMatch specified in the HttpRouteRuleMatch,
    /// retaining the remaining portion of the URL before redirecting the request.
    /// prefixRedirect cannot be supplied together with pathRedirect. Supply one alone or
    /// neither. If neither is supplied, the path of the original request will be used for
    /// the redirect. The value must be between 1 and 1024 characters.
    /// </summary>
    public TerraformValue<string>? PrefixRedirect
    {
        get => GetArgument<TerraformValue<string>>("prefix_redirect");
        set => SetArgument("prefix_redirect", value);
    }

    /// <summary>
    /// The HTTP Status code to use for this RedirectAction. Supported values are:
    /// 
    /// * MOVED_PERMANENTLY_DEFAULT, which is the default value and corresponds to 301.
    /// 
    /// * FOUND, which corresponds to 302.
    /// 
    /// * SEE_OTHER which corresponds to 303.
    /// 
    /// * TEMPORARY_REDIRECT, which corresponds to 307. In this case, the request method
    /// will be retained.
    /// 
    /// * PERMANENT_REDIRECT, which corresponds to 308. In this case,
    /// the request method will be retained. Possible values: [&amp;quot;FOUND&amp;quot;, &amp;quot;MOVED_PERMANENTLY_DEFAULT&amp;quot;, &amp;quot;PERMANENT_REDIRECT&amp;quot;, &amp;quot;SEE_OTHER&amp;quot;, &amp;quot;TEMPORARY_REDIRECT&amp;quot;]
    /// </summary>
    public TerraformValue<string>? RedirectResponseCode
    {
        get => GetArgument<TerraformValue<string>>("redirect_response_code");
        set => SetArgument("redirect_response_code", value);
    }

    /// <summary>
    /// If set to true, any accompanying query portion of the original URL is removed prior
    /// to redirecting the request. If set to false, the query portion of the original URL is
    /// retained.
    ///  This field is required to ensure an empty block is not set. The normal default value is false.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StripQuery is required")]
    public required TerraformValue<bool> StripQuery
    {
        get => GetRequiredArgument<TerraformValue<bool>>("strip_query");
        set => SetArgument("strip_query", value);
    }

}

/// <summary>
/// Block type for header_action in GoogleComputeRegionUrlMapPathMatcherBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionUrlMapPathMatcherBlockHeaderActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "header_action";

    /// <summary>
    /// A list of header names for headers that need to be removed from the request before forwarding the request to the backendService.
    /// </summary>
    public TerraformList<string>? RequestHeadersToRemove
    {
        get => GetArgument<TerraformList<string>>("request_headers_to_remove");
        set => SetArgument("request_headers_to_remove", value);
    }

    /// <summary>
    /// A list of header names for headers that need to be removed from the response before sending the response back to the client.
    /// </summary>
    public TerraformList<string>? ResponseHeadersToRemove
    {
        get => GetArgument<TerraformList<string>>("response_headers_to_remove");
        set => SetArgument("response_headers_to_remove", value);
    }

    /// <summary>
    /// RequestHeadersToAdd block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockHeaderActionBlockRequestHeadersToAddBlock>? RequestHeadersToAdd
    {
        get => GetArgument<TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockHeaderActionBlockRequestHeadersToAddBlock>>("request_headers_to_add");
        set => SetArgument("request_headers_to_add", value);
    }

    /// <summary>
    /// ResponseHeadersToAdd block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockHeaderActionBlockResponseHeadersToAddBlock>? ResponseHeadersToAdd
    {
        get => GetArgument<TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockHeaderActionBlockResponseHeadersToAddBlock>>("response_headers_to_add");
        set => SetArgument("response_headers_to_add", value);
    }

}

/// <summary>
/// Block type for request_headers_to_add in GoogleComputeRegionUrlMapPathMatcherBlockHeaderActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionUrlMapPathMatcherBlockHeaderActionBlockRequestHeadersToAddBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "request_headers_to_add";

    /// <summary>
    /// The name of the header.
    /// </summary>
    public TerraformValue<string>? HeaderName
    {
        get => GetArgument<TerraformValue<string>>("header_name");
        set => SetArgument("header_name", value);
    }

    /// <summary>
    /// The value of the header to add.
    /// </summary>
    public TerraformValue<string>? HeaderValue
    {
        get => GetArgument<TerraformValue<string>>("header_value");
        set => SetArgument("header_value", value);
    }

    /// <summary>
    /// If false, headerValue is appended to any values that already exist for the header. If true, headerValue is set for the header, discarding any values that were set for that header.
    /// The default value is false.
    /// </summary>
    public TerraformValue<bool>? Replace
    {
        get => GetArgument<TerraformValue<bool>>("replace");
        set => SetArgument("replace", value);
    }

}

/// <summary>
/// Block type for response_headers_to_add in GoogleComputeRegionUrlMapPathMatcherBlockHeaderActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionUrlMapPathMatcherBlockHeaderActionBlockResponseHeadersToAddBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "response_headers_to_add";

    /// <summary>
    /// The name of the header.
    /// </summary>
    public TerraformValue<string>? HeaderName
    {
        get => GetArgument<TerraformValue<string>>("header_name");
        set => SetArgument("header_name", value);
    }

    /// <summary>
    /// The value of the header to add.
    /// </summary>
    public TerraformValue<string>? HeaderValue
    {
        get => GetArgument<TerraformValue<string>>("header_value");
        set => SetArgument("header_value", value);
    }

    /// <summary>
    /// If false, headerValue is appended to any values that already exist for the header. If true, headerValue is set for the header, discarding any values that were set for that header.
    /// The default value is false.
    /// </summary>
    public TerraformValue<bool>? Replace
    {
        get => GetArgument<TerraformValue<bool>>("replace");
        set => SetArgument("replace", value);
    }

}

/// <summary>
/// Block type for path_rule in GoogleComputeRegionUrlMapPathMatcherBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionUrlMapPathMatcherBlockPathRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "path_rule";

    /// <summary>
    /// The list of path patterns to match. Each must start with / and the only place a
    /// \* is allowed is at the end following a /. The string fed to the path matcher
    /// does not include any text after the first ? or #, and those chars are not
    /// allowed here.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Paths is required")]
    public required TerraformSet<string> Paths
    {
        get => GetRequiredArgument<TerraformSet<string>>("paths");
        set => SetArgument("paths", value);
    }

    /// <summary>
    /// The region backend service resource to which traffic is
    /// directed if this rule is matched. If routeAction is additionally specified,
    /// advanced routing actions like URL Rewrites, etc. take effect prior to sending
    /// the request to the backend. However, if service is specified, routeAction cannot
    /// contain any weightedBackendService s. Conversely, if routeAction specifies any
    /// weightedBackendServices, service must not be specified. Only one of urlRedirect,
    /// service or routeAction.weightedBackendService must be set.
    /// </summary>
    public TerraformValue<string>? Service
    {
        get => GetArgument<TerraformValue<string>>("service");
        set => SetArgument("service", value);
    }

    /// <summary>
    /// RouteAction block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RouteAction block(s) allowed")]
    public TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockPathRuleBlockRouteActionBlock>? RouteAction
    {
        get => GetArgument<TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockPathRuleBlockRouteActionBlock>>("route_action");
        set => SetArgument("route_action", value);
    }

    /// <summary>
    /// UrlRedirect block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UrlRedirect block(s) allowed")]
    public TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockPathRuleBlockUrlRedirectBlock>? UrlRedirect
    {
        get => GetArgument<TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockPathRuleBlockUrlRedirectBlock>>("url_redirect");
        set => SetArgument("url_redirect", value);
    }

}

/// <summary>
/// Block type for route_action in GoogleComputeRegionUrlMapPathMatcherBlockPathRuleBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionUrlMapPathMatcherBlockPathRuleBlockRouteActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "route_action";

    /// <summary>
    /// CorsPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CorsPolicy block(s) allowed")]
    public TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockCorsPolicyBlock>? CorsPolicy
    {
        get => GetArgument<TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockCorsPolicyBlock>>("cors_policy");
        set => SetArgument("cors_policy", value);
    }

    /// <summary>
    /// FaultInjectionPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FaultInjectionPolicy block(s) allowed")]
    public TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockFaultInjectionPolicyBlock>? FaultInjectionPolicy
    {
        get => GetArgument<TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockFaultInjectionPolicyBlock>>("fault_injection_policy");
        set => SetArgument("fault_injection_policy", value);
    }

    /// <summary>
    /// RequestMirrorPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RequestMirrorPolicy block(s) allowed")]
    public TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockRequestMirrorPolicyBlock>? RequestMirrorPolicy
    {
        get => GetArgument<TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockRequestMirrorPolicyBlock>>("request_mirror_policy");
        set => SetArgument("request_mirror_policy", value);
    }

    /// <summary>
    /// RetryPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetryPolicy block(s) allowed")]
    public TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockRetryPolicyBlock>? RetryPolicy
    {
        get => GetArgument<TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockRetryPolicyBlock>>("retry_policy");
        set => SetArgument("retry_policy", value);
    }

    /// <summary>
    /// Timeout block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Timeout block(s) allowed")]
    public TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockTimeoutBlock>? Timeout
    {
        get => GetArgument<TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockTimeoutBlock>>("timeout");
        set => SetArgument("timeout", value);
    }

    /// <summary>
    /// UrlRewrite block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UrlRewrite block(s) allowed")]
    public TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockUrlRewriteBlock>? UrlRewrite
    {
        get => GetArgument<TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockUrlRewriteBlock>>("url_rewrite");
        set => SetArgument("url_rewrite", value);
    }

    /// <summary>
    /// WeightedBackendServices block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockWeightedBackendServicesBlock>? WeightedBackendServices
    {
        get => GetArgument<TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockWeightedBackendServicesBlock>>("weighted_backend_services");
        set => SetArgument("weighted_backend_services", value);
    }

}

/// <summary>
/// Block type for cors_policy in GoogleComputeRegionUrlMapPathMatcherBlockPathRuleBlockRouteActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockCorsPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cors_policy";

    /// <summary>
    /// In response to a preflight request, setting this to true indicates that the
    /// actual request can include user credentials. This translates to the Access-
    /// Control-Allow-Credentials header. Defaults to false.
    /// </summary>
    public TerraformValue<bool>? AllowCredentials
    {
        get => GetArgument<TerraformValue<bool>>("allow_credentials");
        set => SetArgument("allow_credentials", value);
    }

    /// <summary>
    /// Specifies the content for the Access-Control-Allow-Headers header.
    /// </summary>
    public TerraformList<string>? AllowHeaders
    {
        get => GetArgument<TerraformList<string>>("allow_headers");
        set => SetArgument("allow_headers", value);
    }

    /// <summary>
    /// Specifies the content for the Access-Control-Allow-Methods header.
    /// </summary>
    public TerraformList<string>? AllowMethods
    {
        get => GetArgument<TerraformList<string>>("allow_methods");
        set => SetArgument("allow_methods", value);
    }

    /// <summary>
    /// Specifies the regular expression patterns that match allowed origins. For
    /// regular expression grammar please see en.cppreference.com/w/cpp/regex/ecmascript
    /// An origin is allowed if it matches either allow_origins or allow_origin_regex.
    /// </summary>
    public TerraformList<string>? AllowOriginRegexes
    {
        get => GetArgument<TerraformList<string>>("allow_origin_regexes");
        set => SetArgument("allow_origin_regexes", value);
    }

    /// <summary>
    /// Specifies the list of origins that will be allowed to do CORS requests. An
    /// origin is allowed if it matches either allow_origins or allow_origin_regex.
    /// </summary>
    public TerraformList<string>? AllowOrigins
    {
        get => GetArgument<TerraformList<string>>("allow_origins");
        set => SetArgument("allow_origins", value);
    }

    /// <summary>
    /// If true, specifies the CORS policy is disabled.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Disabled is required")]
    public required TerraformValue<bool> Disabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("disabled");
        set => SetArgument("disabled", value);
    }

    /// <summary>
    /// Specifies the content for the Access-Control-Expose-Headers header.
    /// </summary>
    public TerraformList<string>? ExposeHeaders
    {
        get => GetArgument<TerraformList<string>>("expose_headers");
        set => SetArgument("expose_headers", value);
    }

    /// <summary>
    /// Specifies how long the results of a preflight request can be cached. This
    /// translates to the content for the Access-Control-Max-Age header.
    /// </summary>
    public TerraformValue<double>? MaxAge
    {
        get => GetArgument<TerraformValue<double>>("max_age");
        set => SetArgument("max_age", value);
    }

}

/// <summary>
/// Block type for fault_injection_policy in GoogleComputeRegionUrlMapPathMatcherBlockPathRuleBlockRouteActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockFaultInjectionPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "fault_injection_policy";

    /// <summary>
    /// Abort block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Abort block(s) allowed")]
    public TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockFaultInjectionPolicyBlockAbortBlock>? Abort
    {
        get => GetArgument<TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockFaultInjectionPolicyBlockAbortBlock>>("abort");
        set => SetArgument("abort", value);
    }

    /// <summary>
    /// Delay block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Delay block(s) allowed")]
    public TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockFaultInjectionPolicyBlockDelayBlock>? Delay
    {
        get => GetArgument<TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockFaultInjectionPolicyBlockDelayBlock>>("delay");
        set => SetArgument("delay", value);
    }

}

/// <summary>
/// Block type for abort in GoogleComputeRegionUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockFaultInjectionPolicyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockFaultInjectionPolicyBlockAbortBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "abort";

    /// <summary>
    /// The HTTP status code used to abort the request. The value must be between 200
    /// and 599 inclusive.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HttpStatus is required")]
    public required TerraformValue<double> HttpStatus
    {
        get => GetRequiredArgument<TerraformValue<double>>("http_status");
        set => SetArgument("http_status", value);
    }

    /// <summary>
    /// The percentage of traffic (connections/operations/requests) which will be
    /// aborted as part of fault injection. The value must be between 0.0 and 100.0
    /// inclusive.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Percentage is required")]
    public required TerraformValue<double> Percentage
    {
        get => GetRequiredArgument<TerraformValue<double>>("percentage");
        set => SetArgument("percentage", value);
    }

}

/// <summary>
/// Block type for delay in GoogleComputeRegionUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockFaultInjectionPolicyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockFaultInjectionPolicyBlockDelayBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "delay";

    /// <summary>
    /// The percentage of traffic (connections/operations/requests) on which delay will
    /// be introduced as part of fault injection. The value must be between 0.0 and
    /// 100.0 inclusive.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Percentage is required")]
    public required TerraformValue<double> Percentage
    {
        get => GetRequiredArgument<TerraformValue<double>>("percentage");
        set => SetArgument("percentage", value);
    }

    /// <summary>
    /// FixedDelay block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FixedDelay is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 FixedDelay block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FixedDelay block(s) allowed")]
    public required TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockFaultInjectionPolicyBlockDelayBlockFixedDelayBlock> FixedDelay
    {
        get => GetRequiredArgument<TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockFaultInjectionPolicyBlockDelayBlockFixedDelayBlock>>("fixed_delay");
        set => SetArgument("fixed_delay", value);
    }

}

/// <summary>
/// Block type for fixed_delay in GoogleComputeRegionUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockFaultInjectionPolicyBlockDelayBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockFaultInjectionPolicyBlockDelayBlockFixedDelayBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "fixed_delay";

    /// <summary>
    /// Span of time that&#39;s a fraction of a second at nanosecond resolution. Durations
    /// less than one second are represented with a 0 &#39;seconds&#39; field and a positive
    /// &#39;nanos&#39; field. Must be from 0 to 999,999,999 inclusive.
    /// </summary>
    public TerraformValue<double>? Nanos
    {
        get => GetArgument<TerraformValue<double>>("nanos");
        set => SetArgument("nanos", value);
    }

    /// <summary>
    /// Span of time at a resolution of a second. Must be from 0 to 315,576,000,000
    /// inclusive.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Seconds is required")]
    public required TerraformValue<string> Seconds
    {
        get => GetRequiredArgument<TerraformValue<string>>("seconds");
        set => SetArgument("seconds", value);
    }

}

/// <summary>
/// Block type for request_mirror_policy in GoogleComputeRegionUrlMapPathMatcherBlockPathRuleBlockRouteActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockRequestMirrorPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "request_mirror_policy";

    /// <summary>
    /// The RegionBackendService resource being mirrored to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackendService is required")]
    public required TerraformValue<string> BackendService
    {
        get => GetRequiredArgument<TerraformValue<string>>("backend_service");
        set => SetArgument("backend_service", value);
    }

}

/// <summary>
/// Block type for retry_policy in GoogleComputeRegionUrlMapPathMatcherBlockPathRuleBlockRouteActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockRetryPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "retry_policy";

    /// <summary>
    /// Specifies the allowed number retries. This number must be &amp;gt; 0.
    /// </summary>
    public TerraformValue<double>? NumRetries
    {
        get => GetArgument<TerraformValue<double>>("num_retries");
        set => SetArgument("num_retries", value);
    }

    /// <summary>
    /// Specifies one or more conditions when this retry rule applies. Valid values are:
    /// 
    /// - 5xx: Loadbalancer will attempt a retry if the backend service responds with
    /// any 5xx response code, or if the backend service does not respond at all,
    /// for example: disconnects, reset, read timeout, connection failure, and refused
    /// streams.
    /// - gateway-error: Similar to 5xx, but only applies to response codes
    /// 502, 503 or 504.
    /// - connect-failure: Loadbalancer will retry on failures
    /// connecting to backend services, for example due to connection timeouts.
    /// - retriable-4xx: Loadbalancer will retry for retriable 4xx response codes.
    /// Currently the only retriable error supported is 409.
    /// - refused-stream: Loadbalancer will retry if the backend service resets the stream with a
    /// REFUSED_STREAM error code. This reset type indicates that it is safe to retry.
    /// - cancelled: Loadbalancer will retry if the gRPC status code in the response
    /// header is set to cancelled
    /// - deadline-exceeded: Loadbalancer will retry if the
    /// gRPC status code in the response header is set to deadline-exceeded
    /// - resource-exhausted: Loadbalancer will retry if the gRPC status code in the response
    /// header is set to resource-exhausted
    /// - unavailable: Loadbalancer will retry if
    /// the gRPC status code in the response header is set to unavailable
    /// </summary>
    public TerraformList<string>? RetryConditions
    {
        get => GetArgument<TerraformList<string>>("retry_conditions");
        set => SetArgument("retry_conditions", value);
    }

    /// <summary>
    /// PerTryTimeout block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PerTryTimeout block(s) allowed")]
    public TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockRetryPolicyBlockPerTryTimeoutBlock>? PerTryTimeout
    {
        get => GetArgument<TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockRetryPolicyBlockPerTryTimeoutBlock>>("per_try_timeout");
        set => SetArgument("per_try_timeout", value);
    }

}

/// <summary>
/// Block type for per_try_timeout in GoogleComputeRegionUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockRetryPolicyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockRetryPolicyBlockPerTryTimeoutBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "per_try_timeout";

    /// <summary>
    /// Span of time that&#39;s a fraction of a second at nanosecond resolution. Durations
    /// less than one second are represented with a 0 &#39;seconds&#39; field and a positive
    /// &#39;nanos&#39; field. Must be from 0 to 999,999,999 inclusive.
    /// </summary>
    public TerraformValue<double>? Nanos
    {
        get => GetArgument<TerraformValue<double>>("nanos");
        set => SetArgument("nanos", value);
    }

    /// <summary>
    /// Span of time at a resolution of a second. Must be from 0 to 315,576,000,000
    /// inclusive.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Seconds is required")]
    public required TerraformValue<string> Seconds
    {
        get => GetRequiredArgument<TerraformValue<string>>("seconds");
        set => SetArgument("seconds", value);
    }

}

/// <summary>
/// Block type for timeout in GoogleComputeRegionUrlMapPathMatcherBlockPathRuleBlockRouteActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockTimeoutBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeout";

    /// <summary>
    /// Span of time that&#39;s a fraction of a second at nanosecond resolution. Durations
    /// less than one second are represented with a 0 &#39;seconds&#39; field and a positive
    /// &#39;nanos&#39; field. Must be from 0 to 999,999,999 inclusive.
    /// </summary>
    public TerraformValue<double>? Nanos
    {
        get => GetArgument<TerraformValue<double>>("nanos");
        set => SetArgument("nanos", value);
    }

    /// <summary>
    /// Span of time at a resolution of a second. Must be from 0 to 315,576,000,000
    /// inclusive.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Seconds is required")]
    public required TerraformValue<string> Seconds
    {
        get => GetRequiredArgument<TerraformValue<string>>("seconds");
        set => SetArgument("seconds", value);
    }

}

/// <summary>
/// Block type for url_rewrite in GoogleComputeRegionUrlMapPathMatcherBlockPathRuleBlockRouteActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockUrlRewriteBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "url_rewrite";

    /// <summary>
    /// Prior to forwarding the request to the selected service, the request&#39;s host
    /// header is replaced with contents of hostRewrite. The value must be between 1 and
    /// 255 characters.
    /// </summary>
    public TerraformValue<string>? HostRewrite
    {
        get => GetArgument<TerraformValue<string>>("host_rewrite");
        set => SetArgument("host_rewrite", value);
    }

    /// <summary>
    /// Prior to forwarding the request to the selected backend service, the matching
    /// portion of the request&#39;s path is replaced by pathPrefixRewrite. The value must
    /// be between 1 and 1024 characters.
    /// </summary>
    public TerraformValue<string>? PathPrefixRewrite
    {
        get => GetArgument<TerraformValue<string>>("path_prefix_rewrite");
        set => SetArgument("path_prefix_rewrite", value);
    }

}

/// <summary>
/// Block type for weighted_backend_services in GoogleComputeRegionUrlMapPathMatcherBlockPathRuleBlockRouteActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockWeightedBackendServicesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "weighted_backend_services";

    /// <summary>
    /// The default RegionBackendService resource. Before
    /// forwarding the request to backendService, the loadbalancer applies any relevant
    /// headerActions specified as part of this backendServiceWeight.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackendService is required")]
    public required TerraformValue<string> BackendService
    {
        get => GetRequiredArgument<TerraformValue<string>>("backend_service");
        set => SetArgument("backend_service", value);
    }

    /// <summary>
    /// Specifies the fraction of traffic sent to backendService, computed as weight /
    /// (sum of all weightedBackendService weights in routeAction) . The selection of a
    /// backend service is determined only for new traffic. Once a user&#39;s request has
    /// been directed to a backendService, subsequent requests will be sent to the same
    /// backendService as determined by the BackendService&#39;s session affinity policy.
    /// The value must be between 0 and 1000
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Weight is required")]
    public required TerraformValue<double> Weight
    {
        get => GetRequiredArgument<TerraformValue<double>>("weight");
        set => SetArgument("weight", value);
    }

    /// <summary>
    /// HeaderAction block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HeaderAction block(s) allowed")]
    public TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockWeightedBackendServicesBlockHeaderActionBlock>? HeaderAction
    {
        get => GetArgument<TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockWeightedBackendServicesBlockHeaderActionBlock>>("header_action");
        set => SetArgument("header_action", value);
    }

}

/// <summary>
/// Block type for header_action in GoogleComputeRegionUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockWeightedBackendServicesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockWeightedBackendServicesBlockHeaderActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "header_action";

    /// <summary>
    /// A list of header names for headers that need to be removed from the request
    /// prior to forwarding the request to the backendService.
    /// </summary>
    public TerraformList<string>? RequestHeadersToRemove
    {
        get => GetArgument<TerraformList<string>>("request_headers_to_remove");
        set => SetArgument("request_headers_to_remove", value);
    }

    /// <summary>
    /// A list of header names for headers that need to be removed from the response
    /// prior to sending the response back to the client.
    /// </summary>
    public TerraformList<string>? ResponseHeadersToRemove
    {
        get => GetArgument<TerraformList<string>>("response_headers_to_remove");
        set => SetArgument("response_headers_to_remove", value);
    }

    /// <summary>
    /// RequestHeadersToAdd block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockWeightedBackendServicesBlockHeaderActionBlockRequestHeadersToAddBlock>? RequestHeadersToAdd
    {
        get => GetArgument<TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockWeightedBackendServicesBlockHeaderActionBlockRequestHeadersToAddBlock>>("request_headers_to_add");
        set => SetArgument("request_headers_to_add", value);
    }

    /// <summary>
    /// ResponseHeadersToAdd block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockWeightedBackendServicesBlockHeaderActionBlockResponseHeadersToAddBlock>? ResponseHeadersToAdd
    {
        get => GetArgument<TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockWeightedBackendServicesBlockHeaderActionBlockResponseHeadersToAddBlock>>("response_headers_to_add");
        set => SetArgument("response_headers_to_add", value);
    }

}

/// <summary>
/// Block type for request_headers_to_add in GoogleComputeRegionUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockWeightedBackendServicesBlockHeaderActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockWeightedBackendServicesBlockHeaderActionBlockRequestHeadersToAddBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "request_headers_to_add";

    /// <summary>
    /// The name of the header.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HeaderName is required")]
    public required TerraformValue<string> HeaderName
    {
        get => GetRequiredArgument<TerraformValue<string>>("header_name");
        set => SetArgument("header_name", value);
    }

    /// <summary>
    /// The value of the header to add.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HeaderValue is required")]
    public required TerraformValue<string> HeaderValue
    {
        get => GetRequiredArgument<TerraformValue<string>>("header_value");
        set => SetArgument("header_value", value);
    }

    /// <summary>
    /// If false, headerValue is appended to any values that already exist for the
    /// header. If true, headerValue is set for the header, discarding any values that
    /// were set for that header.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Replace is required")]
    public required TerraformValue<bool> Replace
    {
        get => GetRequiredArgument<TerraformValue<bool>>("replace");
        set => SetArgument("replace", value);
    }

}

/// <summary>
/// Block type for response_headers_to_add in GoogleComputeRegionUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockWeightedBackendServicesBlockHeaderActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockWeightedBackendServicesBlockHeaderActionBlockResponseHeadersToAddBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "response_headers_to_add";

    /// <summary>
    /// The name of the header.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HeaderName is required")]
    public required TerraformValue<string> HeaderName
    {
        get => GetRequiredArgument<TerraformValue<string>>("header_name");
        set => SetArgument("header_name", value);
    }

    /// <summary>
    /// The value of the header to add.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HeaderValue is required")]
    public required TerraformValue<string> HeaderValue
    {
        get => GetRequiredArgument<TerraformValue<string>>("header_value");
        set => SetArgument("header_value", value);
    }

    /// <summary>
    /// If false, headerValue is appended to any values that already exist for the
    /// header. If true, headerValue is set for the header, discarding any values that
    /// were set for that header.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Replace is required")]
    public required TerraformValue<bool> Replace
    {
        get => GetRequiredArgument<TerraformValue<bool>>("replace");
        set => SetArgument("replace", value);
    }

}

/// <summary>
/// Block type for url_redirect in GoogleComputeRegionUrlMapPathMatcherBlockPathRuleBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionUrlMapPathMatcherBlockPathRuleBlockUrlRedirectBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "url_redirect";

    /// <summary>
    /// The host that will be used in the redirect response instead of the one
    /// that was supplied in the request. The value must be between 1 and 255
    /// characters.
    /// </summary>
    public TerraformValue<string>? HostRedirect
    {
        get => GetArgument<TerraformValue<string>>("host_redirect");
        set => SetArgument("host_redirect", value);
    }

    /// <summary>
    /// If set to true, the URL scheme in the redirected request is set to https.
    /// If set to false, the URL scheme of the redirected request will remain the
    /// same as that of the request. This must only be set for UrlMaps used in
    /// TargetHttpProxys. Setting this true for TargetHttpsProxy is not
    /// permitted. The default is set to false.
    /// </summary>
    public TerraformValue<bool>? HttpsRedirect
    {
        get => GetArgument<TerraformValue<bool>>("https_redirect");
        set => SetArgument("https_redirect", value);
    }

    /// <summary>
    /// The path that will be used in the redirect response instead of the one
    /// that was supplied in the request. pathRedirect cannot be supplied
    /// together with prefixRedirect. Supply one alone or neither. If neither is
    /// supplied, the path of the original request will be used for the redirect.
    /// The value must be between 1 and 1024 characters.
    /// </summary>
    public TerraformValue<string>? PathRedirect
    {
        get => GetArgument<TerraformValue<string>>("path_redirect");
        set => SetArgument("path_redirect", value);
    }

    /// <summary>
    /// The prefix that replaces the prefixMatch specified in the
    /// HttpRouteRuleMatch, retaining the remaining portion of the URL before
    /// redirecting the request. prefixRedirect cannot be supplied together with
    /// pathRedirect. Supply one alone or neither. If neither is supplied, the
    /// path of the original request will be used for the redirect. The value
    /// must be between 1 and 1024 characters.
    /// </summary>
    public TerraformValue<string>? PrefixRedirect
    {
        get => GetArgument<TerraformValue<string>>("prefix_redirect");
        set => SetArgument("prefix_redirect", value);
    }

    /// <summary>
    /// The HTTP Status code to use for this RedirectAction. Supported values are:
    /// 
    /// * MOVED_PERMANENTLY_DEFAULT, which is the default value and corresponds to 301.
    /// 
    /// * FOUND, which corresponds to 302.
    /// 
    /// * SEE_OTHER which corresponds to 303.
    /// 
    /// * TEMPORARY_REDIRECT, which corresponds to 307. In this case, the request method
    /// will be retained.
    /// 
    /// * PERMANENT_REDIRECT, which corresponds to 308. In this case,
    /// the request method will be retained. Possible values: [&amp;quot;FOUND&amp;quot;, &amp;quot;MOVED_PERMANENTLY_DEFAULT&amp;quot;, &amp;quot;PERMANENT_REDIRECT&amp;quot;, &amp;quot;SEE_OTHER&amp;quot;, &amp;quot;TEMPORARY_REDIRECT&amp;quot;]
    /// </summary>
    public TerraformValue<string>? RedirectResponseCode
    {
        get => GetArgument<TerraformValue<string>>("redirect_response_code");
        set => SetArgument("redirect_response_code", value);
    }

    /// <summary>
    /// If set to true, any accompanying query portion of the original URL is removed
    /// prior to redirecting the request. If set to false, the query portion of the
    /// original URL is retained.
    ///  This field is required to ensure an empty block is not set. The normal default value is false.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StripQuery is required")]
    public required TerraformValue<bool> StripQuery
    {
        get => GetRequiredArgument<TerraformValue<bool>>("strip_query");
        set => SetArgument("strip_query", value);
    }

}

/// <summary>
/// Block type for route_rules in GoogleComputeRegionUrlMapPathMatcherBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "route_rules";

    /// <summary>
    /// For routeRules within a given pathMatcher, priority determines the order
    /// in which load balancer will interpret routeRules. RouteRules are evaluated
    /// in order of priority, from the lowest to highest number. The priority of
    /// a rule decreases as its number increases (1, 2, 3, N+1). The first rule
    /// that matches the request is applied.
    /// 
    /// You cannot configure two or more routeRules with the same priority.
    /// Priority for each rule must be set to a number between 0 and
    /// 2147483647 inclusive.
    /// 
    /// Priority numbers can have gaps, which enable you to add or remove rules
    /// in the future without affecting the rest of the rules. For example,
    /// 1, 2, 3, 4, 5, 9, 12, 16 is a valid series of priority numbers to which
    /// you could add rules numbered from 6 to 8, 10 to 11, and 13 to 15 in the
    /// future without any impact on existing rules.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    public required TerraformValue<double> Priority
    {
        get => GetRequiredArgument<TerraformValue<double>>("priority");
        set => SetArgument("priority", value);
    }

    /// <summary>
    /// The region backend service resource to which traffic is
    /// directed if this rule is matched. If routeAction is additionally specified,
    /// advanced routing actions like URL Rewrites, etc. take effect prior to sending
    /// the request to the backend. However, if service is specified, routeAction cannot
    /// contain any weightedBackendService s. Conversely, if routeAction specifies any
    /// weightedBackendServices, service must not be specified. Only one of urlRedirect,
    /// service or routeAction.weightedBackendService must be set.
    /// </summary>
    public TerraformValue<string>? Service
    {
        get => GetArgument<TerraformValue<string>>("service");
        set => SetArgument("service", value);
    }

    /// <summary>
    /// HeaderAction block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HeaderAction block(s) allowed")]
    public TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockHeaderActionBlock>? HeaderAction
    {
        get => GetArgument<TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockHeaderActionBlock>>("header_action");
        set => SetArgument("header_action", value);
    }

    /// <summary>
    /// MatchRules block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockMatchRulesBlock>? MatchRules
    {
        get => GetArgument<TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockMatchRulesBlock>>("match_rules");
        set => SetArgument("match_rules", value);
    }

    /// <summary>
    /// RouteAction block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RouteAction block(s) allowed")]
    public TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlock>? RouteAction
    {
        get => GetArgument<TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlock>>("route_action");
        set => SetArgument("route_action", value);
    }

    /// <summary>
    /// UrlRedirect block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UrlRedirect block(s) allowed")]
    public TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockUrlRedirectBlock>? UrlRedirect
    {
        get => GetArgument<TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockUrlRedirectBlock>>("url_redirect");
        set => SetArgument("url_redirect", value);
    }

}

/// <summary>
/// Block type for header_action in GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockHeaderActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "header_action";

    /// <summary>
    /// A list of header names for headers that need to be removed from the request
    /// prior to forwarding the request to the backendService.
    /// </summary>
    public TerraformList<string>? RequestHeadersToRemove
    {
        get => GetArgument<TerraformList<string>>("request_headers_to_remove");
        set => SetArgument("request_headers_to_remove", value);
    }

    /// <summary>
    /// A list of header names for headers that need to be removed from the response
    /// prior to sending the response back to the client.
    /// </summary>
    public TerraformList<string>? ResponseHeadersToRemove
    {
        get => GetArgument<TerraformList<string>>("response_headers_to_remove");
        set => SetArgument("response_headers_to_remove", value);
    }

    /// <summary>
    /// RequestHeadersToAdd block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockHeaderActionBlockRequestHeadersToAddBlock>? RequestHeadersToAdd
    {
        get => GetArgument<TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockHeaderActionBlockRequestHeadersToAddBlock>>("request_headers_to_add");
        set => SetArgument("request_headers_to_add", value);
    }

    /// <summary>
    /// ResponseHeadersToAdd block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockHeaderActionBlockResponseHeadersToAddBlock>? ResponseHeadersToAdd
    {
        get => GetArgument<TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockHeaderActionBlockResponseHeadersToAddBlock>>("response_headers_to_add");
        set => SetArgument("response_headers_to_add", value);
    }

}

/// <summary>
/// Block type for request_headers_to_add in GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockHeaderActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockHeaderActionBlockRequestHeadersToAddBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "request_headers_to_add";

    /// <summary>
    /// The name of the header.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HeaderName is required")]
    public required TerraformValue<string> HeaderName
    {
        get => GetRequiredArgument<TerraformValue<string>>("header_name");
        set => SetArgument("header_name", value);
    }

    /// <summary>
    /// The value of the header to add.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HeaderValue is required")]
    public required TerraformValue<string> HeaderValue
    {
        get => GetRequiredArgument<TerraformValue<string>>("header_value");
        set => SetArgument("header_value", value);
    }

    /// <summary>
    /// If false, headerValue is appended to any values that already exist for the
    /// header. If true, headerValue is set for the header, discarding any values that
    /// were set for that header.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Replace is required")]
    public required TerraformValue<bool> Replace
    {
        get => GetRequiredArgument<TerraformValue<bool>>("replace");
        set => SetArgument("replace", value);
    }

}

/// <summary>
/// Block type for response_headers_to_add in GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockHeaderActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockHeaderActionBlockResponseHeadersToAddBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "response_headers_to_add";

    /// <summary>
    /// The name of the header.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HeaderName is required")]
    public required TerraformValue<string> HeaderName
    {
        get => GetRequiredArgument<TerraformValue<string>>("header_name");
        set => SetArgument("header_name", value);
    }

    /// <summary>
    /// The value of the header to add.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HeaderValue is required")]
    public required TerraformValue<string> HeaderValue
    {
        get => GetRequiredArgument<TerraformValue<string>>("header_value");
        set => SetArgument("header_value", value);
    }

    /// <summary>
    /// If false, headerValue is appended to any values that already exist for the
    /// header. If true, headerValue is set for the header, discarding any values that
    /// were set for that header.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Replace is required")]
    public required TerraformValue<bool> Replace
    {
        get => GetRequiredArgument<TerraformValue<bool>>("replace");
        set => SetArgument("replace", value);
    }

}

/// <summary>
/// Block type for match_rules in GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockMatchRulesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "match_rules";

    /// <summary>
    /// For satisfying the matchRule condition, the path of the request must exactly
    /// match the value specified in fullPathMatch after removing any query parameters
    /// and anchor that may be part of the original URL. FullPathMatch must be between 1
    /// and 1024 characters. Only one of prefixMatch, fullPathMatch or regexMatch must
    /// be specified.
    /// </summary>
    public TerraformValue<string>? FullPathMatch
    {
        get => GetArgument<TerraformValue<string>>("full_path_match");
        set => SetArgument("full_path_match", value);
    }

    /// <summary>
    /// Specifies that prefixMatch and fullPathMatch matches are case sensitive.
    /// Defaults to false.
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
    /// For satisfying the matchRule condition, the request&#39;s path must begin with the
    /// specified prefixMatch. prefixMatch must begin with a /. The value must be
    /// between 1 and 1024 characters. Only one of prefixMatch, fullPathMatch or
    /// regexMatch must be specified.
    /// </summary>
    public TerraformValue<string>? PrefixMatch
    {
        get => GetArgument<TerraformValue<string>>("prefix_match");
        set => SetArgument("prefix_match", value);
    }

    /// <summary>
    /// For satisfying the matchRule condition, the path of the request must satisfy the
    /// regular expression specified in regexMatch after removing any query parameters
    /// and anchor supplied with the original URL. For regular expression grammar please
    /// see en.cppreference.com/w/cpp/regex/ecmascript  Only one of prefixMatch,
    /// fullPathMatch or regexMatch must be specified.
    /// </summary>
    public TerraformValue<string>? RegexMatch
    {
        get => GetArgument<TerraformValue<string>>("regex_match");
        set => SetArgument("regex_match", value);
    }

    /// <summary>
    /// HeaderMatches block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockMatchRulesBlockHeaderMatchesBlock>? HeaderMatches
    {
        get => GetArgument<TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockMatchRulesBlockHeaderMatchesBlock>>("header_matches");
        set => SetArgument("header_matches", value);
    }

    /// <summary>
    /// MetadataFilters block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockMatchRulesBlockMetadataFiltersBlock>? MetadataFilters
    {
        get => GetArgument<TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockMatchRulesBlockMetadataFiltersBlock>>("metadata_filters");
        set => SetArgument("metadata_filters", value);
    }

    /// <summary>
    /// QueryParameterMatches block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockMatchRulesBlockQueryParameterMatchesBlock>? QueryParameterMatches
    {
        get => GetArgument<TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockMatchRulesBlockQueryParameterMatchesBlock>>("query_parameter_matches");
        set => SetArgument("query_parameter_matches", value);
    }

}

/// <summary>
/// Block type for header_matches in GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockMatchRulesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockMatchRulesBlockHeaderMatchesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "header_matches";

    /// <summary>
    /// The value should exactly match contents of exactMatch. Only one of exactMatch,
    /// prefixMatch, suffixMatch, regexMatch, presentMatch or rangeMatch must be set.
    /// </summary>
    public TerraformValue<string>? ExactMatch
    {
        get => GetArgument<TerraformValue<string>>("exact_match");
        set => SetArgument("exact_match", value);
    }

    /// <summary>
    /// The name of the HTTP header to match. For matching against the HTTP request&#39;s
    /// authority, use a headerMatch with the header name &amp;quot;:authority&amp;quot;. For matching a
    /// request&#39;s method, use the headerName &amp;quot;:method&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HeaderName is required")]
    public required TerraformValue<string> HeaderName
    {
        get => GetRequiredArgument<TerraformValue<string>>("header_name");
        set => SetArgument("header_name", value);
    }

    /// <summary>
    /// If set to false, the headerMatch is considered a match if the match criteria
    /// above are met. If set to true, the headerMatch is considered a match if the
    /// match criteria above are NOT met. Defaults to false.
    /// </summary>
    public TerraformValue<bool>? InvertMatch
    {
        get => GetArgument<TerraformValue<bool>>("invert_match");
        set => SetArgument("invert_match", value);
    }

    /// <summary>
    /// The value of the header must start with the contents of prefixMatch. Only one of
    /// exactMatch, prefixMatch, suffixMatch, regexMatch, presentMatch or rangeMatch
    /// must be set.
    /// </summary>
    public TerraformValue<string>? PrefixMatch
    {
        get => GetArgument<TerraformValue<string>>("prefix_match");
        set => SetArgument("prefix_match", value);
    }

    /// <summary>
    /// A header with the contents of headerName must exist. The match takes place
    /// whether or not the request&#39;s header has a value or not. Only one of exactMatch,
    /// prefixMatch, suffixMatch, regexMatch, presentMatch or rangeMatch must be set.
    /// </summary>
    public TerraformValue<bool>? PresentMatch
    {
        get => GetArgument<TerraformValue<bool>>("present_match");
        set => SetArgument("present_match", value);
    }

    /// <summary>
    /// The value of the header must match the regular expression specified in
    /// regexMatch. For regular expression grammar, please see:
    /// en.cppreference.com/w/cpp/regex/ecmascript  For matching against a port
    /// specified in the HTTP request, use a headerMatch with headerName set to PORT and
    /// a regular expression that satisfies the RFC2616 Host header&#39;s port specifier.
    /// Only one of exactMatch, prefixMatch, suffixMatch, regexMatch, presentMatch or
    /// rangeMatch must be set.
    /// </summary>
    public TerraformValue<string>? RegexMatch
    {
        get => GetArgument<TerraformValue<string>>("regex_match");
        set => SetArgument("regex_match", value);
    }

    /// <summary>
    /// The value of the header must end with the contents of suffixMatch. Only one of
    /// exactMatch, prefixMatch, suffixMatch, regexMatch, presentMatch or rangeMatch
    /// must be set.
    /// </summary>
    public TerraformValue<string>? SuffixMatch
    {
        get => GetArgument<TerraformValue<string>>("suffix_match");
        set => SetArgument("suffix_match", value);
    }

    /// <summary>
    /// RangeMatch block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RangeMatch block(s) allowed")]
    public TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockMatchRulesBlockHeaderMatchesBlockRangeMatchBlock>? RangeMatch
    {
        get => GetArgument<TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockMatchRulesBlockHeaderMatchesBlockRangeMatchBlock>>("range_match");
        set => SetArgument("range_match", value);
    }

}

/// <summary>
/// Block type for range_match in GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockMatchRulesBlockHeaderMatchesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockMatchRulesBlockHeaderMatchesBlockRangeMatchBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "range_match";

    /// <summary>
    /// The end of the range (exclusive).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RangeEnd is required")]
    public required TerraformValue<double> RangeEnd
    {
        get => GetRequiredArgument<TerraformValue<double>>("range_end");
        set => SetArgument("range_end", value);
    }

    /// <summary>
    /// The start of the range (inclusive).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RangeStart is required")]
    public required TerraformValue<double> RangeStart
    {
        get => GetRequiredArgument<TerraformValue<double>>("range_start");
        set => SetArgument("range_start", value);
    }

}

/// <summary>
/// Block type for metadata_filters in GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockMatchRulesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockMatchRulesBlockMetadataFiltersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "metadata_filters";

    /// <summary>
    /// Specifies how individual filterLabel matches within the list of filterLabels
    /// contribute towards the overall metadataFilter match. Supported values are:
    /// 
    /// * MATCH_ANY: At least one of the filterLabels must have a matching label in the
    /// provided metadata.
    /// * MATCH_ALL: All filterLabels must have matching labels in
    /// the provided metadata. Possible values: [&amp;quot;MATCH_ALL&amp;quot;, &amp;quot;MATCH_ANY&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FilterMatchCriteria is required")]
    public required TerraformValue<string> FilterMatchCriteria
    {
        get => GetRequiredArgument<TerraformValue<string>>("filter_match_criteria");
        set => SetArgument("filter_match_criteria", value);
    }

    /// <summary>
    /// FilterLabels block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FilterLabels is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 FilterLabels block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(64, ErrorMessage = "Maximum 64 FilterLabels block(s) allowed")]
    public required TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockMatchRulesBlockMetadataFiltersBlockFilterLabelsBlock> FilterLabels
    {
        get => GetRequiredArgument<TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockMatchRulesBlockMetadataFiltersBlockFilterLabelsBlock>>("filter_labels");
        set => SetArgument("filter_labels", value);
    }

}

/// <summary>
/// Block type for filter_labels in GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockMatchRulesBlockMetadataFiltersBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockMatchRulesBlockMetadataFiltersBlockFilterLabelsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filter_labels";

    /// <summary>
    /// Name of metadata label. The name can have a maximum length of 1024 characters
    /// and must be at least 1 character long.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The value of the label must match the specified value. value can have a maximum
    /// length of 1024 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for query_parameter_matches in GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockMatchRulesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockMatchRulesBlockQueryParameterMatchesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "query_parameter_matches";

    /// <summary>
    /// The queryParameterMatch matches if the value of the parameter exactly matches
    /// the contents of exactMatch. Only one of presentMatch, exactMatch and regexMatch
    /// must be set.
    /// </summary>
    public TerraformValue<string>? ExactMatch
    {
        get => GetArgument<TerraformValue<string>>("exact_match");
        set => SetArgument("exact_match", value);
    }

    /// <summary>
    /// The name of the query parameter to match. The query parameter must exist in the
    /// request, in the absence of which the request match fails.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Specifies that the queryParameterMatch matches if the request contains the query
    /// parameter, irrespective of whether the parameter has a value or not. Only one of
    /// presentMatch, exactMatch and regexMatch must be set.
    /// </summary>
    public TerraformValue<bool>? PresentMatch
    {
        get => GetArgument<TerraformValue<bool>>("present_match");
        set => SetArgument("present_match", value);
    }

    /// <summary>
    /// The queryParameterMatch matches if the value of the parameter matches the
    /// regular expression specified by regexMatch. For the regular expression grammar,
    /// please see en.cppreference.com/w/cpp/regex/ecmascript  Only one of presentMatch,
    /// exactMatch and regexMatch must be set.
    /// </summary>
    public TerraformValue<string>? RegexMatch
    {
        get => GetArgument<TerraformValue<string>>("regex_match");
        set => SetArgument("regex_match", value);
    }

}

/// <summary>
/// Block type for route_action in GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "route_action";

    /// <summary>
    /// CorsPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CorsPolicy block(s) allowed")]
    public TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockCorsPolicyBlock>? CorsPolicy
    {
        get => GetArgument<TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockCorsPolicyBlock>>("cors_policy");
        set => SetArgument("cors_policy", value);
    }

    /// <summary>
    /// FaultInjectionPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FaultInjectionPolicy block(s) allowed")]
    public TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockFaultInjectionPolicyBlock>? FaultInjectionPolicy
    {
        get => GetArgument<TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockFaultInjectionPolicyBlock>>("fault_injection_policy");
        set => SetArgument("fault_injection_policy", value);
    }

    /// <summary>
    /// RequestMirrorPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RequestMirrorPolicy block(s) allowed")]
    public TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockRequestMirrorPolicyBlock>? RequestMirrorPolicy
    {
        get => GetArgument<TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockRequestMirrorPolicyBlock>>("request_mirror_policy");
        set => SetArgument("request_mirror_policy", value);
    }

    /// <summary>
    /// RetryPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetryPolicy block(s) allowed")]
    public TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockRetryPolicyBlock>? RetryPolicy
    {
        get => GetArgument<TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockRetryPolicyBlock>>("retry_policy");
        set => SetArgument("retry_policy", value);
    }

    /// <summary>
    /// Timeout block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Timeout block(s) allowed")]
    public TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockTimeoutBlock>? Timeout
    {
        get => GetArgument<TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockTimeoutBlock>>("timeout");
        set => SetArgument("timeout", value);
    }

    /// <summary>
    /// UrlRewrite block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UrlRewrite block(s) allowed")]
    public TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockUrlRewriteBlock>? UrlRewrite
    {
        get => GetArgument<TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockUrlRewriteBlock>>("url_rewrite");
        set => SetArgument("url_rewrite", value);
    }

    /// <summary>
    /// WeightedBackendServices block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockWeightedBackendServicesBlock>? WeightedBackendServices
    {
        get => GetArgument<TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockWeightedBackendServicesBlock>>("weighted_backend_services");
        set => SetArgument("weighted_backend_services", value);
    }

}

/// <summary>
/// Block type for cors_policy in GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockCorsPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cors_policy";

    /// <summary>
    /// In response to a preflight request, setting this to true indicates that the
    /// actual request can include user credentials. This translates to the Access-
    /// Control-Allow-Credentials header. Defaults to false.
    /// </summary>
    public TerraformValue<bool>? AllowCredentials
    {
        get => GetArgument<TerraformValue<bool>>("allow_credentials");
        set => SetArgument("allow_credentials", value);
    }

    /// <summary>
    /// Specifies the content for the Access-Control-Allow-Headers header.
    /// </summary>
    public TerraformList<string>? AllowHeaders
    {
        get => GetArgument<TerraformList<string>>("allow_headers");
        set => SetArgument("allow_headers", value);
    }

    /// <summary>
    /// Specifies the content for the Access-Control-Allow-Methods header.
    /// </summary>
    public TerraformList<string>? AllowMethods
    {
        get => GetArgument<TerraformList<string>>("allow_methods");
        set => SetArgument("allow_methods", value);
    }

    /// <summary>
    /// Specifies the regular expression patterns that match allowed origins. For
    /// regular expression grammar please see en.cppreference.com/w/cpp/regex/ecmascript
    /// An origin is allowed if it matches either allow_origins or allow_origin_regex.
    /// </summary>
    public TerraformList<string>? AllowOriginRegexes
    {
        get => GetArgument<TerraformList<string>>("allow_origin_regexes");
        set => SetArgument("allow_origin_regexes", value);
    }

    /// <summary>
    /// Specifies the list of origins that will be allowed to do CORS requests. An
    /// origin is allowed if it matches either allow_origins or allow_origin_regex.
    /// </summary>
    public TerraformList<string>? AllowOrigins
    {
        get => GetArgument<TerraformList<string>>("allow_origins");
        set => SetArgument("allow_origins", value);
    }

    /// <summary>
    /// If true, specifies the CORS policy is disabled.
    /// which indicates that the CORS policy is in effect. Defaults to false.
    /// </summary>
    public TerraformValue<bool>? Disabled
    {
        get => GetArgument<TerraformValue<bool>>("disabled");
        set => SetArgument("disabled", value);
    }

    /// <summary>
    /// Specifies the content for the Access-Control-Expose-Headers header.
    /// </summary>
    public TerraformList<string>? ExposeHeaders
    {
        get => GetArgument<TerraformList<string>>("expose_headers");
        set => SetArgument("expose_headers", value);
    }

    /// <summary>
    /// Specifies how long the results of a preflight request can be cached. This
    /// translates to the content for the Access-Control-Max-Age header.
    /// </summary>
    public TerraformValue<double>? MaxAge
    {
        get => GetArgument<TerraformValue<double>>("max_age");
        set => SetArgument("max_age", value);
    }

}

/// <summary>
/// Block type for fault_injection_policy in GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockFaultInjectionPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "fault_injection_policy";

    /// <summary>
    /// Abort block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Abort block(s) allowed")]
    public TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockFaultInjectionPolicyBlockAbortBlock>? Abort
    {
        get => GetArgument<TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockFaultInjectionPolicyBlockAbortBlock>>("abort");
        set => SetArgument("abort", value);
    }

    /// <summary>
    /// Delay block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Delay block(s) allowed")]
    public TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockFaultInjectionPolicyBlockDelayBlock>? Delay
    {
        get => GetArgument<TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockFaultInjectionPolicyBlockDelayBlock>>("delay");
        set => SetArgument("delay", value);
    }

}

/// <summary>
/// Block type for abort in GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockFaultInjectionPolicyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockFaultInjectionPolicyBlockAbortBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "abort";

    /// <summary>
    /// The HTTP status code used to abort the request. The value must be between 200
    /// and 599 inclusive.
    /// </summary>
    public TerraformValue<double>? HttpStatus
    {
        get => GetArgument<TerraformValue<double>>("http_status");
        set => SetArgument("http_status", value);
    }

    /// <summary>
    /// The percentage of traffic (connections/operations/requests) which will be
    /// aborted as part of fault injection. The value must be between 0.0 and 100.0
    /// inclusive.
    /// </summary>
    public TerraformValue<double>? Percentage
    {
        get => GetArgument<TerraformValue<double>>("percentage");
        set => SetArgument("percentage", value);
    }

}

/// <summary>
/// Block type for delay in GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockFaultInjectionPolicyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockFaultInjectionPolicyBlockDelayBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "delay";

    /// <summary>
    /// The percentage of traffic (connections/operations/requests) on which delay will
    /// be introduced as part of fault injection. The value must be between 0.0 and
    /// 100.0 inclusive.
    /// </summary>
    public TerraformValue<double>? Percentage
    {
        get => GetArgument<TerraformValue<double>>("percentage");
        set => SetArgument("percentage", value);
    }

    /// <summary>
    /// FixedDelay block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FixedDelay block(s) allowed")]
    public TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockFaultInjectionPolicyBlockDelayBlockFixedDelayBlock>? FixedDelay
    {
        get => GetArgument<TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockFaultInjectionPolicyBlockDelayBlockFixedDelayBlock>>("fixed_delay");
        set => SetArgument("fixed_delay", value);
    }

}

/// <summary>
/// Block type for fixed_delay in GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockFaultInjectionPolicyBlockDelayBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockFaultInjectionPolicyBlockDelayBlockFixedDelayBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "fixed_delay";

    /// <summary>
    /// Span of time that&#39;s a fraction of a second at nanosecond resolution. Durations
    /// less than one second are represented with a 0 &#39;seconds&#39; field and a positive
    /// &#39;nanos&#39; field. Must be from 0 to 999,999,999 inclusive.
    /// </summary>
    public TerraformValue<double>? Nanos
    {
        get => GetArgument<TerraformValue<double>>("nanos");
        set => SetArgument("nanos", value);
    }

    /// <summary>
    /// Span of time at a resolution of a second. Must be from 0 to 315,576,000,000
    /// inclusive.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Seconds is required")]
    public required TerraformValue<string> Seconds
    {
        get => GetRequiredArgument<TerraformValue<string>>("seconds");
        set => SetArgument("seconds", value);
    }

}

/// <summary>
/// Block type for request_mirror_policy in GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockRequestMirrorPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "request_mirror_policy";

    /// <summary>
    /// The RegionBackendService resource being mirrored to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackendService is required")]
    public required TerraformValue<string> BackendService
    {
        get => GetRequiredArgument<TerraformValue<string>>("backend_service");
        set => SetArgument("backend_service", value);
    }

}

/// <summary>
/// Block type for retry_policy in GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockRetryPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "retry_policy";

    /// <summary>
    /// Specifies the allowed number retries. This number must be &amp;gt; 0.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NumRetries is required")]
    public required TerraformValue<double> NumRetries
    {
        get => GetRequiredArgument<TerraformValue<double>>("num_retries");
        set => SetArgument("num_retries", value);
    }

    /// <summary>
    /// Specifies one or more conditions when this retry rule applies. Valid values are:
    /// 
    /// * 5xx: Loadbalancer will attempt a retry if the backend service responds with
    ///   any 5xx response code, or if the backend service does not respond at all,
    ///   for example: disconnects, reset, read timeout, connection failure, and refused
    ///   streams.
    /// * gateway-error: Similar to 5xx, but only applies to response codes
    ///   502, 503 or 504.
    /// * connect-failure: Loadbalancer will retry on failures
    ///   connecting to backend services, for example due to connection timeouts.
    /// * retriable-4xx: Loadbalancer will retry for retriable 4xx response codes.
    ///   Currently the only retriable error supported is 409.
    /// * refused-stream: Loadbalancer will retry if the backend service resets the stream with a
    ///   REFUSED_STREAM error code. This reset type indicates that it is safe to retry.
    /// * cancelled: Loadbalancer will retry if the gRPC status code in the response
    ///   header is set to cancelled
    /// * deadline-exceeded: Loadbalancer will retry if the
    ///   gRPC status code in the response header is set to deadline-exceeded
    /// * resource-exhausted: Loadbalancer will retry if the gRPC status code in the response
    ///   header is set to resource-exhausted
    /// * unavailable: Loadbalancer will retry if the gRPC status code in
    ///   the response header is set to unavailable
    /// </summary>
    public TerraformList<string>? RetryConditions
    {
        get => GetArgument<TerraformList<string>>("retry_conditions");
        set => SetArgument("retry_conditions", value);
    }

    /// <summary>
    /// PerTryTimeout block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PerTryTimeout block(s) allowed")]
    public TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockRetryPolicyBlockPerTryTimeoutBlock>? PerTryTimeout
    {
        get => GetArgument<TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockRetryPolicyBlockPerTryTimeoutBlock>>("per_try_timeout");
        set => SetArgument("per_try_timeout", value);
    }

}

/// <summary>
/// Block type for per_try_timeout in GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockRetryPolicyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockRetryPolicyBlockPerTryTimeoutBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "per_try_timeout";

    /// <summary>
    /// Span of time that&#39;s a fraction of a second at nanosecond resolution. Durations
    /// less than one second are represented with a 0 &#39;seconds&#39; field and a positive
    /// &#39;nanos&#39; field. Must be from 0 to 999,999,999 inclusive.
    /// </summary>
    public TerraformValue<double>? Nanos
    {
        get => GetArgument<TerraformValue<double>>("nanos");
        set => SetArgument("nanos", value);
    }

    /// <summary>
    /// Span of time at a resolution of a second. Must be from 0 to 315,576,000,000
    /// inclusive.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Seconds is required")]
    public required TerraformValue<string> Seconds
    {
        get => GetRequiredArgument<TerraformValue<string>>("seconds");
        set => SetArgument("seconds", value);
    }

}

/// <summary>
/// Block type for timeout in GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockTimeoutBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeout";

    /// <summary>
    /// Span of time that&#39;s a fraction of a second at nanosecond resolution. Durations
    /// less than one second are represented with a 0 &#39;seconds&#39; field and a positive
    /// &#39;nanos&#39; field. Must be from 0 to 999,999,999 inclusive.
    /// </summary>
    public TerraformValue<double>? Nanos
    {
        get => GetArgument<TerraformValue<double>>("nanos");
        set => SetArgument("nanos", value);
    }

    /// <summary>
    /// Span of time at a resolution of a second. Must be from 0 to 315,576,000,000
    /// inclusive.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Seconds is required")]
    public required TerraformValue<string> Seconds
    {
        get => GetRequiredArgument<TerraformValue<string>>("seconds");
        set => SetArgument("seconds", value);
    }

}

/// <summary>
/// Block type for url_rewrite in GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockUrlRewriteBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "url_rewrite";

    /// <summary>
    /// Prior to forwarding the request to the selected service, the request&#39;s host
    /// header is replaced with contents of hostRewrite. The value must be between 1 and
    /// 255 characters.
    /// </summary>
    public TerraformValue<string>? HostRewrite
    {
        get => GetArgument<TerraformValue<string>>("host_rewrite");
        set => SetArgument("host_rewrite", value);
    }

    /// <summary>
    /// Prior to forwarding the request to the selected backend service, the matching
    /// portion of the request&#39;s path is replaced by pathPrefixRewrite. The value must
    /// be between 1 and 1024 characters.
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
/// Block type for weighted_backend_services in GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockWeightedBackendServicesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "weighted_backend_services";

    /// <summary>
    /// The default RegionBackendService resource. Before
    /// forwarding the request to backendService, the loadbalancer applies any relevant
    /// headerActions specified as part of this backendServiceWeight.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackendService is required")]
    public required TerraformValue<string> BackendService
    {
        get => GetRequiredArgument<TerraformValue<string>>("backend_service");
        set => SetArgument("backend_service", value);
    }

    /// <summary>
    /// Specifies the fraction of traffic sent to backendService, computed as weight /
    /// (sum of all weightedBackendService weights in routeAction) . The selection of a
    /// backend service is determined only for new traffic. Once a user&#39;s request has
    /// been directed to a backendService, subsequent requests will be sent to the same
    /// backendService as determined by the BackendService&#39;s session affinity policy.
    /// The value must be between 0 and 1000
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Weight is required")]
    public required TerraformValue<double> Weight
    {
        get => GetRequiredArgument<TerraformValue<double>>("weight");
        set => SetArgument("weight", value);
    }

    /// <summary>
    /// HeaderAction block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HeaderAction block(s) allowed")]
    public TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockWeightedBackendServicesBlockHeaderActionBlock>? HeaderAction
    {
        get => GetArgument<TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockWeightedBackendServicesBlockHeaderActionBlock>>("header_action");
        set => SetArgument("header_action", value);
    }

}

/// <summary>
/// Block type for header_action in GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockWeightedBackendServicesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockWeightedBackendServicesBlockHeaderActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "header_action";

    /// <summary>
    /// A list of header names for headers that need to be removed from the request
    /// prior to forwarding the request to the backendService.
    /// </summary>
    public TerraformList<string>? RequestHeadersToRemove
    {
        get => GetArgument<TerraformList<string>>("request_headers_to_remove");
        set => SetArgument("request_headers_to_remove", value);
    }

    /// <summary>
    /// A list of header names for headers that need to be removed from the response
    /// prior to sending the response back to the client.
    /// </summary>
    public TerraformList<string>? ResponseHeadersToRemove
    {
        get => GetArgument<TerraformList<string>>("response_headers_to_remove");
        set => SetArgument("response_headers_to_remove", value);
    }

    /// <summary>
    /// RequestHeadersToAdd block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockWeightedBackendServicesBlockHeaderActionBlockRequestHeadersToAddBlock>? RequestHeadersToAdd
    {
        get => GetArgument<TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockWeightedBackendServicesBlockHeaderActionBlockRequestHeadersToAddBlock>>("request_headers_to_add");
        set => SetArgument("request_headers_to_add", value);
    }

    /// <summary>
    /// ResponseHeadersToAdd block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockWeightedBackendServicesBlockHeaderActionBlockResponseHeadersToAddBlock>? ResponseHeadersToAdd
    {
        get => GetArgument<TerraformList<GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockWeightedBackendServicesBlockHeaderActionBlockResponseHeadersToAddBlock>>("response_headers_to_add");
        set => SetArgument("response_headers_to_add", value);
    }

}

/// <summary>
/// Block type for request_headers_to_add in GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockWeightedBackendServicesBlockHeaderActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockWeightedBackendServicesBlockHeaderActionBlockRequestHeadersToAddBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "request_headers_to_add";

    /// <summary>
    /// The name of the header.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HeaderName is required")]
    public required TerraformValue<string> HeaderName
    {
        get => GetRequiredArgument<TerraformValue<string>>("header_name");
        set => SetArgument("header_name", value);
    }

    /// <summary>
    /// The value of the header to add.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HeaderValue is required")]
    public required TerraformValue<string> HeaderValue
    {
        get => GetRequiredArgument<TerraformValue<string>>("header_value");
        set => SetArgument("header_value", value);
    }

    /// <summary>
    /// If false, headerValue is appended to any values that already exist for the
    /// header. If true, headerValue is set for the header, discarding any values that
    /// were set for that header.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Replace is required")]
    public required TerraformValue<bool> Replace
    {
        get => GetRequiredArgument<TerraformValue<bool>>("replace");
        set => SetArgument("replace", value);
    }

}

/// <summary>
/// Block type for response_headers_to_add in GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockWeightedBackendServicesBlockHeaderActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockWeightedBackendServicesBlockHeaderActionBlockResponseHeadersToAddBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "response_headers_to_add";

    /// <summary>
    /// The name of the header.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HeaderName is required")]
    public required TerraformValue<string> HeaderName
    {
        get => GetRequiredArgument<TerraformValue<string>>("header_name");
        set => SetArgument("header_name", value);
    }

    /// <summary>
    /// The value of the header to add.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HeaderValue is required")]
    public required TerraformValue<string> HeaderValue
    {
        get => GetRequiredArgument<TerraformValue<string>>("header_value");
        set => SetArgument("header_value", value);
    }

    /// <summary>
    /// If false, headerValue is appended to any values that already exist for the
    /// header. If true, headerValue is set for the header, discarding any values that
    /// were set for that header.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Replace is required")]
    public required TerraformValue<bool> Replace
    {
        get => GetRequiredArgument<TerraformValue<bool>>("replace");
        set => SetArgument("replace", value);
    }

}

/// <summary>
/// Block type for url_redirect in GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionUrlMapPathMatcherBlockRouteRulesBlockUrlRedirectBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "url_redirect";

    /// <summary>
    /// The host that will be used in the redirect response instead of the one
    /// that was supplied in the request. The value must be between 1 and 255
    /// characters.
    /// </summary>
    public TerraformValue<string>? HostRedirect
    {
        get => GetArgument<TerraformValue<string>>("host_redirect");
        set => SetArgument("host_redirect", value);
    }

    /// <summary>
    /// If set to true, the URL scheme in the redirected request is set to https.
    /// If set to false, the URL scheme of the redirected request will remain the
    /// same as that of the request. This must only be set for UrlMaps used in
    /// TargetHttpProxys. Setting this true for TargetHttpsProxy is not
    /// permitted. The default is set to false.
    /// </summary>
    public TerraformValue<bool>? HttpsRedirect
    {
        get => GetArgument<TerraformValue<bool>>("https_redirect");
        set => SetArgument("https_redirect", value);
    }

    /// <summary>
    /// The path that will be used in the redirect response instead of the one
    /// that was supplied in the request. pathRedirect cannot be supplied
    /// together with prefixRedirect. Supply one alone or neither. If neither is
    /// supplied, the path of the original request will be used for the redirect.
    /// The value must be between 1 and 1024 characters.
    /// </summary>
    public TerraformValue<string>? PathRedirect
    {
        get => GetArgument<TerraformValue<string>>("path_redirect");
        set => SetArgument("path_redirect", value);
    }

    /// <summary>
    /// The prefix that replaces the prefixMatch specified in the
    /// HttpRouteRuleMatch, retaining the remaining portion of the URL before
    /// redirecting the request. prefixRedirect cannot be supplied together with
    /// pathRedirect. Supply one alone or neither. If neither is supplied, the
    /// path of the original request will be used for the redirect. The value
    /// must be between 1 and 1024 characters.
    /// </summary>
    public TerraformValue<string>? PrefixRedirect
    {
        get => GetArgument<TerraformValue<string>>("prefix_redirect");
        set => SetArgument("prefix_redirect", value);
    }

    /// <summary>
    /// The HTTP Status code to use for this RedirectAction. Supported values are:
    /// 
    /// * MOVED_PERMANENTLY_DEFAULT, which is the default value and corresponds to 301.
    /// 
    /// * FOUND, which corresponds to 302.
    /// 
    /// * SEE_OTHER which corresponds to 303.
    /// 
    /// * TEMPORARY_REDIRECT, which corresponds to 307. In this case, the request method
    /// will be retained.
    /// 
    /// * PERMANENT_REDIRECT, which corresponds to 308. In this case,
    /// the request method will be retained. Possible values: [&amp;quot;FOUND&amp;quot;, &amp;quot;MOVED_PERMANENTLY_DEFAULT&amp;quot;, &amp;quot;PERMANENT_REDIRECT&amp;quot;, &amp;quot;SEE_OTHER&amp;quot;, &amp;quot;TEMPORARY_REDIRECT&amp;quot;]
    /// </summary>
    public TerraformValue<string>? RedirectResponseCode
    {
        get => GetArgument<TerraformValue<string>>("redirect_response_code");
        set => SetArgument("redirect_response_code", value);
    }

    /// <summary>
    /// If set to true, any accompanying query portion of the original URL is
    /// removed prior to redirecting the request. If set to false, the query
    /// portion of the original URL is retained. The default value is false.
    /// </summary>
    public TerraformValue<bool>? StripQuery
    {
        get => GetArgument<TerraformValue<bool>>("strip_query");
        set => SetArgument("strip_query", value);
    }

}


/// <summary>
/// Block type for test in GoogleComputeRegionUrlMap.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionUrlMapTestBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "test";

    /// <summary>
    /// Description of this test case.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Host portion of the URL.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Host is required")]
    public required TerraformValue<string> Host
    {
        get => GetRequiredArgument<TerraformValue<string>>("host");
        set => SetArgument("host", value);
    }

    /// <summary>
    /// Path portion of the URL.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    public required TerraformValue<string> Path
    {
        get => GetRequiredArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// A reference to expected RegionBackendService resource the given URL should be mapped to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    public required TerraformValue<string> Service
    {
        get => GetRequiredArgument<TerraformValue<string>>("service");
        set => SetArgument("service", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleComputeRegionUrlMap.
/// Nesting mode: single
/// </summary>
public class GoogleComputeRegionUrlMapTimeoutsBlock : TerraformBlock
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
/// Represents a google_compute_region_url_map Terraform resource.
/// Manages a google_compute_region_url_map resource.
/// </summary>
public partial class GoogleComputeRegionUrlMap(string name) : TerraformResource("google_compute_region_url_map", name)
{
    /// <summary>
    /// The full or partial URL of the defaultService resource to which traffic is directed if
    /// none of the hostRules match. If defaultRouteAction is additionally specified, advanced
    /// routing actions like URL Rewrites, etc. take effect prior to sending the request to the
    /// backend. However, if defaultService is specified, defaultRouteAction cannot contain any
    /// weightedBackendServices. Conversely, if routeAction specifies any
    /// weightedBackendServices, service must not be specified.  Only one of defaultService,
    /// defaultUrlRedirect or defaultRouteAction.weightedBackendService must be set.
    /// </summary>
    public TerraformValue<string>? DefaultService
    {
        get => GetArgument<TerraformValue<string>>("default_service");
        set => SetArgument("default_service", value);
    }

    /// <summary>
    /// An optional description of this resource. Provide this property when
    /// you create the resource.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Name of the resource. Provided by the client when the resource is
    /// created. The name must be 1-63 characters long, and comply with
    /// RFC1035. Specifically, the name must be 1-63 characters long and match
    /// the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39; which means the
    /// first character must be a lowercase letter, and all following
    /// characters must be a dash, lowercase letter, or digit, except the last
    /// character, which cannot be a dash.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? AsReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The Region in which the url map should reside.
    /// If it is not provided, the provider region is used.
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformValue<string> CreationTimestamp
        => AsReference("creation_timestamp");

    /// <summary>
    /// Fingerprint of this resource. This field is used internally during
    /// updates of this resource.
    /// </summary>
    public TerraformValue<string> Fingerprint
        => AsReference("fingerprint");

    /// <summary>
    /// The unique identifier for the resource.
    /// </summary>
    public TerraformValue<double> MapId
        => AsReference("map_id");

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformValue<string> SelfLink
        => AsReference("self_link");

    /// <summary>
    /// DefaultRouteAction block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultRouteAction block(s) allowed")]
    public TerraformList<GoogleComputeRegionUrlMapDefaultRouteActionBlock>? DefaultRouteAction
    {
        get => GetArgument<TerraformList<GoogleComputeRegionUrlMapDefaultRouteActionBlock>>("default_route_action");
        set => SetArgument("default_route_action", value);
    }

    /// <summary>
    /// DefaultUrlRedirect block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultUrlRedirect block(s) allowed")]
    public TerraformList<GoogleComputeRegionUrlMapDefaultUrlRedirectBlock>? DefaultUrlRedirect
    {
        get => GetArgument<TerraformList<GoogleComputeRegionUrlMapDefaultUrlRedirectBlock>>("default_url_redirect");
        set => SetArgument("default_url_redirect", value);
    }

    /// <summary>
    /// HeaderAction block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HeaderAction block(s) allowed")]
    public TerraformList<GoogleComputeRegionUrlMapHeaderActionBlock>? HeaderAction
    {
        get => GetArgument<TerraformList<GoogleComputeRegionUrlMapHeaderActionBlock>>("header_action");
        set => SetArgument("header_action", value);
    }

    /// <summary>
    /// HostRule block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleComputeRegionUrlMapHostRuleBlock>? HostRule
    {
        get => GetArgument<TerraformSet<GoogleComputeRegionUrlMapHostRuleBlock>>("host_rule");
        set => SetArgument("host_rule", value);
    }

    /// <summary>
    /// PathMatcher block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeRegionUrlMapPathMatcherBlock>? PathMatcher
    {
        get => GetArgument<TerraformList<GoogleComputeRegionUrlMapPathMatcherBlock>>("path_matcher");
        set => SetArgument("path_matcher", value);
    }

    /// <summary>
    /// Test block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeRegionUrlMapTestBlock>? Test
    {
        get => GetArgument<TerraformList<GoogleComputeRegionUrlMapTestBlock>>("test");
        set => SetArgument("test", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleComputeRegionUrlMapTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleComputeRegionUrlMapTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
