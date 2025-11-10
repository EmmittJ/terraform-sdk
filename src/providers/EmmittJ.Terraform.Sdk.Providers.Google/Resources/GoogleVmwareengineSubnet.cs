using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleVmwareengineSubnetTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a google_vmwareengine_subnet resource.
/// </summary>
public class GoogleVmwareengineSubnet : TerraformResource
{
    public GoogleVmwareengineSubnet(string name) : base("google_vmwareengine_subnet", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The IP address range of the subnet in CIDR format.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpCidrRange is required")]
    [TerraformPropertyName("ip_cidr_range")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> IpCidrRange { get; set; }

    /// <summary>
    /// The ID of the subnet. For userDefined subnets, this name should be in the format of &amp;quot;service-n&amp;quot;,
    /// where n ranges from 1 to 5.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The resource name of the private cloud to create a new subnet in.
    /// Resource names are schemeless URIs that follow the conventions in https://cloud.google.com/apis/design/resource_names.
    /// For example: projects/my-project/locations/us-west1-a/privateClouds/my-cloud
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    [TerraformPropertyName("parent")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Parent { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleVmwareengineSubnetTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Creation time of this resource.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and
    /// up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// DHCP address ranges.
    /// </summary>
    [TerraformPropertyName("dhcp_address_ranges")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> DhcpAddressRanges => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "dhcp_address_ranges");

    /// <summary>
    /// The canonical identifier of the logical router that this subnet is attached to.
    /// </summary>
    [TerraformPropertyName("gateway_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> GatewayId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "gateway_id");

    /// <summary>
    /// The IP address of the gateway of this subnet. Must fall within the IP prefix defined above.
    /// </summary>
    [TerraformPropertyName("gateway_ip")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> GatewayIp => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "gateway_ip");

    /// <summary>
    /// Whether the NSX-T configuration in the backend follows the standard configuration supported by Google Cloud.
    /// If false, the subnet cannot be modified through Google Cloud, only through NSX-T directly.
    /// </summary>
    [TerraformPropertyName("standard_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> StandardConfig => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "standard_config");

    /// <summary>
    /// State of the subnet.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state");

    /// <summary>
    /// The type of the subnet.
    /// </summary>
    [TerraformPropertyName("type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Type => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "type");

    /// <summary>
    /// System-generated unique identifier for the resource.
    /// </summary>
    [TerraformPropertyName("uid")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Uid => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "uid");

    /// <summary>
    /// Last updated time of this resource.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine
    /// fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "update_time");

    /// <summary>
    /// VLAN ID of the VLAN on which the subnet is configured.
    /// </summary>
    [TerraformPropertyName("vlan_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> VlanId => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "vlan_id");

}
