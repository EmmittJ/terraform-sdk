using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_compute_region_backend_service.
/// </summary>
public class GoogleComputeRegionBackendServiceDataSource : TerraformDataSource
{
    public GoogleComputeRegionBackendServiceDataSource(string name) : base("google_compute_region_backend_service", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

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
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// The Region in which the created backend service should reside.
    /// If it is not provided, the provider region is used.
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Region { get; set; }

    /// <summary>
    /// Lifetime of cookies in seconds if session_affinity is
    /// GENERATED_COOKIE. If set to 0, the cookie is non-persistent and lasts
    /// only until the end of the browser session (or equivalent). The
    /// maximum allowed value for TTL is one day.
    /// 
    /// When the load balancing scheme is INTERNAL, this field is not used.
    /// </summary>
    [TerraformPropertyName("affinity_cookie_ttl_sec")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> AffinityCookieTtlSec => new TerraformReference(this, "affinity_cookie_ttl_sec");

    /// <summary>
    /// The set of backends that serve this RegionBackendService.
    /// </summary>
    [TerraformPropertyName("backend")]
    // Output-only attribute - read-only reference
    public TerraformSet<object> Backend => new TerraformReference(this, "backend");

    /// <summary>
    /// Cloud CDN configuration for this BackendService.
    /// </summary>
    [TerraformPropertyName("cdn_policy")]
    // Output-only attribute - read-only reference
    public TerraformList<object> CdnPolicy => new TerraformReference(this, "cdn_policy");

    /// <summary>
    /// Settings controlling the volume of connections to a backend service. This field
    /// is applicable only when the &#39;load_balancing_scheme&#39; is set to INTERNAL_MANAGED
    /// and the &#39;protocol&#39; is set to HTTP, HTTPS, HTTP2 or H2C.
    /// </summary>
    [TerraformPropertyName("circuit_breakers")]
    // Output-only attribute - read-only reference
    public TerraformList<object> CircuitBreakers => new TerraformReference(this, "circuit_breakers");

    /// <summary>
    /// Time for which instance will be drained (not accept new
    /// connections, but still work to finish started).
    /// </summary>
    [TerraformPropertyName("connection_draining_timeout_sec")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> ConnectionDrainingTimeoutSec => new TerraformReference(this, "connection_draining_timeout_sec");

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
    [TerraformPropertyName("consistent_hash")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ConsistentHash => new TerraformReference(this, "consistent_hash");

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    [TerraformPropertyName("creation_timestamp")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreationTimestamp => new TerraformReference(this, "creation_timestamp");

    /// <summary>
    /// List of custom metrics that are used for the WEIGHTED_ROUND_ROBIN locality_lb_policy.
    /// </summary>
    [TerraformPropertyName("custom_metrics")]
    // Output-only attribute - read-only reference
    public TerraformList<object> CustomMetrics => new TerraformReference(this, "custom_metrics");

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Description => new TerraformReference(this, "description");

    /// <summary>
    /// If true, enable Cloud CDN for this RegionBackendService.
    /// </summary>
    [TerraformPropertyName("enable_cdn")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> EnableCdn => new TerraformReference(this, "enable_cdn");

    /// <summary>
    /// Policy for failovers.
    /// </summary>
    [TerraformPropertyName("failover_policy")]
    // Output-only attribute - read-only reference
    public TerraformList<object> FailoverPolicy => new TerraformReference(this, "failover_policy");

    /// <summary>
    /// Fingerprint of this resource. A hash of the contents stored in this
    /// object. This field is used in optimistic locking.
    /// </summary>
    [TerraformPropertyName("fingerprint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Fingerprint => new TerraformReference(this, "fingerprint");

    /// <summary>
    /// The unique identifier for the resource. This identifier is defined by the server.
    /// </summary>
    [TerraformPropertyName("generated_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> GeneratedId => new TerraformReference(this, "generated_id");

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
    [TerraformPropertyName("ha_policy")]
    // Output-only attribute - read-only reference
    public TerraformList<object> HaPolicy => new TerraformReference(this, "ha_policy");

    /// <summary>
    /// The set of URLs to HealthCheck resources for health checking
    /// this RegionBackendService. Currently at most one health
    /// check can be specified.
    /// 
    /// A health check must be specified unless the backend service uses an internet
    /// or serverless NEG as a backend.
    /// </summary>
    [TerraformPropertyName("health_checks")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> HealthChecks => new TerraformReference(this, "health_checks");

    /// <summary>
    /// Settings for enabling Cloud Identity Aware Proxy.
    /// If OAuth client is not set, Google-managed OAuth client is used.
    /// </summary>
    [TerraformPropertyName("iap")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Iap => new TerraformReference(this, "iap");

    /// <summary>
    /// Specifies preference of traffic to the backend (from the proxy and from the client for proxyless gRPC). Possible values: [&amp;quot;IPV4_ONLY&amp;quot;, &amp;quot;PREFER_IPV6&amp;quot;, &amp;quot;IPV6_ONLY&amp;quot;]
    /// </summary>
    [TerraformPropertyName("ip_address_selection_policy")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> IpAddressSelectionPolicy => new TerraformReference(this, "ip_address_selection_policy");

    /// <summary>
    /// Indicates what kind of load balancing this regional backend service
    /// will be used for. A backend service created for one type of load
    /// balancing cannot be used with the other(s). For more information, refer to
    /// [Choosing a load balancer](https://cloud.google.com/load-balancing/docs/backend-service). Default value: &amp;quot;INTERNAL&amp;quot; Possible values: [&amp;quot;EXTERNAL&amp;quot;, &amp;quot;EXTERNAL_MANAGED&amp;quot;, &amp;quot;INTERNAL&amp;quot;, &amp;quot;INTERNAL_MANAGED&amp;quot;]
    /// </summary>
    [TerraformPropertyName("load_balancing_scheme")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LoadBalancingScheme => new TerraformReference(this, "load_balancing_scheme");

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
    [TerraformPropertyName("locality_lb_policy")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LocalityLbPolicy => new TerraformReference(this, "locality_lb_policy");

    /// <summary>
    /// This field denotes the logging options for the load balancer traffic served by this backend service.
    /// If logging is enabled, logs will be exported to Stackdriver.
    /// </summary>
    [TerraformPropertyName("log_config")]
    // Output-only attribute - read-only reference
    public TerraformList<object> LogConfig => new TerraformReference(this, "log_config");

    /// <summary>
    /// The URL of the network to which this backend service belongs.
    /// This field must be set for Internal Passthrough Network Load Balancers when the haPolicy is enabled, and for External Passthrough Network Load Balancers when the haPolicy fastIpMove is enabled.
    /// This field can only be specified when the load balancing scheme is set to INTERNAL, or when the load balancing scheme is set to EXTERNAL and haPolicy fastIpMove is enabled.
    /// Changes to this field force recreation of the resource.
    /// </summary>
    [TerraformPropertyName("network")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Network => new TerraformReference(this, "network");

    /// <summary>
    /// Settings controlling eviction of unhealthy hosts from the load balancing pool.
    /// This field is applicable only when the &#39;load_balancing_scheme&#39; is set
    /// to INTERNAL_MANAGED and the &#39;protocol&#39; is set to HTTP, HTTPS, HTTP2 or H2C.
    /// </summary>
    [TerraformPropertyName("outlier_detection")]
    // Output-only attribute - read-only reference
    public TerraformList<object> OutlierDetection => new TerraformReference(this, "outlier_detection");

    /// <summary>
    /// Additional params passed with the request, but not persisted as part of resource payload
    /// </summary>
    [TerraformPropertyName("params")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Params => new TerraformReference(this, "params");

    /// <summary>
    /// A named port on a backend instance group representing the port for
    /// communication to the backend VMs in that group. Required when the
    /// loadBalancingScheme is EXTERNAL, EXTERNAL_MANAGED, INTERNAL_MANAGED, or INTERNAL_SELF_MANAGED
    /// and the backends are instance groups. The named port must be defined on each
    /// backend instance group. This parameter has no meaning if the backends are NEGs. API sets a
    /// default of &amp;quot;http&amp;quot; if not given.
    /// Must be omitted when the loadBalancingScheme is INTERNAL (Internal TCP/UDP Load Balancing).
    /// </summary>
    [TerraformPropertyName("port_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PortName => new TerraformReference(this, "port_name");

    /// <summary>
    /// The protocol this BackendService uses to communicate with backends.
    /// The default is HTTP. Possible values are HTTP, HTTPS, HTTP2, H2C, TCP, SSL, UDP
    /// or GRPC. Refer to the documentation for the load balancers or for Traffic Director
    /// for more information. Possible values: [&amp;quot;HTTP&amp;quot;, &amp;quot;HTTPS&amp;quot;, &amp;quot;HTTP2&amp;quot;, &amp;quot;TCP&amp;quot;, &amp;quot;SSL&amp;quot;, &amp;quot;UDP&amp;quot;, &amp;quot;GRPC&amp;quot;, &amp;quot;UNSPECIFIED&amp;quot;, &amp;quot;H2C&amp;quot;]
    /// </summary>
    [TerraformPropertyName("protocol")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Protocol => new TerraformReference(this, "protocol");

    /// <summary>
    /// The security policy associated with this backend service.
    /// </summary>
    [TerraformPropertyName("security_policy")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SecurityPolicy => new TerraformReference(this, "security_policy");

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    [TerraformPropertyName("self_link")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SelfLink => new TerraformReference(this, "self_link");

    /// <summary>
    /// Type of session affinity to use. The default is NONE. Session affinity is
    /// not applicable if the protocol is UDP. Possible values: [&amp;quot;NONE&amp;quot;, &amp;quot;CLIENT_IP&amp;quot;, &amp;quot;CLIENT_IP_PORT_PROTO&amp;quot;, &amp;quot;CLIENT_IP_PROTO&amp;quot;, &amp;quot;GENERATED_COOKIE&amp;quot;, &amp;quot;HEADER_FIELD&amp;quot;, &amp;quot;HTTP_COOKIE&amp;quot;, &amp;quot;CLIENT_IP_NO_DESTINATION&amp;quot;, &amp;quot;STRONG_COOKIE_AFFINITY&amp;quot;]
    /// </summary>
    [TerraformPropertyName("session_affinity")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SessionAffinity => new TerraformReference(this, "session_affinity");

    /// <summary>
    /// Describes the HTTP cookie used for stateful session affinity. This field is applicable and required if the sessionAffinity is set to STRONG_COOKIE_AFFINITY.
    /// </summary>
    [TerraformPropertyName("strong_session_affinity_cookie")]
    // Output-only attribute - read-only reference
    public TerraformList<object> StrongSessionAffinityCookie => new TerraformReference(this, "strong_session_affinity_cookie");

    /// <summary>
    /// The backend service timeout has a different meaning depending on the type of load balancer.
    /// For more information see, [Backend service settings](https://cloud.google.com/compute/docs/reference/rest/v1/backendServices).
    /// The default is 30 seconds.
    /// The full range of timeout values allowed goes from 1 through 2,147,483,647 seconds.
    /// </summary>
    [TerraformPropertyName("timeout_sec")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> TimeoutSec => new TerraformReference(this, "timeout_sec");

}
