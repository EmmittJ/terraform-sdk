using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for tunnel1_log_options in AwsVpnConnection.
/// Nesting mode: list
/// </summary>
public class AwsVpnConnectionTunnel1LogOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tunnel1_log_options";

    /// <summary>
    /// CloudwatchLogOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudwatchLogOptions block(s) allowed")]
    public TerraformList<AwsVpnConnectionTunnel1LogOptionsBlockCloudwatchLogOptionsBlock>? CloudwatchLogOptions
    {
        get => GetArgument<TerraformList<AwsVpnConnectionTunnel1LogOptionsBlockCloudwatchLogOptionsBlock>>("cloudwatch_log_options");
        set => SetArgument("cloudwatch_log_options", value);
    }

}

/// <summary>
/// Block type for cloudwatch_log_options in AwsVpnConnectionTunnel1LogOptionsBlock.
/// Nesting mode: list
/// </summary>
public class AwsVpnConnectionTunnel1LogOptionsBlockCloudwatchLogOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloudwatch_log_options";

    /// <summary>
    /// The log_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? LogEnabled
    {
        get => new TerraformReference<bool>(this, "log_enabled");
        set => SetArgument("log_enabled", value);
    }

    /// <summary>
    /// The log_group_arn attribute.
    /// </summary>
    public TerraformValue<string>? LogGroupArn
    {
        get => new TerraformReference<string>(this, "log_group_arn");
        set => SetArgument("log_group_arn", value);
    }

    /// <summary>
    /// The log_output_format attribute.
    /// </summary>
    public TerraformValue<string>? LogOutputFormat
    {
        get => new TerraformReference<string>(this, "log_output_format");
        set => SetArgument("log_output_format", value);
    }

}


/// <summary>
/// Block type for tunnel2_log_options in AwsVpnConnection.
/// Nesting mode: list
/// </summary>
public class AwsVpnConnectionTunnel2LogOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tunnel2_log_options";

    /// <summary>
    /// CloudwatchLogOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudwatchLogOptions block(s) allowed")]
    public TerraformList<AwsVpnConnectionTunnel2LogOptionsBlockCloudwatchLogOptionsBlock>? CloudwatchLogOptions
    {
        get => GetArgument<TerraformList<AwsVpnConnectionTunnel2LogOptionsBlockCloudwatchLogOptionsBlock>>("cloudwatch_log_options");
        set => SetArgument("cloudwatch_log_options", value);
    }

}

/// <summary>
/// Block type for cloudwatch_log_options in AwsVpnConnectionTunnel2LogOptionsBlock.
/// Nesting mode: list
/// </summary>
public class AwsVpnConnectionTunnel2LogOptionsBlockCloudwatchLogOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloudwatch_log_options";

    /// <summary>
    /// The log_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? LogEnabled
    {
        get => new TerraformReference<bool>(this, "log_enabled");
        set => SetArgument("log_enabled", value);
    }

    /// <summary>
    /// The log_group_arn attribute.
    /// </summary>
    public TerraformValue<string>? LogGroupArn
    {
        get => new TerraformReference<string>(this, "log_group_arn");
        set => SetArgument("log_group_arn", value);
    }

    /// <summary>
    /// The log_output_format attribute.
    /// </summary>
    public TerraformValue<string>? LogOutputFormat
    {
        get => new TerraformReference<string>(this, "log_output_format");
        set => SetArgument("log_output_format", value);
    }

}


/// <summary>
/// Represents a aws_vpn_connection Terraform resource.
/// Manages a aws_vpn_connection resource.
/// </summary>
public partial class AwsVpnConnection(string name) : TerraformResource("aws_vpn_connection", name)
{
    /// <summary>
    /// The customer_gateway_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomerGatewayId is required")]
    public required TerraformValue<string> CustomerGatewayId
    {
        get => new TerraformReference<string>(this, "customer_gateway_id");
        set => SetArgument("customer_gateway_id", value);
    }

