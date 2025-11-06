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
    public HashSet<string>? CreatorRoleAssignmentRoles
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("creator_role_assignment_roles")?.Value;
        set => this.WithProperty("creator_role_assignment_roles", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The deployment_target_id attribute.
    /// </summary>
    public string? DeploymentTargetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("deployment_target_id")?.Value;
        set => this.WithProperty("deployment_target_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The dev_center_project_id attribute.
    /// </summary>
    public string? DevCenterProjectId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("dev_center_project_id")?.Value;
        set => this.WithProperty("dev_center_project_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

}
