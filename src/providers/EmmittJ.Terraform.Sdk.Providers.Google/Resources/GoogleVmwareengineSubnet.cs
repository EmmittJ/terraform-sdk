using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleVmwareengineSubnet.
/// Nesting mode: single
/// </summary>
public class GoogleVmwareengineSubnetTimeoutsBlock : TerraformBlock
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
/// Represents a google_vmwareengine_subnet Terraform resource.
/// Manages a google_vmwareengine_subnet resource.
/// </summary>
public partial class GoogleVmwareengineSubnet(string name) : TerraformResource("google_vmwareengine_subnet", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The IP address range of the subnet in CIDR format.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpCidrRange is required")]
    public required TerraformValue<string> IpCidrRange
    {
        get => GetArgument<TerraformValue<string>>("ip_cidr_range");
        set => SetArgument("ip_cidr_range", value);
    }

    /// <summary>
    /// The ID of the subnet. For userDefined subnets, this name should be in the format of &amp;quot;service-n&amp;quot;,
    /// where n ranges from 1 to 5.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource name of the private cloud to create a new subnet in.
    /// Resource names are schemeless URIs that follow the conventions in https://cloud.google.com/apis/design/resource_names.
    /// For example: projects/my-project/locations/us-west1-a/privateClouds/my-cloud
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    public required TerraformValue<string> Parent
    {
        get => GetArgument<TerraformValue<string>>("parent");
        set => SetArgument("parent", value);
    }

    /// <summary>
    /// Creation time of this resource.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and
    /// up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// DHCP address ranges.
    /// </summary>
    public TerraformList<TerraformMap<object>> DhcpAddressRanges
        => AsReference("dhcp_address_ranges");

    /// <summary>
    /// The canonical identifier of the logical router that this subnet is attached to.
    /// </summary>
    public TerraformValue<string> GatewayId
        => AsReference("gateway_id");

    /// <summary>
    /// The IP address of the gateway of this subnet. Must fall within the IP prefix defined above.
    /// </summary>
    public TerraformValue<string> GatewayIp
        => AsReference("gateway_ip");

    /// <summary>
    /// Whether the NSX-T configuration in the backend follows the standard configuration supported by Google Cloud.
    /// If false, the subnet cannot be modified through Google Cloud, only through NSX-T directly.
    /// </summary>
    public TerraformValue<bool> StandardConfig
        => AsReference("standard_config");

    /// <summary>
    /// State of the subnet.
    /// </summary>
    public TerraformValue<string> State
        => AsReference("state");

    /// <summary>
    /// The type of the subnet.
    /// </summary>
    public TerraformValue<string> Type
        => AsReference("type");

    /// <summary>
    /// System-generated unique identifier for the resource.
    /// </summary>
    public TerraformValue<string> Uid
        => AsReference("uid");

    /// <summary>
    /// Last updated time of this resource.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine
    /// fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// VLAN ID of the VLAN on which the subnet is configured.
    /// </summary>
    public TerraformValue<double> VlanId
        => AsReference("vlan_id");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleVmwareengineSubnetTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleVmwareengineSubnetTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
