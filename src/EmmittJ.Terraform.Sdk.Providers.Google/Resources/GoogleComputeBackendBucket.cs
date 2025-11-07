using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_compute_backend_bucket resource.
/// </summary>
public class GoogleComputeBackendBucket : TerraformResource
{
    public GoogleComputeBackendBucket(string name) : base("google_compute_backend_bucket", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("creation_timestamp");
        this.DeclareOutput("self_link");
    }

    /// <summary>
    /// Cloud Storage bucket name.
    /// </summary>
    public TerraformProperty<string>? BucketName
    {
        get => GetProperty<TerraformProperty<string>>("bucket_name");
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
    public TerraformProperty<List<string>>? CustomResponseHeaders
    {
        get => GetProperty<TerraformProperty<List<string>>>("custom_response_headers");
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
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
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
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformExpression CreationTimestamp => this["creation_timestamp"];

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

}
