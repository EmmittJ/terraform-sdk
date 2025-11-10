using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadDirectoryRoleTemplatesDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

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
        SetOutput("object_ids");
        SetOutput("role_templates");
        SetOutput("id");
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzureadDirectoryRoleTemplatesDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