    /// <summary>
    /// The enable_acceleration attribute.
    /// </summary>
    public TerraformValue<bool> EnableAcceleration
    {
        get => new TerraformReference<bool>(this, "enable_acceleration");
        set => SetArgument("enable_acceleration", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The local_ipv4_network_cidr attribute.
    /// </summary>
    public TerraformValue<string> LocalIpv4NetworkCidr
    {
        get => new TerraformReference<string>(this, "local_ipv4_network_cidr");
        set => SetArgument("local_ipv4_network_cidr", value);
    }

    /// <summary>
    /// The local_ipv6_network_cidr attribute.
    /// </summary>
    public TerraformValue<string> LocalIpv6NetworkCidr
    {
        get => new TerraformReference<string>(this, "local_ipv6_network_cidr");
        set => SetArgument("local_ipv6_network_cidr", value);
    }

    /// <summary>
    /// The outside_ip_address_type attribute.
    /// </summary>
    public TerraformValue<string> OutsideIpAddressType
    {
        get => new TerraformReference<string>(this, "outside_ip_address_type");
        set => SetArgument("outside_ip_address_type", value);
    }

    /// <summary>
    /// The preshared_key_storage attribute.
    /// </summary>
    public TerraformValue<string> PresharedKeyStorage
    {
        get => new TerraformReference<string>(this, "preshared_key_storage");
        set => SetArgument("preshared_key_storage", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The remote_ipv4_network_cidr attribute.
    /// </summary>
    public TerraformValue<string> RemoteIpv4NetworkCidr
    {
        get => new TerraformReference<string>(this, "remote_ipv4_network_cidr");
        set => SetArgument("remote_ipv4_network_cidr", value);
    }

    /// <summary>
    /// The remote_ipv6_network_cidr attribute.
    /// </summary>
    public TerraformValue<string> RemoteIpv6NetworkCidr
    {
        get => new TerraformReference<string>(this, "remote_ipv6_network_cidr");
        set => SetArgument("remote_ipv6_network_cidr", value);
    }

    /// <summary>
    /// The static_routes_only attribute.
    /// </summary>
    public TerraformValue<bool> StaticRoutesOnly
    {
        get => new TerraformReference<bool>(this, "static_routes_only");
        set => SetArgument("static_routes_only", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The transit_gateway_id attribute.
    /// </summary>
    public TerraformValue<string>? TransitGatewayId
    {
        get => new TerraformReference<string>(this, "transit_gateway_id");
        set => SetArgument("transit_gateway_id", value);
    }

    /// <summary>
    /// The transport_transit_gateway_attachment_id attribute.
    /// </summary>
    public TerraformValue<string>? TransportTransitGatewayAttachmentId
    {
        get => new TerraformReference<string>(this, "transport_transit_gateway_attachment_id");
        set => SetArgument("transport_transit_gateway_attachment_id", value);
    }

    /// <summary>
    /// The tunnel1_dpd_timeout_action attribute.
    /// </summary>
    public TerraformValue<string>? Tunnel1DpdTimeoutAction
    {
        get => new TerraformReference<string>(this, "tunnel1_dpd_timeout_action");
        set => SetArgument("tunnel1_dpd_timeout_action", value);
    }

    /// <summary>
    /// The tunnel1_dpd_timeout_seconds attribute.
    /// </summary>
    public TerraformValue<double>? Tunnel1DpdTimeoutSeconds
    {
        get => new TerraformReference<double>(this, "tunnel1_dpd_timeout_seconds");
        set => SetArgument("tunnel1_dpd_timeout_seconds", value);
    }

    /// <summary>
    /// The tunnel1_enable_tunnel_lifecycle_control attribute.
    /// </summary>
    public TerraformValue<bool>? Tunnel1EnableTunnelLifecycleControl
    {
        get => new TerraformReference<bool>(this, "tunnel1_enable_tunnel_lifecycle_control");
        set => SetArgument("tunnel1_enable_tunnel_lifecycle_control", value);
    }

    /// <summary>
    /// The tunnel1_ike_versions attribute.
    /// </summary>
    public TerraformSet<string>? Tunnel1IkeVersions
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "tunnel1_ike_versions").ResolveNodes(ctx));
        set => SetArgument("tunnel1_ike_versions", value);
    }

    /// <summary>
    /// The tunnel1_inside_cidr attribute.
    /// </summary>
    public TerraformValue<string> Tunnel1InsideCidr
    {
        get => new TerraformReference<string>(this, "tunnel1_inside_cidr");
        set => SetArgument("tunnel1_inside_cidr", value);
    }

    /// <summary>
    /// The tunnel1_inside_ipv6_cidr attribute.
    /// </summary>
    public TerraformValue<string> Tunnel1InsideIpv6Cidr
    {
        get => new TerraformReference<string>(this, "tunnel1_inside_ipv6_cidr");
        set => SetArgument("tunnel1_inside_ipv6_cidr", value);
    }

    /// <summary>
    /// The tunnel1_phase1_dh_group_numbers attribute.
    /// </summary>
    public TerraformSet<double>? Tunnel1Phase1DhGroupNumbers
    {
        get => TerraformSet<double>.Lazy(ctx => new TerraformReference<TerraformSet<double>>(this, "tunnel1_phase1_dh_group_numbers").ResolveNodes(ctx));
        set => SetArgument("tunnel1_phase1_dh_group_numbers", value);
    }

    /// <summary>
    /// The tunnel1_phase1_encryption_algorithms attribute.
    /// </summary>
    public TerraformSet<string>? Tunnel1Phase1EncryptionAlgorithms
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "tunnel1_phase1_encryption_algorithms").ResolveNodes(ctx));
        set => SetArgument("tunnel1_phase1_encryption_algorithms", value);
    }

