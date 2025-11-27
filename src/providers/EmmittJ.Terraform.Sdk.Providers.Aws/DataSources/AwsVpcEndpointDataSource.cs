using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in AwsVpcEndpointDataSource.
/// Nesting mode: set
/// </summary>
public class AwsVpcEndpointDataSourceFilterBlock : TerraformBlock
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
/// Block type for timeouts in AwsVpcEndpointDataSource.
/// Nesting mode: single
/// </summary>
public class AwsVpcEndpointDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a aws_vpc_endpoint Terraform data source.
/// Retrieves information about a aws_vpc_endpoint.
/// </summary>
public partial class AwsVpcEndpointDataSource(string name) : TerraformDataSource("aws_vpc_endpoint", name)
{
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
    /// The service_name attribute.
    /// </summary>
    public TerraformValue<string> ServiceName
    {
        get => new TerraformReference<string>(this, "service_name");
        set => SetArgument("service_name", value);
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
    /// The vpc_id attribute.
    /// </summary>
    public TerraformValue<string> VpcId
    {
        get => new TerraformReference<string>(this, "vpc_id");
        set => SetArgument("vpc_id", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The cidr_blocks attribute.
    /// </summary>
    public TerraformList<string> CidrBlocks
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "cidr_blocks").ResolveNodes(ctx));
    }

    /// <summary>
    /// The dns_entry attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> DnsEntry
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "dns_entry").ResolveNodes(ctx));
    }

    /// <summary>
    /// The dns_options attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> DnsOptions
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "dns_options").ResolveNodes(ctx));
    }

    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    public TerraformValue<string> IpAddressType
    {
        get => new TerraformReference<string>(this, "ip_address_type");
    }

    /// <summary>
    /// The network_interface_ids attribute.
    /// </summary>
    public TerraformSet<string> NetworkInterfaceIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "network_interface_ids").ResolveNodes(ctx));
    }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformValue<string> OwnerId
    {
        get => new TerraformReference<string>(this, "owner_id");
    }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    public TerraformValue<string> Policy
    {
        get => new TerraformReference<string>(this, "policy");
    }

    /// <summary>
    /// The prefix_list_id attribute.
    /// </summary>
    public TerraformValue<string> PrefixListId
    {
        get => new TerraformReference<string>(this, "prefix_list_id");
    }

    /// <summary>
    /// The private_dns_enabled attribute.
    /// </summary>
    public TerraformValue<bool> PrivateDnsEnabled
    {
        get => new TerraformReference<bool>(this, "private_dns_enabled");
    }

    /// <summary>
    /// The requester_managed attribute.
    /// </summary>
    public TerraformValue<bool> RequesterManaged
    {
        get => new TerraformReference<bool>(this, "requester_managed");
    }

    /// <summary>
    /// The route_table_ids attribute.
    /// </summary>
    public TerraformSet<string> RouteTableIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "route_table_ids").ResolveNodes(ctx));
    }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public TerraformSet<string> SecurityGroupIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "security_group_ids").ResolveNodes(ctx));
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public TerraformSet<string> SubnetIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "subnet_ids").ResolveNodes(ctx));
    }

    /// <summary>
    /// The vpc_endpoint_type attribute.
    /// </summary>
    public TerraformValue<string> VpcEndpointType
    {
        get => new TerraformReference<string>(this, "vpc_endpoint_type");
    }

    /// <summary>
    /// Filter block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsVpcEndpointDataSourceFilterBlock>? Filter
    {
        get => GetArgument<TerraformSet<AwsVpcEndpointDataSourceFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsVpcEndpointDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsVpcEndpointDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
