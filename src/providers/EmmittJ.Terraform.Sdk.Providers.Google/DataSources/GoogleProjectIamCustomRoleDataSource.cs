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
        SetOutput("deleted");
        SetOutput("description");
        SetOutput("name");
        SetOutput("permissions");
        SetOutput("stage");
        SetOutput("title");
        SetOutput("id");
        SetOutput("project");
        SetOutput("role_id");
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
    /// The project that the service account will be created in. Defaults to the provider project configuration.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// The camel case role id to use for this role. Cannot contain - characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleId is required")]
    public required TerraformProperty<string> RoleId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("role_id");
        set => SetProperty("role_id", value);
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
