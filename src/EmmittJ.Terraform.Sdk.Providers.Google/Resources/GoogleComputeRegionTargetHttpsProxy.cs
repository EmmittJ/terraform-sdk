using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_compute_region_target_https_proxy resource.
/// </summary>
public class GoogleComputeRegionTargetHttpsProxy : TerraformResource
{
    public GoogleComputeRegionTargetHttpsProxy(string name) : base("google_compute_region_target_https_proxy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("creation_timestamp");
        this.DeclareOutput("proxy_id");
        this.DeclareOutput("self_link");
    }

    /// <summary>
    /// URLs to certificate manager certificate resources that are used to authenticate connections between users and the load balancer.
    /// sslCertificates and certificateManagerCertificates can&#39;t be defined together.
    /// Accepted format is &#39;//certificatemanager.googleapis.com/projects/{project}/locations/{location}/certificates/{resourceName}&#39; or just the self_link &#39;projects/{project}/locations/{location}/certificates/{resourceName}&#39;
    /// </summary>
    public List<string>? CertificateManagerCertificates
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("certificate_manager_certificates")?.Value;
        set => this.WithProperty("certificate_manager_certificates", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Specifies how long to keep a connection open, after completing a response,
    /// while there is no matching traffic (in seconds). If an HTTP keepalive is
    /// not specified, a default value (600 seconds) will be used. For Regioanl
    /// HTTP(S) load balancer, the minimum allowed value is 5 seconds and the
    /// maximum allowed value is 600 seconds.
    /// </summary>
    public double? HttpKeepAliveTimeoutSec
    {
        get => GetProperty<TerraformLiteralProperty<double>>("http_keep_alive_timeout_sec")?.Value;
        set => this.WithProperty("http_keep_alive_timeout_sec", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// RFC1035. Specifically, the name must be 1-63 characters long and match
    /// the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39; which means the
    /// first character must be a lowercase letter, and all following
    /// characters must be a dash, lowercase letter, or digit, except the last
    /// character, which cannot be a dash.
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
    /// The Region in which the created target https proxy should reside.
    /// If it is not provided, the provider region is used.
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// A URL referring to a networksecurity.ServerTlsPolicy
    /// resource that describes how the proxy should authenticate inbound
    /// traffic. serverTlsPolicy only applies to a global TargetHttpsProxy
    /// attached to globalForwardingRules with the loadBalancingScheme
    /// set to INTERNAL_SELF_MANAGED or EXTERNAL or EXTERNAL_MANAGED.
    /// For details which ServerTlsPolicy resources are accepted with
    /// INTERNAL_SELF_MANAGED and which with EXTERNAL, EXTERNAL_MANAGED
    /// loadBalancingScheme consult ServerTlsPolicy documentation.
    /// If left blank, communications are not encrypted.
    /// 
    /// If you remove this field from your configuration at the same time as
    /// deleting or recreating a referenced ServerTlsPolicy resource, you will
    /// receive a resourceInUseByAnotherResource error. Use lifecycle.create_before_destroy
    /// within the ServerTlsPolicy resource to avoid this.
    /// </summary>
    public string? ServerTlsPolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("server_tls_policy")?.Value;
        set => this.WithProperty("server_tls_policy", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// URLs to SslCertificate resources that are used to authenticate connections between users and the load balancer.
    /// At least one SSL certificate must be specified. Currently, you may specify up to 15 SSL certificates.
    /// sslCertificates do not apply when the load balancing scheme is set to INTERNAL_SELF_MANAGED.
    /// </summary>
    public List<string>? SslCertificates
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("ssl_certificates")?.Value;
        set => this.WithProperty("ssl_certificates", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// A reference to the Region SslPolicy resource that will be associated with
    /// the TargetHttpsProxy resource. If not set, the TargetHttpsProxy
    /// resource will not have any SSL policy configured.
    /// </summary>
    public string? SslPolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ssl_policy")?.Value;
        set => this.WithProperty("ssl_policy", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// A reference to the RegionUrlMap resource that defines the mapping from URL
    /// to the RegionBackendService.
    /// </summary>
    public string? UrlMap
    {
        get => GetProperty<TerraformLiteralProperty<string>>("url_map")?.Value;
        set => this.WithProperty("url_map", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformExpression CreationTimestamp => this["creation_timestamp"];

    /// <summary>
    /// The unique identifier for the resource.
    /// </summary>
    public TerraformExpression ProxyId => this["proxy_id"];

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

}
