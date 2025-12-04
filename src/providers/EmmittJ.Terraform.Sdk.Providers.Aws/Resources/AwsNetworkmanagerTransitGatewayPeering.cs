using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsNetworkmanagerTransitGatewayPeering.
/// Nesting mode: single
/// </summary>
public class AwsNetworkmanagerTransitGatewayPeeringTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

}


/// <summary>
/// Represents a aws_networkmanager_transit_gateway_peering Terraform resource.
/// Manages a aws_networkmanager_transit_gateway_peering resource.
/// </summary>
public partial class AwsNetworkmanagerTransitGatewayPeering(string name) : TerraformResource("aws_networkmanager_transit_gateway_peering", name)
{
    /// <summary>
    /// The core_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CoreNetworkId is required")]
    public required TerraformValue<string> CoreNetworkId
    {
        get => GetArgument<TerraformValue<string>>("core_network_id");
        set => SetArgument("core_network_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
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
    /// The transit_gateway_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TransitGatewayArn is required")]
    public required TerraformValue<string> TransitGatewayArn
    {
        get => GetArgument<TerraformValue<string>>("transit_gateway_arn");
        set => SetArgument("transit_gateway_arn", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The core_network_arn attribute.
    /// </summary>
    public TerraformValue<string> CoreNetworkArn
        => AsReference("core_network_arn");

    /// <summary>
    /// The edge_location attribute.
    /// </summary>
    public TerraformValue<string> EdgeLocation
        => AsReference("edge_location");

    /// <summary>
    /// The owner_account_id attribute.
    /// </summary>
    public TerraformValue<string> OwnerAccountId
        => AsReference("owner_account_id");

    /// <summary>
    /// The peering_type attribute.
    /// </summary>
    public TerraformValue<string> PeeringType
        => AsReference("peering_type");

    /// <summary>
    /// The resource_arn attribute.
    /// </summary>
    public TerraformValue<string> ResourceArn
        => AsReference("resource_arn");

    /// <summary>
    /// The transit_gateway_peering_attachment_id attribute.
    /// </summary>
    public TerraformValue<string> TransitGatewayPeeringAttachmentId
        => AsReference("transit_gateway_peering_attachment_id");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsNetworkmanagerTransitGatewayPeeringTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsNetworkmanagerTransitGatewayPeeringTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
