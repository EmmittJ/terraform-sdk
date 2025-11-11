using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzureadApplicationPreAuthorizedTimeoutsBlock : TerraformBlockBase
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
/// Manages a azuread_application_pre_authorized resource.
/// </summary>
public partial class AzureadApplicationPreAuthorized : TerraformResource
{
    public AzureadApplicationPreAuthorized(string name) : base("azuread_application_pre_authorized", name)
    {
    }

    /// <summary>
    /// The resource ID of the application to which this pre-authorized application should be added
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationId is required")]
    [TerraformProperty("application_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ApplicationId { get; set; }

    /// <summary>
    /// The client ID of the pre-authorized application
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthorizedClientId is required")]
    [TerraformProperty("authorized_client_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> AuthorizedClientId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The IDs of the permission scopes required by the pre-authorized application
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PermissionIds is required")]
    [TerraformProperty("permission_ids")]
    // Required argument - source generator will implement get/set
    public required TerraformSet<string> PermissionIds { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzureadApplicationPreAuthorizedTimeoutsBlock>? Timeouts { get; set; }

}
