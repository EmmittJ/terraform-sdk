using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in AwsEc2TransitGatewayRouteTablePropagationsDataSource.
/// Nesting mode: set
/// </summary>
public class AwsEc2TransitGatewayRouteTablePropagationsDataSourceFilterBlock : TerraformBlock
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
/// Block type for timeouts in AwsEc2TransitGatewayRouteTablePropagationsDataSource.
/// Nesting mode: single
/// </summary>
public class AwsEc2TransitGatewayRouteTablePropagationsDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a aws_ec2_transit_gateway_route_table_propagations Terraform data source.
/// Retrieves information about a aws_ec2_transit_gateway_route_table_propagations.
/// </summary>
public partial class AwsEc2TransitGatewayRouteTablePropagationsDataSource(string name) : TerraformDataSource("aws_ec2_transit_gateway_route_table_propagations", name)
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
    /// The transit_gateway_route_table_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TransitGatewayRouteTableId is required")]
    public required TerraformValue<string> TransitGatewayRouteTableId
    {
        get => new TerraformReference<string>(this, "transit_gateway_route_table_id");
        set => SetArgument("transit_gateway_route_table_id", value);
    }

    /// <summary>
    /// The ids attribute.
    /// </summary>
    public TerraformList<string> Ids
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "ids").ResolveNodes(ctx));
    }

    /// <summary>
    /// Filter block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsEc2TransitGatewayRouteTablePropagationsDataSourceFilterBlock>? Filter
    {
        get => GetArgument<TerraformSet<AwsEc2TransitGatewayRouteTablePropagationsDataSourceFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsEc2TransitGatewayRouteTablePropagationsDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsEc2TransitGatewayRouteTablePropagationsDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
