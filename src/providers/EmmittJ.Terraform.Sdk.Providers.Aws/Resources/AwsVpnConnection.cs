using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for tunnel1_log_options in .
/// Nesting mode: list
/// </summary>
public class AwsVpnConnectionTunnel1LogOptionsBlock : TerraformBlock
{
}

/// <summary>
/// Block type for tunnel2_log_options in .
/// Nesting mode: list
/// </summary>
public class AwsVpnConnectionTunnel2LogOptionsBlock : TerraformBlock
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
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("core_network_arn");
        SetOutput("core_network_attachment_arn");
        SetOutput("customer_gateway_configuration");
        SetOutput("preshared_key_arn");
        SetOutput("routes");
        SetOutput("transit_gateway_attachment_id");
        SetOutput("tunnel1_address");
        SetOutput("tunnel1_bgp_asn");
        SetOutput("tunnel1_bgp_holdtime");
        SetOutput("tunnel1_cgw_inside_address");
        SetOutput("tunnel1_vgw_inside_address");
        SetOutput("tunnel2_address");
        SetOutput("tunnel2_bgp_asn");
        SetOutput("tunnel2_bgp_holdtime");
        SetOutput("tunnel2_cgw_inside_address");
        SetOutput("tunnel2_vgw_inside_address");
        SetOutput("vgw_telemetry");
        SetOutput("customer_gateway_id");
        SetOutput("enable_acceleration");
        SetOutput("id");
        SetOutput("local_ipv4_network_cidr");
        SetOutput("local_ipv6_network_cidr");
        SetOutput("outside_ip_address_type");
        SetOutput("preshared_key_storage");
        SetOutput("region");
        SetOutput("remote_ipv4_network_cidr");
        SetOutput("remote_ipv6_network_cidr");
        SetOutput("static_routes_only");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("transit_gateway_id");
        SetOutput("transport_transit_gateway_attachment_id");
        SetOutput("tunnel1_dpd_timeout_action");
        SetOutput("tunnel1_dpd_timeout_seconds");
        SetOutput("tunnel1_enable_tunnel_lifecycle_control");
        SetOutput("tunnel1_ike_versions");
        SetOutput("tunnel1_inside_cidr");
        SetOutput("tunnel1_inside_ipv6_cidr");
        SetOutput("tunnel1_phase1_dh_group_numbers");
        SetOutput("tunnel1_phase1_encryption_algorithms");
        SetOutput("tunnel1_phase1_integrity_algorithms");
        SetOutput("tunnel1_phase1_lifetime_seconds");
        SetOutput("tunnel1_phase2_dh_group_numbers");
        SetOutput("tunnel1_phase2_encryption_algorithms");
        SetOutput("tunnel1_phase2_integrity_algorithms");
        SetOutput("tunnel1_phase2_lifetime_seconds");
        SetOutput("tunnel1_preshared_key");
        SetOutput("tunnel1_rekey_fuzz_percentage");
        SetOutput("tunnel1_rekey_margin_time_seconds");
        SetOutput("tunnel1_replay_window_size");
        SetOutput("tunnel1_startup_action");
        SetOutput("tunnel2_dpd_timeout_action");
        SetOutput("tunnel2_dpd_timeout_seconds");
        SetOutput("tunnel2_enable_tunnel_lifecycle_control");
        SetOutput("tunnel2_ike_versions");
        SetOutput("tunnel2_inside_cidr");
        SetOutput("tunnel2_inside_ipv6_cidr");
        SetOutput("tunnel2_phase1_dh_group_numbers");
        SetOutput("tunnel2_phase1_encryption_algorithms");
        SetOutput("tunnel2_phase1_integrity_algorithms");
        SetOutput("tunnel2_phase1_lifetime_seconds");
        SetOutput("tunnel2_phase2_dh_group_numbers");
        SetOutput("tunnel2_phase2_encryption_algorithms");
        SetOutput("tunnel2_phase2_integrity_algorithms");
        SetOutput("tunnel2_phase2_lifetime_seconds");
        SetOutput("tunnel2_preshared_key");
        SetOutput("tunnel2_rekey_fuzz_percentage");
        SetOutput("tunnel2_rekey_margin_time_seconds");
        SetOutput("tunnel2_replay_window_size");
        SetOutput("tunnel2_startup_action");
        SetOutput("tunnel_inside_ip_version");
        SetOutput("type");
        SetOutput("vpn_gateway_id");
    }

    /// <summary>
    /// The customer_gateway_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomerGatewayId is required")]
    public required TerraformProperty<string> CustomerGatewayId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("customer_gateway_id");
        set => SetProperty("customer_gateway_id", value);
    }

    /// <summary>
    /// The enable_acceleration attribute.
    /// </summary>
    public TerraformProperty<bool> EnableAcceleration
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_acceleration");
        set => SetProperty("enable_acceleration", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The local_ipv4_network_cidr attribute.
    /// </summary>
    public TerraformProperty<string> LocalIpv4NetworkCidr
    {
        get => GetRequiredOutput<TerraformProperty<string>>("local_ipv4_network_cidr");
        set => SetProperty("local_ipv4_network_cidr", value);
    }

    /// <summary>
    /// The local_ipv6_network_cidr attribute.
    /// </summary>
    public TerraformProperty<string> LocalIpv6NetworkCidr
    {
        get => GetRequiredOutput<TerraformProperty<string>>("local_ipv6_network_cidr");
        set => SetProperty("local_ipv6_network_cidr", value);
    }

    /// <summary>
    /// The outside_ip_address_type attribute.
    /// </summary>
    public TerraformProperty<string> OutsideIpAddressType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("outside_ip_address_type");
        set => SetProperty("outside_ip_address_type", value);
    }

    /// <summary>
    /// The preshared_key_storage attribute.
    /// </summary>
    public TerraformProperty<string> PresharedKeyStorage
    {
        get => GetRequiredOutput<TerraformProperty<string>>("preshared_key_storage");
        set => SetProperty("preshared_key_storage", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The remote_ipv4_network_cidr attribute.
    /// </summary>
    public TerraformProperty<string> RemoteIpv4NetworkCidr
    {
        get => GetRequiredOutput<TerraformProperty<string>>("remote_ipv4_network_cidr");
        set => SetProperty("remote_ipv4_network_cidr", value);
    }

    /// <summary>
    /// The remote_ipv6_network_cidr attribute.
    /// </summary>
    public TerraformProperty<string> RemoteIpv6NetworkCidr
    {
        get => GetRequiredOutput<TerraformProperty<string>>("remote_ipv6_network_cidr");
        set => SetProperty("remote_ipv6_network_cidr", value);
    }

    /// <summary>
    /// The static_routes_only attribute.
    /// </summary>
    public TerraformProperty<bool> StaticRoutesOnly
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("static_routes_only");
        set => SetProperty("static_routes_only", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The transit_gateway_id attribute.
    /// </summary>
    public TerraformProperty<string> TransitGatewayId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("transit_gateway_id");
        set => SetProperty("transit_gateway_id", value);
    }

    /// <summary>
    /// The transport_transit_gateway_attachment_id attribute.
    /// </summary>
    public TerraformProperty<string> TransportTransitGatewayAttachmentId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("transport_transit_gateway_attachment_id");
        set => SetProperty("transport_transit_gateway_attachment_id", value);
    }

    /// <summary>
    /// The tunnel1_dpd_timeout_action attribute.
    /// </summary>
    public TerraformProperty<string> Tunnel1DpdTimeoutAction
    {
        get => GetRequiredOutput<TerraformProperty<string>>("tunnel1_dpd_timeout_action");
        set => SetProperty("tunnel1_dpd_timeout_action", value);
    }

    /// <summary>
    /// The tunnel1_dpd_timeout_seconds attribute.
    /// </summary>
    public TerraformProperty<double> Tunnel1DpdTimeoutSeconds
    {
        get => GetRequiredOutput<TerraformProperty<double>>("tunnel1_dpd_timeout_seconds");
        set => SetProperty("tunnel1_dpd_timeout_seconds", value);
    }

    /// <summary>
    /// The tunnel1_enable_tunnel_lifecycle_control attribute.
    /// </summary>
    public TerraformProperty<bool> Tunnel1EnableTunnelLifecycleControl
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("tunnel1_enable_tunnel_lifecycle_control");
        set => SetProperty("tunnel1_enable_tunnel_lifecycle_control", value);
    }

    /// <summary>
    /// The tunnel1_ike_versions attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> Tunnel1IkeVersions
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("tunnel1_ike_versions");
        set => SetProperty("tunnel1_ike_versions", value);
    }

    /// <summary>
    /// The tunnel1_inside_cidr attribute.
    /// </summary>
    public TerraformProperty<string> Tunnel1InsideCidr
    {
        get => GetRequiredOutput<TerraformProperty<string>>("tunnel1_inside_cidr");
        set => SetProperty("tunnel1_inside_cidr", value);
    }

    /// <summary>
    /// The tunnel1_inside_ipv6_cidr attribute.
    /// </summary>
    public TerraformProperty<string> Tunnel1InsideIpv6Cidr
    {
        get => GetRequiredOutput<TerraformProperty<string>>("tunnel1_inside_ipv6_cidr");
        set => SetProperty("tunnel1_inside_ipv6_cidr", value);
    }

    /// <summary>
    /// The tunnel1_phase1_dh_group_numbers attribute.
    /// </summary>
    public HashSet<TerraformProperty<double>> Tunnel1Phase1DhGroupNumbers
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<double>>>("tunnel1_phase1_dh_group_numbers");
        set => SetProperty("tunnel1_phase1_dh_group_numbers", value);
    }

    /// <summary>
    /// The tunnel1_phase1_encryption_algorithms attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> Tunnel1Phase1EncryptionAlgorithms
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("tunnel1_phase1_encryption_algorithms");
        set => SetProperty("tunnel1_phase1_encryption_algorithms", value);
    }

    /// <summary>
    /// The tunnel1_phase1_integrity_algorithms attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> Tunnel1Phase1IntegrityAlgorithms
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("tunnel1_phase1_integrity_algorithms");
        set => SetProperty("tunnel1_phase1_integrity_algorithms", value);
    }

    /// <summary>
    /// The tunnel1_phase1_lifetime_seconds attribute.
    /// </summary>
    public TerraformProperty<double> Tunnel1Phase1LifetimeSeconds
    {
        get => GetRequiredOutput<TerraformProperty<double>>("tunnel1_phase1_lifetime_seconds");
        set => SetProperty("tunnel1_phase1_lifetime_seconds", value);
    }

    /// <summary>
    /// The tunnel1_phase2_dh_group_numbers attribute.
    /// </summary>
    public HashSet<TerraformProperty<double>> Tunnel1Phase2DhGroupNumbers
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<double>>>("tunnel1_phase2_dh_group_numbers");
        set => SetProperty("tunnel1_phase2_dh_group_numbers", value);
    }

    /// <summary>
    /// The tunnel1_phase2_encryption_algorithms attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> Tunnel1Phase2EncryptionAlgorithms
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("tunnel1_phase2_encryption_algorithms");
        set => SetProperty("tunnel1_phase2_encryption_algorithms", value);
    }

    /// <summary>
    /// The tunnel1_phase2_integrity_algorithms attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> Tunnel1Phase2IntegrityAlgorithms
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("tunnel1_phase2_integrity_algorithms");
        set => SetProperty("tunnel1_phase2_integrity_algorithms", value);
    }

    /// <summary>
    /// The tunnel1_phase2_lifetime_seconds attribute.
    /// </summary>
    public TerraformProperty<double> Tunnel1Phase2LifetimeSeconds
    {
        get => GetRequiredOutput<TerraformProperty<double>>("tunnel1_phase2_lifetime_seconds");
        set => SetProperty("tunnel1_phase2_lifetime_seconds", value);
    }

    /// <summary>
    /// The tunnel1_preshared_key attribute.
    /// </summary>
    public TerraformProperty<string> Tunnel1PresharedKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("tunnel1_preshared_key");
        set => SetProperty("tunnel1_preshared_key", value);
    }

    /// <summary>
    /// The tunnel1_rekey_fuzz_percentage attribute.
    /// </summary>
    public TerraformProperty<double> Tunnel1RekeyFuzzPercentage
    {
        get => GetRequiredOutput<TerraformProperty<double>>("tunnel1_rekey_fuzz_percentage");
        set => SetProperty("tunnel1_rekey_fuzz_percentage", value);
    }

    /// <summary>
    /// The tunnel1_rekey_margin_time_seconds attribute.
    /// </summary>
    public TerraformProperty<double> Tunnel1RekeyMarginTimeSeconds
    {
        get => GetRequiredOutput<TerraformProperty<double>>("tunnel1_rekey_margin_time_seconds");
        set => SetProperty("tunnel1_rekey_margin_time_seconds", value);
    }

    /// <summary>
    /// The tunnel1_replay_window_size attribute.
    /// </summary>
    public TerraformProperty<double> Tunnel1ReplayWindowSize
    {
        get => GetRequiredOutput<TerraformProperty<double>>("tunnel1_replay_window_size");
        set => SetProperty("tunnel1_replay_window_size", value);
    }

    /// <summary>
    /// The tunnel1_startup_action attribute.
    /// </summary>
    public TerraformProperty<string> Tunnel1StartupAction
    {
        get => GetRequiredOutput<TerraformProperty<string>>("tunnel1_startup_action");
        set => SetProperty("tunnel1_startup_action", value);
    }

    /// <summary>
    /// The tunnel2_dpd_timeout_action attribute.
    /// </summary>
    public TerraformProperty<string> Tunnel2DpdTimeoutAction
    {
        get => GetRequiredOutput<TerraformProperty<string>>("tunnel2_dpd_timeout_action");
        set => SetProperty("tunnel2_dpd_timeout_action", value);
    }

    /// <summary>
    /// The tunnel2_dpd_timeout_seconds attribute.
    /// </summary>
    public TerraformProperty<double> Tunnel2DpdTimeoutSeconds
    {
        get => GetRequiredOutput<TerraformProperty<double>>("tunnel2_dpd_timeout_seconds");
        set => SetProperty("tunnel2_dpd_timeout_seconds", value);
    }

    /// <summary>
    /// The tunnel2_enable_tunnel_lifecycle_control attribute.
    /// </summary>
    public TerraformProperty<bool> Tunnel2EnableTunnelLifecycleControl
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("tunnel2_enable_tunnel_lifecycle_control");
        set => SetProperty("tunnel2_enable_tunnel_lifecycle_control", value);
    }

    /// <summary>
    /// The tunnel2_ike_versions attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> Tunnel2IkeVersions
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("tunnel2_ike_versions");
        set => SetProperty("tunnel2_ike_versions", value);
    }

    /// <summary>
    /// The tunnel2_inside_cidr attribute.
    /// </summary>
    public TerraformProperty<string> Tunnel2InsideCidr
    {
        get => GetRequiredOutput<TerraformProperty<string>>("tunnel2_inside_cidr");
        set => SetProperty("tunnel2_inside_cidr", value);
    }

    /// <summary>
    /// The tunnel2_inside_ipv6_cidr attribute.
    /// </summary>
    public TerraformProperty<string> Tunnel2InsideIpv6Cidr
    {
        get => GetRequiredOutput<TerraformProperty<string>>("tunnel2_inside_ipv6_cidr");
        set => SetProperty("tunnel2_inside_ipv6_cidr", value);
    }

    /// <summary>
    /// The tunnel2_phase1_dh_group_numbers attribute.
    /// </summary>
    public HashSet<TerraformProperty<double>> Tunnel2Phase1DhGroupNumbers
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<double>>>("tunnel2_phase1_dh_group_numbers");
        set => SetProperty("tunnel2_phase1_dh_group_numbers", value);
    }

    /// <summary>
    /// The tunnel2_phase1_encryption_algorithms attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> Tunnel2Phase1EncryptionAlgorithms
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("tunnel2_phase1_encryption_algorithms");
        set => SetProperty("tunnel2_phase1_encryption_algorithms", value);
    }

    /// <summary>
    /// The tunnel2_phase1_integrity_algorithms attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> Tunnel2Phase1IntegrityAlgorithms
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("tunnel2_phase1_integrity_algorithms");
        set => SetProperty("tunnel2_phase1_integrity_algorithms", value);
    }

    /// <summary>
    /// The tunnel2_phase1_lifetime_seconds attribute.
    /// </summary>
    public TerraformProperty<double> Tunnel2Phase1LifetimeSeconds
    {
        get => GetRequiredOutput<TerraformProperty<double>>("tunnel2_phase1_lifetime_seconds");
        set => SetProperty("tunnel2_phase1_lifetime_seconds", value);
    }

    /// <summary>
    /// The tunnel2_phase2_dh_group_numbers attribute.
    /// </summary>
    public HashSet<TerraformProperty<double>> Tunnel2Phase2DhGroupNumbers
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<double>>>("tunnel2_phase2_dh_group_numbers");
        set => SetProperty("tunnel2_phase2_dh_group_numbers", value);
    }

    /// <summary>
    /// The tunnel2_phase2_encryption_algorithms attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> Tunnel2Phase2EncryptionAlgorithms
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("tunnel2_phase2_encryption_algorithms");
        set => SetProperty("tunnel2_phase2_encryption_algorithms", value);
    }

    /// <summary>
    /// The tunnel2_phase2_integrity_algorithms attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> Tunnel2Phase2IntegrityAlgorithms
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("tunnel2_phase2_integrity_algorithms");
        set => SetProperty("tunnel2_phase2_integrity_algorithms", value);
    }

    /// <summary>
    /// The tunnel2_phase2_lifetime_seconds attribute.
    /// </summary>
    public TerraformProperty<double> Tunnel2Phase2LifetimeSeconds
    {
        get => GetRequiredOutput<TerraformProperty<double>>("tunnel2_phase2_lifetime_seconds");
        set => SetProperty("tunnel2_phase2_lifetime_seconds", value);
    }

    /// <summary>
    /// The tunnel2_preshared_key attribute.
    /// </summary>
    public TerraformProperty<string> Tunnel2PresharedKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("tunnel2_preshared_key");
        set => SetProperty("tunnel2_preshared_key", value);
    }

    /// <summary>
    /// The tunnel2_rekey_fuzz_percentage attribute.
    /// </summary>
    public TerraformProperty<double> Tunnel2RekeyFuzzPercentage
    {
        get => GetRequiredOutput<TerraformProperty<double>>("tunnel2_rekey_fuzz_percentage");
        set => SetProperty("tunnel2_rekey_fuzz_percentage", value);
    }

    /// <summary>
    /// The tunnel2_rekey_margin_time_seconds attribute.
    /// </summary>
    public TerraformProperty<double> Tunnel2RekeyMarginTimeSeconds
    {
        get => GetRequiredOutput<TerraformProperty<double>>("tunnel2_rekey_margin_time_seconds");
        set => SetProperty("tunnel2_rekey_margin_time_seconds", value);
    }

    /// <summary>
    /// The tunnel2_replay_window_size attribute.
    /// </summary>
    public TerraformProperty<double> Tunnel2ReplayWindowSize
    {
        get => GetRequiredOutput<TerraformProperty<double>>("tunnel2_replay_window_size");
        set => SetProperty("tunnel2_replay_window_size", value);
    }

    /// <summary>
    /// The tunnel2_startup_action attribute.
    /// </summary>
    public TerraformProperty<string> Tunnel2StartupAction
    {
        get => GetRequiredOutput<TerraformProperty<string>>("tunnel2_startup_action");
        set => SetProperty("tunnel2_startup_action", value);
    }

    /// <summary>
    /// The tunnel_inside_ip_version attribute.
    /// </summary>
    public TerraformProperty<string> TunnelInsideIpVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("tunnel_inside_ip_version");
        set => SetProperty("tunnel_inside_ip_version", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetRequiredOutput<TerraformProperty<string>>("type");
        set => SetProperty("type", value);
    }

    /// <summary>
    /// The vpn_gateway_id attribute.
    /// </summary>
    public TerraformProperty<string> VpnGatewayId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("vpn_gateway_id");
        set => SetProperty("vpn_gateway_id", value);
    }

    /// <summary>
    /// Block for tunnel1_log_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Tunnel1LogOptions block(s) allowed")]
    public List<AwsVpnConnectionTunnel1LogOptionsBlock>? Tunnel1LogOptions
    {
        set => SetProperty("tunnel1_log_options", value);
    }

    /// <summary>
    /// Block for tunnel2_log_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Tunnel2LogOptions block(s) allowed")]
    public List<AwsVpnConnectionTunnel2LogOptionsBlock>? Tunnel2LogOptions
    {
        set => SetProperty("tunnel2_log_options", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The core_network_arn attribute.
    /// </summary>
    public TerraformExpression CoreNetworkArn => this["core_network_arn"];

    /// <summary>
    /// The core_network_attachment_arn attribute.
    /// </summary>
    public TerraformExpression CoreNetworkAttachmentArn => this["core_network_attachment_arn"];

    /// <summary>
    /// The customer_gateway_configuration attribute.
    /// </summary>
    public TerraformExpression CustomerGatewayConfiguration => this["customer_gateway_configuration"];

    /// <summary>
    /// The preshared_key_arn attribute.
    /// </summary>
    public TerraformExpression PresharedKeyArn => this["preshared_key_arn"];

    /// <summary>
    /// The routes attribute.
    /// </summary>
    public TerraformExpression Routes => this["routes"];

    /// <summary>
    /// The transit_gateway_attachment_id attribute.
    /// </summary>
    public TerraformExpression TransitGatewayAttachmentId => this["transit_gateway_attachment_id"];

    /// <summary>
    /// The tunnel1_address attribute.
    /// </summary>
    public TerraformExpression Tunnel1Address => this["tunnel1_address"];

    /// <summary>
    /// The tunnel1_bgp_asn attribute.
    /// </summary>
    public TerraformExpression Tunnel1BgpAsn => this["tunnel1_bgp_asn"];

    /// <summary>
    /// The tunnel1_bgp_holdtime attribute.
    /// </summary>
    public TerraformExpression Tunnel1BgpHoldtime => this["tunnel1_bgp_holdtime"];

    /// <summary>
    /// The tunnel1_cgw_inside_address attribute.
    /// </summary>
    public TerraformExpression Tunnel1CgwInsideAddress => this["tunnel1_cgw_inside_address"];

    /// <summary>
    /// The tunnel1_vgw_inside_address attribute.
    /// </summary>
    public TerraformExpression Tunnel1VgwInsideAddress => this["tunnel1_vgw_inside_address"];

    /// <summary>
    /// The tunnel2_address attribute.
    /// </summary>
    public TerraformExpression Tunnel2Address => this["tunnel2_address"];

    /// <summary>
    /// The tunnel2_bgp_asn attribute.
    /// </summary>
    public TerraformExpression Tunnel2BgpAsn => this["tunnel2_bgp_asn"];

    /// <summary>
    /// The tunnel2_bgp_holdtime attribute.
    /// </summary>
    public TerraformExpression Tunnel2BgpHoldtime => this["tunnel2_bgp_holdtime"];

    /// <summary>
    /// The tunnel2_cgw_inside_address attribute.
    /// </summary>
    public TerraformExpression Tunnel2CgwInsideAddress => this["tunnel2_cgw_inside_address"];

    /// <summary>
    /// The tunnel2_vgw_inside_address attribute.
    /// </summary>
    public TerraformExpression Tunnel2VgwInsideAddress => this["tunnel2_vgw_inside_address"];

    /// <summary>
    /// The vgw_telemetry attribute.
    /// </summary>
    public TerraformExpression VgwTelemetry => this["vgw_telemetry"];

}
