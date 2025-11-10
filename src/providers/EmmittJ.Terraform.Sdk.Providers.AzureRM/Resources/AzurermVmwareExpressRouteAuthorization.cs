using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermVmwareExpressRouteAuthorizationTimeoutsBlock : ITerraformBlock
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

}

/// <summary>
/// Manages a azurerm_vmware_express_route_authorization resource.
/// </summary>
public class AzurermVmwareExpressRouteAuthorization : TerraformResource
{
    public AzurermVmwareExpressRouteAuthorization(string name) : base("azurerm_vmware_express_route_authorization", name)
    {
    }

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
    /// The private_cloud_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivateCloudId is required")]
    [TerraformPropertyName("private_cloud_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> PrivateCloudId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermVmwareExpressRouteAuthorizationTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The express_route_authorization_id attribute.
    /// </summary>
    [TerraformPropertyName("express_route_authorization_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ExpressRouteAuthorizationId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "express_route_authorization_id");

    /// <summary>
    /// The express_route_authorization_key attribute.
    /// </summary>
    [TerraformPropertyName("express_route_authorization_key")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ExpressRouteAuthorizationKey => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "express_route_authorization_key");

}
