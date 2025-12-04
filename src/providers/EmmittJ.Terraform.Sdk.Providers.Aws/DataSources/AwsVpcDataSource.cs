using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in AwsVpcDataSource.
/// Nesting mode: set
/// </summary>
public class AwsVpcDataSourceFilterBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public required TerraformSet<string> ValuesAttribute
    {
        get => GetRequiredArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsVpcDataSource.
/// Nesting mode: single
/// </summary>
public class AwsVpcDataSourceTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a aws_vpc Terraform data source.
/// Retrieves information about a aws_vpc.
/// </summary>
public partial class AwsVpcDataSource(string name) : TerraformDataSource("aws_vpc", name)
{
    /// <summary>
    /// The cidr_block attribute.
    /// </summary>
    public TerraformValue<string> CidrBlock
    {
        get => GetArgument<TerraformValue<string>>("cidr_block") ?? AsReference("cidr_block");
        set => SetArgument("cidr_block", value);
    }

    /// <summary>
    /// The default attribute.
    /// </summary>
    public TerraformValue<bool> DefaultAttribute
    {
        get => GetArgument<TerraformValue<bool>>("default") ?? AsReference("default");
        set => SetArgument("default", value);
    }

    /// <summary>
    /// The dhcp_options_id attribute.
    /// </summary>
    public TerraformValue<string> DhcpOptionsId
    {
        get => GetArgument<TerraformValue<string>>("dhcp_options_id") ?? AsReference("dhcp_options_id");
        set => SetArgument("dhcp_options_id", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string> State
    {
        get => GetArgument<TerraformValue<string>>("state") ?? AsReference("state");
        set => SetArgument("state", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => GetArgument<TerraformMap<string>>("tags") ?? AsReference("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The cidr_block_associations attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> CidrBlockAssociations
        => AsReference("cidr_block_associations");

    /// <summary>
    /// The enable_dns_hostnames attribute.
    /// </summary>
    public TerraformValue<bool> EnableDnsHostnames
        => AsReference("enable_dns_hostnames");

    /// <summary>
    /// The enable_dns_support attribute.
    /// </summary>
    public TerraformValue<bool> EnableDnsSupport
        => AsReference("enable_dns_support");

    /// <summary>
    /// The enable_network_address_usage_metrics attribute.
    /// </summary>
    public TerraformValue<bool> EnableNetworkAddressUsageMetrics
        => AsReference("enable_network_address_usage_metrics");

    /// <summary>
    /// The instance_tenancy attribute.
    /// </summary>
    public TerraformValue<string> InstanceTenancy
        => AsReference("instance_tenancy");

    /// <summary>
    /// The ipv6_association_id attribute.
    /// </summary>
    public TerraformValue<string> Ipv6AssociationId
        => AsReference("ipv6_association_id");

    /// <summary>
    /// The ipv6_cidr_block attribute.
    /// </summary>
    public TerraformValue<string> Ipv6CidrBlock
        => AsReference("ipv6_cidr_block");

    /// <summary>
    /// The main_route_table_id attribute.
    /// </summary>
    public TerraformValue<string> MainRouteTableId
        => AsReference("main_route_table_id");

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformValue<string> OwnerId
        => AsReference("owner_id");

    /// <summary>
    /// Filter block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsVpcDataSourceFilterBlock>? Filter
    {
        get => GetArgument<TerraformSet<AwsVpcDataSourceFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsVpcDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsVpcDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
