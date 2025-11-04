using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_vpn_connection resource.
/// </summary>
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
    public string? CustomerGatewayId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("customer_gateway_id")?.Value;
        set => this.WithProperty("customer_gateway_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The enable_acceleration attribute.
    /// </summary>
    public bool? EnableAcceleration
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_acceleration")?.Value;
        set => this.WithProperty("enable_acceleration", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The local_ipv4_network_cidr attribute.
    /// </summary>
    public string? LocalIpv4NetworkCidr
    {
        get => GetProperty<TerraformLiteralProperty<string>>("local_ipv4_network_cidr")?.Value;
        set => this.WithProperty("local_ipv4_network_cidr", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The local_ipv6_network_cidr attribute.
    /// </summary>
    public string? LocalIpv6NetworkCidr
    {
        get => GetProperty<TerraformLiteralProperty<string>>("local_ipv6_network_cidr")?.Value;
        set => this.WithProperty("local_ipv6_network_cidr", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The outside_ip_address_type attribute.
    /// </summary>
    public string? OutsideIpAddressType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("outside_ip_address_type")?.Value;
        set => this.WithProperty("outside_ip_address_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The preshared_key_storage attribute.
    /// </summary>
    public string? PresharedKeyStorage
    {
        get => GetProperty<TerraformLiteralProperty<string>>("preshared_key_storage")?.Value;
        set => this.WithProperty("preshared_key_storage", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The remote_ipv4_network_cidr attribute.
    /// </summary>
    public string? RemoteIpv4NetworkCidr
    {
        get => GetProperty<TerraformLiteralProperty<string>>("remote_ipv4_network_cidr")?.Value;
        set => this.WithProperty("remote_ipv4_network_cidr", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The remote_ipv6_network_cidr attribute.
    /// </summary>
    public string? RemoteIpv6NetworkCidr
    {
        get => GetProperty<TerraformLiteralProperty<string>>("remote_ipv6_network_cidr")?.Value;
        set => this.WithProperty("remote_ipv6_network_cidr", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The static_routes_only attribute.
    /// </summary>
    public bool? StaticRoutesOnly
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("static_routes_only")?.Value;
        set => this.WithProperty("static_routes_only", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The transit_gateway_id attribute.
    /// </summary>
    public string? TransitGatewayId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("transit_gateway_id")?.Value;
        set => this.WithProperty("transit_gateway_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The transport_transit_gateway_attachment_id attribute.
    /// </summary>
    public string? TransportTransitGatewayAttachmentId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("transport_transit_gateway_attachment_id")?.Value;
        set => this.WithProperty("transport_transit_gateway_attachment_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tunnel1_dpd_timeout_action attribute.
    /// </summary>
    public string? Tunnel1DpdTimeoutAction
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tunnel1_dpd_timeout_action")?.Value;
        set => this.WithProperty("tunnel1_dpd_timeout_action", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tunnel1_dpd_timeout_seconds attribute.
    /// </summary>
    public double? Tunnel1DpdTimeoutSeconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("tunnel1_dpd_timeout_seconds")?.Value;
        set => this.WithProperty("tunnel1_dpd_timeout_seconds", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The tunnel1_enable_tunnel_lifecycle_control attribute.
    /// </summary>
    public bool? Tunnel1EnableTunnelLifecycleControl
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("tunnel1_enable_tunnel_lifecycle_control")?.Value;
        set => this.WithProperty("tunnel1_enable_tunnel_lifecycle_control", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The tunnel1_ike_versions attribute.
    /// </summary>
    public HashSet<string>? Tunnel1IkeVersions
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("tunnel1_ike_versions")?.Value;
        set => this.WithProperty("tunnel1_ike_versions", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The tunnel1_inside_cidr attribute.
    /// </summary>
    public string? Tunnel1InsideCidr
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tunnel1_inside_cidr")?.Value;
        set => this.WithProperty("tunnel1_inside_cidr", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tunnel1_inside_ipv6_cidr attribute.
    /// </summary>
    public string? Tunnel1InsideIpv6Cidr
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tunnel1_inside_ipv6_cidr")?.Value;
        set => this.WithProperty("tunnel1_inside_ipv6_cidr", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tunnel1_phase1_dh_group_numbers attribute.
    /// </summary>
    public HashSet<double>? Tunnel1Phase1DhGroupNumbers
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<double>>>("tunnel1_phase1_dh_group_numbers")?.Value;
        set => this.WithProperty("tunnel1_phase1_dh_group_numbers", value == null ? null : new TerraformLiteralProperty<HashSet<double>>(value));
    }

    /// <summary>
    /// The tunnel1_phase1_encryption_algorithms attribute.
    /// </summary>
    public HashSet<string>? Tunnel1Phase1EncryptionAlgorithms
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("tunnel1_phase1_encryption_algorithms")?.Value;
        set => this.WithProperty("tunnel1_phase1_encryption_algorithms", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The tunnel1_phase1_integrity_algorithms attribute.
    /// </summary>
    public HashSet<string>? Tunnel1Phase1IntegrityAlgorithms
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("tunnel1_phase1_integrity_algorithms")?.Value;
        set => this.WithProperty("tunnel1_phase1_integrity_algorithms", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The tunnel1_phase1_lifetime_seconds attribute.
    /// </summary>
    public double? Tunnel1Phase1LifetimeSeconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("tunnel1_phase1_lifetime_seconds")?.Value;
        set => this.WithProperty("tunnel1_phase1_lifetime_seconds", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The tunnel1_phase2_dh_group_numbers attribute.
    /// </summary>
    public HashSet<double>? Tunnel1Phase2DhGroupNumbers
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<double>>>("tunnel1_phase2_dh_group_numbers")?.Value;
        set => this.WithProperty("tunnel1_phase2_dh_group_numbers", value == null ? null : new TerraformLiteralProperty<HashSet<double>>(value));
    }

    /// <summary>
    /// The tunnel1_phase2_encryption_algorithms attribute.
    /// </summary>
    public HashSet<string>? Tunnel1Phase2EncryptionAlgorithms
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("tunnel1_phase2_encryption_algorithms")?.Value;
        set => this.WithProperty("tunnel1_phase2_encryption_algorithms", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The tunnel1_phase2_integrity_algorithms attribute.
    /// </summary>
    public HashSet<string>? Tunnel1Phase2IntegrityAlgorithms
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("tunnel1_phase2_integrity_algorithms")?.Value;
        set => this.WithProperty("tunnel1_phase2_integrity_algorithms", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The tunnel1_phase2_lifetime_seconds attribute.
    /// </summary>
    public double? Tunnel1Phase2LifetimeSeconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("tunnel1_phase2_lifetime_seconds")?.Value;
        set => this.WithProperty("tunnel1_phase2_lifetime_seconds", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The tunnel1_preshared_key attribute.
    /// </summary>
    public string? Tunnel1PresharedKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tunnel1_preshared_key")?.Value;
        set => this.WithProperty("tunnel1_preshared_key", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tunnel1_rekey_fuzz_percentage attribute.
    /// </summary>
    public double? Tunnel1RekeyFuzzPercentage
    {
        get => GetProperty<TerraformLiteralProperty<double>>("tunnel1_rekey_fuzz_percentage")?.Value;
        set => this.WithProperty("tunnel1_rekey_fuzz_percentage", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The tunnel1_rekey_margin_time_seconds attribute.
    /// </summary>
    public double? Tunnel1RekeyMarginTimeSeconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("tunnel1_rekey_margin_time_seconds")?.Value;
        set => this.WithProperty("tunnel1_rekey_margin_time_seconds", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The tunnel1_replay_window_size attribute.
    /// </summary>
    public double? Tunnel1ReplayWindowSize
    {
        get => GetProperty<TerraformLiteralProperty<double>>("tunnel1_replay_window_size")?.Value;
        set => this.WithProperty("tunnel1_replay_window_size", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The tunnel1_startup_action attribute.
    /// </summary>
    public string? Tunnel1StartupAction
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tunnel1_startup_action")?.Value;
        set => this.WithProperty("tunnel1_startup_action", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tunnel2_dpd_timeout_action attribute.
    /// </summary>
    public string? Tunnel2DpdTimeoutAction
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tunnel2_dpd_timeout_action")?.Value;
        set => this.WithProperty("tunnel2_dpd_timeout_action", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tunnel2_dpd_timeout_seconds attribute.
    /// </summary>
    public double? Tunnel2DpdTimeoutSeconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("tunnel2_dpd_timeout_seconds")?.Value;
        set => this.WithProperty("tunnel2_dpd_timeout_seconds", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The tunnel2_enable_tunnel_lifecycle_control attribute.
    /// </summary>
    public bool? Tunnel2EnableTunnelLifecycleControl
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("tunnel2_enable_tunnel_lifecycle_control")?.Value;
        set => this.WithProperty("tunnel2_enable_tunnel_lifecycle_control", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The tunnel2_ike_versions attribute.
    /// </summary>
    public HashSet<string>? Tunnel2IkeVersions
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("tunnel2_ike_versions")?.Value;
        set => this.WithProperty("tunnel2_ike_versions", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The tunnel2_inside_cidr attribute.
    /// </summary>
    public string? Tunnel2InsideCidr
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tunnel2_inside_cidr")?.Value;
        set => this.WithProperty("tunnel2_inside_cidr", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tunnel2_inside_ipv6_cidr attribute.
    /// </summary>
    public string? Tunnel2InsideIpv6Cidr
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tunnel2_inside_ipv6_cidr")?.Value;
        set => this.WithProperty("tunnel2_inside_ipv6_cidr", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tunnel2_phase1_dh_group_numbers attribute.
    /// </summary>
    public HashSet<double>? Tunnel2Phase1DhGroupNumbers
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<double>>>("tunnel2_phase1_dh_group_numbers")?.Value;
        set => this.WithProperty("tunnel2_phase1_dh_group_numbers", value == null ? null : new TerraformLiteralProperty<HashSet<double>>(value));
    }

    /// <summary>
    /// The tunnel2_phase1_encryption_algorithms attribute.
    /// </summary>
    public HashSet<string>? Tunnel2Phase1EncryptionAlgorithms
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("tunnel2_phase1_encryption_algorithms")?.Value;
        set => this.WithProperty("tunnel2_phase1_encryption_algorithms", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The tunnel2_phase1_integrity_algorithms attribute.
    /// </summary>
    public HashSet<string>? Tunnel2Phase1IntegrityAlgorithms
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("tunnel2_phase1_integrity_algorithms")?.Value;
        set => this.WithProperty("tunnel2_phase1_integrity_algorithms", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The tunnel2_phase1_lifetime_seconds attribute.
    /// </summary>
    public double? Tunnel2Phase1LifetimeSeconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("tunnel2_phase1_lifetime_seconds")?.Value;
        set => this.WithProperty("tunnel2_phase1_lifetime_seconds", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The tunnel2_phase2_dh_group_numbers attribute.
    /// </summary>
    public HashSet<double>? Tunnel2Phase2DhGroupNumbers
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<double>>>("tunnel2_phase2_dh_group_numbers")?.Value;
        set => this.WithProperty("tunnel2_phase2_dh_group_numbers", value == null ? null : new TerraformLiteralProperty<HashSet<double>>(value));
    }

    /// <summary>
    /// The tunnel2_phase2_encryption_algorithms attribute.
    /// </summary>
    public HashSet<string>? Tunnel2Phase2EncryptionAlgorithms
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("tunnel2_phase2_encryption_algorithms")?.Value;
        set => this.WithProperty("tunnel2_phase2_encryption_algorithms", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The tunnel2_phase2_integrity_algorithms attribute.
    /// </summary>
    public HashSet<string>? Tunnel2Phase2IntegrityAlgorithms
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("tunnel2_phase2_integrity_algorithms")?.Value;
        set => this.WithProperty("tunnel2_phase2_integrity_algorithms", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The tunnel2_phase2_lifetime_seconds attribute.
    /// </summary>
    public double? Tunnel2Phase2LifetimeSeconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("tunnel2_phase2_lifetime_seconds")?.Value;
        set => this.WithProperty("tunnel2_phase2_lifetime_seconds", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The tunnel2_preshared_key attribute.
    /// </summary>
    public string? Tunnel2PresharedKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tunnel2_preshared_key")?.Value;
        set => this.WithProperty("tunnel2_preshared_key", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tunnel2_rekey_fuzz_percentage attribute.
    /// </summary>
    public double? Tunnel2RekeyFuzzPercentage
    {
        get => GetProperty<TerraformLiteralProperty<double>>("tunnel2_rekey_fuzz_percentage")?.Value;
        set => this.WithProperty("tunnel2_rekey_fuzz_percentage", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The tunnel2_rekey_margin_time_seconds attribute.
    /// </summary>
    public double? Tunnel2RekeyMarginTimeSeconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("tunnel2_rekey_margin_time_seconds")?.Value;
        set => this.WithProperty("tunnel2_rekey_margin_time_seconds", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The tunnel2_replay_window_size attribute.
    /// </summary>
    public double? Tunnel2ReplayWindowSize
    {
        get => GetProperty<TerraformLiteralProperty<double>>("tunnel2_replay_window_size")?.Value;
        set => this.WithProperty("tunnel2_replay_window_size", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The tunnel2_startup_action attribute.
    /// </summary>
    public string? Tunnel2StartupAction
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tunnel2_startup_action")?.Value;
        set => this.WithProperty("tunnel2_startup_action", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tunnel_inside_ip_version attribute.
    /// </summary>
    public string? TunnelInsideIpVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tunnel_inside_ip_version")?.Value;
        set => this.WithProperty("tunnel_inside_ip_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public string? Type
    {
        get => GetProperty<TerraformLiteralProperty<string>>("type")?.Value;
        set => this.WithProperty("type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The vpn_gateway_id attribute.
    /// </summary>
    public string? VpnGatewayId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vpn_gateway_id")?.Value;
        set => this.WithProperty("vpn_gateway_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
