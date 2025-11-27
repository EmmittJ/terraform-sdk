using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for backend in GoogleComputeBackendService.
/// Nesting mode: set
/// </summary>
public class GoogleComputeBackendServiceBackendBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "backend";

    /// <summary>
    /// Specifies the balancing mode for this backend.
    /// 
    /// For global HTTP(S) or TCP/SSL load balancing, the default is
    /// UTILIZATION. Valid values are UTILIZATION, RATE (for HTTP(S)),
    /// CUSTOM_METRICS (for HTTP(s)) and CONNECTION (for TCP/SSL).
    /// 
    /// See the [Backend Services Overview](https://cloud.google.com/load-balancing/docs/backend-service#balancing-mode)
    /// for an explanation of load balancing modes. Default value: &amp;quot;UTILIZATION&amp;quot; Possible values: [&amp;quot;UTILIZATION&amp;quot;, &amp;quot;RATE&amp;quot;, &amp;quot;CONNECTION&amp;quot;, &amp;quot;CUSTOM_METRICS&amp;quot;, &amp;quot;IN_FLIGHT&amp;quot;]
    /// </summary>
    public TerraformValue<string>? BalancingMode
    {
        get => new TerraformReference<string>(this, "balancing_mode");
        set => SetArgument("balancing_mode", value);
    }

    /// <summary>
    /// A multiplier applied to the group&#39;s maximum servicing capacity
    /// (based on UTILIZATION, RATE or CONNECTION).
    /// 
    /// Default value is 1, which means the group will serve up to 100%
    /// of its configured capacity (depending on balancingMode). A
    /// setting of 0 means the group is completely drained, offering
    /// 0% of its available Capacity. Valid range is [0.0,1.0].
    /// </summary>
    public TerraformValue<double>? CapacityScaler
    {
        get => new TerraformReference<double>(this, "capacity_scaler");
        set => SetArgument("capacity_scaler", value);
    }

    /// <summary>
    /// An optional description of this resource.
    /// Provide this property when you create the resource.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The fully-qualified URL of an Instance Group or Network Endpoint
    /// Group resource. In case of instance group this defines the list
    /// of instances that serve traffic. Member virtual machine
    /// instances from each instance group must live in the same zone as
    /// the instance group itself. No two backends in a backend service
    /// are allowed to use same Instance Group resource.
    /// 
    /// For Network Endpoint Groups this defines list of endpoints. All
    /// endpoints of Network Endpoint Group must be hosted on instances
    /// located in the same zone as the Network Endpoint Group.
    /// 
    /// Backend services cannot mix Instance Group and
    /// Network Endpoint Group backends.
    /// 
    /// Note that you must specify an Instance Group or Network Endpoint
    /// Group resource using the fully-qualified URL, rather than a
    /// partial URL.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Group is required")]
    public required TerraformValue<string> Group
    {
        get => new TerraformReference<string>(this, "group");
        set => SetArgument("group", value);
    }

    /// <summary>
    /// The max number of simultaneous connections for the group. Can
    /// be used with either CONNECTION or UTILIZATION balancing modes.
    /// 
    /// For CONNECTION mode, either maxConnections or one
    /// of maxConnectionsPerInstance or maxConnectionsPerEndpoint,
    /// as appropriate for group type, must be set.
    /// </summary>
    public TerraformValue<double> MaxConnections
    {
        get => new TerraformReference<double>(this, "max_connections");
        set => SetArgument("max_connections", value);
    }

    /// <summary>
    /// The max number of simultaneous connections that a single backend
    /// network endpoint can handle. This is used to calculate the
    /// capacity of the group. Can be used in either CONNECTION or
    /// UTILIZATION balancing modes.
    /// 
    /// For CONNECTION mode, either
    /// maxConnections or maxConnectionsPerEndpoint must be set.
    /// </summary>
    public TerraformValue<double> MaxConnectionsPerEndpoint
    {
        get => new TerraformReference<double>(this, "max_connections_per_endpoint");
        set => SetArgument("max_connections_per_endpoint", value);
    }

    /// <summary>
    /// The max number of simultaneous connections that a single
    /// backend instance can handle. This is used to calculate the
    /// capacity of the group. Can be used in either CONNECTION or
    /// UTILIZATION balancing modes.
    /// 
    /// For CONNECTION mode, either maxConnections or
    /// maxConnectionsPerInstance must be set.
    /// </summary>
    public TerraformValue<double> MaxConnectionsPerInstance
    {
        get => new TerraformReference<double>(this, "max_connections_per_instance");
        set => SetArgument("max_connections_per_instance", value);
    }

    /// <summary>
    /// The max requests per second (RPS) of the group.
    /// 
    /// Can be used with either RATE or UTILIZATION balancing modes,
    /// but required if RATE mode. For RATE mode, either maxRate or one
    /// of maxRatePerInstance or maxRatePerEndpoint, as appropriate for
    /// group type, must be set.
    /// </summary>
    public TerraformValue<double> MaxRate
    {
        get => new TerraformReference<double>(this, "max_rate");
        set => SetArgument("max_rate", value);
    }

    /// <summary>
    /// The max requests per second (RPS) that a single backend network
    /// endpoint can handle. This is used to calculate the capacity of
    /// the group. Can be used in either balancing mode. For RATE mode,
    /// either maxRate or maxRatePerEndpoint must be set.
    /// </summary>
    public TerraformValue<double> MaxRatePerEndpoint
    {
        get => new TerraformReference<double>(this, "max_rate_per_endpoint");
        set => SetArgument("max_rate_per_endpoint", value);
    }

    /// <summary>
    /// The max requests per second (RPS) that a single backend
    /// instance can handle. This is used to calculate the capacity of
    /// the group. Can be used in either balancing mode. For RATE mode,
    /// either maxRate or maxRatePerInstance must be set.
    /// </summary>
    public TerraformValue<double> MaxRatePerInstance
    {
        get => new TerraformReference<double>(this, "max_rate_per_instance");
        set => SetArgument("max_rate_per_instance", value);
    }

    /// <summary>
    /// Used when balancingMode is UTILIZATION. This ratio defines the
    /// CPU utilization target for the group. Valid range is [0.0, 1.0].
    /// </summary>
    public TerraformValue<double> MaxUtilization
    {
        get => new TerraformReference<double>(this, "max_utilization");
        set => SetArgument("max_utilization", value);
    }

    /// <summary>
    /// This field indicates whether this backend should be fully utilized before sending traffic to backends
    /// with default preference. This field cannot be set when loadBalancingScheme is set to &#39;EXTERNAL&#39;. The possible values are:
    ///   - PREFERRED: Backends with this preference level will be filled up to their capacity limits first,
    ///     based on RTT.
    ///   - DEFAULT: If preferred backends don&#39;t have enough capacity, backends in this layer would be used and
    ///     traffic would be assigned based on the load balancing algorithm you use. This is the default Possible values: [&amp;quot;PREFERRED&amp;quot;, &amp;quot;DEFAULT&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Preference
    {
        get => new TerraformReference<string>(this, "preference");
        set => SetArgument("preference", value);
    }

    /// <summary>
    /// CustomMetrics block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeBackendServiceBackendBlockCustomMetricsBlock>? CustomMetrics
    {
        get => GetArgument<TerraformList<GoogleComputeBackendServiceBackendBlockCustomMetricsBlock>>("custom_metrics");
        set => SetArgument("custom_metrics", value);
    }

}

/// <summary>
/// Block type for custom_metrics in GoogleComputeBackendServiceBackendBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeBackendServiceBackendBlockCustomMetricsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_metrics";

    /// <summary>
    /// If true, the metric data is collected and reported to Cloud
    /// Monitoring, but is not used for load balancing.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DryRun is required")]
    public required TerraformValue<bool> DryRun
    {
        get => new TerraformReference<bool>(this, "dry_run");
        set => SetArgument("dry_run", value);
    }

    /// <summary>
    /// Optional parameter to define a target utilization for the Custom Metrics
    /// balancing mode. The valid range is &amp;lt;code&amp;gt;[0.0, 1.0]&amp;lt;/code&amp;gt;.
    /// </summary>
    public TerraformValue<double>? MaxUtilization
    {
        get => new TerraformReference<double>(this, "max_utilization");
        set => SetArgument("max_utilization", value);
    }

    /// <summary>
    /// Name of a custom utilization signal. The name must be 1-64 characters
    /// long and match the regular expression [a-z]([-_.a-z0-9]*[a-z0-9])? which
    /// means the first character must be a lowercase letter, and all following
    /// characters must be a dash, period, underscore, lowercase letter, or
    /// digit, except the last character, which cannot be a dash, period, or
    /// underscore. For usage guidelines, see Custom Metrics balancing mode. This
    /// field can only be used for a global or regional backend service with the
    /// loadBalancingScheme set to &amp;lt;code&amp;gt;EXTERNAL_MANAGED&amp;lt;/code&amp;gt;,
    /// &amp;lt;code&amp;gt;INTERNAL_MANAGED&amp;lt;/code&amp;gt; &amp;lt;code&amp;gt;INTERNAL_SELF_MANAGED&amp;lt;/code&amp;gt;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

}


