using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_compute_backend_bucket.
/// </summary>
public class GoogleComputeBackendBucketDataSource : TerraformDataSource
{
    public GoogleComputeBackendBucketDataSource(string name) : base("google_compute_backend_bucket", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

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
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Project { get; set; }

    /// <summary>
    /// Cloud Storage bucket name.
    /// </summary>
    [TerraformPropertyName("bucket_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> BucketName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "bucket_name");

    /// <summary>
    /// Cloud CDN configuration for this Backend Bucket.
    /// </summary>
    [TerraformPropertyName("cdn_policy")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> CdnPolicy => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "cdn_policy");

    /// <summary>
    /// Compress text responses using Brotli or gzip compression, based on the client&#39;s Accept-Encoding header. Possible values: [&amp;quot;AUTOMATIC&amp;quot;, &amp;quot;DISABLED&amp;quot;]
    /// </summary>
    [TerraformPropertyName("compression_mode")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CompressionMode => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "compression_mode");

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    [TerraformPropertyName("creation_timestamp")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreationTimestamp => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "creation_timestamp");

    /// <summary>
    /// Headers that the HTTP/S load balancer should add to proxied responses.
    /// </summary>
    [TerraformPropertyName("custom_response_headers")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> CustomResponseHeaders => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "custom_response_headers");

    /// <summary>
    /// An optional textual description of the resource; provided by the
    /// client when the resource is created.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// The security policy associated with this backend bucket.
    /// </summary>
    [TerraformPropertyName("edge_security_policy")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EdgeSecurityPolicy => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "edge_security_policy");

    /// <summary>
    /// If true, enable Cloud CDN for this BackendBucket.
    /// Note: This cannot be set to true when loadBalancingScheme is set to INTERNAL_MANAGED.
    /// </summary>
    [TerraformPropertyName("enable_cdn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> EnableCdn => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "enable_cdn");

    /// <summary>
    /// The value can only be INTERNAL_MANAGED for cross-region internal layer 7 load balancer.
    /// If loadBalancingScheme is not specified, the backend bucket can be used by classic global external load balancers, or global application external load balancers, or both.
    /// Important: CDN cannot be enabled (enableCdn cannot be set to true) when loadBalancingScheme is set to INTERNAL_MANAGED. Possible values: [&amp;quot;INTERNAL_MANAGED&amp;quot;]
    /// </summary>
    [TerraformPropertyName("load_balancing_scheme")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LoadBalancingScheme => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "load_balancing_scheme");

    /// <summary>
    /// Additional params passed with the request, but not persisted as part of resource payload
    /// </summary>
    [TerraformPropertyName("params")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Params => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "params");

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    [TerraformPropertyName("self_link")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SelfLink => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "self_link");

}
