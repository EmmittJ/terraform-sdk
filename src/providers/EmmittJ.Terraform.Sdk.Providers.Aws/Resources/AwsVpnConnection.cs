using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for tunnel1_log_options in .
/// Nesting mode: list
/// </summary>
public class AwsVpnConnectionTunnel1LogOptionsBlock
{
}

/// <summary>
/// Block type for tunnel2_log_options in .
/// Nesting mode: list
/// </summary>
public class AwsVpnConnectionTunnel2LogOptionsBlock
{
}

/// <summary>
/// Manages a aws_vpn_connection resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsVpnConnection : TerraformResource
{
    public AwsVpnConnection(string name) : base("aws_vpn_connection", name)
    {
    }

    /// <summary>
    /// The customer_gateway_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomerGatewayId is required")]
    [TerraformPropertyName("customer_gateway_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> CustomerGatewayId { get; set; }

    /// <summary>
    /// The enable_acceleration attribute.
    /// </summary>
    [TerraformPropertyName("enable_acceleration")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> EnableAcceleration { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The local_ipv4_network_cidr attribute.
    /// </summary>
    [TerraformPropertyName("local_ipv4_network_cidr")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> LocalIpv4NetworkCidr { get; set; } = default!;

    /// <summary>
    /// The local_ipv6_network_cidr attribute.
    /// </summary>
    [TerraformPropertyName("local_ipv6_network_cidr")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> LocalIpv6NetworkCidr { get; set; } = default!;

    /// <summary>
    /// The outside_ip_address_type attribute.
    /// </summary>
    [TerraformPropertyName("outside_ip_address_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> OutsideIpAddressType { get; set; } = default!;

    /// <summary>
    /// The preshared_key_storage attribute.
    /// </summary>
    [TerraformPropertyName("preshared_key_storage")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> PresharedKeyStorage { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The remote_ipv4_network_cidr attribute.
    /// </summary>
    [TerraformPropertyName("remote_ipv4_network_cidr")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> RemoteIpv4NetworkCidr { get; set; } = default!;

    /// <summary>
    /// The remote_ipv6_network_cidr attribute.
    /// </summary>
    [TerraformPropertyName("remote_ipv6_network_cidr")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> RemoteIpv6NetworkCidr { get; set; } = default!;

    /// <summary>
    /// The static_routes_only attribute.
    /// </summary>
    [TerraformPropertyName("static_routes_only")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> StaticRoutesOnly { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// The transit_gateway_id attribute.
    /// </summary>
    [TerraformPropertyName("transit_gateway_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TransitGatewayId { get; set; }

    /// <summary>
    /// The transport_transit_gateway_attachment_id attribute.
    /// </summary>
    [TerraformPropertyName("transport_transit_gateway_attachment_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TransportTransitGatewayAttachmentId { get; set; }

    /// <summary>
    /// The tunnel1_dpd_timeout_action attribute.
    /// </summary>
    [TerraformPropertyName("tunnel1_dpd_timeout_action")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Tunnel1DpdTimeoutAction { get; set; }

    /// <summary>
    /// The tunnel1_dpd_timeout_seconds attribute.
    /// </summary>
    [TerraformPropertyName("tunnel1_dpd_timeout_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? Tunnel1DpdTimeoutSeconds { get; set; }

    /// <summary>
    /// The tunnel1_enable_tunnel_lifecycle_control attribute.
    /// </summary>
    [TerraformPropertyName("tunnel1_enable_tunnel_lifecycle_control")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Tunnel1EnableTunnelLifecycleControl { get; set; }

    /// <summary>
    /// The tunnel1_ike_versions attribute.
    /// </summary>
    [TerraformPropertyName("tunnel1_ike_versions")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? Tunnel1IkeVersions { get; set; }

    /// <summary>
    /// The tunnel1_inside_cidr attribute.
    /// </summary>
    [TerraformPropertyName("tunnel1_inside_cidr")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Tunnel1InsideCidr { get; set; } = default!;

    /// <summary>
    /// The tunnel1_inside_ipv6_cidr attribute.
    /// </summary>
    [TerraformPropertyName("tunnel1_inside_ipv6_cidr")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Tunnel1InsideIpv6Cidr { get; set; } = default!;

    /// <summary>
    /// The tunnel1_phase1_dh_group_numbers attribute.
    /// </summary>
    [TerraformPropertyName("tunnel1_phase1_dh_group_numbers")]
    // Optional argument - user may or may not set a value
    public TerraformSet<double>? Tunnel1Phase1DhGroupNumbers { get; set; }

    /// <summary>
    /// The tunnel1_phase1_encryption_algorithms attribute.
    /// </summary>
    [TerraformPropertyName("tunnel1_phase1_encryption_algorithms")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? Tunnel1Phase1EncryptionAlgorithms { get; set; }

    /// <summary>
    /// The tunnel1_phase1_integrity_algorithms attribute.
    /// </summary>
    [TerraformPropertyName("tunnel1_phase1_integrity_algorithms")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? Tunnel1Phase1IntegrityAlgorithms { get; set; }

    /// <summary>
    /// The tunnel1_phase1_lifetime_seconds attribute.
    /// </summary>
    [TerraformPropertyName("tunnel1_phase1_lifetime_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? Tunnel1Phase1LifetimeSeconds { get; set; }

    /// <summary>
    /// The tunnel1_phase2_dh_group_numbers attribute.
    /// </summary>
    [TerraformPropertyName("tunnel1_phase2_dh_group_numbers")]
    // Optional argument - user may or may not set a value
    public TerraformSet<double>? Tunnel1Phase2DhGroupNumbers { get; set; }

    /// <summary>
    /// The tunnel1_phase2_encryption_algorithms attribute.
    /// </summary>
    [TerraformPropertyName("tunnel1_phase2_encryption_algorithms")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? Tunnel1Phase2EncryptionAlgorithms { get; set; }

    /// <summary>
    /// The tunnel1_phase2_integrity_algorithms attribute.
    /// </summary>
    [TerraformPropertyName("tunnel1_phase2_integrity_algorithms")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? Tunnel1Phase2IntegrityAlgorithms { get; set; }

    /// <summary>
    /// The tunnel1_phase2_lifetime_seconds attribute.
    /// </summary>
    [TerraformPropertyName("tunnel1_phase2_lifetime_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? Tunnel1Phase2LifetimeSeconds { get; set; }

    /// <summary>
    /// The tunnel1_preshared_key attribute.
    /// </summary>
    [TerraformPropertyName("tunnel1_preshared_key")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Tunnel1PresharedKey { get; set; } = default!;

    /// <summary>
    /// The tunnel1_rekey_fuzz_percentage attribute.
    /// </summary>
    [TerraformPropertyName("tunnel1_rekey_fuzz_percentage")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? Tunnel1RekeyFuzzPercentage { get; set; }

    /// <summary>
    /// The tunnel1_rekey_margin_time_seconds attribute.
    /// </summary>
    [TerraformPropertyName("tunnel1_rekey_margin_time_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? Tunnel1RekeyMarginTimeSeconds { get; set; }

    /// <summary>
    /// The tunnel1_replay_window_size attribute.
    /// </summary>
    [TerraformPropertyName("tunnel1_replay_window_size")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? Tunnel1ReplayWindowSize { get; set; }

    /// <summary>
    /// The tunnel1_startup_action attribute.
    /// </summary>
    [TerraformPropertyName("tunnel1_startup_action")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Tunnel1StartupAction { get; set; }

    /// <summary>
    /// The tunnel2_dpd_timeout_action attribute.
    /// </summary>
    [TerraformPropertyName("tunnel2_dpd_timeout_action")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Tunnel2DpdTimeoutAction { get; set; }

    /// <summary>
    /// The tunnel2_dpd_timeout_seconds attribute.
    /// </summary>
    [TerraformPropertyName("tunnel2_dpd_timeout_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? Tunnel2DpdTimeoutSeconds { get; set; }

    /// <summary>
    /// The tunnel2_enable_tunnel_lifecycle_control attribute.
    /// </summary>
    [TerraformPropertyName("tunnel2_enable_tunnel_lifecycle_control")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Tunnel2EnableTunnelLifecycleControl { get; set; }

    /// <summary>
    /// The tunnel2_ike_versions attribute.
    /// </summary>
    [TerraformPropertyName("tunnel2_ike_versions")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? Tunnel2IkeVersions { get; set; }

    /// <summary>
    /// The tunnel2_inside_cidr attribute.
    /// </summary>
    [TerraformPropertyName("tunnel2_inside_cidr")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Tunnel2InsideCidr { get; set; } = default!;

    /// <summary>
    /// The tunnel2_inside_ipv6_cidr attribute.
    /// </summary>
    [TerraformPropertyName("tunnel2_inside_ipv6_cidr")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Tunnel2InsideIpv6Cidr { get; set; } = default!;

    /// <summary>
    /// The tunnel2_phase1_dh_group_numbers attribute.
    /// </summary>
    [TerraformPropertyName("tunnel2_phase1_dh_group_numbers")]
    // Optional argument - user may or may not set a value
    public TerraformSet<double>? Tunnel2Phase1DhGroupNumbers { get; set; }

    /// <summary>
    /// The tunnel2_phase1_encryption_algorithms attribute.
    /// </summary>
    [TerraformPropertyName("tunnel2_phase1_encryption_algorithms")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? Tunnel2Phase1EncryptionAlgorithms { get; set; }

    /// <summary>
    /// The tunnel2_phase1_integrity_algorithms attribute.
    /// </summary>
    [TerraformPropertyName("tunnel2_phase1_integrity_algorithms")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? Tunnel2Phase1IntegrityAlgorithms { get; set; }

    /// <summary>
    /// The tunnel2_phase1_lifetime_seconds attribute.
    /// </summary>
    [TerraformPropertyName("tunnel2_phase1_lifetime_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? Tunnel2Phase1LifetimeSeconds { get; set; }

    /// <summary>
    /// The tunnel2_phase2_dh_group_numbers attribute.
    /// </summary>
    [TerraformPropertyName("tunnel2_phase2_dh_group_numbers")]
    // Optional argument - user may or may not set a value
    public TerraformSet<double>? Tunnel2Phase2DhGroupNumbers { get; set; }

    /// <summary>
    /// The tunnel2_phase2_encryption_algorithms attribute.
    /// </summary>
    [TerraformPropertyName("tunnel2_phase2_encryption_algorithms")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? Tunnel2Phase2EncryptionAlgorithms { get; set; }

    /// <summary>
    /// The tunnel2_phase2_integrity_algorithms attribute.
    /// </summary>
    [TerraformPropertyName("tunnel2_phase2_integrity_algorithms")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? Tunnel2Phase2IntegrityAlgorithms { get; set; }

    /// <summary>
    /// The tunnel2_phase2_lifetime_seconds attribute.
    /// </summary>
    [TerraformPropertyName("tunnel2_phase2_lifetime_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? Tunnel2Phase2LifetimeSeconds { get; set; }

    /// <summary>
    /// The tunnel2_preshared_key attribute.
    /// </summary>
    [TerraformPropertyName("tunnel2_preshared_key")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Tunnel2PresharedKey { get; set; } = default!;

    /// <summary>
    /// The tunnel2_rekey_fuzz_percentage attribute.
    /// </summary>
    [TerraformPropertyName("tunnel2_rekey_fuzz_percentage")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? Tunnel2RekeyFuzzPercentage { get; set; }

    /// <summary>
    /// The tunnel2_rekey_margin_time_seconds attribute.
    /// </summary>
    [TerraformPropertyName("tunnel2_rekey_margin_time_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? Tunnel2RekeyMarginTimeSeconds { get; set; }

    /// <summary>
    /// The tunnel2_replay_window_size attribute.
    /// </summary>
    [TerraformPropertyName("tunnel2_replay_window_size")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? Tunnel2ReplayWindowSize { get; set; }

    /// <summary>
    /// The tunnel2_startup_action attribute.
    /// </summary>
    [TerraformPropertyName("tunnel2_startup_action")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Tunnel2StartupAction { get; set; }

    /// <summary>
    /// The tunnel_inside_ip_version attribute.
    /// </summary>
    [TerraformPropertyName("tunnel_inside_ip_version")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> TunnelInsideIpVersion { get; set; } = default!;

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Type { get; set; }

    /// <summary>
    /// The vpn_gateway_id attribute.
    /// </summary>
    [TerraformPropertyName("vpn_gateway_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? VpnGatewayId { get; set; }

    /// <summary>
    /// Block for tunnel1_log_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Tunnel1LogOptions block(s) allowed")]
    [TerraformPropertyName("tunnel1_log_options")]
    public TerraformList<TerraformBlock<AwsVpnConnectionTunnel1LogOptionsBlock>>? Tunnel1LogOptions { get; set; }

    /// <summary>
    /// Block for tunnel2_log_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Tunnel2LogOptions block(s) allowed")]
    [TerraformPropertyName("tunnel2_log_options")]
    public TerraformList<TerraformBlock<AwsVpnConnectionTunnel2LogOptionsBlock>>? Tunnel2LogOptions { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The core_network_arn attribute.
    /// </summary>
    [TerraformPropertyName("core_network_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CoreNetworkArn => new TerraformReference(this, "core_network_arn");

    /// <summary>
    /// The core_network_attachment_arn attribute.
    /// </summary>
    [TerraformPropertyName("core_network_attachment_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CoreNetworkAttachmentArn => new TerraformReference(this, "core_network_attachment_arn");

    /// <summary>
    /// The customer_gateway_configuration attribute.
    /// </summary>
    [TerraformPropertyName("customer_gateway_configuration")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CustomerGatewayConfiguration => new TerraformReference(this, "customer_gateway_configuration");

    /// <summary>
    /// The preshared_key_arn attribute.
    /// </summary>
    [TerraformPropertyName("preshared_key_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PresharedKeyArn => new TerraformReference(this, "preshared_key_arn");

    /// <summary>
    /// The routes attribute.
    /// </summary>
    [TerraformPropertyName("routes")]
    // Output-only attribute - read-only reference
    public TerraformSet<object> Routes => new TerraformReference(this, "routes");

    /// <summary>
    /// The transit_gateway_attachment_id attribute.
    /// </summary>
    [TerraformPropertyName("transit_gateway_attachment_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TransitGatewayAttachmentId => new TerraformReference(this, "transit_gateway_attachment_id");

    /// <summary>
    /// The tunnel1_address attribute.
    /// </summary>
    [TerraformPropertyName("tunnel1_address")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Tunnel1Address => new TerraformReference(this, "tunnel1_address");

    /// <summary>
    /// The tunnel1_bgp_asn attribute.
    /// </summary>
    [TerraformPropertyName("tunnel1_bgp_asn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Tunnel1BgpAsn => new TerraformReference(this, "tunnel1_bgp_asn");

    /// <summary>
    /// The tunnel1_bgp_holdtime attribute.
    /// </summary>
    [TerraformPropertyName("tunnel1_bgp_holdtime")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> Tunnel1BgpHoldtime => new TerraformReference(this, "tunnel1_bgp_holdtime");

    /// <summary>
    /// The tunnel1_cgw_inside_address attribute.
    /// </summary>
    [TerraformPropertyName("tunnel1_cgw_inside_address")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Tunnel1CgwInsideAddress => new TerraformReference(this, "tunnel1_cgw_inside_address");

    /// <summary>
    /// The tunnel1_vgw_inside_address attribute.
    /// </summary>
    [TerraformPropertyName("tunnel1_vgw_inside_address")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Tunnel1VgwInsideAddress => new TerraformReference(this, "tunnel1_vgw_inside_address");

    /// <summary>
    /// The tunnel2_address attribute.
    /// </summary>
    [TerraformPropertyName("tunnel2_address")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Tunnel2Address => new TerraformReference(this, "tunnel2_address");

    /// <summary>
    /// The tunnel2_bgp_asn attribute.
    /// </summary>
    [TerraformPropertyName("tunnel2_bgp_asn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Tunnel2BgpAsn => new TerraformReference(this, "tunnel2_bgp_asn");

    /// <summary>
    /// The tunnel2_bgp_holdtime attribute.
    /// </summary>
    [TerraformPropertyName("tunnel2_bgp_holdtime")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> Tunnel2BgpHoldtime => new TerraformReference(this, "tunnel2_bgp_holdtime");

    /// <summary>
    /// The tunnel2_cgw_inside_address attribute.
    /// </summary>
    [TerraformPropertyName("tunnel2_cgw_inside_address")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Tunnel2CgwInsideAddress => new TerraformReference(this, "tunnel2_cgw_inside_address");

    /// <summary>
    /// The tunnel2_vgw_inside_address attribute.
    /// </summary>
    [TerraformPropertyName("tunnel2_vgw_inside_address")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Tunnel2VgwInsideAddress => new TerraformReference(this, "tunnel2_vgw_inside_address");

    /// <summary>
    /// The vgw_telemetry attribute.
    /// </summary>
    [TerraformPropertyName("vgw_telemetry")]
    // Output-only attribute - read-only reference
    public TerraformSet<object> VgwTelemetry => new TerraformReference(this, "vgw_telemetry");

}
