using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for tunnel1_log_options in .
/// Nesting mode: list
/// </summary>
public class AwsVpnConnectionTunnel1LogOptionsBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for tunnel2_log_options in .
/// Nesting mode: list
/// </summary>
public class AwsVpnConnectionTunnel2LogOptionsBlock : ITerraformBlock
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
    public required TerraformProperty<TerraformProperty<string>> CustomerGatewayId { get; set; }

    /// <summary>
    /// The enable_acceleration attribute.
    /// </summary>
    [TerraformPropertyName("enable_acceleration")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> EnableAcceleration { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "enable_acceleration");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The local_ipv4_network_cidr attribute.
    /// </summary>
    [TerraformPropertyName("local_ipv4_network_cidr")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> LocalIpv4NetworkCidr { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "local_ipv4_network_cidr");

    /// <summary>
    /// The local_ipv6_network_cidr attribute.
    /// </summary>
    [TerraformPropertyName("local_ipv6_network_cidr")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> LocalIpv6NetworkCidr { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "local_ipv6_network_cidr");

    /// <summary>
    /// The outside_ip_address_type attribute.
    /// </summary>
    [TerraformPropertyName("outside_ip_address_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> OutsideIpAddressType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "outside_ip_address_type");

    /// <summary>
    /// The preshared_key_storage attribute.
    /// </summary>
    [TerraformPropertyName("preshared_key_storage")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> PresharedKeyStorage { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "preshared_key_storage");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The remote_ipv4_network_cidr attribute.
    /// </summary>
    [TerraformPropertyName("remote_ipv4_network_cidr")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> RemoteIpv4NetworkCidr { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "remote_ipv4_network_cidr");

    /// <summary>
    /// The remote_ipv6_network_cidr attribute.
    /// </summary>
    [TerraformPropertyName("remote_ipv6_network_cidr")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> RemoteIpv6NetworkCidr { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "remote_ipv6_network_cidr");

    /// <summary>
    /// The static_routes_only attribute.
    /// </summary>
    [TerraformPropertyName("static_routes_only")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> StaticRoutesOnly { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "static_routes_only");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// The transit_gateway_id attribute.
    /// </summary>
    [TerraformPropertyName("transit_gateway_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TransitGatewayId { get; set; }

    /// <summary>
    /// The transport_transit_gateway_attachment_id attribute.
    /// </summary>
    [TerraformPropertyName("transport_transit_gateway_attachment_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TransportTransitGatewayAttachmentId { get; set; }

    /// <summary>
    /// The tunnel1_dpd_timeout_action attribute.
    /// </summary>
    [TerraformPropertyName("tunnel1_dpd_timeout_action")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Tunnel1DpdTimeoutAction { get; set; }

    /// <summary>
    /// The tunnel1_dpd_timeout_seconds attribute.
    /// </summary>
    [TerraformPropertyName("tunnel1_dpd_timeout_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Tunnel1DpdTimeoutSeconds { get; set; }

    /// <summary>
    /// The tunnel1_enable_tunnel_lifecycle_control attribute.
    /// </summary>
    [TerraformPropertyName("tunnel1_enable_tunnel_lifecycle_control")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Tunnel1EnableTunnelLifecycleControl { get; set; }

    /// <summary>
    /// The tunnel1_ike_versions attribute.
    /// </summary>
    [TerraformPropertyName("tunnel1_ike_versions")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Tunnel1IkeVersions { get; set; }

    /// <summary>
    /// The tunnel1_inside_cidr attribute.
    /// </summary>
    [TerraformPropertyName("tunnel1_inside_cidr")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Tunnel1InsideCidr { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "tunnel1_inside_cidr");

    /// <summary>
    /// The tunnel1_inside_ipv6_cidr attribute.
    /// </summary>
    [TerraformPropertyName("tunnel1_inside_ipv6_cidr")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Tunnel1InsideIpv6Cidr { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "tunnel1_inside_ipv6_cidr");

    /// <summary>
    /// The tunnel1_phase1_dh_group_numbers attribute.
    /// </summary>
    [TerraformPropertyName("tunnel1_phase1_dh_group_numbers")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<double>>>? Tunnel1Phase1DhGroupNumbers { get; set; }

    /// <summary>
    /// The tunnel1_phase1_encryption_algorithms attribute.
    /// </summary>
    [TerraformPropertyName("tunnel1_phase1_encryption_algorithms")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Tunnel1Phase1EncryptionAlgorithms { get; set; }

    /// <summary>
    /// The tunnel1_phase1_integrity_algorithms attribute.
    /// </summary>
    [TerraformPropertyName("tunnel1_phase1_integrity_algorithms")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Tunnel1Phase1IntegrityAlgorithms { get; set; }

    /// <summary>
    /// The tunnel1_phase1_lifetime_seconds attribute.
    /// </summary>
    [TerraformPropertyName("tunnel1_phase1_lifetime_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Tunnel1Phase1LifetimeSeconds { get; set; }

    /// <summary>
    /// The tunnel1_phase2_dh_group_numbers attribute.
    /// </summary>
    [TerraformPropertyName("tunnel1_phase2_dh_group_numbers")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<double>>>? Tunnel1Phase2DhGroupNumbers { get; set; }

    /// <summary>
    /// The tunnel1_phase2_encryption_algorithms attribute.
    /// </summary>
    [TerraformPropertyName("tunnel1_phase2_encryption_algorithms")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Tunnel1Phase2EncryptionAlgorithms { get; set; }

    /// <summary>
    /// The tunnel1_phase2_integrity_algorithms attribute.
    /// </summary>
    [TerraformPropertyName("tunnel1_phase2_integrity_algorithms")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Tunnel1Phase2IntegrityAlgorithms { get; set; }

    /// <summary>
    /// The tunnel1_phase2_lifetime_seconds attribute.
    /// </summary>
    [TerraformPropertyName("tunnel1_phase2_lifetime_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Tunnel1Phase2LifetimeSeconds { get; set; }

    /// <summary>
    /// The tunnel1_preshared_key attribute.
    /// </summary>
    [TerraformPropertyName("tunnel1_preshared_key")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Tunnel1PresharedKey { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "tunnel1_preshared_key");

    /// <summary>
    /// The tunnel1_rekey_fuzz_percentage attribute.
    /// </summary>
    [TerraformPropertyName("tunnel1_rekey_fuzz_percentage")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Tunnel1RekeyFuzzPercentage { get; set; }

    /// <summary>
    /// The tunnel1_rekey_margin_time_seconds attribute.
    /// </summary>
    [TerraformPropertyName("tunnel1_rekey_margin_time_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Tunnel1RekeyMarginTimeSeconds { get; set; }

    /// <summary>
    /// The tunnel1_replay_window_size attribute.
    /// </summary>
    [TerraformPropertyName("tunnel1_replay_window_size")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Tunnel1ReplayWindowSize { get; set; }

    /// <summary>
    /// The tunnel1_startup_action attribute.
    /// </summary>
    [TerraformPropertyName("tunnel1_startup_action")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Tunnel1StartupAction { get; set; }

    /// <summary>
    /// The tunnel2_dpd_timeout_action attribute.
    /// </summary>
    [TerraformPropertyName("tunnel2_dpd_timeout_action")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Tunnel2DpdTimeoutAction { get; set; }

    /// <summary>
    /// The tunnel2_dpd_timeout_seconds attribute.
    /// </summary>
    [TerraformPropertyName("tunnel2_dpd_timeout_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Tunnel2DpdTimeoutSeconds { get; set; }

    /// <summary>
    /// The tunnel2_enable_tunnel_lifecycle_control attribute.
    /// </summary>
    [TerraformPropertyName("tunnel2_enable_tunnel_lifecycle_control")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Tunnel2EnableTunnelLifecycleControl { get; set; }

    /// <summary>
    /// The tunnel2_ike_versions attribute.
    /// </summary>
    [TerraformPropertyName("tunnel2_ike_versions")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Tunnel2IkeVersions { get; set; }

    /// <summary>
    /// The tunnel2_inside_cidr attribute.
    /// </summary>
    [TerraformPropertyName("tunnel2_inside_cidr")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Tunnel2InsideCidr { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "tunnel2_inside_cidr");

    /// <summary>
    /// The tunnel2_inside_ipv6_cidr attribute.
    /// </summary>
    [TerraformPropertyName("tunnel2_inside_ipv6_cidr")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Tunnel2InsideIpv6Cidr { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "tunnel2_inside_ipv6_cidr");

    /// <summary>
    /// The tunnel2_phase1_dh_group_numbers attribute.
    /// </summary>
    [TerraformPropertyName("tunnel2_phase1_dh_group_numbers")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<double>>>? Tunnel2Phase1DhGroupNumbers { get; set; }

    /// <summary>
    /// The tunnel2_phase1_encryption_algorithms attribute.
    /// </summary>
    [TerraformPropertyName("tunnel2_phase1_encryption_algorithms")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Tunnel2Phase1EncryptionAlgorithms { get; set; }

    /// <summary>
    /// The tunnel2_phase1_integrity_algorithms attribute.
    /// </summary>
    [TerraformPropertyName("tunnel2_phase1_integrity_algorithms")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Tunnel2Phase1IntegrityAlgorithms { get; set; }

    /// <summary>
    /// The tunnel2_phase1_lifetime_seconds attribute.
    /// </summary>
    [TerraformPropertyName("tunnel2_phase1_lifetime_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Tunnel2Phase1LifetimeSeconds { get; set; }

    /// <summary>
    /// The tunnel2_phase2_dh_group_numbers attribute.
    /// </summary>
    [TerraformPropertyName("tunnel2_phase2_dh_group_numbers")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<double>>>? Tunnel2Phase2DhGroupNumbers { get; set; }

    /// <summary>
    /// The tunnel2_phase2_encryption_algorithms attribute.
    /// </summary>
    [TerraformPropertyName("tunnel2_phase2_encryption_algorithms")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Tunnel2Phase2EncryptionAlgorithms { get; set; }

    /// <summary>
    /// The tunnel2_phase2_integrity_algorithms attribute.
    /// </summary>
    [TerraformPropertyName("tunnel2_phase2_integrity_algorithms")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Tunnel2Phase2IntegrityAlgorithms { get; set; }

    /// <summary>
    /// The tunnel2_phase2_lifetime_seconds attribute.
    /// </summary>
    [TerraformPropertyName("tunnel2_phase2_lifetime_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Tunnel2Phase2LifetimeSeconds { get; set; }

    /// <summary>
    /// The tunnel2_preshared_key attribute.
    /// </summary>
    [TerraformPropertyName("tunnel2_preshared_key")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Tunnel2PresharedKey { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "tunnel2_preshared_key");

    /// <summary>
    /// The tunnel2_rekey_fuzz_percentage attribute.
    /// </summary>
    [TerraformPropertyName("tunnel2_rekey_fuzz_percentage")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Tunnel2RekeyFuzzPercentage { get; set; }

    /// <summary>
    /// The tunnel2_rekey_margin_time_seconds attribute.
    /// </summary>
    [TerraformPropertyName("tunnel2_rekey_margin_time_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Tunnel2RekeyMarginTimeSeconds { get; set; }

    /// <summary>
    /// The tunnel2_replay_window_size attribute.
    /// </summary>
    [TerraformPropertyName("tunnel2_replay_window_size")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Tunnel2ReplayWindowSize { get; set; }

    /// <summary>
    /// The tunnel2_startup_action attribute.
    /// </summary>
    [TerraformPropertyName("tunnel2_startup_action")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Tunnel2StartupAction { get; set; }

    /// <summary>
    /// The tunnel_inside_ip_version attribute.
    /// </summary>
    [TerraformPropertyName("tunnel_inside_ip_version")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> TunnelInsideIpVersion { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "tunnel_inside_ip_version");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

    /// <summary>
    /// The vpn_gateway_id attribute.
    /// </summary>
    [TerraformPropertyName("vpn_gateway_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? VpnGatewayId { get; set; }

    /// <summary>
    /// Block for tunnel1_log_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Tunnel1LogOptions block(s) allowed")]
    [TerraformPropertyName("tunnel1_log_options")]
    public TerraformList<TerraformBlock<AwsVpnConnectionTunnel1LogOptionsBlock>>? Tunnel1LogOptions { get; set; } = new();

    /// <summary>
    /// Block for tunnel2_log_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Tunnel2LogOptions block(s) allowed")]
    [TerraformPropertyName("tunnel2_log_options")]
    public TerraformList<TerraformBlock<AwsVpnConnectionTunnel2LogOptionsBlock>>? Tunnel2LogOptions { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The core_network_arn attribute.
    /// </summary>
    [TerraformPropertyName("core_network_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CoreNetworkArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "core_network_arn");

    /// <summary>
    /// The core_network_attachment_arn attribute.
    /// </summary>
    [TerraformPropertyName("core_network_attachment_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CoreNetworkAttachmentArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "core_network_attachment_arn");

    /// <summary>
    /// The customer_gateway_configuration attribute.
    /// </summary>
    [TerraformPropertyName("customer_gateway_configuration")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CustomerGatewayConfiguration => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "customer_gateway_configuration");

    /// <summary>
    /// The preshared_key_arn attribute.
    /// </summary>
    [TerraformPropertyName("preshared_key_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PresharedKeyArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "preshared_key_arn");

    /// <summary>
    /// The routes attribute.
    /// </summary>
    [TerraformPropertyName("routes")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> Routes => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "routes");

    /// <summary>
    /// The transit_gateway_attachment_id attribute.
    /// </summary>
    [TerraformPropertyName("transit_gateway_attachment_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TransitGatewayAttachmentId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "transit_gateway_attachment_id");

    /// <summary>
    /// The tunnel1_address attribute.
    /// </summary>
    [TerraformPropertyName("tunnel1_address")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Tunnel1Address => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "tunnel1_address");

    /// <summary>
    /// The tunnel1_bgp_asn attribute.
    /// </summary>
    [TerraformPropertyName("tunnel1_bgp_asn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Tunnel1BgpAsn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "tunnel1_bgp_asn");

    /// <summary>
    /// The tunnel1_bgp_holdtime attribute.
    /// </summary>
    [TerraformPropertyName("tunnel1_bgp_holdtime")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> Tunnel1BgpHoldtime => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "tunnel1_bgp_holdtime");

    /// <summary>
    /// The tunnel1_cgw_inside_address attribute.
    /// </summary>
    [TerraformPropertyName("tunnel1_cgw_inside_address")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Tunnel1CgwInsideAddress => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "tunnel1_cgw_inside_address");

    /// <summary>
    /// The tunnel1_vgw_inside_address attribute.
    /// </summary>
    [TerraformPropertyName("tunnel1_vgw_inside_address")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Tunnel1VgwInsideAddress => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "tunnel1_vgw_inside_address");

    /// <summary>
    /// The tunnel2_address attribute.
    /// </summary>
    [TerraformPropertyName("tunnel2_address")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Tunnel2Address => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "tunnel2_address");

    /// <summary>
    /// The tunnel2_bgp_asn attribute.
    /// </summary>
    [TerraformPropertyName("tunnel2_bgp_asn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Tunnel2BgpAsn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "tunnel2_bgp_asn");

    /// <summary>
    /// The tunnel2_bgp_holdtime attribute.
    /// </summary>
    [TerraformPropertyName("tunnel2_bgp_holdtime")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> Tunnel2BgpHoldtime => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "tunnel2_bgp_holdtime");

    /// <summary>
    /// The tunnel2_cgw_inside_address attribute.
    /// </summary>
    [TerraformPropertyName("tunnel2_cgw_inside_address")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Tunnel2CgwInsideAddress => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "tunnel2_cgw_inside_address");

    /// <summary>
    /// The tunnel2_vgw_inside_address attribute.
    /// </summary>
    [TerraformPropertyName("tunnel2_vgw_inside_address")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Tunnel2VgwInsideAddress => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "tunnel2_vgw_inside_address");

    /// <summary>
    /// The vgw_telemetry attribute.
    /// </summary>
    [TerraformPropertyName("vgw_telemetry")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> VgwTelemetry => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "vgw_telemetry");

}
