using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in AwsEc2LocalGatewayRouteTableDataSource.
/// Nesting mode: set
/// </summary>
public class AwsEc2LocalGatewayRouteTableDataSourceFilterBlock : TerraformBlock
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
/// Block type for timeouts in AwsEc2LocalGatewayRouteTableDataSource.
/// Nesting mode: single
/// </summary>
public class AwsEc2LocalGatewayRouteTableDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a aws_ec2_local_gateway_route_table Terraform data source.
/// Retrieves information about a aws_ec2_local_gateway_route_table.
/// </summary>
public partial class AwsEc2LocalGatewayRouteTableDataSource(string name) : TerraformDataSource("aws_ec2_local_gateway_route_table", name)
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
    /// The local_gateway_id attribute.
    /// </summary>
    public TerraformValue<string> LocalGatewayId
    {
        get => new TerraformReference<string>(this, "local_gateway_id");
        set => SetArgument("local_gateway_id", value);
    }

    /// <summary>
    /// The local_gateway_route_table_id attribute.
    /// </summary>
    public TerraformValue<string> LocalGatewayRouteTableId
    {
        get => new TerraformReference<string>(this, "local_gateway_route_table_id");
        set => SetArgument("local_gateway_route_table_id", value);
    }

    /// <summary>
    /// The outpost_arn attribute.
    /// </summary>
    public TerraformValue<string> OutpostArn
    {
        get => new TerraformReference<string>(this, "outpost_arn");
        set => SetArgument("outpost_arn", value);
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
    /// Filter block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsEc2LocalGatewayRouteTableDataSourceFilterBlock>? Filter
    {
        get => GetArgument<TerraformSet<AwsEc2LocalGatewayRouteTableDataSourceFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsEc2LocalGatewayRouteTableDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsEc2LocalGatewayRouteTableDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