/// <summary>
/// Block type for cdn_policy in GoogleComputeBackendService.
/// Nesting mode: list
/// </summary>
public class GoogleComputeBackendServiceCdnPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cdn_policy";

    /// <summary>
    /// Specifies the cache setting for all responses from this backend.
    /// The possible values are: USE_ORIGIN_HEADERS, FORCE_CACHE_ALL and CACHE_ALL_STATIC Possible values: [&amp;quot;USE_ORIGIN_HEADERS&amp;quot;, &amp;quot;FORCE_CACHE_ALL&amp;quot;, &amp;quot;CACHE_ALL_STATIC&amp;quot;]
    /// </summary>
    public TerraformValue<string> CacheMode
    {
        get => new TerraformReference<string>(this, "cache_mode");
        set => SetArgument("cache_mode", value);
    }

    /// <summary>
    /// Specifies the maximum allowed TTL for cached content served by this origin.
    /// </summary>
    public TerraformValue<double> ClientTtl
    {
        get => new TerraformReference<double>(this, "client_ttl");
        set => SetArgument("client_ttl", value);
    }

    /// <summary>
    /// Specifies the default TTL for cached content served by this origin for responses
    /// that do not have an existing valid TTL (max-age or s-max-age).
    /// </summary>
    public TerraformValue<double> DefaultTtl
    {
        get => new TerraformReference<double>(this, "default_ttl");
        set => SetArgument("default_ttl", value);
    }

    /// <summary>
    /// Specifies the maximum allowed TTL for cached content served by this origin.
    /// </summary>
    public TerraformValue<double> MaxTtl
    {
        get => new TerraformReference<double>(this, "max_ttl");
        set => SetArgument("max_ttl", value);
    }

    /// <summary>
    /// Negative caching allows per-status code TTLs to be set, in order to apply fine-grained caching for common errors or redirects.
    /// </summary>
    public TerraformValue<bool> NegativeCaching
    {
        get => new TerraformReference<bool>(this, "negative_caching");
        set => SetArgument("negative_caching", value);
    }

    /// <summary>
    /// If true then Cloud CDN will combine multiple concurrent cache fill requests into a small number of requests
    /// to the origin.
    /// </summary>
    public TerraformValue<bool> RequestCoalescing
    {
        get => new TerraformReference<bool>(this, "request_coalescing");
        set => SetArgument("request_coalescing", value);
    }

    /// <summary>
    /// Serve existing content from the cache (if available) when revalidating content with the origin, or when an error is encountered when refreshing the cache.
    /// </summary>
    public TerraformValue<double> ServeWhileStale
    {
        get => new TerraformReference<double>(this, "serve_while_stale");
        set => SetArgument("serve_while_stale", value);
    }

    /// <summary>
    /// Maximum number of seconds the response to a signed URL request
    /// will be considered fresh, defaults to 1hr (3600s). After this
    /// time period, the response will be revalidated before
    /// being served.
    /// 
    /// When serving responses to signed URL requests, Cloud CDN will
    /// internally behave as though all responses from this backend had a
    /// &amp;quot;Cache-Control: public, max-age=[TTL]&amp;quot; header, regardless of any
    /// existing Cache-Control header. The actual headers served in
    /// responses will not be altered.
    /// </summary>
    public TerraformValue<double>? SignedUrlCacheMaxAgeSec
    {
        get => new TerraformReference<double>(this, "signed_url_cache_max_age_sec");
        set => SetArgument("signed_url_cache_max_age_sec", value);
    }

    /// <summary>
    /// BypassCacheOnRequestHeaders block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeBackendServiceCdnPolicyBlockBypassCacheOnRequestHeadersBlock>? BypassCacheOnRequestHeaders
    {
        get => GetArgument<TerraformList<GoogleComputeBackendServiceCdnPolicyBlockBypassCacheOnRequestHeadersBlock>>("bypass_cache_on_request_headers");
        set => SetArgument("bypass_cache_on_request_headers", value);
    }

    /// <summary>
    /// CacheKeyPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CacheKeyPolicy block(s) allowed")]
    public TerraformList<GoogleComputeBackendServiceCdnPolicyBlockCacheKeyPolicyBlock>? CacheKeyPolicy
    {
        get => GetArgument<TerraformList<GoogleComputeBackendServiceCdnPolicyBlockCacheKeyPolicyBlock>>("cache_key_policy");
        set => SetArgument("cache_key_policy", value);
    }

    /// <summary>
    /// NegativeCachingPolicy block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeBackendServiceCdnPolicyBlockNegativeCachingPolicyBlock>? NegativeCachingPolicy
    {
        get => GetArgument<TerraformList<GoogleComputeBackendServiceCdnPolicyBlockNegativeCachingPolicyBlock>>("negative_caching_policy");
        set => SetArgument("negative_caching_policy", value);
    }

}

/// <summary>
/// Block type for bypass_cache_on_request_headers in GoogleComputeBackendServiceCdnPolicyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeBackendServiceCdnPolicyBlockBypassCacheOnRequestHeadersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "bypass_cache_on_request_headers";

    /// <summary>
    /// The header field name to match on when bypassing cache. Values are case-insensitive.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HeaderName is required")]
    public required TerraformValue<string> HeaderName
    {
        get => new TerraformReference<string>(this, "header_name");
        set => SetArgument("header_name", value);
    }

}

/// <summary>
/// Block type for cache_key_policy in GoogleComputeBackendServiceCdnPolicyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeBackendServiceCdnPolicyBlockCacheKeyPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cache_key_policy";

    /// <summary>
    /// If true requests to different hosts will be cached separately.
    /// </summary>
    public TerraformValue<bool>? IncludeHost
    {
        get => new TerraformReference<bool>(this, "include_host");
        set => SetArgument("include_host", value);
    }

    /// <summary>
    /// Allows HTTP request headers (by name) to be used in the
    /// cache key.
    /// </summary>
    public TerraformList<string>? IncludeHttpHeaders
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "include_http_headers").ResolveNodes(ctx));
        set => SetArgument("include_http_headers", value);
    }

    /// <summary>
    /// Names of cookies to include in cache keys.
    /// </summary>
    public TerraformList<string>? IncludeNamedCookies
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "include_named_cookies").ResolveNodes(ctx));
        set => SetArgument("include_named_cookies", value);
    }

    /// <summary>
    /// If true, http and https requests will be cached separately.
    /// </summary>
    public TerraformValue<bool>? IncludeProtocol
    {
        get => new TerraformReference<bool>(this, "include_protocol");
        set => SetArgument("include_protocol", value);
    }

    /// <summary>
    /// If true, include query string parameters in the cache key
    /// according to query_string_whitelist and
    /// query_string_blacklist. If neither is set, the entire query
    /// string will be included.
    /// 
    /// If false, the query string will be excluded from the cache
    /// key entirely.
    /// </summary>
    public TerraformValue<bool>? IncludeQueryString
    {
        get => new TerraformReference<bool>(this, "include_query_string");
        set => SetArgument("include_query_string", value);
    }

    /// <summary>
    /// Names of query string parameters to exclude in cache keys.
    /// 
    /// All other parameters will be included. Either specify
    /// query_string_whitelist or query_string_blacklist, not both.
    /// &#39;&amp;amp;&#39; and &#39;=&#39; will be percent encoded and not treated as
    /// delimiters.
    /// </summary>
    public TerraformSet<string>? QueryStringBlacklist
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "query_string_blacklist").ResolveNodes(ctx));
        set => SetArgument("query_string_blacklist", value);
    }

    /// <summary>
    /// Names of query string parameters to include in cache keys.
    /// 
    /// All other parameters will be excluded. Either specify
    /// query_string_whitelist or query_string_blacklist, not both.
    /// &#39;&amp;amp;&#39; and &#39;=&#39; will be percent encoded and not treated as
    /// delimiters.
    /// </summary>
    public TerraformSet<string>? QueryStringWhitelist
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "query_string_whitelist").ResolveNodes(ctx));
        set => SetArgument("query_string_whitelist", value);
    }

}

