using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsDxBgpPeerTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

}

/// <summary>
/// Manages a aws_dx_bgp_peer resource.
/// </summary>
public class AwsDxBgpPeer : TerraformResource
{
    public AwsDxBgpPeer(string name) : base("aws_dx_bgp_peer", name)
    {
    }

    /// <summary>
    /// The address_family attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AddressFamily is required")]
    [TerraformPropertyName("address_family")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AddressFamily { get; set; }

    /// <summary>
    /// The amazon_address attribute.
    /// </summary>
    [TerraformPropertyName("amazon_address")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> AmazonAddress { get; set; } = default!;

    /// <summary>
    /// The bgp_asn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BgpAsn is required")]
    [TerraformPropertyName("bgp_asn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> BgpAsn { get; set; }

    /// <summary>
    /// The bgp_auth_key attribute.
    /// </summary>
    [TerraformPropertyName("bgp_auth_key")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> BgpAuthKey { get; set; } = default!;

    /// <summary>
    /// The customer_address attribute.
    /// </summary>
    [TerraformPropertyName("customer_address")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> CustomerAddress { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The virtual_interface_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualInterfaceId is required")]
    [TerraformPropertyName("virtual_interface_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> VirtualInterfaceId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsDxBgpPeerTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The aws_device attribute.
    /// </summary>
    [TerraformPropertyName("aws_device")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AwsDevice => new TerraformReference(this, "aws_device");

    /// <summary>
    /// The bgp_peer_id attribute.
    /// </summary>
    [TerraformPropertyName("bgp_peer_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> BgpPeerId => new TerraformReference(this, "bgp_peer_id");

    /// <summary>
    /// The bgp_status attribute.
    /// </summary>
    [TerraformPropertyName("bgp_status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> BgpStatus => new TerraformReference(this, "bgp_status");

}
