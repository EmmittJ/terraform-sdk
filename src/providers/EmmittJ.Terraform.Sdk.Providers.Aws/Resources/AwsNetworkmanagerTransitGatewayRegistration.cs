using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsNetworkmanagerTransitGatewayRegistrationTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

}

/// <summary>
/// Manages a aws_networkmanager_transit_gateway_registration resource.
/// </summary>
public partial class AwsNetworkmanagerTransitGatewayRegistration : TerraformResource
{
    public AwsNetworkmanagerTransitGatewayRegistration(string name) : base("aws_networkmanager_transit_gateway_registration", name)
    {
    }

    /// <summary>
    /// The global_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GlobalNetworkId is required")]
    [TerraformProperty("global_network_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> GlobalNetworkId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The transit_gateway_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TransitGatewayArn is required")]
    [TerraformProperty("transit_gateway_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> TransitGatewayArn { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AwsNetworkmanagerTransitGatewayRegistrationTimeoutsBlock>? Timeouts { get; set; }

}
