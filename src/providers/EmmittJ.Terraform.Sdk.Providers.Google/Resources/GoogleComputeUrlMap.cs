using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for default_custom_error_response_policy in GoogleComputeUrlMap.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapDefaultCustomErrorResponsePolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "default_custom_error_response_policy";

    /// <summary>
    /// The full or partial URL to the BackendBucket resource that contains the custom error content. Examples are:
    /// 
    /// https://www.googleapis.com/compute/v1/projects/project/global/backendBuckets/myBackendBucket
    /// compute/v1/projects/project/global/backendBuckets/myBackendBucket
    /// global/backendBuckets/myBackendBucket
    /// 
    /// If errorService is not specified at lower levels like pathMatcher, pathRule and routeRule, an errorService specified at a higher level in the UrlMap will be used. If UrlMap.defaultCustomErrorResponsePolicy contains one or more errorResponseRules[], it must specify errorService.
    /// If load balancer cannot reach the backendBucket, a simple Not Found Error will be returned, with the original response code (or overrideResponseCode if configured).
    /// </summary>
    public TerraformValue<string>? ErrorService
    {
        get => GetArgument<TerraformValue<string>>("error_service");
        set => SetArgument("error_service", value);
    }

    /// <summary>
    /// ErrorResponseRule block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeUrlMapDefaultCustomErrorResponsePolicyBlockErrorResponseRuleBlock>? ErrorResponseRule
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapDefaultCustomErrorResponsePolicyBlockErrorResponseRuleBlock>>("error_response_rule");
        set => SetArgument("error_response_rule", value);
    }

}

/// <summary>
/// Block type for error_response_rule in GoogleComputeUrlMapDefaultCustomErrorResponsePolicyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapDefaultCustomErrorResponsePolicyBlockErrorResponseRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "error_response_rule";

    /// <summary>
    /// Valid values include:
    /// - A number between 400 and 599: For example 401 or 503, in which case the load balancer applies the policy if the error code exactly matches this value.
    /// - 5xx: Load Balancer will apply the policy if the backend service responds with any response code in the range of 500 to 599.
    /// - 4xx: Load Balancer will apply the policy if the backend service responds with any response code in the range of 400 to 499.
    /// Values must be unique within matchResponseCodes and across all errorResponseRules of CustomErrorResponsePolicy.
    /// </summary>
    public TerraformList<string>? MatchResponseCodes
    {
        get => GetArgument<TerraformList<string>>("match_response_codes");
        set => SetArgument("match_response_codes", value);
    }

    /// <summary>
    /// The HTTP status code returned with the response containing the custom error content.
    /// If overrideResponseCode is not supplied, the same response code returned by the original backend bucket or backend service is returned to the client.
    /// </summary>
    public TerraformValue<double>? OverrideResponseCode
    {
        get => GetArgument<TerraformValue<double>>("override_response_code");
        set => SetArgument("override_response_code", value);
    }

    /// <summary>
    /// The full path to a file within backendBucket. For example: /errors/defaultError.html
    /// path must start with a leading slash. path cannot have trailing slashes.
    /// If the file is not available in backendBucket or the load balancer cannot reach the BackendBucket, a simple Not Found Error is returned to the client.
    /// The value must be from 1 to 1024 characters.
    /// </summary>
    public TerraformValue<string>? Path
    {
        get => GetArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

}


/// <summary>
/// Block type for default_route_action in GoogleComputeUrlMap.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapDefaultRouteActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "default_route_action";

    /// <summary>
    /// CorsPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CorsPolicy block(s) allowed")]
    public TerraformList<GoogleComputeUrlMapDefaultRouteActionBlockCorsPolicyBlock>? CorsPolicy
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapDefaultRouteActionBlockCorsPolicyBlock>>("cors_policy");
        set => SetArgument("cors_policy", value);
    }

    /// <summary>
    /// FaultInjectionPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FaultInjectionPolicy block(s) allowed")]
    public TerraformList<GoogleComputeUrlMapDefaultRouteActionBlockFaultInjectionPolicyBlock>? FaultInjectionPolicy
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapDefaultRouteActionBlockFaultInjectionPolicyBlock>>("fault_injection_policy");
        set => SetArgument("fault_injection_policy", value);
    }

    /// <summary>
    /// MaxStreamDuration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaxStreamDuration block(s) allowed")]
    public TerraformList<GoogleComputeUrlMapDefaultRouteActionBlockMaxStreamDurationBlock>? MaxStreamDuration
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapDefaultRouteActionBlockMaxStreamDurationBlock>>("max_stream_duration");
        set => SetArgument("max_stream_duration", value);
    }

    /// <summary>
    /// RequestMirrorPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RequestMirrorPolicy block(s) allowed")]
    public TerraformList<GoogleComputeUrlMapDefaultRouteActionBlockRequestMirrorPolicyBlock>? RequestMirrorPolicy
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapDefaultRouteActionBlockRequestMirrorPolicyBlock>>("request_mirror_policy");
        set => SetArgument("request_mirror_policy", value);
    }

    /// <summary>
    /// RetryPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetryPolicy block(s) allowed")]
    public TerraformList<GoogleComputeUrlMapDefaultRouteActionBlockRetryPolicyBlock>? RetryPolicy
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapDefaultRouteActionBlockRetryPolicyBlock>>("retry_policy");
        set => SetArgument("retry_policy", value);
    }

    /// <summary>
    /// Timeout block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Timeout block(s) allowed")]
    public TerraformList<GoogleComputeUrlMapDefaultRouteActionBlockTimeoutBlock>? Timeout
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapDefaultRouteActionBlockTimeoutBlock>>("timeout");
        set => SetArgument("timeout", value);
    }

    /// <summary>
    /// UrlRewrite block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UrlRewrite block(s) allowed")]
    public TerraformList<GoogleComputeUrlMapDefaultRouteActionBlockUrlRewriteBlock>? UrlRewrite
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapDefaultRouteActionBlockUrlRewriteBlock>>("url_rewrite");
        set => SetArgument("url_rewrite", value);
    }

    /// <summary>
    /// WeightedBackendServices block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeUrlMapDefaultRouteActionBlockWeightedBackendServicesBlock>? WeightedBackendServices
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapDefaultRouteActionBlockWeightedBackendServicesBlock>>("weighted_backend_services");
        set => SetArgument("weighted_backend_services", value);
    }

}

/// <summary>
/// Block type for cors_policy in GoogleComputeUrlMapDefaultRouteActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapDefaultRouteActionBlockCorsPolicyBlock : TerraformBlock
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
/// Block type for fault_injection_policy in GoogleComputeUrlMapDefaultRouteActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapDefaultRouteActionBlockFaultInjectionPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "fault_injection_policy";

    /// <summary>
    /// Abort block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Abort block(s) allowed")]
    public TerraformList<GoogleComputeUrlMapDefaultRouteActionBlockFaultInjectionPolicyBlockAbortBlock>? Abort
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapDefaultRouteActionBlockFaultInjectionPolicyBlockAbortBlock>>("abort");
        set => SetArgument("abort", value);
    }

    /// <summary>
    /// Delay block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Delay block(s) allowed")]
    public TerraformList<GoogleComputeUrlMapDefaultRouteActionBlockFaultInjectionPolicyBlockDelayBlock>? Delay
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapDefaultRouteActionBlockFaultInjectionPolicyBlockDelayBlock>>("delay");
        set => SetArgument("delay", value);
    }

}

/// <summary>
/// Block type for abort in GoogleComputeUrlMapDefaultRouteActionBlockFaultInjectionPolicyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapDefaultRouteActionBlockFaultInjectionPolicyBlockAbortBlock : TerraformBlock
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
/// Block type for delay in GoogleComputeUrlMapDefaultRouteActionBlockFaultInjectionPolicyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapDefaultRouteActionBlockFaultInjectionPolicyBlockDelayBlock : TerraformBlock
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
    public TerraformList<GoogleComputeUrlMapDefaultRouteActionBlockFaultInjectionPolicyBlockDelayBlockFixedDelayBlock>? FixedDelay
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapDefaultRouteActionBlockFaultInjectionPolicyBlockDelayBlockFixedDelayBlock>>("fixed_delay");
        set => SetArgument("fixed_delay", value);
    }

}

