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
        SetOutput("arn");
        SetOutput("owner_id");
        SetOutput("domain_name");
        SetOutput("domain_name_servers");
        SetOutput("id");
        SetOutput("ipv6_address_preferred_lease_time");
        SetOutput("netbios_name_servers");
        SetOutput("netbios_node_type");
        SetOutput("ntp_servers");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    public TerraformProperty<string> DomainName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("domain_name");
        set => SetProperty("domain_name", value);
    }

    /// <summary>
    /// The domain_name_servers attribute.
    /// </summary>
    public List<TerraformProperty<string>> DomainNameServers
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("domain_name_servers");
        set => SetProperty("domain_name_servers", value);
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
    /// The ipv6_address_preferred_lease_time attribute.
    /// </summary>
    public TerraformProperty<string> Ipv6AddressPreferredLeaseTime
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ipv6_address_preferred_lease_time");
        set => SetProperty("ipv6_address_preferred_lease_time", value);
    }

    /// <summary>
    /// The netbios_name_servers attribute.
    /// </summary>
    public List<TerraformProperty<string>> NetbiosNameServers
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("netbios_name_servers");
        set => SetProperty("netbios_name_servers", value);
    }

    /// <summary>
    /// The netbios_node_type attribute.
    /// </summary>
    public TerraformProperty<string> NetbiosNodeType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("netbios_node_type");
        set => SetProperty("netbios_node_type", value);
    }

    /// <summary>
    /// The ntp_servers attribute.
    /// </summary>
    public List<TerraformProperty<string>> NtpServers
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("ntp_servers");
        set => SetProperty("ntp_servers", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformExpression OwnerId => this["owner_id"];

}
