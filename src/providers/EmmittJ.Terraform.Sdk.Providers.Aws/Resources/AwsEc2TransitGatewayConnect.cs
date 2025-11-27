using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsEc2TransitGatewayConnect.
/// Nesting mode: single
/// </summary>
public class AwsEc2TransitGatewayConnectTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_ec2_transit_gateway_connect Terraform resource.
/// Manages a aws_ec2_transit_gateway_connect resource.
/// </summary>
public partial class AwsEc2TransitGatewayConnect(string name) : TerraformResource("aws_ec2_transit_gateway_connect", name)
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
    /// The protocol attribute.
    /// </summary>
    public TerraformValue<string>? Protocol
    {
        get => new TerraformReference<string>(this, "protocol");
        set => SetArgument("protocol", value);
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
    /// The transit_gateway_default_route_table_association attribute.
    /// </summary>
    public TerraformValue<bool>? TransitGatewayDefaultRouteTableAssociation
    {
        get => new TerraformReference<bool>(this, "transit_gateway_default_route_table_association");
        set => SetArgument("transit_gateway_default_route_table_association", value);
    }

    /// <summary>
    /// The transit_gateway_default_route_table_propagation attribute.
    /// </summary>
    public TerraformValue<bool>? TransitGatewayDefaultRouteTablePropagation
    {
        get => new TerraformReference<bool>(this, "transit_gateway_default_route_table_propagation");
        set => SetArgument("transit_gateway_default_route_table_propagation", value);
    }

    /// <summary>
    /// The transit_gateway_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TransitGatewayId is required")]
    public required TerraformValue<string> TransitGatewayId
    {
        get => new TerraformReference<string>(this, "transit_gateway_id");
        set => SetArgument("transit_gateway_id", value);
    }

    /// <summary>
    /// The transport_attachment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TransportAttachmentId is required")]
    public required TerraformValue<string> TransportAttachmentId
    {
        get => new TerraformReference<string>(this, "transport_attachment_id");
        set => SetArgument("transport_attachment_id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsEc2TransitGatewayConnectTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsEc2TransitGatewayConnectTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
