using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_vmwareengine_subnet.
/// </summary>
public partial class GoogleVmwareengineSubnetDataSource : TerraformDataSource
{
    public GoogleVmwareengineSubnetDataSource(string name) : base("google_vmwareengine_subnet", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The ID of the subnet. For userDefined subnets, this name should be in the format of &amp;quot;service-n&amp;quot;,
    /// where n ranges from 1 to 5.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource name of the private cloud to create a new subnet in.
    /// Resource names are schemeless URIs that follow the conventions in https://cloud.google.com/apis/design/resource_names.
    /// For example: projects/my-project/locations/us-west1-a/privateClouds/my-cloud
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    [TerraformProperty("parent")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Parent { get; set; }

    /// <summary>
    /// Creation time of this resource.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and
    /// up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// DHCP address ranges.
    /// </summary>
    [TerraformProperty("dhcp_address_ranges")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> DhcpAddressRanges { get; }

    /// <summary>
    /// The canonical identifier of the logical router that this subnet is attached to.
    /// </summary>
    [TerraformProperty("gateway_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> GatewayId { get; }

    /// <summary>
    /// The IP address of the gateway of this subnet. Must fall within the IP prefix defined above.
    /// </summary>
    [TerraformProperty("gateway_ip")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> GatewayIp { get; }

    /// <summary>
    /// The IP address range of the subnet in CIDR format.
    /// </summary>
    [TerraformProperty("ip_cidr_range")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> IpCidrRange { get; }

    /// <summary>
    /// Whether the NSX-T configuration in the backend follows the standard configuration supported by Google Cloud.
    /// If false, the subnet cannot be modified through Google Cloud, only through NSX-T directly.
    /// </summary>
    [TerraformProperty("standard_config")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> StandardConfig { get; }

    /// <summary>
    /// State of the subnet.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

    /// <summary>
    /// The type of the subnet.
    /// </summary>
    [TerraformProperty("type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Type { get; }

    /// <summary>
    /// System-generated unique identifier for the resource.
    /// </summary>
    [TerraformProperty("uid")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Uid { get; }

    /// <summary>
    /// Last updated time of this resource.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine
    /// fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

    /// <summary>
    /// VLAN ID of the VLAN on which the subnet is configured.
    /// </summary>
    [TerraformProperty("vlan_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> VlanId { get; }

}
