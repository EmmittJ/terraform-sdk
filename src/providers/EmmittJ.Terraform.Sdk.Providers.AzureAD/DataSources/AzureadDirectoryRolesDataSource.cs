using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadDirectoryRolesDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azuread_directory_roles.
/// </summary>
public class AzureadDirectoryRolesDataSource : TerraformDataSource
{
    public AzureadDirectoryRolesDataSource(string name) : base("azuread_directory_roles", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("object_ids");
        SetOutput("roles");
        SetOutput("template_ids");
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
    public AzureadDirectoryRolesDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The object IDs of the roles
    /// </summary>
    public TerraformExpression ObjectIds => this["object_ids"];

    /// <summary>
    /// A list of roles
    /// </summary>
    public TerraformExpression Roles => this["roles"];

    /// <summary>
    /// The template IDs of the roles
    /// </summary>
    public TerraformExpression TemplateIds => this["template_ids"];

}
