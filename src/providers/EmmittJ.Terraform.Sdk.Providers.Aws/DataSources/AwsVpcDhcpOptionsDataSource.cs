using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in AwsVpcDhcpOptionsDataSource.
/// Nesting mode: set
/// </summary>
public class AwsVpcDhcpOptionsDataSourceFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filter";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public required TerraformSet<string> ValuesAttribute
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "values").ResolveNodes(ctx));
        set => SetArgument("values", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsVpcDhcpOptionsDataSource.
/// Nesting mode: single
/// </summary>
public class AwsVpcDhcpOptionsDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a aws_vpc_dhcp_options Terraform data source.
/// Retrieves information about a aws_vpc_dhcp_options.
/// </summary>
public partial class AwsVpcDhcpOptionsDataSource(string name) : TerraformDataSource("aws_vpc_dhcp_options", name)
{
    /// <summary>
    /// The dhcp_options_id attribute.
    /// </summary>
    public TerraformValue<string> DhcpOptionsId
    {
        get => new TerraformReference<string>(this, "dhcp_options_id");
        set => SetArgument("dhcp_options_id", value);
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
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    public TerraformValue<string> DomainName
    {
        get => new TerraformReference<string>(this, "domain_name");
    }

    /// <summary>
    /// The domain_name_servers attribute.
    /// </summary>
    public TerraformList<string> DomainNameServers
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "domain_name_servers").ResolveNodes(ctx));
    }

    /// <summary>
    /// The ipv6_address_preferred_lease_time attribute.
    /// </summary>
    public TerraformValue<string> Ipv6AddressPreferredLeaseTime
    {
        get => new TerraformReference<string>(this, "ipv6_address_preferred_lease_time");
    }

    /// <summary>
    /// The netbios_name_servers attribute.
    /// </summary>
    public TerraformList<string> NetbiosNameServers
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "netbios_name_servers").ResolveNodes(ctx));
    }

    /// <summary>
    /// The netbios_node_type attribute.
    /// </summary>
    public TerraformValue<string> NetbiosNodeType
    {
        get => new TerraformReference<string>(this, "netbios_node_type");
    }

    /// <summary>
    /// The ntp_servers attribute.
    /// </summary>
    public TerraformList<string> NtpServers
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "ntp_servers").ResolveNodes(ctx));
    }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformValue<string> OwnerId
    {
        get => new TerraformReference<string>(this, "owner_id");
    }

    /// <summary>
    /// Filter block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsVpcDhcpOptionsDataSourceFilterBlock>? Filter
    {
        get => GetArgument<TerraformSet<AwsVpcDhcpOptionsDataSourceFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsVpcDhcpOptionsDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsVpcDhcpOptionsDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
