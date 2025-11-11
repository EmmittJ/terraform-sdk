using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsDxBgpPeerTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

}

/// <summary>
/// Manages a aws_dx_bgp_peer resource.
/// </summary>
public partial class AwsDxBgpPeer : TerraformResource
{
    public AwsDxBgpPeer(string name) : base("aws_dx_bgp_peer", name)
    {
    }

    /// <summary>
    /// The address_family attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AddressFamily is required")]
    [TerraformProperty("address_family")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> AddressFamily { get; set; }

    /// <summary>
    /// The amazon_address attribute.
    /// </summary>
    [TerraformProperty("amazon_address")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> AmazonAddress { get; set; }

    /// <summary>
    /// The bgp_asn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BgpAsn is required")]
    [TerraformProperty("bgp_asn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> BgpAsn { get; set; }

    /// <summary>
    /// The bgp_auth_key attribute.
    /// </summary>
    [TerraformProperty("bgp_auth_key")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> BgpAuthKey { get; set; }

    /// <summary>
    /// The customer_address attribute.
    /// </summary>
    [TerraformProperty("customer_address")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> CustomerAddress { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The virtual_interface_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualInterfaceId is required")]
    [TerraformProperty("virtual_interface_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> VirtualInterfaceId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AwsDxBgpPeerTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The aws_device attribute.
    /// </summary>
    [TerraformProperty("aws_device")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> AwsDevice { get; }

    /// <summary>
    /// The bgp_peer_id attribute.
    /// </summary>
    [TerraformProperty("bgp_peer_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> BgpPeerId { get; }

    /// <summary>
    /// The bgp_status attribute.
    /// </summary>
    [TerraformProperty("bgp_status")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> BgpStatus { get; }

}
