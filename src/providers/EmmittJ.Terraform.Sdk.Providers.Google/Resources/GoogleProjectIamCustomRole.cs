using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_project_iam_custom_role resource.
/// </summary>
public class GoogleProjectIamCustomRole : TerraformResource
{
    public GoogleProjectIamCustomRole(string name) : base("google_project_iam_custom_role", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("deleted");
        SetOutput("name");
        SetOutput("description");
        SetOutput("id");
        SetOutput("permissions");
        SetOutput("project");
        SetOutput("role_id");
        SetOutput("stage");
        SetOutput("title");
    }

    /// <summary>
    /// A human-readable description for the role.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
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
    /// The names of the permissions this role grants when bound in an IAM policy. At least one permission must be specified.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Permissions is required")]
    public HashSet<TerraformProperty<string>> Permissions
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("permissions");
        set => SetProperty("permissions", value);
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
    /// The current launch stage of the role. Defaults to GA.
    /// </summary>
    public TerraformProperty<string> Stage
    {
        get => GetRequiredOutput<TerraformProperty<string>>("stage");
        set => SetProperty("stage", value);
    }

    /// <summary>
    /// A human-readable title for the role.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Title is required")]
    public required TerraformProperty<string> Title
    {
        get => GetRequiredOutput<TerraformProperty<string>>("title");
        set => SetProperty("title", value);
    }

    /// <summary>
    /// The current deleted state of the role.
    /// </summary>
    public TerraformExpression Deleted => this["deleted"];

    /// <summary>
    /// The name of the role in the format projects/{{project}}/roles/{{role_id}}. Like id, this field can be used as a reference in other resources such as IAM role bindings.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
