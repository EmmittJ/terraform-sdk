using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermDevCenterProjectEnvironmentTypeDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermDevCenterProjectEnvironmentTypeDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_dev_center_project_environment_type Terraform data source.
/// Retrieves information about a azurerm_dev_center_project_environment_type.
/// </summary>
public partial class AzurermDevCenterProjectEnvironmentTypeDataSource(string name) : TerraformDataSource("azurerm_dev_center_project_environment_type", name)
{
    /// <summary>
    /// The dev_center_project_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DevCenterProjectId is required")]
    public required TerraformValue<string> DevCenterProjectId
    {
        get => GetArgument<TerraformValue<string>>("dev_center_project_id");
        set => SetArgument("dev_center_project_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The creator_role_assignment_roles attribute.
    /// </summary>
    public TerraformSet<string> CreatorRoleAssignmentRoles
        => AsReference("creator_role_assignment_roles");

    /// <summary>
    /// The deployment_target_id attribute.
    /// </summary>
    public TerraformValue<string> DeploymentTargetId
        => AsReference("deployment_target_id");

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Identity
        => AsReference("identity");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => AsReference("location");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => AsReference("tags");

    /// <summary>
    /// The user_role_assignment attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> UserRoleAssignment
        => AsReference("user_role_assignment");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermDevCenterProjectEnvironmentTypeDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermDevCenterProjectEnvironmentTypeDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