/// <summary>
/// Block type for fixed_delay in GoogleComputeUrlMapDefaultRouteActionBlockFaultInjectionPolicyBlockDelayBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapDefaultRouteActionBlockFaultInjectionPolicyBlockDelayBlockFixedDelayBlock : TerraformBlock
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
/// Block type for max_stream_duration in GoogleComputeUrlMapDefaultRouteActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapDefaultRouteActionBlockMaxStreamDurationBlock : TerraformBlock
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
/// Block type for request_mirror_policy in GoogleComputeUrlMapDefaultRouteActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapDefaultRouteActionBlockRequestMirrorPolicyBlock : TerraformBlock
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
/// Block type for retry_policy in GoogleComputeUrlMapDefaultRouteActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapDefaultRouteActionBlockRetryPolicyBlock : TerraformBlock
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
    public TerraformList<GoogleComputeUrlMapDefaultRouteActionBlockRetryPolicyBlockPerTryTimeoutBlock>? PerTryTimeout
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapDefaultRouteActionBlockRetryPolicyBlockPerTryTimeoutBlock>>("per_try_timeout");
        set => SetArgument("per_try_timeout", value);
    }

}

/// <summary>
/// Block type for per_try_timeout in GoogleComputeUrlMapDefaultRouteActionBlockRetryPolicyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapDefaultRouteActionBlockRetryPolicyBlockPerTryTimeoutBlock : TerraformBlock
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
/// Block type for timeout in GoogleComputeUrlMapDefaultRouteActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapDefaultRouteActionBlockTimeoutBlock : TerraformBlock
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
/// Block type for url_rewrite in GoogleComputeUrlMapDefaultRouteActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapDefaultRouteActionBlockUrlRewriteBlock : TerraformBlock
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

}

/// <summary>
/// Block type for weighted_backend_services in GoogleComputeUrlMapDefaultRouteActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapDefaultRouteActionBlockWeightedBackendServicesBlock : TerraformBlock
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
    public TerraformList<GoogleComputeUrlMapDefaultRouteActionBlockWeightedBackendServicesBlockHeaderActionBlock>? HeaderAction
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapDefaultRouteActionBlockWeightedBackendServicesBlockHeaderActionBlock>>("header_action");
        set => SetArgument("header_action", value);
    }

}

/// <summary>
/// Block type for header_action in GoogleComputeUrlMapDefaultRouteActionBlockWeightedBackendServicesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapDefaultRouteActionBlockWeightedBackendServicesBlockHeaderActionBlock : TerraformBlock
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
    public TerraformList<GoogleComputeUrlMapDefaultRouteActionBlockWeightedBackendServicesBlockHeaderActionBlockRequestHeadersToAddBlock>? RequestHeadersToAdd
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapDefaultRouteActionBlockWeightedBackendServicesBlockHeaderActionBlockRequestHeadersToAddBlock>>("request_headers_to_add");
        set => SetArgument("request_headers_to_add", value);
    }

    /// <summary>
    /// ResponseHeadersToAdd block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeUrlMapDefaultRouteActionBlockWeightedBackendServicesBlockHeaderActionBlockResponseHeadersToAddBlock>? ResponseHeadersToAdd
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapDefaultRouteActionBlockWeightedBackendServicesBlockHeaderActionBlockResponseHeadersToAddBlock>>("response_headers_to_add");
        set => SetArgument("response_headers_to_add", value);
    }

}

/// <summary>
/// Block type for request_headers_to_add in GoogleComputeUrlMapDefaultRouteActionBlockWeightedBackendServicesBlockHeaderActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapDefaultRouteActionBlockWeightedBackendServicesBlockHeaderActionBlockRequestHeadersToAddBlock : TerraformBlock
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
/// Block type for response_headers_to_add in GoogleComputeUrlMapDefaultRouteActionBlockWeightedBackendServicesBlockHeaderActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapDefaultRouteActionBlockWeightedBackendServicesBlockHeaderActionBlockResponseHeadersToAddBlock : TerraformBlock
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
/// Block type for default_url_redirect in GoogleComputeUrlMap.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapDefaultUrlRedirectBlock : TerraformBlock
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
    /// retained. The default is set to false.
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
/// Block type for header_action in GoogleComputeUrlMap.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapHeaderActionBlock : TerraformBlock
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
    public TerraformList<GoogleComputeUrlMapHeaderActionBlockRequestHeadersToAddBlock>? RequestHeadersToAdd
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapHeaderActionBlockRequestHeadersToAddBlock>>("request_headers_to_add");
        set => SetArgument("request_headers_to_add", value);
    }

    /// <summary>
    /// ResponseHeadersToAdd block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeUrlMapHeaderActionBlockResponseHeadersToAddBlock>? ResponseHeadersToAdd
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapHeaderActionBlockResponseHeadersToAddBlock>>("response_headers_to_add");
        set => SetArgument("response_headers_to_add", value);
    }

}

/// <summary>
/// Block type for request_headers_to_add in GoogleComputeUrlMapHeaderActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapHeaderActionBlockRequestHeadersToAddBlock : TerraformBlock
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
/// Block type for response_headers_to_add in GoogleComputeUrlMapHeaderActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapHeaderActionBlockResponseHeadersToAddBlock : TerraformBlock
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
/// Block type for host_rule in GoogleComputeUrlMap.
/// Nesting mode: set
/// </summary>
public class GoogleComputeUrlMapHostRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "host_rule";

    /// <summary>
    /// An optional description of this resource. Provide this property when you create
    /// the resource.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The list of host patterns to match. They must be valid hostnames, except * will
    /// match any string of ([a-z0-9-.]*). In that case, * must be the first character
    /// and must be followed in the pattern by either - or ..
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hosts is required")]
    public required TerraformSet<string> Hosts
    {
        get => GetRequiredArgument<TerraformSet<string>>("hosts");
        set => SetArgument("hosts", value);
    }

    /// <summary>
    /// The name of the PathMatcher to use to match the path portion of the URL if the
    /// hostRule matches the URL&#39;s host portion.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PathMatcher is required")]
    public required TerraformValue<string> PathMatcher
    {
        get => GetRequiredArgument<TerraformValue<string>>("path_matcher");
        set => SetArgument("path_matcher", value);
    }

}


/// <summary>
/// Block type for path_matcher in GoogleComputeUrlMap.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapPathMatcherBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "path_matcher";

    /// <summary>
    /// The backend service or backend bucket to use when none of the given paths match.
    /// </summary>
    public TerraformValue<string>? DefaultService
    {
        get => GetArgument<TerraformValue<string>>("default_service");
        set => SetArgument("default_service", value);
    }

    /// <summary>
    /// An optional description of this resource. Provide this property when you create
    /// the resource.
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
    /// DefaultCustomErrorResponsePolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultCustomErrorResponsePolicy block(s) allowed")]
    public TerraformList<GoogleComputeUrlMapPathMatcherBlockDefaultCustomErrorResponsePolicyBlock>? DefaultCustomErrorResponsePolicy
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapPathMatcherBlockDefaultCustomErrorResponsePolicyBlock>>("default_custom_error_response_policy");
        set => SetArgument("default_custom_error_response_policy", value);
    }

    /// <summary>
    /// DefaultRouteAction block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultRouteAction block(s) allowed")]
    public TerraformList<GoogleComputeUrlMapPathMatcherBlockDefaultRouteActionBlock>? DefaultRouteAction
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapPathMatcherBlockDefaultRouteActionBlock>>("default_route_action");
        set => SetArgument("default_route_action", value);
    }

    /// <summary>
    /// DefaultUrlRedirect block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultUrlRedirect block(s) allowed")]
    public TerraformList<GoogleComputeUrlMapPathMatcherBlockDefaultUrlRedirectBlock>? DefaultUrlRedirect
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapPathMatcherBlockDefaultUrlRedirectBlock>>("default_url_redirect");
        set => SetArgument("default_url_redirect", value);
    }

    /// <summary>
    /// HeaderAction block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HeaderAction block(s) allowed")]
    public TerraformList<GoogleComputeUrlMapPathMatcherBlockHeaderActionBlock>? HeaderAction
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapPathMatcherBlockHeaderActionBlock>>("header_action");
        set => SetArgument("header_action", value);
    }

    /// <summary>
    /// PathRule block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeUrlMapPathMatcherBlockPathRuleBlock>? PathRule
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapPathMatcherBlockPathRuleBlock>>("path_rule");
        set => SetArgument("path_rule", value);
    }

    /// <summary>
    /// RouteRules block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeUrlMapPathMatcherBlockRouteRulesBlock>? RouteRules
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapPathMatcherBlockRouteRulesBlock>>("route_rules");
        set => SetArgument("route_rules", value);
    }

}

