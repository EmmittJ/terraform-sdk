using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for attachment in .
/// Nesting mode: set
/// </summary>
public partial class AwsNetworkInterfaceAttachmentBlock : TerraformBlockBase
{

    /// <summary>
    /// The device_index attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeviceIndex is required")]
    [TerraformProperty("device_index")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> DeviceIndex { get; set; }

    /// <summary>
    /// The instance attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Instance is required")]
    [TerraformProperty("instance")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Instance { get; set; }

    /// <summary>
    /// The network_card_index attribute.
    /// </summary>
    [TerraformProperty("network_card_index")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> NetworkCardIndex { get; set; }

}

/// <summary>
/// Manages a aws_network_interface resource.
/// </summary>
public partial class AwsNetworkInterface : TerraformResource
{
    public AwsNetworkInterface(string name) : base("aws_network_interface", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The enable_primary_ipv6 attribute.
    /// </summary>
    [TerraformProperty("enable_primary_ipv6")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> EnablePrimaryIpv6 { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The interface_type attribute.
    /// </summary>
    [TerraformProperty("interface_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> InterfaceType { get; set; }

    /// <summary>
    /// The ipv4_prefix_count attribute.
    /// </summary>
    [TerraformProperty("ipv4_prefix_count")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> Ipv4PrefixCount { get; set; }

    /// <summary>
    /// The ipv4_prefixes attribute.
    /// </summary>
    [TerraformProperty("ipv4_prefixes")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> Ipv4Prefixes { get; set; }

    /// <summary>
    /// The ipv6_address_count attribute.
    /// </summary>
    [TerraformProperty("ipv6_address_count")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> Ipv6AddressCount { get; set; }

    /// <summary>
    /// The ipv6_address_list attribute.
    /// </summary>
    [TerraformProperty("ipv6_address_list")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformList<string> Ipv6AddressList { get; set; }

    /// <summary>
    /// The ipv6_address_list_enabled attribute.
    /// </summary>
    [TerraformProperty("ipv6_address_list_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Ipv6AddressListEnabled { get; set; }

    /// <summary>
    /// The ipv6_addresses attribute.
    /// </summary>
    [TerraformProperty("ipv6_addresses")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> Ipv6Addresses { get; set; }

    /// <summary>
    /// The ipv6_prefix_count attribute.
    /// </summary>
    [TerraformProperty("ipv6_prefix_count")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> Ipv6PrefixCount { get; set; }

    /// <summary>
    /// The ipv6_prefixes attribute.
    /// </summary>
    [TerraformProperty("ipv6_prefixes")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> Ipv6Prefixes { get; set; }

    /// <summary>
    /// The private_ip attribute.
    /// </summary>
    [TerraformProperty("private_ip")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> PrivateIp { get; set; }

    /// <summary>
    /// The private_ip_list attribute.
    /// </summary>
    [TerraformProperty("private_ip_list")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformList<string> PrivateIpList { get; set; }

    /// <summary>
    /// The private_ip_list_enabled attribute.
    /// </summary>
    [TerraformProperty("private_ip_list_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? PrivateIpListEnabled { get; set; }

    /// <summary>
    /// The private_ips attribute.
    /// </summary>
    [TerraformProperty("private_ips")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> PrivateIps { get; set; }

    /// <summary>
    /// The private_ips_count attribute.
    /// </summary>
    [TerraformProperty("private_ips_count")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> PrivateIpsCount { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    [TerraformProperty("security_groups")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> SecurityGroups { get; set; }

    /// <summary>
    /// The source_dest_check attribute.
    /// </summary>
    [TerraformProperty("source_dest_check")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? SourceDestCheck { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    [TerraformProperty("subnet_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SubnetId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for attachment.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("attachment")]
    public partial TerraformSet<TerraformBlock<AwsNetworkInterfaceAttachmentBlock>>? Attachment { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The mac_address attribute.
    /// </summary>
    [TerraformProperty("mac_address")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> MacAddress { get; }

    /// <summary>
    /// The outpost_arn attribute.
    /// </summary>
    [TerraformProperty("outpost_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OutpostArn { get; }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformProperty("owner_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OwnerId { get; }

    /// <summary>
    /// The private_dns_name attribute.
    /// </summary>
    [TerraformProperty("private_dns_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrivateDnsName { get; }

}
