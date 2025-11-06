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
        this.DeclareOutput("roles");
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
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The show_deleted attribute.
    /// </summary>
    public bool? ShowDeleted
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("show_deleted")?.Value;
        set => this.WithProperty("show_deleted", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The view attribute.
    /// </summary>
    public string? View
    {
        get => GetProperty<TerraformLiteralProperty<string>>("view")?.Value;
        set => this.WithProperty("view", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The roles attribute.
    /// </summary>
    public TerraformExpression Roles => this["roles"];

}
