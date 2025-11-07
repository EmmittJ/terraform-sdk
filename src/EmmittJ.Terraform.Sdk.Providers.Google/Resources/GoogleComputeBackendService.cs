using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_compute_backend_service resource.
/// </summary>
public class GoogleComputeBackendService : TerraformResource
{
    public GoogleComputeBackendService(string name) : base("google_compute_backend_service", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("creation_timestamp");
        this.DeclareOutput("fingerprint");
        this.DeclareOutput("generated_id");
        this.DeclareOutput("self_link");
    }

    /// <summary>
    /// Lifetime of cookies in seconds if session_affinity is
    /// GENERATED_COOKIE. If set to 0, the cookie is non-persistent and lasts
    /// only until the end of the browser session (or equivalent). The
    /// maximum allowed value for TTL is one day.
    /// 
    /// When the load balancing scheme is INTERNAL, this field is not used.
    /// </summary>
    public TerraformLiteralProperty<double>? AffinityCookieTtlSec
    {
        get => GetProperty<TerraformLiteralProperty<double>>("affinity_cookie_ttl_sec");
        set => this.WithProperty("affinity_cookie_ttl_sec", value);
    }

    /// <summary>
    /// Compress text responses using Brotli or gzip compression, based on the client&#39;s Accept-Encoding header. Possible values: [&amp;quot;AUTOMATIC&amp;quot;, &amp;quot;DISABLED&amp;quot;]
    /// </summary>
    public TerraformLiteralProperty<string>? CompressionMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("compression_mode");
        set => this.WithProperty("compression_mode", value);
    }

    /// <summary>
    /// Time for which instance will be drained (not accept new
    /// connections, but still work to finish started).
    /// </summary>
    public TerraformLiteralProperty<double>? ConnectionDrainingTimeoutSec
    {
        get => GetProperty<TerraformLiteralProperty<double>>("connection_draining_timeout_sec");
        set => this.WithProperty("connection_draining_timeout_sec", value);
    }

    /// <summary>
    /// Headers that the HTTP/S load balancer should add to proxied
    /// requests.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? CustomRequestHeaders
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("custom_request_headers");
        set => this.WithProperty("custom_request_headers", value);
    }

    /// <summary>
    /// Headers that the HTTP/S load balancer should add to proxied
    /// responses.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? CustomResponseHeaders
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("custom_response_headers");
        set => this.WithProperty("custom_response_headers", value);
    }

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The resource URL for the edge security policy associated with this backend service.
    /// </summary>
    public TerraformLiteralProperty<string>? EdgeSecurityPolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("edge_security_policy");
        set => this.WithProperty("edge_security_policy", value);
    }

    /// <summary>
    /// If true, enable Cloud CDN for this BackendService.
    /// </summary>
    public TerraformLiteralProperty<bool>? EnableCdn
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_cdn");
        set => this.WithProperty("enable_cdn", value);
    }

    /// <summary>
    /// Specifies the canary migration state. Possible values are PREPARE, TEST_BY_PERCENTAGE, and
    /// TEST_ALL_TRAFFIC.
    /// 
    /// To begin the migration from EXTERNAL to EXTERNAL_MANAGED, the state must be changed to
    /// PREPARE. The state must be changed to TEST_ALL_TRAFFIC before the loadBalancingScheme can be
    /// changed to EXTERNAL_MANAGED. Optionally, the TEST_BY_PERCENTAGE state can be used to migrate
    /// traffic by percentage using externalManagedMigrationTestingPercentage.
    /// 
    /// Rolling back a migration requires the states to be set in reverse order. So changing the
    /// scheme from EXTERNAL_MANAGED to EXTERNAL requires the state to be set to TEST_ALL_TRAFFIC at
    /// the same time. Optionally, the TEST_BY_PERCENTAGE state can be used to migrate some traffic
    /// back to EXTERNAL or PREPARE can be used to migrate all traffic back to EXTERNAL. Possible values: [&amp;quot;PREPARE&amp;quot;, &amp;quot;TEST_BY_PERCENTAGE&amp;quot;, &amp;quot;TEST_ALL_TRAFFIC&amp;quot;]
    /// </summary>
    public TerraformLiteralProperty<string>? ExternalManagedMigrationState
    {
        get => GetProperty<TerraformLiteralProperty<string>>("external_managed_migration_state");
        set => this.WithProperty("external_managed_migration_state", value);
    }

    /// <summary>
    /// Determines the fraction of requests that should be processed by the Global external
    /// Application Load Balancer.
    /// 
    /// The value of this field must be in the range [0, 100].
    /// 
    /// Session affinity options will slightly affect this routing behavior, for more details,
    /// see: Session Affinity.
    /// 
    /// This value can only be set if the loadBalancingScheme in the backend service is set to
    /// EXTERNAL (when using the Classic ALB) and the migration state is TEST_BY_PERCENTAGE.
    /// </summary>
    public TerraformLiteralProperty<double>? ExternalManagedMigrationTestingPercentage
    {
        get => GetProperty<TerraformLiteralProperty<double>>("external_managed_migration_testing_percentage");
        set => this.WithProperty("external_managed_migration_testing_percentage", value);
    }

    /// <summary>
    /// The set of URLs to the HttpHealthCheck or HttpsHealthCheck resource
    /// for health checking this BackendService. Currently at most one health
    /// check can be specified.
    /// 
    /// A health check must be specified unless the backend service uses an internet
    /// or serverless NEG as a backend.
    /// 
    /// For internal load balancing, a URL to a HealthCheck resource must be specified instead.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? HealthChecks
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("health_checks");
        set => this.WithProperty("health_checks", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Specifies preference of traffic to the backend (from the proxy and from the client for proxyless gRPC). Possible values: [&amp;quot;IPV4_ONLY&amp;quot;, &amp;quot;PREFER_IPV6&amp;quot;, &amp;quot;IPV6_ONLY&amp;quot;]
    /// </summary>
    public TerraformLiteralProperty<string>? IpAddressSelectionPolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ip_address_selection_policy");
        set => this.WithProperty("ip_address_selection_policy", value);
    }

    /// <summary>
    /// Indicates whether the backend service will be used with internal or
    /// external load balancing. A backend service created for one type of
    /// load balancing cannot be used with the other. For more information, refer to
    /// [Choosing a load balancer](https://cloud.google.com/load-balancing/docs/backend-service). Default value: &amp;quot;EXTERNAL&amp;quot; Possible values: [&amp;quot;EXTERNAL&amp;quot;, &amp;quot;INTERNAL_SELF_MANAGED&amp;quot;, &amp;quot;INTERNAL_MANAGED&amp;quot;, &amp;quot;EXTERNAL_MANAGED&amp;quot;]
    /// </summary>
    public TerraformLiteralProperty<string>? LoadBalancingScheme
    {
        get => GetProperty<TerraformLiteralProperty<string>>("load_balancing_scheme");
        set => this.WithProperty("load_balancing_scheme", value);
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
    public TerraformLiteralProperty<string>? LocalityLbPolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("locality_lb_policy");
        set => this.WithProperty("locality_lb_policy", value);
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
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Name of backend port. The same name should appear in the instance
    /// groups referenced by this service. Required when the load balancing
    /// scheme is EXTERNAL.
    /// </summary>
    public TerraformLiteralProperty<string>? PortName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("port_name");
        set => this.WithProperty("port_name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The protocol this BackendService uses to communicate with backends.
    /// The default is HTTP. Possible values are HTTP, HTTPS, HTTP2, H2C, TCP, SSL, UDP
    /// or GRPC. Refer to the documentation for the load balancers or for Traffic Director
    /// for more information. Must be set to GRPC when the backend service is referenced
    /// by a URL map that is bound to target gRPC proxy. Possible values: [&amp;quot;HTTP&amp;quot;, &amp;quot;HTTPS&amp;quot;, &amp;quot;HTTP2&amp;quot;, &amp;quot;TCP&amp;quot;, &amp;quot;SSL&amp;quot;, &amp;quot;UDP&amp;quot;, &amp;quot;GRPC&amp;quot;, &amp;quot;UNSPECIFIED&amp;quot;, &amp;quot;H2C&amp;quot;]
    /// </summary>
    public TerraformLiteralProperty<string>? Protocol
    {
        get => GetProperty<TerraformLiteralProperty<string>>("protocol");
        set => this.WithProperty("protocol", value);
    }

    /// <summary>
    /// The security policy associated with this backend service.
    /// </summary>
    public TerraformLiteralProperty<string>? SecurityPolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("security_policy");
        set => this.WithProperty("security_policy", value);
    }

    /// <summary>
    /// URL to networkservices.ServiceLbPolicy resource.
    /// Can only be set if load balancing scheme is EXTERNAL, EXTERNAL_MANAGED, INTERNAL_MANAGED or INTERNAL_SELF_MANAGED and the scope is global.
    /// </summary>
    public TerraformLiteralProperty<string>? ServiceLbPolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_lb_policy");
        set => this.WithProperty("service_lb_policy", value);
    }

    /// <summary>
    /// Type of session affinity to use. The default is NONE. Session affinity is
    /// not applicable if the protocol is UDP. Possible values: [&amp;quot;NONE&amp;quot;, &amp;quot;CLIENT_IP&amp;quot;, &amp;quot;CLIENT_IP_PORT_PROTO&amp;quot;, &amp;quot;CLIENT_IP_PROTO&amp;quot;, &amp;quot;GENERATED_COOKIE&amp;quot;, &amp;quot;HEADER_FIELD&amp;quot;, &amp;quot;HTTP_COOKIE&amp;quot;, &amp;quot;STRONG_COOKIE_AFFINITY&amp;quot;]
    /// </summary>
    public TerraformLiteralProperty<string>? SessionAffinity
    {
        get => GetProperty<TerraformLiteralProperty<string>>("session_affinity");
        set => this.WithProperty("session_affinity", value);
    }

    /// <summary>
    /// The backend service timeout has a different meaning depending on the type of load balancer.
    /// For more information see, [Backend service settings](https://cloud.google.com/compute/docs/reference/rest/v1/backendServices).
    /// The default is 30 seconds.
    /// The full range of timeout values allowed goes from 1 through 2,147,483,647 seconds.
    /// </summary>
    public TerraformLiteralProperty<double>? TimeoutSec
    {
        get => GetProperty<TerraformLiteralProperty<double>>("timeout_sec");
        set => this.WithProperty("timeout_sec", value);
    }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformExpression CreationTimestamp => this["creation_timestamp"];

    /// <summary>
    /// Fingerprint of this resource. A hash of the contents stored in this
    /// object. This field is used in optimistic locking.
    /// </summary>
    public TerraformExpression Fingerprint => this["fingerprint"];

    /// <summary>
    /// The unique identifier for the resource. This identifier is defined by the server.
    /// </summary>
    public TerraformExpression GeneratedId => this["generated_id"];

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

}
