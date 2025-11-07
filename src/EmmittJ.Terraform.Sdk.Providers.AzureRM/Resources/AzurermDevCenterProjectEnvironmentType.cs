using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_dev_center_project_environment_type resource.
/// </summary>
public class AzurermDevCenterProjectEnvironmentType : TerraformResource
{
    public AzurermDevCenterProjectEnvironmentType(string name) : base("azurerm_dev_center_project_environment_type", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The creator_role_assignment_roles attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? CreatorRoleAssignmentRoles
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("creator_role_assignment_roles");
        set => this.WithProperty("creator_role_assignment_roles", value);
    }

    /// <summary>
    /// The deployment_target_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DeploymentTargetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("deployment_target_id");
        set => this.WithProperty("deployment_target_id", value);
    }

    /// <summary>
    /// The dev_center_project_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DevCenterProjectId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("dev_center_project_id");
        set => this.WithProperty("dev_center_project_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

}
