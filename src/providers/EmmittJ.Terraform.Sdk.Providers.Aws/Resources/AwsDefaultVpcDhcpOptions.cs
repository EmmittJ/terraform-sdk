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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformPropertyName("owner_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> OwnerId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "owner_id");

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
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

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
    public TerraformProperty<TerraformProperty<string>> DomainNameServers => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "domain_name_servers");

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
    public TerraformProperty<TerraformProperty<string>> NetbiosNameServers => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "netbios_name_servers");

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
    public TerraformProperty<TerraformProperty<string>> NtpServers => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ntp_servers");

}
