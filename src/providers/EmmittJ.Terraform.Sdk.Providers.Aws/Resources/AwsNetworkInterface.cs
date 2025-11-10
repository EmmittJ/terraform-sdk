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
        set => SetProperty("attachment_id", value);
    }

    /// <summary>
    /// The device_index attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeviceIndex is required")]
    public required TerraformProperty<double> DeviceIndex
    {
        set => SetProperty("device_index", value);
    }

    /// <summary>
    /// The instance attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Instance is required")]
    public required TerraformProperty<string> Instance
    {
        set => SetProperty("instance", value);
    }

    /// <summary>
    /// The network_card_index attribute.
    /// </summary>
    public TerraformProperty<double>? NetworkCardIndex
    {
        set => SetProperty("network_card_index", value);
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
        SetOutput("arn");
        SetOutput("mac_address");
        SetOutput("outpost_arn");
        SetOutput("owner_id");
        SetOutput("private_dns_name");
        SetOutput("description");
        SetOutput("enable_primary_ipv6");
        SetOutput("id");
        SetOutput("interface_type");
        SetOutput("ipv4_prefix_count");
        SetOutput("ipv4_prefixes");
        SetOutput("ipv6_address_count");
        SetOutput("ipv6_address_list");
        SetOutput("ipv6_address_list_enabled");
        SetOutput("ipv6_addresses");
        SetOutput("ipv6_prefix_count");
        SetOutput("ipv6_prefixes");
        SetOutput("private_ip");
        SetOutput("private_ip_list");
        SetOutput("private_ip_list_enabled");
        SetOutput("private_ips");
        SetOutput("private_ips_count");
        SetOutput("region");
        SetOutput("security_groups");
        SetOutput("source_dest_check");
        SetOutput("subnet_id");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The enable_primary_ipv6 attribute.
    /// </summary>
    public TerraformProperty<bool> EnablePrimaryIpv6
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_primary_ipv6");
        set => SetProperty("enable_primary_ipv6", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The interface_type attribute.
    /// </summary>
    public TerraformProperty<string> InterfaceType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("interface_type");
        set => SetProperty("interface_type", value);
    }

    /// <summary>
    /// The ipv4_prefix_count attribute.
    /// </summary>
    public TerraformProperty<double> Ipv4PrefixCount
    {
        get => GetRequiredOutput<TerraformProperty<double>>("ipv4_prefix_count");
        set => SetProperty("ipv4_prefix_count", value);
    }

    /// <summary>
    /// The ipv4_prefixes attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> Ipv4Prefixes
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("ipv4_prefixes");
        set => SetProperty("ipv4_prefixes", value);
    }

    /// <summary>
    /// The ipv6_address_count attribute.
    /// </summary>
    public TerraformProperty<double> Ipv6AddressCount
    {
        get => GetRequiredOutput<TerraformProperty<double>>("ipv6_address_count");
        set => SetProperty("ipv6_address_count", value);
    }

    /// <summary>
    /// The ipv6_address_list attribute.
    /// </summary>
    public List<TerraformProperty<string>> Ipv6AddressList
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("ipv6_address_list");
        set => SetProperty("ipv6_address_list", value);
    }

    /// <summary>
    /// The ipv6_address_list_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> Ipv6AddressListEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("ipv6_address_list_enabled");
        set => SetProperty("ipv6_address_list_enabled", value);
    }

    /// <summary>
    /// The ipv6_addresses attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> Ipv6Addresses
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("ipv6_addresses");
        set => SetProperty("ipv6_addresses", value);
    }

    /// <summary>
    /// The ipv6_prefix_count attribute.
    /// </summary>
    public TerraformProperty<double> Ipv6PrefixCount
    {
        get => GetRequiredOutput<TerraformProperty<double>>("ipv6_prefix_count");
        set => SetProperty("ipv6_prefix_count", value);
    }

    /// <summary>
    /// The ipv6_prefixes attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> Ipv6Prefixes
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("ipv6_prefixes");
        set => SetProperty("ipv6_prefixes", value);
    }

    /// <summary>
    /// The private_ip attribute.
    /// </summary>
    public TerraformProperty<string> PrivateIp
    {
        get => GetRequiredOutput<TerraformProperty<string>>("private_ip");
        set => SetProperty("private_ip", value);
    }

    /// <summary>
    /// The private_ip_list attribute.
    /// </summary>
    public List<TerraformProperty<string>> PrivateIpList
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("private_ip_list");
        set => SetProperty("private_ip_list", value);
    }

    /// <summary>
    /// The private_ip_list_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> PrivateIpListEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("private_ip_list_enabled");
        set => SetProperty("private_ip_list_enabled", value);
    }

    /// <summary>
    /// The private_ips attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> PrivateIps
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("private_ips");
        set => SetProperty("private_ips", value);
    }

    /// <summary>
    /// The private_ips_count attribute.
    /// </summary>
    public TerraformProperty<double> PrivateIpsCount
    {
        get => GetRequiredOutput<TerraformProperty<double>>("private_ips_count");
        set => SetProperty("private_ips_count", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> SecurityGroups
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("security_groups");
        set => SetProperty("security_groups", value);
    }

    /// <summary>
    /// The source_dest_check attribute.
    /// </summary>
    public TerraformProperty<bool> SourceDestCheck
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("source_dest_check");
        set => SetProperty("source_dest_check", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformProperty<string> SubnetId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("subnet_id");
        set => SetProperty("subnet_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// Block for attachment.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsNetworkInterfaceAttachmentBlock>? Attachment
    {
        set => SetProperty("attachment", value);
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
