using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermVmwareExpressRouteAuthorizationTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_vmware_express_route_authorization resource.
/// </summary>
public partial class AzurermVmwareExpressRouteAuthorization : TerraformResource
{
    public AzurermVmwareExpressRouteAuthorization(string name) : base("azurerm_vmware_express_route_authorization", name)
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
    /// The private_cloud_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivateCloudId is required")]
    [TerraformProperty("private_cloud_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PrivateCloudId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermVmwareExpressRouteAuthorizationTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The express_route_authorization_id attribute.
    /// </summary>
    [TerraformProperty("express_route_authorization_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ExpressRouteAuthorizationId { get; }

    /// <summary>
    /// The express_route_authorization_key attribute.
    /// </summary>
    [TerraformProperty("express_route_authorization_key")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ExpressRouteAuthorizationKey { get; }

}
