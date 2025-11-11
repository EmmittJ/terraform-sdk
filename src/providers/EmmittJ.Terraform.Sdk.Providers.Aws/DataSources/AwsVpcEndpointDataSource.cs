using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public partial class AwsVpcEndpointDataSourceFilterBlock : TerraformBlockBase
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
public partial class AwsVpcEndpointDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a aws_vpc_endpoint.
/// </summary>
public partial class AwsVpcEndpointDataSource : TerraformDataSource
{
    public AwsVpcEndpointDataSource(string name) : base("aws_vpc_endpoint", name)
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
    /// The service_name attribute.
    /// </summary>
    [TerraformProperty("service_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ServiceName { get; set; }

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
    public partial TerraformSet<TerraformBlock<AwsVpcEndpointDataSourceFilterBlock>>? Filter { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsVpcEndpointDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The cidr_blocks attribute.
    /// </summary>
    [TerraformProperty("cidr_blocks")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> CidrBlocks { get; }

    /// <summary>
    /// The dns_entry attribute.
    /// </summary>
    [TerraformProperty("dns_entry")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> DnsEntry { get; }

    /// <summary>
    /// The dns_options attribute.
    /// </summary>
    [TerraformProperty("dns_options")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> DnsOptions { get; }

    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    [TerraformProperty("ip_address_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> IpAddressType { get; }

    /// <summary>
    /// The network_interface_ids attribute.
    /// </summary>
    [TerraformProperty("network_interface_ids")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> NetworkInterfaceIds { get; }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformProperty("owner_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OwnerId { get; }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    [TerraformProperty("policy")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Policy { get; }

    /// <summary>
    /// The prefix_list_id attribute.
    /// </summary>
    [TerraformProperty("prefix_list_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrefixListId { get; }

    /// <summary>
    /// The private_dns_enabled attribute.
    /// </summary>
    [TerraformProperty("private_dns_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> PrivateDnsEnabled { get; }

    /// <summary>
    /// The requester_managed attribute.
    /// </summary>
    [TerraformProperty("requester_managed")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> RequesterManaged { get; }

    /// <summary>
    /// The route_table_ids attribute.
    /// </summary>
    [TerraformProperty("route_table_ids")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> RouteTableIds { get; }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [TerraformProperty("security_group_ids")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> SecurityGroupIds { get; }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [TerraformProperty("subnet_ids")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> SubnetIds { get; }

    /// <summary>
    /// The vpc_endpoint_type attribute.
    /// </summary>
    [TerraformProperty("vpc_endpoint_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> VpcEndpointType { get; }

}
