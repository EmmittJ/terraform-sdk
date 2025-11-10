using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for interface in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeExternalVpnGatewayInterfaceBlock : TerraformBlock
{
    /// <summary>
    /// The numeric ID for this interface. Allowed values are based on the redundancy type
    /// of this external VPN gateway
    /// * &#39;0 - SINGLE_IP_INTERNALLY_REDUNDANT&#39;
    /// * &#39;0, 1 - TWO_IPS_REDUNDANCY&#39;
    /// * &#39;0, 1, 2, 3 - FOUR_IPS_REDUNDANCY&#39;
    /// </summary>
    public TerraformProperty<double>? Id
    {
        set => SetProperty("id", value);
    }

    /// <summary>
    /// IP address of the interface in the external VPN gateway.
    /// Only IPv4 is supported. This IP address can be either from
    /// your on-premise gateway or another Cloud provider&#39;s VPN gateway,
    /// it cannot be an IP address from Google Compute Engine.
    /// </summary>
    public TerraformProperty<string>? IpAddress
    {
        set => SetProperty("ip_address", value);
    }

    /// <summary>
    /// IPv6 address of the interface in the external VPN gateway. This IPv6
    /// address can be either from your on-premise gateway or another Cloud
    /// provider&#39;s VPN gateway, it cannot be an IP address from Google Compute
    /// Engine. Must specify an IPv6 address (not IPV4-mapped) using any format
    /// described in RFC 4291 (e.g. 2001:db8:0:0:2d9:51:0:0). The output format
    /// is RFC 5952 format (e.g. 2001:db8::2d9:51:0:0).
    /// </summary>
    public TerraformProperty<string>? Ipv6Address
    {
        set => SetProperty("ipv6_address", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeExternalVpnGatewayTimeoutsBlock : TerraformBlock
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
/// Manages a google_compute_external_vpn_gateway resource.
/// </summary>
public class GoogleComputeExternalVpnGateway : TerraformResource
{
    public GoogleComputeExternalVpnGateway(string name) : base("google_compute_external_vpn_gateway", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("effective_labels");
        SetOutput("label_fingerprint");
        SetOutput("self_link");
        SetOutput("terraform_labels");
        SetOutput("description");
        SetOutput("id");
        SetOutput("labels");
        SetOutput("name");
        SetOutput("project");
        SetOutput("redundancy_type");
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
    /// Labels for the external VPN gateway resource.
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
    /// Name of the resource. Provided by the client when the resource is
    /// created. The name must be 1-63 characters long, and comply with
    /// RFC1035.  Specifically, the name must be 1-63 characters long and
    /// match the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39; which means
    /// the first character must be a lowercase letter, and all following
    /// characters must be a dash, lowercase letter, or digit, except the last
    /// character, which cannot be a dash.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
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
    /// Indicates the redundancy type of this external VPN gateway Possible values: [&amp;quot;FOUR_IPS_REDUNDANCY&amp;quot;, &amp;quot;SINGLE_IP_INTERNALLY_REDUNDANT&amp;quot;, &amp;quot;TWO_IPS_REDUNDANCY&amp;quot;]
    /// </summary>
    public TerraformProperty<string> RedundancyType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("redundancy_type");
        set => SetProperty("redundancy_type", value);
    }

    /// <summary>
    /// Block for interface.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleComputeExternalVpnGatewayInterfaceBlock>? Interface
    {
        set => SetProperty("interface", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleComputeExternalVpnGatewayTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

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
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

}
