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
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The object ID of the template associated with the directory role
    /// </summary>
    public string? TemplateId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("template_id")?.Value;
        set => this.WithProperty("template_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
