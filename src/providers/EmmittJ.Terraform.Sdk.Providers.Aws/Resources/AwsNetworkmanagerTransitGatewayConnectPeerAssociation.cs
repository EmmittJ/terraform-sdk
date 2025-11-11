using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsNetworkmanagerTransitGatewayConnectPeerAssociationTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

}

/// <summary>
/// Manages a aws_networkmanager_transit_gateway_connect_peer_association resource.
/// </summary>
public partial class AwsNetworkmanagerTransitGatewayConnectPeerAssociation : TerraformResource
{
    public AwsNetworkmanagerTransitGatewayConnectPeerAssociation(string name) : base("aws_networkmanager_transit_gateway_connect_peer_association", name)
    {
    }

    /// <summary>
    /// The device_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeviceId is required")]
    [TerraformProperty("device_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DeviceId { get; set; }

    /// <summary>
    /// The global_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GlobalNetworkId is required")]
    [TerraformProperty("global_network_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> GlobalNetworkId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The link_id attribute.
    /// </summary>
    [TerraformProperty("link_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? LinkId { get; set; }

    /// <summary>
    /// The transit_gateway_connect_peer_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TransitGatewayConnectPeerArn is required")]
    [TerraformProperty("transit_gateway_connect_peer_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TransitGatewayConnectPeerArn { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsNetworkmanagerTransitGatewayConnectPeerAssociationTimeoutsBlock>? Timeouts { get; set; }

}
