using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for cipher_suite in GoogleComputeVpnTunnel.
/// Nesting mode: list
/// </summary>
public class GoogleComputeVpnTunnelCipherSuiteBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cipher_suite";

    /// <summary>
    /// Phase1 block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Phase1 block(s) allowed")]
    public TerraformList<GoogleComputeVpnTunnelCipherSuiteBlockPhase1Block>? Phase1
    {
        get => GetArgument<TerraformList<GoogleComputeVpnTunnelCipherSuiteBlockPhase1Block>>("phase1");
        set => SetArgument("phase1", value);
    }

    /// <summary>
    /// Phase2 block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Phase2 block(s) allowed")]
    public TerraformList<GoogleComputeVpnTunnelCipherSuiteBlockPhase2Block>? Phase2
    {
        get => GetArgument<TerraformList<GoogleComputeVpnTunnelCipherSuiteBlockPhase2Block>>("phase2");
        set => SetArgument("phase2", value);
    }

}

/// <summary>
/// Block type for phase1 in GoogleComputeVpnTunnelCipherSuiteBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeVpnTunnelCipherSuiteBlockPhase1Block : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "phase1";

    /// <summary>
    /// Diffie-Hellman groups.
    /// </summary>
    public TerraformSet<string>? Dh
    {
        get => GetArgument<TerraformSet<string>>("dh");
        set => SetArgument("dh", value);
    }

    /// <summary>
    /// Encryption algorithms.
    /// </summary>
    public TerraformSet<string>? Encryption
    {
        get => GetArgument<TerraformSet<string>>("encryption");
        set => SetArgument("encryption", value);
    }

    /// <summary>
    /// Integrity algorithms.
    /// </summary>
    public TerraformSet<string>? Integrity
    {
        get => GetArgument<TerraformSet<string>>("integrity");
        set => SetArgument("integrity", value);
    }

    /// <summary>
    /// Pseudo-random functions.
    /// </summary>
    public TerraformSet<string>? Prf
    {
        get => GetArgument<TerraformSet<string>>("prf");
        set => SetArgument("prf", value);
    }

}

