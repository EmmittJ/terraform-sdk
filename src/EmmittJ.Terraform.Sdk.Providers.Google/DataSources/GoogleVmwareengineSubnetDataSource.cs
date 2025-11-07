using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_vmwareengine_subnet.
/// </summary>
public class GoogleVmwareengineSubnetDataSource : TerraformDataSource
{
    public GoogleVmwareengineSubnetDataSource(string name) : base("google_vmwareengine_subnet", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("dhcp_address_ranges");
        this.DeclareOutput("gateway_id");
        this.DeclareOutput("gateway_ip");
        this.DeclareOutput("ip_cidr_range");
        this.DeclareOutput("standard_config");
        this.DeclareOutput("state");
        this.DeclareOutput("type");
        this.DeclareOutput("uid");
        this.DeclareOutput("update_time");
        this.DeclareOutput("vlan_id");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The ID of the subnet. For userDefined subnets, this name should be in the format of &amp;quot;service-n&amp;quot;,
    /// where n ranges from 1 to 5.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource name of the private cloud to create a new subnet in.
    /// Resource names are schemeless URIs that follow the conventions in https://cloud.google.com/apis/design/resource_names.
    /// For example: projects/my-project/locations/us-west1-a/privateClouds/my-cloud
    /// </summary>
    public TerraformProperty<string>? Parent
    {
        get => GetProperty<TerraformProperty<string>>("parent");
        set => this.WithProperty("parent", value);
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
    /// The IP address range of the subnet in CIDR format.
    /// </summary>
    public TerraformExpression IpCidrRange => this["ip_cidr_range"];

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
