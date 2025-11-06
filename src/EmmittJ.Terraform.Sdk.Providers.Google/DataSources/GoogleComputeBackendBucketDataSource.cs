using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_compute_backend_bucket.
/// </summary>
public class GoogleComputeBackendBucketDataSource : TerraformDataSource
{
    public GoogleComputeBackendBucketDataSource(string name) : base("google_compute_backend_bucket", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("bucket_name");
        this.DeclareOutput("cdn_policy");
        this.DeclareOutput("compression_mode");
        this.DeclareOutput("creation_timestamp");
        this.DeclareOutput("custom_response_headers");
        this.DeclareOutput("description");
        this.DeclareOutput("edge_security_policy");
        this.DeclareOutput("enable_cdn");
        this.DeclareOutput("load_balancing_scheme");
        this.DeclareOutput("params");
        this.DeclareOutput("self_link");
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
    /// Cloud Storage bucket name.
    /// </summary>
    public TerraformExpression BucketName => this["bucket_name"];

    /// <summary>
    /// Cloud CDN configuration for this Backend Bucket.
    /// </summary>
    public TerraformExpression CdnPolicy => this["cdn_policy"];

    /// <summary>
    /// Compress text responses using Brotli or gzip compression, based on the client&#39;s Accept-Encoding header. Possible values: [&amp;quot;AUTOMATIC&amp;quot;, &amp;quot;DISABLED&amp;quot;]
    /// </summary>
    public TerraformExpression CompressionMode => this["compression_mode"];

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformExpression CreationTimestamp => this["creation_timestamp"];

    /// <summary>
    /// Headers that the HTTP/S load balancer should add to proxied responses.
    /// </summary>
    public TerraformExpression CustomResponseHeaders => this["custom_response_headers"];

    /// <summary>
    /// An optional textual description of the resource; provided by the
    /// client when the resource is created.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The security policy associated with this backend bucket.
    /// </summary>
    public TerraformExpression EdgeSecurityPolicy => this["edge_security_policy"];

    /// <summary>
    /// If true, enable Cloud CDN for this BackendBucket.
    /// Note: This cannot be set to true when loadBalancingScheme is set to INTERNAL_MANAGED.
    /// </summary>
    public TerraformExpression EnableCdn => this["enable_cdn"];

    /// <summary>
    /// The value can only be INTERNAL_MANAGED for cross-region internal layer 7 load balancer.
    /// If loadBalancingScheme is not specified, the backend bucket can be used by classic global external load balancers, or global application external load balancers, or both.
    /// Important: CDN cannot be enabled (enableCdn cannot be set to true) when loadBalancingScheme is set to INTERNAL_MANAGED. Possible values: [&amp;quot;INTERNAL_MANAGED&amp;quot;]
    /// </summary>
    public TerraformExpression LoadBalancingScheme => this["load_balancing_scheme"];

    /// <summary>
    /// Additional params passed with the request, but not persisted as part of resource payload
    /// </summary>
    public TerraformExpression Params => this["params"];

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

}
