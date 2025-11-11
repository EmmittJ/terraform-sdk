using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for backend in .
/// Nesting mode: set
/// </summary>
public partial class GoogleComputeRegionBackendServiceBackendBlock : TerraformBlockBase
{
    /// <summary>
    /// Specifies the balancing mode for this backend.
    /// 
    /// See the [Backend Services Overview](https://cloud.google.com/load-balancing/docs/backend-service#balancing-mode)
    /// for an explanation of load balancing modes. Default value: &amp;quot;UTILIZATION&amp;quot; Possible values: [&amp;quot;UTILIZATION&amp;quot;, &amp;quot;RATE&amp;quot;, &amp;quot;CONNECTION&amp;quot;, &amp;quot;CUSTOM_METRICS&amp;quot;]
    /// </summary>
    [TerraformProperty("balancing_mode")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? BalancingMode { get; set; }

    /// <summary>
    /// A multiplier applied to the group&#39;s maximum servicing capacity
    /// (based on UTILIZATION, RATE or CONNECTION).
    /// 
    /// ~&amp;gt;**NOTE**: This field cannot be set for
    /// INTERNAL region backend services (default loadBalancingScheme),
    /// but is required for non-INTERNAL backend service. The total
    /// capacity_scaler for all backends must be non-zero.
    /// 
    /// A setting of 0 means the group is completely drained, offering
    /// 0% of its available Capacity. Valid range is [0.0,1.0].
    /// </summary>
    [TerraformProperty("capacity_scaler")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? CapacityScaler { get; set; }

    /// <summary>
    /// An optional description of this resource.
    /// Provide this property when you create the resource.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// This field designates whether this is a failover backend. More
    /// than one failover backend can be configured for a given RegionBackendService.
    /// </summary>
    [TerraformProperty("failover")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> Failover { get; set; }

    /// <summary>
    /// The fully-qualified URL of an Instance Group or Network Endpoint
    /// Group resource. In case of instance group this defines the list
    /// of instances that serve traffic. Member virtual machine
    /// instances from each instance group must live in the same zone as
    /// the instance group itself. No two backends in a backend service
    /// are allowed to use same Instance Group resource.
    /// 
    /// For Network Endpoint Groups this defines list of endpoints. All
    /// endpoints of Network Endpoint Group must be hosted on instances
    /// located in the same zone as the Network Endpoint Group.
    /// 
    /// Backend services cannot mix Instance Group and
    /// Network Endpoint Group backends.
    /// 
    /// When the &#39;load_balancing_scheme&#39; is INTERNAL, only instance groups
    /// are supported.
    /// 
    /// Note that you must specify an Instance Group or Network Endpoint
    /// Group resource using the fully-qualified URL, rather than a
    /// partial URL.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Group is required")]
    [TerraformProperty("group")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Group { get; set; }

    /// <summary>
    /// The max number of simultaneous connections for the group. Can
    /// be used with either CONNECTION or UTILIZATION balancing modes.
    /// Cannot be set for INTERNAL backend services.
    /// 
    /// For CONNECTION mode, either maxConnections or one
    /// of maxConnectionsPerInstance or maxConnectionsPerEndpoint,
    /// as appropriate for group type, must be set.
    /// </summary>
    [TerraformProperty("max_connections")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MaxConnections { get; set; }

    /// <summary>
    /// The max number of simultaneous connections that a single backend
    /// network endpoint can handle. Cannot be set
    /// for INTERNAL backend services.
    /// 
    /// This is used to calculate the capacity of the group. Can be
    /// used in either CONNECTION or UTILIZATION balancing modes. For
    /// CONNECTION mode, either maxConnections or
    /// maxConnectionsPerEndpoint must be set.
    /// </summary>
    [TerraformProperty("max_connections_per_endpoint")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MaxConnectionsPerEndpoint { get; set; }

    /// <summary>
    /// The max number of simultaneous connections that a single
    /// backend instance can handle. Cannot be set for INTERNAL backend
    /// services.
    /// 
    /// This is used to calculate the capacity of the group.
    /// Can be used in either CONNECTION or UTILIZATION balancing modes.
    /// For CONNECTION mode, either maxConnections or
    /// maxConnectionsPerInstance must be set.
    /// </summary>
    [TerraformProperty("max_connections_per_instance")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MaxConnectionsPerInstance { get; set; }

    /// <summary>
    /// The max requests per second (RPS) of the group. Cannot be set
    /// for INTERNAL backend services.
    /// 
    /// Can be used with either RATE or UTILIZATION balancing modes,
    /// but required if RATE mode. Either maxRate or one
    /// of maxRatePerInstance or maxRatePerEndpoint, as appropriate for
    /// group type, must be set.
    /// </summary>
    [TerraformProperty("max_rate")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MaxRate { get; set; }

    /// <summary>
    /// The max requests per second (RPS) that a single backend network
    /// endpoint can handle. This is used to calculate the capacity of
    /// the group. Can be used in either balancing mode. For RATE mode,
    /// either maxRate or maxRatePerEndpoint must be set. Cannot be set
    /// for INTERNAL backend services.
    /// </summary>
    [TerraformProperty("max_rate_per_endpoint")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MaxRatePerEndpoint { get; set; }

    /// <summary>
    /// The max requests per second (RPS) that a single backend
    /// instance can handle. This is used to calculate the capacity of
    /// the group. Can be used in either balancing mode. For RATE mode,
    /// either maxRate or maxRatePerInstance must be set. Cannot be set
    /// for INTERNAL backend services.
    /// </summary>
    [TerraformProperty("max_rate_per_instance")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MaxRatePerInstance { get; set; }

    /// <summary>
    /// Used when balancingMode is UTILIZATION. This ratio defines the
    /// CPU utilization target for the group. Valid range is [0.0, 1.0].
    /// Cannot be set for INTERNAL backend services.
    /// </summary>
    [TerraformProperty("max_utilization")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MaxUtilization { get; set; }

}

/// <summary>
/// Block type for cdn_policy in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeRegionBackendServiceCdnPolicyBlock : TerraformBlockBase
{
    /// <summary>
    /// Specifies the cache setting for all responses from this backend.
    /// The possible values are: USE_ORIGIN_HEADERS, FORCE_CACHE_ALL and CACHE_ALL_STATIC Possible values: [&amp;quot;USE_ORIGIN_HEADERS&amp;quot;, &amp;quot;FORCE_CACHE_ALL&amp;quot;, &amp;quot;CACHE_ALL_STATIC&amp;quot;]
    /// </summary>
    [TerraformProperty("cache_mode")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> CacheMode { get; set; }

    /// <summary>
    /// Specifies the maximum allowed TTL for cached content served by this origin.
    /// </summary>
    [TerraformProperty("client_ttl")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> ClientTtl { get; set; }

    /// <summary>
    /// Specifies the default TTL for cached content served by this origin for responses
    /// that do not have an existing valid TTL (max-age or s-max-age).
    /// </summary>
    [TerraformProperty("default_ttl")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> DefaultTtl { get; set; }

    /// <summary>
    /// Specifies the maximum allowed TTL for cached content served by this origin.
    /// </summary>
    [TerraformProperty("max_ttl")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> MaxTtl { get; set; }

    /// <summary>
    /// Negative caching allows per-status code TTLs to be set, in order to apply fine-grained caching for common errors or redirects.
    /// </summary>
    [TerraformProperty("negative_caching")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> NegativeCaching { get; set; }

    /// <summary>
    /// Serve existing content from the cache (if available) when revalidating content with the origin, or when an error is encountered when refreshing the cache.
    /// </summary>
    [TerraformProperty("serve_while_stale")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> ServeWhileStale { get; set; }

    /// <summary>
    /// Maximum number of seconds the response to a signed URL request
    /// will be considered fresh, defaults to 1hr (3600s). After this
    /// time period, the response will be revalidated before
    /// being served.
    /// 
    /// When serving responses to signed URL requests, Cloud CDN will
    /// internally behave as though all responses from this backend had a
    /// &amp;quot;Cache-Control: public, max-age=[TTL]&amp;quot; header, regardless of any
    /// existing Cache-Control header. The actual headers served in
    /// responses will not be altered.
    /// </summary>
    [TerraformProperty("signed_url_cache_max_age_sec")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? SignedUrlCacheMaxAgeSec { get; set; }

}

/// <summary>
/// Block type for circuit_breakers in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeRegionBackendServiceCircuitBreakersBlock : TerraformBlockBase
{
    /// <summary>
    /// The maximum number of connections to the backend cluster.
    /// Defaults to 1024.
    /// </summary>
    [TerraformProperty("max_connections")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MaxConnections { get; set; }

    /// <summary>
    /// The maximum number of pending requests to the backend cluster.
    /// Defaults to 1024.
    /// </summary>
    [TerraformProperty("max_pending_requests")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MaxPendingRequests { get; set; }

    /// <summary>
    /// The maximum number of parallel requests to the backend cluster.
    /// Defaults to 1024.
    /// </summary>
    [TerraformProperty("max_requests")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MaxRequests { get; set; }

    /// <summary>
    /// Maximum requests for a single backend connection. This parameter
    /// is respected by both the HTTP/1.1 and HTTP/2 implementations. If
    /// not specified, there is no limit. Setting this parameter to 1
    /// will effectively disable keep alive.
    /// </summary>
    [TerraformProperty("max_requests_per_connection")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MaxRequestsPerConnection { get; set; }

    /// <summary>
    /// The maximum number of parallel retries to the backend cluster.
    /// Defaults to 3.
    /// </summary>
    [TerraformProperty("max_retries")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MaxRetries { get; set; }

}

/// <summary>
/// Block type for consistent_hash in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeRegionBackendServiceConsistentHashBlock : TerraformBlockBase
{
    /// <summary>
    /// The hash based on the value of the specified header field.
    /// This field is applicable if the sessionAffinity is set to HEADER_FIELD.
    /// </summary>
    [TerraformProperty("http_header_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? HttpHeaderName { get; set; }

    /// <summary>
    /// The minimum number of virtual nodes to use for the hash ring.
    /// Larger ring sizes result in more granular load
    /// distributions. If the number of hosts in the load balancing pool
    /// is larger than the ring size, each host will be assigned a single
    /// virtual node.
    /// Defaults to 1024.
    /// </summary>
    [TerraformProperty("minimum_ring_size")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MinimumRingSize { get; set; }

}

/// <summary>
/// Block type for custom_metrics in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeRegionBackendServiceCustomMetricsBlock : TerraformBlockBase
{
    /// <summary>
    /// If true, the metric data is not used for load balancing.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DryRun is required")]
    [TerraformProperty("dry_run")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> DryRun { get; set; }

    /// <summary>
    /// Name of a custom utilization signal. The name must be 1-64 characters
    /// long and match the regular expression [a-z]([-_.a-z0-9]*[a-z0-9])? which
    /// means the first character must be a lowercase letter, and all following
    /// characters must be a dash, period, underscore, lowercase letter, or
    /// digit, except the last character, which cannot be a dash, period, or
    /// underscore. For usage guidelines, see Custom Metrics balancing mode. This
    /// field can only be used for a global or regional backend service with the
    /// loadBalancingScheme set to &amp;lt;code&amp;gt;EXTERNAL_MANAGED&amp;lt;/code&amp;gt;,
    /// &amp;lt;code&amp;gt;INTERNAL_MANAGED&amp;lt;/code&amp;gt; &amp;lt;code&amp;gt;INTERNAL_SELF_MANAGED&amp;lt;/code&amp;gt;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

}

/// <summary>
/// Block type for failover_policy in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeRegionBackendServiceFailoverPolicyBlock : TerraformBlockBase
{
    /// <summary>
    /// On failover or failback, this field indicates whether connection drain
    /// will be honored. Setting this to true has the following effect: connections
    /// to the old active pool are not drained. Connections to the new active pool
    /// use the timeout of 10 min (currently fixed). Setting to false has the
    /// following effect: both old and new connections will have a drain timeout
    /// of 10 min.
    /// This can be set to true only if the protocol is TCP.
    /// The default is false.
    /// </summary>
    [TerraformProperty("disable_connection_drain_on_failover")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> DisableConnectionDrainOnFailover { get; set; }

    /// <summary>
    /// This option is used only when no healthy VMs are detected in the primary
    /// and backup instance groups. When set to true, traffic is dropped. When
    /// set to false, new connections are sent across all VMs in the primary group.
    /// The default is false.
    /// </summary>
    [TerraformProperty("drop_traffic_if_unhealthy")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> DropTrafficIfUnhealthy { get; set; }

    /// <summary>
    /// The value of the field must be in [0, 1]. If the ratio of the healthy
    /// VMs in the primary backend is at or below this number, traffic arriving
    /// at the load-balanced IP will be directed to the failover backend.
    /// In case where &#39;failoverRatio&#39; is not set or all the VMs in the backup
    /// backend are unhealthy, the traffic will be directed back to the primary
    /// backend in the &amp;quot;force&amp;quot; mode, where traffic will be spread to the healthy
    /// VMs with the best effort, or to all VMs when no VM is healthy.
    /// This field is only used with l4 load balancing.
    /// </summary>
    [TerraformProperty("failover_ratio")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? FailoverRatio { get; set; }

}

/// <summary>
/// Block type for ha_policy in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeRegionBackendServiceHaPolicyBlock : TerraformBlockBase
{
    /// <summary>
    /// Specifies whether fast IP move is enabled, and if so, the mechanism to achieve it.
    /// Supported values are:
    /// 
    /// * &#39;DISABLED&#39;: Fast IP Move is disabled. You can only use the haPolicy.leader API to
    ///               update the leader.
    /// 
    /// * &#39;GARP_RA&#39;: Provides a method to very quickly define a new network endpoint as the
    ///              leader. This method is faster than updating the leader using the
    ///              haPolicy.leader API. Fast IP move works as follows: The VM hosting the
    ///              network endpoint that should become the new leader sends either a
    ///              Gratuitous ARP (GARP) packet (IPv4) or an ICMPv6 Router Advertisement(RA)
    ///              packet (IPv6). Google Cloud immediately but temporarily associates the
    ///              forwarding rule IP address with that VM, and both new and in-flight packets
    ///              are quickly delivered to that VM. Possible values: [&amp;quot;DISABLED&amp;quot;, &amp;quot;GARP_RA&amp;quot;]
    /// </summary>
    [TerraformProperty("fast_ip_move")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? FastIpMove { get; set; }

}

/// <summary>
/// Block type for iap in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeRegionBackendServiceIapBlock : TerraformBlockBase
{
    /// <summary>
    /// Whether the serving infrastructure will authenticate and authorize all incoming requests.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformProperty("enabled")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> Enabled { get; set; }

    /// <summary>
    /// OAuth2 Client ID for IAP
    /// </summary>
    [TerraformProperty("oauth2_client_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Oauth2ClientId { get; set; }

    /// <summary>
    /// OAuth2 Client Secret for IAP
    /// </summary>
    [TerraformProperty("oauth2_client_secret")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Oauth2ClientSecret { get; set; }


}

/// <summary>
/// Block type for log_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeRegionBackendServiceLogConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// Whether to enable logging for the load balancer traffic served by this backend service.
    /// </summary>
    [TerraformProperty("enable")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Enable { get; set; }

    /// <summary>
    /// Specifies the fields to include in logging. This field can only be specified if logging is enabled for this backend service.
    /// </summary>
    [TerraformProperty("optional_fields")]
    // Optional+Computed - source generator will implement get/set
    public TerraformList<string> OptionalFields { get; set; }

    /// <summary>
    /// Specifies the optional logging mode for the load balancer traffic.
    /// Supported values: INCLUDE_ALL_OPTIONAL, EXCLUDE_ALL_OPTIONAL, CUSTOM. Possible values: [&amp;quot;INCLUDE_ALL_OPTIONAL&amp;quot;, &amp;quot;EXCLUDE_ALL_OPTIONAL&amp;quot;, &amp;quot;CUSTOM&amp;quot;]
    /// </summary>
    [TerraformProperty("optional_mode")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> OptionalMode { get; set; }

    /// <summary>
    /// This field can only be specified if logging is enabled for this backend service. The value of
    /// the field must be in [0, 1]. This configures the sampling rate of requests to the load balancer
    /// where 1.0 means all logged requests are reported and 0.0 means no logged requests are reported.
    /// The default value is 1.0.
    /// </summary>
    [TerraformProperty("sample_rate")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? SampleRate { get; set; }

}

/// <summary>
/// Block type for outlier_detection in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeRegionBackendServiceOutlierDetectionBlock : TerraformBlockBase
{
    /// <summary>
    /// Number of errors before a host is ejected from the connection pool. When the
    /// backend host is accessed over HTTP, a 5xx return code qualifies as an error.
    /// Defaults to 5.
    /// </summary>
    [TerraformProperty("consecutive_errors")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? ConsecutiveErrors { get; set; }

    /// <summary>
    /// The number of consecutive gateway failures (502, 503, 504 status or connection
    /// errors that are mapped to one of those status codes) before a consecutive
    /// gateway failure ejection occurs. Defaults to 5.
    /// </summary>
    [TerraformProperty("consecutive_gateway_failure")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? ConsecutiveGatewayFailure { get; set; }

    /// <summary>
    /// The percentage chance that a host will be actually ejected when an outlier
    /// status is detected through consecutive 5xx. This setting can be used to disable
    /// ejection or to ramp it up slowly. Defaults to 100.
    /// </summary>
    [TerraformProperty("enforcing_consecutive_errors")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? EnforcingConsecutiveErrors { get; set; }

    /// <summary>
    /// The percentage chance that a host will be actually ejected when an outlier
    /// status is detected through consecutive gateway failures. This setting can be
    /// used to disable ejection or to ramp it up slowly. Defaults to 0.
    /// </summary>
    [TerraformProperty("enforcing_consecutive_gateway_failure")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? EnforcingConsecutiveGatewayFailure { get; set; }

    /// <summary>
    /// The percentage chance that a host will be actually ejected when an outlier
    /// status is detected through success rate statistics. This setting can be used to
    /// disable ejection or to ramp it up slowly. Defaults to 100.
    /// </summary>
    [TerraformProperty("enforcing_success_rate")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? EnforcingSuccessRate { get; set; }

    /// <summary>
    /// Maximum percentage of hosts in the load balancing pool for the backend service
    /// that can be ejected. Defaults to 10%.
    /// </summary>
    [TerraformProperty("max_ejection_percent")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MaxEjectionPercent { get; set; }

    /// <summary>
    /// The number of hosts in a cluster that must have enough request volume to detect
    /// success rate outliers. If the number of hosts is less than this setting, outlier
    /// detection via success rate statistics is not performed for any host in the
    /// cluster. Defaults to 5.
    /// </summary>
    [TerraformProperty("success_rate_minimum_hosts")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? SuccessRateMinimumHosts { get; set; }

    /// <summary>
    /// The minimum number of total requests that must be collected in one interval (as
    /// defined by the interval duration above) to include this host in success rate
    /// based outlier detection. If the volume is lower than this setting, outlier
    /// detection via success rate statistics is not performed for that host. Defaults
    /// to 100.
    /// </summary>
    [TerraformProperty("success_rate_request_volume")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? SuccessRateRequestVolume { get; set; }

    /// <summary>
    /// This factor is used to determine the ejection threshold for success rate outlier
    /// ejection. The ejection threshold is the difference between the mean success
    /// rate, and the product of this factor and the standard deviation of the mean
    /// success rate: mean - (stdev * success_rate_stdev_factor). This factor is divided
    /// by a thousand to get a double. That is, if the desired factor is 1.9, the
    /// runtime value should be 1900. Defaults to 1900.
    /// </summary>
    [TerraformProperty("success_rate_stdev_factor")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? SuccessRateStdevFactor { get; set; }

}

/// <summary>
/// Block type for params in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeRegionBackendServiceParamsBlock : TerraformBlockBase
{
    /// <summary>
    /// Resource manager tags to be bound to the region backend service. Tag keys and values have the
    /// same definition as resource manager tags. Keys must be in the format tagKeys/{tag_key_id},
    /// and values are in the format tagValues/456.
    /// </summary>
    [TerraformProperty("resource_manager_tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? ResourceManagerTags { get; set; }

}

/// <summary>
/// Block type for strong_session_affinity_cookie in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeRegionBackendServiceStrongSessionAffinityCookieBlock : TerraformBlockBase
{
    /// <summary>
    /// Name of the cookie.
    /// </summary>
    [TerraformProperty("name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// Path to set for the cookie.
    /// </summary>
    [TerraformProperty("path")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Path { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleComputeRegionBackendServiceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_compute_region_backend_service resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleComputeRegionBackendService : TerraformResource
{
    public GoogleComputeRegionBackendService(string name) : base("google_compute_region_backend_service", name)
    {
    }

    /// <summary>
    /// Lifetime of cookies in seconds if session_affinity is
    /// GENERATED_COOKIE. If set to 0, the cookie is non-persistent and lasts
    /// only until the end of the browser session (or equivalent). The
    /// maximum allowed value for TTL is one day.
    /// 
    /// When the load balancing scheme is INTERNAL, this field is not used.
    /// </summary>
    [TerraformProperty("affinity_cookie_ttl_sec")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? AffinityCookieTtlSec { get; set; }

    /// <summary>
    /// Time for which instance will be drained (not accept new
    /// connections, but still work to finish started).
    /// </summary>
    [TerraformProperty("connection_draining_timeout_sec")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? ConnectionDrainingTimeoutSec { get; set; }

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// If true, enable Cloud CDN for this RegionBackendService.
    /// </summary>
    [TerraformProperty("enable_cdn")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? EnableCdn { get; set; }

    /// <summary>
    /// The set of URLs to HealthCheck resources for health checking
    /// this RegionBackendService. Currently at most one health
    /// check can be specified.
    /// 
    /// A health check must be specified unless the backend service uses an internet
    /// or serverless NEG as a backend.
    /// </summary>
    [TerraformProperty("health_checks")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? HealthChecks { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Specifies preference of traffic to the backend (from the proxy and from the client for proxyless gRPC). Possible values: [&amp;quot;IPV4_ONLY&amp;quot;, &amp;quot;PREFER_IPV6&amp;quot;, &amp;quot;IPV6_ONLY&amp;quot;]
    /// </summary>
    [TerraformProperty("ip_address_selection_policy")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? IpAddressSelectionPolicy { get; set; }

    /// <summary>
    /// Indicates what kind of load balancing this regional backend service
    /// will be used for. A backend service created for one type of load
    /// balancing cannot be used with the other(s). For more information, refer to
    /// [Choosing a load balancer](https://cloud.google.com/load-balancing/docs/backend-service). Default value: &amp;quot;INTERNAL&amp;quot; Possible values: [&amp;quot;EXTERNAL&amp;quot;, &amp;quot;EXTERNAL_MANAGED&amp;quot;, &amp;quot;INTERNAL&amp;quot;, &amp;quot;INTERNAL_MANAGED&amp;quot;]
    /// </summary>
    [TerraformProperty("load_balancing_scheme")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? LoadBalancingScheme { get; set; }

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
    [TerraformProperty("locality_lb_policy")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? LocalityLbPolicy { get; set; }

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
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The URL of the network to which this backend service belongs.
    /// This field must be set for Internal Passthrough Network Load Balancers when the haPolicy is enabled, and for External Passthrough Network Load Balancers when the haPolicy fastIpMove is enabled.
    /// This field can only be specified when the load balancing scheme is set to INTERNAL, or when the load balancing scheme is set to EXTERNAL and haPolicy fastIpMove is enabled.
    /// Changes to this field force recreation of the resource.
    /// </summary>
    [TerraformProperty("network")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Network { get; set; }

    /// <summary>
    /// A named port on a backend instance group representing the port for
    /// communication to the backend VMs in that group. Required when the
    /// loadBalancingScheme is EXTERNAL, EXTERNAL_MANAGED, INTERNAL_MANAGED, or INTERNAL_SELF_MANAGED
    /// and the backends are instance groups. The named port must be defined on each
    /// backend instance group. This parameter has no meaning if the backends are NEGs. API sets a
    /// default of &amp;quot;http&amp;quot; if not given.
    /// Must be omitted when the loadBalancingScheme is INTERNAL (Internal TCP/UDP Load Balancing).
    /// </summary>
    [TerraformProperty("port_name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> PortName { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The protocol this BackendService uses to communicate with backends.
    /// The default is HTTP. Possible values are HTTP, HTTPS, HTTP2, H2C, TCP, SSL, UDP
    /// or GRPC. Refer to the documentation for the load balancers or for Traffic Director
    /// for more information. Possible values: [&amp;quot;HTTP&amp;quot;, &amp;quot;HTTPS&amp;quot;, &amp;quot;HTTP2&amp;quot;, &amp;quot;TCP&amp;quot;, &amp;quot;SSL&amp;quot;, &amp;quot;UDP&amp;quot;, &amp;quot;GRPC&amp;quot;, &amp;quot;UNSPECIFIED&amp;quot;, &amp;quot;H2C&amp;quot;]
    /// </summary>
    [TerraformProperty("protocol")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Protocol { get; set; }

    /// <summary>
    /// The Region in which the created backend service should reside.
    /// If it is not provided, the provider region is used.
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The security policy associated with this backend service.
    /// </summary>
    [TerraformProperty("security_policy")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SecurityPolicy { get; set; }

    /// <summary>
    /// Type of session affinity to use. The default is NONE. Session affinity is
    /// not applicable if the protocol is UDP. Possible values: [&amp;quot;NONE&amp;quot;, &amp;quot;CLIENT_IP&amp;quot;, &amp;quot;CLIENT_IP_PORT_PROTO&amp;quot;, &amp;quot;CLIENT_IP_PROTO&amp;quot;, &amp;quot;GENERATED_COOKIE&amp;quot;, &amp;quot;HEADER_FIELD&amp;quot;, &amp;quot;HTTP_COOKIE&amp;quot;, &amp;quot;CLIENT_IP_NO_DESTINATION&amp;quot;, &amp;quot;STRONG_COOKIE_AFFINITY&amp;quot;]
    /// </summary>
    [TerraformProperty("session_affinity")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> SessionAffinity { get; set; }

    /// <summary>
    /// The backend service timeout has a different meaning depending on the type of load balancer.
    /// For more information see, [Backend service settings](https://cloud.google.com/compute/docs/reference/rest/v1/backendServices).
    /// The default is 30 seconds.
    /// The full range of timeout values allowed goes from 1 through 2,147,483,647 seconds.
    /// </summary>
    [TerraformProperty("timeout_sec")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> TimeoutSec { get; set; }

    /// <summary>
    /// Block for backend.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("backend")]
    public TerraformSet<TerraformBlock<GoogleComputeRegionBackendServiceBackendBlock>>? Backend { get; set; }

    /// <summary>
    /// Block for cdn_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CdnPolicy block(s) allowed")]
    [TerraformProperty("cdn_policy")]
    public TerraformList<TerraformBlock<GoogleComputeRegionBackendServiceCdnPolicyBlock>>? CdnPolicy { get; set; }

    /// <summary>
    /// Block for circuit_breakers.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CircuitBreakers block(s) allowed")]
    [TerraformProperty("circuit_breakers")]
    public TerraformList<TerraformBlock<GoogleComputeRegionBackendServiceCircuitBreakersBlock>>? CircuitBreakers { get; set; }

    /// <summary>
    /// Block for consistent_hash.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConsistentHash block(s) allowed")]
    [TerraformProperty("consistent_hash")]
    public TerraformList<TerraformBlock<GoogleComputeRegionBackendServiceConsistentHashBlock>>? ConsistentHash { get; set; }

    /// <summary>
    /// Block for custom_metrics.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("custom_metrics")]
    public TerraformList<TerraformBlock<GoogleComputeRegionBackendServiceCustomMetricsBlock>>? CustomMetrics { get; set; }

    /// <summary>
    /// Block for failover_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FailoverPolicy block(s) allowed")]
    [TerraformProperty("failover_policy")]
    public TerraformList<TerraformBlock<GoogleComputeRegionBackendServiceFailoverPolicyBlock>>? FailoverPolicy { get; set; }

    /// <summary>
    /// Block for ha_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HaPolicy block(s) allowed")]
    [TerraformProperty("ha_policy")]
    public TerraformList<TerraformBlock<GoogleComputeRegionBackendServiceHaPolicyBlock>>? HaPolicy { get; set; }

    /// <summary>
    /// Block for iap.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Iap block(s) allowed")]
    [TerraformProperty("iap")]
    public TerraformList<TerraformBlock<GoogleComputeRegionBackendServiceIapBlock>>? Iap { get; set; }

    /// <summary>
    /// Block for log_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LogConfig block(s) allowed")]
    [TerraformProperty("log_config")]
    public TerraformList<TerraformBlock<GoogleComputeRegionBackendServiceLogConfigBlock>>? LogConfig { get; set; }

    /// <summary>
    /// Block for outlier_detection.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OutlierDetection block(s) allowed")]
    [TerraformProperty("outlier_detection")]
    public TerraformList<TerraformBlock<GoogleComputeRegionBackendServiceOutlierDetectionBlock>>? OutlierDetection { get; set; }

    /// <summary>
    /// Block for params.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Params block(s) allowed")]
    [TerraformProperty("params")]
    public TerraformList<TerraformBlock<GoogleComputeRegionBackendServiceParamsBlock>>? Params { get; set; }

    /// <summary>
    /// Block for strong_session_affinity_cookie.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StrongSessionAffinityCookie block(s) allowed")]
    [TerraformProperty("strong_session_affinity_cookie")]
    public TerraformList<TerraformBlock<GoogleComputeRegionBackendServiceStrongSessionAffinityCookieBlock>>? StrongSessionAffinityCookie { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleComputeRegionBackendServiceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    [TerraformProperty("creation_timestamp")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreationTimestamp { get; }

    /// <summary>
    /// Fingerprint of this resource. A hash of the contents stored in this
    /// object. This field is used in optimistic locking.
    /// </summary>
    [TerraformProperty("fingerprint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Fingerprint { get; }

    /// <summary>
    /// The unique identifier for the resource. This identifier is defined by the server.
    /// </summary>
    [TerraformProperty("generated_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> GeneratedId { get; }

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    [TerraformProperty("self_link")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SelfLink { get; }

}
