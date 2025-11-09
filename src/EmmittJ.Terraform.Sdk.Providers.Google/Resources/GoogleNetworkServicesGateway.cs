using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_network_services_gateway resource.
/// </summary>
public class GoogleNetworkServicesGateway : TerraformResource
{
    public GoogleNetworkServicesGateway(string name) : base("google_network_services_gateway", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("self_link");
        this.DeclareOutput("terraform_labels");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// Zero or one IPv4 or IPv6 address on which the Gateway will receive the traffic.
    /// When no address is provided, an IP from the subnetwork is allocated.
    /// 
    /// This field only applies to gateways of type &#39;SECURE_WEB_GATEWAY&#39;.
    /// Gateways of type &#39;OPEN_MESH&#39; listen on 0.0.0.0 for IPv4 and :: for IPv6.
    /// </summary>
    public TerraformProperty<List<string>>? Addresses
    {
        get => GetProperty<TerraformProperty<List<string>>>("addresses");
        set => this.WithProperty("addresses", value);
    }

    /// <summary>
    /// A fully-qualified Certificates URL reference. The proxy presents a Certificate (selected based on SNI) when establishing a TLS connection.
    /// This feature only applies to gateways of type &#39;SECURE_WEB_GATEWAY&#39;.
    /// </summary>
    public TerraformProperty<List<string>>? CertificateUrls
    {
        get => GetProperty<TerraformProperty<List<string>>>("certificate_urls");
        set => this.WithProperty("certificate_urls", value);
    }

    /// <summary>
    /// When deleting a gateway of type &#39;SECURE_WEB_GATEWAY&#39;, this boolean option will also delete auto generated router by the gateway creation.
    /// If there is no other gateway of type &#39;SECURE_WEB_GATEWAY&#39; remaining for that region and network it will be deleted.
    /// </summary>
    public TerraformProperty<bool>? DeleteSwgAutogenRouterOnDestroy
    {
        get => GetProperty<TerraformProperty<bool>>("delete_swg_autogen_router_on_destroy");
        set => this.WithProperty("delete_swg_autogen_router_on_destroy", value);
    }

    /// <summary>
    /// A free-text description of the resource. Max length 1024 characters.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// Determines if envoy will insert internal debug headers into upstream requests.
    /// Other Envoy headers may still be injected.
    /// By default, envoy will not insert any debug headers. Possible values: [&amp;quot;NONE&amp;quot;, &amp;quot;DEBUG_HEADERS&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? EnvoyHeaders
    {
        get => GetProperty<TerraformProperty<string>>("envoy_headers");
        set => this.WithProperty("envoy_headers", value);
    }

    /// <summary>
    /// A fully-qualified GatewaySecurityPolicy URL reference. Defines how a server should apply security policy to inbound (VM to Proxy) initiated connections.
    /// For example: &#39;projects/*/locations/*/gatewaySecurityPolicies/swg-policy&#39;.
    /// This policy is specific to gateways of type &#39;SECURE_WEB_GATEWAY&#39;.
    /// </summary>
    public TerraformProperty<string>? GatewaySecurityPolicy
    {
        get => GetProperty<TerraformProperty<string>>("gateway_security_policy");
        set => this.WithProperty("gateway_security_policy", value);
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
    /// The IP Version that will be used by this gateway. Possible values: [&amp;quot;IPV4&amp;quot;, &amp;quot;IPV6&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? IpVersion
    {
        get => GetProperty<TerraformProperty<string>>("ip_version");
        set => this.WithProperty("ip_version", value);
    }

    /// <summary>
    /// Set of label tags associated with the Gateway resource.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMapProperty<string>? Labels
    {
        get => GetProperty<TerraformMapProperty<string>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// The location of the gateway.
    /// The default value is &#39;global&#39;.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// Name of the Gateway resource.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The relative resource name identifying the VPC network that is using this configuration.
    /// For example: &#39;projects/*/global/networks/network-1&#39;.
    /// 
    /// Currently, this field is specific to gateways of type &#39;SECURE_WEB_GATEWAY&#39;.
    /// </summary>
    public TerraformProperty<string>? Network
    {
        get => GetProperty<TerraformProperty<string>>("network");
        set => this.WithProperty("network", value);
    }

    /// <summary>
    /// One or more port numbers (1-65535), on which the Gateway will receive traffic.
    /// The proxy binds to the specified ports. Gateways of type &#39;SECURE_WEB_GATEWAY&#39; are limited to 1 port.
    ///  Gateways of type &#39;OPEN_MESH&#39; listen on 0.0.0.0 for IPv4 and :: for IPv6 and support multiple ports.
    /// </summary>
    public TerraformProperty<List<double>>? Ports
    {
        get => GetProperty<TerraformProperty<List<double>>>("ports");
        set => this.WithProperty("ports", value);
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
    /// The routing mode of the Gateway. This field is configurable only for gateways of type SECURE_WEB_GATEWAY. This field is required for gateways of type SECURE_WEB_GATEWAY. Possible values: [&amp;quot;NEXT_HOP_ROUTING_MODE&amp;quot;, &amp;quot;EXPLICIT_ROUTING_MODE&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? RoutingMode
    {
        get => GetProperty<TerraformProperty<string>>("routing_mode");
        set => this.WithProperty("routing_mode", value);
    }

    /// <summary>
    /// Immutable. Scope determines how configuration across multiple Gateway instances are merged.
    /// The configuration for multiple Gateway instances with the same scope will be merged as presented as a single coniguration to the proxy/load balancer.
    /// 
    /// Max length 64 characters. Scope should start with a letter and can only have letters, numbers, hyphens.
    /// </summary>
    public TerraformProperty<string>? Scope
    {
        get => GetProperty<TerraformProperty<string>>("scope");
        set => this.WithProperty("scope", value);
    }

    /// <summary>
    /// A fully-qualified ServerTLSPolicy URL reference. Specifies how TLS traffic is terminated. If empty, TLS termination is disabled.
    /// </summary>
    public TerraformProperty<string>? ServerTlsPolicy
    {
        get => GetProperty<TerraformProperty<string>>("server_tls_policy");
        set => this.WithProperty("server_tls_policy", value);
    }

    /// <summary>
    /// The relative resource name identifying the subnetwork in which this SWG is allocated.
    /// For example: projects/*/regions/us-central1/subnetworks/network-1.
    /// 
    /// Currently, this field is specific to gateways of type &#39;SECURE_WEB_GATEWAY&#39;.
    /// </summary>
    public TerraformProperty<string>? Subnetwork
    {
        get => GetProperty<TerraformProperty<string>>("subnetwork");
        set => this.WithProperty("subnetwork", value);
    }

    /// <summary>
    /// Immutable. The type of the customer managed gateway. Possible values: [&amp;quot;OPEN_MESH&amp;quot;, &amp;quot;SECURE_WEB_GATEWAY&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// The timestamp when the resource was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// Server-defined URL of this resource.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// The timestamp when the resource was updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
