using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_firestore_document.
/// </summary>
public class GoogleFirestoreDocumentDataSource : TerraformDataSource
{
    public GoogleFirestoreDocumentDataSource(string name) : base("google_firestore_document", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("fields");
        this.DeclareOutput("name");
        this.DeclareOutput("path");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// The collection ID, relative to database. For example: chatrooms or chatrooms/my-document/private-messages.
    /// </summary>
    public string? Collection
    {
        get => GetProperty<TerraformLiteralProperty<string>>("collection")?.Value;
        set => this.WithProperty("collection", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The Firestore database id. Defaults to &#39;&amp;quot;(default)&amp;quot;&#39;.
    /// </summary>
    public string? Database
    {
        get => GetProperty<TerraformLiteralProperty<string>>("database")?.Value;
        set => this.WithProperty("database", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The client-assigned document ID to use for this document during creation.
    /// </summary>
    public string? DocumentId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("document_id")?.Value;
        set => this.WithProperty("document_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Creation timestamp in RFC3339 format.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// The document&#39;s [fields](https://cloud.google.com/firestore/docs/reference/rest/v1/projects.databases.documents) formated as a json string.
    /// </summary>
    public TerraformExpression Fields => this["fields"];

    /// <summary>
    /// A server defined name for this document. Format:
    /// &#39;projects/{{project_id}}/databases/{{database_id}}/documents/{{path}}/{{document_id}}&#39;
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// A relative path to the collection this document exists within
    /// </summary>
    public TerraformExpression Path => this["path"];

    /// <summary>
    /// Last update timestamp in RFC3339 format.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