/// <summary>
/// Block type for negative_caching_policy in GoogleComputeBackendServiceCdnPolicyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeBackendServiceCdnPolicyBlockNegativeCachingPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "negative_caching_policy";

    /// <summary>
    /// The HTTP status code to define a TTL against. Only HTTP status codes 300, 301, 308, 404, 405, 410, 421, 451 and 501
    /// can be specified as values, and you cannot specify a status code more than once.
    /// </summary>
    public TerraformValue<double>? Code
    {
        get => new TerraformReference<double>(this, "code");
        set => SetArgument("code", value);
    }

    /// <summary>
    /// The TTL (in seconds) for which to cache responses with the corresponding status code. The maximum allowed value is 1800s
    /// (30 minutes), noting that infrequently accessed objects may be evicted from the cache before the defined TTL.
    /// </summary>
    public TerraformValue<double>? Ttl
    {
        get => new TerraformReference<double>(this, "ttl");
        set => SetArgument("ttl", value);
    }

}


/// <summary>
/// Block type for circuit_breakers in GoogleComputeBackendService.
/// Nesting mode: list
/// </summary>
public class GoogleComputeBackendServiceCircuitBreakersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "circuit_breakers";

    /// <summary>
    /// The maximum number of connections to the backend cluster.
    /// Defaults to 1024.
    /// </summary>
    public TerraformValue<double>? MaxConnections
    {
        get => new TerraformReference<double>(this, "max_connections");
        set => SetArgument("max_connections", value);
    }

    /// <summary>
    /// The maximum number of pending requests to the backend cluster.
    /// Defaults to 1024.
    /// </summary>
    public TerraformValue<double>? MaxPendingRequests
    {
        get => new TerraformReference<double>(this, "max_pending_requests");
        set => SetArgument("max_pending_requests", value);
    }

    /// <summary>
    /// The maximum number of parallel requests to the backend cluster.
    /// Defaults to 1024.
    /// </summary>
    public TerraformValue<double>? MaxRequests
    {
        get => new TerraformReference<double>(this, "max_requests");
        set => SetArgument("max_requests", value);
    }

    /// <summary>
    /// Maximum requests for a single backend connection. This parameter
    /// is respected by both the HTTP/1.1 and HTTP/2 implementations. If
    /// not specified, there is no limit. Setting this parameter to 1
    /// will effectively disable keep alive.
    /// </summary>
    public TerraformValue<double>? MaxRequestsPerConnection
    {
        get => new TerraformReference<double>(this, "max_requests_per_connection");
        set => SetArgument("max_requests_per_connection", value);
    }

    /// <summary>
    /// The maximum number of parallel retries to the backend cluster.
    /// Defaults to 3.
    /// </summary>
    public TerraformValue<double>? MaxRetries
    {
        get => new TerraformReference<double>(this, "max_retries");
        set => SetArgument("max_retries", value);
    }

}


/// <summary>
/// Block type for consistent_hash in GoogleComputeBackendService.
/// Nesting mode: list
/// </summary>
public class GoogleComputeBackendServiceConsistentHashBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "consistent_hash";

    /// <summary>
    /// The hash based on the value of the specified header field.
    /// This field is applicable if the sessionAffinity is set to HEADER_FIELD.
    /// </summary>
    public TerraformValue<string>? HttpHeaderName
    {
        get => new TerraformReference<string>(this, "http_header_name");
        set => SetArgument("http_header_name", value);
    }

    /// <summary>
    /// The minimum number of virtual nodes to use for the hash ring.
    /// Larger ring sizes result in more granular load
    /// distributions. If the number of hosts in the load balancing pool
    /// is larger than the ring size, each host will be assigned a single
    /// virtual node.
    /// Defaults to 1024.
    /// </summary>
    public TerraformValue<double>? MinimumRingSize
    {
        get => new TerraformReference<double>(this, "minimum_ring_size");
        set => SetArgument("minimum_ring_size", value);
    }

    /// <summary>
    /// HttpCookie block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HttpCookie block(s) allowed")]
    public TerraformList<GoogleComputeBackendServiceConsistentHashBlockHttpCookieBlock>? HttpCookie
    {
        get => GetArgument<TerraformList<GoogleComputeBackendServiceConsistentHashBlockHttpCookieBlock>>("http_cookie");
        set => SetArgument("http_cookie", value);
    }

}

/// <summary>
/// Block type for http_cookie in GoogleComputeBackendServiceConsistentHashBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeBackendServiceConsistentHashBlockHttpCookieBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "http_cookie";

    /// <summary>
    /// Name of the cookie.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Path to set for the cookie.
    /// </summary>
    public TerraformValue<string>? Path
    {
        get => new TerraformReference<string>(this, "path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// Ttl block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Ttl block(s) allowed")]
    public TerraformList<GoogleComputeBackendServiceConsistentHashBlockHttpCookieBlockTtlBlock>? Ttl
    {
        get => GetArgument<TerraformList<GoogleComputeBackendServiceConsistentHashBlockHttpCookieBlockTtlBlock>>("ttl");
        set => SetArgument("ttl", value);
    }

}

/// <summary>
/// Block type for ttl in GoogleComputeBackendServiceConsistentHashBlockHttpCookieBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeBackendServiceConsistentHashBlockHttpCookieBlockTtlBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ttl";

    /// <summary>
    /// Span of time that&#39;s a fraction of a second at nanosecond
    /// resolution. Durations less than one second are represented
    /// with a 0 seconds field and a positive nanos field. Must
    /// be from 0 to 999,999,999 inclusive.
    /// </summary>
    public TerraformValue<double>? Nanos
    {
        get => new TerraformReference<double>(this, "nanos");
        set => SetArgument("nanos", value);
    }

    /// <summary>
    /// Span of time at a resolution of a second.
    /// Must be from 0 to 315,576,000,000 inclusive.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Seconds is required")]
    public required TerraformValue<double> Seconds
    {
        get => new TerraformReference<double>(this, "seconds");
        set => SetArgument("seconds", value);
    }

}


/// <summary>
/// Block type for custom_metrics in GoogleComputeBackendService.
/// Nesting mode: list
/// </summary>
public class GoogleComputeBackendServiceCustomMetricsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_metrics";

    /// <summary>
    /// If true, the metric data is not used for load balancing.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DryRun is required")]
    public required TerraformValue<bool> DryRun
    {
        get => new TerraformReference<bool>(this, "dry_run");
        set => SetArgument("dry_run", value);
    }

    /// <summary>
    /// Name of a custom utilization signal. The name must be 1-64 characters
    /// long and match the regular expression [a-z]([-_.a-z0-9]*[a-z0-9])? which
    /// means the first character must be a lowercase letter, and all following
    /// characters must be a dash, period, underscore, lowercase letter, or
    /// digit, except the last character, which cannot be a dash, period, or
    /// underscore. For usage guidelines, see Custom Metrics balancing mode. This
    /// field can only be used for a global or regional backend service with the
    /// loadBalancingScheme set to &amp;lt;code&amp;gt;EXTERNAL_MANAGED&amp;lt;/code&amp;gt;,
    /// &amp;lt;code&amp;gt;INTERNAL_MANAGED&amp;lt;/code&amp;gt; &amp;lt;code&amp;gt;INTERNAL_SELF_MANAGED&amp;lt;/code&amp;gt;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

}


/// <summary>
/// Block type for iap in GoogleComputeBackendService.
/// Nesting mode: list
/// </summary>
public class GoogleComputeBackendServiceIapBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "iap";

    /// <summary>
    /// Whether the serving infrastructure will authenticate and authorize all incoming requests.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// OAuth2 Client ID for IAP
    /// </summary>
    public TerraformValue<string>? Oauth2ClientId
    {
        get => new TerraformReference<string>(this, "oauth2_client_id");
        set => SetArgument("oauth2_client_id", value);
    }

    /// <summary>
    /// OAuth2 Client Secret for IAP
    /// </summary>
    public TerraformValue<string>? Oauth2ClientSecret
    {
        get => new TerraformReference<string>(this, "oauth2_client_secret");
        set => SetArgument("oauth2_client_secret", value);
    }

    /// <summary>
    /// OAuth2 Client Secret SHA-256 for IAP
    /// </summary>
    public TerraformValue<string> Oauth2ClientSecretSha256
    {
        get => new TerraformReference<string>(this, "oauth2_client_secret_sha256");
    }

}


