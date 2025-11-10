using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_organization_iam_custom_role resource.
/// </summary>
public class GoogleOrganizationIamCustomRole : TerraformResource
{
    public GoogleOrganizationIamCustomRole(string name) : base("google_organization_iam_custom_role", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("deleted");
        SetOutput("name");
        SetOutput("description");
        SetOutput("id");
        SetOutput("org_id");
        SetOutput("permissions");
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
    /// The numeric ID of the organization in which you want to create a custom role.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrgId is required")]
    public required TerraformProperty<string> OrgId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("org_id");
        set => SetProperty("org_id", value);
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
    /// The role id to use for this role.
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
    /// The name of the role in the format organizations/{{org_id}}/roles/{{role_id}}. Like id, this field can be used as a reference in other resources such as IAM role bindings.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
