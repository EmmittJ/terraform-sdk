using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleNetworkServicesGatewayTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a google_network_services_gateway resource.
/// </summary>
public class GoogleNetworkServicesGateway : TerraformResource
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
    [TerraformPropertyName("addresses")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<List<TerraformProperty<string>>> Addresses { get; set; } = new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "addresses");

    /// <summary>
    /// A fully-qualified Certificates URL reference. The proxy presents a Certificate (selected based on SNI) when establishing a TLS connection.
    /// This feature only applies to gateways of type &#39;SECURE_WEB_GATEWAY&#39;.
    /// </summary>
    [TerraformPropertyName("certificate_urls")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? CertificateUrls { get; set; }

    /// <summary>
    /// When deleting a gateway of type &#39;SECURE_WEB_GATEWAY&#39;, this boolean option will also delete auto generated router by the gateway creation.
    /// If there is no other gateway of type &#39;SECURE_WEB_GATEWAY&#39; remaining for that region and network it will be deleted.
    /// </summary>
    [TerraformPropertyName("delete_swg_autogen_router_on_destroy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DeleteSwgAutogenRouterOnDestroy { get; set; }

    /// <summary>
    /// A free-text description of the resource. Max length 1024 characters.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// Determines if envoy will insert internal debug headers into upstream requests.
    /// Other Envoy headers may still be injected.
    /// By default, envoy will not insert any debug headers. Possible values: [&amp;quot;NONE&amp;quot;, &amp;quot;DEBUG_HEADERS&amp;quot;]
    /// </summary>
    [TerraformPropertyName("envoy_headers")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? EnvoyHeaders { get; set; }

    /// <summary>
    /// A fully-qualified GatewaySecurityPolicy URL reference. Defines how a server should apply security policy to inbound (VM to Proxy) initiated connections.
    /// For example: &#39;projects/*/locations/*/gatewaySecurityPolicies/swg-policy&#39;.
    /// This policy is specific to gateways of type &#39;SECURE_WEB_GATEWAY&#39;.
    /// </summary>
    [TerraformPropertyName("gateway_security_policy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? GatewaySecurityPolicy { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The IP Version that will be used by this gateway. Possible values: [&amp;quot;IPV4&amp;quot;, &amp;quot;IPV6&amp;quot;]
    /// </summary>
    [TerraformPropertyName("ip_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? IpVersion { get; set; }

    /// <summary>
    /// Set of label tags associated with the Gateway resource.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Labels { get; set; }

    /// <summary>
    /// The location of the gateway.
    /// The default value is &#39;global&#39;.
    /// </summary>
    [TerraformPropertyName("location")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Location { get; set; }

    /// <summary>
    /// Name of the Gateway resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The relative resource name identifying the VPC network that is using this configuration.
    /// For example: &#39;projects/*/global/networks/network-1&#39;.
    /// 
    /// Currently, this field is specific to gateways of type &#39;SECURE_WEB_GATEWAY&#39;.
    /// </summary>
    [TerraformPropertyName("network")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Network { get; set; }

    /// <summary>
    /// One or more port numbers (1-65535), on which the Gateway will receive traffic.
    /// The proxy binds to the specified ports. Gateways of type &#39;SECURE_WEB_GATEWAY&#39; are limited to 1 port.
    ///  Gateways of type &#39;OPEN_MESH&#39; listen on 0.0.0.0 for IPv4 and :: for IPv6 and support multiple ports.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Ports is required")]
    [TerraformPropertyName("ports")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<List<TerraformProperty<double>>>? Ports { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// The routing mode of the Gateway. This field is configurable only for gateways of type SECURE_WEB_GATEWAY. This field is required for gateways of type SECURE_WEB_GATEWAY. Possible values: [&amp;quot;NEXT_HOP_ROUTING_MODE&amp;quot;, &amp;quot;EXPLICIT_ROUTING_MODE&amp;quot;]
    /// </summary>
    [TerraformPropertyName("routing_mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RoutingMode { get; set; }

    /// <summary>
    /// Immutable. Scope determines how configuration across multiple Gateway instances are merged.
    /// The configuration for multiple Gateway instances with the same scope will be merged as presented as a single coniguration to the proxy/load balancer.
    /// 
    /// Max length 64 characters. Scope should start with a letter and can only have letters, numbers, hyphens.
    /// </summary>
    [TerraformPropertyName("scope")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Scope { get; set; }

    /// <summary>
    /// A fully-qualified ServerTLSPolicy URL reference. Specifies how TLS traffic is terminated. If empty, TLS termination is disabled.
    /// </summary>
    [TerraformPropertyName("server_tls_policy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ServerTlsPolicy { get; set; }

    /// <summary>
    /// The relative resource name identifying the subnetwork in which this SWG is allocated.
    /// For example: projects/*/regions/us-central1/subnetworks/network-1.
    /// 
    /// Currently, this field is specific to gateways of type &#39;SECURE_WEB_GATEWAY&#39;.
    /// </summary>
    [TerraformPropertyName("subnetwork")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Subnetwork { get; set; }

    /// <summary>
    /// Immutable. The type of the customer managed gateway. Possible values: [&amp;quot;OPEN_MESH&amp;quot;, &amp;quot;SECURE_WEB_GATEWAY&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleNetworkServicesGatewayTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The timestamp when the resource was created.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_labels");

    /// <summary>
    /// Server-defined URL of this resource.
    /// </summary>
    [TerraformPropertyName("self_link")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SelfLink => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "self_link");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TerraformLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "terraform_labels");

    /// <summary>
    /// The timestamp when the resource was updated.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "update_time");

}
