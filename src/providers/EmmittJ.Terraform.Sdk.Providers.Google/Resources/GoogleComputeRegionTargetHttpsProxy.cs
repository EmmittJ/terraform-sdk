using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeRegionTargetHttpsProxyTimeoutsBlock : TerraformBlock
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
        this.WithOutput("creation_timestamp");
        this.WithOutput("proxy_id");
        this.WithOutput("self_link");
    }

    /// <summary>
    /// URLs to certificate manager certificate resources that are used to authenticate connections between users and the load balancer.
    /// sslCertificates and certificateManagerCertificates can&#39;t be defined together.
    /// Accepted format is &#39;//certificatemanager.googleapis.com/projects/{project}/locations/{location}/certificates/{resourceName}&#39; or just the self_link &#39;projects/{project}/locations/{location}/certificates/{resourceName}&#39;
    /// </summary>
    public List<TerraformProperty<string>>? CertificateManagerCertificates
    {
        get => GetProperty<List<TerraformProperty<string>>>("certificate_manager_certificates");
        set => this.WithProperty("certificate_manager_certificates", value);
    }

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// Specifies how long to keep a connection open, after completing a response,
    /// while there is no matching traffic (in seconds). If an HTTP keepalive is
    /// not specified, a default value (600 seconds) will be used. For Regioanl
    /// HTTP(S) load balancer, the minimum allowed value is 5 seconds and the
    /// maximum allowed value is 600 seconds.
    /// </summary>
    public TerraformProperty<double>? HttpKeepAliveTimeoutSec
    {
        get => GetProperty<TerraformProperty<double>>("http_keep_alive_timeout_sec");
        set => this.WithProperty("http_keep_alive_timeout_sec", value);
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
    /// Name of the resource. Provided by the client when the resource is
    /// created. The name must be 1-63 characters long, and comply with
    /// RFC1035. Specifically, the name must be 1-63 characters long and match
    /// the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39; which means the
    /// first character must be a lowercase letter, and all following
    /// characters must be a dash, lowercase letter, or digit, except the last
    /// character, which cannot be a dash.
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
    /// The Region in which the created target https proxy should reside.
    /// If it is not provided, the provider region is used.
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
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
    public TerraformProperty<string>? ServerTlsPolicy
    {
        get => GetProperty<TerraformProperty<string>>("server_tls_policy");
        set => this.WithProperty("server_tls_policy", value);
    }

    /// <summary>
    /// URLs to SslCertificate resources that are used to authenticate connections between users and the load balancer.
    /// At least one SSL certificate must be specified. Currently, you may specify up to 15 SSL certificates.
    /// sslCertificates do not apply when the load balancing scheme is set to INTERNAL_SELF_MANAGED.
    /// </summary>
    public List<TerraformProperty<string>>? SslCertificates
    {
        get => GetProperty<List<TerraformProperty<string>>>("ssl_certificates");
        set => this.WithProperty("ssl_certificates", value);
    }

    /// <summary>
    /// A reference to the Region SslPolicy resource that will be associated with
    /// the TargetHttpsProxy resource. If not set, the TargetHttpsProxy
    /// resource will not have any SSL policy configured.
    /// </summary>
    public TerraformProperty<string>? SslPolicy
    {
        get => GetProperty<TerraformProperty<string>>("ssl_policy");
        set => this.WithProperty("ssl_policy", value);
    }

    /// <summary>
    /// A reference to the RegionUrlMap resource that defines the mapping from URL
    /// to the RegionBackendService.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UrlMap is required")]
    public required TerraformProperty<string> UrlMap
    {
        get => GetRequiredProperty<TerraformProperty<string>>("url_map");
        set => this.WithProperty("url_map", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleComputeRegionTargetHttpsProxyTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleComputeRegionTargetHttpsProxyTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
