using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in AwsEc2TransitGatewayAttachmentDataSource.
/// Nesting mode: set
/// </summary>
public class AwsEc2TransitGatewayAttachmentDataSourceFilterBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public required TerraformSet<string> ValuesAttribute
    {
        get => GetArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

}


/// <summary>
/// Represents a aws_ec2_transit_gateway_attachment Terraform data source.
/// Retrieves information about a aws_ec2_transit_gateway_attachment.
/// </summary>
public partial class AwsEc2TransitGatewayAttachmentDataSource(string name) : TerraformDataSource("aws_ec2_transit_gateway_attachment", name)
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
    /// The transit_gateway_attachment_id attribute.
    /// </summary>
    public TerraformValue<string>? TransitGatewayAttachmentId
    {
        get => GetArgument<TerraformValue<string>>("transit_gateway_attachment_id");
        set => SetArgument("transit_gateway_attachment_id", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The association_state attribute.
    /// </summary>
    public TerraformValue<string> AssociationState
        => AsReference("association_state");

    /// <summary>
    /// The association_transit_gateway_route_table_id attribute.
    /// </summary>
    public TerraformValue<string> AssociationTransitGatewayRouteTableId
        => AsReference("association_transit_gateway_route_table_id");

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    public TerraformValue<string> ResourceId
        => AsReference("resource_id");

    /// <summary>
    /// The resource_owner_id attribute.
    /// </summary>
    public TerraformValue<string> ResourceOwnerId
        => AsReference("resource_owner_id");

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    public TerraformValue<string> ResourceTypeAttribute
        => AsReference("resource_type");

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string> State
        => AsReference("state");

    /// <summary>
    /// The transit_gateway_id attribute.
    /// </summary>
    public TerraformValue<string> TransitGatewayId
        => AsReference("transit_gateway_id");

    /// <summary>
    /// The transit_gateway_owner_id attribute.
    /// </summary>
    public TerraformValue<string> TransitGatewayOwnerId
        => AsReference("transit_gateway_owner_id");

    /// <summary>
    /// Filter block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsEc2TransitGatewayAttachmentDataSourceFilterBlock>? Filter
    {
        get => GetArgument<TerraformSet<AwsEc2TransitGatewayAttachmentDataSourceFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

}
