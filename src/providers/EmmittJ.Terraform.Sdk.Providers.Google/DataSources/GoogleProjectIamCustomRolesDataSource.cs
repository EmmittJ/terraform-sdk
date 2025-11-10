using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_project_iam_custom_roles.
/// </summary>
public class GoogleProjectIamCustomRolesDataSource : TerraformDataSource
{
    public GoogleProjectIamCustomRolesDataSource(string name) : base("google_project_iam_custom_roles", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("roles");
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
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The show_deleted attribute.
    /// </summary>
    public TerraformProperty<bool>? ShowDeleted
    {
        get => GetProperty<TerraformProperty<bool>>("show_deleted");
        set => this.WithProperty("show_deleted", value);
    }

    /// <summary>
    /// The view attribute.
    /// </summary>
    public TerraformProperty<string>? View
    {
        get => GetProperty<TerraformProperty<string>>("view");
        set => this.WithProperty("view", value);
    }

    /// <summary>
    /// The roles attribute.
    /// </summary>
    public TerraformExpression Roles => this["roles"];

}
