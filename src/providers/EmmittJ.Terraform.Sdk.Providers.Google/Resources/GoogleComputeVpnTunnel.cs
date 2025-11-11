using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for cipher_suite in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeVpnTunnelCipherSuiteBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeVpnTunnelTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_compute_vpn_tunnel resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleComputeVpnTunnel : TerraformResource
{
    public GoogleComputeVpnTunnel(string name) : base("google_compute_vpn_tunnel", name)
    {
    }

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// IKE protocol version to use when establishing the VPN tunnel with
    /// peer VPN gateway.
    /// Acceptable IKE versions are 1 or 2. Default version is 2.
    /// </summary>
    [TerraformPropertyName("ike_version")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? IkeVersion { get; set; }

    /// <summary>
    /// Labels to apply to this VpnTunnel.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// Local traffic selector to use when establishing the VPN tunnel with
    /// peer VPN gateway. The value should be a CIDR formatted string,
    /// for example &#39;192.168.0.0/16&#39;. The ranges should be disjoint.
    /// Only IPv4 is supported.
    /// </summary>
    [TerraformPropertyName("local_traffic_selector")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<string> LocalTrafficSelector { get; set; } = default!;

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
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// URL of the peer side external VPN gateway to which this VPN tunnel is connected.
    /// </summary>
    [TerraformPropertyName("peer_external_gateway")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PeerExternalGateway { get; set; }

    /// <summary>
    /// The interface ID of the external VPN gateway to which this VPN tunnel is connected.
    /// </summary>
    [TerraformPropertyName("peer_external_gateway_interface")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? PeerExternalGatewayInterface { get; set; }

    /// <summary>
    /// URL of the peer side HA GCP VPN gateway to which this VPN tunnel is connected.
    /// If provided, the VPN tunnel will automatically use the same vpn_gateway_interface
    /// ID in the peer GCP VPN gateway.
    /// This field must reference a &#39;google_compute_ha_vpn_gateway&#39; resource.
    /// </summary>
    [TerraformPropertyName("peer_gcp_gateway")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PeerGcpGateway { get; set; }

    /// <summary>
    /// IP address of the peer VPN gateway. Only IPv4 is supported.
    /// </summary>
    [TerraformPropertyName("peer_ip")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> PeerIp { get; set; } = default!;

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// The region where the tunnel is located. If unset, is set to the region of &#39;target_vpn_gateway&#39;.
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// Remote traffic selector to use when establishing the VPN tunnel with
    /// peer VPN gateway. The value should be a CIDR formatted string,
    /// for example &#39;192.168.0.0/16&#39;. The ranges should be disjoint.
    /// Only IPv4 is supported.
    /// </summary>
    [TerraformPropertyName("remote_traffic_selector")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<string> RemoteTrafficSelector { get; set; } = default!;

    /// <summary>
    /// URL of router resource to be used for dynamic routing.
    /// </summary>
    [TerraformPropertyName("router")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Router { get; set; }

    /// <summary>
    /// Shared secret used to set the secure session between the Cloud VPN
    /// gateway and the peer VPN gateway.
    /// </summary>
    [TerraformPropertyName("shared_secret")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SharedSecret { get; set; }

    /// <summary>
    /// Shared secret used to set the secure session between the Cloud VPN
    /// gateway and the peer VPN gateway.
    ///  Note: This property is write-only and will not be read from the API. For more info see [updating write-only attributes](/docs/providers/google/guides/using_write_only_attributes.html#updating-write-only-attributes)
    /// </summary>
    [TerraformPropertyName("shared_secret_wo")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SharedSecretWo { get; set; }

    /// <summary>
    /// Triggers update of shared_secret_wo write-only. For more info see [updating write-only attributes](/docs/providers/google/guides/using_write_only_attributes.html#updating-write-only-attributes)
    /// </summary>
    [TerraformPropertyName("shared_secret_wo_version")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SharedSecretWoVersion { get; set; }

    /// <summary>
    /// URL of the Target VPN gateway with which this VPN tunnel is
    /// associated.
    /// </summary>
    [TerraformPropertyName("target_vpn_gateway")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TargetVpnGateway { get; set; }

    /// <summary>
    /// URL of the VPN gateway with which this VPN tunnel is associated.
    /// This must be used if a High Availability VPN gateway resource is created.
    /// This field must reference a &#39;google_compute_ha_vpn_gateway&#39; resource.
    /// </summary>
    [TerraformPropertyName("vpn_gateway")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? VpnGateway { get; set; }

    /// <summary>
    /// The interface ID of the VPN gateway with which this VPN tunnel is associated.
    /// </summary>
    [TerraformPropertyName("vpn_gateway_interface")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? VpnGatewayInterface { get; set; }

    /// <summary>
    /// Block for cipher_suite.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CipherSuite block(s) allowed")]
    [TerraformPropertyName("cipher_suite")]
    public TerraformList<TerraformBlock<GoogleComputeVpnTunnelCipherSuiteBlock>>? CipherSuite { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleComputeVpnTunnelTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    [TerraformPropertyName("creation_timestamp")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreationTimestamp => new TerraformReference(this, "creation_timestamp");

    /// <summary>
    /// Detailed status message for the VPN tunnel.
    /// </summary>
    [TerraformPropertyName("detailed_status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DetailedStatus => new TerraformReference(this, "detailed_status");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> EffectiveLabels => new TerraformReference(this, "effective_labels");

    /// <summary>
    /// The fingerprint used for optimistic locking of this resource.  Used
    /// internally during updates.
    /// </summary>
    [TerraformPropertyName("label_fingerprint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LabelFingerprint => new TerraformReference(this, "label_fingerprint");

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    [TerraformPropertyName("self_link")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SelfLink => new TerraformReference(this, "self_link");

    /// <summary>
    /// Hash of the shared secret.
    /// </summary>
    [TerraformPropertyName("shared_secret_hash")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SharedSecretHash => new TerraformReference(this, "shared_secret_hash");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> TerraformLabels => new TerraformReference(this, "terraform_labels");

    /// <summary>
    /// The unique identifier for the resource. This identifier is defined by the server.
    /// </summary>
    [TerraformPropertyName("tunnel_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TunnelId => new TerraformReference(this, "tunnel_id");

}
