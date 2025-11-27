using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleComputeRegionTargetHttpsProxy.
/// Nesting mode: single
/// </summary>
public class GoogleComputeRegionTargetHttpsProxyTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_compute_region_target_https_proxy Terraform resource.
/// Manages a google_compute_region_target_https_proxy resource.
/// </summary>
public partial class GoogleComputeRegionTargetHttpsProxy(string name) : TerraformResource("google_compute_region_target_https_proxy", name)
{
    /// <summary>
    /// URLs to certificate manager certificate resources that are used to authenticate connections between users and the load balancer.
    /// sslCertificates and certificateManagerCertificates can&#39;t be defined together.
    /// Accepted format is &#39;//certificatemanager.googleapis.com/projects/{project}/locations/{location}/certificates/{resourceName}&#39; or just the self_link &#39;projects/{project}/locations/{location}/certificates/{resourceName}&#39;
    /// </summary>
    public TerraformList<string>? CertificateManagerCertificates
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "certificate_manager_certificates").ResolveNodes(ctx));
        set => SetArgument("certificate_manager_certificates", value);
    }

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Specifies how long to keep a connection open, after completing a response,
    /// while there is no matching traffic (in seconds). If an HTTP keepalive is
    /// not specified, a default value (600 seconds) will be used. For Regioanl
    /// HTTP(S) load balancer, the minimum allowed value is 5 seconds and the
    /// maximum allowed value is 600 seconds.
    /// </summary>
    public TerraformValue<double>? HttpKeepAliveTimeoutSec
    {
        get => new TerraformReference<double>(this, "http_keep_alive_timeout_sec");
        set => SetArgument("http_keep_alive_timeout_sec", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
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
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The Region in which the created target https proxy should reside.
    /// If it is not provided, the provider region is used.
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
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
    public TerraformValue<string>? ServerTlsPolicy
    {
        get => new TerraformReference<string>(this, "server_tls_policy");
        set => SetArgument("server_tls_policy", value);
    }

    /// <summary>
    /// URLs to SslCertificate resources that are used to authenticate connections between users and the load balancer.
    /// At least one SSL certificate must be specified. Currently, you may specify up to 15 SSL certificates.
    /// sslCertificates do not apply when the load balancing scheme is set to INTERNAL_SELF_MANAGED.
    /// </summary>
    public TerraformList<string>? SslCertificates
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "ssl_certificates").ResolveNodes(ctx));
        set => SetArgument("ssl_certificates", value);
    }

    /// <summary>
    /// A reference to the Region SslPolicy resource that will be associated with
    /// the TargetHttpsProxy resource. If not set, the TargetHttpsProxy
    /// resource will not have any SSL policy configured.
    /// </summary>
    public TerraformValue<string>? SslPolicy
    {
        get => new TerraformReference<string>(this, "ssl_policy");
        set => SetArgument("ssl_policy", value);
    }

    /// <summary>
    /// A reference to the RegionUrlMap resource that defines the mapping from URL
    /// to the RegionBackendService.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UrlMap is required")]
    public required TerraformValue<string> UrlMap
    {
        get => new TerraformReference<string>(this, "url_map");
        set => SetArgument("url_map", value);
    }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformValue<string> CreationTimestamp
    {
        get => new TerraformReference<string>(this, "creation_timestamp");
    }

    /// <summary>
    /// The unique identifier for the resource.
    /// </summary>
    public TerraformValue<double> ProxyId
    {
        get => new TerraformReference<double>(this, "proxy_id");
    }

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformValue<string> SelfLink
    {
        get => new TerraformReference<string>(this, "self_link");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleComputeRegionTargetHttpsProxyTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleComputeRegionTargetHttpsProxyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