/// <summary>
/// Block type for locality_lb_policies in GoogleComputeBackendService.
/// Nesting mode: list
/// </summary>
public class GoogleComputeBackendServiceLocalityLbPoliciesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "locality_lb_policies";

    /// <summary>
    /// CustomPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomPolicy block(s) allowed")]
    public TerraformList<GoogleComputeBackendServiceLocalityLbPoliciesBlockCustomPolicyBlock>? CustomPolicy
    {
        get => GetArgument<TerraformList<GoogleComputeBackendServiceLocalityLbPoliciesBlockCustomPolicyBlock>>("custom_policy");
        set => SetArgument("custom_policy", value);
    }

    /// <summary>
    /// Policy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Policy block(s) allowed")]
    public TerraformList<GoogleComputeBackendServiceLocalityLbPoliciesBlockPolicyBlock>? Policy
    {
        get => GetArgument<TerraformList<GoogleComputeBackendServiceLocalityLbPoliciesBlockPolicyBlock>>("policy");
        set => SetArgument("policy", value);
    }

}

/// <summary>
/// Block type for custom_policy in GoogleComputeBackendServiceLocalityLbPoliciesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeBackendServiceLocalityLbPoliciesBlockCustomPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_policy";

    /// <summary>
    /// An optional, arbitrary JSON object with configuration data, understood
    /// by a locally installed custom policy implementation.
    /// </summary>
    public TerraformValue<string>? Data
    {
        get => new TerraformReference<string>(this, "data");
        set => SetArgument("data", value);
    }

    /// <summary>
    /// Identifies the custom policy.
    /// 
    /// The value should match the type the custom implementation is registered
    /// with on the gRPC clients. It should follow protocol buffer
    /// message naming conventions and include the full path (e.g.
    /// myorg.CustomLbPolicy). The maximum length is 256 characters.
    /// 
    /// Note that specifying the same custom policy more than once for a
    /// backend is not a valid configuration and will be rejected.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for policy in GoogleComputeBackendServiceLocalityLbPoliciesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeBackendServiceLocalityLbPoliciesBlockPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "policy";

    /// <summary>
    /// The name of a locality load balancer policy to be used. The value
    /// should be one of the predefined ones as supported by localityLbPolicy,
    /// although at the moment only ROUND_ROBIN is supported.
    /// 
    /// This field should only be populated when the customPolicy field is not
    /// used.
    /// 
    /// Note that specifying the same policy more than once for a backend is
    /// not a valid configuration and will be rejected.
    /// 
    /// The possible values are:
    /// 
    /// * &#39;ROUND_ROBIN&#39;: This is a simple policy in which each healthy backend
    ///                 is selected in round robin order.
    /// 
    /// * &#39;LEAST_REQUEST&#39;: An O(1) algorithm which selects two random healthy
    ///                   hosts and picks the host which has fewer active requests.
    /// 
    /// * &#39;RING_HASH&#39;: The ring/modulo hash load balancer implements consistent
    ///               hashing to backends. The algorithm has the property that the
    ///               addition/removal of a host from a set of N hosts only affects
    ///               1/N of the requests.
    /// 
    /// * &#39;RANDOM&#39;: The load balancer selects a random healthy host.
    /// 
    /// * &#39;ORIGINAL_DESTINATION&#39;: Backend host is selected based on the client
    ///                           connection metadata, i.e., connections are opened
    ///                           to the same address as the destination address of
    ///                           the incoming connection before the connection
    ///                           was redirected to the load balancer.
    /// 
    /// * &#39;MAGLEV&#39;: used as a drop in replacement for the ring hash load balancer.
    ///             Maglev is not as stable as ring hash but has faster table lookup
    ///             build times and host selection times. For more information about
    ///             Maglev, refer to https://ai.google/research/pubs/pub44824 Possible values: [&amp;quot;ROUND_ROBIN&amp;quot;, &amp;quot;LEAST_REQUEST&amp;quot;, &amp;quot;RING_HASH&amp;quot;, &amp;quot;RANDOM&amp;quot;, &amp;quot;ORIGINAL_DESTINATION&amp;quot;, &amp;quot;MAGLEV&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

}


/// <summary>
/// Block type for log_config in GoogleComputeBackendService.
/// Nesting mode: list
/// </summary>
public class GoogleComputeBackendServiceLogConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "log_config";

    /// <summary>
    /// Whether to enable logging for the load balancer traffic served by this backend service.
    /// </summary>
    public TerraformValue<bool>? Enable
    {
        get => new TerraformReference<bool>(this, "enable");
        set => SetArgument("enable", value);
    }

    /// <summary>
    /// This field can only be specified if logging is enabled for this backend service and &amp;quot;logConfig.optionalMode&amp;quot;
    /// was set to CUSTOM. Contains a list of optional fields you want to include in the logs.
    /// For example: serverInstance, serverGkeDetails.cluster, serverGkeDetails.pod.podNamespace
    /// For example: orca_load_report, tls.protocol
    /// </summary>
    public TerraformList<string>? OptionalFields
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "optional_fields").ResolveNodes(ctx));
        set => SetArgument("optional_fields", value);
    }

    /// <summary>
    /// Specifies the optional logging mode for the load balancer traffic.
    /// Supported values: INCLUDE_ALL_OPTIONAL, EXCLUDE_ALL_OPTIONAL, CUSTOM. Possible values: [&amp;quot;INCLUDE_ALL_OPTIONAL&amp;quot;, &amp;quot;EXCLUDE_ALL_OPTIONAL&amp;quot;, &amp;quot;CUSTOM&amp;quot;]
    /// </summary>
    public TerraformValue<string> OptionalMode
    {
        get => new TerraformReference<string>(this, "optional_mode");
        set => SetArgument("optional_mode", value);
    }

    /// <summary>
    /// This field can only be specified if logging is enabled for this backend service. The value of
    /// the field must be in [0, 1]. This configures the sampling rate of requests to the load balancer
    /// where 1.0 means all logged requests are reported and 0.0 means no logged requests are reported.
    /// The default value is 1.0.
    /// </summary>
    public TerraformValue<double>? SampleRate
    {
        get => new TerraformReference<double>(this, "sample_rate");
        set => SetArgument("sample_rate", value);
    }

}


/// <summary>
/// Block type for max_stream_duration in GoogleComputeBackendService.
/// Nesting mode: list
/// </summary>
public class GoogleComputeBackendServiceMaxStreamDurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "max_stream_duration";

    /// <summary>
    /// Span of time that&#39;s a fraction of a second at nanosecond resolution.
    /// Durations less than one second are represented with a 0 seconds field and a positive nanos field.
    /// Must be from 0 to 999,999,999 inclusive.
    /// </summary>
    public TerraformValue<double>? Nanos
    {
        get => new TerraformReference<double>(this, "nanos");
        set => SetArgument("nanos", value);
    }

    /// <summary>
    /// Span of time at a resolution of a second. Must be from 0 to 315,576,000,000 inclusive. (int64 format)
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Seconds is required")]
    public required TerraformValue<string> Seconds
    {
        get => new TerraformReference<string>(this, "seconds");
        set => SetArgument("seconds", value);
    }

}


