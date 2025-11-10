using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleVmwareengineSubnetTimeoutsBlock : TerraformBlock
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
/// Manages a google_vmwareengine_subnet resource.
/// </summary>
public class GoogleVmwareengineSubnet : TerraformResource
{
    public GoogleVmwareengineSubnet(string name) : base("google_vmwareengine_subnet", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("create_time");
        SetOutput("dhcp_address_ranges");
        SetOutput("gateway_id");
        SetOutput("gateway_ip");
        SetOutput("standard_config");
        SetOutput("state");
        SetOutput("type");
        SetOutput("uid");
        SetOutput("update_time");
        SetOutput("vlan_id");
        SetOutput("id");
        SetOutput("ip_cidr_range");
        SetOutput("name");
        SetOutput("parent");
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
    /// The IP address range of the subnet in CIDR format.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpCidrRange is required")]
    public required TerraformProperty<string> IpCidrRange
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ip_cidr_range");
        set => SetProperty("ip_cidr_range", value);
    }

    /// <summary>
    /// The ID of the subnet. For userDefined subnets, this name should be in the format of &amp;quot;service-n&amp;quot;,
    /// where n ranges from 1 to 5.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The resource name of the private cloud to create a new subnet in.
    /// Resource names are schemeless URIs that follow the conventions in https://cloud.google.com/apis/design/resource_names.
    /// For example: projects/my-project/locations/us-west1-a/privateClouds/my-cloud
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    public required TerraformProperty<string> Parent
    {
        get => GetRequiredOutput<TerraformProperty<string>>("parent");
        set => SetProperty("parent", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleVmwareengineSubnetTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Creation time of this resource.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and
    /// up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// DHCP address ranges.
    /// </summary>
    public TerraformExpression DhcpAddressRanges => this["dhcp_address_ranges"];

    /// <summary>
    /// The canonical identifier of the logical router that this subnet is attached to.
    /// </summary>
    public TerraformExpression GatewayId => this["gateway_id"];

    /// <summary>
    /// The IP address of the gateway of this subnet. Must fall within the IP prefix defined above.
    /// </summary>
    public TerraformExpression GatewayIp => this["gateway_ip"];

    /// <summary>
    /// Whether the NSX-T configuration in the backend follows the standard configuration supported by Google Cloud.
    /// If false, the subnet cannot be modified through Google Cloud, only through NSX-T directly.
    /// </summary>
    public TerraformExpression StandardConfig => this["standard_config"];

    /// <summary>
    /// State of the subnet.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// The type of the subnet.
    /// </summary>
    public TerraformExpression Type => this["type"];

    /// <summary>
    /// System-generated unique identifier for the resource.
    /// </summary>
    public TerraformExpression Uid => this["uid"];

    /// <summary>
    /// Last updated time of this resource.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine
    /// fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

    /// <summary>
    /// VLAN ID of the VLAN on which the subnet is configured.
    /// </summary>
    public TerraformExpression VlanId => this["vlan_id"];

}
