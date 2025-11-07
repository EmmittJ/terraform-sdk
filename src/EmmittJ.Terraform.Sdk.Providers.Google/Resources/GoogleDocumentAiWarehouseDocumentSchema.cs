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
    public TerraformLiteralProperty<string>? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// Tells whether the document is a folder or a typical document.
    /// </summary>
    public TerraformLiteralProperty<bool>? DocumentIsFolder
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("document_is_folder");
        set => this.WithProperty("document_is_folder", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The location of the resource.
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The unique identifier of the project.
    /// </summary>
    public TerraformLiteralProperty<string>? ProjectNumber
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project_number");
        set => this.WithProperty("project_number", value);
    }

    /// <summary>
    /// The resource name of the document schema.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
