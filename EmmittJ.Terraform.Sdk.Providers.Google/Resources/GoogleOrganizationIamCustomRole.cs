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
    /// The numeric ID of the organization in which you want to create a custom role.
    /// </summary>
    public string? OrgId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("org_id")?.Value;
        set => this.WithProperty("org_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The role id to use for this role.
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
    /// The name of the role in the format organizations/{{org_id}}/roles/{{role_id}}. Like id, this field can be used as a reference in other resources such as IAM role bindings.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
