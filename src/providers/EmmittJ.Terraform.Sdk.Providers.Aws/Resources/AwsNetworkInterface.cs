using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for attachment in .
/// Nesting mode: set
/// </summary>
public class AwsNetworkInterfaceAttachmentBlock
{

    /// <summary>
    /// The device_index attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeviceIndex is required")]
    [TerraformPropertyName("device_index")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> DeviceIndex { get; set; }

    /// <summary>
    /// The instance attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Instance is required")]
    [TerraformPropertyName("instance")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Instance { get; set; }

    /// <summary>
    /// The network_card_index attribute.
    /// </summary>
    [TerraformPropertyName("network_card_index")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> NetworkCardIndex { get; set; } = default!;

}

/// <summary>
/// Manages a aws_network_interface resource.
/// </summary>
public class AwsNetworkInterface : TerraformResource
{
    public AwsNetworkInterface(string name) : base("aws_network_interface", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The enable_primary_ipv6 attribute.
    /// </summary>
    [TerraformPropertyName("enable_primary_ipv6")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> EnablePrimaryIpv6 { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The interface_type attribute.
    /// </summary>
    [TerraformPropertyName("interface_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> InterfaceType { get; set; } = default!;

    /// <summary>
    /// The ipv4_prefix_count attribute.
    /// </summary>
    [TerraformPropertyName("ipv4_prefix_count")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> Ipv4PrefixCount { get; set; } = default!;

    /// <summary>
    /// The ipv4_prefixes attribute.
    /// </summary>
    [TerraformPropertyName("ipv4_prefixes")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<string> Ipv4Prefixes { get; set; } = default!;

    /// <summary>
    /// The ipv6_address_count attribute.
    /// </summary>
    [TerraformPropertyName("ipv6_address_count")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> Ipv6AddressCount { get; set; } = default!;

    /// <summary>
    /// The ipv6_address_list attribute.
    /// </summary>
    [TerraformPropertyName("ipv6_address_list")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformList<string> Ipv6AddressList { get; set; } = default!;

    /// <summary>
    /// The ipv6_address_list_enabled attribute.
    /// </summary>
    [TerraformPropertyName("ipv6_address_list_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Ipv6AddressListEnabled { get; set; }

    /// <summary>
    /// The ipv6_addresses attribute.
    /// </summary>
    [TerraformPropertyName("ipv6_addresses")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<string> Ipv6Addresses { get; set; } = default!;

    /// <summary>
    /// The ipv6_prefix_count attribute.
    /// </summary>
    [TerraformPropertyName("ipv6_prefix_count")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> Ipv6PrefixCount { get; set; } = default!;

    /// <summary>
    /// The ipv6_prefixes attribute.
    /// </summary>
    [TerraformPropertyName("ipv6_prefixes")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<string> Ipv6Prefixes { get; set; } = default!;

    /// <summary>
    /// The private_ip attribute.
    /// </summary>
    [TerraformPropertyName("private_ip")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> PrivateIp { get; set; } = default!;

    /// <summary>
    /// The private_ip_list attribute.
    /// </summary>
    [TerraformPropertyName("private_ip_list")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformList<string> PrivateIpList { get; set; } = default!;

    /// <summary>
    /// The private_ip_list_enabled attribute.
    /// </summary>
    [TerraformPropertyName("private_ip_list_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? PrivateIpListEnabled { get; set; }

    /// <summary>
    /// The private_ips attribute.
    /// </summary>
    [TerraformPropertyName("private_ips")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<string> PrivateIps { get; set; } = default!;

    /// <summary>
    /// The private_ips_count attribute.
    /// </summary>
    [TerraformPropertyName("private_ips_count")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> PrivateIpsCount { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    [TerraformPropertyName("security_groups")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<string> SecurityGroups { get; set; } = default!;

    /// <summary>
    /// The source_dest_check attribute.
    /// </summary>
    [TerraformPropertyName("source_dest_check")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? SourceDestCheck { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    [TerraformPropertyName("subnet_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> SubnetId { get; set; }

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
    /// Block for attachment.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("attachment")]
    public TerraformSet<TerraformBlock<AwsNetworkInterfaceAttachmentBlock>>? Attachment { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The mac_address attribute.
    /// </summary>
    [TerraformPropertyName("mac_address")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> MacAddress => new TerraformReference(this, "mac_address");

    /// <summary>
    /// The outpost_arn attribute.
    /// </summary>
    [TerraformPropertyName("outpost_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OutpostArn => new TerraformReference(this, "outpost_arn");

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformPropertyName("owner_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OwnerId => new TerraformReference(this, "owner_id");

    /// <summary>
    /// The private_dns_name attribute.
    /// </summary>
    [TerraformPropertyName("private_dns_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrivateDnsName => new TerraformReference(this, "private_dns_name");

}