/// <summary>
/// Block type for outlier_detection in GoogleComputeBackendService.
/// Nesting mode: list
/// </summary>
public class GoogleComputeBackendServiceOutlierDetectionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "outlier_detection";

    /// <summary>
    /// Number of errors before a host is ejected from the connection pool. When the
    /// backend host is accessed over HTTP, a 5xx return code qualifies as an error.
    /// Defaults to 5.
    /// </summary>
    public TerraformValue<double>? ConsecutiveErrors
    {
        get => new TerraformReference<double>(this, "consecutive_errors");
        set => SetArgument("consecutive_errors", value);
    }

    /// <summary>
    /// The number of consecutive gateway failures (502, 503, 504 status or connection
    /// errors that are mapped to one of those status codes) before a consecutive
    /// gateway failure ejection occurs. Defaults to 5.
    /// </summary>
    public TerraformValue<double>? ConsecutiveGatewayFailure
    {
        get => new TerraformReference<double>(this, "consecutive_gateway_failure");
        set => SetArgument("consecutive_gateway_failure", value);
    }

    /// <summary>
    /// The percentage chance that a host will be actually ejected when an outlier
    /// status is detected through consecutive 5xx. This setting can be used to disable
    /// ejection or to ramp it up slowly. Defaults to 100.
    /// </summary>
    public TerraformValue<double>? EnforcingConsecutiveErrors
    {
        get => new TerraformReference<double>(this, "enforcing_consecutive_errors");
        set => SetArgument("enforcing_consecutive_errors", value);
    }

    /// <summary>
    /// The percentage chance that a host will be actually ejected when an outlier
    /// status is detected through consecutive gateway failures. This setting can be
    /// used to disable ejection or to ramp it up slowly. Defaults to 0.
    /// </summary>
    public TerraformValue<double>? EnforcingConsecutiveGatewayFailure
    {
        get => new TerraformReference<double>(this, "enforcing_consecutive_gateway_failure");
        set => SetArgument("enforcing_consecutive_gateway_failure", value);
    }

    /// <summary>
    /// The percentage chance that a host will be actually ejected when an outlier
    /// status is detected through success rate statistics. This setting can be used to
    /// disable ejection or to ramp it up slowly. Defaults to 100.
    /// </summary>
    public TerraformValue<double>? EnforcingSuccessRate
    {
        get => new TerraformReference<double>(this, "enforcing_success_rate");
        set => SetArgument("enforcing_success_rate", value);
    }

    /// <summary>
    /// Maximum percentage of hosts in the load balancing pool for the backend service
    /// that can be ejected. Defaults to 10%.
    /// </summary>
    public TerraformValue<double>? MaxEjectionPercent
    {
        get => new TerraformReference<double>(this, "max_ejection_percent");
        set => SetArgument("max_ejection_percent", value);
    }

    /// <summary>
    /// The number of hosts in a cluster that must have enough request volume to detect
    /// success rate outliers. If the number of hosts is less than this setting, outlier
    /// detection via success rate statistics is not performed for any host in the
    /// cluster. Defaults to 5.
    /// </summary>
    public TerraformValue<double>? SuccessRateMinimumHosts
    {
        get => new TerraformReference<double>(this, "success_rate_minimum_hosts");
        set => SetArgument("success_rate_minimum_hosts", value);
    }

    /// <summary>
    /// The minimum number of total requests that must be collected in one interval (as
    /// defined by the interval duration above) to include this host in success rate
    /// based outlier detection. If the volume is lower than this setting, outlier
    /// detection via success rate statistics is not performed for that host. Defaults
    /// to 100.
    /// </summary>
    public TerraformValue<double>? SuccessRateRequestVolume
    {
        get => new TerraformReference<double>(this, "success_rate_request_volume");
        set => SetArgument("success_rate_request_volume", value);
    }

    /// <summary>
    /// This factor is used to determine the ejection threshold for success rate outlier
    /// ejection. The ejection threshold is the difference between the mean success
    /// rate, and the product of this factor and the standard deviation of the mean
    /// success rate: mean - (stdev * success_rate_stdev_factor). This factor is divided
    /// by a thousand to get a double. That is, if the desired factor is 1.9, the
    /// runtime value should be 1900. Defaults to 1900.
    /// </summary>
    public TerraformValue<double>? SuccessRateStdevFactor
    {
        get => new TerraformReference<double>(this, "success_rate_stdev_factor");
        set => SetArgument("success_rate_stdev_factor", value);
    }

    /// <summary>
    /// BaseEjectionTime block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BaseEjectionTime block(s) allowed")]
    public TerraformList<GoogleComputeBackendServiceOutlierDetectionBlockBaseEjectionTimeBlock>? BaseEjectionTime
    {
        get => GetArgument<TerraformList<GoogleComputeBackendServiceOutlierDetectionBlockBaseEjectionTimeBlock>>("base_ejection_time");
        set => SetArgument("base_ejection_time", value);
    }

    /// <summary>
    /// Interval block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Interval block(s) allowed")]
    public TerraformList<GoogleComputeBackendServiceOutlierDetectionBlockIntervalBlock>? Interval
    {
        get => GetArgument<TerraformList<GoogleComputeBackendServiceOutlierDetectionBlockIntervalBlock>>("interval");
        set => SetArgument("interval", value);
    }

}

/// <summary>
/// Block type for base_ejection_time in GoogleComputeBackendServiceOutlierDetectionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeBackendServiceOutlierDetectionBlockBaseEjectionTimeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "base_ejection_time";

    /// <summary>
    /// Span of time that&#39;s a fraction of a second at nanosecond resolution. Durations
    /// less than one second are represented with a 0 &#39;seconds&#39; field and a positive
    /// &#39;nanos&#39; field. Must be from 0 to 999,999,999 inclusive.
    /// </summary>
    public TerraformValue<double>? Nanos
    {
        get => new TerraformReference<double>(this, "nanos");
        set => SetArgument("nanos", value);
    }

    /// <summary>
    /// Span of time at a resolution of a second. Must be from 0 to 315,576,000,000
    /// inclusive.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Seconds is required")]
    public required TerraformValue<double> Seconds
    {
        get => new TerraformReference<double>(this, "seconds");
        set => SetArgument("seconds", value);
    }

}

/// <summary>
/// Block type for interval in GoogleComputeBackendServiceOutlierDetectionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeBackendServiceOutlierDetectionBlockIntervalBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "interval";

    /// <summary>
    /// Span of time that&#39;s a fraction of a second at nanosecond resolution. Durations
    /// less than one second are represented with a 0 &#39;seconds&#39; field and a positive
    /// &#39;nanos&#39; field. Must be from 0 to 999,999,999 inclusive.
    /// </summary>
    public TerraformValue<double>? Nanos
    {
        get => new TerraformReference<double>(this, "nanos");
        set => SetArgument("nanos", value);
    }

    /// <summary>
    /// Span of time at a resolution of a second. Must be from 0 to 315,576,000,000
    /// inclusive.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Seconds is required")]
    public required TerraformValue<double> Seconds
    {
        get => new TerraformReference<double>(this, "seconds");
        set => SetArgument("seconds", value);
    }

}


/// <summary>
/// Block type for params in GoogleComputeBackendService.
/// Nesting mode: list
/// </summary>
public class GoogleComputeBackendServiceParamsAttributeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "params";

    /// <summary>
    /// Resource manager tags to be bound to the backend service. Tag keys and values have the
    /// same definition as resource manager tags. Keys must be in the format tagKeys/{tag_key_id},
    /// and values are in the format tagValues/456.
    /// </summary>
    public TerraformMap<string>? ResourceManagerTags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "resource_manager_tags").ResolveNodes(ctx));
        set => SetArgument("resource_manager_tags", value);
    }

}


/// <summary>
/// Block type for security_settings in GoogleComputeBackendService.
/// Nesting mode: list
/// </summary>
public class GoogleComputeBackendServiceSecuritySettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "security_settings";

    /// <summary>
    /// ClientTlsPolicy is a resource that specifies how a client should authenticate
    /// connections to backends of a service. This resource itself does not affect
    /// configuration unless it is attached to a backend service resource.
    /// </summary>
    public TerraformValue<string>? ClientTlsPolicy
    {
        get => new TerraformReference<string>(this, "client_tls_policy");
        set => SetArgument("client_tls_policy", value);
    }

    /// <summary>
    /// A list of alternate names to verify the subject identity in the certificate.
    /// If specified, the client will verify that the server certificate&#39;s subject
    /// alt name matches one of the specified values.
    /// </summary>
    public TerraformList<string>? SubjectAltNames
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "subject_alt_names").ResolveNodes(ctx));
        set => SetArgument("subject_alt_names", value);
    }

    /// <summary>
    /// AwsV4Authentication block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AwsV4Authentication block(s) allowed")]
    public TerraformList<GoogleComputeBackendServiceSecuritySettingsBlockAwsV4AuthenticationBlock>? AwsV4Authentication
    {
        get => GetArgument<TerraformList<GoogleComputeBackendServiceSecuritySettingsBlockAwsV4AuthenticationBlock>>("aws_v4_authentication");
        set => SetArgument("aws_v4_authentication", value);
    }

}

