using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleNetworkServicesGateway.
/// Nesting mode: single
/// </summary>
public class GoogleNetworkServicesGatewayTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_network_services_gateway Terraform resource.
/// Manages a google_network_services_gateway resource.
/// </summary>
public partial class GoogleNetworkServicesGateway(string name) : TerraformResource("google_network_services_gateway", name)
{
    /// <summary>
    /// Zero or one IPv4 or IPv6 address on which the Gateway will receive the traffic.
    /// When no address is provided, an IP from the subnetwork is allocated.
    /// 
    /// This field only applies to gateways of type &#39;SECURE_WEB_GATEWAY&#39;.
    /// Gateways of type &#39;OPEN_MESH&#39; listen on 0.0.0.0 for IPv4 and :: for IPv6.
    /// </summary>
    public TerraformList<string>? Addresses
    {
        get => GetArgument<TerraformList<string>>("addresses");
        set => SetArgument("addresses", value);
    }

    /// <summary>
    /// A fully-qualified Certificates URL reference. The proxy presents a Certificate (selected based on SNI) when establishing a TLS connection.
    /// This feature only applies to gateways of type &#39;SECURE_WEB_GATEWAY&#39;.
    /// </summary>
    public TerraformList<string>? CertificateUrls
    {
        get => GetArgument<TerraformList<string>>("certificate_urls");
        set => SetArgument("certificate_urls", value);
    }

    /// <summary>
    /// When deleting a gateway of type &#39;SECURE_WEB_GATEWAY&#39;, this boolean option will also delete auto generated router by the gateway creation.
    /// If there is no other gateway of type &#39;SECURE_WEB_GATEWAY&#39; remaining for that region and network it will be deleted.
    /// </summary>
    public TerraformValue<bool>? DeleteSwgAutogenRouterOnDestroy
    {
        get => GetArgument<TerraformValue<bool>>("delete_swg_autogen_router_on_destroy");
        set => SetArgument("delete_swg_autogen_router_on_destroy", value);
    }

    /// <summary>
    /// A free-text description of the resource. Max length 1024 characters.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Determines if envoy will insert internal debug headers into upstream requests.
    /// Other Envoy headers may still be injected.
    /// By default, envoy will not insert any debug headers. Possible values: [&amp;quot;NONE&amp;quot;, &amp;quot;DEBUG_HEADERS&amp;quot;]
    /// </summary>
    public TerraformValue<string>? EnvoyHeaders
    {
        get => GetArgument<TerraformValue<string>>("envoy_headers");
        set => SetArgument("envoy_headers", value);
    }

    /// <summary>
    /// A fully-qualified GatewaySecurityPolicy URL reference. Defines how a server should apply security policy to inbound (VM to Proxy) initiated connections.
    /// For example: &#39;projects/*/locations/*/gatewaySecurityPolicies/swg-policy&#39;.
    /// This policy is specific to gateways of type &#39;SECURE_WEB_GATEWAY&#39;.
    /// </summary>
    public TerraformValue<string>? GatewaySecurityPolicy
    {
        get => GetArgument<TerraformValue<string>>("gateway_security_policy");
        set => SetArgument("gateway_security_policy", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The IP Version that will be used by this gateway. Possible values: [&amp;quot;IPV4&amp;quot;, &amp;quot;IPV6&amp;quot;]
    /// </summary>
    public TerraformValue<string>? IpVersion
    {
        get => GetArgument<TerraformValue<string>>("ip_version");
        set => SetArgument("ip_version", value);
    }

    /// <summary>
    /// Set of label tags associated with the Gateway resource.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The location of the gateway.
    /// The default value is &#39;global&#39;.
    /// </summary>
    public TerraformValue<string>? Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// Name of the Gateway resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The relative resource name identifying the VPC network that is using this configuration.
    /// For example: &#39;projects/*/global/networks/network-1&#39;.
    /// 
    /// Currently, this field is specific to gateways of type &#39;SECURE_WEB_GATEWAY&#39;.
    /// </summary>
    public TerraformValue<string>? Network
    {
        get => GetArgument<TerraformValue<string>>("network");
        set => SetArgument("network", value);
    }

    /// <summary>
    /// One or more port numbers (1-65535), on which the Gateway will receive traffic.
    /// The proxy binds to the specified ports. Gateways of type &#39;SECURE_WEB_GATEWAY&#39; are limited to 1 port.
    ///  Gateways of type &#39;OPEN_MESH&#39; listen on 0.0.0.0 for IPv4 and :: for IPv6 and support multiple ports.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Ports is required")]
    public TerraformList<double>? Ports
    {
        get => GetArgument<TerraformList<double>>("ports");
        set => SetArgument("ports", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The routing mode of the Gateway. This field is configurable only for gateways of type SECURE_WEB_GATEWAY. This field is required for gateways of type SECURE_WEB_GATEWAY. Possible values: [&amp;quot;NEXT_HOP_ROUTING_MODE&amp;quot;, &amp;quot;EXPLICIT_ROUTING_MODE&amp;quot;]
    /// </summary>
    public TerraformValue<string>? RoutingMode
    {
        get => GetArgument<TerraformValue<string>>("routing_mode");
        set => SetArgument("routing_mode", value);
    }

    /// <summary>
    /// Immutable. Scope determines how configuration across multiple Gateway instances are merged.
    /// The configuration for multiple Gateway instances with the same scope will be merged as presented as a single coniguration to the proxy/load balancer.
    /// 
    /// Max length 64 characters. Scope should start with a letter and can only have letters, numbers, hyphens.
    /// </summary>
    public TerraformValue<string>? Scope
    {
        get => GetArgument<TerraformValue<string>>("scope");
        set => SetArgument("scope", value);
    }

    /// <summary>
    /// A fully-qualified ServerTLSPolicy URL reference. Specifies how TLS traffic is terminated. If empty, TLS termination is disabled.
    /// </summary>
    public TerraformValue<string>? ServerTlsPolicy
    {
        get => GetArgument<TerraformValue<string>>("server_tls_policy");
        set => SetArgument("server_tls_policy", value);
    }

    /// <summary>
    /// The relative resource name identifying the subnetwork in which this SWG is allocated.
    /// For example: projects/*/regions/us-central1/subnetworks/network-1.
    /// 
    /// Currently, this field is specific to gateways of type &#39;SECURE_WEB_GATEWAY&#39;.
    /// </summary>
    public TerraformValue<string>? Subnetwork
    {
        get => GetArgument<TerraformValue<string>>("subnetwork");
        set => SetArgument("subnetwork", value);
    }

    /// <summary>
    /// Immutable. The type of the customer managed gateway. Possible values: [&amp;quot;OPEN_MESH&amp;quot;, &amp;quot;SECURE_WEB_GATEWAY&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The timestamp when the resource was created.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => AsReference("effective_labels");

    /// <summary>
    /// Server-defined URL of this resource.
    /// </summary>
    public TerraformValue<string> SelfLink
        => AsReference("self_link");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => AsReference("terraform_labels");

    /// <summary>
    /// The timestamp when the resource was updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleNetworkServicesGatewayTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleNetworkServicesGatewayTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
