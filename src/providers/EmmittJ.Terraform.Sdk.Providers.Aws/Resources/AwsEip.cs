using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsEipTimeoutsBlock
{
    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_eip resource.
/// </summary>
public class AwsEip : TerraformResource
{
    public AwsEip(string name) : base("aws_eip", name)
    {
    }

    /// <summary>
    /// The address attribute.
    /// </summary>
    [TerraformPropertyName("address")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Address { get; set; }

    /// <summary>
    /// The associate_with_private_ip attribute.
    /// </summary>
    [TerraformPropertyName("associate_with_private_ip")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AssociateWithPrivateIp { get; set; }

    /// <summary>
    /// The customer_owned_ipv4_pool attribute.
    /// </summary>
    [TerraformPropertyName("customer_owned_ipv4_pool")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CustomerOwnedIpv4Pool { get; set; }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    [TerraformPropertyName("domain")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Domain { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The instance attribute.
    /// </summary>
    [TerraformPropertyName("instance")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Instance { get; set; } = default!;

    /// <summary>
    /// The ipam_pool_id attribute.
    /// </summary>
    [TerraformPropertyName("ipam_pool_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> IpamPoolId { get; set; } = default!;

    /// <summary>
    /// The network_border_group attribute.
    /// </summary>
    [TerraformPropertyName("network_border_group")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> NetworkBorderGroup { get; set; } = default!;

    /// <summary>
    /// The network_interface attribute.
    /// </summary>
    [TerraformPropertyName("network_interface")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> NetworkInterface { get; set; } = default!;

    /// <summary>
    /// The public_ipv4_pool attribute.
    /// </summary>
    [TerraformPropertyName("public_ipv4_pool")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> PublicIpv4Pool { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsEipTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The allocation_id attribute.
    /// </summary>
    [TerraformPropertyName("allocation_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AllocationId => new TerraformReference(this, "allocation_id");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The association_id attribute.
    /// </summary>
    [TerraformPropertyName("association_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AssociationId => new TerraformReference(this, "association_id");

    /// <summary>
    /// The carrier_ip attribute.
    /// </summary>
    [TerraformPropertyName("carrier_ip")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CarrierIp => new TerraformReference(this, "carrier_ip");

    /// <summary>
    /// The customer_owned_ip attribute.
    /// </summary>
    [TerraformPropertyName("customer_owned_ip")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CustomerOwnedIp => new TerraformReference(this, "customer_owned_ip");

    /// <summary>
    /// The private_dns attribute.
    /// </summary>
    [TerraformPropertyName("private_dns")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrivateDns => new TerraformReference(this, "private_dns");

    /// <summary>
    /// The private_ip attribute.
    /// </summary>
    [TerraformPropertyName("private_ip")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrivateIp => new TerraformReference(this, "private_ip");

    /// <summary>
    /// The ptr_record attribute.
    /// </summary>
    [TerraformPropertyName("ptr_record")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PtrRecord => new TerraformReference(this, "ptr_record");

    /// <summary>
    /// The public_dns attribute.
    /// </summary>
    [TerraformPropertyName("public_dns")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PublicDns => new TerraformReference(this, "public_dns");

    /// <summary>
    /// The public_ip attribute.
    /// </summary>
    [TerraformPropertyName("public_ip")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PublicIp => new TerraformReference(this, "public_ip");

}
