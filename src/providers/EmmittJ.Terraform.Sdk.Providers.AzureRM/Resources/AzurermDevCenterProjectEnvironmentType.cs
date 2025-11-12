using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public partial class AzurermDevCenterProjectEnvironmentTypeIdentityBlock() : TerraformBlock("identity")
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformProperty("identity_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? IdentityIds { get; set; }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermDevCenterProjectEnvironmentTypeTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Block type for user_role_assignment in .
/// Nesting mode: set
/// </summary>
public partial class AzurermDevCenterProjectEnvironmentTypeUserRoleAssignmentBlock() : TerraformBlock("user_role_assignment")
{
    /// <summary>
    /// The roles attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Roles is required")]
    [TerraformProperty("roles")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> Roles { get; set; }

    /// <summary>
    /// The user_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserId is required")]
    [TerraformProperty("user_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> UserId { get; set; }

}

/// <summary>
/// Manages a azurerm_dev_center_project_environment_type resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermDevCenterProjectEnvironmentType : TerraformResource
{
    public AzurermDevCenterProjectEnvironmentType(string name) : base("azurerm_dev_center_project_environment_type", name)
    {
    }

    /// <summary>
    /// The creator_role_assignment_roles attribute.
    /// </summary>
    [TerraformProperty("creator_role_assignment_roles")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? CreatorRoleAssignmentRoles { get; set; }

    /// <summary>
    /// The deployment_target_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeploymentTargetId is required")]
    [TerraformProperty("deployment_target_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DeploymentTargetId { get; set; }

    /// <summary>
    /// The dev_center_project_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DevCenterProjectId is required")]
    [TerraformProperty("dev_center_project_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DevCenterProjectId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Identity is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Identity block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformProperty("identity")]
    public required TerraformList<AzurermDevCenterProjectEnvironmentTypeIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermDevCenterProjectEnvironmentTypeTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for user_role_assignment.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("user_role_assignment")]
    public TerraformSet<AzurermDevCenterProjectEnvironmentTypeUserRoleAssignmentBlock> UserRoleAssignment { get; set; } = new();

}
