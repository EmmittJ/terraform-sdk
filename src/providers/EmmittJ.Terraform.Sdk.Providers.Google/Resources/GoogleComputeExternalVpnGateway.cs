using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for interface in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeExternalVpnGatewayInterfaceBlock : ITerraformBlock
{
    /// <summary>
    /// The numeric ID for this interface. Allowed values are based on the redundancy type
    /// of this external VPN gateway
    /// * &#39;0 - SINGLE_IP_INTERNALLY_REDUNDANT&#39;
    /// * &#39;0, 1 - TWO_IPS_REDUNDANCY&#39;
    /// * &#39;0, 1, 2, 3 - FOUR_IPS_REDUNDANCY&#39;
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Id { get; set; }

    /// <summary>
    /// IP address of the interface in the external VPN gateway.
    /// Only IPv4 is supported. This IP address can be either from
    /// your on-premise gateway or another Cloud provider&#39;s VPN gateway,
    /// it cannot be an IP address from Google Compute Engine.
    /// </summary>
    [TerraformPropertyName("ip_address")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? IpAddress { get; set; }

    /// <summary>
    /// IPv6 address of the interface in the external VPN gateway. This IPv6
    /// address can be either from your on-premise gateway or another Cloud
    /// provider&#39;s VPN gateway, it cannot be an IP address from Google Compute
    /// Engine. Must specify an IPv6 address (not IPV4-mapped) using any format
    /// described in RFC 4291 (e.g. 2001:db8:0:0:2d9:51:0:0). The output format
    /// is RFC 5952 format (e.g. 2001:db8::2d9:51:0:0).
    /// </summary>
    [TerraformPropertyName("ipv6_address")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Ipv6Address { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeExternalVpnGatewayTimeoutsBlock : ITerraformBlock
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
/// Manages a google_compute_external_vpn_gateway resource.
/// </summary>
public class GoogleComputeExternalVpnGateway : TerraformResource
{
    public GoogleComputeExternalVpnGateway(string name) : base("google_compute_external_vpn_gateway", name)
    {
    }

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Labels for the external VPN gateway resource.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Labels { get; set; }

    /// <summary>
    /// Name of the resource. Provided by the client when the resource is
    /// created. The name must be 1-63 characters long, and comply with
    /// RFC1035.  Specifically, the name must be 1-63 characters long and
    /// match the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39; which means
    /// the first character must be a lowercase letter, and all following
    /// characters must be a dash, lowercase letter, or digit, except the last
    /// character, which cannot be a dash.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Indicates the redundancy type of this external VPN gateway Possible values: [&amp;quot;FOUR_IPS_REDUNDANCY&amp;quot;, &amp;quot;SINGLE_IP_INTERNALLY_REDUNDANT&amp;quot;, &amp;quot;TWO_IPS_REDUNDANCY&amp;quot;]
    /// </summary>
    [TerraformPropertyName("redundancy_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RedundancyType { get; set; }

    /// <summary>
    /// Block for interface.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("interface")]
    public TerraformList<TerraformBlock<GoogleComputeExternalVpnGatewayInterfaceBlock>>? Interface { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleComputeExternalVpnGatewayTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_labels");

    /// <summary>
    /// The fingerprint used for optimistic locking of this resource.  Used
    /// internally during updates.
    /// </summary>
    [TerraformPropertyName("label_fingerprint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LabelFingerprint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "label_fingerprint");

    /// <summary>
    /// The self_link attribute.
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

}
