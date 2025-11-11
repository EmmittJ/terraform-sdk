using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDevCenterProjectEnvironmentTypeDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_dev_center_project_environment_type.
/// </summary>
public class AzurermDevCenterProjectEnvironmentTypeDataSource : TerraformDataSource
{
    public AzurermDevCenterProjectEnvironmentTypeDataSource(string name) : base("azurerm_dev_center_project_environment_type", name)
    {
    }

    /// <summary>
    /// The dev_center_project_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DevCenterProjectId is required")]
    [TerraformPropertyName("dev_center_project_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DevCenterProjectId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermDevCenterProjectEnvironmentTypeDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The creator_role_assignment_roles attribute.
    /// </summary>
    [TerraformPropertyName("creator_role_assignment_roles")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> CreatorRoleAssignmentRoles => new TerraformReference(this, "creator_role_assignment_roles");

    /// <summary>
    /// The deployment_target_id attribute.
    /// </summary>
    [TerraformPropertyName("deployment_target_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DeploymentTargetId => new TerraformReference(this, "deployment_target_id");

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformPropertyName("identity")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Identity => new TerraformReference(this, "identity");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Location => new TerraformReference(this, "location");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Tags => new TerraformReference(this, "tags");

    /// <summary>
    /// The user_role_assignment attribute.
    /// </summary>
    [TerraformPropertyName("user_role_assignment")]
    // Output-only attribute - read-only reference
    public TerraformSet<object> UserRoleAssignment => new TerraformReference(this, "user_role_assignment");

}
