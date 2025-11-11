using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for dns_options in .
/// Nesting mode: list
/// </summary>
public partial class AwsVpcEndpointDnsOptionsBlock : TerraformBlockBase
{
    /// <summary>
    /// The dns_record_ip_type attribute.
    /// </summary>
    [TerraformProperty("dns_record_ip_type")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> DnsRecordIpType { get; set; }

    /// <summary>
    /// The private_dns_only_for_inbound_resolver_endpoint attribute.
    /// </summary>
    [TerraformProperty("private_dns_only_for_inbound_resolver_endpoint")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? PrivateDnsOnlyForInboundResolverEndpoint { get; set; }

}

/// <summary>
/// Block type for subnet_configuration in .
/// Nesting mode: set
/// </summary>
public partial class AwsVpcEndpointSubnetConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The ipv4 attribute.
    /// </summary>
    [TerraformProperty("ipv4")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Ipv4 { get; set; }

    /// <summary>
    /// The ipv6 attribute.
    /// </summary>
    [TerraformProperty("ipv6")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Ipv6 { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformProperty("subnet_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SubnetId { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsVpcEndpointTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_vpc_endpoint resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsVpcEndpoint : TerraformResource
{
    public AwsVpcEndpoint(string name) : base("aws_vpc_endpoint", name)
    {
    }

    /// <summary>
    /// The auto_accept attribute.
    /// </summary>
    [TerraformProperty("auto_accept")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? AutoAccept { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    [TerraformProperty("ip_address_type")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> IpAddressType { get; set; }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    [TerraformProperty("policy")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Policy { get; set; }

    /// <summary>
    /// The private_dns_enabled attribute.
    /// </summary>
    [TerraformProperty("private_dns_enabled")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> PrivateDnsEnabled { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The resource_configuration_arn attribute.
    /// </summary>
    [TerraformProperty("resource_configuration_arn")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ResourceConfigurationArn { get; set; }

    /// <summary>
    /// The route_table_ids attribute.
    /// </summary>
    [TerraformProperty("route_table_ids")]
    // Optional+Computed - source generator will implement get/set
    public TerraformSet<string> RouteTableIds { get; set; }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [TerraformProperty("security_group_ids")]
    // Optional+Computed - source generator will implement get/set
    public TerraformSet<string> SecurityGroupIds { get; set; }

    /// <summary>
    /// The service_name attribute.
    /// </summary>
    [TerraformProperty("service_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ServiceName { get; set; }

    /// <summary>
    /// The service_network_arn attribute.
    /// </summary>
    [TerraformProperty("service_network_arn")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ServiceNetworkArn { get; set; }

    /// <summary>
    /// The service_region attribute.
    /// </summary>
    [TerraformProperty("service_region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ServiceRegion { get; set; }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [TerraformProperty("subnet_ids")]
    // Optional+Computed - source generator will implement get/set
    public TerraformSet<string> SubnetIds { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The vpc_endpoint_type attribute.
    /// </summary>
    [TerraformProperty("vpc_endpoint_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? VpcEndpointType { get; set; }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcId is required")]
    [TerraformProperty("vpc_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> VpcId { get; set; }

    /// <summary>
    /// Block for dns_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DnsOptions block(s) allowed")]
    [TerraformProperty("dns_options")]
    public TerraformList<TerraformBlock<AwsVpcEndpointDnsOptionsBlock>>? DnsOptions { get; set; }

    /// <summary>
    /// Block for subnet_configuration.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("subnet_configuration")]
    public TerraformSet<TerraformBlock<AwsVpcEndpointSubnetConfigurationBlock>>? SubnetConfiguration { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AwsVpcEndpointTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The cidr_blocks attribute.
    /// </summary>
    [TerraformProperty("cidr_blocks")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> CidrBlocks { get; }

    /// <summary>
    /// The dns_entry attribute.
    /// </summary>
    [TerraformProperty("dns_entry")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> DnsEntry { get; }

    /// <summary>
    /// The network_interface_ids attribute.
    /// </summary>
    [TerraformProperty("network_interface_ids")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<string> NetworkInterfaceIds { get; }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformProperty("owner_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> OwnerId { get; }

    /// <summary>
    /// The prefix_list_id attribute.
    /// </summary>
    [TerraformProperty("prefix_list_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PrefixListId { get; }

    /// <summary>
    /// The requester_managed attribute.
    /// </summary>
    [TerraformProperty("requester_managed")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> RequesterManaged { get; }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> State { get; }

}
