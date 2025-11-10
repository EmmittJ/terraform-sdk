using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for cipher_suite in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeVpnTunnelCipherSuiteBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeVpnTunnelTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a google_compute_vpn_tunnel resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleComputeVpnTunnel : TerraformResource
{
    public GoogleComputeVpnTunnel(string name) : base("google_compute_vpn_tunnel", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("creation_timestamp");
        SetOutput("detailed_status");
        SetOutput("effective_labels");
        SetOutput("label_fingerprint");
        SetOutput("self_link");
        SetOutput("shared_secret_hash");
        SetOutput("terraform_labels");
        SetOutput("tunnel_id");
        SetOutput("description");
        SetOutput("id");
        SetOutput("ike_version");
        SetOutput("labels");
        SetOutput("local_traffic_selector");
        SetOutput("name");
        SetOutput("peer_external_gateway");
        SetOutput("peer_external_gateway_interface");
        SetOutput("peer_gcp_gateway");
        SetOutput("peer_ip");
        SetOutput("project");
        SetOutput("region");
        SetOutput("remote_traffic_selector");
        SetOutput("router");
        SetOutput("shared_secret");
        SetOutput("shared_secret_wo");
        SetOutput("shared_secret_wo_version");
        SetOutput("target_vpn_gateway");
        SetOutput("vpn_gateway");
        SetOutput("vpn_gateway_interface");
    }

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
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
    /// IKE protocol version to use when establishing the VPN tunnel with
    /// peer VPN gateway.
    /// Acceptable IKE versions are 1 or 2. Default version is 2.
    /// </summary>
    public TerraformProperty<double> IkeVersion
    {
        get => GetRequiredOutput<TerraformProperty<double>>("ike_version");
        set => SetProperty("ike_version", value);
    }

    /// <summary>
    /// Labels to apply to this VpnTunnel.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Labels
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("labels");
        set => SetProperty("labels", value);
    }

    /// <summary>
    /// Local traffic selector to use when establishing the VPN tunnel with
    /// peer VPN gateway. The value should be a CIDR formatted string,
    /// for example &#39;192.168.0.0/16&#39;. The ranges should be disjoint.
    /// Only IPv4 is supported.
    /// </summary>
    public HashSet<TerraformProperty<string>> LocalTrafficSelector
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("local_traffic_selector");
        set => SetProperty("local_traffic_selector", value);
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
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// URL of the peer side external VPN gateway to which this VPN tunnel is connected.
    /// </summary>
    public TerraformProperty<string> PeerExternalGateway
    {
        get => GetRequiredOutput<TerraformProperty<string>>("peer_external_gateway");
        set => SetProperty("peer_external_gateway", value);
    }

    /// <summary>
    /// The interface ID of the external VPN gateway to which this VPN tunnel is connected.
    /// </summary>
    public TerraformProperty<double> PeerExternalGatewayInterface
    {
        get => GetRequiredOutput<TerraformProperty<double>>("peer_external_gateway_interface");
        set => SetProperty("peer_external_gateway_interface", value);
    }

    /// <summary>
    /// URL of the peer side HA GCP VPN gateway to which this VPN tunnel is connected.
    /// If provided, the VPN tunnel will automatically use the same vpn_gateway_interface
    /// ID in the peer GCP VPN gateway.
    /// This field must reference a &#39;google_compute_ha_vpn_gateway&#39; resource.
    /// </summary>
    public TerraformProperty<string> PeerGcpGateway
    {
        get => GetRequiredOutput<TerraformProperty<string>>("peer_gcp_gateway");
        set => SetProperty("peer_gcp_gateway", value);
    }

    /// <summary>
    /// IP address of the peer VPN gateway. Only IPv4 is supported.
    /// </summary>
    public TerraformProperty<string> PeerIp
    {
        get => GetRequiredOutput<TerraformProperty<string>>("peer_ip");
        set => SetProperty("peer_ip", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// The region where the tunnel is located. If unset, is set to the region of &#39;target_vpn_gateway&#39;.
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// Remote traffic selector to use when establishing the VPN tunnel with
    /// peer VPN gateway. The value should be a CIDR formatted string,
    /// for example &#39;192.168.0.0/16&#39;. The ranges should be disjoint.
    /// Only IPv4 is supported.
    /// </summary>
    public HashSet<TerraformProperty<string>> RemoteTrafficSelector
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("remote_traffic_selector");
        set => SetProperty("remote_traffic_selector", value);
    }

    /// <summary>
    /// URL of router resource to be used for dynamic routing.
    /// </summary>
    public TerraformProperty<string> Router
    {
        get => GetRequiredOutput<TerraformProperty<string>>("router");
        set => SetProperty("router", value);
    }

    /// <summary>
    /// Shared secret used to set the secure session between the Cloud VPN
    /// gateway and the peer VPN gateway.
    /// </summary>
    public TerraformProperty<string> SharedSecret
    {
        get => GetRequiredOutput<TerraformProperty<string>>("shared_secret");
        set => SetProperty("shared_secret", value);
    }

    /// <summary>
    /// Shared secret used to set the secure session between the Cloud VPN
    /// gateway and the peer VPN gateway.
    ///  Note: This property is write-only and will not be read from the API. For more info see [updating write-only attributes](/docs/providers/google/guides/using_write_only_attributes.html#updating-write-only-attributes)
    /// </summary>
    public TerraformProperty<string> SharedSecretWo
    {
        get => GetRequiredOutput<TerraformProperty<string>>("shared_secret_wo");
        set => SetProperty("shared_secret_wo", value);
    }

    /// <summary>
    /// Triggers update of shared_secret_wo write-only. For more info see [updating write-only attributes](/docs/providers/google/guides/using_write_only_attributes.html#updating-write-only-attributes)
    /// </summary>
    public TerraformProperty<string> SharedSecretWoVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("shared_secret_wo_version");
        set => SetProperty("shared_secret_wo_version", value);
    }

    /// <summary>
    /// URL of the Target VPN gateway with which this VPN tunnel is
    /// associated.
    /// </summary>
    public TerraformProperty<string> TargetVpnGateway
    {
        get => GetRequiredOutput<TerraformProperty<string>>("target_vpn_gateway");
        set => SetProperty("target_vpn_gateway", value);
    }

    /// <summary>
    /// URL of the VPN gateway with which this VPN tunnel is associated.
    /// This must be used if a High Availability VPN gateway resource is created.
    /// This field must reference a &#39;google_compute_ha_vpn_gateway&#39; resource.
    /// </summary>
    public TerraformProperty<string> VpnGateway
    {
        get => GetRequiredOutput<TerraformProperty<string>>("vpn_gateway");
        set => SetProperty("vpn_gateway", value);
    }

    /// <summary>
    /// The interface ID of the VPN gateway with which this VPN tunnel is associated.
    /// </summary>
    public TerraformProperty<double> VpnGatewayInterface
    {
        get => GetRequiredOutput<TerraformProperty<double>>("vpn_gateway_interface");
        set => SetProperty("vpn_gateway_interface", value);
    }

    /// <summary>
    /// Block for cipher_suite.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CipherSuite block(s) allowed")]
    public List<GoogleComputeVpnTunnelCipherSuiteBlock>? CipherSuite
    {
        set => SetProperty("cipher_suite", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleComputeVpnTunnelTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformExpression CreationTimestamp => this["creation_timestamp"];

    /// <summary>
    /// Detailed status message for the VPN tunnel.
    /// </summary>
    public TerraformExpression DetailedStatus => this["detailed_status"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The fingerprint used for optimistic locking of this resource.  Used
    /// internally during updates.
    /// </summary>
    public TerraformExpression LabelFingerprint => this["label_fingerprint"];

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

    /// <summary>
    /// Hash of the shared secret.
    /// </summary>
    public TerraformExpression SharedSecretHash => this["shared_secret_hash"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// The unique identifier for the resource. This identifier is defined by the server.
    /// </summary>
    public TerraformExpression TunnelId => this["tunnel_id"];

}
