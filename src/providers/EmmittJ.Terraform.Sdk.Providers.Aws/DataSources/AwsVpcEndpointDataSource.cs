using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsVpcEndpointDataSourceFilterBlock : ITerraformBlock
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
public class AwsVpcEndpointDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a aws_vpc_endpoint.
/// </summary>
public class AwsVpcEndpointDataSource : TerraformDataSource
{
    public AwsVpcEndpointDataSource(string name) : base("aws_vpc_endpoint", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The service_name attribute.
    /// </summary>
    [TerraformPropertyName("service_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ServiceName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "service_name");

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
    public TerraformSet<TerraformBlock<AwsVpcEndpointDataSourceFilterBlock>>? Filter { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsVpcEndpointDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The cidr_blocks attribute.
    /// </summary>
    [TerraformPropertyName("cidr_blocks")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> CidrBlocks => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "cidr_blocks");

    /// <summary>
    /// The dns_entry attribute.
    /// </summary>
    [TerraformPropertyName("dns_entry")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> DnsEntry => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "dns_entry");

    /// <summary>
    /// The dns_options attribute.
    /// </summary>
    [TerraformPropertyName("dns_options")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> DnsOptions => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "dns_options");

    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    [TerraformPropertyName("ip_address_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> IpAddressType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ip_address_type");

    /// <summary>
    /// The network_interface_ids attribute.
    /// </summary>
    [TerraformPropertyName("network_interface_ids")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> NetworkInterfaceIds => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "network_interface_ids");

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformPropertyName("owner_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OwnerId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "owner_id");

    /// <summary>
    /// The policy attribute.
    /// </summary>
    [TerraformPropertyName("policy")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Policy => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "policy");

    /// <summary>
    /// The prefix_list_id attribute.
    /// </summary>
    [TerraformPropertyName("prefix_list_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrefixListId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "prefix_list_id");

    /// <summary>
    /// The private_dns_enabled attribute.
    /// </summary>
    [TerraformPropertyName("private_dns_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> PrivateDnsEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "private_dns_enabled");

    /// <summary>
    /// The requester_managed attribute.
    /// </summary>
    [TerraformPropertyName("requester_managed")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> RequesterManaged => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "requester_managed");

    /// <summary>
    /// The route_table_ids attribute.
    /// </summary>
    [TerraformPropertyName("route_table_ids")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> RouteTableIds => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "route_table_ids");

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("security_group_ids")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> SecurityGroupIds => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "security_group_ids");

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [TerraformPropertyName("subnet_ids")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> SubnetIds => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "subnet_ids");

    /// <summary>
    /// The vpc_endpoint_type attribute.
    /// </summary>
    [TerraformPropertyName("vpc_endpoint_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VpcEndpointType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "vpc_endpoint_type");

}
