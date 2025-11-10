using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for attachment in .
/// Nesting mode: set
/// </summary>
public class AwsNetworkInterfaceAttachmentBlock : ITerraformBlock
{
    /// <summary>
    /// The attachment_id attribute.
    /// </summary>
    [TerraformPropertyName("attachment_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AttachmentId => new TerraformReferenceProperty<TerraformProperty<string>>("", "attachment_id");

    /// <summary>
    /// The device_index attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeviceIndex is required")]
    [TerraformPropertyName("device_index")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> DeviceIndex { get; set; }

    /// <summary>
    /// The instance attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Instance is required")]
    [TerraformPropertyName("instance")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Instance { get; set; }

    /// <summary>
    /// The network_card_index attribute.
    /// </summary>
    [TerraformPropertyName("network_card_index")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> NetworkCardIndex { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "network_card_index");

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
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The enable_primary_ipv6 attribute.
    /// </summary>
    [TerraformPropertyName("enable_primary_ipv6")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> EnablePrimaryIpv6 { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "enable_primary_ipv6");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The interface_type attribute.
    /// </summary>
    [TerraformPropertyName("interface_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> InterfaceType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "interface_type");

    /// <summary>
    /// The ipv4_prefix_count attribute.
    /// </summary>
    [TerraformPropertyName("ipv4_prefix_count")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> Ipv4PrefixCount { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "ipv4_prefix_count");

    /// <summary>
    /// The ipv4_prefixes attribute.
    /// </summary>
    [TerraformPropertyName("ipv4_prefixes")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> Ipv4Prefixes { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "ipv4_prefixes");

    /// <summary>
    /// The ipv6_address_count attribute.
    /// </summary>
    [TerraformPropertyName("ipv6_address_count")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> Ipv6AddressCount { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "ipv6_address_count");

    /// <summary>
    /// The ipv6_address_list attribute.
    /// </summary>
    [TerraformPropertyName("ipv6_address_list")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<List<TerraformProperty<string>>> Ipv6AddressList { get; set; } = new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "ipv6_address_list");

    /// <summary>
    /// The ipv6_address_list_enabled attribute.
    /// </summary>
    [TerraformPropertyName("ipv6_address_list_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Ipv6AddressListEnabled { get; set; }

    /// <summary>
    /// The ipv6_addresses attribute.
    /// </summary>
    [TerraformPropertyName("ipv6_addresses")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> Ipv6Addresses { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "ipv6_addresses");

    /// <summary>
    /// The ipv6_prefix_count attribute.
    /// </summary>
    [TerraformPropertyName("ipv6_prefix_count")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> Ipv6PrefixCount { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "ipv6_prefix_count");

    /// <summary>
    /// The ipv6_prefixes attribute.
    /// </summary>
    [TerraformPropertyName("ipv6_prefixes")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> Ipv6Prefixes { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "ipv6_prefixes");

    /// <summary>
    /// The private_ip attribute.
    /// </summary>
    [TerraformPropertyName("private_ip")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> PrivateIp { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "private_ip");

    /// <summary>
    /// The private_ip_list attribute.
    /// </summary>
    [TerraformPropertyName("private_ip_list")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<List<TerraformProperty<string>>> PrivateIpList { get; set; } = new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "private_ip_list");

    /// <summary>
    /// The private_ip_list_enabled attribute.
    /// </summary>
    [TerraformPropertyName("private_ip_list_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? PrivateIpListEnabled { get; set; }

    /// <summary>
    /// The private_ips attribute.
    /// </summary>
    [TerraformPropertyName("private_ips")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> PrivateIps { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "private_ips");

    /// <summary>
    /// The private_ips_count attribute.
    /// </summary>
    [TerraformPropertyName("private_ips_count")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> PrivateIpsCount { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "private_ips_count");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    [TerraformPropertyName("security_groups")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> SecurityGroups { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "security_groups");

    /// <summary>
    /// The source_dest_check attribute.
    /// </summary>
    [TerraformPropertyName("source_dest_check")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? SourceDestCheck { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    [TerraformPropertyName("subnet_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SubnetId { get; set; }

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
    /// Block for attachment.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("attachment")]
    public TerraformSet<TerraformBlock<AwsNetworkInterfaceAttachmentBlock>>? Attachment { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The mac_address attribute.
    /// </summary>
    [TerraformPropertyName("mac_address")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> MacAddress => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "mac_address");

    /// <summary>
    /// The outpost_arn attribute.
    /// </summary>
    [TerraformPropertyName("outpost_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OutpostArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "outpost_arn");

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformPropertyName("owner_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OwnerId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "owner_id");

    /// <summary>
    /// The private_dns_name attribute.
    /// </summary>
    [TerraformPropertyName("private_dns_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrivateDnsName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "private_dns_name");

}
