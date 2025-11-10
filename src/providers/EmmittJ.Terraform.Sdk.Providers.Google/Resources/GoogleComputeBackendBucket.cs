using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for cdn_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeBackendBucketCdnPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Specifies the cache setting for all responses from this backend.
    /// The possible values are: USE_ORIGIN_HEADERS, FORCE_CACHE_ALL and CACHE_ALL_STATIC Possible values: [&amp;quot;USE_ORIGIN_HEADERS&amp;quot;, &amp;quot;FORCE_CACHE_ALL&amp;quot;, &amp;quot;CACHE_ALL_STATIC&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? CacheMode
    {
        get => GetProperty<TerraformProperty<string>>("cache_mode");
        set => WithProperty("cache_mode", value);
    }

    /// <summary>
    /// Specifies the maximum allowed TTL for cached content served by this origin. When the
    /// &#39;cache_mode&#39; is set to &amp;quot;USE_ORIGIN_HEADERS&amp;quot;, you must omit this field.
    /// </summary>
    public TerraformProperty<double>? ClientTtl
    {
        get => GetProperty<TerraformProperty<double>>("client_ttl");
        set => WithProperty("client_ttl", value);
    }

    /// <summary>
    /// Specifies the default TTL for cached content served by this origin for responses
    /// that do not have an existing valid TTL (max-age or s-max-age). When the &#39;cache_mode&#39;
    /// is set to &amp;quot;USE_ORIGIN_HEADERS&amp;quot;, you must omit this field.
    /// </summary>
    public TerraformProperty<double>? DefaultTtl
    {
        get => GetProperty<TerraformProperty<double>>("default_ttl");
        set => WithProperty("default_ttl", value);
    }

    /// <summary>
    /// Specifies the maximum allowed TTL for cached content served by this origin. When the
    /// &#39;cache_mode&#39; is set to &amp;quot;USE_ORIGIN_HEADERS&amp;quot;, you must omit this field.
    /// </summary>
    public TerraformProperty<double>? MaxTtl
    {
        get => GetProperty<TerraformProperty<double>>("max_ttl");
        set => WithProperty("max_ttl", value);
    }

    /// <summary>
    /// Negative caching allows per-status code TTLs to be set, in order to apply fine-grained caching for common errors or redirects.
    /// </summary>
    public TerraformProperty<bool>? NegativeCaching
    {
        get => GetProperty<TerraformProperty<bool>>("negative_caching");
        set => WithProperty("negative_caching", value);
    }

    /// <summary>
    /// If true then Cloud CDN will combine multiple concurrent cache fill requests into a small number of requests to the origin.
    /// </summary>
    public TerraformProperty<bool>? RequestCoalescing
    {
        get => GetProperty<TerraformProperty<bool>>("request_coalescing");
        set => WithProperty("request_coalescing", value);
    }

    /// <summary>
    /// Serve existing content from the cache (if available) when revalidating content with the origin, or when an error is encountered when refreshing the cache.
    /// </summary>
    public TerraformProperty<double>? ServeWhileStale
    {
        get => GetProperty<TerraformProperty<double>>("serve_while_stale");
        set => WithProperty("serve_while_stale", value);
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
    public TerraformProperty<double>? SignedUrlCacheMaxAgeSec
    {
        get => GetProperty<TerraformProperty<double>>("signed_url_cache_max_age_sec");
        set => WithProperty("signed_url_cache_max_age_sec", value);
    }

}

/// <summary>
/// Block type for params in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeBackendBucketParamsBlock : TerraformBlock
{
    /// <summary>
    /// Resource manager tags to be bound to the backend bucket. Tag keys and values have the
    /// same definition as resource manager tags. Keys must be in the format tagKeys/{tag_key_id},
    /// and values are in the format tagValues/456.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? ResourceManagerTags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("resource_manager_tags");
        set => WithProperty("resource_manager_tags", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeBackendBucketTimeoutsBlock : TerraformBlock
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
/// Manages a google_compute_backend_bucket resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleComputeBackendBucket : TerraformResource
{
    public GoogleComputeBackendBucket(string name) : base("google_compute_backend_bucket", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("creation_timestamp");
        this.WithOutput("self_link");
    }

    /// <summary>
    /// Cloud Storage bucket name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketName is required")]
    public required TerraformProperty<string> BucketName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("bucket_name");
        set => this.WithProperty("bucket_name", value);
    }

    /// <summary>
    /// Compress text responses using Brotli or gzip compression, based on the client&#39;s Accept-Encoding header. Possible values: [&amp;quot;AUTOMATIC&amp;quot;, &amp;quot;DISABLED&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? CompressionMode
    {
        get => GetProperty<TerraformProperty<string>>("compression_mode");
        set => this.WithProperty("compression_mode", value);
    }

    /// <summary>
    /// Headers that the HTTP/S load balancer should add to proxied responses.
    /// </summary>
    public List<TerraformProperty<string>>? CustomResponseHeaders
    {
        get => GetProperty<List<TerraformProperty<string>>>("custom_response_headers");
        set => this.WithProperty("custom_response_headers", value);
    }

    /// <summary>
    /// An optional textual description of the resource; provided by the
    /// client when the resource is created.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The security policy associated with this backend bucket.
    /// </summary>
    public TerraformProperty<string>? EdgeSecurityPolicy
    {
        get => GetProperty<TerraformProperty<string>>("edge_security_policy");
        set => this.WithProperty("edge_security_policy", value);
    }

    /// <summary>
    /// If true, enable Cloud CDN for this BackendBucket.
    /// Note: This cannot be set to true when loadBalancingScheme is set to INTERNAL_MANAGED.
    /// </summary>
    public TerraformProperty<bool>? EnableCdn
    {
        get => GetProperty<TerraformProperty<bool>>("enable_cdn");
        set => this.WithProperty("enable_cdn", value);
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
    /// The value can only be INTERNAL_MANAGED for cross-region internal layer 7 load balancer.
    /// If loadBalancingScheme is not specified, the backend bucket can be used by classic global external load balancers, or global application external load balancers, or both.
    /// Important: CDN cannot be enabled (enableCdn cannot be set to true) when loadBalancingScheme is set to INTERNAL_MANAGED. Possible values: [&amp;quot;INTERNAL_MANAGED&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? LoadBalancingScheme
    {
        get => GetProperty<TerraformProperty<string>>("load_balancing_scheme");
        set => this.WithProperty("load_balancing_scheme", value);
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
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// Block for cdn_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CdnPolicy block(s) allowed")]
    public List<GoogleComputeBackendBucketCdnPolicyBlock>? CdnPolicy
    {
        get => GetProperty<List<GoogleComputeBackendBucketCdnPolicyBlock>>("cdn_policy");
        set => this.WithProperty("cdn_policy", value);
    }

    /// <summary>
    /// Block for params.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Params block(s) allowed")]
    public List<GoogleComputeBackendBucketParamsBlock>? Params
    {
        get => GetProperty<List<GoogleComputeBackendBucketParamsBlock>>("params");
        set => this.WithProperty("params", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleComputeBackendBucketTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleComputeBackendBucketTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformExpression CreationTimestamp => this["creation_timestamp"];

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

}
