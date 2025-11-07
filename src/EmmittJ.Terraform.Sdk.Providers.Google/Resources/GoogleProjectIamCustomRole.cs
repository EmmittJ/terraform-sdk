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
        this.DeclareOutput("deleted");
        this.DeclareOutput("name");
    }

    /// <summary>
    /// A human-readable description for the role.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// The names of the permissions this role grants when bound in an IAM policy. At least one permission must be specified.
    /// </summary>
    public TerraformProperty<HashSet<string>>? Permissions
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("permissions");
        set => this.WithProperty("permissions", value);
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
    /// The current launch stage of the role. Defaults to GA.
    /// </summary>
    public TerraformProperty<string>? Stage
    {
        get => GetProperty<TerraformProperty<string>>("stage");
        set => this.WithProperty("stage", value);
    }

    /// <summary>
    /// A human-readable title for the role.
    /// </summary>
    public TerraformProperty<string>? Title
    {
        get => GetProperty<TerraformProperty<string>>("title");
        set => this.WithProperty("title", value);
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
