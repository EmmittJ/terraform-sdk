using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_compute_vpn_tunnel resource.
/// </summary>
public class GoogleComputeVpnTunnel : TerraformResource
{
    public GoogleComputeVpnTunnel(string name) : base("google_compute_vpn_tunnel", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("creation_timestamp");
        this.DeclareOutput("detailed_status");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("label_fingerprint");
        this.DeclareOutput("self_link");
        this.DeclareOutput("shared_secret_hash");
        this.DeclareOutput("terraform_labels");
        this.DeclareOutput("tunnel_id");
    }

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// IKE protocol version to use when establishing the VPN tunnel with
    /// peer VPN gateway.
    /// Acceptable IKE versions are 1 or 2. Default version is 2.
    /// </summary>
    public TerraformLiteralProperty<double>? IkeVersion
    {
        get => GetProperty<TerraformLiteralProperty<double>>("ike_version");
        set => this.WithProperty("ike_version", value);
    }

    /// <summary>
    /// Labels to apply to this VpnTunnel.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Labels
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// Local traffic selector to use when establishing the VPN tunnel with
    /// peer VPN gateway. The value should be a CIDR formatted string,
    /// for example &#39;192.168.0.0/16&#39;. The ranges should be disjoint.
    /// Only IPv4 is supported.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? LocalTrafficSelector
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("local_traffic_selector");
        set => this.WithProperty("local_traffic_selector", value);
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
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// URL of the peer side external VPN gateway to which this VPN tunnel is connected.
    /// </summary>
    public TerraformLiteralProperty<string>? PeerExternalGateway
    {
        get => GetProperty<TerraformLiteralProperty<string>>("peer_external_gateway");
        set => this.WithProperty("peer_external_gateway", value);
    }

    /// <summary>
    /// The interface ID of the external VPN gateway to which this VPN tunnel is connected.
    /// </summary>
    public TerraformLiteralProperty<double>? PeerExternalGatewayInterface
    {
        get => GetProperty<TerraformLiteralProperty<double>>("peer_external_gateway_interface");
        set => this.WithProperty("peer_external_gateway_interface", value);
    }

    /// <summary>
    /// URL of the peer side HA GCP VPN gateway to which this VPN tunnel is connected.
    /// If provided, the VPN tunnel will automatically use the same vpn_gateway_interface
    /// ID in the peer GCP VPN gateway.
    /// This field must reference a &#39;google_compute_ha_vpn_gateway&#39; resource.
    /// </summary>
    public TerraformLiteralProperty<string>? PeerGcpGateway
    {
        get => GetProperty<TerraformLiteralProperty<string>>("peer_gcp_gateway");
        set => this.WithProperty("peer_gcp_gateway", value);
    }

    /// <summary>
    /// IP address of the peer VPN gateway. Only IPv4 is supported.
    /// </summary>
    public TerraformLiteralProperty<string>? PeerIp
    {
        get => GetProperty<TerraformLiteralProperty<string>>("peer_ip");
        set => this.WithProperty("peer_ip", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The region where the tunnel is located. If unset, is set to the region of &#39;target_vpn_gateway&#39;.
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// Remote traffic selector to use when establishing the VPN tunnel with
    /// peer VPN gateway. The value should be a CIDR formatted string,
    /// for example &#39;192.168.0.0/16&#39;. The ranges should be disjoint.
    /// Only IPv4 is supported.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? RemoteTrafficSelector
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("remote_traffic_selector");
        set => this.WithProperty("remote_traffic_selector", value);
    }

    /// <summary>
    /// URL of router resource to be used for dynamic routing.
    /// </summary>
    public TerraformLiteralProperty<string>? Router
    {
        get => GetProperty<TerraformLiteralProperty<string>>("router");
        set => this.WithProperty("router", value);
    }

    /// <summary>
    /// Shared secret used to set the secure session between the Cloud VPN
    /// gateway and the peer VPN gateway.
    /// </summary>
    public TerraformLiteralProperty<string>? SharedSecret
    {
        get => GetProperty<TerraformLiteralProperty<string>>("shared_secret");
        set => this.WithProperty("shared_secret", value);
    }

    /// <summary>
    /// Shared secret used to set the secure session between the Cloud VPN
    /// gateway and the peer VPN gateway.
    ///  Note: This property is write-only and will not be read from the API. For more info see [updating write-only attributes](/docs/providers/google/guides/using_write_only_attributes.html#updating-write-only-attributes)
    /// </summary>
    public TerraformLiteralProperty<string>? SharedSecretWo
    {
        get => GetProperty<TerraformLiteralProperty<string>>("shared_secret_wo");
        set => this.WithProperty("shared_secret_wo", value);
    }

    /// <summary>
    /// Triggers update of shared_secret_wo write-only. For more info see [updating write-only attributes](/docs/providers/google/guides/using_write_only_attributes.html#updating-write-only-attributes)
    /// </summary>
    public TerraformLiteralProperty<string>? SharedSecretWoVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("shared_secret_wo_version");
        set => this.WithProperty("shared_secret_wo_version", value);
    }

    /// <summary>
    /// URL of the Target VPN gateway with which this VPN tunnel is
    /// associated.
    /// </summary>
    public TerraformLiteralProperty<string>? TargetVpnGateway
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_vpn_gateway");
        set => this.WithProperty("target_vpn_gateway", value);
    }

    /// <summary>
    /// URL of the VPN gateway with which this VPN tunnel is associated.
    /// This must be used if a High Availability VPN gateway resource is created.
    /// This field must reference a &#39;google_compute_ha_vpn_gateway&#39; resource.
    /// </summary>
    public TerraformLiteralProperty<string>? VpnGateway
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vpn_gateway");
        set => this.WithProperty("vpn_gateway", value);
    }

    /// <summary>
    /// The interface ID of the VPN gateway with which this VPN tunnel is associated.
    /// </summary>
    public TerraformLiteralProperty<double>? VpnGatewayInterface
    {
        get => GetProperty<TerraformLiteralProperty<double>>("vpn_gateway_interface");
        set => this.WithProperty("vpn_gateway_interface", value);
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
