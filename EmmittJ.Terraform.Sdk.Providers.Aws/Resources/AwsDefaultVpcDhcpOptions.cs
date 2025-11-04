using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_default_vpc_dhcp_options resource.
/// </summary>
public class AwsDefaultVpcDhcpOptions : TerraformResource
{
    public AwsDefaultVpcDhcpOptions(string name) : base("aws_default_vpc_dhcp_options", name)
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
    /// The owner_id attribute.
    /// </summary>
    public string? OwnerId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("owner_id")?.Value;
        set => this.WithProperty("owner_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
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

}
