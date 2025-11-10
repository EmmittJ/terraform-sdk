using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDevCenterProjectEnvironmentTypeDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_dev_center_project_environment_type.
/// </summary>
public class AzurermDevCenterProjectEnvironmentTypeDataSource : TerraformDataSource
{
    public AzurermDevCenterProjectEnvironmentTypeDataSource(string name) : base("azurerm_dev_center_project_environment_type", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("creator_role_assignment_roles");
        SetOutput("deployment_target_id");
        SetOutput("identity");
        SetOutput("location");
        SetOutput("tags");
        SetOutput("user_role_assignment");
        SetOutput("dev_center_project_id");
        SetOutput("id");
        SetOutput("name");
    }

    /// <summary>
    /// The dev_center_project_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DevCenterProjectId is required")]
    public required TerraformProperty<string> DevCenterProjectId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("dev_center_project_id");
        set => SetProperty("dev_center_project_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermDevCenterProjectEnvironmentTypeDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The creator_role_assignment_roles attribute.
    /// </summary>
    public TerraformExpression CreatorRoleAssignmentRoles => this["creator_role_assignment_roles"];

    /// <summary>
    /// The deployment_target_id attribute.
    /// </summary>
    public TerraformExpression DeploymentTargetId => this["deployment_target_id"];

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformExpression Identity => this["identity"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The user_role_assignment attribute.
    /// </summary>
    public TerraformExpression UserRoleAssignment => this["user_role_assignment"];

}
