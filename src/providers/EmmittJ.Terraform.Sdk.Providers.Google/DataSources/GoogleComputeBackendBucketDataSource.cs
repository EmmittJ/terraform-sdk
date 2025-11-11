using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_compute_backend_bucket.
/// </summary>
public partial class GoogleComputeBackendBucketDataSource : TerraformDataSource
{
    public GoogleComputeBackendBucketDataSource(string name) : base("google_compute_backend_bucket", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

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
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// Cloud Storage bucket name.
    /// </summary>
    [TerraformProperty("bucket_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> BucketName { get; }

    /// <summary>
    /// Cloud CDN configuration for this Backend Bucket.
    /// </summary>
    [TerraformProperty("cdn_policy")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> CdnPolicy { get; }

    /// <summary>
    /// Compress text responses using Brotli or gzip compression, based on the client&#39;s Accept-Encoding header. Possible values: [&amp;quot;AUTOMATIC&amp;quot;, &amp;quot;DISABLED&amp;quot;]
    /// </summary>
    [TerraformProperty("compression_mode")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CompressionMode { get; }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    [TerraformProperty("creation_timestamp")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreationTimestamp { get; }

    /// <summary>
    /// Headers that the HTTP/S load balancer should add to proxied responses.
    /// </summary>
    [TerraformProperty("custom_response_headers")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> CustomResponseHeaders { get; }

    /// <summary>
    /// An optional textual description of the resource; provided by the
    /// client when the resource is created.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Description { get; }

    /// <summary>
    /// The security policy associated with this backend bucket.
    /// </summary>
    [TerraformProperty("edge_security_policy")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> EdgeSecurityPolicy { get; }

    /// <summary>
    /// If true, enable Cloud CDN for this BackendBucket.
    /// Note: This cannot be set to true when loadBalancingScheme is set to INTERNAL_MANAGED.
    /// </summary>
    [TerraformProperty("enable_cdn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> EnableCdn { get; }

    /// <summary>
    /// The value can only be INTERNAL_MANAGED for cross-region internal layer 7 load balancer.
    /// If loadBalancingScheme is not specified, the backend bucket can be used by classic global external load balancers, or global application external load balancers, or both.
    /// Important: CDN cannot be enabled (enableCdn cannot be set to true) when loadBalancingScheme is set to INTERNAL_MANAGED. Possible values: [&amp;quot;INTERNAL_MANAGED&amp;quot;]
    /// </summary>
    [TerraformProperty("load_balancing_scheme")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LoadBalancingScheme { get; }

    /// <summary>
    /// Additional params passed with the request, but not persisted as part of resource payload
    /// </summary>
    [TerraformProperty("params")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Params { get; }

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    [TerraformProperty("self_link")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SelfLink { get; }

}
