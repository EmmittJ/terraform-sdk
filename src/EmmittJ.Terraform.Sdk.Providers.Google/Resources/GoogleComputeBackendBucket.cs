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
    public string? BucketName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("bucket_name")?.Value;
        set => this.WithProperty("bucket_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Compress text responses using Brotli or gzip compression, based on the client&#39;s Accept-Encoding header. Possible values: [&amp;quot;AUTOMATIC&amp;quot;, &amp;quot;DISABLED&amp;quot;]
    /// </summary>
    public string? CompressionMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("compression_mode")?.Value;
        set => this.WithProperty("compression_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Headers that the HTTP/S load balancer should add to proxied responses.
    /// </summary>
    public List<string>? CustomResponseHeaders
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("custom_response_headers")?.Value;
        set => this.WithProperty("custom_response_headers", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// An optional textual description of the resource; provided by the
    /// client when the resource is created.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The security policy associated with this backend bucket.
    /// </summary>
    public string? EdgeSecurityPolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("edge_security_policy")?.Value;
        set => this.WithProperty("edge_security_policy", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// If true, enable Cloud CDN for this BackendBucket.
    /// Note: This cannot be set to true when loadBalancingScheme is set to INTERNAL_MANAGED.
    /// </summary>
    public bool? EnableCdn
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_cdn")?.Value;
        set => this.WithProperty("enable_cdn", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The value can only be INTERNAL_MANAGED for cross-region internal layer 7 load balancer.
    /// If loadBalancingScheme is not specified, the backend bucket can be used by classic global external load balancers, or global application external load balancers, or both.
    /// Important: CDN cannot be enabled (enableCdn cannot be set to true) when loadBalancingScheme is set to INTERNAL_MANAGED. Possible values: [&amp;quot;INTERNAL_MANAGED&amp;quot;]
    /// </summary>
    public string? LoadBalancingScheme
    {
        get => GetProperty<TerraformLiteralProperty<string>>("load_balancing_scheme")?.Value;
        set => this.WithProperty("load_balancing_scheme", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
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
