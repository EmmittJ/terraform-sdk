using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_project_iam_custom_role.
/// </summary>
public class GoogleProjectIamCustomRoleDataSource : TerraformDataSource
{
    public GoogleProjectIamCustomRoleDataSource(string name) : base("google_project_iam_custom_role", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("deleted");
        this.DeclareOutput("description");
        this.DeclareOutput("name");
        this.DeclareOutput("permissions");
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
    /// The project that the service account will be created in. Defaults to the provider project configuration.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The camel case role id to use for this role. Cannot contain - characters.
    /// </summary>
    public TerraformProperty<string>? RoleId
    {
        get => GetProperty<TerraformProperty<string>>("role_id");
        set => this.WithProperty("role_id", value);
    }

    /// <summary>
    /// The current deleted state of the role.
    /// </summary>
    public TerraformExpression Deleted => this["deleted"];

    /// <summary>
    /// A human-readable description for the role.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The name of the role in the format projects/{{project}}/roles/{{role_id}}. Like id, this field can be used as a reference in other resources such as IAM role bindings.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The names of the permissions this role grants when bound in an IAM policy. At least one permission must be specified.
    /// </summary>
    public TerraformExpression Permissions => this["permissions"];

    /// <summary>
    /// The current launch stage of the role. Defaults to GA.
    /// </summary>
    public TerraformExpression Stage => this["stage"];

    /// <summary>
    /// A human-readable title for the role.
    /// </summary>
    public TerraformExpression Title => this["title"];

}
