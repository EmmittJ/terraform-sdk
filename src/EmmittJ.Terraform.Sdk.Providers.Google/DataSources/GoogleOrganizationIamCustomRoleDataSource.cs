using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_organization_iam_custom_role.
/// </summary>
public class GoogleOrganizationIamCustomRoleDataSource : TerraformDataSource
{
    public GoogleOrganizationIamCustomRoleDataSource(string name) : base("google_organization_iam_custom_role", name)
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
    /// The numeric ID of the organization in which you want to create a custom role.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrgId is required")]
    public required TerraformProperty<string> OrgId
    {
        get => GetProperty<TerraformProperty<string>>("org_id");
        set => this.WithProperty("org_id", value);
    }

    /// <summary>
    /// The role id to use for this role.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleId is required")]
    public required TerraformProperty<string> RoleId
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
    /// The name of the role in the format organizations/{{org_id}}/roles/{{role_id}}. Like id, this field can be used as a reference in other resources such as IAM role bindings.
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
