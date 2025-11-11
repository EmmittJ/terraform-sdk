using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public partial class AwsNetworkInterfaceDataSourceFilterBlock : TerraformBlockBase
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
public partial class AwsNetworkInterfaceDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a aws_network_interface.
/// </summary>
public partial class AwsNetworkInterfaceDataSource : TerraformDataSource
{
    public AwsNetworkInterfaceDataSource(string name) : base("aws_network_interface", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

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
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("filter")]
    public partial TerraformSet<TerraformBlock<AwsNetworkInterfaceDataSourceFilterBlock>>? Filter { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsNetworkInterfaceDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The association attribute.
    /// </summary>
    [TerraformProperty("association")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Association { get; }

    /// <summary>
    /// The attachment attribute.
    /// </summary>
    [TerraformProperty("attachment")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Attachment { get; }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    [TerraformProperty("availability_zone")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AvailabilityZone { get; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Description { get; }

    /// <summary>
    /// The interface_type attribute.
    /// </summary>
    [TerraformProperty("interface_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> InterfaceType { get; }

    /// <summary>
    /// The ipv6_addresses attribute.
    /// </summary>
    [TerraformProperty("ipv6_addresses")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> Ipv6Addresses { get; }

    /// <summary>
    /// The mac_address attribute.
    /// </summary>
    [TerraformProperty("mac_address")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> MacAddress { get; }

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
    /// The private_dns_name attribute.
    /// </summary>
    [TerraformProperty("private_dns_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrivateDnsName { get; }

    /// <summary>
    /// The private_ip attribute.
    /// </summary>
    [TerraformProperty("private_ip")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrivateIp { get; }

    /// <summary>
    /// The private_ips attribute.
    /// </summary>
    [TerraformProperty("private_ips")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> PrivateIps { get; }

    /// <summary>
    /// The requester_id attribute.
    /// </summary>
    [TerraformProperty("requester_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> RequesterId { get; }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    [TerraformProperty("security_groups")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> SecurityGroups { get; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformProperty("subnet_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SubnetId { get; }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformProperty("vpc_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> VpcId { get; }

}
