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
        SetOutput("roles");
        SetOutput("id");
        SetOutput("org_id");
        SetOutput("show_deleted");
        SetOutput("view");
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
    /// The org_id attribute.
    /// </summary>
    public TerraformProperty<string> OrgId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("org_id");
        set => SetProperty("org_id", value);
    }

    /// <summary>
    /// The show_deleted attribute.
    /// </summary>
    public TerraformProperty<bool> ShowDeleted
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("show_deleted");
        set => SetProperty("show_deleted", value);
    }

    /// <summary>
    /// The view attribute.
    /// </summary>
    public TerraformProperty<string> View
    {
        get => GetRequiredOutput<TerraformProperty<string>>("view");
        set => SetProperty("view", value);
    }

    /// <summary>
    /// The roles attribute.
    /// </summary>
    public TerraformExpression Roles => this["roles"];

}