/// <summary>
/// Block type for aws_v4_authentication in GoogleComputeBackendServiceSecuritySettingsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeBackendServiceSecuritySettingsBlockAwsV4AuthenticationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "aws_v4_authentication";

    /// <summary>
    /// The access key used for s3 bucket authentication.
    /// Required for updating or creating a backend that uses AWS v4 signature authentication, but will not be returned as part of the configuration when queried with a REST API GET request.
    /// </summary>
    public TerraformValue<string>? AccessKey
    {
        get => new TerraformReference<string>(this, "access_key");
        set => SetArgument("access_key", value);
    }

    /// <summary>
    /// The identifier of an access key used for s3 bucket authentication.
    /// </summary>
    public TerraformValue<string>? AccessKeyId
    {
        get => new TerraformReference<string>(this, "access_key_id");
        set => SetArgument("access_key_id", value);
    }

    /// <summary>
    /// The optional version identifier for the access key. You can use this to keep track of different iterations of your access key.
    /// </summary>
    public TerraformValue<string>? AccessKeyVersion
    {
        get => new TerraformReference<string>(this, "access_key_version");
        set => SetArgument("access_key_version", value);
    }

    /// <summary>
    /// The name of the cloud region of your origin. This is a free-form field with the name of the region your cloud uses to host your origin.
    /// For example, &amp;quot;us-east-1&amp;quot; for AWS or &amp;quot;us-ashburn-1&amp;quot; for OCI.
    /// </summary>
    public TerraformValue<string>? OriginRegion
    {
        get => new TerraformReference<string>(this, "origin_region");
        set => SetArgument("origin_region", value);
    }

}


/// <summary>
/// Block type for strong_session_affinity_cookie in GoogleComputeBackendService.
/// Nesting mode: list
/// </summary>
public class GoogleComputeBackendServiceStrongSessionAffinityCookieBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "strong_session_affinity_cookie";

    /// <summary>
    /// Name of the cookie.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Path to set for the cookie.
    /// </summary>
    public TerraformValue<string>? Path
    {
        get => new TerraformReference<string>(this, "path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// Ttl block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Ttl block(s) allowed")]
    public TerraformList<GoogleComputeBackendServiceStrongSessionAffinityCookieBlockTtlBlock>? Ttl
    {
        get => GetArgument<TerraformList<GoogleComputeBackendServiceStrongSessionAffinityCookieBlockTtlBlock>>("ttl");
        set => SetArgument("ttl", value);
    }

}

/// <summary>
/// Block type for ttl in GoogleComputeBackendServiceStrongSessionAffinityCookieBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeBackendServiceStrongSessionAffinityCookieBlockTtlBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ttl";

    /// <summary>
    /// Span of time that&#39;s a fraction of a second at nanosecond
    /// resolution. Durations less than one second are represented
    /// with a 0 seconds field and a positive nanos field. Must
    /// be from 0 to 999,999,999 inclusive.
    /// </summary>
    public TerraformValue<double>? Nanos
    {
        get => new TerraformReference<double>(this, "nanos");
        set => SetArgument("nanos", value);
    }

    /// <summary>
    /// Span of time at a resolution of a second.
    /// Must be from 0 to 315,576,000,000 inclusive.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Seconds is required")]
    public required TerraformValue<double> Seconds
    {
        get => new TerraformReference<double>(this, "seconds");
        set => SetArgument("seconds", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleComputeBackendService.
/// Nesting mode: single
/// </summary>
public class GoogleComputeBackendServiceTimeoutsBlock : TerraformBlock
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
/// Block type for tls_settings in GoogleComputeBackendService.
/// Nesting mode: list
/// </summary>
public class GoogleComputeBackendServiceTlsSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tls_settings";

    /// <summary>
    /// Reference to the BackendAuthenticationConfig resource from the networksecurity.googleapis.com namespace.
    /// Can be used in authenticating TLS connections to the backend, as specified by the authenticationMode field.
    /// Can only be specified if authenticationMode is not NONE.
    /// </summary>
    public TerraformValue<string>? AuthenticationConfig
    {
        get => new TerraformReference<string>(this, "authentication_config");
        set => SetArgument("authentication_config", value);
    }

    /// <summary>
    /// Server Name Indication - see RFC3546 section 3.1. If set, the load balancer sends this string as the SNI hostname in the
    /// TLS connection to the backend, and requires that this string match a Subject Alternative Name (SAN) in the backend&#39;s
    /// server certificate. With a Regional Internet NEG backend, if the SNI is specified here, the load balancer uses it
    /// regardless of whether the Regional Internet NEG is specified with FQDN or IP address and port.
    /// </summary>
    public TerraformValue<string>? Sni
    {
        get => new TerraformReference<string>(this, "sni");
        set => SetArgument("sni", value);
    }

    /// <summary>
    /// SubjectAltNames block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeBackendServiceTlsSettingsBlockSubjectAltNamesBlock>? SubjectAltNames
    {
        get => GetArgument<TerraformList<GoogleComputeBackendServiceTlsSettingsBlockSubjectAltNamesBlock>>("subject_alt_names");
        set => SetArgument("subject_alt_names", value);
    }

}

/// <summary>
/// Block type for subject_alt_names in GoogleComputeBackendServiceTlsSettingsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeBackendServiceTlsSettingsBlockSubjectAltNamesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "subject_alt_names";

    /// <summary>
    /// The SAN specified as a DNS Name.
    /// </summary>
    public TerraformValue<string>? DnsName
    {
        get => new TerraformReference<string>(this, "dns_name");
        set => SetArgument("dns_name", value);
    }

    /// <summary>
    /// The SAN specified as a URI.
    /// </summary>
    public TerraformValue<string>? UniformResourceIdentifier
    {
        get => new TerraformReference<string>(this, "uniform_resource_identifier");
        set => SetArgument("uniform_resource_identifier", value);
    }

}


/// <summary>
/// Represents a google_compute_backend_service Terraform resource.
/// Manages a google_compute_backend_service resource.
/// </summary>
public partial class GoogleComputeBackendService(string name) : TerraformResource("google_compute_backend_service", name)
{
    /// <summary>
    /// Lifetime of cookies in seconds if session_affinity is
    /// GENERATED_COOKIE. If set to 0, the cookie is non-persistent and lasts
    /// only until the end of the browser session (or equivalent). The
    /// maximum allowed value for TTL is one day.
    /// 
    /// When the load balancing scheme is INTERNAL, this field is not used.
    /// </summary>
    public TerraformValue<double>? AffinityCookieTtlSec
    {
        get => new TerraformReference<double>(this, "affinity_cookie_ttl_sec");
        set => SetArgument("affinity_cookie_ttl_sec", value);
    }

    /// <summary>
    /// Compress text responses using Brotli or gzip compression, based on the client&#39;s Accept-Encoding header. Possible values: [&amp;quot;AUTOMATIC&amp;quot;, &amp;quot;DISABLED&amp;quot;]
    /// </summary>
    public TerraformValue<string>? CompressionMode
    {
        get => new TerraformReference<string>(this, "compression_mode");
        set => SetArgument("compression_mode", value);
    }

    /// <summary>
    /// Time for which instance will be drained (not accept new
    /// connections, but still work to finish started).
    /// </summary>
    public TerraformValue<double>? ConnectionDrainingTimeoutSec
    {
        get => new TerraformReference<double>(this, "connection_draining_timeout_sec");
        set => SetArgument("connection_draining_timeout_sec", value);
    }

