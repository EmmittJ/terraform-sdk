using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzureadApplicationPermissionScopeTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azuread_application_permission_scope resource.
/// </summary>
public partial class AzureadApplicationPermissionScope : TerraformResource
{
    public AzureadApplicationPermissionScope(string name) : base("azuread_application_permission_scope", name)
    {
    }

    /// <summary>
    /// Delegated permission description that appears in all tenant-wide admin consent experiences, intended to be read by an administrator granting the permission on behalf of all users
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdminConsentDescription is required")]
    [TerraformProperty("admin_consent_description")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AdminConsentDescription { get; set; }

    /// <summary>
    /// Display name for the delegated permission, intended to be read by an administrator granting the permission on behalf of all users
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdminConsentDisplayName is required")]
    [TerraformProperty("admin_consent_display_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AdminConsentDisplayName { get; set; }

    /// <summary>
    /// The resource ID of the application to which this permission scope should be applied
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationId is required")]
    [TerraformProperty("application_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ApplicationId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The unique identifier of the permission scope
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScopeId is required")]
    [TerraformProperty("scope_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ScopeId { get; set; }

    /// <summary>
    /// Whether this delegated permission should be considered safe for non-admin users to consent to on behalf of themselves, or whether an administrator should be required for consent to the permissions
    /// </summary>
    [TerraformProperty("type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Type { get; set; }

    /// <summary>
    /// Delegated permission description that appears in the end user consent experience, intended to be read by a user consenting on their own behalf
    /// </summary>
    [TerraformProperty("user_consent_description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? UserConsentDescription { get; set; }

    /// <summary>
    /// Display name for the delegated permission that appears in the end user consent experience
    /// </summary>
    [TerraformProperty("user_consent_display_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? UserConsentDisplayName { get; set; }

    /// <summary>
    /// The value that is used for the `scp` claim in OAuth access tokens
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    [TerraformProperty("value")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Value { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzureadApplicationPermissionScopeTimeoutsBlock Timeouts { get; set; } = new();

}
