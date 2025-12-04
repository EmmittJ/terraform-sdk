using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_compute_backend_bucket Terraform data source.
/// Retrieves information about a google_compute_backend_bucket.
/// </summary>
public partial class GoogleComputeBackendBucketDataSource(string name) : TerraformDataSource("google_compute_backend_bucket", name)
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
    /// Cloud Storage bucket name.
    /// </summary>
    public TerraformValue<string> BucketName
        => AsReference("bucket_name");

    /// <summary>
    /// Cloud CDN configuration for this Backend Bucket.
    /// </summary>
    public TerraformList<TerraformMap<object>> CdnPolicy
        => AsReference("cdn_policy");

    /// <summary>
    /// Compress text responses using Brotli or gzip compression, based on the client&#39;s Accept-Encoding header. Possible values: [&amp;quot;AUTOMATIC&amp;quot;, &amp;quot;DISABLED&amp;quot;]
    /// </summary>
    public TerraformValue<string> CompressionMode
        => AsReference("compression_mode");

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformValue<string> CreationTimestamp
        => AsReference("creation_timestamp");

    /// <summary>
    /// Headers that the HTTP/S load balancer should add to proxied responses.
    /// </summary>
    public TerraformList<string> CustomResponseHeaders
        => AsReference("custom_response_headers");

    /// <summary>
    /// An optional textual description of the resource; provided by the
    /// client when the resource is created.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// The security policy associated with this backend bucket.
    /// </summary>
    public TerraformValue<string> EdgeSecurityPolicy
        => AsReference("edge_security_policy");

    /// <summary>
    /// If true, enable Cloud CDN for this BackendBucket.
    /// Note: This cannot be set to true when loadBalancingScheme is set to INTERNAL_MANAGED.
    /// </summary>
    public TerraformValue<bool> EnableCdn
        => AsReference("enable_cdn");

    /// <summary>
    /// The value can only be INTERNAL_MANAGED for cross-region internal layer 7 load balancer.
    /// If loadBalancingScheme is not specified, the backend bucket can be used by classic global external load balancers, or global application external load balancers, or both.
    /// Important: CDN cannot be enabled (enableCdn cannot be set to true) when loadBalancingScheme is set to INTERNAL_MANAGED. Possible values: [&amp;quot;INTERNAL_MANAGED&amp;quot;]
    /// </summary>
    public TerraformValue<string> LoadBalancingScheme
        => AsReference("load_balancing_scheme");

    /// <summary>
    /// Additional params passed with the request, but not persisted as part of resource payload
    /// </summary>
    public TerraformList<TerraformMap<object>> ParamsAttribute
        => AsReference("params");

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformValue<string> SelfLink
        => AsReference("self_link");

}
