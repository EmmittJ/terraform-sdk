using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_iam_role Terraform data source.
/// Retrieves information about a google_iam_role.
/// </summary>
public partial class GoogleIamRoleDataSource(string name) : TerraformDataSource("google_iam_role", name)
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The included_permissions attribute.
    /// </summary>
    public TerraformList<string> IncludedPermissions
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "included_permissions").ResolveNodes(ctx));
    }

    /// <summary>
    /// The stage attribute.
    /// </summary>
    public TerraformValue<string> Stage
    {
        get => new TerraformReference<string>(this, "stage");
    }

    /// <summary>
    /// The title attribute.
    /// </summary>
    public TerraformValue<string> Title
    {
        get => new TerraformReference<string>(this, "title");
    }

}
