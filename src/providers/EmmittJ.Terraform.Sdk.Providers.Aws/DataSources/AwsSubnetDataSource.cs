using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsSubnetDataSourceFilterBlock : ITerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    [TerraformPropertyName("values")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Values { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsSubnetDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AvailabilityZone { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "availability_zone");

    /// <summary>
    /// The availability_zone_id attribute.
    /// </summary>
    [TerraformPropertyName("availability_zone_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AvailabilityZoneId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "availability_zone_id");

    /// <summary>
    /// The cidr_block attribute.
    /// </summary>
    [TerraformPropertyName("cidr_block")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> CidrBlock { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "cidr_block");

    /// <summary>
    /// The default_for_az attribute.
    /// </summary>
    [TerraformPropertyName("default_for_az")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> DefaultForAz { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "default_for_az");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The ipv6_cidr_block attribute.
    /// </summary>
    [TerraformPropertyName("ipv6_cidr_block")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Ipv6CidrBlock { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ipv6_cidr_block");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformPropertyName("state")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> State { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformPropertyName("vpc_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> VpcId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "vpc_id");

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("filter")]
    public TerraformSet<TerraformBlock<AwsSubnetDataSourceFilterBlock>>? Filter { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsSubnetDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The assign_ipv6_address_on_creation attribute.
    /// </summary>
    [TerraformPropertyName("assign_ipv6_address_on_creation")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> AssignIpv6AddressOnCreation => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "assign_ipv6_address_on_creation");

    /// <summary>
    /// The available_ip_address_count attribute.
    /// </summary>
    [TerraformPropertyName("available_ip_address_count")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> AvailableIpAddressCount => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "available_ip_address_count");

    /// <summary>
    /// The customer_owned_ipv4_pool attribute.
    /// </summary>
    [TerraformPropertyName("customer_owned_ipv4_pool")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CustomerOwnedIpv4Pool => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "customer_owned_ipv4_pool");

    /// <summary>
    /// The enable_dns64 attribute.
    /// </summary>
    [TerraformPropertyName("enable_dns64")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> EnableDns64 => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "enable_dns64");

    /// <summary>
    /// The enable_lni_at_device_index attribute.
    /// </summary>
    [TerraformPropertyName("enable_lni_at_device_index")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> EnableLniAtDeviceIndex => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "enable_lni_at_device_index");

    /// <summary>
    /// The enable_resource_name_dns_a_record_on_launch attribute.
    /// </summary>
    [TerraformPropertyName("enable_resource_name_dns_a_record_on_launch")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> EnableResourceNameDnsARecordOnLaunch => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "enable_resource_name_dns_a_record_on_launch");

    /// <summary>
    /// The enable_resource_name_dns_aaaa_record_on_launch attribute.
    /// </summary>
    [TerraformPropertyName("enable_resource_name_dns_aaaa_record_on_launch")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> EnableResourceNameDnsAaaaRecordOnLaunch => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "enable_resource_name_dns_aaaa_record_on_launch");

    /// <summary>
    /// The ipv6_cidr_block_association_id attribute.
    /// </summary>
    [TerraformPropertyName("ipv6_cidr_block_association_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Ipv6CidrBlockAssociationId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ipv6_cidr_block_association_id");

    /// <summary>
    /// The ipv6_native attribute.
    /// </summary>
    [TerraformPropertyName("ipv6_native")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> Ipv6Native => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "ipv6_native");

    /// <summary>
    /// The map_customer_owned_ip_on_launch attribute.
    /// </summary>
    [TerraformPropertyName("map_customer_owned_ip_on_launch")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> MapCustomerOwnedIpOnLaunch => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "map_customer_owned_ip_on_launch");

    /// <summary>
    /// The map_public_ip_on_launch attribute.
    /// </summary>
    [TerraformPropertyName("map_public_ip_on_launch")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> MapPublicIpOnLaunch => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "map_public_ip_on_launch");

    /// <summary>
    /// The outpost_arn attribute.
    /// </summary>
    [TerraformPropertyName("outpost_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OutpostArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "outpost_arn");

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformPropertyName("owner_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OwnerId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "owner_id");

    /// <summary>
    /// The private_dns_hostname_type_on_launch attribute.
    /// </summary>
    [TerraformPropertyName("private_dns_hostname_type_on_launch")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrivateDnsHostnameTypeOnLaunch => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "private_dns_hostname_type_on_launch");

}
