using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for interface in GoogleComputeExternalVpnGateway.
/// Nesting mode: list
/// </summary>
public class GoogleComputeExternalVpnGatewayInterfaceAttributeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "interface";

    /// <summary>
    /// The numeric ID for this interface. Allowed values are based on the redundancy type
    /// of this external VPN gateway
    /// * &#39;0 - SINGLE_IP_INTERNALLY_REDUNDANT&#39;
    /// * &#39;0, 1 - TWO_IPS_REDUNDANCY&#39;
    /// * &#39;0, 1, 2, 3 - FOUR_IPS_REDUNDANCY&#39;
    /// </summary>
    public TerraformValue<double>? Id
    {
        get => new TerraformReference<double>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// IP address of the interface in the external VPN gateway.
    /// Only IPv4 is supported. This IP address can be either from
    /// your on-premise gateway or another Cloud provider&#39;s VPN gateway,
    /// it cannot be an IP address from Google Compute Engine.
    /// </summary>
    public TerraformValue<string>? IpAddress
    {
        get => new TerraformReference<string>(this, "ip_address");
        set => SetArgument("ip_address", value);
    }

    /// <summary>
    /// IPv6 address of the interface in the external VPN gateway. This IPv6
    /// address can be either from your on-premise gateway or another Cloud
    /// provider&#39;s VPN gateway, it cannot be an IP address from Google Compute
    /// Engine. Must specify an IPv6 address (not IPV4-mapped) using any format
    /// described in RFC 4291 (e.g. 2001:db8:0:0:2d9:51:0:0). The output format
    /// is RFC 5952 format (e.g. 2001:db8::2d9:51:0:0).
    /// </summary>
    public TerraformValue<string>? Ipv6Address
    {
        get => new TerraformReference<string>(this, "ipv6_address");
        set => SetArgument("ipv6_address", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleComputeExternalVpnGateway.
/// Nesting mode: single
/// </summary>
public class GoogleComputeExternalVpnGatewayTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_compute_external_vpn_gateway Terraform resource.
/// Manages a google_compute_external_vpn_gateway resource.
/// </summary>
public partial class GoogleComputeExternalVpnGateway(string name) : TerraformResource("google_compute_external_vpn_gateway", name)
{
    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
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
    /// Labels for the external VPN gateway resource.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "labels").ResolveNodes(ctx));
        set => SetArgument("labels", value);
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
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Indicates the redundancy type of this external VPN gateway Possible values: [&amp;quot;FOUR_IPS_REDUNDANCY&amp;quot;, &amp;quot;SINGLE_IP_INTERNALLY_REDUNDANT&amp;quot;, &amp;quot;TWO_IPS_REDUNDANCY&amp;quot;]
    /// </summary>
    public TerraformValue<string>? RedundancyType
    {
        get => new TerraformReference<string>(this, "redundancy_type");
        set => SetArgument("redundancy_type", value);
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "effective_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// The fingerprint used for optimistic locking of this resource.  Used
    /// internally during updates.
    /// </summary>
    public TerraformValue<string> LabelFingerprint
    {
        get => new TerraformReference<string>(this, "label_fingerprint");
    }

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformValue<string> SelfLink
    {
        get => new TerraformReference<string>(this, "self_link");
    }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "terraform_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// InterfaceAttribute block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeExternalVpnGatewayInterfaceAttributeBlock>? InterfaceAttribute
    {
        get => GetArgument<TerraformList<GoogleComputeExternalVpnGatewayInterfaceAttributeBlock>>("interface");
        set => SetArgument("interface", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleComputeExternalVpnGatewayTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleComputeExternalVpnGatewayTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
