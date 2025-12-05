using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for cdn_policy in GoogleComputeBackendBucket.
/// Nesting mode: list
/// </summary>
public class GoogleComputeBackendBucketCdnPolicyBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("cache_mode") ?? CreateReference("cache_mode");
        set => SetArgument("cache_mode", value);
    }

    /// <summary>
    /// Specifies the maximum allowed TTL for cached content served by this origin. When the
    /// &#39;cache_mode&#39; is set to &amp;quot;USE_ORIGIN_HEADERS&amp;quot;, you must omit this field.
    /// </summary>
    public TerraformValue<double> ClientTtl
    {
        get => GetArgument<TerraformValue<double>>("client_ttl") ?? CreateReference("client_ttl");
        set => SetArgument("client_ttl", value);
    }

    /// <summary>
    /// Specifies the default TTL for cached content served by this origin for responses
    /// that do not have an existing valid TTL (max-age or s-max-age). When the &#39;cache_mode&#39;
    /// is set to &amp;quot;USE_ORIGIN_HEADERS&amp;quot;, you must omit this field.
    /// </summary>
    public TerraformValue<double> DefaultTtl
    {
        get => GetArgument<TerraformValue<double>>("default_ttl") ?? CreateReference("default_ttl");
        set => SetArgument("default_ttl", value);
    }

    /// <summary>
    /// Specifies the maximum allowed TTL for cached content served by this origin. When the
    /// &#39;cache_mode&#39; is set to &amp;quot;USE_ORIGIN_HEADERS&amp;quot;, you must omit this field.
    /// </summary>
    public TerraformValue<double> MaxTtl
    {
        get => GetArgument<TerraformValue<double>>("max_ttl") ?? CreateReference("max_ttl");
        set => SetArgument("max_ttl", value);
    }

    /// <summary>
    /// Negative caching allows per-status code TTLs to be set, in order to apply fine-grained caching for common errors or redirects.
    /// </summary>
    public TerraformValue<bool> NegativeCaching
    {
        get => GetArgument<TerraformValue<bool>>("negative_caching") ?? CreateReference("negative_caching");
        set => SetArgument("negative_caching", value);
    }

    /// <summary>
    /// If true then Cloud CDN will combine multiple concurrent cache fill requests into a small number of requests to the origin.
    /// </summary>
    public TerraformValue<bool>? RequestCoalescing
    {
        get => GetArgument<TerraformValue<bool>>("request_coalescing");
        set => SetArgument("request_coalescing", value);
    }

    /// <summary>
    /// Serve existing content from the cache (if available) when revalidating content with the origin, or when an error is encountered when refreshing the cache.
    /// </summary>
    public TerraformValue<double> ServeWhileStale
    {
        get => GetArgument<TerraformValue<double>>("serve_while_stale") ?? CreateReference("serve_while_stale");
        set => SetArgument("serve_while_stale", value);
    }

    /// <summary>
    /// Maximum number of seconds the response to a signed URL request will
    /// be considered fresh. After this time period,
    /// the response will be revalidated before being served.
    /// When serving responses to signed URL requests,
    /// Cloud CDN will internally behave as though
    /// all responses from this backend had a &amp;quot;Cache-Control: public,
    /// max-age=[TTL]&amp;quot; header, regardless of any existing Cache-Control
    /// header. The actual headers served in responses will not be altered.
    /// </summary>
    public TerraformValue<double>? SignedUrlCacheMaxAgeSec
    {
        get => GetArgument<TerraformValue<double>>("signed_url_cache_max_age_sec");
        set => SetArgument("signed_url_cache_max_age_sec", value);
    }

    /// <summary>
    /// BypassCacheOnRequestHeaders block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 BypassCacheOnRequestHeaders block(s) allowed")]
    public TerraformList<GoogleComputeBackendBucketCdnPolicyBlockBypassCacheOnRequestHeadersBlock>? BypassCacheOnRequestHeaders
    {
        get => GetArgument<TerraformList<GoogleComputeBackendBucketCdnPolicyBlockBypassCacheOnRequestHeadersBlock>>("bypass_cache_on_request_headers");
        set => SetArgument("bypass_cache_on_request_headers", value);
    }

    /// <summary>
    /// CacheKeyPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CacheKeyPolicy block(s) allowed")]
    public TerraformList<GoogleComputeBackendBucketCdnPolicyBlockCacheKeyPolicyBlock>? CacheKeyPolicy
    {
        get => GetArgument<TerraformList<GoogleComputeBackendBucketCdnPolicyBlockCacheKeyPolicyBlock>>("cache_key_policy");
        set => SetArgument("cache_key_policy", value);
    }

    /// <summary>
    /// NegativeCachingPolicy block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeBackendBucketCdnPolicyBlockNegativeCachingPolicyBlock>? NegativeCachingPolicy
    {
        get => GetArgument<TerraformList<GoogleComputeBackendBucketCdnPolicyBlockNegativeCachingPolicyBlock>>("negative_caching_policy");
        set => SetArgument("negative_caching_policy", value);
    }

}

