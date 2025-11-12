using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermExpressRoutePortAuthorizationTimeoutsBlock() : TerraformBlock("timeouts")
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

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Manages a azurerm_express_route_port_authorization resource.
/// </summary>
public partial class AzurermExpressRoutePortAuthorization : TerraformResource
{
    public AzurermExpressRoutePortAuthorization(string name) : base("azurerm_express_route_port_authorization", name)
    {
    }

    /// <summary>
    /// The express_route_port_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExpressRoutePortName is required")]
    [TerraformProperty("express_route_port_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ExpressRoutePortName { get; set; }

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
    public AzurermExpressRoutePortAuthorizationTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The authorization_key attribute.
    /// </summary>
    [TerraformProperty("authorization_key")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AuthorizationKey { get; }

    /// <summary>
    /// The authorization_use_status attribute.
    /// </summary>
    [TerraformProperty("authorization_use_status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AuthorizationUseStatus { get; }

}