/// <summary>
/// Block type for default_custom_error_response_policy in GoogleComputeUrlMapPathMatcherBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapPathMatcherBlockDefaultCustomErrorResponsePolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "default_custom_error_response_policy";

    /// <summary>
    /// The full or partial URL to the BackendBucket resource that contains the custom error content. Examples are:
    /// https://www.googleapis.com/compute/v1/projects/project/global/backendBuckets/myBackendBucket
    /// compute/v1/projects/project/global/backendBuckets/myBackendBucket
    /// global/backendBuckets/myBackendBucket
    /// If errorService is not specified at lower levels like pathMatcher, pathRule and routeRule, an errorService specified at a higher level in the UrlMap will be used. If UrlMap.defaultCustomErrorResponsePolicy contains one or more errorResponseRules[], it must specify errorService.
    /// If load balancer cannot reach the backendBucket, a simple Not Found Error will be returned, with the original response code (or overrideResponseCode if configured).
    /// </summary>
    public TerraformValue<string>? ErrorService
    {
        get => GetArgument<TerraformValue<string>>("error_service");
        set => SetArgument("error_service", value);
    }

    /// <summary>
    /// ErrorResponseRule block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeUrlMapPathMatcherBlockDefaultCustomErrorResponsePolicyBlockErrorResponseRuleBlock>? ErrorResponseRule
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapPathMatcherBlockDefaultCustomErrorResponsePolicyBlockErrorResponseRuleBlock>>("error_response_rule");
        set => SetArgument("error_response_rule", value);
    }

}

/// <summary>
/// Block type for error_response_rule in GoogleComputeUrlMapPathMatcherBlockDefaultCustomErrorResponsePolicyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapPathMatcherBlockDefaultCustomErrorResponsePolicyBlockErrorResponseRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "error_response_rule";

    /// <summary>
    /// Valid values include:
    /// - A number between 400 and 599: For example 401 or 503, in which case the load balancer applies the policy if the error code exactly matches this value.
    /// - 5xx: Load Balancer will apply the policy if the backend service responds with any response code in the range of 500 to 599.
    /// - 4xx: Load Balancer will apply the policy if the backend service responds with any response code in the range of 400 to 499.
    /// Values must be unique within matchResponseCodes and across all errorResponseRules of CustomErrorResponsePolicy.
    /// </summary>
    public TerraformList<string>? MatchResponseCodes
    {
        get => GetArgument<TerraformList<string>>("match_response_codes");
        set => SetArgument("match_response_codes", value);
    }

    /// <summary>
    /// The HTTP status code returned with the response containing the custom error content.
    /// If overrideResponseCode is not supplied, the same response code returned by the original backend bucket or backend service is returned to the client.
    /// </summary>
    public TerraformValue<double>? OverrideResponseCode
    {
        get => GetArgument<TerraformValue<double>>("override_response_code");
        set => SetArgument("override_response_code", value);
    }

    /// <summary>
    /// The full path to a file within backendBucket . For example: /errors/defaultError.html
    /// path must start with a leading slash. path cannot have trailing slashes.
    /// If the file is not available in backendBucket or the load balancer cannot reach the BackendBucket, a simple Not Found Error is returned to the client.
    /// The value must be from 1 to 1024 characters
    /// </summary>
    public TerraformValue<string>? Path
    {
        get => GetArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

}

/// <summary>
/// Block type for default_route_action in GoogleComputeUrlMapPathMatcherBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapPathMatcherBlockDefaultRouteActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "default_route_action";

    /// <summary>
    /// CorsPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CorsPolicy block(s) allowed")]
    public TerraformList<GoogleComputeUrlMapPathMatcherBlockDefaultRouteActionBlockCorsPolicyBlock>? CorsPolicy
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapPathMatcherBlockDefaultRouteActionBlockCorsPolicyBlock>>("cors_policy");
        set => SetArgument("cors_policy", value);
    }

    /// <summary>
    /// FaultInjectionPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FaultInjectionPolicy block(s) allowed")]
    public TerraformList<GoogleComputeUrlMapPathMatcherBlockDefaultRouteActionBlockFaultInjectionPolicyBlock>? FaultInjectionPolicy
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapPathMatcherBlockDefaultRouteActionBlockFaultInjectionPolicyBlock>>("fault_injection_policy");
        set => SetArgument("fault_injection_policy", value);
    }

    /// <summary>
    /// MaxStreamDuration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaxStreamDuration block(s) allowed")]
    public TerraformList<GoogleComputeUrlMapPathMatcherBlockDefaultRouteActionBlockMaxStreamDurationBlock>? MaxStreamDuration
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapPathMatcherBlockDefaultRouteActionBlockMaxStreamDurationBlock>>("max_stream_duration");
        set => SetArgument("max_stream_duration", value);
    }

    /// <summary>
    /// RequestMirrorPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RequestMirrorPolicy block(s) allowed")]
    public TerraformList<GoogleComputeUrlMapPathMatcherBlockDefaultRouteActionBlockRequestMirrorPolicyBlock>? RequestMirrorPolicy
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapPathMatcherBlockDefaultRouteActionBlockRequestMirrorPolicyBlock>>("request_mirror_policy");
        set => SetArgument("request_mirror_policy", value);
    }

    /// <summary>
    /// RetryPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetryPolicy block(s) allowed")]
    public TerraformList<GoogleComputeUrlMapPathMatcherBlockDefaultRouteActionBlockRetryPolicyBlock>? RetryPolicy
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapPathMatcherBlockDefaultRouteActionBlockRetryPolicyBlock>>("retry_policy");
        set => SetArgument("retry_policy", value);
    }

    /// <summary>
    /// Timeout block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Timeout block(s) allowed")]
    public TerraformList<GoogleComputeUrlMapPathMatcherBlockDefaultRouteActionBlockTimeoutBlock>? Timeout
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapPathMatcherBlockDefaultRouteActionBlockTimeoutBlock>>("timeout");
        set => SetArgument("timeout", value);
    }

    /// <summary>
    /// UrlRewrite block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UrlRewrite block(s) allowed")]
    public TerraformList<GoogleComputeUrlMapPathMatcherBlockDefaultRouteActionBlockUrlRewriteBlock>? UrlRewrite
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapPathMatcherBlockDefaultRouteActionBlockUrlRewriteBlock>>("url_rewrite");
        set => SetArgument("url_rewrite", value);
    }

    /// <summary>
    /// WeightedBackendServices block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeUrlMapPathMatcherBlockDefaultRouteActionBlockWeightedBackendServicesBlock>? WeightedBackendServices
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapPathMatcherBlockDefaultRouteActionBlockWeightedBackendServicesBlock>>("weighted_backend_services");
        set => SetArgument("weighted_backend_services", value);
    }

}

/// <summary>
/// Block type for cors_policy in GoogleComputeUrlMapPathMatcherBlockDefaultRouteActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapPathMatcherBlockDefaultRouteActionBlockCorsPolicyBlock : TerraformBlock
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
/// Block type for fault_injection_policy in GoogleComputeUrlMapPathMatcherBlockDefaultRouteActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapPathMatcherBlockDefaultRouteActionBlockFaultInjectionPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "fault_injection_policy";

    /// <summary>
    /// Abort block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Abort block(s) allowed")]
    public TerraformList<GoogleComputeUrlMapPathMatcherBlockDefaultRouteActionBlockFaultInjectionPolicyBlockAbortBlock>? Abort
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapPathMatcherBlockDefaultRouteActionBlockFaultInjectionPolicyBlockAbortBlock>>("abort");
        set => SetArgument("abort", value);
    }

    /// <summary>
    /// Delay block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Delay block(s) allowed")]
    public TerraformList<GoogleComputeUrlMapPathMatcherBlockDefaultRouteActionBlockFaultInjectionPolicyBlockDelayBlock>? Delay
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapPathMatcherBlockDefaultRouteActionBlockFaultInjectionPolicyBlockDelayBlock>>("delay");
        set => SetArgument("delay", value);
    }

}

/// <summary>
/// Block type for abort in GoogleComputeUrlMapPathMatcherBlockDefaultRouteActionBlockFaultInjectionPolicyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapPathMatcherBlockDefaultRouteActionBlockFaultInjectionPolicyBlockAbortBlock : TerraformBlock
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
/// Block type for delay in GoogleComputeUrlMapPathMatcherBlockDefaultRouteActionBlockFaultInjectionPolicyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapPathMatcherBlockDefaultRouteActionBlockFaultInjectionPolicyBlockDelayBlock : TerraformBlock
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
    public TerraformList<GoogleComputeUrlMapPathMatcherBlockDefaultRouteActionBlockFaultInjectionPolicyBlockDelayBlockFixedDelayBlock>? FixedDelay
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapPathMatcherBlockDefaultRouteActionBlockFaultInjectionPolicyBlockDelayBlockFixedDelayBlock>>("fixed_delay");
        set => SetArgument("fixed_delay", value);
    }

}

