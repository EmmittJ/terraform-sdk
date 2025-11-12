using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermNatGatewayDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_nat_gateway.
/// </summary>
public partial class AzurermNatGatewayDataSource : TerraformDataSource
{
    public AzurermNatGatewayDataSource(string name) : base("azurerm_nat_gateway", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The public_ip_address_ids attribute.
    /// </summary>
    [TerraformProperty("public_ip_address_ids")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformList<string> PublicIpAddressIds { get; set; }

    /// <summary>
    /// The public_ip_prefix_ids attribute.
    /// </summary>
    [TerraformProperty("public_ip_prefix_ids")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformList<string> PublicIpPrefixIds { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermNatGatewayDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The idle_timeout_in_minutes attribute.
    /// </summary>
    [TerraformProperty("idle_timeout_in_minutes")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> IdleTimeoutInMinutes { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Location { get; }

    /// <summary>
    /// The resource_guid attribute.
    /// </summary>
    [TerraformProperty("resource_guid")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ResourceGuid { get; }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [TerraformProperty("sku_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SkuName { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Tags { get; }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [TerraformProperty("zones")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> Zones { get; }

}
