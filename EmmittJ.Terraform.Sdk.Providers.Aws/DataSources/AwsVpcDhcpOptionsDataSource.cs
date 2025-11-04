using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_vpc_dhcp_options.
/// </summary>
public class AwsVpcDhcpOptionsDataSource : TerraformDataSource
{
    public AwsVpcDhcpOptionsDataSource(string name) : base("aws_vpc_dhcp_options", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("domain_name");
        this.DeclareOutput("domain_name_servers");
        this.DeclareOutput("ipv6_address_preferred_lease_time");
        this.DeclareOutput("netbios_name_servers");
        this.DeclareOutput("netbios_node_type");
        this.DeclareOutput("ntp_servers");
        this.DeclareOutput("owner_id");
    }

    /// <summary>
    /// The dhcp_options_id attribute.
    /// </summary>
    public string? DhcpOptionsId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("dhcp_options_id")?.Value;
        set => this.WithProperty("dhcp_options_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    public TerraformExpression DomainName => this["domain_name"];

    /// <summary>
    /// The domain_name_servers attribute.
    /// </summary>
    public TerraformExpression DomainNameServers => this["domain_name_servers"];

    /// <summary>
    /// The ipv6_address_preferred_lease_time attribute.
    /// </summary>
    public TerraformExpression Ipv6AddressPreferredLeaseTime => this["ipv6_address_preferred_lease_time"];

    /// <summary>
    /// The netbios_name_servers attribute.
    /// </summary>
    public TerraformExpression NetbiosNameServers => this["netbios_name_servers"];

    /// <summary>
    /// The netbios_node_type attribute.
    /// </summary>
    public TerraformExpression NetbiosNodeType => this["netbios_node_type"];

    /// <summary>
    /// The ntp_servers attribute.
    /// </summary>
    public TerraformExpression NtpServers => this["ntp_servers"];

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformExpression OwnerId => this["owner_id"];

}
