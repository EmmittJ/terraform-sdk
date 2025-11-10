using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for attachment in .
/// Nesting mode: set
/// </summary>
public class AwsNetworkInterfaceAttachmentBlock : TerraformBlock
{
    /// <summary>
    /// The attachment_id attribute.
    /// </summary>
    public TerraformProperty<string>? AttachmentId
    {
        get => GetProperty<TerraformProperty<string>>("attachment_id");
        set => WithProperty("attachment_id", value);
    }

    /// <summary>
    /// The device_index attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeviceIndex is required")]
    public required TerraformProperty<double> DeviceIndex
    {
        get => GetRequiredProperty<TerraformProperty<double>>("device_index");
        set => WithProperty("device_index", value);
    }

    /// <summary>
    /// The instance attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Instance is required")]
    public required TerraformProperty<string> Instance
    {
        get => GetRequiredProperty<TerraformProperty<string>>("instance");
        set => WithProperty("instance", value);
    }

    /// <summary>
    /// The network_card_index attribute.
    /// </summary>
    public TerraformProperty<double>? NetworkCardIndex
    {
        get => GetProperty<TerraformProperty<double>>("network_card_index");
        set => WithProperty("network_card_index", value);
    }

}

/// <summary>
/// Manages a aws_network_interface resource.
/// </summary>
public class AwsNetworkInterface : TerraformResource
{
    public AwsNetworkInterface(string name) : base("aws_network_interface", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
        this.WithOutput("mac_address");
        this.WithOutput("outpost_arn");
        this.WithOutput("owner_id");
        this.WithOutput("private_dns_name");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The enable_primary_ipv6 attribute.
    /// </summary>
    public TerraformProperty<bool>? EnablePrimaryIpv6
    {
        get => GetProperty<TerraformProperty<bool>>("enable_primary_ipv6");
        set => this.WithProperty("enable_primary_ipv6", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The interface_type attribute.
    /// </summary>
    public TerraformProperty<string>? InterfaceType
    {
        get => GetProperty<TerraformProperty<string>>("interface_type");
        set => this.WithProperty("interface_type", value);
    }

    /// <summary>
    /// The ipv4_prefix_count attribute.
    /// </summary>
    public TerraformProperty<double>? Ipv4PrefixCount
    {
        get => GetProperty<TerraformProperty<double>>("ipv4_prefix_count");
        set => this.WithProperty("ipv4_prefix_count", value);
    }

    /// <summary>
    /// The ipv4_prefixes attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Ipv4Prefixes
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("ipv4_prefixes");
        set => this.WithProperty("ipv4_prefixes", value);
    }

    /// <summary>
    /// The ipv6_address_count attribute.
    /// </summary>
    public TerraformProperty<double>? Ipv6AddressCount
    {
        get => GetProperty<TerraformProperty<double>>("ipv6_address_count");
        set => this.WithProperty("ipv6_address_count", value);
    }

    /// <summary>
    /// The ipv6_address_list attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Ipv6AddressList
    {
        get => GetProperty<List<TerraformProperty<string>>>("ipv6_address_list");
        set => this.WithProperty("ipv6_address_list", value);
    }

    /// <summary>
    /// The ipv6_address_list_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Ipv6AddressListEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("ipv6_address_list_enabled");
        set => this.WithProperty("ipv6_address_list_enabled", value);
    }

    /// <summary>
    /// The ipv6_addresses attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Ipv6Addresses
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("ipv6_addresses");
        set => this.WithProperty("ipv6_addresses", value);
    }

    /// <summary>
    /// The ipv6_prefix_count attribute.
    /// </summary>
    public TerraformProperty<double>? Ipv6PrefixCount
    {
        get => GetProperty<TerraformProperty<double>>("ipv6_prefix_count");
        set => this.WithProperty("ipv6_prefix_count", value);
    }

    /// <summary>
    /// The ipv6_prefixes attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Ipv6Prefixes
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("ipv6_prefixes");
        set => this.WithProperty("ipv6_prefixes", value);
    }

    /// <summary>
    /// The private_ip attribute.
    /// </summary>
    public TerraformProperty<string>? PrivateIp
    {
        get => GetProperty<TerraformProperty<string>>("private_ip");
        set => this.WithProperty("private_ip", value);
    }

    /// <summary>
    /// The private_ip_list attribute.
    /// </summary>
    public List<TerraformProperty<string>>? PrivateIpList
    {
        get => GetProperty<List<TerraformProperty<string>>>("private_ip_list");
        set => this.WithProperty("private_ip_list", value);
    }

    /// <summary>
    /// The private_ip_list_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? PrivateIpListEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("private_ip_list_enabled");
        set => this.WithProperty("private_ip_list_enabled", value);
    }

    /// <summary>
    /// The private_ips attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? PrivateIps
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("private_ips");
        set => this.WithProperty("private_ips", value);
    }

    /// <summary>
    /// The private_ips_count attribute.
    /// </summary>
    public TerraformProperty<double>? PrivateIpsCount
    {
        get => GetProperty<TerraformProperty<double>>("private_ips_count");
        set => this.WithProperty("private_ips_count", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SecurityGroups
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("security_groups");
        set => this.WithProperty("security_groups", value);
    }

    /// <summary>
    /// The source_dest_check attribute.
    /// </summary>
    public TerraformProperty<bool>? SourceDestCheck
    {
        get => GetProperty<TerraformProperty<bool>>("source_dest_check");
        set => this.WithProperty("source_dest_check", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformProperty<string> SubnetId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("subnet_id");
        set => this.WithProperty("subnet_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// Block for attachment.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsNetworkInterfaceAttachmentBlock>? Attachment
    {
        get => GetProperty<HashSet<AwsNetworkInterfaceAttachmentBlock>>("attachment");
        set => this.WithProperty("attachment", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The mac_address attribute.
    /// </summary>
    public TerraformExpression MacAddress => this["mac_address"];

    /// <summary>
    /// The outpost_arn attribute.
    /// </summary>
    public TerraformExpression OutpostArn => this["outpost_arn"];

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformExpression OwnerId => this["owner_id"];

    /// <summary>
    /// The private_dns_name attribute.
    /// </summary>
    public TerraformExpression PrivateDnsName => this["private_dns_name"];

}
