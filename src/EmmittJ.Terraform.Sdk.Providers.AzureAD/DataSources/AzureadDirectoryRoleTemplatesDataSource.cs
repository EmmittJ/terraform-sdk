using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Retrieves information about a azuread_directory_role_templates.
/// </summary>
public class AzureadDirectoryRoleTemplatesDataSource : TerraformDataSource
{
    public AzureadDirectoryRoleTemplatesDataSource(string name) : base("azuread_directory_role_templates", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("object_ids");
        this.DeclareOutput("role_templates");
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
    /// The object IDs of the role templates
    /// </summary>
    public TerraformExpression ObjectIds => this["object_ids"];

    /// <summary>
    /// A list of role templates
    /// </summary>
    public TerraformExpression RoleTemplates => this["role_templates"];

}
