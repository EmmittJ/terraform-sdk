using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_organization_iam_custom_roles.
/// </summary>
public class GoogleOrganizationIamCustomRolesDataSource : TerraformDataSource
{
    public GoogleOrganizationIamCustomRolesDataSource(string name) : base("google_organization_iam_custom_roles", name)
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
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The org_id attribute.
    /// </summary>
    public TerraformProperty<string>? OrgId
    {
        get => GetProperty<TerraformProperty<string>>("org_id");
        set => this.WithProperty("org_id", value);
    }

    /// <summary>
    /// The show_deleted attribute.
    /// </summary>
    public TerraformProperty<bool>? ShowDeleted
    {
        get => GetProperty<TerraformProperty<bool>>("show_deleted");
        set => this.WithProperty("show_deleted", value);
    }

    /// <summary>
    /// The view attribute.
    /// </summary>
    public TerraformProperty<string>? View
    {
        get => GetProperty<TerraformProperty<string>>("view");
        set => this.WithProperty("view", value);
    }

    /// <summary>
    /// The roles attribute.
    /// </summary>
    public TerraformExpression Roles => this["roles"];

}
