using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermNatGatewayPublicIpPrefixAssociationTimeoutsBlock : TerraformBlockBase
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

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Manages a azurerm_nat_gateway_public_ip_prefix_association resource.
/// </summary>
public partial class AzurermNatGatewayPublicIpPrefixAssociation : TerraformResource
{
    public AzurermNatGatewayPublicIpPrefixAssociation(string name) : base("azurerm_nat_gateway_public_ip_prefix_association", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The nat_gateway_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NatGatewayId is required")]
    [TerraformProperty("nat_gateway_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> NatGatewayId { get; set; }

    /// <summary>
    /// The public_ip_prefix_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PublicIpPrefixId is required")]
    [TerraformProperty("public_ip_prefix_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> PublicIpPrefixId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermNatGatewayPublicIpPrefixAssociationTimeoutsBlock>? Timeouts { get; set; }

}