/// <summary>
/// Block type for fixed_delay in GoogleComputeUrlMapPathMatcherBlockDefaultRouteActionBlockFaultInjectionPolicyBlockDelayBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapPathMatcherBlockDefaultRouteActionBlockFaultInjectionPolicyBlockDelayBlockFixedDelayBlock : TerraformBlock
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
/// Block type for max_stream_duration in GoogleComputeUrlMapPathMatcherBlockDefaultRouteActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapPathMatcherBlockDefaultRouteActionBlockMaxStreamDurationBlock : TerraformBlock
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
/// Block type for request_mirror_policy in GoogleComputeUrlMapPathMatcherBlockDefaultRouteActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapPathMatcherBlockDefaultRouteActionBlockRequestMirrorPolicyBlock : TerraformBlock
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
/// Block type for retry_policy in GoogleComputeUrlMapPathMatcherBlockDefaultRouteActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapPathMatcherBlockDefaultRouteActionBlockRetryPolicyBlock : TerraformBlock
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
    public TerraformList<GoogleComputeUrlMapPathMatcherBlockDefaultRouteActionBlockRetryPolicyBlockPerTryTimeoutBlock>? PerTryTimeout
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapPathMatcherBlockDefaultRouteActionBlockRetryPolicyBlockPerTryTimeoutBlock>>("per_try_timeout");
        set => SetArgument("per_try_timeout", value);
    }

}

/// <summary>
/// Block type for per_try_timeout in GoogleComputeUrlMapPathMatcherBlockDefaultRouteActionBlockRetryPolicyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapPathMatcherBlockDefaultRouteActionBlockRetryPolicyBlockPerTryTimeoutBlock : TerraformBlock
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
/// Block type for timeout in GoogleComputeUrlMapPathMatcherBlockDefaultRouteActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapPathMatcherBlockDefaultRouteActionBlockTimeoutBlock : TerraformBlock
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
/// Block type for url_rewrite in GoogleComputeUrlMapPathMatcherBlockDefaultRouteActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapPathMatcherBlockDefaultRouteActionBlockUrlRewriteBlock : TerraformBlock
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

}

/// <summary>
/// Block type for weighted_backend_services in GoogleComputeUrlMapPathMatcherBlockDefaultRouteActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapPathMatcherBlockDefaultRouteActionBlockWeightedBackendServicesBlock : TerraformBlock
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
    public TerraformList<GoogleComputeUrlMapPathMatcherBlockDefaultRouteActionBlockWeightedBackendServicesBlockHeaderActionBlock>? HeaderAction
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapPathMatcherBlockDefaultRouteActionBlockWeightedBackendServicesBlockHeaderActionBlock>>("header_action");
        set => SetArgument("header_action", value);
    }

}

/// <summary>
/// Block type for header_action in GoogleComputeUrlMapPathMatcherBlockDefaultRouteActionBlockWeightedBackendServicesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapPathMatcherBlockDefaultRouteActionBlockWeightedBackendServicesBlockHeaderActionBlock : TerraformBlock
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
    public TerraformList<GoogleComputeUrlMapPathMatcherBlockDefaultRouteActionBlockWeightedBackendServicesBlockHeaderActionBlockRequestHeadersToAddBlock>? RequestHeadersToAdd
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapPathMatcherBlockDefaultRouteActionBlockWeightedBackendServicesBlockHeaderActionBlockRequestHeadersToAddBlock>>("request_headers_to_add");
        set => SetArgument("request_headers_to_add", value);
    }

    /// <summary>
    /// ResponseHeadersToAdd block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeUrlMapPathMatcherBlockDefaultRouteActionBlockWeightedBackendServicesBlockHeaderActionBlockResponseHeadersToAddBlock>? ResponseHeadersToAdd
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapPathMatcherBlockDefaultRouteActionBlockWeightedBackendServicesBlockHeaderActionBlockResponseHeadersToAddBlock>>("response_headers_to_add");
        set => SetArgument("response_headers_to_add", value);
    }

}

/// <summary>
/// Block type for request_headers_to_add in GoogleComputeUrlMapPathMatcherBlockDefaultRouteActionBlockWeightedBackendServicesBlockHeaderActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapPathMatcherBlockDefaultRouteActionBlockWeightedBackendServicesBlockHeaderActionBlockRequestHeadersToAddBlock : TerraformBlock
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
/// Block type for response_headers_to_add in GoogleComputeUrlMapPathMatcherBlockDefaultRouteActionBlockWeightedBackendServicesBlockHeaderActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapPathMatcherBlockDefaultRouteActionBlockWeightedBackendServicesBlockHeaderActionBlockResponseHeadersToAddBlock : TerraformBlock
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
/// Block type for default_url_redirect in GoogleComputeUrlMapPathMatcherBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapPathMatcherBlockDefaultUrlRedirectBlock : TerraformBlock
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
/// Block type for header_action in GoogleComputeUrlMapPathMatcherBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapPathMatcherBlockHeaderActionBlock : TerraformBlock
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
    public TerraformList<GoogleComputeUrlMapPathMatcherBlockHeaderActionBlockRequestHeadersToAddBlock>? RequestHeadersToAdd
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapPathMatcherBlockHeaderActionBlockRequestHeadersToAddBlock>>("request_headers_to_add");
        set => SetArgument("request_headers_to_add", value);
    }

    /// <summary>
    /// ResponseHeadersToAdd block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeUrlMapPathMatcherBlockHeaderActionBlockResponseHeadersToAddBlock>? ResponseHeadersToAdd
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapPathMatcherBlockHeaderActionBlockResponseHeadersToAddBlock>>("response_headers_to_add");
        set => SetArgument("response_headers_to_add", value);
    }

}

/// <summary>
/// Block type for request_headers_to_add in GoogleComputeUrlMapPathMatcherBlockHeaderActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapPathMatcherBlockHeaderActionBlockRequestHeadersToAddBlock : TerraformBlock
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
/// Block type for response_headers_to_add in GoogleComputeUrlMapPathMatcherBlockHeaderActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapPathMatcherBlockHeaderActionBlockResponseHeadersToAddBlock : TerraformBlock
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
/// Block type for path_rule in GoogleComputeUrlMapPathMatcherBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapPathMatcherBlockPathRuleBlock : TerraformBlock
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
    /// The backend service or backend bucket to use if any of the given paths match.
    /// </summary>
    public TerraformValue<string>? Service
    {
        get => GetArgument<TerraformValue<string>>("service");
        set => SetArgument("service", value);
    }

    /// <summary>
    /// CustomErrorResponsePolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomErrorResponsePolicy block(s) allowed")]
    public TerraformList<GoogleComputeUrlMapPathMatcherBlockPathRuleBlockCustomErrorResponsePolicyBlock>? CustomErrorResponsePolicy
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapPathMatcherBlockPathRuleBlockCustomErrorResponsePolicyBlock>>("custom_error_response_policy");
        set => SetArgument("custom_error_response_policy", value);
    }

    /// <summary>
    /// RouteAction block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RouteAction block(s) allowed")]
    public TerraformList<GoogleComputeUrlMapPathMatcherBlockPathRuleBlockRouteActionBlock>? RouteAction
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapPathMatcherBlockPathRuleBlockRouteActionBlock>>("route_action");
        set => SetArgument("route_action", value);
    }

    /// <summary>
    /// UrlRedirect block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UrlRedirect block(s) allowed")]
    public TerraformList<GoogleComputeUrlMapPathMatcherBlockPathRuleBlockUrlRedirectBlock>? UrlRedirect
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapPathMatcherBlockPathRuleBlockUrlRedirectBlock>>("url_redirect");
        set => SetArgument("url_redirect", value);
    }

}

/// <summary>
/// Block type for custom_error_response_policy in GoogleComputeUrlMapPathMatcherBlockPathRuleBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapPathMatcherBlockPathRuleBlockCustomErrorResponsePolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_error_response_policy";

    /// <summary>
    /// The full or partial URL to the BackendBucket resource that contains the custom error content. Examples are:
    /// 
    /// https://www.googleapis.com/compute/v1/projects/project/global/backendBuckets/myBackendBucket
    /// compute/v1/projects/project/global/backendBuckets/myBackendBucket
    /// global/backendBuckets/myBackendBucket
    /// 
    /// If errorService is not specified at lower levels like pathMatcher, pathRule and routeRule, an errorService specified at a higher level in the UrlMap will be used. If UrlMap.defaultCustomErrorResponsePolicy contains one or more errorResponseRules[], it must specify errorService.
    /// If load balancer cannot reach the backendBucket, a simple Not Found Error will be returned, with the original response code (or overrideResponseCode if configured).
    /// </summary>
    public TerraformValue<string>? ErrorService
    {
        get => GetArgument<TerraformValue<string>>("error_service");
        set => SetArgument("error_service", value);
    }

    /// <summary>
    /// ErrorResponseRule block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeUrlMapPathMatcherBlockPathRuleBlockCustomErrorResponsePolicyBlockErrorResponseRuleBlock>? ErrorResponseRule
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapPathMatcherBlockPathRuleBlockCustomErrorResponsePolicyBlockErrorResponseRuleBlock>>("error_response_rule");
        set => SetArgument("error_response_rule", value);
    }

}

