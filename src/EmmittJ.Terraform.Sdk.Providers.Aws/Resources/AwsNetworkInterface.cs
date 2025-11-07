using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
        this.DeclareOutput("arn");
        this.DeclareOutput("mac_address");
        this.DeclareOutput("outpost_arn");
        this.DeclareOutput("owner_id");
        this.DeclareOutput("private_dns_name");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The enable_primary_ipv6 attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? EnablePrimaryIpv6
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_primary_ipv6");
        set => this.WithProperty("enable_primary_ipv6", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The interface_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? InterfaceType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("interface_type");
        set => this.WithProperty("interface_type", value);
    }

    /// <summary>
    /// The ipv4_prefix_count attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? Ipv4PrefixCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("ipv4_prefix_count");
        set => this.WithProperty("ipv4_prefix_count", value);
    }

    /// <summary>
    /// The ipv4_prefixes attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? Ipv4Prefixes
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("ipv4_prefixes");
        set => this.WithProperty("ipv4_prefixes", value);
    }

    /// <summary>
    /// The ipv6_address_count attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? Ipv6AddressCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("ipv6_address_count");
        set => this.WithProperty("ipv6_address_count", value);
    }

    /// <summary>
    /// The ipv6_address_list attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? Ipv6AddressList
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("ipv6_address_list");
        set => this.WithProperty("ipv6_address_list", value);
    }

    /// <summary>
    /// The ipv6_address_list_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? Ipv6AddressListEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("ipv6_address_list_enabled");
        set => this.WithProperty("ipv6_address_list_enabled", value);
    }

    /// <summary>
    /// The ipv6_addresses attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? Ipv6Addresses
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("ipv6_addresses");
        set => this.WithProperty("ipv6_addresses", value);
    }

    /// <summary>
    /// The ipv6_prefix_count attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? Ipv6PrefixCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("ipv6_prefix_count");
        set => this.WithProperty("ipv6_prefix_count", value);
    }

    /// <summary>
    /// The ipv6_prefixes attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? Ipv6Prefixes
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("ipv6_prefixes");
        set => this.WithProperty("ipv6_prefixes", value);
    }

    /// <summary>
    /// The private_ip attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PrivateIp
    {
        get => GetProperty<TerraformLiteralProperty<string>>("private_ip");
        set => this.WithProperty("private_ip", value);
    }

    /// <summary>
    /// The private_ip_list attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? PrivateIpList
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("private_ip_list");
        set => this.WithProperty("private_ip_list", value);
    }

    /// <summary>
    /// The private_ip_list_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? PrivateIpListEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("private_ip_list_enabled");
        set => this.WithProperty("private_ip_list_enabled", value);
    }

    /// <summary>
    /// The private_ips attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? PrivateIps
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("private_ips");
        set => this.WithProperty("private_ips", value);
    }

    /// <summary>
    /// The private_ips_count attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? PrivateIpsCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("private_ips_count");
        set => this.WithProperty("private_ips_count", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? SecurityGroups
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("security_groups");
        set => this.WithProperty("security_groups", value);
    }

    /// <summary>
    /// The source_dest_check attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? SourceDestCheck
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("source_dest_check");
        set => this.WithProperty("source_dest_check", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SubnetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("subnet_id");
        set => this.WithProperty("subnet_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
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
