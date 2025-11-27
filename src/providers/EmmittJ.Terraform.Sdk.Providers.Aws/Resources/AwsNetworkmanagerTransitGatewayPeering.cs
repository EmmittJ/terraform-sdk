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
        get => new TerraformReference<string>(this, "core_network_id");
        set => SetArgument("core_network_id", value);
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
    /// The transit_gateway_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TransitGatewayArn is required")]
    public required TerraformValue<string> TransitGatewayArn
    {
        get => new TerraformReference<string>(this, "transit_gateway_arn");
        set => SetArgument("transit_gateway_arn", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The core_network_arn attribute.
    /// </summary>
    public TerraformValue<string> CoreNetworkArn
    {
        get => new TerraformReference<string>(this, "core_network_arn");
    }

    /// <summary>
    /// The edge_location attribute.
    /// </summary>
    public TerraformValue<string> EdgeLocation
    {
        get => new TerraformReference<string>(this, "edge_location");
    }

    /// <summary>
    /// The owner_account_id attribute.
    /// </summary>
    public TerraformValue<string> OwnerAccountId
    {
        get => new TerraformReference<string>(this, "owner_account_id");
    }

    /// <summary>
    /// The peering_type attribute.
    /// </summary>
    public TerraformValue<string> PeeringType
    {
        get => new TerraformReference<string>(this, "peering_type");
    }

    /// <summary>
    /// The resource_arn attribute.
    /// </summary>
    public TerraformValue<string> ResourceArn
    {
        get => new TerraformReference<string>(this, "resource_arn");
    }

    /// <summary>
    /// The transit_gateway_peering_attachment_id attribute.
    /// </summary>
    public TerraformValue<string> TransitGatewayPeeringAttachmentId
    {
        get => new TerraformReference<string>(this, "transit_gateway_peering_attachment_id");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsNetworkmanagerTransitGatewayPeeringTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsNetworkmanagerTransitGatewayPeeringTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