/// <summary>
/// Block type for error_response_rule in GoogleComputeUrlMapPathMatcherBlockPathRuleBlockCustomErrorResponsePolicyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapPathMatcherBlockPathRuleBlockCustomErrorResponsePolicyBlockErrorResponseRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "error_response_rule";

    /// <summary>
    /// Valid values include:
    /// 
    /// - A number between 400 and 599: For example 401 or 503, in which case the load balancer applies the policy if the error code exactly matches this value.
    /// - 5xx: Load Balancer will apply the policy if the backend service responds with any response code in the range of 500 to 599.
    /// - 4xx: Load Balancer will apply the policy if the backend service responds with any response code in the range of 400 to 499.
    /// 
    /// Values must be unique within matchResponseCodes and across all errorResponseRules of CustomErrorResponsePolicy.
    /// </summary>
    public TerraformList<string>? MatchResponseCodes
    {
        get => GetArgument<TerraformList<string>>("match_response_codes");
        set => SetArgument("match_response_codes", value);
    }

    /// <summary>
    /// The HTTP status code returned with the response containing the custom error content.
    /// If overrideResponseCode is not supplied, the same response code returned by the original backend bucket or backend service is returned to the client.
    /// </summary>
    public TerraformValue<double>? OverrideResponseCode
    {
        get => GetArgument<TerraformValue<double>>("override_response_code");
        set => SetArgument("override_response_code", value);
    }

    /// <summary>
    /// The full path to a file within backendBucket . For example: /errors/defaultError.html
    /// path must start with a leading slash. path cannot have trailing slashes.
    /// If the file is not available in backendBucket or the load balancer cannot reach the BackendBucket, a simple Not Found Error is returned to the client.
    /// The value must be from 1 to 1024 characters
    /// </summary>
    public TerraformValue<string>? Path
    {
        get => GetArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

}

/// <summary>
/// Block type for route_action in GoogleComputeUrlMapPathMatcherBlockPathRuleBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapPathMatcherBlockPathRuleBlockRouteActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "route_action";

    /// <summary>
    /// CorsPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CorsPolicy block(s) allowed")]
    public TerraformList<GoogleComputeUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockCorsPolicyBlock>? CorsPolicy
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockCorsPolicyBlock>>("cors_policy");
        set => SetArgument("cors_policy", value);
    }

    /// <summary>
    /// FaultInjectionPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FaultInjectionPolicy block(s) allowed")]
    public TerraformList<GoogleComputeUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockFaultInjectionPolicyBlock>? FaultInjectionPolicy
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockFaultInjectionPolicyBlock>>("fault_injection_policy");
        set => SetArgument("fault_injection_policy", value);
    }

    /// <summary>
    /// MaxStreamDuration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaxStreamDuration block(s) allowed")]
    public TerraformList<GoogleComputeUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockMaxStreamDurationBlock>? MaxStreamDuration
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockMaxStreamDurationBlock>>("max_stream_duration");
        set => SetArgument("max_stream_duration", value);
    }

    /// <summary>
    /// RequestMirrorPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RequestMirrorPolicy block(s) allowed")]
    public TerraformList<GoogleComputeUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockRequestMirrorPolicyBlock>? RequestMirrorPolicy
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockRequestMirrorPolicyBlock>>("request_mirror_policy");
        set => SetArgument("request_mirror_policy", value);
    }

    /// <summary>
    /// RetryPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetryPolicy block(s) allowed")]
    public TerraformList<GoogleComputeUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockRetryPolicyBlock>? RetryPolicy
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockRetryPolicyBlock>>("retry_policy");
        set => SetArgument("retry_policy", value);
    }

    /// <summary>
    /// Timeout block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Timeout block(s) allowed")]
    public TerraformList<GoogleComputeUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockTimeoutBlock>? Timeout
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockTimeoutBlock>>("timeout");
        set => SetArgument("timeout", value);
    }

    /// <summary>
    /// UrlRewrite block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UrlRewrite block(s) allowed")]
    public TerraformList<GoogleComputeUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockUrlRewriteBlock>? UrlRewrite
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockUrlRewriteBlock>>("url_rewrite");
        set => SetArgument("url_rewrite", value);
    }

    /// <summary>
    /// WeightedBackendServices block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockWeightedBackendServicesBlock>? WeightedBackendServices
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockWeightedBackendServicesBlock>>("weighted_backend_services");
        set => SetArgument("weighted_backend_services", value);
    }

}

/// <summary>
/// Block type for cors_policy in GoogleComputeUrlMapPathMatcherBlockPathRuleBlockRouteActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockCorsPolicyBlock : TerraformBlock
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
/// Block type for fault_injection_policy in GoogleComputeUrlMapPathMatcherBlockPathRuleBlockRouteActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockFaultInjectionPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "fault_injection_policy";

    /// <summary>
    /// Abort block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Abort block(s) allowed")]
    public TerraformList<GoogleComputeUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockFaultInjectionPolicyBlockAbortBlock>? Abort
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockFaultInjectionPolicyBlockAbortBlock>>("abort");
        set => SetArgument("abort", value);
    }

    /// <summary>
    /// Delay block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Delay block(s) allowed")]
    public TerraformList<GoogleComputeUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockFaultInjectionPolicyBlockDelayBlock>? Delay
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockFaultInjectionPolicyBlockDelayBlock>>("delay");
        set => SetArgument("delay", value);
    }

}

/// <summary>
/// Block type for abort in GoogleComputeUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockFaultInjectionPolicyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockFaultInjectionPolicyBlockAbortBlock : TerraformBlock
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
/// Block type for delay in GoogleComputeUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockFaultInjectionPolicyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockFaultInjectionPolicyBlockDelayBlock : TerraformBlock
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
    public required TerraformList<GoogleComputeUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockFaultInjectionPolicyBlockDelayBlockFixedDelayBlock> FixedDelay
    {
        get => GetRequiredArgument<TerraformList<GoogleComputeUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockFaultInjectionPolicyBlockDelayBlockFixedDelayBlock>>("fixed_delay");
        set => SetArgument("fixed_delay", value);
    }

}

/// <summary>
/// Block type for fixed_delay in GoogleComputeUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockFaultInjectionPolicyBlockDelayBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockFaultInjectionPolicyBlockDelayBlockFixedDelayBlock : TerraformBlock
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
/// Block type for max_stream_duration in GoogleComputeUrlMapPathMatcherBlockPathRuleBlockRouteActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockMaxStreamDurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "max_stream_duration";

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
/// Block type for request_mirror_policy in GoogleComputeUrlMapPathMatcherBlockPathRuleBlockRouteActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockRequestMirrorPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "request_mirror_policy";

    /// <summary>
    /// The BackendService resource being mirrored to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackendService is required")]
    public required TerraformValue<string> BackendService
    {
        get => GetRequiredArgument<TerraformValue<string>>("backend_service");
        set => SetArgument("backend_service", value);
    }

}

/// <summary>
/// Block type for retry_policy in GoogleComputeUrlMapPathMatcherBlockPathRuleBlockRouteActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockRetryPolicyBlock : TerraformBlock
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
    /// * 5xx: Loadbalancer will attempt a retry if the backend service responds with
    /// any 5xx response code, or if the backend service does not respond at all,
    /// for example: disconnects, reset, read timeout, connection failure, and refused
    /// streams.
    /// * gateway-error: Similar to 5xx, but only applies to response codes
    /// 502, 503 or 504.
    /// * connect-failure: Loadbalancer will retry on failures
    /// connecting to backend services, for example due to connection timeouts.
    /// * retriable-4xx: Loadbalancer will retry for retriable 4xx response codes.
    /// Currently the only retriable error supported is 409.
    /// * refused-stream: Loadbalancer will retry if the backend service resets the stream with a
    /// REFUSED_STREAM error code. This reset type indicates that it is safe to retry.
    /// * cancelled: Loadbalancer will retry if the gRPC status code in the response
    /// header is set to cancelled
    /// * deadline-exceeded: Loadbalancer will retry if the
    /// gRPC status code in the response header is set to deadline-exceeded
    /// * resource-exhausted: Loadbalancer will retry if the gRPC status code in the response
    /// header is set to resource-exhausted
    /// * unavailable: Loadbalancer will retry if
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
    public TerraformList<GoogleComputeUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockRetryPolicyBlockPerTryTimeoutBlock>? PerTryTimeout
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockRetryPolicyBlockPerTryTimeoutBlock>>("per_try_timeout");
        set => SetArgument("per_try_timeout", value);
    }

}

