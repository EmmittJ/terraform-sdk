using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsDxTransitVirtualInterfaceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_dx_transit_virtual_interface resource.
/// </summary>
public partial class AwsDxTransitVirtualInterface : TerraformResource
{
    public AwsDxTransitVirtualInterface(string name) : base("aws_dx_transit_virtual_interface", name)
    {
    }

    /// <summary>
    /// The address_family attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AddressFamily is required")]
    [TerraformProperty("address_family")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AddressFamily { get; set; }

    /// <summary>
    /// The amazon_address attribute.
    /// </summary>
    [TerraformProperty("amazon_address")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> AmazonAddress { get; set; }

    /// <summary>
    /// The bgp_asn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BgpAsn is required")]
    [TerraformProperty("bgp_asn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> BgpAsn { get; set; }

    /// <summary>
    /// The bgp_auth_key attribute.
    /// </summary>
    [TerraformProperty("bgp_auth_key")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> BgpAuthKey { get; set; }

    /// <summary>
    /// The connection_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionId is required")]
    [TerraformProperty("connection_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ConnectionId { get; set; }

    /// <summary>
    /// The customer_address attribute.
    /// </summary>
    [TerraformProperty("customer_address")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> CustomerAddress { get; set; }

    /// <summary>
    /// The dx_gateway_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DxGatewayId is required")]
    [TerraformProperty("dx_gateway_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DxGatewayId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The mtu attribute.
    /// </summary>
    [TerraformProperty("mtu")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Mtu { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The sitelink_enabled attribute.
    /// </summary>
    [TerraformProperty("sitelink_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? SitelinkEnabled { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The vlan attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Vlan is required")]
    [TerraformProperty("vlan")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> Vlan { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsDxTransitVirtualInterfaceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The amazon_side_asn attribute.
    /// </summary>
    [TerraformProperty("amazon_side_asn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AmazonSideAsn { get; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The aws_device attribute.
    /// </summary>
    [TerraformProperty("aws_device")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AwsDevice { get; }

    /// <summary>
    /// The jumbo_frame_capable attribute.
    /// </summary>
    [TerraformProperty("jumbo_frame_capable")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> JumboFrameCapable { get; }

}
