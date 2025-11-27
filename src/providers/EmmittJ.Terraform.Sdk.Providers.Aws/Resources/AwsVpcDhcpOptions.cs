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
        get => new TerraformReference<string>(this, "domain_name");
        set => SetArgument("domain_name", value);
    }

    /// <summary>
    /// The domain_name_servers attribute.
    /// </summary>
    public TerraformList<string>? DomainNameServers
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "domain_name_servers").ResolveNodes(ctx));
        set => SetArgument("domain_name_servers", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The ipv6_address_preferred_lease_time attribute.
    /// </summary>
    public TerraformValue<string>? Ipv6AddressPreferredLeaseTime
    {
        get => new TerraformReference<string>(this, "ipv6_address_preferred_lease_time");
        set => SetArgument("ipv6_address_preferred_lease_time", value);
    }

    /// <summary>
    /// The netbios_name_servers attribute.
    /// </summary>
    public TerraformList<string>? NetbiosNameServers
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "netbios_name_servers").ResolveNodes(ctx));
        set => SetArgument("netbios_name_servers", value);
    }

    /// <summary>
    /// The netbios_node_type attribute.
    /// </summary>
    public TerraformValue<string>? NetbiosNodeType
    {
        get => new TerraformReference<string>(this, "netbios_node_type");
        set => SetArgument("netbios_node_type", value);
    }

    /// <summary>
    /// The ntp_servers attribute.
    /// </summary>
    public TerraformList<string>? NtpServers
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "ntp_servers").ResolveNodes(ctx));
        set => SetArgument("ntp_servers", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformValue<string> OwnerId
    {
        get => new TerraformReference<string>(this, "owner_id");
    }

}
