using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for open_api in .
/// Nesting mode: list
/// </summary>
public partial class AzurermSpringCloudGatewayRouteConfigOpenApiBlock : TerraformBlockBase
{
    /// <summary>
    /// The uri attribute.
    /// </summary>
    [TerraformProperty("uri")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Uri { get; set; }

}

/// <summary>
/// Block type for route in .
/// Nesting mode: set
/// </summary>
public partial class AzurermSpringCloudGatewayRouteConfigRouteBlock : TerraformBlockBase
{
    /// <summary>
    /// The classification_tags attribute.
    /// </summary>
    [TerraformProperty("classification_tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? ClassificationTags { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The filters attribute.
    /// </summary>
    [TerraformProperty("filters")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? Filters { get; set; }

    /// <summary>
    /// The order attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Order is required")]
    [TerraformProperty("order")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> Order { get; set; }

    /// <summary>
    /// The predicates attribute.
    /// </summary>
    [TerraformProperty("predicates")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? Predicates { get; set; }

    /// <summary>
    /// The sso_validation_enabled attribute.
    /// </summary>
    [TerraformProperty("sso_validation_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? SsoValidationEnabled { get; set; }

    /// <summary>
    /// The title attribute.
    /// </summary>
    [TerraformProperty("title")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Title { get; set; }

    /// <summary>
    /// The token_relay attribute.
    /// </summary>
    [TerraformProperty("token_relay")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? TokenRelay { get; set; }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    [TerraformProperty("uri")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Uri { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermSpringCloudGatewayRouteConfigTimeoutsBlock : TerraformBlockBase
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_spring_cloud_gateway_route_config resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermSpringCloudGatewayRouteConfig : TerraformResource
{
    public AzurermSpringCloudGatewayRouteConfig(string name) : base("azurerm_spring_cloud_gateway_route_config", name)
    {
    }

    /// <summary>
    /// The filters attribute.
    /// </summary>
    [TerraformProperty("filters")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? Filters { get; set; }

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
    /// The predicates attribute.
    /// </summary>
    [TerraformProperty("predicates")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? Predicates { get; set; }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    [TerraformProperty("protocol")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Protocol { get; set; }

    /// <summary>
    /// The spring_cloud_app_id attribute.
    /// </summary>
    [TerraformProperty("spring_cloud_app_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SpringCloudAppId { get; set; }

    /// <summary>
    /// The spring_cloud_gateway_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpringCloudGatewayId is required")]
    [TerraformProperty("spring_cloud_gateway_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SpringCloudGatewayId { get; set; }

    /// <summary>
    /// The sso_validation_enabled attribute.
    /// </summary>
    [TerraformProperty("sso_validation_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? SsoValidationEnabled { get; set; }

    /// <summary>
    /// Block for open_api.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OpenApi block(s) allowed")]
    [TerraformProperty("open_api")]
    public partial TerraformList<TerraformBlock<AzurermSpringCloudGatewayRouteConfigOpenApiBlock>>? OpenApi { get; set; }

    /// <summary>
    /// Block for route.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("route")]
    public partial TerraformSet<TerraformBlock<AzurermSpringCloudGatewayRouteConfigRouteBlock>>? Route { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermSpringCloudGatewayRouteConfigTimeoutsBlock>? Timeouts { get; set; }

}
