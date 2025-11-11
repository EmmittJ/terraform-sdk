using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for cipher_suite in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeVpnTunnelCipherSuiteBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleComputeVpnTunnelTimeoutsBlock : TerraformBlockBase
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
/// Manages a google_compute_vpn_tunnel resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleComputeVpnTunnel : TerraformResource
{
    public GoogleComputeVpnTunnel(string name) : base("google_compute_vpn_tunnel", name)
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
    /// IKE protocol version to use when establishing the VPN tunnel with
    /// peer VPN gateway.
    /// Acceptable IKE versions are 1 or 2. Default version is 2.
    /// </summary>
    [TerraformProperty("ike_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? IkeVersion { get; set; }

    /// <summary>
    /// Labels to apply to this VpnTunnel.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// Local traffic selector to use when establishing the VPN tunnel with
    /// peer VPN gateway. The value should be a CIDR formatted string,
    /// for example &#39;192.168.0.0/16&#39;. The ranges should be disjoint.
    /// Only IPv4 is supported.
    /// </summary>
    [TerraformProperty("local_traffic_selector")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> LocalTrafficSelector { get; set; }

    /// <summary>
    /// Name of the resource. The name must be 1-63 characters long, and
    /// comply with RFC1035. Specifically, the name must be 1-63
    /// characters long and match the regular expression
    /// &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39; which means the first character
    /// must be a lowercase letter, and all following characters must
    /// be a dash, lowercase letter, or digit,
    /// except the last character, which cannot be a dash.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// URL of the peer side external VPN gateway to which this VPN tunnel is connected.
    /// </summary>
    [TerraformProperty("peer_external_gateway")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PeerExternalGateway { get; set; }

    /// <summary>
    /// The interface ID of the external VPN gateway to which this VPN tunnel is connected.
    /// </summary>
    [TerraformProperty("peer_external_gateway_interface")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? PeerExternalGatewayInterface { get; set; }

    /// <summary>
    /// URL of the peer side HA GCP VPN gateway to which this VPN tunnel is connected.
    /// If provided, the VPN tunnel will automatically use the same vpn_gateway_interface
    /// ID in the peer GCP VPN gateway.
    /// This field must reference a &#39;google_compute_ha_vpn_gateway&#39; resource.
    /// </summary>
    [TerraformProperty("peer_gcp_gateway")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PeerGcpGateway { get; set; }

    /// <summary>
    /// IP address of the peer VPN gateway. Only IPv4 is supported.
    /// </summary>
    [TerraformProperty("peer_ip")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> PeerIp { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The region where the tunnel is located. If unset, is set to the region of &#39;target_vpn_gateway&#39;.
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Remote traffic selector to use when establishing the VPN tunnel with
    /// peer VPN gateway. The value should be a CIDR formatted string,
    /// for example &#39;192.168.0.0/16&#39;. The ranges should be disjoint.
    /// Only IPv4 is supported.
    /// </summary>
    [TerraformProperty("remote_traffic_selector")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> RemoteTrafficSelector { get; set; }

    /// <summary>
    /// URL of router resource to be used for dynamic routing.
    /// </summary>
    [TerraformProperty("router")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Router { get; set; }

    /// <summary>
    /// Shared secret used to set the secure session between the Cloud VPN
    /// gateway and the peer VPN gateway.
    /// </summary>
    [TerraformProperty("shared_secret")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SharedSecret { get; set; }

    /// <summary>
    /// Shared secret used to set the secure session between the Cloud VPN
    /// gateway and the peer VPN gateway.
    ///  Note: This property is write-only and will not be read from the API. For more info see [updating write-only attributes](/docs/providers/google/guides/using_write_only_attributes.html#updating-write-only-attributes)
    /// </summary>
    [TerraformProperty("shared_secret_wo")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SharedSecretWo { get; set; }

    /// <summary>
    /// Triggers update of shared_secret_wo write-only. For more info see [updating write-only attributes](/docs/providers/google/guides/using_write_only_attributes.html#updating-write-only-attributes)
    /// </summary>
    [TerraformProperty("shared_secret_wo_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SharedSecretWoVersion { get; set; }

    /// <summary>
    /// URL of the Target VPN gateway with which this VPN tunnel is
    /// associated.
    /// </summary>
    [TerraformProperty("target_vpn_gateway")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TargetVpnGateway { get; set; }

    /// <summary>
    /// URL of the VPN gateway with which this VPN tunnel is associated.
    /// This must be used if a High Availability VPN gateway resource is created.
    /// This field must reference a &#39;google_compute_ha_vpn_gateway&#39; resource.
    /// </summary>
    [TerraformProperty("vpn_gateway")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? VpnGateway { get; set; }

    /// <summary>
    /// The interface ID of the VPN gateway with which this VPN tunnel is associated.
    /// </summary>
    [TerraformProperty("vpn_gateway_interface")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? VpnGatewayInterface { get; set; }

    /// <summary>
    /// Block for cipher_suite.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CipherSuite block(s) allowed")]
    [TerraformProperty("cipher_suite")]
    public partial TerraformList<TerraformBlock<GoogleComputeVpnTunnelCipherSuiteBlock>>? CipherSuite { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleComputeVpnTunnelTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    [TerraformProperty("creation_timestamp")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreationTimestamp { get; }

    /// <summary>
    /// Detailed status message for the VPN tunnel.
    /// </summary>
    [TerraformProperty("detailed_status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DetailedStatus { get; }

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
    /// Hash of the shared secret.
    /// </summary>
    [TerraformProperty("shared_secret_hash")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SharedSecretHash { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TerraformLabels { get; }

    /// <summary>
    /// The unique identifier for the resource. This identifier is defined by the server.
    /// </summary>
    [TerraformProperty("tunnel_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> TunnelId { get; }

}