/// <summary>
/// Block type for per_try_timeout in GoogleComputeUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockRetryPolicyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockRetryPolicyBlockPerTryTimeoutBlock : TerraformBlock
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
/// Block type for timeout in GoogleComputeUrlMapPathMatcherBlockPathRuleBlockRouteActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockTimeoutBlock : TerraformBlock
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
/// Block type for url_rewrite in GoogleComputeUrlMapPathMatcherBlockPathRuleBlockRouteActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockUrlRewriteBlock : TerraformBlock
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
/// Block type for weighted_backend_services in GoogleComputeUrlMapPathMatcherBlockPathRuleBlockRouteActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockWeightedBackendServicesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "weighted_backend_services";

    /// <summary>
    /// The default BackendService resource. Before
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
    public TerraformList<GoogleComputeUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockWeightedBackendServicesBlockHeaderActionBlock>? HeaderAction
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockWeightedBackendServicesBlockHeaderActionBlock>>("header_action");
        set => SetArgument("header_action", value);
    }

}

/// <summary>
/// Block type for header_action in GoogleComputeUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockWeightedBackendServicesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockWeightedBackendServicesBlockHeaderActionBlock : TerraformBlock
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
    public TerraformList<GoogleComputeUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockWeightedBackendServicesBlockHeaderActionBlockRequestHeadersToAddBlock>? RequestHeadersToAdd
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockWeightedBackendServicesBlockHeaderActionBlockRequestHeadersToAddBlock>>("request_headers_to_add");
        set => SetArgument("request_headers_to_add", value);
    }

    /// <summary>
    /// ResponseHeadersToAdd block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockWeightedBackendServicesBlockHeaderActionBlockResponseHeadersToAddBlock>? ResponseHeadersToAdd
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockWeightedBackendServicesBlockHeaderActionBlockResponseHeadersToAddBlock>>("response_headers_to_add");
        set => SetArgument("response_headers_to_add", value);
    }

}

/// <summary>
/// Block type for request_headers_to_add in GoogleComputeUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockWeightedBackendServicesBlockHeaderActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockWeightedBackendServicesBlockHeaderActionBlockRequestHeadersToAddBlock : TerraformBlock
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
/// Block type for response_headers_to_add in GoogleComputeUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockWeightedBackendServicesBlockHeaderActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapPathMatcherBlockPathRuleBlockRouteActionBlockWeightedBackendServicesBlockHeaderActionBlockResponseHeadersToAddBlock : TerraformBlock
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
/// Block type for url_redirect in GoogleComputeUrlMapPathMatcherBlockPathRuleBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapPathMatcherBlockPathRuleBlockUrlRedirectBlock : TerraformBlock
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
    /// portion of the original URL is retained.
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
/// Block type for route_rules in GoogleComputeUrlMapPathMatcherBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapPathMatcherBlockRouteRulesBlock : TerraformBlock
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
    /// The backend service resource to which traffic is
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
    /// CustomErrorResponsePolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomErrorResponsePolicy block(s) allowed")]
    public TerraformList<GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockCustomErrorResponsePolicyBlock>? CustomErrorResponsePolicy
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockCustomErrorResponsePolicyBlock>>("custom_error_response_policy");
        set => SetArgument("custom_error_response_policy", value);
    }

    /// <summary>
    /// HeaderAction block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HeaderAction block(s) allowed")]
    public TerraformList<GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockHeaderActionBlock>? HeaderAction
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockHeaderActionBlock>>("header_action");
        set => SetArgument("header_action", value);
    }

    /// <summary>
    /// MatchRules block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockMatchRulesBlock>? MatchRules
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockMatchRulesBlock>>("match_rules");
        set => SetArgument("match_rules", value);
    }

    /// <summary>
    /// RouteAction block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RouteAction block(s) allowed")]
    public TerraformList<GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlock>? RouteAction
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlock>>("route_action");
        set => SetArgument("route_action", value);
    }

    /// <summary>
    /// UrlRedirect block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UrlRedirect block(s) allowed")]
    public TerraformList<GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockUrlRedirectBlock>? UrlRedirect
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockUrlRedirectBlock>>("url_redirect");
        set => SetArgument("url_redirect", value);
    }

}

/// <summary>
/// Block type for custom_error_response_policy in GoogleComputeUrlMapPathMatcherBlockRouteRulesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockCustomErrorResponsePolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_error_response_policy";

    /// <summary>
    /// The full or partial URL to the BackendBucket resource that contains the custom error content. Examples are:
    /// 
    /// https://www.googleapis.com/compute/v1/projects/project/global/backendBuckets/myBackendBucket
    /// compute/v1/projects/project/global/backendBuckets/myBackendBucket
    /// global/backendBuckets/myBackendBucket
    /// 
    /// If errorService is not specified at lower levels like pathMatcher, pathRule and routeRule, an errorService specified at a higher level in the UrlMap will be used. If UrlMap.defaultCustomErrorResponsePolicy contains one or more errorResponseRules[], it must specify errorService.
    /// If load balancer cannot reach the backendBucket, a simple Not Found Error will be returned, with the original response code (or overrideResponseCode if configured).
    /// </summary>
    public TerraformValue<string>? ErrorService
    {
        get => GetArgument<TerraformValue<string>>("error_service");
        set => SetArgument("error_service", value);
    }

    /// <summary>
    /// ErrorResponseRule block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockCustomErrorResponsePolicyBlockErrorResponseRuleBlock>? ErrorResponseRule
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockCustomErrorResponsePolicyBlockErrorResponseRuleBlock>>("error_response_rule");
        set => SetArgument("error_response_rule", value);
    }

}

/// <summary>
/// Block type for error_response_rule in GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockCustomErrorResponsePolicyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockCustomErrorResponsePolicyBlockErrorResponseRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "error_response_rule";

    /// <summary>
    /// Valid values include:
    /// 
    /// - A number between 400 and 599: For example 401 or 503, in which case the load balancer applies the policy if the error code exactly matches this value.
    /// - 5xx: Load Balancer will apply the policy if the backend service responds with any response code in the range of 500 to 599.
    /// - 4xx: Load Balancer will apply the policy if the backend service responds with any response code in the range of 400 to 499.
    /// 
    /// Values must be unique within matchResponseCodes and across all errorResponseRules of CustomErrorResponsePolicy.
    /// </summary>
    public TerraformList<string>? MatchResponseCodes
    {
        get => GetArgument<TerraformList<string>>("match_response_codes");
        set => SetArgument("match_response_codes", value);
    }

    /// <summary>
    /// The HTTP status code returned with the response containing the custom error content.
    /// If overrideResponseCode is not supplied, the same response code returned by the original backend bucket or backend service is returned to the client.
    /// </summary>
    public TerraformValue<double>? OverrideResponseCode
    {
        get => GetArgument<TerraformValue<double>>("override_response_code");
        set => SetArgument("override_response_code", value);
    }

    /// <summary>
    /// The full path to a file within backendBucket . For example: /errors/defaultError.html
    /// path must start with a leading slash. path cannot have trailing slashes.
    /// If the file is not available in backendBucket or the load balancer cannot reach the BackendBucket, a simple Not Found Error is returned to the client.
    /// The value must be from 1 to 1024 characters
    /// </summary>
    public TerraformValue<string>? Path
    {
        get => GetArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

}

/// <summary>
/// Block type for header_action in GoogleComputeUrlMapPathMatcherBlockRouteRulesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockHeaderActionBlock : TerraformBlock
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
    public TerraformList<GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockHeaderActionBlockRequestHeadersToAddBlock>? RequestHeadersToAdd
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockHeaderActionBlockRequestHeadersToAddBlock>>("request_headers_to_add");
        set => SetArgument("request_headers_to_add", value);
    }

    /// <summary>
    /// ResponseHeadersToAdd block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockHeaderActionBlockResponseHeadersToAddBlock>? ResponseHeadersToAdd
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockHeaderActionBlockResponseHeadersToAddBlock>>("response_headers_to_add");
        set => SetArgument("response_headers_to_add", value);
    }

}

/// <summary>
/// Block type for request_headers_to_add in GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockHeaderActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockHeaderActionBlockRequestHeadersToAddBlock : TerraformBlock
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
/// Block type for response_headers_to_add in GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockHeaderActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockHeaderActionBlockResponseHeadersToAddBlock : TerraformBlock
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
/// Block type for match_rules in GoogleComputeUrlMapPathMatcherBlockRouteRulesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockMatchRulesBlock : TerraformBlock
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
    public TerraformList<GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockMatchRulesBlockHeaderMatchesBlock>? HeaderMatches
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockMatchRulesBlockHeaderMatchesBlock>>("header_matches");
        set => SetArgument("header_matches", value);
    }

    /// <summary>
    /// MetadataFilters block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockMatchRulesBlockMetadataFiltersBlock>? MetadataFilters
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockMatchRulesBlockMetadataFiltersBlock>>("metadata_filters");
        set => SetArgument("metadata_filters", value);
    }

    /// <summary>
    /// QueryParameterMatches block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockMatchRulesBlockQueryParameterMatchesBlock>? QueryParameterMatches
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockMatchRulesBlockQueryParameterMatchesBlock>>("query_parameter_matches");
        set => SetArgument("query_parameter_matches", value);
    }

}

