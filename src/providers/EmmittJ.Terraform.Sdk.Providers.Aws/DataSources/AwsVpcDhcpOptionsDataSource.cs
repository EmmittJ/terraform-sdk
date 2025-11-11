using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsVpcDhcpOptionsDataSourceFilterBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    [TerraformPropertyName("values")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> Values { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsVpcDhcpOptionsDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

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
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> DhcpOptionsId { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Tags { get; set; } = default!;

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("filter")]
    public TerraformSet<TerraformBlock<AwsVpcDhcpOptionsDataSourceFilterBlock>>? Filter { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsVpcDhcpOptionsDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [TerraformPropertyName("domain_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DomainName => new TerraformReference(this, "domain_name");

    /// <summary>
    /// The domain_name_servers attribute.
    /// </summary>
    [TerraformPropertyName("domain_name_servers")]
    // Output-only attribute - read-only reference
    public TerraformList<string> DomainNameServers => new TerraformReference(this, "domain_name_servers");

    /// <summary>
    /// The ipv6_address_preferred_lease_time attribute.
    /// </summary>
    [TerraformPropertyName("ipv6_address_preferred_lease_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Ipv6AddressPreferredLeaseTime => new TerraformReference(this, "ipv6_address_preferred_lease_time");

    /// <summary>
    /// The netbios_name_servers attribute.
    /// </summary>
    [TerraformPropertyName("netbios_name_servers")]
    // Output-only attribute - read-only reference
    public TerraformList<string> NetbiosNameServers => new TerraformReference(this, "netbios_name_servers");

    /// <summary>
    /// The netbios_node_type attribute.
    /// </summary>
    [TerraformPropertyName("netbios_node_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> NetbiosNodeType => new TerraformReference(this, "netbios_node_type");

    /// <summary>
    /// The ntp_servers attribute.
    /// </summary>
    [TerraformPropertyName("ntp_servers")]
    // Output-only attribute - read-only reference
    public TerraformList<string> NtpServers => new TerraformReference(this, "ntp_servers");

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformPropertyName("owner_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OwnerId => new TerraformReference(this, "owner_id");

}
