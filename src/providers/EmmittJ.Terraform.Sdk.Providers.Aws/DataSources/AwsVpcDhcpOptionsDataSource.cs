using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public partial class AwsVpcDhcpOptionsDataSourceFilterBlock : TerraformBlockBase
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    [TerraformProperty("values")]
    // Required argument - source generator will implement get/set
    public required TerraformSet<string> Values { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsVpcDhcpOptionsDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a aws_vpc_dhcp_options.
/// </summary>
public partial class AwsVpcDhcpOptionsDataSource : TerraformDataSource
{
    public AwsVpcDhcpOptionsDataSource(string name) : base("aws_vpc_dhcp_options", name)
    {
    }

    /// <summary>
    /// The dhcp_options_id attribute.
    /// </summary>
    [TerraformProperty("dhcp_options_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> DhcpOptionsId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("filter")]
    public TerraformSet<TerraformBlock<AwsVpcDhcpOptionsDataSourceFilterBlock>>? Filter { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AwsVpcDhcpOptionsDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [TerraformProperty("domain_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DomainName { get; }

    /// <summary>
    /// The domain_name_servers attribute.
    /// </summary>
    [TerraformProperty("domain_name_servers")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> DomainNameServers { get; }

    /// <summary>
    /// The ipv6_address_preferred_lease_time attribute.
    /// </summary>
    [TerraformProperty("ipv6_address_preferred_lease_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Ipv6AddressPreferredLeaseTime { get; }

    /// <summary>
    /// The netbios_name_servers attribute.
    /// </summary>
    [TerraformProperty("netbios_name_servers")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> NetbiosNameServers { get; }

    /// <summary>
    /// The netbios_node_type attribute.
    /// </summary>
    [TerraformProperty("netbios_node_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> NetbiosNodeType { get; }

    /// <summary>
    /// The ntp_servers attribute.
    /// </summary>
    [TerraformProperty("ntp_servers")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> NtpServers { get; }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformProperty("owner_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> OwnerId { get; }

}