/// <summary>
/// Block type for header_matches in GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockMatchRulesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockMatchRulesBlockHeaderMatchesBlock : TerraformBlock
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
    public TerraformList<GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockMatchRulesBlockHeaderMatchesBlockRangeMatchBlock>? RangeMatch
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockMatchRulesBlockHeaderMatchesBlockRangeMatchBlock>>("range_match");
        set => SetArgument("range_match", value);
    }

}

/// <summary>
/// Block type for range_match in GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockMatchRulesBlockHeaderMatchesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockMatchRulesBlockHeaderMatchesBlockRangeMatchBlock : TerraformBlock
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
/// Block type for metadata_filters in GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockMatchRulesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockMatchRulesBlockMetadataFiltersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "metadata_filters";

    /// <summary>
    /// Specifies how individual filterLabel matches within the list of filterLabels
    /// contribute towards the overall metadataFilter match. Supported values are:
    ///   - MATCH_ANY: At least one of the filterLabels must have a matching label in the
    /// provided metadata.
    ///   - MATCH_ALL: All filterLabels must have matching labels in
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
    public required TerraformList<GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockMatchRulesBlockMetadataFiltersBlockFilterLabelsBlock> FilterLabels
    {
        get => GetRequiredArgument<TerraformList<GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockMatchRulesBlockMetadataFiltersBlockFilterLabelsBlock>>("filter_labels");
        set => SetArgument("filter_labels", value);
    }

}

/// <summary>
/// Block type for filter_labels in GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockMatchRulesBlockMetadataFiltersBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockMatchRulesBlockMetadataFiltersBlockFilterLabelsBlock : TerraformBlock
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
/// Block type for query_parameter_matches in GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockMatchRulesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockMatchRulesBlockQueryParameterMatchesBlock : TerraformBlock
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
/// Block type for route_action in GoogleComputeUrlMapPathMatcherBlockRouteRulesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "route_action";

    /// <summary>
    /// CorsPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CorsPolicy block(s) allowed")]
    public TerraformList<GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockCorsPolicyBlock>? CorsPolicy
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockCorsPolicyBlock>>("cors_policy");
        set => SetArgument("cors_policy", value);
    }

    /// <summary>
    /// FaultInjectionPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FaultInjectionPolicy block(s) allowed")]
    public TerraformList<GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockFaultInjectionPolicyBlock>? FaultInjectionPolicy
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockFaultInjectionPolicyBlock>>("fault_injection_policy");
        set => SetArgument("fault_injection_policy", value);
    }

    /// <summary>
    /// MaxStreamDuration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaxStreamDuration block(s) allowed")]
    public TerraformList<GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockMaxStreamDurationBlock>? MaxStreamDuration
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockMaxStreamDurationBlock>>("max_stream_duration");
        set => SetArgument("max_stream_duration", value);
    }

    /// <summary>
    /// RequestMirrorPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RequestMirrorPolicy block(s) allowed")]
    public TerraformList<GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockRequestMirrorPolicyBlock>? RequestMirrorPolicy
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockRequestMirrorPolicyBlock>>("request_mirror_policy");
        set => SetArgument("request_mirror_policy", value);
    }

    /// <summary>
    /// RetryPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetryPolicy block(s) allowed")]
    public TerraformList<GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockRetryPolicyBlock>? RetryPolicy
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockRetryPolicyBlock>>("retry_policy");
        set => SetArgument("retry_policy", value);
    }

    /// <summary>
    /// Timeout block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Timeout block(s) allowed")]
    public TerraformList<GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockTimeoutBlock>? Timeout
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockTimeoutBlock>>("timeout");
        set => SetArgument("timeout", value);
    }

    /// <summary>
    /// UrlRewrite block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UrlRewrite block(s) allowed")]
    public TerraformList<GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockUrlRewriteBlock>? UrlRewrite
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockUrlRewriteBlock>>("url_rewrite");
        set => SetArgument("url_rewrite", value);
    }

    /// <summary>
    /// WeightedBackendServices block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockWeightedBackendServicesBlock>? WeightedBackendServices
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockWeightedBackendServicesBlock>>("weighted_backend_services");
        set => SetArgument("weighted_backend_services", value);
    }

}

/// <summary>
/// Block type for cors_policy in GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockCorsPolicyBlock : TerraformBlock
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
/// Block type for fault_injection_policy in GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockFaultInjectionPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "fault_injection_policy";

    /// <summary>
    /// Abort block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Abort block(s) allowed")]
    public TerraformList<GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockFaultInjectionPolicyBlockAbortBlock>? Abort
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockFaultInjectionPolicyBlockAbortBlock>>("abort");
        set => SetArgument("abort", value);
    }

    /// <summary>
    /// Delay block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Delay block(s) allowed")]
    public TerraformList<GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockFaultInjectionPolicyBlockDelayBlock>? Delay
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockFaultInjectionPolicyBlockDelayBlock>>("delay");
        set => SetArgument("delay", value);
    }

}

/// <summary>
/// Block type for abort in GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockFaultInjectionPolicyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockFaultInjectionPolicyBlockAbortBlock : TerraformBlock
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
/// Block type for delay in GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockFaultInjectionPolicyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockFaultInjectionPolicyBlockDelayBlock : TerraformBlock
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
    public TerraformList<GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockFaultInjectionPolicyBlockDelayBlockFixedDelayBlock>? FixedDelay
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockFaultInjectionPolicyBlockDelayBlockFixedDelayBlock>>("fixed_delay");
        set => SetArgument("fixed_delay", value);
    }

}

/// <summary>
/// Block type for fixed_delay in GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockFaultInjectionPolicyBlockDelayBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockFaultInjectionPolicyBlockDelayBlockFixedDelayBlock : TerraformBlock
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
/// Block type for max_stream_duration in GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockMaxStreamDurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "max_stream_duration";

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
/// Block type for request_mirror_policy in GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockRequestMirrorPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "request_mirror_policy";

    /// <summary>
    /// The BackendService resource being mirrored to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackendService is required")]
    public required TerraformValue<string> BackendService
    {
        get => GetRequiredArgument<TerraformValue<string>>("backend_service");
        set => SetArgument("backend_service", value);
    }

}

/// <summary>
/// Block type for retry_policy in GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockRetryPolicyBlock : TerraformBlock
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
    /// Specfies one or more conditions when this retry rule applies. Valid values are:
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
    public TerraformList<GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockRetryPolicyBlockPerTryTimeoutBlock>? PerTryTimeout
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockRetryPolicyBlockPerTryTimeoutBlock>>("per_try_timeout");
        set => SetArgument("per_try_timeout", value);
    }

}

/// <summary>
/// Block type for per_try_timeout in GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockRetryPolicyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockRetryPolicyBlockPerTryTimeoutBlock : TerraformBlock
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
/// Block type for timeout in GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockTimeoutBlock : TerraformBlock
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
/// Block type for url_rewrite in GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockUrlRewriteBlock : TerraformBlock
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
/// Block type for weighted_backend_services in GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockWeightedBackendServicesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "weighted_backend_services";

    /// <summary>
    /// The default BackendService resource. Before
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
    public TerraformList<GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockWeightedBackendServicesBlockHeaderActionBlock>? HeaderAction
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockWeightedBackendServicesBlockHeaderActionBlock>>("header_action");
        set => SetArgument("header_action", value);
    }

}

/// <summary>
/// Block type for header_action in GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockWeightedBackendServicesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockWeightedBackendServicesBlockHeaderActionBlock : TerraformBlock
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
    public TerraformList<GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockWeightedBackendServicesBlockHeaderActionBlockRequestHeadersToAddBlock>? RequestHeadersToAdd
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockWeightedBackendServicesBlockHeaderActionBlockRequestHeadersToAddBlock>>("request_headers_to_add");
        set => SetArgument("request_headers_to_add", value);
    }

    /// <summary>
    /// ResponseHeadersToAdd block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockWeightedBackendServicesBlockHeaderActionBlockResponseHeadersToAddBlock>? ResponseHeadersToAdd
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockWeightedBackendServicesBlockHeaderActionBlockResponseHeadersToAddBlock>>("response_headers_to_add");
        set => SetArgument("response_headers_to_add", value);
    }

}

