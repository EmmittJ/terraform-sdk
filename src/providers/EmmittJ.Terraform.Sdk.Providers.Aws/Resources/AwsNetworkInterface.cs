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
    {
        get => new TerraformReference<string>(this, "attachment_id");
    }

    /// <summary>
    /// The device_index attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeviceIndex is required")]
    public required TerraformValue<double> DeviceIndex
    {
        get => new TerraformReference<double>(this, "device_index");
        set => SetArgument("device_index", value);
    }

    /// <summary>
    /// The instance attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Instance is required")]
    public required TerraformValue<string> Instance
    {
        get => new TerraformReference<string>(this, "instance");
        set => SetArgument("instance", value);
    }

    /// <summary>
    /// The network_card_index attribute.
    /// </summary>
    public TerraformValue<double> NetworkCardIndex
    {
        get => new TerraformReference<double>(this, "network_card_index");
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
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The enable_primary_ipv6 attribute.
    /// </summary>
    public TerraformValue<bool> EnablePrimaryIpv6
    {
        get => new TerraformReference<bool>(this, "enable_primary_ipv6");
        set => SetArgument("enable_primary_ipv6", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The interface_type attribute.
    /// </summary>
    public TerraformValue<string> InterfaceType
    {
        get => new TerraformReference<string>(this, "interface_type");
        set => SetArgument("interface_type", value);
    }

    /// <summary>
    /// The ipv4_prefix_count attribute.
    /// </summary>
    public TerraformValue<double> Ipv4PrefixCount
    {
        get => new TerraformReference<double>(this, "ipv4_prefix_count");
        set => SetArgument("ipv4_prefix_count", value);
    }

    /// <summary>
    /// The ipv4_prefixes attribute.
    /// </summary>
    public TerraformSet<string> Ipv4Prefixes
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "ipv4_prefixes").ResolveNodes(ctx));
        set => SetArgument("ipv4_prefixes", value);
    }

    /// <summary>
    /// The ipv6_address_count attribute.
    /// </summary>
    public TerraformValue<double> Ipv6AddressCount
    {
        get => new TerraformReference<double>(this, "ipv6_address_count");
        set => SetArgument("ipv6_address_count", value);
    }

    /// <summary>
    /// The ipv6_address_list attribute.
    /// </summary>
    public TerraformList<string> Ipv6AddressList
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "ipv6_address_list").ResolveNodes(ctx));
        set => SetArgument("ipv6_address_list", value);
    }

    /// <summary>
    /// The ipv6_address_list_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Ipv6AddressListEnabled
    {
        get => new TerraformReference<bool>(this, "ipv6_address_list_enabled");
        set => SetArgument("ipv6_address_list_enabled", value);
    }

    /// <summary>
    /// The ipv6_addresses attribute.
    /// </summary>
    public TerraformSet<string> Ipv6Addresses
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "ipv6_addresses").ResolveNodes(ctx));
        set => SetArgument("ipv6_addresses", value);
    }

    /// <summary>
    /// The ipv6_prefix_count attribute.
    /// </summary>
    public TerraformValue<double> Ipv6PrefixCount
    {
        get => new TerraformReference<double>(this, "ipv6_prefix_count");
        set => SetArgument("ipv6_prefix_count", value);
    }

    /// <summary>
    /// The ipv6_prefixes attribute.
    /// </summary>
    public TerraformSet<string> Ipv6Prefixes
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "ipv6_prefixes").ResolveNodes(ctx));
        set => SetArgument("ipv6_prefixes", value);
    }

    /// <summary>
    /// The private_ip attribute.
    /// </summary>
    public TerraformValue<string> PrivateIp
    {
        get => new TerraformReference<string>(this, "private_ip");
        set => SetArgument("private_ip", value);
    }

    /// <summary>
    /// The private_ip_list attribute.
    /// </summary>
    public TerraformList<string> PrivateIpList
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "private_ip_list").ResolveNodes(ctx));
        set => SetArgument("private_ip_list", value);
    }

    /// <summary>
    /// The private_ip_list_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? PrivateIpListEnabled
    {
        get => new TerraformReference<bool>(this, "private_ip_list_enabled");
        set => SetArgument("private_ip_list_enabled", value);
    }

    /// <summary>
    /// The private_ips attribute.
    /// </summary>
    public TerraformSet<string> PrivateIps
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "private_ips").ResolveNodes(ctx));
        set => SetArgument("private_ips", value);
    }

    /// <summary>
    /// The private_ips_count attribute.
    /// </summary>
    public TerraformValue<double> PrivateIpsCount
    {
        get => new TerraformReference<double>(this, "private_ips_count");
        set => SetArgument("private_ips_count", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    public TerraformSet<string> SecurityGroups
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "security_groups").ResolveNodes(ctx));
        set => SetArgument("security_groups", value);
    }

    /// <summary>
    /// The source_dest_check attribute.
    /// </summary>
    public TerraformValue<bool>? SourceDestCheck
    {
        get => new TerraformReference<bool>(this, "source_dest_check");
        set => SetArgument("source_dest_check", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformValue<string> SubnetId
    {
        get => new TerraformReference<string>(this, "subnet_id");
        set => SetArgument("subnet_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The mac_address attribute.
    /// </summary>
    public TerraformValue<string> MacAddress
    {
        get => new TerraformReference<string>(this, "mac_address");
    }

    /// <summary>
    /// The outpost_arn attribute.
    /// </summary>
    public TerraformValue<string> OutpostArn
    {
        get => new TerraformReference<string>(this, "outpost_arn");
    }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformValue<string> OwnerId
    {
        get => new TerraformReference<string>(this, "owner_id");
    }

    /// <summary>
    /// The private_dns_name attribute.
    /// </summary>
    public TerraformValue<string> PrivateDnsName
    {
        get => new TerraformReference<string>(this, "private_dns_name");
    }

    /// <summary>
    /// Attachment block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsNetworkInterfaceAttachmentBlock>? Attachment
    {
        get => GetArgument<TerraformSet<AwsNetworkInterfaceAttachmentBlock>>("attachment");
        set => SetArgument("attachment", value);
    }

}
