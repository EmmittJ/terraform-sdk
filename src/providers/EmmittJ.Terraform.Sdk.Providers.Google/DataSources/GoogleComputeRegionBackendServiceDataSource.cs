using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_compute_region_backend_service Terraform data source.
/// Retrieves information about a google_compute_region_backend_service.
/// </summary>
public partial class GoogleComputeRegionBackendServiceDataSource(string name) : TerraformDataSource("google_compute_region_backend_service", name)
{
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
    public TerraformValue<string>? Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The Region in which the created backend service should reside.
    /// If it is not provided, the provider region is used.
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// Lifetime of cookies in seconds if session_affinity is
    /// GENERATED_COOKIE. If set to 0, the cookie is non-persistent and lasts
    /// only until the end of the browser session (or equivalent). The
    /// maximum allowed value for TTL is one day.
    /// 
    /// When the load balancing scheme is INTERNAL, this field is not used.
    /// </summary>
    public TerraformValue<double> AffinityCookieTtlSec
    {
        get => new TerraformReference<double>(this, "affinity_cookie_ttl_sec");
    }

    /// <summary>
    /// The set of backends that serve this RegionBackendService.
    /// </summary>
    public TerraformSet<TerraformMap<object>> Backend
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "backend").ResolveNodes(ctx));
    }

    /// <summary>
    /// Cloud CDN configuration for this BackendService.
    /// </summary>
    public TerraformList<TerraformMap<object>> CdnPolicy
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "cdn_policy").ResolveNodes(ctx));
    }

    /// <summary>
    /// Settings controlling the volume of connections to a backend service. This field
    /// is applicable only when the &#39;load_balancing_scheme&#39; is set to INTERNAL_MANAGED
    /// and the &#39;protocol&#39; is set to HTTP, HTTPS, HTTP2 or H2C.
    /// </summary>
    public TerraformList<TerraformMap<object>> CircuitBreakers
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "circuit_breakers").ResolveNodes(ctx));
    }

    /// <summary>
    /// Time for which instance will be drained (not accept new
    /// connections, but still work to finish started).
    /// </summary>
    public TerraformValue<double> ConnectionDrainingTimeoutSec
    {
        get => new TerraformReference<double>(this, "connection_draining_timeout_sec");
    }

    /// <summary>
    /// Consistent Hash-based load balancing can be used to provide soft session
    /// affinity based on HTTP headers, cookies or other properties. This load balancing
    /// policy is applicable only for HTTP connections. The affinity to a particular
    /// destination host will be lost when one or more hosts are added/removed from the
    /// destination service. This field specifies parameters that control consistent
    /// hashing.
    /// This field only applies when all of the following are true -
    ///   * &#39;load_balancing_scheme&#39; is set to INTERNAL_MANAGED
    ///   * &#39;protocol&#39; is set to HTTP, HTTPS, HTTP2 or H2C
    ///   * &#39;locality_lb_policy&#39; is set to MAGLEV or RING_HASH
    /// </summary>
    public TerraformList<TerraformMap<object>> ConsistentHash
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "consistent_hash").ResolveNodes(ctx));
    }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformValue<string> CreationTimestamp
    {
        get => new TerraformReference<string>(this, "creation_timestamp");
    }

    /// <summary>
    /// List of custom metrics that are used for the WEIGHTED_ROUND_ROBIN locality_lb_policy.
    /// </summary>
    public TerraformList<TerraformMap<object>> CustomMetrics
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "custom_metrics").ResolveNodes(ctx));
    }

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// If true, enable Cloud CDN for this RegionBackendService.
    /// </summary>
    public TerraformValue<bool> EnableCdn
    {
        get => new TerraformReference<bool>(this, "enable_cdn");
    }

    /// <summary>
    /// Policy for failovers.
    /// </summary>
    public TerraformList<TerraformMap<object>> FailoverPolicy
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "failover_policy").ResolveNodes(ctx));
    }

    /// <summary>
    /// Fingerprint of this resource. A hash of the contents stored in this
    /// object. This field is used in optimistic locking.
    /// </summary>
    public TerraformValue<string> Fingerprint
    {
        get => new TerraformReference<string>(this, "fingerprint");
    }

    /// <summary>
    /// The unique identifier for the resource. This identifier is defined by the server.
    /// </summary>
    public TerraformValue<double> GeneratedId
    {
        get => new TerraformReference<double>(this, "generated_id");
    }

    /// <summary>
    /// Configures self-managed High Availability (HA) for External and Internal Protocol Forwarding.
    /// The backends of this regional backend service must only specify zonal network endpoint groups
    /// (NEGs) of type GCE_VM_IP. Note that haPolicy is not for load balancing, and therefore cannot
    /// be specified with sessionAffinity, connectionTrackingPolicy, and failoverPolicy. haPolicy
    /// requires customers to be responsible for tracking backend endpoint health and electing a
    /// leader among the healthy endpoints. Therefore, haPolicy cannot be specified with healthChecks.
    /// haPolicy can only be specified for External Passthrough Network Load Balancers and Internal
    /// Passthrough Network Load Balancers.
    /// </summary>
    public TerraformList<TerraformMap<object>> HaPolicy
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "ha_policy").ResolveNodes(ctx));
    }

    /// <summary>
    /// The set of URLs to HealthCheck resources for health checking
    /// this RegionBackendService. Currently at most one health
    /// check can be specified.
    /// 
    /// A health check must be specified unless the backend service uses an internet
    /// or serverless NEG as a backend.
    /// </summary>
    public TerraformSet<string> HealthChecks
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "health_checks").ResolveNodes(ctx));
    }

    /// <summary>
    /// Settings for enabling Cloud Identity Aware Proxy.
    /// If OAuth client is not set, Google-managed OAuth client is used.
    /// </summary>
    public TerraformList<TerraformMap<object>> Iap
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "iap").ResolveNodes(ctx));
    }

    /// <summary>
    /// Specifies preference of traffic to the backend (from the proxy and from the client for proxyless gRPC). Possible values: [&amp;quot;IPV4_ONLY&amp;quot;, &amp;quot;PREFER_IPV6&amp;quot;, &amp;quot;IPV6_ONLY&amp;quot;]
    /// </summary>
    public TerraformValue<string> IpAddressSelectionPolicy
    {
        get => new TerraformReference<string>(this, "ip_address_selection_policy");
    }

    /// <summary>
    /// Indicates what kind of load balancing this regional backend service
    /// will be used for. A backend service created for one type of load
    /// balancing cannot be used with the other(s). For more information, refer to
    /// [Choosing a load balancer](https://cloud.google.com/load-balancing/docs/backend-service). Default value: &amp;quot;INTERNAL&amp;quot; Possible values: [&amp;quot;EXTERNAL&amp;quot;, &amp;quot;EXTERNAL_MANAGED&amp;quot;, &amp;quot;INTERNAL&amp;quot;, &amp;quot;INTERNAL_MANAGED&amp;quot;]
    /// </summary>
    public TerraformValue<string> LoadBalancingScheme
    {
        get => new TerraformReference<string>(this, "load_balancing_scheme");
    }

    /// <summary>
    /// The load balancing algorithm used within the scope of the locality.
    /// The possible values are:
    /// 
    /// * &#39;ROUND_ROBIN&#39;: This is a simple policy in which each healthy backend
    ///                  is selected in round robin order.
    /// 
    /// * &#39;LEAST_REQUEST&#39;: An O(1) algorithm which selects two random healthy
    ///                    hosts and picks the host which has fewer active requests.
    /// 
    /// * &#39;RING_HASH&#39;: The ring/modulo hash load balancer implements consistent
    ///                hashing to backends. The algorithm has the property that the
    ///                addition/removal of a host from a set of N hosts only affects
    ///                1/N of the requests.
    /// 
    /// * &#39;RANDOM&#39;: The load balancer selects a random healthy host.
    /// 
    /// * &#39;ORIGINAL_DESTINATION&#39;: Backend host is selected based on the client
    ///                           connection metadata, i.e., connections are opened
    ///                           to the same address as the destination address of
    ///                           the incoming connection before the connection
    ///                           was redirected to the load balancer.
    /// 
    /// * &#39;MAGLEV&#39;: used as a drop in replacement for the ring hash load balancer.
    ///             Maglev is not as stable as ring hash but has faster table lookup
    ///             build times and host selection times. For more information about
    ///             Maglev, refer to https://ai.google/research/pubs/pub44824
    /// 
    /// * &#39;WEIGHTED_MAGLEV&#39;: Per-instance weighted Load Balancing via health check
    ///                      reported weights. Only applicable to loadBalancingScheme
    ///                      EXTERNAL. If set, the Backend Service must
    ///                      configure a non legacy HTTP-based Health Check, and
    ///                      health check replies are expected to contain
    ///                      non-standard HTTP response header field
    ///                      X-Load-Balancing-Endpoint-Weight to specify the
    ///                      per-instance weights. If set, Load Balancing is weight
    ///                      based on the per-instance weights reported in the last
    ///                      processed health check replies, as long as every
    ///                      instance either reported a valid weight or had
    ///                      UNAVAILABLE_WEIGHT. Otherwise, Load Balancing remains
    ///                      equal-weight.
    /// 
    /// * &#39;WEIGHTED_ROUND_ROBIN&#39;: Per-endpoint weighted round-robin Load Balancing using weights computed
    ///                           from Backend reported Custom Metrics. If set, the Backend Service
    ///                           responses are expected to contain non-standard HTTP response header field
    ///                           X-Endpoint-Load-Metrics. The reported metrics
    ///                           to use for computing the weights are specified via the
    ///                           backends[].customMetrics fields.
    /// 
    /// locality_lb_policy is applicable to either:
    /// 
    /// * A regional backend service with the service_protocol set to HTTP, HTTPS, HTTP2 or H2C,
    ///   and loadBalancingScheme set to INTERNAL_MANAGED.
    /// * A global backend service with the load_balancing_scheme set to INTERNAL_SELF_MANAGED.
    /// * A regional backend service with loadBalancingScheme set to EXTERNAL (External Network
    ///   Load Balancing). Only MAGLEV and WEIGHTED_MAGLEV values are possible for External
    ///   Network Load Balancing. The default is MAGLEV.
    /// 
    /// If session_affinity is not NONE, and locality_lb_policy is not set to MAGLEV, WEIGHTED_MAGLEV,
    /// or RING_HASH, session affinity settings will not take effect.
    /// 
    /// Only ROUND_ROBIN and RING_HASH are supported when the backend service is referenced
    /// by a URL map that is bound to target gRPC proxy that has validate_for_proxyless
    /// field set to true. Possible values: [&amp;quot;ROUND_ROBIN&amp;quot;, &amp;quot;LEAST_REQUEST&amp;quot;, &amp;quot;RING_HASH&amp;quot;, &amp;quot;RANDOM&amp;quot;, &amp;quot;ORIGINAL_DESTINATION&amp;quot;, &amp;quot;MAGLEV&amp;quot;, &amp;quot;WEIGHTED_MAGLEV&amp;quot;, &amp;quot;WEIGHTED_ROUND_ROBIN&amp;quot;]
    /// </summary>
    public TerraformValue<string> LocalityLbPolicy
    {
        get => new TerraformReference<string>(this, "locality_lb_policy");
    }

    /// <summary>
    /// This field denotes the logging options for the load balancer traffic served by this backend service.
    /// If logging is enabled, logs will be exported to Stackdriver.
    /// </summary>
    public TerraformList<TerraformMap<object>> LogConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "log_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// The URL of the network to which this backend service belongs.
    /// This field must be set for Internal Passthrough Network Load Balancers when the haPolicy is enabled, and for External Passthrough Network Load Balancers when the haPolicy fastIpMove is enabled.
    /// This field can only be specified when the load balancing scheme is set to INTERNAL, or when the load balancing scheme is set to EXTERNAL and haPolicy fastIpMove is enabled.
    /// Changes to this field force recreation of the resource.
    /// </summary>
    public TerraformValue<string> Network
    {
        get => new TerraformReference<string>(this, "network");
    }

    /// <summary>
    /// Settings controlling eviction of unhealthy hosts from the load balancing pool.
    /// This field is applicable only when the &#39;load_balancing_scheme&#39; is set
    /// to INTERNAL_MANAGED and the &#39;protocol&#39; is set to HTTP, HTTPS, HTTP2 or H2C.
    /// </summary>
    public TerraformList<TerraformMap<object>> OutlierDetection
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "outlier_detection").ResolveNodes(ctx));
    }

    /// <summary>
    /// Additional params passed with the request, but not persisted as part of resource payload
    /// </summary>
    public TerraformList<TerraformMap<object>> ParamsAttribute
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "params").ResolveNodes(ctx));
    }

    /// <summary>
    /// A named port on a backend instance group representing the port for
    /// communication to the backend VMs in that group. Required when the
    /// loadBalancingScheme is EXTERNAL, EXTERNAL_MANAGED, INTERNAL_MANAGED, or INTERNAL_SELF_MANAGED
    /// and the backends are instance groups. The named port must be defined on each
    /// backend instance group. This parameter has no meaning if the backends are NEGs. API sets a
    /// default of &amp;quot;http&amp;quot; if not given.
    /// Must be omitted when the loadBalancingScheme is INTERNAL (Internal TCP/UDP Load Balancing).
    /// </summary>
    public TerraformValue<string> PortName
    {
        get => new TerraformReference<string>(this, "port_name");
    }

    /// <summary>
    /// The protocol this BackendService uses to communicate with backends.
    /// The default is HTTP. Possible values are HTTP, HTTPS, HTTP2, H2C, TCP, SSL, UDP
    /// or GRPC. Refer to the documentation for the load balancers or for Traffic Director
    /// for more information. Possible values: [&amp;quot;HTTP&amp;quot;, &amp;quot;HTTPS&amp;quot;, &amp;quot;HTTP2&amp;quot;, &amp;quot;TCP&amp;quot;, &amp;quot;SSL&amp;quot;, &amp;quot;UDP&amp;quot;, &amp;quot;GRPC&amp;quot;, &amp;quot;UNSPECIFIED&amp;quot;, &amp;quot;H2C&amp;quot;]
    /// </summary>
    public TerraformValue<string> Protocol
    {
        get => new TerraformReference<string>(this, "protocol");
    }

    /// <summary>
    /// The security policy associated with this backend service.
    /// </summary>
    public TerraformValue<string> SecurityPolicy
    {
        get => new TerraformReference<string>(this, "security_policy");
    }

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformValue<string> SelfLink
    {
        get => new TerraformReference<string>(this, "self_link");
    }

    /// <summary>
    /// Type of session affinity to use. The default is NONE. Session affinity is
    /// not applicable if the protocol is UDP. Possible values: [&amp;quot;NONE&amp;quot;, &amp;quot;CLIENT_IP&amp;quot;, &amp;quot;CLIENT_IP_PORT_PROTO&amp;quot;, &amp;quot;CLIENT_IP_PROTO&amp;quot;, &amp;quot;GENERATED_COOKIE&amp;quot;, &amp;quot;HEADER_FIELD&amp;quot;, &amp;quot;HTTP_COOKIE&amp;quot;, &amp;quot;CLIENT_IP_NO_DESTINATION&amp;quot;, &amp;quot;STRONG_COOKIE_AFFINITY&amp;quot;]
    /// </summary>
    public TerraformValue<string> SessionAffinity
    {
        get => new TerraformReference<string>(this, "session_affinity");
    }

    /// <summary>
    /// Describes the HTTP cookie used for stateful session affinity. This field is applicable and required if the sessionAffinity is set to STRONG_COOKIE_AFFINITY.
    /// </summary>
    public TerraformList<TerraformMap<object>> StrongSessionAffinityCookie
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "strong_session_affinity_cookie").ResolveNodes(ctx));
    }

    /// <summary>
    /// The backend service timeout has a different meaning depending on the type of load balancer.
    /// For more information see, [Backend service settings](https://cloud.google.com/compute/docs/reference/rest/v1/backendServices).
    /// The default is 30 seconds.
    /// The full range of timeout values allowed goes from 1 through 2,147,483,647 seconds.
    /// </summary>
    public TerraformValue<double> TimeoutSec
    {
        get => new TerraformReference<double>(this, "timeout_sec");
    }

}
