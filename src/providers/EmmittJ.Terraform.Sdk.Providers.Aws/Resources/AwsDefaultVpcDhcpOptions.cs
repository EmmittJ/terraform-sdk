using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_default_vpc_dhcp_options Terraform resource.
/// Manages a aws_default_vpc_dhcp_options resource.
/// </summary>
public partial class AwsDefaultVpcDhcpOptions(string name) : TerraformResource("aws_default_vpc_dhcp_options", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformValue<string>? OwnerId
    {
        get => GetArgument<TerraformValue<string>>("owner_id");
        set => SetArgument("owner_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
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
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    public TerraformValue<string> DomainName
        => AsReference("domain_name");

    /// <summary>
    /// The domain_name_servers attribute.
    /// </summary>
    public TerraformValue<string> DomainNameServers
        => AsReference("domain_name_servers");

    /// <summary>
    /// The ipv6_address_preferred_lease_time attribute.
    /// </summary>
    public TerraformValue<string> Ipv6AddressPreferredLeaseTime
        => AsReference("ipv6_address_preferred_lease_time");

    /// <summary>
    /// The netbios_name_servers attribute.
    /// </summary>
    public TerraformValue<string> NetbiosNameServers
        => AsReference("netbios_name_servers");

    /// <summary>
    /// The netbios_node_type attribute.
    /// </summary>
    public TerraformValue<string> NetbiosNodeType
        => AsReference("netbios_node_type");

    /// <summary>
    /// The ntp_servers attribute.
    /// </summary>
    public TerraformValue<string> NtpServers
        => AsReference("ntp_servers");

}
