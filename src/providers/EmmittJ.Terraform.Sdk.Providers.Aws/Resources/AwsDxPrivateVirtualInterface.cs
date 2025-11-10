using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsDxPrivateVirtualInterfaceTimeoutsBlock : ITerraformBlock
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
/// Manages a aws_dx_private_virtual_interface resource.
/// </summary>
public class AwsDxPrivateVirtualInterface : TerraformResource
{
    public AwsDxPrivateVirtualInterface(string name) : base("aws_dx_private_virtual_interface", name)
    {
    }

    /// <summary>
    /// The address_family attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AddressFamily is required")]
    [TerraformPropertyName("address_family")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AddressFamily { get; set; }

    /// <summary>
    /// The amazon_address attribute.
    /// </summary>
    [TerraformPropertyName("amazon_address")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AmazonAddress { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "amazon_address");

    /// <summary>
    /// The bgp_asn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BgpAsn is required")]
    [TerraformPropertyName("bgp_asn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> BgpAsn { get; set; }

    /// <summary>
    /// The bgp_auth_key attribute.
    /// </summary>
    [TerraformPropertyName("bgp_auth_key")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> BgpAuthKey { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "bgp_auth_key");

    /// <summary>
    /// The connection_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionId is required")]
    [TerraformPropertyName("connection_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ConnectionId { get; set; }

    /// <summary>
    /// The customer_address attribute.
    /// </summary>
    [TerraformPropertyName("customer_address")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> CustomerAddress { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "customer_address");

    /// <summary>
    /// The dx_gateway_id attribute.
    /// </summary>
    [TerraformPropertyName("dx_gateway_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DxGatewayId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The mtu attribute.
    /// </summary>
    [TerraformPropertyName("mtu")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Mtu { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The sitelink_enabled attribute.
    /// </summary>
    [TerraformPropertyName("sitelink_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? SitelinkEnabled { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// The vlan attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Vlan is required")]
    [TerraformPropertyName("vlan")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> Vlan { get; set; }

    /// <summary>
    /// The vpn_gateway_id attribute.
    /// </summary>
    [TerraformPropertyName("vpn_gateway_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? VpnGatewayId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsDxPrivateVirtualInterfaceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The amazon_side_asn attribute.
    /// </summary>
    [TerraformPropertyName("amazon_side_asn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AmazonSideAsn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "amazon_side_asn");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The aws_device attribute.
    /// </summary>
    [TerraformPropertyName("aws_device")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AwsDevice => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "aws_device");

    /// <summary>
    /// The jumbo_frame_capable attribute.
    /// </summary>
    [TerraformPropertyName("jumbo_frame_capable")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> JumboFrameCapable => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "jumbo_frame_capable");

}
