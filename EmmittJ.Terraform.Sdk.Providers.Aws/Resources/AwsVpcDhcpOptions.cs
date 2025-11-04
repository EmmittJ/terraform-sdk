using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_vpc_dhcp_options resource.
/// </summary>
public class AwsVpcDhcpOptions : TerraformResource
{
    public AwsVpcDhcpOptions(string name) : base("aws_vpc_dhcp_options", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("owner_id");
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    public string? DomainName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("domain_name")?.Value;
        set => this.WithProperty("domain_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The domain_name_servers attribute.
    /// </summary>
    public List<string>? DomainNameServers
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("domain_name_servers")?.Value;
        set => this.WithProperty("domain_name_servers", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
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
    /// The ipv6_address_preferred_lease_time attribute.
    /// </summary>
    public string? Ipv6AddressPreferredLeaseTime
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ipv6_address_preferred_lease_time")?.Value;
        set => this.WithProperty("ipv6_address_preferred_lease_time", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The netbios_name_servers attribute.
    /// </summary>
    public List<string>? NetbiosNameServers
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("netbios_name_servers")?.Value;
        set => this.WithProperty("netbios_name_servers", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The netbios_node_type attribute.
    /// </summary>
    public string? NetbiosNodeType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("netbios_node_type")?.Value;
        set => this.WithProperty("netbios_node_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ntp_servers attribute.
    /// </summary>
    public List<string>? NtpServers
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("ntp_servers")?.Value;
        set => this.WithProperty("ntp_servers", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
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
    /// The owner_id attribute.
    /// </summary>
    public TerraformExpression OwnerId => this["owner_id"];

}