/// <summary>
/// Block type for bypass_cache_on_request_headers in GoogleComputeBackendBucketCdnPolicyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeBackendBucketCdnPolicyBlockBypassCacheOnRequestHeadersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "bypass_cache_on_request_headers";

    /// <summary>
    /// The header field name to match on when bypassing cache. Values are case-insensitive.
    /// </summary>
    public TerraformValue<string>? HeaderName
    {
        get => GetArgument<TerraformValue<string>>("header_name");
        set => SetArgument("header_name", value);
    }

}

/// <summary>
/// Block type for cache_key_policy in GoogleComputeBackendBucketCdnPolicyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeBackendBucketCdnPolicyBlockCacheKeyPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cache_key_policy";

    /// <summary>
    /// Allows HTTP request headers (by name) to be used in the
    /// cache key.
    /// </summary>
    public TerraformList<string>? IncludeHttpHeaders
    {
        get => GetArgument<TerraformList<string>>("include_http_headers");
        set => SetArgument("include_http_headers", value);
    }

    /// <summary>
    /// Names of query string parameters to include in cache keys.
    /// Default parameters are always included. &#39;&amp;amp;&#39; and &#39;=&#39; will
    /// be percent encoded and not treated as delimiters.
    /// </summary>
    public TerraformList<string>? QueryStringWhitelist
    {
        get => GetArgument<TerraformList<string>>("query_string_whitelist");
        set => SetArgument("query_string_whitelist", value);
    }

}

/// <summary>
/// Block type for negative_caching_policy in GoogleComputeBackendBucketCdnPolicyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeBackendBucketCdnPolicyBlockNegativeCachingPolicyBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<double>>("code");
        set => SetArgument("code", value);
    }

    /// <summary>
    /// The TTL (in seconds) for which to cache responses with the corresponding status code. The maximum allowed value is 1800s
    /// (30 minutes), noting that infrequently accessed objects may be evicted from the cache before the defined TTL.
    /// </summary>
    public TerraformValue<double>? Ttl
    {
        get => GetArgument<TerraformValue<double>>("ttl");
        set => SetArgument("ttl", value);
    }

}


