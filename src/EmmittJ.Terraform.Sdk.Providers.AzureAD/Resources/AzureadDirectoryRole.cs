using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Manages a azuread_directory_role resource.
/// </summary>
public class AzureadDirectoryRole : TerraformResource
{
    public AzureadDirectoryRole(string name) : base("azuread_directory_role", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("description");
        this.DeclareOutput("object_id");
    }

    /// <summary>
    /// The display name of the directory role
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
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
    /// The object ID of the template associated with the directory role
    /// </summary>
    public TerraformProperty<string>? TemplateId
    {
        get => GetProperty<TerraformProperty<string>>("template_id");
        set => this.WithProperty("template_id", value);
    }

    /// <summary>
    /// The description of the directory role
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The object ID of the directory role
    /// </summary>
    public TerraformExpression ObjectId => this["object_id"];

}
