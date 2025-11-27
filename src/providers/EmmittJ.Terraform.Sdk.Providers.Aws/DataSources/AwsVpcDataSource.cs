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
        get => new TerraformReference<string>(this, "read");
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
        get => new TerraformReference<string>(this, "cidr_block");
        set => SetArgument("cidr_block", value);
    }

    /// <summary>
    /// The default attribute.
    /// </summary>
    public TerraformValue<bool> DefaultAttribute
    {
        get => new TerraformReference<bool>(this, "default");
        set => SetArgument("default", value);
    }

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
    /// The state attribute.
    /// </summary>
    public TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
        set => SetArgument("state", value);
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
    /// The cidr_block_associations attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> CidrBlockAssociations
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "cidr_block_associations").ResolveNodes(ctx));
    }

    /// <summary>
    /// The enable_dns_hostnames attribute.
    /// </summary>
    public TerraformValue<bool> EnableDnsHostnames
    {
        get => new TerraformReference<bool>(this, "enable_dns_hostnames");
    }

    /// <summary>
    /// The enable_dns_support attribute.
    /// </summary>
    public TerraformValue<bool> EnableDnsSupport
    {
        get => new TerraformReference<bool>(this, "enable_dns_support");
    }

    /// <summary>
    /// The enable_network_address_usage_metrics attribute.
    /// </summary>
    public TerraformValue<bool> EnableNetworkAddressUsageMetrics
    {
        get => new TerraformReference<bool>(this, "enable_network_address_usage_metrics");
    }

    /// <summary>
    /// The instance_tenancy attribute.
    /// </summary>
    public TerraformValue<string> InstanceTenancy
    {
        get => new TerraformReference<string>(this, "instance_tenancy");
    }

    /// <summary>
    /// The ipv6_association_id attribute.
    /// </summary>
    public TerraformValue<string> Ipv6AssociationId
    {
        get => new TerraformReference<string>(this, "ipv6_association_id");
    }

    /// <summary>
    /// The ipv6_cidr_block attribute.
    /// </summary>
    public TerraformValue<string> Ipv6CidrBlock
    {
        get => new TerraformReference<string>(this, "ipv6_cidr_block");
    }

    /// <summary>
    /// The main_route_table_id attribute.
    /// </summary>
    public TerraformValue<string> MainRouteTableId
    {
        get => new TerraformReference<string>(this, "main_route_table_id");
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
