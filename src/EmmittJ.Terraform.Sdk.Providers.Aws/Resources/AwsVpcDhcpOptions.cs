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
    public TerraformProperty<string>? DomainName
    {
        get => GetProperty<TerraformProperty<string>>("domain_name");
        set => this.WithProperty("domain_name", value);
    }

    /// <summary>
    /// The domain_name_servers attribute.
    /// </summary>
    public TerraformProperty<List<string>>? DomainNameServers
    {
        get => GetProperty<TerraformProperty<List<string>>>("domain_name_servers");
        set => this.WithProperty("domain_name_servers", value);
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
    /// The ipv6_address_preferred_lease_time attribute.
    /// </summary>
    public TerraformProperty<string>? Ipv6AddressPreferredLeaseTime
    {
        get => GetProperty<TerraformProperty<string>>("ipv6_address_preferred_lease_time");
        set => this.WithProperty("ipv6_address_preferred_lease_time", value);
    }

    /// <summary>
    /// The netbios_name_servers attribute.
    /// </summary>
    public TerraformProperty<List<string>>? NetbiosNameServers
    {
        get => GetProperty<TerraformProperty<List<string>>>("netbios_name_servers");
        set => this.WithProperty("netbios_name_servers", value);
    }

    /// <summary>
    /// The netbios_node_type attribute.
    /// </summary>
    public TerraformProperty<string>? NetbiosNodeType
    {
        get => GetProperty<TerraformProperty<string>>("netbios_node_type");
        set => this.WithProperty("netbios_node_type", value);
    }

    /// <summary>
    /// The ntp_servers attribute.
    /// </summary>
    public TerraformProperty<List<string>>? NtpServers
    {
        get => GetProperty<TerraformProperty<List<string>>>("ntp_servers");
        set => this.WithProperty("ntp_servers", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMapProperty<string>? TagsAll
    {
        get => GetProperty<TerraformMapProperty<string>>("tags_all");
        set => this.WithProperty("tags_all", value);
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
