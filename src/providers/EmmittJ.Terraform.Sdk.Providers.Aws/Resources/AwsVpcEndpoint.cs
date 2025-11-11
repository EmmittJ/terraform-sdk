using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for dns_options in .
/// Nesting mode: list
/// </summary>
public class AwsVpcEndpointDnsOptionsBlock
{
    /// <summary>
    /// The dns_record_ip_type attribute.
    /// </summary>
    [TerraformPropertyName("dns_record_ip_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> DnsRecordIpType { get; set; } = default!;

    /// <summary>
    /// The private_dns_only_for_inbound_resolver_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("private_dns_only_for_inbound_resolver_endpoint")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? PrivateDnsOnlyForInboundResolverEndpoint { get; set; }

}

/// <summary>
/// Block type for subnet_configuration in .
/// Nesting mode: set
/// </summary>
public class AwsVpcEndpointSubnetConfigurationBlock
{
    /// <summary>
    /// The ipv4 attribute.
    /// </summary>
    [TerraformPropertyName("ipv4")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Ipv4 { get; set; }

    /// <summary>
    /// The ipv6 attribute.
    /// </summary>
    [TerraformPropertyName("ipv6")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Ipv6 { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformPropertyName("subnet_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SubnetId { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsVpcEndpointTimeoutsBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_vpc_endpoint resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsVpcEndpoint : TerraformResource
{
    public AwsVpcEndpoint(string name) : base("aws_vpc_endpoint", name)
    {
    }

    /// <summary>
    /// The auto_accept attribute.
    /// </summary>
    [TerraformPropertyName("auto_accept")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AutoAccept { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    [TerraformPropertyName("ip_address_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> IpAddressType { get; set; } = default!;

    /// <summary>
    /// The policy attribute.
    /// </summary>
    [TerraformPropertyName("policy")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Policy { get; set; } = default!;

    /// <summary>
    /// The private_dns_enabled attribute.
    /// </summary>
    [TerraformPropertyName("private_dns_enabled")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> PrivateDnsEnabled { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The resource_configuration_arn attribute.
    /// </summary>
    [TerraformPropertyName("resource_configuration_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ResourceConfigurationArn { get; set; }

    /// <summary>
    /// The route_table_ids attribute.
    /// </summary>
    [TerraformPropertyName("route_table_ids")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<string> RouteTableIds { get; set; } = default!;

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("security_group_ids")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<string> SecurityGroupIds { get; set; } = default!;

    /// <summary>
    /// The service_name attribute.
    /// </summary>
    [TerraformPropertyName("service_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ServiceName { get; set; }

    /// <summary>
    /// The service_network_arn attribute.
    /// </summary>
    [TerraformPropertyName("service_network_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ServiceNetworkArn { get; set; }

    /// <summary>
    /// The service_region attribute.
    /// </summary>
    [TerraformPropertyName("service_region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ServiceRegion { get; set; } = default!;

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [TerraformPropertyName("subnet_ids")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<string> SubnetIds { get; set; } = default!;

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
    /// The vpc_endpoint_type attribute.
    /// </summary>
    [TerraformPropertyName("vpc_endpoint_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? VpcEndpointType { get; set; }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcId is required")]
    [TerraformPropertyName("vpc_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> VpcId { get; set; }

    /// <summary>
    /// Block for dns_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DnsOptions block(s) allowed")]
    [TerraformPropertyName("dns_options")]
    public TerraformList<TerraformBlock<AwsVpcEndpointDnsOptionsBlock>>? DnsOptions { get; set; }

    /// <summary>
    /// Block for subnet_configuration.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("subnet_configuration")]
    public TerraformSet<TerraformBlock<AwsVpcEndpointSubnetConfigurationBlock>>? SubnetConfiguration { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsVpcEndpointTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The cidr_blocks attribute.
    /// </summary>
    [TerraformPropertyName("cidr_blocks")]
    // Output-only attribute - read-only reference
    public TerraformList<string> CidrBlocks => new TerraformReference(this, "cidr_blocks");

    /// <summary>
    /// The dns_entry attribute.
    /// </summary>
    [TerraformPropertyName("dns_entry")]
    // Output-only attribute - read-only reference
    public TerraformList<object> DnsEntry => new TerraformReference(this, "dns_entry");

    /// <summary>
    /// The network_interface_ids attribute.
    /// </summary>
    [TerraformPropertyName("network_interface_ids")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> NetworkInterfaceIds => new TerraformReference(this, "network_interface_ids");

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformPropertyName("owner_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OwnerId => new TerraformReference(this, "owner_id");

    /// <summary>
    /// The prefix_list_id attribute.
    /// </summary>
    [TerraformPropertyName("prefix_list_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrefixListId => new TerraformReference(this, "prefix_list_id");

    /// <summary>
    /// The requester_managed attribute.
    /// </summary>
    [TerraformPropertyName("requester_managed")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> RequesterManaged => new TerraformReference(this, "requester_managed");

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> State => new TerraformReference(this, "state");

}
