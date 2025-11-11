using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for interface in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeExternalVpnGatewayInterfaceBlock : TerraformBlockBase
{
    /// <summary>
    /// The numeric ID for this interface. Allowed values are based on the redundancy type
    /// of this external VPN gateway
    /// * &#39;0 - SINGLE_IP_INTERNALLY_REDUNDANT&#39;
    /// * &#39;0, 1 - TWO_IPS_REDUNDANCY&#39;
    /// * &#39;0, 1, 2, 3 - FOUR_IPS_REDUNDANCY&#39;
    /// </summary>
    [TerraformProperty("id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Id { get; set; }

    /// <summary>
    /// IP address of the interface in the external VPN gateway.
    /// Only IPv4 is supported. This IP address can be either from
    /// your on-premise gateway or another Cloud provider&#39;s VPN gateway,
    /// it cannot be an IP address from Google Compute Engine.
    /// </summary>
    [TerraformProperty("ip_address")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? IpAddress { get; set; }

    /// <summary>
    /// IPv6 address of the interface in the external VPN gateway. This IPv6
    /// address can be either from your on-premise gateway or another Cloud
    /// provider&#39;s VPN gateway, it cannot be an IP address from Google Compute
    /// Engine. Must specify an IPv6 address (not IPV4-mapped) using any format
    /// described in RFC 4291 (e.g. 2001:db8:0:0:2d9:51:0:0). The output format
    /// is RFC 5952 format (e.g. 2001:db8::2d9:51:0:0).
    /// </summary>
    [TerraformProperty("ipv6_address")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Ipv6Address { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleComputeExternalVpnGatewayTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_compute_external_vpn_gateway resource.
/// </summary>
public partial class GoogleComputeExternalVpnGateway : TerraformResource
{
    public GoogleComputeExternalVpnGateway(string name) : base("google_compute_external_vpn_gateway", name)
    {
    }

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Labels for the external VPN gateway resource.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

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
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Indicates the redundancy type of this external VPN gateway Possible values: [&amp;quot;FOUR_IPS_REDUNDANCY&amp;quot;, &amp;quot;SINGLE_IP_INTERNALLY_REDUNDANT&amp;quot;, &amp;quot;TWO_IPS_REDUNDANCY&amp;quot;]
    /// </summary>
    [TerraformProperty("redundancy_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RedundancyType { get; set; }

    /// <summary>
    /// Block for interface.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("interface")]
    public partial TerraformList<TerraformBlock<GoogleComputeExternalVpnGatewayInterfaceBlock>>? Interface { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleComputeExternalVpnGatewayTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// The fingerprint used for optimistic locking of this resource.  Used
    /// internally during updates.
    /// </summary>
    [TerraformProperty("label_fingerprint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LabelFingerprint { get; }

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    [TerraformProperty("self_link")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SelfLink { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TerraformLabels { get; }

}