/// <summary>
/// Block type for phase2 in GoogleComputeVpnTunnelCipherSuiteBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeVpnTunnelCipherSuiteBlockPhase2Block : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "phase2";

    /// <summary>
    /// Encryption algorithms.
    /// </summary>
    public TerraformSet<string>? Encryption
    {
        get => GetArgument<TerraformSet<string>>("encryption");
        set => SetArgument("encryption", value);
    }

    /// <summary>
    /// Integrity algorithms.
    /// </summary>
    public TerraformSet<string>? Integrity
    {
        get => GetArgument<TerraformSet<string>>("integrity");
        set => SetArgument("integrity", value);
    }

    /// <summary>
    /// Perfect forward secrecy groups.
    /// </summary>
    public TerraformSet<string>? Pfs
    {
        get => GetArgument<TerraformSet<string>>("pfs");
        set => SetArgument("pfs", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleComputeVpnTunnel.
/// Nesting mode: single
/// </summary>
public class GoogleComputeVpnTunnelTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_compute_vpn_tunnel Terraform resource.
/// Manages a google_compute_vpn_tunnel resource.
/// </summary>
public partial class GoogleComputeVpnTunnel(string name) : TerraformResource("google_compute_vpn_tunnel", name)
{
    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// IKE protocol version to use when establishing the VPN tunnel with
    /// peer VPN gateway.
    /// Acceptable IKE versions are 1 or 2. Default version is 2.
    /// </summary>
    public TerraformValue<double>? IkeVersion
    {
        get => GetArgument<TerraformValue<double>>("ike_version");
        set => SetArgument("ike_version", value);
    }

    /// <summary>
    /// Labels to apply to this VpnTunnel.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// Local traffic selector to use when establishing the VPN tunnel with
    /// peer VPN gateway. The value should be a CIDR formatted string,
    /// for example &#39;192.168.0.0/16&#39;. The ranges should be disjoint.
    /// Only IPv4 is supported.
    /// </summary>
    public TerraformSet<string> LocalTrafficSelector
    {
        get => GetArgument<TerraformSet<string>>("local_traffic_selector") ?? CreateReference("local_traffic_selector");
        set => SetArgument("local_traffic_selector", value);
    }

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
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// URL of the peer side external VPN gateway to which this VPN tunnel is connected.
    /// </summary>
    public TerraformValue<string>? PeerExternalGateway
    {
        get => GetArgument<TerraformValue<string>>("peer_external_gateway");
        set => SetArgument("peer_external_gateway", value);
    }

    /// <summary>
    /// The interface ID of the external VPN gateway to which this VPN tunnel is connected.
    /// </summary>
    public TerraformValue<double>? PeerExternalGatewayInterface
    {
        get => GetArgument<TerraformValue<double>>("peer_external_gateway_interface");
        set => SetArgument("peer_external_gateway_interface", value);
    }

    /// <summary>
    /// URL of the peer side HA GCP VPN gateway to which this VPN tunnel is connected.
    /// If provided, the VPN tunnel will automatically use the same vpn_gateway_interface
    /// ID in the peer GCP VPN gateway.
    /// This field must reference a &#39;google_compute_ha_vpn_gateway&#39; resource.
    /// </summary>
    public TerraformValue<string>? PeerGcpGateway
    {
        get => GetArgument<TerraformValue<string>>("peer_gcp_gateway");
        set => SetArgument("peer_gcp_gateway", value);
    }

    /// <summary>
    /// IP address of the peer VPN gateway. Only IPv4 is supported.
    /// </summary>
    public TerraformValue<string> PeerIp
    {
        get => GetArgument<TerraformValue<string>>("peer_ip") ?? CreateReference("peer_ip");
        set => SetArgument("peer_ip", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? CreateReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The region where the tunnel is located. If unset, is set to the region of &#39;target_vpn_gateway&#39;.
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// Remote traffic selector to use when establishing the VPN tunnel with
    /// peer VPN gateway. The value should be a CIDR formatted string,
    /// for example &#39;192.168.0.0/16&#39;. The ranges should be disjoint.
    /// Only IPv4 is supported.
    /// </summary>
    public TerraformSet<string> RemoteTrafficSelector
    {
        get => GetArgument<TerraformSet<string>>("remote_traffic_selector") ?? CreateReference("remote_traffic_selector");
        set => SetArgument("remote_traffic_selector", value);
    }

    /// <summary>
    /// URL of router resource to be used for dynamic routing.
    /// </summary>
    public TerraformValue<string>? Router
    {
        get => GetArgument<TerraformValue<string>>("router");
        set => SetArgument("router", value);
    }

    /// <summary>
    /// Shared secret used to set the secure session between the Cloud VPN
    /// gateway and the peer VPN gateway.
    /// </summary>
    public TerraformValue<string>? SharedSecret
    {
        get => GetArgument<TerraformValue<string>>("shared_secret");
        set => SetArgument("shared_secret", value);
    }

    /// <summary>
    /// Shared secret used to set the secure session between the Cloud VPN
    /// gateway and the peer VPN gateway.
    ///  Note: This property is write-only and will not be read from the API. For more info see [updating write-only attributes](/docs/providers/google/guides/using_write_only_attributes.html#updating-write-only-attributes)
    /// </summary>
    public TerraformValue<string>? SharedSecretWo
    {
        get => GetArgument<TerraformValue<string>>("shared_secret_wo");
        set => SetArgument("shared_secret_wo", value);
    }

    /// <summary>
    /// Triggers update of shared_secret_wo write-only. For more info see [updating write-only attributes](/docs/providers/google/guides/using_write_only_attributes.html#updating-write-only-attributes)
    /// </summary>
    public TerraformValue<string>? SharedSecretWoVersion
    {
        get => GetArgument<TerraformValue<string>>("shared_secret_wo_version");
        set => SetArgument("shared_secret_wo_version", value);
    }

    /// <summary>
    /// URL of the Target VPN gateway with which this VPN tunnel is
    /// associated.
    /// </summary>
    public TerraformValue<string>? TargetVpnGateway
    {
        get => GetArgument<TerraformValue<string>>("target_vpn_gateway");
        set => SetArgument("target_vpn_gateway", value);
    }

    /// <summary>
    /// URL of the VPN gateway with which this VPN tunnel is associated.
    /// This must be used if a High Availability VPN gateway resource is created.
    /// This field must reference a &#39;google_compute_ha_vpn_gateway&#39; resource.
    /// </summary>
    public TerraformValue<string>? VpnGateway
    {
        get => GetArgument<TerraformValue<string>>("vpn_gateway");
        set => SetArgument("vpn_gateway", value);
    }

    /// <summary>
    /// The interface ID of the VPN gateway with which this VPN tunnel is associated.
    /// </summary>
    public TerraformValue<double>? VpnGatewayInterface
    {
        get => GetArgument<TerraformValue<double>>("vpn_gateway_interface");
        set => SetArgument("vpn_gateway_interface", value);
    }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformValue<string> CreationTimestamp
        => CreateReference("creation_timestamp");

    /// <summary>
    /// Detailed status message for the VPN tunnel.
    /// </summary>
    public TerraformValue<string> DetailedStatus
        => CreateReference("detailed_status");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => CreateReference("effective_labels");

    /// <summary>
    /// The fingerprint used for optimistic locking of this resource.  Used
    /// internally during updates.
    /// </summary>
    public TerraformValue<string> LabelFingerprint
        => CreateReference("label_fingerprint");

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformValue<string> SelfLink
        => CreateReference("self_link");

    /// <summary>
    /// Hash of the shared secret.
    /// </summary>
    public TerraformValue<string> SharedSecretHash
        => CreateReference("shared_secret_hash");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => CreateReference("terraform_labels");

    /// <summary>
    /// The unique identifier for the resource. This identifier is defined by the server.
    /// </summary>
    public TerraformValue<string> TunnelId
        => CreateReference("tunnel_id");

    /// <summary>
    /// CipherSuite block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CipherSuite block(s) allowed")]
    public TerraformList<GoogleComputeVpnTunnelCipherSuiteBlock>? CipherSuite
    {
        get => GetArgument<TerraformList<GoogleComputeVpnTunnelCipherSuiteBlock>>("cipher_suite");
        set => SetArgument("cipher_suite", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleComputeVpnTunnelTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleComputeVpnTunnelTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
