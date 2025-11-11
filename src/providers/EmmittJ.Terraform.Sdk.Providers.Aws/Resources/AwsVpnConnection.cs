using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for tunnel1_log_options in .
/// Nesting mode: list
/// </summary>
public partial class AwsVpnConnectionTunnel1LogOptionsBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for tunnel2_log_options in .
/// Nesting mode: list
/// </summary>
public partial class AwsVpnConnectionTunnel2LogOptionsBlock : TerraformBlockBase
{
}

/// <summary>
/// Manages a aws_vpn_connection resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsVpnConnection : TerraformResource
{
    public AwsVpnConnection(string name) : base("aws_vpn_connection", name)
    {
    }

    /// <summary>
    /// The customer_gateway_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomerGatewayId is required")]
    [TerraformProperty("customer_gateway_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> CustomerGatewayId { get; set; }

    /// <summary>
    /// The enable_acceleration attribute.
    /// </summary>
    [TerraformProperty("enable_acceleration")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> EnableAcceleration { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The local_ipv4_network_cidr attribute.
    /// </summary>
    [TerraformProperty("local_ipv4_network_cidr")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> LocalIpv4NetworkCidr { get; set; }

    /// <summary>
    /// The local_ipv6_network_cidr attribute.
    /// </summary>
    [TerraformProperty("local_ipv6_network_cidr")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> LocalIpv6NetworkCidr { get; set; }

    /// <summary>
    /// The outside_ip_address_type attribute.
    /// </summary>
    [TerraformProperty("outside_ip_address_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> OutsideIpAddressType { get; set; }

    /// <summary>
    /// The preshared_key_storage attribute.
    /// </summary>
    [TerraformProperty("preshared_key_storage")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> PresharedKeyStorage { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The remote_ipv4_network_cidr attribute.
    /// </summary>
    [TerraformProperty("remote_ipv4_network_cidr")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> RemoteIpv4NetworkCidr { get; set; }

    /// <summary>
    /// The remote_ipv6_network_cidr attribute.
    /// </summary>
    [TerraformProperty("remote_ipv6_network_cidr")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> RemoteIpv6NetworkCidr { get; set; }

    /// <summary>
    /// The static_routes_only attribute.
    /// </summary>
    [TerraformProperty("static_routes_only")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> StaticRoutesOnly { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The transit_gateway_id attribute.
    /// </summary>
    [TerraformProperty("transit_gateway_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TransitGatewayId { get; set; }

    /// <summary>
    /// The transport_transit_gateway_attachment_id attribute.
    /// </summary>
    [TerraformProperty("transport_transit_gateway_attachment_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TransportTransitGatewayAttachmentId { get; set; }

    /// <summary>
    /// The tunnel1_dpd_timeout_action attribute.
    /// </summary>
    [TerraformProperty("tunnel1_dpd_timeout_action")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Tunnel1DpdTimeoutAction { get; set; }

    /// <summary>
    /// The tunnel1_dpd_timeout_seconds attribute.
    /// </summary>
    [TerraformProperty("tunnel1_dpd_timeout_seconds")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Tunnel1DpdTimeoutSeconds { get; set; }

    /// <summary>
    /// The tunnel1_enable_tunnel_lifecycle_control attribute.
    /// </summary>
    [TerraformProperty("tunnel1_enable_tunnel_lifecycle_control")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Tunnel1EnableTunnelLifecycleControl { get; set; }

    /// <summary>
    /// The tunnel1_ike_versions attribute.
    /// </summary>
    [TerraformProperty("tunnel1_ike_versions")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? Tunnel1IkeVersions { get; set; }

    /// <summary>
    /// The tunnel1_inside_cidr attribute.
    /// </summary>
    [TerraformProperty("tunnel1_inside_cidr")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Tunnel1InsideCidr { get; set; }

    /// <summary>
    /// The tunnel1_inside_ipv6_cidr attribute.
    /// </summary>
    [TerraformProperty("tunnel1_inside_ipv6_cidr")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Tunnel1InsideIpv6Cidr { get; set; }

    /// <summary>
    /// The tunnel1_phase1_dh_group_numbers attribute.
    /// </summary>
    [TerraformProperty("tunnel1_phase1_dh_group_numbers")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<double>? Tunnel1Phase1DhGroupNumbers { get; set; }

    /// <summary>
    /// The tunnel1_phase1_encryption_algorithms attribute.
    /// </summary>
    [TerraformProperty("tunnel1_phase1_encryption_algorithms")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? Tunnel1Phase1EncryptionAlgorithms { get; set; }

    /// <summary>
    /// The tunnel1_phase1_integrity_algorithms attribute.
    /// </summary>
    [TerraformProperty("tunnel1_phase1_integrity_algorithms")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? Tunnel1Phase1IntegrityAlgorithms { get; set; }

    /// <summary>
    /// The tunnel1_phase1_lifetime_seconds attribute.
    /// </summary>
    [TerraformProperty("tunnel1_phase1_lifetime_seconds")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Tunnel1Phase1LifetimeSeconds { get; set; }

    /// <summary>
    /// The tunnel1_phase2_dh_group_numbers attribute.
    /// </summary>
    [TerraformProperty("tunnel1_phase2_dh_group_numbers")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<double>? Tunnel1Phase2DhGroupNumbers { get; set; }

    /// <summary>
    /// The tunnel1_phase2_encryption_algorithms attribute.
    /// </summary>
    [TerraformProperty("tunnel1_phase2_encryption_algorithms")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? Tunnel1Phase2EncryptionAlgorithms { get; set; }

    /// <summary>
    /// The tunnel1_phase2_integrity_algorithms attribute.
    /// </summary>
    [TerraformProperty("tunnel1_phase2_integrity_algorithms")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? Tunnel1Phase2IntegrityAlgorithms { get; set; }

    /// <summary>
    /// The tunnel1_phase2_lifetime_seconds attribute.
    /// </summary>
    [TerraformProperty("tunnel1_phase2_lifetime_seconds")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Tunnel1Phase2LifetimeSeconds { get; set; }

    /// <summary>
    /// The tunnel1_preshared_key attribute.
    /// </summary>
    [TerraformProperty("tunnel1_preshared_key")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Tunnel1PresharedKey { get; set; }

    /// <summary>
    /// The tunnel1_rekey_fuzz_percentage attribute.
    /// </summary>
    [TerraformProperty("tunnel1_rekey_fuzz_percentage")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Tunnel1RekeyFuzzPercentage { get; set; }

    /// <summary>
    /// The tunnel1_rekey_margin_time_seconds attribute.
    /// </summary>
    [TerraformProperty("tunnel1_rekey_margin_time_seconds")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Tunnel1RekeyMarginTimeSeconds { get; set; }

    /// <summary>
    /// The tunnel1_replay_window_size attribute.
    /// </summary>
    [TerraformProperty("tunnel1_replay_window_size")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Tunnel1ReplayWindowSize { get; set; }

    /// <summary>
    /// The tunnel1_startup_action attribute.
    /// </summary>
    [TerraformProperty("tunnel1_startup_action")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Tunnel1StartupAction { get; set; }

    /// <summary>
    /// The tunnel2_dpd_timeout_action attribute.
    /// </summary>
    [TerraformProperty("tunnel2_dpd_timeout_action")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Tunnel2DpdTimeoutAction { get; set; }

    /// <summary>
    /// The tunnel2_dpd_timeout_seconds attribute.
    /// </summary>
    [TerraformProperty("tunnel2_dpd_timeout_seconds")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Tunnel2DpdTimeoutSeconds { get; set; }

    /// <summary>
    /// The tunnel2_enable_tunnel_lifecycle_control attribute.
    /// </summary>
    [TerraformProperty("tunnel2_enable_tunnel_lifecycle_control")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Tunnel2EnableTunnelLifecycleControl { get; set; }

    /// <summary>
    /// The tunnel2_ike_versions attribute.
    /// </summary>
    [TerraformProperty("tunnel2_ike_versions")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? Tunnel2IkeVersions { get; set; }

    /// <summary>
    /// The tunnel2_inside_cidr attribute.
    /// </summary>
    [TerraformProperty("tunnel2_inside_cidr")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Tunnel2InsideCidr { get; set; }

    /// <summary>
    /// The tunnel2_inside_ipv6_cidr attribute.
    /// </summary>
    [TerraformProperty("tunnel2_inside_ipv6_cidr")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Tunnel2InsideIpv6Cidr { get; set; }

    /// <summary>
    /// The tunnel2_phase1_dh_group_numbers attribute.
    /// </summary>
    [TerraformProperty("tunnel2_phase1_dh_group_numbers")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<double>? Tunnel2Phase1DhGroupNumbers { get; set; }

    /// <summary>
    /// The tunnel2_phase1_encryption_algorithms attribute.
    /// </summary>
    [TerraformProperty("tunnel2_phase1_encryption_algorithms")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? Tunnel2Phase1EncryptionAlgorithms { get; set; }

    /// <summary>
    /// The tunnel2_phase1_integrity_algorithms attribute.
    /// </summary>
    [TerraformProperty("tunnel2_phase1_integrity_algorithms")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? Tunnel2Phase1IntegrityAlgorithms { get; set; }

    /// <summary>
    /// The tunnel2_phase1_lifetime_seconds attribute.
    /// </summary>
    [TerraformProperty("tunnel2_phase1_lifetime_seconds")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Tunnel2Phase1LifetimeSeconds { get; set; }

    /// <summary>
    /// The tunnel2_phase2_dh_group_numbers attribute.
    /// </summary>
    [TerraformProperty("tunnel2_phase2_dh_group_numbers")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<double>? Tunnel2Phase2DhGroupNumbers { get; set; }

    /// <summary>
    /// The tunnel2_phase2_encryption_algorithms attribute.
    /// </summary>
    [TerraformProperty("tunnel2_phase2_encryption_algorithms")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? Tunnel2Phase2EncryptionAlgorithms { get; set; }

    /// <summary>
    /// The tunnel2_phase2_integrity_algorithms attribute.
    /// </summary>
    [TerraformProperty("tunnel2_phase2_integrity_algorithms")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? Tunnel2Phase2IntegrityAlgorithms { get; set; }

    /// <summary>
    /// The tunnel2_phase2_lifetime_seconds attribute.
    /// </summary>
    [TerraformProperty("tunnel2_phase2_lifetime_seconds")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Tunnel2Phase2LifetimeSeconds { get; set; }

    /// <summary>
    /// The tunnel2_preshared_key attribute.
    /// </summary>
    [TerraformProperty("tunnel2_preshared_key")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Tunnel2PresharedKey { get; set; }

    /// <summary>
    /// The tunnel2_rekey_fuzz_percentage attribute.
    /// </summary>
    [TerraformProperty("tunnel2_rekey_fuzz_percentage")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Tunnel2RekeyFuzzPercentage { get; set; }

    /// <summary>
    /// The tunnel2_rekey_margin_time_seconds attribute.
    /// </summary>
    [TerraformProperty("tunnel2_rekey_margin_time_seconds")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Tunnel2RekeyMarginTimeSeconds { get; set; }

    /// <summary>
    /// The tunnel2_replay_window_size attribute.
    /// </summary>
    [TerraformProperty("tunnel2_replay_window_size")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Tunnel2ReplayWindowSize { get; set; }

    /// <summary>
    /// The tunnel2_startup_action attribute.
    /// </summary>
    [TerraformProperty("tunnel2_startup_action")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Tunnel2StartupAction { get; set; }

    /// <summary>
    /// The tunnel_inside_ip_version attribute.
    /// </summary>
    [TerraformProperty("tunnel_inside_ip_version")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> TunnelInsideIpVersion { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

    /// <summary>
    /// The vpn_gateway_id attribute.
    /// </summary>
    [TerraformProperty("vpn_gateway_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? VpnGatewayId { get; set; }

    /// <summary>
    /// Block for tunnel1_log_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Tunnel1LogOptions block(s) allowed")]
    [TerraformProperty("tunnel1_log_options")]
    public partial TerraformList<TerraformBlock<AwsVpnConnectionTunnel1LogOptionsBlock>>? Tunnel1LogOptions { get; set; }

    /// <summary>
    /// Block for tunnel2_log_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Tunnel2LogOptions block(s) allowed")]
    [TerraformProperty("tunnel2_log_options")]
    public partial TerraformList<TerraformBlock<AwsVpnConnectionTunnel2LogOptionsBlock>>? Tunnel2LogOptions { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The core_network_arn attribute.
    /// </summary>
    [TerraformProperty("core_network_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CoreNetworkArn { get; }

    /// <summary>
    /// The core_network_attachment_arn attribute.
    /// </summary>
    [TerraformProperty("core_network_attachment_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CoreNetworkAttachmentArn { get; }

    /// <summary>
    /// The customer_gateway_configuration attribute.
    /// </summary>
    [TerraformProperty("customer_gateway_configuration")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CustomerGatewayConfiguration { get; }

    /// <summary>
    /// The preshared_key_arn attribute.
    /// </summary>
    [TerraformProperty("preshared_key_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PresharedKeyArn { get; }

    /// <summary>
    /// The routes attribute.
    /// </summary>
    [TerraformProperty("routes")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<object> Routes { get; }

    /// <summary>
    /// The transit_gateway_attachment_id attribute.
    /// </summary>
    [TerraformProperty("transit_gateway_attachment_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> TransitGatewayAttachmentId { get; }

    /// <summary>
    /// The tunnel1_address attribute.
    /// </summary>
    [TerraformProperty("tunnel1_address")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Tunnel1Address { get; }

    /// <summary>
    /// The tunnel1_bgp_asn attribute.
    /// </summary>
    [TerraformProperty("tunnel1_bgp_asn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Tunnel1BgpAsn { get; }

    /// <summary>
    /// The tunnel1_bgp_holdtime attribute.
    /// </summary>
    [TerraformProperty("tunnel1_bgp_holdtime")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> Tunnel1BgpHoldtime { get; }

    /// <summary>
    /// The tunnel1_cgw_inside_address attribute.
    /// </summary>
    [TerraformProperty("tunnel1_cgw_inside_address")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Tunnel1CgwInsideAddress { get; }

    /// <summary>
    /// The tunnel1_vgw_inside_address attribute.
    /// </summary>
    [TerraformProperty("tunnel1_vgw_inside_address")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Tunnel1VgwInsideAddress { get; }

    /// <summary>
    /// The tunnel2_address attribute.
    /// </summary>
    [TerraformProperty("tunnel2_address")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Tunnel2Address { get; }

    /// <summary>
    /// The tunnel2_bgp_asn attribute.
    /// </summary>
    [TerraformProperty("tunnel2_bgp_asn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Tunnel2BgpAsn { get; }

    /// <summary>
    /// The tunnel2_bgp_holdtime attribute.
    /// </summary>
    [TerraformProperty("tunnel2_bgp_holdtime")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> Tunnel2BgpHoldtime { get; }

    /// <summary>
    /// The tunnel2_cgw_inside_address attribute.
    /// </summary>
    [TerraformProperty("tunnel2_cgw_inside_address")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Tunnel2CgwInsideAddress { get; }

    /// <summary>
    /// The tunnel2_vgw_inside_address attribute.
    /// </summary>
    [TerraformProperty("tunnel2_vgw_inside_address")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Tunnel2VgwInsideAddress { get; }

    /// <summary>
    /// The vgw_telemetry attribute.
    /// </summary>
    [TerraformProperty("vgw_telemetry")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<object> VgwTelemetry { get; }

}
