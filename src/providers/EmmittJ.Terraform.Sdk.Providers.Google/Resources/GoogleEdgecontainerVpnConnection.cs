using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleEdgecontainerVpnConnection.
/// Nesting mode: single
/// </summary>
public class GoogleEdgecontainerVpnConnectionTimeoutsBlock : TerraformBlock
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
/// Block type for vpc_project in GoogleEdgecontainerVpnConnection.
/// Nesting mode: list
/// </summary>
public class GoogleEdgecontainerVpnConnectionVpcProjectBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "vpc_project";

    /// <summary>
    /// The project of the VPC to connect to. If not specified, it is the same as the cluster project.
    /// </summary>
    public TerraformValue<string>? ProjectId
    {
        get => new TerraformReference<string>(this, "project_id");
        set => SetArgument("project_id", value);
    }

}


/// <summary>
/// Represents a google_edgecontainer_vpn_connection Terraform resource.
/// Manages a google_edgecontainer_vpn_connection resource.
/// </summary>
public partial class GoogleEdgecontainerVpnConnection(string name) : TerraformResource("google_edgecontainer_vpn_connection", name)
{
    /// <summary>
    /// The canonical Cluster name to connect to. It is in the form of projects/{project}/locations/{location}/clusters/{cluster}.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cluster is required")]
    public required TerraformValue<string> Cluster
    {
        get => new TerraformReference<string>(this, "cluster");
        set => SetArgument("cluster", value);
    }

    /// <summary>
    /// Whether this VPN connection has HA enabled on cluster side. If enabled, when creating VPN connection we will attempt to use 2 ANG floating IPs.
    /// </summary>
    public TerraformValue<bool> EnableHighAvailability
    {
        get => new TerraformReference<bool>(this, "enable_high_availability");
        set => SetArgument("enable_high_availability", value);
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
    /// Labels associated with this resource.
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
    /// Google Cloud Platform location.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The resource name of VPN connection
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// NAT gateway IP, or WAN IP address. If a customer has multiple NAT IPs, the customer needs to configure NAT such that only one external IP maps to the GMEC Anthos cluster.
    /// This is empty if NAT is not used.
    /// </summary>
    public TerraformValue<string>? NatGatewayIp
    {
        get => new TerraformReference<string>(this, "nat_gateway_ip");
        set => SetArgument("nat_gateway_ip", value);
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
    /// The VPN connection Cloud Router name.
    /// </summary>
    public TerraformValue<string>? Router
    {
        get => new TerraformReference<string>(this, "router");
        set => SetArgument("router", value);
    }

    /// <summary>
    /// The network ID of VPC to connect to.
    /// </summary>
    public TerraformValue<string>? Vpc
    {
        get => new TerraformReference<string>(this, "vpc");
        set => SetArgument("vpc", value);
    }

    /// <summary>
    /// The time when the VPN connection was created.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// A nested object resource.
    /// </summary>
    public TerraformList<TerraformMap<object>> Details
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "details").ResolveNodes(ctx));
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "effective_labels").ResolveNodes(ctx));
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
    /// The time when the VPN connection was last updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
    {
        get => new TerraformReference<string>(this, "update_time");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleEdgecontainerVpnConnectionTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleEdgecontainerVpnConnectionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// VpcProject block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcProject block(s) allowed")]
    public TerraformList<GoogleEdgecontainerVpnConnectionVpcProjectBlock>? VpcProject
    {
        get => GetArgument<TerraformList<GoogleEdgecontainerVpnConnectionVpcProjectBlock>>("vpc_project");
        set => SetArgument("vpc_project", value);
    }

}
