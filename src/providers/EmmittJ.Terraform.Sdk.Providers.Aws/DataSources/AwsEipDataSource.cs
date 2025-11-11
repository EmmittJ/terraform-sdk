using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsEipDataSourceFilterBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    [TerraformPropertyName("values")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> Values { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsEipDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a aws_eip.
/// </summary>
public class AwsEipDataSource : TerraformDataSource
{
    public AwsEipDataSource(string name) : base("aws_eip", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The public_ip attribute.
    /// </summary>
    [TerraformPropertyName("public_ip")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> PublicIp { get; set; } = default!;

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
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Tags { get; set; } = default!;

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("filter")]
    public TerraformSet<TerraformBlock<AwsEipDataSourceFilterBlock>>? Filter { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsEipDataSourceTimeoutsBlock>? Timeouts { get; set; }

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
    /// The customer_owned_ipv4_pool attribute.
    /// </summary>
    [TerraformPropertyName("customer_owned_ipv4_pool")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CustomerOwnedIpv4Pool => new TerraformReference(this, "customer_owned_ipv4_pool");

    /// <summary>
    /// The domain attribute.
    /// </summary>
    [TerraformPropertyName("domain")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Domain => new TerraformReference(this, "domain");

    /// <summary>
    /// The instance_id attribute.
    /// </summary>
    [TerraformPropertyName("instance_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> InstanceId => new TerraformReference(this, "instance_id");

    /// <summary>
    /// The ipam_pool_id attribute.
    /// </summary>
    [TerraformPropertyName("ipam_pool_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> IpamPoolId => new TerraformReference(this, "ipam_pool_id");

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    [TerraformPropertyName("network_interface_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> NetworkInterfaceId => new TerraformReference(this, "network_interface_id");

    /// <summary>
    /// The network_interface_owner_id attribute.
    /// </summary>
    [TerraformPropertyName("network_interface_owner_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> NetworkInterfaceOwnerId => new TerraformReference(this, "network_interface_owner_id");

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
    /// The public_ipv4_pool attribute.
    /// </summary>
    [TerraformPropertyName("public_ipv4_pool")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PublicIpv4Pool => new TerraformReference(this, "public_ipv4_pool");

}