    /// <summary>
    /// Headers that the HTTP/S load balancer should add to proxied
    /// requests.
    /// </summary>
    public TerraformSet<string>? CustomRequestHeaders
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "custom_request_headers").ResolveNodes(ctx));
        set => SetArgument("custom_request_headers", value);
    }

    /// <summary>
    /// Headers that the HTTP/S load balancer should add to proxied
    /// responses.
    /// </summary>
    public TerraformSet<string>? CustomResponseHeaders
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "custom_response_headers").ResolveNodes(ctx));
        set => SetArgument("custom_response_headers", value);
    }

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The resource URL for the edge security policy associated with this backend service.
    /// </summary>
    public TerraformValue<string>? EdgeSecurityPolicy
    {
        get => new TerraformReference<string>(this, "edge_security_policy");
        set => SetArgument("edge_security_policy", value);
    }

    /// <summary>
    /// If true, enable Cloud CDN for this BackendService.
    /// </summary>
    public TerraformValue<bool>? EnableCdn
    {
        get => new TerraformReference<bool>(this, "enable_cdn");
        set => SetArgument("enable_cdn", value);
    }

    /// <summary>
    /// Specifies the canary migration state. Possible values are PREPARE, TEST_BY_PERCENTAGE, and
    /// TEST_ALL_TRAFFIC.
    /// 
    /// To begin the migration from EXTERNAL to EXTERNAL_MANAGED, the state must be changed to
    /// PREPARE. The state must be changed to TEST_ALL_TRAFFIC before the loadBalancingScheme can be
    /// changed to EXTERNAL_MANAGED. Optionally, the TEST_BY_PERCENTAGE state can be used to migrate
    /// traffic by percentage using externalManagedMigrationTestingPercentage.
    /// 
    /// Rolling back a migration requires the states to be set in reverse order. So changing the
    /// scheme from EXTERNAL_MANAGED to EXTERNAL requires the state to be set to TEST_ALL_TRAFFIC at
    /// the same time. Optionally, the TEST_BY_PERCENTAGE state can be used to migrate some traffic
    /// back to EXTERNAL or PREPARE can be used to migrate all traffic back to EXTERNAL. Possible values: [&amp;quot;PREPARE&amp;quot;, &amp;quot;TEST_BY_PERCENTAGE&amp;quot;, &amp;quot;TEST_ALL_TRAFFIC&amp;quot;]
    /// </summary>
    public TerraformValue<string>? ExternalManagedMigrationState
    {
        get => new TerraformReference<string>(this, "external_managed_migration_state");
        set => SetArgument("external_managed_migration_state", value);
    }

    /// <summary>
    /// Determines the fraction of requests that should be processed by the Global external
    /// Application Load Balancer.
    /// 
    /// The value of this field must be in the range [0, 100].
    /// 
    /// Session affinity options will slightly affect this routing behavior, for more details,
    /// see: Session Affinity.
    /// 
    /// This value can only be set if the loadBalancingScheme in the backend service is set to
    /// EXTERNAL (when using the Classic ALB) and the migration state is TEST_BY_PERCENTAGE.
    /// </summary>
    public TerraformValue<double>? ExternalManagedMigrationTestingPercentage
    {
        get => new TerraformReference<double>(this, "external_managed_migration_testing_percentage");
        set => SetArgument("external_managed_migration_testing_percentage", value);
    }

    /// <summary>
    /// The set of URLs to the HttpHealthCheck or HttpsHealthCheck resource
    /// for health checking this BackendService. Currently at most one health
    /// check can be specified.
    /// 
    /// A health check must be specified unless the backend service uses an internet
    /// or serverless NEG as a backend.
    /// 
    /// For internal load balancing, a URL to a HealthCheck resource must be specified instead.
    /// </summary>
    public TerraformSet<string>? HealthChecks
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "health_checks").ResolveNodes(ctx));
        set => SetArgument("health_checks", value);
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
    /// Specifies preference of traffic to the backend (from the proxy and from the client for proxyless gRPC). Possible values: [&amp;quot;IPV4_ONLY&amp;quot;, &amp;quot;PREFER_IPV6&amp;quot;, &amp;quot;IPV6_ONLY&amp;quot;]
    /// </summary>
    public TerraformValue<string>? IpAddressSelectionPolicy
    {
        get => new TerraformReference<string>(this, "ip_address_selection_policy");
        set => SetArgument("ip_address_selection_policy", value);
    }

    /// <summary>
    /// Indicates whether the backend service will be used with internal or
    /// external load balancing. A backend service created for one type of
    /// load balancing cannot be used with the other. For more information, refer to
    /// [Choosing a load balancer](https://cloud.google.com/load-balancing/docs/backend-service). Default value: &amp;quot;EXTERNAL&amp;quot; Possible values: [&amp;quot;EXTERNAL&amp;quot;, &amp;quot;INTERNAL_SELF_MANAGED&amp;quot;, &amp;quot;INTERNAL_MANAGED&amp;quot;, &amp;quot;EXTERNAL_MANAGED&amp;quot;]
    /// </summary>
    public TerraformValue<string>? LoadBalancingScheme
    {
        get => new TerraformReference<string>(this, "load_balancing_scheme");
        set => SetArgument("load_balancing_scheme", value);
    }

    /// <summary>
    /// The load balancing algorithm used within the scope of the locality.
    /// The possible values are:
    /// 
    /// * &#39;ROUND_ROBIN&#39;: This is a simple policy in which each healthy backend
    ///                  is selected in round robin order.
    /// 
    /// * &#39;LEAST_REQUEST&#39;: An O(1) algorithm which selects two random healthy
    ///                    hosts and picks the host which has fewer active requests.
    /// 
    /// * &#39;RING_HASH&#39;: The ring/modulo hash load balancer implements consistent
    ///                hashing to backends. The algorithm has the property that the
    ///                addition/removal of a host from a set of N hosts only affects
    ///                1/N of the requests.
    /// 
    /// * &#39;RANDOM&#39;: The load balancer selects a random healthy host.
    /// 
    /// * &#39;ORIGINAL_DESTINATION&#39;: Backend host is selected based on the client
    ///                           connection metadata, i.e., connections are opened
    ///                           to the same address as the destination address of
    ///                           the incoming connection before the connection
    ///                           was redirected to the load balancer.
    /// 
    /// * &#39;MAGLEV&#39;: used as a drop in replacement for the ring hash load balancer.
    ///             Maglev is not as stable as ring hash but has faster table lookup
    ///             build times and host selection times. For more information about
    ///             Maglev, refer to https://ai.google/research/pubs/pub44824
    /// 
    /// * &#39;WEIGHTED_MAGLEV&#39;: Per-instance weighted Load Balancing via health check
    ///                      reported weights. Only applicable to loadBalancingScheme
    ///                      EXTERNAL. If set, the Backend Service must
    ///                      configure a non legacy HTTP-based Health Check, and
    ///                      health check replies are expected to contain
    ///                      non-standard HTTP response header field
    ///                      X-Load-Balancing-Endpoint-Weight to specify the
    ///                      per-instance weights. If set, Load Balancing is weight
    ///                      based on the per-instance weights reported in the last
    ///                      processed health check replies, as long as every
    ///                      instance either reported a valid weight or had
    ///                      UNAVAILABLE_WEIGHT. Otherwise, Load Balancing remains
    ///                      equal-weight.
    /// 
    /// * &#39;WEIGHTED_ROUND_ROBIN&#39;: Per-endpoint weighted round-robin Load Balancing using weights computed
    ///                           from Backend reported Custom Metrics. If set, the Backend Service
    ///                           responses are expected to contain non-standard HTTP response header field
    ///                           X-Endpoint-Load-Metrics. The reported metrics
    ///                           to use for computing the weights are specified via the
    ///                           backends[].customMetrics fields.
    /// 
    /// locality_lb_policy is applicable to either:
    /// 
    /// * A regional backend service with the service_protocol set to HTTP, HTTPS, HTTP2 or H2C,
    ///   and loadBalancingScheme set to INTERNAL_MANAGED.
    /// * A global backend service with the load_balancing_scheme set to INTERNAL_SELF_MANAGED.
    /// * A regional backend service with loadBalancingScheme set to EXTERNAL (External Network
    ///   Load Balancing). Only MAGLEV and WEIGHTED_MAGLEV values are possible for External
    ///   Network Load Balancing. The default is MAGLEV.
    /// 
    /// If session_affinity is not NONE, and locality_lb_policy is not set to MAGLEV, WEIGHTED_MAGLEV,
    /// or RING_HASH, session affinity settings will not take effect.
    /// 
    /// Only ROUND_ROBIN and RING_HASH are supported when the backend service is referenced
    /// by a URL map that is bound to target gRPC proxy that has validate_for_proxyless
    /// field set to true. Possible values: [&amp;quot;ROUND_ROBIN&amp;quot;, &amp;quot;LEAST_REQUEST&amp;quot;, &amp;quot;RING_HASH&amp;quot;, &amp;quot;RANDOM&amp;quot;, &amp;quot;ORIGINAL_DESTINATION&amp;quot;, &amp;quot;MAGLEV&amp;quot;, &amp;quot;WEIGHTED_MAGLEV&amp;quot;, &amp;quot;WEIGHTED_ROUND_ROBIN&amp;quot;]
    /// </summary>
    public TerraformValue<string>? LocalityLbPolicy
    {
        get => new TerraformReference<string>(this, "locality_lb_policy");
        set => SetArgument("locality_lb_policy", value);
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
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Name of backend port. The same name should appear in the instance
    /// groups referenced by this service. Required when the load balancing
    /// scheme is EXTERNAL.
    /// </summary>
    public TerraformValue<string> PortName
    {
        get => new TerraformReference<string>(this, "port_name");
        set => SetArgument("port_name", value);
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
    /// The protocol this BackendService uses to communicate with backends.
    /// The default is HTTP. Possible values are HTTP, HTTPS, HTTP2, H2C, TCP, SSL, UDP
    /// or GRPC. Refer to the documentation for the load balancers or for Traffic Director
    /// for more information. Must be set to GRPC when the backend service is referenced
    /// by a URL map that is bound to target gRPC proxy. Possible values: [&amp;quot;HTTP&amp;quot;, &amp;quot;HTTPS&amp;quot;, &amp;quot;HTTP2&amp;quot;, &amp;quot;TCP&amp;quot;, &amp;quot;SSL&amp;quot;, &amp;quot;UDP&amp;quot;, &amp;quot;GRPC&amp;quot;, &amp;quot;UNSPECIFIED&amp;quot;, &amp;quot;H2C&amp;quot;]
    /// </summary>
    public TerraformValue<string> Protocol
    {
        get => new TerraformReference<string>(this, "protocol");
        set => SetArgument("protocol", value);
    }

    /// <summary>
    /// The security policy associated with this backend service.
    /// </summary>
    public TerraformValue<string>? SecurityPolicy
    {
        get => new TerraformReference<string>(this, "security_policy");
        set => SetArgument("security_policy", value);
    }

    /// <summary>
    /// URL to networkservices.ServiceLbPolicy resource.
    /// Can only be set if load balancing scheme is EXTERNAL, EXTERNAL_MANAGED, INTERNAL_MANAGED or INTERNAL_SELF_MANAGED and the scope is global.
    /// </summary>
    public TerraformValue<string>? ServiceLbPolicy
    {
        get => new TerraformReference<string>(this, "service_lb_policy");
        set => SetArgument("service_lb_policy", value);
    }

    /// <summary>
    /// Type of session affinity to use. The default is NONE. Session affinity is
    /// not applicable if the protocol is UDP. Possible values: [&amp;quot;NONE&amp;quot;, &amp;quot;CLIENT_IP&amp;quot;, &amp;quot;CLIENT_IP_PORT_PROTO&amp;quot;, &amp;quot;CLIENT_IP_PROTO&amp;quot;, &amp;quot;GENERATED_COOKIE&amp;quot;, &amp;quot;HEADER_FIELD&amp;quot;, &amp;quot;HTTP_COOKIE&amp;quot;, &amp;quot;STRONG_COOKIE_AFFINITY&amp;quot;]
    /// </summary>
    public TerraformValue<string> SessionAffinity
    {
        get => new TerraformReference<string>(this, "session_affinity");
        set => SetArgument("session_affinity", value);
    }

    /// <summary>
    /// The backend service timeout has a different meaning depending on the type of load balancer.
    /// For more information see, [Backend service settings](https://cloud.google.com/compute/docs/reference/rest/v1/backendServices).
    /// The default is 30 seconds.
    /// The full range of timeout values allowed goes from 1 through 2,147,483,647 seconds.
    /// </summary>
    public TerraformValue<double> TimeoutSec
    {
        get => new TerraformReference<double>(this, "timeout_sec");
        set => SetArgument("timeout_sec", value);
    }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformValue<string> CreationTimestamp
    {
        get => new TerraformReference<string>(this, "creation_timestamp");
    }

    /// <summary>
    /// Fingerprint of this resource. A hash of the contents stored in this
    /// object. This field is used in optimistic locking.
    /// </summary>
    public TerraformValue<string> Fingerprint
    {
        get => new TerraformReference<string>(this, "fingerprint");
    }

    /// <summary>
    /// The unique identifier for the resource. This identifier is defined by the server.
    /// </summary>
    public TerraformValue<double> GeneratedId
    {
        get => new TerraformReference<double>(this, "generated_id");
    }

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformValue<string> SelfLink
    {
        get => new TerraformReference<string>(this, "self_link");
    }

    /// <summary>
    /// Backend block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleComputeBackendServiceBackendBlock>? Backend
    {
        get => GetArgument<TerraformSet<GoogleComputeBackendServiceBackendBlock>>("backend");
        set => SetArgument("backend", value);
    }

    /// <summary>
    /// CdnPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CdnPolicy block(s) allowed")]
    public TerraformList<GoogleComputeBackendServiceCdnPolicyBlock>? CdnPolicy
    {
        get => GetArgument<TerraformList<GoogleComputeBackendServiceCdnPolicyBlock>>("cdn_policy");
        set => SetArgument("cdn_policy", value);
    }

    /// <summary>
    /// CircuitBreakers block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CircuitBreakers block(s) allowed")]
    public TerraformList<GoogleComputeBackendServiceCircuitBreakersBlock>? CircuitBreakers
    {
        get => GetArgument<TerraformList<GoogleComputeBackendServiceCircuitBreakersBlock>>("circuit_breakers");
        set => SetArgument("circuit_breakers", value);
    }

    /// <summary>
    /// ConsistentHash block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConsistentHash block(s) allowed")]
    public TerraformList<GoogleComputeBackendServiceConsistentHashBlock>? ConsistentHash
    {
        get => GetArgument<TerraformList<GoogleComputeBackendServiceConsistentHashBlock>>("consistent_hash");
        set => SetArgument("consistent_hash", value);
    }

    /// <summary>
    /// CustomMetrics block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeBackendServiceCustomMetricsBlock>? CustomMetrics
    {
        get => GetArgument<TerraformList<GoogleComputeBackendServiceCustomMetricsBlock>>("custom_metrics");
        set => SetArgument("custom_metrics", value);
    }

    /// <summary>
    /// Iap block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Iap block(s) allowed")]
    public TerraformList<GoogleComputeBackendServiceIapBlock>? Iap
    {
        get => GetArgument<TerraformList<GoogleComputeBackendServiceIapBlock>>("iap");
        set => SetArgument("iap", value);
    }

    /// <summary>
    /// LocalityLbPolicies block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeBackendServiceLocalityLbPoliciesBlock>? LocalityLbPolicies
    {
        get => GetArgument<TerraformList<GoogleComputeBackendServiceLocalityLbPoliciesBlock>>("locality_lb_policies");
        set => SetArgument("locality_lb_policies", value);
    }

    /// <summary>
    /// LogConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LogConfig block(s) allowed")]
    public TerraformList<GoogleComputeBackendServiceLogConfigBlock>? LogConfig
    {
        get => GetArgument<TerraformList<GoogleComputeBackendServiceLogConfigBlock>>("log_config");
        set => SetArgument("log_config", value);
    }

    /// <summary>
    /// MaxStreamDuration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaxStreamDuration block(s) allowed")]
    public TerraformList<GoogleComputeBackendServiceMaxStreamDurationBlock>? MaxStreamDuration
    {
        get => GetArgument<TerraformList<GoogleComputeBackendServiceMaxStreamDurationBlock>>("max_stream_duration");
        set => SetArgument("max_stream_duration", value);
    }

    /// <summary>
    /// OutlierDetection block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OutlierDetection block(s) allowed")]
    public TerraformList<GoogleComputeBackendServiceOutlierDetectionBlock>? OutlierDetection
    {
        get => GetArgument<TerraformList<GoogleComputeBackendServiceOutlierDetectionBlock>>("outlier_detection");
        set => SetArgument("outlier_detection", value);
    }

    /// <summary>
    /// ParamsAttribute block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ParamsAttribute block(s) allowed")]
    public TerraformList<GoogleComputeBackendServiceParamsAttributeBlock>? ParamsAttribute
    {
        get => GetArgument<TerraformList<GoogleComputeBackendServiceParamsAttributeBlock>>("params");
        set => SetArgument("params", value);
    }

    /// <summary>
    /// SecuritySettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecuritySettings block(s) allowed")]
    public TerraformList<GoogleComputeBackendServiceSecuritySettingsBlock>? SecuritySettings
    {
        get => GetArgument<TerraformList<GoogleComputeBackendServiceSecuritySettingsBlock>>("security_settings");
        set => SetArgument("security_settings", value);
    }

    /// <summary>
    /// StrongSessionAffinityCookie block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StrongSessionAffinityCookie block(s) allowed")]
    public TerraformList<GoogleComputeBackendServiceStrongSessionAffinityCookieBlock>? StrongSessionAffinityCookie
    {
        get => GetArgument<TerraformList<GoogleComputeBackendServiceStrongSessionAffinityCookieBlock>>("strong_session_affinity_cookie");
        set => SetArgument("strong_session_affinity_cookie", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleComputeBackendServiceTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleComputeBackendServiceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// TlsSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TlsSettings block(s) allowed")]
    public TerraformList<GoogleComputeBackendServiceTlsSettingsBlock>? TlsSettings
    {
        get => GetArgument<TerraformList<GoogleComputeBackendServiceTlsSettingsBlock>>("tls_settings");
        set => SetArgument("tls_settings", value);
    }

}
