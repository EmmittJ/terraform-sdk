using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for attachment in AwsNetworkInterface.
/// Nesting mode: set
/// </summary>
public class AwsNetworkInterfaceAttachmentBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "attachment";

    /// <summary>
    /// The attachment_id attribute.
    /// </summary>
    public TerraformValue<string> AttachmentId
        => AsReference("attachment_id");

    /// <summary>
    /// The device_index attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeviceIndex is required")]
    public required TerraformValue<double> DeviceIndex
    {
        get => GetRequiredArgument<TerraformValue<double>>("device_index");
        set => SetArgument("device_index", value);
    }

    /// <summary>
    /// The instance attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Instance is required")]
    public required TerraformValue<string> Instance
    {
        get => GetRequiredArgument<TerraformValue<string>>("instance");
        set => SetArgument("instance", value);
    }

    /// <summary>
    /// The network_card_index attribute.
    /// </summary>
    public TerraformValue<double> NetworkCardIndex
    {
        get => GetArgument<TerraformValue<double>>("network_card_index") ?? AsReference("network_card_index");
        set => SetArgument("network_card_index", value);
    }

}


/// <summary>
/// Represents a aws_network_interface Terraform resource.
/// Manages a aws_network_interface resource.
/// </summary>
public partial class AwsNetworkInterface(string name) : TerraformResource("aws_network_interface", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The enable_primary_ipv6 attribute.
    /// </summary>
    public TerraformValue<bool> EnablePrimaryIpv6
    {
        get => GetArgument<TerraformValue<bool>>("enable_primary_ipv6") ?? AsReference("enable_primary_ipv6");
        set => SetArgument("enable_primary_ipv6", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The interface_type attribute.
    /// </summary>
    public TerraformValue<string> InterfaceType
    {
        get => GetArgument<TerraformValue<string>>("interface_type") ?? AsReference("interface_type");
        set => SetArgument("interface_type", value);
    }

    /// <summary>
    /// The ipv4_prefix_count attribute.
    /// </summary>
    public TerraformValue<double> Ipv4PrefixCount
    {
        get => GetArgument<TerraformValue<double>>("ipv4_prefix_count") ?? AsReference("ipv4_prefix_count");
        set => SetArgument("ipv4_prefix_count", value);
    }

    /// <summary>
    /// The ipv4_prefixes attribute.
    /// </summary>
    public TerraformSet<string> Ipv4Prefixes
    {
        get => GetArgument<TerraformSet<string>>("ipv4_prefixes") ?? AsReference("ipv4_prefixes");
        set => SetArgument("ipv4_prefixes", value);
    }

    /// <summary>
    /// The ipv6_address_count attribute.
    /// </summary>
    public TerraformValue<double> Ipv6AddressCount
    {
        get => GetArgument<TerraformValue<double>>("ipv6_address_count") ?? AsReference("ipv6_address_count");
        set => SetArgument("ipv6_address_count", value);
    }

    /// <summary>
    /// The ipv6_address_list attribute.
    /// </summary>
    public TerraformList<string> Ipv6AddressList
    {
        get => GetArgument<TerraformList<string>>("ipv6_address_list") ?? AsReference("ipv6_address_list");
        set => SetArgument("ipv6_address_list", value);
    }

    /// <summary>
    /// The ipv6_address_list_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Ipv6AddressListEnabled
    {
        get => GetArgument<TerraformValue<bool>>("ipv6_address_list_enabled");
        set => SetArgument("ipv6_address_list_enabled", value);
    }

    /// <summary>
    /// The ipv6_addresses attribute.
    /// </summary>
    public TerraformSet<string> Ipv6Addresses
    {
        get => GetArgument<TerraformSet<string>>("ipv6_addresses") ?? AsReference("ipv6_addresses");
        set => SetArgument("ipv6_addresses", value);
    }

    /// <summary>
    /// The ipv6_prefix_count attribute.
    /// </summary>
    public TerraformValue<double> Ipv6PrefixCount
    {
        get => GetArgument<TerraformValue<double>>("ipv6_prefix_count") ?? AsReference("ipv6_prefix_count");
        set => SetArgument("ipv6_prefix_count", value);
    }

    /// <summary>
    /// The ipv6_prefixes attribute.
    /// </summary>
    public TerraformSet<string> Ipv6Prefixes
    {
        get => GetArgument<TerraformSet<string>>("ipv6_prefixes") ?? AsReference("ipv6_prefixes");
        set => SetArgument("ipv6_prefixes", value);
    }

    /// <summary>
    /// The private_ip attribute.
    /// </summary>
    public TerraformValue<string> PrivateIp
    {
        get => GetArgument<TerraformValue<string>>("private_ip") ?? AsReference("private_ip");
        set => SetArgument("private_ip", value);
    }

    /// <summary>
    /// The private_ip_list attribute.
    /// </summary>
    public TerraformList<string> PrivateIpList
    {
        get => GetArgument<TerraformList<string>>("private_ip_list") ?? AsReference("private_ip_list");
        set => SetArgument("private_ip_list", value);
    }

    /// <summary>
    /// The private_ip_list_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? PrivateIpListEnabled
    {
        get => GetArgument<TerraformValue<bool>>("private_ip_list_enabled");
        set => SetArgument("private_ip_list_enabled", value);
    }

    /// <summary>
    /// The private_ips attribute.
    /// </summary>
    public TerraformSet<string> PrivateIps
    {
        get => GetArgument<TerraformSet<string>>("private_ips") ?? AsReference("private_ips");
        set => SetArgument("private_ips", value);
    }

    /// <summary>
    /// The private_ips_count attribute.
    /// </summary>
    public TerraformValue<double> PrivateIpsCount
    {
        get => GetArgument<TerraformValue<double>>("private_ips_count") ?? AsReference("private_ips_count");
        set => SetArgument("private_ips_count", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    public TerraformSet<string> SecurityGroups
    {
        get => GetArgument<TerraformSet<string>>("security_groups") ?? AsReference("security_groups");
        set => SetArgument("security_groups", value);
    }

    /// <summary>
    /// The source_dest_check attribute.
    /// </summary>
    public TerraformValue<bool>? SourceDestCheck
    {
        get => GetArgument<TerraformValue<bool>>("source_dest_check");
        set => SetArgument("source_dest_check", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformValue<string> SubnetId
    {
        get => GetRequiredArgument<TerraformValue<string>>("subnet_id");
        set => SetArgument("subnet_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? AsReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The mac_address attribute.
    /// </summary>
    public TerraformValue<string> MacAddress
        => AsReference("mac_address");

    /// <summary>
    /// The outpost_arn attribute.
    /// </summary>
    public TerraformValue<string> OutpostArn
        => AsReference("outpost_arn");

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformValue<string> OwnerId
        => AsReference("owner_id");

    /// <summary>
    /// The private_dns_name attribute.
    /// </summary>
    public TerraformValue<string> PrivateDnsName
        => AsReference("private_dns_name");

    /// <summary>
    /// Attachment block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsNetworkInterfaceAttachmentBlock>? Attachment
    {
        get => GetArgument<TerraformSet<AwsNetworkInterfaceAttachmentBlock>>("attachment");
        set => SetArgument("attachment", value);
    }

}
