using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsVpcDhcpOptionsDataSourceFilterBlock : ITerraformBlock
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
public class AwsVpcDhcpOptionsDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a aws_vpc_dhcp_options.
/// </summary>
public class AwsVpcDhcpOptionsDataSource : TerraformDataSource
{
    public AwsVpcDhcpOptionsDataSource(string name) : base("aws_vpc_dhcp_options", name)
    {
    }

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
    public TerraformSet<TerraformBlock<AwsVpcDhcpOptionsDataSourceFilterBlock>>? Filter { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsVpcDhcpOptionsDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [TerraformPropertyName("domain_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DomainName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "domain_name");

    /// <summary>
    /// The domain_name_servers attribute.
    /// </summary>
    [TerraformPropertyName("domain_name_servers")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> DomainNameServers => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "domain_name_servers");

    /// <summary>
    /// The ipv6_address_preferred_lease_time attribute.
    /// </summary>
    [TerraformPropertyName("ipv6_address_preferred_lease_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Ipv6AddressPreferredLeaseTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ipv6_address_preferred_lease_time");

    /// <summary>
    /// The netbios_name_servers attribute.
    /// </summary>
    [TerraformPropertyName("netbios_name_servers")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> NetbiosNameServers => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "netbios_name_servers");

    /// <summary>
    /// The netbios_node_type attribute.
    /// </summary>
    [TerraformPropertyName("netbios_node_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NetbiosNodeType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "netbios_node_type");

    /// <summary>
    /// The ntp_servers attribute.
    /// </summary>
    [TerraformPropertyName("ntp_servers")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> NtpServers => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "ntp_servers");

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformPropertyName("owner_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OwnerId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "owner_id");

}
