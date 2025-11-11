using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsDxHostedTransitVirtualInterfaceTimeoutsBlock
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
/// Manages a aws_dx_hosted_transit_virtual_interface resource.
/// </summary>
public class AwsDxHostedTransitVirtualInterface : TerraformResource
{
    public AwsDxHostedTransitVirtualInterface(string name) : base("aws_dx_hosted_transit_virtual_interface", name)
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
    /// The connection_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionId is required")]
    [TerraformPropertyName("connection_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ConnectionId { get; set; }

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
    /// The mtu attribute.
    /// </summary>
    [TerraformPropertyName("mtu")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? Mtu { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The owner_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OwnerAccountId is required")]
    [TerraformPropertyName("owner_account_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> OwnerAccountId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The vlan attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Vlan is required")]
    [TerraformPropertyName("vlan")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> Vlan { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsDxHostedTransitVirtualInterfaceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The amazon_side_asn attribute.
    /// </summary>
    [TerraformPropertyName("amazon_side_asn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AmazonSideAsn => new TerraformReference(this, "amazon_side_asn");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The aws_device attribute.
    /// </summary>
    [TerraformPropertyName("aws_device")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AwsDevice => new TerraformReference(this, "aws_device");

    /// <summary>
    /// The jumbo_frame_capable attribute.
    /// </summary>
    [TerraformPropertyName("jumbo_frame_capable")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> JumboFrameCapable => new TerraformReference(this, "jumbo_frame_capable");

}
