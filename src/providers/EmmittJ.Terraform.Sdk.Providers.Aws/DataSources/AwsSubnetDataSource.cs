using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public partial class AwsSubnetDataSourceFilterBlock : TerraformBlockBase
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    [TerraformProperty("values")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> Values { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsSubnetDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a aws_subnet.
/// </summary>
public partial class AwsSubnetDataSource : TerraformDataSource
{
    public AwsSubnetDataSource(string name) : base("aws_subnet", name)
    {
    }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    [TerraformProperty("availability_zone")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> AvailabilityZone { get; set; }

    /// <summary>
    /// The availability_zone_id attribute.
    /// </summary>
    [TerraformProperty("availability_zone_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> AvailabilityZoneId { get; set; }

    /// <summary>
    /// The cidr_block attribute.
    /// </summary>
    [TerraformProperty("cidr_block")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> CidrBlock { get; set; }

    /// <summary>
    /// The default_for_az attribute.
    /// </summary>
    [TerraformProperty("default_for_az")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> DefaultForAz { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The ipv6_cidr_block attribute.
    /// </summary>
    [TerraformProperty("ipv6_cidr_block")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Ipv6CidrBlock { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformProperty("state")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> State { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformProperty("vpc_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> VpcId { get; set; }

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("filter")]
    public partial TerraformSet<TerraformBlock<AwsSubnetDataSourceFilterBlock>>? Filter { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsSubnetDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The assign_ipv6_address_on_creation attribute.
    /// </summary>
    [TerraformProperty("assign_ipv6_address_on_creation")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> AssignIpv6AddressOnCreation { get; }

    /// <summary>
    /// The available_ip_address_count attribute.
    /// </summary>
    [TerraformProperty("available_ip_address_count")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> AvailableIpAddressCount { get; }

    /// <summary>
    /// The customer_owned_ipv4_pool attribute.
    /// </summary>
    [TerraformProperty("customer_owned_ipv4_pool")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CustomerOwnedIpv4Pool { get; }

    /// <summary>
    /// The enable_dns64 attribute.
    /// </summary>
    [TerraformProperty("enable_dns64")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> EnableDns64 { get; }

    /// <summary>
    /// The enable_lni_at_device_index attribute.
    /// </summary>
    [TerraformProperty("enable_lni_at_device_index")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> EnableLniAtDeviceIndex { get; }

    /// <summary>
    /// The enable_resource_name_dns_a_record_on_launch attribute.
    /// </summary>
    [TerraformProperty("enable_resource_name_dns_a_record_on_launch")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> EnableResourceNameDnsARecordOnLaunch { get; }

    /// <summary>
    /// The enable_resource_name_dns_aaaa_record_on_launch attribute.
    /// </summary>
    [TerraformProperty("enable_resource_name_dns_aaaa_record_on_launch")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> EnableResourceNameDnsAaaaRecordOnLaunch { get; }

    /// <summary>
    /// The ipv6_cidr_block_association_id attribute.
    /// </summary>
    [TerraformProperty("ipv6_cidr_block_association_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Ipv6CidrBlockAssociationId { get; }

    /// <summary>
    /// The ipv6_native attribute.
    /// </summary>
    [TerraformProperty("ipv6_native")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> Ipv6Native { get; }

    /// <summary>
    /// The map_customer_owned_ip_on_launch attribute.
    /// </summary>
    [TerraformProperty("map_customer_owned_ip_on_launch")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> MapCustomerOwnedIpOnLaunch { get; }

    /// <summary>
    /// The map_public_ip_on_launch attribute.
    /// </summary>
    [TerraformProperty("map_public_ip_on_launch")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> MapPublicIpOnLaunch { get; }

    /// <summary>
    /// The outpost_arn attribute.
    /// </summary>
    [TerraformProperty("outpost_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OutpostArn { get; }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformProperty("owner_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OwnerId { get; }

    /// <summary>
    /// The private_dns_hostname_type_on_launch attribute.
    /// </summary>
    [TerraformProperty("private_dns_hostname_type_on_launch")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrivateDnsHostnameTypeOnLaunch { get; }

}
