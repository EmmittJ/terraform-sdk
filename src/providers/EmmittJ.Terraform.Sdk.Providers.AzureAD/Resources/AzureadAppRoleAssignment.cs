using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzureadAppRoleAssignmentTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azuread_app_role_assignment resource.
/// </summary>
public partial class AzureadAppRoleAssignment : TerraformResource
{
    public AzureadAppRoleAssignment(string name) : base("azuread_app_role_assignment", name)
    {
    }

    /// <summary>
    /// The ID of the app role to be assigned
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppRoleId is required")]
    [TerraformProperty("app_role_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AppRoleId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The object ID of the user, group or service principal to be assigned this app role
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrincipalObjectId is required")]
    [TerraformProperty("principal_object_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PrincipalObjectId { get; set; }

    /// <summary>
    /// The object ID of the service principal representing the resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceObjectId is required")]
    [TerraformProperty("resource_object_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceObjectId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzureadAppRoleAssignmentTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The display name of the principal to which the app role is assigned
    /// </summary>
    [TerraformProperty("principal_display_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrincipalDisplayName { get; }

    /// <summary>
    /// The object type of the principal to which the app role is assigned
    /// </summary>
    [TerraformProperty("principal_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrincipalType { get; }

    /// <summary>
    /// The display name of the application representing the resource
    /// </summary>
    [TerraformProperty("resource_display_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ResourceDisplayName { get; }

}
