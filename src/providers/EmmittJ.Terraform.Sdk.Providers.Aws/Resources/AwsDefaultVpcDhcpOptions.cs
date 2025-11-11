using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_default_vpc_dhcp_options resource.
/// </summary>
public partial class AwsDefaultVpcDhcpOptions : TerraformResource
{
    public AwsDefaultVpcDhcpOptions(string name) : base("aws_default_vpc_dhcp_options", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformProperty("owner_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> OwnerId { get; set; }

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
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

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
    public TerraformValue<string> DomainNameServers { get; }

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
    public TerraformValue<string> NetbiosNameServers { get; }

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
    public TerraformValue<string> NtpServers { get; }

}
