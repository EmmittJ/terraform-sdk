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
        SetOutput("arn");
        SetOutput("domain_name");
        SetOutput("domain_name_servers");
        SetOutput("ipv6_address_preferred_lease_time");
        SetOutput("netbios_name_servers");
        SetOutput("netbios_node_type");
        SetOutput("ntp_servers");
        SetOutput("id");
        SetOutput("owner_id");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("tags_all");
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
    /// The owner_id attribute.
    /// </summary>
    public TerraformProperty<string> OwnerId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("owner_id");
        set => SetProperty("owner_id", value);
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
