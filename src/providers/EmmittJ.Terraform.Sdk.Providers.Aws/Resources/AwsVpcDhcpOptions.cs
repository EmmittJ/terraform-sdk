using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_vpc_dhcp_options Terraform resource.
/// Manages a aws_vpc_dhcp_options resource.
/// </summary>
public partial class AwsVpcDhcpOptions(string name) : TerraformResource("aws_vpc_dhcp_options", name)
{
    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    public TerraformValue<string>? DomainName
    {
        get => GetArgument<TerraformValue<string>>("domain_name");
        set => SetArgument("domain_name", value);
    }

    /// <summary>
    /// The domain_name_servers attribute.
    /// </summary>
    public TerraformList<string>? DomainNameServers
    {
        get => GetArgument<TerraformList<string>>("domain_name_servers");
        set => SetArgument("domain_name_servers", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The ipv6_address_preferred_lease_time attribute.
    /// </summary>
    public TerraformValue<string>? Ipv6AddressPreferredLeaseTime
    {
        get => GetArgument<TerraformValue<string>>("ipv6_address_preferred_lease_time");
        set => SetArgument("ipv6_address_preferred_lease_time", value);
    }

    /// <summary>
    /// The netbios_name_servers attribute.
    /// </summary>
    public TerraformList<string>? NetbiosNameServers
    {
        get => GetArgument<TerraformList<string>>("netbios_name_servers");
        set => SetArgument("netbios_name_servers", value);
    }

    /// <summary>
    /// The netbios_node_type attribute.
    /// </summary>
    public TerraformValue<string>? NetbiosNodeType
    {
        get => GetArgument<TerraformValue<string>>("netbios_node_type");
        set => SetArgument("netbios_node_type", value);
    }

    /// <summary>
    /// The ntp_servers attribute.
    /// </summary>
    public TerraformList<string>? NtpServers
    {
        get => GetArgument<TerraformList<string>>("ntp_servers");
        set => SetArgument("ntp_servers", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? AsReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformValue<string> OwnerId
        => AsReference("owner_id");

}
