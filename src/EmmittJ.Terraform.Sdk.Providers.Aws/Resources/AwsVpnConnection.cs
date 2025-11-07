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
    public TerraformLiteralProperty<string>? CustomerGatewayId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("customer_gateway_id");
        set => this.WithProperty("customer_gateway_id", value);
    }

    /// <summary>
    /// The enable_acceleration attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? EnableAcceleration
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_acceleration");
        set => this.WithProperty("enable_acceleration", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The local_ipv4_network_cidr attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? LocalIpv4NetworkCidr
    {
        get => GetProperty<TerraformLiteralProperty<string>>("local_ipv4_network_cidr");
        set => this.WithProperty("local_ipv4_network_cidr", value);
    }

    /// <summary>
    /// The local_ipv6_network_cidr attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? LocalIpv6NetworkCidr
    {
        get => GetProperty<TerraformLiteralProperty<string>>("local_ipv6_network_cidr");
        set => this.WithProperty("local_ipv6_network_cidr", value);
    }

    /// <summary>
    /// The outside_ip_address_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? OutsideIpAddressType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("outside_ip_address_type");
        set => this.WithProperty("outside_ip_address_type", value);
    }

    /// <summary>
    /// The preshared_key_storage attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PresharedKeyStorage
    {
        get => GetProperty<TerraformLiteralProperty<string>>("preshared_key_storage");
        set => this.WithProperty("preshared_key_storage", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The remote_ipv4_network_cidr attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RemoteIpv4NetworkCidr
    {
        get => GetProperty<TerraformLiteralProperty<string>>("remote_ipv4_network_cidr");
        set => this.WithProperty("remote_ipv4_network_cidr", value);
    }

    /// <summary>
    /// The remote_ipv6_network_cidr attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RemoteIpv6NetworkCidr
    {
        get => GetProperty<TerraformLiteralProperty<string>>("remote_ipv6_network_cidr");
        set => this.WithProperty("remote_ipv6_network_cidr", value);
    }

    /// <summary>
    /// The static_routes_only attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? StaticRoutesOnly
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("static_routes_only");
        set => this.WithProperty("static_routes_only", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The transit_gateway_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TransitGatewayId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("transit_gateway_id");
        set => this.WithProperty("transit_gateway_id", value);
    }

    /// <summary>
    /// The transport_transit_gateway_attachment_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TransportTransitGatewayAttachmentId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("transport_transit_gateway_attachment_id");
        set => this.WithProperty("transport_transit_gateway_attachment_id", value);
    }

    /// <summary>
    /// The tunnel1_dpd_timeout_action attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Tunnel1DpdTimeoutAction
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tunnel1_dpd_timeout_action");
        set => this.WithProperty("tunnel1_dpd_timeout_action", value);
    }

    /// <summary>
    /// The tunnel1_dpd_timeout_seconds attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? Tunnel1DpdTimeoutSeconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("tunnel1_dpd_timeout_seconds");
        set => this.WithProperty("tunnel1_dpd_timeout_seconds", value);
    }

    /// <summary>
    /// The tunnel1_enable_tunnel_lifecycle_control attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? Tunnel1EnableTunnelLifecycleControl
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("tunnel1_enable_tunnel_lifecycle_control");
        set => this.WithProperty("tunnel1_enable_tunnel_lifecycle_control", value);
    }

    /// <summary>
    /// The tunnel1_ike_versions attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? Tunnel1IkeVersions
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("tunnel1_ike_versions");
        set => this.WithProperty("tunnel1_ike_versions", value);
    }

    /// <summary>
    /// The tunnel1_inside_cidr attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Tunnel1InsideCidr
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tunnel1_inside_cidr");
        set => this.WithProperty("tunnel1_inside_cidr", value);
    }

    /// <summary>
    /// The tunnel1_inside_ipv6_cidr attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Tunnel1InsideIpv6Cidr
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tunnel1_inside_ipv6_cidr");
        set => this.WithProperty("tunnel1_inside_ipv6_cidr", value);
    }

    /// <summary>
    /// The tunnel1_phase1_dh_group_numbers attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<double>>? Tunnel1Phase1DhGroupNumbers
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<double>>>("tunnel1_phase1_dh_group_numbers");
        set => this.WithProperty("tunnel1_phase1_dh_group_numbers", value);
    }

    /// <summary>
    /// The tunnel1_phase1_encryption_algorithms attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? Tunnel1Phase1EncryptionAlgorithms
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("tunnel1_phase1_encryption_algorithms");
        set => this.WithProperty("tunnel1_phase1_encryption_algorithms", value);
    }

    /// <summary>
    /// The tunnel1_phase1_integrity_algorithms attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? Tunnel1Phase1IntegrityAlgorithms
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("tunnel1_phase1_integrity_algorithms");
        set => this.WithProperty("tunnel1_phase1_integrity_algorithms", value);
    }

    /// <summary>
    /// The tunnel1_phase1_lifetime_seconds attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? Tunnel1Phase1LifetimeSeconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("tunnel1_phase1_lifetime_seconds");
        set => this.WithProperty("tunnel1_phase1_lifetime_seconds", value);
    }

    /// <summary>
    /// The tunnel1_phase2_dh_group_numbers attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<double>>? Tunnel1Phase2DhGroupNumbers
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<double>>>("tunnel1_phase2_dh_group_numbers");
        set => this.WithProperty("tunnel1_phase2_dh_group_numbers", value);
    }

    /// <summary>
    /// The tunnel1_phase2_encryption_algorithms attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? Tunnel1Phase2EncryptionAlgorithms
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("tunnel1_phase2_encryption_algorithms");
        set => this.WithProperty("tunnel1_phase2_encryption_algorithms", value);
    }

    /// <summary>
    /// The tunnel1_phase2_integrity_algorithms attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? Tunnel1Phase2IntegrityAlgorithms
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("tunnel1_phase2_integrity_algorithms");
        set => this.WithProperty("tunnel1_phase2_integrity_algorithms", value);
    }

    /// <summary>
    /// The tunnel1_phase2_lifetime_seconds attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? Tunnel1Phase2LifetimeSeconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("tunnel1_phase2_lifetime_seconds");
        set => this.WithProperty("tunnel1_phase2_lifetime_seconds", value);
    }

    /// <summary>
    /// The tunnel1_preshared_key attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Tunnel1PresharedKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tunnel1_preshared_key");
        set => this.WithProperty("tunnel1_preshared_key", value);
    }

    /// <summary>
    /// The tunnel1_rekey_fuzz_percentage attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? Tunnel1RekeyFuzzPercentage
    {
        get => GetProperty<TerraformLiteralProperty<double>>("tunnel1_rekey_fuzz_percentage");
        set => this.WithProperty("tunnel1_rekey_fuzz_percentage", value);
    }

    /// <summary>
    /// The tunnel1_rekey_margin_time_seconds attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? Tunnel1RekeyMarginTimeSeconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("tunnel1_rekey_margin_time_seconds");
        set => this.WithProperty("tunnel1_rekey_margin_time_seconds", value);
    }

    /// <summary>
    /// The tunnel1_replay_window_size attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? Tunnel1ReplayWindowSize
    {
        get => GetProperty<TerraformLiteralProperty<double>>("tunnel1_replay_window_size");
        set => this.WithProperty("tunnel1_replay_window_size", value);
    }

    /// <summary>
    /// The tunnel1_startup_action attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Tunnel1StartupAction
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tunnel1_startup_action");
        set => this.WithProperty("tunnel1_startup_action", value);
    }

    /// <summary>
    /// The tunnel2_dpd_timeout_action attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Tunnel2DpdTimeoutAction
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tunnel2_dpd_timeout_action");
        set => this.WithProperty("tunnel2_dpd_timeout_action", value);
    }

    /// <summary>
    /// The tunnel2_dpd_timeout_seconds attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? Tunnel2DpdTimeoutSeconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("tunnel2_dpd_timeout_seconds");
        set => this.WithProperty("tunnel2_dpd_timeout_seconds", value);
    }

    /// <summary>
    /// The tunnel2_enable_tunnel_lifecycle_control attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? Tunnel2EnableTunnelLifecycleControl
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("tunnel2_enable_tunnel_lifecycle_control");
        set => this.WithProperty("tunnel2_enable_tunnel_lifecycle_control", value);
    }

    /// <summary>
    /// The tunnel2_ike_versions attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? Tunnel2IkeVersions
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("tunnel2_ike_versions");
        set => this.WithProperty("tunnel2_ike_versions", value);
    }

    /// <summary>
    /// The tunnel2_inside_cidr attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Tunnel2InsideCidr
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tunnel2_inside_cidr");
        set => this.WithProperty("tunnel2_inside_cidr", value);
    }

    /// <summary>
    /// The tunnel2_inside_ipv6_cidr attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Tunnel2InsideIpv6Cidr
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tunnel2_inside_ipv6_cidr");
        set => this.WithProperty("tunnel2_inside_ipv6_cidr", value);
    }

    /// <summary>
    /// The tunnel2_phase1_dh_group_numbers attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<double>>? Tunnel2Phase1DhGroupNumbers
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<double>>>("tunnel2_phase1_dh_group_numbers");
        set => this.WithProperty("tunnel2_phase1_dh_group_numbers", value);
    }

    /// <summary>
    /// The tunnel2_phase1_encryption_algorithms attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? Tunnel2Phase1EncryptionAlgorithms
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("tunnel2_phase1_encryption_algorithms");
        set => this.WithProperty("tunnel2_phase1_encryption_algorithms", value);
    }

    /// <summary>
    /// The tunnel2_phase1_integrity_algorithms attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? Tunnel2Phase1IntegrityAlgorithms
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("tunnel2_phase1_integrity_algorithms");
        set => this.WithProperty("tunnel2_phase1_integrity_algorithms", value);
    }

    /// <summary>
    /// The tunnel2_phase1_lifetime_seconds attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? Tunnel2Phase1LifetimeSeconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("tunnel2_phase1_lifetime_seconds");
        set => this.WithProperty("tunnel2_phase1_lifetime_seconds", value);
    }

    /// <summary>
    /// The tunnel2_phase2_dh_group_numbers attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<double>>? Tunnel2Phase2DhGroupNumbers
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<double>>>("tunnel2_phase2_dh_group_numbers");
        set => this.WithProperty("tunnel2_phase2_dh_group_numbers", value);
    }

    /// <summary>
    /// The tunnel2_phase2_encryption_algorithms attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? Tunnel2Phase2EncryptionAlgorithms
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("tunnel2_phase2_encryption_algorithms");
        set => this.WithProperty("tunnel2_phase2_encryption_algorithms", value);
    }

    /// <summary>
    /// The tunnel2_phase2_integrity_algorithms attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? Tunnel2Phase2IntegrityAlgorithms
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("tunnel2_phase2_integrity_algorithms");
        set => this.WithProperty("tunnel2_phase2_integrity_algorithms", value);
    }

    /// <summary>
    /// The tunnel2_phase2_lifetime_seconds attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? Tunnel2Phase2LifetimeSeconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("tunnel2_phase2_lifetime_seconds");
        set => this.WithProperty("tunnel2_phase2_lifetime_seconds", value);
    }

    /// <summary>
    /// The tunnel2_preshared_key attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Tunnel2PresharedKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tunnel2_preshared_key");
        set => this.WithProperty("tunnel2_preshared_key", value);
    }

    /// <summary>
    /// The tunnel2_rekey_fuzz_percentage attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? Tunnel2RekeyFuzzPercentage
    {
        get => GetProperty<TerraformLiteralProperty<double>>("tunnel2_rekey_fuzz_percentage");
        set => this.WithProperty("tunnel2_rekey_fuzz_percentage", value);
    }

    /// <summary>
    /// The tunnel2_rekey_margin_time_seconds attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? Tunnel2RekeyMarginTimeSeconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("tunnel2_rekey_margin_time_seconds");
        set => this.WithProperty("tunnel2_rekey_margin_time_seconds", value);
    }

    /// <summary>
    /// The tunnel2_replay_window_size attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? Tunnel2ReplayWindowSize
    {
        get => GetProperty<TerraformLiteralProperty<double>>("tunnel2_replay_window_size");
        set => this.WithProperty("tunnel2_replay_window_size", value);
    }

    /// <summary>
    /// The tunnel2_startup_action attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Tunnel2StartupAction
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tunnel2_startup_action");
        set => this.WithProperty("tunnel2_startup_action", value);
    }

    /// <summary>
    /// The tunnel_inside_ip_version attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TunnelInsideIpVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tunnel_inside_ip_version");
        set => this.WithProperty("tunnel_inside_ip_version", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Type
    {
        get => GetProperty<TerraformLiteralProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// The vpn_gateway_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? VpnGatewayId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vpn_gateway_id");
        set => this.WithProperty("vpn_gateway_id", value);
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
