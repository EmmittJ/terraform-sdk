using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadServicePrincipalDelegatedPermissionGrantTimeoutsBlock : ITerraformBlock
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
/// Manages a azuread_service_principal_delegated_permission_grant resource.
/// </summary>
public class AzureadServicePrincipalDelegatedPermissionGrant : TerraformResource
{
    public AzureadServicePrincipalDelegatedPermissionGrant(string name) : base("azuread_service_principal_delegated_permission_grant", name)
    {
    }

    /// <summary>
    /// A set of claim values for delegated permission scopes which should be included in access tokens for the resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClaimValues is required")]
    [TerraformPropertyName("claim_values")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? ClaimValues { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The object ID of the service principal representing the resource to be accessed
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceServicePrincipalObjectId is required")]
    [TerraformPropertyName("resource_service_principal_object_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceServicePrincipalObjectId { get; set; }

    /// <summary>
    /// The object ID of the service principal for which this delegated permission grant should be created
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServicePrincipalObjectId is required")]
    [TerraformPropertyName("service_principal_object_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ServicePrincipalObjectId { get; set; }

    /// <summary>
    /// The object ID of the user on behalf of whom the service principal is authorized to access the resource
    /// </summary>
    [TerraformPropertyName("user_object_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? UserObjectId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzureadServicePrincipalDelegatedPermissionGrantTimeoutsBlock>? Timeouts { get; set; } = new();

}
