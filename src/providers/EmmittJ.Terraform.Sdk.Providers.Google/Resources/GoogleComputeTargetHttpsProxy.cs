using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleComputeTargetHttpsProxy.
/// Nesting mode: single
/// </summary>
public class GoogleComputeTargetHttpsProxyTimeoutsBlock : TerraformBlock
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
/// Represents a google_compute_target_https_proxy Terraform resource.
/// Manages a google_compute_target_https_proxy resource.
/// </summary>
public partial class GoogleComputeTargetHttpsProxy(string name) : TerraformResource("google_compute_target_https_proxy", name)
{
    /// <summary>
    /// URLs to certificate manager certificate resources that are used to authenticate connections between users and the load balancer.
    /// Certificate manager certificates only apply when the load balancing scheme is set to INTERNAL_MANAGED.
    /// For EXTERNAL and EXTERNAL_MANAGED, use certificate_map instead.
    /// sslCertificates and certificateManagerCertificates fields can not be defined together.
    /// Accepted format is &#39;//certificatemanager.googleapis.com/projects/{project}/locations/{location}/certificates/{resourceName}&#39; or just the self_link &#39;projects/{project}/locations/{location}/certificates/{resourceName}&#39;
    /// </summary>
    public TerraformList<string>? CertificateManagerCertificates
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "certificate_manager_certificates").ResolveNodes(ctx));
        set => SetArgument("certificate_manager_certificates", value);
    }

    /// <summary>
    /// A reference to the CertificateMap resource uri that identifies a certificate map
    /// associated with the given target proxy. This field is only supported for EXTERNAL and EXTERNAL_MANAGED load balancing schemes.
    /// For INTERNAL_MANAGED, use certificate_manager_certificates instead.
    /// Accepted format is &#39;//certificatemanager.googleapis.com/projects/{project}/locations/{location}/certificateMaps/{resourceName}&#39;.
    /// </summary>
    public TerraformValue<string>? CertificateMap
    {
        get => new TerraformReference<string>(this, "certificate_map");
        set => SetArgument("certificate_map", value);
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
    /// not specified, a default value will be used. For Global
    /// external HTTP(S) load balancer, the default value is 610 seconds, the
    /// minimum allowed value is 5 seconds and the maximum allowed value is 1200
    /// seconds. For cross-region internal HTTP(S) load balancer, the default
    /// value is 600 seconds, the minimum allowed value is 5 seconds, and the
    /// maximum allowed value is 600 seconds. For Global external HTTP(S) load
    /// balancer (classic), this option is not available publicly.
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
    /// This field only applies when the forwarding rule that references
    /// this target proxy has a loadBalancingScheme set to INTERNAL_SELF_MANAGED.
    /// </summary>
    public TerraformValue<bool> ProxyBind
    {
        get => new TerraformReference<bool>(this, "proxy_bind");
        set => SetArgument("proxy_bind", value);
    }

    /// <summary>
    /// Specifies the QUIC override policy for this resource. This determines
    /// whether the load balancer will attempt to negotiate QUIC with clients
    /// or not. Can specify one of NONE, ENABLE, or DISABLE. If NONE is
    /// specified, Google manages whether QUIC is used. Default value: &amp;quot;NONE&amp;quot; Possible values: [&amp;quot;NONE&amp;quot;, &amp;quot;ENABLE&amp;quot;, &amp;quot;DISABLE&amp;quot;]
    /// </summary>
    public TerraformValue<string>? QuicOverride
    {
        get => new TerraformReference<string>(this, "quic_override");
        set => SetArgument("quic_override", value);
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
    /// Currently, you may specify up to 15 SSL certificates. sslCertificates do not apply when the load balancing scheme is set to INTERNAL_SELF_MANAGED.
    /// sslCertificates and certificateManagerCertificates can not be defined together.
    /// </summary>
    public TerraformList<string>? SslCertificates
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "ssl_certificates").ResolveNodes(ctx));
        set => SetArgument("ssl_certificates", value);
    }

    /// <summary>
    /// A reference to the SslPolicy resource that will be associated with
    /// the TargetHttpsProxy resource. If not set, the TargetHttpsProxy
    /// resource will not have any SSL policy configured.
    /// </summary>
    public TerraformValue<string>? SslPolicy
    {
        get => new TerraformReference<string>(this, "ssl_policy");
        set => SetArgument("ssl_policy", value);
    }

    /// <summary>
    /// Specifies whether TLS 1.3 0-RTT Data (“Early Data”) should be accepted for this service.
    /// Early Data allows a TLS resumption handshake to include the initial application payload
    /// (a HTTP request) alongside the handshake, reducing the effective round trips to “zero”.
    /// This applies to TLS 1.3 connections over TCP (HTTP/2) as well as over UDP (QUIC/h3). Possible values: [&amp;quot;STRICT&amp;quot;, &amp;quot;PERMISSIVE&amp;quot;, &amp;quot;UNRESTRICTED&amp;quot;, &amp;quot;DISABLED&amp;quot;]
    /// </summary>
    public TerraformValue<string> TlsEarlyData
    {
        get => new TerraformReference<string>(this, "tls_early_data");
        set => SetArgument("tls_early_data", value);
    }

    /// <summary>
    /// A reference to the UrlMap resource that defines the mapping from URL
    /// to the BackendService.
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
    /// Fingerprint of this resource. A hash of the contents stored in this object. This field is used in optimistic locking.
    /// This field will be ignored when inserting a TargetHttpsProxy. An up-to-date fingerprint must be provided in order to
    /// patch the TargetHttpsProxy; otherwise, the request will fail with error 412 conditionNotMet.
    /// To see the latest fingerprint, make a get() request to retrieve the TargetHttpsProxy.
    /// A base64-encoded string.
    /// </summary>
    public TerraformValue<string> Fingerprint
    {
        get => new TerraformReference<string>(this, "fingerprint");
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
    public GoogleComputeTargetHttpsProxyTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleComputeTargetHttpsProxyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
