using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for open_api in .
/// Nesting mode: list
/// </summary>
public class AzurermSpringCloudGatewayRouteConfigOpenApiBlock : ITerraformBlock
{
    /// <summary>
    /// The uri attribute.
    /// </summary>
    [TerraformPropertyName("uri")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Uri { get; set; }

}

/// <summary>
/// Block type for route in .
/// Nesting mode: set
/// </summary>
public class AzurermSpringCloudGatewayRouteConfigRouteBlock : ITerraformBlock
{
    /// <summary>
    /// The classification_tags attribute.
    /// </summary>
    [TerraformPropertyName("classification_tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? ClassificationTags { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The filters attribute.
    /// </summary>
    [TerraformPropertyName("filters")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Filters { get; set; }

    /// <summary>
    /// The order attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Order is required")]
    [TerraformPropertyName("order")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> Order { get; set; }

    /// <summary>
    /// The predicates attribute.
    /// </summary>
    [TerraformPropertyName("predicates")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Predicates { get; set; }

    /// <summary>
    /// The sso_validation_enabled attribute.
    /// </summary>
    [TerraformPropertyName("sso_validation_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? SsoValidationEnabled { get; set; }

    /// <summary>
    /// The title attribute.
    /// </summary>
    [TerraformPropertyName("title")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Title { get; set; }

    /// <summary>
    /// The token_relay attribute.
    /// </summary>
    [TerraformPropertyName("token_relay")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? TokenRelay { get; set; }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    [TerraformPropertyName("uri")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Uri { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSpringCloudGatewayRouteConfigTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_spring_cloud_gateway_route_config resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermSpringCloudGatewayRouteConfig : TerraformResource
{
    public AzurermSpringCloudGatewayRouteConfig(string name) : base("azurerm_spring_cloud_gateway_route_config", name)
    {
    }

    /// <summary>
    /// The filters attribute.
    /// </summary>
    [TerraformPropertyName("filters")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Filters { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The predicates attribute.
    /// </summary>
    [TerraformPropertyName("predicates")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Predicates { get; set; }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    [TerraformPropertyName("protocol")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Protocol { get; set; }

    /// <summary>
    /// The spring_cloud_app_id attribute.
    /// </summary>
    [TerraformPropertyName("spring_cloud_app_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SpringCloudAppId { get; set; }

    /// <summary>
    /// The spring_cloud_gateway_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpringCloudGatewayId is required")]
    [TerraformPropertyName("spring_cloud_gateway_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SpringCloudGatewayId { get; set; }

    /// <summary>
    /// The sso_validation_enabled attribute.
    /// </summary>
    [TerraformPropertyName("sso_validation_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? SsoValidationEnabled { get; set; }

    /// <summary>
    /// Block for open_api.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OpenApi block(s) allowed")]
    [TerraformPropertyName("open_api")]
    public TerraformList<TerraformBlock<AzurermSpringCloudGatewayRouteConfigOpenApiBlock>>? OpenApi { get; set; } = new();

    /// <summary>
    /// Block for route.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("route")]
    public TerraformSet<TerraformBlock<AzurermSpringCloudGatewayRouteConfigRouteBlock>>? Route { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermSpringCloudGatewayRouteConfigTimeoutsBlock>? Timeouts { get; set; } = new();

}
