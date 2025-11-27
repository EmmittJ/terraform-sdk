using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_organization_iam_custom_roles Terraform data source.
/// Retrieves information about a google_organization_iam_custom_roles.
/// </summary>
public partial class GoogleOrganizationIamCustomRolesDataSource(string name) : TerraformDataSource("google_organization_iam_custom_roles", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The org_id attribute.
    /// </summary>
    public TerraformValue<string>? OrgId
    {
        get => new TerraformReference<string>(this, "org_id");
        set => SetArgument("org_id", value);
    }

    /// <summary>
    /// The show_deleted attribute.
    /// </summary>
    public TerraformValue<bool>? ShowDeleted
    {
        get => new TerraformReference<bool>(this, "show_deleted");
        set => SetArgument("show_deleted", value);
    }

    /// <summary>
    /// The view attribute.
    /// </summary>
    public TerraformValue<string>? View
    {
        get => new TerraformReference<string>(this, "view");
        set => SetArgument("view", value);
    }

    /// <summary>
    /// The roles attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Roles
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "roles").ResolveNodes(ctx));
    }

}