    /// <summary>
    /// The tunnel1_phase1_integrity_algorithms attribute.
    /// </summary>
    public TerraformSet<string>? Tunnel1Phase1IntegrityAlgorithms
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "tunnel1_phase1_integrity_algorithms").ResolveNodes(ctx));
        set => SetArgument("tunnel1_phase1_integrity_algorithms", value);
    }

    /// <summary>
    /// The tunnel1_phase1_lifetime_seconds attribute.
    /// </summary>
    public TerraformValue<double>? Tunnel1Phase1LifetimeSeconds
    {
        get => new TerraformReference<double>(this, "tunnel1_phase1_lifetime_seconds");
        set => SetArgument("tunnel1_phase1_lifetime_seconds", value);
    }

    /// <summary>
    /// The tunnel1_phase2_dh_group_numbers attribute.
    /// </summary>
    public TerraformSet<double>? Tunnel1Phase2DhGroupNumbers
    {
        get => TerraformSet<double>.Lazy(ctx => new TerraformReference<TerraformSet<double>>(this, "tunnel1_phase2_dh_group_numbers").ResolveNodes(ctx));
        set => SetArgument("tunnel1_phase2_dh_group_numbers", value);
    }

    /// <summary>
    /// The tunnel1_phase2_encryption_algorithms attribute.
    /// </summary>
    public TerraformSet<string>? Tunnel1Phase2EncryptionAlgorithms
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "tunnel1_phase2_encryption_algorithms").ResolveNodes(ctx));
        set => SetArgument("tunnel1_phase2_encryption_algorithms", value);
    }

    /// <summary>
    /// The tunnel1_phase2_integrity_algorithms attribute.
    /// </summary>
    public TerraformSet<string>? Tunnel1Phase2IntegrityAlgorithms
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "tunnel1_phase2_integrity_algorithms").ResolveNodes(ctx));
        set => SetArgument("tunnel1_phase2_integrity_algorithms", value);
    }

    /// <summary>
    /// The tunnel1_phase2_lifetime_seconds attribute.
    /// </summary>
    public TerraformValue<double>? Tunnel1Phase2LifetimeSeconds
    {
        get => new TerraformReference<double>(this, "tunnel1_phase2_lifetime_seconds");
        set => SetArgument("tunnel1_phase2_lifetime_seconds", value);
    }

    /// <summary>
    /// The tunnel1_preshared_key attribute.
    /// </summary>
    public TerraformValue<string> Tunnel1PresharedKey
    {
        get => new TerraformReference<string>(this, "tunnel1_preshared_key");
        set => SetArgument("tunnel1_preshared_key", value);
    }

    /// <summary>
    /// The tunnel1_rekey_fuzz_percentage attribute.
    /// </summary>
    public TerraformValue<double>? Tunnel1RekeyFuzzPercentage
    {
        get => new TerraformReference<double>(this, "tunnel1_rekey_fuzz_percentage");
        set => SetArgument("tunnel1_rekey_fuzz_percentage", value);
    }

    /// <summary>
    /// The tunnel1_rekey_margin_time_seconds attribute.
    /// </summary>
    public TerraformValue<double>? Tunnel1RekeyMarginTimeSeconds
    {
        get => new TerraformReference<double>(this, "tunnel1_rekey_margin_time_seconds");
        set => SetArgument("tunnel1_rekey_margin_time_seconds", value);
    }

    /// <summary>
    /// The tunnel1_replay_window_size attribute.
    /// </summary>
    public TerraformValue<double>? Tunnel1ReplayWindowSize
    {
        get => new TerraformReference<double>(this, "tunnel1_replay_window_size");
        set => SetArgument("tunnel1_replay_window_size", value);
    }

    /// <summary>
    /// The tunnel1_startup_action attribute.
    /// </summary>
    public TerraformValue<string>? Tunnel1StartupAction
    {
        get => new TerraformReference<string>(this, "tunnel1_startup_action");
        set => SetArgument("tunnel1_startup_action", value);
    }

    /// <summary>
    /// The tunnel2_dpd_timeout_action attribute.
    /// </summary>
    public TerraformValue<string>? Tunnel2DpdTimeoutAction
    {
        get => new TerraformReference<string>(this, "tunnel2_dpd_timeout_action");
        set => SetArgument("tunnel2_dpd_timeout_action", value);
    }

    /// <summary>
    /// The tunnel2_dpd_timeout_seconds attribute.
    /// </summary>
    public TerraformValue<double>? Tunnel2DpdTimeoutSeconds
    {
        get => new TerraformReference<double>(this, "tunnel2_dpd_timeout_seconds");
        set => SetArgument("tunnel2_dpd_timeout_seconds", value);
    }

    /// <summary>
    /// The tunnel2_enable_tunnel_lifecycle_control attribute.
    /// </summary>
    public TerraformValue<bool>? Tunnel2EnableTunnelLifecycleControl
    {
        get => new TerraformReference<bool>(this, "tunnel2_enable_tunnel_lifecycle_control");
        set => SetArgument("tunnel2_enable_tunnel_lifecycle_control", value);
    }

    /// <summary>
    /// The tunnel2_ike_versions attribute.
    /// </summary>
    public TerraformSet<string>? Tunnel2IkeVersions
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "tunnel2_ike_versions").ResolveNodes(ctx));
        set => SetArgument("tunnel2_ike_versions", value);
    }

    /// <summary>
    /// The tunnel2_inside_cidr attribute.
    /// </summary>
    public TerraformValue<string> Tunnel2InsideCidr
    {
        get => new TerraformReference<string>(this, "tunnel2_inside_cidr");
        set => SetArgument("tunnel2_inside_cidr", value);
    }

    /// <summary>
    /// The tunnel2_inside_ipv6_cidr attribute.
    /// </summary>
    public TerraformValue<string> Tunnel2InsideIpv6Cidr
    {
        get => new TerraformReference<string>(this, "tunnel2_inside_ipv6_cidr");
        set => SetArgument("tunnel2_inside_ipv6_cidr", value);
    }

    /// <summary>
    /// The tunnel2_phase1_dh_group_numbers attribute.
    /// </summary>
    public TerraformSet<double>? Tunnel2Phase1DhGroupNumbers
    {
        get => TerraformSet<double>.Lazy(ctx => new TerraformReference<TerraformSet<double>>(this, "tunnel2_phase1_dh_group_numbers").ResolveNodes(ctx));
        set => SetArgument("tunnel2_phase1_dh_group_numbers", value);
    }

    /// <summary>
    /// The tunnel2_phase1_encryption_algorithms attribute.
    /// </summary>
    public TerraformSet<string>? Tunnel2Phase1EncryptionAlgorithms
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "tunnel2_phase1_encryption_algorithms").ResolveNodes(ctx));
        set => SetArgument("tunnel2_phase1_encryption_algorithms", value);
    }

    /// <summary>
    /// The tunnel2_phase1_integrity_algorithms attribute.
    /// </summary>
    public TerraformSet<string>? Tunnel2Phase1IntegrityAlgorithms
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "tunnel2_phase1_integrity_algorithms").ResolveNodes(ctx));
        set => SetArgument("tunnel2_phase1_integrity_algorithms", value);
    }

    /// <summary>
    /// The tunnel2_phase1_lifetime_seconds attribute.
    /// </summary>
    public TerraformValue<double>? Tunnel2Phase1LifetimeSeconds
    {
        get => new TerraformReference<double>(this, "tunnel2_phase1_lifetime_seconds");
        set => SetArgument("tunnel2_phase1_lifetime_seconds", value);
    }

    /// <summary>
    /// The tunnel2_phase2_dh_group_numbers attribute.
    /// </summary>
    public TerraformSet<double>? Tunnel2Phase2DhGroupNumbers
    {
        get => TerraformSet<double>.Lazy(ctx => new TerraformReference<TerraformSet<double>>(this, "tunnel2_phase2_dh_group_numbers").ResolveNodes(ctx));
        set => SetArgument("tunnel2_phase2_dh_group_numbers", value);
    }

    /// <summary>
    /// The tunnel2_phase2_encryption_algorithms attribute.
    /// </summary>
    public TerraformSet<string>? Tunnel2Phase2EncryptionAlgorithms
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "tunnel2_phase2_encryption_algorithms").ResolveNodes(ctx));
        set => SetArgument("tunnel2_phase2_encryption_algorithms", value);
    }

    /// <summary>
    /// The tunnel2_phase2_integrity_algorithms attribute.
    /// </summary>
    public TerraformSet<string>? Tunnel2Phase2IntegrityAlgorithms
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "tunnel2_phase2_integrity_algorithms").ResolveNodes(ctx));
        set => SetArgument("tunnel2_phase2_integrity_algorithms", value);
    }

    /// <summary>
    /// The tunnel2_phase2_lifetime_seconds attribute.
    /// </summary>
    public TerraformValue<double>? Tunnel2Phase2LifetimeSeconds
    {
        get => new TerraformReference<double>(this, "tunnel2_phase2_lifetime_seconds");
        set => SetArgument("tunnel2_phase2_lifetime_seconds", value);
    }

    /// <summary>
    /// The tunnel2_preshared_key attribute.
    /// </summary>
    public TerraformValue<string> Tunnel2PresharedKey
    {
        get => new TerraformReference<string>(this, "tunnel2_preshared_key");
        set => SetArgument("tunnel2_preshared_key", value);
    }

    /// <summary>
    /// The tunnel2_rekey_fuzz_percentage attribute.
    /// </summary>
    public TerraformValue<double>? Tunnel2RekeyFuzzPercentage
    {
        get => new TerraformReference<double>(this, "tunnel2_rekey_fuzz_percentage");
        set => SetArgument("tunnel2_rekey_fuzz_percentage", value);
    }

    /// <summary>
    /// The tunnel2_rekey_margin_time_seconds attribute.
    /// </summary>
    public TerraformValue<double>? Tunnel2RekeyMarginTimeSeconds
    {
        get => new TerraformReference<double>(this, "tunnel2_rekey_margin_time_seconds");
        set => SetArgument("tunnel2_rekey_margin_time_seconds", value);
    }

    /// <summary>
    /// The tunnel2_replay_window_size attribute.
    /// </summary>
    public TerraformValue<double>? Tunnel2ReplayWindowSize
    {
        get => new TerraformReference<double>(this, "tunnel2_replay_window_size");
        set => SetArgument("tunnel2_replay_window_size", value);
    }

    /// <summary>
    /// The tunnel2_startup_action attribute.
    /// </summary>
    public TerraformValue<string>? Tunnel2StartupAction
    {
        get => new TerraformReference<string>(this, "tunnel2_startup_action");
        set => SetArgument("tunnel2_startup_action", value);
    }

    /// <summary>
    /// The tunnel_inside_ip_version attribute.
    /// </summary>
    public TerraformValue<string> TunnelInsideIpVersion
    {
        get => new TerraformReference<string>(this, "tunnel_inside_ip_version");
        set => SetArgument("tunnel_inside_ip_version", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The vpn_gateway_id attribute.
    /// </summary>
    public TerraformValue<string>? VpnGatewayId
    {
        get => new TerraformReference<string>(this, "vpn_gateway_id");
        set => SetArgument("vpn_gateway_id", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The core_network_arn attribute.
    /// </summary>
    public TerraformValue<string> CoreNetworkArn
    {
        get => new TerraformReference<string>(this, "core_network_arn");
    }

    /// <summary>
    /// The core_network_attachment_arn attribute.
    /// </summary>
    public TerraformValue<string> CoreNetworkAttachmentArn
    {
        get => new TerraformReference<string>(this, "core_network_attachment_arn");
    }

    /// <summary>
    /// The customer_gateway_configuration attribute.
    /// </summary>
    public TerraformValue<string> CustomerGatewayConfiguration
    {
        get => new TerraformReference<string>(this, "customer_gateway_configuration");
    }

    /// <summary>
    /// The preshared_key_arn attribute.
    /// </summary>
    public TerraformValue<string> PresharedKeyArn
    {
        get => new TerraformReference<string>(this, "preshared_key_arn");
    }

    /// <summary>
    /// The routes attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> Routes
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "routes").ResolveNodes(ctx));
    }

    /// <summary>
    /// The transit_gateway_attachment_id attribute.
    /// </summary>
    public TerraformValue<string> TransitGatewayAttachmentId
    {
        get => new TerraformReference<string>(this, "transit_gateway_attachment_id");
    }

    /// <summary>
    /// The tunnel1_address attribute.
    /// </summary>
    public TerraformValue<string> Tunnel1Address
    {
        get => new TerraformReference<string>(this, "tunnel1_address");
    }

    /// <summary>
    /// The tunnel1_bgp_asn attribute.
    /// </summary>
    public TerraformValue<string> Tunnel1BgpAsn
    {
        get => new TerraformReference<string>(this, "tunnel1_bgp_asn");
    }

    /// <summary>
    /// The tunnel1_bgp_holdtime attribute.
    /// </summary>
    public TerraformValue<double> Tunnel1BgpHoldtime
    {
        get => new TerraformReference<double>(this, "tunnel1_bgp_holdtime");
    }

    /// <summary>
    /// The tunnel1_cgw_inside_address attribute.
    /// </summary>
    public TerraformValue<string> Tunnel1CgwInsideAddress
    {
        get => new TerraformReference<string>(this, "tunnel1_cgw_inside_address");
    }

    /// <summary>
    /// The tunnel1_vgw_inside_address attribute.
    /// </summary>
    public TerraformValue<string> Tunnel1VgwInsideAddress
    {
        get => new TerraformReference<string>(this, "tunnel1_vgw_inside_address");
    }

    /// <summary>
    /// The tunnel2_address attribute.
    /// </summary>
    public TerraformValue<string> Tunnel2Address
    {
        get => new TerraformReference<string>(this, "tunnel2_address");
    }

    /// <summary>
    /// The tunnel2_bgp_asn attribute.
    /// </summary>
    public TerraformValue<string> Tunnel2BgpAsn
    {
        get => new TerraformReference<string>(this, "tunnel2_bgp_asn");
    }

    /// <summary>
    /// The tunnel2_bgp_holdtime attribute.
    /// </summary>
    public TerraformValue<double> Tunnel2BgpHoldtime
    {
        get => new TerraformReference<double>(this, "tunnel2_bgp_holdtime");
    }

    /// <summary>
    /// The tunnel2_cgw_inside_address attribute.
    /// </summary>
    public TerraformValue<string> Tunnel2CgwInsideAddress
    {
        get => new TerraformReference<string>(this, "tunnel2_cgw_inside_address");
    }

    /// <summary>
    /// The tunnel2_vgw_inside_address attribute.
    /// </summary>
    public TerraformValue<string> Tunnel2VgwInsideAddress
    {
        get => new TerraformReference<string>(this, "tunnel2_vgw_inside_address");
    }

    /// <summary>
    /// The vgw_telemetry attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> VgwTelemetry
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "vgw_telemetry").ResolveNodes(ctx));
    }

    /// <summary>
    /// Tunnel1LogOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Tunnel1LogOptions block(s) allowed")]
    public TerraformList<AwsVpnConnectionTunnel1LogOptionsBlock>? Tunnel1LogOptions
    {
        get => GetArgument<TerraformList<AwsVpnConnectionTunnel1LogOptionsBlock>>("tunnel1_log_options");
        set => SetArgument("tunnel1_log_options", value);
    }

    /// <summary>
    /// Tunnel2LogOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Tunnel2LogOptions block(s) allowed")]
    public TerraformList<AwsVpnConnectionTunnel2LogOptionsBlock>? Tunnel2LogOptions
    {
        get => GetArgument<TerraformList<AwsVpnConnectionTunnel2LogOptionsBlock>>("tunnel2_log_options");
        set => SetArgument("tunnel2_log_options", value);
    }

}
