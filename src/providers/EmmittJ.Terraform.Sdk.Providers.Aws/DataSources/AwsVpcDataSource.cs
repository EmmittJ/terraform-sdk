using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsVpcDataSourceFilterBlock : ITerraformBlock
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
public class AwsVpcDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a aws_vpc.
/// </summary>
public class AwsVpcDataSource : TerraformDataSource
{
    public AwsVpcDataSource(string name) : base("aws_vpc", name)
    {
    }

    /// <summary>
    /// The cidr_block attribute.
    /// </summary>
    [TerraformPropertyName("cidr_block")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> CidrBlock { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "cidr_block");

    /// <summary>
    /// The default attribute.
    /// </summary>
    [TerraformPropertyName("default")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> Default { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "default");

    /// <summary>
    /// The dhcp_options_id attribute.
    /// </summary>
    [TerraformPropertyName("dhcp_options_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DhcpOptionsId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "dhcp_options_id");

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
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("filter")]
    public TerraformSet<TerraformBlock<AwsVpcDataSourceFilterBlock>>? Filter { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsVpcDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The cidr_block_associations attribute.
    /// </summary>
    [TerraformPropertyName("cidr_block_associations")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> CidrBlockAssociations => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "cidr_block_associations");

    /// <summary>
    /// The enable_dns_hostnames attribute.
    /// </summary>
    [TerraformPropertyName("enable_dns_hostnames")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> EnableDnsHostnames => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "enable_dns_hostnames");

    /// <summary>
    /// The enable_dns_support attribute.
    /// </summary>
    [TerraformPropertyName("enable_dns_support")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> EnableDnsSupport => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "enable_dns_support");

    /// <summary>
    /// The enable_network_address_usage_metrics attribute.
    /// </summary>
    [TerraformPropertyName("enable_network_address_usage_metrics")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> EnableNetworkAddressUsageMetrics => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "enable_network_address_usage_metrics");

    /// <summary>
    /// The instance_tenancy attribute.
    /// </summary>
    [TerraformPropertyName("instance_tenancy")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> InstanceTenancy => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "instance_tenancy");

    /// <summary>
    /// The ipv6_association_id attribute.
    /// </summary>
    [TerraformPropertyName("ipv6_association_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Ipv6AssociationId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ipv6_association_id");

    /// <summary>
    /// The ipv6_cidr_block attribute.
    /// </summary>
    [TerraformPropertyName("ipv6_cidr_block")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Ipv6CidrBlock => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ipv6_cidr_block");

    /// <summary>
    /// The main_route_table_id attribute.
    /// </summary>
    [TerraformPropertyName("main_route_table_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> MainRouteTableId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "main_route_table_id");

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformPropertyName("owner_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OwnerId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "owner_id");

}
