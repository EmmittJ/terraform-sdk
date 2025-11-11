using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsSubnetTimeoutsBlock
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
/// Manages a aws_subnet resource.
/// </summary>
public class AwsSubnet : TerraformResource
{
    public AwsSubnet(string name) : base("aws_subnet", name)
    {
    }

    /// <summary>
    /// The assign_ipv6_address_on_creation attribute.
    /// </summary>
    [TerraformPropertyName("assign_ipv6_address_on_creation")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AssignIpv6AddressOnCreation { get; set; }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    [TerraformPropertyName("availability_zone")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> AvailabilityZone { get; set; } = default!;

    /// <summary>
    /// The availability_zone_id attribute.
    /// </summary>
    [TerraformPropertyName("availability_zone_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> AvailabilityZoneId { get; set; } = default!;

    /// <summary>
    /// The cidr_block attribute.
    /// </summary>
    [TerraformPropertyName("cidr_block")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CidrBlock { get; set; }

    /// <summary>
    /// The customer_owned_ipv4_pool attribute.
    /// </summary>
    [TerraformPropertyName("customer_owned_ipv4_pool")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CustomerOwnedIpv4Pool { get; set; }

    /// <summary>
    /// The enable_dns64 attribute.
    /// </summary>
    [TerraformPropertyName("enable_dns64")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnableDns64 { get; set; }

    /// <summary>
    /// The enable_lni_at_device_index attribute.
    /// </summary>
    [TerraformPropertyName("enable_lni_at_device_index")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? EnableLniAtDeviceIndex { get; set; }

    /// <summary>
    /// The enable_resource_name_dns_a_record_on_launch attribute.
    /// </summary>
    [TerraformPropertyName("enable_resource_name_dns_a_record_on_launch")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnableResourceNameDnsARecordOnLaunch { get; set; }

    /// <summary>
    /// The enable_resource_name_dns_aaaa_record_on_launch attribute.
    /// </summary>
    [TerraformPropertyName("enable_resource_name_dns_aaaa_record_on_launch")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnableResourceNameDnsAaaaRecordOnLaunch { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The ipv6_cidr_block attribute.
    /// </summary>
    [TerraformPropertyName("ipv6_cidr_block")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Ipv6CidrBlock { get; set; }

    /// <summary>
    /// The ipv6_native attribute.
    /// </summary>
    [TerraformPropertyName("ipv6_native")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Ipv6Native { get; set; }

    /// <summary>
    /// The map_customer_owned_ip_on_launch attribute.
    /// </summary>
    [TerraformPropertyName("map_customer_owned_ip_on_launch")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? MapCustomerOwnedIpOnLaunch { get; set; }

    /// <summary>
    /// The map_public_ip_on_launch attribute.
    /// </summary>
    [TerraformPropertyName("map_public_ip_on_launch")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? MapPublicIpOnLaunch { get; set; }

    /// <summary>
    /// The outpost_arn attribute.
    /// </summary>
    [TerraformPropertyName("outpost_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? OutpostArn { get; set; }

    /// <summary>
    /// The private_dns_hostname_type_on_launch attribute.
    /// </summary>
    [TerraformPropertyName("private_dns_hostname_type_on_launch")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> PrivateDnsHostnameTypeOnLaunch { get; set; } = default!;

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
    /// The vpc_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcId is required")]
    [TerraformPropertyName("vpc_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> VpcId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsSubnetTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The ipv6_cidr_block_association_id attribute.
    /// </summary>
    [TerraformPropertyName("ipv6_cidr_block_association_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Ipv6CidrBlockAssociationId => new TerraformReference(this, "ipv6_cidr_block_association_id");

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformPropertyName("owner_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OwnerId => new TerraformReference(this, "owner_id");

}
