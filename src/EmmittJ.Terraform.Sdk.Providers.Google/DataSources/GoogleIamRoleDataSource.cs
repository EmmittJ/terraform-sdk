using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_iam_role.
/// </summary>
public class GoogleIamRoleDataSource : TerraformDataSource
{
    public GoogleIamRoleDataSource(string name) : base("google_iam_role", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("included_permissions");
        this.DeclareOutput("stage");
        this.DeclareOutput("title");
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The included_permissions attribute.
    /// </summary>
    public TerraformExpression IncludedPermissions => this["included_permissions"];

    /// <summary>
    /// The stage attribute.
    /// </summary>
    public TerraformExpression Stage => this["stage"];

    /// <summary>
    /// The title attribute.
    /// </summary>
    public TerraformExpression Title => this["title"];

}
