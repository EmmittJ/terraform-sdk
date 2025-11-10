using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeHaVpnGatewayTimeoutsBlock : TerraformBlock
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
/// Block type for vpn_interfaces in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeHaVpnGatewayVpnInterfacesBlock : TerraformBlock
{
    /// <summary>
    /// The numeric ID of this VPN gateway interface.
    /// </summary>
    public TerraformProperty<double>? Id
    {
        set => SetProperty("id", value);
    }

    /// <summary>
    /// URL of the interconnect attachment resource. When the value
    /// of this field is present, the VPN Gateway will be used for
    /// IPsec-encrypted Cloud Interconnect; all Egress or Ingress
    /// traffic for this VPN Gateway interface will go through the
    /// specified interconnect attachment resource.
    /// 
    /// Not currently available publicly.
    /// </summary>
    public TerraformProperty<string>? InterconnectAttachment
    {
        set => SetProperty("interconnect_attachment", value);
    }

    /// <summary>
    /// The external IP address for this VPN gateway interface.
    /// </summary>
    public TerraformProperty<string>? IpAddress
    {
        set => SetProperty("ip_address", value);
    }

}

/// <summary>
/// Manages a google_compute_ha_vpn_gateway resource.
/// </summary>
public class GoogleComputeHaVpnGateway : TerraformResource
{
    public GoogleComputeHaVpnGateway(string name) : base("google_compute_ha_vpn_gateway", name)
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
        SetOutput("gateway_ip_version");
        SetOutput("id");
        SetOutput("labels");
        SetOutput("name");
        SetOutput("network");
        SetOutput("project");
        SetOutput("region");
        SetOutput("stack_type");
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
    /// The IP family of the gateway IPs for the HA-VPN gateway interfaces. If not specified, IPV4 will be used. Default value: &amp;quot;IPV4&amp;quot; Possible values: [&amp;quot;IPV4&amp;quot;, &amp;quot;IPV6&amp;quot;]
    /// </summary>
    public TerraformProperty<string> GatewayIpVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("gateway_ip_version");
        set => SetProperty("gateway_ip_version", value);
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
    /// Labels for this resource. These can only be added or modified by the setLabels method.
    /// Each label key/value pair must comply with RFC1035. Label values may be empty.
    /// 
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
    /// The network this VPN gateway is accepting traffic for.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    public required TerraformProperty<string> Network
    {
        get => GetRequiredOutput<TerraformProperty<string>>("network");
        set => SetProperty("network", value);
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
    /// The region this gateway should sit in.
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The stack type for this VPN gateway to identify the IP protocols that are enabled.
    /// If not specified, IPV4_ONLY will be used. Default value: &amp;quot;IPV4_ONLY&amp;quot; Possible values: [&amp;quot;IPV4_ONLY&amp;quot;, &amp;quot;IPV4_IPV6&amp;quot;, &amp;quot;IPV6_ONLY&amp;quot;]
    /// </summary>
    public TerraformProperty<string> StackType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("stack_type");
        set => SetProperty("stack_type", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleComputeHaVpnGatewayTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for vpn_interfaces.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleComputeHaVpnGatewayVpnInterfacesBlock>? VpnInterfaces
    {
        set => SetProperty("vpn_interfaces", value);
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// A fingerprint for the labels being applied to this VpnGateway, which is essentially a hash
    /// of the labels set used for optimistic locking. The fingerprint is initially generated by
    /// Compute Engine and changes after every request to modify or update labels.
    /// You must always provide an up-to-date fingerprint hash in order to update or change labels,
    /// otherwise the request will fail with error 412 conditionNotMet.
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
