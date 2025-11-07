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
    public TerraformProperty<HashSet<string>>? CreatorRoleAssignmentRoles
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("creator_role_assignment_roles");
        set => this.WithProperty("creator_role_assignment_roles", value);
    }

    /// <summary>
    /// The deployment_target_id attribute.
    /// </summary>
    public TerraformProperty<string>? DeploymentTargetId
    {
        get => GetProperty<TerraformProperty<string>>("deployment_target_id");
        set => this.WithProperty("deployment_target_id", value);
    }

    /// <summary>
    /// The dev_center_project_id attribute.
    /// </summary>
    public TerraformProperty<string>? DevCenterProjectId
    {
        get => GetProperty<TerraformProperty<string>>("dev_center_project_id");
        set => this.WithProperty("dev_center_project_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

}
