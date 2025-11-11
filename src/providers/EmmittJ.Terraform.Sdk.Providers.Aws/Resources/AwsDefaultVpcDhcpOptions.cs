using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_default_vpc_dhcp_options resource.
/// </summary>
public class AwsDefaultVpcDhcpOptions : TerraformResource
{
    public AwsDefaultVpcDhcpOptions(string name) : base("aws_default_vpc_dhcp_options", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformPropertyName("owner_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> OwnerId { get; set; } = default!;

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
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

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
    public TerraformValue<string> DomainNameServers => new TerraformReference(this, "domain_name_servers");

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
    public TerraformValue<string> NetbiosNameServers => new TerraformReference(this, "netbios_name_servers");

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
    public TerraformValue<string> NtpServers => new TerraformReference(this, "ntp_servers");

}
