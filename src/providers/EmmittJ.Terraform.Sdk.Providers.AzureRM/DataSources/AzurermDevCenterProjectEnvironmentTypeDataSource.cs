using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermDevCenterProjectEnvironmentTypeDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_dev_center_project_environment_type.
/// </summary>
public partial class AzurermDevCenterProjectEnvironmentTypeDataSource : TerraformDataSource
{
    public AzurermDevCenterProjectEnvironmentTypeDataSource(string name) : base("azurerm_dev_center_project_environment_type", name)
    {
    }

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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermDevCenterProjectEnvironmentTypeDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The creator_role_assignment_roles attribute.
    /// </summary>
    [TerraformProperty("creator_role_assignment_roles")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> CreatorRoleAssignmentRoles { get; }

    /// <summary>
    /// The deployment_target_id attribute.
    /// </summary>
    [TerraformProperty("deployment_target_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DeploymentTargetId { get; }

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformProperty("identity")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Identity { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Location { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Tags { get; }

    /// <summary>
    /// The user_role_assignment attribute.
    /// </summary>
    [TerraformProperty("user_role_assignment")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<object> UserRoleAssignment { get; }

}
