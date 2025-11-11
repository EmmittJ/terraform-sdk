using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_vmwareengine_subnet.
/// </summary>
public class GoogleVmwareengineSubnetDataSource : TerraformDataSource
{
    public GoogleVmwareengineSubnetDataSource(string name) : base("google_vmwareengine_subnet", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The ID of the subnet. For userDefined subnets, this name should be in the format of &amp;quot;service-n&amp;quot;,
    /// where n ranges from 1 to 5.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource name of the private cloud to create a new subnet in.
    /// Resource names are schemeless URIs that follow the conventions in https://cloud.google.com/apis/design/resource_names.
    /// For example: projects/my-project/locations/us-west1-a/privateClouds/my-cloud
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    [TerraformPropertyName("parent")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Parent { get; set; }

    /// <summary>
    /// Creation time of this resource.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and
    /// up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreateTime => new TerraformReference(this, "create_time");

    /// <summary>
    /// DHCP address ranges.
    /// </summary>
    [TerraformPropertyName("dhcp_address_ranges")]
    // Output-only attribute - read-only reference
    public TerraformList<object> DhcpAddressRanges => new TerraformReference(this, "dhcp_address_ranges");

    /// <summary>
    /// The canonical identifier of the logical router that this subnet is attached to.
    /// </summary>
    [TerraformPropertyName("gateway_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> GatewayId => new TerraformReference(this, "gateway_id");

    /// <summary>
    /// The IP address of the gateway of this subnet. Must fall within the IP prefix defined above.
    /// </summary>
    [TerraformPropertyName("gateway_ip")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> GatewayIp => new TerraformReference(this, "gateway_ip");

    /// <summary>
    /// The IP address range of the subnet in CIDR format.
    /// </summary>
    [TerraformPropertyName("ip_cidr_range")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> IpCidrRange => new TerraformReference(this, "ip_cidr_range");

    /// <summary>
    /// Whether the NSX-T configuration in the backend follows the standard configuration supported by Google Cloud.
    /// If false, the subnet cannot be modified through Google Cloud, only through NSX-T directly.
    /// </summary>
    [TerraformPropertyName("standard_config")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> StandardConfig => new TerraformReference(this, "standard_config");

    /// <summary>
    /// State of the subnet.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> State => new TerraformReference(this, "state");

    /// <summary>
    /// The type of the subnet.
    /// </summary>
    [TerraformPropertyName("type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Type => new TerraformReference(this, "type");

    /// <summary>
    /// System-generated unique identifier for the resource.
    /// </summary>
    [TerraformPropertyName("uid")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Uid => new TerraformReference(this, "uid");

    /// <summary>
    /// Last updated time of this resource.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine
    /// fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UpdateTime => new TerraformReference(this, "update_time");

    /// <summary>
    /// VLAN ID of the VLAN on which the subnet is configured.
    /// </summary>
    [TerraformPropertyName("vlan_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> VlanId => new TerraformReference(this, "vlan_id");

}
