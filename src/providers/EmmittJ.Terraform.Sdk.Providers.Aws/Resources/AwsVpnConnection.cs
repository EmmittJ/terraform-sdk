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
        this.DeclareOutput("arn");
        this.DeclareOutput("core_network_arn");
        this.DeclareOutput("core_network_attachment_arn");
        this.DeclareOutput("customer_gateway_configuration");
        this.DeclareOutput("preshared_key_arn");
        this.DeclareOutput("routes");
        this.DeclareOutput("transit_gateway_attachment_id");
        this.DeclareOutput("tunnel1_address");
        this.DeclareOutput("tunnel1_bgp_asn");
        this.DeclareOutput("tunnel1_bgp_holdtime");
        this.DeclareOutput("tunnel1_cgw_inside_address");
        this.DeclareOutput("tunnel1_vgw_inside_address");
        this.DeclareOutput("tunnel2_address");
        this.DeclareOutput("tunnel2_bgp_asn");
        this.DeclareOutput("tunnel2_bgp_holdtime");
        this.DeclareOutput("tunnel2_cgw_inside_address");
        this.DeclareOutput("tunnel2_vgw_inside_address");
        this.DeclareOutput("vgw_telemetry");
    }

    /// <summary>
    /// The customer_gateway_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomerGatewayId is required")]
    public required TerraformProperty<string> CustomerGatewayId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("customer_gateway_id");
        set => this.WithProperty("customer_gateway_id", value);
    }

    /// <summary>
    /// The enable_acceleration attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableAcceleration
    {
        get => GetProperty<TerraformProperty<bool>>("enable_acceleration");
        set => this.WithProperty("enable_acceleration", value);
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
    /// The local_ipv4_network_cidr attribute.
    /// </summary>
    public TerraformProperty<string>? LocalIpv4NetworkCidr
    {
        get => GetProperty<TerraformProperty<string>>("local_ipv4_network_cidr");
        set => this.WithProperty("local_ipv4_network_cidr", value);
    }

    /// <summary>
    /// The local_ipv6_network_cidr attribute.
    /// </summary>
    public TerraformProperty<string>? LocalIpv6NetworkCidr
    {
        get => GetProperty<TerraformProperty<string>>("local_ipv6_network_cidr");
        set => this.WithProperty("local_ipv6_network_cidr", value);
    }

    /// <summary>
    /// The outside_ip_address_type attribute.
    /// </summary>
    public TerraformProperty<string>? OutsideIpAddressType
    {
        get => GetProperty<TerraformProperty<string>>("outside_ip_address_type");
        set => this.WithProperty("outside_ip_address_type", value);
    }

    /// <summary>
    /// The preshared_key_storage attribute.
    /// </summary>
    public TerraformProperty<string>? PresharedKeyStorage
    {
        get => GetProperty<TerraformProperty<string>>("preshared_key_storage");
        set => this.WithProperty("preshared_key_storage", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The remote_ipv4_network_cidr attribute.
    /// </summary>
    public TerraformProperty<string>? RemoteIpv4NetworkCidr
    {
        get => GetProperty<TerraformProperty<string>>("remote_ipv4_network_cidr");
        set => this.WithProperty("remote_ipv4_network_cidr", value);
    }

    /// <summary>
    /// The remote_ipv6_network_cidr attribute.
    /// </summary>
    public TerraformProperty<string>? RemoteIpv6NetworkCidr
    {
        get => GetProperty<TerraformProperty<string>>("remote_ipv6_network_cidr");
        set => this.WithProperty("remote_ipv6_network_cidr", value);
    }

    /// <summary>
    /// The static_routes_only attribute.
    /// </summary>
    public TerraformProperty<bool>? StaticRoutesOnly
    {
        get => GetProperty<TerraformProperty<bool>>("static_routes_only");
        set => this.WithProperty("static_routes_only", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The transit_gateway_id attribute.
    /// </summary>
    public TerraformProperty<string>? TransitGatewayId
    {
        get => GetProperty<TerraformProperty<string>>("transit_gateway_id");
        set => this.WithProperty("transit_gateway_id", value);
    }

    /// <summary>
    /// The transport_transit_gateway_attachment_id attribute.
    /// </summary>
    public TerraformProperty<string>? TransportTransitGatewayAttachmentId
    {
        get => GetProperty<TerraformProperty<string>>("transport_transit_gateway_attachment_id");
        set => this.WithProperty("transport_transit_gateway_attachment_id", value);
    }

    /// <summary>
    /// The tunnel1_dpd_timeout_action attribute.
    /// </summary>
    public TerraformProperty<string>? Tunnel1DpdTimeoutAction
    {
        get => GetProperty<TerraformProperty<string>>("tunnel1_dpd_timeout_action");
        set => this.WithProperty("tunnel1_dpd_timeout_action", value);
    }

    /// <summary>
    /// The tunnel1_dpd_timeout_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? Tunnel1DpdTimeoutSeconds
    {
        get => GetProperty<TerraformProperty<double>>("tunnel1_dpd_timeout_seconds");
        set => this.WithProperty("tunnel1_dpd_timeout_seconds", value);
    }

    /// <summary>
    /// The tunnel1_enable_tunnel_lifecycle_control attribute.
    /// </summary>
    public TerraformProperty<bool>? Tunnel1EnableTunnelLifecycleControl
    {
        get => GetProperty<TerraformProperty<bool>>("tunnel1_enable_tunnel_lifecycle_control");
        set => this.WithProperty("tunnel1_enable_tunnel_lifecycle_control", value);
    }

    /// <summary>
    /// The tunnel1_ike_versions attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Tunnel1IkeVersions
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("tunnel1_ike_versions");
        set => this.WithProperty("tunnel1_ike_versions", value);
    }

    /// <summary>
    /// The tunnel1_inside_cidr attribute.
    /// </summary>
    public TerraformProperty<string>? Tunnel1InsideCidr
    {
        get => GetProperty<TerraformProperty<string>>("tunnel1_inside_cidr");
        set => this.WithProperty("tunnel1_inside_cidr", value);
    }

    /// <summary>
    /// The tunnel1_inside_ipv6_cidr attribute.
    /// </summary>
    public TerraformProperty<string>? Tunnel1InsideIpv6Cidr
    {
        get => GetProperty<TerraformProperty<string>>("tunnel1_inside_ipv6_cidr");
        set => this.WithProperty("tunnel1_inside_ipv6_cidr", value);
    }

    /// <summary>
    /// The tunnel1_phase1_dh_group_numbers attribute.
    /// </summary>
    public HashSet<TerraformProperty<double>>? Tunnel1Phase1DhGroupNumbers
    {
        get => GetProperty<HashSet<TerraformProperty<double>>>("tunnel1_phase1_dh_group_numbers");
        set => this.WithProperty("tunnel1_phase1_dh_group_numbers", value);
    }

    /// <summary>
    /// The tunnel1_phase1_encryption_algorithms attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Tunnel1Phase1EncryptionAlgorithms
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("tunnel1_phase1_encryption_algorithms");
        set => this.WithProperty("tunnel1_phase1_encryption_algorithms", value);
    }

    /// <summary>
    /// The tunnel1_phase1_integrity_algorithms attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Tunnel1Phase1IntegrityAlgorithms
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("tunnel1_phase1_integrity_algorithms");
        set => this.WithProperty("tunnel1_phase1_integrity_algorithms", value);
    }

    /// <summary>
    /// The tunnel1_phase1_lifetime_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? Tunnel1Phase1LifetimeSeconds
    {
        get => GetProperty<TerraformProperty<double>>("tunnel1_phase1_lifetime_seconds");
        set => this.WithProperty("tunnel1_phase1_lifetime_seconds", value);
    }

    /// <summary>
    /// The tunnel1_phase2_dh_group_numbers attribute.
    /// </summary>
    public HashSet<TerraformProperty<double>>? Tunnel1Phase2DhGroupNumbers
    {
        get => GetProperty<HashSet<TerraformProperty<double>>>("tunnel1_phase2_dh_group_numbers");
        set => this.WithProperty("tunnel1_phase2_dh_group_numbers", value);
    }

    /// <summary>
    /// The tunnel1_phase2_encryption_algorithms attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Tunnel1Phase2EncryptionAlgorithms
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("tunnel1_phase2_encryption_algorithms");
        set => this.WithProperty("tunnel1_phase2_encryption_algorithms", value);
    }

    /// <summary>
    /// The tunnel1_phase2_integrity_algorithms attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Tunnel1Phase2IntegrityAlgorithms
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("tunnel1_phase2_integrity_algorithms");
        set => this.WithProperty("tunnel1_phase2_integrity_algorithms", value);
    }

    /// <summary>
    /// The tunnel1_phase2_lifetime_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? Tunnel1Phase2LifetimeSeconds
    {
        get => GetProperty<TerraformProperty<double>>("tunnel1_phase2_lifetime_seconds");
        set => this.WithProperty("tunnel1_phase2_lifetime_seconds", value);
    }

    /// <summary>
    /// The tunnel1_preshared_key attribute.
    /// </summary>
    public TerraformProperty<string>? Tunnel1PresharedKey
    {
        get => GetProperty<TerraformProperty<string>>("tunnel1_preshared_key");
        set => this.WithProperty("tunnel1_preshared_key", value);
    }

    /// <summary>
    /// The tunnel1_rekey_fuzz_percentage attribute.
    /// </summary>
    public TerraformProperty<double>? Tunnel1RekeyFuzzPercentage
    {
        get => GetProperty<TerraformProperty<double>>("tunnel1_rekey_fuzz_percentage");
        set => this.WithProperty("tunnel1_rekey_fuzz_percentage", value);
    }

    /// <summary>
    /// The tunnel1_rekey_margin_time_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? Tunnel1RekeyMarginTimeSeconds
    {
        get => GetProperty<TerraformProperty<double>>("tunnel1_rekey_margin_time_seconds");
        set => this.WithProperty("tunnel1_rekey_margin_time_seconds", value);
    }

    /// <summary>
    /// The tunnel1_replay_window_size attribute.
    /// </summary>
    public TerraformProperty<double>? Tunnel1ReplayWindowSize
    {
        get => GetProperty<TerraformProperty<double>>("tunnel1_replay_window_size");
        set => this.WithProperty("tunnel1_replay_window_size", value);
    }

    /// <summary>
    /// The tunnel1_startup_action attribute.
    /// </summary>
    public TerraformProperty<string>? Tunnel1StartupAction
    {
        get => GetProperty<TerraformProperty<string>>("tunnel1_startup_action");
        set => this.WithProperty("tunnel1_startup_action", value);
    }

    /// <summary>
    /// The tunnel2_dpd_timeout_action attribute.
    /// </summary>
    public TerraformProperty<string>? Tunnel2DpdTimeoutAction
    {
        get => GetProperty<TerraformProperty<string>>("tunnel2_dpd_timeout_action");
        set => this.WithProperty("tunnel2_dpd_timeout_action", value);
    }

    /// <summary>
    /// The tunnel2_dpd_timeout_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? Tunnel2DpdTimeoutSeconds
    {
        get => GetProperty<TerraformProperty<double>>("tunnel2_dpd_timeout_seconds");
        set => this.WithProperty("tunnel2_dpd_timeout_seconds", value);
    }

    /// <summary>
    /// The tunnel2_enable_tunnel_lifecycle_control attribute.
    /// </summary>
    public TerraformProperty<bool>? Tunnel2EnableTunnelLifecycleControl
    {
        get => GetProperty<TerraformProperty<bool>>("tunnel2_enable_tunnel_lifecycle_control");
        set => this.WithProperty("tunnel2_enable_tunnel_lifecycle_control", value);
    }

    /// <summary>
    /// The tunnel2_ike_versions attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Tunnel2IkeVersions
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("tunnel2_ike_versions");
        set => this.WithProperty("tunnel2_ike_versions", value);
    }

    /// <summary>
    /// The tunnel2_inside_cidr attribute.
    /// </summary>
    public TerraformProperty<string>? Tunnel2InsideCidr
    {
        get => GetProperty<TerraformProperty<string>>("tunnel2_inside_cidr");
        set => this.WithProperty("tunnel2_inside_cidr", value);
    }

    /// <summary>
    /// The tunnel2_inside_ipv6_cidr attribute.
    /// </summary>
    public TerraformProperty<string>? Tunnel2InsideIpv6Cidr
    {
        get => GetProperty<TerraformProperty<string>>("tunnel2_inside_ipv6_cidr");
        set => this.WithProperty("tunnel2_inside_ipv6_cidr", value);
    }

    /// <summary>
    /// The tunnel2_phase1_dh_group_numbers attribute.
    /// </summary>
    public HashSet<TerraformProperty<double>>? Tunnel2Phase1DhGroupNumbers
    {
        get => GetProperty<HashSet<TerraformProperty<double>>>("tunnel2_phase1_dh_group_numbers");
        set => this.WithProperty("tunnel2_phase1_dh_group_numbers", value);
    }

    /// <summary>
    /// The tunnel2_phase1_encryption_algorithms attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Tunnel2Phase1EncryptionAlgorithms
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("tunnel2_phase1_encryption_algorithms");
        set => this.WithProperty("tunnel2_phase1_encryption_algorithms", value);
    }

    /// <summary>
    /// The tunnel2_phase1_integrity_algorithms attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Tunnel2Phase1IntegrityAlgorithms
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("tunnel2_phase1_integrity_algorithms");
        set => this.WithProperty("tunnel2_phase1_integrity_algorithms", value);
    }

    /// <summary>
    /// The tunnel2_phase1_lifetime_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? Tunnel2Phase1LifetimeSeconds
    {
        get => GetProperty<TerraformProperty<double>>("tunnel2_phase1_lifetime_seconds");
        set => this.WithProperty("tunnel2_phase1_lifetime_seconds", value);
    }

    /// <summary>
    /// The tunnel2_phase2_dh_group_numbers attribute.
    /// </summary>
    public HashSet<TerraformProperty<double>>? Tunnel2Phase2DhGroupNumbers
    {
        get => GetProperty<HashSet<TerraformProperty<double>>>("tunnel2_phase2_dh_group_numbers");
        set => this.WithProperty("tunnel2_phase2_dh_group_numbers", value);
    }

    /// <summary>
    /// The tunnel2_phase2_encryption_algorithms attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Tunnel2Phase2EncryptionAlgorithms
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("tunnel2_phase2_encryption_algorithms");
        set => this.WithProperty("tunnel2_phase2_encryption_algorithms", value);
    }

    /// <summary>
    /// The tunnel2_phase2_integrity_algorithms attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Tunnel2Phase2IntegrityAlgorithms
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("tunnel2_phase2_integrity_algorithms");
        set => this.WithProperty("tunnel2_phase2_integrity_algorithms", value);
    }

    /// <summary>
    /// The tunnel2_phase2_lifetime_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? Tunnel2Phase2LifetimeSeconds
    {
        get => GetProperty<TerraformProperty<double>>("tunnel2_phase2_lifetime_seconds");
        set => this.WithProperty("tunnel2_phase2_lifetime_seconds", value);
    }

    /// <summary>
    /// The tunnel2_preshared_key attribute.
    /// </summary>
    public TerraformProperty<string>? Tunnel2PresharedKey
    {
        get => GetProperty<TerraformProperty<string>>("tunnel2_preshared_key");
        set => this.WithProperty("tunnel2_preshared_key", value);
    }

    /// <summary>
    /// The tunnel2_rekey_fuzz_percentage attribute.
    /// </summary>
    public TerraformProperty<double>? Tunnel2RekeyFuzzPercentage
    {
        get => GetProperty<TerraformProperty<double>>("tunnel2_rekey_fuzz_percentage");
        set => this.WithProperty("tunnel2_rekey_fuzz_percentage", value);
    }

    /// <summary>
    /// The tunnel2_rekey_margin_time_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? Tunnel2RekeyMarginTimeSeconds
    {
        get => GetProperty<TerraformProperty<double>>("tunnel2_rekey_margin_time_seconds");
        set => this.WithProperty("tunnel2_rekey_margin_time_seconds", value);
    }

    /// <summary>
    /// The tunnel2_replay_window_size attribute.
    /// </summary>
    public TerraformProperty<double>? Tunnel2ReplayWindowSize
    {
        get => GetProperty<TerraformProperty<double>>("tunnel2_replay_window_size");
        set => this.WithProperty("tunnel2_replay_window_size", value);
    }

    /// <summary>
    /// The tunnel2_startup_action attribute.
    /// </summary>
    public TerraformProperty<string>? Tunnel2StartupAction
    {
        get => GetProperty<TerraformProperty<string>>("tunnel2_startup_action");
        set => this.WithProperty("tunnel2_startup_action", value);
    }

    /// <summary>
    /// The tunnel_inside_ip_version attribute.
    /// </summary>
    public TerraformProperty<string>? TunnelInsideIpVersion
    {
        get => GetProperty<TerraformProperty<string>>("tunnel_inside_ip_version");
        set => this.WithProperty("tunnel_inside_ip_version", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetRequiredProperty<TerraformProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// The vpn_gateway_id attribute.
    /// </summary>
    public TerraformProperty<string>? VpnGatewayId
    {
        get => GetProperty<TerraformProperty<string>>("vpn_gateway_id");
        set => this.WithProperty("vpn_gateway_id", value);
    }

    /// <summary>
    /// Block for tunnel1_log_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Tunnel1LogOptions block(s) allowed")]
    public List<AwsVpnConnectionTunnel1LogOptionsBlock>? Tunnel1LogOptions
    {
        get => GetProperty<List<AwsVpnConnectionTunnel1LogOptionsBlock>>("tunnel1_log_options");
        set => this.WithProperty("tunnel1_log_options", value);
    }

    /// <summary>
    /// Block for tunnel2_log_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Tunnel2LogOptions block(s) allowed")]
    public List<AwsVpnConnectionTunnel2LogOptionsBlock>? Tunnel2LogOptions
    {
        get => GetProperty<List<AwsVpnConnectionTunnel2LogOptionsBlock>>("tunnel2_log_options");
        set => this.WithProperty("tunnel2_log_options", value);
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