/// <summary>
/// Block type for request_headers_to_add in GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockWeightedBackendServicesBlockHeaderActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockWeightedBackendServicesBlockHeaderActionBlockRequestHeadersToAddBlock : TerraformBlock
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
/// Block type for response_headers_to_add in GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockWeightedBackendServicesBlockHeaderActionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockRouteActionBlockWeightedBackendServicesBlockHeaderActionBlockResponseHeadersToAddBlock : TerraformBlock
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
/// Block type for url_redirect in GoogleComputeUrlMapPathMatcherBlockRouteRulesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapPathMatcherBlockRouteRulesBlockUrlRedirectBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "url_redirect";

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
    /// If set to true, the URL scheme in the redirected request is set to https. If set
    /// to false, the URL scheme of the redirected request will remain the same as that
    /// of the request. This must only be set for UrlMaps used in TargetHttpProxys.
    /// Setting this true for TargetHttpsProxy is not permitted. Defaults to false.
    /// </summary>
    public TerraformValue<bool>? HttpsRedirect
    {
        get => GetArgument<TerraformValue<bool>>("https_redirect");
        set => SetArgument("https_redirect", value);
    }

    /// <summary>
    /// The path that will be used in the redirect response instead of the one that was
    /// supplied in the request. Only one of pathRedirect or prefixRedirect must be
    /// specified. The value must be between 1 and 1024 characters.
    /// </summary>
    public TerraformValue<string>? PathRedirect
    {
        get => GetArgument<TerraformValue<string>>("path_redirect");
        set => SetArgument("path_redirect", value);
    }

    /// <summary>
    /// The prefix that replaces the prefixMatch specified in the HttpRouteRuleMatch,
    /// retaining the remaining portion of the URL before redirecting the request.
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
    /// * TEMPORARY_REDIRECT, which corresponds to 307. In this case, the request method will be retained.
    /// 
    /// * PERMANENT_REDIRECT, which corresponds to 308. In this case, the request method will be retained. Possible values: [&amp;quot;FOUND&amp;quot;, &amp;quot;MOVED_PERMANENTLY_DEFAULT&amp;quot;, &amp;quot;PERMANENT_REDIRECT&amp;quot;, &amp;quot;SEE_OTHER&amp;quot;, &amp;quot;TEMPORARY_REDIRECT&amp;quot;]
    /// </summary>
    public TerraformValue<string>? RedirectResponseCode
    {
        get => GetArgument<TerraformValue<string>>("redirect_response_code");
        set => SetArgument("redirect_response_code", value);
    }

    /// <summary>
    /// If set to true, any accompanying query portion of the original URL is removed
    /// prior to redirecting the request. If set to false, the query portion of the
    /// original URL is retained. Defaults to false.
    /// </summary>
    public TerraformValue<bool>? StripQuery
    {
        get => GetArgument<TerraformValue<bool>>("strip_query");
        set => SetArgument("strip_query", value);
    }

}


/// <summary>
/// Block type for test in GoogleComputeUrlMap.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapTestBlock : TerraformBlock
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
    /// The expected output URL evaluated by the load balancer containing the scheme, host, path and query parameters.
    /// 
    /// For rules that forward requests to backends, the test passes only when expectedOutputUrl matches the request forwarded by the load balancer to backends. For rules with urlRewrite, the test verifies that the forwarded request matches hostRewrite and pathPrefixRewrite in the urlRewrite action. When service is specified, expectedOutputUrl&#39;s scheme is ignored.
    /// 
    /// For rules with urlRedirect, the test passes only if expectedOutputUrl matches the URL in the load balancer&#39;s redirect response. If urlRedirect specifies httpsRedirect, the test passes only if the scheme in expectedOutputUrl is also set to HTTPS. If urlRedirect specifies stripQuery, the test passes only if expectedOutputUrl does not contain any query parameters.
    /// 
    /// expectedOutputUrl is optional when service is specified.
    /// </summary>
    public TerraformValue<string>? ExpectedOutputUrl
    {
        get => GetArgument<TerraformValue<string>>("expected_output_url");
        set => SetArgument("expected_output_url", value);
    }

    /// <summary>
    /// For rules with urlRedirect, the test passes only if expectedRedirectResponseCode matches the HTTP status code in load balancer&#39;s redirect response.
    /// 
    /// expectedRedirectResponseCode cannot be set when service is set.
    /// </summary>
    public TerraformValue<double>? ExpectedRedirectResponseCode
    {
        get => GetArgument<TerraformValue<double>>("expected_redirect_response_code");
        set => SetArgument("expected_redirect_response_code", value);
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
    /// The backend service or backend bucket link that should be matched by this test.
    /// </summary>
    public TerraformValue<string>? Service
    {
        get => GetArgument<TerraformValue<string>>("service");
        set => SetArgument("service", value);
    }

    /// <summary>
    /// Headers block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeUrlMapTestBlockHeadersBlock>? Headers
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapTestBlockHeadersBlock>>("headers");
        set => SetArgument("headers", value);
    }

}

/// <summary>
/// Block type for headers in GoogleComputeUrlMapTestBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeUrlMapTestBlockHeadersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "headers";

    /// <summary>
    /// Header name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Header value.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleComputeUrlMap.
/// Nesting mode: single
/// </summary>
public class GoogleComputeUrlMapTimeoutsBlock : TerraformBlock
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
/// Represents a google_compute_url_map Terraform resource.
/// Manages a google_compute_url_map resource.
/// </summary>
public partial class GoogleComputeUrlMap(string name) : TerraformResource("google_compute_url_map", name)
{
    /// <summary>
    /// The backend service or backend bucket to use when none of the given rules match.
    /// </summary>
    public TerraformValue<string>? DefaultService
    {
        get => GetArgument<TerraformValue<string>>("default_service");
        set => SetArgument("default_service", value);
    }

    /// <summary>
    /// An optional description of this resource. Provide this property when you create
    /// the resource.
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
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Name of the resource. Provided by the client when the resource is created. The
    /// name must be 1-63 characters long, and comply with RFC1035. Specifically, the
    /// name must be 1-63 characters long and match the regular expression
    /// &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39; which means the first character must be a lowercase
    /// letter, and all following characters must be a dash, lowercase letter, or digit,
    /// except the last character, which cannot be a dash.
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
        get => GetArgument<TerraformValue<string>>("project") ?? CreateReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformValue<string> CreationTimestamp
        => CreateReference("creation_timestamp");

    /// <summary>
    /// Fingerprint of this resource. A hash of the contents stored in this object. This
    /// field is used in optimistic locking.
    /// </summary>
    public TerraformValue<string> Fingerprint
        => CreateReference("fingerprint");

    /// <summary>
    /// The unique identifier for the resource.
    /// </summary>
    public TerraformValue<double> MapId
        => CreateReference("map_id");

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformValue<string> SelfLink
        => CreateReference("self_link");

    /// <summary>
    /// DefaultCustomErrorResponsePolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultCustomErrorResponsePolicy block(s) allowed")]
    public TerraformList<GoogleComputeUrlMapDefaultCustomErrorResponsePolicyBlock>? DefaultCustomErrorResponsePolicy
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapDefaultCustomErrorResponsePolicyBlock>>("default_custom_error_response_policy");
        set => SetArgument("default_custom_error_response_policy", value);
    }

    /// <summary>
    /// DefaultRouteAction block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultRouteAction block(s) allowed")]
    public TerraformList<GoogleComputeUrlMapDefaultRouteActionBlock>? DefaultRouteAction
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapDefaultRouteActionBlock>>("default_route_action");
        set => SetArgument("default_route_action", value);
    }

    /// <summary>
    /// DefaultUrlRedirect block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultUrlRedirect block(s) allowed")]
    public TerraformList<GoogleComputeUrlMapDefaultUrlRedirectBlock>? DefaultUrlRedirect
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapDefaultUrlRedirectBlock>>("default_url_redirect");
        set => SetArgument("default_url_redirect", value);
    }

    /// <summary>
    /// HeaderAction block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HeaderAction block(s) allowed")]
    public TerraformList<GoogleComputeUrlMapHeaderActionBlock>? HeaderAction
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapHeaderActionBlock>>("header_action");
        set => SetArgument("header_action", value);
    }

    /// <summary>
    /// HostRule block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleComputeUrlMapHostRuleBlock>? HostRule
    {
        get => GetArgument<TerraformSet<GoogleComputeUrlMapHostRuleBlock>>("host_rule");
        set => SetArgument("host_rule", value);
    }

    /// <summary>
    /// PathMatcher block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeUrlMapPathMatcherBlock>? PathMatcher
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapPathMatcherBlock>>("path_matcher");
        set => SetArgument("path_matcher", value);
    }

    /// <summary>
    /// Test block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeUrlMapTestBlock>? Test
    {
        get => GetArgument<TerraformList<GoogleComputeUrlMapTestBlock>>("test");
        set => SetArgument("test", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleComputeUrlMapTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleComputeUrlMapTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