/// <summary>
/// Block type for params in GoogleComputeBackendBucket.
/// Nesting mode: list
/// </summary>
public class GoogleComputeBackendBucketParamsAttributeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "params";

    /// <summary>
    /// Resource manager tags to be bound to the backend bucket. Tag keys and values have the
    /// same definition as resource manager tags. Keys must be in the format tagKeys/{tag_key_id},
    /// and values are in the format tagValues/456.
    /// </summary>
    public TerraformMap<string>? ResourceManagerTags
    {
        get => GetArgument<TerraformMap<string>>("resource_manager_tags");
        set => SetArgument("resource_manager_tags", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleComputeBackendBucket.
/// Nesting mode: single
/// </summary>
public class GoogleComputeBackendBucketTimeoutsBlock : TerraformBlock
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
/// Represents a google_compute_backend_bucket Terraform resource.
/// Manages a google_compute_backend_bucket resource.
/// </summary>
public partial class GoogleComputeBackendBucket(string name) : TerraformResource("google_compute_backend_bucket", name)
{
    /// <summary>
    /// Cloud Storage bucket name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketName is required")]
    public required TerraformValue<string> BucketName
    {
        get => GetRequiredArgument<TerraformValue<string>>("bucket_name");
        set => SetArgument("bucket_name", value);
    }

    /// <summary>
    /// Compress text responses using Brotli or gzip compression, based on the client&#39;s Accept-Encoding header. Possible values: [&amp;quot;AUTOMATIC&amp;quot;, &amp;quot;DISABLED&amp;quot;]
    /// </summary>
    public TerraformValue<string>? CompressionMode
    {
        get => GetArgument<TerraformValue<string>>("compression_mode");
        set => SetArgument("compression_mode", value);
    }

    /// <summary>
    /// Headers that the HTTP/S load balancer should add to proxied responses.
    /// </summary>
    public TerraformList<string>? CustomResponseHeaders
    {
        get => GetArgument<TerraformList<string>>("custom_response_headers");
        set => SetArgument("custom_response_headers", value);
    }

    /// <summary>
    /// An optional textual description of the resource; provided by the
    /// client when the resource is created.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The security policy associated with this backend bucket.
    /// </summary>
    public TerraformValue<string>? EdgeSecurityPolicy
    {
        get => GetArgument<TerraformValue<string>>("edge_security_policy");
        set => SetArgument("edge_security_policy", value);
    }

    /// <summary>
    /// If true, enable Cloud CDN for this BackendBucket.
    /// Note: This cannot be set to true when loadBalancingScheme is set to INTERNAL_MANAGED.
    /// </summary>
    public TerraformValue<bool>? EnableCdn
    {
        get => GetArgument<TerraformValue<bool>>("enable_cdn");
        set => SetArgument("enable_cdn", value);
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
    /// The value can only be INTERNAL_MANAGED for cross-region internal layer 7 load balancer.
    /// If loadBalancingScheme is not specified, the backend bucket can be used by classic global external load balancers, or global application external load balancers, or both.
    /// Important: CDN cannot be enabled (enableCdn cannot be set to true) when loadBalancingScheme is set to INTERNAL_MANAGED. Possible values: [&amp;quot;INTERNAL_MANAGED&amp;quot;]
    /// </summary>
    public TerraformValue<string>? LoadBalancingScheme
    {
        get => GetArgument<TerraformValue<string>>("load_balancing_scheme");
        set => SetArgument("load_balancing_scheme", value);
    }

    /// <summary>
    /// Name of the resource. Provided by the client when the resource is
    /// created. The name must be 1-63 characters long, and comply with
    /// RFC1035.  Specifically, the name must be 1-63 characters long and
    /// match the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39; which means
    /// the first character must be a lowercase letter, and all following
    /// characters must be a dash, lowercase letter, or digit, except the
    /// last character, which cannot be a dash.
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
    /// The self_link attribute.
    /// </summary>
    public TerraformValue<string> SelfLink
        => CreateReference("self_link");

    /// <summary>
    /// CdnPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CdnPolicy block(s) allowed")]
    public TerraformList<GoogleComputeBackendBucketCdnPolicyBlock>? CdnPolicy
    {
        get => GetArgument<TerraformList<GoogleComputeBackendBucketCdnPolicyBlock>>("cdn_policy");
        set => SetArgument("cdn_policy", value);
    }

    /// <summary>
    /// ParamsAttribute block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ParamsAttribute block(s) allowed")]
    public TerraformList<GoogleComputeBackendBucketParamsAttributeBlock>? ParamsAttribute
    {
        get => GetArgument<TerraformList<GoogleComputeBackendBucketParamsAttributeBlock>>("params");
        set => SetArgument("params", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleComputeBackendBucketTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleComputeBackendBucketTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
