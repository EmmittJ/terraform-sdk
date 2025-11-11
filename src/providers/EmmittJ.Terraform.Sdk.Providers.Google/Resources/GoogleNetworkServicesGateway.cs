using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleNetworkServicesGatewayTimeoutsBlock : TerraformBlockBase
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
/// Manages a google_network_services_gateway resource.
/// </summary>
public partial class GoogleNetworkServicesGateway : TerraformResource
{
    public GoogleNetworkServicesGateway(string name) : base("google_network_services_gateway", name)
    {
    }

    /// <summary>
    /// Zero or one IPv4 or IPv6 address on which the Gateway will receive the traffic.
    /// When no address is provided, an IP from the subnetwork is allocated.
    /// 
    /// This field only applies to gateways of type &#39;SECURE_WEB_GATEWAY&#39;.
    /// Gateways of type &#39;OPEN_MESH&#39; listen on 0.0.0.0 for IPv4 and :: for IPv6.
    /// </summary>
    [TerraformProperty("addresses")]
    // Optional+Computed - source generator will implement get/set
    public TerraformList<string> Addresses { get; set; }

    /// <summary>
    /// A fully-qualified Certificates URL reference. The proxy presents a Certificate (selected based on SNI) when establishing a TLS connection.
    /// This feature only applies to gateways of type &#39;SECURE_WEB_GATEWAY&#39;.
    /// </summary>
    [TerraformProperty("certificate_urls")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? CertificateUrls { get; set; }

    /// <summary>
    /// When deleting a gateway of type &#39;SECURE_WEB_GATEWAY&#39;, this boolean option will also delete auto generated router by the gateway creation.
    /// If there is no other gateway of type &#39;SECURE_WEB_GATEWAY&#39; remaining for that region and network it will be deleted.
    /// </summary>
    [TerraformProperty("delete_swg_autogen_router_on_destroy")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? DeleteSwgAutogenRouterOnDestroy { get; set; }

    /// <summary>
    /// A free-text description of the resource. Max length 1024 characters.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// Determines if envoy will insert internal debug headers into upstream requests.
    /// Other Envoy headers may still be injected.
    /// By default, envoy will not insert any debug headers. Possible values: [&amp;quot;NONE&amp;quot;, &amp;quot;DEBUG_HEADERS&amp;quot;]
    /// </summary>
    [TerraformProperty("envoy_headers")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? EnvoyHeaders { get; set; }

    /// <summary>
    /// A fully-qualified GatewaySecurityPolicy URL reference. Defines how a server should apply security policy to inbound (VM to Proxy) initiated connections.
    /// For example: &#39;projects/*/locations/*/gatewaySecurityPolicies/swg-policy&#39;.
    /// This policy is specific to gateways of type &#39;SECURE_WEB_GATEWAY&#39;.
    /// </summary>
    [TerraformProperty("gateway_security_policy")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? GatewaySecurityPolicy { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The IP Version that will be used by this gateway. Possible values: [&amp;quot;IPV4&amp;quot;, &amp;quot;IPV6&amp;quot;]
    /// </summary>
    [TerraformProperty("ip_version")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? IpVersion { get; set; }

    /// <summary>
    /// Set of label tags associated with the Gateway resource.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The location of the gateway.
    /// The default value is &#39;global&#39;.
    /// </summary>
    [TerraformProperty("location")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Location { get; set; }

    /// <summary>
    /// Name of the Gateway resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The relative resource name identifying the VPC network that is using this configuration.
    /// For example: &#39;projects/*/global/networks/network-1&#39;.
    /// 
    /// Currently, this field is specific to gateways of type &#39;SECURE_WEB_GATEWAY&#39;.
    /// </summary>
    [TerraformProperty("network")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Network { get; set; }

    /// <summary>
    /// One or more port numbers (1-65535), on which the Gateway will receive traffic.
    /// The proxy binds to the specified ports. Gateways of type &#39;SECURE_WEB_GATEWAY&#39; are limited to 1 port.
    ///  Gateways of type &#39;OPEN_MESH&#39; listen on 0.0.0.0 for IPv4 and :: for IPv6 and support multiple ports.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Ports is required")]
    [TerraformProperty("ports")]
    // Required argument - source generator will implement get/set
    public TerraformList<double>? Ports { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The routing mode of the Gateway. This field is configurable only for gateways of type SECURE_WEB_GATEWAY. This field is required for gateways of type SECURE_WEB_GATEWAY. Possible values: [&amp;quot;NEXT_HOP_ROUTING_MODE&amp;quot;, &amp;quot;EXPLICIT_ROUTING_MODE&amp;quot;]
    /// </summary>
    [TerraformProperty("routing_mode")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? RoutingMode { get; set; }

    /// <summary>
    /// Immutable. Scope determines how configuration across multiple Gateway instances are merged.
    /// The configuration for multiple Gateway instances with the same scope will be merged as presented as a single coniguration to the proxy/load balancer.
    /// 
    /// Max length 64 characters. Scope should start with a letter and can only have letters, numbers, hyphens.
    /// </summary>
    [TerraformProperty("scope")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Scope { get; set; }

    /// <summary>
    /// A fully-qualified ServerTLSPolicy URL reference. Specifies how TLS traffic is terminated. If empty, TLS termination is disabled.
    /// </summary>
    [TerraformProperty("server_tls_policy")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ServerTlsPolicy { get; set; }

    /// <summary>
    /// The relative resource name identifying the subnetwork in which this SWG is allocated.
    /// For example: projects/*/regions/us-central1/subnetworks/network-1.
    /// 
    /// Currently, this field is specific to gateways of type &#39;SECURE_WEB_GATEWAY&#39;.
    /// </summary>
    [TerraformProperty("subnetwork")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Subnetwork { get; set; }

    /// <summary>
    /// Immutable. The type of the customer managed gateway. Possible values: [&amp;quot;OPEN_MESH&amp;quot;, &amp;quot;SECURE_WEB_GATEWAY&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Type { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleNetworkServicesGatewayTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The timestamp when the resource was created.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// Server-defined URL of this resource.
    /// </summary>
    [TerraformProperty("self_link")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SelfLink { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> TerraformLabels { get; }

    /// <summary>
    /// The timestamp when the resource was updated.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UpdateTime { get; }

}
