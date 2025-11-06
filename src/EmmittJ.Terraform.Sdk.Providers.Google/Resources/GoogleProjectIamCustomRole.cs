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
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The names of the permissions this role grants when bound in an IAM policy. At least one permission must be specified.
    /// </summary>
    public HashSet<string>? Permissions
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("permissions")?.Value;
        set => this.WithProperty("permissions", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The project that the service account will be created in. Defaults to the provider project configuration.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The camel case role id to use for this role. Cannot contain - characters.
    /// </summary>
    public string? RoleId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("role_id")?.Value;
        set => this.WithProperty("role_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The current launch stage of the role. Defaults to GA.
    /// </summary>
    public string? Stage
    {
        get => GetProperty<TerraformLiteralProperty<string>>("stage")?.Value;
        set => this.WithProperty("stage", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// A human-readable title for the role.
    /// </summary>
    public string? Title
    {
        get => GetProperty<TerraformLiteralProperty<string>>("title")?.Value;
        set => this.WithProperty("title", value == null ? null : new TerraformLiteralProperty<string>(value));
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
