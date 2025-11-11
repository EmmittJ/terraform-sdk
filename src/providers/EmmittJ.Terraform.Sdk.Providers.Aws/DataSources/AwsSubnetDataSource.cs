using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsSubnetDataSourceFilterBlock
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
public class AwsSubnetDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a aws_subnet.
/// </summary>
public class AwsSubnetDataSource : TerraformDataSource
{
    public AwsSubnetDataSource(string name) : base("aws_subnet", name)
    {
    }

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
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> CidrBlock { get; set; } = default!;

    /// <summary>
    /// The default_for_az attribute.
    /// </summary>
    [TerraformPropertyName("default_for_az")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> DefaultForAz { get; set; } = default!;

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
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Ipv6CidrBlock { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformPropertyName("state")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> State { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Tags { get; set; } = default!;

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformPropertyName("vpc_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> VpcId { get; set; } = default!;

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("filter")]
    public TerraformSet<TerraformBlock<AwsSubnetDataSourceFilterBlock>>? Filter { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsSubnetDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The assign_ipv6_address_on_creation attribute.
    /// </summary>
    [TerraformPropertyName("assign_ipv6_address_on_creation")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> AssignIpv6AddressOnCreation => new TerraformReference(this, "assign_ipv6_address_on_creation");

    /// <summary>
    /// The available_ip_address_count attribute.
    /// </summary>
    [TerraformPropertyName("available_ip_address_count")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> AvailableIpAddressCount => new TerraformReference(this, "available_ip_address_count");

    /// <summary>
    /// The customer_owned_ipv4_pool attribute.
    /// </summary>
    [TerraformPropertyName("customer_owned_ipv4_pool")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CustomerOwnedIpv4Pool => new TerraformReference(this, "customer_owned_ipv4_pool");

    /// <summary>
    /// The enable_dns64 attribute.
    /// </summary>
    [TerraformPropertyName("enable_dns64")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> EnableDns64 => new TerraformReference(this, "enable_dns64");

    /// <summary>
    /// The enable_lni_at_device_index attribute.
    /// </summary>
    [TerraformPropertyName("enable_lni_at_device_index")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> EnableLniAtDeviceIndex => new TerraformReference(this, "enable_lni_at_device_index");

    /// <summary>
    /// The enable_resource_name_dns_a_record_on_launch attribute.
    /// </summary>
    [TerraformPropertyName("enable_resource_name_dns_a_record_on_launch")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> EnableResourceNameDnsARecordOnLaunch => new TerraformReference(this, "enable_resource_name_dns_a_record_on_launch");

    /// <summary>
    /// The enable_resource_name_dns_aaaa_record_on_launch attribute.
    /// </summary>
    [TerraformPropertyName("enable_resource_name_dns_aaaa_record_on_launch")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> EnableResourceNameDnsAaaaRecordOnLaunch => new TerraformReference(this, "enable_resource_name_dns_aaaa_record_on_launch");

    /// <summary>
    /// The ipv6_cidr_block_association_id attribute.
    /// </summary>
    [TerraformPropertyName("ipv6_cidr_block_association_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Ipv6CidrBlockAssociationId => new TerraformReference(this, "ipv6_cidr_block_association_id");

    /// <summary>
    /// The ipv6_native attribute.
    /// </summary>
    [TerraformPropertyName("ipv6_native")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> Ipv6Native => new TerraformReference(this, "ipv6_native");

    /// <summary>
    /// The map_customer_owned_ip_on_launch attribute.
    /// </summary>
    [TerraformPropertyName("map_customer_owned_ip_on_launch")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> MapCustomerOwnedIpOnLaunch => new TerraformReference(this, "map_customer_owned_ip_on_launch");

    /// <summary>
    /// The map_public_ip_on_launch attribute.
    /// </summary>
    [TerraformPropertyName("map_public_ip_on_launch")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> MapPublicIpOnLaunch => new TerraformReference(this, "map_public_ip_on_launch");

    /// <summary>
    /// The outpost_arn attribute.
    /// </summary>
    [TerraformPropertyName("outpost_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OutpostArn => new TerraformReference(this, "outpost_arn");

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformPropertyName("owner_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OwnerId => new TerraformReference(this, "owner_id");

    /// <summary>
    /// The private_dns_hostname_type_on_launch attribute.
    /// </summary>
    [TerraformPropertyName("private_dns_hostname_type_on_launch")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrivateDnsHostnameTypeOnLaunch => new TerraformReference(this, "private_dns_hostname_type_on_launch");

}
