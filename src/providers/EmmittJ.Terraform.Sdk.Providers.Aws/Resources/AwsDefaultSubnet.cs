using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsDefaultSubnetTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

}

/// <summary>
/// Manages a aws_default_subnet resource.
/// </summary>
public partial class AwsDefaultSubnet : TerraformResource
{
    public AwsDefaultSubnet(string name) : base("aws_default_subnet", name)
    {
    }

    /// <summary>
    /// The assign_ipv6_address_on_creation attribute.
    /// </summary>
    [TerraformProperty("assign_ipv6_address_on_creation")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AssignIpv6AddressOnCreation { get; set; }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AvailabilityZone is required")]
    [TerraformProperty("availability_zone")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AvailabilityZone { get; set; }

    /// <summary>
    /// The customer_owned_ipv4_pool attribute.
    /// </summary>
    [TerraformProperty("customer_owned_ipv4_pool")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CustomerOwnedIpv4Pool { get; set; }

    /// <summary>
    /// The enable_dns64 attribute.
    /// </summary>
    [TerraformProperty("enable_dns64")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableDns64 { get; set; }

    /// <summary>
    /// The enable_resource_name_dns_a_record_on_launch attribute.
    /// </summary>
    [TerraformProperty("enable_resource_name_dns_a_record_on_launch")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableResourceNameDnsARecordOnLaunch { get; set; }

    /// <summary>
    /// The enable_resource_name_dns_aaaa_record_on_launch attribute.
    /// </summary>
    [TerraformProperty("enable_resource_name_dns_aaaa_record_on_launch")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableResourceNameDnsAaaaRecordOnLaunch { get; set; }

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    [TerraformProperty("force_destroy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ForceDestroy { get; set; }

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
    /// The ipv6_native attribute.
    /// </summary>
    [TerraformProperty("ipv6_native")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Ipv6Native { get; set; }

    /// <summary>
    /// The map_customer_owned_ip_on_launch attribute.
    /// </summary>
    [TerraformProperty("map_customer_owned_ip_on_launch")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? MapCustomerOwnedIpOnLaunch { get; set; }

    /// <summary>
    /// The map_public_ip_on_launch attribute.
    /// </summary>
    [TerraformProperty("map_public_ip_on_launch")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? MapPublicIpOnLaunch { get; set; }

    /// <summary>
    /// The private_dns_hostname_type_on_launch attribute.
    /// </summary>
    [TerraformProperty("private_dns_hostname_type_on_launch")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> PrivateDnsHostnameTypeOnLaunch { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsDefaultSubnetTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The availability_zone_id attribute.
    /// </summary>
    [TerraformProperty("availability_zone_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AvailabilityZoneId { get; }

    /// <summary>
    /// The cidr_block attribute.
    /// </summary>
    [TerraformProperty("cidr_block")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CidrBlock { get; }

    /// <summary>
    /// The enable_lni_at_device_index attribute.
    /// </summary>
    [TerraformProperty("enable_lni_at_device_index")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> EnableLniAtDeviceIndex { get; }

    /// <summary>
    /// The existing_default_subnet attribute.
    /// </summary>
    [TerraformProperty("existing_default_subnet")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> ExistingDefaultSubnet { get; }

    /// <summary>
    /// The ipv6_cidr_block_association_id attribute.
    /// </summary>
    [TerraformProperty("ipv6_cidr_block_association_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Ipv6CidrBlockAssociationId { get; }

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
    /// The vpc_id attribute.
    /// </summary>
    [TerraformProperty("vpc_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> VpcId { get; }

}
