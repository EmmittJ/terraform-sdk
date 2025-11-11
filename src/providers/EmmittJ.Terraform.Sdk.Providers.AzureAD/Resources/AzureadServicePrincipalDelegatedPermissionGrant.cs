using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzureadServicePrincipalDelegatedPermissionGrantTimeoutsBlock : TerraformBlockBase
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azuread_service_principal_delegated_permission_grant resource.
/// </summary>
public partial class AzureadServicePrincipalDelegatedPermissionGrant : TerraformResource
{
    public AzureadServicePrincipalDelegatedPermissionGrant(string name) : base("azuread_service_principal_delegated_permission_grant", name)
    {
    }

    /// <summary>
    /// A set of claim values for delegated permission scopes which should be included in access tokens for the resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClaimValues is required")]
    [TerraformProperty("claim_values")]
    // Required argument - source generator will implement get/set
    public required TerraformSet<string> ClaimValues { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The object ID of the service principal representing the resource to be accessed
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceServicePrincipalObjectId is required")]
    [TerraformProperty("resource_service_principal_object_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceServicePrincipalObjectId { get; set; }

    /// <summary>
    /// The object ID of the service principal for which this delegated permission grant should be created
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServicePrincipalObjectId is required")]
    [TerraformProperty("service_principal_object_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ServicePrincipalObjectId { get; set; }

    /// <summary>
    /// The object ID of the user on behalf of whom the service principal is authorized to access the resource
    /// </summary>
    [TerraformProperty("user_object_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? UserObjectId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzureadServicePrincipalDelegatedPermissionGrantTimeoutsBlock>? Timeouts { get; set; }

}
