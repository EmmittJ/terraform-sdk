using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_document_ai_warehouse_document_schema resource.
/// </summary>
public class GoogleDocumentAiWarehouseDocumentSchema : TerraformResource
{
    public GoogleDocumentAiWarehouseDocumentSchema(string name) : base("google_document_ai_warehouse_document_schema", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("name");
    }

    /// <summary>
    /// Name of the schema given by the user.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// Tells whether the document is a folder or a typical document.
    /// </summary>
    public TerraformProperty<bool>? DocumentIsFolder
    {
        get => GetProperty<TerraformProperty<bool>>("document_is_folder");
        set => this.WithProperty("document_is_folder", value);
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
    /// The location of the resource.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The unique identifier of the project.
    /// </summary>
    public TerraformProperty<string>? ProjectNumber
    {
        get => GetProperty<TerraformProperty<string>>("project_number");
        set => this.WithProperty("project_number", value);
    }

    /// <summary>
    /// The resource name of the document schema.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
