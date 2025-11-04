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
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The enable_primary_ipv6 attribute.
    /// </summary>
    public bool? EnablePrimaryIpv6
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_primary_ipv6")?.Value;
        set => this.WithProperty("enable_primary_ipv6", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The interface_type attribute.
    /// </summary>
    public string? InterfaceType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("interface_type")?.Value;
        set => this.WithProperty("interface_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ipv4_prefix_count attribute.
    /// </summary>
    public double? Ipv4PrefixCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("ipv4_prefix_count")?.Value;
        set => this.WithProperty("ipv4_prefix_count", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The ipv4_prefixes attribute.
    /// </summary>
    public HashSet<string>? Ipv4Prefixes
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("ipv4_prefixes")?.Value;
        set => this.WithProperty("ipv4_prefixes", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The ipv6_address_count attribute.
    /// </summary>
    public double? Ipv6AddressCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("ipv6_address_count")?.Value;
        set => this.WithProperty("ipv6_address_count", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The ipv6_address_list attribute.
    /// </summary>
    public List<string>? Ipv6AddressList
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("ipv6_address_list")?.Value;
        set => this.WithProperty("ipv6_address_list", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The ipv6_address_list_enabled attribute.
    /// </summary>
    public bool? Ipv6AddressListEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("ipv6_address_list_enabled")?.Value;
        set => this.WithProperty("ipv6_address_list_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The ipv6_addresses attribute.
    /// </summary>
    public HashSet<string>? Ipv6Addresses
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("ipv6_addresses")?.Value;
        set => this.WithProperty("ipv6_addresses", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The ipv6_prefix_count attribute.
    /// </summary>
    public double? Ipv6PrefixCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("ipv6_prefix_count")?.Value;
        set => this.WithProperty("ipv6_prefix_count", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The ipv6_prefixes attribute.
    /// </summary>
    public HashSet<string>? Ipv6Prefixes
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("ipv6_prefixes")?.Value;
        set => this.WithProperty("ipv6_prefixes", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The private_ip attribute.
    /// </summary>
    public string? PrivateIp
    {
        get => GetProperty<TerraformLiteralProperty<string>>("private_ip")?.Value;
        set => this.WithProperty("private_ip", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The private_ip_list attribute.
    /// </summary>
    public List<string>? PrivateIpList
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("private_ip_list")?.Value;
        set => this.WithProperty("private_ip_list", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The private_ip_list_enabled attribute.
    /// </summary>
    public bool? PrivateIpListEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("private_ip_list_enabled")?.Value;
        set => this.WithProperty("private_ip_list_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The private_ips attribute.
    /// </summary>
    public HashSet<string>? PrivateIps
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("private_ips")?.Value;
        set => this.WithProperty("private_ips", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The private_ips_count attribute.
    /// </summary>
    public double? PrivateIpsCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("private_ips_count")?.Value;
        set => this.WithProperty("private_ips_count", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    public HashSet<string>? SecurityGroups
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("security_groups")?.Value;
        set => this.WithProperty("security_groups", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The source_dest_check attribute.
    /// </summary>
    public bool? SourceDestCheck
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("source_dest_check")?.Value;
        set => this.WithProperty("source_dest_check", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public string? SubnetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("subnet_id")?.Value;
        set => this.WithProperty("subnet_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
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
